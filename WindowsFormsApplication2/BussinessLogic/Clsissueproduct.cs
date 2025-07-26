using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clsissueproduct
    {

        DBTask _Dbtask = new DBTask();
        
        public long Vno;
        public long Employeeid;
        public DateTime Issuedate;
        public string Remarks;
        public int IStatus;
        public long Tvno;

        public DataSet Ds;

        public void Insertissueproduct()
        {
            object[,] ObjArg = new object[6, 2]
            {
            {"@vno",Vno},
            {"@employee",Employeeid},
            {"@issuedate",Issuedate},
            {"@remarks",Remarks},
             {"@istatus",IStatus},
             {"@Tvno",Tvno}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertissueproduct", ObjArg);
            return;
        }

        public long VnoIssueproduct()
        {
            Vno = Convert.ToInt64(Generalfunction.getnextid("vno", "tblissueproduct"));
            return Vno;
        }
        public DataSet Showissueproduct(string Where)
        {
            Ds=_Dbtask.ExecuteQuery("select vno as issueid,issuedate date,employee from tblissueproduct "+Where+" order by vno asc");
            return Ds;
        }
    }
}
