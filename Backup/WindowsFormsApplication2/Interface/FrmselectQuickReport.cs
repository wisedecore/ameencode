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
    public partial class FrmselectQuickReport : Form
    {
        public FrmselectQuickReport()
        {
            InitializeComponent();
        }
        ClsAccountLedger _Ledger = new ClsAccountLedger();
        NextGFuntion _Nextg = new NextGFuntion();
        public DataSet Ds;
        DBTask _Dbtask = new DBTask();
         FrmReport _Report = new FrmReport();
         public int Countrow;
         public int selectedRow;
         public bool IsEnter = false;

        private void FrmselectQuickReport_Load(object sender, EventArgs e)
        {
          TxtAccount.Focus();
          _Nextg.FormStylesett(this);
         // _Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
          //_Nextg.FormHeadStyle(pnlHead);
          //_Nextg.FormImage(pnlImage);
          ChangeLanguage();
          CommonClass._Nextg.FormIcon(this);

        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
            }
        }
        public void Showledger()
        {
            if (IsEnter == false)
            {

                GridAccount.Rows.Clear();
                GridAccount.Visible = true;
                //this.Size = new System.Drawing.Size(401, 236);
                Ds = _Ledger.ShowLedger(" where lname like N'%" + TxtAccount.Text + "%' or phone like N'%" + TxtAccount.Text + "%' or mobile like '%" + TxtAccount.Text + "%' or address like '%" + TxtAccount.Text + "%'");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    GridAccount.Rows.Add(1);
                    GridAccount.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["lname"];
                    GridAccount.Rows[i].Cells[1].Value = Ds.Tables[0].Rows[i]["mobile"];
                    GridAccount.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["lid"];
                }
               Countrow= GridAccount.Rows.Add(1);
               GridAccount.Rows[Countrow].Cells[0].Value = "Stock Ledger";
               GridAccount.Rows[Countrow].Cells[0].Value = "Cheque Details";
            }
            }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }
        public void NextgInitialize()
        {
            DateTime fromDate = DateTime.Now.AddMonths(-1);
            DateTime toDate = DateTime.Now;
            _Report.DTFrom = fromDate;
            _Report.DTTo = toDate;
            FrmReport.Lbl2 = TxtAccount.Text;

            if (TxtAccount.Text == "Stock Ledger")
            {
                CommonClass._report.ReportType = "Stock Value";
                _Report.Query = "select * from tblitemmaster where status=1 order by  categoryid asc";
            }
            else if (TxtAccount.Text == "Cheque Details")
            {
                CommonClass._report.ReportType = "Cheque Details";
                
            }
            else
            {
                CommonClass._report.ReportType = "AccountReport";
                _Report.Query = "select * from tblgeneralledger  where ledcode='" + TxtAccount.Tag + "' ";
                _Report.QueryTemp = "select * from tblaccountledger where lid='" + TxtAccount.Tag + "'";
            }

            Clsselectreport.RType = CommonClass._report.ReportType;
            Clsselectreport.RQuery = _Report.Query;
            Clsselectreport.RQueryTemp = _Report.QueryTemp;
            Clsselectreport.RQueryDetail = _Report.QueryDetail;
            Clsselectreport.RDtfrom = _Report.DTFrom;
            Clsselectreport.Rdtto = _Report.DTTo;
            CommonClass._Clreport.ShowReport(this,true);
        }
        private bool ValidationFu()
        {
            return true;
        }
       
        public void ShowReport()
        {
            NextgInitialize(); 
        }
        
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    // NextgInitialize();
                    ShowReport();

                    return true;

                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void TxtAccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (GridAccount.Rows.Count > 1)
                {

                    selectedRow = GridAccount.SelectedRows[0].Index;
                    // Lblpartybalance.Visible = true;
                    if (e.KeyValue == 40 && GridAccount.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (GridAccount.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            GridAccount.Rows[selectedRow + 1].Selected = true;
                            GridAccount.Rows[selectedRow].Selected = false;
                            GridAccount.CurrentCell = GridAccount.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        GridAccount.Rows[selectedRow - 1].Selected = true;
                        GridAccount.Rows[selectedRow].Selected = false;
                        GridAccount.CurrentCell = GridAccount.SelectedRows[0].Cells[0];
                    }
                    if (e.KeyValue == 13)
                    {
                        IsEnter = true;
                        TxtAccount.Text = GridAccount.Rows[selectedRow].Cells[0].Value.ToString();
                        TxtAccount.Tag = GridAccount.Rows[selectedRow].Cells[0].Tag;
                        IsEnter = false;
                        Main();
                    }
                }
            }
            catch
            {
            }
        }

        private void TxtAccount_TextChanged(object sender, EventArgs e)
        {
            Showledger();
        }

        private void FrmselectQuickReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void FrmselectQuickReport_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117)
                Main();
        }
    }
}
