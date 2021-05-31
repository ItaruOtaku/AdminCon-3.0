using System;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - PrintOSinfo.cs
 * 主要功能：打印计算机基础信息。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    class PrintOSinfo
    {
        public void PRINTSYSINFO()
        {
            #region Get Machine Info
            //获取计算机的操作系统信息
            string                 MACHINE_NAME =     Environment.MachineName;
            string   WINDOWS_NT_OS_VERSION_NAME =     Convert.ToString(Environment.OSVersion.Version);
            string                 SERVICE_PACK =     Environment.OSVersion.ServicePack;
                     WINDOWS_NT_OS_VERSION_NAME =     WINDOWS_NT_OS_VERSION_NAME + " " + SERVICE_PACK;
            string                    USER_NAME =     Environment.UserName;
            string                  DOMAIN_NAME =     Environment.UserDomainName;
            string                   TICK_COUNT =    (Environment.TickCount / 1000).ToString() + "s";
            string             SYSTEM_PAGE_SIZE =    (Environment.SystemPageSize / 1024).ToString() + "KB";
            string                   SYSTEM_DIR =     Environment.SystemDirectory;
            string        PROCESSOR_CORES_COUNT =     Environment.ProcessorCount.ToString();
            string                     PLATFORM =     Environment.OSVersion.Platform.ToString();
            bool                    IS_64BIT_OS =     Environment.Is64BitOperatingSystem;
            bool               IS_X64_PROCESSOR =     Environment.Is64BitProcess;
            string                  CURRENT_DIR =     Environment.CurrentDirectory;
            string                 COMMAND_LINE =     Environment.CommandLine;
            string[]             LOGICAL_DRIVES =     Environment.GetLogicalDrives();
            string                    HOST_NAME =     System.Net.Dns.GetHostName();
            System.Net.IPAddress[]     ipadrlst =     System.Net.Dns.GetHostAddresses(HOST_NAME);
            #endregion
            #region Print Machine Info
            //打印操作系统信息
            Console.WriteLine("\n\n********* Computer Info *********\n\n");
            Console.WriteLine("\n||   Machine name: "+                    MACHINE_NAME);
            Console.WriteLine("\n||   NT kernel version: " +WINDOWS_NT_OS_VERSION_NAME);
            Console.WriteLine("\n||   User name: " +                         USER_NAME);
            Console.WriteLine("\n||   Domain: " +                          DOMAIN_NAME);
            Console.WriteLine("\n||   Tick count: " +                       TICK_COUNT);
            Console.WriteLine("\n||   System page size: " +           SYSTEM_PAGE_SIZE);
            Console.WriteLine("\n||   System directory: " +                 SYSTEM_DIR);
            Console.WriteLine("\n||   Processor cores count: " + PROCESSOR_CORES_COUNT);
            Console.WriteLine("\n||   Platform: " +                           PLATFORM);
            Console.WriteLine("\n||   X64OS: " +                           IS_64BIT_OS);
            Console.WriteLine("\n||   X64CPU: " +                     IS_X64_PROCESSOR);
            Console.WriteLine("\n||   Current directory: " +               CURRENT_DIR);
            Console.WriteLine("\n||   Command line: " +                   COMMAND_LINE);
            Console.Write("\n||   Logical drives: ");
            for(int i = 0; i < LOGICAL_DRIVES.Length; i++)
            {
                Console.Write(LOGICAL_DRIVES[i] + "\t"); //打印逻辑分区列表
            }
            Console.WriteLine("\n\n||   IPv4-IPv6: ");
            for (int i = 0; i < ipadrlst.Length; i++)
            {
                Console.WriteLine("\n        "+ipadrlst[i] + "\n"); //打印当前网络可用的IPv4和IPv6地址
            }
            HardwareInfo obj_hdwinfo = new HardwareInfo();
            obj_hdwinfo.printHardwareInfo();
            Console.WriteLine("\n\n********************************\n\n");
            #endregion
            ExceptionNotiSound SoundPlay = new ExceptionNotiSound();
            SoundPlay.OPERATION_COMPLETE_NOTISOUND_PLAY();
        }
    }
}
//Program Entry @ Program.cs