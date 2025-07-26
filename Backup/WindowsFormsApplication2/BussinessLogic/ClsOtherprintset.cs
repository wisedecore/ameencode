using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsOtherprintset
    {
        public int sts = 1;
        public string OPname = "";
        DBTask _dbtask = new DBTask();

        public void insertOtherprintsets()
        {
            object[,] objArg = new object[2, 2]
              {
                {"@OPname",OPname},
                {"@OPstatus",sts}
               
              };
            CommonClass._Dbtask.ExecuteNonQuery_SP("insertOtherprintsets", objArg);
            return;
        }

        public string getstatusprinting(string head)
        {
            string print="";
            print =_dbtask.znllString( _dbtask.ExecuteScalar("select OPstatus from TblOtherprintsets where OPname='" + head + "'"));

            if (print=="")
            {
                print = "0";
            }
            
            return print;
        }

        public void defaultvalsetotherprint()
        {
            OPname = "Opencash"; sts = 1; insertOtherprintsets();
            OPname = "Tot.purchase"; sts = 1; insertOtherprintsets();
            OPname = "cash.purchase"; sts = 1; insertOtherprintsets();
            OPname = "credit"; sts = 1; insertOtherprintsets();
            OPname = "Pr"; sts = 1; insertOtherprintsets();
            OPname = "Tot.Sale"; sts = 1; insertOtherprintsets();
            OPname = "Tot.cardamtbysale"; sts = 1; insertOtherprintsets();
            OPname = "Tot.cashamtbysale"; sts = 1; insertOtherprintsets();
            OPname = "Totservice"; sts = 1; insertOtherprintsets();
            OPname = "Tot.mechine"; sts = 1; insertOtherprintsets();
            OPname = "Tot.card"; sts = 1; insertOtherprintsets();
            OPname = "Tot.visa/mada/master"; sts = 1; insertOtherprintsets();
            OPname = "Tot.cashSale"; sts = 1; insertOtherprintsets();
            OPname = "Salecredit"; sts = 1; insertOtherprintsets();
            OPname = "SR"; sts = 1; insertOtherprintsets();
            OPname = "paymenttax"; sts = 1; insertOtherprintsets();
            OPname = "Tot.saletax"; sts = 1; insertOtherprintsets();
            OPname = "Tot.SRtax"; sts = 1; insertOtherprintsets();
            OPname = "Tot.purchasetax"; sts = 1; insertOtherprintsets();
            OPname = "Tot.PRtax"; sts = 1; insertOtherprintsets();
            OPname = "Tax(get-paid)"; sts = 1; insertOtherprintsets();
            OPname = "Tot.grsssale"; sts = 1; insertOtherprintsets();
            OPname = "Tot.grsspurchase"; sts = 1; insertOtherprintsets();
            OPname = "Tot.(pur-sale)"; sts = 1; insertOtherprintsets();
            OPname = "payment"; sts = 1; insertOtherprintsets();
            OPname = "receipt"; sts = 1; insertOtherprintsets();
            OPname = "bankblnce"; sts = 1; insertOtherprintsets();
            OPname = "tot.cashBalnce"; sts = 1; insertOtherprintsets();
            OPname = "TransactnBalnce"; sts = 1; insertOtherprintsets();
            OPname = "Bank-cash"; sts = 1; insertOtherprintsets();
            OPname = "cash-bank"; sts = 1; insertOtherprintsets();
            OPname = "Customer reamins"; sts = 1; insertOtherprintsets();
            OPname = "Supplier reamins"; sts = 1; insertOtherprintsets();
            OPname = "SalesTax-PurchaseTax"; sts = 1; insertOtherprintsets();
            
            OPname = "OpeningBank"; sts = 1; insertOtherprintsets();
            OPname = "cash&bankAMT"; sts = 1; insertOtherprintsets();
            OPname = "Category"; sts = 1; insertOtherprintsets();
           




        }



    }
}
