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
    public partial class Frmsalespos : Form
    {
        public Frmsalespos()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.DataGridView Gridbatchlist;
        Clssales _sales = new Clssales();
        ClsTable _Table = new ClsTable();
        ClsBusinessIssue _Bussinessissue = new ClsBusinessIssue();
        DBTask _Dbtask = new DBTask();
        DataSet DS = new DataSet();
        ClsIssueDetails _Issuedetails = new ClsIssueDetails();
        ClsInventory _Inventory = new ClsInventory();
        DataSet DS2=new DataSet();
        DataSet DS3 = new DataSet();
        ClsInGrid _ingrid = new ClsInGrid();
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        clsitemCategory _itemcategory = new clsitemCategory();
        ClsEmployeeMaster _EmployeeMaster = new ClsEmployeeMaster();
       // frmAddenquiry _AddEnqry = new frmAddenquiry();
        ClsAccountLedger _Ledger = new ClsAccountLedger();
        ClsAddenquiry _Addenq = new ClsAddenquiry();

        public int selectedRow;
        int k = 0;
        int i = 0;
        public bool SBatch = false;
        public bool Seditsrate=false;
        public bool SDepo = false;
        public bool Useasbarcode = false;
        public bool Supdatesrate = false;
        public bool STax = true;
        public double Templedouble;
     

        public double TaxAmut;
        public double TaxPerc;
        public string sql;

        public int Retrivemode1 = 0;
        public string cid;
        public string Vnoenq;
        public string ItemId;
        public bool EditMode=true;
        public string SalesAccount;
        public string Vtype;
        public int retrivemode=0;
        public string columname;
        public string Heading;
        public int Rowindex;
        public int Columnidex;
        public bool searchbarcode=true;
        public string StockAreaid = "0";
        public bool IsEnter=false;
        int selectedrow1;
        public string Itemname;
        public long KOTId;
        public string Itemcode;
        public string Srate;
        public string batchcode;
        public int ClickCount = 0;
        public string ClickItemId;
        public string StrPurticulars;
        public string StrPurticularsForLedger;
        public bool Bmode;
        public string temp;
        public bool Isinotherwindow = false;
        public bool NotExist = false;
        public string SelectedValue1;
        public string SelectedValue;
        public bool ClickPOS = false;

        public double NQTY;
        public double NRATE;
        public double NAMOUNT;
        public double NTOTAL=0;
        public double Nntotal;
        public double NDiscAmnt = 0;
        public double Nnetamt = 0;
        public double NCooly = 0;

        public double Netqty=0;
        public double NetAmount=0;
        public double NetRate=0;
        public double NetDiscount = 0;
        public double NetTotal=0;
        public double NetCooly = 0;

        private bool main()
        {
            if (Retrivemode1 == 0)
            {
                GetVno();
            }
            RowValidation();
            if (validationFu())
            {
                if (Vtype == "CRM")
                {
                    SBatch = false;
                }
                if (Retrivemode1 == 1)
                {

                    UpdateTable();
                    Retrivemode1 = 0;
                }
               
                    Initialize();
             
            }

            ClearinFocusGrid();
            return true;
        }
        public void UpdateTable()
        {
            DS = _Dbtask.ExecuteQuery("delete TblIssuedetails where IssueCode='" + txtvno.Tag + "'");
            //for(int i=0;i<GridMain.Rows.Count;i++)
            //{
            //    double uqty =Convert.ToDouble(GridMain.Rows[i].Cells["clnqty"].Value);
            //    double urate =Convert.ToDouble(GridMain.Rows[i].Cells["clnrate"].Value);

            //    sql = "update TblIssuedetails set qty='" + uqty + "',rate='" + urate + "',NetAMT='" + txttotal.Text + "',Vtype='" + Vtype + "' where IssueCode='" + txtvno.Tag + "' and Slno='" + i + "'";
            //    DS = _Dbtask.ExecuteQuery(sql);
            //    frmAddenquiry.ProductVno = txtvno.Text; 

            //}
        }
        public void ClearinFocusGrid()
        {
            EditMode = false;
            CommonClass._Nextg.ClearControles(pnlfirst);
            CommonClass._Nextg.ClearControles(GridMain);
            //_Dbtask.SetintoDecimalpoint(0);
            
            txtTblName.textBox1.Text = "";
            txtCustomer.Text = "";
            txtKotNo.textBox1.Text = "";
            Txtdiscount.Text = _Dbtask.SetintoDecimalpoint(0);
            Txtcooly.Text = _Dbtask.SetintoDecimalpoint(0);
            dtdate.Value = DateTime.Now;
            lbltime.Text = Convert.ToString(DateTime.Now);
            //GridMain.AutoSizeRowsMode = DataGridViewAutoSizeRowMode.None;
            GridMain.AllowUserToResizeRows = false;
            if (Retrivemode1 != 1)
            {
                GetVno();
            }
            GridMain.Rows.Clear();
            Totalcalculation();
            txttotal.Text = _Dbtask.SetintoDecimalpoint(0);
            GridCustomer.Visible = false;
            cmdTable.Text = "Table";
            
        }
        public bool validationFu()
        {
            if (txtvno.Text == "")
            {
                MessageBox.Show("Enter Vno");
                txtvno.Focus();
                return false;
            }
            return true;
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)//TxtProduct,Txtqty,TxtAmt,panel2/*
            {


                //if (this.ActiveControl.Name != "Gridbatchlist" || this.ActiveControl.Name != "pnlbill")
                //{
                    if (msg.WParam.ToInt32() == (int)Keys.Enter)
                    {
                        SendKeys.Send("{Tab}");
                        return true;
                    }
                    if (uscitemshowsimple1.Visible == true)
                    {
                        if (msg.WParam.ToInt32() == (int)Keys.Down)
                        {
                            // SendKeys.Send("{Tab}");
                            return true;
                        }
                        if (msg.WParam.ToInt32() == (int)Keys.Up)
                        {
                            //SendKeys.Send("{Tab}");
                            return true;

                        }
                    }
                    if (uscGridshow2.Visible == true)
                    {
                        if (msg.WParam.ToInt32() == (int)Keys.Down)
                        {
                            // SendKeys.Send("{Tab}");
                            return true;
                        }
                        if (msg.WParam.ToInt32() == (int)Keys.Up)
                        {
                            //SendKeys.Send("{Tab}");
                            return true;

                        }
                    }
                    if (GridCustomer.Visible == true)
                    {
                        if (msg.WParam.ToInt32() == (int)Keys.Down)
                        {
                            // SendKeys.Send("{Tab}");
                            return true;
                        }
                        if (msg.WParam.ToInt32() == (int)Keys.Up)
                        {
                            //SendKeys.Send("{Tab}");
                            return true;

                        }
                    }
                
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        public void RowValidation()
        {
            try
            {
                for (int i = 0; i < GridMain.Rows.Count; i++)
                {
                    if (GridMain.Rows[i].Cells["clnitemname"].Tag == null || Convert.ToDouble(GridMain.Rows[i].Cells["clnamount"].Value) == Convert.ToDouble(0))
                    {
                        GridMain.Rows[i].Tag = -1;
                        // gridmain.Rows[rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        GridMain.Rows[i].Tag = 1;
                        GridMain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }

            }
            catch
            {
            }
        }
        public void Initialize()
        {
           // frmAddenquiry _AddEnqry = new frmAddenquiry();
          //  GetPrevious();
            for (int i = 0; i < GridMain.Rows.Count; i++)
            {
                if (GridMain.Rows[i].Tag != null)
                {
                    if (GridMain.Rows[i].Tag.ToString() == "1")
                    {
                        //StrPurticulars = _GeneralLedger.PurticularsCreate(txttotal.Text, txtvno.Text);
                        //StrPurticularsForLedger = _GeneralLedger.PurticularsCreateForLedger(this.Text, txtvno);

                        long Slno = Convert.ToInt64(i);
                        //string SlTracking = _Dbtask.znllString(gridmain.Rows[i].Cells["clnserialno"].Value);
                        string pid = GridMain.Rows[i].Cells["clnitemname"].Tag.ToString();
                        //if (GridMain.Columns["clnbatch"].Visible != false)
                        //{
                        //    string batchcode = GridMain.Rows[i].Cells["clnbatch"].Value.ToString();
                        //}
                      
                        double qty = _Dbtask.gridnul(GridMain.Rows[i].Cells["clnqty"].Value);
                        double Srate = _Dbtask.gridnul(GridMain.Rows[i].Cells["clnrate"].Value);
                        double NetAmt = _Dbtask.gridnul(GridMain.Rows[i].Cells["clnamount"].Value);

                        if (SBatch == true && GridMain.Columns["clnbatch"].Visible==true)
                        {
                            batchcode = GridMain.Rows[i].Cells["clnbatch"].Value.ToString();
                        }
                        if (Vtype == "POS")
                        {
                            CommonClass._Inventory.Ledcode = SalesAccount;
                            CommonClass._Inventory.DCodeStr = StockAreaid;
                            CommonClass._Inventory.InvDateDt = dtdate.Value;
                            CommonClass._Inventory.PcodeStr = pid;
                            if (SBatch==true&&GridMain.Columns["clnbatch"].Visible == true)
                            {
                                CommonClass._Inventory.Batchcode = batchcode;
                            }
                            else
                            {
                                CommonClass._Inventory.Batchcode = "0";
                            }
                            CommonClass._Inventory.Sales = qty;
                            CommonClass._Inventory.Sr = 0;
                            CommonClass._Inventory.Dn = 0;
                            CommonClass._Inventory.InsertInventory();


                            _Issuedetails.SlNoLng = Slno;
                            _Issuedetails.PCodeStr = pid;
                            _Issuedetails.QtyDb = qty;
                            _Issuedetails.RateDb = Srate;
                            _Issuedetails.NetAmtDb = Convert.ToDouble(txttotal.Text);
                            if (SBatch==true&&GridMain.Columns["clnbatch"].Visible == true)
                            {
                                _Issuedetails.BatchIdStr = batchcode;
                            }
                            else
                            {
                                _Issuedetails.BatchIdStr = "0";
                            }
                            _Issuedetails.Ledcode = SalesAccount;
                            _Issuedetails.Vtype = Vtype;
                            _Issuedetails.InsertIssueDetails();
                        }
                         if (Vtype == "CRM")
                         {
                            
                         _Issuedetails.SlNoLng = Slno;
                         _Issuedetails.PCodeStr = pid;
                         _Issuedetails.QtyDb = qty;
                         _Issuedetails.RateDb = Srate;
                         _Issuedetails.NetAmtDb =Convert.ToDouble(txttotal.Text);
                         if (SBatch==true&&GridMain.Columns["clnbatch"].Visible == true)
                         {
                             _Issuedetails.BatchIdStr = batchcode;
                         }
                         else
                         {
                             _Issuedetails.BatchIdStr = "0";
                         }
                         _Issuedetails.Ledcode = SalesAccount;
                         _Issuedetails.Vtype = Vtype;
                         _Issuedetails.InsertIssueDetails();
                         }
                         if (Vtype == "KOT")
                         {

                             _Issuedetails.SlNoLng = Slno;
                             _Issuedetails.PCodeStr = pid;
                             _Issuedetails.QtyDb = qty;
                             _Issuedetails.RateDb = Srate;
                             _Issuedetails.NetAmtDb = Convert.ToDouble(txttotal.Text);
                             _Issuedetails.BatchIdStr = "0";
                             _Issuedetails.Ledcode = SalesAccount;
                             _Issuedetails.Vtype = Vtype;
                             _Issuedetails.InsertIssueDetails();
                         }
                    }
                }
            }
            CommonClass._Nextg.SetVno(txtvno.Text);

            if (Vtype == "KOT")
            {
                KOTId = Convert.ToInt64(txtvno.Text);
                _Table.UpdateTbl(Vtype, 1, KOTId, "where Id='" + txtTableId.Text + "'");
                if (txtTblName.textBox1.Tag != null && txtTblName.textBox1.Tag != "")
                {
                }
            }
            if (Vtype == "POS")
            {
                _Table.UpdateTbl(Vtype, -1, 0, "where Id='" + txtTableId.Text + "'");
                if (txtTblName.textBox1.Tag != null && txtTblName.textBox1.Tag != "")
                {
                }
            }
            if (Vtype == "POS")
            {
                _Bussinessissue.VnoStr = CommonClass._Nextg.vno;
                _Bussinessissue.Pvno = CommonClass._Nextg.pvno;
                _Bussinessissue.IssueTypeStr = Vtype;
                _Bussinessissue.DCode = StockAreaid;
                _Bussinessissue.IssueDateDt = dtdate.Value;
                _Bussinessissue.CoolyDb = _Dbtask.znullDouble(Txtcooly.Text);
                _Bussinessissue.DiscAmtDb = _Dbtask.znullDouble(Txtdiscount.Text);
                _Bussinessissue.LedCodeCr = SalesAccount.ToString();
                if (txtCustomer.Tag != null && txtCustomer.Tag != "")
                {
                    _Bussinessissue.LedCodeDr = txtCustomer.Tag.ToString();
                }
                _Bussinessissue.AMTDb = Convert.ToDouble(txttotal.Text);
                _Bussinessissue.InsertBusinessIssue();


                _GeneralLedger.VdateDt = dtdate.Value;
                _GeneralLedger.RefnoStr = SalesAccount;
                _GeneralLedger.SlNoLng = Convert.ToInt64(txtvno.Tag);
                _GeneralLedger.LedCodeStr = SalesAccount.ToString(); ;
                _GeneralLedger.CrAmt = 0;
                _GeneralLedger.VTypeStr = Vtype;
                _GeneralLedger.VnoStr = txtvno.Text;
                _GeneralLedger.CrAmt = Convert.ToDouble(txttotal.Text);
                _GeneralLedger.InsertGeneralLedger();


              
            }
            if (Vtype == "CRM" || Vtype == "KOT")
            {
                _Bussinessissue.VnoStr = CommonClass._Nextg.vno;
                _Bussinessissue.Pvno = CommonClass._Nextg.pvno;
                _Bussinessissue.IssueTypeStr = Vtype;
                _Bussinessissue.DCode = StockAreaid;
                _Bussinessissue.IssueDateDt = dtdate.Value;
                _Bussinessissue.LedCodeCr = SalesAccount.ToString();
                if (txtCustomer.Tag != null && txtCustomer.Tag != "")
                {
                    _Bussinessissue.LedCodeDr = txtCustomer.Tag.ToString();
                }
                _Bussinessissue.AMTDb = Convert.ToDouble(txttotal.Text);
                _Bussinessissue.Agent = comAgent.Text;
                _Bussinessissue.EmpId = comEmployee.Text;

                _Bussinessissue.InsertBusinessIssue();

                if (Vtype == "CRM")
                {
                }

            }
            
        }

       
        public void clear()
        {
            uscitemshowsimple1.Visible = false;
            EditMode = false;
           
           // RegistrationCheck();
            retrivemode = 10;
            CommonClass._Nextg.ClearControles(pnlfirst);
            CommonClass._Nextg.ClearControles(GridMain);
            GridMain.Rows.Clear();
            txtCustomer.Text = "";
            Txtdiscount.Text = _Dbtask.SetintoDecimalpoint(0);
            Txtcooly.Text = _Dbtask.SetintoDecimalpoint(0);
            txtTblName.textBox1.Text = "";
            dtdate.Value = DateTime.Now;
            lbltime.Text = Convert.ToString(DateTime.Now.TimeOfDay);
            GridMain.AllowUserToResizeRows = false;
            if (Vtype != "KOT")
            {
                SalesAccount = "2";
            }
            if (Vtype == "KOT")
            {
                lblvno.Text = "KOT No:";
            }
            if (Vtype == "POS")
            {
                txtKotNo.Visible = true;
                lblkotno.Visible = true;
                lblAgent.Visible = true;
                comAgent.Visible = true;
                txtKotNo.textBox1.Text = "";
            }
            SetGridColumn();
            Fill_Combo();
            GetVno();

            Totalcalculation();
            GridCustomer.Visible = false;
            txttotal.Text = _Dbtask.SetintoDecimalpoint(0);
            cmdTable.Text = "Table";

        }

       
        
        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (columname == "clnqty" || columname == "clnrate")
            {
                Generalfunction.allowNumeric(sender, e, false);
            }
        }

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            try
            {
                if (columname == "clnbatch")
                {
                        _ingrid.RowUpDownSelect(e.KeyValue, uscitemshowsimple1.GridProductShow, selectedRow, uscitemshowsimple1, GridMain);
                    if (e.KeyValue == 13)
                    {
                        if (uscitemshowsimple1.GridProductShow.SelectedRows.Count > 0)
                        {
                            selectedrow1 = uscitemshowsimple1.GridProductShow.SelectedRows[0].Index;
                            string selectedItem = Convert.ToString(uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["itemid"].Value);

                            Itemname = CommonClass._Itemmaster.SpecificField(selectedItem, "itemname");
                            Itemcode = CommonClass._Itemmaster.SpecificField(selectedItem, "ItemCode");
                            Srate = CommonClass._Itemmaster.SpecificField(selectedItem, "srate");
                            GridMain.Rows[Rowindex].Cells["clnitemname"].Value = Itemname;
                            GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = Itemcode;
                            
                            GridMain.Rows[Rowindex].Cells["clnrate"].Value = Srate;
                            GridMain.Rows[Rowindex].Cells["clnbatch"].Value = uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["bcode"].Value;
                            //GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["itemcode"].Value;

                            uscitemshowsimple1.Visible = false;
                        }
                        //if (ComTax.Text != null)
                        //{
                        //    retrivemode = 0;
                        //}
                    }
                    if (searchbarcode == false)
                    {
                        GridMain.Rows[Rowindex].Cells["clnbatch"].Value = (sender as TextBox).Text;
                    }
                    if (e.KeyValue == 27)
                    {
                        if (Gridbatchlist.Visible == true)
                        {
                            Gridbatchlist.Visible = false;
                        }
                    }
                    if (GridMain.Columns[Columnidex].Name == "clnbatch")
                    {
                        if (e.KeyValue == 13)
                        {
                            int NowselectedRow;
                            string TempBathcode;
                            if (uscitemshowsimple1.Visible == true)
                            {
                                NowselectedRow = uscitemshowsimple1.GridProductShow.SelectedRows[0].Index;
                                TempBathcode = uscitemshowsimple1.GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                            }
                            else
                            {
                                TempBathcode = _Dbtask.znllString(GridMain.Rows[Rowindex].Cells["clnbatch"].Value);
                            }
                          
                            GridMain.NotifyCurrentCellDirty(false);
                            DS = _Dbtask.ExecuteQuery("select * from Tblbatch where bcode='" + TempBathcode + "'");
                            if (DS.Tables[0].Rows.Count > 0)
                            {
                                string TemItemid = _Dbtask.ExecuteScalar("select itemid from Tblbatch where bcode='" + TempBathcode + "'");
                                ItemId = TemItemid;
                                GridMain.Rows[Rowindex].Cells["clnitemname"].Tag = TemItemid;
                                GridMain.Rows[Rowindex].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from Tblitemmaster where itemid='" + TemItemid + "'");
                                GridMain.Rows[Rowindex].Cells["clnqty"].Value = 1;
                                double TempSrate = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "srate"));
                                GridMain.Rows[Rowindex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);

                                NQTY = Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnqty"].Value);
                                NRATE = Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnrate"].Value);
                                uscitemshowsimple1.Visible = false;
                               
                                cellEnterCalculationpart();
                                Totalcalculation();

                                if (searchbarcode == false)
                                {
                                    GridMain.Rows.Add(1);
                                    GridMain.CurrentCell = GridMain.Rows[Rowindex + 1].Cells[0];
                                }
                            }
                            else
                            {
                                MessageBox.Show("Batchcode Not exsting");
                                //if (Useasbarcode == true)
                                //{
                                //    gridmain.CurrentCell = gridmain.Rows[rowindex].Cells["clnbatch"];
                                //}
                            }


                        }

                    }
                }
               
                    if (columname == "clnitemcode")
                    {

                        //RowClick((sender as TextBox).Text, e.KeyValue);
                        //(sender as TextBox).Text = GridMain.Rows[Rowindex].Cells[Columnidex].Value.ToString();
                        //if (e.KeyValue == 40)
                        //{
                        _ingrid.RowUpDownSelect(e.KeyValue, uscGridshow2.GridProductShow, selectedRow, uscGridshow2, GridMain);
                        // }
                        if (e.KeyValue == 13)
                        {
                            if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                            {
                                selectedrow1 = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                                string selectedItem = Convert.ToString(uscGridshow2.GridProductShow.Rows[selectedrow1].Cells["itemid"].Value);

                                Itemname = CommonClass._Itemmaster.SpecificField(selectedItem, "itemname");
                                Srate = CommonClass._Itemmaster.SpecificField(selectedItem, "srate");
                                GridMain.Rows[Rowindex].Cells["clnitemname"].Value = Itemname;
                                GridMain.Rows[Rowindex].Cells["clnrate"].Value = Srate;
                                // GridMain.Rows[Rowindex].Cells["clnbatch"].Value = uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["bcode"].Value;
                                GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = uscGridshow2.GridProductShow.Rows[selectedrow1].Cells["itemcode"].Value;

                                uscGridshow2.Visible = false;
                            }
                            //if (ComTax.Text != null)
                            //{
                            //    retrivemode = 0;
                            //}
                        }
                        //if (searchbarcode == false)
                        //{
                        //    GridMain.Rows[Rowindex].Cells["clnbatch"].Value = (sender as TextBox).Text;
                        //}
                        if (e.KeyValue == 27)
                        {
                            if (Gridbatchlist.Visible == true)
                            {
                                Gridbatchlist.Visible = false;
                            }
                        }
                       
                        if (GridMain.Columns[Columnidex].Name == "clnitemcode")
                        {
                            if (e.KeyValue == 13)
                            {
                                int NowselectedRow;
                                string TempItemcode;
                                if (uscGridshow2.Visible == true)
                                {
                                    NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                                    TempItemcode = uscGridshow2 .GridProductShow.Rows[NowselectedRow].Cells["itemcode"].Value.ToString();
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
                                    GridMain.Rows[Rowindex].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from Tblitemmaster where itemid='" + TemItemid + "'");
                                    GridMain.Rows[Rowindex].Cells["clnqty"].Value = 1;
                                    double TempSrate = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(ItemId, "srate"));
                                    GridMain.Rows[Rowindex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);

                                    NQTY = Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnqty"].Value);
                                    NRATE = Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnrate"].Value);
                                    uscGridshow2.Visible = false;

                                    cellEnterCalculationpart();
                                    Totalcalculation();

                                    //if (searchbarcode == false)
                                    //{
                                    //    GridMain.Rows.Add(1);
                                    //    GridMain.CurrentCell = GridMain.Rows[Rowindex + 1].Cells[0];
                                    //}
                                }
                                else
                                {
                                    MessageBox.Show("Itemcode Not exsting");
                                    //if (Useasbarcode == true)
                                    //{
                                    //    gridmain.CurrentCell = gridmain.Rows[rowindex].Cells["clnbatch"];
                                    //}
                                }


                            }

                        }
                    }
                }
               
            
            catch
            {
            }
            if (e.KeyValue == 113 && ItemId != null) /*For F2  Delete Rows */
            {
                try
                {
                    DialogResult Result = MessageBox.Show("Do You Want to Delete This Row?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result.ToString() == "Yes")
                    {

                        int selectedIndex = GridMain.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            GridMain.Rows.RemoveAt(selectedIndex);
                            Totalcalculation();
                        }
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Unable to remove selected row at this time");
                }
            }
        }
        public void SelectItemcode()
        {
           
              
        }

        public void InsertZeroValue()
        {
            if (GridMain.Rows[Rowindex].Cells["clnqty"] == null)
            {
                GridMain.Rows[Rowindex].Cells["clnqty"].Value = 0;
            }
            if (GridMain.Rows[Rowindex].Cells["clnrate"].Value == null)
            {
                GridMain.Rows[Rowindex].Cells["clnrate"].Value = 0;
            }
            if (GridMain.Rows[Rowindex].Cells["clnamount"].Value == null)
            {
                GridMain.Rows[Rowindex].Cells["clnamount"].Value = 0;
            }
            
            
        } 
        
             
        public void RowClick(string Value, int KeyValue)
        {
            try
            {
                GridMain.Rows[Rowindex].Cells["clnbatch"].Value = Value;
               CommonClass._Ingrid.PreviewKeyDownInGrid(KeyValue, uscitemshowsimple1,uscitemshowsimple1.GridProductShow, GridMain, IsEnter, Value, Convert.ToInt64(ItemId), Rowindex, Columnidex, "clnrate", "rate", "0");
              // uscitemshowsimple1.lblstock.Text = _Dbtask.SetintoDecimalpointStock(CommonClass._Ingrid.Stock);
                if (KeyValue == 13)
                {
                    ItemId = GridMain.Rows[Rowindex].Cells["clnbatch"].Tag.ToString();
                    IsEnter = false;
                    Value = GridMain.Rows[Rowindex].Cells["clnitemname"].Value.ToString();
                   uscitemshowsimple1.Visible = false;
                }
            }
            catch
            {
            }
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

            _Issuedetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
            _Bussinessissue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
            _Inventory.Vcode = txtvno.Tag.ToString();
        }

        public void ProductGridShowWithBatch(string WhereCondition)
        {
            try
            {
                _ingrid.BatchGridShow(uscitemshowsimple1, WhereCondition,uscitemshowsimple1.GridProductShow,StockAreaid,false,false,"");

                Rectangle temprect = GridMain.GetCellDisplayRectangle(GridMain.CurrentCell.ColumnIndex, GridMain.CurrentCell.RowIndex, false);
                if (temprect.Top > 400)
                {
                    _ingrid.ProductGridShowLocationSett(uscitemshowsimple1, temprect.Left, temprect.Top - temprect.Height + 6 * 3);
                }
                else
                {
                    _ingrid.ProductGridShowLocationSett(uscitemshowsimple1, temprect.Left-45, temprect.Top + temprect.Height-10);
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
        public void ProductGridShow(string WhereCondition)
        {
            try
            {
                _ingrid.ProductGridShowFixed(uscGridshow2, WhereCondition,uscGridshow2.GridProductShow, StockAreaid);

                // IsEnter = true;
                Rectangle tempRect = GridMain.GetCellDisplayRectangle(GridMain.CurrentCell.ColumnIndex, GridMain.CurrentCell.RowIndex, false);

                if (tempRect.Top > 400)
                    _ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top - tempRect.Height + 6 * 3);
                else
                    _ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left-40, tempRect.Top + tempRect.Height-6);

                if (uscGridshow2.Visible == false)
                {
                    uscGridshow2.Visible = true;
                }
            }
            catch
            {
            }
        }

        public void ProductGridShowLocationSett(UserControl UserControleName, int Left, int Top)
        {
            UserControleName.Left = Left;

            UserControleName.Top = Top + 10;
        }
        public void TaxCalcPart()
        {
            try
            {
                TaxAmut = 0;
                TaxPerc = 0;
                if (STax== true && ItemId != null)
                {
                    if (ComTax.Text!= "None")
                    {
                        double Qty = Convert.ToDouble(Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnqty"].Value));
                        double Rate = Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnrate"].Value);
                        double DiscAmt =Convert.ToDouble(Txtdiscount.Text);
                        double CoolyAmt = Convert.ToDouble(Txtcooly.Text);
                        double Amount = Qty * Rate;
                        Amount = Amount + CoolyAmt-DiscAmt;
                       // Amount = Amount - DiscAmt;
                        if (ComTax.Text== "VAT")
                        {
                            TaxPerc = Convert.ToDouble(_Dbtask.ExecuteScalar("select VAT from tblitemmaster where itemid='" + ItemId + "'"));

                            //TaxAmt =  Gross* TaxPerc / 100;
                        }
                        if (ComTax.Text == "CST")
                        {
                            TaxPerc = Convert.ToDouble(_Dbtask.ExecuteScalar("select CST from tblitemmaster where itemid='" + ItemId + "'"));

                        }
                        if (ComTax.Text == "Tax on MRP")
                        {
                            TaxPerc = Convert.ToDouble(_Dbtask.ExecuteScalar("select VAT from tblitemmaster where itemid='" + ItemId + "'"));


                        }
                        /*For Tax Calc **********************/
                        string Incs = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + ItemId + "'");
                       // double AddAmoutplusbilldiscount;
                        //NBillDisc = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnbilldiscount"].Value);
                        //NNetamout = NNetamout - NBillDisc;

                        if (Incs == "1")
                        {
                            double tempTaxPerc = 100 + TaxPerc;
                            TaxAmut = NAMOUNT * TaxPerc / tempTaxPerc;
                           // NGross = Gross - TaxAmt;
                            NAMOUNT = Amount + TaxAmut;

                        }
                        else
                        {
                            double tempTaxPerc = 100;
                            TaxAmut = NAMOUNT * TaxPerc / tempTaxPerc;

                            NAMOUNT = Amount + TaxAmut;
                        }

                        /*********************************/

                    }

                    //    if (Incs == "1")
                    //        {
                    //            double tempTaxPerc = 100;
                    //            TaxAmt = AddAmoutplusbilldiscount * TaxPerc / tempTaxPerc;;
                    //            NNetamout = NGross +TaxAmt;
                    //            NNetamout = NNetamout - NBillDisc;
                    //        }
                    //        else
                    //        {
                    //            double tempTaxPerc = 100 + TaxPerc;
                    //            TaxAmt = AddAmoutplusbilldiscount * TaxPerc / tempTaxPerc;
                    //            NNetamout = NGross + TaxAmt;
                    //            NNetamout = NNetamout - NBillDisc;
                    //        }

                    //    /*********************************/

                    //}
                    //NNetamout = NNetamout - NBillDisc;
                  //  gridmain.Rows[rowindex].Cells["ClntaxPer"].Value = _Dbtask.SetintoDecimalpoint(TaxPerc);
                    //NTaxamount = TaxAmt;
                    //gridmain.Rows[rowindex].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(NTaxamount);
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
                InsertZeroValue();
                //GridMain.Rows[Rowindex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(NQTY);
                //GridMain.Rows[Rowindex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpointStock(NRATE);
              //  GridMain.Rows[Rowindex].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpointStock(NAMOUNT);

                NAMOUNT = NQTY * NRATE;
                NAMOUNT = NAMOUNT + NCooly-NDiscAmnt;
              //  NAMOUNT = NAMOUNT - NDiscAmnt;
                

         
                //if (retrivemode == 0)
                //{
                //    TaxCalcPart();
                //}
                GridMain.Rows[Rowindex].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpointStock(NAMOUNT);
               
                
            }
            catch
            {
            }
        }
        public void Totalcalculation()
        {
           
            try
            {
                if (Rowindex < GridMain.Rows.Count)
                {
                    GridMain.Rows[Rowindex].Cells["clnslno"].Value = Rowindex + 1;/* For SlNo*/
                    Netqty = 0;
                    NetRate = 0;
                    NetAmount = 0;
                    NetTotal = 0;

                    for (int i = 0; i <GridMain.Rows.Count; i++)  /* For Row NetAmount*/
                    {
                        if (GridMain.Rows[i].Cells["clnamount"].Value != null)
                        {
                           NetAmount = NetAmount + Convert.ToDouble(GridMain.Rows[i].Cells["clnamount"].Value);
                        }
                    }
                    NetDiscount = _Dbtask.znullDouble(Txtdiscount.Text);
                    NetCooly = _Dbtask.znullDouble(Txtcooly.Text);

                    txttotal.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(NetAmount) + NetCooly - NetDiscount);
                }
            }
            catch
            {
            }
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text=="")
            {
                if (columname!="clnitemname" && columname!="clnbatch" && columname!="clnslno"&& columname!="clnitemcode")
                {
                    (sender as TextBox).Text = "0";

                }

            }
            GridMain.Rows[Rowindex].Cells[Columnidex].Value = (sender as TextBox).Text;

            NQTY =_Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnqty"].Value);
            NRATE = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnrate"].Value);

            string temp =_Dbtask.znllString(GridMain.Rows[Rowindex].Cells[Columnidex].Value);

            if (columname == "clnbatch")
                {
                    if (searchbarcode == true)
                    {

                        ProductGridShowWithBatch("where Tblbatch.bcode like N'%" + temp + "%'");
                       //uscitemshowsimple1.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_ingrid.Stock);
                    }
                     

                }
            if (columname == "clnitemcode")
            {
                ProductGridShow(temp);
                //("where TblItemMaster.Itemcode like '%" + temp + "%'");
            }
            
            //if (ComTax.Text!=null)
            //{
            //    retrivemode = 0;
            //}

            if (columname == "clnqty")
            {
                
            }

        
            cellEnterCalculationpart();
            TaxCalcPart();
            Totalcalculation();
            
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
            if (Vtype != "CRM")
            {
                //if (columname == "clnqty")
                //{
                //    SendKeys.Send("{Enter}");
                //}
                if (columname == "clnrate")
                {
                    SendKeys.Send("{Enter}");
                }
            }
            if (columname == "clnamount")
            {
                SendKeys.Send("{Enter}");
            }
            if (columname == "clnrate" || columname == "clnqty")
            {
                //  GridMain.Rows[Rowindex].Cells["clnbatch"].Value = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnbatch"].Value);
                GridMain.BeginEdit(true);
            }
        }

      
        private void cmdfront_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Tag) + 1).ToString(), false);
        }
        public void GetPrevious(string Vno, bool Isinenter)
        {
            try
            {
                if (Convert.ToInt64(Vno) > 0)
                    {
                    SetGridColumn();
                    string PreIssuecode = Vno;
                    Retrivemode1 = 1;
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

                            string CustTag = DS.Tables[0].Rows[0]["LedcodeDr"].ToString();
                            string Custmr = _Dbtask.ExecuteScalar("select Lname from TblAccountLedger where Lid='" + CustTag + "'");
                            txtCustomer.Text = Custmr;
                            txtCustomer.Tag = CustTag;
                            if (Vtype == "POS" || Vtype == "KOT")
                            {
                                string TblId = DS.Tables[0].Rows[0]["FTable"].ToString();
                                string tblName = _Dbtask.ExecuteScalar("select Name from TblTable where Id='" + TblId + "'");
                                txtTblName.textBox1.Text = tblName;
                                txtTblName.textBox1.Tag = TblId;
                                cmdTable.Text = tblName;
                            }

                            double cooly = _Dbtask.znullDouble(DS.Tables[0].Rows[0]["cooly"].ToString());
                            double Discnt = _Dbtask.znullDouble(DS.Tables[0].Rows[0]["DiscAmt"].ToString());
                           
                            Txtcooly.Text = cooly.ToString();
                            Txtdiscount.Text = Discnt.ToString();
                            dtdate.Value = Convert.ToDateTime(DS.Tables[0].Rows[0]["issuedate"]);
                          
                            DS = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + PreIssuecode + "'and vtype='" + Vtype + "' and ledcode ='" + SalesAccount + "'order by slno asc");
                            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                            {
                                GridMain.Rows.Add(1);
                                string tempSlno = (i + 1).ToString();
                                string tempitemid = DS.Tables[0].Rows[i]["pcode"].ToString();
                                double tempQty = Convert.ToDouble(DS.Tables[0].Rows[i]["qty"].ToString());
                                double tempsRate = Convert.ToDouble(DS.Tables[0].Rows[i]["Rate"].ToString());
                                double tempNetAmt = Convert.ToDouble(DS.Tables[0].Rows[i]["NetAMT"].ToString());
                                string tempBatchid = DS.Tables[0].Rows[i]["batchid"].ToString();
                                

                                GridMain.Rows[i].Cells["clnbatch"].Value = tempBatchid;
                                GridMain.Rows[i].Cells["clnslno"].Value = tempSlno;
                                GridMain.Rows[i].Cells["clnamount"].Value = tempNetAmt;
                                GridMain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
                                GridMain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                                GridMain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                                GridMain.Rows[i].Cells["clnitemcode"].Tag = tempitemid;
                                txttotal.Text =_Dbtask.SetintoDecimalpoint(Convert.ToDouble(tempNetAmt));

                                NQTY = tempQty;
                                GridMain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);

                                NRATE = tempsRate;
                                GridMain.Rows[i].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(tempsRate);
                                GridMain.Rows[i].Cells["clnrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");

                                Templedouble = Convert.ToDouble(GridMain.Rows[i].Cells["clnrate"].Value) * Convert.ToDouble(GridMain.Rows[i].Cells["clnqty"].Value);
                                Rowindex = i;

                                cellEnterCalculationpart();
                                RowValidation();
                            }
                            Totalcalculation();
                           // Retrivemode1 = 0;
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

        public void SetGridColumn()
        {
            try
            {
                GetMenusettings();

                Generalfunction.ActiveForm = this.Name.ToString();
                retrivemode = 0;
                Textalignsett();
                this.Text = Heading;
               
                Bmode = true;             
                if (SBatch == false)/*For Batch Enabled*/
                {
                    clnbatch.Visible = false;
                    clnitemname.ReadOnly = false;
                }
               if (Seditsrate == false)
                {
                    clnrate.ReadOnly = true;
                }
               if (STax == false)
               {
                 //  clntax.Visible = false;
                   //ClntaxPer.Visible = false;
                   ComTax.Visible = false;
                   lbltax.Visible = false;
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
        public void Textalignsett()
        {
            GridMain.Columns["clnqty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain.Columns["clnbatch"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain.Columns["clnslno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain.Columns["clnrate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain.Columns["clnitemname"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain.Columns["clnamount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void cmdback_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Tag) - 1).ToString(), false);
        }

       
        public void Fill_CategrorItem()
        {
            k = 0;
            GridItemList.AllowUserToAddRows = true;
            cid = Convert.ToString(GridItem.CurrentCell.Tag);
            DS = _Dbtask.ExecuteQuery("select ItemName,CategoryId,itemId from TblItemMaster where CategoryId='" + cid + "'");
            try
            {
                GridItemList.Rows.Clear();
              
                for (int i = 0; i < DS.Tables[0].Rows.Count; )
                {

                    GridItemList.Rows.Add(1);
                    GridItemList.Rows[k].Height = 65;
                    
                    for (int j = 0; j < 8; j++)
                    {
                        if (i >= DS.Tables[0].Rows.Count)
                        {
                            break;
                        }
                        string itemId = DS.Tables[0].Rows[i]["ItemId"].ToString();
                        GridItemList.Rows[k].Cells[j].Tag = itemId;
                        GridItemList.Rows[k].Cells[j].Value = _Dbtask.ExecuteScalar("select ItemName from TblItemMaster where ItemId='" + itemId + "'");
                       // (GridItemList.Rows[k].Cells[j].Value as Button).BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Fried_Egg_Plate;

                        i++;
                    }
                    k++;

                }
            }
            catch
            {
            }
            GridItemList.AllowUserToAddRows = false;
        }

       

        public void Fill_Category()
        {
            k = 0;
            GridItem.AllowUserToAddRows = true;
            DS = _Dbtask.ExecuteQuery("select * from TblItemCategory");
            try
            {
                GridItem.Rows.Clear();
                GridItem.Columns.Clear();
                for (int cell = 0; cell < 8; cell++)
                {
                    GridItem.Columns.Add("cln" + cell, "");
                    GridItem.Rows[0].Cells["cln" + cell] = new DataGridViewButtonCell();
                }

                    for (int i = 0; i < DS.Tables[0].Rows.Count; )
                    {
                        if (i < DS.Tables[0].Rows.Count)
                        {
                            GridItem.Rows.Add(1);

                            GridItem.Rows[k].Height = 45;

                            for (int j = 0; j < 8; j++)
                            {

                                //GridItem.Rows[k].Height = 40;
                                if (i < DS.Tables[0].Rows.Count)
                                {
                                    cid = DS.Tables[0].Rows[i]["CategoryId"].ToString();
                                    //GridItem.Columns.Add("", "");
                                    GridItem.Rows[k].Cells[j] = new DataGridViewButtonCell();
                                    GridItem.Rows[k].Cells[j].Tag = cid;
                                    GridItem.Rows[k].Cells[j].Value = _Dbtask.ExecuteScalar("select Category from TblItemCategory where CategoryId='" + cid + "'");

                                    //if (Convert.ToInt16(cid) > 20)
                                    //{
                                    //}
                                    i++;
                                }
                            }
                            k++;
                        }
                    }
            }
            catch
            {
            }
            GridItem.AllowUserToAddRows = false;
            //GridItem.Rows.RemoveAt(GridItem.Rows.Count - 1);
        }

        private void Frmsalespos_Load(object sender, EventArgs e)
        {
            //if (Vtype == "POS")
            //{
            //    GridMain.Columns["clnitemcode"].Visible = false;
            //    GridMain.Columns["clnbatch"].Visible = true;
            //}
            if (Vtype == "CRM")
            {
               // GridMain.Columns["clnbatch"].Visible = false;
                //GridMain.Columns["clnitemcode"].Width =150 ;
                //GridMain.Columns["clnitemcode"].Visible = true;
                lblvno.Text = "VNo";

                if (Retrivemode1 == 1)
                {
                    SalesAccount = "2";
                   
                   FillGridEdit();
                }
                
            }
            if (Retrivemode1 != 1)
            {
                if (Isinotherwindow == false)
                {
                    clear();
                }
                else
                {
                    SalesAccount = FrmReport.MainAccount;
                    string Issuecode = FrmReport.ClickCode;
                    GetPrevious((Convert.ToInt64(Issuecode)).ToString(), false);
                }
            }
            

            Fill_Category();
            Fill_Combo();

        }
        public void FillGridEdit()
        {
            DS = _Dbtask.ExecuteQuery("select * from Tbladdenquiry where enqvno='" + Vnoenq + "' ");
            //DS2 = _Dbtask.ExecuteQuery("select * from TblIssuedetails where IssueCode='" + Vnoenq + "'");
            if (DS.Tables[0].Rows.Count > 0)
            {
                string Pvno=DS.Tables[0].Rows[0]["ProductVno"].ToString();
                if(Pvno=="0")
                {
                    GetVno();
                }
                else
                {
                txtvno.Text = DS.Tables[0].Rows[0]["ProductVno"].ToString();
                }
                dtdate.Value = Convert.ToDateTime(DS.Tables[0].Rows[0]["enqtime"]);
                string preIssuecode = txtvno.Text;

                DS2 = _Dbtask.ExecuteQuery("select * from TblIssuedetails where IssueCode='" + txtvno.Text + "'");
                if (DS2.Tables[0].Rows.Count > 0)
                {
                    preIssuecode = DS2.Tables[0].Rows[0]["IssueCode"].ToString();
                    txtvno.Tag = preIssuecode.ToString();

                    _Issuedetails.IssueCodeLng = Convert.ToInt64(preIssuecode);
                     _Bussinessissue.IssueCodeLng = Convert.ToInt64(preIssuecode);

                    //_Inventory.Vcode = PreIssuecode.ToString();

                    //dtdate.Value = Convert.ToDateTime(DS.Tables[0].Rows[0]["issuedate"]);
                    //ComDepot.SelectedValue = Ds2.Tables[0].Rows[0]["Dcode"];
                    //txtCustomer.Tag = Ds2.Tables[0].Rows[0]["Ledcodedr"];
                    //TxtAccount.Text = Ds2.Tables[0].Rows[0]["Tename"].ToString();
                    for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                    {
                        GridMain.Rows.Add(1);
                        string tempSlno = (i + 1).ToString();
                        string tempitemid = DS2.Tables[0].Rows[i]["pcode"].ToString();
                        double tempQty = Convert.ToDouble(DS2.Tables[0].Rows[i]["qty"].ToString());
                       // double tempfree = Convert.ToDouble(Ds.Tables[0].Rows[i]["freeqty"].ToString());
                        double tempsRate = Convert.ToDouble(DS2.Tables[0].Rows[i]["Rate"].ToString());
                       // double tempMrp = Convert.ToDouble(Ds.Tables[0].Rows[i]["Mrp"].ToString());
                        double tempdiscrate = Convert.ToDouble(DS2.Tables[0].Rows[i]["DiscRate"].ToString());
                        double temptaxrate = Convert.ToDouble(DS2.Tables[0].Rows[i]["Taxrate"].ToString());
                        double tempamount = tempQty * tempsRate;

                        double tempNetAmt = Convert.ToDouble(DS2.Tables[0].Rows[i]["NetAMT"].ToString());
                        double temptaxperc = Convert.ToDouble(DS2.Tables[0].Rows[i]["taxper"].ToString());
                        //string tempBatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();
                      //  string Slnotracking = Ds.Tables[0].Rows[i]["slnotracking"].ToString();


                        //gridmain.Rows[i].Cells["clnbatch"].Value = tempBatchid;
                        GridMain.Rows[i].Cells["clnslno"].Value = tempSlno;
                        //GridMain.Rows[i].Cells["clnserialno"].Value = Slnotracking;
                        GridMain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                        GridMain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
                        GridMain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                        //GridMain.Rows[i].Cells["qty"].Value = tempQty;


                        NQTY = tempQty;
                        GridMain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);

                        GridMain.Rows[i].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpointStock(tempamount);

                        //NFree = tempfree;
                        //GridMain.Rows[i].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(tempfree);

                        NRATE = tempsRate;
                        GridMain.Rows[i].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(tempsRate);
                        GridMain.Rows[i].Cells["clnrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");

                        //NMrp = tempMrp;
                        //gridmain.Rows[i].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(tempMrp);

                       // NDiscamt = tempdiscrate;
                       // gridmain.Rows[i].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpoint(tempdiscrate);

                        //NTaxamount = temptaxrate;
                        //gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(temptaxrate);

                        //NTaxperc = temptaxperc;
                        //gridmain.Rows[i].Cells["ClntaxPer"].Value = _Dbtask.SetintoDecimalpoint(temptaxperc);


                        cellEnterCalculationpart();
                        RowValidation();
                       // Totalcalculation();
                    }
                    Totalcalculation();

                }
            }
        }
        public void GridItem_ContentClick()
        {
            //GridMain.Columns["clnbatch"].Visible = false;
            ClickCount = ClickCount + 1;
            //string MainItemId = Convert.ToString(GridMain.CurrentCell.Tag);
            string ItemId = Convert.ToString(GridItemList.CurrentCell.Tag);
            DS = _Dbtask.ExecuteQuery("select ItemName,ItemCode,ItemId,Srate from TblItemMaster where ItemId='" + ItemId + "'");
            try
            {
                if (ClickCount > 1 && ClickItemId == ItemId)
                {
                    ClickPlus();
                }
                else
                {
                    GridMain.Rows.Add(1);
                    ClickItemId = ItemId;
                    Rowindex = GridMain.Rows.Count - 2;
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        GridMain.NotifyCurrentCellDirty(false);
                        Itemname = DS.Tables[0].Rows[0]["ItemName"].ToString();
                        Srate = DS.Tables[0].Rows[0]["Srate"].ToString();
                        Itemcode = DS.Tables[0].Rows[0]["ItemCode"].ToString();
                        //if (SBatch == true)
                        //{
                        //    DS2 = _Dbtask.ExecuteQuery("select Bcode,Bid from Tblbatch where itemid='" + ItemId + "'");
                        //    if (DS2.Tables[0].Rows.Count > 0)
                        //    {
                        //        GridMain.Rows[Rowindex].Cells["clnbatch"].Value = DS2.Tables[0].Rows[0]["Bcode"].ToString();
                        //        GridMain.Rows[Rowindex].Cells["clnbatch"].Tag = DS2.Tables[0].Rows[0]["Bid"].ToString();
                        //    }
                        //}
                        GridMain.Rows[Rowindex].Cells["clnItemName"].Value = Itemname;
                        GridMain.Rows[Rowindex].Cells["clnItemName"].Tag = ItemId;
                        GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = Itemcode;
                        GridMain.Rows[Rowindex].Cells["clnrate"].Value = Srate;
                        GridMain.Rows[Rowindex].Cells["clnqty"].Value = 1;
                        //Rowindex = i;
                        NQTY = Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnqty"].Value);
                        NRATE = Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnrate"].Value);
                        cellEnterCalculationpart();
                        Totalcalculation();

                    }
                }
            }
            catch
            {
            }
            //cellEnterCalculationpart();
            //Totalcalculation();
            //// cellEnter();
        }

       


        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            GridMain.Columns["clnbatch"].Visible = false;

        }

        public void Fill_Combo()
        {
          
                _Ledger.FillComboWhere(comAgent, "where AGroupId=29");

                _EmployeeMaster.FillCombo(comEmployee);
            string temp = _Dbtask.ExecuteScalar("select paramvalue from Tblparamlist where paramname='TaxDef'");
            ComTax.Text = temp;
            CommonClass._Gen.FillActivePrinter(comPrint);
           // commodeofpayment.SelectedIndex = 0;
            if (Vtype == "CRM")
            {
                comAgent.Text = SelectedValue1;
                comEmployee.Text = SelectedValue;
            }
            
        }

        private void ComTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            comTaxTextchange();
            
        }
        public void comTaxTextchange()
        {
            RowValidation();

            for (int i = 0; i < GridMain.Rows.Count; i++)
            {

                if (GridMain.Rows[i].Tag != null)
                {
                    if (GridMain.Rows[i].Tag.ToString() == "1")
                    {
                        Rowindex = i;
                        ItemId = GridMain.Rows[Rowindex].Cells["clnitemname"].Tag.ToString();
                        //TaxCalcPart();
                        NQTY = Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnqty"].Value);
                       // NFree = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnfree"].Value);
                        NRATE = Convert.ToDouble(GridMain.Rows[Rowindex].Cells["clnrate"].Value);
                        // nta gridmain.Rows[rowindex].Cells["clntaxper"].Value;
                       // NDiscamt = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscount"].Value);
                       // NDiscper = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscper"].Value);
                        //NMrp = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnmrp"].Value);
                       // NTaxamount = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clntax"].Value);
                        cellEnterCalculationpart();
                        //TaxCalcPart();

                    }
                }
            }
            Totalcalculation();
        }
        //public void discountAmount()
        //{
        //    //if (Txtdiscount.Text != 0)
        //   // {
        //    double total =Convert.ToDouble(txttotal.Text);
        //    double discount =Convert.ToDouble(Txtdiscount.Text);
        //    NetAmount = total - discount;
        //    txttotal.Text =Convert.ToString(NetAmount);
        //       // txttotal.Text = txttotal.Text - Txtdiscount.Text;
        //    //}
        //}

        private void Txtdiscount_TextChanged(object sender, EventArgs e)
        {
            Txtdiscount.Select();
            Totalcalculation();
            //discountAmount();
        }

        private void ComTax_Click(object sender, EventArgs e)
        {
            ComTax.Focus();
            ComTax.Select();
           
        }

        private void ComTax_MouseClick(object sender, MouseEventArgs e)
        {
            _ingrid.FocusinControl(ComTax);
        }

        private void scrcategory_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            CustomerListShow();
           
        }
        public void CustomerListShow()
        {
            if (Retrivemode1 == 0)
            {
                DS = _Dbtask.ExecuteQuery("select * from TblAccountLedger where AGroupId=18 and Lname like '%" + txtCustomer.Text + "%' ");
                //GridCustomer.Rows.Clear();
                //GridCustomer.Columns.Clear();
                GridCustomer.Columns.Add("ClnName", "Customer Name");
                GridCustomer.Columns["ClnName"].Width = 200;
                GridCustomer.Visible = true;
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    GridCustomer.Rows.Add(1);
                    GridCustomer.Rows[i].Cells[0].Tag = DS.Tables[0].Rows[i]["Lid"].ToString();
                    GridCustomer.Rows[i].Cells[0].Value = DS.Tables[0].Rows[i]["Lname"];
                }
            }

        }

        private void txtCustomer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            try
            {
                if (GridCustomer.SelectedRows.Count>0)
                {
                    selectedRow = GridCustomer.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && GridCustomer.Rows[selectedRow].Cells[0].Value != null)
                    {
                        if (GridCustomer.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            GridCustomer.Rows[selectedRow + 1].Selected = true;
                            GridCustomer.Rows[selectedRow].Selected = false;
                            GridCustomer.CurrentCell = GridCustomer.SelectedRows[0].Cells[0];
                        }
                    }
                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        GridCustomer.Rows[selectedRow - 1].Selected = true;
                        GridCustomer.Rows[selectedRow].Selected = false;
                        GridCustomer.CurrentCell = GridCustomer.SelectedRows[0].Cells[0];
                    }
                    if (e.KeyValue == 13)
                    {
                        if (GridCustomer.SelectedRows.Count > 0 && GridCustomer.Visible == true)
                        {
                            txtCustomer.Text = GridCustomer.SelectedRows[0].Cells[0].Value.ToString();
                            txtCustomer.Tag = GridCustomer.SelectedRows[0].Cells[0].Tag;
                        }
                        GridCustomer.Visible = false;
                    }
                    if (e.KeyValue == 27)
                    {
                        GridCustomer.Visible = false;
                        if (txtCustomer.Text.Length > 0)
                        {
                            NotExist = false;
                            txtCustomer.Text = "";
                        }
                        else
                        {
                            NotExist = true;
                            this.Close();
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void Txtcooly_TextChanged(object sender, EventArgs e)
        {
            Txtcooly.Select();
            Totalcalculation();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }
        public void SaveSettings()
        {
            /*For Default Printer*/
            CommonClass.temp = comPrint.Text;
            CommonClass._Paramlist.UpdateParamlist("SPrintSelect", "1", CommonClass.temp);
        }

        private void picclear_Click(object sender, EventArgs e)
        {
            //GridMain.Rows.Clear();
        }

        private void Frmsalespos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void GridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Fill_CategrorItem();
        }

        private void GridItem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Rowindex = GridItem.CurrentCell.RowIndex;
            Columnidex = GridItem.CurrentCell.ColumnIndex;
        }

        private void GridItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridItem_ContentClick();
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            main();
            if (Vtype == "CRM")
            {
                this.Close();
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            ClearinFocusGrid();
            GridItemList.Rows.Clear();
            GridItemList.Columns.Clear();
            this.Close();
        }

        private void cmdplus_Click(object sender, EventArgs e)
        {
            ClickPlus();
        }
        public void ClickPlus()
        {
            try
            {
                if (GridMain.Rows.Count > 0)
                {
                    // GridMain.Rows.Add(1);
                    // Rowindex = Rowindex + 1;
                    double qty1 = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnqty"].Value);
                    GridMain.Rows[Rowindex].Cells["clnqty"].Value = qty1 + 1;
                    NQTY = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnqty"].Value);
                    NRATE = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnrate"].Value);

                    cellEnterCalculationpart();
                    Totalcalculation();
                }
            }
            catch
            {

            }
        }
        private void cmdminus_Click(object sender, EventArgs e)
        {
            Minus();
        }

        public void Minus()
        {
            try
            {
                if (GridMain.Rows.Count > 0)
                {
                    // GridMain.Rows.Add(1);
                    // Rowindex = Rowindex + 1;
                    double qty1 = _Dbtask.znullDouble(GridMain.Rows[Rowindex].Cells["clnqty"].Value.ToString());
                    if (qty1 != 0)
                    {
                        GridMain.Rows[Rowindex].Cells["clnqty"].Value = qty1 - 1;
                        NQTY = _Dbtask.znullDouble(GridMain.Rows[Rowindex].Cells["clnqty"].Value.ToString());
                        NRATE = _Dbtask.znullDouble(GridMain.Rows[Rowindex].Cells["clnrate"].Value.ToString());

                        cellEnterCalculationpart();
                        Totalcalculation();
                    }
                }
            }
            catch
            {

            }
        }

        private void cmdDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = GridMain.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    GridMain.Rows.RemoveAt(selectedIndex);
                    Totalcalculation();
                }
            }
            catch 
            {
                MessageBox.Show("Unable to remove selected row at this time");
            }
        }

        private void cmdTable_Click(object sender, EventArgs e)
        {
            pnlTableList.Visible = true;
            this.pnlTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            LoadTables();
            ChangeColur();
        }
        public void ChangeColur()
        {
            for (int i = 0; i < GridTable.Rows.Count; i++)
            {
                for(int j=0;j<GridTable.Columns.Count;j++)
                {
                    if (GridTable.Rows[i].Cells[j].Tag != null)
                    {
                        long tableItemId = Convert.ToInt64(GridTable.Rows[i].Cells[j].Tag.ToString());
                        int status = Convert.ToInt16(_Dbtask.ExecuteScalar("select Status from TblTable where Id='" + tableItemId + "'"));
                        if (status == 1)
                        {
                            GridTable.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            GridTable.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Green;
                        }
                    }
                }
            }
        }

        public void LoadTables()
        {
            if (Vtype == "POS")
            {
                DS = _Dbtask.ExecuteQuery("select Id,Name from TblTable where Status='1'");
            }
            else
            {
                DS = _Dbtask.ExecuteQuery("select Id,Name from TblTable");
            }
            try
            {
                int k = 0;
                int row = 0;
                int colum = 0;
                GridTable.Columns.Clear();
                GridTable.Rows.Clear();
                GridTable.Columns.Add("C1", "");
                GridTable.Rows.Add(1);
       
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (k < 5&&i<DS.Tables[0].Rows.Count)
                    {
                        colum = GridTable.Columns.Add("cln" + k, "");
                       // GridTable.Columns[colum].Width = 100;
                        GridTable.Rows[row].Height = 60;
                       // GridItem.Rows[row].Cells[colum-1] = new DataGridViewButtonCell();
                        GridTable.Rows[row].Cells[k].Value = DS.Tables[0].Rows[i]["Name"].ToString();
                        GridTable.Rows[row].Cells[k].Tag = DS.Tables[0].Rows[i]["Id"];
                        k++;
                    }
                    else
                    {
                      GridTable.Rows.Add(1);
                        row++;
                        k = 0;
                        colum = 0;
                        i--;
                    }


                }
            }
            catch
            {

            }
        }

       
        public void CellTable_Click()
            {
            string TableId = GridTable.CurrentCell.Tag.ToString();
            string Status = _Dbtask.ExecuteScalar("select Status from TblTable where Id='" + TableId + "'");
            string TblName = _Dbtask.ExecuteScalar("select Name from TblTable where Id='" + TableId + "'");
            if (Status == "1"&&Vtype=="KOT")
            {
                DialogResult Result = MessageBox.Show("Table Is Booked", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtTableId.Text = TableId;
                txtTblName.textBox1.Text = TblName;
                txtTblName.textBox1.Tag = TableId;
                cmdTable.Text = TblName;
                //txtTblName.Enabled = false;
                if (Vtype == "POS")
                {
                    ClickPOS = true;
                    FillGridByKotNo();
                }

                // GridTable.Rows[Rowindex].Cells[Columnidex].Style.BackColor = System.Drawing.Color.Red;
                pnlTableList.Visible = false;
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

        private void GridMain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Columnidex = GridMain.CurrentCell.ColumnIndex;
            Rowindex = GridMain.CurrentCell.RowIndex;
            columname = GridMain.Columns[Columnidex].Name.ToString();

            cellEnter();
            
        }

        private void GridMain_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            uscitemshowsimple1.Visible = false;
            // uscGridshow2.Visible = false;
        }


        private void txtKotNo_Leave(object sender, EventArgs e)
        {
            FillGridByKotNo();
        }
        public void FillGridByKotNo()
        {
            Retrivemode1 = 1;
            try
            {

                if (ClickPOS == true)
                {
                    string Vno = _Dbtask.ExecuteScalar("select KOTId from TblTable where Id='" + txtTableId.Text + "'");
                    DS = _Dbtask.ExecuteQuery("select * from TblIssuedetails where IssueCode='" + Vno + "' and Vtype='KOT'");
                    txtKotNo.textBox1.Text = Vno;

                    DS3 = _Dbtask.ExecuteQuery("select * from TblBusinessIssue where issuecode='" + txtKotNo.textBox1.Text + "' and issuetype='KOT'");
                    string CustTag = DS3.Tables[0].Rows[0]["LedcodeDr"].ToString();
                    string Custmr = _Dbtask.ExecuteScalar("select Lname from TblAccountLedger where Lid='" + CustTag + "'");
                    txtCustomer.Text = Custmr;
                    txtCustomer.Tag = CustTag;
                    ClickPOS = false;
                }
                else
                {
                    DS = _Dbtask.ExecuteQuery("select * from TblIssuedetails where IssueCode='" + txtKotNo.textBox1.Text + "' and Vtype='KOT'");
                    string TblId = _Dbtask.ExecuteScalar("select Id from TblTable where KOTId='" + txtKotNo.textBox1.Text + "'");
                    txtTableId.Text = TblId;
                    string TblName = _Dbtask.ExecuteScalar("select Name from TblTable where Id='" + TblId + "'");
                    txtTblName.textBox1.Text = TblName;
                    txtTblName.textBox1.Tag = TblId;
                    cmdTable.Text = TblName;

                    DS3 = _Dbtask.ExecuteQuery("select * from TblBusinessIssue where issuecode='" + txtKotNo.textBox1.Text + "' and issuetype='KOT'");
                    string CustTag = DS3.Tables[0].Rows[0]["LedcodeDr"].ToString();
                    string Custmr = _Dbtask.ExecuteScalar("select Lname from TblAccountLedger where Lid='" + CustTag + "'");
                    txtCustomer.Text = Custmr;
                    txtCustomer.Tag = CustTag;
                    // txtTblName.Enabled = false;
                }
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    GridMain.Rows.Add(1);
                    string tempSlno = (i + 1).ToString();
                    string tempitemid = DS.Tables[0].Rows[i]["pcode"].ToString();
                    double tempQty = Convert.ToDouble(DS.Tables[0].Rows[i]["qty"].ToString());
                    double tempsRate = Convert.ToDouble(DS.Tables[0].Rows[i]["Rate"].ToString());
                    double tempNetAmt = Convert.ToDouble(DS.Tables[0].Rows[i]["NetAMT"].ToString());


                    GridMain.Rows[i].Cells["clnslno"].Value = tempSlno;
                    GridMain.Rows[i].Cells["clnamount"].Value = tempNetAmt;
                    GridMain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
                    GridMain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                    GridMain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                    GridMain.Rows[i].Cells["clnitemcode"].Tag = tempitemid;
                    //txttotal.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(tempNetAmt));


                    NQTY = tempQty;
                    GridMain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);

                    NRATE = tempsRate;
                    GridMain.Rows[i].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(tempsRate);
                    GridMain.Rows[i].Cells["clnrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");

                    Templedouble = Convert.ToDouble(GridMain.Rows[i].Cells["clnrate"].Value) * Convert.ToDouble(GridMain.Rows[i].Cells["clnqty"].Value);
                    Rowindex = i;

                    cellEnterCalculationpart();
                    RowValidation();

                }
                Totalcalculation();
                Retrivemode1 = 0;
            }
            catch
            {

            }

        }

      
        private void compayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Retrivemode1 == 0)
            {
                if (compayment.Text == "CASH")
                {
                    txtCustomer.Tag = 1;
                   // txtpaid.Enabled = false;
                   // txtpaid.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
                }
                else
                {
                    if (txtCustomer.Text == "")
                    {
                        txtCustomer.Tag = null;
                    }
                    else
                    {
                        string temp = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + txtCustomer.Text + "'");
                        txtCustomer.Tag = temp;
                    }
                   // txtpaid.Enabled = true;
                }
            }
        }

        private void cmdX_Click(object sender, EventArgs e)
        {
            pnlTableList.Visible = false;
        }

        private void GridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellTable_Click();

        }

        private void GridTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Rowindex = GridTable.CurrentCell.RowIndex;
            Columnidex = GridTable.CurrentCell.ColumnIndex;
        }

    }
}
