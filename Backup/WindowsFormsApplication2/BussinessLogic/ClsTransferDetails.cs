using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsTransferDetails
    {
        public long TCode;
        public int Slno;
        public string Pcode = "";
        public string ItemDesc = "";
        public int Unitid = 0;
        public string Batchid;
        public int MultiRateid = 0;
        public double CF = 0;
        public double Qty = 0;
        public double Rate = 0;
        public string Comment = "";
        public int ShelfCode = 0;
        public int Dcode = 0;
        public string SupCode = "";

        
        
        DBTask _Dbtask = new DBTask();
        
        public void InsertTransferDetails()
        {

            object[,] objArg = new object[14, 2]
        {
            {"@Tcode",TCode},
            {"@Slno",Slno},  
            {"@Pcode",Pcode},
            {"@ItemDesc",ItemDesc},
            {"@UnitId",Unitid},
            {"@Batchid",Batchid},
            {"@MultiRateId",MultiRateid},  
            {"@CF",CF},
            {"@Qty",Qty},
            {"@Rate",Rate},
            {"@Comment",Comment},
            {"@ShelfCode",ShelfCode},
            {"@Dcode",Dcode},
            {"@Supcode",SupCode}

        };
            _Dbtask.ExecuteNonQuery_SP("InsertTransferDetails", objArg);
            return;
        }

        public void IdStockTransfer()
        {
            TCode = Convert.ToInt64(Generalfunction.getnextid("Tcode", "Tbltransferdetails"));
        }
    }
}
