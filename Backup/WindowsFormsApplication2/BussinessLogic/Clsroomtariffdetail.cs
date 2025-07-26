using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class Clsroomtariffdetail
    {
        public long thariffid;
        public long Slno;
        public long Roomcategory;
        public double tariff=0;

        DBTask _Dbtask = new DBTask();
        public DataSet Ds;

        public void Insertroomtariffdetail()
        {
            object[,] objArg = new object[4, 2]
            {
      
              {"@thariffid",thariffid},
              {"@slno",Slno},  
              {"@roomcategory",Roomcategory},
              {"@tariff",tariff}
            };
            _Dbtask.ExecuteNonQuery_SP("Insertroomtariffdetail", objArg);
            return;
        }
    }
}
