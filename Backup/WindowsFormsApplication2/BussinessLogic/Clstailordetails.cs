using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clstailordetails
    {
        public long vno;
        public string lid;
         public string length;
         public string chest;
         public string sleevL;
          public string Bottom;
          public string sholder;
         public string waist;
           public string neck;
          public string material;
          public string model; DBTask _Dbtask = new DBTask();
          public string color;
        public void Inserttaillordetails()
        {
            object[,] objArg = new object[12, 2]
            {
              {"@vno",vno},
              {"@lid",lid},  
              {"@length",length},
              {"@chest",chest},
              {"@bottom ",Bottom},  
              {"@sleevL",sleevL},
              {"@Sholder",sholder},
              {"@waist",waist},  
              {"@neck",neck},
              {"@material",material},
              {"@model",model},
              {"@color",color}
            
            };
            _Dbtask.ExecuteNonQuery_SP("Inserttaillordetails", objArg);
            return;
        }
    }
}
