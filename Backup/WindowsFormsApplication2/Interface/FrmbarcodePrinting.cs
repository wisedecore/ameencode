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
    public partial class FrmbarcodePrinting : Form
    {
        public FrmbarcodePrinting()
        {
            InitializeComponent();
        }
        ClsInGrid _Ingrid = new ClsInGrid();
        DBTask _Dbtask = new DBTask();
        LPrinter MyPrinter = new LPrinter();
        Clssettings _Settings = new Clssettings();
        ClsInventory _Inventory = new ClsInventory();
        ClsParamlist _Paramlist = new ClsParamlist();
        Clsbatch _Batch = new Clsbatch();
        public int SeleRow;
        //public int SeleRow;
        public double Strprate;
        public string StockareaId;
        public string Temp;
        public bool IsEnter;
        public bool P1by1;
        public bool search = false;
        public string Itemid;
        public string ItemName;
        public string ItemCode;
        public double Srate;
        public double Prate;
        public double MRP;
        public static bool prnt = false;
        public static string Barcodeprintingin;

        public string SelectedBarcode;
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)
            {
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                    SendKeys.Send("{Tab}");
                        }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        public void PrintBarcode()
        {

            this.barCodeCtrl1.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Left;
            // this.barCodeCtrl1.LeftMargin = 20;
            // this.barCodeCtrl1.Height = 50;
            this.barCodeCtrl1.BarCodeHeight = 30;
            //this.barCodeCtrl1.TopMargin=50;
            // this.barCodeCtrl1.Height = 50;

            string StrHeader;
            /*************For Get Heading Barcode***********/

            double Dbtemp = Convert.ToDouble(_Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=142"));
            Itemid =_Dbtask.znllString(txtitemname.Tag);
            
            
            if (Dbtemp == 1)
            {
                StrHeader = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            }
            else
            {
                StrHeader = WindowsFormsApplication2.CommonClass._Paramlist.GetParamvalue("BarcodeHeading");
            }
            /*******************************************************/
           // string StrHeader = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            string Strpname = txtitemname.Text;
            if (_Settings.ReturnStatus("169") == "1")
            {
                Strpname = CommonClass._Itemmaster.SpecificField(txtitemname.Tag.ToString(), "llang");
            }

            Barcodeprintingin = _Paramlist.GetParamvalue("Printbarcodein");
            if (Barcodeprintingin == "Srate")
            {
                Strprate = _Dbtask.znullDouble(txtsrate.Text);
                if (CommonClass._Paramlist.GetParamvalue("PrintTaxpurchase") == "-1")
                {
                    Strprate = Strprate + Strprate * _Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "vat")) / 100;
                }
            }
            else if (Barcodeprintingin == "MRP")
            {
                Strprate = _Dbtask.znullDouble(txtmrp.Text);
            }
            string StrBarcode = txtbarcode.Text;
            double temp = _Dbtask.znullDouble(txtqty.Text);
            //if (temp % 2 != 0)
            //{
            //    temp = temp + 1;
            //}

            // double temp2= temp / 2;
            // Strprate = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Strprate));
            int InNoofcpies = Convert.ToInt16(temp);
            this.barCodeCtrl1.bcdpic = true;
            this.barCodeCtrl1.ShowHeader = true;
            this.barCodeCtrl1.HeaderFont = new Font("Calibri", 8, FontStyle.Bold);
            this.barCodeCtrl1.ProductFont = new Font("Calibri", 8, FontStyle.Regular);
            this.barCodeCtrl1.Rsfont = new Font("Calibri", 9, FontStyle.Bold);
            this.barCodeCtrl1.FooterFont = new Font("Calibri", 8, FontStyle.Regular);
            this.barCodeCtrl1.HeaderText = StrHeader;
            this.barCodeCtrl1.RupeeImgaeFu = Picrupee.BackgroundImage;
            this.barCodeCtrl1.PInfo = Strpname;
            this.barCodeCtrl1.PInfo1 = ": " + Strprate.ToString("0.00");
            this.barCodeCtrl1.BarCode = StrBarcode;
            this.barCodeCtrl1.ShowFooter = true;
            this.barCodeCtrl1.Noofcpies = InNoofcpies;
            this.barCodeCtrl1.seclang = _Dbtask.znllString( CommonClass._Itemmaster.SpecificField(Itemid, "llang"));
            this.barCodeCtrl1.itemcodee = _Dbtask.znllString(CommonClass._Itemmaster.SpecificField(Itemid, "itemcode"));
            string dateexs = ""; dateexs = _Dbtask.znllString(Dtexdate.Value);
            string datemans = ""; datemans = _Dbtask.znllString(dtmanfactdate.Value);
            string datess = "";
            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("225")) == "1")
            {

                this.barCodeCtrl1.mandate = "Mf:" + datemans.Substring(0, 10) ;
                this.barCodeCtrl1.exedate = "Ex:" + dateexs.Substring(0, 10);
            }

            if(_Dbtask.znllString( CommonClass._Menusettings.GetMnustatus("225"))=="-1")
            {

            datess ="Mf:"+ (datemans.Substring(0, 10) + " _ "+"Ex:" + dateexs.Substring(0, 10));
            this.barCodeCtrl1.exedate = datess;
            }
            if (_Settings.FunSettings1("MdateBPrint") == true)
            {
                this.barCodeCtrl1.LeftMargin = 20;
                this.barCodeCtrl1.PrintManDate = true;
            }
            this.barCodeCtrl1.ThemalTopmargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LaserTop"));
            this.barCodeCtrl1.LeftMargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LeftBarcode"));
            this.barCodeCtrl1.DistanceBysticker = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Dissticker"));
            this.barCodeCtrl1.TopMargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LaserTop"));
            //if (_Settings.FunSettings1("SuppliercodeBPrint") == true)
            //{
            //    this.barCodeCtrl1.LeftMargin = 20;
            //    this.barCodeCtrl1.ShowSupplierCode = true;

            //    this.barCodeCtrl1.SuppCode = _AccountLedger.GetspecifField("laliasname", TxtAccount.Tag.ToString());
            //}
            this.barCodeCtrl1.Print(gridmain, this.barCodeCtrl1.Barcodeprintingin, "Roll", P1by1, comprint.Text);

            //this.barCodeCtrl1.PrintSingle(Barcodeprintingin, "Roll");
        }
        public void ProductGridShow(string WhereCondition)
        {
            try
            {
                _Ingrid.BatchGridShow(uscGridshow1, WhereCondition, uscGridshow1.GridProductShow, StockareaId, true, false, "");



                if (uscGridshow1.Visible == false)
                {
                    uscGridshow1.Visible = true;
                }
            }
            catch
            {
            }
        }
        public void RowClick(string Value, int KeyValue)
            {
            try
            {
                // gridmain.Rows[rowindex].Cells["clnitemcode"].Value = Value;

                _Ingrid.RowUpDownSelectinTexttbox(KeyValue, uscGridshow1.GridProductShow, SeleRow, uscGridshow1);
                uscGridshow1.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);
                if (KeyValue == 13)
                {
                    SeleRow = uscGridshow1.GridProductShow.SelectedRows[0].Index;
                    Itemid = uscGridshow1.GridProductShow.Rows[SeleRow].Cells["itemid"].Value.ToString();
                    ItemName = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                    ItemCode = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Itemid + "'");
                    
                    txtitemname.Text = ItemName;
                    txtitemcode.Text = ItemCode;
                    txtitemname.Tag = Itemid;
                    txtbarcode.Text =_Dbtask.znllString( uscGridshow1.GridProductShow.Rows[SeleRow].Cells["bcode"].Value);
                    if (_Dbtask.znllString(txtbarcode.Text) != "")
                    {
                        double MRP = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select mrp from tblbatch where bcode='" + _Dbtask.znllString(txtbarcode.Text) + "' and itemid='" + Itemid + "'"));
                        double SRate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select srate from tblbatch where bcode='" + _Dbtask.znllString(txtbarcode.Text) + "' and itemid='" + Itemid + "'"));
                        double PRate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select prate from tblbatch where bcode='" + _Dbtask.znllString(txtbarcode.Text) + "' and itemid='" + Itemid + "'"));



                        txtmrp.Text = _Dbtask.SetintoDecimalpoint(MRP);
                        txtsrate.Text = _Dbtask.SetintoDecimalpoint(SRate);
                        txtprate.Text = _Dbtask.SetintoDecimalpoint(PRate);
                    }
                        
                        txtqty.Text = _Dbtask.znllString("1");
                    uscGridshow1.Visible = false;
                    IsEnter = false;
                    ListBarcode(Itemid);
                }
            }
            catch
            {
            }
        }
        public void ListBarcode(string Itemid)
        {
            _Dbtask.fillDatainCombowithQuery(combatchcode, "bid", "bcode", "tblbatch", "select * from tblbatch where itemid='" + Itemid + "'");

        }
        public void SelindexChange(string Bcode, string Itemid)
        {
            double MRP = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select mrp from tblbatch where bcode='" + Bcode + "' and itemid='" + Itemid + "'"));
            double SRate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select srate from tblbatch where bcode='" + Bcode + "' and itemid='" + Itemid + "'"));
            double PRate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select prate from tblbatch where bcode='" + Bcode + "' and itemid='" + Itemid + "'"));
            double Qty = _Inventory.GetStock(" where pcode='" + Itemid + "' and batchcode='" + Bcode + "'");
            txtmrp.Text = _Dbtask.SetintoDecimalpoint(MRP);
            txtsrate.Text = _Dbtask.SetintoDecimalpoint(SRate);
            txtprate.Text = _Dbtask.SetintoDecimalpoint(PRate);
            Qty = 1;
            txtbarcode.Text = _Dbtask.znllString(uscGridshow1.GridProductShow.Rows[SeleRow].Cells["bcode"].Value);
            txtqty.Text = _Dbtask.SetintoDecimalpoint(Qty);
        }

        public void SelindexChangeWithExpiry(string Bcode, string Itemid,DateTime Pexpiry)
        {
            double MRP = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select mrp from tblbatch where bcode='" + Bcode + "' and itemid='" + Itemid + "' and exdate='"+Pexpiry.ToString("dd/MMM/yyyy")+"'"));
            double SRate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select srate from tblbatch where bcode='" + Bcode + "' and itemid='" + Itemid + "' and exdate='" + Pexpiry.ToString("dd/MMM/yyyy") + "'"));
            double PRate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select prate from tblbatch where bcode='" + Bcode + "' and itemid='" + Itemid + "' and exdate='" + Pexpiry.ToString("dd/MMM/yyyy") + "'"));
            double Qty = _Inventory.GetStock(" where pcode='" + Itemid + "' and batchcode='" + Bcode + "' and exdate='" + Pexpiry.ToString("dd/MMM/yyyy") + "'");
            txtmrp.Text = _Dbtask.SetintoDecimalpoint(MRP);
            txtsrate.Text = _Dbtask.SetintoDecimalpoint(SRate);
            txtprate.Text = _Dbtask.SetintoDecimalpoint(PRate);
            Qty = 1;
            
            txtqty.Text = _Dbtask.SetintoDecimalpoint(Qty);
        }
        private void txtitemname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void txtitemname_TextChanged(object sender, EventArgs e)
        {
            //  IsEnter = true;
            Temp = txtitemname.Text;
            if (IsEnter == true)
            {
                ProductGridShow(" where itemCode Like N'%" + Temp + "%' OR itemName Like N'%" + Temp + "%' OR llang Like N'%" + Temp + "%'");
            }
        }

        private void txtitemname_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            // _Ingrid.KeyMoveinTextbox(gri
            RowClick(txtitemname.Text, e.KeyValue);
        }

        private void combatchcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string Bcode = _Dbtask.znllString(txtbarcode.Text);
            //SelindexChange(Bcode, txtitemname.Tag.ToString());
        }

        public void UpdateBarcodeRates()
        {
            SelectedBarcode = txtbarcode.Text;

            if (txtbarcode.Text != "" && txtbarcode.Text != null)
            {
                Itemid = txtitemname.Tag.ToString();
                MRP = _Dbtask.znullDouble(txtmrp.Text);
                Srate = _Dbtask.znullDouble(txtsrate.Text);
                Prate = _Dbtask.znullDouble(txtprate.Text);

                _Batch.UpdateField(Itemid, MRP, "mrp", SelectedBarcode,Dtexdate.Value.ToString("dd/MMM/yyyy"));
                _Batch.UpdateField(Itemid, Srate, "srate", SelectedBarcode, Dtexdate.Value.ToString("dd/MMM/yyyy"));
                _Batch.UpdateField(Itemid, Prate, "prate", SelectedBarcode, Dtexdate.Value.ToString("dd/MMM/yyyy"));

                CommonClass._Gen.ExportToWieghtMechine();
                MessageBox.Show("Barcode Rates Updated Successfully", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ivalid Update Select Fields", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void UpdateMaxbarcode()
        {
            try
            {
                float MaxBcode = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("MaxBcode"));
                if (Convert.ToInt64(txtnewbarcode.Text) > MaxBcode)
                {
                    _Dbtask.ExecuteNonQuery(" update tblparamlist set paramvalue='" + txtnewbarcode.Text + "' where paramname='MaxBcode' ");
                }
            }
            catch
            {
            }
        }

        public void UpdateBarcodeName()
        {
            try
            {
                UpdateMaxbarcode();
                SelectedBarcode = txtbarcode.Text;
                string NewBarcode = txtnewbarcode.Text;
                Temp = _Dbtask.ExecuteScalar("select count(*) from tblbatch where bcode='" + NewBarcode + "'");
                if (SelectedBarcode != "" && SelectedBarcode != null && NewBarcode != "" )
                {
                    //_Dbtask.ExecuteNonQuery("DELETE FROM tblbatch  where bcode='" + SelectedBarcode + "'");
                    _Dbtask.ExecuteNonQuery("update tblbatch set bcode ='" + NewBarcode + "' where bcode='" + SelectedBarcode + "'");
                    _Dbtask.ExecuteNonQuery("update tblreceiptdetails set batchid ='" + NewBarcode + "' where batchid='" + SelectedBarcode + "'");
                    _Dbtask.ExecuteNonQuery("update tblissuedetails set batchid ='" + NewBarcode + "' where batchid='" + SelectedBarcode + "'");
                    _Dbtask.ExecuteNonQuery("update tblinventory set batchcode ='" + NewBarcode + "' where batchcode='" + SelectedBarcode + "'");

                    MessageBox.Show("Barcode Name Updated Successfully", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ivalid Update Select Fields", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
            }
        }
        public void SaveSettings()
        {
            /*For Default Printer*/
            //CommonClass.temp = comprint.SelectedIndex.ToString();
            //// CommonClass._Paramlist.UpdateParamlist("SPrintSelect", "1", CommonClass.temp);

            //CommonClass._Dbtask.SetPrinterSelectbcode(CommonClass.temp);
            CommonClass.temp = comprint.Text;
            CommonClass._Dbtask.SetPrinterNamebcode(CommonClass.temp);

        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            UpdateBarcodeRates();
        }
        public void SETPRICECODE()
        {
            string Pricecode="";
            string rate= "";
            rate = _Dbtask.znllString(txtsrate.Text);
             


        }
        private void cmdprint_Click_1(object sender, EventArgs e)
                {
             FrmbarcodePrinting.prnt = true;

             CommonClass._Gen.FillActivePrinter(comprint);
             PrintBarcode();
             // pnlprintsettings.Visible = false;
             Clearing();
             
            //CommonClass._Gen.FillActivePrinter(comprint);
           
           // pnlprintsettings.Visible = true;

             FrmbarcodePrinting.prnt = false;
         
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmbarcodePrinting_KeyDown(object sender, KeyEventArgs e)
            {

           
            
            if (e.KeyValue == 27)
            {
                this.Close();
            }
            if (e.KeyValue == 123)
            {

                if (search == true)
                {
                    search = false;
                    txtbarcode.BackColor = Color.White;
                    
                }
                else
                {

                    search = true;
                    txtbarcode.BackColor = Color.Gold;
                }
               
            }


        }

        private void combatchcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string seclang = "";
                string Bcode = combatchcode.Text;
                 Itemid = _Batch.GetSpecificFieldofBatchBaseonitemid(Bcode);
                string ItemName = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                string ItemCode = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Itemid + "'");
             seclang =_Dbtask.znllString( CommonClass._Itemmaster.SpecificField(Itemid, "llang"));
                IsEnter = false;
                txtitemname.Text = ItemName;
                txtitemcode.Text = ItemCode;
                //txtseclang.Text = seclang;
                txtitemname.Tag = Itemid;
                SelindexChange(Bcode, txtitemname.Tag.ToString());
            }
        }

        private void txtitemname_Enter(object sender, EventArgs e)
        {
            IsEnter = true;
        }
        public void DeleteBarcode()
        {
            DialogResult Result = MessageBox.Show("DELETE SELECTED BARCODE " + txtbarcode.Text + "", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result.ToString() == "Yes")
            {
                SelectedBarcode = txtbarcode.Text;
                if (txtbarcode.Text != "" && txtbarcode.Text != null)
                {
                    CommonClass.DBtemp = Convert.ToDouble(CommonClass._Inventory.GetStock(" where batchcode='" + SelectedBarcode + "'"));
                    if (CommonClass.DBtemp == 0)
                    {
                        _Dbtask.ExecuteNonQuery("delete from tblbatch where bcode='" + SelectedBarcode + "'");
                        MessageBox.Show("Deleted Successfully", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("It Can't be Delete,Transaction already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void cmddeletebarcode_Click(object sender, EventArgs e)
        {
            DeleteBarcode();
        }

        private void cmdupdatebarcode_Click(object sender, EventArgs e)
        {
            UpdateBarcodeName();
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, true);
        }

        private void FrmbarcodePrinting_Load(object sender, EventArgs e)
            {
           
            //ChangeLanguage();


                Fufocusing();
                Clearing();
                START();
                chkmanexdate.Checked = true;

                CommonClass._Nextg.FormIcon(this);
            //CommonClass._Nextg.FormIcon();
        }
        public void Fufocusing()
        {
            if (_Dbtask.znllString(  _Settings.ReturnStatus("103")) == "1")
            {
                combatchcode.Focus();
                combatchcode.Select();
            }
        }

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                //CommonClass._Language.GridHeaderConversion(gridmain);
                //CommonClass._Language.PanelBasedConversion(pnltotal);
                //CommonClass._Language.PanelBasedConversion(Pnlbottom);

                CommonClass._Language.GroupBoxConvertion(grpbarcodesettings);
            }
        }

        private void Cmdshow_Click(object sender, EventArgs e)
        {
            string Bcode = txtbarcode.Text;
            SelindexChangeWithExpiry(Bcode, txtitemname.Tag.ToString(),Dtexdate.Value);
        }
        public void START()
        {
            ClsInGrid.stocksetting = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("219"));
            ClsInGrid.WGmitemcode = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemcode"));

            ClsInGrid.WGmitemname = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemname"));
            ClsInGrid.WGmsrate = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmsrate"));
            ClsInGrid.WGmmrp = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmmrp"));
            ClsInGrid.WGmrack = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmrack"));
            ClsInGrid.WGmprate = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmprate"));
            ClsInGrid.WGmbcode = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmbcode"));
        }
        public void Clearing()
        {

            Frmpurchase.Purprint = false;

            search = false;
            
            prnt = true;
            //txtitemcode.Text = "";
            //txtitemcode.Tag = "";
            //txtitemname.Text = "";
            //txtitemname.Tag = "";
            CommonClass._Gen.FillActivePrinter(comprint);

            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("203")) == "1")
            {
                pnlmanexdate.Visible = true;
            }
            else
            {
                pnlmanexdate.Visible = false;
               
            }

            Dtexdate.Value=System.DateTime.Today;

            dtmanfactdate.Value = System.DateTime.Today;
            //combatchcode.SelectedIndex = "";
        }
        private void cmdadprint_Click(object sender, EventArgs e)
        {
            
            CommonClass._Gen.FillActivePrinter(comprint);
            PrintBarcode();
           // pnlprintsettings.Visible = false;
            Clearing();
            
        }

        private void comprint_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtitemcode_TextChanged(object sender, EventArgs e)
        {
            Temp =_Dbtask.znllString( txtitemcode.Text);
            if (IsEnter == true)
            {
                ProductGridShow(" where itemCode Like N'%" + Temp + "%' OR itemName Like N'%" + Temp + "%' OR llang Like N'%" + Temp + "%'");
            }
        }

        private void uscGridshow1_Load(object sender, EventArgs e)
        {

        }

        private void txtitemcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            RowClick(txtitemname.Text, e.KeyValue);
        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
            Temp = txtbarcode.Text;

            if (IsEnter == true && search == true)
            {
                ProductGridShow(" where itemCode Like N'%" + Temp + "%' OR itemName Like N'%" + Temp + "%' OR llang Like N'%" + Temp + "%'  or tblbatch.bcode Like N'%" + Temp + "%'");
            }
        }

        private void txtbarcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


            if (e.KeyValue == 13)
            {
                //txtbarcode.Text=

                if (uscGridshow1.Visible == true && e.KeyValue == 13&&search==true)
                {
                    SeleRow = uscGridshow1.GridProductShow.SelectedRows[0].Index;
                    Itemid = uscGridshow1.GridProductShow.Rows[SeleRow].Cells["itemid"].Value.ToString();
                    txtbarcode.Text = _Dbtask.znllString(uscGridshow1.GridProductShow.Rows[SeleRow].Cells["bcode"].Value);

                }
                else
                        {

                            if (CommonClass._Batch.SameNamealreadyexistNew(_Dbtask.znllString(txtbarcode.Text)) == true)
                            {

                                txtbarcode.Text = _Dbtask.znllString(txtbarcode.Text);
                                Itemid = _Dbtask.znllString(CommonClass._Batch.GetSpecificFieldByBarcode("itemid", _Dbtask.znllString(txtbarcode.Text)));
                            }
                            else
                            {
                                txtbarcode.Text = "";
                                MessageBox.Show("BARCODE not existing");
                                Frmquickadditems _Form = new Frmquickadditems();
                                _Form.ShowDialog();
                            }
                }
               
               
                ItemName = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                ItemCode = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Itemid + "'");

                txtitemname.Text = ItemName;
                txtitemcode.Text = ItemCode;
                txtitemname.Tag = Itemid;
    
                if (_Dbtask.znllString(txtbarcode.Text) != "")
                {
                    double MRP = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select mrp from tblbatch where bcode='" + _Dbtask.znllString(txtbarcode.Text) + "' and itemid='" + Itemid + "'"));
                    double SRate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select srate from tblbatch where bcode='" + _Dbtask.znllString(txtbarcode.Text) + "' and itemid='" + Itemid + "'"));
                    double PRate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select prate from tblbatch where bcode='" + _Dbtask.znllString(txtbarcode.Text) + "' and itemid='" + Itemid + "'"));



                    txtmrp.Text = _Dbtask.SetintoDecimalpoint(MRP);
                    txtsrate.Text = _Dbtask.SetintoDecimalpoint(SRate);
                    txtprate.Text = _Dbtask.SetintoDecimalpoint(PRate);
                }

                txtqty.Text = _Dbtask.znllString("1");
                uscGridshow1.Visible = false;
                IsEnter = false;
                //ListBarcode(Itemid);
            }
            else
            {
                if (search == true&&uscGridshow1.Visible == true)
                {
                RowClick(txtbarcode.Text, e.KeyValue);
                }
            }
        }

        private void txtitemcode_Enter(object sender, EventArgs e)
        {
            IsEnter = true;
        }

        private void txtbarcode_Enter(object sender, EventArgs e)
        {
            IsEnter = true;
        }

        private void Chksearch_CheckedChanged(object sender, EventArgs e)
        {
            if (Chksearch.Checked==true)
            {
                search = true;
                txtbarcode.BackColor = Color.Gold;
            }
            else
            {
                

                search = false;
                txtbarcode.BackColor = Color.White;
                    
            }
        }

        private void chkmanexdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmanexdate.Checked == true)
            {
                _Dbtask.ExecuteNonQuery("UPDATE TBLMNUSETTINGS SET STATUS='1' where menuid='203' ");
                pnlmanexdate.Visible = true;
            
            }
            else
            {
                _Dbtask.ExecuteNonQuery("UPDATE TBLMNUSETTINGS SET STATUS='-1' where menuid='203' ");
                pnlmanexdate.Visible = false;
            
            }
        }



    }
}
