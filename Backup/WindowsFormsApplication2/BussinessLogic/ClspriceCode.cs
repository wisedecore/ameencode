using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClspriceCode
    {
        string Temp;
        public string Field;
        public string Code;
       
        public DataSet Ds;
        DBTask _Dbtask = new DBTask();
        Generalfunction _Gen = new Generalfunction();
        Clsselectreport _SelectReport = new Clsselectreport();

        public void InsertpriceCode()
        {
            object[,] objArg = new object[2, 2]
        {
              {"@field",Field},
              {"@code",Code}
            };
            _Dbtask.ExecuteNonQuery_SP("Insertpricecode", objArg);
            return;
        }

        public void Delete()
        {

            _Dbtask.ExecuteNonQuery("delete from tblpricecode");
        }
        public string RetriveCode(string SAmount)
        {
            return _Dbtask.ExecuteScalar("select code from tblpricecode where field='" + SAmount + "'");
        }

        public string GetCode(string Amount)
        {
            try
            {
                Temp = "";
                for (int i = 0; i < Amount.Length; i++)
                {
                    Temp = Temp + RetriveCode(Amount.Substring(i, 1));
                }
                Temp = RetriveCode("Pre") + Temp;
                return Temp;
            }
            catch
            {
                return "";
            }
        }
    }
}
