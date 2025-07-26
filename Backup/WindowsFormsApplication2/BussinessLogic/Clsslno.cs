using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace WindowsFormsApplication2
{
    class Clsslno
    {
        public long Itemid;
        public string Slno;
        public string Vtype;
        public string Vno;
        public int Slstatus;
        public string Temp;
        public void InsertSlno()
        {
            object[,] objArg = new object[5, 2]
            {
              {"@itemid",Itemid},
              {"@slno",Slno},  
              {"@vtype",Vtype},
              {"@vno",Vno},
              {"@slstatus",Slstatus}
            };
           CommonClass._Dbtask.ExecuteNonQuery_SP("Insertslnotracking", objArg);
            return;
        }

        public DataSet ShowSlno(string Where)
        {
           return CommonClass._Dbtask.ExecuteQuery("select * from tblslnotracking "+Where+" ");
        }
       
        public void InsertSlnopara(string PItemid, string PSlno, string PVtype, string PVno, int PSstatus)
        {
            Itemid =Convert.ToInt64(PItemid);
            Vtype = PVtype;
            Vno = PVno;
            Slstatus = PSstatus;
            for (int i = 0; i < PSlno.Length; i++)
            {
                if (PSlno.Substring(i, 1) != ",")
                {
                    Temp = Temp + PSlno.Substring(i, 1);
                }
                else
                {
                    if (Temp != "")
                    {
                        Slno = Temp;
                        InsertSlno();
                    }
                    Temp = "";
                }

            }
            if (Temp != "" || Temp != ",")
            {
                Slno = Temp;
                InsertSlno();
            }
        }

    }
}
