using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using Microsoft.Win32;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class MDIParent2 : Form
    {
        private int childFormNumber = 0;

        public MDIParent2()
        {
            InitializeComponent();
        }
        int Count;
        public static bool registered = false;
        int selectedRow;
        public static string OpCompany;
        string Temp; public static bool billsetSI = false;
        Frmusercontroles _userControles = new Frmusercontroles();
        RegistryKey regKey = Registry.CurrentUser;
        DBTask _Dbtask = new DBTask();
        DataSet Ds;
        bool IsVisible;
        Frmusercontroles _form = new Frmusercontroles();
        FrmProductdetails _prd = new FrmProductdetails();
        public string ReportType;

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
                menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                MenuConversion();
                

            }
        }

        public void MenuConversion()
        {
       // this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            for (int i = 0; i < menuStrip.Items.Count; i++)
            {
                string MenuName;
                MenuName = menuStrip.Items[i].Name;
                menuStrip.Items[i].Text = CommonClass._Language.GetArabicString(menuStrip.Items[i].Text);
                if (MenuName == "Createmenu")
                {
                    menuStrip.Items[i].Text = " خلق  ";
                }
               
                // for(int k=0;k<=menuStrip.Items[MenuName].items
                foreach (ToolStripMenuItem itm in menuStrip.Items)
                {
                    for (int k = 0; k < itm.DropDownItems.Count; k++)
                    {
                        if (itm.DropDownItems[k].Text == "Items Category")
                        {
                            itm.DropDownItems[k].Text = " مجموعة العناصر";
                        }
                        if (itm.DropDownItems[k].Text == "Simple Item")
                        {
                            itm.DropDownItems[k].Text = "بند بسيط";
                        }
                        else
                        {
                            itm.DropDownItems[k].Text = CommonClass._Language.GetArabicString(itm.DropDownItems[k].Text);
                        }
                    }  
                }
            }
        }
        public void MdiLoad()
        {
            Generalfunction.MdiHieght = this.Size.Height;
            Generalfunction.Mdiwidth = this.Size.Width;
            CommonClass._Gen.SetBahavQuries();
            // Active = false;
            FrmLogin _Login = new FrmLogin();
            // usctools1.Enabled = false;

            // _Login.MdiParent = this;
            Generalfunction.Comeform = "MDILOAD";
            if (regKey.ValueCount < 2)
            {
                regKey = regKey.CreateSubKey("Software\\Techno");
            }

            //_Login.MdiParent = this;
            _Login.WindowState = System.Windows.Forms.FormWindowState.Normal;
            _Login.ShowDialog();
            //if (CommonClass._ClsCheque.ShowChequeRecholding() == true)
            //{
            //    FrmCheque _Cheque = new FrmCheque();
            //    _Cheque.mode = 0;
            //    _Cheque.ShowDialog();
            //}
            //if (CommonClass._ClsCheque.ShowChequePayholding() == true)
            //{
            //    FrmCheque _Cheque = new FrmCheque();
            //    _Cheque.mode = 1;
            //    _Cheque.ShowDialog();
            //}
            CommonClass._Gen.StartUpWindow();
            MenusettingsAndRefreshDB();
            
            //break;
            //FormShowNromal(_Login);
        }
       
        public void SetCounterSales()
        {
            if (ClsUserDetails.UserGroupid == "100" || ClsUserDetails.UserGroupid == "101")
            {
                menuStrip.Visible = false;
                menuStrip.Enabled = false;
              //  menuStrip.
                for(int i=0;i<menuStrip.Items.Count;i++)
                {
                    menuStrip.Items.Remove(menuStrip.Items[i]);
                }
                   // toolStripTextBox1.Visible = false;
              //  menuStrip.Items
            }
            else
            {
                menuStrip.Visible = true;
                menuStrip.Enabled = true;
                toolStripTextBox1.Visible = true;
                //menuStrip.Items.IsReadOnly = false;

            }
        }

        public void MaxforSett(Form Frm)
                {
           // Frm.Size = new System.Drawing.Size(this.Width - 40, this.Size.Height - 130 - toolStrip.Height);
            Frm.Location = new Point(0, 0);
            Frm.Size = new System.Drawing.Size(this.Width - 20, this.Size.Height - toolStrip.Height-90);

           // Frm.Size = new System.Drawing.Size(
        }

        public void MenusettingsAndRefreshDB()
        {
            ShowCompanyName();
            CommonClass._Nextg.RefreshDB();
            Menusettings();
        }

        public void ShowCompanyName()
        {
            Toolcompanyname.Text = CommonClass._Dbtask.currentcompany();
            Tooluser.Text = ClsUserDetails.MUserName;
            Toolcompanyprofile.Text = CommonClass._compMaster.GetspecifField("cname").ToString();
        
        }

        public void VisblityFunction(string Status)
        {
            if (Status == "1")
            {
                IsVisible = true;
            }
            else
            {
                IsVisible = false;
            }
        }

        public void Menusettings()
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings");
            if (Ds.Tables[0].Rows.Count > 0)
            {

                VisblityFunction( CommonClass._settings.ReturnStatus("11"));/*Multi Rate*/

                    ClsMenusettings.EMRate = IsVisible;
                    mnumultirate.Visible = IsVisible;

               VisblityFunction(  CommonClass._settings.ReturnStatus("12"));/*Multi Unit*/

                    ClsMenusettings.EMunit = IsVisible;
                    mnumultiunit.Visible = IsVisible;


                VisblityFunction(  CommonClass._settings.ReturnStatus("13"));/*Stock Area*/

                    ClsMenusettings.EDepot = IsVisible;
                    mnustockarea.Visible = IsVisible;


               VisblityFunction( CommonClass._settings.ReturnStatus("14"));/*TAX*/

                    ClsMenusettings.ETax = IsVisible;
                   // mnutax.Visible = IsVisible;
            

                VisblityFunction(  CommonClass._settings.ReturnStatus("105"));/*Production*/

                    ClsMenusettings.EProduction = IsVisible;
                    Productionmenu.Visible = IsVisible;
             

                VisblityFunction(  CommonClass._settings.ReturnStatus("21"));/*Sales Estimation*/
             
                    ClsMenusettings.ESalesestimation = IsVisible;
                

                VisblityFunction( CommonClass._settings.ReturnStatus("22"));/*Sales Return*/
              
                    ClsMenusettings.ESalesreturn = IsVisible;
                    mnusalesreturn.Visible = IsVisible;
                

                VisblityFunction( CommonClass._settings.ReturnStatus("137"));/*Deactive Ledger*/
                
                    Clssettings.SDeactiveLedger = IsVisible;
               

                VisblityFunction( CommonClass._settings.ReturnStatus("140"));/*CRM*/
                
                    ClsMenusettings.ECRM = IsVisible;
                    crmmenu.Visible = IsVisible;
                

                   VisblityFunction( CommonClass._settings.ReturnStatus("123"));/*SIZE*/
               
                    ClsMenusettings.ESizes = IsVisible;
                    mnusizes.Visible = IsVisible;

                    VisblityFunction(CommonClass._settings.ReturnStatus("103"));/*Batch*/

                    ClsMenusettings.EBatch = IsVisible;
              

                ClsMenusettings.ItemSearch = CommonClass._Paramlist.GetParamvalue("ItemSearch");
                CommonClass._settings.SetDecc();
            }
        }

        public void ShowselectprofitandLossAccount()
        {
            FrmSelectPandL _SelectPandL = new FrmSelectPandL();
            FormShowNromal(_SelectPandL);
        }

        public void ShowSMS()
        {
            Frmmessege _mess = new Frmmessege();
            FormShowNromal(_mess);
        }

        public void ShowPhysicalStock()
        {
            Frmphysical _PhysicalStock = new Frmphysical();
            MaxforSett(_PhysicalStock);
            FormShowNromal(_PhysicalStock);
        }
        public void Showstockadjustment()
        {
            Frmstockadjustment _Stockadjustment = new Frmstockadjustment();
            FormShowNromal(_Stockadjustment);
        }
        public void ShowLabelprinting()
        {
            Frmlabelprinting _Labelprinting = new Frmlabelprinting();
            FormShowNromal(_Labelprinting);
        }
        public void ShowreorderReport()
        {
            frmreorderreport _ReorderReport = new frmreorderreport();
            MaxforSett(_ReorderReport);
            FormShowNromal(_ReorderReport);
        }
        public void Showtransferwindow()
        {
            frmTransferwindow _transfer = new frmTransferwindow();
            FormShowNromal(_transfer);
        }
        public void ShowCompanyProfile()
        {
            FrmCreateCompany _CompanyProf = new FrmCreateCompany();
            FormShowNromal(_CompanyProf);
        }
        public void ShowSecondphaseCompanyprofile()
        {
            FrmAutogenerate _CompanyProf = new FrmAutogenerate();
            FormShowNromal(_CompanyProf);
        }
        public void ShowPOS()
        {
            Frmsalespos _pos = new Frmsalespos();
            MaxforSett(_pos);
            FormShowNromal(_pos);
        }

        public void     ShowSales(string Heading,string Vtype)
        {
            frmsalesinvoice _Sales = new frmsalesinvoice();
            MaxforSett(_Sales);

            if (Heading == "Sales Return"||Heading =="Sales Order"||Heading =="Sales Quatation")
            {
                _Sales.SalesAccount = "2";
            }
            else
            {
                _Sales.SalesAccount = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + Heading + "'");
            }
            if (Heading == "Services")
            {
                _Sales.SalesAccount = "14";
            }
            

            if (_Sales.SalesAccount != "")
            {
                _Sales.Heading = Heading;
                _Sales.Vtype = Vtype;
                FormShowNromal(_Sales);
            }
            else
            {
                MessageBox.Show("Create a Ledger", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        

        public void ShowPurchase(string Heading, string Vtype)
        {
            Frmpurchase _purchase = new Frmpurchase();
            if (Heading == "Purchase Return" || Heading == "Purchase Order")
            {
                _purchase.PurchaseAccount = "3";
            }
            else
            {
                _purchase.PurchaseAccount = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + Heading + "'");
            }
            MaxforSett(_purchase);
            _purchase.Heading = Heading;
            _purchase.Vtype = Vtype;
            _purchase.Isinotherwindow = false;
            FormShowNromal(_purchase);
        }

        public void FormShowNromal(Form FormName)
        {
            try
            {
                FormName.MdiParent = this;
                FormName.WindowState = System.Windows.Forms.FormWindowState.Normal;
                FormName.Show();
            }
            catch
            {
            }
        }

        public void Showcashcadjetinmain()
        {
            Frmf2 _F2 = new Frmf2();
            FormShowNromal(_F2);
        }

        public void ShowTraidingAccount()
        {
            FrmReport _report = new FrmReport();
            _report.DTFrom = Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
            _report.DTTo = Convert.ToDateTime(DateTime.Now);
            _report.ReportType = "Trading Account";

            MaxforSett(_report);
            FormShowNromal(_report);
        }

        public void ShowBalancesheet()
        {
            FrmReport _report = new FrmReport();
            _report.DTFrom = Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
            _report.DTTo = Convert.ToDateTime(DateTime.Now);

            ClsReports.DTFrom =Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
            ClsReports.DTTo = Convert.ToDateTime(DateTime.Now);
            _report.ReportType = "Balancesheet";

            MaxforSett(_report);
            FormShowNromal(_report);
        }

        public void Showcashcadjet()
        {
              FrmReport _report = new FrmReport();
               _report.DTFrom = Convert.ToDateTime(DateTime.Now);
               _report.DTTo = Convert.ToDateTime(DateTime.Now);

               _report.ReportType = "Cashcadjet";
               _report.Query = "select * from tblgeneralledger ";

               Clsselectreport.RType = "Cashcadjet";
               Clsselectreport.RQuery = _report.Query;
               Clsselectreport.RQueryTemp = _report.QueryTemp;
               Clsselectreport.RQueryDetail = _report.QueryDetail;
               Clsselectreport.RDtfrom = _report.DTFrom;
               Clsselectreport.Rdtto = _report.DTTo;

               MaxforSett(_report);
               FormShowNromal(_report);
        }
        private void ShowNewForm(object sender, EventArgs e)
        
{
            FrmCompanyName _Form = new FrmCompanyName();
            FormShowNromal(_Form);
            //_Form.ShowDialog();
            Toolcompanyname.Text = Generalfunction.OpCompany;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent2_Load(object sender, EventArgs e)
        {
            try
            {
                MdiLoad();
                FormShowNromal(_form);

                if (CommonClass._Menusettings.GetMnustatus("177") == "1")
                {
                    FormShowNromal(_prd);
                }

                MainRefresh();
                DetectLanguage();
                if (IsArabic == true)
                {
                    _form.Location = new Point(menuStrip.Size.Width - _form.Width - 4, 0);
                    _prd.Location = new Point(0, 0);
                }
                else
                {
                    _prd.Location = new Point(menuStrip.Size.Width - _prd.Width - 4, 0);
                    _form.Location = new Point(0, 0);
                }
                toolStrip.Visible = true;
                SetCounterSales();
                toolStripTextBox1.Focus();
                ChangeLanguage();
                mnubarcodetools.Visible = true;
                CommonClass._Nextg.FormIcon(this);
            }
            catch
            {
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmaboutus _About = new Frmaboutus();
            _About.ShowDialog();
        }

        public string ImageToBase64(Image image,
          System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        
        private void mnudeletecompany_Click(object sender, EventArgs e)
        {
            CommonClass._commenevent.CheckinAdminUser("Showdeletecompany",false);
            showcheckinuser("Showdeletecompany", false);
        
        }


        public void ShowPOS(string Heading, string Vtype)
        {
            Frmsalespos _pos = new Frmsalespos();
            MaxforSett(_pos);
            if (Heading == "KOT")
            {
                _pos.SalesAccount = "3";
            }
            _pos.Heading = Heading;
            _pos.Vtype = Vtype;
            FormShowNromal(_pos);
        }
        public void Applicationclose()
        {
             Application.Exit();
        }
        private void mnuexit_Click(object sender, EventArgs e)
        {
            Applicationclose();
        }
        public void ShowExpiryReport()
        {
            Frmexpiryreport _Form = new Frmexpiryreport();
            //Frmitems.Isinotherwindow = false;
            FormShowNromal(_Form);
        }

        public void ShowVoucherType()
        {
            FrmVoucherType _Form = new FrmVoucherType();
            FormShowNromal(_Form);
        }

        public void Showcommision()
        {
            Frmcommision _Form = new Frmcommision();
            FormShowNromal(_Form);
        }
        public void showcheckinuser(string Vtype, bool IncBatc)
        {
            FrmCheckinuser _checkuser = new FrmCheckinuser();
            _checkuser.Vtype = Vtype;
            _checkuser.IncludeBatch = IncBatc;
            FormShowNromal(_checkuser);
        
        }
        public void Showdiscount()
        {
            Frmdiscountslab _Form = new Frmdiscountslab();
            FormShowNromal(_Form);
        }

        public void Showarea()
        {
            Frmareacreate _Form = new Frmareacreate();
            FormShowNromal(_Form);
        }
        public void Showinvoicedesigndotmetrix(string Txt)
        {
            Frmprintmain _Form = new Frmprintmain();
            _Form.Richtext = Txt;
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }


        public void ViewCustomers()
        {
            Frmeditwindow _Form = new Frmeditwindow();
            _Form.Openwindow = "Ndcustomer";
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        public void Viewsuppliers()
        {
            Frmeditwindow _Form = new Frmeditwindow();
            _Form.Openwindow = "NdSuppliers";
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        public void ViewItems()
        {
            Frmeditwindow _Form = new Frmeditwindow();
            _Form.Openwindow = "Nditems";
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }
        public void Showproducttransfering()
        {
            Frmproducttransfering _producttransfering = new Frmproducttransfering();
            FormShowNromal(_producttransfering);
        }
        public void Showattendence()
        {
            Frmattendence _atten = new Frmattendence();
            MaxforSett(_atten);
            FormShowNromal(_atten);
        }

        public void ShowItems()
        {
            Frmitems _Form = new Frmitems();
            Frmitems.Isinotherwindow = false;
            FormShowNromal(_Form);
        }

        public void ShowItemsSimple()
        {
            Frmquickadditems _Form = new Frmquickadditems();
            _Form.Isinotherwindow = false;
            _Form.EditMode = false;
            FormShowNromal(_Form);
        }

        public void ShowManufacturer()
        {
            FrmManufacturer _Form = new FrmManufacturer();
            Frmitems.Isinotherwindow = false;
            FormShowNromal(_Form);
        }

        public void ShowItemsGroup()
        {
            Frmitemgroup _Form = new Frmitemgroup();
            FormShowNromal(_Form);
        }

        public void ShowTable()
        {
          //  FrmTableCreate _TableCreate = new FrmTableCreate();
          //  FormShowNromal(_TableCreate);
        }

        public void ShowCustomer()
        {
            frmcreateledger _Form = new frmcreateledger();
            _Form.WheregroupeQuerye = "  WHERE AUnder=18 or AGroupId=18";
            Generalfunction.Comeform = "MDICUSTOMER";
            FormShowNromal(_Form);
        }

        public void ShowAgent()
        {
            frmcreateledger _Form = new frmcreateledger();
            _Form.WheregroupeQuerye = "  WHERE AUnder=29 or AGroupId=29";
            Generalfunction.Comeform = "MDIAGENT";
            FormShowNromal(_Form);
        }
         
        public void ShowSupplier()
        {
            frmcreateledger _Form = new frmcreateledger();
            _Form.WheregroupeQuerye = " WHERE AUnder=19 or AGroupId=19";
            Generalfunction.Comeform = "MDISUPPLIER";
            FormShowNromal(_Form);
        }

        public void ShowEmployeeMaster()
        {
            Frmemployees _Form = new Frmemployees();
            FormShowNromal(_Form);
        }

        public void ShowLedgerCreate()
        {
            frmcreateledger _Form = new frmcreateledger();
            _Form.Size = new System.Drawing.Size(312, 498);
            Generalfunction.Comeform = "";
            FormShowNromal(_Form);
        }

        public void ShowAccountGroup()
        {
            frmaccountGroup _Form = new frmaccountGroup();
            FormShowNromal(_Form);
        }

        public void ShowChequeReceipt()
        {
            FrmCheque _Cheque = new FrmCheque();
            _Cheque.mode = 0;
            FrmCheque.Isinotherwindow = false;
            FormShowNromal(_Cheque);
        }

        public void ChangeCompany()
        {
            Temp = CommonClass._Paramlist.GetParamvalue("SDelete");
            if (Temp == "1")
            {
                Ds = CommonClass._ComCreate.LoadCompany();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        string TempLoadingCompany = Ds.Tables[0].Rows[i]["name"].ToString();
                        Generalfunction.TempCompanyname = TempLoadingCompany;
                         Temp = CommonClass._Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='SDelete'");
                        if (Temp == "0")
                        {
                            OpCompany = Generalfunction.TempCompanyname;
                        }
                    }
                    catch
                    {

                    }
                    Generalfunction.TempCompanyname="";
                    Generalfunction.OpCompany = OpCompany;
                }     
            }
            else
            {
                Ds = CommonClass._ComCreate.LoadCompany();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        string TempLoadingCompany = Ds.Tables[0].Rows[i]["name"].ToString();
                        Generalfunction.TempCompanyname = TempLoadingCompany;
                        Temp = CommonClass._Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='SDelete'");
                        if (Temp == "1")
                        {
                            OpCompany = Generalfunction.TempCompanyname;
                        }
                    }
                    catch
                    {

                    }
                    Generalfunction.TempCompanyname = "";
                    Generalfunction.OpCompany = OpCompany;
                }    
            }
            MainRefresh();
            ShowCompanyName();
        }

        public void ShowChequePayment()
        {
            FrmCheque _Cheque = new FrmCheque();
            _Cheque.mode = 1;
            FrmCheque.Isinotherwindow = false;
            FormShowNromal(_Cheque);
        }
        public void Showdailyexpence()
        {
            Frmdailyexpence _Cash = new Frmdailyexpence();
            Frmcash.Isinotherwindow = false;
            FormShowNromal(_Cash);
        }

        public void ShowReceipt()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 0;
            Frmcash.Isinotherwindow = false;
            FormShowNromal(_Cash);
        }

        public void ShowPayment()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 1;
            Frmcash.Isinotherwindow = false;
            FormShowNromal(_Cash);
        }

        public void ShowDebitnote()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 2;
            Frmcash.Isinotherwindow = false;
            FormShowNromal(_Cash);
        }

        public void ShowCreditNote()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 3;
            Frmcash.Isinotherwindow = false;
            FormShowNromal(_Cash);
        }

        public void ShowContraEntry()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 6;
            Frmcash.Isinotherwindow = false;
            FormShowNromal(_Cash);
        }

        public void ShowJournelReceipt()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 4;
            Frmcash.Isinotherwindow = false;
            FormShowNromal(_Cash);
        }

        public void ShowJournelPayment()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 5;
            Frmcash.Isinotherwindow = false;
            FormShowNromal(_Cash);
        }
        public void ShowopeningStock()
        {
            FrmopeningStock _Form = new FrmopeningStock();
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        public void ShowRepacking()
        {
            FrmRepacking _Repacking = new FrmRepacking();
            MaxforSett(_Repacking);
            FormShowNromal(_Repacking);
        }

        public void ShowStockReport()
        {
            FrmSelectStockList _Form = new FrmSelectStockList();
            FormShowNromal(_Form);
        }
        public void ShowSalesReport()
        {
            FrmSelectSalesReport _Form = new FrmSelectSalesReport();
            FormShowNromal(_Form);

            //FrmSelectSalesReport1 _Form = new FrmSelectSalesReport1();
            //FormShowNromal(_Form);
        }

        public void ShowPurchasereport()
        {
            Frmselectpurchasereportnew _Form = new Frmselectpurchasereportnew();
            FormShowNromal(_Form);
        }

        public void ShowAccountReport()
        {
            Frmselectaccountreport _Form = new Frmselectaccountreport();
            FormShowNromal(_Form);
        }

        public void ShowStockhistory()
        {
            Frmstockhistory _Form = new Frmstockhistory();
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }
        public void ShowDayBook()
        {
            Frmselectdaybook _Form = new Frmselectdaybook();
            FormShowNromal(_Form);
        }

        public void ShowTrailbalance()
        {
            FrmselectTrailbalance _Form = new FrmselectTrailbalance();
            FormShowNromal(_Form);
        }
        

        private void mnuitemgroupcreate_Click(object sender, EventArgs e)
        {
            ShowItemsGroup();
        }

        private void mnucustomercreate_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }

        private void mnusuppliercreate_Click(object sender, EventArgs e)
        {
            ShowSupplier();
        }

        private void mnuemployeecreate_Click(object sender, EventArgs e)
        {
            ShowEmployeeMaster();
        }

        private void mnuledgercreate_Click(object sender, EventArgs e)
        {
            ShowLedgerCreate();
        }

        private void mnuledgergroupcreate_Click(object sender, EventArgs e)
        {
            ShowAccountGroup();
        }

        private void mnumultirate_Click(object sender, EventArgs e)
        {
            FrmMultiRate _Form = new FrmMultiRate();
            FormShowNromal(_Form);
        }

        private void mnustockarea_Click(object sender, EventArgs e)
        {
            FrmAddDepot _Form = new FrmAddDepot();
            FormShowNromal(_Form);
        }

        private void mnusizes_Click(object sender, EventArgs e)
        {
            Frmcreatesizes _Form = new Frmcreatesizes();
            FormShowNromal(_Form);
        }

        private void mnucontacts_Click(object sender, EventArgs e)
        {
            Frmtempcantacts _Form = new Frmtempcantacts();
            FormShowNromal(_Form);
        }

        private void mnusales_Click(object sender, EventArgs e)
            {
            Generalfunction.Newformsales = false;
            ShowSales("Sales", "SI");
        }

        private void mnupurchase_Click(object sender, EventArgs e)
        {
            ShowPurchase("Purchase", "PI");
        }

        private void mnusalesreturn_Click(object sender, EventArgs e)
        {
            ShowSales("Sales Return", "SR");
        }

        private void mnupurchasereturn_Click(object sender, EventArgs e)
        {
            ShowPurchase("Purchase Return","PR");
        }

        private void mnureceipt_Click(object sender, EventArgs e)
        {
            ShowReceipt();
        }

        private void mnupayment_Click(object sender, EventArgs e)
        {
            ShowPayment();
        }

        private void mnudebitnote_Click(object sender, EventArgs e)
        {
            ShowDebitnote();
        }

        private void mnucreditnote_Click(object sender, EventArgs e)
        {
            ShowCreditNote();
        }

        private void mnujournalreceipt_Click(object sender, EventArgs e)
        {
            ShowJournelReceipt();
        }

        private void mnujournalpayment_Click(object sender, EventArgs e)
        {
            ShowJournelPayment();
        }

        private void mnuopeningstock_Click(object sender, EventArgs e)
        {
            ShowopeningStock();
        }

        private void mnustocktransfer_Click(object sender, EventArgs e)
        {
            FrmStockTRansfer _FORM = new FrmStockTRansfer();
            FormShowNromal(_FORM);
        }

        private void excessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmstockadjustment _Form = new Frmstockadjustment();
            Frmstockadjustment.Vtype = "Ireceipt";
            _Form.Heading = "Excess";
            FormShowNromal(_Form);
        }

        private void mnushortage_Click(object sender, EventArgs e)
        {
            Frmstockadjustment _Form = new Frmstockadjustment();
            Frmstockadjustment.Vtype = "Sh";
            _Form.Heading = "Shortage";
            FormShowNromal(_Form);
        }

        private void mnudeliverynote_Click(object sender, EventArgs e)
        {
            frmsalesinvoice _sales = new frmsalesinvoice();
            _sales.SalesAccount = "2";
            _sales.Heading = "Delivery Note";
            _sales.Vtype = "DN";
            MaxforSett(_sales);
            FormShowNromal(_sales);
        }

       

        private void settProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsetmainproduct _Form = new Frmsetmainproduct();
            FormShowNromal(_Form);
        }

        private void issueProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmissuetable _Form = new Frmissuetable();
            FormShowNromal(_Form);
        }

        private void receivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepacking _Form = new FrmRepacking();
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

     
        private void mnustockreport_Click(object sender, EventArgs e)
        {
            ShowStockReport();
        }

        private void mnusalesreport_Click(object sender, EventArgs e)
        {
            ShowSalesReport();
        }

        private void mnupurchasereport_Click(object sender, EventArgs e)
        {
            ShowPurchasereport();
        }

        private void mnuledgerreport_Click(object sender, EventArgs e)
        {
            ShowAccountReport();
        }

        private void stockTransferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmstocktransferdetails _form = new Frmstocktransferdetails();
            FormShowNromal(_form);

            //FrmStockTRansfer _FORM = new FrmStockTRansfer();
            //FormShowNromal( _FORM);
            //Frmstocktransferdetails _form = new Frmstocktransferdetails();
            //FormShowNromal(_form);

            //Frmselectstocktransfer _Form = new Frmselectstocktransfer();
            //FormShowNromal(_Form);
        }

        private void mnuquickreport_Click(object sender, EventArgs e)
        {
            
                FrmselectQuickReport _Form = new FrmselectQuickReport();
                FormShowNromal(_Form);
            
        }

        private void mnucashbook_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 1)
            {
                CommonClass._commenevent.WaitCursor(this);
                Showcashcadjet();
                CommonClass._commenevent.NormalCursor(this);
            }
        }

        private void mnucashgadjet_Click(object sender, EventArgs e)
        {
            if ( menuStrip.Visible==true)
            {
                CommonClass._commenevent.WaitCursor(this);
                Showcashcadjetinmain();
                CommonClass._commenevent.NormalCursor(this);
            }
        }

        private void mnuzatpandl_Click(object sender, EventArgs e)
        {
            if ( menuStrip.Visible==true)
            {
                Selectzatpandl _Form = new Selectzatpandl();
              
                FormShowNromal(_Form);
            }
        }

        private void mnumainreport_Click(object sender, EventArgs e)
        {
            Frmreportselect _Form = new Frmreportselect();
            FormShowNromal(_Form);
        }

        private void mnustockbook_Click(object sender, EventArgs e)
        {
            ShowStockhistory();
        }

        private void mnudaybook_Click(object sender, EventArgs e)
        {
            Frmselectdaybook _Daybook = new Frmselectdaybook();
            FormShowNromal(_Daybook);
        }

        private void mnutrailbalance_Click(object sender, EventArgs e)
        {
            ShowTrailbalance();
        }

        private void mnuimport_Click(object sender, EventArgs e)
        {
            Frmexcelimport _Form = new Frmexcelimport();
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void mnucommandwindow_Click(object sender, EventArgs e)
        {
            FrmCheckinuser.Blreturn = false;
            CommonClass._commenevent.CheckinAdminUser("ShowCommandwindow", false);
            showcheckinuser("ShowCommandwindow", false);
            //if (FrmCheckinuser.Blreturn == true)
            //{
            //    Frmcommandwindow _Form = new Frmcommandwindow();
            //    FormShowNromal(_Form);
            //}
        }

        private void mnucalculater_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void mnudbtransfer_Click(object sender, EventArgs e)
        {
            Frmproducttransfering _Form = new Frmproducttransfering();
            FormShowNromal(_Form);
        }

        private void mnupriceupdater_Click(object sender, EventArgs e)
        {
            Frmpriceupdater _Form = new Frmpriceupdater();
            FormShowNromal(_Form);
        }

        private void mnusoftwaretool_Click(object sender, EventArgs e)
        {
            FrmTools _Form = new FrmTools();
            FormShowNromal(_Form);       
        }

        private void mnubarcodetools_Click(object sender, EventArgs e)
        {
            FrmbarcodePrinting _Form = new FrmbarcodePrinting();
            FormShowNromal(_Form);
        }

        private void mnuusergroups_Click(object sender, EventArgs e)
        {

        }

        private void mnunewuser_Click(object sender, EventArgs e)
        {
            Frmusers _Form = new Frmusers();
            FormShowNromal(_Form);
        }

        private void mnuchangepassword_Click(object sender, EventArgs e)
        {
            FrmChengepassword _Form = new FrmChengepassword();
            FormShowNromal(_Form);
        }

        private void mnulogindetails_Click(object sender, EventArgs e)
        {

        }
        public void CloseOpenform()
        {
            if (this.MdiChildren.Count() > 0)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.Name != "Frmusercontroles")
                    {
                        frm.Dispose();

                    }
                }
            }
        }

        public void ShowLogout()
        {
            DialogResult Result = MessageBox.Show("Are You Sure to Logout?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result.ToString() == "Yes")
            {

              string  NewData = "User Logout";
              string OldData = "User Logout";

              CloseOpenform();
              CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "Logout", "", "Logout", OldData, NewData);
              MdiLoad();
            }

        }
        private void mnulogout_Click(object sender, EventArgs e)
        {
            ShowLogout();
        }

       

       

        private void MDIParent2_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void mnureport_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
              //  ShowReport();
            }
        }
        public void ShowReport()
        {
            FrmReport _report = new FrmReport();
            _report.ReportType = Clsselectreport.RType;
            _report.Query = Clsselectreport.RQuery;
            _report.QueryTemp = Clsselectreport.RQueryTemp;
            _report.QueryDetail = Clsselectreport.RQueryDetail;
            _report.DTFrom = Clsselectreport.RDtfrom;
            _report.DTTo = Clsselectreport.Rdtto;
            _report.ReportTypeSecond = Clsselectreport.RTypeSecond;
            MaxforSett(_report);
            FormShowNromal(_report);
        }
        private void mnusoftwaresettings_Click(object sender, EventArgs e)
        {
            Frmsettings _Form = new Frmsettings();
          //  MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void mnueditwindow_Click(object sender, EventArgs e)
        {
            Frmeditwindow _Form = new Frmeditwindow();
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void mnuusermoniter_Click(object sender, EventArgs e)
        {
            Frmusermonitore _Form = new Frmusermonitore();
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void picitems_Click(object sender, EventArgs e)
        {

        }

        private void cmdcadjetdescription_Click(object sender, EventArgs e)
        {

        }
        public void visiblefalse()
        {
            try
            {
                CommonClass.temp = _Dbtask.currentcompany();
                if (CommonClass.temp != "master" && CommonClass.temp != null)
                {
                    Ds = _Dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=21 and lname='WHOLESALE'");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                       mnusaleswholesale.Visible = true;
                    }
                    else
                    {
                        mnusaleswholesale.Visible = false;
                    }
                    mnusalesestimation.Visible = false;
                    //Ds = _Dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=21 and lname='Estimate'");
                    //if (Ds.Tables[0].Rows.Count > 0)
                    //{
                    //    mnusalesestimation.Visible = true;
                    //}
                    //else
                    //{
                    //    mnusalesestimation.Visible = false;
                    //}
                }
            }
            catch
            {
            }
        }
        public void ESettings() /*For Enable and Disable Menus*/
        {
            try
            {
                MenusettingsFu(Generalfunction.EWmachine, mnuexporttowieghtmechine);/*Wieght Mechine*/
                MenusettingsFu(Generalfunction.EMunit, mnumultiunit);/*Multi Unit*/
                MenusettingsFu(Generalfunction.EMRate, mnumultirate);/*Multi Rate*/
                MenusettingsFu(Generalfunction.EDepot, mnustockarea);/*Stock area*/

               // MenusettingsFu(Generalfunction.ETax, mnutax);/*Tax*/
                MenusettingsFu(Clssettings.EProduction, Productionmenu);/*Production*/
                MenusettingsFu(Generalfunction.ESalesestimation, mnusalesestimation);/*Sales Estimation*/
                MenusettingsFu(Generalfunction.EPurchasereturn, mnupurchasereturn);/*Purchase Return*/
                MenusettingsFu(Generalfunction.ESalesreturn, mnusalesreturn);/*Sales Return*/
                MenusettingsFu(Generalfunction.ECRM, crmmenu);/*CRM*/
                MenusettingsFu(Clssettings.Sbatch, mnubarcodetools);/*Batch*/

            }
            catch
            {
            }
        }
        public void MenusettingsFu(bool IsVisible,ToolStripMenuItem Mnu)
        {
            if (IsVisible == true)
                Mnu.Visible = true;
            else
                Mnu.Visible = false;
        }
        public void RefreshSettings()
        {
           // ShowCompanyNameandfinacialyear();
            visiblefalse();
            ESettings();
           //RefreshSettings();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRefresh();
        }
        public void MainRefresh()
        {
            QplexRefresh();
            RefreshSettings();
            visiblefalse();
            VtypeSales();
            VtypePurchase();
        }

        public void QplexRefresh()
        {
            if (Clssettings.ActiveCompany == true)
            {
                //ShowCompanyNameandfinacialyear();
                visiblefalse();
                ESettings();
                CommonClass._Nextg.RefreshDB();
                CommonClass._Nextg.RefreshDbAzureServer();
            }
        }

        public void VtypeSales()
        {
            mnusales.DropDownItems.Clear();
            Ds = _Dbtask.ExecuteQuery("select * from tblaccountledger where  lid !=2 and agroupid=21 and lid !=17 and lid !=24 and lname !='WHOLESALE' and lname !='ESTIMATE'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    ToolStripItem item2 = new ToolStripMenuItem();
                    // Name that will apear on the menu
                    item2.Text = Ds.Tables[0].Rows[i]["Lname"].ToString();
                    //Put in the Name property whatever neccessery to retrive your data on click event
                    item2.Name = Ds.Tables[0].Rows[i]["Lid"].ToString();
                    //On-Click event

                    item2.Click -= new EventHandler(item2_Click);
                    item2.Click += new EventHandler(item2_Click);

                    //Add the submenu to the parent menu
                    mnusales.DropDownItems.Add(item2);

                    this.mnusales.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
                }
            }

        }
        void item2_Click(object sender, EventArgs e)
        {
            ShowSales(sender.ToString(), "SI");
        }

        void item3_Click(object sender, EventArgs e)
        {
            ShowPurchase(sender.ToString(), "PI");
        }
        public void VtypePurchase()
        {
            mnupurchase.DropDownItems.Clear();
            Ds = _Dbtask.ExecuteQuery("SELECT * FROM TblAccountLedger  where  AgroupId=26 and Lid not in(3,18,25)");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    ToolStripItem item3 = new ToolStripMenuItem();
                    //Name that will apear on the menu
                    item3.Text = Ds.Tables[0].Rows[i]["Lname"].ToString();
                    //Put in the Name property whatever neccessery to retrive your data on click event
                    item3.Name = Ds.Tables[0].Rows[i]["Lid"].ToString();
                    //On-Click event
                    item3.Click -= new EventHandler(item3_Click);
                    item3.Click += new EventHandler(item3_Click);
                    //Add the submenu to the parent menu
                    mnupurchase.DropDownItems.Add(item3);
                }
            }

        }

        
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            pnlShortcut.Show();
        }

        private void cmdHide_Click(object sender, EventArgs e)
        {
            pnlShortcut.Visible = false;
        }

        private void crmmenu_Click(object sender, EventArgs e)
        {
            frmAddenquiry _Form = new frmAddenquiry();
            FormShowNromal(_Form);
        }

        //private void mnujobcard_Click(object sender, EventArgs e)
        //{
        //    frmJobCard _Form = new frmJobCard();
        //    MaxforSett(_Form);
        //    FormShowNromal(_Form);
        //}

        //private void customerProfileToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmCustomerProfile _Form = new frmCustomerProfile();
        //   // MaxforSett(_Form);
        //    FormShowNromal(_Form);
        //}

        private void Searchmenu_Click(object sender, EventArgs e)
        {
            frmzatsearch _ZatSearch = new frmzatsearch();
            MaxforSett(_ZatSearch);
            FormShowNromal(_ZatSearch);
        }

        private void mnusalesorder_Click(object sender, EventArgs e)
        {
            ShowSales("Sales Order", "SO");
        }

        private void mnupurchaseorder_Click(object sender, EventArgs e)
        {
            ShowPurchase("Purchase Order", "PO");
        }

        private void mnusaleswholesale_Click(object sender, EventArgs e)
        {
            ShowSales("Wholesale", "SI");
        }

        private void mnusalesestimation_Click(object sender, EventArgs e)
        {
            ShowSales("Estimate", "SI");
        }

        private void MDIParent2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                if (Gridsearch.Visible == true)
                {
                    Gridsearch.Visible = false;
                }
                else
                {

                    if (this.MdiChildren.Count() == 1)
                    {
                        Applicationclose();
                    }
                }
            }
            else
            {
               
            }
        }

        private void MDIParent2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Generalfunction.BlnLogin == true)
            {
                DialogResult Result = MessageBox.Show("Are You Sure to Exit Application?", "Nesma POS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result.ToString() == "No")
                {
                    e.Cancel = true;
                }

            }
        }

        private void MDIParent2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //private void mnuop_Click(object sender, EventArgs e)
        //{
        //    Frmop _Op = new Frmop();
        //    FormShowNromal(_Op);
        //}

        //private void mnudoctorsheet_Click(object sender, EventArgs e)
        //{
        //    Frmdoctorsheet _DoctorSheet = new Frmdoctorsheet();
        //    FormShowNromal(_DoctorSheet);
        //}

        private void printBarcodeSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmlabelprinting _Labelprinting = new Frmlabelprinting();
            FormShowNromal(_Labelprinting);
        }

        private void backupAndRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackupandrestore _BackupandRestore = new FrmBackupandrestore();
            FormShowNromal(_BackupandRestore);
        }

        private void mnuyearend_Click(object sender, EventArgs e)
        {
            FrmCheckinuser.Blreturn = false;
            CommonClass._commenevent.CheckinAdminUser("yearend", false);
            showcheckinuser("yearend", false);

            
        }

        private void mnurepacking_Click(object sender, EventArgs e)
        {
            ShowRepacking();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        public void ShowMenus(string txt)
        {
            string Menuid;
            string MenuName;
            Ds = _Dbtask.ExecuteQuery("select * from tblmenus where menuname like '%" + txt + "%'");
            Gridsearch.Rows.Clear();
            Gridsearch.Visible = true;
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
              Count=  Gridsearch.Rows.Add(1);
                Menuid = Ds.Tables[0].Rows[i]["id"].ToString();
                MenuName = Ds.Tables[0].Rows[i]["menuname"].ToString();
                Gridsearch.Rows[Count].Cells[0].Value = MenuName;
                Gridsearch.Rows[Count].Cells[0].Tag = Menuid;
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            ShowMenus(toolStripTextBox1.Text);
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Gridsearch.SelectedRows.Count > 0)
                {
                    selectedRow = Gridsearch.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridsearch.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridsearch.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridsearch.Rows[selectedRow + 1].Selected = true;
                            Gridsearch.Rows[selectedRow].Selected = false;
                            Gridsearch.CurrentCell = Gridsearch.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridsearch.Rows[selectedRow - 1].Selected = true;
                        Gridsearch.Rows[selectedRow].Selected = false;
                        Gridsearch.CurrentCell = Gridsearch.SelectedRows[0].Cells[0];
                    }

                    if (e.KeyValue == 13)
                    {
                        string Id;
                        if (Gridsearch.SelectedRows.Count > 0)
                        {
                            int SRow;
                            SRow=Gridsearch.SelectedRows[0].Index;
                            if (Gridsearch.Rows[SRow].Cells[0].Value != null)
                            {
                                SRow =Convert.ToInt16(Gridsearch.Rows[SRow].Cells[0].Tag);
                                switch (SRow)
                                {
                                    case 1:
                                        ShowItems();
                                        break;

                                    case 2:
                                        ShowItemsGroup();
                                        break;

                                    case 3:
                                        ShowCustomer();
                                        break;

                                    case 4:
                                        ShowSupplier();
                                        break;

                                    case 5:
                                        ShowEmployeeMaster();
                                        break;

                                    case 6:
                                        ShowLedgerCreate();
                                        break;

                                    case 7:
                                        ShowAccountGroup();
                                        break;

                                    case 8:
                                        ShowSales("Sales", "SI");
                                        break;

                                    case 9:
                                        ShowPurchase("Purchase", "PI");
                                        break;

                                    case 10:
                                        ShowReceipt();
                                        break;

                                    case 11:
                                        ShowPayment();
                                        break;

                                    case 12:
                                       ShowDebitnote();
                                        break;

                                    case 13:
                                        ShowCreditNote();
                                        break;

                                    case 14:
                                       ShowJournelReceipt();
                                        break;

                                    case 15:
                                        ShowJournelPayment();
                                        break;

                                    case 16:
                                       ShowopeningStock();
                                        break;

                                    case 17:
                                       ShowRepacking();
                                        break;

                                    //case 18:
                                    //    showcr;
                                    //    break;

                                    case 19:
                                        ShowStockReport();
                                        break;

                                    case 20:
                                       ShowReport();
                                        break;

                                    case 21:
                                       ShowPurchasereport();
                                        break;

                                    case 22:
                                       ShowAccountReport();
                                        break;

                                    case 23:
                                       // ShowPurchase("Purchase", "PI");
                                        break;

                                    case 24:
                                        ShowDayBook();
                                        break;

                                    case 25:
                                        ShowTrailbalance();
                                        break;
                                }
                                Gridsearch.Visible = false;
                            }
                        }
                    }
                    if (e.KeyValue == 27)
                    {
                        ////Gridmain.Visible = false;
                        ////if (Txtitemcategory.Text.Length > 0)
                        ////{
                        ////    Notexit = false;
                        ////}
                        ////else
                        ////{
                        ////    Notexit = true;
                        ////}
                    }
                }
            }
            catch
            {
            }
        }

       

        private void mnuagent_Click(object sender, EventArgs e)
        {
            ShowAgent();
        }

        private void mnupos_Click(object sender, EventArgs e)
        {
            ShowPOS("POS", "POS");
        }

        private void companyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCompanyProfile();
        }

        private void mnutransferwindow_Click(object sender, EventArgs e)
        {
            Showtransferwindow();
        }

        private void reorderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowreorderReport();
        }

        private void mnulabelprinting_Click(object sender, EventArgs e)
        {
            ShowLabelprinting();
        }

        private void mnustockadjustment_Click(object sender, EventArgs e)
        {
            ShowPhysicalStock();
        }

        private void mnusms_Click(object sender, EventArgs e)
        {
            ShowSMS();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBalancesheet();
        }

        private void profitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowselectprofitandLossAccount();
        }
       
        private void ratioAnalyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clsselectreport.RType = "RatioAnalysis";
            Clsselectreport.RDtfrom =Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
                //Convert.ToDateTime("01-01-2015 12:00:00 AM");
            Clsselectreport.Rdtto = DateTime.Now;
            mnureport.PerformClick();
        }

        private void MDIParent2_MdiChildActivate(object sender, EventArgs e)
        {
           // if(this.c
        }

        private void expiryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExpiryReport();
        }

        private void mnutable_Click(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void mnuitemcreate_Click(object sender, EventArgs e)
        {
            ShowItemsSimple();
            //ShowItems();
        }

        private void mnukot_Click(object sender, EventArgs e)
        {
            ShowPOS("POS", "POS");
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frmimage _Form = new Frmimage();
            //FormShowNromal(_Form);
        }

        private void registraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registered = true;
            Frmregistration _Registration = new Frmregistration();
            _Registration.ShowDialog();
        }

        private void mnujobcard_Click(object sender, EventArgs e)
        {
            frmJobCard _Form = new frmJobCard();
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void mnumultiunit_Click(object sender, EventArgs e)
        {
            Frmunitcreation _UnitCreation = new Frmunitcreation();
            FormShowNromal(_UnitCreation);
        }

        private void mnusalesquatation_Click(object sender, EventArgs e)
        {
            ShowSales("Sales Quatation", "SQ");
        }

        private void mnucontraentry_Click(object sender, EventArgs e)
        {
            ShowContraEntry();
        }

        private void mnutraidingAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTraidingAccount();
        }

        private void mnuchequereceipt_Click(object sender, EventArgs e)
        {
            ShowChequeReceipt();
        }

        private void mnuchequepayment_Click(object sender, EventArgs e)
        {
            ShowChequePayment();
        }

        private void mnuwarantybill_Click(object sender, EventArgs e)
        {
            ShowSales("Waranty Bill", "WR");
        }

        private void mnupricecodesett_Click(object sender, EventArgs e)
        {
            Frmsettpricecode _Form = new Frmsettpricecode();
            FormShowNromal(_Form);
        }

 

        private void mnuitemsearchquick_Click(object sender, EventArgs e)
        {
            Frmsearchitems _Form = new Frmsearchitems();
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void mnuitemsearch_Click(object sender, EventArgs e)
        {

        }

        private void mnupartyproject_Click(object sender, EventArgs e)
        {
            Frmcustomerprojects _Form = new Frmcustomerprojects();
            FormShowNromal(_Form);
        }

        private void mnutoolremainder_Click(object sender, EventArgs e)
        {
            Frmremainder _Form = new Frmremainder();
            FormShowNromal(_Form);
        }

        private void mnucreatevouchertype_Click(object sender, EventArgs e)
        {
            ShowVoucherType();
        }

        private void Tlitemcreate_ButtonClick(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void Toolitemcreate_Click(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void toolshortcuts_ButtonClick(object sender, EventArgs e)
        {

        }

        private void mnushowitems_Click(object sender, EventArgs e)
        {
            ViewItems();
        }

        private void showCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomers();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewsuppliers();
        }

        private void mnutoolsattendence_Click(object sender, EventArgs e)
        {
            Showattendence();
        }

        private void Mnutoolproducttransfering_Click(object sender, EventArgs e)
        {
            Showproducttransfering();
        }

        private void mnuservices_Click(object sender, EventArgs e)
        {
            ShowSales("Services", "SV");
        }

        private void mnudressmaking_Click(object sender, EventArgs e)
        {
            Frmdressmakers _dress = new Frmdressmakers();
            MaxforSett(_dress);
            FormShowNromal(_dress);
        }

        private void electricMechineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmechinetool _Mechine = new Frmmechinetool();
            FormShowNromal(_Mechine);
        }

        private void mnutdailyexpence_Click(object sender, EventArgs e)
        {
            Showdailyexpence();
        }

        private void mnuccommisionslab_Click(object sender, EventArgs e)
        {
            Showcommision();
        }

        private void mnuareacreate_Click(object sender, EventArgs e)
        {
            Showarea();
        }

        private void mnucdiscountslab_Click(object sender, EventArgs e)
        {
            Showdiscount();
        }

        private void mnuinvoicedesigndotmetrix_Click(object sender, EventArgs e)
        {
            Showinvoicedesigndotmetrix(CommonClass.temp);
        }

        private void simpleItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowItemsSimple();
        }

        private void MnuUpdateArabic_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            CommonClass._Language.DeleteLanguage();
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        public void SUMMERYREPORT()
        {
            Frmreport2 _Form = new Frmreport2();
            _Form.Reporttype = "Summury Report";
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }
        private void itemListReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            SUMMERYREPORT();
        }
        

        private void categorywiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmreport2 _Form = new Frmreport2();
            _Form.Reporttype = "Salesdaybookcount Category Wise";
            MaxforSett(_Form);
            FormShowNromal(_Form);

        }

        private void iteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmreport2 _Form = new Frmreport2();
            _Form.Reporttype = "Salesdaybookcount Category";
            MaxforSett(_Form);
            FormShowNromal(_Form);

        }

        private void iconsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmiconset _ico = new Frmiconset();
            FormShowNromal(_ico);


        }

        private void chequeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelectChequeReport _Form = new FrmSelectChequeReport();
            FormShowNromal(_Form);
        }

        private void billWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSelectBillWiseSettlementReport _Form = new FrmSelectBillWiseSettlementReport();
            //FormShowNromal(_Form);

            Frmbillwisesettlereport _billwise = new Frmbillwisesettlereport();
            billsetSI = true;
            Frmbillwisesettlereport.conditn = "SI";
            FormShowNromal(_billwise);
        }

        private void cOMMNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcmnd _Form = new Frmcmnd();
            FormShowNromal(_Form);
        }

        private void salepopupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoldpopup _form = new FrmHoldpopup();
            FormShowNromal(_form);
        }

        private void baseUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaseunit _frm = new FrmBaseunit();
            FormShowNromal(_frm);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColor _color = new FrmColor();


            FormShowNromal(_color);
        }

        private void Createmenu_Click(object sender, EventArgs e)
        {

        }

        private void taillorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDesigning _form = new FrmDesigning();

            // MaxforSett(_form);
            FormShowNromal(_form);
        }

        private void tailortoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frmtaillorreport _form = new Frmtaillorreport();
            FormShowNromal(_form);
        }

        private void mnusalesnew_Click(object sender, EventArgs e)
        {
            Generalfunction.Newformsales = true;
            ShowSales("Sales", "SI");
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManufacturer _form = new FrmManufacturer();
            FormShowNromal(_form);
        }

        private void Lblproductdetails_Click(object sender, EventArgs e)
        {
            FrmProductdetails _proddetails = new FrmProductdetails();
            _proddetails.ShowDialog();
        }

        private void tAXSummeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmreport2 _Form = new Frmreport2();
            _Form.Reporttype = "TaxSummery";
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void followUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFollowup _Form = new FrmFollowup();
            FormShowNromal(_Form);
        }

        private void feedBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFeedback _form = new FrmFeedback();
            FormShowNromal(_form);
        }

        private void feedbackFollowUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport _Form = new FrmReport();
            _Form.ReportType= "feedbackandFollow";
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void checkinuserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oPENINGSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmopeningStock _FRM = new FrmopeningStock();
            FormShowNromal(_FRM);
        }

        private void serviceUpdationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registered = true;
            Frmserviceupdated _service = new Frmserviceupdated();
            _service.ShowDialog();

            
        }

        private void taxSummeryTwoMenuItem_Click(object sender, EventArgs e)
        {
            Frmreport2 _Form = new Frmreport2();
            _Form.Reporttype = "TaxSummeryTWO";
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void purchaseSettlementReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmbillwisesettlereport _billwise = new Frmbillwisesettlereport();
            billsetSI = false;
            Frmbillwisesettlereport.conditn = "PI";

            FormShowNromal(_billwise);
        }

        private void saleReturnBillwisesettleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmbillwisesettlereport _billwise = new Frmbillwisesettlereport();
            billsetSI = true;
            Frmbillwisesettlereport.conditn = "SR";
            FormShowNromal(_billwise);
        }

        private void purchaseReturnBillwisesetttleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmbillwisesettlereport _billwise = new Frmbillwisesettlereport();
            billsetSI = false;
            Frmbillwisesettlereport.conditn = "PR";

            FormShowNromal(_billwise);
        }
        public void showproductionreport()
        {
            FrmReport _Form = new FrmReport();
            _Form.ReportType = "Productionanddetails";
            _Form.DTFrom = System.DateTime.Today;
            _Form.DTTo = System.DateTime.Today;
            MaxforSett(_Form);
            FormShowNromal(_Form);
        }

        private void productionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frmprodutionreport _form = new Frmprodutionreport();
            FormShowNromal(_form);

            //showproductionreport();
        }

        private void modelformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmodelformset _form = new Frmmodelformset();
            FormShowNromal(_form);
        }

        private void pOSSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmpointofsale _POS = new Frmpointofsale();

           // FormShowNromal(_POS);
            
            MaxforSett(_POS);

        FormShowNromal(_POS);

        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmrack _rack = new Frmrack();
            _rack.ShowDialog();
        }

        private void Mnusecondphaseprofile_Click(object sender, EventArgs e)
        {
            ShowSecondphaseCompanyprofile();
        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //D:\Development c#\SimpleInvoice
            //Process ExternalProcess = new Process();
            //Process.StartInfo.FileName = @"D:\Development c#\SimpleInvoice.exe";
            //Process.StartInfo.Arguments = "olaa"; //argument
            //Process.StartInfo.UseShellExecute = false;
            //Process.StartInfo.RedirectStandardOutput = true;
            //Process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //Process.StartInfo.CreateNoWindow = true; //not diplay a windows
            //Process.Start();
            System.Diagnostics.Process.Start(@"D:\Development c#\SimpleInvoice\bin\Debug\SimpleInvoice.exe");
          //  Process.Start();
        }
    }
}
