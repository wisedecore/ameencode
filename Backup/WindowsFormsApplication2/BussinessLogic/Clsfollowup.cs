using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsfollowup
    {
        public string cusid = "";
        public string cusname="";
        public string cusmob = "";
        public string cusaddress = "";
        public string custype = "";
        DBTask _Dbtask = new DBTask();
        public void Insertfollowup()
        {

            object[,] objArg = new object[5, 2]
        {
            {"@cusid",cusid},
            {"@cusname",cusname},  
            {"@cusmob",cusmob},
            {"@cusaddress",cusaddress},
            {"@custype",custype}
             
        };
            _Dbtask.ExecuteNonQuery_SP("Insertfollowup", objArg);
            return;
        }
    }
}
