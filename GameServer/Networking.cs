using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Threading;
using System.Reflection.Emit;
using System.Collections;
using System.Net.WebSockets;
using System.IO;
using GameServer.WebSockets.Internal;

namespace GameServer
{
    class UserData
    {
        public Boolean Connected = false;
        public TcpClient Socket;
        public String socketData = String.Empty;
        public String Username = String.Empty;
        public String Name = String.Empty;
        public String Password = String.Empty;
        public String IP = String.Empty;
    }

    class Net
    {
        public static IPEndPoint ipEndPoint;
        public static TcpListener serverSocket;
        public static Dictionary<int, UserData> mapIndex_Client = new Dictionary<int, UserData>();
        public static int Port = 2602;
        public static bool Listening;

        public static void LoadServerSocket()
        {
            ipEndPoint = new IPEndPoint(IPAddress.Any, Port);
            serverSocket = new TcpListener(ipEndPoint);
            //serverSocket.Server.NoDelay = true;
            //serverSocket.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
        }

        public static bool StartListen()
        {
            retry:
            try
            {
                serverSocket.Start();
                Listening = true;
                Program.serverApp.printLog("Server is now accepting connections on Port " + ipEndPoint.Port.ToString());
                return true;
            }
            catch (SocketException e)
            {
                if (e.ErrorCode == 10048)
                {

                    string St = Interaction.InputBox("A server is already running on this port!" + Environment.NewLine + Environment.NewLine + "Please select a valid port number: ", "Update Server: Invalid Port");
                    if (St != string.Empty)
                    {
                        if (int.TryParse(St, out Port))
                        {
                            LoadServerSocket();
                            goto retry;
                        }
                        else
                        {
                            MessageBox.Show("An invalid port number was used, the Update Server will now shutdown.", "Update Server: Invalid Port");
                            Program.blnEnd = true;
                        }
                    }
                    else
                    {
                        Program.blnEnd = true;
                    }
                }
                else
                {
                    MessageBox.Show(e.ToString());
                }
                return false;
            }
        }

        public static void StopListen()
        {
            Listening = false;
            serverSocket.Stop();
            Program.serverApp.printLog("Server is no longer accepting connections");
        }

        public static int FreeSocket()
        {
            int i = 0;
            while (mapIndex_Client.ContainsKey(i))
            {
                i++;
            }
            return i;
        }

        public static void HandleConnections()
        {
            if (Listening && serverSocket.Pending()) //Check for pending connection requests...
            {
                int i = FreeSocket();
                UserData client = new UserData();
                client.Socket = serverSocket.AcceptTcpClient();
                client.IP = (client.Socket.Client.RemoteEndPoint as IPEndPoint).Address.ToString();
                mapIndex_Client.Add(i, client);
                Program.serverApp.printLog("Connection accepted from " + client.IP + " - Index: " + i.ToString());
            }
        }

        public static void HandleIncomingData()
        {
            foreach(int clientIndex in mapIndex_Client.Keys)
            {
                UserData client = mapIndex_Client[clientIndex];
                TcpClient socket = client.Socket;
                if (socket.Available > 0) {
                    NetworkStream stream = socket.GetStream();
                    Byte[] data = new Byte[socket.Available];
                    stream.Read(data, 0, socket.Available);
                    String St;
                    if (!client.Connected) {
                        St = Encoding.UTF8.GetString(data);
                        if (Regex.IsMatch(St, "^GET"))
                        {
                            const string eol = "\r\n"; // HTTP/1.1 defines the sequence CR LF as the end-of-line marker

                            Byte[] response = Encoding.UTF8.GetBytes("HTTP/1.1 101 Switching Protocols" + eol
                                + "Connection: Upgrade" + eol
                                + "Upgrade: websocket" + eol
                                + "Sec-WebSocket-Accept: " + Convert.ToBase64String(
                                    System.Security.Cryptography.SHA1.Create().ComputeHash(
                                        Encoding.UTF8.GetBytes(
                                            new System.Text.RegularExpressions.Regex("Sec-WebSocket-Key: (.*)").Match(St).Groups[1].Value.Trim() + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11"
                                        )
                                    )
                                ) + eol
                                + eol);

                            stream.Write(response, 0, response.Length);

                            client.Connected = true;
                        }
                    }
                    else
                    {
                        St = DecodeWebSocketData(data);
                        Program.serverApp.printLog(St);
                    }
                }
            }
        }

