using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clsdiscount
    {
        public long Did;
        public string Dname = "";
        public double Dperc;
        public double Dfromamount;
        public double Dtoamount;


        public void InsertDiscount()
        {
            object[,] objArg = new object[5, 2]
          {
            {"@Did",Did},
            {"@Dname",Dname},  
            {"@Dperc",Dperc},
            {"@Dfromamount",Dfromamount},  
            {"@Dtoamount",Dtoamount}
          };
            CommonClass._Dbtask.ExecuteNonQuery_SP("Insertdiscount", objArg);
            return;
        }

        public string RetriveDiscountperc(string amount, string Cfor)
        {
            return CommonClass._Dbtask.ExecuteScalar("select isnull(sum(Dperc),0)  from tbldiscount where " + amount + ">=dfromamount and " + amount + " <=dtoamount");
        }

        public DataSet Showdiscount(string Where)
        {
            return CommonClass._Dbtask.ExecuteQuery("select *  from tbldiscount " + Where + "");
        }
    }
}
