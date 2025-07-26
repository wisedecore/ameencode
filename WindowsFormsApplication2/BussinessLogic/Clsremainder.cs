using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clsremainder
    {
        public long LngRId;
        public string StrRName;
        public string StrRsubject;
        public DateTime Dtrdate;
        public int Rstatus=-1;

        public void InsertRemainder()
        {
            object[,] objArg = new object[5, 2]
            {
              {"@Rid",LngRId},
              {"@Rname",StrRName},  
              {"@Rsubject",StrRsubject},
              {"@Rdate",Dtrdate},
              {"@Rstatus",Rstatus},
            };
           CommonClass._Dbtask.ExecuteNonQuery_SP("InsertRemainder", objArg);
            return;
        }

        public string Getid()
        {
         return   Generalfunction.getnextid("rid", "tblremainder");
        }

        public DataSet ShowRemainder( string Where)
        {
         return CommonClass._Dbtask.ExecuteQuery("select * from tblremainder "+Where+"");
        }
    }
}
