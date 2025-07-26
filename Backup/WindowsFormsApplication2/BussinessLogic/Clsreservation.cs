using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    class Clsreservation
    {
        public long Resno;
        public DateTime Reservationdate;
        public DateTime Rtime;
        public long Employee;
        public long Agent;
        public string Purpose;
        public string Reservationmode;
        public string Contactperson;
        public string Contactno;
        public long Tariff;
        public long Rplan;
        public DateTime Chekindate;
        public DateTime Chekintime;
        public DateTime Chekoutdate;
        public DateTime Chekouttime;

        DataSet Ds = new DataSet();

        DBTask _Dbtask = new DBTask();




        public void Insertreservation()
        {
            object[,] objArg = new object[15, 2]
        {
            {"@resno",Resno},
            {"@reservationdate",Reservationdate},  
            {"@rtime",Rtime},
            {"@employee",Employee},
            {"@agent", Agent},
            {"@purpose",Purpose},  
            {"@reservationmode",Reservationmode},    
            {"@contactperson",Contactperson},
            {"@contactno",Contactno},  
            {"@tariff",Tariff},
            {"@rplan",Rplan},
            {"@chekindate",Chekindate},  
            {"@chekintime",Chekintime},
            {"@chekoutdate",Chekoutdate},
            {"@chekouttime",Chekouttime}

        };
            _Dbtask.ExecuteNonQuery_SP("Insertreservation", objArg);
            return;
        }
    }
}
