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
using System.IO;


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
            if (hodoor.IsRunDav())
            {
                RunStateChange();
            }
            else
            {
                StopStateChange();
            }

            reSever.Enabled = false;
            cbDisk.SelectedIndex = 0;

            // 获取本机所有ip地址
            foreach (string s in GOT.GetAllIP())
            {
                cbIpList.Items.Add(s);
            }
            var count = cbIpList.Items.Count;
            cbIpList.SelectedIndex = count == 0 ? 0 : count - 1;
            
            // 判断注册表
            Regedit Reg = new();
            Reg.CheckReg();
            // 添加防火墙规则
            var Path = Application.ExecutablePath;
            FireWalld.AddRuls(Path);
        }

        private void mainWin_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
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
                this.Activate();
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // 运行状态改变
        private void RunStateChange()
        {
            butStart.Enabled = false;
            butStop.Enabled = true;
            butReStart.Enabled = true;

            startServer.Enabled = false;
            stopServer.Enabled = true;
            reSever.Enabled = true;
        }

        private void GlobalStart()
        {
            // 切换启动图片
            pbStatusBox.Image = Properties.Resources.start_64;
            if (cbServer.Checked)
            {
                var PassWord = txServerPass.Text;
                if (PassWord == "")
                {
                    MessageBox.Show("请填写密码");
                    return;
                }

                hodoor.Run(PassWord);
            } else
            {
                hodoor.Run();
            }

            // 改变按钮状态
            RunStateChange();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            GlobalStart();
        }
        // 停止状态改变
        private void StopStateChange()
        {
            butStart.Enabled = true;
            butStop.Enabled = false;
            butReStart.Enabled = false;

            startServer.Enabled = true;
            stopServer.Enabled = false;
            reSever.Enabled = false;
        }

        private void GlobalStop()
        {
            pbStatusBox.Image = Properties.Resources.stop_64;
            try
            {
                hodoor.Stop();
            } catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
           
            StopStateChange();
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            GlobalStop();
        }

        // 重启状态改变
        private void ReStartStateChange()
        {
            butStart.Enabled = false;
            butStop.Enabled = true;
            butReStart.Enabled = true;

            startServer.Enabled = false;
            stopServer.Enabled = true;
            reSever.Enabled = true;
        }

        private void butReStart_Click(object sender, EventArgs e)
        {
            GlobalReStart();
        }

        // 全局调用重启事件
        private void GlobalReStart()
        {
            hodoor.Stop();
            pbStatusBox.Image = Properties.Resources.stop_64;
            System.Threading.Thread.Sleep(1000);
            pbStatusBox.Image = Properties.Resources.start_64;
            hodoor.Run();
        }

        private void butCon_Click(object sender, EventArgs e)
        {
            var ip = cbIP.Text;
            var disk = cbDisk.Text;
            var pass = txClientPass.Text;
            if (GOT.DriverExists(disk))
            {
                MessageBox.Show("盘符已存在,请选用其它盘");
                return;
            }

            bool ret = false;

            if (pass == "")
            {
                ret = cmd(ip, disk);
            } else
            {
                ret = cmd(ip, disk,pass);
            }
            

            if (ret)
            {
                // 如果返回成功则打开 盘符
                GOT.OpenFolder(disk);
            }

            //var path = @"http://127.0.0.1:5081/";
            //var status = NetwareDriveAPI.Connect(path, disk, "admin", "123");

            //if (status == (int)NetwareDriveAPI.ERROR_ID.ERROR_SUCCESS)
            //{
            //    // 连接成功，在服务器端创建一文件，并写入一字串 , 
            //    FileStream fs = new FileStream(disk + @"//ConnectSuccess.txt", FileMode.OpenOrCreate);
            //    using (StreamWriter stream = new StreamWriter(fs))
            //    {
            //        stream.WriteLine("网络连接成功");
            //        stream.Flush();
            //        stream.Close();
            //    }
            //    fs.Close();
            //}
            //else
            //{
            //    // 连接失败
            //    Console.WriteLine(status);
            //}
        }

        private bool cmd(string IPstr, string disk)
        {
            try
            {
                using (var process = new Process())
                {

                    process.StartInfo.FileName = "net";
                    var cmdline = "use " + disk + " http://" + IPstr + ":5081/ 123  /user:admin /persistent:YES";

                    process.StartInfo.Arguments = cmdline;
                    // process.StartInfo.Verb = "Runas";
                    //process.StartInfo.UserName = "administrator";

                    //var strPWD = "1076";
                    //System.Security.SecureString password = new System.Security.SecureString();   //SecureString，安全字符，必须是char类型
                    //foreach (char c in strPWD.ToCharArray())
                    //{
                    //    password.AppendChar(c);
                    //}
                    //process.StartInfo.Password = password;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = false;

                    process.Start();
                    // process.StandardInput.AutoFlush = true;

                    //process.StandardInput.WriteLine(cmdline + "&exit");

                    //获取cmd窗口的输出信息  
                    //string output = process.StandardOutput.ReadToEnd();

                    //process.WaitForExit();
                    //process.Close();

                    return true;
                }
            } catch(Exception)
            {
                return false;
            }
        }

        private bool cmd(string IPstr, string disk,string pass)
        {
            try
            {
                using (var process = new Process())
                {
                    process.StartInfo.FileName = "net";
                    var cmdline = "use " + disk + " http://" + IPstr + ":5081/ "+pass+"  /user:admin /persistent:YES";

                    process.StartInfo.Arguments = cmdline;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = false;
                    process.Start();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                using var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "https://ser163.cn/doc";
                process.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void cbDisk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gb2_Enter(object sender, EventArgs e)
        {

        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            GlobalStop();
        }

        private void startServer_Click(object sender, EventArgs e)
        {
            GlobalStart();
        }

        private void cbIpList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainWin_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (hodoor.IsRunDav())
            {
                DialogResult ret = MessageBox.Show("是否退出服务", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == ret)
                {
                    hodoor.KillDav();
                }
            }
        }
    }
}
