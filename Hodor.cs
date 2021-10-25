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

        public void Run(string SharePath)
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
            exep.StartInfo.Arguments = " -p \""+SharePath+"\" -port 5081";
            exep.StartInfo.FileName = DavFile;
            exep.StartInfo.CreateNoWindow = true;
            try
            {
              exep.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
           
        }

        public void Run(string SharePath,string pass)
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
            exep.StartInfo.Arguments = " -p \"" + SharePath + "\" -port 5081 -user \"admin\" -pass \"" + pass+"\"";
            exep.StartInfo.FileName = DavFile;
            exep.StartInfo.CreateNoWindow = true;
            try
            {
                exep.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        public void Stop()
        {
            try
            {
                exep.Kill();
            } catch(InvalidOperationException ex)
            {
                KillDav();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public bool IsRunDav()
        {
            var Count = System.Diagnostics.Process.GetProcessesByName("webDav_go").ToList().Count;
            if (Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool KillDav()
        {
            try
            {
                var DavList = System.Diagnostics.Process.GetProcessesByName("webDav_go");

                for (int i = 0; i < DavList.Length; i++)
                {
                    DavList[i].Kill();//结束进程
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
    }
}
