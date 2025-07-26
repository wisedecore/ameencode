using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsinserttaillor
    {
        DBTask _Dbtask = new DBTask();
        
        public long vno;
        public string cname;
        public string ledcode;
        public string sleev;
        public string collor;
        public string bttntype;
        public string bttn;
       public DateTime delydate;
       public DateTime Arrdate;

        public void Inserttaillor()
        {
            object[,] objArg = new object[9, 2]
            {
              {"@Vno",vno},
              {"@Cname",cname},  
              {"@lid",ledcode},
              {"@sleev",sleev},
              {"@collor ",collor},  
              {"@bttntype",bttntype},
              {"@bttn",bttn},
              {"@Deldate",delydate},  
              {"@Ardate",Arrdate}
            
            };
            _Dbtask.ExecuteNonQuery_SP("Inserttaillor", objArg);
            return;
        }
    }
}
