using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsProductUnits
    {
        public string PCodeStr = "";
        public long UnitIdLng;
        public double PRate;
        public double SRate;
        public double MRP;
        DBTask _Dbtask = new DBTask();

        public void InsertproductUnits()
        {
            object[,] objArg = new object[5, 2]
        {
            {"@Pcode",PCodeStr},
            {"@Unitid",UnitIdLng},  
            {"@PRate",PRate},
            {"@SRate",SRate},
            {"@MRP",MRP}
        };
            _Dbtask.ExecuteNonQuery_SP("InsertProductunits", objArg);
            return;

        }
    }
}
