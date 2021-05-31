using System;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - Encapsulation.cs
 * 主要功能：将主要类集合并封装成一个对象，在main中调用。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    /// <summary>
    /// 封装各功能的对象，由main()统一调用。
    /// </summary>
    class Encapsulation
    {
        static void ProgressBarController()
        {
            // You are not allowed to view this.
            // No, you are not allowed. Trust me.
            // Only God and me should know what does this function do.
            Random rd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Console.Write('*');
                System.Threading.Thread.Sleep(rd.Next(1, 200));
            }
            Console.Write("\n");
        }
        #region Shared Interface
        public void run(bool ProgramSwitch)//共用对外接口
        {
            ExceptionNotiSound soundplay = new ExceptionNotiSound();
            Load ACCLI = new Load();
            ACCLI.LoadComponents();
            Console.WriteLine("\nInitializing Components...");
            ProgressBarController();
            Console.Write("\n");
            Console.Clear();
            soundplay.PROGRAM_START_NOTISOUND_PLAY();
            Console.WriteLine("AdminCon 3.0 CLI Edition\n(c) 2017-2021 Project Amadeus. All rights reserved." +
                "\n\nType \"help\" to see available commands.\nType \"UI\" to enable the graphical interface." + "\n=================\n");
            ConsoleInteract COMMAND_PROMPT_INTERFACE = new ConsoleInteract();
            while (ProgramSwitch == true)
            {
                COMMAND_PROMPT_INTERFACE.COMMAND(); //无限循环命令行I/O
                if (ProgramSwitch == false) { break; } //当输入"QT -R"时，会把这个变量设为false，程序重启。
            }
        }
        #endregion
    }
}
//Program Entry @ Program.cs