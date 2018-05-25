namespace GameServer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstConnections = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.mnuItems = new System.Windows.Forms.MenuStrip();
            this.mnuServer = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandwidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timedShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceptingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monstersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guildsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mnuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstConnections
            // 
            this.lstConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colUsername,
            this.colName,
            this.colIP,
            this.colStatus});
            this.lstConnections.Location = new System.Drawing.Point(12, 44);
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.Size = new System.Drawing.Size(444, 147);
            this.lstConnections.TabIndex = 0;
            this.lstConnections.UseCompatibleStateImageBehavior = false;
            this.lstConnections.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "Index";
            this.colIndex.Width = 48;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            // 
            // colName
            // 
            this.colName.Text = "Player Name";
            this.colName.Width = 168;
            // 
            // colIP
            // 
            this.colIP.Text = "IP Address";
            this.colIP.Width = 97;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 67;
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Location = new System.Drawing.Point(12, 210);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(444, 134);
            this.lstStatus.TabIndex = 1;
            // 
            // mnuItems
            // 
            this.mnuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuServer,
            this.connectionsToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.mnuItems.Location = new System.Drawing.Point(0, 0);
            this.mnuItems.Name = "mnuItems";
            this.mnuItems.Size = new System.Drawing.Size(468, 24);
            this.mnuItems.TabIndex = 2;
            this.mnuItems.Text = "menuStrip1";
            // 
            // mnuServer
            // 
            this.mnuServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.bandwidthToolStripMenuItem,
            this.timedShutdownToolStripMenuItem,
            this.shutdownToolStripMenuItem});
            this.mnuServer.Name = "mnuServer";
            this.mnuServer.ShowShortcutKeys = false;
            this.mnuServer.Size = new System.Drawing.Size(51, 20);
            this.mnuServer.Text = "Server";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // bandwidthToolStripMenuItem
            // 
            this.bandwidthToolStripMenuItem.Name = "bandwidthToolStripMenuItem";
            this.bandwidthToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bandwidthToolStripMenuItem.Text = "Bandwidth";
            // 
            // timedShutdownToolStripMenuItem
            // 
            this.timedShutdownToolStripMenuItem.Name = "timedShutdownToolStripMenuItem";
            this.timedShutdownToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.timedShutdownToolStripMenuItem.Text = "Timed Shutdown";
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptingToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.ShowShortcutKeys = false;
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.connectionsToolStripMenuItem.Text = "Connections";
            // 
            // acceptingToolStripMenuItem
            // 
            this.acceptingToolStripMenuItem.Checked = true;
            this.acceptingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.acceptingToolStripMenuItem.Name = "acceptingToolStripMenuItem";
            this.acceptingToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.acceptingToolStripMenuItem.Text = "Accepting";
            this.acceptingToolStripMenuItem.Click += new System.EventHandler(this.acceptingToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.ShowShortcutKeys = false;
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monstersToolStripMenuItem,
            this.objectsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mapsToolStripMenuItem,
            this.shopsToolStripMenuItem,
            this.guildsToolStripMenuItem,
            this.hallsToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // monstersToolStripMenuItem
            // 
            this.monstersToolStripMenuItem.Name = "monstersToolStripMenuItem";
            this.monstersToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.monstersToolStripMenuItem.Text = "Accounts";
            // 
            // objectsToolStripMenuItem
            // 
            this.objectsToolStripMenuItem.Name = "objectsToolStripMenuItem";
            this.objectsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.objectsToolStripMenuItem.Text = "Objects";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "Monsters";
            // 
            // mapsToolStripMenuItem
            // 
            this.mapsToolStripMenuItem.Name = "mapsToolStripMenuItem";
            this.mapsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.mapsToolStripMenuItem.Text = "Maps";
            // 
            // shopsToolStripMenuItem
            // 
            this.shopsToolStripMenuItem.Name = "shopsToolStripMenuItem";
            this.shopsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.shopsToolStripMenuItem.Text = "Shops";
            // 
            // guildsToolStripMenuItem
            // 
            this.guildsToolStripMenuItem.Name = "guildsToolStripMenuItem";
            this.guildsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.guildsToolStripMenuItem.Text = "Guilds";
            // 
            // hallsToolStripMenuItem
            // 
            this.hallsToolStripMenuItem.Name = "hallsToolStripMenuItem";
            this.hallsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hallsToolStripMenuItem.Text = "Halls";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Connections";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 358);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.lstConnections);
            this.Controls.Add(this.mnuItems);
            this.MainMenuStrip = this.mnuItems;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.ResizeBegin += new System.EventHandler(this.frmMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.mnuItems.ResumeLayout(false);
            this.mnuItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstConnections;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.MenuStrip mnuItems;
        private System.Windows.Forms.ToolStripMenuItem mnuServer;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timedShutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceptingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monstersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guildsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colIP;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ToolStripMenuItem bandwidthToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

