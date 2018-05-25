using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GameServer
{
    public static class Program
    {
        public static Boolean blnEnd = false;
        public static frmMain serverApp = new frmMain();

        public static int tick = Environment.TickCount;
        public static int secondTimer;

        static void Main()
        {
            Net.LoadServerSocket();
            Net.StartListen();

            serverApp.Show();

            while (!blnEnd)
            {
                tick = Environment.TickCount;
                if(tick >= secondTimer)
                {
                    serverApp.updateConnectedClientsList();
                    secondTimer = tick + 1000;
                }
                Net.HandleConnections();
                Net.HandleIncomingData();
                while (Environment.TickCount - tick < 25)
                {
                    Application.DoEvents();
                    Thread.Sleep(1);
                }
                Application.DoEvents();
            }
            Net.StopListen();
        }
    }
}
