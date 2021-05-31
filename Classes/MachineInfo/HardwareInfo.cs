using System;
using System.Management;
/* AdminCon 3.0 Command Line Interface Edition - 源代码 - HardwareInfo.cs
 * 主要功能：打印硬件SSID。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition
{
    class HardwareInfo
    {
        #region Get CPU Serial Number
        //获取CPU序列号
        private string GetCPUSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Processor");
                string sCPUSerialNumber = "";
                foreach (ManagementObject MGMT_OBJ in searcher.Get())
                {
                    sCPUSerialNumber = MGMT_OBJ["ProcessorId"].ToString().Trim();
                    break;
                }
                return sCPUSerialNumber;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Get Motherboard Serial Number
        //获取主板序列号
        private string GetBIOSSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_BIOS");
                string sBIOSSerialNumber = "";
                foreach (ManagementObject MGMT_OBJ in searcher.Get())
                {
                    sBIOSSerialNumber = MGMT_OBJ.GetPropertyValue("SerialNumber").ToString().Trim();
                    break;
                }
                return sBIOSSerialNumber;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Get Harddrive Serial Number
        //获取硬盘序列号
        private string GetHardDiskSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                string sHardDiskSerialNumber = "";
                foreach (ManagementObject MGMT_OBJ in searcher.Get())
                {
                    sHardDiskSerialNumber = MGMT_OBJ["SerialNumber"].ToString().Trim();
                    break;
                }
                return sHardDiskSerialNumber;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Get MAC Address
        //获取网卡MAC地址
        private string GetNetCardMACAddress()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE ((MACAddress Is Not NULL) AND (Manufacturer <> 'Microsoft'))");
                string NetCardMACAddress = "";
                foreach (ManagementObject MGMT_OBJ in searcher.Get())
                {
                    NetCardMACAddress = MGMT_OBJ["MACAddress"].ToString().Trim();
                    break;
                }
                return NetCardMACAddress;
            }
            catch
            {
                return "";
            }
        }
        #endregion
        public void printHardwareInfo() //打印硬件序列号
        {
            Console.WriteLine("\n\nAdditional Hardware information:\n");
            Console.WriteLine("\n||   BIOS Serial Number: " +          GetBIOSSerialNumber());
            Console.WriteLine("\n||   CPU Serial Number: " +           GetCPUSerialNumber());
            Console.WriteLine("\n||   Localdisk Serial Number: " +     GetHardDiskSerialNumber());
            Console.WriteLine("\n||   MAC Address: " +                 GetNetCardMACAddress());
        }
    }
}
//Program Entry @ Program.cs