using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer
{
    public partial class frmMain : Form
    {
        public Size frmOldSize = new Size();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_ResizeBegin(object sender, EventArgs e)
        {
            frmOldSize = this.Size;
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            int widthDiff = this.Size.Width - frmOldSize.Width;
            int heightDiff = this.Size.Height - frmOldSize.Height;

            lstConnections.Width += widthDiff;
            lstConnections.Height += heightDiff;
            foreach (ColumnHeader col in lstConnections.Columns)
            {
                col.Width += widthDiff / lstConnections.Columns.Count;
            }
            label2.Top += heightDiff;

            lstStatus.Top += heightDiff;
            lstStatus.Width += widthDiff;
        }

        public void printLog(String St)
        {
            lstStatus.Items.Add(St);
            lstStatus.SelectedIndex = lstStatus.Items.Count - 1;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.blnEnd = true;
        }

        private void acceptingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(acceptingToolStripMenuItem.Checked)
            {
                acceptingToolStripMenuItem.Checked = false;
                Net.StopListen();
            }
            else
            {
                acceptingToolStripMenuItem.Checked = true;
                Net.StartListen();
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Net.CloseConnections();
        }

        public void updateConnectedClientsList()
        {
            foreach(int clientIndex in Net.mapIndex_Client.Keys)
            {
                UserData clientUser = Net.mapIndex_Client[clientIndex];
                String indexKey = clientIndex.ToString();

                if (lstConnections.Items.ContainsKey(indexKey))
                {
                    int i = lstConnections.Items.IndexOfKey(indexKey);

                    // Set Index
                    if(indexKey != lstConnections.Items[i].Text) {
                        lstConnections.Items[i].Text = indexKey;
                    }

                    // Set Index
                    if (clientUser.Username != lstConnections.Items[i].SubItems[1].Text)
                    {
                        lstConnections.Items[i].SubItems[1].Text = clientUser.Username;
                    }

                }
                else
                {
                    ListViewItem user = new ListViewItem();
                    user.Name = indexKey;
                    user.Text = indexKey;
                    user.SubItems.Add(clientUser.Username);
                    user.SubItems.Add(clientUser.Name);
                    user.SubItems.Add(clientUser.IP);
                    user.SubItems.Add("Connected");
                    lstConnections.Items.Add(user);
                }

            }

            foreach(ListViewItem lvi in lstConnections.Items)
            {
                int index = int.Parse(lvi.Name);

                if(!Net.mapIndex_Client.ContainsKey(index))
                {
                    lvi.Remove();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                Net.SendWebSocket(0, WebSockets.Internal.WebSocketOpCode.TextFrame, textBox1.Text, true);
                textBox1.Text = String.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
