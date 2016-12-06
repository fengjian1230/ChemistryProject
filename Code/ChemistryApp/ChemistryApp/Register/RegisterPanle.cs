using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ChemistryApp.Register
{
    class RegisterPanle : Panel
    {
        MainForm mianForm;
        /// <summary>
        /// 获取到主form
        /// </summary>
        /// <param name="main"></param>
        public RegisterPanle(MainForm main)
        {
            this.mianForm = main;
        }

        ///<summary>  
        /// 获取硬盘卷标号  
        ///</summary>  
        ///<returns></returns>  
        public string GetDiskVolumeSerialNumber()
        {
            ManagementClass mc = new ManagementClass("win32_NetworkAdapterConfiguration");
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
            disk.Get();
            return disk.GetPropertyValue("VolumeSerialNumber").ToString();
        }

        ///<summary>  
        /// 获取CPU序列号  
        ///</summary>  
        ///<returns></returns>  
        public string GetCpu()
        {
            string strCpu = null;
            ManagementClass myCpu = new ManagementClass("win32_Processor");
            ManagementObjectCollection myCpuCollection = myCpu.GetInstances();
            foreach (ManagementObject myObject in myCpuCollection)
            {
                strCpu = myObject.Properties["Processorid"].Value.ToString();
            }
            return strCpu;
        }

        ///<summary>  
        /// 生成机器码  
        ///</summary>  
        ///<returns></returns>  
        public string GetMNum()
        {
            string strNum = GetCpu() + GetDiskVolumeSerialNumber();
            string strMNum = strNum.Substring(0, 24);    //截取前24位作为机器码  
            return strMNum;
        }

        public int[] intCode = new int[127];    //存储密钥  
        public char[] charCode = new char[25];  //存储ASCII码  
        public int[] intNumber = new int[25];   //存储ASCII码值  

        //初始化密钥  
        public void SetIntCode()
        {
            for (int i = 1; i < intCode.Length; i++)
            {
                intCode[i] = i % 9;
            }
        }

        ///<summary>  
        /// 生成注册码  
        ///</summary>  
        ///<returns></returns>  
        public string GetRNum()
        {
            SetIntCode();
            string strMNum = GetMNum();
            for (int i = 1; i < charCode.Length; i++)   //存储机器码  
            {
                charCode[i] = Convert.ToChar(strMNum.Substring(i - 1, 1));
            }
            for (int j = 1; j < intNumber.Length; j++)  //改变ASCII码值  
            {
                intNumber[j] = Convert.ToInt32(charCode[j]) + intCode[Convert.ToInt32(charCode[j])];
            }
            string strAsciiName = "";   //注册码  
            for (int k = 1; k < intNumber.Length; k++)  //生成注册码  
            {

                if ((intNumber[k] >= 48 && intNumber[k] <= 57) || (intNumber[k] >= 65 && intNumber[k]
                    <= 90) || (intNumber[k] >= 97 && intNumber[k] <= 122))  //判断如果在0-9、A-Z、a-z之间  
                {
                    strAsciiName += Convert.ToChar(intNumber[k]).ToString();
                }
                else if (intNumber[k] > 122)  //判断如果大于z  
                {
                    strAsciiName += Convert.ToChar(intNumber[k] - 10).ToString();
                }
                else
                {
                    strAsciiName += Convert.ToChar(intNumber[k] - 9).ToString();
                }
            }
            return strAsciiName;
        }

        /// 窗体加载  
        ///</summary>  
        ///<param name="sender"></param>  
        ///<param name="e"></param>  
        public void IsRegister()
        {
            //判断软件是否注册  
            RegistryKey retkey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true).CreateSubKey("wxf").CreateSubKey("wxf.INI");
            foreach (string strRNum in retkey.GetSubKeyNames())
            {
                if (strRNum == this.GetRNum())
                {
                    MessageBox.Show("已经注册!");
                    return;
                }
            }
            MessageBox.Show("您现在使用的是试用版，可以免费试用30次！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Int32 tLong;
            try
            {

                tLong = (Int32)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\MySoft", "UseTimes", 0);
                MessageBox.Show("您已经使用了" + tLong + "次！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("欢迎使用本软件！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\MySoft", "UseTimes", 0, RegistryValueKind.DWord);
            }
            tLong = (Int32)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\MySoft", "UseTimes", 0);
            if (tLong < 30)
            {
                int tTimes = tLong + 0;
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\MySoft", "UseTimes", tTimes);
            }
            else
            {
                DialogResult result = MessageBox.Show("试用期限已到！如果需要继续使用请联系管理员！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mianForm.MainPanel.Visible = false;
            }
        }

        /// <summary>
        /// 注册进注册表
        /// </summary>
        public void RegisterInRegisterTable()
        {
            try
            {
                RegistryKey retkey = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("wxf").CreateSubKey("wxf.INI").CreateSubKey(this.GetRNum());
                retkey.SetValue("UserName", "Rsoft");
                this.mianForm.MainPanel.Visible = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}