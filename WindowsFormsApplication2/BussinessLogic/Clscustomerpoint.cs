using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Clscustomerpoint
    {

        /*For Calculating Functions*/
        public double Amount;
        /**********************************/
        DBTask _Dbtask = new DBTask();
        ClsGeneralLedger _GenLedger = new ClsGeneralLedger();
        public long Cpid;
        public string CardName;
        public DateTime ValidFrom;
        public DateTime ValidTo;
        public double SalesValue;
        public double Point;
        public double Discount;

        public double Custpoint;

        public void InsertCustomerPoint()
        {
            object[,] ObjArg = new object[7, 2]
            {
            {"@cpid",Cpid},
            {"@cardname",CardName},
            {"@validfrom",ValidFrom},
            {"@validto",ValidTo},
            {"@salevalue",SalesValue},
            {"@point",Point},
            {"@discount",Discount},
        };
            _Dbtask.ExecuteNonQuery_SP("Insertcustomerpoint", ObjArg);
            return;
        }
        
        public void FillCustomerpoint(ComboBox Cmb)
        {
            _Dbtask.fillDatainCombowithQuery(Cmb, "cpid", "cardname", "tblcustomerpoint", "select * from tblcustomerpoint");
        }

        public double CalcCustomerBalance(string Custid,double CurentSale)
        {
            string CustomercardNo = _Dbtask.ExecuteScalar("select laliasname from tblaccountledger where lid='" + Custid + "'");
            string CuPlan = _Dbtask.ExecuteScalar("select cplan from tblaccountledger where lid='" + Custid + "'");
            Amount = _GenLedger.TottalAmountOfType("dbamt", "SI", " where ledcode='" + Custid + "'");
            return Amount;
        }
        public double AmountPerPoint(string Planid)
        {
            double SaleVale = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select salevalue from tblcustomerpoint where cpid='"+Planid+"'"));
            return SaleVale;
        }
        public double DiscountPerPoint(string Planid)
        {
            double Discount = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select discount from tblcustomerpoint where cpid='" + Planid + "'"));
            return Discount;
        }
        public void IdCustomerPoint()
        {
            Cpid = Convert.ToInt64(Generalfunction.getnextid("cpid", "tblcustomerpoint"));
        }
        public double EffectedDiscount(double Amt,string Cusid)
        {
            return Amount;
        }
    }
}