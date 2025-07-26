using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clstempcontact
    {
       public  long tid;
       public string tname="";
       public string tmobile="";
       public string taddress="";
       public string tarea = "";
       public string temail="";

        public void Inserttempcontact()
        {
            object[,] ObjArg = new object[6, 2]
            {
            {"@tid",tid},
            {"@tname",tname},
            {"@tmobile",tmobile},  
            {"@taddress",taddress},
            {"@area",tarea},
            {"@temail",temail}
        };
           CommonClass._Dbtask.ExecuteNonQuery_SP("Inserttempcontact", ObjArg);
            return;
        }
        public DataSet ShowSpecifcFiled(string Field, string Where)
        {
            CommonClass.Ds =CommonClass._Dbtask.ExecuteQuery("select DISTINCT " + Field + " from tbltempcontact " + Where + "");
            return CommonClass.Ds;
        }
        public DataSet ShowContactList(string Where)
        {
           CommonClass.Ds=  CommonClass._Dbtask.ExecuteQuery("select tid as Slno,tname as Name,tmobile as Mobile,taddress as Address,temail as Email,Area "+
           " from tbltempcontact "+Where+"");
           return CommonClass.Ds;
        }
    }
}
