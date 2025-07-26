using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frmquickadditems : Form
    {
        public Frmquickadditems()
        {
            InitializeComponent();
        }
        public bool SearchingMode;
        public bool manbool = false;
        public bool Catbool = false; public bool P1by1;
        public int selectedRow;
        Clsarabicchange _langchange =new Clsarabicchange();
        public string Txt;
        Clsrack _rack = new Clsrack();

        DataSet Ds; DBTask _Dbtask = new DBTask();
        public bool Isinotherwindow;
        bool Sbatch; public static string Barcodeprintingin;
        public bool EditMode;
        string IdSimple;
        public string Id;
        public string Barcode = "";
        string ItemName;
        string Itemcode;
        string Itemnote;
        string SecondLangague;
        string Vat;
        string Prate;
        string Srate;
        string LastRate;
        string MRP; DataSet Ds1 = new DataSet();
        string OPQty; public bool find = false;

        string Oldbcodee = ""; public string ontable = "No";
        ClsBaseunit _base = new ClsBaseunit();
        Clssettings _Settings = new Clssettings();
        ClsInventory _Inventory = new ClsInventory();
        ClsParamlist _Paramlist = new ClsParamlist();
        string Sid;
        Translator _t = new Translator();
             
        DBTask _dbtask = new DBTask();
        public bool IsinCloseStage;
        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();

            if (CommonClass._Gen.chkother() == true)
            {
                this.Close();
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



        public void RetriveSetyesorNo(DataSet Dss)
        {
            Dss.Tables[0].Rows[0]["Incs"].ToString();
            if (CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[0]["Incs"]) == 1)
            {
                txttaxsaleincluseive.textBox1.Text = "Yes";
            }
            else
            {
                txttaxsaleincluseive.textBox1.Text = "No";
            }

            Dss.Tables[0].Rows[0]["Incp"].ToString();
            if (CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[0]["Incp"]) == 1)
            {
                txttaxpurchaseincluseive.textBox1.Text = "Yes";
            }
            else
            {
                txttaxpurchaseincluseive.textBox1.Text = "No";
            }
        }

        public void RetriveWieghtmechine(string Value)
        {
            if (Value == "1")
            {
                Comusemechine.SelectedIndex = 1;
            }
            else
            {
                Comusemechine.SelectedIndex = 0;
            }

        }

        public void SetyesorNo()
        {
            string temp = txttaxsaleincluseive.textBox1.Text.ToLower();
            if (temp == "yes" || temp == "ye" || temp == "y" || temp == "s")
            {
                CommonClass._Itemmaster.Incs = 1;
            }
            else
            {
                CommonClass._Itemmaster.Incs = -1;
            }


            temp = txttaxpurchaseincluseive.textBox1.Text.ToLower();
            if (temp == "yes" || temp == "ye" || temp == "y" || temp == "s")
            {
                CommonClass._Itemmaster.Incp = 1;
            }
            else
            {
                CommonClass._Itemmaster.Incp = -1;
            }
        }

        public void setmechinevalue()
        {
            if (Comusemechine.SelectedIndex == 0)
            {
                CommonClass._Itemmaster.Usingmechine = -1;
            }
            else
            {
                CommonClass._Itemmaster.Usingmechine = 1;
            }
        }

        public void NextgInitialize()
        {
            string Itemclass = Comitemclass.Text;
            CommonClass._Itemmaster.ItemIdLng = Convert.ToInt64(Id);

            CommonClass._Itemmaster.ItemNameStr = ItemName;
            CommonClass._Itemmaster.ItemCodeStr = Itemcode;
            CommonClass._Itemmaster.ItemnoteStr = Itemnote;
            CommonClass._Itemmaster.ReorderStockDb = CommonClass._Dbtask.znlldoubletoobject(txtreorder.textBox1.Text);

            CommonClass._Itemmaster.CategoryIdLng = 0;
            CommonClass._Itemmaster.DescriptionStr = "";
            CommonClass._Itemmaster.ItemnoteStr = Txtitemnote.textBox1.Text;

            CommonClass._Itemmaster.rackname = _dbtask.znllString(Txtrackselect.Text);
            CommonClass._Itemmaster.Rack = _dbtask.znllString(Txtrackselect.Tag);

            CommonClass._Itemmaster.CategoryIdLng = Convert.ToInt64(CommonClass._Dbtask.znlldoubletoobject(Txtitemcategory.Tag));
            CommonClass._Itemmaster.ManufacturerLng = Convert.ToInt64(CommonClass._Dbtask.znlldoubletoobject(Txtmanufacturer.Tag));

            if (Sbatch == false)
            {

                CommonClass._Itemmaster.MRPDb = CommonClass._Dbtask.znullDouble(MRP);
                CommonClass._Itemmaster.SRateDb = CommonClass._Dbtask.znullDouble(Srate);
                CommonClass._Itemmaster.PRateDb = CommonClass._Dbtask.znullDouble(Prate);
            }
            else
            {
                CommonClass._Batch.Bcode = Barcode;
                CommonClass._Batch.Itemid = Id;
                CommonClass._Batch.Costcenter = "0";
                CommonClass._Batch.Depo = "0";
                CommonClass._Batch.Bid = Barcode;
                CommonClass._Batch.Ledcode = "0";
                CommonClass._Batch.Mrp = CommonClass._Dbtask.znullDouble(MRP);
                CommonClass._Batch.Srate = CommonClass._Dbtask.znullDouble(Srate);
                CommonClass._Batch.Lastrate = CommonClass._Dbtask.znullDouble(LastRate);
                CommonClass._Batch.ManDate = CommonClass._Dbtask.ZnullDatetime(1 / 1 / 1900);
                CommonClass._Batch.ExDate = CommonClass._Dbtask.ZnullDatetime(1 / 1 / 1900);
                CommonClass._Batch.Prate = CommonClass._Dbtask.znullDouble(Prate);
                CommonClass._Batch.Unconv = 0;
                CommonClass._Batch.prateper = CommonClass._Dbtask.znlldoubletoobject(txtpratepercntage.textBox1.Text);
                CommonClass._Batch.Recptcode = CommonClass._Dbtask.znllString(Lblid.Tag);
                CommonClass._Batch.baseU = CommonClass._Dbtask.znllString(comunit.SelectedValue);
                CommonClass._Itemmaster.MRPDb = 0;
                CommonClass._Itemmaster.SRateDb = 0;
                CommonClass._Itemmaster.PRateDb = 0;
                CommonClass._Batch.ontable = ontable;


                

            }

            //   CommonClass._Itemmaster.ManufacturerLng = 0;
            CommonClass._Itemmaster.StatusInt = 1;
            CommonClass._Itemmaster.AgentCommisionDb = 0;
            CommonClass._Itemmaster.CoolyDb = 0;
            CommonClass._Itemmaster.MinStockDb = 0;
            //CommonClass._Itemmaster.ReorderStockDb = 0;
            CommonClass._Itemmaster.MaximumDb = 0;
            CommonClass._Itemmaster.TaxSlabIdLng = Convert.ToInt64(0);
            CommonClass._Itemmaster.Unit = "";
            CommonClass._Itemmaster.VAT = CommonClass._Dbtask.znullDouble(Vat);
            CommonClass._Itemmaster.CST = 0;
            CommonClass._Itemmaster.Purtax = CommonClass._Dbtask.znullDouble(Vat);
            CommonClass._Itemmaster.Incp = -1;
            CommonClass._Itemmaster.Incs = -1;
            //CommonClass._Itemmaster.Rack = "";
            CommonClass._Itemmaster.ItemClass = Itemclass;
            CommonClass._Itemmaster.Balance = 0;
            CommonClass._Itemmaster.PLU = "";
            CommonClass._Itemmaster.Sizelessname = "";
            CommonClass._Itemmaster.Ledid = 0;
            CommonClass._Itemmaster.Localaungage = SecondLangague;

            if (comunit.SelectedValue != null)
            {
                CommonClass._Itemmaster.Bunit = comunit.SelectedValue.ToString(); ;
            }
            else
            {
                CommonClass._Itemmaster.Bunit = "1";
            }
            setmechinevalue();
            SetyesorNo();

            //CommonClass._Itemmastersimple.id = Convert.ToInt64(Lblsimpleitemid.Text);
            //CommonClass._Itemmastersimple.Barcode = Barcode;
            //CommonClass._Itemmastersimple.Itemid =Convert.ToInt64(Id);

            //Image img = Picitemimage.BackgroundImage;
            //byte[] arr;
            //ImageConverter converter = new ImageConverter();
            //arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            //_Dbtask.ExecuteNonQuery("INSERT INTO ImagesTable (Image) VALUES('" + arr + "')");


            if (CommonClass._Dbtask.znullDouble(OPQty) > 0)
            {
                CommonClass._Inventory.Vcode = CommonClass._Dbtask.znllString(Lblid.Tag);
                CommonClass._Inventory.DCodeStr = "0";
                CommonClass._Inventory.InvDateDt = DateTime.Now;
                CommonClass._Inventory.PcodeStr = Lblid.Text;
                CommonClass._Inventory.Os = CommonClass._Dbtask.znullDouble(OPQty);
                CommonClass._Inventory.Iissue = 0;
                CommonClass._Inventory.Ireceipt = 0;
                CommonClass._Inventory.Batchcode = Barcode;

                CommonClass._ReceiptDetails.RcptCodeLng = Convert.ToInt64(Lblid.Tag);
                CommonClass._ReceiptDetails.SlNoLng = 1;
                CommonClass._ReceiptDetails.PCodeStr = Lblid.Text;
                CommonClass._ReceiptDetails.UnitIdLng = 0;
                CommonClass._ReceiptDetails.MultiRateIdLng = 0;
                CommonClass._ReceiptDetails.QtyDb = CommonClass._Dbtask.znullDouble(OPQty);
                CommonClass._ReceiptDetails.Vtype = "OS";

                CommonClass._Transactionreceipt.RcptCodeLng = Convert.ToInt64(Lblid.Tag);
                // _TransactionReceipt.IdOpeningStockFu();
                CommonClass._Transactionreceipt.VNoStr = CommonClass._Dbtask.znllString(Lblid.Tag);
                CommonClass._Transactionreceipt.RCptTypeStr = "OS";
                CommonClass._Transactionreceipt.DcodeStr = "0";
                CommonClass._Transactionreceipt.RcptDateDt = DateTime.Now;
                CommonClass._Transactionreceipt.Rcptdatebilling = DateTime.Now;
                // _TransactionReceipt.AMTDb = OPQty * PRate;
                CommonClass._Transactionreceipt.RemarkStr = "Opening Stock";
                CommonClass._Transactionreceipt.RefNo = "1001";
                CommonClass._Transactionreceipt.LedCodeCr = Convert.ToString(0);
                CommonClass._Transactionreceipt.LedCodeDr = Convert.ToString(0);
                CommonClass._Transactionreceipt.EmpId = Convert.ToString(0);
           
            
            
            }





            if (EditMode == true)
            {
                updateedit(Id, Oldbcodee, CommonClass._Dbtask.znllString(Txtbarcode.textBox1.Text));
            }

        }
        public void updateedit(string id, string oldbarcode, string newww)
        {
            double cnt = 0;
            cnt = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select count(batchid) from tblissuedetails where batchid='" + oldbarcode + "' and pcode='" + id + "'"));
            if (cnt > 0)
            {
                CommonClass._Dbtask.ExecuteNonQuery("update tblissuedetails set batchid='" + newww + "' where batchid='" + oldbarcode + "' and pcode='" + id + "'");
            }
            cnt = 0;
            cnt = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select count(batchid) from tblreceiptdetails where batchid='" + oldbarcode + "' and pcode='" + id + "'"));
            if (cnt > 0)
            {
                CommonClass._Dbtask.ExecuteNonQuery("update tblreceiptdetails set batchid='" + newww + "' where batchid='" + oldbarcode + "' and pcode='" + id + "'");
            }

            cnt = 0;
            cnt = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select count(batchcode) from tblinventory where batchcode='" + oldbarcode + "' and pcode='" + id + "'"));
            if (cnt > 0)
            {
                CommonClass._Dbtask.ExecuteNonQuery("update tblinventory set batchcode='" + newww + "' where batchcode='" + oldbarcode + "' and pcode='" + id + "'");
            }



        }
        /*ForOpening Stock*/
        public void Insert()
        {
            CommonClass._Itemmaster.InsertItems();
            CommonClass._Itemmaster.InsertItemsAzure();

            //  CommonClass._Itemmastersimple.Insertsimpleitem();
            OpeningBalanceInsert();
            if (Sbatch == true)
            {
                CommonClass._Batch.InsertBatch();
                CommonClass._Batch.InsertBatchAzure();

                if (EditMode == false)
                {
                    CommonClass._Batch.FuupdateStartingBarcode((CommonClass._Dbtask.znlldoubletoobject(Txtbarcode.textBox1.Tag) + 1).ToString());
                }
            }
            CommonClass._Inventory.Os = 0;
        }
        public void OpeningBalanceInsert()
        {
            if (CommonClass._Dbtask.znullDouble(OPQty) > 0) /*For Opening Stock */
            {
                CommonClass._Inventory.InsertInventory();
                CommonClass._Inventory.InsertInventoryAzureServer();
                CommonClass._Transactionreceipt.InsertTransactionReceipt();
                CommonClass._ReceiptDetails.InsertReceiptDetails();
            }
        }

        public void CategoryShow()
        {
            if (SearchingMode == true)
            {
                Ds = CommonClass._ItemCategory.Showitemcategory("where Category like '%" + Txtitemcategory.textBox1.Text + "%'");
                Gridmainlist.Rows.Clear();
                Gridmainlist.Visible = true;
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Gridmainlist.Rows.Add(1);
                    Gridmainlist.Rows[i].Cells["clnname"].Value = Ds.Tables[0].Rows[i]["Category"];
                    Gridmainlist.Rows[i].Cells["clnname"].Tag = Ds.Tables[0].Rows[i]["Categoryid"];
                }
                this.Gridmainlist.Location = new System.Drawing.Point(274, 339);
            }
        }

        private bool ValidationFu()
        {
            ItemName = TxtItemname.textBox1.Text.Replace("\r", " ");
            ItemName = ItemName.Replace("\n", " ");

            Itemcode = TxtItemcode.textBox1.Text.Replace("\r", " ");
            Itemcode = Itemcode.Replace("\n", " ");

            Itemnote = Txtitemnote.textBox1.Text.Replace("\r", " ");
            Itemnote = Itemnote.Replace("\n", " ");

            SecondLangague = Txtsecondlangague.textBox1.Text;
            Barcode = Txtbarcode.textBox1.Text.Replace("\r", " ");
            Barcode = Barcode.Replace("\n", " ");
            Vat = Txtvat.textBox1.Text;
            Prate = Txtprate.textBox1.Text;
            Srate = Txtsrate.textBox1.Text;
            LastRate = Txtlastrate.textBox1.Text;
            MRP = Txtmrp.textBox1.Text;
            OPQty = Txtopqty.textBox1.Text;
            IdSimple = Lblsimpleitemid.Text;


            if (Barcode != "" && Sbatch == true)
            {
                if (CommonClass._GenF.splcharacter(Barcode) == true)
                {
                    MessageBox.Show("Splecial characters are not allowed in Barcode", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txtbarcode.textBox1.Focus();
                    return false;
                }
            }

            if (CommonClass._settings.FunSettings1("Batch") == true)
            {
                Sbatch = true;
            }
            if (Barcode.Replace(" ", "") == "" && Sbatch == true)
            {
                MessageBox.Show("Enter Barcode", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txtbarcode.textBox1.Focus();
                return false;
            }
            if (ItemName.Replace(" ", "") == "")
            {
                MessageBox.Show("Enter the Product Code", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtItemname.textBox1.Focus();
                return false;
            }

            if (Itemcode.Replace(" ", "") == "")
            {
                MessageBox.Show("Enter the Product Code", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtItemcode.textBox1.Focus();
                return false;
            }

            if (CommonClass._Batch.SameNamealreadyexistNew(Barcode) == true && EditMode == false && Sbatch == true)
            {
                MessageBox.Show("Barcode Already Exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txtbarcode.textBox1.Focus();
                return false;
            }

            Ds = CommonClass._Dbtask.ExecuteQuery("select itemcode from tblitemmaster where itemcode=N'" + Itemcode + "'");
            if (Ds.Tables[0].Rows.Count > 0 && EditMode == false)
            {
                Lblid.Text = CommonClass._Itemmaster.Getitemid(Itemcode);
            }

            return true;
        }
        public void ItemCode()
        {
            CommonClass._Itemmaster.IdItemName();
            Lblid.Text = Convert.ToString(CommonClass._Itemmaster.ItemIdLng);
            Id = Lblid.Text;
            CommonClass._Transactionreceipt.IdOpeningStockFu();
            Lblid.Tag = Convert.ToString(CommonClass._Transactionreceipt.RcptCodeLng);
            // Lblsimpleitemid.Text = CommonClass._Itemmastersimple.IdItemName();
        }

        public void DeleteItems()
        {
            Id = Lblid.Text;
            CommonClass._Dbtask.ExecuteNonQuery("Delete from tblitemmaster where itemid in (" + Id + ")");


            CommonClass._Dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where reptcode='" + Lblid.Tag + "' and recpttype='OS'");
            CommonClass._Dbtask.ExecuteNonQuery("delete from tblinventory where os !=0 and pcode='" + Id + "'  AND BATCHCODE='" + CommonClass._Dbtask.znllString(Txtbarcode.textBox1.Tag) + "'   AND SLNO IN('0','')");
            CommonClass._Dbtask.ExecuteNonQuery("delete from tblreceiptdetails where  vtype='OS' and pcode='" + Id + "'");
            CommonClass._Dbtask.ExecuteNonQuery("Delete from tblbatch where Bcode ='" + CommonClass._Dbtask.znllString(Txtbarcode.textBox1.Tag) + "'");
            //  CommonClass._Dbtask.ExecuteNonQuery("Delete from TblitemMastersimple where id ='" + Lblsimpleitemid.Text + "'");

        }
        public void DeleteItemsAzureServer()
        {
            Id = Lblid.Text;
            CommonClass._Dbtask.ExecuteNonQueryAzureServer("Delete from tblitemmaster where itemid in (" + Id + ")");


            CommonClass._Dbtask.ExecuteNonQueryAzureServer("delete from tbltransactionreceipt where reptcode='" + Lblid.Tag + "' and recpttype='OS'");
            CommonClass._Dbtask.ExecuteNonQueryAzureServer("delete from tblinventory where os !=0 and pcode='" + Id + "'  AND BATCHCODE='" + CommonClass._Dbtask.znllString(Txtbarcode.textBox1.Tag) + "'   AND SLNO IN('0','')");
            CommonClass._Dbtask.ExecuteNonQueryAzureServer("delete from tblreceiptdetails where  vtype='OS' and pcode='" + Id + "'");
            CommonClass._Dbtask.ExecuteNonQueryAzureServer("Delete from tblbatch where Bcode ='" + CommonClass._Dbtask.znllString(Txtbarcode.textBox1.Tag) + "'");
            //  CommonClass._Dbtask.ExecuteNonQuery("Delete from TblitemMastersimple where id ='" + Lblsimpleitemid.Text + "'");

        }
        public void Retrive()
        {
           string ds = CommonClass._Dbtask.ExecuteScalarAzureServer("select * from tblitemmaster where itemid='" + Id + "'");
            if (ds != "")
            {
                Ds = CommonClass._Dbtask.ExecuteQueryAzureServer("select * from tblitemmaster where itemid='" + Id + "'");
            }
            else
            {
                Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblitemmaster where itemid='" + Id + "'");
            }
            


            if (Ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Cmdunitrefresh.Enabled = false;
                    Txtopqty.textBox1.Enabled = false;

                    EditMode = true;
                    Lblid.Text = Id;
                    TxtItemname.textBox1.Text = Ds.Tables[0].Rows[i]["itemname"].ToString();
                    TxtItemcode.textBox1.Text = Ds.Tables[0].Rows[i]["itemcode"].ToString();
                    Txtitemnote.textBox1.Text = CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["itemnote"]);
                    lblreorder.Visible = true;
                    txtreorder.textBox1.Text = CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["reorder"]);

                    Txtrackselect.Tag = _dbtask.znllString(Ds.Tables[0].Rows[i]["rack"]);
                    Txtrackselect.Text = _dbtask.znllString(Ds.Tables[0].Rows[i]["rackname"]);



                    //Txtbarcode.textBox1.Text = Barcode;
                    Barcode = Barcode;
                    Txtbarcode.textBox1.Tag = Barcode;
                    Oldbcodee = Barcode;
                    Comitemclass.Text = Ds.Tables[0].Rows[i]["itemclass"].ToString();
                    //Barcode = CommonClass._Dbtask.ExecuteScalar("select bcode from tblbatch where itemid='" + Id + "'");
                    Txtbarcode.textBox1.Text = Barcode;
                    Txtsecondlangague.textBox1.Text = Ds.Tables[0].Rows[i]["llang"].ToString();
                    Txtitemcategory.Tag = CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["categoryid"]);
                    Txtitemcategory.textBox1.Text = CommonClass._ItemCategory.SpecificField(CommonClass._Dbtask.znllString(Txtitemcategory.Tag), "Category");
                    Txtmanufacturer.Tag = CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Manufacturer"]);
                    Txtmanufacturer.textBox1.Text = CommonClass._Manufacturer.SpecificField(CommonClass._Dbtask.znllString(Txtmanufacturer.Tag), "Mname");
                    Txtvat.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["vat"]));



                    //Txtbarcode.textBox1.Text = Barcode;
                    RetriveSetyesorNo(Ds);
                    RetriveWieghtmechine(CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["Usingmechine"]));
                    //IdSimple= Ds.Tables[0].Rows[i]["sid"].ToString();
                    // Lblsimpleitemid.Text=IdSimple;
                    if (CommonClass._settings.FunSettings1("Batch") == true)
                    {
                        Sbatch = true;
                    }
                    if (Sbatch == true)
                    {
                        // Barcode = CommonClass._Itemmastersimple.Getspecificfield("barcode", IdSimple);
                        //Txtbarcode.textBox1.Text = Barcode;
                        Txt = Txtbarcode.textBox1.Text;
                        Txtprate.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Txt, "prate", Id)));
                        Txtsrate.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Txt, "srate", Id)));
                        txtpratepercntage.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Txt, "prateperc", Id)));
                        if (_dbtask.znllString(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Txt, "ONtable", Id)) == "No" || _dbtask.znllString(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Txt, "prateperc", Id)) == "")
                        {
                            chkontable.Checked = false;
                        }
                        else
                        {
                            chkontable.Checked = true;
                        }



                        Txtlastrate.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Txt, "lastrate", Id)));
                        Txtmrp.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Txt, "mrp", Id)));
                        Lblid.Tag = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select vcode from tblinventory where pcode=" + Id + " and os !=0 and batchcode='" + Txt + "'"));
                        Txtopqty.textBox1.Text = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select os from tblinventory where pcode=" + Id + " and os !=0 and batchcode='" + Txt + "'")).ToString("0.00");
                        //Txtopqty.textBox1.Text = CommonClass._Dbtask.znllString(CommonClass._Inventory.GETSTOCKBYBARCODE(Txt));

                        string bunit = "";
                        bunit = CommonClass._Dbtask.znllString(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Txt, "baseU", Id));

                        if (bunit != "")
                        {
                            comunit.SelectedValue = Convert.ToInt32(bunit);
                        }
                        else
                        {
                            comunit.SelectedValue = "1";
                        }

                    }
                    else
                    {

                        Txtprate.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["prate"]));
                        Txtsrate.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["srate"]));
                        Txtmrp.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["Mrp"]));

                        Lblid.Tag = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select vcode from tblinventory where pcode=" + Id + " and os !=0 "));
                        Txtopqty.textBox1.Text = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select os from tblinventory where pcode=" + Id + " and os !=0 ")).ToString("0.00");
                    }
                    /***************************/

                }
            }
            else
            {
                Clear();
            }


            gridracklist.Visible = false;



        }
        public void Clear()
        {
            Fillcombo();
            EditMode = false;
            ItemCode();
            Cmdunitrefresh.Enabled = true;
            Txtopqty.textBox1.Enabled = true;
            txttaxsaleincluseive.textBox1.Text = CommonClass._Paramlist.GetParamvalue("Staxinclusive");
            txttaxpurchaseincluseive.textBox1.Text = "No";

            if (CommonClass._settings.FunSettings1("Batch") == true)
            {
                string bcodepre = "";
                bcodepre = CommonClass._Dbtask.znllString(CommonClass._Batch.GeUpdateBcodecreatePrefix());
                if (Txt == "" || Txt == null)
                {
                    Txt = bcodepre + "00" + Convert.ToString(CommonClass._Batch.GeUpdateBarcode());
                    Txtbarcode.textBox1.Text = bcodepre + "00" + Convert.ToString(CommonClass._Batch.GeUpdateBarcode());
                    Txtbarcode.textBox1.Tag = bcodepre + "00" + Convert.ToString(CommonClass._Batch.GeUpdateBarcode());

                }
                else
                {
                    //  Txt = "00" + Convert.ToString(CommonClass._Batch.GeUpdateBarcode());

                    Txt = bcodepre + Txt;
                    Txtbarcode.textBox1.Text = Txt;
                    Txtbarcode.textBox1.Tag = Txt;

                }
            }


            txtfind.Text = "";
            txtfind.Tag = "";
            //CommonClass._Batch.GeUpdateBarcode();
            TxtItemname.textBox1.Text = "";
            TxtItemcode.textBox1.Text = "";
            Txtsecondlangague.textBox1.Text = "";
            Txtitemnote.textBox1.Text = "";
            Txtvat.textBox1.Text = "0.00";
            Txtprate.textBox1.Text = "0.00";
            Txtsrate.textBox1.Text = "0.00";
            Txtvat.textBox1.Text = "15";
            Txtopqty.textBox1.Text = "0.00";
            Comitemclass.SelectedIndex = 0;
            gridracklist.Visible = false;
            Txtrackselect.Text = "";
            Txtrackselect.Tag = "";
            if (CommonClass._settings.FunSettings1("Batch") == true)
            {
                Txtbarcode.textBox1.Focus();
                Txtbarcode.textBox1.Select();
                Sbatch = true;

            }
            else
            {
                TxtItemname.textBox1.Focus();
                TxtItemname.textBox1.Select();
                Sbatch = false;
            }
            lblreorder.Visible = true;
            txtreorder.textBox1.Text = "0";
            Catbool = false;
            manbool = false;

            CommonClass._Gen.FillActivePrinter(comprint);


        }
        public void ClearTemp()
        {
            Txt = "";
            Catbool = false;
            manbool = false;
            Txtlastrate.textBox1.Text = "";
            if (Isinotherwindow == true)
            {
                this.Close();
            }
            else
            {
                Clear();
            }
        }
        private bool Main()
        {

            if (ValidationFu())
            {
                try
                {
                    if (EditMode == false)
                        ItemCode();

                    if (EditMode == true)
                    {
                        DeleteItems();
                        DeleteItemsAzureServer();
                    }
                    NextgInitialize();
                    Insert();
                    ClearTemp();

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

        public void Menusettings()
        {

            if (CommonClass._settings.FunSettings1("Batch") == true)
            {
                lblbarcode.Visible = true;
                Lblbarcodedot.Visible = true;
                Txtbarcode.Visible = true;
                Txtbarcode.textBox1.Text = Txt;
            }
            else
            {
                // TxtItemname.textBox1.Text=Txt;
            }

        }
        public void Fillcombo()
        {
            //CommonClass._ItemCategory.FillCombo(Comitemcategory,false);
            // CommonClass._Manufacturer.FillCombo(Comitemmanufacturer);
            _base.FillUnit(comunit);
            Comusemechine.SelectedIndex = 0;
        }
        public void visiblefalse()
        {
            //label17.Visible = false;
            //Comitemmanufacturer.Visible = false;
            label21.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            Txtmrp.Visible = false;
            string baseu = "";
            baseu = CommonClass._Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='302010' ").ToString();
            if (baseu == "1")
            {
                comunit.Visible = true; Lblbaseunit.Visible = true; LblbaseunitDot.Visible = true;
            }
        }
        public void vatset()
        {
            Txtvat.textBox1.Text = CommonClass._Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("taxpercset"));
        }

        private void Frmquickadditems_Load(object sender, EventArgs e)
        {
            IsinCloseStage = false;
            Fillcombo();
            if (EditMode == true)
            {
                Retrive();
            }
            else
            {
                Clear();
            }
            Menusettings();
            visiblefalse();
            CommonClass._Nextg.FormIcon(this);
            vatset();

            CommonClass._Gen.FillActivePrinter(comprint);
        }

        private void Txtopqty_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void Frmquickadditems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
            if (e.KeyValue == 27)
            {
                if (Gridmainlist.Visible == true)
                {
                    Gridmainlist.Visible = false;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            IsinCloseStage = true;
            this.Close();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Txtsrate_Load(object sender, EventArgs e)
        {

        }

        private void Txtbarcode_Leave(object sender, EventArgs e)
        {
            if (IsinCloseStage == false)
            {
                string chk = "";
                //var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
                string testbcode = Txtbarcode.textBox1.Text.ToString();
                chk = testbcode.Replace(" ", "");

                if (testbcode != "\"" && testbcode != "%" && testbcode != "'")
                {
                    if (CommonClass._Batch.SameNamealreadyexistNew(Txtbarcode.textBox1.Text.ToString()) == true && EditMode == false)
                    {

                        if (chk.Length < 1 || chk.Length > 50)
                        {
                            MessageBox.Show("Minimum. 1 character,white space's not considered as a character", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Txtbarcode.textBox1.Tag = "";
                            Txtbarcode.textBox1.Text = chk.ToString();
                            Txtbarcode.textBox1.Focus();
                        }

                        if (Txtbarcode.textBox1.Text != "")
                        {
                            MessageBox.Show("Barcode Already Exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Txtbarcode.textBox1.Tag = "";
                            Txtbarcode.textBox1.Text = "";
                            Txtbarcode.textBox1.Focus();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("These special characters not allowed", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txtbarcode.textBox1.Tag = "";
                    Txtbarcode.textBox1.Text = "";
                    Txtbarcode.textBox1.Focus();

                }
            }
            // TxtItemcode.textBox1.Text = TxtItemname.textBox1.Text;
        }

        private void TxtItemname_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("ItemName", "tblitemmaster", TxtItemname.textBox1);
            if (_dbtask.znllString(TxtItemcode.textBox1.Text)=="")
            {
                TxtItemcode.textBox1.Text = TxtItemname.textBox1.Text;
            }
            //else
            //{
            //    TxtItemcode.textBox1.Text = Txtitemnote.textBox1.Text + " " + TxtItemname.textBox1.Text;
            //}
        }

        private void Frmquickadditems_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsinCloseStage = true;
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
                            SearchingMode = false;
                            Txtitemcategory.textBox1.Text = Gridmainlist.SelectedRows[0].Cells["clnname"].Value.ToString();
                            Txtitemcategory.Tag = Gridmainlist.SelectedRows[0].Cells["clnname"].Tag;
                            SearchingMode = true;
                        }
                        if (Txtitemcategory.textBox1.Text == "")
                        {
                            Txtitemcategory.textBox1.Text = "None";
                            Txtitemcategory.Tag = 0;
                        }
                        Gridmainlist.Visible = false;

                        Catbool = false;

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

        public void DoubleClickGrid()
        {
            try
            {

                if (Gridmainlist.SelectedRows.Count > 0)
                {
                   
                   selectedRow = Gridmainlist.SelectedRows[0].Index;
                   
                    if(Catbool==true)
                    {
                        Txtitemcategory.textBox1.Text = _dbtask.znllString(Gridmainlist.Rows[selectedRow].Cells["clnname"].Value);
                        Txtitemcategory.textBox1.Tag = _dbtask.znllString(Gridmainlist.Rows[selectedRow].Cells["clnname"].Tag);
                    Catbool = false;
                    
                    }
                    if (manbool== true)
                    {
                        Txtmanufacturer.textBox1.Text = _dbtask.znllString(Gridmainlist.Rows[selectedRow].Cells["clnname"].Value);
                        Txtmanufacturer.textBox1.Tag = _dbtask.znllString(Gridmainlist.Rows[selectedRow].Cells["clnname"].Tag);
                       manbool = false;

                    }
                    Gridmainlist.Visible = false;

                    Catbool = false;
                    manbool = false;
                    
                   
                        
                }
                

            }
            catch
            {
            }

        }

        private void Txtitemcategory_Leave(object sender, EventArgs e)
        {
            //Gridmain.Visible = false;
            //Catbool = false;

        }

        private void Txtitemcategory_Enter(object sender, EventArgs e)
        {
            SearchingMode = true;
           
        }

        private void Txtitemcategory_TextChanged(object Sender, EventArgs e)
        {
            Catbool = true;
            CategoryShow();
        }

        private void Txtmanufacturer_Enter(object sender, EventArgs e)
        {
            
            SearchingMode = true;
        }

        private void Txtmanufacturer_Leave(object sender, EventArgs e)
        {
            //manbool = false;
           Gridmainlist.Visible = false;
        }

        private void Txtmanufacturer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
                            Txtmanufacturer.textBox1.Text = Gridmainlist.SelectedRows[0].Cells["clnname"].Value.ToString();
                            Txtmanufacturer.Tag = Gridmainlist.SelectedRows[0].Cells["clnname"].Tag;
                        }
                        if (Txtmanufacturer.textBox1.Text == "")
                        {
                            Txtmanufacturer.textBox1.Text = "None";
                            Txtmanufacturer.Tag = 0;
                        }
                        Gridmainlist.Visible = false;
                        SearchingMode = false;

                        manbool = false;


                    }
                    if (e.KeyValue == 27)
                    {
                        Gridmainlist.Visible = false;

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

        private void Txtmanufacturer_TextChanged(object Sender, EventArgs e)
        {
            manbool = true;
            if (SearchingMode == true)
            {
                Ds = CommonClass._Manufacturer.ShowManfacturer("where mname like N'%" + Txtmanufacturer.textBox1.Text + "%'");
                Gridmainlist.Rows.Clear();
                Gridmainlist.Visible = true;
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Gridmainlist.Rows.Add(1);
                    Gridmainlist.Rows[i].Cells["clnname"].Value = Ds.Tables[0].Rows[i]["mname"];
                    Gridmainlist.Rows[i].Cells["clnname"].Tag = Ds.Tables[0].Rows[i]["mid"];
                }
                this.Gridmainlist.Location = new System.Drawing.Point(274, 339);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Txtvat_Leave(object sender, EventArgs e)
        {
            Txtvat.textBox1.Text = Checkinvalidsave(CommonClass._Dbtask.znllString(Txtvat.textBox1.Text));
        }

        private void Txtprate_Leave(object sender, EventArgs e)
        {
            Txtprate.textBox1.Text = Checkinvalidsave(CommonClass._Dbtask.znllString(Txtprate.textBox1.Text));
        }

        private void Txtsrate_Leave(object sender, EventArgs e)
        {
            Txtsrate.textBox1.Text = Checkinvalidsave(CommonClass._Dbtask.znllString(Txtsrate.textBox1.Text));
            if (_dbtask.znlldoubletoobject(Txtprate.textBox1.Text) > 0 && _dbtask.znlldoubletoobject(Txtsrate.textBox1.Text) > 0)
            {
                if (_dbtask.znlldoubletoobject(Txtprate.textBox1.Text) > _dbtask.znlldoubletoobject(Txtsrate.textBox1.Text))
                {
                    MessageBox.Show("sale rate is less than purchase rate ...!");
                    Txtsrate.textBox1.Focus();
                }
            }
        
        }

        public string Checkinvalidsave(string value)
        {
            string invalid = "";
            invalid = invalid = value;
            if (value.Length > 8)
            {
                invalid = "";
            }
            else
            {
                invalid = value;
            }
            return invalid;
        }

        private void Txtopqty_Leave(object sender, EventArgs e)
        {
            Txtopqty.textBox1.Text = Checkinvalidsave(CommonClass._Dbtask.znllString(Txtopqty.textBox1.Text));
        }

        private void Txtlastrate_Leave(object sender, EventArgs e)
        {
            Txtlastrate.textBox1.Text = Checkinvalidsave(CommonClass._Dbtask.znllString(Txtlastrate.textBox1.Text));

            if (_dbtask.znlldoubletoobject(Txtsrate.textBox1.Text) > 0 && _dbtask.znlldoubletoobject(Txtlastrate.textBox1.Text) == 0)
            {
                Txtlastrate.textBox1.Text = _dbtask.znllString(Txtsrate.textBox1.Text);
            }
        
        
        }

        private void Txtlastrate_TextChanged(object Sender, EventArgs e)
        {
            if (CommonClass._Dbtask.znlldoubletoobject(Txtlastrate.textBox1.Text) > 100000000)
            {
                MessageBox.Show("check last sale rate");
            }
        }

        private void TxtItemcode_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("ItemCode", "tblitemmaster", TxtItemcode.textBox1);

        }

        private void Txtsecondlangague_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("llang", "tblitemmaster", Txtsecondlangague.textBox1);

        }

        //private void Gridmain_DoubleClick(object sender, EventArgs e)
        //{
        //    DoubleClickGrid();
        //}
        public void setbarcodedetails()
        {

            pnlbcodeprint.Visible = true;
            CommonClass._Gen.FillActivePrinter(comprint);
            lblpname.Text = "";lblpbcode.Text = "";
            lblpsrate.Text = "";lblpprate.Text = "";


            lblpname.Text = _dbtask.znllString(TxtItemname.textBox1.Text);
            lblpbcode.Text = _dbtask.znllString(Txtbarcode.textBox1.Text);
            lblpsrate.Text ="Srate:"+ _dbtask.znllString(Txtsrate.textBox1.Text); 
            lblpprate.Text ="Prate:"+ _dbtask.znllString(Txtprate.textBox1.Text);
            lblpsrate.Tag = _dbtask.znllString(Txtsrate.textBox1.Text);
            lblpprate.Tag = _dbtask.znllString(Txtprate.textBox1.Text);



            txtnoofcopybcode.textBox1.Focus();


        }

        private void Cmdbarcodeprint_Click(object sender, EventArgs e)
        {
            if(_dbtask.znllString(Txtbarcode.textBox1.Text)!="")
            {
            setbarcodedetails();
            }
        }



        private void cmdprint_Click(object sender, EventArgs e)
        {
            PrintBarcode();
            lblpname.Text = ""; lblpbcode.Text = "";
            lblpsrate.Text = ""; lblpprate.Text = "";
            lblpsrate.Tag = "";
            lblpprate.Tag = "";

            pnlbcodeprint.Visible = false;

        }
        public void PrintBarcode()
        {

            this.barCodeCtrl1.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Left;
           
            this.barCodeCtrl1.BarCodeHeight = 30;
           
            string StrHeader;
            /*************For Get Heading Barcode***********/

            //double Dbtemp = Convert.ToDouble(_Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=142"));
            //Itemid = _Dbtask.znllString(txtitemname.Tag);


            //if (Dbtemp == 1)
            //{
                StrHeader = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            //}
            //else
            //{
            //    StrHeader = WindowsFormsApplication2.CommonClass._Paramlist.GetParamvalue("BarcodeHeading");
            //}
            /*******************************************************/
            // string StrHeader = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            string Strpname = "";
            

            Barcodeprintingin = _Paramlist.GetParamvalue("Printbarcodein");
            //if (Barcodeprintingin == "Srate")
            //{
            //    Strprate = _Dbtask.znullDouble(txtsrate.Text);
            //    if (CommonClass._Paramlist.GetParamvalue("PrintTaxpurchase") == "-1")
            //    {
            //        Strprate = lblpprate.Text;//Strprate + Strprate * _Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "vat")) / 100;
            //    }
            //}
            //else if (Barcodeprintingin == "MRP")
            //{
            //    Strprate = _Dbtask.znullDouble(txtmrp.Text);
            //}
            string StrBarcode = lblpbcode.Text;
           // double temp = _Dbtask.znullDouble(txtqty.Text);
            int InNoofcpies = 1;
            if (txtnoofcopybcode.textBox1.Text == "")
            {
                InNoofcpies = 1;
            }
            else
            {
                InNoofcpies = Convert.ToInt32(txtnoofcopybcode.textBox1.Text);
            }

            
            this.barCodeCtrl1.bcdpic = true;
            this.barCodeCtrl1.ShowHeader = true;
            this.barCodeCtrl1.HeaderFont = new Font("Calibri", 8, FontStyle.Bold);
            this.barCodeCtrl1.ProductFont = new Font("Calibri", 8, FontStyle.Regular);
            this.barCodeCtrl1.Rsfont = new Font("Calibri", 9, FontStyle.Bold);
            this.barCodeCtrl1.FooterFont = new Font("Calibri", 8, FontStyle.Regular);
            this.barCodeCtrl1.HeaderText = StrHeader;
            //this.barCodeCtrl1.RupeeImgaeFu = Picrupee.BackgroundImage;
            this.barCodeCtrl1.PInfo = lblpname.Text;
            this.barCodeCtrl1.PInfo1 = ": " + lblpsrate.Tag;
            this.barCodeCtrl1.BarCode = StrBarcode;
            this.barCodeCtrl1.ShowFooter = true;
            this.barCodeCtrl1.Noofcpies = InNoofcpies;
            //this.barCodeCtrl1.seclang = _Dbtask.znllString(CommonClass._Itemmaster.SpecificField(Itemid, "llang"));
           // this.barCodeCtrl1.itemcodee = _Dbtask.znllString(CommonClass._Itemmaster.SpecificField(Itemid, "itemcode"));
            //string dateexs = ""; dateexs = _Dbtask.znllString(Dtexdate.Value);
            //string datemans = ""; datemans = _Dbtask.znllString(dtmanfactdate.Value);
            //string datess = "";

            //datess = (datemans.Substring(0, 10) + " - " + dateexs.Substring(0, 10));
            //this.barCodeCtrl1.exedate = datess;

            if (_Settings.FunSettings1("MdateBPrint") == true)
            {
                this.barCodeCtrl1.LeftMargin = 20;
                this.barCodeCtrl1.PrintManDate = true;
            }
            this.barCodeCtrl1.ThemalTopmargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LaserTop"));
            this.barCodeCtrl1.LeftMargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LeftBarcode"));
            this.barCodeCtrl1.DistanceBysticker = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Dissticker"));
            this.barCodeCtrl1.TopMargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LaserTop"));
            //this.barCodeCtrl1.PrintSingle("", "");
            for (int k = 0; k < InNoofcpies; k++)
            {

                this.barCodeCtrl1.Print(gridmain, this.barCodeCtrl1.Barcodeprintingin, "Roll", P1by1, comprint.Text);

            }
        }

        private void Gridmainlist_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlbcodeprint.Visible = false;
            lblpname.Text = ""; lblpbcode.Text = "";
            lblpsrate.Text = ""; lblpprate.Text = "";
            lblpsrate.Tag = "";
            lblpprate.Tag = "";
        }

        private void pnlimg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdlangconvert_Click(object sender, EventArgs e)
        {

            Txtsecondlangague.textBox1.Text = _t.Translate(TxtItemname.textBox1.Text.Trim(), "English", "Arabic");

        //    string getlang = "";
        // //getlang =  _langchange.changetoarabic(_dbtask.znllString(TxtItemname.textBox1.Text));

        // Txtsecondlangague.textBox1.Text = getlang;

        // //var result = Clsarabicchange.Translate(_dbtask.znllString(TxtItemname.textBox1.Text), "es|en", Encoding.UTF8);

        // string convertTo = "en|" + "fr";
        // //getlang = _langchange.transword(_dbtask.znllString(TxtItemname.textBox1.Text), convertTo);

        // string strSource_String = "FISH";
        // string strSource_Language = "en";

        //string str_Fr = _langchange.TranslateWithGoogle(strSource_String, strSource_Language + "|fr");

         //_langchange.functionloadanotheroneexe();

        }


        public void calculateautosratebasedprate()
        {
            if (_dbtask.znlldoubletoobject( Txtprate.textBox1.Text)>0 )
            {
                if (_dbtask.znlldoubletoobject(txtpratepercntage.textBox1.Text) > 0)
                {
                    double perc = 0; double crate = 0; double percamt = 0;
                    double vat = 0; double taxprate = 0; double autosrate = 0;
                   
                    
                    vat = _dbtask.znlldoubletoobject(Txtvat.textBox1.Text);
                    if (_dbtask.znllString(txttaxpurchaseincluseive.textBox1.Text).ToLower() == "no")
                    {

                        taxprate = (vat * _dbtask.znlldoubletoobject(Txtprate.textBox1.Text)) / (vat + 100);
                        crate = _dbtask.znlldoubletoobject(Txtprate.textBox1.Text) + taxprate;

                        perc = _dbtask.znlldoubletoobject(txtpratepercntage.textBox1.Text);
                    }
                    else
                    {
                        crate = _dbtask.znlldoubletoobject(Txtprate.textBox1.Text);

                        perc = _dbtask.znlldoubletoobject(txtpratepercntage.textBox1.Text);
                    }

                    percamt = (perc * crate) / 100;
                    autosrate = _dbtask.znlldoubletoobject(crate) + percamt;
                    Txtsrate.textBox1.Text =_dbtask.znllString( _dbtask.SetintoDecimalpoint(autosrate));
                    txtpratepercntage.textBox1.Text = _dbtask.znllString( perc);
                

                
                }
            }
        }
        private void txtpratepercntage_Leave(object sender, EventArgs e)
        {
            calculateautosratebasedprate();
        }

        private void Comitemclass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Main();
            }
        }

        private void Txtsrate_TextChanged(object Sender, EventArgs e)
        {
            txtpratepercntage.textBox1.Text = "";
        }

        private void chkontable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkontable.Checked == false)
            {
                ontable = "No";
            }
            else
            {
                ontable = "Yes";
            }
        }

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Isinotherwindow == false)
                {
                    find = true;
                    GridProductList.DataSource = null;
                    GridProductList.Columns.Clear();


                    GridProductList.Visible = true;

                    //Ds1 = _Dbtask.ExecuteQuery("select itemcode,itemid,itemname from tblitemmaster  where  itemName Like N'%" + _dbtask.znllString(txtfind.Text) + "%'");

                    Ds1 = _Dbtask.ExecuteQuery("SELECT TblItemMaster.itemid,TblItemMaster.Itemname,  "+
                    "   TblItemMaster.itemcode,tblbatch.bcode from Tblbatch  "+
                    "   INNER JOIN tblitemmaster  ON Tblbatch.ItemId=tblitemmaster.itemid  "+
                    "   where TblItemMaster.itemCode Like N'%" + _dbtask.znllString(txtfind.Text) + "%' OR   " +
                    "   TblItemMaster.ItemName Like N'%" + _dbtask.znllString(txtfind.Text) + "%'  or   " +
                    "   TblItemMaster.llang Like N'%" + _dbtask.znllString(txtfind.Text) + "%'   " +
                    "   or Tblbatch.bcode like N'%" + _dbtask.znllString(txtfind.Text) + "%' ");
                    GridProductList.DataSource = Ds1.Tables[0];
                    //GridProductList.Columns[0].Width = 250;

                    for (int i = 0; i < GridProductList.Columns.Count; i++)
                    {
                        if (GridProductList.Columns[i].Name.ToString() == "itemid")
                            GridProductList.Columns[i].Visible = false;
                        if (GridProductList.Columns[i].Name.ToString() == "itemcode")
                            GridProductList.Columns[i].Visible = false;



                    }
                    //GridProductList.Columns["ItemName"].Width = 20;

                }
            }
            catch
            {
            }
        }

        private void txtfind_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 39)
            {
                //GetIteminList = true;
            }
            find = true;

            if (GridProductList.Visible == true)
            {


                if (GridProductList.SelectedRows.Count > 0)
                {
                    selectedRow = GridProductList.SelectedRows[0].Index;

                    if (e.KeyValue == 40 && GridProductList.Rows[selectedRow].Cells[0].Value != null)
                    {
                        if (GridProductList.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            GridProductList.Rows[selectedRow + 1].Selected = true;
                            GridProductList.Rows[selectedRow].Selected = false;

                            GridProductList.CurrentCell = GridProductList.SelectedRows[0].Cells[1];
                        }
                    }
                    if (e.KeyValue == 38 && selectedRow != 0)
                    {

                        GridProductList.Rows[selectedRow - 1].Selected = true;
                        GridProductList.Rows[selectedRow].Selected = false;
                        GridProductList.CurrentCell = GridProductList.SelectedRows[0].Cells[1];
                    }
                    if (e.KeyValue == 13 && GridProductList.SelectedRows.Count > 0)
                    {
                        string grditemid = "";
                        string fINDBCODE = "";
                        grditemid = GridProductList.SelectedRows[0].Cells["itemid"].Value.ToString();
                        txtfind.Text = CommonClass._Itemmaster.SpecificField(grditemid, "itemname");
                        txtfind.Tag = _dbtask.znllString(GridProductList.SelectedRows[0].Cells["itemid"].Value);
                        fINDBCODE = _dbtask.znllString(GridProductList.SelectedRows[0].Cells["bcode"].Value);
                        //GetIteminList = false;

                        //GetIteminList = false;
                        GridProductList.Visible = false;



                        Id = _dbtask.znllString(txtfind.Tag);
                        Barcode = fINDBCODE;

                        if (Id != "" && Barcode!="")
                        {
                        Retrive();
                        }

                        //GetIteminList = false;
                        GridProductList.Visible = false;

                        find = false;
                        //Id = grditemid;
                        //EditMode = true;
                        //Retrive();

                    }

                }
            }
        }

        private void cmdfront_Click(object sender, EventArgs e)
        {
            Id = (Convert.ToInt32(Lblid.Text) + 1).ToString();
            if (CommonClass._Batch.Howmanyitems(Id) != "NO")
            {
                Barcode = CommonClass._Batch.Howmanyitems(Id);
                Retrive();
            }
            else
            {
                MessageBox.Show("Multiple items, Use ' Search ' methode");
                Clear();
            }
        }

        private void cmdback_Click(object sender, EventArgs e)
        {
             Id = (Convert.ToInt32(Lblid.Text) - 1).ToString();

             if (CommonClass._Batch.Howmanyitems(Id) != "NO")
             {
                 Barcode = CommonClass._Batch.Howmanyitems(Id);
                 Retrive();
             }
             else
             {
                 MessageBox.Show("Multiple items, Use ' Search ' methode");
                 Clear();
             }
         
        }

        private void GridProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (GridProductList.SelectedRows.Count > 0)
            {
                string grditemid = "";
                grditemid = GridProductList.SelectedRows[0].Cells["itemid"].Value.ToString();

                if (find == true)
                {
                    txtfind.Text = CommonClass._Itemmaster.SpecificField(grditemid, "itemname");
                    txtfind.Tag = grditemid;


                    Id = _dbtask.znllString(txtfind.Tag);
                    Retrive();

                    // GetIteminList = false;
                    GridProductList.Visible = false;

                    find = false;


                }
            }
        }

        private void Cmdunitrefresh_Click(object sender, EventArgs e)
        {
            Fillcombo();
        }

        private void cmdaddcatgory_Click(object sender, EventArgs e)
        {
            Frmitemgroup _Form = new Frmitemgroup();
            _Form.ShowDialog();
        }

        private void GridProductList_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void cmdaddmanfact_Click(object sender, EventArgs e)
        {
            FrmManufacturer _form = new FrmManufacturer(); ;
            _form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Txtsecondlangague.textBox1.Text = _t.Translate(TxtItemname.textBox1.Text.Trim(), "English", "Arabic");
        }

        private void Txtrackselect_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Isinotherwindow == false)
                {
                    gridracklist.DataSource = null;
                    gridracklist.Columns.Clear();


                    gridracklist.Visible = true;

                    Ds1 = _Dbtask.ExecuteQuery("select rid,rack from tblrack  where  rack Like N'%" + _dbtask.znllString(Txtrackselect.Text) + "%' order by rid");
                    gridracklist.DataSource = Ds1.Tables[0];
                    //GridProductList.Columns[0].Width = 250;

                    for (int i = 0; i < gridracklist.Columns.Count; i++)
                    {
                        if (gridracklist.Columns[i].Name.ToString() == "rid")
                            gridracklist.Columns[i].Visible = false;




                    }
                    gridracklist.Columns["rack"].Width = 103;

                }
            }
            catch
            {
            }
        }

        private void Txtrackselect_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (gridracklist.Visible == true)
            {


                if (gridracklist.SelectedRows.Count > 0)
                {
                    selectedRow = gridracklist.SelectedRows[0].Index;

                    if (e.KeyValue == 40 && gridracklist.Rows[selectedRow].Cells[0].Value != null)
                    {
                        if (gridracklist.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            gridracklist.Rows[selectedRow + 1].Selected = true;
                            gridracklist.Rows[selectedRow].Selected = false;

                            gridracklist.CurrentCell = gridracklist.SelectedRows[0].Cells[1];
                        }
                    }
                    if (e.KeyValue == 38 && selectedRow != 0)
                    {

                        gridracklist.Rows[selectedRow - 1].Selected = true;
                        gridracklist.Rows[selectedRow].Selected = false;
                        gridracklist.CurrentCell = gridracklist.SelectedRows[0].Cells[1];
                    }
                    if (e.KeyValue == 13 && gridracklist.SelectedRows.Count > 0)
                    {
                        string grditemid = "";
                        grditemid = gridracklist.SelectedRows[0].Cells["rid"].Value.ToString();
                        Txtrackselect.Text = _dbtask.znllString(_rack.FurackName(grditemid));
                        Txtrackselect.Tag = _dbtask.znllString(gridracklist.SelectedRows[0].Cells["rid"].Value);

                        // GetIteminList = false;
                        //Id = grditemid;
                        //EditMode = true;
                        //Retrive();

                    }

                }
            }
        }

        private void Txtrackselect_Leave(object sender, EventArgs e)
        {
            gridracklist.Visible = false;
        }
      
        private void btnserveradd_Click(object sender, EventArgs e)
        {
         

        }
    }
}
