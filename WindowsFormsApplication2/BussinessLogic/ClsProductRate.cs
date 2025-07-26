using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsproductRate
    {
        public string PCode = "";
        public long UnitId;
        public long RateId;
        public double Ratedb;
        public string Batchid;

        DBTask _Dbtask = new DBTask();
        public void InsertProductRate()
        {
            object[,] objArg = new object[5, 2]
        {
            {"@Pcode",PCode},
            {"@Unitid",UnitId},  
            {"@Rateid",RateId},
            {"@Rate",Ratedb},
            {"@batchid",Batchid},
        };
            _Dbtask.ExecuteNonQuery_SP("InsertProductrate", objArg);
            return;
        }

        public void UpdateField(string ItemId, double Rate, string Field,bool Batchenable,string Batchid,float PUnit)
        {
            if (Batchenable == true)
            {
                _Dbtask.ExecuteNonQuery("Update tblproductrate set " + Field + " =" + Rate + "  where pcode='" + ItemId + "' and batchid='" + Batchid + "' and Unitid="+PUnit+"");
            }
            else
            {
                _Dbtask.ExecuteNonQuery("Update tblproductrate set " + Field + " =" + Rate + "  where pcode='" + ItemId + "' and Unitid=" + PUnit + "");
            }
        }
    }
}
