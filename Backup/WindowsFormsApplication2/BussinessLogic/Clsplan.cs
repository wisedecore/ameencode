using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    class Clsplan
    {
        public long Id;
        public string Pname;
        public string Description="";

        DBTask _Dbtask = new DBTask();
        public DataSet Ds;

        public void Insertplan()
        {
            object[,] objArg = new object[3, 2]
            {
      
              {"@id",Id},
              {"@pname",Pname},  
              {"@description",Description}
            };
            _Dbtask.ExecuteNonQuery_SP("Insertplan", objArg);
            return;
        }
    }
}
