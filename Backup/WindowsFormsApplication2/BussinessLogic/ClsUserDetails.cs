using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class ClsUserDetails
    {
        /*For Login Details*/
        public static string MUserName;
        public static string MUserGroup;
        public static string ComputerName;
        public static string UserGroupid;

        //public static long UserId;
        /****************************/

        public long UserId;
        public long Groupid;
        public int AStatus;
        public string UserName = "";
        public string Password = "";
        public string DataBaseNameStr = "";


        DBTask _Dbtask = new DBTask();
       // ClsCompanyCreate _Companycreate = new ClsCompanyCreate();
       // public  DataSet Ds=new DataSet();
        //DataSet Ds1 = new DataSet();
        RegistryKey regKey = Registry.CurrentUser;

        //public void CheckUser(string UserName, string Password)
        //{
        //    object[,] objArg = new object[2, 2]
        //    {
        //        {"@UserName",UserName},
        //         {"@Password",Password}
               
        //    };

        //  Ds1=  _Dbtask.ExecuteQuery_SP("CheckUser", objArg);
        //}
        public bool Permited()
        {
            MUserName = MUserName.ToLower();
            if (MUserName == "admin"||_Dbtask.ExecuteScalar("select ugroup from tbluserdetails where username='"+MUserName+"'")=="0")
            {
                return true;
            }
            MessageBox.Show("Not Permited User");
            return false;
        }
        public bool Permitedblock()
        {
            MUserName = MUserName.ToLower();
            if (MUserName == "admin" || _Dbtask.ExecuteScalar("select ugroup from tbluserdetails where username='" + MUserName + "'") == "0")
            {
                return true;
            }
           
            return false;
        }
        public void FillCombobyuser(ComboBox Cmb,string user)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "userid", "username", "tbluserdetails", "SELECT * FROM tbluserdetails where username='" + user + "' ");
        }
        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "userid", "username", "tbluserdetails", "SELECT * FROM tbluserdetails ");
        }

        public void InserUser()
        {
            object[,] objArg = new object[5, 2]
            {
            {"@Userid",UserId},    
            {"@UserName",UserName},
                 {"@uPassword",Password},
                 {"@ugroup",Groupid},
                 {"@astatus",AStatus}         
            };

            _Dbtask.ExecuteNonQuery_SP("InsertUserdetails", objArg);
        }
        public string GetSpecificfieldbyname(string user, string Field)
        {
            try
            {
                return _Dbtask.ExecuteScalar("select " + Field + " from tbluserdetails where  username='" + user + "'");
            }
            catch
            {
                return "";
            }
        }
        public long GetUserId()
        {
            UserId = Convert.ToInt64(Generalfunction.getnextid("userid", "tbluserdetails"));
            return UserId;
        }

        public void FillUser(ComboBox Comb)
        {
            _Dbtask.fillDatainCombowithQuery(Comb, "Userid", "UserName", "tbluserdetails", "select DISTINCT UserName from tbluserdetails");
            Comb.SelectedIndex = 0;
        }
       
    }
    
}
