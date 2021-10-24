using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Collections;



namespace Hodor
{

    static class GOT
    {

        // 获取本机所有ip
        public static List<string> GetAllIP()
        {
            string name = Dns.GetHostName();
            IPAddress[] ipadrlist = Dns.GetHostAddresses(name);

            List<string> IPList = new List<string>();
            foreach (IPAddress ipa in ipadrlist)
            {
                if (ipa.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPList.Add(ipa.ToString());
                }

            }
            return IPList;
        }
    }

}



