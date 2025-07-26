using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsAmc
    {

        public string Amccdkey = "";
        public string Amcproductid = "";
        public string Amcregnumber = "";


         public void insertAMCdetails()
        {
                object[,] objArg = new object[3, 2]
              {
                {"@Amccdkey",Amccdkey},
                {"@Amcproductid",Amcproductid},
                {"@Amcregnumber",Amcregnumber}
              };
                CommonClass._Dbtask.ExecuteNonQuery_SP("insertAMCdetails", objArg);
                return;
        }


        


    }
}
