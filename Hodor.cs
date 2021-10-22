using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Hodor
{
    class Hodoor
    {
        private Process exep = new();   
        public void Run()
        {
            exep.StartInfo.Arguments = "-port 5081 -log true";
            exep.StartInfo.FileName = @"webDav_go.exe";
            /*          exep.StartInfo.UseShellExecute = false;
                        exep.StartInfo.RedirectStandardInput = true;
                        exep.StartInfo.RedirectStandardOutput = true;
                        exep.StartInfo.RedirectStandardError = true;*/
            exep.StartInfo.CreateNoWindow = true;
            exep.EnableRaisingEvents = true;
            exep.Exited += new EventHandler(exep_Exited);
            exep.Start();
            // string output = process.StandardOutput.ReadToEnd();
            // process.WaitForExit();
        }

        public void Stop()
        {
            exep.Kill();
        }
        void exep_Exited(object sender, EventArgs e)
        {
            Console.WriteLine("go exit.....");
        }
    }
}
