using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsunitsrates
    {
        public long Uid;
        public long Itemid ;
        public double Srate;
        public double Prate;
        public double Mrp;
        public double WRate=0;
        public double WRate1 = 0;
        public double Wrate2=0;
        public double Wrate3=0;


        public void InsertUnitsrates()
        {
            object[,] objArg = new object[9, 2]
          {
            {"@Uid",Uid},
            {"@itemid",Itemid},  
            {"@Srate",Srate},
            {"@prate",Prate},  
            {"@Mrp",Mrp},
            {"@Wrate",WRate},
            {"@Wrate1",WRate1},
            {"@Wrate2",Wrate2},
            {"@Wrate3",Wrate3}
          };
            CommonClass._Dbtask.ExecuteNonQuery_SP("Insertunitssrates", objArg);
            return;
        }

        public string SpecificField(string Itemid, string RateName,string Punit)
        {
            string Specific;
            Specific =CommonClass._Dbtask.ExecuteScalar("select " + RateName + " from tblunitsrates where itemid='" + Itemid + "' and Uid='"+Punit+"'");
            return Specific;
        }

    }
}
