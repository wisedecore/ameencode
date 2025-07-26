using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsauditlog
    {
       public DateTime Mdate;
       public string UserId;
       public string Computername;
       public string Actiontype;
       public string Actiontype1;
       public string Mformname;
       public string Description;
       public string OldData="";
       public string NewData;

       DBTask _Dbtask = new DBTask();     
       public void InsertAuditlog()
       {
           
           object[,] objArg = new object[9, 2]
            {
                
                {"@Mdate",Mdate},
                {"@userid",UserId},
                {"@computername",Computername},
                {"@Actiontype",Actiontype},
                {"@Actiontype1",Actiontype1},
                {"@Description",Description},
                {"@mformname",Mformname},
                {"@olddata",OldData},
                {"@newdata",NewData}
            };
           _Dbtask.ExecuteNonQuery_SP("Insertauditlog", objArg);
           return;
       }

       public void PassLoginDetails(DateTime PVdate,string PUserId,string PComputerName,string PAction,string PDescription,string PMforname,string POldData,string PNewData)
       {
           Mdate=PVdate;
           UserId=PUserId;
           Computername=PComputerName;
           Actiontype="";
           Actiontype1 = PAction;
           Description=PDescription;
           Mformname=PMforname;
           OldData= POldData;
           NewData=PNewData;
          InsertAuditlog();
       }
       public void SaveNewAuditLog(string Action, string Discription, string FormName, string NewData, string OldData)
       {
           if (Action == "NEW")
           {
               OldData = "";
           }
           else if (Action == "DELETE")
           {
               NewData = "";
           }
           PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, Action, Discription, FormName, OldData, NewData);
       }

       public string OldDataCreate()
       {
           return "";
       }

       public string NewDataCreate()
       {
           return "";
       }
    }
}
