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
    public partial class frmTransferwindow : Form
    {
        public frmTransferwindow()
        {
            InitializeComponent();
        }
        double DiscPerc;
        double TTAmount;
        string temp1;
        string temp2;
        string FromDb;
        string ToDb;
        string Itemdiscount;
        public static  string Temp;
        public static string Temp1;
        string LedCodeDr = "";
        string VoCodes;
        string Ledcode;
        string Sql;
        string Format;
        string rePCODEid = "";
        string rebatchid = "";
        string recatid = "";

       // string Ledcode;
        string Vno;
      //  string Pvno;
        string IssuecodeOld;
        string IssuecodeNew;

       
        string LedCodeCr;
        string LedcodeDr;
        string Dcode;
        DateTime IDate;
       // string LedcodeCr;

        ////{"@invdisc",InvDisc},
        ////{"@TaxAmt",TaxAMTDb},  
        ////{"@cooly",CoolyDb},
        ////{"@adamount",AdvanceAmount},
        ////{"@agent",Agent},
        ////{"@pvno",Pvno},
        ////{"@Taxid",TaxId},
        ////{"@Tename",Tename},
        //// {"@cpdiscount",CpDiscount}

        double Amt;
        string Pvno;
        string Remarks;
        double DiscAmt;
        double InvDisc;
        double TaxAmt;
        double Cooly;
        string AgentId;
        string EmpId;
        string TaxId;
        string Tename;
        double CpDiscount;
        double AdvanceAmt;
        DataSet Ds;
        DBTask _dbtask = new DBTask();
        private void Transferwindow_Load(object sender, EventArgs e)
        {
            Fillcombo();
            CommonClass._Nextg.FormIcon(this);
        }
        public void fillitembcode()
        {

        }
        public void FillBusinessissue(string Vtype,string Where)
        {
            CommonClass.Ds = CommonClass._Businessissue.ShowBusinessIssueWithJoint("SI");
            gridmain.DataSource = CommonClass.Ds.Tables[0];
            if(gridmain.Rows.Count>0)
            {
                gridmain.Columns["issuecode"].Visible=false;
                gridmain.Columns["ledcodecr"].Visible=false;
                gridmain.Columns["sales"].Width = 200;
            }
        }

        public void Fillcombo()
        {
            CompanyList();
        }

        public void TransferSettings()
        {
            FromDb = CommonClass._Dbtask.currentcompany();
            ToDb = comtocompany.Text;
            Generalfunction.TempCompanyname = ToDb;
            //CommonClass._Dbtask.ExecuteNonQuery("delete from tblmnusettings");
            //CommonClass._Dbtask.ExecuteNonQuery("delete from tblparamlist");

            //TableTransferOneDBToOther("tblmnusettings", " ");
            //TableTransferOneDBToOther("tblparamlist", " ");
            Generalfunction.TempCompanyname = "";
        }

        public void CompanyList()
        {
            CommonClass.Ds=CommonClass._ComCreate.LoadCompany();
            comtocompany.Items.Clear();
            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                try
                {
                    string TempLoadingCompany = CommonClass.Ds.Tables[0].Rows[i]["name"].ToString();
                    comtocompany.Items.Add(TempLoadingCompany);
                }
                catch
                {

                }
            }
        }
        public void FillTransactionreceipt(string Vtype,string Where)
        {
            CommonClass.Ds = CommonClass._Transactionreceipt.ShowTransactionReceipt(" * ", " where recpttype='" + Vtype + "' " + Where + "");
        }
        public string CheckalreadyExstingAndreturn(string Conditions, string Table,string Vtype,string Fieled,string Ledcode,string WCode)
        {
            //Generalfunction.TempCompanyname = ToDb;
            //Ds=CommonClass._Dbtask.ExecuteQuery("select * from "+Table+" "+Conditions+"");
            //Generalfunction.TempCompanyname = "";
            string TempVno;
            string Vno;
            //TempVno = WCode;
            //if (Ds.Tables[0].Rows.Count > 0)
            //{
            Generalfunction.TempCompanyname = ToDb;
            TempVno =CommonClass._Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(" + Fieled + "), 0)}+1 AS Expr1  FROM " + Table + " where IssueType='" + Vtype + "' and ledcodeCr='" + Ledcode + "'");
            Vno = TempVno;
            //}
         //   return TempVno;
            return TempVno;
        }

        private bool Main()
        {
            if (ValidationFu())
            {
                TransferSettings();

                if (Convert.ToInt64(comsourcevoucher.SelectedIndex) != 2)
                {
                    TransferToIssueFormat("SI");
                    MessageBox.Show("sucess");
                }

                if (Convert.ToInt64(comsourcevoucher.SelectedIndex) == 2)
                {
                }
            }
            return true;
        }

        private bool ValidationFu()
        {
            if (comtocompany.Text == "")
            {
                MessageBox.Show("Select To Company ", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                comtocompany.Focus();
                return false;
            }
            return true;
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }
        public string ShowSelectedinGrid(string Columnname)
        {
            Temp = "";
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                string Value;
                if (gridmain.Rows[i].Cells[0].Value != null)
                {
                    Value = gridmain.Rows[i].Cells[0].Value.ToString();

                    if (Value == "1" && gridmain.Rows[i].Cells[Columnname].Value != null)
                        {
                            string Id = CommonClass._Dbtask.znllString(gridmain.Rows[i].Cells[Columnname].Value);
                            Temp = Temp + "," + Id;
                        }
                }
            }
            if (Temp.Length > 0)
                Temp = Temp.Substring(1, Temp.Length - 1);
            return Temp;
        }

        public string CalcItemDiscount(double TotalAmt,double NetAmt)
        {
            double DiscPerc;
            string Amt;
            
            //DiscAmount = CommonClass._Dbtask.znullDouble(txtdiscounttransfer.Text);
             DiscPerc = NetAmt * 100 / TotalAmt;
             TotalAmt = TotalAmt * CommonClass._Dbtask.znullDouble(txtdiscounttransfer.Text) / 100;

            Amt = (TotalAmt * DiscPerc / 100).ToString();
            return Amt;
        }
        public void TransferItemswithbatch()
        {

        }
        public void TransferToIssueFormat(string Vtype)
        {
            VoCodes = ShowSelectedinGrid("issuecode");
            LedCodeCr = ShowSelectedinGrid("ledcodecr");
           
             
            CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblbusinessissue where issuecode in (" + VoCodes + ") and issuetype='"+Vtype+"' and ledcodecr in ("+LedCodeCr+")");
            if(CommonClass.Ds.Tables[0].Rows.Count>0)
            {
                /*For Agent*/
                

                CommonClass.Ds3 = CommonClass._Dbtask.ExecuteQuery(" select * from tblbusinessissue where issuecode in (" + VoCodes + ") and agent !=0");
                for (int ii = 0; ii < CommonClass.Ds3.Tables[0].Rows.Count; ii++)
                {
                    string Lid=CommonClass.Ds3.Tables[0].Rows[ii]["agent"].ToString();
                    temp1 = CommonClass._Ledger.GetspecifField("lname", Lid);
                    Generalfunction.TempCompanyname = ToDb;
                    temp1 = CommonClass._Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + temp1 + "'");
                    if (temp1 == "")
                    {
                        Generalfunction.TempCompanyname = "";
                        CommonClass.Ds4 = CommonClass._Dbtask.ExecuteQuery("select * from tblaccountledger where lid ='" + Lid + "'");
                        if(CommonClass.Ds4.Tables[0].Rows.Count>0)
                        {
                            TableTransferOneDBToOther("tblaccountledger"," where lid='"+Temp+"'");
                        }
                    }
                }


                /*For Employee*/
                CommonClass.Ds3 = CommonClass._Dbtask.ExecuteQuery(" select * from tblbusinessissue where issuecode in (" + VoCodes + ") and empid !=0");
                for (int ii = 0; ii < CommonClass.Ds3.Tables[0].Rows.Count; ii++)
                {
                    string Lid = CommonClass.Ds3.Tables[0].Rows[ii]["empid"].ToString();
                    temp1 = CommonClass._Ledger.GetspecifField("lname", Lid);
                    Generalfunction.TempCompanyname = ToDb;
                    temp1 = CommonClass._Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + temp1 + "'");

                    if (temp1 == "")
                    {
                        Generalfunction.TempCompanyname = "";
                        CommonClass.Ds4 = CommonClass._Dbtask.ExecuteQuery("select * from tblaccountledger where lid ='" + Lid + "'");
                        if (CommonClass.Ds4.Tables[0].Rows.Count > 0)
                        {
                            //TableTransferOneDBToOther("tblaccountledger", " where lid='" + Temp + "'");
                            //TableTransferOneDBToOther("tblemployeemaster", " where empid='" + Temp + "'");
                        }
                    }
                }               
            }
            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                IssuecodeOld = CommonClass.Ds.Tables[0].Rows[i]["issuecode"].ToString();
                LedCodeCr = CommonClass.Ds.Tables[0].Rows[i]["ledcodecr"].ToString();
                Vno = CommonClass.Ds.Tables[0].Rows[i]["Vno"].ToString();
                /*Businessissue*/
                IssuecodeNew = CheckalreadyExstingAndreturn(" where vno='" + Vno + "' and issuetype='" + Vtype + "' and ledcodecr ='" + LedCodeCr + "'", "tblbusinessissue", "SI", "issuecode", LedCodeCr, Vno);

                Vtype = "SI";
                Dcode = CommonClass.Ds.Tables[0].Rows[i]["dcode"].ToString();
                IDate = Convert.ToDateTime(CommonClass.Ds.Tables[0].Rows[i]["issuedate"].ToString());
                LedCodeCr = CommonClass.Ds.Tables[0].Rows[i]["ledcodecr"].ToString();
                LedcodeDr = CommonClass.Ds.Tables[0].Rows[i]["ledcodedr"].ToString();
                Amt=CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[i]["amt"].ToString());
                Remarks = CommonClass.Ds.Tables[0].Rows[i]["remarks"].ToString();
                EmpId = CommonClass.Ds.Tables[0].Rows[i]["empid"].ToString();
                DiscAmt = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[i]["discamt"]);
                InvDisc =CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[i]["invdisc"]);
                TaxAmt =CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[i]["taxamt"]);
                Cooly =CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[i]["cooly"]);
                AdvanceAmt =CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[i]["adamount"]);
                AgentId = CommonClass.Ds.Tables[0].Rows[i]["agent"].ToString();
                Pvno = CommonClass.Ds.Tables[0].Rows[i]["pvno"].ToString();
                TaxId = CommonClass.Ds.Tables[0].Rows[i]["taxid"].ToString();
                Tename = CommonClass.Ds.Tables[0].Rows[i]["tename"].ToString();
                TTAmount = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[i]["amt"]);
                int mpayment = Convert.ToInt32( CommonClass.Ds.Tables[0].Rows[i]["mpayment"]);
                CpDiscount = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[i]["cpdiscount"]);

                Generalfunction.TempCompanyname = ToDb;
                if (LedcodeDr != "1" && LedcodeDr != "28")
                {
                    //transferledger(ToDb, LedcodeDr);
                }

                //if (LedcodeDr != "1" && LedcodeDr != "28")
                //{
                //    transferledger(ToDb, LedcodeDr);
                //}
                Generalfunction.TempCompanyname = ToDb;

                //transferbcodewithitem(Dcode,);
               // transferbcodewithitemstock(Dcode, ToDb);


                Generalfunction.TempCompanyname = ToDb;
                string maxofsi= "";
                maxofsi = _dbtask.ExecuteScalar("SELECT paramvalue   FROM  " + ToDb + "..Tblparamlist where paramname='MaxofSI' ");

                long lonval=0; 


                CommonClass._Businessissue.InsertBusinessIssuePara(0,Convert.ToInt64(maxofsi), maxofsi, Vtype, Dcode, IDate,
                    LedCodeCr, LedcodeDr, Amt, Remarks, EmpId, DiscAmt, InvDisc, TaxAmt, Cooly, AdvanceAmt,
                    AgentId, Pvno, TaxId, Tename, CpDiscount, mpayment,"","", Convert.ToInt64(lonval) ,"","","","","","", "","",0,"");
                
                
            
                
                
                Generalfunction.TempCompanyname = "";
                //CommonClass._Businessissue.InsertBusinessIssuePara(
                VoCodes = CommonClass.Ds.Tables[0].Rows[i]["issuecode"].ToString();
                CommonClass.Ds1 = CommonClass._Dbtask.ExecuteQuery("select * from tblissuedetails where "+
              "  issuecode  in (" + VoCodes + ") and vtype='" + Vtype + "' and ledcode ='" + LedCodeCr + "'");

                for (int k = 0;k < CommonClass.Ds1.Tables[0].Rows.Count; k++)
                {
                      long CategoryId;
                      string ManId;

                      long  SlNoLng ;
                      string  PCodeStr ;
                      long  UnitIdLng ;
                      string  BatchIdStr ;
                      long  MultiRateIdLng ;
                      double  QtyDb ;
                      double  QtyFreeDb ;
                      double  Mrp ;
                      double  RateDb ;
                      double  DiscDb ;
                      double  BillDisc ;
                      double  TaxRateDb ;
                      double  NetAmtDb ;
                      string  ItemNoteStr ;
                     // string Ledcode;
                     // string Vtype;
                      double  Taxper ;
                      string  SlnoTracking ;

                      SlNoLng =Convert.ToInt64(CommonClass.Ds1.Tables[0].Rows[k]["slno"]);
                      PCodeStr = CommonClass.Ds1.Tables[0].Rows[k]["pcode"].ToString();
                      UnitIdLng = Convert.ToInt64(CommonClass.Ds1.Tables[0].Rows[k]["unitid"]);
                      BatchIdStr = CommonClass.Ds1.Tables[0].Rows[k]["batchid"].ToString();
                      MultiRateIdLng = Convert.ToInt64(CommonClass.Ds1.Tables[0].Rows[k]["multirateid"]);
                      QtyDb = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["qty"]);
                      QtyFreeDb = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["freeqty"]);
                      Mrp = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["mrp"]);
                      RateDb = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["rate"]);
                      DiscDb = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["discrate"]);

                      BillDisc = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["billdisc"]);
                      TaxRateDb = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["taxrate"]);
                      NetAmtDb = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["netamt"]);
                      ItemNoteStr = CommonClass.Ds1.Tables[0].Rows[k]["itemnote"].ToString();
                      Ledcode = CommonClass.Ds1.Tables[0].Rows[k]["ledcode"].ToString();
                      Vtype = CommonClass.Ds1.Tables[0].Rows[k]["vtype"].ToString();
                      Taxper = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["taxper"]);
                      SlnoTracking = CommonClass.Ds1.Tables[0].Rows[k]["slnotracking"].ToString();
                      DiscDb =DiscDb+ CommonClass._Dbtask.znlldoubletoobject(CalcItemDiscount(TTAmount,CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds1.Tables[0].Rows[k]["netamt"])));
                      DateTime Exdate = CommonClass._Dbtask.ZnullDatetime(CommonClass.Ds1.Tables[0].Rows[k]["slnotracking"].ToString());
                          
                    
                    
                    /*Item Category*/
                      
                      temp1 = CommonClass._ItemCategory.SpecificField(CommonClass._Itemmaster.SpecificField(PCodeStr, "categoryid"), "category");
                      //Generalfunction.TempCompanyname = ToDb;
                      //temp1 = CommonClass._Dbtask.ExecuteScalar("select categoryid from tblitemcategory where category='" + temp1 + "'");
                      //if (temp1 == "")
                      //{
                      //    CommonClass._ItemCategory.IdCategory();
                      //    CategoryId = CommonClass._ItemCategory.CategoryIdLng;
                      //    Generalfunction.TempCompanyname = "";
                      //    //CommonClass._ItemCategory.CategoryNameStr = CommonClass._ItemCategory.SpecificField(CategoryId, "category");
                      //    //CommonClass._ItemCategory.RemarkStr = CommonClass._ItemCategory.SpecificField(CategoryId, "remarks");
                      //    Generalfunction.TempCompanyname = ToDb; 
                      //    CommonClass._ItemCategory.InsertItemCategory();
                      //}
                      //else
                      //{
                      //    CategoryId = 0;
                      //}

                      /*For ItemMaster*/
                      Generalfunction.TempCompanyname = "";
                      string OldPid;
                      OldPid = PCodeStr;
                      //temp1 = CommonClass._Itemmaster.SpecificField(PCodeStr, "itemname");
                      //Generalfunction.TempCompanyname = ToDb;
                      //CommonClass.Ds3 = CommonClass._Dbtask.ExecuteQuery("select itemid from tblitemmaster where itemname='" + temp1 + "'");

                      //if (CommonClass.Ds3.Tables[0].Rows.Count == 0)
                      //{
                      //    Generalfunction.TempCompanyname = ToDb;
                      //    CommonClass._Itemmaster.IdItemName();
                      //    PCodeStr = CommonClass._Itemmaster.ItemIdLng.ToString();
                      //    Generalfunction.TempCompanyname = "";
                      //    string ItemCodeStr = CommonClass._Itemmaster.SpecificField(OldPid, "itemcode");
                      //    string ItemNameStr = CommonClass._Itemmaster.SpecificField(OldPid, "itemname");
                      //    long CategoryIdLng;
                      //    if (CategoryId == 0)
                      //    {
                      //        CategoryIdLng = Convert.ToInt64(CommonClass._Itemmaster.SpecificField(OldPid, "categoryid"));
                      //    }
                      //    else
                      //    {
                      //        CategoryIdLng = CategoryId;
                      //    }
                      //    string DescriptionStr = CommonClass._Itemmaster.SpecificField(OldPid, "description");
                      //    double MRPDb = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "mrp"));
                      //    double SRateDb = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "srate"));
                      //    double PRateDb = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "prate"));
                      //    long ManufacturerLng = Convert.ToInt64(CommonClass._Itemmaster.SpecificField(OldPid, "manufacturer"));
                      //    int StatusInt = Convert.ToInt16(CommonClass._Itemmaster.SpecificField(OldPid, "status"));
                      //    double AgentCommisionDb = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "agentcommision"));
                      //    double CoolyDb = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "cooly"));
                      //    double MinStockDb = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "minstock"));
                      //    string Rack = CommonClass._Itemmaster.SpecificField(OldPid, "rack");
                      //    double ReorderStockDb = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "reorder"));
                      //    double MaximumDb = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "maximum"));
                      //    long TaxSlabIdLng = Convert.ToInt64(CommonClass._Itemmaster.SpecificField(OldPid, "slabid"));
                      //    double Balance = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "balance"));
                      //    string Unit = CommonClass._Itemmaster.SpecificField(OldPid, "unit");
                      //    double VAT = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "vat"));
                      //    double CST = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "cst"));
                      //    double Purtax = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "purtax"));
                      //    int Incs = Convert.ToInt16(CommonClass._Itemmaster.SpecificField(OldPid, "incs"));
                      //    int Incp = Convert.ToInt16(CommonClass._Itemmaster.SpecificField(OldPid, "incp"));
                      //    string ItemClass = CommonClass._Itemmaster.SpecificField(OldPid, "itemclass");
                      //    string Sizelessname = CommonClass._Itemmaster.SpecificField(OldPid, "sizelessname");
                      //    string PLU = CommonClass._Itemmaster.SpecificField(OldPid, "plu");
                      //    string Unit2 = CommonClass._Itemmaster.SpecificField(OldPid, "Unit2");
                      //    double UnitAmnt1 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "UnitAmount1"));
                      //    double Unitamnt2 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(OldPid, "UnitAmount2"));
                      //    long Ledid =Convert.ToInt64(CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(OldPid, "ledid")));
                        
                      //    Generalfunction.TempCompanyname = ToDb;
                      //    /*Item Master*/
                      //    if (Convert.ToInt64(PCodeStr) > 100)
                      //    {
                      //      //  PCodeStr=
                      //    }
                          //CommonClass._Itemmaster.InsertItemsPara(Convert.ToInt64(PCodeStr), ItemCodeStr, ItemNameStr, CategoryIdLng, DescriptionStr, MRPDb, SRateDb,
                          //PRateDb, ManufacturerLng, StatusInt, AgentCommisionDb, CoolyDb, MinStockDb, Rack,
                          //ReorderStockDb, MaximumDb, TaxSlabIdLng, Balance, Unit, VAT, CST, Purtax, Incs, Incp,
                          //ItemClass, Sizelessname, PLU, Unit2, UnitAmnt1, Unitamnt2,Ledid);
                      //}
                      //else
                      //{
                      //    PCodeStr = CommonClass.Ds3.Tables[0].Rows[0][0].ToString();
                      //}
                      /*Inventory */
                     // TableTransferOneDBToOther("tblinventory", " where  sales !=0 and ledcode='" + LedCodeCr + "' and vcode='" + IssuecodeOld + "' and pcode in (" + PCodeStr + ")");

                      temp1 = CommonClass._Itemmaster.SpecificField(PCodeStr, "categoryid");
                      
                    
                    //transferbcodewithitem(temp1, PCodeStr, BatchIdStr, ToDb);

                    Generalfunction.TempCompanyname = ToDb;

                      /*Issue Details*/
                    CommonClass._IssueDetails.InsertIssueDetailsPara(Convert.ToInt64(maxofsi), SlNoLng, PCodeStr, UnitIdLng, BatchIdStr, Convert.ToInt16(MultiRateIdLng),
                      QtyDb, QtyFreeDb, Mrp, RateDb, DiscDb, BillDisc, TaxRateDb, NetAmtDb, ItemNoteStr, Ledcode, Vtype, Taxper, SlnoTracking, Exdate, Amt, "");


                     
                
                
                
                }
                TableTransferOneDBToOther("tblgeneralledger", " where  vtype='" + Vtype + "' and vno='" + maxofsi + "' and Refno='" + LedCodeCr + "'");

                Generalfunction.TempCompanyname = ToDb;
                int newval=Convert.ToInt32(  _dbtask.znlldoubletoobject( maxofsi )  + 1);
                _dbtask.ExecuteNonQuery("update tblparamlist set paramvalue='" + _dbtask.znllString(newval) + "' where paramname='MaxofSI' " );

                Generalfunction.TempCompanyname = ""; ;




                if(chkdeleteinvoice.Checked==true)
                {
                    _dbtask.ExecuteNonQuery("DELETE from tblbusinessissue where  vno ='"+  Vno+"'  and issuetype='SI'  ");

                    _dbtask.ExecuteNonQuery("DELETE from tblISSUEDETAILS where  issuecode ='" + Vno + "'  and vtype='SI'  ");
                    _dbtask.ExecuteNonQuery("DELETE from tblgeneralledger where  vno ='" + Vno + "'  and vtype='SI'  ");
                }
            
            }
               
            
        }

        public void transferledger(string db,string lid)
        {
            Generalfunction.TempCompanyname = db;
            string existid = "";
            existid = _dbtask.ExecuteScalar("SELECT max(lid)+1 FROM  "+db+"..Tblaccountledger ");
            Generalfunction.TempCompanyname = "";


            LedcodeDr = existid;
            long IId=Convert.ToInt64( existid);
            string ILname=CommonClass._Ledger.GetspecifField("lname",lid)   ;
            string IAliasName=CommonClass._Ledger.GetspecifField("LAliasName",lid)   ;
            long IGid=Convert.ToInt64(CommonClass._Ledger.GetspecifField("AGroupId",lid) )  ;
            string IAddress=CommonClass._Ledger.GetspecifField("Address",lid)   ;
            string Iphone=CommonClass._Ledger.GetspecifField("Phone",lid)   ;
            string IMobile = CommonClass._Ledger.GetspecifField("Mobile", lid);
            
            double IDiscperc = _dbtask.znlldoubletoobject(CommonClass._Ledger.GetspecifField("DiscPer", lid));
            string ITaxReg = CommonClass._Ledger.GetspecifField("TaxregNo", lid);
            string Iemail = CommonClass._Ledger.GetspecifField("email", lid);
            string IArea = CommonClass._Ledger.GetspecifField("Area", lid);
            double ICreditDays = _dbtask.znlldoubletoobject(CommonClass._Ledger.GetspecifField("CreditDays", lid));
            double ICreLimi = _dbtask.znlldoubletoobject(CommonClass._Ledger.GetspecifField("CreditLimit", lid));
            string IOthers = CommonClass._Ledger.GetspecifField("Other", lid);

            double IBalance = _dbtask.znlldoubletoobject(CommonClass._Ledger.GetspecifField("Balance", lid));
            double ICommi = _dbtask.znlldoubletoobject(CommonClass._Ledger.GetspecifField("Commision", lid));
            long ICplan = Convert.ToInt64(CommonClass._Ledger.GetspecifField("cplan", lid));
            int ILstatus = Convert.ToInt32(CommonClass._Ledger.GetspecifField("lstatus", lid));
            int ILstatus2 = Convert.ToInt32(CommonClass._Ledger.GetspecifField("lstatus2", lid));
            string ICst = CommonClass._Ledger.GetspecifField("cst", lid);
            double ICpBalance = _dbtask.znlldoubletoobject(CommonClass._Ledger.GetspecifField("cpbalance", lid));

            int IUsecard = Convert.ToInt32(CommonClass._Ledger.GetspecifField("usecard", lid));
            string custmrcode = CommonClass._Ledger.GetspecifField("customercode", lid);
            string cityy = CommonClass._Ledger.GetspecifField("cityy", lid);
            string Lcountryname = CommonClass._Ledger.GetspecifField("Lcountryname", lid);
            string postcode = CommonClass._Ledger.GetspecifField("postcode", lid);
            string LDistrict = CommonClass._Ledger.GetspecifField("LDistrict", lid);


            Generalfunction.TempCompanyname = db;

            CommonClass._Ledger.InsertLedgerPara(IId, ILname, IAliasName, IGid, IAddress,
             Iphone, IMobile, IDiscperc, ITaxReg, Iemail, IArea,
            ICreditDays, ICreLimi, IOthers, IBalance, ICommi,
             ICplan,ILstatus, ILstatus2,ICst,ICpBalance,IUsecard, custmrcode, cityy, Lcountryname, postcode, LDistrict);


            
        }

        public void transferbcodewithitem(string cate, string pcode, string batch, string db)
        {
            Generalfunction.TempCompanyname = db;
            string existidcat = "";
            existidcat = _dbtask.ExecuteScalar("SELECT max(CategoryId)+1 FROM  " + db + "..TblItemCategory ");
            if (cate != "0")
            {

                recatid = existidcat;
                Generalfunction.TempCompanyname = "";

                long CategoryIdLng = Convert.ToInt64(existidcat);
                string CategoryNameStr = CommonClass._category.SpecificField(cate, "Category");
                string RemarkStr = CommonClass._category.SpecificField(cate, "Remarks");

                Generalfunction.TempCompanyname = db;

                if (CommonClass._category.SameNamealreadyexist(CategoryNameStr) == false)
                {
                    Generalfunction.TempCompanyname = db;
                    CommonClass._category.InsertcatPara(CategoryIdLng, CategoryNameStr, RemarkStr);
                }



            }
            else
            {
                recatid = cate; 
            }

            string existipcode = "";
            existipcode = _dbtask.ExecuteScalar("SELECT max(ItemId)+1 FROM  " + db + "..TblItemmaster ");

            if (existipcode == "")
            {
                existipcode = "1";
            }
           rePCODEid= existipcode;

            Generalfunction.TempCompanyname = "";

            long IItemid=Convert.ToInt64(existipcode);
            string IItemcode = CommonClass._Item.SpecificField(pcode, "ItemCode");
            string IItemname = CommonClass._Item.SpecificField(pcode, "ItemName");
            long ICategoryId = Convert.ToInt64(recatid); //CommonClass._Item.SpecificField(pcode, "CategoryId"));
            string IDescription = CommonClass._Item.SpecificField(pcode, "Description");
            double IMrp =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "MRP"));
            double ISrate =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "SRate"));
            double IPrate =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "Prate"));
            long Imanfacturer =Convert.ToInt64( CommonClass._Item.SpecificField(pcode, "Manufacturer"));

            int IStatus =Convert.ToInt32(  CommonClass._Item.SpecificField(pcode, "Status"));
            double IAgentCommision =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "AgentCommision"));
            double ICooly =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "cooly"));
            double IMinstock =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "Minstock"));
            string IRack = CommonClass._Item.SpecificField(pcode, "rack");
            double IReorder =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "reorder"));
            double IMaximum =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "maximum"));
            long ITaxid = 0;//Convert.ToInt64( CommonClass._Item.SpecificField(pcode, "taxslabid"));

            double IBalance =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "Balance"));
            string IUnit = CommonClass._Item.SpecificField(pcode, "Unit");
            double IVat =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "VAT"));
            double ICst =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "CST"));
            double IPurtax =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "Purtax"));
            int IIncs =Convert.ToInt32(  CommonClass._Item.SpecificField(pcode, "incs"));
            int IIncp =Convert.ToInt32(  CommonClass._Item.SpecificField(pcode, "incp"));
            string IItemclass = CommonClass._Item.SpecificField(pcode, "itemclass");

            string ISizelessname = CommonClass._Item.SpecificField(pcode, "Sizelessname");
            string IPlus = CommonClass._Item.SpecificField(pcode, "plu");
            string IUnit2 = CommonClass._Item.SpecificField(pcode, "Unit2");
            double IUnitAmnt1 =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "UnitAmount1"));
            double IUnitAmnt2 =_dbtask.znlldoubletoobject( CommonClass._Item.SpecificField(pcode, "UnitAmount2"));
            float ILedid = float.Parse(CommonClass._Item.SpecificField(pcode, "Ledid"));
            string Localaungage = CommonClass._Item.SpecificField(pcode, "llang");
            string Bunit = CommonClass._Item.SpecificField(pcode, "Bunit");
            int Usingmechine =Convert.ToInt32( CommonClass._Item.SpecificField(pcode, "Usingmechine"));
            string ItemnoteStr = CommonClass._Item.SpecificField(pcode, "Itemnote");

            Generalfunction.TempCompanyname = db;

            CommonClass._Item.InsertItemsPara(IItemid, IItemcode, IItemname, ICategoryId, IDescription,
             IMrp, ISrate, IPrate, Imanfacturer, IStatus, IAgentCommision,
                 ICooly, IMinstock, IRack, IReorder, IMaximum,
                  ITaxid, IBalance, IUnit, IVat, ICst, IPurtax,
                IIncs, IIncp, IItemclass, ISizelessname, IPlus,
              IUnit2, IUnitAmnt1, IUnitAmnt2, ILedid, Localaungage,
                 Bunit, Usingmechine, ItemnoteStr);


            Generalfunction.TempCompanyname = db;
            string existbatch = "";
            if (CommonClass._Batch.SameNamealreadyexist(batch) == false)
            {
                Generalfunction.TempCompanyname = "";
                string Bcode=batch;
                string Itemid = rePCODEid; //CommonClass._Batch.GetSpecificFieldByBarcode("Itemid", batch);
                string Costcenter = CommonClass._Batch.GetSpecificFieldByBarcode("Costcenter", batch);
                string Depo = CommonClass._Batch.GetSpecificFieldByBarcode("Depo", batch);
                string Bid = CommonClass._Batch.GetSpecificFieldByBarcode("Bid", batch);
                string Ledcode = CommonClass._Batch.GetSpecificFieldByBarcode("Ledcode", batch);

                string Recptcode = CommonClass._Batch.GetSpecificFieldByBarcode("Recptcode", batch);
                double Mrp =_dbtask.znlldoubletoobject( CommonClass._Batch.GetSpecificFieldByBarcode("mrp", batch));
                double Srate = _dbtask.znlldoubletoobject(CommonClass._Batch.GetSpecificFieldByBarcode("srate", batch));
                double Prate = _dbtask.znlldoubletoobject(CommonClass._Batch.GetSpecificFieldByBarcode("prate", batch));
                double Lastrate = _dbtask.znlldoubletoobject(CommonClass._Batch.GetSpecificFieldByBarcode("Lastrate", batch));
                string baseU = CommonClass._Batch.GetSpecificFieldByBarcode("baseU", batch);
                double Unconv = _dbtask.znlldoubletoobject(CommonClass._Batch.GetSpecificFieldByBarcode("unconv", batch));
                DateTime ManDate = _dbtask.ZnullDatetime(CommonClass._Batch.GetSpecificFieldByBarcode("ManDate", batch));
                DateTime ExDate = _dbtask.ZnullDatetime(CommonClass._Batch.GetSpecificFieldByBarcode("exdate", batch));


                Generalfunction.TempCompanyname = db;

                CommonClass._Batch.InsertbcodePara(Bcode, Itemid, Costcenter, Depo, Bid, Ledcode,
                 Recptcode, Mrp, Srate, Prate, Lastrate, baseU, Unconv, ManDate, ExDate);

                Generalfunction.TempCompanyname = "";

            }




        }



        public void transferbcodewithitemstock(string areaid, string db)
        {
            
            Generalfunction.TempCompanyname = db;
            string existid = "";
            existid = _dbtask.ExecuteScalar("SELECT max(Dcode)+1 FROM  " + db + "..TblDepot ");

            if (areaid!="0")
            {
            Generalfunction.TempCompanyname = "";

            long Dcode = Convert.ToInt64(existid);
            string Dname = CommonClass._Depot.GetspecifField("Dname", areaid);
            int VehicleNo = Convert.ToInt32(CommonClass._Depot.GetspecifField("VehicleNo", areaid));
            string Address = CommonClass._Depot.GetspecifField("Address", areaid);
            string City = CommonClass._Depot.GetspecifField("City", areaid);
            string Pin = CommonClass._Depot.GetspecifField("Pin", areaid);
            string PhoneNo = CommonClass._Depot.GetspecifField("Phoneno", areaid);
            string Mobile = CommonClass._Depot.GetspecifField("Mobile", areaid);
            string Cpersone = CommonClass._Depot.GetspecifField("Cperson", areaid);
            string RegNo = CommonClass._Depot.GetspecifField("RegNo", areaid);
            string Lisenseno = CommonClass._Depot.GetspecifField("Lisenseno", areaid);
            string Description = CommonClass._Depot.GetspecifField("Description", areaid);

            Generalfunction.TempCompanyname = db;
            CommonClass._Depot.InsertdepotPara(Dcode,Dname ,VehicleNo,Address , City ,Pin,PhoneNo, Mobile, Cpersone,
               RegNo, Lisenseno,Description );
            }
        }

        public void TableTransferOneDBToOther(string TableName, string Where)
        {
           // CommonClass._Dbtask.ExecuteNonQuery("delete from " + ToDb + ".." + TableName + "");
             Sql = "select column_name from INFORMATION_SCHEMA.COLUMNS " +
                         " where TABLE_NAME='" + TableName + "'";
             Temp = CommonClass._SelectReport.Showindataset(Sql);
             CommonClass._Dbtask.ExecuteNonQuery("INSERT INTO " + ToDb + ".." + TableName + " (" + Temp + ") " +
                                 " SELECT " + Temp + " FROM  " + FromDb + ".." + TableName + " "+Where+"");
        }

        private void comsourcevoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillBusinessissue("SI", "");
        }

        private void txtdiscounttransfer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
        }

        private void cmdtransferopeningbalance_Click(object sender, EventArgs e)
        {
            Generalfunction.TempCompanyname = "";
            Sql = "select column_name from INFORMATION_SCHEMA.COLUMNS  where TABLE_NAME='TblGeneralLedger'";


         string  Temp = CommonClass._SelectReport.Showindataset(Sql);
         FromDb = CommonClass._Dbtask.currentcompany();
         ToDb = comtocompany.Text;
         CommonClass._Dbtask.ExecuteNonQuery("INSERT INTO " + ToDb + "..TblGeneralLedger (" + Temp + ") " +
                               " SELECT " + Temp + " FROM  " + FromDb + "..TblGeneralLedger");
        }

        //TableTransferOneDBToOther("tblbusinessissue", "  where issuecode in (" + VoCodes + ")");
        //        /*For Agent*/
        //        Temp = CommonClass._SelectReport.Showindataset(" select agent from tblbusinessissue where issuecode in (" + VoCodes + ") ");
        //       TableTransferOneDBToOther("tblaccountledger", "  where lid in (" + Temp + ")");

        //        /*For Employee*/
        //        Temp = CommonClass._SelectReport.Showindataset(" select empid from tblbusinessissue where issuecode in (" + VoCodes + ") ");
        //       TableTransferOneDBToOther("tblaccountledger", "  where lid in (" + Temp + ")");
        //       TableTransferOneDBToOther("tblemployeemaster", "  where empid in (" + Temp + ")");

        //        /*IssueDetails*/
        //       TableTransferOneDBToOther("tblissuedetails", "  where issuecode in (" + VoCodes + ")");
        //       Temp = CommonClass._SelectReport.Showindataset(" select pcode from tblissuedetails where issuecode in (" + VoCodes + ") ");
        //       TableTransferOneDBToOther("tblbatch", "  where itemid in (" + Temp + ")");
        //       TableTransferOneDBToOther("tblitemmaster", "  where itemid in (" + Temp + ")");
        //       Temp = CommonClass._SelectReport.Showindataset(" select pcode from tblissuedetails where issuecode in (" + VoCodes + ") ");
        //       Temp = CommonClass._SelectReport.Showindataset(" select categoryid from tblitemmaster where itemid in (" + Temp + ") ");
        //        TableTransferOneDBToOther("tblitemcategory", "  where categoryid in (" + Temp + ")");
        //        Temp = CommonClass._SelectReport.Showindataset(" select pcode from tblissuedetails where issuecode in (" + VoCodes + ") ");
        //        Temp = CommonClass._SelectReport.Showindataset(" select manufacturer from tblitemmaster where itemid in (" + Temp + ") ");
        //       TableTransferOneDBToOther("tblmanufacturer", "  where manufacturer in (" + Temp + ")");
        //      TableTransferOneDBToOther("tblinventory", "  where vcode in (" + VoCodes + ") and sales !=0 ");


    }
}
