using System;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - Load.cs
 * 主要功能：加载程序库文件的提示。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    class Load
    {
        public void LoadComponents()
        {
            Random obj_rd = new Random();
            Console.WriteLine("System Environment Configured            -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50,100));
            Console.WriteLine(".NET Runtime Configured                  -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50,100));
            Console.WriteLine("Hard Disk Drive Detected                 -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50,100));
            Console.WriteLine("Hardware status Detected                 -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50,100));
            Console.WriteLine("Windows UAC Checked                      -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50,100));
            Console.WriteLine("LIBFILE_LOADED: kernel32.dll             -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50,100));
            Console.WriteLine("LIBFILE_LOADED: amod.lib                 -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50,100));
            Console.WriteLine("LIBFILE_LOADED: recvsp.lib               -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50,100));
            Console.WriteLine("LIBFILE_LOADED: ACCLI_PROGRAM_DATAPOOL   -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50, 100));
            Console.WriteLine("LIBFILE_LOADED: THREADING_SECURITY       -TASK_COMPLETE");
            System.Threading.Thread.Sleep(obj_rd.Next(50, 100));
            Console.WriteLine("Program Integrity Test                   -PIT_ATTEMPTED");
            System.Threading.Thread.Sleep(obj_rd.Next(200,300));
            Console.WriteLine("\nDone.");
        }
    }
}
//Program Entry @ Program.cs