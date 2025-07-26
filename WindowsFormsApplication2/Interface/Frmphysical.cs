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
    public partial class Frmphysical : Form
    {
        public Frmphysical()
        {
            InitializeComponent();
        }
        
        DBTask _Dbtask = new DBTask();
        DataSet DS = new DataSet();
        ClsInGrid _InGrid = new ClsInGrid();
        ClsItemMaster _itemmaster = new ClsItemMaster();
        ClsBusinessIssue _Bussinessissue = new ClsBusinessIssue();
        ClsIssueDetails _Issuedetails = new ClsIssueDetails();
        ClsInventory _Inventory = new ClsInventory();
        ClsInGrid _ingrid = new ClsInGrid();
        Clspurchase _Purchase = new Clspurchase();
        Clsbatch _batch = new Clsbatch();
        ClsUserDetails _UserDetails = new ClsUserDetails();
        Clssales _sales = new Clssales();
        NextGFuntion _Nextg = new NextGFuntion();
        public string SalesAccount;
        public string PreIssuecode;
        public string temp;
        public int retrivemode = 0;
        public string Vtype = "PS";
        public string columname;
        public string Batch;
        public DateTime ExDate;
        public DateTime ManDate;
      //  public bool SBatch = false;
        public bool Bmode = true;
        public bool IsinBatchList;
        public bool SearchBarcode = false;
        public int Rowindex;
        public int Columnindex;
        public string ItemId;
      //  public int Columnidex;
        public double NQTY;
        public double NPRATE;
        public double NAMOUNT;
        public double NSRATE;
        public double NACTUAL;
        public double NQTYHAND;
        double Templedouble;
        public bool searchbarcode=true;
        public bool EditMode = true;
        DataGridViewCellStyle dataGridViewCellStyleNew = new DataGridViewCellStyle();
        public double NMRP;
        public string BatchCode="";
        public string tempbcode;
        public string Itemname;
        public string Srate;
        public string prate;
        public string mrp;
        public string Itemcode;
        int selectedRow;
        int selectedrow1;
        public string StockAreaid = "0";
        public double Netqty = 0;

        public double NetActual;
        public double NetAmount = 0;
        public double NetPrate = 0;
        public double TAmount = 0;
        public bool IsEnter = false;
        /*menu setings*/
        public string Printerselect;
        public bool Sitemwiseagentcommision = false;
        public static bool SBatch = false;
        public bool SSitemDiscount = false;
        public bool SSfree = false;
        public bool Seditsrate = false;
        public bool STax = false;
        public bool SDepo = false;
        public bool Smrate = false;
        public bool Smunit = false;
        public bool Sagent = false;
        public bool Semployee = false;
        public bool Supdatesrate = false;
        public bool Useasbarcode = false;
        public bool SSsizes = false;
        public bool Sprintwhilesaving = false;
        public bool Spconfirmation = false;
        public bool SprintPreview = false;
        public bool SFlex;
        public bool SCashDesk;
        public bool SSerialnotracking;
        public bool Sinvoicediscount;
        DateTime Exdatee;
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)
            {
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }
                
                if (uscGridshow2.Visible == true)
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Down)
                    {
                        return true;
                    }
                    if (msg.WParam.ToInt32() == (int)Keys.Up)
                    {
                        return true;

                    }
                }
                 if (GridBatchlist.Visible == true)
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Down)
                    {
                        return true;
                    }
                    if (msg.WParam.ToInt32() == (int)Keys.Up)
                    {
                        return true;
                    }
                }

            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        public void GetVno()
        {
            _Bussinessissue.PVno2(SalesAccount.ToString(), Vtype);
            if (_Bussinessissue.Pvno != "")
            {
                txtvno.Text = Convert.ToString(_Bussinessissue.Pvno);
                txtvno.Text = txtvno.Text + Convert.ToString(_Bussinessissue.VnoStr);
            }
            else
            {
                txtvno.Text = Convert.ToString(_Bussinessissue.VnoStr);
            }
            txtvno.Tag = _Bussinessissue.IdSalesFu(SalesAccount, Vtype);
            txtvno.Text = txtvno.Tag.ToString();
            _Issuedetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
            _Bussinessissue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
            _Inventory.Vcode = txtvno.Tag.ToString();
        }
       

        private void Frmphysical_Load(object sender, EventArgs e)
        {
            clear();
        }

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.PanelBasedConversion(panel1);
            }
        }
        

        void txt_TextChanged(object sender, EventArgs e)
        {

            
            if ((sender as TextBox).Text=="")
            {
                if (columname!="clnitemname" && columname!="clnbatch" && columname!="clnslno")
                {
                    (sender as TextBox).Text = "0";

                }

            }
            GridMain.Rows[Rowindex].Cells[Columnindex].Value = (sender as TextBox).Text;
       

            NQTY = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnqty"].Value);
            NPRATE = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnprate"].Value);
            NACTUAL = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnactual"].Value);
            NQTYHAND = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnqtyhand"].Value);
            string temp = _Dbtask.znllString(GridMain.Rows[Rowindex].Cells[Columnindex].Value);

            
            if (columname == "clnitemcode")
            {
                if (SearchBarcode == true)
                {
                    ProductGridShow(temp);
                }
            }


            if (columname == "clnbatch")
            {
                LoadBatches((sender as TextBox).Text);
            }
            cellEnterCalculationpart();
            Totalcalculation();
            
        }
        public void LoadBatches(string Search)
        {
            GridBatchlist.CellBorderStyle = DataGridViewCellBorderStyle.None;                        //+ 34 * 3//
            CommonClass._Batch.BatchlistshowBaseonItem(ItemId, GridBatchlist, Search);
            Rectangle tempRect = GridMain.GetCellDisplayRectangle(GridMain.CurrentCell.ColumnIndex, GridMain.CurrentCell.RowIndex, false);
            _InGrid.ProductGridShowLocationSettGrid(GridBatchlist, tempRect.Left, tempRect.Top + tempRect.Height + 30);
            GridBatchlist.Columns[0].Width = GridBatchlist.Width - 10;
        }
        
        public void ProductGridShow(string WhereCondition)
        {
            try
            {
                _ingrid.ProductGridShowFixed(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, StockAreaid);

                // IsEnter = true;
                Rectangle tempRect = GridMain.GetCellDisplayRectangle(GridMain.CurrentCell.ColumnIndex, GridMain.CurrentCell.RowIndex, false);

                if (tempRect.Top > 400)
                    _ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top - tempRect.Height + 6 );
                else
                    _ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height + 25 );

                if (uscGridshow2.Visible == false)
                {
                    uscGridshow2.Visible = true;
                }
            }
            catch
            {
            }
        }


        public void cellEnterCalculationpart()
        {
            try
            {
                GridMain.Rows[Rowindex].Cells["clnprate"].Value = _Dbtask.SetintoDecimalpointStock(NPRATE);
                GridMain.Rows[Rowindex].Cells["clnactual"].Value = NACTUAL;
                NAMOUNT = NACTUAL * NPRATE;
                NQTY = NACTUAL-NQTYHAND;
                GridMain.Rows[Rowindex].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpointStock(NAMOUNT);
                GridMain.Rows[Rowindex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(NQTY);
            }
            catch
            {
            }
        }

       
       
     

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (columname == "clnqty" || columname == "clnrate")
            {
                Generalfunction.allowNumeric(sender, e, false);
            }
        }
        
       

        public void cellEnter()
        {
            
            if (columname == "clnslno")
            {
                SendKeys.Send("{Tab}");
            }
            if (columname == "clnitemname")
            {
                SendKeys.Send("{Enter}");
            }
            if (columname == "clnqty")
            {
                SendKeys.Send("{Enter}");
            }
   
            if (columname == "clnqtyhand")
            {
                SendKeys.Send("{Enter}");
            }
            if (columname == "clnmrp")
            {
                SendKeys.Send("{Enter}");
            }
            if (columname == "clnamount")
            {
                SendKeys.Send("{Enter}");
            }

            if (columname == "clnprate" || columname == "clnactual" || columname == "clnbatch")
            {
                GridMain.BeginEdit(true);
            }

            if (columname == "clnbatch")
            {

                if (clnbatch.ReadOnly == true)
                {
                    Getbatchcode();
                }
            }
        
        }
        public void Getbatchcode()
        {
            try
            {
                if (SBatch == true && SearchBarcode == false)
                {
                    if (retrivemode == 0)
                    {

                        if (_Dbtask.znllString(GridMain.Rows[Rowindex].Cells["clnbatch"].Value) == "")
                        {
                            if (Rowindex == 0 || EditMode == true)
                            {
                                if (Rowindex != 0)
                                {
                                    if (EditMode == true && GridMain.Rows[Rowindex - 1].Cells["clnbatch"].Tag != null && GridMain.Rows[Rowindex].Cells["clnbatch"].Tag == null)
                                    {
                                        if (Convert.ToDouble(GridMain.Rows[Rowindex - 1].Cells["clnbatch"].Tag) != 0)
                                        {
                                            GridMain.Rows[Rowindex].Cells["clnbatch"].Tag = Convert.ToDouble(GridMain.Rows[Rowindex - 1].Cells["clnbatch"].Tag) + 1;
                                            string BackValue = BarcodeBackValue(GridMain.Rows[Rowindex].Cells["clnbatch"].Tag.ToString());
                                            Batch = CommonClass._Batch.Batchstring + BackValue;
                                            GridMain.Rows[Rowindex].Cells["clnbatch"].Value = Batch;
                                            GridMain.Rows[Rowindex + 1].Cells["clnbatch"].Tag = 1;
                                        }

                                    }
                                }
                            }
                            else
                            {

                                GridMain.Rows[Rowindex].Cells["clnbatch"].Tag = Convert.ToDouble(GridMain.Rows[Rowindex - 1].Cells["clnbatch"].Tag) + 1;
                                Batch = (GridMain.Rows[Rowindex].Cells["clnbatch"].Tag).ToString();
                                Batch = CommonClass._Batch.Batchstring + CommonClass._Batch.BatchcodeSpecified(Batch);
                                GridMain.Rows[Rowindex].Cells["clnbatch"].Value = Batch;
                                GridMain.Rows[Rowindex + 1].Cells["clnbatch"].Tag = 1;

                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
        public void SetGridColumn()
        {
            try
            {
                GetMenusettings();

                Generalfunction.ActiveForm = this.Name.ToString();
                retrivemode = 0;
                //Textalignsett();

                Bmode = true;
                if (SBatch == false)/*For Batch Enabled*/
                {
                    clnbatch.Visible = false;
                }
            }
            catch
            {
            }
        }
        public void GetMenusettings()
        {
            try
            {
                _sales.FuFocusfirstRow();
                /*Batch*/
                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=103");
                if (temp == "1")
                {
                    SBatch = true;
                }
                /*Edit SalesRate*/
                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=112");
                if (temp == "1")
                {
                    Seditsrate = true;
                }
                /*Tax */
                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=14");
                if (temp == "1")
                {
                    STax = true;
                }

                /*Stock Area*/

                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=13");
                if (temp == "1")
                {
                    SDepo = true;
                }

                /*For Batch is Second*/

                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=121");
                if (temp == "1")
                {
                    Useasbarcode = true;
                }
                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=124");
                if (temp == "1")
                {
                    Supdatesrate = true;
                }
            }
            catch
            {
            }
        }
        public string BarcodeBackValue(string Value)
        {
            if (Value.Length == 1)
                Value = "00" + Value;
            else if (Value.Length == 2)
                Value = "0" + Value;
            return Value;
        }
        public void Totalcalculation()
        {

            try
            {
                if (Rowindex < GridMain.Rows.Count)
                {
                    GridMain.Rows[Rowindex].Cells["clnslno"].Value = Rowindex + 1;/* For SlNo*/
                    Netqty = 0;
                    NetPrate = 0;
                    NetAmount = 0;
                    

                    for (int i = 0; i < GridMain.Rows.Count; i++)  /* For Row NetAmount*/
                    {
                        if (GridMain.Rows[i].Cells["clnamount"].Value != null)
                        {
                            NetAmount = NetAmount + Convert.ToDouble(GridMain.Rows[i].Cells["clnamount"].Value);
                        }
                    }
                    
                }
            }
            catch
            {
            }
        }

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
                                            {
            try
            {
                if (columname == "clnitemcode")
                {
                    _ingrid.RowUpDownSelect(e.KeyValue, uscGridshow2.GridProductShow, selectedRow, uscGridshow2, GridMain);
                    if (e.KeyValue == 13)
                    {
                        if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                        {
                            GridMain.NotifyCurrentCellDirty(false);
                            selectedrow1 = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                            ItemId = Convert.ToString(uscGridshow2.GridProductShow.Rows[selectedrow1].Cells["itemid"].Value);

                            Itemcode = CommonClass._Itemmaster.SpecificField(ItemId, "itemcode");

                            Itemname = CommonClass._Itemmaster.SpecificField(ItemId, "itemname");
                            prate = CommonClass._Itemmaster.SpecificField(ItemId, "prate");
                            Srate = CommonClass._Itemmaster.SpecificField(ItemId, "srate");
                            mrp = CommonClass._Itemmaster.SpecificField(ItemId, "mrp");
                            GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = Itemcode;
                            GridMain.Rows[Rowindex].Cells["clnitemname"].Tag = ItemId;
                            GridMain.Rows[Rowindex].Cells["clnitemname"].Value = Itemname;
                            GridMain.Rows[Rowindex].Cells["clnprate"].Value = _Dbtask.ExecuteScalar("select prate from Tblitemmaster where itemid='" + ItemId + "'");
                            GridMain.Rows[Rowindex].Cells["clnsrate"].Value = Srate;
                            GridMain.Rows[Rowindex].Cells["clnmrp"].Value = mrp;
                            GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = uscGridshow2.GridProductShow.Rows[selectedrow1].Cells["itemcode"].Value;
                            GridMain.Rows[Rowindex].Cells["clnqtyhand"].Value = _Inventory.GetStock(" where  pcode ='" + ItemId + "'");
                            GridMain.Rows[Rowindex].Cells["clnqty"].Value = _Inventory.GetStock(" where  pcode ='" + ItemId + "'");
                            uscGridshow2.Visible = false;
                        }
                    }
                   
                    if (GridMain.Columns[Columnindex].Name == "clnitemcode")
                    {
                        if (e.KeyValue == 13)
                        {
                            int NowselectedRow;
                            string TempItemcode;
                            if (uscGridshow2.Visible == true)
                            {
                                NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                                TempItemcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["itemcode"].Value.ToString();
                            }
                            else
                            {
                                TempItemcode = _Dbtask.znllString(GridMain.Rows[Rowindex].Cells["clnitemcode"].Value);
                            }

                            GridMain.NotifyCurrentCellDirty(false);
                            DS = _Dbtask.ExecuteQuery("select * from TblItemMaster where itemcode='" + TempItemcode + "'");
                            if (DS.Tables[0].Rows.Count > 0)
                            {
                                string TemItemid = _Dbtask.ExecuteScalar("select itemid from TblItemMaster where itemcode='" + TempItemcode + "'");
                                ItemId = TemItemid;
                                GridMain.Rows[Rowindex].Cells["clnitemname"].Tag = TemItemid;
                                GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from Tblitemmaster where itemid='" + TemItemid + "'");
                                GridMain.Rows[Rowindex].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from Tblitemmaster where itemid='" + TemItemid + "'");
                                GridMain.Rows[Rowindex].Cells["clnactual"].Value = " ";
                                double Tempprate = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(ItemId, "prate"));
                                double Tempsrate = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(ItemId, "srate"));
                                double Tempmrp = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(ItemId, "mrp"));
                                GridMain.Rows[Rowindex].Cells["clnprate"].Value = _Dbtask.SetintoDecimalpoint(Tempprate);
                                GridMain.Rows[Rowindex].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(Tempmrp);
                                NACTUAL = _Dbtask.znullDouble(GridMain.Rows[Rowindex].Cells["clnactual"].Value.ToString());
                                NQTY = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnqty"].Value.ToString());
                                NPRATE = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnprate"].Value.ToString());
                                NQTYHAND = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnqtyhand"].Value.ToString());
                                GridBatchlist.Visible = false;
                                cellEnterCalculationpart();
                                Totalcalculation();
                            }
                            else
                            {
                                MessageBox.Show("Itemcode Not exsting");

                            }
                        }

                    }
                }
                if (columname == "clnbatch")
                        {

                    CommonClass._commenevent.UpDowninGridList(GridBatchlist, e.KeyValue, GridMain);
                    if (e.KeyValue == 13 && GridBatchlist.SelectedRows.Count > 0)
                    {
                        //if (GridMain.Rows[Rowindex].Cells["clnitemname"].Tag != null)
                        //{
                        //    if (GridMain.Rows[Rowindex].Cells["clnitemname"].Tag != "")
                        //    {
                        //        BatchCode = GridBatchlist.Rows[GridBatchlist.SelectedRows[0].Index].Cells[0].Value.ToString();
                        //    }
                        //    else
                        //    {
                        //        BatchCode = GridMain.Rows[Rowindex].Cells["clnbatch"].Value.ToString();
                        //    }
                        //}
                        
                        //else

                        if (GridMain.Rows[Rowindex].Cells["clnbatch"].Value != null &&_Dbtask.znllString( GridMain.Rows[Rowindex].Cells["clnbatch"].Value) != "")
                        {
                            BatchCode =_Dbtask.znllString( GridMain.Rows[Rowindex].Cells["clnbatch"].Value);
                        }
                       else
                        {

                        //    {00
                            BatchCode = GridBatchlist.Rows[GridBatchlist.SelectedRows[0].Index].Cells[0].Value.ToString();
}
                        //BatchCode = GridMain.Rows[Rowindex].Cells["clnbatch"].Value.ToString();
                            GridMain.Rows[Rowindex].Cells["clnbatch"].Value = _Dbtask.znllString(BatchCode);
                        IsinBatchList = true;
                        temp = _Dbtask.znllString(GridMain.Rows[Rowindex].Cells["clnbatch"].Value);
                        string ItemId = _Dbtask.ExecuteScalar("select itemid from Tblbatch where bcode='" + BatchCode + "'");
                        Itemcode = CommonClass._Itemmaster.SpecificField(ItemId, "itemcode");
                        Itemname = CommonClass._Itemmaster.SpecificField(ItemId, "itemname");
                        double Tempmrp1 = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(ItemId, "mrp"));
                        double Tempprate1 = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(ItemId, "prate"));
                        GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = Itemcode;
                        GridMain.Rows[Rowindex].Cells["clnitemname"].Value = Itemname;
                        GridMain.Rows[Rowindex].Cells["clnprate"].Value = Tempprate1;
                        GridMain.Rows[Rowindex].Cells["clnmrp"].Value = Tempmrp1;
                        GridMain.Rows[Rowindex].Cells["clnbatch"].Value = BatchCode;
                        BatchCode = GridMain.Rows[Rowindex].Cells["clnbatch"].Value.ToString();
                        GridMain.Rows[Rowindex].Cells["clnqtyhand"].Value = _Inventory.GetStock(" where   batchcode='" + BatchCode + "'  and pcode ='" + ItemId + "'");
                        GridMain.Rows[Rowindex].Cells["clnqty"].Value = _Inventory.GetStock(" where  batchcode='" + BatchCode + "' and pcode ='" + ItemId + "'");


                        GridBatchlist.Visible = false;


                    }

                }
                if (e.KeyValue == 123)
                {
                    if (SearchBarcode == true)
                    {
                        Falsesearchbarcode();
                    }
                    else
                    {
                        Truesearchbarcode();
                    }
                }
                
            }




            catch
            {
            }
        }
      
        public void AutomaticFillBatch()
        {
            GridMain.Rows.Clear();
            DS = _Dbtask.ExecuteQuery("SELECT    Tblbatch.itemid , TblItemMaster.ItemName, Tblbatch.Bcode FROM  Tblbatch INNER JOIN " +
                     " TblItemMaster ON Tblbatch.itemid = TblItemMaster.ItemId ORDER BY Tblbatch.itemid  ");
            for(int i=0;i<DS.Tables[0].Rows.Count;i++)
            {
                GridMain.Rows.Add(1);
                temp = DS.Tables[0].Rows[i]["bcode"].ToString();
                string ItemId = DS.Tables[0].Rows[i]["itemid"].ToString();
              //  Itemcode = CommonClass._Itemmaster.SpecificField(ItemId, "itemcode");
                Itemname = DS.Tables[0].Rows[i]["itemname"].ToString();

               // double Tempmrp1 = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(temp, "mrp"));
                //double Tempprate1 = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(temp, "prate"));
                GridMain.Rows[i].Cells["clnslno"].Value = i+1;
                GridMain.Rows[i].Cells["clnitemcode"].Value = Itemcode;
                GridMain.Rows[i].Cells["clnitemname"].Value = Itemname;
                GridMain.Rows[i].Cells["clnitemname"].Tag = ItemId;
                //GridMain.Rows[i].Cells["clnprate"].Value = Tempprate1;
                //GridMain.Rows[i].Cells["clnmrp"].Value = Tempmrp1;
                GridMain.Rows[i].Cells["clnbatch"].Value = temp;
               // BatchCode = GridMain.Rows[Rowindex].Cells["clnbatch"].Value.ToString();
               // GridMain.Rows[i].Cells["clnqtyhand"].Value = _Inventory.GetStock(" where   batchcode='" + temp + "'  and pcode ='" + ItemId + "'");
               // GridMain.Rows[i].Cells["clnqty"].Value = _Inventory.GetStock(" where  batchcode='" + temp + "' and pcode ='" + ItemId + "'");


                
            }
            GridBatchlist.Visible = false;
        }


        public void AutomaticFillBatchNEGETIVE()
        {
            GridMain.Rows.Clear();
            DateTime from; DateTime TO;
            //TO = /dtdate.Value;
            double SUMNET = 0;
            string vnn = "";
            from = dtdate.Value.AddYears(-1);
            SalesAccount = "2";
            vnn =_Dbtask.znllString( _Dbtask.ExecuteScalar("select max(issuecode)+1 from tblbusinessissue where issuetype='PS'"));
            DS = _Dbtask.ExecuteQuery("select * from tblbatch");



            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                double stock = 0;
                temp = DS.Tables[0].Rows[i]["bcode"].ToString();
                double rate = 0;
                rate = _Dbtask.znlldoubletoobject(DS.Tables[0].Rows[i]["prate"]);
                string ItemId = DS.Tables[0].Rows[i]["itemid"].ToString();

                stock = _Inventory.GetStock(" where   batchcode='" + temp + "'  and pcode ='" + ItemId + "'");

                Itemcode = CommonClass._Itemmaster.SpecificField(ItemId, "itemcode");
                Itemname = CommonClass._Itemmaster.SpecificField(ItemId, "itemname");
             
                double netamt = 0;

                if (stock < 0)
                {

                    double actual = 0;
                    if (stock < 0)
                    {
                        stock = stock * (-1);
                        actual = 0 + stock;


                        netamt = rate * actual;

                        SUMNET = SUMNET + netamt;
                    }

                    CommonClass._Inventory.Ledcode = SalesAccount;
                    CommonClass._Inventory.DCodeStr = StockAreaid;
                    CommonClass._Inventory.InvDateDt = System.DateTime.Today; ;

                    CommonClass._Inventory.PcodeStr = ItemId;
                    CommonClass._Inventory.Vcode = vnn;
                    CommonClass._Inventory.Batchcode = temp;



                    CommonClass._Inventory.ps = actual;

                    CommonClass._Inventory.InsertInventory();



                    if (Vtype == "PS")
                    {
                        _Issuedetails.SlNoLng = i + 1;
                        _Issuedetails.IssueCodeLng = Convert.ToInt64(vnn);
                        _Issuedetails.PCodeStr = ItemId;
                        _Issuedetails.ExDate=from;
                        _Issuedetails.ManDate = from;
                        _Issuedetails.QtyDb = stock;
                        _Issuedetails.RateDb = rate;
                        _Issuedetails.Qty1 = stock;
                        _Issuedetails.Qty2 = actual;
                        _Issuedetails.Vtype = Vtype;
                        _Issuedetails.NetAmtDb = netamt;
                        _Issuedetails.BatchIdStr = BatchCode;
                        _Issuedetails.Ledcode = SalesAccount;
                        _Issuedetails.InsertIssueDetails();
                    }

                   

                }


            }

            CommonClass._Nextg.SetVno(vnn );
            _Bussinessissue.VnoStr = vnn;
            _Bussinessissue.Pvno = "";
            _Bussinessissue.IssueTypeStr = Vtype;
            _Bussinessissue.DCode = StockAreaid;
            _Bussinessissue.IssueDateDt = System.DateTime.Today; ;
            _Bussinessissue.LedCodeCr = SalesAccount.ToString();
            _Bussinessissue.AMTDb = SUMNET;
            _Bussinessissue.InsertBusinessIssue();

        }


        public void ClearinFocusGrid()
        {

            EditMode = false;
            
            CommonClass._Nextg.ClearControles(GridMain);
            
            dtdate.Value = DateTime.Now;
            
            GridMain.AllowUserToResizeRows = false;
            GetVno();
            GridMain.Rows.Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool validationFu()
        {
            if(EditMode==true)
            {
                MessageBox.Show("Editing not allowed");
                txtvno.Focus();
                return false;
            }

                    if (txtvno.Text == "")
                    {
                        MessageBox.Show("Enter Vno");
                        txtvno.Focus();
                        return false;
                    }
                    return true;
         }
        private void cmdsave_Click(object sender, EventArgs e)
        {
            main();
            
        }
        
       private bool main()
        {
            if (EditMode == true)
            {

                //DeleteVoucher();
            }
            RowValidation();
            if (validationFu())
            {
               
                Initialize();
            }

            ClearinFocusGrid();
            return true;
        }
        
        public void RowValidation()
        {
            try
            {
                for (int i = 0; i < GridMain.Rows.Count; i++)
                {
                    if (SBatch == true)
                    {
                        if (GridMain.Rows[i].Cells["clnitemname"].Tag == null ||_Dbtask.znllString(GridMain.Rows[i].Cells["clnbatch"].Value)==null)
                        {
                            GridMain.Rows[i].Tag = -1;
                        }

                        else
                        {
                            GridMain.Rows[i].Tag = 1;
                            GridMain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                        }
                    }
                    else
                    {
                        if (GridMain.Rows[i].Cells["clnitemname"].Tag == null)
                        {
                            GridMain.Rows[i].Tag = -1;
                        }

                        else
                        {
                            GridMain.Rows[i].Tag = 1;
                            GridMain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                        }
                    }
                }

            }
            catch
            {
            }
        }
        public void clear()
        {
            EditMode = false;
            retrivemode = 10;
            SetGridColumn();
            CommonClass._Nextg.ClearControles(GridMain);
            dtdate.Value = DateTime.Now;
            GridMain.AllowUserToResizeRows = false;
            SalesAccount = "2";
            GetVno();
            txtvno.Focus();
            ChangeLanguage();

            if (SearchBarcode == true)
            {
                Truesearchbarcode();
            }
            else
            {
                Falsesearchbarcode();
            }

            CommonClass._Nextg.FormIcon(this);
        }
        public void Initialize()
        {
            DateTime exdate;
           
            for (int i = 0; i < GridMain.Rows.Count; i++)
            {
                if (GridMain.Rows[i].Tag != null)
                {
                    if (GridMain.Rows[i].Tag.ToString() == "1")
                    {

                        long Slno = Convert.ToInt64(i);
                        string pid = GridMain.Rows[i].Cells["clnitemname"].Tag.ToString();
                        double qtyhand = _Dbtask.znlldoubletoobject(GridMain.Rows[i].Cells["clnqtyhand"].Value);
                        double actual = _Dbtask.znlldoubletoobject(GridMain.Rows[i].Cells["clnactual"].Value);
                        double qty = _Dbtask.znlldoubletoobject(GridMain.Rows[i].Cells["clnqty"].Value);
                        double prate = _Dbtask.znlldoubletoobject(GridMain.Rows[i].Cells["clnprate"].Value);
                        double mrp = _Dbtask.znlldoubletoobject(GridMain.Rows[i].Cells["clnmrp"].Value);
                        double NetAmt = _Dbtask.znlldoubletoobject(GridMain.Rows[i].Cells["clnamount"].Value);
                        TAmount = TAmount + NetAmt;
                        if (SBatch == true)
                        {
                            BatchCode = GridMain.Rows[i].Cells["clnbatch"].Value.ToString();
                        }
                            if (SBatch == true)
                            {
                                CommonClass._Batch.CheckbarcodeandreturnMax(GridMain, i);
                                if (CommonClass.temp == "" || CommonClass.temp == null)
                                {
                                    CommonClass.temp = "0";
                                }

                                if (CommonClass._Dbtask.znllString(GridMain.Rows[i].Cells["clnbatch"].Tag) == "")
                                {
                                    GridMain.Rows[i].Cells["clnbatch"].Tag = CommonClass.temp;
                                }
                                BatchCode = GridMain.Rows[i].Cells["clnbatch"].Value.ToString();

                            }

                            CommonClass._Inventory.Os = 0;
                        CommonClass._Inventory.Ledcode = SalesAccount;
                        CommonClass._Inventory.DCodeStr = StockAreaid;
                        CommonClass._Inventory.InvDateDt = dtdate.Value;

                        CommonClass._Inventory.PcodeStr = pid;
                        CommonClass._Inventory.Vcode =txtvno.Tag.ToString();
                        CommonClass._Inventory.Batchcode = BatchCode;



                        CommonClass._Inventory.ps = qty;

                        CommonClass._Inventory.InsertInventory();

                        

                        if (Vtype == "PS")
                        {
                            _Issuedetails.SlNoLng = i+1;
                            _Issuedetails.PCodeStr = pid;
                            _Issuedetails.QtyDb = qty;
                            _Issuedetails.RateDb = prate;
                            _Issuedetails.Qty1 = qtyhand;
                            _Issuedetails.Qty2 = actual;
                            _Issuedetails.Vtype = Vtype;
                            _Issuedetails.NetAmtDb = NetAmt;
                            _Issuedetails.BatchIdStr = BatchCode;
                            _Issuedetails.ExDate = CommonClass._Dbtask.ZnullDatetime(01 / 01 / 1900 );
                            //_Issuedetails.m
                            
                            //_Issuedetails.ExDate = Convert.ToDateTime(Exdatee);
                            _Issuedetails.Ledcode = SalesAccount;
                            _Issuedetails.InsertIssueDetails();
                        }
                    }
                    
                }
                
                }
            CommonClass._Nextg.SetVno(txtvno.Text);
            _Bussinessissue.VnoStr = CommonClass._Nextg.vno;
            _Bussinessissue.Pvno = CommonClass._Nextg.pvno;
            _Bussinessissue.IssueTypeStr = Vtype;
            _Bussinessissue.DCode = StockAreaid;
            _Bussinessissue.IssueDateDt = dtdate.Value;
            _Bussinessissue.LedCodeCr = SalesAccount.ToString();
            _Bussinessissue.AMTDb = TAmount;
            _Bussinessissue.InsertBusinessIssue();
                   
            }
        public void GetPrevious(string Vno, bool Isinenter)
          {

            try
            {
                if (Convert.ToInt64(Vno) > 0)
                {
                    SetGridColumn();
                    string PreIssuecode = Vno;
                    retrivemode = 1;
                    DS = _Dbtask.ExecuteQuery("select * from TblBusinessIssue where issuecode='" + PreIssuecode + "' and issuetype='" + Vtype + "' and ledcodeCr='" + SalesAccount + "'");
                    if (DS.Tables[0].Rows.Count != 0)
                    {
                        GridMain.Rows.Clear();
                        EditMode = true;
                        if (DS.Tables[0].Rows[0]["pvno"].ToString() != "")
                        {
                            txtvno.Text = DS.Tables[0].Rows[0]["pvno"].ToString() + DS.Tables[0].Rows[0]["vno"].ToString();
                        }
                        else
                        {
                            txtvno.Text = DS.Tables[0].Rows[0]["vno"].ToString();
                        }
                        PreIssuecode = DS.Tables[0].Rows[0]["issuecode"].ToString();
                        txtvno.Tag = PreIssuecode.ToString();

                        _Issuedetails.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                        _Bussinessissue.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                        _Inventory.Vcode = PreIssuecode.ToString();


                        dtdate.Value = Convert.ToDateTime(DS.Tables[0].Rows[0]["issuedate"]);
                        DS = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + PreIssuecode + "'and ledcode ='" + SalesAccount + "' and Vtype='" + Vtype + "' order by slno asc");
                        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        {
                            GridMain.Rows.Add(1);
                            string tempSlno = (i + 1).ToString();
                            string tempitemid = DS.Tables[0].Rows[i]["pcode"].ToString();
                            double temppRate = Convert.ToDouble(DS.Tables[0].Rows[i]["rate"].ToString());
                             double tempNetAmt = Convert.ToDouble(DS.Tables[0].Rows[i]["NetAMT"].ToString());
                             if (SBatch == true)
                             {

                                 string tempBatchid = DS.Tables[0].Rows[i]["batchid"].ToString();
                                 GridMain.Rows[i].Cells["clnbatch"].Value = tempBatchid;
                             }
                             GridMain.Rows[i].Cells["clnitemcode"].Value = CommonClass._Itemmaster.SpecificField(tempitemid, "itemcode");
                           
                            GridMain.Rows[i].Cells["clnslno"].Value = tempSlno;
                            GridMain.Rows[i].Cells["clnitemname"].Value = CommonClass._Itemmaster.SpecificField(tempitemid, "itemname");
                            GridMain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                            GridMain.Rows[i].Cells["clnqtyhand"].Value = _Dbtask.znullDouble(DS.Tables[0].Rows[i]["qty1"].ToString());
                            GridMain.Rows[i].Cells["clnactual"].Value = _Dbtask.znullDouble(DS.Tables[0].Rows[i]["qty2"].ToString());
                            GridMain.Rows[i].Cells["clnqty"].Value = _Dbtask.znullDouble(DS.Tables[0].Rows[i]["qty"].ToString());
                            GridMain.Rows[i].Cells["clnprate"].Value = temppRate;
                            GridMain.Rows[i].Cells["clnmrp"].Value = _Dbtask.ExecuteScalar("select mrp from tblitemmaster where itemid='" + tempitemid + "'");
                            double tempQty2 = _Dbtask.znullDouble(DS.Tables[0].Rows[i]["qty2"].ToString());

                            NACTUAL = tempQty2;
                            GridMain.Rows[i].Cells["clnactual"].Value = _Dbtask.SetintoDecimalpointStock(tempQty2);
                            NQTY = _Dbtask.znullDouble(DS.Tables[0].Rows[i]["qty"].ToString());
                            NPRATE = temppRate;
                            NQTYHAND = _Dbtask.znullDouble(DS.Tables[0].Rows[i]["qty1"].ToString());
                            GridMain.Rows[i].Cells["clnprate"].Value = _Dbtask.SetintoDecimalpoint(temppRate);
                            Templedouble = _Dbtask.znullDouble(GridMain.Rows[i].Cells["clnprate"].Value.ToString()) * Convert.ToDouble(GridMain.Rows[i].Cells["clnactual"].Value.ToString());
                            Rowindex = i;

                            cellEnterCalculationpart();
                            RowValidation();
                        }
                       
                        retrivemode = 0;
                    }
                    else
                    {
                        if (IsEnter == false)
                        {
                            GetPrevious(((Convert.ToInt64(PreIssuecode)) - 1).ToString(), false);
                        }

                    }
                }
            }
            catch
            {
                clear();
            }
        }

        private void cmdback_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Tag) + 1).ToString(), false);
        }
        private void cmdrefresh_Click(object sender, EventArgs e)
        {
            ClearinFocusGrid();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
           
            if (EditMode == true)
            {
                if (_UserDetails.Permited() == true)
                {
                    DialogResult Result = MessageBox.Show("Delete ?", "Are you sure want to Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result.ToString() == "Yes")
                    {
                        DeleteVoucher();
                        //ForLogindetails("DELETE");
                        ClearinFocusGrid();
                       
                    }
                }
            }
        }
       
        public void DeleteVoucher()
        {
            _Dbtask.ExecuteNonQuery("delete from tblinventory where Vcode='" + txtvno.Tag + "' and Ledcode='" + SalesAccount + "' and " + Vtype + " !=0");
            _Dbtask.ExecuteNonQuery("delete from tblBusinessIssue where VNo='" + txtvno.Tag + "' and Ledcodecr='" + SalesAccount + "' and IssueType='" + Vtype + "'");
            _Dbtask.ExecuteNonQuery("delete from tblIssuedetails where issuecode='" + txtvno.Tag + "' and Ledcode='" + SalesAccount + "' and vtype='" + Vtype + "'");          
        }

        private void cmdfirst_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Tag) - 1).ToString(), false);
        }
        public void Falsesearchbarcode()
        {
            if (SBatch == true)
            {
                SearchBarcode = false;
                uscGridshow2.Visible = false;
                // dataGridViewCellStyleNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
                dataGridViewCellStyleNew.BackColor = System.Drawing.Color.Teal;
                dataGridViewCellStyleNew.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                dataGridViewCellStyleNew.ForeColor = System.Drawing.Color.White;
               //gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleNew;
                 GridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleNew;
              Chksearchingmode.Checked = false;
            }
        }
        private void Frmphysical_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
            if (e.KeyValue == 123)
            {
                if (SearchBarcode == true)
                {
                    Falsesearchbarcode();
                }
                else
                {
                    Truesearchbarcode();
                }
            }



        }
        public void Truesearchbarcode()
        {
            if (SBatch == true)
            {
                SearchBarcode = true;
                dataGridViewCellStyleNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                GridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleNew;
                
            }
        }
        private void GridMain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            Columnindex = GridMain.CurrentCell.ColumnIndex;
            Rowindex = GridMain.CurrentCell.RowIndex;
            columname = GridMain.Columns[Columnindex].Name.ToString();
            cellEnter();
            //if (GridMain.Rows[Rowindex].Cells[Columnindex].ReadOnly == true)
            //{
            //    SendKeys.Send("{Tab}");
            //}
            ItemId =_Dbtask.znllString(GridMain.Rows[Rowindex].Cells["clnitemname"].Tag);
            BatchCode = _Dbtask.znllString(GridMain.Rows[Rowindex].Cells["clnbatch"].Value);
           
            if(columname=="clnactual")
             GridMain.Rows[Rowindex].Cells["clnqtyhand"].Value = _Inventory.GetStock(" where   batchcode='" + BatchCode + "'  and pcode ='" + ItemId + "'");
        }

        private void GridMain_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridMain.Columns[Columnindex].Name.ToString() == "clnbatch")
                {
                    GridBatchlist.Visible = false;
                    if (IsinBatchList == true)
                    {
                        GridMain.Rows[Rowindex].Cells["clnbatch"].Value = BatchCode;
                        GridMain.NotifyCurrentCellDirty(false);
                        IsinBatchList = false;
                    }
                    Batch = GridMain.Rows[Rowindex].Cells["clnbatch"].Value.ToString();
                    string TempBatch = CommonClass._Dbtask.ExecuteScalar("select distinct bcode from tblbatch where bcode='" + Batch + "'");
                    string TempItemName = CommonClass._Dbtask.znllString(GridMain.Rows[Rowindex].Cells["clnitemname"].Value);
                    if (TempBatch != "" || TempItemName == "")
                    {
                        ItemId = _Dbtask.ExecuteScalar("select distinct itemid from tblbatch where bcode='" + Batch + "'");
                        _Purchase.RefillingRow(GridMain, ItemId, Rowindex, TempBatch);
                        BatchCode = GridMain.Rows[Rowindex].Cells["clnbatch"].Value.ToString();
                        GridMain.Rows[Rowindex].Cells["clnqtyhand"].Value = _Inventory.GetStock(" where   batchcode='" + BatchCode + "'  and pcode ='" + ItemId + "'");
                        GridMain.Rows[Rowindex].Cells["clnqty"].Value = _Inventory.GetStock(" where  batchcode='" + BatchCode + "' and pcode ='" + ItemId + "'");
                        GridMain.NotifyCurrentCellDirty(false);
                    }
                    if (Batch == "")
                        GridMain.Rows[Rowindex].Cells["clnamount"].Value = CommonClass._Dbtask.SetintoDecimalpoint(0);
                }
            }
            catch
            {
            }

        }

        private void GridMain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            
            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);
           
            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            
            txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

       

        public void Reset()
        {
            RowValidation();
            for (int i = 0; i < GridMain.Rows.Count; i++)
            {
                if (GridMain.Rows[i].Tag != null)
                {
                    if (GridMain.Rows[i].Tag.ToString() == "1")
                    {

                        string pid = GridMain.Rows[i].Cells["clnitemname"].Tag.ToString();
                        NQTYHAND= _Inventory.GetStock(" where  pcode ='" + pid + "'");

                        
                        NACTUAL = _Dbtask.znlldoubletoobject(GridMain.Rows[i].Cells["clnactual"].Value);

                        NQTY = NACTUAL - NQTYHAND;

                        Itemcode = CommonClass._Itemmaster.SpecificField(pid, "itemcode");

                        Itemname = CommonClass._Itemmaster.SpecificField(pid, "itemname");
                        prate = CommonClass._Itemmaster.SpecificField(pid, "prate");
                        Srate = CommonClass._Itemmaster.SpecificField(pid, "srate");
                        mrp = CommonClass._Itemmaster.SpecificField(pid, "mrp");

                        Rowindex = GridMain.Rows.Add(1);
                        GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = Itemcode;
                        GridMain.Rows[Rowindex].Cells["clnitemname"].Tag = pid;
                        GridMain.Rows[Rowindex].Cells["clnitemname"].Value = Itemname;
                        GridMain.Rows[Rowindex].Cells["clnprate"].Value = prate;
                        GridMain.Rows[Rowindex].Cells["clnsrate"].Value = Srate;
                        GridMain.Rows[Rowindex].Cells["clnmrp"].Value = mrp;

                        GridMain.Rows[Rowindex].Cells["clnqtyhand"].Value = NQTYHAND; 
                        GridMain.Rows[Rowindex].Cells["clnqty"].Value = NQTY;
                        GridMain.Rows[Rowindex].Cells["clnactual"].Value = NACTUAL;
                    }
                }
            }

        }

        private void cmdreset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Cmdfillautomatic_Click(object sender, EventArgs e)
        {
            AutomaticFillBatch();
        }

        private void Frmphysical_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Frmphysical_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Frmphysical_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Chksearchingmode_CheckedChanged(object sender, EventArgs e)
        {
            if (Chksearchingmode.Checked == true)
            {
                CommonClass._Menusettings.UpdateMenusettings("173", "1");
                Truesearchbarcode();
            }
            else
            {
                CommonClass._Menusettings.UpdateMenusettings("173", "-1");
                Falsesearchbarcode();
            }
        }

       }    
     }

    


