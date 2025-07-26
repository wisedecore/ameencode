using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class Clsroom
    {
        public long Id;
        public string Rname;
        public long Category;
        public string Facilities = "";
        public int Status;

        DBTask _Dbtask = new DBTask();
        public DataSet Ds;

        public void Insertroom()
        {
            object[,] objArg = new object[5, 2]
            {
      
              {"@id",Id},
              {"@gname",Category},  
              {"@category",Category},
              {"@facilities",Facilities},
              {"@status",Status}
             
         
            };
            _Dbtask.ExecuteNonQuery_SP("Insertroom", objArg);
            return;
        }
    }
}
