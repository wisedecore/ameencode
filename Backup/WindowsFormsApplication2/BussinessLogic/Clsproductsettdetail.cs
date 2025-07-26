using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clsproductsettdetail
    {
        DBTask _Dbtask = new DBTask();

        public long Id;
        public long Slno;
        public long Itemid;
        public double Qty;
        public double Rate;
        public string Bcode;
        public void Insertproductsettdetail()
        {
            object[,] ObjArg = new object[6, 2]
            {
            {"@id",Id},
            {"@slno",Slno},
            {"@Bcode",Bcode},
            {"@item",Itemid},
            {"@qty",Qty},
             {"@rate",Rate}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertproductsettdetail", ObjArg);
            return;
        }
    }
}
