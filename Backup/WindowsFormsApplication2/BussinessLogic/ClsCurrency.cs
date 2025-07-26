using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsCurrency
    {
        public float CurrId;
        public string Code;
        public string Description;
        public string Currency;
        public string Change;

        DBTask _Dbtask = new DBTask();
        public DataSet Ds;

        public void InsertCurrency()
        {
            object[,] objArg = new object[5, 2]
            {
                {"@CId",CurrId},
                {"@code",Code},
                {"@description",Description},
                {"@currency",Currency},
                {"@change",Change}
            };
            _Dbtask.ExecuteNonQuery_SP("InsertCurrency", objArg);
            return;
        }

    }
}
