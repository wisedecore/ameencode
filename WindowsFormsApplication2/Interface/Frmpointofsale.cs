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
    public partial class Frmpointofsale : Form
    {
        public Frmpointofsale()
        {
            InitializeComponent();
        }
        private TextBox focusedTextbox = null;
        public string vnoname = "";
        public int Count = 0;
        public int BatchFoundIndex;
        public bool erase = false;
        DBTask _dbtask = new DBTask();
        NextGFuntion _Nextg = new NextGFuntion();
        int FocusTextbox = 2;
        public double QTY = 0;
        public bool plus = false;
        public bool minus = false;
        public string itemname = "";
        public string itemid = "";
        public string barcode = "";
        public string uid = "";
        public int NoofCopies;
        public string unitname = "";
        public double srate = 0;
        public double tax = 0;
        public string incs = "";
        public bool SUnit = false;

        public string Printerselect = "";
        DataSet Dd;
        DataSet Dtp;
        ClsInvThermal _Thermal = new ClsInvThermal();

        bool EditMode = false; DateTime Exdate;
        Clssettings _Settings = new Clssettings();
        ClsParamlist _Param = new ClsParamlist();
        clsmnusettings _menuset = new clsmnusettings();
        ClsBusinessIssue _BusinessIssue = new ClsBusinessIssue();
        ClsIssueDetails _Issuedetails = new ClsIssueDetails();
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        ClsInventory _Inventory = new ClsInventory();
        public string StockareaId = "0";
        public static string MINofPOS = "";
        //public bool EditMode =false;

        DataSet Db;
        DBTask _Dbtask = new DBTask();
        public string SalesAccount;
        public bool SBatch = false;
        public int frstival = 0;
        public bool frstibool = false;
        public string Vtype;
    public double NRate= 0;
    public double NQty= 0;
    public double NTaxamount= 0;
    public double NNetamout= 0;
    public double NGross = 0;

    public double TBillAmount;
    public double NetTottal = 0;
      public double  NetGross= 0;
      public double  NetAmount= 0;
      public double  NetTax= 0;
      public double  NetSrate= 0;
      public double NetQty = 0;
        double TAmount = 0;
        double discamt = 0;
        double discperc = 0;
        //public bool SBatch = false;
        //Clssettings _Settings = new Clssettings();


        private void Frmpointofsale_Load(object sender, EventArgs e)
        {
            startsettings();
            clear();
        }
        public void startsettings()
        {
            if (_Settings.ReturnStatus("103") == "1")
            {
                SBatch = true;
            }
            if (_Settings.ReturnStatus("12") == "1")
            {
                SUnit = true;
            }

            Vtype = "POS";
            SalesAccount = "2";

            if (Vtype == "POS" && SalesAccount == "2")
            {
               MINofPOS = CommonClass._Paramlist.GetParamvalue("MINofPOS");

            }

            cmdreportmode.SelectedIndex = 0;

            CommonClass._Gen.FillActivePrinter(ComPrintSheme);
        }
        //private void Txttypebilldiscount_Enter(object sender, EventArgs e)
        //{
        //    focusedTextbox = (TextBox)sender;
        //    FocusTextbox = 0;
        //}

        //private void TxttypebilldiscountPerc_Enter(object sender, EventArgs e)
        //{
        //    focusedTextbox = (TextBox)sender;
        //    FocusTextbox = 1;
        //}

        //private void txtentercash_Enter(object sender, EventArgs e)
        //{
        //    focusedTextbox = (TextBox)sender;
        //    FocusTextbox = 3;
        //}

        //private void TxtQty_Enter(object sender, EventArgs e)
        //{
        //    focusedTextbox = (TextBox)sender;
        //    FocusTextbox = 2;
        //}

        public void increment()
        {

            double old=0;
            old = _dbtask.znlldoubletoobject(txtquantity.Text);

            txtquantity.Text = _dbtask.znllString((old + 1));
            
        
        }
        public void decrement()
        {
            double old = 0;
            old = _dbtask.znlldoubletoobject(txtquantity.Text);

            txtquantity.Text = _dbtask.znllString((old - 1));
        }

        private void cmdqtyplus_Click(object sender, EventArgs e)
        {
            plus = true;
            int selectedIndex = gridmain.CurrentCell.RowIndex;
            if (selectedIndex < 0)
            {
                increment();
            }
            else
            {
                QTYADDRowplusorminus();
            }
            plus = false;
        
        }

        private void cmdqtyminus_Click(object sender, EventArgs e)
        {

            minus = true;
            int selectedIndex = gridmain.CurrentCell.RowIndex;
            if (selectedIndex < 0)
            {
                decrement();
            }
            else
            {
                QTYADDRowplusorminus();
            }
            minus = false;

          
        }

        public void Fupassing(Button Cmd)
        {

            try
            {

                if (focusedTextbox.Name == "txtbarcode" || focusedTextbox.Name == "txtquantity" || focusedTextbox.Name == "txtentercashamt"||focusedTextbox.Name =="TxttypebilldiscountNew"||focusedTextbox.Name =="TxttypebilldiscountPercnew" )
                {

                    if (erase == false)
                    {
                        if (focusedTextbox != null)
                        {


                        }

                        if (focusedTextbox.SelectionLength > 0)
                        {
                            focusedTextbox.Text = "";
                        }
                        if (CommonClass._Dbtask.znullDouble(focusedTextbox.Text) == 0 && focusedTextbox.Text != ".")
                        {
                            focusedTextbox.Text = Cmd.Text;
                        }
                        else
                        {
                            focusedTextbox.Text = focusedTextbox.Text + Cmd.Text;
                        }

                    }
                    else
                    {
                        if (erase == true)
                        {

                            int textlen = 0;
                            textlen = focusedTextbox.Text.Length;
                            //focusedTextbox.Text = "2345";
                            if (textlen > 0)
                            {

                                //string tt = focusedTextbox.Text.Substring(0, (textlen - 1));
                                focusedTextbox.Text = focusedTextbox.Text.Substring(0, (textlen - 1));
                            }

                        }

                        erase = false;
                    }

                    if (focusedTextbox.Name == "txtbarcode" || focusedTextbox.Name == "txtquantity" || focusedTextbox.Name == "txtentercashamt" || focusedTextbox.Name == "TxttypebilldiscountNew" || focusedTextbox.Name == "TxttypebilldiscountPercnew")
                    {
                        focusedTextbox.Focus();
                        focusedTextbox.SelectionStart = focusedTextbox.Text.Length;
                        //txtbarcode.Cursor();
                    }
                    


                }
                else
                {
                    MessageBox.Show("As your purpose ,select Qty/barcode/cash received column ");
                }
            
            
            }
            catch
            {
            }

        }

        private void Cmdone_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdone);
        }

        private void Cmdtwo_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdtwo);
        }

        private void Cmdthree_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdthree);
        }

        private void Cmdfour_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdfour);
        }

        private void Cmdfive_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdfive);
        }

        private void Cmdsix_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdsix);
        }

        private void Cmdseven_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdseven);
        }

        private void Cmdeight_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdeight);
        }

        private void Cmdnine_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdnine);
        }

        private void Cmdzero_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdzero);
        }

        private void Cmdpoint_Click(object sender, EventArgs e)
        {
            Fupassing(Cmdpoint);
        }

        private void TxttypebilldiscountNew_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
           FocusTextbox = 0;
        }

        private void TxttypebilldiscountPercnew_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
            FocusTextbox = 1;
        }

        private void txtquantity_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
            FocusTextbox = 2;
        }

        private void txtentercashamt_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
            FocusTextbox = 3;
        }

        private void Cmdbackspace_Click(object sender, EventArgs e)
        {
            erase = true;
            Fupassing(Cmdbackspace);
        }

        

        private void TxttypebilldiscountNew_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxttypebilldiscountPercnew_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void TxttypebilldiscountNew_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyValue==13)
            {
                if (CommonClass._Dbtask.znullDouble(TxttypebilldiscountNew.Text) > 0)
                {

                    totalamountcalculations();
                }
                else
                {
                    TxttypebilldiscountNew.Text = "";
                    TxttypebilldiscountPercnew.Text = "";
                }
            }

            //TAmount = CommonClass._Dbtask.znlldoubletoobject(txtbillamount.Text);
            //discamt = CommonClass._Dbtask.znullDouble(TxttypebilldiscountNew.Text);
            //discperc = (discamt * 100) / TAmount;
            //TxttypebilldiscountPercnew.Text = CommonClass._Dbtask.SetintoDecimalpoint(discperc);
        }

        private void TxttypebilldiscountPercnew_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (CommonClass._Dbtask.znullDouble(TxttypebilldiscountPercnew.Text) > 0)
            {
                totalamountcalculations();
            }

            else
            {

                TxttypebilldiscountPercnew.Text = "";
                TxttypebilldiscountNew.Text = "";

            }
            //TAmount = CommonClass._Dbtask.znlldoubletoobject(txtbillamount.Text);
            //discperc = CommonClass._Dbtask.znullDouble(TxttypebilldiscountPercnew.Text);
            //discamt = (discperc * TAmount) / 100;
            //TxttypebilldiscountNew.Text = CommonClass._Dbtask.SetintoDecimalpoint(discamt);
        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {

        }
        public void deletevoucher()
        {
            if(Vtype=="POS")
            {
                _Dbtask.ExecuteNonQuery("delete from tblissuedetails where issuecode='" + txtvno.Tag + "' and Ledcode='" + SalesAccount + "' and vtype='" + Vtype + "'");
                _Dbtask.ExecuteNonQuery("delete from tblbusinessissue where  issuecode='" + txtvno.Tag + "' and issuetype='" + Vtype + "' and Ledcodecr='" + SalesAccount + "'");
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Refno='" + SalesAccount + "'");
            
            }
        }
        public bool validation()
        {
            if (_dbtask.znlldoubletoobject( txtgrandtotal.Text )<=0)
            {
                MessageBox.Show("Grand total is not valid please check the Bill..!");
                return false;
            
            }
            if(_dbtask.znllString( TxtAccount.Tag )==""&&commodeofpayment.SelectedIndex==1)
            {
                MessageBox.Show("check credit bill details ");
                return false;
            }


            return true;
        }
        public void cleargrid()
        {
            gridmain.Rows.Clear();
            Count = 0;
           
        }
        public void Main()
        {


            if (RowValidation() == true && validation()==true)
            {

                if (EditMode == true)
                {
                    deletevoucher();
                }
                nextginitialisation();

                if(Chkprint.Checked==true)
                {
                    print();
                }

                cleargrid();
                clear();
            }
        
        
        
        
        }



        public void totalamountcalculations()
        {
            try
            {
                NetTottal = 0; NetAmount = 0;
                NetQty = 0; NetGross = 0;
                NetTax = 0; NetSrate = 0;
              NRate= 0;
              NQty= 0;
              NTaxamount= 0;
              NNetamout= 0;
              NGross = 0;

              for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
              {
              if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
              {

                  gridmain.Rows[i].Cells["clnslno"].Value = i + 1;
                  NetTottal = Convert.ToDouble(NetTottal) + _dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value);
                  NetAmount = NetAmount + _dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value);
                  NetQty = NetQty + _dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                  NetGross = NetGross + _dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clngross"].Value);



                  NetTax = NetTax + _dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnTax"].Value);

                  NetSrate = NetSrate + _dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnsrate"].Value);


              }
              }

              txtbillamount.Text =_dbtask.znllString( NetGross);

              
              txttaxtotal.Text = _dbtask.znllString(NetTax);

              double Ndiscount = 0; double discperc = 0;
              discperc = _dbtask.znlldoubletoobject(TxttypebilldiscountPercnew.Text);
              Ndiscount = _dbtask.znlldoubletoobject(TxttypebilldiscountNew.Text);

              if (Ndiscount>0)
              {

              discperc = ( Ndiscount * 100) / NetTottal;
              TxttypebilldiscountPercnew.Text = CommonClass._Dbtask.SetintoDecimalpoint( discperc);
              }
              if (discperc>0)
                {
                    Ndiscount = (discperc * NetTottal) / 100;
                    TxttypebilldiscountNew.Text = CommonClass._Dbtask.SetintoDecimalpoint(Ndiscount);
                }



              NetTottal = NetTottal - Ndiscount;
              txtbillbalance.Text = _dbtask.znllString(NetTottal);
              txtbillbalance.Text =_dbtask.znllString( (NetTottal) -  _dbtask.znlldoubletoobject(txtentercashamt.Text));

              txtgrandtotal.Text = _dbtask.znllString(NetTottal);

            }
            catch
            {
            }
        }

        public void taxcalculation()
        {
            double TaxAmt = 0;
            double TaxPerc = 0;

            try
            {

                double Gross=0;
                double Qty = _dbtask.znlldoubletoobject(gridmain.Rows[Count].Cells["clnqty"].Value);
                double Rate = _dbtask.znlldoubletoobject(gridmain.Rows[Count].Cells["clnsrate"].Value);

                Gross = Qty * Rate;
                TaxPerc = _dbtask.znlldoubletoobject(gridmain.Rows[Count].Cells["ClntaxPer"].Value);
                itemid = _dbtask.znllString(gridmain.Rows[Count].Cells["Clnitemname"].Tag);
                
                incs = _dbtask.znllString(CommonClass._Itemmaster.SpecificField(itemid, "INCS"));
                
                if (incs== "1")
                {
                    double tempTaxPerc = 100 + TaxPerc;
                    
                    TaxAmt = NNetamout * TaxPerc / tempTaxPerc;
                    NGross = Gross - TaxAmt;
                    NNetamout = NGross + TaxAmt;

                }
                else
                {
                    double tempTaxPerc = 100;
                    TaxAmt = NNetamout * TaxPerc / tempTaxPerc;

                    NNetamout = NGross + TaxAmt;
                }

                gridmain.Rows[Count].Cells["ClntaxPer"].Value = _dbtask.SetintoDecimalpoint(TaxPerc);
                NTaxamount = TaxAmt;
                gridmain.Rows[Count].Cells["clntax"].Value = _dbtask.SetintoDecimalpoint(NTaxamount);

            }
            catch
            {

            }


        }

        public void Cellentercalculationpart()
        {
            try
            {
                itemid = _dbtask.znllString(gridmain.Rows[Count].Cells["clnitemname"].Tag);

                if (itemid != "")
                {
                    gridmain.Rows[Count].Cells["clnqty"].Value = _dbtask.SetintoDecimalpointStock(NQty);

                    gridmain.Rows[Count].Cells["clnsrate"].Value = _dbtask.SetintoDecimalpoint(NRate);

                    NGross = NQty * NRate;

                    NNetamout = NGross;


                    gridmain.Rows[Count].Cells["clntax"].Value = _dbtask.SetintoDecimalpoint(NTaxamount);
                    taxcalculation();

                    gridmain.Rows[Count].Cells["clnnettamount"].Value = _dbtask.SetintoDecimalpoint(NNetamout);
                    gridmain.Rows[Count].Cells["Clngross"].Value = _dbtask.SetintoDecimalpoint(NGross);

                }

                
            }
            catch
            {
            }
        }

        public void ProductAddtoGrid(string batch)
        {
            if (CommonClass._Batch.SameNamealreadyexistNew(_dbtask.znllString( txtbarcode.Text)) == true)
            {

                if (SameBatchFound(_dbtask.znllString(txtbarcode.Text)) == false)
                {
                    itemid = "";
                    itemname = "";
                    barcode = "";
                    uid = "";
                    unitname = "";
                    srate = 0;
                    tax = 0;
                    incs = "";

                    itemid = _dbtask.znllString(CommonClass._Batch.GetSpecificFieldByBarcode("itemid", batch)); ;
                    itemname = _dbtask.znllString(CommonClass._Itemmaster.SpecificField(itemid, "itemname"));
                    uid = _dbtask.znllString(CommonClass._Itemmaster.SpecificField(itemid, "unit"));

                    if (uid == "")
                    {
                        uid = "1";
                    }

                    unitname = _dbtask.znllString(CommonClass._Unitcreation.Getspesificfield("NAME", uid));
                    barcode = batch;

                    srate = _dbtask.znlldoubletoobject(CommonClass._Batch.GetSpecificFieldByBarcode("SRATE", batch)); ;
                    NRate = srate;
                    tax = _dbtask.znlldoubletoobject(CommonClass._Itemmaster.SpecificField(itemid, "VAT"));
                    incs = _dbtask.znllString(CommonClass._Itemmaster.SpecificField(itemid, "INCS"));

                    Count = gridmain.Rows.Add(1);
                  
                    gridmain.Rows[Count].Cells["clnbatch"].Value = barcode;
                    gridmain.Rows[Count].Cells["clnitemname"].Value = itemname;

                    gridmain.Rows[Count].Cells["clnitemname"].Tag = itemid;
                    gridmain.Rows[Count].Cells["clnqty"].Value = NQty;

                    gridmain.Rows[Count].Cells["ClnUnit"].Value = unitname;
                    gridmain.Rows[Count].Cells["ClnUnit"].Tag = uid;

                    gridmain.Rows[Count].Cells["clnsrate"].Value = srate;
                    gridmain.Rows[Count].Cells["ClntaxPer"].Value = tax;



                }
                else
                {
                    gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value = _dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value) + 1);

                    NQty = _dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value);
                    srate = _dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnsrate"].Value);
                    NRate = srate;
                    
                    Count = BatchFoundIndex;
                
                
                }
                
                Cellentercalculationpart();

                totalamountcalculations();


            }
        }

        public void Retreive(string Rvno)
        {
            string PreIssuecode = ""; string TempVtype = Vtype;



            if (Convert.ToInt64(Rvno) > 0 && Convert.ToInt64(Rvno) >= Convert.ToInt64(MINofPOS))
                {
           

            PreIssuecode = Rvno;
            Db = _dbtask.ExecuteQuery("select * from tblbusinessissue where issuecode='" + Rvno + "'  and issuetype='" + Vtype + "' and ledcodecr='"+SalesAccount+"' ");
            if (Db.Tables[0].Rows.Count > 0)
            {


                PreIssuecode = Db.Tables[0].Rows[0]["issuecode"].ToString();
                txtvno.Tag = PreIssuecode.ToString();
                txtvno.Text = PreIssuecode.ToString();
                EditMode = true;
                _Issuedetails.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                _BusinessIssue.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                _Inventory.Vcode = PreIssuecode.ToString();

                dtdate.Value = Convert.ToDateTime(Db.Tables[0].Rows[0]["issuedate"]);

                TxtAccount.Tag = _dbtask.znllString(Db.Tables[0].Rows[0]["Ledcodedr"]);
                TxtAccount.Text = _dbtask.znllString(CommonClass._Ledger.GetspecifField("lname", CommonClass._Dbtask.znllString(TxtAccount.Tag)));
                if (_dbtask.znllString(TxtAccount.Tag) != "1" && _dbtask.znllString(TxtAccount.Tag) != "28")
                {

                    Lblcusname.Text = CommonClass._Dbtask.znllString(TxtAccount.Text);
                    lblmobnum.Text = "Mobile : " + CommonClass._Ledger.GetspecifField("mobile", CommonClass._Dbtask.znllString(TxtAccount.Tag));
                }
                else
                {
                    if (_dbtask.znllString(TxtAccount.Tag) == "1" )
                    {

                        Lblcusname.Text ="Cash";
                        lblmobnum.Text = "";
                    }
                    if (_dbtask.znllString(TxtAccount.Tag) == "28")
                    {

                        Lblcusname.Text = "Bank";
                        lblmobnum.Text = "";
                    }

                }
                txtentercashamt.Text = _dbtask.znllString(Db.Tables[0].Rows[0]["CashReceived"]);
                TempVtype = _dbtask.znllString(Db.Tables[0].Rows[0]["issuetype"]);

                TxttypebilldiscountNew.Text = _dbtask.znllString(Db.Tables[0].Rows[0]["discamt"]);
 
                string MoPayment = _Dbtask.znllString(Db.Tables[0].Rows[0]["Mpayment"]);

                if (MoPayment == "")
                {
                    if (TxtAccount.Tag.ToString() == "1")
                    {
                        commodeofpayment.SelectedIndex = 0;
                    }
                    else
                    {
                        commodeofpayment.SelectedIndex = 1;
                    }
                }
                else
                {
                    commodeofpayment.SelectedIndex = Convert.ToInt16(Db.Tables[0].Rows[0]["mpayment"].ToString());
                }

                Count = 0;
                Dd = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + PreIssuecode + "'and vtype='" + Vtype + "' and ledcode ='" + SalesAccount + "'order by slno asc");
                for (int i = 0; i < Dd.Tables[0].Rows.Count; i++)
                {
                    //gridmain.Rows.Add(1);

                    gridmain.Rows.Add(1);
                    string tempSlno = (i + 1).ToString();

                  int Y=  gridmain.Rows.Count;
                    string tempitemid = Dd.Tables[0].Rows[i]["pcode"].ToString();
                    double tempQty = Convert.ToDouble(Dd.Tables[0].Rows[i]["qty"].ToString());

                    double tempsRate = Convert.ToDouble(Dd.Tables[0].Rows[i]["Rate"].ToString());


                    double tempdiscrate = Convert.ToDouble(Dd.Tables[0].Rows[i]["DiscRate"].ToString());
                    double temptaxrate = Convert.ToDouble(Dd.Tables[0].Rows[i]["Taxrate"].ToString());

                    double tempNetAmt = Convert.ToDouble(Dd.Tables[0].Rows[i]["NetAMT"].ToString());
                    double temptaxperc = Convert.ToDouble(Dd.Tables[0].Rows[i]["taxper"].ToString());


                    string tempBatchid = Dd.Tables[0].Rows[i]["batchid"].ToString();
                    string tempexpiry = _Dbtask.ZnullDatetime(Dd.Tables[0].Rows[i]["Exdate"]).ToString("dd-MM-yyyy");



                    gridmain.Rows[i].Cells["clnbatch"].Value = tempBatchid;
                    gridmain.Rows[i].Cells["clnslno"].Value = tempSlno;
                    //gridmain.Rows[i].Cells["clnserialno"].Value = tempSlno;
                    //gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");

                    gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemNAME from tblitemmaster where itemid='" + tempitemid + "'");
                    gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;


                    gridmain.Rows[i].Cells["clnexpiry"].Value = tempexpiry;
                    NQty = tempQty;
                    gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);


                   


                    NRate = tempsRate;

                    gridmain.Rows[i].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(tempsRate);

                    gridmain.Rows[i].Cells["clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");

                    NTaxamount = temptaxrate;
                    gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(temptaxrate);

                    //NTaxperc = temptaxperc;
                    gridmain.Rows[i].Cells["ClntaxPer"].Value = _Dbtask.SetintoDecimalpoint(temptaxperc);

                    //if (SUnit == true)
                    //{
                        string Unitid = "";
                        Unitid = Dd.Tables[0].Rows[i]["unitid"].ToString();
                        if (Unitid == "")
                       {
                           Unitid = "1";
                       }
                        
                        string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                        gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                        gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                    //}
                    Count = i;
                    Cellentercalculationpart();

                }

                totalamountcalculations();






            }
            else
            {
                clear();
                billclear();
                if (Vtype == "POS"  && SalesAccount == "2")
                {
                    
                    if (Convert.ToInt64(PreIssuecode) < Convert.ToInt64(Generalfunction.getnextidCondition("issuecode", "TblBusinessIssue", " where ledcodecr='2' And issuetype='" + Vtype + "'")))
                    {
                       
                        txtvno.Text = PreIssuecode.ToString();
                        txtvno.Tag = PreIssuecode.ToString();
                        _Issuedetails.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                        _BusinessIssue.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                        if (Vtype == "POS")
                        {
                            _Inventory.Vcode = Convert.ToInt64(PreIssuecode).ToString();
                        }

                        EditMode = true;


                    }


                }
            }
            }


        }

        private void txtentercashamt_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtbarcode_Leave(object sender, EventArgs e)
        {
            //ProductAddtoGrid(_dbtask.znllString(txtbarcode.Text));
        }

        public bool SameBatchFound(string BarCode)
        {
           

            int rowind = 0;

            if (gridmain.Rows.Count > 1)
            {

                for (int a = 0; a < gridmain.Rows.Count; a++)
                {
                    if (_dbtask.znlldoubletoobject(gridmain.Rows[a].Cells["clnnettamount"].Value) != 0)
                    {

                        if (_dbtask.znllString(gridmain.Rows[a].Cells["clnbatch"].Value) == BarCode && a != Count)
                        {
                            BatchFoundIndex = a;
                            rowind = rowind + 1;
                            break;
                        }
                    }
                }
            }
            if (rowind == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        private void txtbarcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if(e.KeyValue==13)
            {
                if (txtquantity.Text == "")
                {

                    NQty = 1;
                }
                else
                {
                    NQty =_dbtask.znlldoubletoobject( txtquantity.Text);
                }
                
                txtquantity.Text =_dbtask.znllString( NQty);


                
                ProductAddtoGrid(_dbtask.znllString(txtbarcode.Text));
               
            
                NQty = 0;
            
                txtquantity.Text = "";
            
                txtbarcode.Text = "";

            }
           
            
            }

        private void cmdrowdelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }


        public void DeleteRow()
        {
            try
            {
                int selectedIndex = gridmain.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    gridmain.Rows.RemoveAt(selectedIndex);
                    totalamountcalculations();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Unable to remove selected row at this time");
            }
        }
        public void QTYADDRow()
        {
            try
            {
                int selectedIndex = gridmain.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {

                    if (_dbtask.znllString(  gridmain.Rows[selectedIndex].Cells["clnitemname"].Tag) !="")
                    {
                  double addqty = 0;
                  addqty = _dbtask.znlldoubletoobject(txtquantity.Text);
                  gridmain.Rows[selectedIndex].Cells["clnqty"].Value = _dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(gridmain.Rows[selectedIndex].Cells["clnqty"].Value) + addqty);

                    NQty = _dbtask.znlldoubletoobject(gridmain.Rows[selectedIndex].Cells["clnqty"].Value);
                    srate = _dbtask.znlldoubletoobject(gridmain.Rows[selectedIndex].Cells["clnsrate"].Value);
                    NRate = srate;
                    
                    Count = selectedIndex;

                    Cellentercalculationpart();
                    totalamountcalculations();
                    }


                }
                else
                {
                    MessageBox.Show("Please select a row");
                }
            }
            catch 
            {
                
            }
        }


        public void QTYADDRowplusorminus()
        {
            try
            {
                int selectedIndex = gridmain.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    double addqty = 0;
                    if(plus==true)
                    {
                    gridmain.Rows[selectedIndex].Cells["clnqty"].Value = _dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(gridmain.Rows[selectedIndex].Cells["clnqty"].Value) + 1);
                    }

                    if (minus == true)
                    {
                        gridmain.Rows[selectedIndex].Cells["clnqty"].Value = _dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(gridmain.Rows[selectedIndex].Cells["clnqty"].Value) - 1);
                    }

                    NQty = _dbtask.znlldoubletoobject(gridmain.Rows[selectedIndex].Cells["clnqty"].Value);
                    srate = _dbtask.znlldoubletoobject(gridmain.Rows[selectedIndex].Cells["clnsrate"].Value);
                    NRate = srate;

                    Count = selectedIndex;

                    Cellentercalculationpart();
                    totalamountcalculations();
                }
                else
                {
                    if (plus == true)
                    {
                        increment();
                    }
                    if (minus == true)
                    {
                        decrement();
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                
            }
        }



        private void txtquantity_TextChanged(object sender, EventArgs e)
        {


            //NQty = _dbtask.znlldoubletoobject(txtquantity.Text);
        
        
        
        }
        public void GETVNO()
        {
            if (Vtype == "POS")
            {
                _BusinessIssue.PVno2(SalesAccount.ToString(), Vtype);
                txtvno.Text = Convert.ToString(_BusinessIssue.VnoStr);

                txtvno.Tag = _BusinessIssue.IdSalesFu(SalesAccount, Vtype);

                _Issuedetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _Inventory.Vcode = txtvno.Tag.ToString();
            }
        }

        public void SETTINGS()
        {
            if (_Settings.ReturnStatus("103") == "1")
            {
                SBatch = true;
            }
            if (Vtype == "POS" && SalesAccount == "2")
            {
                MINofPOS = CommonClass._Paramlist.GetParamvalue("MINofPOS");

            }
        }

        public void clear()
        {
            commodeofpayment.SelectedIndex = 0;
            EditMode = false;
            LBLUSER.Text = "User: " + ClsUserDetails.MUserName;
            lbltime.Text = Convert.ToString(DateTime.Now.TimeOfDay);
            txtquantity.Text = "";
            txtbarcode.Text = "";
            txtentercashamt.Text = "";
            TxttypebilldiscountNew.Text = "";
            TxttypebilldiscountPercnew.Text = "";
            Lblcusname.Text = "";
            lblmobnum.Text = "";
            TxtAccount.Tag = "1";
            GETVNO();
            SETTINGS();
          
        
        }
        public void balance()
        {
            double grandtot = 0;
            double recevd = 0;
            double balance = 0;
            grandtot =_dbtask.znlldoubletoobject( txtgrandtotal.Text);
            recevd = _dbtask.znlldoubletoobject(txtentercashamt.Text);
            balance = grandtot - recevd;

            txtbillbalance.Text =_dbtask.znllString( _dbtask.SetintoDecimalpoint(balance));
        }

        private void txtentercashamt_TextChanged(object sender, EventArgs e)
        {
            balance();
        }

        private void txtquantity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13 && _dbtask.znllString(txtbarcode.Text) != "")
            {

                NQty = _dbtask.znlldoubletoobject(txtquantity.Text);
                ProductAddtoGrid(_dbtask.znllString(txtbarcode.Text));
                NQty = 0;
                txtquantity.Text = "";
                txtbarcode.Text = "";


            }
            else
            {
                QTYADDRow();
                NQty = 0;
                txtquantity.Text = "";
                txtbarcode.Text = "";
            }
        }


        public void nextginitialisation()
        {
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
              
                
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        string Fitemid = ""; string Fbatch = ""; long Fslno;
                        string FUid = ""; string Ledcode = "";
                        double fqty = 0; double ftaxperc = 0;
                        double fsrate = 0; double ftaxamt = 0;
                        double fnetamount = 0; double fbilltot = 0;
                        double Convrt = 0;

                        Fslno = Convert.ToInt64(_dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["Clnslno"].Value));
                        Fbatch = _dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value);

                        Fitemid = _dbtask.znllString(gridmain.Rows[i].Cells["clnitemname"].Tag);
                        FUid = _dbtask.znllString(gridmain.Rows[i].Cells["clnunit"].Tag);
                        fqty = _dbtask.gridnul(gridmain.Rows[i].Cells["Clnqty"].Value);
                        fsrate = _dbtask.gridnul(gridmain.Rows[i].Cells["clnsrate"].Value);
                        ftaxamt = _dbtask.gridnul(gridmain.Rows[i].Cells["clntax"].Value);
                        ftaxperc = _dbtask.gridnul(gridmain.Rows[i].Cells["ClntaxPer"].Value);

                        fnetamount = _dbtask.gridnul(gridmain.Rows[i].Cells["Clnnettamount"].Value);
                        fbilltot =_dbtask.znlldoubletoobject(txtgrandtotal.Text);
                        Convrt =_dbtask.znlldoubletoobject( CommonClass._Unitcreation.Getspesificfield("ucount", FUid));
                        Exdate = _dbtask.ZnullDatetime(gridmain.Rows[i].Cells["clnexpiry"].Value);

                        _Inventory.Ledcode = SalesAccount;
                        _Inventory.DCodeStr = StockareaId;
                        _Inventory.InvDateDt = dtdate.Value;
                        _Inventory.PcodeStr = Fitemid;
                        _Inventory.Slno =_dbtask.znllString( Fslno);
                        _Inventory.UC = Convrt;
                        _Inventory.Exdate =_dbtask.ZnullDatetime( Exdate);

                        _Inventory.Sales = fqty;
                        _Inventory.Sr = 0;
                        _Inventory.Dn = 0;

                        _Inventory.freeiss = 0;
                        _Inventory.Costcenter = "0";
                        _Inventory.Batchcode = Fbatch;

                        if (i == frstival && EditMode == false)
                        {
                            getmaxvnonumber();
                            CommonClass._Paramlist.updateparamvalueVNO(vnoname, Convert.ToInt32(txtvno.Tag));
                        }
                        _Inventory.InsertInventory();


                        if(Vtype=="POS")
                        {

                            _Issuedetails.SlNoLng = Fslno;
                            _Issuedetails.PCodeStr = Fitemid;
                            _Issuedetails.UnitIdLng =Convert.ToInt64( FUid);
                            _Issuedetails.MultiRateIdLng = 0;
                            _Issuedetails.QtyDb = fqty;
                            _Issuedetails.RateDb = fsrate;
                            _Issuedetails.Mrp = 0;
                            _Issuedetails.NetAmtDb = fnetamount;
                            _Issuedetails.BatchIdStr = Fbatch;
                            _Issuedetails.Ledcode = SalesAccount;
                            _Issuedetails.DiscDb = 0;
                            _Issuedetails.TaxRateDb = ftaxamt;
                            _Issuedetails.QtyFreeDb =0;
                            _Issuedetails.Vtype = Vtype;
                            _Issuedetails.Taxper = ftaxperc;

                            _Issuedetails.SlnoTracking =_dbtask.znllString( Fslno);
                            _Issuedetails.Length = 0;
                            _Issuedetails.width = 0;
                            _Issuedetails.CRate =0;
                            _Issuedetails.ExDate = Exdate;
                            _Issuedetails.Itemnote2 ="";
                            _Issuedetails.billtot = fbilltot;
                            _Issuedetails.billtime = "";

                            _Issuedetails.InsertIssueDetails();
                        
                        
                        
                        }

                    }
                }
            }


            if(Vtype=="POS")
            {

                if (commodeofpayment.SelectedIndex!=1)
                {
                    txtentercashamt.Text = _dbtask.znllString(txtgrandtotal.Text); ;
                }

                _BusinessIssue.VnoStr = _dbtask.znllString(txtvno.Text);
                _BusinessIssue.Pvno = _Nextg.pvno;

                _BusinessIssue.IssueTypeStr = Vtype;
                _BusinessIssue.DCode = "0";
                _BusinessIssue.IssueDateDt = dtdate.Value;
                _BusinessIssue.LedCodeCr = SalesAccount.ToString();
                _BusinessIssue.LedCodeDr = _dbtask.znllString(TxtAccount.Tag);
                _BusinessIssue.AMTDb = _dbtask.znlldoubletoobject(txtgrandtotal.Text); ;
                _BusinessIssue.RemarkStr ="";
                _BusinessIssue.DiscAmtDb = _dbtask.gridnul(TxttypebilldiscountNew.Text);
                _BusinessIssue.TaxAMTDb = _dbtask.gridnul(txttaxtotal.Text);
                _BusinessIssue.CoolyDb = 0;
                _BusinessIssue.Agent = "";
                _BusinessIssue.EmpId ="";
                _BusinessIssue.AdvanceAmount = 0;
                _BusinessIssue.CashReceived =_dbtask.znllString( txtentercashamt.Text );
                _BusinessIssue.SR = NextGFuntion.SalesReturnVno;
                _BusinessIssue.Pproject = 0;
                _BusinessIssue.warrantyy = "";
                _BusinessIssue.Uid = ClsUserDetails.MUserName;
                _BusinessIssue.vehicle = "";
                _BusinessIssue.mtrread = "";
                _BusinessIssue.Tmob = "";
                _BusinessIssue.Tvat = "";
                _BusinessIssue.Taddres ="";
                _BusinessIssue.Tename = _dbtask.znllString(TxtAccount.Text);
                _BusinessIssue.twopaymode = "";

                _BusinessIssue.twopayAmt = 0;
                _BusinessIssue.LBLaccnt = "";
                _BusinessIssue.ModeOfpayment = commodeofpayment.SelectedIndex; ;

            }
            if (Vtype == "POS")
            {
                _BusinessIssue.IssueDateDt = dtdate.Value; ;
               
                    _BusinessIssue.TaxId = "9";
                
                _BusinessIssue.InsertBusinessIssue();
            }

            //genledg
            string StrPurticulars = "pos vno:" + _dbtask.znllString(txtvno.Text); ;
            if (Vtype == "POS" )
            {
               
                _GeneralLedger.Uid = ClsUserDetails.MUserName;
                _GeneralLedger.VdateDt = dtdate.Value;
                _GeneralLedger.Naration = "";
              
                _GeneralLedger.RefnoStr = SalesAccount;

                _GeneralLedger.VTypeStr = Vtype;
                _GeneralLedger.VnoStr = txtvno.Text;
                _GeneralLedger.SlNoLng = Convert.ToInt64("1");
                _GeneralLedger.LedCodeStr =_dbtask.znllString( TxtAccount.Tag);
                _GeneralLedger.PurticularsStr = StrPurticulars;
                _GeneralLedger.DbAmtDb = _dbtask.znlldoubletoobject(txtgrandtotal.Text);
                _GeneralLedger.CrAmt = 0;
                _GeneralLedger.cashdskRcvamt = _dbtask.znlldoubletoobject(txtentercashamt.Text);

                Insert();


                TBillAmount = _dbtask.znlldoubletoobject(txtgrandtotal.Text); ;
              
                _GeneralLedger.LedCodeStr = SalesAccount.ToString();
                _GeneralLedger.PurticularsStr = StrPurticulars;//StrPurticulars;
                _GeneralLedger.DbAmtDb = 0;

                _GeneralLedger.cashdskRcvamt = _dbtask.znlldoubletoobject(txtentercashamt.Text);


                double TTInvoiceDiscount = _Dbtask.znullDouble(TxttypebilldiscountNew.Text);
                double TTTax = _Dbtask.znullDouble(txttaxtotal.Text);
                double Cr =  TTTax;
                double TTNet = TBillAmount;
                _GeneralLedger.CrAmt = TTNet + TTInvoiceDiscount;
                Insert();

                //Discount 
                double TottalDiscount = 0;
                TottalDiscount = _Dbtask.znullDouble(TxttypebilldiscountNew.Text);
                if (TottalDiscount > 0)
                {
                    if (Vtype == "POS" )
                    {
                        _GeneralLedger.InsertAccountsDrSales("7", StrPurticulars, TottalDiscount, 0, SalesAccount);
                    }
                    
                }


                //For Tax
                double TottalTax = 0;
                TottalTax = _dbtask.znlldoubletoobject(txttaxtotal.Text);
                if (Vtype == "POS")
                {
                    if ( TottalTax > 0)
                    {
                        _GeneralLedger.InsertAccountsCrPurchase("9", StrPurticulars, 0, TottalTax, SalesAccount);
                    }
                    
                }



            }


        }
        public void Insert()
        {
            _GeneralLedger.InsertGeneralLedger();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        public void getmaxvnonumber()
        {
            vnoname = "";
            EditMode = false;
            if (Vtype == "POS" && SalesAccount == "2")
            {
                vnoname = "MaxofPOS";
                CommonClass._GenF.checkmaxtableandparamval(CommonClass._Paramlist.GetParamvalue("MaxofSI"), vnoname);

                txtvno.Tag = CommonClass._Paramlist.GetParamvalue("MaxofPOS");
                txtvno.Text = CommonClass._Paramlist.GetParamvalue("MaxofPOS");
                _Issuedetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _Inventory.Vcode = txtvno.Tag.ToString();
            }
        }



        public bool RowValidation()
        {
            try
            {

                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["clnitemname"].Tag == null)
                    {
                        gridmain.Rows[i].Tag = -1;
                    }
                    else
                    {
                        if (SBatch == true)
                        {
                            if (gridmain.Rows[i].Cells["clnitemname"].Tag != null && _dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) > 0)
                            {
                                if (_dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value) == "")
                                {
                                    MessageBox.Show("Barcode is empty .Line number = " + (i + 1).ToString());
                                    return false;
                                }
                            }


                            if (gridmain.Rows[i].Cells["clnitemname"].Tag != null && _dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) <= 0)
                            {
                                MessageBox.Show("Check Amount Line number = " + (i + 1).ToString());
                                return false;

                            }

                            else
                            {
                                if (frstibool == false)
                                {
                                    frstival = i;
                                    frstibool = true;
                                }
                                gridmain.Rows[i].Tag = 1;
                                gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                            }




                        }
                            
                    }
                }

                frstibool = false;
            }
            catch
            {
            }
            return true;
        }

        private void Cmdone_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Cmdone_MouseLeave(object sender, EventArgs e)
        {
            Cmdone.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdtwo_MouseEnter(object sender, EventArgs e)
        {
            Cmdtwo.ForeColor = Color.SpringGreen;
        }

        private void Cmdtwo_MouseLeave(object sender, EventArgs e)
        {
            Cmdtwo.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdone_MouseEnter(object sender, EventArgs e)
        {
            Cmdone.ForeColor = Color.SpringGreen;
        }

        private void Cmdthree_MouseEnter(object sender, EventArgs e)
        {
            Cmdthree.ForeColor = Color.SpringGreen;
        }

        private void Cmdthree_MouseLeave(object sender, EventArgs e)
        {
            Cmdthree.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdfour_MouseEnter(object sender, EventArgs e)
        {
            Cmdfour.ForeColor = Color.SpringGreen;
        }

        private void Cmdfour_MouseLeave(object sender, EventArgs e)
        {
            Cmdfour.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdfive_MouseEnter(object sender, EventArgs e)
        {
            Cmdfive.ForeColor = Color.SpringGreen;
        }

        private void Cmdfive_MouseLeave(object sender, EventArgs e)
        {
            Cmdfive.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdsix_MouseEnter(object sender, EventArgs e)
        {
            Cmdsix.ForeColor = Color.SpringGreen;
        }

        private void Cmdsix_MouseLeave(object sender, EventArgs e)
        {
            Cmdsix.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdseven_MouseEnter(object sender, EventArgs e)
        {
            Cmdseven.ForeColor = Color.SpringGreen;
        }

        private void Cmdseven_MouseLeave(object sender, EventArgs e)
        {
            Cmdseven.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdeight_MouseEnter(object sender, EventArgs e)
        {
            Cmdeight.ForeColor = Color.SpringGreen;
        }

        private void Cmdeight_MouseLeave(object sender, EventArgs e)
        {
            Cmdeight.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdnine_MouseEnter(object sender, EventArgs e)
        {
            Cmdnine.ForeColor = Color.SpringGreen;
        }

        private void Cmdnine_MouseLeave(object sender, EventArgs e)
        {
            Cmdnine.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdzero_MouseEnter(object sender, EventArgs e)
        {
            Cmdzero.ForeColor = Color.SpringGreen;
        }

        private void Cmdzero_MouseLeave(object sender, EventArgs e)
        {
            Cmdzero.ForeColor = Color.MediumVioletRed;
        }

        private void Cmdpoint_MouseEnter(object sender, EventArgs e)
        {
            Cmdpoint.ForeColor = Color.SpringGreen;
        }

        private void Cmdpoint_MouseLeave(object sender, EventArgs e)
        {
            Cmdpoint.ForeColor = Color.MediumVioletRed;
        }

        private void cmdenter_MouseEnter(object sender, EventArgs e)
        {
            cmdenter.BackColor = Color.GreenYellow;
        }

        private void cmdenter_MouseLeave(object sender, EventArgs e)
        {
            cmdenter.BackColor = Color.White;
        }

        private void txtbarcode_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
            FocusTextbox = 4;
        }

        private void cmdcalcclear_Click(object sender, EventArgs e)
        {
            txtbarcode.Text="";
            txtquantity.Text="";
            txtentercashamt.Text = "";
            commodeofpayment.SelectedIndex = 0;
        }

        private void cmdcustmoer_Enter(object sender, EventArgs e)
        {
         
        }

        private void cmdcustmoer_Leave(object sender, EventArgs e)
        {
           
        }

        private void cmdcustmoer_MouseEnter(object sender, EventArgs e)
        {
            //cmdcustmoer.BackColor = Color.LemonChiffon;
        }

        private void cmdcustmoer_MouseLeave(object sender, EventArgs e)
        {
            //cmdcustmoer.BackColor = Color.LavenderBlush;

        }

        private void TxtAccount_TextChanged(object sender, EventArgs e)
        {
            LoadPartyOnGrid("18", TxtAccount.Text);
        }

        private void cmdcustmoer_Click(object sender, EventArgs e)
        {

            if (PNLCUSTOMER.Visible == true)
            {
                if (_dbtask.znllString(TxtAccount.Tag) == "")
                {
                    PNLCUSTOMER.Visible = false;

                    //PNLtoptab.Size = new Size(413, 79);
                }
            }
            else
            {

                //PNLtoptab.Size = new Size(413, 266);
                PNLCUSTOMER.Visible = true;
                PNLCUSTOMER.Location = new Point(3, 5);
                PNLCUSTOMER.Size = new Size(379, 184);
                PNLPRINTSET.Visible = false;
                pnlreport.Visible = false;
            }
            

        }
        public void LoadPartyFromGridToBox()
        {

            if (GridAccount.SelectedRows.Count > 0)
            {
                int Index = GridAccount.SelectedRows[0].Index;
                if (CommonClass._Dbtask.znlldoubletoobject(GridAccount.Rows[Index].Cells["ClnAccount"].Tag) != 0)
                {
                    TxtAccount.Tag = CommonClass._Dbtask.znllString(GridAccount.Rows[Index].Cells["ClnAccount"].Tag);
                    TxtAccount.Text = CommonClass._Dbtask.znllString(GridAccount.Rows[Index].Cells["ClnAccount"].Value);
                    Lblcusname.Text = CommonClass._Dbtask.znllString(TxtAccount.Text);
                    lblmobnum.Text ="Mobile : "+ CommonClass._Ledger.GetspecifField("mobile", CommonClass._Dbtask.znllString(TxtAccount.Tag));
                    GridAccount.Visible = false;
                }
            }
        }
        public void LoadPartyOnGrid(string GroupId, string NameLike)
        {
            string Sql = "Select * From TblAccountLedger Where AgroupId = " + GroupId + " And LName Like '%" + NameLike + "%'";
            DataSet Ds = CommonClass._Dbtask.ExecuteQuery(Sql);
           // GridAccount.Location = new Point(TxtAccount.Location.X, TxtAccount.Location.Y + TxtAccount.Size.Height);
            GridAccount.Visible = true;
            GridAccount.Rows.Clear();
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    GridAccount.Rows.Add(1);
                    GridAccount.Rows[i].Cells["ClnAccount"].Value = Ds.Tables[0].Rows[i]["LName"];
                    GridAccount.Rows[i].Cells["ClnAccount"].Tag = Ds.Tables[0].Rows[i]["Lid"];
                    GridAccount.Rows[i].Selected = false;
                }
                GridAccount.Rows[0].Selected = true;
            }
        }
        private void TxtAccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                LoadPartyFromGridToBox();

                PNLCUSTOMER.Visible = false;

                PNLtoptab.Size = new Size(413, 79);
            }
            else
            {
                Generalfunction.ChangeGridSelection(GridAccount, e.KeyValue);
            }
        }

        private void commodeofpayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (commodeofpayment.SelectedIndex == 0)
            {
                TxtAccount.Tag = "1";
            }
            if (commodeofpayment.SelectedIndex == 2)
            {
                TxtAccount.Tag = "28";
            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                TxtAccount.Tag = "";
            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                cmdcustmoer.Enabled = true;
            }
            else
            {
                PNLCUSTOMER.Visible = false;

                PNLtoptab.Size = new Size(413, 79);
                cmdcustmoer.Enabled = false;
            }
        }
        public void Normal3PointLaser(string Pselect)
        {
            
            string Taddres = "";

              string  Tvat = "";
             string   Tmob ="";
             string Tnamee = "";
            _Thermal.PTYpe = this.Text;
            _Thermal.TempCust = TxtAccount.Text;



            _Thermal.TotalTaxable = _Dbtask.znullDouble(txtbillamount.Text);
            _Thermal.TotalTaxAmount = _Dbtask.znullDouble(txttaxtotal.Text);

            _Thermal.TDiscount = _Dbtask.znllString(TxttypebilldiscountNew.Text);
           

            _Thermal.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _Thermal.BillDate = dtdate.Value;
            _Thermal.Billno = _Dbtask.znllString(txtvno.Text);
            _Thermal.TgrossAmt = _Dbtask.znllString(txtbillamount.Text);

            _Thermal.BillAmount = (_Dbtask.znullDouble(txtgrandtotal.Text)).ToString("0.00");
            _Thermal.TotalNetamount = _Dbtask.znullDouble(txtgrandtotal.Text);
            _Thermal.FormType = this.Text;
            _Thermal.Ttaxamount = _Dbtask.znllString(txttaxtotal.Text);
            //_Thermal.TotalQty = txttqty.Text;
            _Thermal.Bunit = false;
            
            if (commodeofpayment.SelectedIndex == 0)
            {
                _Thermal.ModeofPayment = "CASH";
            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _Thermal.ModeofPayment = "CREDIT";
               Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(TxtAccount.Tag)));

                Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(TxtAccount.Tag)));
                Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(TxtAccount.Tag)));
                Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(TxtAccount.Tag)));
            }
            if (commodeofpayment.SelectedIndex == 2)
            {
                _Thermal.ModeofPayment = "BANK";
            }

            if (commodeofpayment.SelectedIndex != 1)
            {
                txtentercashamt.Text = _dbtask.znllString(txtgrandtotal.Text); ;
                txtbillbalance.Text = "";
            
            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                txtbillbalance.Text = _dbtask.znllString(txtgrandtotal.Text); ;
            }
            _Thermal.Taddres = Taddres;
            _Thermal.cashrecvd =_Dbtask.znllString( txtentercashamt.Text);
            _Thermal.Tvat = Tvat;
            _Thermal.Tmob = Tmob;
            _Thermal.Tename = Tnamee;
            

            _Thermal.deskbalnc = _Dbtask.znllString(txtbillbalance.Text);







            _Thermal.PSelect = ComPrintSheme.Text; ;
           

            _Thermal.PrintInvoice(gridmain);
        }
        public void Mainprint()
        {
                Printerselect = CommonClass._Dbtask.GetPrinterSelect();
                Normal3PointLaser(Printerselect);
        }
        public void print()
        {

            NoofCopies = Convert.ToInt32(_Dbtask.znullDouble((CommonClass._Paramlist.GetParamvalue("Nocopies"))));
            if (NoofCopies == 0)
            {
                NoofCopies = 1;
            }


            for (int k = 0; k < NoofCopies; k++)
            {
                if (k == 0)
                    Mainprint();
                else
                    Mainprint();
            }
        }
        private void cmdenter_Click(object sender, EventArgs e)
        {
            
            Main();


        }

        private void Cmdback_Click(object sender, EventArgs e)
        {
            Retreive((Convert.ToInt64(txtvno.Tag) - 1).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retreive((Convert.ToInt64(txtvno.Tag) + 1).ToString());
        }

        public void addtableitems()
        {
            try
            {

                Dtp = CommonClass._Batch.Batchtableitem();
                 if (Dtp.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < Dtp.Tables[0].Rows.Count; i++)
                    {

                        string batch="";
                        batch =_dbtask.znllString( Dtp.Tables[0].Rows[i]["bcode"]);

                     if (SameBatchFound(_dbtask.znllString( batch)) == false)
                     {
                    itemid = "";
                    itemname = "";
                    barcode = "";
                    uid = "";
                    unitname = "";
                    srate = 0;
                    tax = 0;
                    incs = "";

                    itemid = _dbtask.znllString(CommonClass._Batch.GetSpecificFieldByBarcode("itemid", batch)); ;
                    itemname = _dbtask.znllString(CommonClass._Itemmaster.SpecificField(itemid, "itemname"));
                    uid = _dbtask.znllString(CommonClass._Itemmaster.SpecificField(itemid, "unit"));

                    if (uid == "")
                    {
                        uid = "1";
                    }

                    unitname = _dbtask.znllString(CommonClass._Unitcreation.Getspesificfield("NAME", uid));
                    barcode = batch;

                    srate = _dbtask.znlldoubletoobject(CommonClass._Batch.GetSpecificFieldByBarcode("SRATE", batch)); ;
                    NRate = srate;
                    tax = _dbtask.znlldoubletoobject(CommonClass._Itemmaster.SpecificField(itemid, "VAT"));
                    incs = _dbtask.znllString(CommonClass._Itemmaster.SpecificField(itemid, "INCS"));

                    Count = gridmain.Rows.Add(1);
                    gridmain.Rows[Count].Cells["clnbatch"].Value = barcode;
                    gridmain.Rows[Count].Cells["clnitemname"].Value = itemname;

                    gridmain.Rows[Count].Cells["clnitemname"].Tag = itemid;
                    NQty=1;
                    gridmain.Rows[Count].Cells["clnqty"].Value = NQty;

                    gridmain.Rows[Count].Cells["ClnUnit"].Value = unitname;
                    gridmain.Rows[Count].Cells["ClnUnit"].Tag = uid;

                    gridmain.Rows[Count].Cells["clnsrate"].Value = srate;
                    gridmain.Rows[Count].Cells["ClntaxPer"].Value = tax;



                }
                else
                {
                    gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value = _dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value) + 1);

                    NQty = _dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value);
                    srate = _dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnsrate"].Value);
                    Count = BatchFoundIndex;
                
                
                }
                
                Cellentercalculationpart();

                totalamountcalculations();


            }



                    }

                }
            catch
            {
            }
            }

        private void cmdtableitems_Click(object sender, EventArgs e)
        {



            addtableitems();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (PNLPRINTSET.Visible == true)
            {
                PNLPRINTSET.Visible = false;
            }
            else
            {

                //PNLtoptab.Size = new Size(413, 266);
                PNLCUSTOMER.Visible = false;
                pnlreport.Visible = false;
                PNLPRINTSET.Visible = true;
                PNLPRINTSET.Location = new Point(3, 5);
                PNLPRINTSET.Size = new Size(379, 184);
            }
            
        }

        private void CMDOKPRINTER_Click(object sender, EventArgs e)
        {
            PNLPRINTSET.Visible = false;
            //PNLtoptab.Size = new Size(413, 79);
        }

        private void cmdprint_Click(object sender, EventArgs e)
        {
            print();
        }

        private void TxttypebilldiscountPercnew_Leave(object sender, EventArgs e)
        
        {
            if (CommonClass._Dbtask.znullDouble(TxttypebilldiscountPercnew.Text) > 0)
            {
                totalamountcalculations();
            }

            else
            {

                TxttypebilldiscountPercnew.Text = "";
                TxttypebilldiscountNew.Text = "";

            }
            //double perc = 0;
            //TAmount = CommonClass._Dbtask.znlldoubletoobject(txtgrandtotal.Text);
            //perc = CommonClass._Dbtask.znullDouble(TxttypebilldiscountPercnew.Text);
            //discamt = (perc * TAmount) / 100;
            //TxttypebilldiscountNew.Text = CommonClass._Dbtask.SetintoDecimalpoint( discamt);
            ////discperc = CommonClass._Dbtask.znullDouble(TxttypebilldiscountPercnew.Text);
            //TxttypebilldiscountPercnew.Text = CommonClass._Dbtask.SetintoDecimalpoint(perc);
        
        }

        public void billclear()
        {
            gridmain.Rows.Clear();
            txtbillamount.Text = "";

            TxttypebilldiscountNew.Text = "";
            TxttypebilldiscountPercnew.Text = "";
            txttaxtotal.Text = "";
            txtgrandtotal.Text = "";
            txtbillbalance.Text = "";
        }


        private void cmdgridclear_Click(object sender, EventArgs e)
        {
            billclear();
            //gridmain.Rows.Clear();
            //txtbillamount.Text="";

            //    TxttypebilldiscountNew.Text="";
            //    TxttypebilldiscountPercnew.Text="";
            //        txttaxtotal.Text="";
            //        txtgrandtotal.Text="";
            //        txtbillbalance.Text = "";
                    clear();

        }
        public void report()
        {
            string where = "";
            if (cmdreportmode.SelectedIndex == 0)
            {
                where = " having  TblBusinessIssue.issuetype='POS' and  TblBusinessIssue. ledcodecr  IN( 2)";
            }
            if (cmdreportmode.SelectedIndex == 1)
            {
                where = "having  TblBusinessIssue.issuetype='POS' and  TblBusinessIssue. ledcodecr  IN( 2) and TblBusinessIssue.mpayment=0";
            }
            if (cmdreportmode.SelectedIndex == 2)
            {
                where = "having  TblBusinessIssue.issuetype='POS' and  TblBusinessIssue. ledcodecr  IN( 2) and TblBusinessIssue.mpayment=1";
            }
            if (cmdreportmode.SelectedIndex == 3)
            {
                where = "  having  TblBusinessIssue.issuetype='POS' and  TblBusinessIssue. ledcodecr  IN( 2) and TblBusinessIssue.mpayment=2";
            }

            CommonClass._report.DTFrom = Convert.ToDateTime(DtFrom.Value.ToString("dd/MMM/yyyy 00:00:00"));
            CommonClass._report.DTTo = Convert.ToDateTime(DtTo.Value.ToString("dd/MMM/yyyy 23:59:59"));

           

            Clsselectreport.RType = "Sales";
            Clsselectreport.RQuery = where;
            Clsselectreport.RQueryTemp = "";
            Clsselectreport.RQueryDetail = "";
            Clsselectreport.RDtfrom = CommonClass._report.DTFrom;
            Clsselectreport.Rdtto = CommonClass._report.DTTo;
            CommonClass._Clreport.ShowReport(this, true);

        }

        private void CMDSHOW_Click(object sender, EventArgs e)
        {
            report();
            pnlreport.Visible = false;
        }

        private void cmdposreport_Click(object sender, EventArgs e)
        {
            if (pnlreport.Visible == true)
            {
                pnlreport.Visible = false;
            }

            else
            {
                //PNLtoptab.Size = new Size(413, 266);
                PNLCUSTOMER.Visible = false;
                PNLPRINTSET.Visible = false;
                pnlreport.Visible = true;
                pnlreport.Location = new Point(3, 5);
                pnlreport.Size = new Size(379, 184);
            }
        }

        private void TxttypebilldiscountNew_Leave(object sender, EventArgs e)
        {
            //TAmount = CommonClass._Dbtask.znlldoubletoobject(txtgrandtotal.Text);
            //discamt = CommonClass._Dbtask.znullDouble(TxttypebilldiscountNew.Text);
            //discperc = (discamt * 100) / TAmount;
            //TxttypebilldiscountPercnew.Text = CommonClass._Dbtask.SetintoDecimalpoint(discperc);

           
        }

        private void txtquantity_Leave(object sender, EventArgs e)
        {

        }

        //private void cmdtableitems_Click(object sender, EventArgs e)
        //{

        //}




    }
}
