using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clsproductsett
    {
        public long Id;
        public long Itemid;
        public double Mrate = 0;
        public string Bcode = "";

        DataSet Ds;
        DBTask _Dbtask = new DBTask();
        public void Insertproductsett()
        {
            object[,] ObjArg = new object[4, 2]
            {
            {"@id",Id},
            {"@item",Itemid},
            {"@mrate",Mrate},
            {"@Bcode",Bcode}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertproductsett", ObjArg);
            return;
        }
        public long Idproductsett()
        {
            Id = Convert.ToInt64(Generalfunction.getnextid("id", "tblproductsett"));
            return Id;
        }
    }
}
