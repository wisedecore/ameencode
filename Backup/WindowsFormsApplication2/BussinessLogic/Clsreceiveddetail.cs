using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsreceiveddetail
    {
        DBTask _Dbtask = new DBTask();

        public long Id;
        public long Slno;
        public long Itemid;
        public double Qty;
        public double Rate;
        public string Bcode;
        public void Insertreceivedproductdetail()
        {
            object[,] ObjArg = new object[6, 2]
            {
            {"@id",Id},
            {"@slno",Slno},
            {"@item",Itemid},
            {"@qty",Qty},
            {"@rate",Rate},
            {"@Bcode",Bcode}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertreceivedproductdetail", ObjArg);
            return;
        }
    }
}
