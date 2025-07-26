using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clsattendancedetail
    {
        public float vno;
        public float slno;
        public float lid;
        public int amark=1;
        public int ovmark = 1;
        public double salary = 0;
        public double extra = 0;
        public double extra2 = 0;
        public string note="";

        /*tblattendancedetail*/
        public void Insertattendancedetail()
        {
            object[,] objArg = new object[9, 2]
            {
                {"@vno",vno},
                {"@slno",slno},
                {"@lid",lid},
                {"@amark",amark},
                {"@salary",salary},
                {"@extra",extra},
                {"@ovmark",ovmark},
                {"@extra2",extra2},
                {"@note",note}
            };
            CommonClass._Dbtask.ExecuteNonQuery_SP("Insertattendancedetail", objArg);
            return;
        }

        public DataSet show(string where)
        {
            return CommonClass._Dbtask.ExecuteQuery("select * from tblattendancedetail " + where + "");
        }
    }
}
