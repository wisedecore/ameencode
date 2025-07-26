using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Management;
using Microsoft.Win32;

namespace WindowsFormsApplication2
{
    class Clsregistration
    {
        public static bool IsRegistred;
        string sql;
        int Count;

        string CdKey;
        string Productid;
        string RegistratioNumber;
        string NewProductId;


        string RCdKey;
        string RProductid;
        string RRegistratioNumber;
        string RNewProductId;

        public static string PCdkey;
        public static string Pproductid;
        public static string Pregistrationno;
      


        RegistryKey regKey = Registry.CurrentUser;
       
        public string HardDiscNo()
        {

            return "HDD X29HC2BYT";
        }

        public string ReturnKey(string Key, string KeyParam)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM "+Key+"");
            ManagementObjectCollection moc = mos.Get();
            string Value = "";
            foreach (ManagementObject mo in moc)
            {
                Value = (string)mo[KeyParam];
            }
                return Value;
        }

        public string HraddiscModelNumber()
        {
            return ReturnKey("Win32_DiskDrive", "Model");
        }

        public string CPUSerialNumber()
        {
            return ReturnKey("Win32_Processor", "Processorid");
        }

        public string HarddiscFirmware()
        {
            return ReturnKey("Win32_DiskDrive", "FirmwareRevision");
        }

        public string MotherBoardId()
        {
            return ReturnKey("Win32_BaseBoard", "SerialNumber");
        }

        public void TableRefresh()
        {
            sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                       " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                       " SYSOBJECTS.NAME = 'tblregdetails'";
            string ttemp =CommonClass._Dbtask.ExecuteScalar(sql);
            if (ttemp == "0")
            {
                InsertTable();
            }
        }

        public void Checkisregistred()
        {
            try
            {
                string OrgRegNo;

                TableRefresh();


                //try
                //{
                //    regKey.DeleteValue("HKEY_CURRENT_USER\\Software\\32reg");
                //}
                //catch
                //{
                //}
                //= "regKey.Name";
                if (regKey.Name.ToString() != "HKEY_CURRENT_USER\\Software\\32reg")
                    regKey = regKey.CreateSubKey("Software\\32reg");

                RCdKey = regKey.GetValue("KC").ToString();
                RProductid = regKey.GetValue("IP").ToString();
                RRegistratioNumber = regKey.GetValue("NR").ToString();

                OrgRegNo = MD5HashGenerator.GenerateKey(RCdKey + RProductid);
                // RNewProductId = RCdKey + RProductid;
                //&&OrgRegNo==RNewProductId
                if (OrgRegNo == RRegistratioNumber)
                {
                    IsRegistred = true;
                }
                else
                {
                    IsRegistred = false;
                }


            }
            catch
            {
                IsRegistred = false;
            }
        }

        public void GetRegistrationdetails()
        {
            try
            {
                string OrgRegNo;

                TableRefresh();


              
                if (regKey.Name.ToString() != "HKEY_CURRENT_USER\\Software\\32reg")
                    regKey = regKey.CreateSubKey("Software\\32reg");

                PCdkey = regKey.GetValue("KC").ToString();
                Pproductid = regKey.GetValue("IP").ToString();
                Pregistrationno = regKey.GetValue("NR").ToString();

              

            }
            catch
            {
                
            }
        }

        public void InsertTable()
        {
             Count =Convert.ToInt16(CommonClass._Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                           " SYSOBJECTS.NAME = 'tblregdetails' "));
             if (Count == 0)
             {
                 sql = "CREATE TABLE [dbo].[tblregdetails](" +
                       "[Cdkey][nvarchar](50) NULL," +
                       "[ProductId][nvarchar](50) NULL," +
                       "[Regnumber][nvarchar](50) NULL)";
                 CommonClass._Dbtask.ExecuteNonQuery(sql);

                 sql = "create PROCEDURE [dbo].[InsertRegdetails]" +
                     "@Cdkey nvarchar(50)," +
                     "@ProductId nvarchar(50)," +
                     "@Regnumber nvarchar(50)" +
                     " AS" +
                     " BEGIN" +
                     " insert into tblregdetails(Cdkey,ProductId,Regnumber) values " +
                    " (@Cdkey,@ProductId,@Regnumber)" +
                     " END";
                 CommonClass._Dbtask.ExecuteNonQuery(sql);

          
       
             }

        }
    }
}
