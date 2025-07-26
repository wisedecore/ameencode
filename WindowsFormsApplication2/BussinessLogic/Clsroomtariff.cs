using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class Clsroomtariff
    {
        public long Id;
        public string Tname;
        public long Season;
        public DateTime Tfrom;
        public DateTime Tto;
        public string Narration="";

        DBTask _Dbtask = new DBTask();
        public DataSet Ds;

        public void Insertroomtariff()
        {
            object[,] objArg = new object[6, 2]
            {
      
              {"@id",Id},
              {"@tname",Tname},  
              {"@season",Season},
              {"@tfrom",Tfrom},
              {"@tto",Tto},
              {"@narration",Narration}
             
         
            };
            _Dbtask.ExecuteNonQuery_SP("Insertroomtariff", objArg);
            return;
        }

    }
}
