using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clscheckindetails
    {
        public float Chekinno;
        public float Slno;
        public float Guest;
        public float Category;
        public float Room;
        public double Rent = 0;
        public double Discper = 0;
        public double Discount = 0;
        public double Luxurytax = 0;
        public double Servicetax = 0;
        public double Netamt = 0;
        DBTask _Dbtask = new DBTask();
        public void Insertchekindetails()
        {
            object[,] ObjArg = new object[11, 2]
            {
            {"@chekinno",Chekinno},
            {"@slno",Slno},
            {"@guest",Guest},  
            {"@category",Category},
            {"@room",Room},

            {"@rent",Rent},
            {"@discper",Discper},  
            {"@discount",Discount},
            {"@luxurytax",Luxurytax},
             {"@servicetax",Servicetax},
              {"@netamt",Netamt}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertcheckindetails", ObjArg);
            return;
        }
    }
}
