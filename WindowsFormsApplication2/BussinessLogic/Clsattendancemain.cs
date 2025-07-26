using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace WindowsFormsApplication2
{
    class Clsattendancemain
    {
        public float vno;
        public float amode;
        public DateTime adate;


        public void Insertattendancemain()
        {
            object[,] objArg = new object[3, 2]
            {
                {"@vno",vno},
                {"@amode",amode},
                {"@adate",adate}
            };
            CommonClass._Dbtask.ExecuteNonQuery_SP("Insertattendancemain", objArg);
            return;
        }

        public string Getvno()
        {
            return Generalfunction.getnextid("vno", "tblattendancemain");

        }

        public DataSet show(string where)
        {
            return CommonClass._Dbtask.ExecuteQuery("select * from tblattendancemain "+where+"");
        }
    }
}
