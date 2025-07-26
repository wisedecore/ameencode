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
    public partial class FrmSelectSalesReport : Form
    {
        public FrmSelectSalesReport()
        {
            InitializeComponent();
        }
        bool ShowEstimate;

        string WhereUse;
        string TableUse;



        public int actualW = 0;
        public int actualH = 0;

        public static bool SBATCH = false;
        public string Vtype;
        public int SeleRow;

        public int Count;
        public bool IsEnter;
        public DataSet Ds;
        public string Heading;
        public string Vtypein;
        public string Ledcodein;
        public string Selectednode;
        public string Where;
        public string SelectedLedname;
        public int selectedRow;

        //string Selectednode;
        public string Id;
        DBTask _dbtask = new DBTask();
        clsitemCategory _ItemCategory = new clsitemCategory();
        ClsManufacturer _Manufacturer = new ClsManufacturer();
        ClsItemMaster _Itemmaster = new ClsItemMaster();
        ClsDepot _Depot = new ClsDepot();
        ClsEmployeeMaster _EmployeeMaster = new ClsEmployeeMaster();
        ClsAccountGroup _AccountGroupe = new ClsAccountGroup();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        Clsselectreport _SelectReport = new Clsselectreport();
       
        NextGFuntion _NextgFunction = new NextGFuntion();


        //FrmReport _Report = new FrmReport();
        public string Reporttype;

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.TabBasedConversion(Tabnormal);
                CommonClass._Language.TabBasedConversion(tabcustomerwise);
                CommonClass._Language.TabBasedConversion(Tabitemwise);
                CommonClass._Language.TabBasedConversion(Tabitemcategorywise);
                CommonClass._Language.TabBasedConversion(Tabmanufacturerwise);
                CommonClass._Language.TabBasedConversion(Tabsalesmanwise);
                CommonClass._Language.TabBasedConversion(Tabagentwise);
                CommonClass._Language.TabBasedConversion(Tabareawise);
                CommonClass._Language.TabBasedConversion(tabmoreprofitableitems);
                CommonClass._Language.TabBasedConversion(Tabother);
                CommonClass._Language.TabBasedConversion(tabmainsales);
                CommonClass._Language.TabBasedConversion(tabPage2);
                CommonClass._Language.TabBasedConversion(Tabsalestaxsummury);
            }
        }
   
        private void FrmSelectSalesReport_Load(object sender, EventArgs e)
        {
            Clear();
            chkallitem.Checked = false;
            Txtitems.Enabled = true;
        }
        
        public void Clear()
        {
            //if (DateTime.Now.TimeOfDay <Convert.to 7)
            //{
            //    DtFrom.Value = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 07:00:00"));
            //    DateTime.Now.Date.AddDays(-1);
            //    DtTo.Value = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 02:00:00"));
            //}
            //else
            //{
            DtFrom.Value = CommonClass._Gen.FuFromdateReportdef();
            DtTo.Value = CommonClass._Gen.FuTodateReportdef();
            
            _ItemCategory.FillCombo(comcategory,false);
            _Manufacturer.FillCombo(Commanufacturer);
            _AccountLedger.FillComboEmployee(Comsalesman);
            _AccountLedger.FillComboAgent(Comagent);
            CommonClass._Area.FillArea(Comarea);
            CommonClass._UserDetails.FillUser(Comuser);
            ShowAllvoucher();
            chkvtype.Checked = true;
            SelectedMethod(Tabsales.SelectedIndex);
            comvtype.SelectedIndex = 0;
            commodeofpayment.SelectedIndex = 0;
            Commodeoftax.SelectedIndex = 0;
            Comsalesman.SelectedIndex = 0;
            ChangeLanguage();
            actualW = Cmddailyreport.Width;
            actualH = Cmddailyreport.Height;
            Frmreport2.frstdto = Convert.ToDateTime(DtTo.Value.ToString("dd/MMM/yyyy hh:mm tt"));
            Frmreport2.DTFrom = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 07:00:00"));
            Frmreport2.Dtto = Convert.ToDateTime(DtTo.Value.ToString("dd/MMM/yyyy hh:mm tt"));
            CommonClass._Nextg.FormIcon(this);


            ClsInGrid.WGmitemcode=_dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemcode"));

            ClsInGrid.WGmitemname = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemname"));
            ClsInGrid.WGmsrate = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmsrate"));
            ClsInGrid.WGmmrp = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmmrp"));
            ClsInGrid.WGmrack = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmrack"));
            ClsInGrid.WGmprate = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmprate"));
            ClsInGrid.WGmbcode = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmbcode"));
            if( _dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103"))=="1")
            {
            SBATCH =true;
            }
            else
            {
                SBATCH=false;
            }
        
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

        private bool ValidationFu()
        {
            return true;
        }

        public string SelectedVtype()
        {
               CommonClass.temp = "";
             

               CommonClass.temp = " ledcodecr  IN( " + CommonClass._SelectReport.ShowSelectedinGrid(GridVtype, false) + ")";

               if (Vtype == "SV")
                   CommonClass.temp = " ledcodecr  IN(14)";

               return CommonClass.temp;
        }

        public string SelectedModeofPayment()
            {
            CommonClass.temp = "";

            if (Vtype == "SR")
            {
                if (commodeofpayment.Text == "All")
                    CommonClass.temp = "";
                else if (commodeofpayment.Text == "Cash")
                    CommonClass.temp = " and TR.mpayment=0";
                else if (commodeofpayment.Text == "Credit")
                    CommonClass.temp = " and TR.mpayment=1";
                else if (commodeofpayment.Text == "Card")
                    CommonClass.temp = " and TR.mpayment=2";
            }
            else
            {
                //if (commodeofpayment.Text == "All")
                //    CommonClass.temp = "";
                //else if (commodeofpayment.Text == "Cash")
                //    CommonClass.temp = " and TblBusinessIssue.ledcodedr in(1)";
                //else if (commodeofpayment.Text == "Credit")
                //    CommonClass.temp = " and TblBusinessIssue.ledcodedr not in(1)";
                // else if (commodeofpayment.Text == "Card")
                //    CommonClass.temp = " and TblBusinessIssue.ledcodedr not in(1)";

                if (commodeofpayment.Text == "All")
                    CommonClass.temp = "";
                else if (commodeofpayment.Text == "Cash")
                    CommonClass.temp = " and TblBusinessIssue.mpayment=0";
                else if (commodeofpayment.Text == "Credit")
                    CommonClass.temp = " and TblBusinessIssue.mpayment=1";
                else if (commodeofpayment.Text == "Card")
                    CommonClass.temp = " and TblBusinessIssue.mpayment=2";
            }

            return CommonClass.temp;
        }

        public string SelectedModeofTax()
        {
            CommonClass.temp = "";

            if (Vtype == "SR")
            {
                if (commodeofpayment.Text == "All")
                    CommonClass.temp = "";
                else if (commodeofpayment.Text == "Tax")
                    CommonClass.temp = " and TR.taxid not in(0)";
                else if (commodeofpayment.Text == "None")
                    CommonClass.temp = " and TR.taxid in(1)";
            }
            else
            {
                if (Commodeoftax.Text == "All")
                    CommonClass.temp = "";
                else if (Commodeoftax.Text == "Tax")
                    CommonClass.temp = " and TblBusinessIssue.taxid not in(0)";
                else if (Commodeoftax.Text == "None")
                    CommonClass.temp = "  and TblBusinessIssue.taxid  in(0)";
            }

            return CommonClass.temp;
        }
        public string SelectedUser()
        {
            CommonClass.temp = "";

            if (Vtype == "SR")
            {
                if (ChkAlluser.Checked == true)
                    CommonClass.temp = "";
                else 
                    CommonClass.temp = " and TR.Uid ='"+Comuser.Text+"'";
            }
            else
            {
                if (ChkAlluser.Checked == true)
                    CommonClass.temp = "";
                else 
                    CommonClass.temp = " and TblBusinessIssue.Uid ='" + Comuser.Text + "'";

             
            }

            return CommonClass.temp;
        }
        public string SelectedModeofPaymentReceipt()
        {
            CommonClass.temp = "";
            if (commodeofpayment.Text == "All")
                CommonClass.temp = "";
            else if (commodeofpayment.Text == "Cash")
                CommonClass.temp = " and tbltransactionreceipt.ledcodecr in(1)";
            else if (commodeofpayment.Text == "Credit")
                CommonClass.temp = " and tbltransactionreceipt.ledcodecr not in(1)";

            return CommonClass.temp;
        }
       
        public string SelectDateReceipt()
        {
            CommonClass.temp = "  and " + TableUse + "recptdate ";
            return CommonClass.temp;
        }

        public string VtypeFu()
        {
            if(comvtype.Text=="Sales")
            {
               Vtype = "SI";
            }
            if (comvtype.Text == "Services")
            {
                Vtype = "SV";
            }
            if (comvtype.Text == "Sales Return")
            {
                Vtype = "SR";
            }
            if (comvtype.Text == "Sales Order")
            {
                Vtype = "SO";
            }
            if (comvtype.Text == "Sales Quatation")
            {
                Vtype = "SQ";
            }
           
            return Vtype;
        }
        
        public void ReportType()
        {
            if (Vtype == "SI")
                Reporttype = "Sales";
            else if (Vtype == "SO")
                Reporttype = "Sales Order";
            else if (Vtype == "SQ")
                Reporttype = "Sales Quatation";
            else if (Vtype == "SV")
                Reporttype = "Services";

            if (Raddatewisedetail.Checked == true)
            {
                Reporttype = "SalesDay";
            }
            else if (Raddatewisesummury.Checked == true)
            {
                Reporttype = "SalesDaysummury";
            }
            else if (radmonthwisesummury.Checked == true)
            {
                Reporttype = "SalesMonthsummury";
            }

            if (Selectednode == "Customer")
            {
                if (chkcustomerforitem.Checked == true)
                {
                    Reporttype = "Salescustomeranditem";
                    Clsselectreport.RTypeSecond = "Count";
                    
                }
                else if(chkcustomerforitemvalue.Checked==true)
                {
                    Reporttype = "Salescustomeranditem";
                    Clsselectreport.RTypeSecond = "Value";
                }
            }
        }

        public void NextgInitialize()
        {

            FrmReport.ledonly = "";
            if (Selectednode == "Staxmode1" || Selectednode == "Staxmode2" || Selectednode == "Staxmode4")
            {
                WhereUse = " where";
                TableUse = "";
            }
            else
            {
                CommonClass._report.Query = "";

                WhereUse = " having";
                TableUse = " TblBusinessIssue.";
            }

          Vtype=VtypeFu();
          if (Vtype != "SR")
          {
              
                  Where = " " + WhereUse + " " + TableUse + "issuetype='" + Vtype + "' and " + TableUse + "" + SelectedVtype() + SelectedModeofPayment()+SelectedModeofTax()+SelectedUser();
                  if (Selectednode == "Normal")
                  {
                     // Where = Where + " and TblIssuedetails.vtype='" + Vtype + "'";
                      ReportType();
                  }

                  else if (Selectednode == "Customer")
                  {
                      //Where = WhereUse + TableUse + "issuetype='" + Vtype + "' and " + TableUse + "tename in ('" + txtcustomer.Text + "')  ";
                      //ReportType();
                      FrmReport.ledonly =  _dbtask.znllString(txtcustomer.Tag);
                      Where = Where + " and ( tblbusinessissue.ledcodeDr='" + txtcustomer.Tag + "' or tblbusinessissue.tename like '%"+txtcustomer.Text+"%')";
                      ReportType();
                  }
                  else if (Selectednode == "SalesMan")
                  {
                      //Where = WhereUse + TableUse + "issuetype='" + Vtype + "' and " + TableUse + "empid in ('" + Comsalesman.SelectedValue + "')  ";
                      Where = Where + " and empid in ('" + Comsalesman.SelectedValue + "')";

                      ReportType();
                  }

                  else if (Selectednode == "Agent")
                  {
                     // Where = WhereUse + TableUse + "issuetype='" + Vtype + "' and " + TableUse + "agent in ('" + Comagent.SelectedValue + "') ";
                      Where = Where + " and agent in ('" + Comagent.SelectedValue + "') ";
                      ReportType();
                  }

                  else if (Selectednode == "Area")
                  {
                      CommonClass.temp = _SelectReport.ShowindatasetForString("select lname from tblaccountledger where area in ('" + Comarea.SelectedValue + "')");
                      //Where = WhereUse + TableUse + "issuetype='" + Vtype + "' and " + TableUse + " tename in (" + CommonClass.temp + ")  ";
                      Where = Where + " and  tename in (" + CommonClass.temp + ")   ";


                      ReportType();
                  }

                  else if (Selectednode == "Item")
                  {
                      Reporttype = "Salesdaybook";
                      Where = "select * from tblbusinessissue where issuetype='"+Vtype+"'  and " + TableUse + "" + SelectedVtype() + SelectedModeofPayment()+SelectedModeofTax();
                      if (chkallitem.Checked == true)
                      {
                          CommonClass._report.QueryDetail = "";
                      }
                      else
                      {
                          Reporttype = "ItemwiseSlesPreport";
                          if (SBATCH==false)
                          {
                              CommonClass._report.QueryDetail = " ( tblissuedetails.pcode ='" + Txtitems.Tag + "' and tblissuedetails.vtype='" + Vtype + "'  )";
                          }
                          if (SBATCH == true)
                          {
                              CommonClass._report.QueryDetail = "( tblissuedetails.pcode ='" + Txtitems.Tag + "'   and tblissuedetails.batchid='" + _dbtask.znllString(Txtbatchpurch.Text) + "'  and tblissuedetails.vtype='" + Vtype + "'  ) ";
                          }
                          //CommonClass._report.QueryDetail = " and pcode ='" + Txtitems.Tag + "' and vtype='"+Vtype+"'";
                      }

                      if (ChkItemlistwise.Checked == true)
                      {
                          Reporttype = "Item list count";
                          CommonClass._report.Query = "select issuecode from tblbusinessissue where issuedate between "+
                         " '" + DtFrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + DtTo.Value.ToString("MM-dd-yyyy") + " 23:59:59' and vtype='SI' ";
                          CommonClass._report.Query = " where issuecode in(" + CommonClass._report.Query + ") and vtype='SI' group by pcode,UnitId";
                          Where = "";
                      }
                  }

                  else if (Selectednode == "ItemCategory")
                  {
                      Reporttype = "Salesdaybook";
                      Where = "select * from tblbusinessissue where issuetype='" + Vtype + "'and " + TableUse + "" + SelectedVtype() + SelectedModeofPayment()+SelectedModeofTax();
                      CommonClass.temp = _SelectReport.ShowindatasetForString("select itemid from tblitemmaster where categoryid in (" +Txtitemcategory.Tag + ")");
                      CommonClass._report.QueryDetail = " and pcode in (" + CommonClass.temp + ") and vtype='" + Vtype + "'";
                  }

                  else if (Selectednode == "Manufacturer")
                  {
                      Reporttype = "Salesdaybook";
                      Where = "select * from tblbusinessissue where issuetype='" + Vtype + "' and " + TableUse + "" + SelectedVtype() + SelectedModeofPayment()+SelectedModeofTax();
                      CommonClass.temp = _SelectReport.ShowindatasetForString("select itemid from tblitemmaster where manufacturer in (" + Commanufacturer.SelectedValue + ")");
                      CommonClass._report.QueryDetail = " and pcode in (" + CommonClass.temp + ") and vtype='" + Vtype + "'";
                  }
                  else if (Selectednode == "MoreProfitable")
                  {

                  }

                  else if (Selectednode == "Other")
                  {
                      if (chkshowitemdiscount.Checked == true)
                      {
                          CommonClass._report.Query = "SELECT        TblItemMaster.ItemName, SUM(TblIssuedetails.DiscRate) AS Discount, TblIssuedetails.Pcode, " +
                        "(SELECT        SUM(Purchase) AS Expr1 " +
                        "  FROM            TblInventory " +
                        "  WHERE        (PCode = TblIssuedetails.Pcode)) AS Purchase," +
                        " (SELECT        SUM(Sales) AS Expr1 " +
                        "  FROM            TblInventory AS TblInventory_2 " +
                        "  WHERE        (PCode = TblIssuedetails.Pcode)) AS Sales, " +
                        " (SELECT        SUM(Mr + Sr + Ireceipt + bmr + freepre + Dnr + ps + Purchase) - SUM(Sales + dn + pr + iissue + sh + dmg + bmi + freeiss) AS Expr1 " +
                        "  FROM            TblInventory AS TblInventory_1 " +
                        " WHERE        (PCode = TblIssuedetails.Pcode)) AS Balance " +
                        " FROM            TblIssuedetails INNER JOIN " +
                        " TblItemMaster ON TblIssuedetails.Pcode = TblItemMaster.ItemId INNER JOIN " +
                        " TblBusinessIssue ON TblIssuedetails.IssueCode = TblBusinessIssue.IssueCode " +
                        " GROUP BY TblItemMaster.ItemName, TblIssuedetails.Pcode " +
                        " HAVING        (SUM(TblIssuedetails.DiscRate) <> 0) ";
                          Reporttype = "SalesOther";
                          Where = "";
                      }
                  }
                  else if (Selectednode == "Staxmode1" || Selectednode == "Staxmode2" || Selectednode == "Staxmode4")
                  {
                      Reporttype = "Salestaxsummery";
                      CommonClass._report.Query = "select * from tblbusinessissue ";
                      if (Selectednode == "Staxmode1")
                      {
                          CommonClass.SRmode = "Mode1";
                      }
                      else if (Selectednode == "Staxmode2")
                      {
                          CommonClass.SRmode = "Mode2";
                      }
                      else if (Selectednode == "Staxmode4")
                      {
                          CommonClass.SRmode = "Mode4";
                      }
                  }
                  else if (Selectednode == "Staxmode3")
                  {
                      CommonClass._report.Query = "select sum(taxamt)as Taxamt,CONVERT(VARCHAR(10),issuedate,120) as vdate from tblbusinessissue " +
                          "group by tblbusinessissue.IssueType,tblbusinessissue.LedcodeCr,tblbusinessissue.IssueDate ";

                      Reporttype = "Salestaxsummery";
                      CommonClass.SRmode = "Mode3";
                  }
              

              if (Raddatewisesummury.Checked == true)
              {
                  ReportType();
                  Where = "   SELECT   day (issuedate) as 'Day',month (issuedate) as 'Month',year (issuedate) as 'Year',Count (*) as 'No',SUM (TAXAMT)  AS 'Taxamt' ,SUM(AMT) AS 'Amount' " +
                        " FROM         TblBusinessIssue  where issuetype='" + Vtype + "' ";
              }
              if (radmonthwisesummury.Checked == true)
              {
                  ReportType();
                  Where = "   SELECT     year (issuedate) as 'Year',month (issuedate) as 'Month',Count (*) as 'No',SUM(AMT) AS 'Amount' " +
                        " FROM         TblBusinessIssue  where issuetype='"+Vtype+"' ";
              }

          }
          else
          {
              TableUse = " tbltransactionreceipt.";
             // Where = " having TR.recpttype='" + Vtype + "' and TR.ledcodedr in(2) ";
              Where = " having TR.recpttype='" + Vtype + "' and TR.ledcodedr in(2)" + SelectedModeofPayment()+SelectedModeofTax()+SelectedUser();

              Reporttype = "SR";
              if (Selectednode == "Normal")
              {
                  Reporttype = "Sales return";
              }
              else if (Selectednode == "Customer")
              {
                  Where = Where + " and TR.tename in ('" + txtcustomer.Text + "')  " + SelectDate() + "";
                  Reporttype = "Sales return";
              }
              else if (Selectednode == "SalesMan")
              {
                  Where = Where + " and TR.empid in ('" + Comsalesman.SelectedValue + "')  " + SelectDate() + "";
                  Reporttype = "Sales return";
              }
              else if (Selectednode == "Agent")
              {
                  Where = Where + " and TR.agent in ('" + Comagent.SelectedValue + "')  " + SelectDate() + "";
                  Reporttype = "Sales return";
              }

              else if (Selectednode == "Area")
              {
                  CommonClass.temp = CommonClass._SelectReport.ShowindatasetForString("select lname from tblaccountledger where area in ('" + Comarea.SelectedValue + "')");
                  Where = Where + " and TR.tename in (" + CommonClass.temp + ")  " + SelectDate() + "";
                  Reporttype = "Sales return";
              }

              else if (Selectednode == "Item")
              {
                  Reporttype = "Sales returnaybook";

                  Where = "select * from tbltransactionreceipt where Recpttype='SR'"  + SelectedModeofPayment()+SelectedModeofTax();
                  if (chkallitem.Checked == true)
                  {
                      CommonClass._report.QueryDetail = "";
                  }
                  else
                  {
                      CommonClass._report.QueryDetail = " and pcode ='" + Txtitems.Tag + "' and vtype='" + Vtype + "'";
                  }
              }

              else if (Selectednode == "ItemCategory")
              {
                  Reporttype = "Sales returnaybook";

                  Where = "select * from tbltransactionreceipt where Recpttype='SR'" + SelectedModeofPayment()+SelectedModeofTax();

                  CommonClass.temp = CommonClass._SelectReport.ShowindatasetForString("select itemid from tblitemmaster where categoryid in (" + Txtitemcategory.Tag + ")");
                  CommonClass._report.QueryDetail = " and pcode in (" + CommonClass.temp + ") and vtype='" + Vtype + "'";
                  
              }

              else if (Selectednode == "Manufacturer")
              {
                  Reporttype = "Sales returnaybook";

                  Where = "select * from tbltransactionreceipt where Recpttype='SR'" + SelectedModeofPayment()+SelectedModeofTax();
                  CommonClass.temp = CommonClass._SelectReport.ShowindatasetForString("select itemid from tblitemmaster where manufacturer in (" + Commanufacturer.SelectedValue + ")");
                  CommonClass._report.QueryDetail = " and pcode in (" + CommonClass.temp + ") and vtype='" + Vtype + "'";
              }

             
          }
          CommonClass._report.DTFrom = Convert.ToDateTime(DtFrom.Value.ToString("dd/MMM/yyyy hh:mm tt"));
          CommonClass._report.DTTo = Convert.ToDateTime(DtTo.Value.ToString("dd/MMM/yyyy hh:mm tt"));

           //if (Chktime.Checked == true)
           //{
           //    CommonClass._report.DTFrom = Convert.ToDateTime(DtFrom.Value.ToString("dd/MMM/yyyy"));
           //    CommonClass._report.DTTo = Convert.ToDateTime(DtTo.Value.ToString("dd/MMM/yyyy"));
           //}

           Clsselectreport.RType = Reporttype;
           Clsselectreport.RQuery = CommonClass._report.Query+""+Where;
           Clsselectreport.RQueryTemp = CommonClass._report.QueryTemp;
           Clsselectreport.RQueryDetail = CommonClass._report.QueryDetail;
           Clsselectreport.RDtfrom = CommonClass._report.DTFrom;
           Clsselectreport.Rdtto = CommonClass._report.DTTo;
        }

        public string SelectDate()
        {
            CommonClass.temp = "  and TR.recptdate between'" + DtFrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + DtTo.Value.ToString("MM-dd-yyyy") + " 23:59:59'";
            return CommonClass.temp;
        }

        public void ShowReport()
        {
                NextgInitialize();
                CommonClass._Clreport.ShowReport(this,true);
        }

        private void FrmSelectSalesReport_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void ForDateDeclare()
        {
            CommonClass._report.DTFrom = DtFrom.Value;
            CommonClass._report.DTTo = DtTo.Value;
        }

        
        public void GetIssueCodeBaseonDetail(string Itemid)
        {
            CommonClass.temp = CommonClass._SelectReport.Showindataset("select issuecode from tblissuedetails where pcode in(" + Itemid + ") and vtype='SI' ");
            CommonClass._report.Query = CommonClass._report.Query + " and issuecode in (" + CommonClass.temp + ")";
        }
        

       

       

      
      

        private void Comtype_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void chkall_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }
        public void Check()
        {
            
        }
        public void ShowAllvoucher()
        {
            GridVtype.Rows.Clear();
            //if(Generalfunction.BlShowEst==true)
            //Ds = _dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=21 and lid !=17 and lid!=24");
            //else
            //Ds = _dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=21 and lid !=17 and lid!=24 and lname !='estimate'");
            Ds = _dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=21 and lid !=17 and lid!=24");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Count = GridVtype.Rows.Add(1);
                Name = Ds.Tables[0].Rows[i]["lname"].ToString();
                Id = Ds.Tables[0].Rows[i]["lid"].ToString();
                GridVtype.Rows[Count].Cells[1].Value = Name;
                GridVtype.Rows[Count].Cells[1].Tag = Id;
            }
        }

        private void cmdclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }
        //public void ShowVtypes()
        //{
        //    /*For ItemArea*/
        //    GridVtype.Rows.Clear();
        //    if(ShowEstimate==true)
        //    Ds = _dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=21 and lid!=24");
        //    else
        //        Ds = _dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=21 and lid!=24 and lname !='estimate'");

        //    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
        //    {
        //        Count = GridVtype.Rows.Add(1);
        //        Id = Ds.Tables[0].Rows[i]["lid"].ToString();
        //        Name = Ds.Tables[0].Rows[i]["lname"].ToString();
        //        GridVtype.Rows[Count].Cells[1].Value = Name;
        //        GridVtype.Rows[Count].Cells[1].Tag = Id;
        //    }
        //}
       

        private void comledger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (commodeofpayment.SelectedValue != null)
            {
                Ledcodein = commodeofpayment.SelectedValue.ToString();
            }
        }

        private void Gridlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txtitems_Enter(object sender, EventArgs e)
        {
            IsEnter = true;
        }

        private void chkvtype_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvtype.Checked == true)
            {
                GridVtype.Enabled = false;

               _SelectReport.SelectAllCheckinGrid(GridVtype);
            }
            else
            {
                GridVtype.Enabled = true;
            }
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

                    if(SBATCH==true)
                    {
                        string bcode = CommonClass._Dbtask.znllString(uscitemshowsimple1.GridProductShow.Rows[SeleRow].Cells["Bcode"].Value);
                    Txtbatchpurch.Text = "";
                    Txtbatchpurch.Text = bcode;
                    }
                    
                    
                    
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
                if(_dbtask.znllString( CommonClass._Menusettings.GetMnustatus("103"))=="1")
                {
                    CommonClass._Ingrid.BatchGridShow(uscitemshowsimple1, WhereCondition, uscitemshowsimple1.GridProductShow, "0", false, false, "0");
                }
                else
                {

                CommonClass._Ingrid.ProductGridShowFixed(uscitemshowsimple1, WhereCondition, uscitemshowsimple1.GridProductShow, "0");
                
                    
                }
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

        public void SelectedMethodTax(int SIndex)
        {
            switch (SIndex)
            {
                case 0:
                   
                    if(radsalestaxsumode1.Checked==true)
                        Selectednode = "Staxmode1";
                    if (radsalestaxsumode2.Checked == true)
                        Selectednode = "Staxmode2";
                    if (radsalestaxsumode3.Checked == true)
                        Selectednode = "Staxmode3";
                    return;
            }
        }

        public void SelectedMethod(int SIndex)
        {
            switch (SIndex)
            {
                case 0:
                    Selectednode="Normal";
                    return;

                case 1:
                    Selectednode = "Customer";
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
                    Selectednode = "SalesMan";
                    return;

                case 6:
                    Selectednode = "Agent";
                    return;

                case 7:
                    Selectednode = "Area";
                    return;

                case 8:
                    Selectednode = "MoreProfitable";
                    return;

                case 9:
                    Selectednode = "Other";
                    return;
            }
        }

        private void Tabsales_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMethod(Tabsales.SelectedIndex);
        }

        private void Tabsalestax_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMethodTax(Tabsalestax.SelectedIndex);
        }

        private void txtcustomer_TextChanged(object sender, EventArgs e)
        {
           CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtcustomer.Text, uscitemshowsimple2,1);
        }

        private void txtcustomer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CommonClass._Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtcustomer);

        }

        private void Tabmain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Tabmain.SelectedIndex==1)
            SelectedMethodTax(Tabsalestax.SelectedIndex);
            else
                SelectedMethod(Tabsales.SelectedIndex);
        }

        private void radsalestaxsumode1_CheckedChanged(object sender, EventArgs e)
        {
            if(radsalestaxsumode1.Checked==true)
            Selectednode = "Staxmode1";
        }

        private void radsalestaxsumode2_CheckedChanged(object sender, EventArgs e)
        {
            if (radsalestaxsumode2.Checked == true)
                Selectednode = "Staxmode2";
           
        }

        private void radsalestaxsumode3_CheckedChanged(object sender, EventArgs e)
        {
            if (radsalestaxsumode3.Checked == true)
                Selectednode = "Staxmode3";
        }

        private void FrmSelectSalesReport_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void FrmSelectSalesReport_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmSelectSalesReport_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117)
            {
                Main();
            } 
        }

        private void Radsalestaxmode4_CheckedChanged(object sender, EventArgs e)
        {
            if (Radsalestaxmode4.Checked == true)
                Selectednode = "Staxmode4";
        }

        private void Chkshowdatewise_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Raddatewisesummury_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkallitem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkallitem.Checked == true)
            {
                Txtitems.Enabled = false;            
            }
            else
            {
                Txtitems.Enabled = true;  
            }
        }

        private void ChkAlluser_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAlluser.Checked == true)
            {
                Comuser.Enabled = false;
            }
            else
            {
                Comuser.Enabled = true;
            }
        }

        private void Cmddailyreport_Click(object sender, EventArgs e)
        {
           Clsselectreport.RType = "Sales";
           Clsselectreport.RQuery = "  having  TblBusinessIssue.issuetype='SI' and  TblBusinessIssue. ledcodecr  IN( 2) " + SelectedUser();
           Clsselectreport.RQueryTemp ="";
           Clsselectreport.RQueryDetail = "";


           if (DtFrom.Value.ToString("tt") == "AM")
           {
               CommonClass._report.DTFrom = Convert.ToDateTime(Dtdailydate.Value.ToString("dd/MM/yyyy 07:00:00"));
               CommonClass._report.DTTo = Convert.ToDateTime(Dtdailydate.Value.AddDays(1).ToString("dd/MM/yyyy 02:00:00"));
           }
           else
           {
               CommonClass._report.DTFrom = Convert.ToDateTime(Dtdailydate.Value.AddDays(-1).ToString("dd/MM/yyyy 07:00:00"));
               CommonClass._report.DTTo = Convert.ToDateTime(Dtdailydate.Value.ToString("dd/MM/yyyy 02:00:00"));
           }

           Clsselectreport.RDtfrom = CommonClass._report.DTFrom;
           Clsselectreport.Rdtto = CommonClass._report.DTTo;
           CommonClass._Clreport.ShowReport(this,true);
        }

        private void cmditemwiserprt_Click(object sender, EventArgs e)
        {
            //Frmreport2.DTFrom = Convert.ToDateTime(DtFrom.Value.ToString("dd/MM/yyyy 00:00:00"));
            //Frmreport2.Dtto = Convert.ToDateTime(DtTo.Value.AddDays(1).ToString("dd/MM/yyyy 23:59:59"));

            //Frmreport2.DTFrom = DtFrom.Value;
            //Frmreport2.Dtto = DtTo.Value;
            (this.MdiParent as MDIParent2).itemListReportToolStripMenuItem.PerformClick();


            
        }

        private void cmdcategorywise_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).categorywiseToolStripMenuItem.PerformClick();
        }

        private void cmdsaledaybookcatgry_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).iteToolStripMenuItem.PerformClick();
        }

        private void Cmddailyreport_MouseHover(object sender, EventArgs e)
        {


           
        }

        private void Cmddailyreport_MouseEnter(object sender, EventArgs e)
        {
            Cmddailyreport.BackColor = Color.DarkOliveGreen;
            Cmddailyreport.ForeColor = Color.White;
        }

        private void Cmddailyreport_MouseLeave(object sender, EventArgs e)
        {
            Cmddailyreport.BackColor = Color.White;
            Cmddailyreport.ForeColor = Color.Green;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOliveGreen;

            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Green;

        }

        private void cmditemwiserprt_MouseEnter(object sender, EventArgs e)
        {
            cmditemwiserprt.BackColor = Color.DarkOliveGreen;
            cmditemwiserprt.ForeColor = Color.White;

        }

        private void cmditemwiserprt_MouseLeave(object sender, EventArgs e)
        {
            cmditemwiserprt.BackColor = Color.White;
            cmditemwiserprt.ForeColor = Color.Green;
        }

        private void cmdcategorywise_MouseEnter(object sender, EventArgs e)
        {
          cmdcategorywise.BackColor = Color.Wheat;
        }

        private void cmdcategorywise_MouseLeave(object sender, EventArgs e)
        {
            cmdcategorywise.BackColor = Color.White;
        }

        private void cmdsaledaybookcatgry_MouseEnter(object sender, EventArgs e)
        {
            cmdsaledaybookcatgry.BackColor = Color.Wheat;
        }

        private void cmdsaledaybookcatgry_MouseLeave(object sender, EventArgs e)
        {
            cmdsaledaybookcatgry.BackColor = Color.White;
        }

        private void Raddatewisedetail_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void CategoryShow()
        {
            
                Ds = CommonClass._ItemCategory.Showitemcategory("where Category like '%" + Txtitemcategory.Text + "%'");
                Gridmainlist.Rows.Clear();
                Gridmainlist.Visible = true;
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Gridmainlist.Rows.Add(1);
                    Gridmainlist.Rows[i].Cells["clnname"].Value = Ds.Tables[0].Rows[i]["Category"];
                    Gridmainlist.Rows[i].Cells["clnname"].Tag = Ds.Tables[0].Rows[i]["Categoryid"];
                }
              
         
        }
        private void Txtitemcategory_TextChanged(object sender, EventArgs e)
        {
            CategoryShow();
        }

        private void Txtitemcategory_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (Gridmainlist.SelectedRows.Count > 0)
                {
                    selectedRow = Gridmainlist.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridmainlist.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridmainlist.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridmainlist.Rows[selectedRow + 1].Selected = true;
                            Gridmainlist.Rows[selectedRow].Selected = false;
                            Gridmainlist.CurrentCell = Gridmainlist.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridmainlist.Rows[selectedRow - 1].Selected = true;
                        Gridmainlist.Rows[selectedRow].Selected = false;
                        Gridmainlist.CurrentCell = Gridmainlist.SelectedRows[0].Cells[0];
                    }

                    if (e.KeyValue == 13)
                    {
                        if (Gridmainlist.SelectedRows.Count > 0 && Gridmainlist.Visible == true)
                        {

                            Txtitemcategory.Text = Gridmainlist.SelectedRows[0].Cells["clnname"].Value.ToString();
                            Txtitemcategory.Tag = Gridmainlist.SelectedRows[0].Cells["clnname"].Tag;
                           
                        }
                        if (Txtitemcategory.Text == "")
                        {
                            Txtitemcategory.Text = "None";
                           Txtitemcategory.Tag = 0;
                        }
                        Gridmainlist.Visible = false;

                   

                    }
                    if (e.KeyValue == 27)
                    {
                        Gridmainlist.Visible = false;

                    }
                }
            }
            catch
            {
            }
        }

       

        

       
        

        
    }
}
