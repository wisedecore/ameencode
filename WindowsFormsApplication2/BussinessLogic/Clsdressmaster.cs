using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsdressmaster
    {
        public long Vno;
        public long Customer;
        public DateTime Vdate;
        public DateTime Ddate;
        public double Chest;
        public double Waist;
        public double Neck;
        public double Height;
        public double Shapping;
        public long Itemid;
        public double Qty;
        public double Rate;
        public int Delivery;
        public double Adamount;

        public double Length;
        public double Loose;
        public double Sholder;
        public double SholderL;
        public double SholderW;
        public double NeckF;
        public double NeckB;
        public double PantL;
        public double PantW;
        public string Pant;
             

        public void Insertdressmaster()
        {
            object[,] objArg = new object[24, 2]
            {
              {"@vno",Vno},
              {"@customer",Customer},  
              {"@vdate",Vdate},
              {"@ddate",Ddate},
              {"@Chest",Chest},
              {"@waist",Waist},
              {"@neck",Neck},
              {"@height",Height},
              {"@shapping",Shapping},

              {"@Length",Length},
              {"@Loose",Loose},
              {"@sholder",Sholder},
              {"@sholderL",SholderL},
              {"@sholderw",SholderW},

              {"@NeckF",NeckF},
              {"@NeckB",NeckB},
              {"@pantL",PantL},
              {"@pantW",PantW},
              {"@pant",Pant},

              {"@itemid",Itemid},
              {"@qty",Qty},
              {"@rate",Rate},
              {"@Dl",Delivery},
             {"@adamount",Adamount}
            };
           CommonClass._Dbtask.ExecuteNonQuery_SP("Insertdressmaster", objArg);
            return;
        }

        public string Getid()
        {
            return Generalfunction.getnextid("vno", "Tbldressmaster");
        }

        public void Delete(string PVno)
        {
        CommonClass._Dbtask.ExecuteNonQuery("delete from tbldressmaster where vno='"+PVno+"'");
        }
    }
}
