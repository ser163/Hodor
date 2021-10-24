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

                // ��õ�ǰ��¼��Windows�û���ʾ
                //System.Security.Principal.WindowsIdentity Identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                //System.Security.Principal.WindowsPrincipal Principal = new System.Security.Principal.WindowsPrincipal(Identity);
                // ����ǹ���Ա��ֱ������
                //if (Principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                //{
                //    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                //    Application.EnableVisualStyles();
                //    Application.SetCompatibleTextRenderingDefault(false);
                //    Application.Run(new mainWin());
                //}
                //else
                //{
                //    // ������������
                //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //    startInfo.UseShellExecute = true;
                //    startInfo.WorkingDirectory = Environment.CurrentDirectory;
                //    startInfo.FileName = Application.ExecutablePath;
                //    //������������,ȷ���Թ���Ա�������
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
                // ��ֹ�˽��̲�Ϊ��������ϵͳ�ṩָ�����˳����롣
                System.Environment.Exit(1);
            }
        }
    }
}
