using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Hodor
{
    class Hodoor
    {
        private Process exep = new();
        private readonly string  DavFile = @"webDav_go.exe";

        public void Run()
        {
            // 检查webDav.exe文件是否存在
            if (!File.Exists(DavFile))
            {
                MessageBox.Show("webDav_go.exe 程序找不到");
                Environment.Exit(0);
            }
            //判断是否已经运行
            if (IsRunDav())
            {
                MessageBox.Show("webDav_go已经运行,请先停止再启动");
                Environment.Exit(0);
            }
            exep.StartInfo.Arguments = "-port 5081 -log true";
            exep.StartInfo.FileName = DavFile;
            exep.StartInfo.CreateNoWindow = true;
            exep.Start();
        }

        public void Stop()
        {
            try
            {
                exep.Kill();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool IsRunDav()
        {
            var Count = System.Diagnostics.Process.GetProcessesByName("webDav_go").ToList().Count;
            if (Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
