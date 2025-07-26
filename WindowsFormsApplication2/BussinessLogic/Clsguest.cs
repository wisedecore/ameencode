using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace WindowsFormsApplication2
{
    class Clsguest
    {
        public long LidLng;
        public string LNameStr = "";
        public string LAliasNameStr = "";
        public string Address1Str;
        public string Address2Str = "";
        public string City = "";
        public string Phone = "";
        public string Email="";
        public string Age = "";
        public string Ttype = "";
        public string Nationality = "";
        public string Purpose="";
        public int Gender;
        public double Creditlimit = 0;
        public string Bloodgroup = "";
        public string Visano = "";
        public DateTime Visaexpiry;
        public string Bankaccountno="";
        public int Mstatus;
        public string Familydetail="";
        public long Foodtype;
        public string Note="";
        public int Lstatus = -1;
      //  public string Prooflink="";
        public string Noteofproof="";

       // public SqlDbType GuestImage;
        
       // public string ProofImage;
        DBTask _Dbtask = new DBTask();
        public DataSet Ds;
        public void UpdatestatusofGuest(string Lstatus, string Lid)
        {
            _Dbtask.ExecuteNonQuery("update tblguest set lstatus='" + Lstatus + "' where lid='" + Lid + "'");
        }
        public void UpdateGuestStatus(string RoomId, string Status)
        {
            _Dbtask.ExecuteNonQuery("update tblroom set status='" + Status + "' where id in (" + RoomId + ")");
        }
        public DataSet ShowGuest(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblguest "+Where+"");
            return Ds;
        }
        public string GetSpecificFiled(string FiledName,string Lid)
        {
            string Temp = _Dbtask.ExecuteScalar("select " + FiledName + " from tblguest where lid='" + Lid + "'");
            return Temp;
        }
        public void Insertguest()
        {
            object[,] objArg = new object[24, 2]
            {
      
              {"@Lid",LidLng},
              {"@Lname",LNameStr},  
              {"@AliasName",LAliasNameStr},
              {"@address1",Address1Str},
              {"@address2",Address2Str},
              {"@city",City},
              {"@phone",Phone},
              {"@email",Email},
              {"@age",Age},
              {"@ttype",Ttype},
              {"@nationality",Nationality},
              {"@purpose",Purpose},
              {"@gender",Gender},
              {"@creditlimit",Creditlimit},
              {"@bloodgroup",Bloodgroup}, 
            {"@visano",Visano},
            {"@visaexpiry",Visaexpiry},
              {"@bankaccountno",Bankaccountno}, 
            {"@mstatus",Mstatus},
             {"@familydetails",Familydetail}, 
            {"@foodtype",Foodtype},
             {"@note",Note}, 
             {"@noteofproof",Noteofproof},
             {"@lstatus",Lstatus}
         
            };
            _Dbtask.ExecuteNonQuery_SP("Insertguest", objArg);
            return;
        }
    }
}
