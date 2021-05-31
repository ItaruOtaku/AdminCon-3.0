using System;
using System.Windows.Forms;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - GraphicalInterface.cs
 * 主要功能：建立线程，打开UI界面。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition.Classes.UI
{
    public partial class GraphicalInterface : Form
    {
        /// <summary>
        /// 实现图形界面的核心代码。
        /// 通过UserInterface.cs打开此Winform窗口。
        /// </summary>
        #region Object Instantiation
        //对象实例化
        CommandBuilder cmd            = new     CommandBuilder();
        ProcessAlgorithms processAlgo = new  ProcessAlgorithms();
        PrintOSinfo osinfo            = new        PrintOSinfo();
        ProcessQuery processQuery     = new       ProcessQuery();
        DiskOps disk                  = new            DiskOps();
        ExceptionNotiSound exnoti     = new ExceptionNotiSound();
        #endregion
        public GraphicalInterface()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            exnoti.OPERATION_COMPLETE_NOTISOUND_PLAY();
            LOGICAL_DRIVE_RADIOBUTTON_TEXT_INITIALIZE();
            #region Get Machine Info
            //获取计算机的操作系统信息
            string MACHINE_NAME = Environment.MachineName;
            string WINDOWS_NT_OS_VERSION_NAME = Convert.ToString(Environment.OSVersion.Version);
            string SERVICE_PACK = Environment.OSVersion.ServicePack;
            WINDOWS_NT_OS_VERSION_NAME = WINDOWS_NT_OS_VERSION_NAME + " " + SERVICE_PACK;
            string USER_NAME = Environment.UserName;
            string DOMAIN_NAME = Environment.UserDomainName;
            string TICK_COUNT = (Environment.TickCount / 1000).ToString() + "s";
            string SYSTEM_PAGE_SIZE = (Environment.SystemPageSize / 1024).ToString() + "KB";
            string SYSTEM_DIR = Environment.SystemDirectory;
            string PROCESSOR_CORES_COUNT = Environment.ProcessorCount.ToString();
            string PLATFORM = Environment.OSVersion.Platform.ToString();
            bool IS_64BIT_OS = Environment.Is64BitOperatingSystem;
            bool IS_X64_PROCESSOR = Environment.Is64BitProcess;
            string[] LOGICAL_DRIVES = Environment.GetLogicalDrives();
            string HOST_NAME = System.Net.Dns.GetHostName();
            System.Net.IPAddress[] ipadrlst = System.Net.Dns.GetHostAddresses(HOST_NAME);
            #endregion
            #region Print System Info
            InfoRichTextBox.Text =
            "\n\n    ************* Computer Info *************\n\n" +
            "\n||   Machine name:          " + MACHINE_NAME +
            "\n||   NT kernel version:     " + WINDOWS_NT_OS_VERSION_NAME +
            "\n||   User name:             " + USER_NAME +
            "\n||   Domain:                " + DOMAIN_NAME +
            "\n||   Tick count:            " + TICK_COUNT +
            "\n||   System page size:      " + SYSTEM_PAGE_SIZE +
            "\n||   System directory:      " + SYSTEM_DIR +
            "\n||   Logical Processors:    " + PROCESSOR_CORES_COUNT +
            "\n||   Platform:              " + PLATFORM +
            "\n||   X64OS:                 " + IS_64BIT_OS +
            "\n||   X64CPU:                " + IS_X64_PROCESSOR +
            "\n\n\n\n\n\n          (c)2017-2020 Project Amadeus";
            #endregion
        }
        #region Print Logical Drives Letter to Radio Buttons
        private void LOGICAL_DRIVE_RADIOBUTTON_TEXT_INITIALIZE()
        {
            try
            {
                string[] Logical_drives = System.Environment.GetLogicalDrives();
                string[] Logical_drives_final = new string[Logical_drives.Length];
                for (int i = 0; i < Logical_drives_final.Length; i++)
                {
                    Logical_drives_final[i] = Logical_drives[i];
                }
                try
                {
                    LogicalDrive1_RadioButton.Text = Logical_drives_final[0];
                }
                catch (Exception) { LogicalDrive1_RadioButton.Text = "Not Detected"; }
                try
                {
                    LogicalDrive2_RadioButton.Text = Logical_drives_final[1];
                }
                catch (Exception) { LogicalDrive2_RadioButton.Text = "Not Detected"; }
                try
                {
                    LogicalDrive3_RadioButton.Text = Logical_drives_final[2];
                }
                catch (Exception) { LogicalDrive3_RadioButton.Text = "Not Detected"; }
                try
                {
                    LogicalDrive4_RadioButton.Text = Logical_drives_final[3];
                }
                catch (Exception) { LogicalDrive4_RadioButton.Text = "Not Detected"; }
                try
                {
                    LogicalDrive5_RadioButton.Text = Logical_drives_final[4];
                }
                catch (Exception) { LogicalDrive5_RadioButton.Text = "Not Detected"; }
                try
                {
                    LogicalDrive6_RadioButton.Text = Logical_drives_final[5];
                }
                catch (Exception) { LogicalDrive6_RadioButton.Text = "Not Detected"; }
                try
                {
                    LogicalDrive7_RadioButton.Text = Logical_drives_final[6];
                }
                catch (Exception) { LogicalDrive7_RadioButton.Text = "Not Detected"; }
                try
                {
                    LogicalDrive8_RadioButton.Text = Logical_drives_final[7];
                }
                catch (Exception) { LogicalDrive8_RadioButton.Text = "Not Detected"; }
            }

            catch (Exception) { }

        }
        #endregion
        private void RETURN_MSG_BOX_PROMPT(string message)
        {
            MessageBox.Show(message, "RETURN_RESULT");
        }
        #region Process Operations
        private void KILL_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                processAlgo.KillProcess(ProcessOps_TextBox.Text);
            }catch(Exception ex) { RETURN_MSG_BOX_PROMPT(ex.Message); }
        }

        private void getpid_Button_Click(object sender, EventArgs e)
        {
            try
            {
                RETURN_MSG_BOX_PROMPT(processAlgo.PrintPID(ProcessOps_TextBox.Text));
            } catch (Exception ex) { RETURN_MSG_BOX_PROMPT(ex.Message); }
        }

        private void runProcess_Button_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(ProcessOps_TextBox.Text);
            } catch (Exception ex) { RETURN_MSG_BOX_PROMPT(ex.Message); }
        }
        #endregion
        #region Disk Operations
        private void drives_ini_button_Click(object sender, EventArgs e)
        {
            LOGICAL_DRIVE_RADIOBUTTON_TEXT_INITIALIZE();
        }

        private void format_partition_button_Click(object sender, EventArgs e)
        {
            #region Format selected disk
            if (LogicalDrive1_RadioButton.Checked)
            {
                disk.formatdisk(LogicalDrive1_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive2_RadioButton.Checked)
            {
                disk.formatdisk(LogicalDrive2_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive3_RadioButton.Checked)
            {
                disk.formatdisk(LogicalDrive3_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive4_RadioButton.Checked)
            {
                disk.formatdisk(LogicalDrive4_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive5_RadioButton.Checked)
            {
                disk.formatdisk(LogicalDrive5_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive6_RadioButton.Checked)
            {
                disk.formatdisk(LogicalDrive6_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive7_RadioButton.Checked)
            {
                disk.formatdisk(LogicalDrive7_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive8_RadioButton.Checked)
            {
                disk.formatdisk(LogicalDrive8_RadioButton.Text.Replace("\\", ""));
            }
            #endregion
        }

        private void defrag_partition_button_Click(object sender, EventArgs e)
        {
            #region Defrag selected disk
            if (LogicalDrive1_RadioButton.Checked)
            {
                disk.diskdefragment(LogicalDrive1_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive2_RadioButton.Checked)
            {
                disk.diskdefragment(LogicalDrive2_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive3_RadioButton.Checked)
            {
                disk.diskdefragment(LogicalDrive3_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive4_RadioButton.Checked)
            {
                disk.diskdefragment(LogicalDrive4_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive5_RadioButton.Checked)
            {
                disk.diskdefragment(LogicalDrive5_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive6_RadioButton.Checked)
            {
                disk.diskdefragment(LogicalDrive6_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive7_RadioButton.Checked)
            {
                disk.diskdefragment(LogicalDrive7_RadioButton.Text.Replace("\\", ""));
            }
            else if (LogicalDrive8_RadioButton.Checked)
            {
                disk.diskdefragment(LogicalDrive8_RadioButton.Text.Replace("\\", ""));
            }
            #endregion
        }

        private void OpenDrive_button_Click(object sender, EventArgs e)
        {
            #region Open selected disk
            if (LogicalDrive1_RadioButton.Checked)
            {
                disk.OpenDrive(LogicalDrive1_RadioButton.Text);
            }
            else if (LogicalDrive2_RadioButton.Checked)
            {
                disk.OpenDrive(LogicalDrive2_RadioButton.Text);
            }
            else if (LogicalDrive3_RadioButton.Checked)
            {
                disk.OpenDrive(LogicalDrive3_RadioButton.Text);
            }
            else if (LogicalDrive4_RadioButton.Checked)
            {
                disk.OpenDrive(LogicalDrive4_RadioButton.Text);
            }
            else if (LogicalDrive5_RadioButton.Checked)
            {
                disk.OpenDrive(LogicalDrive5_RadioButton.Text);
            }
            else if (LogicalDrive6_RadioButton.Checked)
            {
                disk.OpenDrive(LogicalDrive6_RadioButton.Text);
            }
            else if (LogicalDrive7_RadioButton.Checked)
            {
                disk.OpenDrive(LogicalDrive7_RadioButton.Text);
            }
            else if (LogicalDrive8_RadioButton.Checked)
            {
                disk.OpenDrive(LogicalDrive8_RadioButton.Text);
            }
            #endregion
        }

        private void InfoRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
