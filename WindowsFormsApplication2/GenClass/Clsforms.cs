using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsforms
    {
       // FrmReport  CommonClass._Clreport = new FrmReport();
     //   MDIParent2 _Mdi2 = new MDIParent2();
        public void ShowContacts()
        {
            Frmtempcantacts _Contacts = new Frmtempcantacts();
            // _Sales.MdiParent = this;
            // _Sales.Heading = "Sales Report";
            _Contacts.ShowDialog();
        }
        public void ShowExpiryReport()
        {
            Frmexpiryreport _Expiry = new Frmexpiryreport();
            _Expiry.ShowDialog();
        }
        public void ShowSelectTrailBalance()
        {
            FrmselectTrailbalance _SelectTRailBalance = new FrmselectTrailbalance();
            // _Sales.MdiParent = this;
            // _Sales.Heading = "Sales Report";
            _SelectTRailBalance.ShowDialog();
        }
        
        public void ShowSalesreport()
        {
            //FrmSelectSalesReport1 _Sales = new FrmSelectSalesReport1();
            //// _Sales.MdiParent = this;
            //// _Sales.Heading = "Sales Report";
            //_Sales.ShowDialog();
        }
        public void Showpurchasereport()
        {
            //Frmselectpurchasereport _purchase = new Frmselectpurchasereport();
            ////  _purchase.Heading = "Purchase Report";
            //// _purchase.MdiParent = this;
            //_purchase.ShowDialog();
        }
        public void ShowStockarea()
        {
            FrmAddDepot _Stockarea = new FrmAddDepot();
            _Stockarea.ShowDialog();
        }
        public void ShowCalculater()
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        public void ShowpurchaseReport()
        {
            //Frmselectpurchasereport _purchase = new Frmselectpurchasereport();
            //_purchase.ShowDialog();
        }

        public void ShowSalesReport()
        {
            //FrmSelectSalesReport1 _Sales = new FrmSelectSalesReport1();
            //_Sales.ShowDialog();
        }

        public void ShowSelectStocklist()
        {
            FrmSelectStockList _Stock = new FrmSelectStockList();
            //_Stock.MdiParent = this;
            _Stock.ShowDialog();
        }
        public void ShowMultiRate()
        {
            FrmMultiRate _MultiRate = new FrmMultiRate();
            _MultiRate.ShowDialog();
        }

        public void ShowNewcompany()
        {
            FrmCompanyName _CompanyName = new FrmCompanyName();
            //  _CompanyName.MdiParent = this;
            _CompanyName.ShowDialog();
        }

        public void ShowDeleteCompany()
        {
            frmdeletecomp _deletecompany = new frmdeletecomp();
            // _deletecompany.MdiParent = this;
            _deletecompany.ShowDialog();
        }

        public void ShowItemGroupcreate()
        {
            Frmitemgroup _itemgroup = new Frmitemgroup();
            // _itemgroup.MdiParent = this;
            _itemgroup.Show();
        }
        public void ShowAccountgroupcreate()
        {
            frmaccountGroup _Accountgroup = new frmaccountGroup();
            
            // _Accountgroup.MdiParent = this;
            _Accountgroup.Show();
        }
        public void ShowLedgercreate()
        {
            frmcreateledger _createledger = new frmcreateledger();
            _createledger.Size = new System.Drawing.Size(312, 472);
            Generalfunction.Comeform = "";
            // _createledger.MdiParent = this;
            _createledger.Show();
        }

        public void ShowSoftwaresettings()
        {
            CommonClass._commenevent.CheckinAdminUser("showsettings",false);
        }

        public void Showopeningstock()
        {
            FrmopeningStock _openingStock = new FrmopeningStock();
            //  _openingStock.MdiParent = this;
            _openingStock.ShowDialog();
        }

        public void Showstockadjustment(string vtype, string Heading)
        {
            Frmstockadjustment _stockadjustment = new Frmstockadjustment();
            Frmstockadjustment.Vtype = vtype;
            _stockadjustment.Heading = Heading;
            //_stockadjustment.MdiParent = this;
            _stockadjustment.ShowDialog();
        }

        public void ShowCustomercreate()
        {
            frmcreateledger _CreateLedger = new frmcreateledger();
            _CreateLedger.WheregroupeQuerye = "  WHERE AUnder=18 or AGroupId=18";
            Generalfunction.Comeform = "MDICUSTOMER";
            //_CreateLedger.MdiParent = this;
            _CreateLedger.ShowDialog();
        }
       
        public void Shomultiratecreate()
        {
            FrmMultiRate _Multirate = new FrmMultiRate();
            // _Multirate.MdiParent = this;
            _Multirate.Show();
        }

        public void ShowSuppliercreate()
        {
            frmcreateledger _CreteLedger = new frmcreateledger();
            _CreteLedger.WheregroupeQuerye = " WHERE AUnder=19 or AGroupId=19";
            Generalfunction.Comeform = "MDISUPPLIER";
            // _CreteLedger.MdiParent = this;
            _CreteLedger.ShowDialog();
        }

        public void Showunitscreate()
        {
            FrmUnits _Units = new FrmUnits();
            // _Units.MdiParent = this;
            _Units.ShowDialog();
        }

        public void Showagentcreate()
        {
            frmcreateledger _Agent = new frmcreateledger();
            _Agent.WheregroupeQuerye = "  WHERE AUnder=29 or AGroupId=29";
            Generalfunction.Comeform = "MDIAGENT";
            //_Agent.MdiParent = this;
            _Agent.ShowDialog();
        }

        public void Showdeliverynote()
        {
            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.SalesAccount = "2";
            _Sales.Heading = "Delivery Note";
            _Sales.Vtype = "DN";
            _Sales.ShowDialog(); 
        }
        public void ShowYearEnding()
        {
            Frmyearending _Yearending = new Frmyearending();
            _Yearending.ShowDialog();
        }
        public void ShowtransactionTransfer()
        {
            frmTransferwindow _TransferWindow = new frmTransferwindow();
            _TransferWindow.ShowDialog();
        }

        public void ShowOutPatient()
        {
            //Frmop _Op = new Frmop();
            //_Op.ShowDialog();
        }
        public void Showphysicalstock()
        {
            Frmphysical _Physical = new Frmphysical();
            _Physical.ShowDialog();
        }
        public void Showitemclass()
        {
            FrmCreateItemclass _itemclass = new FrmCreateItemclass();
            _itemclass.ShowDialog();
        }
        public void Showreapacking()
        {
            FrmRepacking _Repacking = new FrmRepacking();
            _Repacking.ShowDialog();
        }
        public void Showproducttransfering()
        {
            Frmproducttransfering _Producttransfering = new Frmproducttransfering();
            _Producttransfering.ShowDialog();
        }

        public void ShowImport()
        {
            Frmexcelimport _Import = new Frmexcelimport();
            _Import.ShowDialog();
        }

        public void ShowLoginDetails()
        {
            Frmusermonitore _UserMoniter = new Frmusermonitore();
            _UserMoniter.ShowDialog();
        }
        public void ShowuserActivity()
        {
            Frmusermonitore _UserMoniter = new Frmusermonitore();
            _UserMoniter.ShowDialog();
        }

        public void Showchangepassword()
        {
            FrmChengepassword _Changepassword = new FrmChengepassword();
            _Changepassword.ShowDialog();
        }

        //public void ShowDeliverynotereturn()
        //{
        //    Frmdeliverynote _Delivernote = new Frmdeliverynote();
        //    _Delivernote.Vtype = "DNR";
        //    _Delivernote.Heading = "Delivery Note Return";
        //    // _Delivernote.MdiParent = this;
        //    _Delivernote.ShowDialog();
        //}

        public void ShowStocktransfer()
        {
            FrmStockTRansfer _Stocktransfer = new FrmStockTRansfer();
            _Stocktransfer.ShowDialog();
        }

        //public void Showshotcuts()
        //{
        //    Frmshortcuts _Shortcuts = new Frmshortcuts();
        //   // _Shortcuts.MdiParent = _Mdi2;
        //    _Shortcuts.Show();
        //}
        public void ShowEditwindow()
        {
            Frmeditwindow _Editwindow = new Frmeditwindow();
            _Editwindow.ShowDialog();
        }

        public void ShowItemcreate()
        {
            try
            {
               // Frmitems _items = new Frmitems();
                Frmquickadditems _items = new Frmquickadditems();
                _items.ShowDialog();

                //Form childForm = new Form();
                //childForm.MdiParent = this;
                //childForm.Text = "Window " + childFormNumber++;
                //childForm.Show();
            }
            catch (Exception exe)
            {
                //MessageBox.Show(exe.ToString());
            }
        }

        public void ShowStockhistory()
        {
            Frmstockhistory _StockHistory = new Frmstockhistory();
            _StockHistory.ShowDialog();
        }
        public void Showdemosale()
        {

            Frmmodelformset _form = new Frmmodelformset();
            _form.ShowDialog();
        }

        public void ShowbarcodeTools()
        {
            FrmbarcodePrinting _BarcodeTool = new FrmbarcodePrinting();
            _BarcodeTool.ShowDialog();
        }

        public void ShowSoftwareTools()
        {
            FrmTools _SoftTools = new FrmTools();
            _SoftTools.ShowDialog();
        }

        public void ShowCustomerCard()
        {
            frmcustomercard _CustomerCard = new frmcustomercard();
            _CustomerCard.ShowDialog();
        }

        public void ShowCreateUser()
        {
            Frmusers _User = new Frmusers();
            _User.ShowDialog();
        }
        public void ShowPriceupdater()
        {
            Frmpriceupdater _PriceUpdater = new Frmpriceupdater();
            _PriceUpdater.ShowDialog();
        }
        public void Showemployeecreate()
        {
            Frmemployees _employee = new Frmemployees();
            _employee.ShowDialog();
        }

        public void showCashpayment()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 1;
            Frmcash.Isinotherwindow = false;
            _Cash.ShowDialog();
        }
        public void showCashreceipt()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 0;
            Frmcash.Isinotherwindow = false;
            _Cash.ShowDialog();
        }

        public void ShowZATSearch()
        {
            frmzatsearch _ZatSearch = new frmzatsearch();
            _ZatSearch.ShowDialog();
        }

        public void showDebitNote()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 2;
            Frmcash.Isinotherwindow = false;
            _Cash.ShowDialog();
        }
        public void showCreditNote()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 3;
            Frmcash.Isinotherwindow = false;
            _Cash.ShowDialog();
        }
        public void showJournelReceipt()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 4;
            Frmcash.Isinotherwindow = false;
            _Cash.ShowDialog();
        }
        public void showJournelPayment()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 5;
            Frmcash.Isinotherwindow = false;
            _Cash.ShowDialog();
        }
        public void ShowpurchaseReturn()
        {
            Frmpurchase _purchase = new Frmpurchase();
            _purchase.Vtype = "PR";
            _purchase.PurchaseAccount = "3";
            _purchase.Heading = " Purchase Return";

            _purchase.ShowDialog();

        }
        public void ShowpurchaseOrder()
        {
            Frmpurchase _purchase = new Frmpurchase();
            _purchase.Vtype = "PO";
            _purchase.PurchaseAccount = "3";
            _purchase.Heading = " Purchase Order";

            _purchase.ShowDialog();

        }
        public void Showpurchase()
        {


            //  panelshowshortcuts.Visible = false;
            Frmpurchase _purchase = new Frmpurchase();
            _purchase.Vtype = "PI";
            _purchase.PurchaseAccount = "3";
            _purchase.Heading = " Purchase Invoice";

            //_purchase.MdiParent = this;
            //_Sales.PnlHeadingColor = System.Drawing.Color.Purple;
            _purchase.ShowDialog();

        }

        public void Showreportselect()
        {
         //  Frmreportselect  _Clreportselect = new Frmreportselect();
          //   CommonClass._Clreportselect.ShowDialog();
        }

        public void Showcommandwindow()
        {
            Frmcommandwindow _Command = new Frmcommandwindow();
            // _Command.MdiParent = this;
            _Command.ShowDialog();
        }

        public void ShowLedgerreport()
        {
            Frmselectaccountreport _Ledger = new Frmselectaccountreport();
            // _Ledger.MdiParent = this;
            _Ledger.ShowDialog();
        }
        public void ShowAnalysisReport()
        {
            Frmselectanalysisreport _Analysis = new Frmselectanalysisreport();
            _Analysis.ShowDialog();
        }
       
        public void ShowAddEnquiry()
        {
            frmAddenquiry _Enquiry = new frmAddenquiry();
            _Enquiry.ShowDialog();
        }
        public void ShowBalancesheet(DateTime Dtfrom, DateTime Dtto)
        {
            CommonClass._report.ReportType = "Balancesheet";
          //  ShowReportMain(Dtfrom, Dtto);
        }
        
        public void ShowTrailBalance(DateTime Dtfrom,DateTime Dtto)
        {
            CommonClass._report.ReportType = "TrailBalance";
            //ShowReportMain( Dtfrom, Dtto);
        }

        public void ShowQuickreport()
        {
            FrmselectQuickReport _Quickreport = new FrmselectQuickReport();
            _Quickreport.Show();
        }
        public void Showcashdesk(double Amount,double Disc,int Pmodeofpayment,string Lid)
            {
            FrmCashDesk _Cashdesk = new FrmCashDesk();
           _Cashdesk.TAmount = Amount;
            FrmCashDesk.TCashdiscount = Disc;
            FrmCashDesk.Modepayment = Pmodeofpayment;
            FrmCashDesk.Lid = Lid;
            _Cashdesk.ShowDialog();
        }
        public void ShowSimpleitem(string Txt)
        {
            Frmquickadditems _form = new Frmquickadditems();
            _form.Txt = Txt;
            _form.Isinotherwindow = true;
            _form.ShowDialog();
        }
        public void ShowSmssending()
        {
            Frmmessege _mess = new Frmmessege();
            _mess.ShowDialog();
        }

        public void Showsettproduct()
        {
            Frmsetmainproduct _MainProduct = new Frmsetmainproduct();
            _MainProduct.ShowDialog();
        }
        public void ShowIssueproduct()
        {
            Frmissuetable _IssueProduct = new Frmissuetable();
            _IssueProduct.ShowDialog();
        }
        public void ShowReceivedProduct()
        {
            Frmreceivedproduct _Receivedproduct = new Frmreceivedproduct();
            _Receivedproduct.ShowDialog();
        }

        public void ClickintoDownload()
        {
            Frmwebbrowser _webbrowser = new Frmwebbrowser();
            _webbrowser.ShowDialog();
        }

        public void Showsizes()
        {
            Frmcreatesizes _Sizes = new Frmcreatesizes();
            _Sizes.ShowDialog();
        }

        public void ShowselectzatPandLselect()
        {
            Selectzatpandl _Zatpandl = new Selectzatpandl();
            _Zatpandl.ShowDialog();
        }
       
    }

    class EditingShow
    {
      //public  void EditShowSales(string VCode,string Vno,string MainAccount,string Vtype)
      //  {
      //      frmsalesinvoice _Sales = new frmsalesinvoice();
      //      _Sales.Vtype = Vtype;
      //      FrmReport.ClickCode = VCode;
      //      _Sales.txtvno.Text = Vno;
      //      FrmReport.MainAccount = MainAccount;
      //      _Sales.Isinotherwindow = true;
      //      _Sales.Show();



      //  }

      public void EditShowPurchase(string VCode, string Vno, string MainAccount,string Vtype)
      {
          //Frmpurchase _Purchase = new Frmpurchase();
          ////  Frmpurchase.Vtype = "PI";
          //_Purchase.txtvno.Text = Vno;
          //_Purchase.PurchaseAccount = MainAccount;
          //_Purchase.Heading = CommonClass._Ledger.GetspecifField("lname",MainAccount) + " Invoice";
          //_Purchase.Isinotherwindow = true;
          //Frmpurchase.Vtype = Vtype;
          //_Purchase.Show();

          Frmpurchase _Purchase = new Frmpurchase();
          _Purchase.Vtype = Vtype;
          FrmReport.ClickCode = VCode;
          FrmReport.MainAccount = MainAccount;

          _Purchase.Isinotherwindow = true;
          _Purchase.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";
          _Purchase.WindowState = System.Windows.Forms.FormWindowState.Normal;
          //_Purchase.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
          _Purchase.ShowDialog();
      }
    }
}
