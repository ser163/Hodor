using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.ServiceProcess;

namespace Hodor
{
    class Regedit
    {


        private RegistryKey MainKey = Registry.LocalMachine;
        private string SubKeyLimit = "SYSTEM\\CurrentControlSet\\Services\\WebClient\\Parameters";

        public void CheckReg()
        {
            GetDavLimit();
            GetAuthLevel();
            // 检查web client
            ReStartService();
        }
        // 检测注册表.并修改无限制的值
        private bool GetDavLimit()
        {
            try
            {
                RegistryKey SkLimit = MainKey.OpenSubKey(SubKeyLimit, RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (SkLimit == null)
                {
                    return false;
                }

                var LimitVal = SkLimit.GetValue("FileSizeLimitInBytes");

                System.Type ValType = LimitVal.GetType();

                if (ValType.Name =="Int64")
                {
                    if ((Int64)LimitVal != 4294967295)
                    {
                        SkLimit.SetValue("FileSizeLimitInBytes", 4294967295, RegistryValueKind.QWord);
                    }
                } else
                {
                    if ((Int32)LimitVal != -1)
                    {
                        SkLimit.SetValue("FileSizeLimitInBytes", 4294967295, RegistryValueKind.QWord);
                    }
                }


                return true;
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        // 支持http协议
        private bool GetAuthLevel()
        {
            try
            {
                RegistryKey SkLimit = MainKey.OpenSubKey(SubKeyLimit, RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (SkLimit == null)
                {
                    return false;
                }

                var LevelVal = SkLimit.GetValue("BasicAuthLevel");

                if ((Int32)LevelVal == 1)
                {
                    // 将值改为2,兼容http协议
                    SkLimit.SetValue("BasicAuthLevel", 2, RegistryValueKind.DWord);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // 重启webClient服务
        private bool ReStartService()
        {
            ServiceController service = new ServiceController("WebClient");
            try
            {
                if (service.Status == ServiceControllerStatus.Running)
                {
                    if (service.CanStop || service.CanShutdown)
                    {
                        service.Stop();
                        service.WaitForStatus(ServiceControllerStatus.Stopped);
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running);
                    }
                }

                if (service.Status == ServiceControllerStatus.Stopped)
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running);
                }
                service.Close();
                return true;
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
