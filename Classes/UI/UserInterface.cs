using System.Threading;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - UserInterface.cs
 * 主要功能：建立线程，打开UI界面。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    class UserInterface
    {
        private static void INITIALIZE_UI_COMPONENTS()
        {
            //打开Winform界面
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Classes.UI.GraphicalInterface());
        }
        public void THREAD_START_UIWINDOW()
        {
            ThreadStart UIStart = new ThreadStart(INITIALIZE_UI_COMPONENTS); //新建线程，打开INITIALIZE_UI_COMPONENTS()方法，开启UI窗口。
            Thread NEW_UI_WINDOW_THREAD = new Thread(UIStart);
            NEW_UI_WINDOW_THREAD.Start();
        }
    }
}
