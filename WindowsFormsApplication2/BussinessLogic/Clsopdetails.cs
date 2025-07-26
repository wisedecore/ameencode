using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsopdetails
    {
        public long opno;
        public long Serviceitem;
        public double Qty;
        public double Rate;
        public double Amount;
     
        DBTask _Dbtask = new DBTask();
        public void InsertOpdetails()
        {
            object[,] ObjArg = new object[5, 2]
            {
            {"@opno",opno},
            {"@serviceitem",Serviceitem},
            {"@Qty",Qty},  
            {"@Rate",Rate},
            {"@Amount",Amount}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertopdetails", ObjArg);
            return;
        }
    }
}
