using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class Clsroomgroup
    {
        public long Id;
        public string Gname ;
        public string Remarks = "";
        public double Luxurytax = 0;
        public double Servicetax = 0;

        DBTask _Dbtask = new DBTask();
        public DataSet Ds;

        public void Insertroomgroup()
        {
            object[,] objArg = new object[5, 2]
            {
      
              {"@id",Id},
              {"@gname",Gname},  
              {"@remarks",Remarks},
              {"@luxurytax",Luxurytax},
              {"@servicetax",Servicetax}
             
         
            };
            _Dbtask.ExecuteNonQuery_SP("Insertroomgroup", objArg);
            return;
        }
    }
}
