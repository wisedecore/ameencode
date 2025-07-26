using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clssizes
    {
        public long Sid;
        public string Sname;
        public string Sremarks;

        public DataSet Ds;

        DBTask _Dbtask = new DBTask();

        public void Insertsizes()
        {
            object[,] ObjArg = new object[3, 2]
            {
            {"@sid",Sid},
            {"@sname",Sname},
            {"@sremarks",Sremarks}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertsizes", ObjArg);
            return;
        }
        public DataSet ShowSizes()
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblsizes");
            return Ds;
        }
        public string IdSizes()
        {
            Sid = Convert.ToInt64(Generalfunction.getnextid("sid", "tblsizes"));
            return Sid.ToString();
        }
    }
}
