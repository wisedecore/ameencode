using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class Clsseason
    {
        public long Id;
        public string Sname;
        public DateTime Startdate;
        public DateTime Enddate;

        DBTask _Dbtask = new DBTask();
        public DataSet Ds;

        public void Insertseason()
        {
            object[,] objArg = new object[4, 2]
            {
      
              {"@id",Id},
              {"@sname",Sname},  
              {"@startdate",Startdate},
              {"@enddate",Enddate}
            };
            _Dbtask.ExecuteNonQuery_SP("Insertseason", objArg);
            return;
        }
    }
}
