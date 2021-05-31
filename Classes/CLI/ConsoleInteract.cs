using System;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - ConsoleInteract.cs
 * 主要功能：控制台交互，调用命令函数。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    /// <summary>
    /// 实现命令行交互的核心代码，建立命令行界面和各对象之间的控制关系。
    /// </summary>  
    class ConsoleInteract
    {
        #region Object Instantiation
        //对象实例化
        CommandBuilder     COMMAND_BUILDER     =    new      CommandBuilder();
        ProcessAlgorithms  PROCESS             =    new   ProcessAlgorithms();
        PrintOSinfo        SYSTEM_INFO         =    new         PrintOSinfo();
        ProcessQuery       PROCESS_QUERY       =    new        ProcessQuery();
        DiskOps            DISK                =    new             DiskOps();
        ExceptionNotiSound EXCEPTION_SOUNDPLAY =    new  ExceptionNotiSound();
        Encapsulation      PROGRAM             =    new       Encapsulation();
        UserInterface      VISUAL_WINDOW       =    new       UserInterface();
        #endregion
        #region System Prompts
        public void BAD_COMMAND_MSG_PROMPT()
        {
            string BAD_COMMAND_MSG = "Error - Bad Command.";
            Console.WriteLine(BAD_COMMAND_MSG);
            EXCEPTION_SOUNDPLAY.BAD_COMMAND_NOTISOUND_PLAY();
        }
        public void Press_Any_Key_To_Continue_Prompt()
        {
            Console.WriteLine("Press any key to continue...");
        }
        #endregion
        public void COMMAND()//类的对外接口
        {
            Console.Write("\n\nAdministrator_>");
            string command = Console.ReadLine();
            string cmdUpper = command.ToUpper();
            #region Internal Commands
            switch (cmdUpper)
            {
                //Null input:
                case "":
                    break;
                //Help Utilities.
                case "HELP":
                    Console.WriteLine("Commands: \nKILL    RUN    TIME    GETPID    FDISK    DFRG\n\n    PING    CLS    WINFO   LISP    QT    UI"
                    + "\n\n\nKey Words: \n[PID]    [PNAME]    [IP_ADDRESS]      [DOMAIN]      [PATH]      [DRIVE]" + "\n\n\nParameters: \n/S: Parameter type of string;" +
                    "    /I: Parameter type of int    /D: Disk drive letter"
                    + "\n\n\nHELP + Command Name to view help info of this command.\nAll commands are not case-sensitive.");
                    break;
                case "HELP KILL":
                    Console.WriteLine("\nKILL - Kill a running process.\n\nParameters: \nKILL /S [PNAME] - Kill a process " +
                        "by its name.\nKILL /I [PID] - Kill a process by its PID.");
                    break;
                case "KILL":
                    Console.WriteLine("\nKILL - Kill a running process.\n\nParameters: \nKILL /S [PNAME] - Kill a process " +
                        "by its name.\nKILL /I [PID] - Kill a process by its PID.");
                    break;
                case "HELP RUN":
                    Console.WriteLine("\nRUN - Start a process, or open a file.\n\nParameters: \nRUN /S [PNAME] - Start a process by its name."+
                        "\nRUN /S [PATH] - Open a file in specific path.");
                    break;
                case "RUN":
                    Console.WriteLine("\nRUN - Start a process, or open a file.\n\nParameters: \nRUN /S [PNAME] - Start a process by its name." +
                        "\nRUN /S [PATH] - Open a file in specific path.");
                    break;
                case "HELP TIME":
                    Console.WriteLine("\nTIME - Print current time.\n\nParameters: none.");
                    break;
                case "TIME":
                    Console.WriteLine(System.DateTime.Now.ToString() + "\n");
                    break;
                case "HELP GETPID":
                    Console.WriteLine("\nGETPID - Get Process ID by its name.\n\nParameters:\nGETPID /S [PNAME]\n");
                    break;
                case "GETPID":
                    Console.WriteLine("\nGETPID - Get Process ID by its name.\n\nParameters:\nGETPID /S [PNAME]\n");
                    break;
                case "HELP PING":
                    Console.WriteLine("\nPING - Send TCP packages to a specific IP Address or domain."
                        + "\nParameters: PING [IP_ADDRESS] or PING [DOMAIN]" + "\n\nExample:\n " +
                    "      PING /S 192.168.0.1     PING /S LOCALHHOST     PING /S GOOGLE.COM \n");
                    break;
                case "PING":
                    Console.WriteLine("\nPING - Send TCP packages to a specific IP Address or domain."
                        + "\nParameters: PING [IP_ADDRESS] or PING [DOMAIN]" + "\n\nExample:\n " +
                    "      PING /S 192.168.0.1     PING /S LOCALHHOST     PING /S GOOGLE.COM \n");
                    break;
                case ("HELP CLS"):
                    Console.WriteLine("\nCLS - Clear the console.\n\nParameters: none.");
                    break;
                case "CLS":
                    Console.Clear();
                    break;
                case ("HELP LISP"):
                    Console.WriteLine("\nLISP - List all processes.\n\nParameters: none.");
                    break;
                case ("LISP"):
                    PROCESS_QUERY.ListProcesses();
                    break;
                case ("HELP WINFO"):
                    Console.WriteLine("\nWINFO - Print infomation of your Windows machine.\n\nParameters: none.");
                    break;
                case ("WINFO"):
                    SYSTEM_INFO.PRINTSYSINFO();
                    break;
                case "HELP FDISK":
                    Console.WriteLine("\nFDISK - Format a specified drive.\n\nParameters: \nFDISK /D [DRIVE] - Format a drive." +
                        "\n\nExample:\n"+"FDISK /D D:\\"+" - Format drive D:\\.");
                    break;
                case "FDISK":
                    Console.WriteLine("\nFDISK - Format a specified drive.\n\nParameters: \nFDISK /D [DRIVE] - Format a drive." +
                        "\n\nExample:\n" + "FDISK /D D:\\" + " - Format drive D:\\.");
                    break;
                case "HELP DFRG":
                    Console.WriteLine("\nDFRG - Defrag a specified drive.\n\nParameters: \nDFRG /D [DRIVE] - Defrag a drive." +
                        "\n\nExample:\n" + "DFRG /D C:\\" + " - Defrag drive C:\\.");
                    break;
                case "DFRG":
                    Console.WriteLine("\nDFRG - Defrag a specified drive.\n\nParameters: \nDFRG /D [DRIVE] - Defrag a drive." +
                        "\n\nExample:\n" + "DFRG /D C:\\" + " - Defrag drive C:\\.");
                    break;
                case "HELP QT":
                    Console.WriteLine("\nQT - Quit or restart this program.\n\nParameters: \nQT -R - Restart this program."+
                        "\nQT -S - Quit this program.");
                    break;
                case "QT":
                    Console.WriteLine("\nQT - Quit or restart this program.\n\nParameters: \nQT -R - Restart this program." +
                        "\nQT -S - Quit this program.");
                    break;
                case "HELP UI":
                    Console.WriteLine("\nUI - Open a window with graphical interface.\n\nParameters: none.");
                    break;
                case "UI":
                    VISUAL_WINDOW.THREAD_START_UIWINDOW();
                    break;
                #endregion
                #region Commands With Parameters and Key Words
                default:
                    string cmds = COMMAND_BUILDER.getCommand(cmdUpper);
                    string para = COMMAND_BUILDER.getParameter(cmdUpper);
                    string keyw = COMMAND_BUILDER.getKeyword(cmdUpper);
                    try
                    {
                        if((0<cmds.Length && 3>=cmds.Length)&&(cmds.Contains(":")||cmds.Contains(":\\")))
                        {
                            try
                            {
                                DISK.OpenDrive(cmds);
                            }catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                EXCEPTION_SOUNDPLAY.SYSTEM_EXCEPTION_NOTISOUND_PLAY();
                            }
                        }
                        else if(cmds.ToUpper() == "QT")
                        {
                            if (para.ToUpper() == "-R")
                            {
                                Console.Clear();
                                EXCEPTION_SOUNDPLAY.PROGRAM_QUIT_NOTISOUND_PLAY();
                                PROGRAM.run(false);
                            }
                            else if (para.ToUpper() == "-S")
                            {
                                EXCEPTION_SOUNDPLAY.PROGRAM_QUIT_NOTISOUND_PLAY();
                                PROCESS.KillProcess("conhost");
                            }
                            else { BAD_COMMAND_MSG_PROMPT(); }
                        }
                        else if(cmds.ToUpper()=="FDISK")
                        {
                            if(para == null) {BAD_COMMAND_MSG_PROMPT(); }
                            else if (para.ToUpper() == "/D")
                            {
                                DISK.formatdisk(keyw);
                            }
                            else {BAD_COMMAND_MSG_PROMPT(); }
                        }
                        else if (cmds.ToUpper() == "DFRG")
                        {
                            if (para == null) { BAD_COMMAND_MSG_PROMPT(); }
                            else if (para.ToUpper() == "/D")
                            {
                                DISK.diskdefragment(keyw);
                            }
                            else { BAD_COMMAND_MSG_PROMPT(); }
                        }
                        else if (cmds.ToUpper() == "KILL")
                        {
                            if (para == null)
                            {
                                BAD_COMMAND_MSG_PROMPT();
                            }
                            else if (para.ToUpper() == "/S")
                            {
                                try
                                {
                                    PROCESS.KillProcess(keyw);
                                }catch(Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    EXCEPTION_SOUNDPLAY.SYSTEM_EXCEPTION_NOTISOUND_PLAY();
                                }
                            }
                            else if (para.ToUpper() == "/I")
                            {
                                try
                                {
                                    PROCESS.KillProcessByPID(Convert.ToInt32(keyw));
                                }catch(Exception)
                                {
                                    Console.WriteLine("Process Not Found.");
                                    EXCEPTION_SOUNDPLAY.SYSTEM_EXCEPTION_NOTISOUND_PLAY();
                                }
                            }
                            else { BAD_COMMAND_MSG_PROMPT(); }
                        }
                        else if (cmds.ToUpper() == "RUN")
                        {
                            if (para == null)
                            {
                                BAD_COMMAND_MSG_PROMPT();
                            }
                            else if (para.ToUpper() == "/S")
                            {
                                try
                                {
                                    System.Diagnostics.Process.Start(keyw);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    EXCEPTION_SOUNDPLAY.SYSTEM_EXCEPTION_NOTISOUND_PLAY();
                                }
                            }
                            else { BAD_COMMAND_MSG_PROMPT(); }
                        }
                        else if (cmds.ToUpper() == "GETPID")
                        {
                            if (para == null)
                            {
                                BAD_COMMAND_MSG_PROMPT();
                            }
                            else if (para.ToUpper() == "/S")
                            {
                                try
                                {
                                    Console.WriteLine(PROCESS.PrintPID(keyw) + "\n");
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Process Not Found.");
                                    EXCEPTION_SOUNDPLAY.SYSTEM_EXCEPTION_NOTISOUND_PLAY();
                                }
                            }
                            else { BAD_COMMAND_MSG_PROMPT(); }
                        }
                        else if (cmds.ToUpper() == "PING")
                        {
                            if (para == null)
                            {
                                BAD_COMMAND_MSG_PROMPT();
                            }
                            else if (para.ToUpper() == "/S")
                            {
                                Console.WriteLine("Please Wait......");
                                string timecmd = "ping " + keyw;
                                System.Diagnostics.Process p = new System.Diagnostics.Process();
                                p.StartInfo.FileName = "cmd.exe";
                                p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
                                p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                                p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                                p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                                p.StartInfo.WindowStyle =
                                    System.Diagnostics.ProcessWindowStyle.Normal;//显示程序窗口
                                p.Start();//启动程序
                                          //向cmd窗口发送输入信息
                                p.StandardInput.WriteLine(timecmd + "&exit");
                                p.StandardInput.AutoFlush = true;
                                //p.StandardInput.WriteLine("exit");
                                //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令。
                                //如果不执行exit命令，后面调用ReadToEnd()方法会假死
                                //同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令
                                //获取cmd窗口的输出信息
                                string output = p.StandardOutput.ReadToEnd();
                                System.IO.StreamReader reader = p.StandardOutput;
                                string line = reader.ReadLine();
                                while (!reader.EndOfStream)
                                {
                                    timecmd += line + "  ";
                                    line = reader.ReadLine();
                                }
                                p.WaitForExit();//等待程序执行完退出进程
                                p.Close();
                                Console.WriteLine(output);
                            }
                            else { BAD_COMMAND_MSG_PROMPT(); }
                        }
                        else
                        {
                           BAD_COMMAND_MSG_PROMPT();
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message + "\n");
                        EXCEPTION_SOUNDPLAY.SYSTEM_EXCEPTION_NOTISOUND_PLAY();}
                    break;
                    #endregion
            }
        }
    }
}
//Program Entry @ Program.cs
