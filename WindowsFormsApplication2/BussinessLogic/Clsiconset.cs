using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsiconset
    {
        public long X;
        public long Y;
        public string ICONnAME = "";
        public long XvF;
        public long YvF;
        int Defaultt = 50;
        public string Footer = "";


        public void Inserticons()
        {
            object[,] objArg = new object[3, 2]
              {
                {"@xvalue",X},
                {"@yvalue",Y},
               {"@icon",ICONnAME }
              };
            CommonClass._Dbtask.ExecuteNonQuery_SP("Inserticon", objArg);
            return;
        }
        public void defaultvalues()
        {
            
           ICONnAME = "Header";
           X = Defaultt;
           Y = Defaultt;
           Inserticons();
           ICONnAME = "Footer";
           X = Defaultt;
           Y = Defaultt;
           Inserticons();
        }
    }
}
