using System;
using System.Diagnostics;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - ProcessQuery.cs
 * 主要功能：进程列表和监视器。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    class ProcessQuery
    {
        public void ListProcesses() //打印所有进程：遍历PID（0~20000）
        {
            for (int i = 0; i<20000; i++)
            {
                try
                {
                    switch(Convert.ToString(i).Length)
                    {
                        case (1):
                            Console.WriteLine("Process ID: " + i + "----------" + Convert.ToString(Process.GetProcessById(i)));
                            break;
                        case (2):
                            Console.WriteLine("Process ID: " + i + "---------" +  Convert.ToString(Process.GetProcessById(i)));
                            break;
                        case (3):
                            Console.WriteLine("Process ID: " + i + "--------" +   Convert.ToString(Process.GetProcessById(i)));
                            break;
                        case (4):
                            Console.WriteLine("Process ID: " + i + "-------" +    Convert.ToString(Process.GetProcessById(i)));
                            break;
                        case (5):
                            Console.WriteLine("Process ID: " + i + "------" +     Convert.ToString(Process.GetProcessById(i)));
                            break;
                    }   
                }
                catch (Exception) {}
            }
            ExceptionNotiSound SoundPlay = new ExceptionNotiSound();
            SoundPlay.OPERATION_COMPLETE_NOTISOUND_PLAY();
        }
    }
}
//Program Entry @ Program.cs