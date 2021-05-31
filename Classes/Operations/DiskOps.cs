using System;
using System.Diagnostics;
using System.Threading;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - DiskOps.cs
 * 主要功能：提供磁盘操作函数。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    class DiskOps
    {
        public void OpenDrive(string driveletter) //命令行输入"C:"或者"C:\"打开磁盘驱动器。
        {
            ExceptionNotiSound obj_es = new ExceptionNotiSound();
            try
            {
                Process.Start(driveletter);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj_es.SYSTEM_EXCEPTION_NOTISOUND_PLAY();
            }
        }
        public void formatdisk(string driveletter) //函数功能：格式化逻辑分区。（FDISK /D X:\）
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("format.com", driveletter); //启动此程序时，加入参数。
            process.StartInfo = startInfo;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }
        public void diskdefragment(string driveletter) //函数功能：清理逻辑分区的文件碎片。（DFRG /D X:\）
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("defrag.exe", driveletter); //启动此程序时，加入参数。
            process.StartInfo = startInfo;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }
    }
}
