using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsreceivedproduct
    {
        DBTask _Dbtask = new DBTask();

        public long Issueid;
        public long Id;
        public DateTime Recdate;
        public long Itemid;
        public double Qty;
        public long Bvno;
        public long Gvno;

        public void Insertreceivedproduct()
        {
            object[,] ObjArg = new object[7, 2]
            {
            {"@issueid",Issueid},
            {"@id",Id},
            {"@recdate",Recdate},
            {"@item",Itemid},
             {"@qty",Qty},
              {"@Bvno",Bvno},
              {"@gvno",Gvno}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertreceivedproduct", ObjArg);
            return;
        }

        public long VnoReceivedproduct()
        {
            Id = Convert.ToInt64(Generalfunction.getnextid("id", "tblreceivedproduct"));
            return Id;
        }
    
    }
}
