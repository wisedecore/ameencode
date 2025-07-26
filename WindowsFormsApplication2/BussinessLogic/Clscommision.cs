using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clscommision
    {

        public long Cid;
        public string Cname = "";
        public double Cperc;
        public double Cfromamount;
        public double Ctoamount;
        public string Cfor;


        public void InsertCommision()
        {
          object[,] objArg = new object[6, 2]
          {
            {"@Cid",Cid},
            {"@Cname",Cname},  
            {"@Cperc",Cperc},
            {"@Cfromamount",Cfromamount},  
            {"@Ctoamount",Ctoamount},
            {"@Cfor",Cfor}
          };
          CommonClass._Dbtask.ExecuteNonQuery_SP("Insertcommision", objArg);
            return;
        }

        public string RetriveCommisionperc(string amount,string Cfor)
        {
            return CommonClass._Dbtask.ExecuteScalar("select isnull(sum(cperc),0)  from tblcommision where " + amount + ">=cfromamount and " + amount + " <=ctoamount");
        }

        public DataSet Showcommision(string Where)
        {
            return CommonClass._Dbtask.ExecuteQuery("select *  from tblcommision "+Where+"");
        }
    }
}
