using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Frmitems : Form
    {
        public Frmitems()
        {
            InitializeComponent();
        }

        //MemoryStream ms;
        byte[] photo_aray;

        ClsItemMaster _Itemmaster = new ClsItemMaster();
        ClsInventory _Inventory = new ClsInventory();
        ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        ClsproductRate _ProductRate = new ClsproductRate();
        ClsProductUnits _ProductUnit = new ClsProductUnits();
        ClsReceiptDetails _ReceiptDetails = new ClsReceiptDetails();
        ClsManufacturer _Manufacturer = new ClsManufacturer();
        clsitemCategory _ItemCategory = new clsitemCategory();
        ClsMultiUnits _MultiUnits = new ClsMultiUnits();
        ClsMultiRates _MultiRates = new ClsMultiRates();
        NextGFuntion _Nextg = new NextGFuntion();
        Generalfunction _Gen = new Generalfunction();
        ClSSlabMaster _SlabMaster =new ClSSlabMaster();
        Clssizes _Sizes = new Clssizes();
        Clssizedetails _Sizedetail = new Clssizedetails();
        DBTask _Dbtask = new DBTask();
        Clssettings _Settings = new Clssettings();

        public static bool Isinotherwindow ;
        public static bool Supplierwiseitems;
        public static bool EditMode;
        public static bool SUnit;
        public static bool Smrate;
        public static string Itemid ;

        public static bool CloseAfterSave=false;

       // public string Itemid;
        double Convrt;
        public int Count;
        public string ControleName;
        public int ItemStatus=1;
        public double Cooly = 0;
        public double OpeningStockAmount;
        public double OpeningStockRate;
        public double OpeningStockNetAmount;
        public int selectedRow;
        int Incs=1;
        int IncP=-1;
        public bool SearchingMode = false;
        public bool SWmachine;
        bool Notexit=true;
      //  public bool EditMode;
       // public bool Isinotherwindow = false;
        public bool Ssizes;
        public bool Sbatch;


        DataSet Ds = new DataSet();
        DataSet Ds1 = new DataSet();

        /*Settings*/

        public bool STax = false;

        //for language Conversion
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
                CommonClass._Language.TabBasedConversion(Tambase);
                CommonClass._Language.TabBasedConversion(Tabunit);
                CommonClass._Language.GroupBoxConvertion(Grpopeningstock);
                //CommonClass._Language.PanelBasedConversion(pnlcommon);
                //CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.PanelBasedConversion(panel5);
                //CommonClass._Language.PanelBasedConversion(PnlPrintOptions);
            }
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)
            {
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                    if (this.ActiveControl.Name != "txtvno")
                    {
                        if (this.ActiveControl.Name != "GrpOpeningStock")
                        {
                            if (this.ActiveControl.Name != "GrpUnit")
                            {
                                if (this.ActiveControl.Name != "GridProductList")
                              {
                                  if (this.ActiveControl.Name != "Gridmain")
                            {
                                  SendKeys.Send("{Tab}");
                                return true;
                               }
                            }
                            }
                        }
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void Frmitems_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar==27&&Notexit==true)

            FormClose();
        }

        private void FormClose()
        {
            this.Close();
        }

        public void ClearTemp()
        {
            ItemCode();
            TxtPrate.textBox1.Text = "0.00";
            TxtPrate.textBox1.Text = "0.00";
            TxtSrate.textBox1.Text = "0.00";
            TxtMRP.textBox1.Text = "0.00";
            TxtOpQty.textBox1.Text = "0.00";
            Txtreorder.textBox1.Text = "0.00";
            txtrack.textBox1.Text = "";
            TxtAgentCommision.textBox1.Text = "0.00";
            TxtDiscription.textBox1.Text="";
            TxtItemname.textBox1.Text = "";
            TxtItemCode.textBox1.Text = "";
            GridProductList.Visible = false;
        }
        private void CmdOk_Click(object sender, EventArgs e)
        {
            Main();
        }
 
        private bool Main()
        {
           
            if (ValidationFu())
            {
                try
                {
                    if(EditMode==false)
                    ItemCode();

                    if (EditMode ==true )
                    {
                        DeleteItems();
                    }
                    NextgInitialize();
                    Insert();
                    ClearTemp();
                    
                    FillCombo();
                    TxtItemname.textBox1.Focus();
                  
                   
                    if (CloseAfterSave == true)
                    {
                        this.Close();
                    }
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
        public void DeleteItems()
        {
            Itemid=TxtItemId.Text;
            _Dbtask.ExecuteNonQuery("select * from tblunitsrates where itemid in (" + Itemid + ")");
            _Dbtask.ExecuteNonQuery("DELETE FROM tblunitsrates WHERE ITEMID in (" + Itemid + ")");
        _Dbtask.ExecuteNonQuery("Delete from tblitemmaster where itemid in ("+Itemid+")");

        if (Sbatch == false)
        {
            _Dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where reptcode='" + TxtVno.Tag + "' and recpttype='OS'");
            _Dbtask.ExecuteNonQuery("delete from tblinventory where os !=0 and pcode='" + Itemid + "'");
            _Dbtask.ExecuteNonQuery("delete from tblreceiptdetails where  vtype='OS' and pcode='" + Itemid + "'");

        }

        _Dbtask.ExecuteNonQuery("delete from tblsizesdetail where itemsizename='" + TxtItemname.textBox1.Text + "'");

        }

        public void SizeFillingInEditMode()
        {
            if (Ssizes == true)
            {
                string ItemSizelessName = TxtItemname.textBox1.Tag.ToString();
                TxtItemname.textBox1.Text = ItemSizelessName;
                TxtItemCode.textBox1.Text = ItemSizelessName;
                string ItemName;
                string SizeName;
                string Itemid;
                TxtItemId.Text = CommonClass._SelectReport.Showindataset("select Itemid from tblitemmaster where sizelessname='" + ItemSizelessName + "'");
                CommonClass.Ds3 = _Dbtask.ExecuteQuery("select * from tblitemmaster where sizelessname='" + ItemSizelessName + "'");

                for (int k = 0; k < CommonClass.Ds3.Tables[0].Rows.Count; k++)
                {
                    ItemName = CommonClass.Ds3.Tables[0].Rows[k]["itemname"].ToString();
                    Itemid = CommonClass.Ds3.Tables[0].Rows[k]["itemid"].ToString();
                    SizeName = ItemName.Replace(ItemSizelessName, "");
                    SizeName = SizeName.Substring(1, SizeName.Length - 1);
                    for (int kk = 0; kk < Gridsizelist.Rows.Count; kk++)
                    {
                        if (Gridsizelist.Rows[kk].Cells["clnsizes"].Value != null)
                        {
                            string GridSizeName = Gridsizelist.Rows[kk].Cells["clnsizes"].Value.ToString();
                            if (GridSizeName == SizeName)
                            {
                                CommonClass.Ds4 = _Dbtask.ExecuteQuery("select * from tblinventory where pcode='" + Itemid + "'");
                                if (CommonClass.Ds4.Tables[0].Rows.Count > 0)
                                {
                                    Gridsizelist.Rows[kk].ReadOnly = true;
                                }
                                Gridsizelist.Rows[kk].Cells["clnstatus"].Value = 1;
                                Gridsizelist.Rows[kk].Cells["clnstatus"].Tag = Itemid;
                            }
                        }
                    }
                }
            }
        }
        public void UnitAmountCalc()
        {
            try
            {
                Convrt = _Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", comunit.SelectedValue.ToString()));
            }
            catch
            {
            }
        }
        public void NextgInitialize()
        {

            /*For Checking Manufacturer is Exsting */
            if (Txtmanufacturer.textBox1.Tag== null)
            {
                Txtmanufacturer.textBox1.Tag= "";
            }

            //if (Txtmanufacturer.textBox1.Text!= "")
            //{
            //    string temp1 = _Dbtask.ExecuteScalar("select * from tblmanufacturer where mname='" + Txtmanufacturer.textBox1.Text+ "'");

            //    if (temp1 == "")
            //    {
            //        _ItemCategory.IdCategory();
            //        _ItemCategory.CategoryNameStr = Txtitemcategory.textBox1.Text;
            //        _ItemCategory.InsertItemCategory();
            //        Txtitemcategory.textBox1.Tag = _ItemCategory.CategoryIdLng;
            //    }
            //}
            
            if ( Txtmanufacturer.textBox1.Tag.ToString() == "" && Txtmanufacturer.textBox1.Text!= ""&&Txtmanufacturer.textBox1.Text!="None")
            {
                
                _Manufacturer.IdManufacturer();
                _Manufacturer.Mname = Txtmanufacturer.textBox1.Text;
                _Manufacturer.InsertManufacturer();
                Txtmanufacturer.textBox1.Tag= _Manufacturer.Mid;
               // _Manufacturer.FillCombo(ComManufacturer);
              //  ComManufacturer.SelectedValue = _Manufacturer.Mid;
            }

            /*For Checking Group Name Is Exsting */
            if (Txtitemcategory.textBox1.Tag == null)
            {
                Txtitemcategory.textBox1.Tag = "";
            }
           
            

            //if (Txtitemcategory.textBox1.Tag.ToString() == "" && Txtitemcategory.textBox1.Text != "" && Txtitemcategory.textBox1.Text != "None")
            //{

            //    string temp = _Dbtask.ExecuteScalar("select categoryid from tblitemcategory where category='" + Txtitemcategory.textBox1.Text + "'");

            //    if (temp == "")
            //    {
            //        _ItemCategory.IdCategory();
            //        _ItemCategory.CategoryNameStr = Txtitemcategory.textBox1.Text;
            //        _ItemCategory.InsertItemCategory();
            //        Txtitemcategory.textBox1.Tag = _ItemCategory.CategoryIdLng;
            //    }
            //    else
            //    {
            //        Txtitemcategory.textBox1.Tag = temp;
            //    }
            //}

            if (Txtitemcategory.textBox1.Tag.ToString() == "")
            {
                Txtitemcategory.textBox1.Tag = 0;
            }
            if (Txtmanufacturer.textBox1.Tag.ToString() == "")
            {
                Txtmanufacturer.textBox1.Tag= 0;
            }
            /*For ItemMaster */
           

              
               // _Itemmaster.ItemIdLng = _Itemmaster.ItemIdLng;
            long Itemid=0;
            if(Ssizes==false)
            {
                 Itemid =Convert.ToInt64(TxtItemId.Text);
            }
               // long Itemid = _Itemmaster.ItemIdLng; 
                string SecUnit = comsecunit.Text;
                double Unitamount1 = _Dbtask.znullDouble(txtwhereunit.textBox1.Text);
                double UnitAmunt2 = _Dbtask.znullDouble(txtwheresecunit.textBox1.Text);
                string Itemcode = TxtItemCode.textBox1.Text;
                string Itemname = TxtItemname.textBox1.Text;
                long Categoryid = Convert.ToInt64(Txtitemcategory.textBox1.Tag);
                string Discription = TxtDiscription.textBox1.Text;
                double MRP = _Dbtask.znullDouble(TxtMRP.textBox1.Text);
                double Srate = _Dbtask.znullDouble(TxtSrate.textBox1.Text);
                double PRate = _Dbtask.znullDouble(TxtPrate.textBox1.Text);
                long Manfaccode = Convert.ToInt64(Txtmanufacturer.textBox1.Tag);
                double Agentcommision = _Dbtask.znullDouble(TxtAgentCommision.textBox1.Text);
                double Minstock = _Dbtask.znullDouble(TxtMinstock.Text);
                double Reorder = _Dbtask.znullDouble(Txtreorder.textBox1.Text);
                double Maximum = _Dbtask.znullDouble(TxtMaximum.Text);
                string Unit = comunit.Text;
                string Rack = txtrack.textBox1.Text;
                double VAT = _Dbtask.znullDouble(Txtvat.textBox1.Text);
                double CST = _Dbtask.znullDouble(TxtCst.textBox1.Text);
                double Purtax = _Dbtask.znullDouble(TxtPurchaseTax.textBox1.Text);
                string Itemclass = Comitemclass.Text;
                string SizelessName = _Dbtask.znllString(TxtItemname.textBox1.Tag);
                string PLU = txtplu.textBox1.Text;
                long Lid =Convert.ToInt64(comsupplier.SelectedValue);
                _Itemmaster.ItemIdLng = Itemid;

                _Itemmaster.SecndUnit = SecUnit;
                _Itemmaster.UnitAmunt1 = Unitamount1;
                _Itemmaster.UnitAmunt2 = UnitAmunt2;
                _Itemmaster.ItemCodeStr = Itemcode;
                _Itemmaster.ItemNameStr = Itemname;
                _Itemmaster.ItemnoteStr = "";
                _Itemmaster.CategoryIdLng = Categoryid;
                _Itemmaster.DescriptionStr = Discription;
                _Itemmaster.MRPDb = MRP;
                _Itemmaster.SRateDb = Srate;
                _Itemmaster.PRateDb = PRate;
                _Itemmaster.ManufacturerLng = Manfaccode;
                _Itemmaster.StatusInt = ItemStatus;
                _Itemmaster.AgentCommisionDb = Agentcommision;
                _Itemmaster.CoolyDb = Convert.ToDouble(Cooly);
                _Itemmaster.MinStockDb = Minstock;
                _Itemmaster.ReorderStockDb = Reorder;
                _Itemmaster.MaximumDb = Maximum;
                _Itemmaster.TaxSlabIdLng = Convert.ToInt64(0);
                _Itemmaster.Unit = Unit;
                _Itemmaster.VAT = VAT;
                _Itemmaster.CST = CST;
                _Itemmaster.Purtax = Purtax;
                _Itemmaster.Incp = IncP;
                _Itemmaster.Incs = Incs;
                _Itemmaster.Rack = txtrack.textBox1.Text;
                _Itemmaster.ItemClass = Itemclass;
                _Itemmaster.Balance = 0;
                _Itemmaster.PLU =PLU;
                _Itemmaster.Sizelessname = SizelessName;
                _Itemmaster.Ledid = Lid;
                _Itemmaster.Localaungage = txtlocallaungage.textBox1.Text;
                double OPQty = _Dbtask.znullDouble(TxtOpQty.textBox1.Text);

                //Image img = Picitemimage.BackgroundImage;
                //byte[] arr;
                //ImageConverter converter = new ImageConverter();
                //arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                //_Dbtask.ExecuteNonQuery("INSERT INTO ImagesTable (Image) VALUES('" + arr + "')");

                    if(Smrate==true)
                    {
                    CommonClass._Unitsrates.Uid = Convert.ToInt64(comunit.SelectedValue);
                    CommonClass._Unitsrates.Itemid = Convert.ToInt64(_Itemmaster.ItemIdLng);
                    CommonClass._Unitsrates.Srate = _Dbtask.znullDouble(TxtSrate.textBox1.Text);
                    CommonClass._Unitsrates.Prate = _Dbtask.znullDouble(TxtPrate.textBox1.Text);
                    CommonClass._Unitsrates.Mrp = _Dbtask.znullDouble(TxtMRP.textBox1.Text);
                    CommonClass._Unitsrates.WRate = _Dbtask.znullDouble(Txtwrate.textBox1.Text);
                    CommonClass._Unitsrates.InsertUnitsrates();
                    }
                if (Comunit1.SelectedValue != null)
                {
                    CommonClass._Unitsrates.Uid = Convert.ToInt64(Comunit1.SelectedValue);
                    CommonClass._Unitsrates.Itemid = Convert.ToInt64(_Itemmaster.ItemIdLng);
                    CommonClass._Unitsrates.Srate = _Dbtask.znullDouble(Txtsrate1.textBox1.Text);
                    CommonClass._Unitsrates.Prate = _Dbtask.znullDouble(txtprate1.textBox1.Text);
                    CommonClass._Unitsrates.Mrp = _Dbtask.znullDouble(Txtmrp1.textBox1.Text);
                    CommonClass._Unitsrates.WRate = _Dbtask.znullDouble(Txtwrate1.textBox1.Text);
                    CommonClass._Unitsrates.InsertUnitsrates();
                }
                if (OPQty > 0)
                {
                    UnitAmountCalc();
                    OPQty = OPQty * Convrt;
                    UnitAmountCalc();
                    _Itemmaster.Balance = Convert.ToInt64(TxtVno.Tag.ToString());
                    _Inventory.Vcode = TxtVno.Tag.ToString();
                    _Inventory.DCodeStr = "0";
                    _Inventory.InvDateDt = DateTime.Now;
                    _Inventory.PcodeStr = Convert.ToString(_Itemmaster.ItemIdLng);
                    _Inventory.Os = OPQty;

                    _Inventory.Batchcode = "";

                    _ReceiptDetails.RcptCodeLng = Convert.ToInt64(TxtVno.Tag);
                    _ReceiptDetails.SlNoLng = 1;
                    _ReceiptDetails.PCodeStr = Convert.ToString(_Itemmaster.ItemIdLng);
                    _ReceiptDetails.UnitIdLng = 0;
                    _ReceiptDetails.MultiRateIdLng = 0;
                    _ReceiptDetails.QtyDb = OPQty;
                    _ReceiptDetails.Vtype = "OS";



                    _TransactionReceipt.RcptCodeLng = Convert.ToInt64(TxtVno.Tag);
                    // _TransactionReceipt.IdOpeningStockFu();
                    _TransactionReceipt.VNoStr = TxtVno.Text;
                    _TransactionReceipt.RCptTypeStr = "OS";
                    _TransactionReceipt.DcodeStr = "0";
                    _TransactionReceipt.RcptDateDt = DateTime.Now;
                    _TransactionReceipt.Rcptdatebilling = DateTime.Now;
                    // _TransactionReceipt.AMTDb = OPQty * PRate;
                    _TransactionReceipt.RemarkStr = "Opening Stock";
                    _TransactionReceipt.RefNo = "1001";
                    _TransactionReceipt.LedCodeCr = Convert.ToString(0);
                    _TransactionReceipt.LedCodeDr = Convert.ToString(0);
                    _TransactionReceipt.EmpId = Convert.ToString(0);



                }  
                
                }
                /*ForOpening Stock*/


        private bool ValidationFu()
        {
            
            if (TxtItemname.textBox1.Text.Replace(" ","")=="")
            {
                MessageBox.Show("Enter the Product Name", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtItemname.textBox1.Focus();
                return false;               
            }

            if (TxtItemCode.textBox1.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Enter the Product Code", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtItemCode.textBox1.Focus();
                return false;
            }
           
            
                Ds = _Dbtask.ExecuteQuery("select itemcode from tblitemmaster where itemcode=N'" + TxtItemCode.textBox1.Text + "'");
                if (EditMode == false && Ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Item Code Is Already Exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtItemCode.textBox1.Focus();
                    return false;
                }
               

                Ds = _Dbtask.ExecuteQuery("select plu from tblitemmaster where plu='" + txtplu.textBox1.Text + "'");
                if (EditMode == false && Ds.Tables[0].Rows.Count > 0&&SWmachine==true)
                {
                    MessageBox.Show("PLU Code Already Exstist Change PLU", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtplu.textBox1.Focus();
                    return false;
                }
                else if (EditMode == true && Ds.Tables[0].Rows.Count > 1&&SWmachine==true)
                {
                    MessageBox.Show("PLU Code Already Exstist Change PLU", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtplu.textBox1.Focus();
                    return false;
                }

            return true;
        }
       
       
        public void Clear()
        {
            
            CloseAfterSave = false;
            EditMode = false;
            Isinotherwindow = false;
            _Nextg.ClearControles(this);
            _Nextg.SetControlesBehave(this);
            SetGridColumn();
            ListSizes();
            ItemCode();
            FillCombo();
            TxtItemname.textBox1.Focus();
            txtstatus.textBox1.Text = "Yes";
            txttaxsaleincluseive.textBox1.Text = "Yes";
            txttaxpurchaseincluseive.textBox1.Text = "No";
            Comitemclass.Text = "Stock Item";
            Gridmain.Visible = false;
            TxtOpQty.textBox1.Text = _Dbtask.SetintoDecimalpointStock(0);
           
            _Nextg.ClearUsercontroles(this);
           // TxtUnit.textBox1.Text = "PC";
            txttaxsaleincluseive.textBox1.Text = "Yes";
            txttaxpurchaseincluseive.textBox1.Text = "No";
            txtstatus.textBox1.Text = "Yes";
            TxtItemname.Select();
        }
        public void SetGridColumn()
        {
            GetMenusettings();
            if (Sbatch == true)
            {
                TxtOpQty.textBox1.Enabled = false;
            }
            if (SWmachine == false)
            {
                lblplu.Visible = false;
                lbldotplu.Visible = false;
                txtplu.Visible = false;
            }
            if (Supplierwiseitems == false)
            {
                lblsupplierwise.Visible = false;
                lblsupplierwisedot.Visible = false;
                comsupplier.Visible = false;
            }
            if (STax == false)
            {
                
                LblPurtaxper.Visible = false;
                lbltax.Visible = false;
                lblcst.Visible = false;
                lbltax.Visible = false;
                lblvatper.Visible = false;
                LblPurtaxper.Visible = false;
                Txtvat.Visible = false;
                TxtCst.Visible = false;
                TxtPurchaseTax.Visible = false;

                LblPurtaxper.Visible = false;
                lbltaxsale.Visible = false;
                txttaxpurchaseincluseive.Visible = false;
                txttaxsaleincluseive.Visible = false;
                lbltaxdot1.Visible = false;
                lbltaxdot2.Visible = false;
                lbltaxdot3.Visible = false;
                lbltaxdot4.Visible = false;
                lbltaxdot5.Visible = false;
                lbltaxdot6.Visible = false;
                lbltaxpurchase.Visible = false;
            }
            if (Ssizes == false)
            {
                this.Size = new System.Drawing.Size(916, 452);
            }
           
            //if (SUnit == false)
            //{
                pnlunits.Visible = false;
        
        }
        public void GetMenusettings()
        {
            /*TAX*/
            string temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=14");
            if (temp == "1")
            {
                STax = true;
            }
           /*For Sizes*/
             temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=123");
            if (temp == "1")
            {
                Ssizes = true;
            }
            /*For Batch*/
            if (_Settings.FunSettings1("Batch") == true)
            {
                Sbatch = true;
            }
             temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=144");
            if (temp == "1")
            {
                SWmachine= true;
            }
            /*Supplier wise items*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=149");
            if (temp == "1")
            {
                Supplierwiseitems = true;
            }

            /*Multi Unit */
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=12 ");
            if (temp == "1")
            {
                SUnit = true;
            }

            /*Multi Rate*/

            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=11");
            if (temp == "1")
            {
                Smrate = true;
            }

        }
        public void ItemCode()
        {
            //_Itemmaster.IdItemName();
            //TxtItemId.Text =Convert.ToString(_Itemmaster.ItemIdLng);
            _Itemmaster.IdItemName();
            TxtItemId.Text = Convert.ToString(_Itemmaster.ItemIdLng);

            _TransactionReceipt.IdOpeningStockFu();
            TxtVno.Tag = Convert.ToString(_TransactionReceipt.RcptCodeLng);
            TxtVno.Text = Convert.ToString(_TransactionReceipt.RcptCodeLng);
        }
        
        public void GetItemid(int Rowindex)
        {
            string Tempitemid;
            if (_Dbtask.znlldoubletoobject(Gridsizelist.Rows[Rowindex].Cells["clnstatus"].Tag) == 0)
            {
                _Itemmaster.IdItemName();
                //_Itemmaster.ItemIdLng = _Itemmaster.ItemIdLng + 1;
            }
            else
            {
                _Itemmaster.ItemIdLng = Convert.ToInt64(Gridsizelist.Rows[Rowindex].Cells["clnstatus"].Tag);
            }
        }

        public void Insert()
        {
                if (Ssizes == true && Gridsizelist.Rows.Count > 1)
                {
                    for (int i = 0; i < Gridsizelist.Rows.Count - 1; i++)
                    {
                        object Value = Gridsizelist.Rows[i].Cells["clnstatus"].Value;
                        if (Value != null)
                        {
                            if (Ssizes == false)
                            {
                                _Itemmaster.ItemIdLng = Convert.ToInt64(TxtItemId.Text);
                            }
                            string SizeName = Gridsizelist.Rows[i].Cells["clnsizes"].Value.ToString();
                            GetItemid(i);
                            _Itemmaster.ItemCodeStr = TxtItemCode.textBox1.Text + " " + SizeName;
                            _Itemmaster.ItemNameStr = TxtItemname.textBox1.Text + " " + SizeName;
                            _Itemmaster.Sizelessname = TxtItemname.textBox1.Text;
                            _Itemmaster.InsertItems();
                            OpeningBalanceInsert();

                            /*For Size Detail Insert*/
                            _Sizedetail.ItemSizename = TxtItemname.textBox1.Text;
                            _Sizedetail.Sname = SizeName;
                            _Sizedetail.InsertSize();
                        }
                    }
                }
            
            else
            {
            _Itemmaster.InsertItems();
            OpeningBalanceInsert();
            }  
       }
        public void OpeningBalanceInsert()
        {
            if (_Dbtask.znullDouble(TxtOpQty.textBox1.Text) > 0) /*For Opening Stock */
            {
                _Inventory.InsertInventory();
                _TransactionReceipt.InsertTransactionReceipt();
                _ReceiptDetails.InsertReceiptDetails();
            }
        }
        public void FillCombo()
        {
            /*Manfacturer*/
            //_Manufacturer.FillCombo(ComManufacturer);

            /*ItemMaster*/
           // _ItemCategory.FillCombo(ComItemGroup);
            /*Base Unit*/
           // _MultiUnits.FillComboMainUnit(ComBaseUnit);

            /* Tax  */
          //  _SlabMaster.FillCombo(ComSlab);
            _Dbtask.fillDatainCombowithQuery(comunit, "Id", "Name", "tblUnitcreation", "select * from tblUnitcreation order by Name");
            _Dbtask.fillDatainCombowithQuery(comsecunit, "Id", "Name", "tblUnitcreation", "select * from tblUnitcreation order by Name");
            _Dbtask.fillDatainCombowithQuery(Comunit1, "Id", "Name", "tblUnitcreation", "select * from tblUnitcreation order by Name");
            _Dbtask.fillDatainCombowithQuery(Comunit2, "Id", "Name", "tblUnitcreation", "select * from tblUnitcreation order by Name");
            _Dbtask.fillDatainCombowithQuery(Comunit3, "Id", "Name", "tblUnitcreation", "select * from tblUnitcreation order by Name");
            _Dbtask.fillDatainCombowithQuery(Comunit4, "Id", "Name", "tblUnitcreation", "select * from tblUnitcreation order by Name");


           // Comitemclass.SelectedIndex = 0;

            if (Supplierwiseitems == true)
                CommonClass._Ledger.FillComboSupplier(comsupplier);
        }
       

        private void OpUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabbasic_Click(object sender, EventArgs e)
        {

        }
        public void ListSizes()
        {

            //Count = Gridsizelist.Rows.Add(1);
            //DataTable dt = new DataTable();
            //dt.Columns.Add("isChecked", typeof(bool));
            //dt.Columns.Add("value");
            if (Ssizes == true)
            {
                Ds = _Sizes.ShowSizes();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    string Sid = Ds.Tables[0].Rows[i]["sid"].ToString();
                    string Sname = Ds.Tables[0].Rows[i]["sname"].ToString();
                    Count = Gridsizelist.Rows.Add(1);
                    
                    Gridsizelist.Rows[Count].Cells["clnsizes"].Tag = Sid;
                    Gridsizelist.Rows[Count].Cells["clnsizes"].Value = Sname;
                }
            }
        }
       
        private void Frmitems_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            _Nextg.ClearControles(this);
            _Nextg.FormStylesett(this);
          
            if (Isinotherwindow == false)
            {
                Clear();
            }
            else
            {
                FillCombo();
                SetGridColumn();
                ListSizes();
                Retrive();
            }


            CommonClass._Nextg.FormIcon(this);

        }



     
       

        private void GridMultiRates_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
           
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender,e,true);
            _Gen.avoidnullDecimal(TxtMinstock.Text);

        }

        private void TxtSrate_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtMRP.textBox1.Text = TxtSrate.textBox1.Text;
            }
        }
        public void CategoryShow()
        {
            if (SearchingMode == true)
            {
                Ds = _ItemCategory.Showitemcategory("where Category like '%" + Txtitemcategory.textBox1.Text + "%'");
                Gridmain.Rows.Clear();
                Gridmain.Visible = true;
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Gridmain.Rows.Add(1);
                    Gridmain.Rows[i].Cells["clnname"].Value = Ds.Tables[0].Rows[i]["Category"];
                    Gridmain.Rows[i].Cells["clnname"].Tag = Ds.Tables[0].Rows[i]["Categoryid"];
                }
                this.Gridmain.Location = new System.Drawing.Point(130, 96);
            }
        }
      
        public void ShowClass()
        {
            if (SearchingMode == true)
            {
                Gridmain.Rows.Clear();
                Gridmain.Visible = true;
                Gridmain.Rows.Add(3);
                Gridmain.Rows[0].Cells["clnname"].Value = "Stock Item";
                Gridmain.Rows[1].Cells["clnname"].Value = "Services";
                Gridmain.Rows[2].Cells["clnname"].Value = "Finished Product";
                this.Gridmain.Location = new System.Drawing.Point(130, 172);
            }
        }
       

        private void Frmitems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

       

       


       
        public void Enetersett(TextBox txt)
        {
            
            txt.BackColor = System.Drawing.Color.Black;
            txt.ForeColor = System.Drawing.Color.White;
            if (txt.Text.Length > 0)
            {
                txt.Select();
            }
        }
        public void Leavesett(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            txt.ForeColor = System.Drawing.Color.Black;
        }
        public void Retrive()
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where itemid='" + Itemid + "'");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                TxtItemId.Text = Itemid;
                TxtItemCode.textBox1.Text = Ds.Tables[0].Rows[i]["itemcode"].ToString();
                TxtItemname.textBox1.Text = Ds.Tables[0].Rows[i]["itemname"].ToString();
                TxtItemname.textBox1.Tag = Ds.Tables[0].Rows[i]["sizelessname"].ToString();
                Txtitemcategory.textBox1.Tag = Ds.Tables[0].Rows[i]["CategoryId"].ToString();
                Txtitemcategory.textBox1.Text = _Dbtask.ExecuteScalar("select category from tblitemcategory where categoryid='" + Ds.Tables[0].Rows[i]["CategoryId"].ToString() + "'");
                Txtmanufacturer.textBox1.Tag= Ds.Tables[0].Rows[i]["manufacturer"].ToString();
                Txtmanufacturer.textBox1.Text= _Dbtask.ExecuteScalar("select mname from tblmanufacturer where mid='" + Ds.Tables[0].Rows[i]["manufacturer"].ToString() + "'");
                txtrack.textBox1.Text = Ds.Tables[0].Rows[i]["rack"].ToString();
                Comitemclass.Text = Ds.Tables[0].Rows[i]["itemclass"].ToString();
                TxtDiscription.textBox1.Text = Ds.Tables[0].Rows[i]["Description"].ToString();
                txtplu.textBox1.Text = Ds.Tables[0].Rows[i]["plu"].ToString();
                txtlocallaungage.textBox1.Text = Ds.Tables[0].Rows[i]["llang"].ToString();
                TxtMRP.textBox1.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["MRP"]));
                TxtSrate.textBox1.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["srate"]));
               
                TxtPrate.textBox1.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["prate"]));

                SizeFillingInEditMode();
                ItemStatus = Convert.ToInt16(Ds.Tables[0].Rows[i]["status"]);
                if (ItemStatus == 1)
                {
                    txtstatus.textBox1.Text = "Yes";
                }
                else if (ItemStatus == -1)
                {
                    txtstatus.textBox1.Text = "No";
                }
                TxtAgentCommision.textBox1.Text= _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["agentcommision"]));
                

               // TxtCooly.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["cooly"]));
                 

                TxtMinstock.Text = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(Ds.Tables[0].Rows[i]["minstock"]));
               

                Txtreorder.textBox1.Text = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(Ds.Tables[0].Rows[i]["Reorder"]));
                 

                TxtMaximum.Text= _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(Ds.Tables[0].Rows[i]["maximum"]));

                comunit.Text = Ds.Tables[0].Rows[i]["Unit"].ToString();

               // TxtUnit.textBox1.Text = Ds.Tables[0].Rows[i]["Unit"].ToString();

                  Txtvat.textBox1.Text= _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["VAT"]));
              

                TxtCst.textBox1.Text= _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["CST"]));
                

                TxtPurchaseTax.textBox1.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["purtax"]));
                

                Incs = Convert.ToInt16(Ds.Tables[0].Rows[i]["incs"]);
                IncP = Convert.ToInt16(Ds.Tables[0].Rows[i]["incp"]);

               //TxtOpQty.Tag=Ds.Tables[0].Rows[i]["balance"];
               

                if (Incs == 1)
                {
                    txttaxsaleincluseive.textBox1.Text = "Yes";
                }
                else
                {
                    txttaxsaleincluseive.textBox1.Text = "No";
                }

                if (IncP == 1)
                {
                    txttaxpurchaseincluseive.textBox1.Text = "Yes";
                }
                else
                {
                    txttaxpurchaseincluseive.textBox1.Text = "No";
                }
               
                /*For Opening Stock*/
                string strtemp = Ds.Tables[0].Rows[i]["balance"].ToString();
                double Recptcode = 0;
                //if (strtemp != "")
                //{
                //     Recptcode = Convert.ToDouble(Ds.Tables[0].Rows[i]["balance"].ToString());
                //}
                
                //if (Recptcode > 0)
                //{
                //    TxtVno.Tag = Recptcode;
                //    TxtVno.Text=_Dbtask.ExecuteScalar("select vno from tbltransactionreceipt where reptcode='"+Recptcode+"'");
                //   double temp=_Dbtask.znullDouble(_Dbtask.ExecuteScalar("select qty from tblreceiptdetails where  pcode='" + TxtItemId.Text + "'  and vtype='OS' and recptcode='" + Recptcode + "'"));
                //    TxtOpQty.textBox1.Text =_Dbtask.SetintoDecimalpoint(temp) ;
                //   // TxtOpQty.Tag = Recptcode;
                //}
                double t;
                double T1;
                t =_Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(os),0) from tblinventory where pcode=" + TxtItemId.Text + " and os !=0"));
                T1 = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(uc),0) from tblinventory where pcode=" + TxtItemId.Text + " and os !=0"));
                if (T1 == 0)
                    T1 = 1;
                TxtOpQty.textBox1.Text =_Dbtask.SetintoDecimalpointStock(t/T1);

                TxtOpQty.Tag = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select vcode from tblinventory where pcode=" + Itemid + " and os !=0"));
                /***************************/

            }

            if (Smrate == true)
            {
                Ds = _Dbtask.ExecuteQuery("select * from tblunitsrates where itemid='" + Itemid + "' and uid='"+comunit.SelectedValue+"'");

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    Txtwrate.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["wrate"]);
                }

                Ds = _Dbtask.ExecuteQuery("select * from tblunitsrates where itemid='" + Itemid + "' and uid !='" + comunit.SelectedValue + "'");

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    Comunit1.SelectedValue = Convert.ToInt16(Ds.Tables[0].Rows[0]["Uid"]);
                    txtprate1.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["Prate"]);
                    Txtsrate1.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["Srate"]);
                    Txtmrp1.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["mrp"]);
                    Txtwrate1.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["wrate"]);
                }
            }
        }

       
      
        public void SetyesorNo(TextBox txt)
        {
            string temp = txt.Text.ToLower();
            if (temp == "yes" || temp == "ye" || temp == "y" || temp == "s")
            {
                txt.Text = "Yes";

            }
            else
            {
                txt.Text = "No";
            }
        }
       
      

      

        

       


        private void TxtDiscription_Leave(object sender, EventArgs e)
        {
            //Leavesett(TxtDiscription);
            Main();
        }

       
      

        private void txtitemclass_Leave(object sender, EventArgs e)
        {
            string Temp = Comitemclass.Text;
            if (Temp != "Stock Item" && Temp != "Services" && Temp != "Finished Product")
            {
                Comitemclass.Text = "Stock Item";
            }
        }

        private void txtitemclass_TextChanged(object sender, EventArgs e)
        {
            ShowClass();
        }

        private void txtitemclass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (Gridmain.SelectedRows.Count > 0)
                {
                    selectedRow = Gridmain.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridmain.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridmain.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridmain.Rows[selectedRow + 1].Selected = true;
                            Gridmain.Rows[selectedRow].Selected = false;
                            Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridmain.Rows[selectedRow - 1].Selected = true;
                        Gridmain.Rows[selectedRow].Selected = false;
                        Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                    }

                    if (e.KeyValue == 13)
                    {
                        if (Gridmain.SelectedRows.Count > 0 && Gridmain.Visible == true)
                        {
                            Comitemclass.Text = Gridmain.SelectedRows[0].Cells["clnname"].Value.ToString();
                            
                        }
                        
                        Gridmain.Visible = false;
                        SearchingMode = false;
                    }
                    if (e.KeyValue == 27)
                    {
                        Gridmain.Visible = false;
                        if (Txtmanufacturer.textBox1.Text.Length > 0)
                        {
                            Notexit = false;
                        }
                        else
                        {
                            Notexit = true;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void txtitemclass_Enter(object sender, EventArgs e)
        {
            SearchingMode = true;
        }

        

        private void TxtSrate_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                TxtMRP.textBox1.Text = TxtSrate.textBox1.Text;
            }
        }

        private void TxtSrate_Enter_1(object sender, EventArgs e)
        {

        }

        private void TxtMRP_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);

        }

        private void TxtMRP_Enter_1(object sender, EventArgs e)
        {

        }

        private void TxtOpQty_Enter_1(object sender, EventArgs e)
        {

        }

        private void Txtreorder_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
        }

        private void TxtAgentCommision_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
        }

      

        private void TxtDiscription_Leave_1(object sender, EventArgs e)
        {
            Main();
        }

        
        public void controltextboxsett(TextBox tt )
        {
            tt.ReadOnly =false;
        }

       

        private void Txtreorder_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
        }

        private void txttaxsaleincluseive_Enter_1(object sender, EventArgs e)
        {

        }

        
        private void txttaxpurchaseincluseive_Leave(object sender, EventArgs e)
        {
            SetyesorNo(txttaxpurchaseincluseive.textBox1);
            if (txttaxpurchaseincluseive.textBox1.Text == "Yes")
            {
                IncP = 1;
            }
            else
            {
                IncP = -1;
            }

        }

       
        private void comunit_Leave(object sender, EventArgs e)
        {
            lblunit.Text = comunit.Text;
        }

        private void comsecunit_Leave(object sender, EventArgs e)
        {
            lblsecunit.Text = comsecunit.Text;
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            Ds = _Dbtask.ExecuteQuery("select * from ImagesTable");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                //textBox1.Text = Ds.Tables[0].Rows[rno][0].ToString();
                //textBox2.Text = Ds.Tables[0].Rows[rno][1].ToString();
                //textBox3.Text = Ds.Tables[0].Rows[rno][2].ToString();
                //textBox4.Text = Ds.Tables[0].Rows[rno][3].ToString();
                Picitemimage.Image = null;
                if (Ds.Tables[0].Rows[0]["image"] != System.DBNull.Value)
                {
                    photo_aray = (byte[])Ds.Tables[0].Rows[0]["image"];
                    MemoryStream ms = new MemoryStream(photo_aray);
                    Picitemimage.Image = Image.FromStream(ms);
                }
            }
        }

        private void TxtItemname_Leave(object sender, EventArgs e)
        {
            GridProductList.Visible = false;
        }

        private void TxtItemname_TextChanged(object Sender, EventArgs e)
        {
            try
            {
                if (Isinotherwindow == false)
                {
                    GridProductList.DataSource = null;
                    GridProductList.Columns.Clear();

                    //GridProductList.Columns.Add("itemname","");
                    GridProductList.Visible = true;

                    Ds1 = _Dbtask.ExecuteQuery("select itemcode from tblitemmaster  where  itemName Like N'%" + TxtItemname.textBox1.Text + "%'");
                    GridProductList.DataSource = Ds1.Tables[0];
                    GridProductList.Columns[0].Width = 250;
                    //for (int i = 0; i < Ds1.Tables[0].Rows.Count; i++)
                    //{
                    //    GridProductList.Rows.Add(1);
                    //    GridProductList.Rows[i].Cells[0].Value = Ds1.Tables[0].Rows[i]["itemname"];
                    //}
                }
            }
            catch
            {
            }
        }

        private void TxtItemname_Load(object sender, EventArgs e)
        {
            controltextboxsett(TxtItemname.textBox1);
        }

        private void TxtItemname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
                TxtItemCode.textBox1.Text = TxtItemname.textBox1.Text;
        }

        private void Txtitemcategory_TextChanged(object Sender, EventArgs e)
        {
            CategoryShow();
        }

        private void Txtitemcategory_Enter(object sender, EventArgs e)
        {
            SearchingMode = true;
        }

        private void Txtitemcategory_Leave(object sender, EventArgs e)
        {
            Gridmain.Visible = false;
        }

        private void Txtitemcategory_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (Gridmain.SelectedRows.Count > 0)
                {
                    selectedRow = Gridmain.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridmain.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridmain.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridmain.Rows[selectedRow + 1].Selected = true;
                            Gridmain.Rows[selectedRow].Selected = false;
                            Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridmain.Rows[selectedRow - 1].Selected = true;
                        Gridmain.Rows[selectedRow].Selected = false;
                        Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                    }

                    if (e.KeyValue == 13)
                    {
                        if (Gridmain.SelectedRows.Count > 0 && Gridmain.Visible == true)
                        {
                            SearchingMode = false;
                            Txtitemcategory.textBox1.Text = Gridmain.SelectedRows[0].Cells["clnname"].Value.ToString();
                            Txtitemcategory.textBox1.Tag = Gridmain.SelectedRows[0].Cells["clnname"].Tag;
                            SearchingMode = true;
                        }
                        if (Txtitemcategory.textBox1.Text == "")
                        {
                            Txtitemcategory.textBox1.Text = "None";
                            Txtitemcategory.textBox1.Tag = 0;
                        }
                        Gridmain.Visible = false;
                    }
                    if (e.KeyValue == 27)
                    {
                        Gridmain.Visible = false;
                        if (Txtitemcategory.textBox1.Text.Length > 0)
                        {
                            Notexit = false;
                        }
                        else
                        {
                            Notexit = true;
                        }
                    }
                }
            }
            catch
            {
            }



        }

        private void cmdshowcategory_Click(object sender, EventArgs e)
        {
            if (Gridmain.Visible == false)
            {
                SearchingMode = true;
                CategoryShow();
            }
            else
            {
                Gridmain.Visible = false;
            }
        }

        private void Txtmanufacturer_TextChanged(object Sender, EventArgs e)
        {
            if (SearchingMode == true)
            {
                Ds = _Manufacturer.ShowManfacturer("where mname like '%" + Txtmanufacturer.textBox1.Text + "%'");
                Gridmain.Rows.Clear();
                Gridmain.Visible = true;
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Gridmain.Rows.Add(1);
                    Gridmain.Rows[i].Cells["clnname"].Value = Ds.Tables[0].Rows[i]["mname"];
                    Gridmain.Rows[i].Cells["clnname"].Tag = Ds.Tables[0].Rows[i]["mid"];
                }
                this.Gridmain.Location = new System.Drawing.Point(128, 126);
            }
        }

        private void Txtmanufacturer_Leave(object sender, EventArgs e)
        {
            Leavesett(Txtmanufacturer.textBox1);
            Gridmain.Visible = false;
        }

        private void Txtmanufacturer_Enter(object sender, EventArgs e)
        {
            SearchingMode = true;
        }

        private void Txtmanufacturer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (Gridmain.SelectedRows.Count > 0)
                {
                    selectedRow = Gridmain.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridmain.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridmain.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridmain.Rows[selectedRow + 1].Selected = true;
                            Gridmain.Rows[selectedRow].Selected = false;
                            Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridmain.Rows[selectedRow - 1].Selected = true;
                        Gridmain.Rows[selectedRow].Selected = false;
                        Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                    }

                    if (e.KeyValue == 13)
                    {
                        if (Gridmain.SelectedRows.Count > 0 && Gridmain.Visible == true)
                        {
                            Txtmanufacturer.textBox1.Text = Gridmain.SelectedRows[0].Cells["clnname"].Value.ToString();
                            Txtmanufacturer.textBox1.Tag = Gridmain.SelectedRows[0].Cells["clnname"].Tag;
                        }
                        if (Txtmanufacturer.textBox1.Text == "")
                        {
                            Txtmanufacturer.textBox1.Text = "None";
                            Txtmanufacturer.textBox1.Tag = 0;
                        }
                        Gridmain.Visible = false;
                        SearchingMode = false;
                    }
                    if (e.KeyValue == 27)
                    {
                        Gridmain.Visible = false;
                        if (Txtmanufacturer.textBox1.Text.Length > 0)
                        {
                            Notexit = false;
                        }
                        else
                        {
                            Notexit = true;
                        }
                    }
                }
                else
                {
                    if (e.KeyValue == 13)
                    {
                        Txtmanufacturer.textBox1.Tag = "";
                    }
                }
            }

            catch
            {
            }
        }

        private void Txtvat_Leave(object sender, EventArgs e)
        {
            TxtPurchaseTax.textBox1.Text = Txtvat.textBox1.Text;

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            FormClose();
        }

        private void TxtPratePerc_Leave(object sender, EventArgs e)
        {
            double Srate;
            Srate = _Dbtask.znullDouble(TxtPrate.textBox1.Text) * _Dbtask.znullDouble(TxtPratePerc.textBox1.Text) / 100;
            TxtSrate.textBox1.Text = (Srate + _Dbtask.znullDouble(TxtPrate.textBox1.Text)).ToString();
        }

        
        private void txttaxsaleincluseive_Leave(object sender, EventArgs e)
        {
            SetyesorNo(txttaxsaleincluseive.textBox1);
            if (txttaxsaleincluseive.textBox1.Text == "Yes")
            {
                Incs = 1;
            }
            else
            {
                Incs = -1;
            }

        }

        private void txtstatus_Leave(object sender, EventArgs e)
        {
            SetyesorNo(txtstatus.textBox1);
            if (txtstatus.textBox1.Text == "Yes")
            {
                ItemStatus = 1;
            }
            else
            {
                ItemStatus = -1;
            }
        }

      
       
       
      }
}
