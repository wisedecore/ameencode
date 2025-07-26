using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FrmCashDesk : Form
    {
        public FrmCashDesk()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)
            {
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                   
                                        SendKeys.Send("{Tab}");
                                        return true;
                                 
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
     
        public   double TAmount;
        public bool Lkmodepayment;
        public static double TCashdiscount;
        public static int Modepayment;
        public static string Lid;
        public static double TCash;
        public double Total;
        public static bool twotypepaymnt = false;
        public static double Otherpayamt=0;
        public static string secndpaymode = "";
        public static double Balance;

        public bool IsArabic;

        public void DetectLanguage()
        {
            string lng = CommonClass._Paramlist.GetParamvalue("Language");
            if (lng == "Arabic")
            {
                IsArabic = true;
            }
            else
            {
                IsArabic = false;
            }
        }
        public void ChangeLanguage()
        {
            DetectLanguage();
            if (IsArabic == true)
            {
                CommonClass._Language.FormBasedConversion(this);
                //CommonClass._Language.PanelBasedConversion(pnlcommon);
                //CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.PanelBasedConversion(panel5);
                //CommonClass._Language.PanelBasedConversion(PnlPrintOptions);
            }
        }

        public void TotalAmountCalculate()
        {

            
                
            TAmount=CommonClass._Dbtask.znullDouble(txtamount.Text);
            TCashdiscount = CommonClass._Dbtask.znullDouble(Txtdiscount.Text);
            TCash = CommonClass._Dbtask.znullDouble(txtcashreceived.Text);
            Otherpayamt =CommonClass._Dbtask.znullDouble( txtsecndmodeamt.Text);
            Total = TCash;
            Balance = (TAmount)- (Otherpayamt + Total);
            Balance = Balance - TCashdiscount;
            txttotal.Text = CommonClass._Dbtask.SetintoDecimalpoint(Total);
            txtbalance.Text = CommonClass._Dbtask.SetintoDecimalpoint(Balance);

        }
        public void Clear()
                            {
                                
            ChangeLanguage();
            txtamount.Text = CommonClass._Dbtask.SetintoDecimalpoint(TAmount);

            if (FrmCashDesk.Otherpayamt > 0)
            {
                txtsecndmodeamt.Text = CommonClass._Dbtask.znllString(FrmCashDesk.Otherpayamt);
            }
        
            Txtdiscount.Text = CommonClass._Dbtask.SetintoDecimalpoint(TCashdiscount);
            Commodeofpayment.SelectedIndex = Modepayment;
            double cashtt = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select RecvdAmt from tblgeneralledger where vno='" + frmsalesinvoice.svno.ToString() + "' and vtype='si' and ledcode='" + Lid + "'"));
            TCash = CommonClass._Dbtask.znlldoubletoobject(cashtt);
            txtcashreceived.Text = TCash.ToString();
            if (Modepayment == 1)
            {
                Lkmodepayment = true;
                Commodeofpayment.Enabled = false;
            }
            else
            {
                Lkmodepayment = false;
            }
            TxtAccount.Tag = Lid;
            TxtAccount.Text = CommonClass._Ledger.GetspecifField("lname", Lid);
            twopayactive();
            
            TotalAmountCalculate();
            txtcashreceived.Select();
            txtcashreceived.Focus();
            
            


        }
        public void twopayactive()
                {
            if (Otherpayamt> 0)
            {
            //if (frmsalesinvoice.twotypepaymnt == true)
            //{
                twotypepaymnt = true;
                chktwotypepaymnt.Checked = true;
                txtsecndmodeamt.Text = CommonClass._Dbtask.znllString(Otherpayamt);
                combotwotypemode.SelectedIndex = Convert.ToInt32(secndpaymode);
           
            
            }
            else
            {
                chktwotypepaymnt.Checked = true;
                Otherpayamt = 0; twotypepaymnt = false;
                txtsecndmodeamt.Text = CommonClass._Dbtask.znllString(Otherpayamt);
                combotwotypemode.SelectedIndex = 2;
            
            }
        }

        private void FrmCashDesk_Load(object sender, EventArgs e)
                            {
            Clear();
        }

        private void txtcashreceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        public void Main()
            {
            TCash = CommonClass._Dbtask.znullDouble(txtcashreceived.Text);
            Balance = CommonClass._Dbtask.znullDouble(txtbalance.Text);
            TCashdiscount = CommonClass._Dbtask.znullDouble(Txtdiscount.Text);
            
            Otherpayamt = 0;
            Otherpayamt = CommonClass._Dbtask.znullDouble(txtsecndmodeamt.Text);
            secndpaymode = CommonClass._Dbtask.znllString(combotwotypemode.SelectedIndex);
           
            Modepayment = Commodeofpayment.SelectedIndex;
            Lid =CommonClass._Dbtask.znllString(TxtAccount.Tag);
            CommonClass.CashDesk = "Cash Received =" + TCash.ToString("0.00") + ", Balance =" + Balance.ToString("0.00") + "";
            CommonClass.CashDeskValidate = true;
            this.Close();
        }
        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void txtcashreceived_TextChanged(object sender, EventArgs e)
        {
            TotalAmountCalculate();
        }

        private void FrmCashDesk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
            if (e.KeyValue == 27)
            {
                CloseForm();
            }
        }
        public void CloseForm()
        {
            CommonClass.CashDesk = "";
            CommonClass.CashDeskValidate = false;
            this.Close();
        }
        private void FrmCashDesk_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
        }

        private void Txtdiscount_TextChanged(object sender, EventArgs e)
        {
            TotalAmountCalculate();
        }

        private void FrmCashDesk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117&&Lkmodepayment==false)
            {
                if (Commodeofpayment.SelectedIndex == 0)
                {
                    Commodeofpayment.SelectedIndex = 2;
                }
                else
                {
                    Commodeofpayment.SelectedIndex = 0;
                }
            }
        }

        private void Commodeofpayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Commodeofpayment.SelectedIndex == 0)
            //{
            //    TxtAccount.Tag = 1;
               
            //}
            //else if (Commodeofpayment.SelectedIndex == 1)
            //{
            //    if (TxtAccount.Text == "")
            //    {
            //        TxtAccount.Tag = null;
            //    }
            //    else
            //    {
            //        string temp =CommonClass._Dbtask.ExecuteScalar("select lid from tblaccountledger where lname =N'" + TxtAccount.Text + "'");
            //        TxtAccount.Tag = temp;
            //    }
            //}
            //else if (Commodeofpayment.SelectedIndex == 2)
            //{
            //    string temp = CommonClass._Dbtask.ExecuteScalar("select lid from tblaccountledger where UseCard=1");
            //    if (temp == "")
            //    {
            //        TxtAccount.Tag = "28";
            //        TxtAccount.Text = "BANK";
            //    }
            //    else
            //    {
            //        TxtAccount.Tag = temp;
            //        TxtAccount.Text = CommonClass._Ledger.GetspecifField("lname", temp);
            //    }
            //    Gridcustomerlist.Visible = false;
            //}
        }

        private void chktwotypepaymnt_CheckedChanged(object sender, EventArgs e)
                            {
            if (chktwotypepaymnt.Checked == true)
            {
                txtsecndmodeamt.Visible = true;
                lbltwotypemode.Visible = true;
                combotwotypemode.Visible = true;
                twotypepaymnt = true;
                frmsalesinvoice.twotypepaymnt = true;
                twopayactive();
            }
            else
            {
                txtsecndmodeamt.Visible = false;
                lbltwotypemode.Visible = false;
                combotwotypemode.Visible = false;
                twotypepaymnt = false;
                Otherpayamt = 0;
                twopayactive();
            }
        }

        private void txtsecndmodeamt_TextChanged(object sender, EventArgs e)
        {
            TotalAmountCalculate();
        }
       
    }
}
