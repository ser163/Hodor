using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFwTypeLib;

namespace Hodor
{
    class FireWalld
    {

        public static bool AddRuls(string Path)
        {
            try
            {
                INetFwMgr netFwMgr = (INetFwMgr)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr"));

                INetFwAuthorizedApplication app = (INetFwAuthorizedApplication)Activator.CreateInstance(
        Type.GetTypeFromProgID("HNetCfg.FwAuthorizedApplication"));

                app.Name = "Hodor";
                app.ProcessImageFileName = Path;
                app.Enabled = true;
                netFwMgr.LocalPolicy.CurrentProfile.AuthorizedApplications.Add(app);
                return true;
            }
            catch (Exception)
            {
                return false;
            } 

        }
    }
}
