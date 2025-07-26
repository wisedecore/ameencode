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
    public partial class Frmf2 : Form
    {
        public Frmf2()
        {
            InitializeComponent();
        }
        DBTask _Dbtask = new DBTask();
        DataSet Ds;


        double salegd = 0;
        double SRGD = 0;
        double purgd = 0;

        double RECGD = 0;

        double PAYGD = 0;

        double openggad = 0;

        double closnggad = 0;
        double bank = 0;
        double FINALGDSALE = 0;
        double PRGD = 0;
        double FINALGDPURCHS = 0;





        private void Frmf2_Load(object sender, EventArgs e)
        {
            //Showcashcadjetinmain();
            cashgadgetnewversion();
            string todayy = System.DateTime.Now.ToString();
            txttodaydate.Text = todayy.ToString();
            CommonClass._Nextg.FormIcon(this);
        }

        //cashgadget newversion

        public void cashgadgetnewversion()
            {
            DateTime today = System.DateTime.Today;
            DateTime datenow = System.DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59); 
            //DateTime today = System.DateTime.Today;
            DateTime today2 = System.DateTime.Now;

            //sales
            //DateTime today = System.DateTime.Today;
            salegd = CommonClass._GenLedger.GADSALE(today2, today2);

            SRGD = CommonClass._GenLedger.GADSALERETURN(today2, today2);
            FINALGDSALE = salegd - SRGD;

            purgd = CommonClass._GenLedger.GADpurchs(today2, today2);
            PRGD = CommonClass._GenLedger.GADpurchsRETURN(today2, today2);
            FINALGDPURCHS = purgd - PRGD;


            RECGD = CommonClass._GenLedger.gadrecept(today2, today2);

            PAYGD = CommonClass._GenLedger.gadPAYMNT(today2, today2);

            closnggad = CommonClass._GenLedger.gadclosng(datenow);

            bank = CommonClass._GenLedger.gadbank(today2, today2);

            //closnggad = CommonClass._GenLedger.gadclosng(yestrdy);


            DateTime yestrdy = System.DateTime.Today.AddDays(-1);
                yestrdy = yestrdy.AddHours(23).AddMinutes(59).AddSeconds(59);
            openggad = CommonClass._GenLedger.gadclosng(yestrdy);
            double TOBANCE = closnggad - openggad;
            //openggad = CommonClass._GenLedger.gadopng(yestrdy);

            Pnlcashcadjet.Visible = true;
            cmdsale.Text = FINALGDSALE.ToString();
            cmdcashpurchaseamt.Text = FINALGDPURCHS.ToString();
            cmdreceiptamt.Text = RECGD.ToString();
            cmdpaymentamt.Text = PAYGD.ToString();
            cmdcashbalanceamt.Text = closnggad.ToString();
            cmdtodayscashbalanceamt.Text = TOBANCE.ToString();
            cmdbankamt.Text = bank.ToString();
            cmdopeningbalance.Text = openggad.ToString();

        }

        public void Showcashcadjetinmain()
        {
            double TCredit = 0;
            double  TDebit = 0;
            if (Pnlcashcadjet.Visible == false)
            {
                double TopeningBalance = 0;
                Pnlcashcadjet.Visible = true;
                TimeSpan timespan = new TimeSpan(DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes, DateTime.Now.TimeOfDay.Seconds);
                DateTime time = DateTime.Today.Add(timespan);
                string displayTime = time.ToString("hh:mm tt");
                cmdcadjetdescription.Text = DateTime.Now.ToString("dd/MM/yyyy") + "   " + displayTime;
                /*For Opening Balance*/
                //DateTime bnkdt =Convert.ToDateTime( DateTime.Now.ToString("mm/dd/yyyy"));

               ////bank
               // double bankdb1 = CommonClass._GenLedger.getsumofdbamtofbank(Convert.ToDateTime(time.ToString()));
               // double bankdb2 = CommonClass._GenLedger.getdbamtofother(Convert.ToDateTime(time.ToString()));
               // double bankcr1 = CommonClass._GenLedger.getsumofcramtofbank(Convert.ToDateTime(time.ToString()));
               // double bankcr2 = CommonClass._GenLedger.getsumofcramt(Convert.ToDateTime(time.ToString()));
               // double bankamount = (bankdb1 + bankdb2) - (bankcr1 + bankcr2);
               // bankamount = bankdb1 - bankcr1;

                //cmdbankamt.Text = bankamount.ToString();
                

                  
                //TopeningBalance = Convert.ToDouble(_Dbtask.ExecuteScalar("select sum(DbAmt)-sum(Cramt) From TblGeneralLedger Where Ledcode = 1 and vdate<'" + time.ToString("MM/dd/yyyy 00:00:00") + "'"));





               TopeningBalance = CommonClass._Gen.GetOpeningBalance("select * from tblgeneralledger where ledcode='1' and  vDate < '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "'", DateTime.Now);
                cmdopeningbalance.Text = _Dbtask.SetintoDecimalpoint(TopeningBalance);

                TCredit = 0;
                TDebit = 0;
                // double tempDbamt=

                Ds = _Dbtask.ExecuteQuery("select lid from tblaccountledger where agroupid=25");
                string Gids = "";
                Gids = "";
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    string temp = Ds.Tables[0].Rows[i]["lid"].ToString();
                    if (i != Ds.Tables[0].Rows.Count - 1)
                    {
                        Gids = Gids + temp + ",";
                    }
                    else
                    {
                        Gids = Gids + temp + ",";
                    }

                }
                if (Gids.Length > 0)
                {
                    Gids = Gids.Substring(0, Gids.Length - 1);
                    Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where ledcode in(" + Gids + ") and  vDate between '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DateTime.Now.ToString("MM/dd/yyyy 23:59:59") + "' order by vDate asc");

                    double TSalesamt = 0;
                    double TPurchaseAmt = 0;
                    double TRceiptAmt = 0;
                    double TPayment = 0;
                    double TSalesreturn = 0;
                    double Tpurchasereturn = 0;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        if (Generalfunction.BlShowEst == true || Generalfunction.BlShowEst==false)
                        {
                            TSalesamt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DateTime.Now.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='SI' "));
                            TSalesreturn = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DateTime.Now.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='SR' "));
                        }
                        else
                        {
                            string Estlid=CommonClass._Ledger.GetSpecificfieldBaseonName("Estimate","lid");
                            if (Estlid != "")
                            {
                                TSalesamt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DateTime.Now.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='SI' and refno !='" + Estlid + "'"));
                                TSalesreturn = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DateTime.Now.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='SR' and refno !='" + Estlid + "'"));
                            }
                        }

                        TPurchaseAmt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DateTime.Now.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='PI' "));
                        Tpurchasereturn = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DateTime.Now.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='PR' "));
                        TRceiptAmt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DateTime.Now.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='R' "));
                        TPayment = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DateTime.Now.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='P' "));
                        TSalesamt = TSalesamt - TSalesreturn;
                        TPurchaseAmt = TPurchaseAmt - Tpurchasereturn;
                    }


                    cmdsale.Text = _Dbtask.SetintoDecimalpoint(TSalesamt);
                    cmdcashpurchaseamt.Text = _Dbtask.SetintoDecimalpoint(TPurchaseAmt);
                    cmdreceiptamt.Text = _Dbtask.SetintoDecimalpoint(TRceiptAmt);
                    cmdpaymentamt.Text = _Dbtask.SetintoDecimalpoint(TPayment);

                    double Tdbbalance = TSalesamt + TRceiptAmt;
                    double Tcrbalance = TPurchaseAmt + TPayment;

                    double TodaysBalance = Tdbbalance - Tcrbalance;
                    double TBalance = TodaysBalance + TopeningBalance;

                    cmdtodayscashbalanceamt.Text = _Dbtask.SetintoDecimalpoint(TodaysBalance);
                    cmdcashbalanceamt.Text = _Dbtask.SetintoDecimalpoint(TBalance);
                }
            }
            else
            {
                Pnlcashcadjet.Visible = false;
            }

        }

        private void Frmf2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void cmsrefresh_Click(object sender, EventArgs e)
        {
            Showcashcadjetinmain();
        }

        private void Frmf2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void cmdcadjetdescription_Click(object sender, EventArgs e)
        {

        }
    }
}
