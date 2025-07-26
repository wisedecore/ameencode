using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clschekin
    {

        public long Vno;
        public DateTime Chekindate;
        public DateTime Chekintime;
        public DateTime Chekoutdate;
        public DateTime Chekouttime;
        public long Employee;
        public string Purpose;
        public string Reservationno;
        public long Agent;
        public long Tariff;
        public long Splan;
        public string Arivvalfrom;
        public string Departto;
        public string Advance;
        public int Status;/*For '-1' Chikin '0' Checkout*/
        public int Post;

        DBTask _Dbtask = new DBTask();


        public void InsertChekin()
        {
            object[,] ObjArg = new object[15, 2]
            {
            {"@vno",Vno},
            {"@checkindate",Chekindate},
            {"@checkintime",Chekintime},  
            {"@checkoutdate",Chekoutdate},
            {"@checkouttime",Chekouttime},

            {"@staff",Employee},
            {"@purpose",Purpose},  
            {"@reservationon",Reservationno},
            {"@agent",Agent},

            {"@tariff",Tariff},
            {"@splan",Splan},  
            {"@arrivalfrom",Arivvalfrom},
            {"@departto",Departto},

            {"@advance",Advance},
            {"@status",Status}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertcheckin", ObjArg);
            return;
        }
    }
}
