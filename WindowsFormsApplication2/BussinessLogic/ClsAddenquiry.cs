using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing;
using Microsoft.Win32;

namespace WindowsFormsApplication2
{
    class ClsAddenquiry
    {
        public string temp;

        public long Vno;
        public string Name;
        public string Company;
        public string Address;
        public string Telephone;
        public string Mobile;
        public string City;
        public string State;
        public long CountryId;
        public string Email;
        public DateTime Date;
        public DateTime Time;
        public long EmpidLng;
        public string Enquiryabout;
        public string Response;
        public long StatusId;
        public string Remarks;
        public string Ptype;
        public string Product;
        public long Aid;
        public long LidLng;
        public long ItemIdLng;
        public string Description;
        public string Userfield1;
        public string Userfield2;
        public string Userfield3;
        public string Userfield4;
        public string Userfield5;
        public string ProductVno;
        public string VType;

        public string Lblnamechange;
        public static string lblChange = "";

        public static string SelLabelID;
        public string sql = "";
        
        DBTask _Dbtask = new DBTask();
        public DataSet Ds;

        public void InsertaddEnquiry()
        {
            object[,] ObjArg = new object[28, 2]
            {
                {"@enqvno" ,Vno},
                {"@Enqname", Name},
                {"@company",Company},
                {"@address",Address},
                {"@telephone",Telephone}, 
                {"@mobile",Mobile},
                {"@city",City},
                {"@state",State},
                {"@CId",CountryId},
                {"@email",Email},
                {"@enqdate",Date}, 
                {"@enqtime",Time}, 
                {"@Empid",EmpidLng},
                {"@enquiryabout",Enquiryabout}, 
                {"@response",Response}, 
                {"@status",StatusId},
                {"@remarks",Remarks}, 
                {"@Aid",Aid},
                {"@Lid",LidLng},
                {"@ItemId",ItemIdLng}, 
                {"@description",Description},
                {"@Userfld1",Userfield1},
                {"@Userfld2",Userfield2},
                {"@Userfld3",Userfield3},
                {"@Userfld4",Userfield4},
                {"@Userfld5",Userfield5},
                {"@ProductVno",ProductVno},
                {"@VType",VType}
            
            };
            _Dbtask.ExecuteNonQuery_SP("InsertEnquiry", ObjArg);
            return;
        }

        public void pnlLocation(Panel pnlCreate,int X,int Y)
        {
            pnlCreate.Show();
            pnlCreate.Location = new Point(X, Y);
        }

        public void LblLocation(Label lblName,TextBox txt,string Labelid)
        {
            txt.Location = lblName.Location;
            txt.Text = lblName.Text;
            txt.Visible = true;
            SelLabelID = Labelid;
            txt.Focus();
        }
        public void FillStatus(ComboBox Cmb, String Str)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "id", "Name", "Tblstatus", "select * from Tblstatus order by id ASC " + Str + ""); 
        }

        public void FillComboWhere(ComboBox Cmb, String Str)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "CId", "description", "TblCurrency", "select * from TblCurrency order by description ASC " + Str + "");
        }

        public void FillProduct(ComboBox Cmb, String Str)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "ItemId", "ItemName", "TblItemMaster", "select * from TblItemMaster " + Str + "");
        }

        public void FillEmployee(ComboBox Cmb, String Str)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "Empid", "EmpName", "TblEmployeemaster", "select * from TblEmployeemaster" + Str + "");
        }
        public void FillAgent(ComboBox Cmb, String Str)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "Lid", "LName", "TblAccountLedger", "select * from TblAccountLedger where AGroupId='29'" + Str + "");
        }

        public void Edit()
        {
 
        }

        public string Getspecificfield(string Field,string Vno)
        {
            temp = _Dbtask.ExecuteScalar("select "+Field+" FROM  Tbladdenquiry where enqvno='"+Vno+"'");
            return temp;
        }
        public long Nextid()
        {
            Vno = Convert.ToInt64(Generalfunction.getnextid("enqvno", "Tbladdenquiry"));
            return Vno; 
        }
        public long NextLid()
        {
            LidLng = Convert.ToInt64(Generalfunction.getnextid("Lid", "TblAccountLedger"));
            return LidLng;
        }
        public void Showstaus()
        {
            
        }

        public void Setstatus()
        {
            sql = "update Tbladdenquiry set status='1";
            _Dbtask.ExecuteQuery(sql);
        }
    }
}
