using System;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - CommandBuilder.cs
 * 主要功能：将用户输入的语句分割成命令，参数和关键字。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    /// <summary>
    /// 从用户输入中读取命令，参数和关键字的核心代码。
    /// </summary>
    class CommandBuilder
    {
        public string getKeyword(string statement)
        {
            //便于访问keywords的值。
            //注：一条完整的命令语句的组成为"command + parameter + keywords"；用空格隔开。
            
            try
            {
                string[] sArray = statement.Split(' ');
                return sArray[2];
            }
            catch(Exception){} 
            return null;
        }
        public string getParameter(string statement)
        {
            //便于访问Parameter的值。
            //注：一条完整的命令语句的组成为"command + parameter + keywords"；用空格隔开。
            
            try
            {
                string[] sArray = statement.Split(' ');
                return sArray[1];
            }
            catch (Exception){}
            return null;
        }
        public string getCommand(string statement)
        {
            //便于访问Command的值。
            //注：一条完整的命令语句的组成为"command + parameter + keywords"；用空格隔开。
            
            try
            {
                string[] sArray = statement.Split(' ');
                return sArray[0];
            }
            catch (Exception){}
            return null;
        }
    }
}
//Program Entry @ Program.cs
