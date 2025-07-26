using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsissueproductdetail
    {
        DBTask _Dbtask = new DBTask();

        public long Issueid;
        public long Slno;
        public long Itemid;
        public double Qty;
        public double Rate;
        public string Bcode="";

        public void Insertissueproductdetail()
        {
            object[,] ObjArg = new object[6, 2]
            {
            {"@issueid",Issueid},
            {"@slno",Slno},
            {"@item",Itemid},
            {"@qty",Qty},
            {"@rate",Rate},
            {"@Bcode",Bcode}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertissueproductdetail", ObjArg);
            return;
        }
    }
}