        public static String DecodeWebSocketData(Byte[] data)
        {
            // Is this the end of message?
            Boolean EOF = (data[0] > 0);

            // Find the entire packet length...
            long packetLength = data[1] - 128;
            int keyIndex = 2;

            if(packetLength == 126)
            {
                keyIndex = 4;
            }
            else if(packetLength == 127)
            {
                keyIndex = 10;
            }

            int dataIndex = keyIndex + 4;
            packetLength = data.Length - dataIndex;

            // Apply encoding and decoding algorithm
            Byte[] decoded = new Byte[packetLength];
            Byte[] encoded = new Byte[packetLength];
            Byte[] key = new Byte[4];

            Array.Copy(data, keyIndex, key, 0, 4);
            Array.Copy(data, dataIndex, encoded, 0, packetLength);

            for (int i = 0; i < encoded.Length; i++)
            {
                decoded[i] = (Byte)(encoded[i] ^ key[i % 4]);
            }

            return Encoding.ASCII.GetString(decoded);
        }

        private static readonly Random _random = new Random((int) DateTime.Now.Ticks);

        public static void SendWebSocket(int Index, WebSocketOpCode opCode, String Data, bool isLastFrame)
        {
            var array = Encoding.UTF8.GetBytes(Data);
            var fromPayload = new ArraySegment<byte>(array);

            MemoryStream memoryStream = new MemoryStream();

            byte finBitSetAsByte = isLastFrame ? (byte)0x80 : (byte)0x00;
            byte byte1 = (byte)(finBitSetAsByte | (byte)opCode);

            memoryStream.WriteByte(byte1);

            byte maskBitSetAsByte = (byte)0x00;

            // depending on the size of the length we want to write it as a byte, ushort or ulong
            if (fromPayload.Count < 126)
            {
                byte byte2 = (byte)(maskBitSetAsByte | (byte)fromPayload.Count);
                memoryStream.WriteByte(byte2);
            }
            else if (fromPayload.Count <= ushort.MaxValue)
            {
                byte byte2 = (byte)(maskBitSetAsByte | 126);
                memoryStream.WriteByte(byte2);
                BinaryReaderWriter.WriteUShort((ushort)fromPayload.Count, memoryStream, false);
            }
            else
            {
                byte byte2 = (byte)(maskBitSetAsByte | 127);
                memoryStream.WriteByte(byte2);
                BinaryReaderWriter.WriteULong((ulong)fromPayload.Count, memoryStream, false);
            }

            memoryStream.Write(fromPayload.Array, fromPayload.Offset, fromPayload.Count);

            mapIndex_Client[Index].Socket.Client.Send(memoryStream.ToArray());
        }

        public static void CloseClientSocket(int index, TcpClient client)
        {
            if (client != null && client.Connected)
            {
                Program.serverApp.printLog("Connection closed from " + (client.Client.RemoteEndPoint as IPEndPoint).Address + " - Index: " + index.ToString());
                client.Close();
                client.Dispose();
            }
        }

        public static void CloseConnections()
        {
            if (mapIndex_Client != null)
            {
                foreach (int clientIndex in mapIndex_Client.Keys)
                {
                    CloseClientSocket(clientIndex, mapIndex_Client[clientIndex].Socket);
                }
                mapIndex_Client.Clear();
                Program.serverApp.printLog("All connections have been closed succesfully!");
            }
        }
    }
}