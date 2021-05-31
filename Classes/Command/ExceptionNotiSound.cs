using System;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - ExceptionNotiSound.cs
 * 主要功能：当发现程序抛出异常或命令不符合规范时，发出警报声。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    class ExceptionNotiSound
    {
        public void BAD_COMMAND_NOTISOUND_PLAY() //当命令格式不符合规范时，发出这个警报声。
        {
            for(int i=0; i<3; i++)
            {
                Console.Beep(600, 50);
            }
        }
        public void SYSTEM_EXCEPTION_NOTISOUND_PLAY() //当程序抛出异常时，发出这个警报声。
        {
            Console.Beep(600, 80);
            Console.Beep(400, 80);
        }
        public void PROGRAM_QUIT_NOTISOUND_PLAY() //当程序通过内置命令关闭/重启时，播放这个声音。
        {
            Console.Beep(600, 300);
            Console.Beep(400, 400);
        }
        public void PROGRAM_START_NOTISOUND_PLAY() //当程序启动时，播放这个声音。
        {
            Console.Beep(400, 400);
            Console.Beep(600, 300);
        }
        public void OPERATION_COMPLETE_NOTISOUND_PLAY() //当操作完成时，播放这个声音。
        {
            Console.Beep(400, 100);
            Console.Beep(400, 100);
        }
    }
}
//Program Entry @ Program.cs