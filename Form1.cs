using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Diagnostics;

namespace Hodor
{
    public partial class mainWin : Form
    {
        private Hodoor hodoor = new();
        public mainWin()
        {
            InitializeComponent();
        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            butStop.Enabled = false;
            butReStart.Enabled = false;
        }

        private void mainWin_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.MyNotifyIcon.Visible = true;
                this.Visible = false;
            }
        }

        private void MyNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible)
            {
               this.Hide();
            }
            else
            {
                 this.Show();
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void butStart_Click(object sender, EventArgs e)
        {
            // 切换启动图片
            pbStatusBox.Image = Properties.Resources.start_64;
            hodoor.Run();
            butStart.Enabled = false;
            butStop.Enabled = true;
            butReStart.Enabled = true;
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            pbStatusBox.Image = Properties.Resources.stop_64;
            hodoor.Stop();
            butStart.Enabled = true;
            butStop.Enabled = false;
            butReStart.Enabled = false;
        }

        private void butReStart_Click(object sender, EventArgs e)
        {
            pbStatusBox.Image = Properties.Resources.stop_64;
            System.Threading.Thread.Sleep(1000);
            pbStatusBox.Image = Properties.Resources.start_64;
            hodoor.Stop();
            hodoor.Run();
        }

        private void butCon_Click(object sender, EventArgs e)
        {
            var ip = cbIP.Text;
            var disk = cbDisk.Text;
            string ret = cmd(ip, disk);
            Console.WriteLine(ret);
        }

        private string cmd(string IPstr,string disk)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.StandardInput.AutoFlush = true;
                var cmdline = "net use "+ disk + " http://"+ IPstr + ":8051/ 123  /user:admin /persistent:YES";
                process.StandardInput.WriteLine(cmdline + "&exit");

                //获取cmd窗口的输出信息  
                string output = process.StandardOutput.ReadToEnd();

                process.WaitForExit();
                process.Close();

                return output;
            }
        }
    }
}
