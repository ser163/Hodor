using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hodor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using Mutex mutex = new Mutex(true, Application.ProductName, out bool IsRun);
            if (IsRun)
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainWin());

                // 获得当前登录的Windows用户标示
                //System.Security.Principal.WindowsIdentity Identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                //System.Security.Principal.WindowsPrincipal Principal = new System.Security.Principal.WindowsPrincipal(Identity);
                // 如果是管理员则直接运行
                //if (Principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                //{
                //    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                //    Application.EnableVisualStyles();
                //    Application.SetCompatibleTextRenderingDefault(false);
                //    Application.Run(new mainWin());
                //}
                //else
                //{
                //    // 创建启动对象
                //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //    startInfo.UseShellExecute = true;
                //    startInfo.WorkingDirectory = Environment.CurrentDirectory;
                //    startInfo.FileName = Application.ExecutablePath;
                //    //设置启动动作,确保以管理员身份运行
                //    startInfo.Verb = "runas";
                //    try
                //    {
                //        System.Diagnostics.Process.Start(startInfo);
                //    }
                //    catch
                //    {
                //        return;
                //    }
                //    Application.Exit();
                //}
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                // 终止此进程并为基础操作系统提供指定的退出代码。
                System.Environment.Exit(1);
            }
        }
    }
}
