using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsop
    {
        public long opno;
        public DateTime Opdate;
        public DateTime Optime;
        public long staffid;
        public long Doctor;
        public long Patientid;
        public string OpNote;
        public double RAmount;
        public long Gno;
        public int Gender;
        public double Age;

        DBTask _Dbtask = new DBTask();
        public void InsertOp()
        {
            object[,] ObjArg = new object[11, 2]
            {
            {"@opno",opno},
            {"@opdate",Opdate},
            {"@optime",Optime},  
            {"@staffid",staffid},
            {"@Doctor",Doctor},
             {"@Patient",Patientid},
            {"@opnote",OpNote},
            {"@ramount",RAmount},
            {"@Gno",Gno},
             {"@gender",Gender},
            {"@age",Age}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertop", ObjArg);
            return;
        }

        public string IdOp()
        {
            string VnoStr = Generalfunction.getnextid("opno", "tblop");
            return VnoStr;
        }
    }
}
