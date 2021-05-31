using System;
using System.Diagnostics;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - ProcessAlgorithms.cs
 * 主要功能：进程操作算法。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    /// <summary>
    /// 操作Windows进程的核心代码。
    /// </summary>
    class ProcessAlgorithms
    {
        #region Process Operations
        //进程操作函数
        public void KillProcess(string PNAME)
        {
            //杀死进程的核心算法
            Process[] P_Array = Process.GetProcessesByName(PNAME);
            foreach (Process p in P_Array)
            {
                p.Kill();
            }
        }
        public void KillProcessByPID(int PID)
        {
            Process p = Process.GetProcessById(PID);
            p.Kill();
        }
        static int GetPID(string PNAME)
        {
            //通过进程名称寻找进程ID的核心算法
            string PName = PNAME;
            int pid = -1;
            Process[] processArray = Process.GetProcessesByName(PName);
            //集合Process[]的第一个元素，就是目标进程。Id方法可以获取此进程的PID。
            pid = processArray[0].Id;
            //函数的最终返回值为PID，以便调用时提供PID的访问接口。
            return pid;
        }
        /*封装*/public string PrintPID(string PNAME) //打印PID的函数
        {
            return "PID of " + PNAME + ": " + Convert.ToString(GetPID(PNAME));
        }
        #endregion
    }
}
//Program Entry @ Program.cs
