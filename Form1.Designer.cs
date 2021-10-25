
namespace Hodor
{
    partial class mainWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWin));
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startServer = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServer = new System.Windows.Forms.ToolStripMenuItem();
            this.reSever = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.browseDir = new System.Windows.Forms.Button();
            this.dirPathBox = new System.Windows.Forms.TextBox();
            this.txServerPass = new System.Windows.Forms.TextBox();
            this.cbServer = new System.Windows.Forms.CheckBox();
            this.pbStatusBox = new System.Windows.Forms.PictureBox();
            this.butStop = new System.Windows.Forms.Button();
            this.butReStart = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txClientPass = new System.Windows.Forms.TextBox();
            this.butCon = new System.Windows.Forms.Button();
            this.cbDisk = new System.Windows.Forms.ComboBox();
            this.lbdisk = new System.Windows.Forms.Label();
            this.lbip = new System.Windows.Forms.Label();
            this.cbIP = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bottomStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.GBIP = new System.Windows.Forms.GroupBox();
            this.cbIpList = new System.Windows.Forms.ComboBox();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cxMenuStrip.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusBox)).BeginInit();
            this.gb2.SuspendLayout();
            this.bottomStatus.SuspendLayout();
            this.GBIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.ContextMenuStrip = this.cxMenuStrip;
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Text = "Hodor";
            this.MyNotifyIcon.Visible = true;
            this.MyNotifyIcon.DoubleClick += new System.EventHandler(this.MyNotifyIcon_DoubleClick);
            // 
            // cxMenuStrip
            // 
            this.cxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServer,
            this.stopServer,
            this.reSever,
            this.toolExit});
            this.cxMenuStrip.Name = "cxMenuStrip";
            this.cxMenuStrip.Size = new System.Drawing.Size(137, 92);
            // 
            // startServer
            // 
            this.startServer.Image = global::Hodor.Properties.Resources.start;
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(136, 22);
            this.startServer.Text = "启动服务器";
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // stopServer
            // 
            this.stopServer.Image = global::Hodor.Properties.Resources.stop;
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(136, 22);
            this.stopServer.Text = "停止服务器";
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // reSever
            // 
            this.reSever.Image = global::Hodor.Properties.Resources.restart;
            this.reSever.Name = "reSever";
            this.reSever.Size = new System.Drawing.Size(136, 22);
            this.reSever.Text = "重启服务";
            // 
            // toolExit
            // 
            this.toolExit.Image = global::Hodor.Properties.Resources.exit;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(136, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.browseDir);
            this.gb1.Controls.Add(this.dirPathBox);
            this.gb1.Controls.Add(this.txServerPass);
            this.gb1.Controls.Add(this.cbServer);
            this.gb1.Controls.Add(this.pbStatusBox);
            this.gb1.Controls.Add(this.butStop);
            this.gb1.Controls.Add(this.butReStart);
            this.gb1.Controls.Add(this.butStart);
            this.gb1.Location = new System.Drawing.Point(8, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(247, 233);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "本机共享";
            this.gb1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // browseDir
            // 
            this.browseDir.Image = global::Hodor.Properties.Resources.dir;
            this.browseDir.Location = new System.Drawing.Point(206, 150);
            this.browseDir.Name = "browseDir";
            this.browseDir.Size = new System.Drawing.Size(28, 23);
            this.browseDir.TabIndex = 7;
            this.browseDir.UseVisualStyleBackColor = true;
            this.browseDir.Click += new System.EventHandler(this.browseDir_Click);
            // 
            // dirPathBox
            // 
            this.dirPathBox.Location = new System.Drawing.Point(15, 150);
            this.dirPathBox.Name = "dirPathBox";
            this.dirPathBox.PlaceholderText = "请选择共享文件夹";
            this.dirPathBox.Size = new System.Drawing.Size(185, 23);
            this.dirPathBox.TabIndex = 6;
            this.dirPathBox.TextChanged += new System.EventHandler(this.dirPathBox_TextChanged);
            // 
            // txServerPass
            // 
            this.txServerPass.Location = new System.Drawing.Point(129, 191);
            this.txServerPass.Name = "txServerPass";
            this.txServerPass.PasswordChar = '*';
            this.txServerPass.Size = new System.Drawing.Size(105, 23);
            this.txServerPass.TabIndex = 5;
            this.txServerPass.UseSystemPasswordChar = true;
            // 
            // cbServer
            // 
            this.cbServer.AutoSize = true;
            this.cbServer.Location = new System.Drawing.Point(15, 191);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(99, 21);
            this.cbServer.TabIndex = 4;
            this.cbServer.Text = "设置共享密码";
            this.cbServer.UseVisualStyleBackColor = true;
            // 
            // pbStatusBox
            // 
            this.pbStatusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStatusBox.Image = global::Hodor.Properties.Resources.stop_64;
            this.pbStatusBox.Location = new System.Drawing.Point(129, 27);
            this.pbStatusBox.Name = "pbStatusBox";
            this.pbStatusBox.Size = new System.Drawing.Size(105, 105);
            this.pbStatusBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusBox.TabIndex = 3;
            this.pbStatusBox.TabStop = false;
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(15, 109);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(92, 23);
            this.butStop.TabIndex = 2;
            this.butStop.Text = "停止服务";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butReStart
            // 
            this.butReStart.Location = new System.Drawing.Point(15, 68);
            this.butReStart.Name = "butReStart";
            this.butReStart.Size = new System.Drawing.Size(92, 23);
            this.butReStart.TabIndex = 1;
            this.butReStart.Text = "重启服务";
            this.butReStart.UseVisualStyleBackColor = true;
            this.butReStart.Click += new System.EventHandler(this.butReStart_Click);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(15, 27);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(92, 23);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "启动服务";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.label1);
            this.gb2.Controls.Add(this.txClientPass);
            this.gb2.Controls.Add(this.butCon);
            this.gb2.Controls.Add(this.cbDisk);
            this.gb2.Controls.Add(this.lbdisk);
            this.gb2.Controls.Add(this.lbip);
            this.gb2.Controls.Add(this.cbIP);
            this.gb2.Location = new System.Drawing.Point(8, 330);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(247, 208);
            this.gb2.TabIndex = 2;
            this.gb2.TabStop = false;
            this.gb2.Text = "连接共享";
            this.gb2.Enter += new System.EventHandler(this.gb2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "密码:";
            // 
            // txClientPass
            // 
            this.txClientPass.Location = new System.Drawing.Point(106, 106);
            this.txClientPass.Name = "txClientPass";
            this.txClientPass.PasswordChar = '*';
            this.txClientPass.Size = new System.Drawing.Size(124, 23);
            this.txClientPass.TabIndex = 6;
            this.txClientPass.UseSystemPasswordChar = true;
            // 
            // butCon
            // 
            this.butCon.Location = new System.Drawing.Point(15, 152);
            this.butCon.Name = "butCon";
            this.butCon.Size = new System.Drawing.Size(215, 37);
            this.butCon.TabIndex = 4;
            this.butCon.Text = "连接共享并映射为盘符";
            this.butCon.UseVisualStyleBackColor = true;
            this.butCon.Click += new System.EventHandler(this.butCon_Click);
            // 
            // cbDisk
            // 
            this.cbDisk.FormattingEnabled = true;
            this.cbDisk.Items.AddRange(new object[] {
            "L:",
            "E:",
            "I:",
            "X:",
            "Y:",
            "Z:"});
            this.cbDisk.Location = new System.Drawing.Point(15, 105);
            this.cbDisk.Name = "cbDisk";
            this.cbDisk.Size = new System.Drawing.Size(52, 25);
            this.cbDisk.TabIndex = 3;
            this.cbDisk.SelectedIndexChanged += new System.EventHandler(this.cbDisk_SelectedIndexChanged);
            // 
            // lbdisk
            // 
            this.lbdisk.AutoSize = true;
            this.lbdisk.Location = new System.Drawing.Point(15, 83);
            this.lbdisk.Name = "lbdisk";
            this.lbdisk.Size = new System.Drawing.Size(59, 17);
            this.lbdisk.TabIndex = 2;
            this.lbdisk.Text = "映射盘符:";
            // 
            // lbip
            // 
            this.lbip.AutoSize = true;
            this.lbip.Location = new System.Drawing.Point(15, 31);
            this.lbip.Name = "lbip";
            this.lbip.Size = new System.Drawing.Size(46, 17);
            this.lbip.TabIndex = 1;
            this.lbip.Text = "IP地址:";
            // 
            // cbIP
            // 
            this.cbIP.FormattingEnabled = true;
            this.cbIP.Location = new System.Drawing.Point(15, 53);
            this.cbIP.Name = "cbIP";
            this.cbIP.Size = new System.Drawing.Size(215, 25);
            this.cbIP.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 545);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ser163.cn";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bottomStatus
            // 
            this.bottomStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.bottomStatus.Location = new System.Drawing.Point(0, 570);
            this.bottomStatus.Name = "bottomStatus";
            this.bottomStatus.Size = new System.Drawing.Size(258, 22);
            this.bottomStatus.TabIndex = 4;
            this.bottomStatus.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatus.Text = "Hold the door ...";
            // 
            // GBIP
            // 
            this.GBIP.Controls.Add(this.cbIpList);
            this.GBIP.Location = new System.Drawing.Point(8, 251);
            this.GBIP.Name = "GBIP";
            this.GBIP.Size = new System.Drawing.Size(247, 74);
            this.GBIP.TabIndex = 5;
            this.GBIP.TabStop = false;
            this.GBIP.Text = "本机IP";
            // 
            // cbIpList
            // 
            this.cbIpList.FormattingEnabled = true;
            this.cbIpList.Location = new System.Drawing.Point(15, 32);
            this.cbIpList.Name = "cbIpList";
            this.cbIpList.Size = new System.Drawing.Size(219, 25);
            this.cbIpList.TabIndex = 0;
            this.cbIpList.SelectedIndexChanged += new System.EventHandler(this.cbIpList_SelectedIndexChanged);
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(258, 592);
            this.Controls.Add(this.GBIP);
            this.Controls.Add(this.bottomStatus);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hodor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWin_FormClosing);
            this.Load += new System.EventHandler(this.mainWin_Load);
            this.SizeChanged += new System.EventHandler(this.mainWin_SizeChanged);
            this.cxMenuStrip.ResumeLayout(false);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusBox)).EndInit();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.bottomStatus.ResumeLayout(false);
            this.bottomStatus.PerformLayout();
            this.GBIP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip cxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startServer;
        private System.Windows.Forms.ToolStripMenuItem stopServer;
        private System.Windows.Forms.ToolStripMenuItem reSever;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.PictureBox pbStatusBox;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butReStart;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Label lbip;
        private System.Windows.Forms.ComboBox cbIP;
        private System.Windows.Forms.ComboBox cbDisk;
        private System.Windows.Forms.Label lbdisk;
        private System.Windows.Forms.Button butCon;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip bottomStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.GroupBox GBIP;
        private System.Windows.Forms.ComboBox cbIpList;
        private System.Windows.Forms.TextBox txServerPass;
        private System.Windows.Forms.CheckBox cbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txClientPass;
        private System.Windows.Forms.Button browseDir;
        private System.Windows.Forms.TextBox dirPathBox;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
    }
}

