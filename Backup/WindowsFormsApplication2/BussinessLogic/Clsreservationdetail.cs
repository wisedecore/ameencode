using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsreservationdetail
    {
        public long resno;
        public long Slno;
        public long Customer;
        public long Roomcategory;
        public long Room;
        public double Rent = 0;

        DBTask _Dbtask = new DBTask();

        public void Insertreservationdetail()
        {
            object[,] objArg = new object[6, 2]
        {
            {"@resno",resno},
            {"@slno",Slno},  
            {"@customer",Customer},
            {"@roomcategory",Roomcategory},
            {"@room", Room},
            {"@rent",Rent}

        };
            _Dbtask.ExecuteNonQuery_SP("Insertreservationdetail", objArg);
            return;
        }
    }
}
