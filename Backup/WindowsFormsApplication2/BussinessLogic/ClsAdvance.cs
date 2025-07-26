using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsAdvance
    {
        public double OpNo;
        public double Weight;
        public double Height;
        public double Standingbp;
        public double Heartrate;
        public double Temperature;
        public double BMI;
        public double Respiration;
        public string Residenceinfo;
        public string Note;

        //DataSet Ds = new DataSet();
        DBTask _Dbtask = new DBTask();
        
        public void InsertAdvance()
        {
            object[,] ObjArg = new object[10, 2]
            {
            {"OpNo",OpNo},
            {"@Weight",Weight},
            {"@Height",Height},
            {"@Standingbp",Standingbp},  
            {"@Heartrate",Heartrate},
            {"@Temperature",Temperature},
            {"@BMI",BMI},
            {"@Respiration",Respiration},
            {"@Residenceinfo",Residenceinfo},
            {"@Note",Note},
            
        };
            _Dbtask.ExecuteNonQuery_SP("InsertAdvance", ObjArg);
            return;
        }
    }
}
