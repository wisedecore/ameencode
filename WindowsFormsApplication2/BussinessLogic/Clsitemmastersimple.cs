using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsitemmastersimple
    {
       public long id;
       public long Itemid;
       public string Barcode;

        public void Insertsimpleitem()
        {
            object[,] objArg = new object[3, 2]
            {
              {"@id",id},
              {"@Itemid",Itemid},  
             {"@Barcode",Barcode}
            };
           CommonClass._Dbtask.ExecuteNonQuery_SP("Insertsimpleitem", objArg);
            return;
        }

        public string IdItemName()
        {
           return Generalfunction.getnextid("Id", "TblitemMastersimple");
        }
        public string Getspecificfield(string Filed,string PId)
        {
            return CommonClass._Dbtask.ExecuteScalar("select "+Filed+"  TblitemMastersimple where id='" + PId + "'");
        }
    }
}
