using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Data;
namespace WindowsFormsApplication2
{
    class Clsregdetails
    {
       public string CdKey;
       public string ProductId;
       public string Regnumber;

       DataSet Ds;

       RegistryKey regKey = Registry.CurrentUser;
       public void InsertTable()
       {
           object[,] ObjArg = new object[3, 2]
            {
            {"@CdKey",CdKey},
            {"@ProductId",ProductId},
            {"@Regnumber",Regnumber}
        };
           CommonClass._Dbtask.ExecuteNonQuery_SP("InsertRegdetails", ObjArg);
           return;
       }

      

       public void InsertRegdetails()
        {
            InsertTable();

            regKey = regKey.CreateSubKey("Software\\32reg");
            regKey.SetValue("KC", CdKey);
            regKey.SetValue("IP", ProductId);
            regKey.SetValue("NR", Regnumber); 
        }

       

    }
}
