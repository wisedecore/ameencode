using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication2

{
    public partial class Frmsettings : Form
    {
        public Frmsettings()
        {
            InitializeComponent();
        }
        RegistryKey regKey = Registry.CurrentUser;
        DBTask _Dbtask = new DBTask();
        DataSet Ds = new DataSet(); DataSet DsM = new DataSet();
        public string stss = "";
        public string opname = ""; public int rowindex;
        public string MMbcode = ""; public int rowindexSize;
        public int columnindex;
        ClsParamlist _Paramlist = new ClsParamlist();
        clsmnusettings _Mnusettings = new clsmnusettings();
        Clssettings _Settings = new Clssettings();
        ClsCompanyCreate _Companycreate = new ClsCompanyCreate();
        ClsMostmoving _mmove = new ClsMostmoving();
        public  bool Ischecked;
        public bool Ischecked1;
        double Coresponding;
        NextGFuntion _Nextg = new NextGFuntion();
        public double automaticmodeSET = -1;
        public double purchprintwhile = -1;
        public double EnableMostmove = -1;
        public double userwisedisc = -1;
        public double bcoderaterounding = -1;
        public double RPdetails = -1;
        public  string Pprintinclusive;
        public double enableservice;
        public double enablefooter;
        public double footrStrt; public double footrmidd;
        public double QRvisible;
        public double Secondprinter;
        public double enbleWrrnty;
        public string EditPItemName = "1";
        public string EditPitemCode = "1";
        public string amtwords = "1";
        public double bcodllang = -1; public double bcodcodevisibl = -1;
        public double crlimiton = -1; public double headervisibl = 1;
        public double vehicle = -1; public double saleitemroundoff = -1;
        public double mtrread = -1;
        public double empsale = -1; public double listvew = -1; public double producttop = -1;
        public double bcodsrateenable = -1; public double exandmandate = -1;
        public string Codewidth = " ";
        public double prateinitemlist = -1;
        public double weignRate = -1;
        public double weignQTY = -1;
        public double stockbottom = -1;
        public string Codewidthprint = " ";
        public double automodepurchase = -1;
        public double customerwisetax = -1;
        public double bcodeBold = 1;
        public double datetwoline = -1;
        public double prefixinSR = -1;
        

        public double ctrlQdatewise = -1;
        public string bcodehight = " ";
        public string Bitemsize = " ";
        public string Bcompnysize = " ";
        public string Bratesize = " ";
        public double Stockshow = -1;
        public string Bitemcodesize = " ";
        public string Blangsize = " ";

        public static string Estimatepwd;
        public double Updateitemrate=-1;
        public double Itemwisecomm=-1;
        public double CurrDec;
        public double StockDec;
        public double Batchcode=-1;
        public double Singlebarcode = -1;
        public double Useasbarcode;
        public double POS=-1;
        public double Payroll=-1;
        public double Partyproject = -1;
        public double Production=-1;
        public double Roundoff=-1;
        public string Dccurrency;
        public string Dcstock;
        public string Majorcurr;
       
        public string FL1="";
        public string FL2="";
        public string FL3="";
        public string FL4="";
        public string FL5="";

        public string MinCurr;

        public string DefTax;
        public string DefPPay;
        public string DefSPay;
        public string DefStockarea;
        public string DefSalesman;

        public string Autobackuppath1;
        public string Autobackuppath2;
        public string Autobackuppath3;
        public string Autobackuppath4;

        FolderBrowserDialog FBD = new FolderBrowserDialog();

        public string Printerselect; public string Printerselectpurch;
        public string BarcodePrintin;
        public string BarcodePrefix;
        public double BarcodePrintSelect=-1;
        public double BarcodePrintLogo = -1;
        public double PrintMandateBarcode=-1;
        public double PrintNote1Barcode=-1;
        public double PrintNote2Barcode=-1;
        public string PrintFooter;
        public double PrintNote2SupplierBarcode=-1;
        public double PrintsecondlangagueBarcode = -1;
        public double CompanyNameAsBarcodeHeading = -1;
        public double PrintBalance = -1;
        public double SaveZeroPrate = -1;
        public double PrintL = -1;
        public double PrintCon = -1;

        public double Mrate=-1;
        public double Munit=-1;
        public double Stockarea=-1;
        public double Tax=-1;
        public  double Costcenter=-1;
        public double Sizes = -1;
        public double Flex = -1;
        public double Zerotaxamount = -1;

        public double SerialNoTracking = -1;
        public double Customerpoint = -1;
        public double ItemSearch = -1;
        public double SCRM = -1;
        public double Wieghtmachine = -1;
        public double Supplierwiseitem = -1;
        public double Pharmacy = -1;

        public double Pexciseduty = -1;
        public double EditSGrossamount=-1;
        public double VSSrate = -1;
        public double Editsqty = -1;
        public double SRemoveDublicateEntry=-1;
        public double Editsrate=-1;
        public double Editprate=-1;
        public double sitemdiscount=-1;
        public double pitemdiscount=-1;
        public double sfree=-1;
        public double pfree=-1;
        public double SalesArea=-1;
        public double Savezeroratesales = -1;
        public double Salessearchingmode = -1;
        public double Poldbalance = -1;
        public double Sitemnote = -1;
        public double Printnotax = -1;
        public double baseunit = -1; public double tailor = -1;
        public double Deliverynote=-1;
        public double Salesest=-1;
        public double Salesorder=-1;
        public double Salesreturn=-1;
        public double UpdateSrate=-1;
        public double UpdateSrateInSale = -1;
        public double SFocusFirstRow = -1;
        public double Sagent = -1;
        public double Semployee = -1;
        public double SDeactiveEmployee = -1;
        public double Scashcadjet = -1;
        public double SinvoiceDiscount = -1;

        public double MeterialReceipt=-1;
        public double Purchaseorder=-1;
        public double Purchaseest=-1;
        public double Purchasereturn=-1;
        public double Updateprate=-1;
        public double UpdateMrp=-1;
        public double Pagent = -1;
        public double Pemployee = -1;
        public double Peditgrossamount = -1;
        public double Pitemnote1 = -1;
        public double Pitemnote2 = -1;
        public double Visibleprate = -1;
        public double SaveZeroRate = -1;
        public double Salerateincludetax = -1;
        public double Pbillingdate = -1;
        /*Warnings*/
        public string WCreditLimit;
        public string WCashLimit;
        /***********************************/
       // public string Defsalesman;
        public string Defbank;
       // public string Defstockarea;
        public string DefCashAccount;
        public string columname;
        public double Creditlimit=-1;
       
        public double Negcash=-1;
        

        public double Autobackup = -1;


        /*Starttup****************/
        public double Startupstock = -1;
        public double startupBalance = -1;

        public string Pname;
        public string Ptype;
        public string Pvalue;
        public bool Transactionisexsting = false;
        public string txt;
        private void Frmsettings_KeyPress(object sender, KeyPressEventArgs e)
        {
             txt = txt + e.KeyChar.ToString();
            if (e.KeyChar == 27)
            {
                this.Close();
            }
            txt=txt.ToLower();
            if (txt == "zat585")
            {
                ChkEProduction.Visible = true;
                Chkesize.Visible = true;
                chkflex.Visible = true;
                chkcustomerpoint.Visible = true;
                lblsmsbalance.Visible = true;
                txtsmsbalance.Visible = true;
                chkcrm.Visible = true;
                chkweightmachine.Visible = true;
                chkenpharmacy.Visible = true;
                Grpsetestimatepassword.Visible = true;
            }
            if (txt == Estimatepwd)
            {
                chkshowestimateledger.Visible = true;
            }
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.TreeViewConvertion(TRMain);

                CommonClass._Language.PanelBasedConversion(PnlGeneral);
                CommonClass._Language.GroupBoxConvertion(Grpbatchenable);
                CommonClass._Language.GroupBoxConvertion(groupBox2);

                CommonClass._Language.PanelBasedConversion(Pnlcreate);
                CommonClass._Language.GroupBoxConvertion(GrpItemSearch);

                CommonClass._Language.PanelBasedConversion(PnlSales);

                CommonClass._Language.PanelBasedConversion(Pnlpurchase);

                CommonClass._Language.PanelBasedConversion(pnlvoucherType);

                CommonClass._Language.PanelBasedConversion(pnldefault);

                CommonClass._Language.PanelBasedConversion(pnlwarnings);

                CommonClass._Language.PanelBasedConversion(Pnlaoutobackup);

                CommonClass._Language.PanelBasedConversion(Pnlstartup);
            }
        }
        public void SetControleText()
        {
            ChkEstockarea.Text = NextGFuntion.StockAreaName;
        }
        public void SettPnel()
        {
            Panelvisible(PnlGeneral);
        }
        public void Panelvisible(Panel Pnl)
        {
            Pnl.Visible = true;
            Pnl.Location = new System.Drawing.Point(154, 30);
            Pnl.Size = new System.Drawing.Size(770, 550);//538
            //Pnl.BackColor = System.Drawing.Color.FromArgb(214, 246, 214);
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Panel)
                {
                    string a = this.Controls[i].Name.ToString();
                    if (a != "pnltop" && a != "pnlbottom" && a != "pnlriqht" && a != "Pnlleft" && a != Pnl.Name)
                    {
                        this.Controls[i].Visible = false;
                    }
                }

            }
        }

        private void Frmsettings_Load(object sender, EventArgs e)
                {
            Fillcombo();
            retrive();
            SetControleText();
            TransactionIsexstistFu();
            SettPnel();
            Setcontrolebeha();
            ChangeLanguage();
            //gridmostmove.Columns.Clear();
            gridmostmove.Rows.Clear();
           retrievemostmove();
            CommonClass._Nextg.FormIcon(this);
        }

        public void retrievemostmove()
        {
            int Count = 0;
            gridmostmove.Columns.Clear();

            DsM = _Dbtask.ExecuteQuery("select mmbcode as Batch,mmname as  Item,MMpcode from  TblMostMoving ");

            gridmostmove.DataSource = DsM.Tables[0];
            for (int M = 0; M < gridmostmove.Columns.Count; M++)
            {
                if (gridmostmove.Columns[M].Name.ToString() == "MMpcode")
                    gridmostmove.Columns[M].Visible = false;
                gridmostmove.Columns["Batch"].Width = 190;
                gridmostmove.Columns["Item"].Width = 150;
            }
            
            
            
            
            
            
            
            //for (int K = 0; K < DsM.Tables[0].Rows.Count; K++)
            //{
            //    if (DsM.Tables[0].Rows.Count>0)
            //    {
                    
            //        string uu= _Dbtask.znllString(DsM.Tables[0].Rows[K]["MMbcode"]);
            //        gridmostmove.Rows[K].Cells["Clnbcode"].Value = _Dbtask.znllString(DsM.Tables[0].Rows[K]["MMbcode"]);
            //        gridmostmove.Rows[K].Cells["Clnpname"].Value = _Dbtask.znllString(DsM.Tables[0].Rows[K]["MMname"]);
            //        gridmostmove.Rows[K].Cells["Clnpname"].Tag = _Dbtask.znllString(DsM.Tables[0].Rows[K]["MMpcode"]);
                    
                
            //    }
            //}
        }

        public void ShowAllitemssts()
        {
            griditems.Rows.Clear();
            int Count = 0;
            Ds = _Dbtask.ExecuteQuery("select * from  TblOtherprintsets ");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                if (_Dbtask.znllString(Ds.Tables[0].Rows[i]["OPname"]) != "")
                {

                    Count = griditems.Rows.Add(1);
                    opname = _Dbtask.znllString(Ds.Tables[0].Rows[i]["OPname"]);
                    stss = Ds.Tables[0].Rows[i]["OPstatus"].ToString();
                    griditems.Rows[Count].Cells[1].Value = opname;
                    griditems.Rows[Count].Cells[0].Value = stss;
                }
            }
        }
        public void Fillcombo()
        {
            CommonClass._Employee.FillCombo(Comdefsalesman);
            CommonClass._Depot.FillCombo(Comdefstockarea);
            GETsecondprintmodel();
            ShowAllitemssts();
        }

        public void TransactionIsexstistFu()
        {

            Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where vtype='SI' or vtype='PI'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Transactionisexsting = true;
            }
            else
            {
                Transactionisexsting = false;
            }
        }
        public void Setcontrolebeha()
        {
            Behparamlist();
            Behmenusettings();
        }
        public void Behparamlist()
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblparamlist");
            string value;

            /*For Selected Printer*/
            string temppurch = CommonClass._Dbtask.GetPrinterSelectpurchaseseting();
            string tempp = CommonClass._Dbtask.GetPrinterSelect();
            if (tempp == "1")
            {
                raddot3.Checked = true;
            }
            if (tempp == "2")
            {
                raddot6.Checked = true;
            }
            if (tempp == "3")
            {
                raddot10.Checked = true;
            }

            if (tempp == "A4Preprint2")
            {
            combprintselectn.SelectedIndex = 3;
            }

            if (tempp == "A4Preprint")
            {
                combprintselectn.SelectedIndex = 4;
            }
            if (tempp == "mode3")
            {
                combprintselectn.SelectedIndex = 5;
            }
            if (tempp == "mode4")
            {
                combprintselectn.SelectedIndex = 6;
            }
            if (tempp == "mode5")
            {
                combprintselectn.SelectedIndex = 7;
            }

            if (tempp == "mode6")
            {
                combprintselectn.SelectedIndex = 8;
            }
            if (tempp == "mode7")
            {
                combprintselectn.SelectedIndex = 9;
            }
            if (tempp == "A4Qatar")
            {
                combprintselectn.SelectedIndex = 10;
            }
           if (tempp == "A4ModeNew")
            {
                combprintselectn.SelectedIndex = 11;
            }

           if (tempp == "ThermalarabNotax")
           {
               combprintselectn.SelectedIndex = 12;
           }
           if (tempp == "ThermalenglishNotax")
           {
               combprintselectn.SelectedIndex = 13;
           }

           if (tempp == "Workshopmode3")
           {
               combprintselectn.SelectedIndex = 14;
           }

           if (tempp == "Workshopmode3Notax")
           {
               combprintselectn.SelectedIndex = 15;
           }

           if (tempp == "codenameNotax")
           {
               combprintselectn.SelectedIndex = 16;
           }
           if (tempp == "NameNotax")
           {
               combprintselectn.SelectedIndex = 17;
           }


           if (tempp == "3pointArabic")
           {
               combprintselectn.SelectedIndex =1;
           }
          



            //eee

           if (temppurch == "4")
           {
               combprintselectnpurchase.SelectedIndex = 0;
           }

           if (temppurch == "A4Preprint2")
           {
               combprintselectnpurchase.SelectedIndex = 3;
           }

           if (temppurch == "A4Preprint")
           {
               combprintselectnpurchase.SelectedIndex = 4;
           }
           if (temppurch == "mode3")
           {
               combprintselectnpurchase.SelectedIndex = 5;
           }
           if (temppurch == "mode4")
           {
               combprintselectnpurchase.SelectedIndex = 6;
           }
           if (temppurch == "mode5")
           {
               combprintselectnpurchase.SelectedIndex = 7;
           }

           if (temppurch == "mode6")
           {
               combprintselectnpurchase.SelectedIndex = 8;
           }
           if (temppurch == "mode7")
           {
               combprintselectnpurchase.SelectedIndex = 9;
           }
           if (temppurch == "A4Qatar")
           {
               combprintselectnpurchase.SelectedIndex = 10;
           }
           if (temppurch == "A4ModeNew")
           {
               combprintselectnpurchase.SelectedIndex = 11;
           }

           if (temppurch =="ThermalarabNotax" )
           {
               combprintselectnpurchase.SelectedIndex = 12;
           }

           if (temppurch == "ThermalenglishNotax")
           {
               combprintselectnpurchase.SelectedIndex = 13;
           }

           if (temppurch == "3pointArabic")
           {
               combprintselectnpurchase.SelectedIndex = 1;
           }





            if (tempp == "14")
            {

                //raddot6.Checked = true;
                //chkmixed3.Checked = true;
            }
            if (tempp == "4")
            {
                combprintselectn.SelectedIndex = 0;
                //radother3.Checked = true;
            }
            if (tempp == "5")
            {
                //radother6.Checked = true;
            }
            if (tempp == "6")
            {
                radother10.Checked = true;
            }
            if (tempp == "7")
            {
                //raddot6.Checked = true;
                //chkmixedkerala.Checked = true;
            }
            if (tempp == "9")
            {
                combprintselectn.SelectedIndex = 2;
                //chka4split.Checked = true;
            }
            if (tempp == "100")
            {
                radotherdetail.Checked = true;
            }
            if (tempp == "10")
            {
                radmultipleprint.Checked = true;
            }
            if (tempp == "11")
            {
                //raddot6.Checked = true;
                //chkmixedkarnataka.Checked = true;
            }
            if (tempp == "DotMobile")
            {
                raddotmobile.Checked = true;
            }
            if (tempp == "3pointArabic")
            {
                combprintselectn.SelectedIndex = 1;
                //Rad3pointarabic.Checked = true;
            }
            if (tempp == "DotPreprinted")
            {
                Raddotpreprinted.Checked = true;
            } 


            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                value = Ds.Tables[0].Rows[i]["paramvalue"].ToString();

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "SPrintRate")
                {
                    Txtsprintrate.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Language")
                {
                    ComLanguage.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Staxinclusive")
                {
                    Comtaxinclusivesales.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "defSaleDiscAMT")
                {
                    txtsaledefaultdisc.textBox1.Text = value.ToString();
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "BCodeCreatePRFX")
                {
                    tempp = value.ToString();
                    //  txtBcodetextPrefix.textBox1.Text = tempp;
                    txtBcodetextPrefix.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "userdiscvalue")
                {
                    if (value=="")
                    {
                        value = "0";
                    }
                    txtuserwiseMaxdisc.textBox1.Text = _Dbtask.znllString(value);
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "CurDecc")
                { 
                    ComCurDecimal.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "StockDecc")
                {
                    ComstockDeci.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Majorsymbol")
                {
                    TxtMajorSymbol.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Minersymbol")
                {
                    TxtMinerSymbol.Text = value.ToString();
                }
               

                /*******Default Sett************/
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "TaxDef")
                {
                    comdeftax.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "PMpayment")
                {
                    commodeofpaymentpurchase.SelectedIndex = Convert.ToInt16(_Dbtask.znlldoubletoobject(value));
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "PSpayment")
                {
                    commodeofpaymentsales.SelectedIndex = Convert.ToInt16(_Dbtask.znlldoubletoobject(value));
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "DepotDef")
                {
                    Comdefstockarea.SelectedValue = Convert.ToInt16(_Dbtask.znlldoubletoobject(value));
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "SalesmanDef")
                {
                    Comdefsalesman.SelectedValue = Convert.ToInt16(_Dbtask.znlldoubletoobject(value));
                }
                /*Auto Backups*/

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "AB1")
                {
                    txtautobackupfilepath1.Text = value.ToString();
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "AB2")
                {
                    txtautobackupfilepath2.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "AB3")
                {
                    txtautobackupfilepath3.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "AB4")
                {
                    txtautobackupfilepath4.Text = value.ToString();
                }
                /*****************************************/

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Prebarcode")
                {
                    txtbarcodeprifix.Text = value.ToString();
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "AmtWords")
                {

                    combamtinwords.SelectedIndex = Convert.ToInt32(value);
                }


                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "codewidthSI")
                {

                    txtcodewidth.textBox1.Text = _Dbtask.znllString(value);
                }


                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "weignbcodestrt")
                {

                   txtbcodestart.Text = _Dbtask.znllString(value);
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "weignbcodeend")
                {

                    txtbcodeend.Text = _Dbtask.znllString(value);
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "weignratestrt")
                {

                    txtbcoderatestart.Text = _Dbtask.znllString(value);
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "weignrateend")
                {

                    txtbcoderateend.Text = _Dbtask.znllString(value);
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "weignQtystrt")
                {

                    txtqtystat.Text = _Dbtask.znllString(value);
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "weignQtyend")
                {

                    txtqtyend.Text = _Dbtask.znllString(value);
                }




                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "weignQtyDIVI")
                {

                    txtBcodeQTYDivision.Text = _Dbtask.znllString(value);
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "weignRateDIVI")
                {

                    txtBcodeRateDivision.Text = _Dbtask.znllString(value);
                }




                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "itemcodeprintsize")
                {

                    txtcodeprintwidth.textBox1.Text = value.ToString();
                }


                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "BcodeH")
                {

                   txtbcodeHeight.textBox1.Text = value.ToString();
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "BitemSize")
                {

                    txtitemsize.textBox1.Text = value.ToString();
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "BcompnySize")
                {

                    txtcompnysize.textBox1.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Bratesize")
                {

                    txtratesize.textBox1.Text = value.ToString();
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Bitemcodesize")
                {

                   txtitemcodebcodesize.textBox1.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Blangsize")
                {

                    txtlangsize.textBox1.Text = value.ToString();
                }


                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "QRwidth")
                {
                    if(value=="")
                    {
                        value="140";
                    }

                   txtqrwidth.textBox1.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "QRheight")
                {
                    if (value == "")
                    {
                        value = "120";
                    }
                    txtqrhight.textBox1.Text = value.ToString();
                }



                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "batchwidthinpurchase")
                {
                    if (value == "")
                    {
                        value = "116";
                    }
                   txtbatchwidthpurchase.textBox1.Text = value.ToString();
                }






                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Printbarcodein")
                {
                    if (value == "Srate")
                    {
                        radbarcodeprintsrate.Checked = true;
                    }
                    if (value == "MRP")
                    {
                        radbarcodeprintmrp.Checked = true;
                    }
                    if (value == "None")
                    {
                        radbarcodeprintnone.Checked = true;
                    }
                    if (value == "None")
                    {
                        radbarcodeprintnone.Checked = true;
                    }
                    if (value == "Namewithrate")
                    {
                        radprintratebyitems.Checked = true;
                    }
                }
               
                
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "ItemSearch")
                {
                     tempp = value.ToString();
                    if (tempp == "1")
                    {
                        Raditemfirstsearch.Checked = true;
                    }
                    if (tempp == "2")
                    {
                        Raditemlastkeysearch.Checked = true;
                    }
                    if (tempp == "3")
                    {
                        raditemanykeysearch.Checked = true;
                    }
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "SB")
                {
                    txtsmsbalance.Text = value.ToString(); 
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "LaserTop")
                {
                    txtlasertopmargin.Text = value.ToString(); 
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "LeftBarcode")
                {
                    txtlaserleftmargin.Text = value.ToString();
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "StrBarcode")
                {
                    txtstartingbarcode.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "StrSrate")
                {
                    txtstickerprint.Text = value.ToString();
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Dissticker")
                {
                    txtdistancebarcodesticker.Text = value.ToString();
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Sprefix")
                {
                    txtprefixsales.Text = value.ToString();
                }
                /**********Warning**********/
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "CreditLimit")
                {
                    comwarncreditlimit.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "MinusCash")
                {
                    comwarnnegetivecash.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "WNstock")
                {
                    Comwarnnegetivestock.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "WMstock")
                {
                    Comwarnminimumstock.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "WRstock")
                {
                    Comwarnreorderstock.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "WMXstock")
                {
                    Comwarnmaximumstock.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "WS<P")
                {
                    Comwarnsaleratelessthanprate.Text = value.ToString();
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "LR<SR")
                {
                    Comwarnsaleratelessthanretailrate.Text = value.ToString();
                }
                /************************/

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Nocopies")
                {
                     tempp = value.ToString();
                     if (tempp=="")
                    {
                        tempp = "1";
                    }
                    txtnocopies.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "BarcodeHeading")
                {
                     tempp = value.ToString();
                    txtbarcodeheading.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Pfooter")
                {
                     tempp = value.ToString();
                    txtprintfooter.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Fscroll")
                {
                     tempp = value.ToString();
                    txtfscroll.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Reverse")
                {
                     tempp = value.ToString();
                    txtreverse.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Strstock")
                {
                     tempp = value.ToString();
                    Txtstrshowstartupstock.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Strbalance")
                {
                     tempp = value.ToString();
                    Txtstrshowstartupbalance.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Leftleser")
                {
                     tempp = value.ToString();
                    txtleftlaser.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Toplaser")
                {
                     tempp = value.ToString();
                    txttoplaser.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "PrintTaxpurchase")
                {
                    tempp = value.ToString();
                    if (tempp == "1")
                    {
                        ChkpprintTaxrateinclusive.Checked = true;
                    }
                    else
                    {
                        ChkpprintTaxrateinclusive.Checked = false;
                    }
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "THheadfnt")
                {
                    tempp = value.ToString();
                    txtcompanyfnt.textBox1.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "THinhomefnt")
                {
                    tempp = value.ToString();
                    txtnamehomefnt.textBox1.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "THtaxfnt")
                {
                    tempp = value.ToString();
                    txttaxtfnt.textBox1.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "THaddphfnt")
                {
                    tempp = value.ToString();
                    txtphadressfont.textBox1.Text = tempp;
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Iconend")
                {
                    tempp = value.ToString();
                    if (tempp == "0")
                    {
                        tempp = "120";
                    }
                   txticonend.textBox1.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Iconstart")
                {
                    tempp = value.ToString();

                    if (tempp=="0")
                    {
                        tempp = "50";
                    }
                   txticonstartpoint.textBox1.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Iconsize")
                {
                    tempp = value.ToString();
                    if (tempp == "0")
                    {
                        tempp = "70";
                    }
                    TXTICONSIZE.textBox1.Text = tempp;
                }

                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "Cashsymbol")
                {
                    tempp = value.ToString();
                    COMCASHSYMBOL.SelectedText = tempp;
                    int TYPE = 0;
                    TYPE = Convert.ToInt32(Ds.Tables[0].Rows[i]["paramtype"]);
                    if (_Dbtask.znllString(TYPE) == "")
                    {
                        TYPE = 0;
                    }
                    COMCASHSYMBOL.SelectedIndex = TYPE;
                }




                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "MaxBcode")
                {
                    tempp = value.ToString();
                    TxtsstartingBarcode.textBox1.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "bcodeprefix")
                {
                    tempp = _Dbtask.znllString(value);
                   txtbcodeeprefix.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "bcodedigit")
                {
                    tempp = _Dbtask.znllString(value);
                   txtbcodedegit.Text = tempp;
                }
                if (Ds.Tables[0].Rows[i]["paramname"].ToString() == "taxpercset")
                {
                    tempp = _Dbtask.znllString(value);

                    if (tempp == "" || tempp=="0")
                    {
                        tempp = "15";
                    }
                  txttaxpercset.textBox1.Text = tempp;
                }


            }
        }
        public void Behmenusettings()
        {
              Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings");
            string status;
            string Menuid;
           
            /*For Estimate Ledger*/
            if (Generalfunction.BlShowEst == true)
                chkshowestimateledger.Checked = true;
            else
                chkshowestimateledger.Checked = false;
            /*****************************************/

            if (regKey.ValueCount < 2)
            {
                regKey = regKey.CreateSubKey("Software\\Techno");
            } 
            Estimatepwd = regKey.GetValue("Hpwd", 0).ToString();

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
               status = Ds.Tables[0].Rows[i]["status"].ToString();
                if(status=="1")
                {
                Ischecked = true;
                }
                if(status=="-1")
                {
                Ischecked = false;
                }
                if (status == "2")
                {
                    Ischecked1 = true;
                }

                Menuid = Ds.Tables[0].Rows[i]["menuid"].ToString();

                if (Menuid == "1007")/*Multi Rate*/
                {
                    ChkEditItemName.Checked = Ischecked;
                }

                if (Menuid == "1008")/*Multi Rate*/
                {
                    Chkpedititemcode.Checked = Ischecked;
                }
                if (Menuid == "2022")/*Purchase Cess*/
                {
                    chkservices.Checked = Ischecked;
                }
                if (Menuid == "2024")
                {
                  chkprintfooter.Checked = Ischecked;
                }
                if (Menuid == "102030")
                {
                    chkfootpostn.Checked = Ischecked;
                }
                if (Menuid == "214")
                {
                   chkmostmove.Checked = Ischecked;
                }
                if (Menuid == "302010")
                {
                    chkbaseunit.Checked = Ischecked;
                }
                if (Menuid == "302011")
                {
                    CHKTAILLOR.Checked = Ischecked;
                }
                if (Menuid == "8000")
                {
                      ChkfootMid.Checked = Ischecked;
                }
                if (Menuid == "9000")
                {
                    chkQrcode.Checked = Ischecked;
                }
                if (Menuid == "112233")
                {
                    chkprintoldblnce.Checked = Ischecked;
                }
                if (Menuid == "2026")/*Purchase Cess*/
                {
                   chkwarranty.Checked = Ischecked;
                }

                if (Menuid == "11")/*Multi Rate*/
                {
                    ChkEmultirate.Checked = Ischecked;
                }
                if (Menuid == "207")/*Multi Rate*/
                {
                   Chkprateinlist.Checked = Ischecked;
                }
                if (Menuid == "223")
                {
                    chkbcodeprintBold.Checked = Ischecked;

                }
                if (Menuid == "225")
                {
                   chkdatetwoline.Checked = Ischecked;

                }
                if (Menuid == "226")
                {
                    chkdatewisectrlreport.Checked= Ischecked;

                }

                if (Menuid == "227")
                {
                    CHKinsrprefix.Checked = Ischecked;

                }

                if (Menuid == "208")/*Multi Rate*/
                {
                  chkbarcoderate.Checked= Ischecked;
                }
                if (Menuid == "209")/*Multi Rate*/
                {
                   ChkbcodeQty.Checked= Ischecked;
                }

                if (Menuid == "215")
                {
                    CHKautomaticmodeSET.Checked = Ischecked;

                }
                if (Menuid == "217")
                {
                   chkuserwisedisc.Checked = Ischecked;

                }


                if (Menuid == "219")
                {
                    chkstockshow.Checked = Ischecked;

                }
                if (Menuid == "220")
                {
                    chkbottomstock.Checked = Ischecked;

                }

                if (Menuid == "221")
                {
                    chkautomodepurchase.Checked = Ischecked;

                }
                if (Menuid == "222")
                {
                    CHKCUSwisevat.Checked = Ischecked;

                }
                //if (Menuid == "218")
                //{
                // chkpurchpritwhile.Checked = Ischecked;

                //}
                if (Menuid == "216")
                {
                    chkrateroundoffbcode.Checked = Ischecked;

                }
                if (Menuid == "211")
                {
                    ChkRPdetails.Checked = Ischecked;

                }
                

                if (Menuid == "12")/*Multi Unit*/
                {
                    Chkmultiunit.Checked = Ischecked;
                }

                if (Menuid == "13")/*Stock Area*/
                {
                    ChkEstockarea.Checked = Ischecked;
                }


                if (Menuid == "14")/*Tax*/
                {
                    chketax.Checked = Ischecked;
                    if (Transactionisexsting == true)
                    {
                        chketax.Enabled = false;
                    }
                    else
                    {
                        chketax.Enabled = true;
                    }
                }

                if (Menuid == "21")/*Sales Estimation*/
                {
                    chksalesestimation.Checked = Ischecked;
                }

                if (Menuid == "22")/*Sales Return*/
                {
                    Chksalesreturn.Checked = Ischecked;
                }

                if (Menuid == "24")/*Purchase Return*/
                {
                    Chkpurchasereturn.Checked = Ischecked;
                }

                if (Menuid == "100")/*Update Srate*/
                {
                    Chkupdatesrate.Checked = Ischecked;
                }

                if (Menuid == "101")/*Update Prate*/
                {
                    Chkupdateprate.Checked = Ischecked;
                }

                if (Menuid == "102")/*ItemWise Commision*/
                {
                    ChkItemwiseagentcomm.Checked = Ischecked;
                }

                if (Menuid == "103")/*Batch*/
                {
                    ChkEBatch.Checked = Ischecked;
                    if (Transactionisexsting == true)
                    {
                        ChkEBatch.Enabled = false;
                    }
                    else
                    {
                        ChkEBatch.Enabled = true;
                    }
                }

                if (Menuid == "104")/*POS*/
                {
                    ChkEPOS.Checked = Ischecked;
                }

                if (Menuid == "105")/*Production*/
                {
                    ChkEProduction.Checked = Ischecked;
                }

                if (Menuid == "106")/*Payroll*/
                {
                    Chkepayroll.Checked = Ischecked;
                }

                if (Menuid == "107")/*Roundoff*/
                {
                    chkroundoff.Checked = Ischecked;
                }

                if (Menuid == "108")/*Sale Item Discount*/
                {
                    Chksitemdiscount.Checked = Ischecked;
                }

                if (Menuid == "109")/*Purchase Item Discount*/
                {
                    chkpitemdiscount.Checked = Ischecked;
                }

                if (Menuid == "110")/*Sale Free*/
                {
                    chksfree.Checked = Ischecked;
                }

                if (Menuid == "111")/*Roundoff*/
                {
                    chkpfree.Checked = Ischecked;
                }

                if (Menuid == "112")/*Sale Item Discount*/
                {
                    chkeditsrate.Checked = Ischecked;
                }

                if (Menuid == "113")/*Purchase Item Discount*/
                {
                    chkeditpurchaserate.Checked = Ischecked;
                }
                if (Menuid == "114")/*Update MRP*/
                {
                    Chkupdatemrp.Checked = Ischecked;
                }

                if (Menuid == "115")/*Sales Agent*/
                {
                    chkagentsales.Checked = Ischecked;
                }

                if (Menuid == "116")/*Sales Employee*/
                {
                    chksalesmansales.Checked = Ischecked;
                }

                if (Menuid == "117")/*Purchase Agent*/
                {
                    chkagentpurchase.Checked = Ischecked;
                }

                if (Menuid == "118")/*Purchase Employee*/
                {
                    chkemployeepurchase.Checked = Ischecked;
                }

                if (Menuid == "119")/*Purchase ExciseDuty*/
                {
                    chkpexciseduty.Checked = Ischecked;
                }
                if (Menuid == "120")/*Purchase Edit Gross Amt*/
                {
                    chkpeditgrossamt.Checked = Ischecked;
                }
                if (Menuid == "121")/*Use asbarcode*/
                {
                    chkuseasbarcode.Checked = Ischecked;
                }
                if (Menuid == "122")/*AutoBackup*/
                {
                    chkautobackup.Checked = Ischecked;
                }
                if (Menuid == "123")/*Sizes*/
                {
                    Chkesize.Checked = Ischecked;
                }
                if (Menuid == "124")/*Update Sales Rate In Sale*/
                {
                    ChkSaleUpdateSalesrate.Checked = Ischecked;
                }
                if (Menuid == "125")/*For Flex Printing*/
                {
                    chkflex.Checked = Ischecked;
                }
                if (Menuid == "126")/*For Flex Printing*/
                {
                    chksfocusfirstrow.Checked = Ischecked;
                }
                if (Menuid == "127")/*For Flex Printing*/
                {
                    chkpitemnote1.Checked = Ischecked;
                }
                if (Menuid == "128")/*For Flex Printing*/
                {
                    chkpitemnote2.Checked = Ischecked;
                }
                if (Menuid == "129")/*For Customerpoint*/
                {
                    chkcustomerpoint.Checked = Ischecked;
                }
                if (Menuid == "130")/*For Customerpoint*/
                {
                    if (Ischecked1 == true)
                    {
                        RadBprintbutterfly.Checked = true;
                    }
                    else
                    {
                        if (Ischecked == false)
                            RadBPrintRoll.Checked = true;
                        else
                            RadBprintlaser.Checked = true;
                    }
                }
                if (Menuid == "131")/*For Flex Printing*/
                {
                    chkbpackeddate.Checked = Ischecked;
                }
                if (Menuid == "132")/*For Flex Printing*/
                {
                    chkbnote1.Checked = Ischecked;
                }
                if (Menuid == "133")/*For Customerpoint*/
                {
                    chkbitemnote2.Checked = Ischecked;
                }
                if (Menuid == "134")/*For Customerpoint*/
                {
                    chkbsuppliercode.Checked = Ischecked;
                }
                if (Menuid == "137")/*For DeactiveEmployee LessThan Zero*/
                {
                    chkdeactivecustomerzerobalance.Checked = Ischecked;
                }
                if (Menuid == "139")/*For Cash Cadjet*/
                {
                    chkcashcadjet.Checked = Ischecked;
                }
                if (Menuid == "140")/*For Cash Cadjet*/
                {
                    chkcrm.Checked = Ischecked;
                }
                if (Menuid == "141")/*For Slno Tracking*/
                {
                    chkslnotracking.Checked = Ischecked;
                }
                if (Menuid == "142")/*Barcode use as company Name*/ 
                {
                    chkbarcodehusecompanyname.Checked = Ischecked;
                }
                if (Menuid == "143")/*For Invoice Discount in Sales*/
                {
                    chksinvoicedisc.Checked = Ischecked;
                }
                if (Menuid == "123")/*Wieght Machine*/
                {
                    Chkesize.Checked = Ischecked;
                }
                if (Menuid == "144")/*Wieght Machine*/
                {
                    chkweightmachine.Checked = Ischecked;
                }
                if (Menuid == "145")/*Enable Pharmacy*/
                {
                    chkenpharmacy.Checked = Ischecked;
                }
                if (Menuid == "146")/*Visible Pur.Rate*/
                {
                    chkvisibleprate.Checked = Ischecked;
                }

                if (Menuid == "147")/*Wieght Machine*/
                {
                    chkeditgrossamountinsales.Checked = Ischecked;
                }
                if (Menuid == "148")/*Wieght Machine*/
                {
                    chkvisiblessrate.Checked = Ischecked;
                }
                if (Menuid == "149")/*Supplier wise item*/
                {
                    Chksupplierwiseitem.Checked = Ischecked;
                }
                if (Menuid == "150")/*Supplier wise item*/
                {
                    chkprintbalance.Checked = Ischecked;
                }
                if (Menuid == "152")/*Save Zero Value in P.Rate*/
                {
                    chkpsavezerorate.Checked = Ischecked;
                }
                if (Menuid == "153")/*Save Zero Value in P.Rate*/
                {
                    chkremovedublicate.Checked = Ischecked;
                }
                if (Menuid == "156")/*Party Project*/
                {
                    chkepartyproject.Checked = Ischecked;
                }
                if (Menuid == "157")/*Party Project*/
                {
                    chkprintbarcodelogo.Checked = Ischecked;
                }
                if (Menuid == "158")/*Startup stock*/
                {
                    chkstrshowstock.Checked = Ischecked;
                }
                if (Menuid == "159")/*Startup Balance*/
                {
                    Chkstrshowbalance.Checked = Ischecked;
                }
                if (Menuid == "160")/*Startup Balance*/
                {
                    chkseditqty.Checked = Ischecked;
                }
                if (Menuid == "161")/*Print multi Lang*/
                {
                    chkprintllangague.Checked = Ischecked;
                }
                if (Menuid == "162")/*Print Console*/
                {
                    chkconsole.Checked = Ischecked;
                }
                if (Menuid == "163")/*Sale rate include tax*/
                {
                    chksetsaleincludetax.Checked = Ischecked;
                }
                if (Menuid == "164")/*Sale rate include tax*/
                {
                    chkzerotaxamount.Checked = Ischecked;
                }
                if (Menuid == "165")/*Billing date in Purchase*/
                {
                    chkpbillingdate.Checked = Ischecked;
                }
                if (Menuid == "166")/*Single barcode*/
                {
                    Chksinglebarcode.Checked = Ischecked;
                }
                if (Menuid == "167")/*Customer area in sales */
                {
                    Chksalearea.Checked = Ischecked;
                }
                if (Menuid == "168")/*Customer area in sales */
                {
                    Chksavezeroratesales.Checked = Ischecked;
                }
                if (Menuid == "169")/*Customer area in sales */
                {
                    Chkpprintsecondlangague.Checked = Ischecked;
                }
                if (Menuid == "173")/*Searching mode on */
                {
                    Chkssearchingmode.Checked = Ischecked;
                }

                /*******/
                CommonClass._Gen.FillActivePrinter(Comsecondprint);
                Comsecondprint.Text = CommonClass._Dbtask.GetPrinterName2();
                if (Menuid == "181")/*Enable Second Printer */
                {
                    Chkenablesecondprinter.Checked = Ischecked;
                }
                if (Menuid == "193")/*Enable Itemnote in Sales */
                {
                    Chksitemnote.Checked = Ischecked;
                }
                if (Menuid == "194")/*Print No Tax*/
                {
                    ChkprintnoTax.Checked = Ischecked;
                }
                if (Menuid == "195")
                {
                   Chkbcodesrate.Checked = Ischecked;
                }
                if (Menuid == "196")
                {
                    chkllangbcode.Checked = Ischecked;
                }
                if (Menuid == "197")
                {
                    chkcodeinbcode.Checked = Ischecked;
                }
                if (Menuid == "198")
                {
                   ChkcreditlimitON.Checked = Ischecked;
                }

                if (Menuid == "199")
                {
                    chkvehicle.Checked = Ischecked;
                }

                if (Menuid == "200")
                {
                  chkmtrread.Checked= Ischecked;
                }
                if (Menuid == "201")
                {
                   chkempsales.Checked = Ischecked;
                }

                if (Menuid == "203")
                {
                    chkmanexdate.Checked = Ischecked;
                }
                if (Menuid == "204")
                {
                    chkitemnametop.Checked = Ischecked;
                }
                if (Menuid == "205")
                {
                    chkheaderVisible.Checked = Ischecked;
                }
                if (Menuid == "206")
                {
                    chkSaleitemroundoff.Checked = Ischecked;
                }
                /*****************/
            }
        }
        private void TRMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string a = TRMain.SelectedNode.Tag.ToString();
                if (a == "1")
                {
                    Panelvisible(PnlGeneral);
                }
                if (a == "2")
                {
                    Panelvisible(Pnlcreate);
                }
                if (a == "3")
                {
                    Panelvisible(PnlSales);
                }
                if (a == "4")
                {
                    Panelvisible(Pnlpurchase);
                }
                if (a == "5")
                {
                    Panelvisible(pnlvoucherType);
                }
                if (a == "6")
                {
                    Panelvisible(pnldefault);
                }

                if (a == "7")
                {
                    Panelvisible(pnlwarnings);
                }

                if (a == "8")
                {
                    Panelvisible(Pnprintersettings);

                }
                if (a == "9")
                {
                    Panelvisible(Pnlaoutobackup);
                }
                if (a == "10")
                {
                    Panelvisible(Pnlstartup);
                }
                if (a == "11")
                {
                    Panelvisible(PnlBarcodeSets);
                }
                if (a == "12")
                {
                    Panelvisible(PnlOtherprint);
                }
            }
            catch
            {
            }
        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void savemostmoveitem()
        {
            _Dbtask.ExecuteNonQuery("delete TblMostMoving");

            for (int i = 0; i < gridmostmove.Rows.Count; i++)
            {
                if (gridmostmove.Rows[i].Cells["Batch"].Value != "" && _Dbtask.znllString(gridmostmove.Rows[i].Cells["MMpcode"].Value)!="")
             {
                 MMbcode = _Dbtask.znllString(gridmostmove.Rows[i].Cells["Batch"].Value);

                 _mmove.MMbcode = MMbcode;
                 _mmove.MMname = _Dbtask.znllString(gridmostmove.Rows[i].Cells["Item"].Value);
                 _mmove.MMpcode = _Dbtask.znllString(gridmostmove.Rows[i].Cells["MMpcode"].Value);
                 _mmove.insertMostMoving();
             }
            }
        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            SetQuery();
            Menusettings();
            this.Close();
        }
        public void SetDecc()
        {
            string tempstock = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='StockDecc'");
            string temocurr = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='CurDecc'");
            tempstock = _Nextg.Decconvertion(tempstock);
            temocurr = _Nextg.Decconvertion(temocurr);
            Generalfunction.CurreDeci = temocurr;
            Generalfunction.StockDeci = tempstock;
        }
        public void ParamlistSettings()
        {
            /*For Credit Limit*/
            Clswarnings.CreditLimit = comwarncreditlimit.Text;
            Clswarnings.MinusCash = comwarnnegetivecash.Text;
            /*For Minus Cash*/
        }
        public void Menusettings()
        {
            SetDecc();
            ParamlistSettings();
            _Settings.RefreshMenusettings();
            Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                bool IsVisible;
                string MenuId = Ds.Tables[0].Rows[i]["Menuid"].ToString();
                string Status = Ds.Tables[0].Rows[i]["status"].ToString();
                if (Status == "1")
                {
                    IsVisible = true;
                }
                else
                {
                    IsVisible = false;
                }
                //MDIParent1 frm = this.MdiParent as MDIParent1;

                //(this.MdiParent as MDIParent1).menuStrip.Enabled = true;
                //(this.MdiParent as MDIParent1).Toolmnu.Enabled = true;  
                if (MenuId == "11")/*Multi Rate*/
                {
                    Generalfunction.EMRate = IsVisible;
                    //(this.MdiParent as MDIParent1).mnumultiratec.Visible = IsVisible;   
                }
                if (MenuId == "12")/*Multi Unit*/
                {
                    Generalfunction.EMunit = IsVisible;
                    //(this.MdiParent as MDIParent1).mnuunitsc.Visible = IsVisible;
                }
                if (MenuId == "13")/*Stock Area*/
                {
                    Generalfunction.EDepot = IsVisible;
                    // (this.MdiParent as MDIParent1).mnustockareac.Visible = IsVisible;
                }
                if (MenuId == "14")/*Tax */
                {
                    Generalfunction.ETax = IsVisible;
                    //(this.MdiParent as MDIParent1).mnutaxc.Visible = IsVisible;
                }
                if (MenuId == "105")/*Production */
                {
                   Clssettings.EProduction = IsVisible;
                    //(this.MdiParent as MDIParent1).mnutaxc.Visible = IsVisible;
                }

                if (MenuId == "21")/*Sales Estimation*/
                {
                    Generalfunction.ESalesestimation = IsVisible;
                    //(this.MdiParent as MDIParent1).mnusalesestimationt.Visible = IsVisible;
                }

                if (MenuId == "22")/*Sales Return*/
                {
                    Generalfunction.ESalesreturn = IsVisible;
                    //(this.MdiParent as MDIParent1).mnusalesreturnt.Visible = IsVisible;
                }

                if (MenuId == "24")/*Purchase Return*/
                {
                    Generalfunction.EPurchasereturn = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                if (MenuId == "137")/*Purchase Return*/
                {
                    Clssettings.SDeactiveLedger = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                if (MenuId == "140")/*Purchase Return*/
                {
                  Generalfunction.ECRM = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                if (MenuId == "144")/*Purchase Return*/
                {
                    Generalfunction.EWmachine = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
            }
        }


        public void footinsert()
        {
            _Dbtask.ExecuteNonQuery("delete from tblparamlist where paramname IN('footer1','footer2','footer3','footer4','footer5') ");
    
            FL1 = txtfarab.textBox1.Text.Replace("\r", " ");
            FL1 = FL1.Replace("\n", " ");
            CommonClass._Paramlist.ParamValue = FL1;
            CommonClass._Paramlist.ParamName = "footer1";
            CommonClass._Paramlist.Paramtype = "footer1";
            CommonClass._Paramlist.InsertParamlist();
            
            FL2 = txtL2.Text.Replace("\r", " ");
            FL2 = FL2.Replace("\n", " ");
            CommonClass._Paramlist.ParamValue = FL2;
            CommonClass._Paramlist.ParamName = "footer2";
            CommonClass._Paramlist.Paramtype = "footer2";
            CommonClass._Paramlist.InsertParamlist();
            // FL2 = txtL2.Text.ToString();
            
            FL3 = txtL3.Text.Replace("\r", " ");
            FL3 = FL3.Replace("\n", " ");
            CommonClass._Paramlist.ParamValue = FL3;
            CommonClass._Paramlist.ParamName = "footer3";
            CommonClass._Paramlist.Paramtype = "footer3";
            CommonClass._Paramlist.InsertParamlist();
            FL4 = txtL4.Text.Replace("\r", " ");
            FL4 = FL4.Replace("\n", " ");
            CommonClass._Paramlist.ParamValue = FL4;
            CommonClass._Paramlist.ParamName = "footer4";
            CommonClass._Paramlist.Paramtype = "footer4";
            CommonClass._Paramlist.InsertParamlist();
            FL5 = txtL5.Text.Replace("\r", " ");
            FL5 = FL5.Replace("\n", " ");
            CommonClass._Paramlist.ParamValue = FL5;
            CommonClass._Paramlist.ParamName = "footer5";
            CommonClass._Paramlist.Paramtype = "footer5";
            CommonClass._Paramlist.InsertParamlist();
           
        }

        public void FuSecondPrinter()
        {
            if (Chkenablesecondprinter.Checked == true)
            {
                Comsecondprint.Enabled = true;
            }
            else
            {
                Comsecondprint.Enabled = false;
            }
            ControleChecked(Chkenablesecondprinter, Secondprinter);

            Secondprinter = Coresponding;
        }
        public void setotherprintsave()
        {

            _Dbtask.ExecuteNonQuery("delete TblOtherprintsets");

            for (int i = 0; i < griditems.Rows.Count; i++)
            {
                if (griditems.Rows[i].Cells[1].Value != "")
                {



                    opname = _Dbtask.znllString(griditems.Rows[i].Cells[1].Value);
                    if (Convert.ToInt32(griditems.Rows[i].Cells[0].Value) == 1)
                    {
                        stss = "1";
                    }
                    else
                    {
                        stss = "0";
                    }
                    CommonClass._otherPrint.OPname = opname;
                    CommonClass._otherPrint.sts = Convert.ToInt32(stss);
                    CommonClass._otherPrint.insertOtherprintsets();

                }

            }

        }



        public void SetQuery()
        {
            savemostmoveitem();
            setotherprintsave();
            FuSecondPrinter();
            SAVESETsecondprintmodel();
            CommonClass._Dbtask.SetPrinterName2(Comsecondprint.Text);/*Second Printer Save*/
           /*ParamList*/
            Dccurrency = ComCurDecimal.Text;
            Dcstock = ComstockDeci.Text;
            Majorcurr = TxtMajorSymbol.Text;
            MinCurr = TxtMinerSymbol.Text;
            //Footer
            footinsert();
            amtwords =_Dbtask.znllString( combamtinwords.SelectedIndex);
            Codewidth =_Dbtask.znllString( txtcodewidth.textBox1.Text);
            if(Codewidth=="")
            {
            Codewidth="46";
            }

            bcodehight = _Dbtask.znllString(txtbcodeHeight.textBox1.Text);
            Bitemsize = _Dbtask.znllString(txtitemsize.textBox1.Text);
            Bcompnysize = _Dbtask.znllString(txtcompnysize.textBox1.Text);
            Bratesize = _Dbtask.znllString(txtratesize.textBox1.Text);
            Bitemcodesize = _Dbtask.znllString(txtitemcodebcodesize.textBox1.Text);
            Blangsize = _Dbtask.znllString(txtlangsize.textBox1.Text);
            
            DefTax = comdeftax.Text;
            DefPPay = commodeofpaymentpurchase.SelectedIndex.ToString();
            DefSPay = commodeofpaymentsales.SelectedIndex.ToString();
            DefSalesman = Comdefsalesman.SelectedValue.ToString();
            DefStockarea = Comdefstockarea.SelectedValue.ToString();

            Autobackuppath1 = txtautobackupfilepath1.Text;
            Autobackuppath2 = txtautobackupfilepath2.Text;
            Autobackuppath3 = txtautobackupfilepath3.Text;
            Autobackuppath4 = txtautobackupfilepath4.Text;

            BarcodePrefix = txtbarcodeprifix.Text;
            Codewidthprint =_Dbtask.znllString( txtcodeprintwidth.textBox1.Text);
            _Paramlist.UpdateParamlist("SPrintRate", "0", Txtsprintrate.Text);
            _Paramlist.UpdateParamlist("Language", "0", ComLanguage.Text);
            _Paramlist.UpdateParamlist("Staxinclusive", "0", Comtaxinclusivesales.Text);
            _Paramlist.UpdateParamlist("curdecc", "0", Dccurrency);
            _Paramlist.UpdateParamlist("stockdecc","0", Dcstock);

            _Paramlist.UpdateParamlist("Cashsymbol", _Dbtask.znllString(COMCASHSYMBOL.SelectedIndex), _Dbtask.znllString(COMCASHSYMBOL.Text));



            _Paramlist.UpdateParamlist("majorsymbol", Majorcurr, Majorcurr);

            _Paramlist.UpdateParamlist("minersymbol", MinCurr, MinCurr);
            _Paramlist.UpdateParamlist("MaxBcode", "", TxtsstartingBarcode.textBox1.Text);
            _Paramlist.UpdateParamlist("Iconsize", "", TXTICONSIZE.textBox1.Text);
            _Paramlist.UpdateParamlist("Iconstart", "", txticonstartpoint.textBox1.Text);
            _Paramlist.UpdateParamlist("Iconend", "", txticonend.textBox1.Text);

            _Paramlist.UpdateParamlist("THheadfnt", "", txtcompanyfnt.textBox1.Text);
            _Paramlist.UpdateParamlist("THinhomefnt", "", txtnamehomefnt.textBox1.Text);
            _Paramlist.UpdateParamlist("THtaxfnt", "", txttaxtfnt.textBox1.Text);
            _Paramlist.UpdateParamlist("THaddphfnt", "", txtphadressfont.textBox1.Text);

            _Paramlist.UpdateParamlist("BCodeCreatePRFX", "", txtBcodetextPrefix.Text);

            _Paramlist.UpdateParamlist("userdiscvalue", "", _Dbtask.znllString(txtuserwiseMaxdisc.textBox1.Text));

            _Paramlist.UpdateParamlist("TaxDef", "1", DefTax);
            _Paramlist.UpdateParamlist("PMpayment", "1", DefPPay);
            _Paramlist.UpdateParamlist("PSpayment", "1", DefSPay);
            _Paramlist.UpdateParamlist("DepotDef", "1", DefStockarea);
            _Paramlist.UpdateParamlist("SalesmanDef", "1", DefSalesman);

            CommonClass._Dbtask.SetPrinterSelect(Printerselect);
            CommonClass._Dbtask.SetPrinterSelectpurchaseseting(Printerselectpurch);
            //_Paramlist.UpdateParamlist("Pselect", "1", Printerselect);

            _Paramlist.UpdateParamlist("AB1", "1", Autobackuppath1);
            _Paramlist.UpdateParamlist("AB2", "2", Autobackuppath2);
            _Paramlist.UpdateParamlist("AB3", "3", Autobackuppath3);
            _Paramlist.UpdateParamlist("AB4", "4", Autobackuppath4);

            _Paramlist.UpdateParamlist("Printbarcodein", "1", BarcodePrintin);
            _Paramlist.UpdateParamlist("Prebarcode", "1", BarcodePrefix);
            _Paramlist.UpdateParamlist("ItemSearch", "1", ItemSearch.ToString());
            _Paramlist.UpdateParamlist("SB", "1", txtsmsbalance.Text.ToString());
            _Paramlist.UpdateParamlist("LaserTop", "1", txtlasertopmargin.Text.ToString());
            _Paramlist.UpdateParamlist("LeftBarcode", "1", txtlaserleftmargin.Text.ToString());
            _Paramlist.UpdateParamlist("Dissticker", "1", txtdistancebarcodesticker.Text.ToString());

            _Paramlist.UpdateParamlist("StrBarcode", "1", txtstartingbarcode.Text.ToString());
            _Paramlist.UpdateParamlist("StrSrate", "1", txtstickerprint.Text.ToString());

            /*******Warning**********/
            _Paramlist.UpdateParamlist("CreditLimit", "2", comwarncreditlimit.Text.ToString());
            _Paramlist.UpdateParamlist("MinusCash", "2", comwarnnegetivecash.Text.ToString());
            _Paramlist.UpdateParamlist("WNstock", "2", Comwarnnegetivestock.Text.ToString());
            _Paramlist.UpdateParamlist("WMstock", "2", Comwarnminimumstock.Text.ToString());
            _Paramlist.UpdateParamlist("WRstock", "2", Comwarnreorderstock.Text.ToString());
            _Paramlist.UpdateParamlist("WMXstock", "2", Comwarnmaximumstock.Text.ToString());
            _Paramlist.UpdateParamlist("WS<P", "2", Comwarnsaleratelessthanprate.Text.ToString());
            _Paramlist.UpdateParamlist("LR<SR", "2", Comwarnsaleratelessthanretailrate.Text.ToString());
            /***********/

            _Paramlist.UpdateParamlist("Nocopies", "2", txtnocopies.Text.ToString());
            _Paramlist.UpdateParamlist("BarcodeHeading", "2", txtbarcodeheading.Text.ToString());
            _Paramlist.UpdateParamlist("Pfooter", "2", txtprintfooter.Text.ToString());
            _Paramlist.UpdateParamlist("Sprefix", "2", txtprefixsales.Text.ToString());
            _Paramlist.UpdateParamlist("Fscroll", "2", txtfscroll.Text.ToString());
            _Paramlist.UpdateParamlist("Reverse", "2", txtreverse.Text.ToString());
            _Paramlist.UpdateParamlist("Strstock", "1", Txtstrshowstartupstock.textBox1.Text.ToString());
            _Paramlist.UpdateParamlist("Strbalance", "1", Txtstrshowstartupbalance.textBox1.Text.ToString());

            _Paramlist.UpdateParamlist("Leftleser", "1", txtleftlaser.Text.ToString());
            _Paramlist.UpdateParamlist("Toplaser", "1", txttoplaser.Text.ToString());
            _Paramlist.UpdateParamlist("PrintTaxpurchase", "1", Pprintinclusive);

            _Paramlist.UpdateParamlist("AmtWords", "1", amtwords);
            _Paramlist.UpdateParamlist("codewidthSI", "1", Codewidth);

            _Paramlist.UpdateParamlist("BcodeH", "1", bcodehight);
            _Paramlist.UpdateParamlist("BitemSize", "1", Bitemsize);
            _Paramlist.UpdateParamlist("BcompnySize", "1", Bcompnysize);
            _Paramlist.UpdateParamlist("Bratesize", "1", Bratesize);
            _Paramlist.UpdateParamlist("Bitemcodesize", "1", Bitemcodesize);
            _Paramlist.UpdateParamlist("Blangsize", "1", Blangsize);

            _Paramlist.UpdateParamlist("itemcodeprintsize", "1",Codewidthprint );
            _Paramlist.UpdateParamlist("bcodeprefix", "1",_Dbtask.znllString( txtbcodeeprefix.Text));
            _Paramlist.UpdateParamlist("bcodedigit", "1", _Dbtask.znllString(txtbcodedegit.Text));
            _Paramlist.UpdateParamlist("taxpercset", "1", _Dbtask.znllString(txttaxpercset.textBox1.Text));
            _Paramlist.UpdateParamlist("defSaleDiscAMT", "1", _Dbtask.znllString(txtsaledefaultdisc.textBox1.Text));

            _Paramlist.UpdateParamlist("weignbcodestrt", "1", _Dbtask.znllString(txtbcodestart.Text));
            _Paramlist.UpdateParamlist("weignbcodeend", "1", _Dbtask.znllString(txtbcodeend.Text));

            _Paramlist.UpdateParamlist("weignratestrt ", "1", _Dbtask.znllString(txtbcoderatestart.Text));
            _Paramlist.UpdateParamlist("weignrateend", "1", _Dbtask.znllString(txtbcoderateend.Text));

            _Paramlist.UpdateParamlist("weignQtystrt ", "1", _Dbtask.znllString(txtqtystat.Text));
            _Paramlist.UpdateParamlist("weignQtyend", "1", _Dbtask.znllString(txtqtyend.Text));

            _Paramlist.UpdateParamlist("weignQtyDIVI", "1", _Dbtask.znllString(txtBcodeQTYDivision.Text));
            _Paramlist.UpdateParamlist("weignRateDIVI", "1", _Dbtask.znllString(txtBcodeRateDivision.Text));

            _Paramlist.UpdateParamlist("QRwidth", "1", _Dbtask.znllString(txtqrwidth.textBox1.Text));
            _Paramlist.UpdateParamlist("QRheight", "1", _Dbtask.znllString(txtqrhight.textBox1.Text));

            _Paramlist.UpdateParamlist("batchwidthinpurchase", "1", _Dbtask.znllString(txtbatchwidthpurchase.textBox1.Text));


           

            /*MenuSettinhs*/
             _Mnusettings.UpdateMenusettings("2026",enbleWrrnty.ToString());
            _Mnusettings.UpdateMenusettings("2024", enablefooter.ToString());
            _Mnusettings.UpdateMenusettings("102030", footrStrt.ToString());
            _Mnusettings.UpdateMenusettings("8000", footrmidd.ToString());
            _Mnusettings.UpdateMenusettings("9000",QRvisible.ToString());
            _Mnusettings.UpdateMenusettings("112233", Poldbalance.ToString());

            _Mnusettings.UpdateMenusettings("302010", baseunit.ToString());
            _Mnusettings.UpdateMenusettings("302011",tailor.ToString());

            _Mnusettings.UpdateMenusettings("215", automaticmodeSET.ToString());
            _Mnusettings.UpdateMenusettings("2022",enableservice.ToString());
            _Mnusettings.UpdateMenusettings("1007", EditPItemName);
            _Mnusettings.UpdateMenusettings("1008", EditPitemCode);
           _Mnusettings.UpdateMenusettings("11", Mrate.ToString());
           _Mnusettings.UpdateMenusettings("12", Munit.ToString());

           _Mnusettings.UpdateMenusettings("13", Stockarea.ToString());
           _Mnusettings.UpdateMenusettings("14", Tax.ToString());

           _Mnusettings.UpdateMenusettings("21", Salesest.ToString());
           _Mnusettings.UpdateMenusettings("22", Salesreturn.ToString());

           _Mnusettings.UpdateMenusettings("24", Purchasereturn.ToString());

           _Mnusettings.UpdateMenusettings("100", UpdateSrate.ToString());
           _Mnusettings.UpdateMenusettings("101", Updateprate.ToString());
           _Mnusettings.UpdateMenusettings("114", UpdateMrp.ToString());
           _Mnusettings.UpdateMenusettings("102", Itemwisecomm.ToString());
           _Mnusettings.UpdateMenusettings("103", Batchcode.ToString());
           _Mnusettings.UpdateMenusettings("104", POS.ToString());
           _Mnusettings.UpdateMenusettings("105", Production.ToString());
           _Mnusettings.UpdateMenusettings("106", Payroll.ToString());
           _Mnusettings.UpdateMenusettings("107", Roundoff.ToString());
           _Mnusettings.UpdateMenusettings("108", sitemdiscount.ToString());
           _Mnusettings.UpdateMenusettings("109", pitemdiscount.ToString());
           _Mnusettings.UpdateMenusettings("110", sfree.ToString());
           _Mnusettings.UpdateMenusettings("111", pfree.ToString());
           _Mnusettings.UpdateMenusettings("112", Editsrate.ToString());
           _Mnusettings.UpdateMenusettings("113", Editprate.ToString());
           _Mnusettings.UpdateMenusettings("115", Sagent.ToString());
           _Mnusettings.UpdateMenusettings("116", Semployee.ToString());
           _Mnusettings.UpdateMenusettings("117", Pagent.ToString());
           _Mnusettings.UpdateMenusettings("118", Pemployee.ToString());
           _Mnusettings.UpdateMenusettings("119", Pexciseduty.ToString());
           _Mnusettings.UpdateMenusettings("120", Peditgrossamount.ToString());
           _Mnusettings.UpdateMenusettings("121", Useasbarcode.ToString());
           _Mnusettings.UpdateMenusettings("122", Autobackup.ToString());
           _Mnusettings.UpdateMenusettings("123", Sizes.ToString());
           _Mnusettings.UpdateMenusettings("124", UpdateSrateInSale.ToString());
           _Mnusettings.UpdateMenusettings("125", Flex.ToString());
           _Mnusettings.UpdateMenusettings("126", SFocusFirstRow.ToString());
           _Mnusettings.UpdateMenusettings("127", Pitemnote1.ToString());
           _Mnusettings.UpdateMenusettings("128", Pitemnote2.ToString());
           _Mnusettings.UpdateMenusettings("129", Customerpoint.ToString());
           _Mnusettings.UpdateMenusettings("130", BarcodePrintSelect.ToString());
           _Mnusettings.UpdateMenusettings("131", PrintMandateBarcode.ToString());
           _Mnusettings.UpdateMenusettings("132", PrintNote1Barcode.ToString());
           _Mnusettings.UpdateMenusettings("133", PrintNote2Barcode.ToString());
           _Mnusettings.UpdateMenusettings("134", PrintNote2SupplierBarcode.ToString());
           _Mnusettings.UpdateMenusettings("137", SDeactiveEmployee.ToString());
           _Mnusettings.UpdateMenusettings("139", Scashcadjet.ToString());
           _Mnusettings.UpdateMenusettings("140", SCRM.ToString());
           _Mnusettings.UpdateMenusettings("141", SerialNoTracking.ToString());
           _Mnusettings.UpdateMenusettings("142", CompanyNameAsBarcodeHeading.ToString());
           _Mnusettings.UpdateMenusettings("143", SinvoiceDiscount.ToString());
           _Mnusettings.UpdateMenusettings("144", Wieghtmachine.ToString());
           _Mnusettings.UpdateMenusettings("145", Pharmacy.ToString());
           _Mnusettings.UpdateMenusettings("146", Visibleprate.ToString());
           _Mnusettings.UpdateMenusettings("147", EditSGrossamount.ToString());
           _Mnusettings.UpdateMenusettings("148", VSSrate.ToString());
           _Mnusettings.UpdateMenusettings("149", Supplierwiseitem.ToString());
           _Mnusettings.UpdateMenusettings("150", PrintBalance.ToString());
           _Mnusettings.UpdateMenusettings("152", SaveZeroRate.ToString());
           _Mnusettings.UpdateMenusettings("153", SRemoveDublicateEntry.ToString());
           _Mnusettings.UpdateMenusettings("156", Partyproject.ToString());
           _Mnusettings.UpdateMenusettings("157", BarcodePrintLogo.ToString());

           _Mnusettings.UpdateMenusettings("158", Startupstock.ToString());
           _Mnusettings.UpdateMenusettings("159", startupBalance.ToString());
           _Mnusettings.UpdateMenusettings("160", Editsqty.ToString());
           _Mnusettings.UpdateMenusettings("161", PrintL.ToString());
           _Mnusettings.UpdateMenusettings("162", PrintCon.ToString());
           _Mnusettings.UpdateMenusettings("163", Salerateincludetax.ToString());
           _Mnusettings.UpdateMenusettings("164", Zerotaxamount.ToString());
           _Mnusettings.UpdateMenusettings("165", Pbillingdate.ToString());
           _Mnusettings.UpdateMenusettings("166", Singlebarcode.ToString());
           _Mnusettings.UpdateMenusettings("167", SalesArea.ToString());
           _Mnusettings.UpdateMenusettings("168", Savezeroratesales.ToString());
           _Mnusettings.UpdateMenusettings("169", PrintsecondlangagueBarcode.ToString());
           _Mnusettings.UpdateMenusettings("173", Salessearchingmode.ToString());
           _Mnusettings.UpdateMenusettings("181", Secondprinter.ToString());
           _Mnusettings.UpdateMenusettings("193", Sitemnote.ToString());
           _Mnusettings.UpdateMenusettings("194", Printnotax.ToString());
           _Mnusettings.UpdateMenusettings("195", bcodsrateenable.ToString());
           _Mnusettings.UpdateMenusettings("196",bcodllang.ToString());
           _Mnusettings.UpdateMenusettings("197", bcodcodevisibl.ToString());
           _Mnusettings.UpdateMenusettings("198", crlimiton.ToString());
           _Mnusettings.UpdateMenusettings("199", vehicle.ToString());
           _Mnusettings.UpdateMenusettings("200", mtrread.ToString());
           _Mnusettings.UpdateMenusettings("201", empsale.ToString());
           _Mnusettings.UpdateMenusettings("202", listvew.ToString());
           _Mnusettings.UpdateMenusettings("203", exandmandate.ToString());
           _Mnusettings.UpdateMenusettings("204", producttop.ToString());
             _Mnusettings.UpdateMenusettings("205", headervisibl.ToString());
             _Mnusettings.UpdateMenusettings("206", saleitemroundoff.ToString());
             _Mnusettings.UpdateMenusettings("207", prateinitemlist.ToString());
             _Mnusettings.UpdateMenusettings("208", weignRate.ToString());
             _Mnusettings.UpdateMenusettings("209", weignQTY.ToString());
            _Mnusettings.UpdateMenusettings("211", RPdetails.ToString());

            _Mnusettings.UpdateMenusettings("214", EnableMostmove.ToString());
            _Mnusettings.UpdateMenusettings("216", bcoderaterounding.ToString());
            _Mnusettings.UpdateMenusettings("217", userwisedisc.ToString());
            //_Mnusettings.UpdateMenusettings("218", purchprintwhile.ToString());
            //crlimitOn

            _Mnusettings.UpdateMenusettings("219", Stockshow.ToString());
           _Mnusettings.UpdateMenusettings("220", stockbottom.ToString());
           _Mnusettings.UpdateMenusettings("221", automodepurchase.ToString());
           _Mnusettings.UpdateMenusettings("222", customerwisetax.ToString());
           _Mnusettings.UpdateMenusettings("223", bcodeBold.ToString());
           _Mnusettings.UpdateMenusettings("225", datetwoline.ToString());
           _Mnusettings.UpdateMenusettings("226", ctrlQdatewise.ToString());
           _Mnusettings.UpdateMenusettings("227", prefixinSR.ToString());




        
        }

        public  void ControleChecked(CheckBox Chk,double CCoresponding)
        {
            if (Chk.Checked == true)
            {
                CCoresponding = 1;
            }
            else
            {
                CCoresponding = -1;
            }
            Coresponding = CCoresponding;
        }
      

        private void ChkItemwiseagentcomm_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkItemwiseagentcomm, Itemwisecomm);
            Itemwisecomm = Coresponding;
        }

        private void ChkEBatch_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkEBatch, Batchcode);
            Batchcode = Coresponding;
        }

        private void ChkEPOS_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkEPOS, POS);
            POS = Coresponding;
        }

        private void ChkEProduction_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkEProduction, Production);
            Production = Coresponding;
        }

        private void Chkepayroll_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkepayroll, Payroll);
            Payroll = Coresponding;
        }

        private void chkroundoff_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkroundoff,Roundoff);
            Roundoff = Coresponding;
        }

        private void ChkEmultirate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkEmultirate, Mrate);
            Mrate = Coresponding;
        }

        private void ChkEstockarea_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkEstockarea,Stockarea);
            Stockarea = Coresponding;
        }

        private void chketax_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chketax,Tax);
            Tax = Coresponding;
        }

        private void Chkecostcenter_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkecostcenter,Costcenter);
            Costcenter = Coresponding;
        }

        private void Chksitemdiscount_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chksitemdiscount, sitemdiscount);
            sitemdiscount = Coresponding;
        }

        private void chksfree_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chksfree, sfree);
            sfree = Coresponding;
        }

        private void chkeditsrate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkeditsrate, Editsrate);
            Editsrate = Coresponding;
        }

        private void chkdeliverynote_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkdeliverynote, Deliverynote);
            Deliverynote = Coresponding;
        }

        private void chksalesestimation_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chksalesestimation, Salesest);
            Salesest = Coresponding;
        }

        private void chksalesorder_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chksalesorder, Salesorder);
            Salesorder = Coresponding;
        }

        private void chkmeterialreceipt_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkmeterialreceipt, MeterialReceipt);
            MeterialReceipt = Coresponding;
        }

        private void chkpurchaseorder_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpurchaseorder, Purchaseorder);
            Purchaseorder = Coresponding;
        }

        private void chkpurchaseestimation_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpurchaseestimation, Purchaseest);
            Purchaseest = Coresponding;
        }

        private void chkpitemdiscount_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpitemdiscount, pitemdiscount);
            pitemdiscount = Coresponding;
        }

        private void chkpfree_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpfree, pfree);
            pfree = Coresponding;
        }

        private void chkeditpurchaserate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkeditpurchaserate, Editprate);
            Editprate = Coresponding;
        }

        private void chkwarncreditlimit_CheckedChanged(object sender, EventArgs e)
        {
            //ControleChecked(chkwarncreditlimit, Creditlimit);
            //Creditlimit = Coresponding;
        }

  

        private void Chkupdateprate_CheckedChanged(object sender, EventArgs e)
        {
        
            ControleChecked(Chkupdateprate,Updateprate );
            Updateprate = Coresponding;
        
        }

        private void Chksalesreturn_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chksalesreturn, Salesreturn);
            Salesreturn = Coresponding;
       
        }

        private void Chkpurchasereturn_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkpurchasereturn, Purchasereturn);
            Purchasereturn = Coresponding;
        }

       

        private void Chkmultiunit_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkmultiunit,Munit);
            Munit = Coresponding;
        }

        private void Chkupdatesrate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkupdatesrate, UpdateSrate);
            UpdateSrate = Coresponding;
        }

        private void Chkupdatemrp_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkupdatemrp,UpdateMrp);
            UpdateMrp = Coresponding;
        }

        private void cmdapply_Click(object sender, EventArgs e)
        {
            SetQuery();
        }

        private void chkemployeesales_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chksalesmansales, Semployee);
            Semployee = Coresponding;
        }

        private void chkagentsales_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkagentsales, Sagent);
            Sagent = Coresponding;
        }

        private void chkemployeepurchase_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkemployeepurchase, Pemployee);
            Pemployee = Coresponding;
        }

        private void chkagentpurchase_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkagentpurchase, Pagent);
            Pagent = Coresponding;
        }

        private void chkpexciseduty_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpexciseduty, Pexciseduty);
            Pexciseduty = Coresponding;
        }

        private void chkeditgrossamt_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpeditgrossamt, Peditgrossamount);
            Peditgrossamount = Coresponding;
        }

        private void raddot3_CheckedChanged(object sender, EventArgs e)
        {
            if (raddot3.Checked == true)
            {
                Printerselect = "1";
            }
        }

        private void raddot6_CheckedChanged(object sender, EventArgs e)
        {
            if (raddot6.Checked == true)
            {
                Printerselect = "2";
            }
        }

        private void raddot10_CheckedChanged(object sender, EventArgs e)
        {
            if (raddot10.Checked == true)
            {
                Printerselect = "3";
            }
        }

        private void radother3_CheckedChanged(object sender, EventArgs e)
        {
            if (radother3.Checked == true)
            {
                Printerselect = "4";
            }
        }

        private void radother6_CheckedChanged(object sender, EventArgs e)
        {
            if (radother6.Checked == true)
            {
                Printerselect = "5";
            }
        }

        private void radother10_CheckedChanged(object sender, EventArgs e)
        {
            if (radother10.Checked == true)
            {
                Printerselect = "6";
            }
        }

        private void chkuseasbarcode_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkuseasbarcode, Useasbarcode);
            Useasbarcode = Coresponding;
        }
       
        private void cmdautobackup1_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string Filepath = FBD.SelectedPath.ToString();
                txtautobackupfilepath1.Text = Filepath;
            }
        }

        private void chkautobackup_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkautobackup, Autobackup);
            Autobackup = Coresponding;
        }

        private void radbarcodeprintsrate_CheckedChanged(object sender, EventArgs e)
        {
            if(radbarcodeprintsrate.Checked==true)
            BarcodePrintin = "Srate";
        }

        private void radbarcodeprintmrp_CheckedChanged(object sender, EventArgs e)
        {
            if (radbarcodeprintmrp.Checked == true)
            BarcodePrintin = "MRP";
        }

        private void chkmixed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmixedkerala.Checked == true)
            {
                if (raddot6.Checked == true)
                {
                    Printerselect = "7";
                }
                if (raddot10.Checked == true)
                {
                    Printerselect = "8";
                }
            }
        }

        private void Chkesize_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkesize, Sizes);
            Sizes = Coresponding;
        }

        private void chka4split_CheckedChanged(object sender, EventArgs e)
        {
            if (chka4split.Checked == true)
            {
                Printerselect = "9";
            }
            
        }
        private void ChkSaleUpdateSalesrate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkSaleUpdateSalesrate, UpdateSrateInSale);
            UpdateSrateInSale = Coresponding;
        }

        private void chkflex_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkflex, Flex);
            Flex = Coresponding;
        }

        private void radotherdetail_CheckedChanged(object sender, EventArgs e)
        {
            if (radotherdetail.Checked == true)
            {
                Printerselect = "100";
            }
        }

        private void radmultipleprint_CheckedChanged(object sender, EventArgs e)
        {
            if (radmultipleprint.Checked == true)
            {
                Printerselect = "10";
            }
        }

        private void chkfocusfirstrow_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chksfocusfirstrow, SFocusFirstRow);
            SFocusFirstRow = Coresponding;
        }

        private void chkmixedkarnataka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmixedkarnataka.Checked == true)
            {
                if (raddot6.Checked == true)
                {
                    Printerselect = "11";
                }
                if (raddot10.Checked == true)
                {
                    Printerselect = "12";
                }
            }
        }

        private void chkpitemnote1_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpitemnote1, Pitemnote1);
            Pitemnote1 = Coresponding;
        }

        private void chkpitemnote2_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpitemnote2, Pitemnote2);
            Pitemnote2 = Coresponding;
        }

        private void chkcustomerpoint_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkcustomerpoint, Customerpoint);
            Customerpoint = Coresponding;
        }

        private void RadBPrintRoll_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBPrintRoll.Checked == true)
            {
                BarcodePrintSelect = -1;
                //txtlasertopmargin.Enabled = false;
                //txtlaserleftmargin.Enabled = false;
            }
           
        }

        private void RadBprintlaser_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBprintlaser.Checked == true)
            {
                BarcodePrintSelect = 1;
                //txtlasertopmargin.Enabled = true;
                //txtlaserleftmargin.Enabled = true;
            }
        }

        private void chkbpackeddate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkbpackeddate, PrintMandateBarcode);
            PrintMandateBarcode = Coresponding;
        }

        private void chkbnote1_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkbnote1, PrintNote1Barcode);
            PrintNote1Barcode = Coresponding;
        }

        private void chkbitemnote2_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkbitemnote2, PrintNote2Barcode);
            PrintNote2Barcode = Coresponding;
        }

        private void chkbsuppliercode_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkbsuppliercode, PrintNote2SupplierBarcode);
            PrintNote2SupplierBarcode = Coresponding;
        }

        private void chkdeactivecustomerzerobalance_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkdeactivecustomerzerobalance, SDeactiveEmployee);
            SDeactiveEmployee = Coresponding;
        }

        private void Raditemfirstsearch_CheckedChanged(object sender, EventArgs e)
        {
            if (Raditemfirstsearch.Checked == true)
                ItemSearch = 1;
        }

        private void Raditemlastkeysearch_CheckedChanged(object sender, EventArgs e)
        {
            if (Raditemlastkeysearch.Checked == true)
                ItemSearch = 2;
        }

        private void raditemanykeysearch_CheckedChanged(object sender, EventArgs e)
        {
            if (raditemanykeysearch.Checked == true)
                ItemSearch = 3;
        }

        private void chkcashcadjet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcashcadjet.Checked == true)
            {
                Scashcadjet = 1;
            }
            else
            {
                Scashcadjet = -1;
            }
        }

        private void chkcrm_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkcrm, SCRM);
            SCRM = Coresponding;
            _Companycreate.RefreshCRm();
        }

        private void chkslnotracking_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkslnotracking, SerialNoTracking);
            SerialNoTracking = Coresponding;
        }

        private void chkbarcodehusecompanyname_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkbarcodehusecompanyname, CompanyNameAsBarcodeHeading);
            CompanyNameAsBarcodeHeading = Coresponding;
        }

        private void chksinvoicedisc_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chksinvoicedisc,SinvoiceDiscount);
            SinvoiceDiscount = Coresponding;
        }

        private void chkweightmachine_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkweightmachine, Wieghtmachine);
            Wieghtmachine = Coresponding;
        }

        private void chkenpharmacy_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkcrm, SCRM);
            SCRM = Coresponding;
            _Companycreate.RefreshParmacy();

            ControleChecked(chkenpharmacy,Pharmacy);
            Pharmacy = Coresponding;
        }

        private void chkvisibleprate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkvisibleprate, Visibleprate);
            Visibleprate = Coresponding;
        }

        private void chkeditgrossamountinsales_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkeditgrossamountinsales, EditSGrossamount);
            EditSGrossamount = Coresponding;
        }

        private void chkvisiblessrate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkvisiblessrate, VSSrate);
            VSSrate = Coresponding;
        }

        private void raddot8_CheckedChanged(object sender, EventArgs e)
        {
            if (raddot8.Checked == true)
            {
                Printerselect = "18";
            }
        }

        private void radbarcodeprintnone_CheckedChanged(object sender, EventArgs e)
        {
            if (radbarcodeprintnone.Checked == true)
                BarcodePrintin = "None";
           
        }

        private void Chksupplierwiseitem_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chksupplierwiseitem, Supplierwiseitem);
            Supplierwiseitem = Coresponding;
        }

        private void chkprintbalance_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkprintbalance, PrintBalance);
            PrintBalance = Coresponding;
        }

        private void radprintratebyitems_CheckedChanged(object sender, EventArgs e)
        {
            if (radprintratebyitems.Checked == true)
                BarcodePrintin = "Namewithrate";
            
        }

        private void cmdautobackup2_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string Filepath = FBD.SelectedPath.ToString();
                txtautobackupfilepath2.Text = Filepath;
            }
        }

        private void cmdautobackup3_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string Filepath = FBD.SelectedPath.ToString();
                txtautobackupfilepath3.Text = Filepath;
            }
        }

        private void cmdautobackup4_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string Filepath = FBD.SelectedPath.ToString();
                txtautobackupfilepath4.Text = Filepath;
            }
        }

        private void chkpsavezerorate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpsavezerorate, SaveZeroRate);
            SaveZeroRate = Coresponding;
        }

        private void chkremovedublicate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkremovedublicate, SRemoveDublicateEntry);
            SRemoveDublicateEntry = Coresponding;
        }

        private void chkepartyproject_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkepartyproject, Partyproject);
            Partyproject = Coresponding;
        }

       

        private void chkprintbarcodelogo_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkprintbarcodelogo, BarcodePrintLogo);
            BarcodePrintLogo = Coresponding;
        }

        private void cmdsett_Click(object sender, EventArgs e)
        {
           if(regKey.ValueCount==0)
            regKey = regKey.CreateSubKey("Software\\Techno");

            regKey.SetValue("Hpwd", txtestimatepwd.textBox1.Text);
        }

      

        private void chkstrshowstock_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkstrshowstock, Startupstock);
            Startupstock = Coresponding;

            if (chkstrshowstock.Checked == true)
            {
                Txtstrshowstartupstock.Enabled = true;
            }
            else
            {
                Txtstrshowstartupstock.Enabled = false;
            }
        }

        private void Chkstrshowbalance_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkstrshowbalance, startupBalance);
            startupBalance = Coresponding;

            if (Chkstrshowbalance.Checked == true)
            {
                Txtstrshowstartupbalance.Enabled = true;
            }
            else
            {
                Txtstrshowstartupbalance.Enabled = false;
            }
        }

        private void chkseditqty_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkseditqty, Editsqty);
            Editsqty = Coresponding;
        }

        private void chkprintllangague_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkprintllangague, PrintL);
            PrintL = Coresponding;
        }

        private void RadBprintbutterfly_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBprintbutterfly.Checked == true)
            {
                BarcodePrintSelect = 2;
                //txtlasertopmargin.Enabled = true;
                //txtlaserleftmargin.Enabled = true;
            }
        }

        private void chkshowestimateledger_CheckedChanged(object sender, EventArgs e)
        {

            if (chkshowestimateledger.Checked == true)
            {
                Generalfunction.BlShowEst = true;
            }
            else
            {
                Generalfunction.BlShowEst = false;
            }
        }

        private void chkconsole_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkconsole, PrintCon);
            PrintCon = Coresponding;
        }

        private void chksetsaleincludetax_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chksetsaleincludetax, Salerateincludetax);
            Salerateincludetax = Coresponding;
        }

        private void chkzerotaxamount_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkzerotaxamount, Zerotaxamount);
            Zerotaxamount = Coresponding;
        }

        private void chkpbillingdate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpbillingdate, Pbillingdate);
            Pbillingdate = Coresponding;
        }

        private void Chksinglebarcode_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chksinglebarcode, Singlebarcode);
            Singlebarcode = Coresponding;
        }

        private void Chksalearea_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chksalearea, SalesArea);
            SalesArea = Coresponding;
        }

        private void Chksavezeroratesales_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chksavezeroratesales, Savezeroratesales);
            Savezeroratesales = Coresponding;
        }

        private void raddotmobile_CheckedChanged(object sender, EventArgs e)
        {
            if (raddotmobile.Checked == true)
            {
                Printerselect = "DotMobile";
            }
        }

        private void Chkpprintsecondlangague_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkpprintsecondlangague, PrintsecondlangagueBarcode);
            PrintsecondlangagueBarcode = Coresponding;
        }

        private void Rad3pointarabic_CheckedChanged(object sender, EventArgs e)
        {
            if (Rad3pointarabic.Checked == true)
            {
                Printerselect = "3pointArabic";
            }
        }

        private void Raddotpreprinted_CheckedChanged(object sender, EventArgs e)
        {
            if (Raddotpreprinted.Checked == true)
            {
                Printerselect = "DotPreprinted";
            }
        }

        private void ChkEditItemName_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEditItemName.Checked == true)
            {
                EditPItemName = "1";
            }
            else
            {
                EditPItemName = "-1";
            }
        }

        private void Chkpedititemcode_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkpedititemcode.Checked == true)
            {
                EditPitemCode = "1";
            }
            else
            {
                EditPitemCode = "-1";
            }
        }

        private void ChkpprintTaxrateinclusive_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkpprintTaxrateinclusive.Checked == true)
            {
                Pprintinclusive = "1";
            }
            else
            {
                Pprintinclusive = "-1";
            }
        }

        private void chkservices_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkservices, enableservice);
            enableservice = Coresponding;
        }

        private void PnlGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkprintfooter_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkprintfooter, enablefooter);
            enablefooter = Coresponding;

        }

        private void chkwarranty_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkwarranty, enbleWrrnty);
            enbleWrrnty = Coresponding;


        }

        private void Comtaxinclusivesales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkfootpostn_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkfootpostn, footrStrt);
            footrStrt = Coresponding;
        }
        public void retrive()
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramvalue!='' and paramname IN('footer1','footer2','footer3','footer4','footer5') ");
            if (Ds.Tables[0].Rows.Count > 0)
            {

                txtfarab.textBox1.Text = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer1'").ToString();
                txtL2.Text=_Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer2'").ToString();

                txtL3.Text=_Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer3'").ToString(); 
                txtL4.Text =_Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer4'").ToString();
                txtL5.Text = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer5'").ToString();
            }
        
        
        }
        public void textproperty()
        {
            string ON ="";
            ON = _Dbtask.ExecuteScalar("Select status from tblmnusettings where menuid='102030' and menuname='footerStart'").ToString();
            if (ON == "1")
            {
                txtfarab.textBox1.RightToLeft = RightToLeft.Yes;
                txtL2.RightToLeft = RightToLeft.Yes;
                txtL3.RightToLeft = RightToLeft.Yes;
                txtL4.RightToLeft = RightToLeft.Yes;
                txtL5.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                txtfarab.textBox1.RightToLeft = RightToLeft.No;
                txtL2.RightToLeft = RightToLeft.No;
                txtL3.RightToLeft = RightToLeft.No;
                txtL4.RightToLeft = RightToLeft.No;
                txtL5.RightToLeft = RightToLeft.No;
            }
        }


        private void Cmdfooterset_Click(object sender, EventArgs e)
        {

            retrive();
            textproperty();
            panelfootr.Visible = true;
            this.panelfootr.Location = this.panelfootr.Location = new System.Drawing.Point(150,270);
            //panelfootr.Visible = true;
        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void cmdFclose_Click(object sender, EventArgs e)
        {

            FL1 = txtfarab.textBox1.Text.Replace("\r", " ");
            FL1 = FL1.Replace("\n", " ");
            //FL1 = txtfarab.textBox1.Text.ToString();//txtL1.Text.ToString();
            FL2 = txtL2.Text.Replace("\r", " ");
            FL2 = FL2.Replace("\n", " ");

            FL3 = txtL3.Text.Replace("\r", " ");
            FL3 = FL3.Replace("\n", " ");

            FL4 = txtL4.Text.Replace("\r", " ");
            FL4 = FL4.Replace("\n", " ");

            FL5 = txtL5.Text.Replace("\r", " ");
            FL5 = FL5.Replace("\n", " "); 
            
           
            panelfootr.Visible = false;

        }

        private void ChkfootMid_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkfootMid, footrmidd);
            footrmidd = Coresponding;
        }

        private void chkQrcode_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkQrcode,QRvisible);
            QRvisible = Coresponding;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtL5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtL4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtL3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtL2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfarab_Load(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void panelfootr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Chkssearchingmode_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkssearchingmode, Salessearchingmode);
            Salessearchingmode = Coresponding;
        }

        private void chkprintoldblnce_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkprintoldblnce, Poldbalance);
            Poldbalance = Coresponding;
        }

        private void chkbaseunit_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkbaseunit, baseunit);
            baseunit = Coresponding;
        }

        private void chkmixed3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmixed3.Checked == true)
            {
                if (raddot6.Checked == true)
                {
                    Printerselect = "14";
                }

            }
        }

        private void CHKTAILLOR_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(CHKTAILLOR, tailor);
            tailor = Coresponding;
        }

        private void Chkenablesecondprinter_CheckedChanged(object sender, EventArgs e)
        {
            FuSecondPrinter();
        }

        private void Chksitemnote_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chksitemnote, Sitemnote);
            Sitemnote = Coresponding;
        }

        private void ChkprintnoTax_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkprintnoTax, Printnotax);
            Printnotax = Coresponding;
        }

        private void combprintselectn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combprintselectn.SelectedIndex == 0)
            {
                Printerselect = "4";

            }
             if (combprintselectn.SelectedIndex == 1)
            {
                Printerselect = "3pointArabic";
            }
           if (combprintselectn.SelectedIndex == 2)
            {
                Printerselect = "9";//half
            }
             if (combprintselectn.SelectedIndex == 3)
            {
                Printerselect = "A4Preprint2";//wthunit m1
            }
            if (combprintselectn.SelectedIndex == 4)
            {
                Printerselect = "A4Preprint";//m2 preprint simple
            }
            if (combprintselectn.SelectedIndex == 5)
            {
                  Printerselect = "mode3";//no unit m3
            }
            if (combprintselectn.SelectedIndex == 6)
            {
                Printerselect = "mode4";//m4 itemcode
            }
            if (combprintselectn.SelectedIndex == 7)
            {
                Printerselect = "mode5";//m5 txlow

            }
            if (combprintselectn.SelectedIndex == 8)
            {
                Printerselect = "mode6";//m5 code,no unit

            }
            if (combprintselectn.SelectedIndex == 9)
            {
                Printerselect = "mode7";//2 INch

            }
            if (combprintselectn.SelectedIndex == 10)
            {
                Printerselect = "A4Qatar";

            }
            if (combprintselectn.SelectedIndex == 11)
            {
                Printerselect = "A4ModeNew";

            }
            if (combprintselectn.SelectedIndex == 12)
            {
                Printerselect = "ThermalarabNotax";

            }
            if (combprintselectn.SelectedIndex == 13)
            {
                Printerselect = "ThermalenglishNotax";

            }
            if (combprintselectn.SelectedIndex == 14)
            {
                Printerselect = "Workshopmode3";

            }

            if (combprintselectn.SelectedIndex == 15)
            {
                Printerselect = "Workshopmode3Notax";

            }

            if (combprintselectn.SelectedIndex == 16)
            {
                Printerselect = "codenameNotax";

            }

            if (combprintselectn.SelectedIndex == 17)
            {
                Printerselect = "NameNotax";

            }


        }
        public void limit(double val)
        {
        if(val>=200)
        {
            MessageBox.Show("very high, allow below 200 ");
            txtcodewidth.textBox1.Focus();
       }
        }
            

        private void txtcodewidth_Load(object sender, EventArgs e)
        {
            

        }

        private void txtcodewidth_TextChanged(object Sender, EventArgs e)
        {
           double valuee = 0;
            valuee = _Dbtask.znlldoubletoobject(txtcodewidth.textBox1.Text);
            limit(valuee);
            
        }

        private void Chkbcodesrate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(Chkbcodesrate, bcodsrateenable);
            bcodsrateenable = Coresponding;
        }

        private void chkllangbcode_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkllangbcode, bcodllang);
            bcodllang = Coresponding;
        }

        private void chkcodeinbcode_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkcodeinbcode, bcodcodevisibl);
            bcodcodevisibl = Coresponding;
        }

        private void ChkcreditlimitON_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkcreditlimitON, crlimiton);
            crlimiton = Coresponding;
        }

        private void chkvehicle_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkvehicle, vehicle);
            vehicle = Coresponding;
        }

        private void chkmtrread_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkmtrread, mtrread);
            mtrread = Coresponding;
        }

        private void chkempsales_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkempsales, empsale);
            empsale = Coresponding;
        }

        private void PnlSales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TRMain_MouseHover(object sender, EventArgs e)
        {
            //TRMain.BackColor = Color.DarkGreen;
        }

        private void txtcodewidth_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //int valuee = 0;
            //valuee = Convert.ToInt32(txtcodewidth.textBox1.Text);
            //limit(valuee);
        }

        private void pnldefault_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkitemlistview_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkitemlistview, listvew);
            listvew = Coresponding;
           
        }

        private void chkmanexdate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkmanexdate, exandmandate);
            exandmandate = Coresponding;
           
        }

        private void chkitemnametop_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkitemnametop,producttop);
            producttop = Coresponding;
        }

        private void chkheaderVisible_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkheaderVisible, headervisibl);
            headervisibl = Coresponding;
        }

        private void chkSaleitemroundoff_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkSaleitemroundoff, saleitemroundoff);
            saleitemroundoff = Coresponding;
        }

        private void Chkprateinlist_CheckedChanged(object sender, EventArgs e)
        {

            ControleChecked(Chkprateinlist, prateinitemlist);
            prateinitemlist = Coresponding;
            
        }

        private void chkbarcoderate_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkbarcoderate, weignRate);
            weignRate = Coresponding;
        }

        private void ChkbcodeQty_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(ChkbcodeQty, weignQTY);
            weignQTY = Coresponding;
        }

        private void CHKautomaticmodeSET_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(CHKautomaticmodeSET, automaticmodeSET);
            automaticmodeSET = Coresponding;
        }

        private void ChkRPdetails_CheckedChanged(object sender, EventArgs e)
        {

            ControleChecked(ChkRPdetails, RPdetails);
            RPdetails = Coresponding;
            
        }

        private void gridmostmove_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridmostmove.SelectedCells.Count > 0)
                {
                    columnindex = gridmostmove.SelectedCells[0].ColumnIndex;
                    rowindex = gridmostmove.SelectedCells[0].RowIndex;
                    //if (gridmostmove.Columns[columnindex].Name.ToString() == "Clnbcode")
                    //{
                    //    if (_Dbtask.znllString(gridmostmove.Rows[rowindex].Cells["Clnbcode"].Value)!="")
                    //    {

                    //    string mbatch="";
                    //    string itmidd="";
                    //    mbatch = _Dbtask.znllString(gridmostmove.Rows[rowindex].Cells["Clnbcode"].Value);
                    //gridmostmove.Rows[rowindex].Cells["Clnpname"].Tag = CommonClass._Batch.GetSpecificFieldByBarcode("Itemid", mbatch);
                    //itmidd=CommonClass._Batch.GetSpecificFieldByBarcode("Itemid", mbatch);

                    //gridmostmove.Rows[rowindex].Cells["Clnpname"].Value =_Dbtask.znllString( CommonClass._Itemmaster.SpecificField(itmidd, "itemname"));
                    
                        //}
                    //}
                }
            }
            catch
            {
            }
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            gridmostmove.Rows[rowindex].Cells[columnindex].Value = (sender as TextBox).Text;
       
        }
        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (columname == "Clnbcode" || columname == "Batch")
                {
                   
                    if (e.KeyValue == 13)
                    {
                        if (gridmostmove.SelectedCells.Count > 0)
                        {
                            gridmostmove.NotifyCurrentCellDirty(false);

                            columnindex = gridmostmove.SelectedCells[0].ColumnIndex;
                            rowindex = gridmostmove.SelectedCells[0].RowIndex;
                            if (gridmostmove.Columns[columnindex].Name.ToString() == "Batch")
                            {
                                if (_Dbtask.znllString(gridmostmove.Rows[rowindex].Cells["Batch"].Value) != "")
                                {

                                    string mbatch = "";
                                    string itmidd = "";
                                    mbatch = _Dbtask.znllString(gridmostmove.Rows[rowindex].Cells["Batch"].Value);
                                    gridmostmove.Rows[rowindex].Cells["Item"].Tag = CommonClass._Batch.GetSpecificFieldByBarcode("Itemid", mbatch);
                                    itmidd = CommonClass._Batch.GetSpecificFieldByBarcode("Itemid", mbatch);

                                    gridmostmove.Rows[rowindex].Cells["Item"].Value = _Dbtask.znllString(CommonClass._Itemmaster.SpecificField(itmidd, "itemname"));
                                    gridmostmove.Rows[rowindex].Cells["MMpcode"].Value = CommonClass._Batch.GetSpecificFieldByBarcode("Itemid", mbatch);
                                }
                            }

                        }

                    }
                }
            }
            catch
            {
            }
        }

        private void gridmostmove_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columnindex = gridmostmove.CurrentCell.ColumnIndex;
            rowindex = gridmostmove.CurrentCell.RowIndex;
            columname = gridmostmove.Columns[columnindex].Name.ToString();
        }

        private void gridmostmove_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);

            //txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
            //txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

        private void chkmostmove_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkmostmove, EnableMostmove);
            EnableMostmove = Coresponding;
        }

        private void lblsample_Click(object sender, EventArgs e)
        {
            Frmbcodesettsample _frm = new Frmbcodesettsample();
            _frm.ShowDialog();
        }

        private void chkrateroundoffbcode_CheckedChanged(object sender, EventArgs e)
        {

            ControleChecked(chkrateroundoffbcode, bcoderaterounding);
            bcoderaterounding = Coresponding;
            
        }

        private void chkuserwisedisc_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkuserwisedisc, userwisedisc);
            userwisedisc = Coresponding;
        }

        private void chkpurchpritwhile_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkpurchpritwhile, purchprintwhile);
            purchprintwhile = Coresponding;
        }

        private void combprintselectnpurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combprintselectnpurchase.SelectedIndex == 0)
            {
                Printerselectpurch = "4";

            }
            if (combprintselectnpurchase.SelectedIndex == 1)
            {
                Printerselectpurch = "3pointArabic";
            }
            if (combprintselectnpurchase.SelectedIndex == 2)
            {
                Printerselectpurch = "9";//half
            }
            if (combprintselectnpurchase.SelectedIndex == 3)
            {
                Printerselectpurch = "A4Preprint2";//wthunit m1
            }
            if (combprintselectnpurchase.SelectedIndex == 4)
            {
                Printerselectpurch = "A4Preprint";//m2 preprint simple
            }
            if (combprintselectnpurchase.SelectedIndex == 5)
            {
                Printerselectpurch = "mode3";//no unit m3
            }
            if (combprintselectnpurchase.SelectedIndex == 6)
            {
                Printerselectpurch = "mode4";//m4 itemcode
            }
            if (combprintselectnpurchase.SelectedIndex == 7)
            {
                Printerselectpurch = "mode5";//m5 txlow

            }
            if (combprintselectnpurchase.SelectedIndex == 8)
            {
                Printerselectpurch = "mode6";//m5 code,no unit

            }
            if (combprintselectnpurchase.SelectedIndex == 9)
            {
                Printerselectpurch = "mode7";//2 INch

            }
            if (combprintselectnpurchase.SelectedIndex == 10)
            {
                Printerselectpurch = "A4Qatar";

            }
            if (combprintselectnpurchase.SelectedIndex == 11)
            {
                Printerselectpurch = "A4ModeNew";

            }

            if (combprintselectnpurchase.SelectedIndex == 12)
            {
                Printerselectpurch = "ThermalarabNotax";

            }
            if (combprintselectnpurchase.SelectedIndex == 13)
            {
                Printerselectpurch = "ThermalenglishNotax";

            }

        }

        private void chkstockshow_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkstockshow, Stockshow);
            Stockshow = Coresponding;
            
        }

        private void chkbottomstock_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkbottomstock, stockbottom);
            stockbottom = Coresponding;
        }

        private void chkautomodepurchase_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkautomodepurchase, automodepurchase);
            automodepurchase = Coresponding;
            
        }

        public void SAVESETsecondprintmodel()
        {
            CommonClass._Dbtask.Setsecondprintmodel(_Dbtask.znllString(combsecondaryModel.Text));

        }

        public void GETsecondprintmodel()
        {
            combsecondaryModel.Text = _Dbtask.znllString(CommonClass._Dbtask.Getsecondprintmodel());
            SAVESETsecondprintmodel();

        }

        private void CHKCUSwisevat_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(CHKCUSwisevat, customerwisetax);
            customerwisetax = Coresponding;
        }

        private void chkbcodeprintBold_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkbcodeprintBold, bcodeBold);
            bcodeBold = Coresponding;
        }

        private void chkdatetwoline_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chkdatetwoline, datetwoline);
            datetwoline = Coresponding;
        }

        private void cmdsummerrefresh_Click(object sender, EventArgs e)
        {
            _Dbtask.ExecuteNonQuery("delete TblOtherprintsets");

            CommonClass._otherPrint.defaultvalsetotherprint();

            ShowAllitemssts();

        }

        private void chkdatewisectrlreport_CheckedChanged(object sender, EventArgs e)
        {
             ControleChecked(chkdatewisectrlreport, ctrlQdatewise);
            ctrlQdatewise = Coresponding;
            
        }

        private void combsecondaryModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CHKinsrprefix_CheckedChanged(object sender, EventArgs e)
        {


            ControleChecked(CHKinsrprefix, prefixinSR);
            prefixinSR = Coresponding;
            
           
        }
        
      
    }
}
