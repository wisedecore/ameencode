using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Clstax
    {
        public static double ZeroPercTaxAmount;
        public static double OnePercTaxAmount;
        public static double TwoPercTaxAmount;
        public static double FivePercTaxAmount;
        public static double TwelPerceTaxAmount;
        public static double ForteenPerceTaxAmount;
        public static double TwenteenPerceTaxAmount;

        public static double ZeroPercTaxableAmount;
        public static double OnePercTaxableAmount;
        public static double TwoPercTaxableAmount;
        public static double FivePercTaxableAmount;
        public static double TwelPerceTaxableAmount;
        public static double ForteenPerceTaxableAmount;
        public static double TwenteenPerceTaxableAmount;

        DBTask _Dbtask = new DBTask();
        public void TaxDeclare(DataGridView gridmain, DataGridViewColumn clntax)
        {
            ClearAmount();
            for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
            {
                if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
                {
                    if (clntax.Visible == true)
                    {
                        double Taxperc = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clntaxper"].Value);
                        double TaxAmount = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clntax"].Value);
                        double TaxableAmount = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnGross"].Value);
                        if (Taxperc == 0)
                        {
                            ZeroPercTaxAmount = ZeroPercTaxAmount + TaxAmount;
                            ZeroPercTaxableAmount = ZeroPercTaxableAmount + TaxableAmount;
                        }

                        if (Taxperc == 1)
                        {
                            OnePercTaxAmount = OnePercTaxAmount + TaxAmount;
                            OnePercTaxableAmount = OnePercTaxableAmount + TaxableAmount;
                        }

                        if (Taxperc == 2)
                        {
                            TwoPercTaxAmount = TwoPercTaxAmount + TaxAmount;
                            TwoPercTaxableAmount = TwoPercTaxableAmount + TaxableAmount;
                        }

                        if (Taxperc == 5)
                        {
                            FivePercTaxAmount = FivePercTaxAmount + TaxAmount;
                            FivePercTaxableAmount = FivePercTaxableAmount + TaxableAmount;
                        }

                        if (Taxperc == 12.5)
                        {
                            TwelPerceTaxAmount = TwelPerceTaxAmount + TaxAmount;
                            TwelPerceTaxableAmount = TwelPerceTaxableAmount + TaxableAmount;
                        }

                        if (Taxperc == 14.5)
                        {
                            ForteenPerceTaxAmount = ForteenPerceTaxAmount + TaxAmount;
                            ForteenPerceTaxableAmount = ForteenPerceTaxableAmount + TaxableAmount;
                        }

                        if (Taxperc == 20)
                        {
                            TwenteenPerceTaxAmount = TwenteenPerceTaxAmount + TaxAmount;
                            TwenteenPerceTaxableAmount = TwenteenPerceTaxableAmount + TaxableAmount;
                        }
                    }
                }
            }
        }
        public void ClearAmount()
        {
                ZeroPercTaxAmount = 0;    
                OnePercTaxAmount =0;
                TwoPercTaxAmount = 0;
                FivePercTaxAmount = 0;
                TwelPerceTaxAmount = 0;
                ForteenPerceTaxAmount = 0;
                TwenteenPerceTaxAmount = 0;

                ZeroPercTaxableAmount=0;
                OnePercTaxableAmount=0;
                TwoPercTaxableAmount=0;
                FivePercTaxableAmount=0;
                TwelPerceTaxableAmount=0;
                ForteenPerceTaxableAmount=0;
                TwenteenPerceTaxableAmount=0;
        }
            
    }
}
