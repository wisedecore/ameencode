using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Clswarnings
    {
        public static string CreditLimit;
        public static string MinusCash;
        public static string SalerateLessLastrate;

        public bool CheckCreditLimit(string Lid,double SecondAmt)
        {
            double CreditLimtAmount =Convert.ToDouble(CommonClass._Ledger.GetspecifField("creditlimit", Lid));
            double LedgerCurrentBalance =Convert.ToDouble(Convert.ToString(CommonClass._Ledger.Balanceofledger(Lid)));
            CreditLimit = CommonClass._Paramlist.GetParamvalue("CreditLimit");
            LedgerCurrentBalance = LedgerCurrentBalance + SecondAmt;

            if (CreditLimtAmount > 0 && CreditLimit != null)
            {
                if (CreditLimtAmount < LedgerCurrentBalance)
                {
                    if (CreditLimit.ToLower() == "allow")
                    {
                        return true;
                    }
                    if (CreditLimit.ToLower() == "warn")
                    {
                        MessageBox.Show("Credit Limit Exceeds", "Zshope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                    if (CreditLimit.ToLower() == "block")
                    {
                        MessageBox.Show("Credit Limit Exceeds So Not Access", "Zshope", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CommonClass._commenevent.CheckinAdminUser("creditlimit",false);
                        return FrmCheckinuser.RetriveType;
                    }
                }
                else
                {
                    double   BalanceAmount = LedgerCurrentBalance * 100 / CreditLimtAmount;
                    if (BalanceAmount >= 75)
                    {
                        BalanceAmount = CreditLimtAmount - LedgerCurrentBalance;
                        MessageBox.Show("Credit Limit Balance Amount =" + BalanceAmount + "", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            return true;
        }


        public bool CheckMinusStock(string ItemId,double SecondStock,string Pwhere)
        {
            CreditLimit = CommonClass._Sales.CreditLimit;//_Paramlist.GetParamvalue("WNstock");


            if (CreditLimit != null && CreditLimit != "" && CreditLimit.ToLower() != "allow")
            {
                double NowStock = CommonClass._Inventory.GetStock(Pwhere);
                double StockCurrentBalance = NowStock - SecondStock;
                if (StockCurrentBalance <= 0)
                {
                    if (CreditLimit.ToLower() == "allow")
                    {
                        return true;
                    }
                    if (CreditLimit.ToLower() == "warn")
                    {
                        MessageBox.Show("Minus Stock", "Zshope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                    if (CreditLimit.ToLower() == "block")
                    {
                        MessageBox.Show("Minus Stock", "Zshope", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                
            }
            return true;
        }

        public bool CheckSrateLessthanLastrate(string PBarcode,double PassingRate)
        {

            SalerateLessLastrate = frmsalesinvoice.SalerateLessLastrate;//_Paramlist.GetParamvalue("LR<SR");


            if (SalerateLessLastrate.ToLower() != "" && SalerateLessLastrate.ToLower() != null && SalerateLessLastrate.ToLower() != "allow")
            {
                double Strlastrate = CommonClass._Dbtask.znullDouble(CommonClass._Batch.GetSpecificFieldByBarcode("Lastrate", PBarcode));
                if (PassingRate != 0 && Strlastrate > PassingRate)
                   {

                if (SalerateLessLastrate.ToLower() == "allow")
                    {
                        return true;
                    }
                if (SalerateLessLastrate.ToLower() == "warn")
                    {
                        MessageBox.Show("Sale Rate Less than LastRate", "Zshope", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                if (SalerateLessLastrate.ToLower() == "block")
                    {
                        MessageBox.Show("Sale Rate Less than LastRate", "Zshope", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
               

            }
            return true;
        }
    }
}
