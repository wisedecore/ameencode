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
    public partial class Frmselectpurchasereportnew : Form
    {
        public Frmselectpurchasereportnew()
        {
            InitializeComponent();
        }
        string Selectednode;
        int SeleRow;
        int Count;
        string Id;
        string Reporttype;
        string Vtype;
        string Where;
        DataSet Ds;
        DBTask _dbtask = new DBTask();
        public static bool SBATCH = false;
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.PanelBasedConversion(Pnlbottom);
                CommonClass._Language.TabBasedConversion(Tabnormal);
                CommonClass._Language.TabBasedConversion(tabsupplierwise);
                CommonClass._Language.TabBasedConversion(Tabitemwise);
                CommonClass._Language.TabBasedConversion(Tabitemcategorywise);
                CommonClass._Language.TabBasedConversion(Tabmanufacturerwise);
                CommonClass._Language.TabBasedConversion(Tabarea);
                CommonClass._Language.TabBasedConversion(tabmainpurchase);
                CommonClass._Language.TabBasedConversion(tabpurchasetax);
                
            }
        }
        private void Frmselectpurchasereportnew_Load(object sender, EventArgs e)
        {
            Clear();
            ClsInGrid.WGmitemcode = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemcode"));

            ClsInGrid.WGmitemname = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemname"));
            ClsInGrid.WGmsrate = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmsrate"));
            ClsInGrid.WGmmrp = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmmrp"));
            ClsInGrid.WGmrack = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmrack"));
            ClsInGrid.WGmprate = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmprate"));
            ClsInGrid.WGmbcode = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmbcode"));
            if (CommonClass._Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
            {
                SBATCH = true;
            }
            else
            {
                SBATCH = false;
            }

        }

        public void Clear()
        {
           CommonClass._ItemCategory.FillCombo(comcategory,false);
           CommonClass._Manufacturer.FillCombo(Commanufacturer);
           CommonClass._Area.FillArea(Comarea);
           DtFrom.Value = CommonClass._Gen.FuFromdateReportdef();
           DtTo.Value = CommonClass._Gen.FuTodateReportdef();
            ShowAllvoucher();
            chkvtype.Checked = true;
            comvtype.SelectedIndex = 0;
            commodeofpayment.SelectedIndex = 0;
            Selectednode = "Normal";



            ChangeLanguage();
        }

        public void ShowAllvoucher()
        {
            GridVtype.Rows.Clear();
            Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=26 and lid !=18 and lid!=25");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Count = GridVtype.Rows.Add(1);
                Name = Ds.Tables[0].Rows[i]["lname"].ToString();
                Id = Ds.Tables[0].Rows[i]["lid"].ToString();
                GridVtype.Rows[Count].Cells[1].Value = Name;
                GridVtype.Rows[Count].Cells[1].Tag = Id;
            }
        }

        private void CmdShow_Click(object sender, EventArgs e)
            {
            Main();
        }
        private bool ValidationFu()
        {
            return true;
        }
        
        public void ShowReport()
        {
            NextgInitialize();
            CommonClass._Clreport.ShowReport(this,true);
        }

        public string VtypeFu()
        {
            if (comvtype.Text == "Purchase")
            {
                Vtype = "PI";
            }
            if (comvtype.Text == "Purchase Return")
            {
                Vtype = "PR";
            }
            if (comvtype.Text == "Purchase Order")
            {
                Vtype = "PO";
            }
            return Vtype;
        }
        public string SelectedVtype()
        {
            CommonClass.temp = "";
            CommonClass.temp = CommonClass._SelectReport.ShowSelectedinGrid(GridVtype, false);
            return CommonClass.temp;
        }
        public string SelectedModeofPayment()
        {
            CommonClass.temp = "";
            if (commodeofpayment.Text == "All")
                CommonClass.temp = "";
            else if (commodeofpayment.Text == "Cash")
                CommonClass.temp = " and TR.ledcodecr in(1)";
            else if (commodeofpayment.Text == "Credit")
                CommonClass.temp = " and TR.ledcodecr not in(1)";

            return CommonClass.temp;
        }
        public string SelectDate()
        {
            CommonClass.temp = "  and TR.recptdate between'" + DtFrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + DtTo.Value.ToString("MM-dd-yyyy") + " 23:59:59'";
            return CommonClass.temp;
        }
        public void NextgInitialize()
        {

            FrmReport.ledonly = "";
            CommonClass._report.Query = "";
            Vtype = VtypeFu();
            if (Vtype != "PR")
            {
                if (Raddatewisedetail.Checked == true)
                {
                    Where = " having TR.recpttype='" + Vtype + "' and TR.ledcodedr in(" + SelectedVtype() + ") " + SelectedModeofPayment();

                    if (Selectednode == "Normal")
                    {
                        if (Vtype == "PI")
                        {
                            Reporttype = "Purchase";

                        }
                        if (Vtype == "PO")
                        {
                            Reporttype = "Purchase Order";
                        }
                    }
                    else if (Selectednode == "Supplier")
                    {
                        FrmReport.ledonly = _dbtask.znllString(txtsuppluer.Tag);
                        Where = " having TR.recpttype='" + Vtype + "' and TR.tename like  '%" + txtsuppluer.Text + "%'  " + SelectDate() + "";
                        Reporttype = "Purchase";
                    }
                    else if (Selectednode == "Area")
                    {
                        CommonClass.temp = CommonClass._SelectReport.ShowindatasetForString("select lname from tblaccountledger where area in ('" + Comarea.Text + "')");
                        Where = " having TR.recpttype='" + Vtype + "' and TR.tename in (" + CommonClass.temp + ")  " + SelectDate() + "";
                        Reporttype = "Purchase";
                    }

                    else if (Selectednode == "Item")
                    {
                        if (Chkitemwisesumofqty.Checked == true)
                        {
                            Reporttype = "Purchasedaybooksumqty";
                            Where = "SELECT     TblItemMaster.ItemName as 'ItemName',sum( TblInventory.Purchase) as 'Qty' "+
                                    " FROM         TblItemMaster INNER JOIN "+
                                    " TblInventory ON TblItemMaster.ItemId = TblInventory.PCode "+
                                    " where tblinventory.invdate between '" + DtFrom.Value.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DtTo.Value.ToString("MM/dd/yyyy") + " 23:59:59'" +
                                    " group by TblItemMaster.ItemName,TblItemMaster.itemid  ";

                            if (chkallitem.Checked == false)
                            {
                               Where=Where+ " having TblItemMaster.itemid in("+Txtitems.Tag+")";
                            }
                            else
                            {
                                Where = Where + " having TblItemMaster.itemid in(select itemid from tblitemmaster)";
                            }
                        }
                        else
                        {
                            Reporttype = "Purchasedaybook";
                            Where = "select * from tbltransactionreceipt where recpttype='" + Vtype + "' ";

                            if (chkallitem.Checked == true)
                            {
                                CommonClass._report.QueryDetail = "";
                            }
                            else
                            {
                                CommonClass._report.QueryDetail = " and pcode ='" + Txtitems.Tag + "' and vtype='" + Vtype + "'";
                            }
                        }
                    }

                    else if (Selectednode == "ItemCategory")
                    {
                        Reporttype = "Purchasedaybook";
                        Where = "select * from tbltransactionreceipt where recpttype='" + Vtype + "' ";
                        CommonClass.temp = CommonClass._SelectReport.ShowindatasetForString("select itemid from tblitemmaster where categoryid in (" + comcategory.SelectedValue + ")");
                        CommonClass._report.QueryDetail = " and pcode in (" + CommonClass.temp + ") and vtype='" + Vtype + "'";
                    }

                    else if (Selectednode == "Manufacturer")
                    {
                        Reporttype = "Purchasedaybook";
                        Where = "select * from tbltransactionreceipt where recpttype='" + Vtype + "' ";
                        CommonClass.temp = CommonClass._SelectReport.ShowindatasetForString("select itemid from tblitemmaster where manufacturer in (" + Commanufacturer.SelectedValue + ")");
                        CommonClass._report.QueryDetail = " and pcode in (" + CommonClass.temp + ") and vtype='" + Vtype + "'";
                    }

                    else if (Selectednode == "Ptaxmode1" || Selectednode == "Ptaxmode2")
                    {
                        Reporttype = "Purchasetaxsummery";
                        CommonClass._report.Query = "select * from tblbusinessissue ";
                        if (Selectednode == "Staxmode1")
                        {
                            CommonClass.SRmode = "Mode1";
                        }
                        else
                        {
                            CommonClass.SRmode = "Mode2";
                        }
                    }
                    else if (Selectednode == "Staxmode3")
                    {
                        // CommonClass._report.Query = "select sum(taxamt)as Taxamt,CONVERT(VARCHAR(10),issuedate,120) as vdate from tblbusinessissue " +
                        //"  group by tblbusinessissue.IssueType,tblbusinessissue.LedcodeCr,tblbusinessissue.IssueDate,tblbusinessissue.IssueType ";
                        // CommonClass.SRmode = "Mode3";
                        // Reporttype = "Salestaxsummery";
                    }
                }
                if (Raddatewisesummury.Checked == true)
                {
                    Reporttype = "PurchaseDaysummury";
                    Where = "   SELECT   day (recptdate) as 'Day',month (recptdate) as 'Month',year (recptdate) as 'Year',Count (*) as 'No',SUM(AMT) AS 'Amount' " +
                          " FROM         tbltransactionreceipt  where recpttype='PI' ";
                }
                if (radmonthwisesummury.Checked == true)
                {
                    Reporttype = "PurchaseMonthsummury";
                    Where = "   SELECT     year (recptdate) as 'Year',month (recptdate) as 'Month',Count (*) as 'No',SUM(AMT) AS 'Amount' " +
                          " FROM         tbltransactionreceipt  where recpttype='PI' ";
                }
            }
            else
            {
                Where = " having tblbusinessissue.issuetype='" + Vtype + "'  and tblissuedetails.vtype='"+Vtype+"' and tblbusinessissue.ledcodecr in(" + SelectedVtype() + ") " + SelectedModeofPayment();
                if (Selectednode == "Normal")
                {
                    Reporttype = "Purchase Return";
                }
                else if (Selectednode == "Supplier")
                    {
                    Where = Where+ " and tblbusinessissue.ledcodedr ='"+txtsuppluer.Tag+"'";
                    Reporttype = "Purchase Return";
                    //ReportType();
                }
                //else if (Selectednode == "Area")
                //{
                //    CommonClass.temp = _SelectReport.ShowindatasetForString("select lname from tblaccountledger where area in ('" + Comarea.Text + "')");
                //    Where = WhereUse + TableUse + "issuetype='" + Vtype + "' and " + TableUse + " tename in (" + CommonClass.temp + ")  ";
                //    ReportType();
                //}

                else    if (Selectednode == "Item")
                {
                    Reporttype = "Purchasereturndaybook";
                    Where = "select * from tblbusinessissue where issuetype ='PR'  and ledcodecr in(" + SelectedVtype() + ")  ";
                    CommonClass._report.QueryDetail = " and pcode ='" + Txtitems.Tag + "' and vtype='PR'";
                }

                else if (Selectednode == "ItemCategory")
                {
                    Reporttype = "Purchasereturndaybook";
                    Where = "select * from tblbusinessissue where issuetype ='PR' and ledcodecr in(" + SelectedVtype() + ")   ";
                    CommonClass.temp = CommonClass._SelectReport.ShowindatasetForString("select itemid from tblitemmaster where categoryid in (" + comcategory.SelectedValue + ")");
                    CommonClass._report.QueryDetail = " and pcode in (" + CommonClass.temp + ")";
                }

                else if (Selectednode == "Manufacturer")
                {
                    Reporttype = "Purchasereturndaybook";
                    Where = "select * from tblbusinessissue where issuetype ='PR' and ledcodecr in(" + SelectedVtype() + ")   ";
                    CommonClass.temp = CommonClass._SelectReport.ShowindatasetForString("select itemid from tblitemmaster where manufacturer in (" + Commanufacturer.SelectedValue + ")");
                    CommonClass._report.QueryDetail = " and pcode in (" + CommonClass.temp + ")";
                }
            }
            CommonClass._report.DTFrom = Convert.ToDateTime(DtFrom.Value.ToString("dd/MMM/yyyy"));
            CommonClass._report.DTTo = Convert.ToDateTime(DtTo.Value.ToString("dd/MMM/yyyy"));

            Clsselectreport.RType = Reporttype;
            Clsselectreport.RQuery = CommonClass._report.Query + "" + Where;
            Clsselectreport.RQueryTemp = CommonClass._report.QueryTemp;
            Clsselectreport.RQueryDetail = CommonClass._report.QueryDetail;
            Clsselectreport.RDtfrom = CommonClass._report.DTFrom;
            Clsselectreport.Rdtto = CommonClass._report.DTTo;

        }

        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
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

        public void SelectedMethodTax(int SIndex)
        {
            switch (SIndex)
            {
                case 0:

                    if (radpurchasetaxsumode1.Checked == true)
                        Selectednode = "Ptaxmode1";
                    if (radpurchasetaxsumode2.Checked == true)
                        Selectednode = "Ptaxmode2";
                    if (radpurchasetaxsumode3.Checked == true)
                        Selectednode = "Ptaxmode3";
                    return;
            }
        }



        public void SelectedMethod(int SIndex)
        {
            switch (SIndex)
            {
                case 0:
                    Selectednode = "Normal";
                    return;

                case 1:
                    Selectednode = "Supplier";
                    return;

                case 2:
                    Selectednode = "Item";
                    return;

                case 3:
                    Selectednode = "ItemCategory";
                    return;

                case 4:
                    Selectednode = "Manufacturer";
                    return;

                case 5:
                    Selectednode = "Area";
                    return;
            }
        }

        private void Tabmain_SelectedIndexChanged(object sender, EventArgs e)
        {
         if(Tabmain.SelectedIndex==1)
            SelectedMethodTax(0);
         else
             SelectedMethod(Tabpurchase.SelectedIndex);
        }

        private void Tabpurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
         SelectedMethod(Tabpurchase.SelectedIndex);
        }

        private void chkvtype_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvtype.Checked == true)
            {
                GridVtype.Enabled = false;

              CommonClass._SelectReport.SelectAllCheckinGrid(GridVtype);
            }
            else
            {
                GridVtype.Enabled = true;
            }
        }

        private void txtsuppluer_TextChanged(object sender, EventArgs e)
        {
            CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtsuppluer.Text, uscitemshowsimple2, 2);
        }

        private void txtsuppluer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CommonClass._Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtsuppluer);
        }

        private void Txtitems_TextChanged(object sender, EventArgs e)
        {
            string Temp = Txtitems.Text;
            Uscitemshowsimple.ActiveControle = Txtitems;
            Uscitemshowsimple.Vtype = "Item";
            string WHEREE = "";
            if (SBATCH == true)
            {
                WHEREE = " where  (TblItemMaster.itemCode Like N'%" + Temp + "%' OR  TblItemMaster.ItemName Like N'%" + Temp + "%' OR  TblItemMaster.llang Like N'%" + Temp + "%' or Tblbatch.bcode like N'%" + Temp + "%' ) ";
            }
            else
            {
                WHEREE = Temp;
            }


            ProductGridShow(WHEREE);
        }
        public void ProductGridShow(string WhereCondition)
        {
            try
            {
                CommonClass._Ingrid.ProductGridShowFixed(uscitemshowsimple1, WhereCondition, uscitemshowsimple1.GridProductShow, "0");
                if (uscitemshowsimple1.Visible == false)
                {
                    uscitemshowsimple1.Visible = true;
                }

            }
            catch
            {
            }
        }
        private void Txtitems_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            RowClick(Txtitems.Text, e.KeyValue);
        }

        public void RowClick(string Value, int KeyValue)
        {
            try
            {
                // gridmain.Rows[rowindex].Cells["clnitemcode"].Value = Value;

                CommonClass._Ingrid.RowUpDownSelectinTexttbox(KeyValue, uscitemshowsimple1.GridProductShow, SeleRow, uscitemshowsimple1);
                // uscitemshowsimple1.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);
                if (KeyValue == 13)
                {
                    SeleRow = uscitemshowsimple1.GridProductShow.SelectedRows[0].Index;
                    string Itemid = uscitemshowsimple1.GridProductShow.Rows[SeleRow].Cells["itemid"].Value.ToString();
                    string ItemName = CommonClass._Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                    string ItemCode = CommonClass._Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Itemid + "'");
                    Txtitems.Text = ItemName;
                    // txtitemcode.Text = ItemCode;
                    Txtitems.Tag = Itemid;
                    uscitemshowsimple1.Visible = false;
                    // BatchList();
                }
            }
            catch
            {
            }
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmselectpurchasereportnew_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void Frmselectpurchasereportnew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        private void Frmselectpurchasereportnew_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117)
            {
                Main();
            }
        }

     
    }
}
