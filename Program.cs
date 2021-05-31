/* AdminCon 3.0 Command Line Interface Edition - 源代码 - Program.cs
 * 主要功能：应用程序的主入口点。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace ACCLI_PROGRAM_ENTRY
{
    /// <summary>
    /// 程序入口。
    /// </summary>
    class Program
    {
        static void Main(string[] args) //Program Entry @ Program.cs
        {
            AdminCon_CLI_dotnetEdition.Encapsulation AdminCon = new AdminCon_CLI_dotnetEdition.Encapsulation();
            try
            {
                AdminCon.run(true);
            }
            catch(System.Exception){}
        }
    }
}