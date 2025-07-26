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
    public partial class FrmRepacking : Form
    {
        public FrmRepacking()
        {
            InitializeComponent();
        }

        DBTask _DBTask = new DBTask();
        ClsInGrid _InGrid = new ClsInGrid();
        DataSet DS = new DataSet();
        ClsRepacking _Repacking=new ClsRepacking();
        ClsRepackingDetails _RepackingDetails=new ClsRepackingDetails();
        Clspurchase _Purchase = new Clspurchase();
        Clssales _sales = new Clssales();
        DataSet DS2 = new DataSet();
        int RowCounting;
        DataSet dset;
        public int columnIndex;
        public int rowIndex;
        public string columnName;
        public string StockAreaId = "0";
        public int selectedRow;
        public int selectedRow1;
        public int select;
        public string ItemName;
        public double Srate;
        public double Prate;
        public double Crate;
        public double MRP;
        public bool Bmode;
        public string temp;
        public bool SearchBarcode = false;
        public int Retrivemode;
        public string Batch;
        public int Itemcode;
        public bool EditMode=false;
        public string BatchCode;
        public bool IsinBatchList;
        public string BID;
        public double Templedouble;
        public double Templedouble1;
        public string DepoToid="0";
        public string DepoFromId="0";
        public bool getFill = false;
        double Stock1;
        public string vno = "";

        public string ItemId;
        public int retrivemode = 0;
        public bool IsEnter;
        public long Vid;
        public bool GridEdit;

        public double NAMOUNT;
        public double NSRATE;
        public double NQTY;
        public double NPRATE;
        public double NCRATE;
        public double NTOTAL = 0;

        public double Netqty;
        public double Netsrate = 0;
        public double Netamount = 0;
        public double Nettotal = 0;
        public double netCostfact = 0;
        public double NetLbrcharge = 0;


        /*Second Grid*/
        public int rowIndex1;
        public int columnIndex1;
        public string columnName1;
        public string stockAreaId1="0";
        public int selectedRow2;
        public int selectedRow3;
        public int select1;
        public string itemId1;
        public string SalesAccount;

        public string ItemName1;
        public double Srate1;
        public double Prate1;
        public double Crate1;
        public double Mrp1;

        public double NAMOUNT1;
        public double NSRATE1;
        public double NQTY1;
        public double NPRATE1;
        public double NTOTAL1 = 0;

        public double Netqty1;
        public double Netsrate1 = 0;
        public double Netamount1 = 0;
        public double Nettotal1= 0;
        public double NetCrate;
        public double NetTotalcost = 0;
        /*Settings*/
        public string Printerselect;
        public bool Sitemwiseagentcommision = false;
        public bool SBatch = false;
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

        string SItemid;
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
                if (uscGridshow1.Visible == true)
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

                if (GridBatchlist.Visible == true)
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
                if (gridBatchList1.Visible == true)
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
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.GroupBoxConvertion(Grpsetproduct);
                CommonClass._Language.GridHeaderConversion(GridPackedMaterial);
                CommonClass._Language.GridHeaderConversion(GridRawMaterials);
                CommonClass._Language.PanelBasedConversion(panel1);
                CommonClass._Language.PanelBasedConversion(pnlgrid2up);
                CommonClass._Language.PanelBasedConversion(pnlLast);
                CommonClass._Language.PanelBasedConversion(pnlFirst);
            }
        }
        private void FrmRepacking_Load(object sender, EventArgs e)
        {
            SetGridColumn();
            FillCombo();
            if(EditMode==true)
            {

                GetPrevious(vno, true);
            }
            else
            {
            clear();
            }
           
        }
        public void clear()
        {
            EditMode = false;
            uscGridshow2.Visible = false;
            uscGridshow1.Visible = false;
            CommonClass._Nextg.ClearControles(pnlFirst);
            CommonClass._Nextg.ClearControles(pnlLast);
            txtLabourCharge.Text = "0.00";
            txtCostFactor.Text = "0.00";
            txtRawmaterialTotalcost.Text = "0.00";
            txttotaiPacked.Text = "0.00";
            txttotalRaw.Text = "0.00";
            txtNaretion.Text = "";
            GridPackedMaterial.Rows.Clear();
            GridRawMaterials.Rows.Clear();
            SalesAccount = "1";
            SetGridColumn();
            FillCombo();
            GetVno();
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
           // Totalcalculation();
        }


        void txt_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();
        }
     

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            {
           // throw new NotImplementedException();
            try
            {
                GridEdit = true;
                if (columnName == "clnitemcode")
                {
                   
                    
                    _InGrid.RowUpDownSelect(e.KeyValue, uscGridshow1.GridProductShow, selectedRow, uscGridshow1, GridPackedMaterial);
                    if(uscGridshow1.GridProductShow.SelectedRows.Count>0)
                    {
                        select=uscGridshow1.GridProductShow.SelectedRows[0].Index;
                        string SelectItem=Convert.ToString(uscGridshow1.GridProductShow.Rows[select].Cells["itemid"].Value);
                        //string ItemId=_DBTask.ExecuteScalar("select itemid from tblItemmaster where ")
                        double Stock =Convert.ToDouble(CommonClass._Inventory.GetStock("where Pcode='" + SelectItem + "'"));
                        uscGridshow1.lblstock.Text = _DBTask.SetintoDecimalpointStock(Stock);
                    }

                    if (e.KeyValue == 13)
                        {
                        if (uscGridshow1.GridProductShow.SelectedRows.Count > 0)
                        {
                            selectedRow1 = uscGridshow1.GridProductShow.SelectedRows[0].Index;
                            string selectedItem = Convert.ToString(uscGridshow1.GridProductShow.Rows[selectedRow1].Cells["itemid"].Value);

                            ItemName = CommonClass._Itemmaster.SpecificField(selectedItem, "itemname");
                            Srate =_DBTask.znullDouble(CommonClass._Itemmaster.SpecificField(selectedItem, "srate"));
                            Prate = _DBTask.znullDouble(CommonClass._Itemmaster.SpecificField(selectedItem, "prate"));
                            Crate =_DBTask.znullDouble(CommonClass._Itemmaster.SpecificField(selectedItem, "Crate"));
                            MRP = _DBTask.znullDouble(CommonClass._Itemmaster.SpecificField(selectedItem, "MRP"));


                            GridPackedMaterial.Rows[rowIndex].Cells["clnItemname"].Tag = selectedItem;
                            GridPackedMaterial.Rows[rowIndex].Cells["clnItemname"].Value = ItemName;
                            
                            GridPackedMaterial.Rows[rowIndex].Cells["clnSrate"].Value = Srate;
                            GridPackedMaterial.Rows[rowIndex].Cells["clnPrate"].Value = Prate;
                            GridPackedMaterial.Rows[rowIndex].Cells["clnCrate"].Value = Crate;
                            GridPackedMaterial.Rows[rowIndex].Cells["clnMRP"].Value = MRP;
                            // GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["bcode"].Value;
                            GridPackedMaterial.Rows[rowIndex].Cells["clnItemcode"].Value = uscGridshow1.GridProductShow.Rows[selectedRow1].Cells["itemcode"].Value;

                            uscGridshow1.Visible = false;
                        }
                    }

                    if (GridPackedMaterial.Columns[columnIndex].Name == "clnitemcode")
                    {
                        if (e.KeyValue == 13)
                        {
                            int NowselectedRow;
                            string TempItemcode;
                            if (uscGridshow1.Visible == true)
                            {
                                NowselectedRow = uscGridshow1.GridProductShow.SelectedRows[0].Index;
                                TempItemcode = uscGridshow1.GridProductShow.Rows[NowselectedRow].Cells["itemcode"].Value.ToString();
                            }
                            else
                            {
                                TempItemcode = _DBTask.znllString(GridPackedMaterial.Rows[rowIndex].Cells["clnitemcode"].Value);
                            }

                            GridPackedMaterial.NotifyCurrentCellDirty(false);
                            DS = _DBTask.ExecuteQuery("select * from TblItemMaster where itemcode=N'" + TempItemcode + "'");
                            if (DS.Tables[0].Rows.Count > 0)
                            {
                                string TemItemid = _DBTask.ExecuteScalar("select itemid from TblItemMaster where itemcode=N'" + TempItemcode + "'");
                                ItemId = TemItemid;
                                GridPackedMaterial.Rows[rowIndex].Cells["clnitemcode"].Tag = TemItemid;
                                GridPackedMaterial.Rows[rowIndex].Cells["clnitemcode"].Value = _DBTask.ExecuteScalar("select itemcode from TblItemmaster where itemid='" + TemItemid + "'");
                                GridPackedMaterial.Rows[rowIndex].Cells["clnItemname"].Tag = TemItemid;
                                GridPackedMaterial.Rows[rowIndex].Cells["clnItemname"].Value = _DBTask.ExecuteScalar("select itemname from Tblitemmaster where itemid='" + TemItemid + "'");
                                GridPackedMaterial.Rows[rowIndex].Cells["clnqty"].Value = 1;
                                double TempSrate = _DBTask.znullDouble(CommonClass._Itemmaster.SpecificField(ItemId, "srate"));
                                double TempPrate = _DBTask.znullDouble(CommonClass._Itemmaster.SpecificField(ItemId, "Prate"));
                                double TempCrate = _DBTask.znullDouble(CommonClass._Itemmaster.SpecificField(ItemId, "Crate"));
                                double TempMRP = _DBTask.znullDouble(CommonClass._Itemmaster.SpecificField(ItemId, "Mrp"));
                                GridPackedMaterial.Rows[rowIndex].Cells["clnSrate"].Value = _DBTask.SetintoDecimalpoint(TempSrate);
                                GridPackedMaterial.Rows[rowIndex].Cells["clnPrate"].Value = _DBTask.SetintoDecimalpoint(TempPrate);
                                GridPackedMaterial.Rows[rowIndex].Cells["clnCrate"].Value = _DBTask.SetintoDecimalpoint(TempCrate);
                                GridPackedMaterial.Rows[rowIndex].Cells["clnMRP"].Value = _DBTask.SetintoDecimalpoint(TempMRP);


                                NQTY = Convert.ToDouble(GridPackedMaterial.Rows[rowIndex].Cells["clnqty"].Value);
                               // NSRATE = Convert.ToDouble(GridPackedMaterial.Rows[rowIndex].Cells["clnSrate"].Value);
                                NPRATE = Convert.ToDouble(GridPackedMaterial.Rows[rowIndex].Cells["clnPrate"].Value);
                                uscGridshow1.Visible = false;


                                cellEnterCalculationpart();
                                TotalcalcPacked();

                              

                            }
                            else
                            {
                                MessageBox.Show("Itemcode Not exsting");
                              
                            }


                        }

                    }
                }
                            if (columnName == "clnbatch")
                            {
                     
                    
                  // _InGrid.RowUpDownSelect(e.KeyValue, GridBatchlist.grid, selectedRow, GridBatchlist, GridPackedMaterial);
                       
                            CommonClass._commenevent.UpDowninGridList(GridBatchlist, e.KeyValue, GridPackedMaterial);
                        if (e.KeyValue == 13 && GridBatchlist.SelectedRows.Count > 0)
                        {
                            BatchCode = GridBatchlist.Rows[GridBatchlist.SelectedRows[0].Index].Cells[0].Value.ToString();
                            IsinBatchList = true;
                            temp = _DBTask.znllString(GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value);
                            if (BatchCode == "(Auto Batch)" && temp.Length < 4)
                            {
                                GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = "";
                                Getbatchcode();
                            }
                            else if (BatchCode == "(Auto Batch)" && temp.Length > 3)
                            {
                                //Batchcode=Batchcode
                            }
                            else
                            {
                                GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = BatchCode;

                            }
                            BatchCode = GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value.ToString();
                            GridBatchlist.Visible = false;
                        }
                    
                }
              
                    GridEdit = false;
                
            }
            catch
            {
            }

            //GridPackedMaterial.Rows[rowIndex].Cells[columnIndex].Value = (sender as TextBox).Text;
            if (e.KeyValue == 113 && ItemId != null) /*For F2  Delete Rows */
            {
                try
                {
                    int selectedIndex = GridPackedMaterial.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        GridPackedMaterial.Rows.RemoveAt(selectedIndex);
                        TotalcalcPacked();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Unable to remove selected row at this time");
                }
            }
             //if (e.KeyValue != 13)
             //{
                 
            // }


        }

        public void cellEnterCalculationRowmeterials()
        {
            try
            {

                //if (GridEdit == true)
                //{
                //   // InsertZeroValue();
                //    NAMOUNT = NQTY * NPRATE;
                //    GridPackedMaterial.Rows[rowIndex].Cells["clnAmount"].Value = _DBTask.SetintoDecimalpointStock(NAMOUNT);

                //}
                //else
                //{
                   // InsertZerovalue1();
                    NAMOUNT1 = NQTY1 * NCRATE;

                    GridRawMaterials.Rows[rowIndex1].Cells["clnamount1"].Value = _DBTask.SetintoDecimalpointStock(NAMOUNT1);

                  //  cellEnterCalculationpart();
                //}


            }
            catch
            {
            }
        }

        public void cellEnterCalculationpart()
        {
            try
            {

                //if (GridPackedMaterial.Rows.Count > 0)
                //{
                //    NQTY = _DBTask.znlldoubletoobject(GridPackedMaterial.Rows[0].Cells["clnqty"].Value);
                //    NPRATE = _DBTask.znlldoubletoobject(GridPackedMaterial.Rows[0].Cells["clnPrate"].Value);
                //}

                NAMOUNT = NQTY * NPRATE;
                GridPackedMaterial.Rows[rowIndex].Cells["clnAmount"].Value = _DBTask.SetintoDecimalpointStock(NAMOUNT);
                //if (GridEdit == true)
                //{
                //       InsertZeroValue();
                //       NAMOUNT = NQTY * NPRATE;
                //       GridPackedMaterial.Rows[rowIndex].Cells["clnAmount"].Value = _DBTask.SetintoDecimalpointStock(NAMOUNT);
                 
                //}
                //else
                //{
                //    InsertZerovalue1();
                //    NAMOUNT1 = NQTY1 * NCRATE;

                //    GridRawMaterials.Rows[rowIndex1].Cells["clnamount1"].Value = _DBTask.SetintoDecimalpointStock(NAMOUNT1);
                //}


            }
            catch
            {
            }
        }
        public void InsertZeroValue()
        {
            try
            {
                if (GridPackedMaterial.Rows[rowIndex].Cells["clnqty"] == null)
                {
                    GridPackedMaterial.Rows[rowIndex].Cells["clnqty"].Value = 0;
                }
                if (GridPackedMaterial.Rows[rowIndex].Cells["clnPrate"].Value == null)
                {
                    GridPackedMaterial.Rows[rowIndex].Cells["clnPrate"].Value = 0;
                }
                if (GridPackedMaterial.Rows[rowIndex].Cells["clnAmount"].Value == null)
                {
                    GridPackedMaterial.Rows[rowIndex].Cells["clnAmount"].Value = 0;
                }
            }
            catch
            {
            }

        }

        public void InsertZerovalue1()
        {
            /*for 2nd grid*/
            if (GridRawMaterials.Rows[rowIndex1].Cells["clnqty1"] == null)
            {
                GridRawMaterials.Rows[rowIndex1].Cells["clnqty1"].Value = 0;
            }
            if (GridRawMaterials.Rows[rowIndex1].Cells["clncrate1"] == null)
            {
                GridRawMaterials.Rows[rowIndex1].Cells["clncrate1"].Value = 0;
            }
            if (GridRawMaterials.Rows[rowIndex1].Cells["clnamount1"].Value == null)
            {
                GridRawMaterials.Rows[rowIndex1].Cells["clnamount1"].Value = 0;
            }
        }
        
        public void TotalcalcPacked()
        {
            try
            {
                if (rowIndex < GridPackedMaterial.Rows.Count)
                {
                    GridPackedMaterial.Rows[rowIndex].Cells["clnSlno"].Value = rowIndex + 1;/* For SlNo*/

                    Netqty = 0;
                    Netsrate = 0;
                    Netamount = 0;
                    Nettotal = 0;
                    double RowMetrials;
                    double LabourCharge;
                    double TOtherCharge;

                    for (int i = 0; i < GridPackedMaterial.Rows.Count; i++)  /* For Row NetAmount*/
                    {
                        NQTY = _DBTask.znlldoubletoobject(GridPackedMaterial.Rows[i].Cells["clnqty"].Value);
                        NPRATE = _DBTask.znlldoubletoobject(GridPackedMaterial.Rows[i].Cells["clnPrate"].Value);
                        GridPackedMaterial.Rows[i].Cells["clnAmount"].Value = NQTY * NPRATE;

                        if (GridPackedMaterial.Rows[i].Cells["clnAmount"].Value != null)
                        {
                            Netamount = Netamount + Convert.ToDouble(GridPackedMaterial.Rows[i].Cells["clnAmount"].Value);
                        }

                    }

                    LabourCharge = _DBTask.znullDouble(txtLabourCharge.Text);
                    RowMetrials = _DBTask.znullDouble(txtCostFactor.Text);
                    TOtherCharge = LabourCharge + RowMetrials;
                   // Netamount = Netamount + TOtherCharge;
                    txttotaiPacked.Text = _DBTask.SetintoDecimalpoint(Convert.ToDouble(Netamount));

                }
            }
            catch
            {
            }
        }

        public void TotalRowmeterials()
        {
            try
            {
                if (rowIndex1 < GridRawMaterials.Rows.Count)
                {
                    GridRawMaterials.Rows[rowIndex1].Cells["clnslno1"].Value = rowIndex1 + 1;
                    Netqty1 = 0;
                    Netsrate1 = 0;
                    Netamount1 = 0;
                    Nettotal1 = 0;
                    NetTotalcost = 0;
                    double TQty;
                    double TPrate;
                    double TNetamount;

                    for (int i = 0; i < GridRawMaterials.Rows.Count; i++)
                    {
                        if (GridRawMaterials.Rows[RowCounting].Cells["clnitemname1"].Tag != null)
                        {
                            if (GridRawMaterials.Rows[RowCounting].Cells["clnitemname1"].Tag.ToString() != "")
                            {
                                TQty = _DBTask.znlldoubletoobject(GridRawMaterials.Rows[i].Cells["clnqty1"].Value);
                                TPrate = _DBTask.znlldoubletoobject(GridRawMaterials.Rows[i].Cells["clnprate1"].Value);
                                TNetamount = TQty * TPrate;
                                GridRawMaterials.Rows[i].Cells["clnamount1"].Value = TNetamount;
                                Netamount1 = Netamount1 + Convert.ToDouble(GridRawMaterials.Rows[i].Cells["clnamount1"].Value);
                            }
                        }
                    }

                    txttotalRaw.Text = _DBTask.SetintoDecimalpoint(Convert.ToDouble(Netamount1));

                }
                double total = Convert.ToDouble(txttotalRaw.Text);
                double qty = _DBTask.znlldoubletoobject(GridPackedMaterial.Rows[0].Cells["clnqty"].Value);
                double pratecln = total / qty;
                //GridPackedMaterial.Rows[0].Cells["clnPrate"].Value = pratecln;
                ItemCrateCalculate();
            }
            catch
            {
            }
        }

        
        

        void txt_TextChanged(object sender, EventArgs e)
        {
            GridEdit = true;
            //throw new NotImplementedException();
            if ((sender as TextBox).Text == "")
            {
                if (columnName != "clnItemname" && columnName != "clnitemcode" && columnName != "clnSlno"&& columnName!="clnbatch")
                {
                    (sender as TextBox).Text = "0";
                }
            }
            GridPackedMaterial.Rows[rowIndex].Cells[columnIndex].Value = (sender as TextBox).Text;
            
            NQTY = _DBTask.znlldoubletoobject(GridPackedMaterial.Rows[rowIndex].Cells["clnqty"].Value);
            NPRATE = _DBTask.znlldoubletoobject(GridPackedMaterial.Rows[rowIndex].Cells["clnPrate"].Value);

            string temp =_DBTask.znllString(GridPackedMaterial.Rows[rowIndex].Cells[columnIndex].Value);
            if (columnName == "clnitemcode")
            {
                ProductGridShow("where (itemCode Like N'%" + temp + "%' OR itemName Like N'%" + temp + "%') and (Status=1) and (Itemclass='Finished Product' or Itemclass='Finished Product2')");
            } 
            if (columnName == "clnbatch")
            {
                //if (clnbatch.ReadOnly == false)
                //{
                    LoadBatches((sender as TextBox).Text);
              //  }
               
            }
            if (columnName == "clnqty")
            {
                if (getFill == true)
                {
                    FillQty();
                }
            }
           
            cellEnterCalculationpart();
            TotalRowmeterials();
            TotalcalcPacked();

            GridEdit = false;

        }
        public void LoadBatches(string Search)
        {
           
            GridBatchlist.CellBorderStyle = DataGridViewCellBorderStyle.None;                        //+ 34 * 3//
            CommonClass._Batch.BatchlistshowBaseonItem(ItemId, GridBatchlist, Search);
            Rectangle tempRect = GridPackedMaterial.GetCellDisplayRectangle(GridPackedMaterial.CurrentCell.ColumnIndex, GridPackedMaterial.CurrentCell.RowIndex, false);
            _InGrid.ProductGridShowLocationSettGrid(GridBatchlist, tempRect.Left, tempRect.Top + tempRect.Height+20);
            GridBatchlist.Columns[0].Width = GridBatchlist.Width - 10;
        }

        public void ProductGridShowWithBatch(string WhereCondition)
        {
            try
            {
                _InGrid.BatchGridShow(uscGridshow1, WhereCondition, uscGridshow1.GridProductShow, StockAreaId,false,true,"");

                Rectangle temprect = GridPackedMaterial.GetCellDisplayRectangle(GridPackedMaterial.CurrentCell.ColumnIndex, GridPackedMaterial.CurrentCell.RowIndex, false);
                if (temprect.Top > 400)
                {
                    _InGrid.ProductGridShowLocationSett(uscGridshow1, temprect.Left, temprect.Top - temprect.Height + 6 * 3);
                }
                else
                {
                    _InGrid.ProductGridShowLocationSett(uscGridshow1, temprect.Left, temprect.Top + temprect.Height - 10);
                }

                if (uscGridshow1.Visible == false)
                {
                    uscGridshow1.Visible = true;
                }
            }
            catch
            {
            }
        }
        public void ProductGridShowWithBatch1(string WhereCondition)
        {
            try
            {
                _InGrid.BatchGridShow(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, stockAreaId1,false,true,"");

                Rectangle temprect = GridRawMaterials.GetCellDisplayRectangle(GridRawMaterials.CurrentCell.ColumnIndex, GridRawMaterials.CurrentCell.RowIndex, false);
                if (temprect.Top > 400)
                {
                    _InGrid.ProductGridShowLocationSett(uscGridshow2, temprect.Left, temprect.Top - temprect.Height + 6 * 3);
                }
                else
                {
                    _InGrid.ProductGridShowLocationSett(uscGridshow2, temprect.Left, temprect.Top + temprect.Height - 10);
                }

                if (uscGridshow2.Visible == false)
                {
                    uscGridshow2.Visible = true;
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
              //  retrivemode = 0;
              //  Textalignsett();

                Bmode = true;
                if (SBatch == false)/*For Batch Enabled*/
                {
                    clnbatch.Visible = false;
                    clnItemname.ReadOnly = false;

                    clnbatchcode1.Visible = false;
                    clnitemname1.ReadOnly = false;
                }
                //if (Seditsrate == false)
                //{
                //    clnSrate.ReadOnly = true;
                //}
                //if (STax == false)
                //{
                //    clntax.Visible = false;
                //    ClntaxPer.Visible = false;
                //    ComTax.Visible = false;
                //    lbltax.Visible = false;
                //}
            }
            catch
            {
            }
        }
        public void GetMenusettings()
        {
            try
            {
                //_sales.FuFocusfirstRow();
                /*Batch*/
                temp = _DBTask.ExecuteScalar("select status from tblmnusettings where menuid=103");
                if (temp == "1")
                {
                    SBatch = true;
                }
                /*Edit SalesRate*/
                temp = _DBTask.ExecuteScalar("select status from tblmnusettings where menuid=112");
                if (temp == "1")
                {
                    Seditsrate = true;
                }
                /*Tax */
                temp = _DBTask.ExecuteScalar("select status from tblmnusettings where menuid=14");
                if (temp == "1")
                {
                    STax = true;
                }

                /*Stock Area*/

                temp = _DBTask.ExecuteScalar("select status from tblmnusettings where menuid=13");
                if (temp == "1")
                {
                    SDepo = true;
                }

                /*For Batch is Second*/

                temp = _DBTask.ExecuteScalar("select status from tblmnusettings where menuid=121");
                if (temp == "1")
                {
                    Useasbarcode = true;
                }
                temp = _DBTask.ExecuteScalar("select status from tblmnusettings where menuid=124");
                if (temp == "1")
                {
                    Supdatesrate = true;
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
                _InGrid.ProductGridShowFixedSecondary(uscGridshow1, WhereCondition, uscGridshow1.GridProductShow, StockAreaId);

                // IsEnter = true;
                Rectangle tempRect = GridPackedMaterial.GetCellDisplayRectangle(GridPackedMaterial.CurrentCell.ColumnIndex, GridPackedMaterial.CurrentCell.RowIndex, false);

                if (tempRect.Top > 400)
                    _InGrid.ProductGridShowLocationSett(uscGridshow1, tempRect.Left, tempRect.Top - tempRect.Height + 6 * 3);
                else
                    _InGrid.ProductGridShowLocationSett(uscGridshow1, tempRect.Left, tempRect.Top + tempRect.Height + 18);

                if (uscGridshow1.Visible == false)
                {
                    uscGridshow1.Visible = true;
                }
            }
            catch
            {
            }
        }

        public void ProductGridShow1(string WhereCondition)
        {
            try
            {
                _InGrid.ProductGridShowFixedSecondary(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, stockAreaId1);

                // IsEnter = true;
                Rectangle tempRect = GridRawMaterials.GetCellDisplayRectangle(GridRawMaterials.CurrentCell.ColumnIndex, GridRawMaterials.CurrentCell.RowIndex, false);

                if (tempRect.Top > 400)
                    _InGrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top - tempRect.Height + 6 * 3);
                else
                    _InGrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height - 10);

                if (uscGridshow2.Visible == false)
                {
                    uscGridshow2.Visible = true;
                }
            }
            catch
            {
            }
        }

     

        void txt1_Enter(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // throw new NotImplementedException();
        }

        void txt1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //throw new NotImplementedException();
            if (columnName1 == "clnitemcode1")
            {
              
                    _InGrid.RowUpDownSelect(e.KeyValue, uscGridshow2.GridProductShow, selectedRow2, uscGridshow2, GridRawMaterials);
                    if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                    {
                        select1 = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                        string SelectItem1 = Convert.ToString(uscGridshow2.GridProductShow.Rows[select1].Cells["itemid"].Value);
                        //string ItemId=_DBTask.ExecuteScalar("select itemid from tblItemmaster where ")
                        Stock1 = Convert.ToDouble(CommonClass._Inventory.GetStock("where Pcode='" + SelectItem1 + "'"));
               
                        uscGridshow2.lblstock.Text = _DBTask.SetintoDecimalpointStock(Stock1);
                    }

                    if (e.KeyValue == 13)
                    {
                        if (Stock1 <= 0)
                        {
                            DialogResult Result = MessageBox.Show("NO Stock", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            RowClick((sender as TextBox).Text, e.KeyValue);
                        }
                    }

                
            }
                if (columnName1 == "clnbatchcode1")
            {
             
                if (getFill == true)
                {
                   // uscGridshow2.Visible = false;
                    CommonClass._commenevent.UpDowninGridList(gridBatchList1, e.KeyValue, GridRawMaterials);
                    IsinBatchList = true;
                    if (e.KeyValue == 13 && gridBatchList1.SelectedRows.Count>0)
                    {
                        string valuebatch;
                        BatchCode = gridBatchList1.Rows[gridBatchList1.SelectedRows[0].Index].Cells[0].Value.ToString();
                        GridRawMaterials.Rows[rowIndex1].Cells["clnbatchcode1"].Value = BatchCode;
                        gridBatchList1.Visible = false;
                    }
                   
                }
                else
                {


                    _InGrid.RowUpDownSelect(e.KeyValue, uscGridshow2.GridProductShow, selectedRow2, uscGridshow2, GridRawMaterials);
                    if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                    {
                        select1 = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                        string SelectItem1 = Convert.ToString(uscGridshow2.GridProductShow.Rows[select1].Cells["itemid"].Value);
                        //string ItemId=_DBTask.ExecuteScalar("select itemid from tblItemmaster where ")
                        Stock1 = Convert.ToDouble(CommonClass._Inventory.GetStock("where Pcode='" + SelectItem1 + "'"));
                        uscGridshow2.lblstock.Text = _DBTask.SetintoDecimalpointStock(Stock1);
                    }

                    if (e.KeyValue == 13)
                    {
                        if (Stock1 <= 0)
                        {
                            DialogResult Result = MessageBox.Show("NO Stock", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            RowClick((sender as TextBox).Text, e.KeyValue);
                        }

                    }

                } 


            }
                GridRawMaterials.Rows[rowIndex1].Cells[columnIndex1].Value = (sender as TextBox).Text;
                if (e.KeyValue == 113 && itemId1 != null) /*For F2  Delete Rows */
                {
                    try
                    {
                        int selectedIndex = GridRawMaterials.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            GridRawMaterials.Rows.RemoveAt(selectedIndex);
                            TotalRowmeterials();
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Unable to remove selected row at this time");
                    }
                }
        }
        public void RowClick(string Value, int KeyValue)
                {
            try
            {
                if(columnName1=="clnitemcode1")
                {
                if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                {
                    selectedRow3 = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                    string selectedItem1 = Convert.ToString(uscGridshow2.GridProductShow.Rows[selectedRow3].Cells["itemid"].Value);

                    ItemName1 = CommonClass._Itemmaster.SpecificField(selectedItem1, "itemname");
                    Srate1 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(selectedItem1, "srate"));
                    Prate1 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(selectedItem1, "prate"));
                    Crate1 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(selectedItem1, "Crate"));
                    Mrp1 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(selectedItem1, "MRP"));
                    if (SBatch == true)
                    {
                        BatchCode = _DBTask.ExecuteScalar("select Bcode from Tblbatch where itemid='" + selectedItem1 + "'");
                        GridRawMaterials.Rows[rowIndex1].Cells["clnbatchcode1"].Value = BatchCode;
                    }


                    GridRawMaterials.Rows[rowIndex1].Cells["clnitemname1"].Value = ItemName1;
                    GridRawMaterials.Rows[rowIndex1].Cells["clnitemname1"].Tag = selectedItem1;
                    GridRawMaterials.Rows[rowIndex1].Cells["clnsrate1"].Value = Srate1;
                    GridRawMaterials.Rows[rowIndex1].Cells["clnprate1"].Value = Prate1;
                    GridRawMaterials.Rows[rowIndex1].Cells["clncrate1"].Value = Crate1;
                    GridRawMaterials.Rows[rowIndex1].Cells["clnmrp1"].Value = Mrp1;
                    // GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["bcode"].Value;
                    GridRawMaterials.Rows[rowIndex1].Cells["clnitemcode1"].Value = uscGridshow2.GridProductShow.Rows[selectedRow3].Cells["itemcode"].Value;

                    uscGridshow2.Visible = false;
                }
                if (GridRawMaterials.Columns[columnIndex1].Name == "clnitemcode1")
                {
                    int NowselectedRow1;
                    string TempItemcode1;
                    if (uscGridshow2.Visible == true)
                    {
                        NowselectedRow1 = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                        TempItemcode1 = uscGridshow2.GridProductShow.Rows[NowselectedRow1].Cells["itemcode"].Value.ToString();
                    }
                    else
                    {
                        TempItemcode1 = _DBTask.znllString(GridRawMaterials.Rows[rowIndex1].Cells["clnitemcode1"].Value);
                    }

                    GridRawMaterials.NotifyCurrentCellDirty(true);
                    DS = _DBTask.ExecuteQuery("select * from TblItemMaster where itemcode=N'" + TempItemcode1 + "'");
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                       // string TemItemid1 = _DBTask.ExecuteScalar("select itemid from TblItemMaster where itemcode='" + TempItemcode1 + "'");
                        string TemItemid1 = DS.Tables[0].Rows[rowIndex1]["itemid"].ToString();
                        itemId1 = TemItemid1;
                        
                        GridRawMaterials.Rows[rowIndex1].Cells["clnitemcode1"].Tag = TemItemid1;
                        GridRawMaterials.Rows[rowIndex1].Cells["clnitemcode1"].Value = TempItemcode1;
                       // GridRawMaterials.Rows[rowIndex1].Cells["clnitemcode1"].Value = _DBTask.ExecuteScalar("select itemcode from Tblitemmaster where itemid='" + TemItemid1 + "'");
                        GridRawMaterials.Rows[rowIndex1].Cells["clnitemname1"].Tag = TemItemid1;
                        GridRawMaterials.Rows[rowIndex1].Cells["clnitemname1"].Value = _DBTask.ExecuteScalar("select itemname from Tblitemmaster where itemid='" + TemItemid1 + "'");
                        GridRawMaterials.Rows[rowIndex1].Cells["clnqty1"].Value = 1;
                        double TempSrate1 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(itemId1, "srate"));
                        double TempPrate1 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(itemId1, "Prate"));
                        double TempCrate1 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(itemId1, "Crate"));
                        double TempMRP1 = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(itemId1, "Mrp"));
                        GridRawMaterials.Rows[rowIndex1].Cells["clnsrate1"].Value = _DBTask.SetintoDecimalpoint(TempSrate1);
                        GridRawMaterials.Rows[rowIndex1].Cells["clnprate1"].Value = _DBTask.SetintoDecimalpoint(TempPrate1);
                        GridRawMaterials.Rows[rowIndex1].Cells["clncrate1"].Value = _DBTask.SetintoDecimalpoint(TempCrate1);
                        GridRawMaterials.Rows[rowIndex1].Cells["clnmrp1"].Value = _DBTask.SetintoDecimalpoint(TempMRP1);


                        NQTY1 = Convert.ToDouble(GridRawMaterials.Rows[rowIndex1].Cells["clnqty1"].Value);
                        NCRATE = Convert.ToDouble(GridRawMaterials.Rows[rowIndex1].Cells["clncrate1"].Value);
                        uscGridshow2.Visible = false;

                        GridEdit = false;
                        cellEnterCalculationpart();


                    }
                    else
                    {
                        MessageBox.Show("Itemcode Not exsting");
                        //if (Useasbarcode == true)
                        //{
                        //    GridPackedMaterial.CurrentCell = GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"];
                        //}
                    }
                }
               
                }

                if (columnName1=="clnbatchcode1")
                {

                    
                        int NowselectedRow;
                        string TempBathcode;
                        if (uscGridshow2.Visible == true && uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                        {
                            NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                            TempBathcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                        }
                        else
                        {
                            TempBathcode = _DBTask.znllString(GridRawMaterials.Rows[rowIndex1].Cells["clnbatchcode1"].Value);
                        }
                        _sales.BarcodeRefilling(TempBathcode);
                        TempBathcode = _sales.Bcode;
                        //NQTY = _sales.NQty;
                        DS = _DBTask.ExecuteQuery("select * from tblbatch where bcode='" + TempBathcode + "'");
                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            string Tempitemid = _DBTask.ExecuteScalar("select itemid from tblbatch where bcode='" + TempBathcode + "'");
                            ItemId = Tempitemid;
                            GridRawMaterials.Rows[rowIndex1].Cells["clnitemcode1"].Value = _DBTask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Tempitemid + "'");
                            GridRawMaterials.Rows[rowIndex1].Cells["clnitemname1"].Tag = Tempitemid;
                            GridRawMaterials.Rows[rowIndex1].Cells["clnqty1"].Value = 1;
                            GridRawMaterials.Rows[rowIndex1].Cells["clnitemname1"].Value = _DBTask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Tempitemid + "'");
                            //ShowStockinLabel(TempBathcode, Tempitemid, StockareaId);
                            //GridRawMaterials.Rows[rowIndex1].Cells["clnqty1"].Value = NQTY;
                            double TempSrate = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "srate"));
                            double TempMrp = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "mrp"));
                            double TempCrate = Convert.ToDouble(_DBTask.ExecuteScalar("select crate from tblitemMaster where itemid='" + ItemId + "'"));
                            double TempPrate = Convert.ToDouble(_DBTask.ExecuteScalar("select Prate from tblitemMaster where itemid='" + ItemId + "'"));
                           // Batch = DS.Tables[0].Rows[0]["Bcode"].ToString();
                           

                            //if (Smrate == true && comratetype.SelectedIndex == 1)
                            //{
                            //    TempSrate = Convert.ToDouble(_DBTask.ExecuteScalar("select isnull(sum(rate),0) from tblproductrate where pcode ='" + Tempitemid + "' and batchid='" + TempBathcode + "'"));
                            //    GridRawMaterials.Rows[rowIndex1].Cells["clnsrate1"].Value = _DBTask.SetintoDecimalpoint(TempSrate);
                            //}
                            //else
                            //{
                                GridRawMaterials.Rows[rowIndex1].Cells["clnsrate1"].Value = _DBTask.SetintoDecimalpoint(TempSrate);
                            
                            //}
                                GridRawMaterials.Rows[rowIndex].Cells["clnprate1"].Value = _DBTask.SetintoDecimalpoint(TempPrate);
                            GridRawMaterials.Rows[rowIndex1].Cells["clnmrp1"].Value = _DBTask.SetintoDecimalpoint(TempMrp);
                            GridRawMaterials.Rows[rowIndex1].Cells["clnprate1"].Tag = _DBTask.ExecuteScalar("select incs from tblitemmaster where itemid='" + Tempitemid + "'");
                            GridRawMaterials.Rows[rowIndex1].Cells["clnbatchcode1"].Value = TempBathcode;
                         

                            NQTY1 = Convert.ToDouble(GridRawMaterials.Rows[rowIndex1].Cells["clnqty1"].Value);

                            GridRawMaterials.Rows[rowIndex1].Cells["clncrate1"].Value = _DBTask.SetintoDecimalpoint(TempCrate);
                            NCRATE = Convert.ToDouble(GridRawMaterials.Rows[rowIndex1].Cells["clncrate1"].Value);
                            
                            
                            uscGridshow2.Visible = false;
                            GridEdit = false;
                            cellEnterCalculationpart();

                            
                                GridRawMaterials.NotifyCurrentCellDirty(false);

                            if (SearchBarcode == false)
                            {
                                GridRawMaterials.Rows.Add(1);
                                GridRawMaterials.CurrentCell = GridRawMaterials.Rows[rowIndex1 + 1].Cells[0];
                            }

                        }
                        else
                        {
                            MessageBox.Show("Batchcode Not exsting");
                            if (Useasbarcode == true)
                            {
                                GridRawMaterials.CurrentCell = GridRawMaterials.Rows[rowIndex1].Cells["clnbatchcode1"];
                            }
                        }

                    

                }
            }
            catch
            {

            }
        }



        void txt1_TextChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();

            if ((sender as TextBox).Text == "")
            {
                if (columnName1 != "clnitemcode1" && columnName1 != "clnitemname1" && columnName1 != "clnslno1")
                {
                    (sender as TextBox).Text = "0";
                }
            }
            GridRawMaterials.Rows[rowIndex1].Cells[columnIndex1].Value = (sender as TextBox).Text;

            NQTY1 = _DBTask.znlldoubletoobject(GridRawMaterials.Rows[rowIndex1].Cells["clnqty1"].Value);
            NCRATE = _DBTask.znlldoubletoobject(GridRawMaterials.Rows[rowIndex1].Cells["clnprate1"].Value);

            string temp1 = _DBTask.znllString(GridRawMaterials.Rows[rowIndex1].Cells[columnIndex1].Value);
            if (columnName1 == "clnitemcode1")
            {
                comfromdepo.Tag = DepoFromId;
                DS = _DBTask.ExecuteQuery("select * from TblInventory where dcode='" + comfromdepo.Tag + "'");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    ProductGridShow1("where (itemCode Like N'%" + temp1 + "%' OR itemName Like N'%" + temp1 + "%') and Status=1 and TblItemMaster.Itemclass!='Finished Product'");
                   // ProductGridShow1(temp1);
                }
                else
                {
                    MessageBox.Show("Stocked Items Are Not Fount");
                }
            }
            if (columnName1 == "clnbatchcode1")
            {
             
                comfromdepo.Tag = DepoFromId;
                DS = _DBTask.ExecuteQuery("select * from TblInventory where dcode='" + comfromdepo.Tag + "'");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    if (getFill != true)
                    {
                        ProductGridShowWithBatch1("where Tblbatch.bcode like N'%" + temp1 + "%'and TblItemMaster.Itemclass!='Finished Product'");
                    }
                } 
                else
                {
                    MessageBox.Show("Stocked Items Are Not Fount");
                }
            }
            GridEdit = false;

            cellEnterCalculationRowmeterials();
           
            TotalRowmeterials();

            TotalcalcPacked();
        }

       
        

        private void CmdClear_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Main();
            

        }

        private bool Main()
        {
            if (EditMode == false)
            {
                GetVno();
            }

            RowValidation();
            if (validationFu())
            {
                if (EditMode == true)
                {
                    DeleteVoucher();
                }

                Initialize();
                Initialize1();
                ClearinFocusGrid();
            }
            return true;
        }

        public void DeleteVoucher()
        {
        _DBTask.ExecuteNonQuery("delete from tblrepacking where vno ='"+txtvno.Text+"'");
        _DBTask.ExecuteNonQuery("delete from tblrepackingdetails where vno ='" + txtvno.Text + "'");
        _DBTask.ExecuteNonQuery("delete from tblinventory where vcode='" + txtvno.Text + "' and ireceipt!=0");
        _DBTask.ExecuteNonQuery("delete from tblinventory where vcode='" + txtvno.Text + "' and iissue!=0");
        }

        public void GetVno()
        {
            Vid = Convert.ToInt64(Generalfunction.getnextid("Vno", "dbo.tblRepacking"));
            txtvno.Text = Vid.ToString();
            txtvno.Tag = Vid.ToString();
            _Repacking.Vno =Convert.ToInt64(txtvno.Text);
            _RepackingDetails.Vno =Convert.ToInt64(txtvno.Text) ;
           
            CommonClass._Inventory.Vcode = txtvno.Text.ToString();
         
        }

        public void Initialize()
        {
            for (int i = 0; i < GridPackedMaterial.Rows.Count; i++)
            {
                if (GridPackedMaterial.Rows[i].Tag != null)
                {
                    if (GridPackedMaterial.Rows[i].Tag.ToString() == "1")
                    {                       
                        long Slno = Convert.ToInt64(i);
                      
                        string ItemCode = GridPackedMaterial.Rows[i].Cells["clnitemcode"].Value.ToString();
                        string ItemId = GridPackedMaterial.Rows[i].Cells["clnItemname"].Tag.ToString();
                      
                        double qty = _DBTask.gridnul(GridPackedMaterial.Rows[i].Cells["clnqty"].Value);
                        double Srate = _DBTask.gridnul(GridPackedMaterial.Rows[i].Cells["clnSrate"].Value);
                        double NetAmt = _DBTask.gridnul(GridPackedMaterial.Rows[i].Cells["clnAmount"].Value);
                        double Prate = _DBTask.gridnul(GridPackedMaterial.Rows[i].Cells["clnPrate"].Value);
                        double Crate = _DBTask.gridnul(GridPackedMaterial.Rows[i].Cells["clnCrate"].Value);
                        double Mrp = _DBTask.gridnul(GridPackedMaterial.Rows[i].Cells["clnMRP"].Value);
                       
                        comTodepo.Tag = DepoToid;

                        DateTime DtMdate = Convert.ToDateTime("01-01-1900");
                        DateTime DtEdate =Convert.ToDateTime("01-01-1900");

                        if (SBatch == true)
                        {
                            //CommonClass._Batch.CheckbarcodeandreturnMax(GridPackedMaterial, i);
                            string Bcode = GridPackedMaterial.Rows[i].Cells["clnbatch"].Value.ToString();
                            GridPackedMaterial.Rows[i].Cells["clnbatch"].Tag =CommonClass._Dbtask.znllString( Bcode);
                            string Itemid = GridPackedMaterial.Rows[i].Cells["clnitemname"].Tag.ToString();
                            
                            
                            if (CommonClass.temp == "" || CommonClass.temp == null)
                            {
                                CommonClass.temp = "0";
                            }

                            if (CommonClass._Dbtask.znllString(GridPackedMaterial.Rows[i].Cells["clnbatch"].Tag) == "")
                            {
                                GridPackedMaterial.Rows[i].Cells["clnbatch"].Tag = CommonClass.temp;
                            }
                            BatchCode = GridPackedMaterial.Rows[i].Cells["clnbatch"].Value.ToString();

                        }
                   
                        CommonClass._Inventory.Ledcode = SalesAccount;
                        CommonClass._Inventory.DCodeStr = comTodepo.Tag.ToString(); ;
                        CommonClass._Inventory.InvDateDt = dtdate.Value;
                        CommonClass._Inventory.PcodeStr = ItemId;

                             /*Update Rates*/
                        CommonClass._Itemmaster.UpdateField(ItemId, Srate, "srate");
                        CommonClass._Itemmaster.UpdateField(ItemId, Prate, "prate");
                        /***************************/
                        if (SBatch == true)
                        {
                            CommonClass._Inventory.Batchcode = BatchCode;
                        }
                        else
                        {
                            CommonClass._Inventory.Batchcode = "0";
                        }
                        
                        // CommonClass._Inventory.Sales = qty;
                        CommonClass._Inventory.Sr = 0;
                        CommonClass._Inventory.Dn = 0;
                        CommonClass._Inventory.Iissue = 0;
                        CommonClass._Inventory.Ireceipt = qty;
                        CommonClass._Inventory.InsertInventory();

                        _Repacking.Slno = Slno.ToString();
                        _Repacking.ItemId =Convert.ToInt64(ItemId);
                        _Repacking.QTY = qty;
                        _Repacking.PRate = Prate;
                        _Repacking.CRate = Crate;
                        _Repacking.SRate = Srate;
                        _Repacking.Mrp = Mrp;
                        if (SBatch == true)
                        {
                            _Repacking.BatchCode = BatchCode;
                        }
                        else
                        {
                            _Repacking.BatchCode = "0";
                        }
                        _Repacking.Amount = Netamount;
                        _Repacking.Vno =Convert.ToInt64(txtvno.Text);
                        _Repacking.VDate = dtdate.Value;
                        _Repacking.PDate = dtPackingdate.Value;
                        _Repacking.Narretion = txtNaretion.Text;
                        _Repacking.LabourCharge =Convert.ToDouble(txtLabourCharge.Text);
                        _Repacking.CostFactor =Convert.ToDouble(txtCostFactor.Text);
                        _Repacking.DepoId =Convert.ToDouble(comTodepo.Tag) ;
                        _Repacking.InsertRepacking();


                      



                        if (SBatch == true )
                        {
                          //  CommonClass._Dbtask.ExecuteNonQuery("delete from tblbatch where itemid='" + ItemId + "' and bcode='" + BatchCode + "'");
                          //  CommonClass._Batch.Bcode = BatchCode;
                          //  CommonClass._Batch.Itemid = ItemId;
                          //  CommonClass._Batch.Costcenter = "0";
                          //  CommonClass._Batch.Depo = comTodepo.Tag.ToString();
                          //  CommonClass._Batch.ManDate =DtMdate;
                          //  CommonClass._Batch.ExDate = DtEdate;
                          ////  CommonClass._Batch.Depo = "0";
                          //  CommonClass._Batch.Bid = CommonClass._Dbtask.znllString(GridPackedMaterial.Rows[i].Cells["clnbatch"].Tag);

                          //  if (CommonClass._Batch.Bid != null)
                          //  {
                          //      if (CommonClass._Batch.Bid != "")
                          //      {
                          //          string PreBatch = CommonClass._Paramlist.GetParamvalue("Prebarcode");
                          //          int PreLength = PreBatch.Length;
                          //          string PreBatch2 = BatchCode.Substring(0, PreLength);
                          //          string tempBatch = CommonClass._Paramlist.GetParamvalue("MaxBcode");
                          //          try
                          //          {
                          //              if (Convert.ToDouble(CommonClass._Batch.Bid) > Convert.ToDouble(tempBatch) && PreBatch2 == PreBatch)
                          //                  CommonClass._Paramlist.UpdateParamlist("MaxBcode", "1", CommonClass._Batch.Bid.ToString());
                          //          }
                          //          catch
                          //          {
                          //          }
                          //      }
                          //  }
                          //  CommonClass._Batch.Recptcode = txtvno.Text.ToString();
                          //  CommonClass._Batch.Ledcode = "0";
                          //  CommonClass._Batch.Mrp = Mrp;
                          //  CommonClass._Batch.Srate = Srate;
                          //  CommonClass._Batch.Prate = Prate;
                          //  CommonClass._Batch.InsertBatch();
                        }
                     
                    }
                    CommonClass._Nextg.SetVno(txtvno.Text);
                   
                }

            }

           
        }
        public void Initialize1()
        {
            for (int i = 0; i < GridRawMaterials.Rows.Count; i++)
            {
                if (GridRawMaterials.Rows[i].Tag != null)
                {
                    if (GridRawMaterials.Rows[i].Tag.ToString() == "1")
                    {

                        string BatchCode1;
                        long Slno1 = Convert.ToInt64(i);
                        //string SlTracking = _Dbtask.znllString(GridPackedMaterial.Rows[i].Cells["clnserialno"].Value);
                        long pid1 = Convert.ToInt64(GridRawMaterials.Rows[i].Cells["clnitemname1"].Tag);
                        // string Itemname1 = GridRawMaterials.Rows[i].Cells["clniemname1"].Value.ToString();
                        string ItemCode1 = GridRawMaterials.Rows[i].Cells["clnitemcode1"].Value.ToString();
                        long itemId1 = pid1; //Convert.ToInt64(_DBTask.ExecuteScalar("select Itemid from TblItemMaster where Itemcode=N'" + ItemCode1 + "'"));
                        if (SBatch == true)
                        {
                            BatchCode1 = GridRawMaterials.Rows[i].Cells["clnbatchcode1"].Value.ToString();
                        }
                        double qty1 = _DBTask.gridnul(GridRawMaterials.Rows[i].Cells["clnqty1"].Value);
                        double Srate1 = _DBTask.gridnul(GridRawMaterials.Rows[i].Cells["clnsrate1"].Value);
                        double NetAmt1 = _DBTask.gridnul(GridRawMaterials.Rows[i].Cells["clnamount1"].Value);
                        double Prate1 = _DBTask.gridnul(GridRawMaterials.Rows[i].Cells["clnprate1"].Value);
                        double Crate1 = _DBTask.gridnul(GridRawMaterials.Rows[i].Cells["clncrate1"].Value);
                        double Mrp1 = _DBTask.gridnul(GridRawMaterials.Rows[i].Cells["clnmrp1"].Value);
                        comfromdepo.Tag = DepoFromId;

                        //if (SBatch == true)
                        //{
                        //    batchcode = GridPackedMaterial.Rows[i].Cells["clnbatch"].Value.ToString();
                        //}

                        CommonClass._Inventory.Ledcode = SalesAccount;
                        CommonClass._Inventory.DCodeStr = comfromdepo.Tag.ToString(); ;
                        CommonClass._Inventory.InvDateDt = dtdate.Value;
                        CommonClass._Inventory.PcodeStr = pid1.ToString();

                        /*Update Rates*/
                        CommonClass._Itemmaster.UpdateField(pid1.ToString(), Srate1, "srate");
                        CommonClass._Itemmaster.UpdateField(pid1.ToString(), Prate1, "prate");
                        /***************************/

                        if (SBatch == true)
                        {
                            BatchCode1 = GridRawMaterials.Rows[i].Cells["clnbatchcode1"].Value.ToString();
                            CommonClass._Inventory.Batchcode = BatchCode1;
                        }
                        else
                        {
                            CommonClass._Inventory.Batchcode = "0";
                        }
                        // CommonClass._Inventory.Sales = qty;
                        CommonClass._Inventory.Sr = 0;
                        CommonClass._Inventory.Dn = 0;
                        CommonClass._Inventory.Iissue = qty1;
                        CommonClass._Inventory.Ireceipt = 0;

                        CommonClass._Inventory.InsertInventory();

                        _RepackingDetails.Vno = Convert.ToInt64(txtvno.Text);
                        _RepackingDetails.Slno = Slno1.ToString();
                        _RepackingDetails.ItemId = itemId1;
                        if (SBatch == true)
                        {
                            BatchCode1 = GridRawMaterials.Rows[i].Cells["clnbatchcode1"].Value.ToString();
                            _RepackingDetails.Batchcode = BatchCode1;
                        }
                        else
                        {
                            _RepackingDetails.Batchcode = "0";
                        }
                        _RepackingDetails.Qty = qty1;
                        _RepackingDetails.Prate = Prate1;
                        _RepackingDetails.Crate = Crate1;
                        _RepackingDetails.Srate = Srate1;
                        _RepackingDetails.Mrp = Mrp1;
                        _RepackingDetails.DepoId =Convert.ToDouble(comfromdepo.Tag);
                        _RepackingDetails.Amount = Netamount1;

                        _RepackingDetails.InsertRepackingDetails();


                    }
                    CommonClass._Nextg.SetVno(txtvno.Text);


                }

            }
        }


        public void ClearinFocusGrid()
        {
           CommonClass._Nextg.ClearControles(pnlFirst);
            CommonClass._Nextg.ClearControles(pnlLast);
            txtLabourCharge.Text = "";
            txtCostFactor.Text = "";
            txttotaiPacked.Text = "";
            txttotalRaw.Text = "";
            dtdate.Value = DateTime.Now;
            GridRawMaterials.Rows.Clear();
            GridPackedMaterial.Rows.Clear();
            GetVno();

        }
        public bool validationFu()
        {
            if (txtCostFactor.Text == "")
            {
                DialogResult Result = MessageBox.Show("Enter Cost Factor", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCostFactor.Focus();
                return false;
            }
            if (txtLabourCharge.Text == "")
            {
                DialogResult Result = MessageBox.Show("Enter Labour Charge", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLabourCharge.Focus();
                return false;
            }
            return true;
        }
        public void FillCombo()
        {
          //  _DBTask.fillDatainCombowithQuery(comfromsettproduct, "itemid", "itemname", "Tblitemmaster", "SELECT     TblItemMaster.ItemName, TblItemMaster.ItemId  FROM  TblItemMaster INNER JOIN Tblproductsett ON TblItemMaster.ItemId = Tblproductsett.item");

            if (SBatch == false)
            {
                _DBTask.fillDatainCombowithQuery(comfromsettproduct, "itemid", "itemname", "TblItemMaster", "select itemname,itemid from tblitemmaster where itemid in(select item from tblproductsett)");
            }
            else
            {
                _DBTask.fillDatainCombowithQuery(comfromsettproduct, "BCODE", "BCODE", "tblBATCH", "select BCODE,ITEMID from tblBATCH  where itemid in(select item from tblproductsett)");
            }


            _DBTask.fillDatainCombowithQuery(comTodepo, "Dcode", "DName", "TblDepot", "select * from TblDepot ");
            _DBTask.fillDatainCombowithQuery(comfromdepo, "Dcode", "DName", "TblDepot", "select * from TblDepot");
        }
        public void RowValidation()
        {
            try
            {
                for (int i = 0; i < GridPackedMaterial.Rows.Count; i++)
                {
                    if (GridPackedMaterial.Rows[i].Cells["clnItemname"].Tag == null || _DBTask.znlldoubletoobject(GridPackedMaterial.Rows[i].Cells["clnAmount"].Value) <=0)
                    {
                        GridPackedMaterial.Rows[i].Tag = -1;
                        // GridPackedMaterial.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        GridPackedMaterial.Rows[i].Tag = 1;
                    }
                }
                for (int i = 0; i < GridRawMaterials.Rows.Count; i++)
                {
                    if (GridRawMaterials.Rows[i].Cells["clnitemname1"].Tag == null || _DBTask.znlldoubletoobject(GridRawMaterials.Rows[i].Cells["clnamount1"].Value) <=0)
                    {
                        GridRawMaterials.Rows[i].Tag = -1;
                        // GridPackedMaterial.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        GridRawMaterials.Rows[i].Tag = 1;
                        GridRawMaterials.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }

            }
            catch
            {
            }
        }

      
        public void FillFromSettproduct()
        {
            string Vno;
            string Itemcode;
            string ItemName;
            string Prate;
            string Srate;
            string MRP;
            string Qty;
            string SetId;

            GridPackedMaterial.Rows.Clear();
            GridRawMaterials.Rows.Clear();
            //getFill = true;
            Vno= comfromsettproduct.SelectedValue.ToString();
            //Vno = comfromsettproduct.SelectedIndex.ToString();
            //Vno = comfromsettproduct.se.ToString();
           string wherecon="";
            
            if(SBatch==false)
            {
          wherecon= "  item='" + Vno + "' ";
            SetId = _DBTask.ExecuteScalar("select id from Tblproductsett where item='" + Vno + "'");
            }
            else
            {
                 wherecon= "  bcode='" + Vno + "' ";
            SetId = _DBTask.ExecuteScalar("select id from Tblproductsett where bcode='" + Vno + "'");
          
            }
            DS = _DBTask.ExecuteQuery("select * from Tblproductsett where  "+wherecon+" ");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                GridEdit = true;
                string tempSlno = (i + 1).ToString();
                SItemid = DS.Tables[0].Rows[i]["item"].ToString();
                Qty =  _DBTask.znllString(DS.Tables[0].Rows[i]["qty"]);
                Itemcode = CommonClass._Itemmaster.SpecificField(SItemid, "itemcode");
                ItemName = CommonClass._Itemmaster.SpecificField(SItemid, "itemname");
                Prate =CommonClass._Itemmaster.SpecificField(SItemid, "prate");
                Srate =CommonClass._Itemmaster.SpecificField(SItemid, "srate");
                MRP =CommonClass._Itemmaster.SpecificField(SItemid, "mrp");
               // Batch=
                RowCounting=GridPackedMaterial.Rows.Add(1);

                    GridPackedMaterial.Rows[RowCounting].Cells["clnSlno"].Value = tempSlno;
                GridPackedMaterial.Rows[RowCounting].Cells["clnqty"].Value = Qty;
                GridPackedMaterial.Rows[RowCounting].Cells["clnitemcode"].Value = Itemcode;
                GridPackedMaterial.Rows[RowCounting].Cells["clnItemname"].Value = ItemName;
                GridPackedMaterial.Rows[RowCounting].Cells["clnItemname"].Tag = SItemid;
                GridPackedMaterial.Rows[RowCounting].Cells["clnPrate"].Value =Prate;
                GridPackedMaterial.Rows[RowCounting].Cells["clnsrate"].Value =Srate;
                GridPackedMaterial.Rows[RowCounting].Cells["clnmrp"].Value =MRP;

                if(SBatch==true)
                {
                    GridPackedMaterial.Rows[RowCounting].Cells["clnBatch"].Value = _DBTask.znllString(DS.Tables[0].Rows[i]["bcode"]);
                }


               // Templedouble =Convert.ToDouble(GridPackedMaterial.Rows[i].Cells["clnsrate"].Value) *Convert.ToDouble(GridPackedMaterial.Rows[i].Cells["clnqty"].Value);
                rowIndex = i;

                cellEnterCalculationpart();
                RowValidation();
                
            }
          //  Totalcalculation();
            GridEdit = false;

            DS = _DBTask.ExecuteQuery("select * from Tblproductsettdetail where id='" + SetId + "'");
           
          //  gridBatchList1.Visible = true;

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
              //  GridRawMaterials.Rows.Add(1);
                string tempSlno = (i + 1).ToString();

                Qty = _DBTask.znllString( DS.Tables[0].Rows[i]["qty"]);
                SItemid = DS.Tables[0].Rows[i]["item"].ToString();
                string barcode = "";
                barcode = _DBTask.znllString(DS.Tables[0].Rows[i]["bcode"]);
                Itemcode = CommonClass._Itemmaster.SpecificField(SItemid, "itemcode");
                ItemName = CommonClass._Itemmaster.SpecificField(SItemid, "itemname");
                Prate =CommonClass._Itemmaster.SpecificField(SItemid, "prate");
                if (SBatch == true)
                {
                    Srate = _DBTask.ExecuteScalar("select Srate from Tblbatch where bcode='" + barcode + "'");
                    MRP = _DBTask.ExecuteScalar("select mrp from Tblbatch where bcode='" + barcode + "'");
                    Batch = _DBTask.ExecuteScalar("select Bcode from Tblbatch where bcode='" + barcode + "'");

                }
                else
                {
                    Srate = CommonClass._Itemmaster.SpecificField(SItemid, "Srate");
                    MRP = CommonClass._Itemmaster.SpecificField(SItemid, "MRP");

                }
                Crate =_DBTask.znullDouble(CommonClass._Itemmaster.SpecificField(SItemid, "Crate"));
               
                RowCounting = GridRawMaterials.Rows.Add(1);
                GridRawMaterials.Rows[RowCounting].Cells["clnslno1"].Value = tempSlno;
                GridRawMaterials.Rows[RowCounting].Cells["clnitemcode1"].Value = Itemcode;
               
                GridRawMaterials.Rows[RowCounting].Cells["clnItemname1"].Value = ItemName;
                GridRawMaterials.Rows[RowCounting].Cells["clnitemname1"].Tag = SItemid;

                GridRawMaterials.Rows[RowCounting].Cells["clnsrate1"].Value =_DBTask.znullDouble (Srate);

                GridRawMaterials.Rows[RowCounting].Cells["clnmrp1"].Value =_DBTask.znullDouble(MRP);
                GridRawMaterials.Rows[RowCounting].Cells["clnbatchcode1"].Value = Batch;
                GridRawMaterials.Rows[RowCounting].Cells["clnPrate1"].Value =_DBTask.znullDouble(Prate);
               
                NQTY1 = Convert.ToDouble(Qty);
                GridRawMaterials.Rows[RowCounting].Cells["clnqty1"].Value =_DBTask.znullDouble(Qty);

                NCRATE = Crate;
                GridRawMaterials.Rows[RowCounting].Cells["clncrate1"].Value =Crate;
               
               
                Templedouble1 = Convert.ToDouble(GridRawMaterials.Rows[i].Cells["clncrate1"].Value) * Convert.ToDouble(GridRawMaterials.Rows[i].Cells["clnqty1"].Value);
                rowIndex1 = i;

               
                cellEnterCalculationpart();
                RowValidation();
                
            }
            //Totalcalculation();
            getFill = true;
            GridRawMaterials.Select();
       
        }
        public void FillQty()
        {
            //GridEdit = false;
            //string Vno;
            //string selectId;
            //Vno = comfromsettproduct.SelectedValue.ToString();
            //selectId = _DBTask.ExecuteScalar("select id from Tblproductsett where item='" + Vno + "'");

            //DS = _DBTask.ExecuteQuery("select * from Tblproductsettdetail where id='" + selectId + "'");
            //if (GridPackedMaterial.Rows[rowIndex].Cells["clnqty"].Value.ToString() != "")
            //{
            //    //CellEnter();
            //    string qty = GridPackedMaterial.Rows[rowIndex].Cells["clnqty"].Value.ToString();
            //    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            //    {
            //        SItemid = DS.Tables[0].Rows[i]["item"].ToString();
            //        string qty1 = DS.Tables[0].Rows[i]["qty"].ToString();
            //        double totalqty = Convert.ToDouble(qty) * Convert.ToDouble(qty1);
            //        Crate =_DBTask.znullDouble(_DBTask.ExecuteScalar("select prate from tblitemmaster where itemid='" + SItemid + "'"));

            //        NQTY1 = totalqty;
            //        GridRawMaterials.Rows[i].Cells["clnqty1"].Value = totalqty;

            //        NCRATE = Convert.ToDouble(Prate1);
            //        GridRawMaterials.Rows[i].Cells["clncrate1"].Value = Crate;
            //        GridRawMaterials.Rows[i].Cells["clnprate1"].Value = Crate;
            //        NCRATE = Crate;
            //        rowIndex1 = i;
            //        cellEnterCalculationRowmeterials();
            //       // RowValidation();

            //    }
            //    Totalcalculation();
            //}
        }
        private void cmdfillsettproduct_Click(object sender, EventArgs e)
        {
            FillFromSettproduct();
          //  gridBatchList1.Visible = true;
           
        }

        private void GridPackedMaterial_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;


            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);

            txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);

            txt.Enter -= new EventHandler(txt_Enter);
            txt.Enter += new EventHandler(txt_Enter);
        }

        private void GridRawMaterials_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt1 = e.Control as TextBox;

            txt1.TextChanged -= new EventHandler(txt1_TextChanged);
            txt1.TextChanged += new EventHandler(txt1_TextChanged);

            txt1.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt1_PreviewKeyDown);
            txt1.PreviewKeyDown += new PreviewKeyDownEventHandler(txt1_PreviewKeyDown);

            txt1.KeyPress -= new KeyPressEventHandler(txt1_KeyPress);
            txt1.KeyPress += new KeyPressEventHandler(txt1_KeyPress);

            txt1.Enter -= new EventHandler(txt1_Enter);
            txt1.Enter += new EventHandler(txt1_Enter);
        }

        private void GridPackedMaterial_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
                columnIndex = GridPackedMaterial.CurrentCell.ColumnIndex;
                rowIndex = GridPackedMaterial.CurrentCell.RowIndex;
                columnName = GridPackedMaterial.Columns[columnIndex].Name.ToString();

                GridPackedMaterial.Rows[rowIndex].Cells["clnSlno"].Value = rowIndex + 1;
                CellEnter();
           
        }
        public void CellEnter()
        {
            if ( columnName == "clnSrate" || columnName == "clnPrate" || columnName == "clnCrate" || columnName == "clnbatch" || columnName == "clnMRP" || columnName == "clnqty")
            {
                GridPackedMaterial.BeginEdit(true);
                //  GridPackedMaterial.CurrentCell = GridPackedMaterial.Rows[rowIndex].Cells["clnitemcode"];

            }
            if (columnName == "clnSlno")
            {
                SendKeys.Send("{Tab}");

            }
            if (columnName == "clnItemname")
            {
                SendKeys.Send("{Tab}");
            }
            if (columnName == "clnCrate")
            {
                SendKeys.Send("{Tab}");
            }
            if (columnName == "clnAmount")
            {
                SendKeys.Send("{Enter}");
            }
            if (columnName == "clnbatch")
            {               
                if (clnbatch.ReadOnly == true)
                {
                    Getbatchcode();
                }
            }
            if (columnName == "clnqty")
            {
                if (getFill == true)
                {
                  //  FillQty();
                }
            }
           
           
        }

        public void BatachEnter()
        {
            GridBatchlist.Visible = true;

        }

        private void GridRawMaterials_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            rowIndex1 = GridRawMaterials.CurrentCell.RowIndex;
            columnIndex1 = GridRawMaterials.CurrentCell.ColumnIndex;
            columnName1 = GridRawMaterials.Columns[columnIndex1].Name.ToString();

            GridRawMaterials.Rows[rowIndex1].Cells["clnslno1"].Value = rowIndex1 + 1;

            CellEnter1();
        }
        public string BarcodeBackValue(string Value)
        {
            if (Value.Length == 1)
                Value = "00" + Value;
            else if (Value.Length == 2)
                Value = "0" + Value;
            return Value;
        }

        public void Getbatchcode()
        {
            try
            {
                if (SBatch == true && SearchBarcode == false)
                {
                    if (Retrivemode == 0)
                    {

                        if (_DBTask.znllString(GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value) == "")
                        {
                            if (rowIndex == 0 || EditMode == true)
                            {
                                if (rowIndex != 0)
                                {
                                    if (EditMode == true && GridPackedMaterial.Rows[rowIndex - 1].Cells["clnbatch"].Tag != null && GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Tag == null)
                                    {
                                        GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = CommonClass._Batch.BatchMax();
                                        GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Tag = CommonClass._Batch.MaxBatchcode;
                                        GridPackedMaterial.Rows[rowIndex + 1].Cells["clnbatch"].Tag = 1;
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(GridPackedMaterial.Rows[rowIndex - 1].Cells["clnbatch"].Tag) != 0)
                                        {
                                            GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Tag = Convert.ToDouble(GridPackedMaterial.Rows[rowIndex - 1].Cells["clnbatch"].Tag) + 1;
                                            string BackValue = BarcodeBackValue(GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Tag.ToString());
                                            Batch = CommonClass._Batch.Batchstring + BackValue;
                                            GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = Batch;
                                            GridPackedMaterial.Rows[rowIndex + 1].Cells["clnbatch"].Tag = 1;
                                        }
                                        else
                                        {

                                            GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = CommonClass._Batch.BatchMax();
                                            GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Tag = CommonClass._Batch.MaxBatchcode;
                                            GridPackedMaterial.Rows[rowIndex + 1].Cells["clnbatch"].Tag = 1;
                                        }
                                    }
                                }
                                else
                                {
                                    GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = CommonClass._Batch.BatchMax();
                                    GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Tag = CommonClass._Batch.MaxBatchcode;
                                    GridPackedMaterial.Rows[rowIndex + 1].Cells["clnbatch"].Tag = 1;
                                }
                            }
                            else
                            {

                                GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Tag = Convert.ToDouble(GridPackedMaterial.Rows[rowIndex - 1].Cells["clnbatch"].Tag) + 1;
                                Batch = (GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Tag).ToString();
                                Batch = CommonClass._Batch.Batchstring + CommonClass._Batch.BatchcodeSpecified(Batch);
                                GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = Batch;
                                GridPackedMaterial.Rows[rowIndex + 1].Cells["clnbatch"].Tag = 1;

                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
        public void CellEnter1()
        {
            if (columnName1 == "clnslno1")
            {
                SendKeys.Send("{Tab}");

            }
            if (columnName1 == "clnitemname1")
            {
                SendKeys.Send("{Tab}");

            }
            if (columnName1 == "clncrate1")
            {
                SendKeys.Send("{Tab}");

            }
            if (columnName1 == "clnamount1")
            {
                SendKeys.Send("{Enter}");

            }
            if (columnName1 == "clnbatchcode1")
            {
                Rectangle tempRect = GridRawMaterials.GetCellDisplayRectangle(GridRawMaterials.CurrentCell.ColumnIndex, GridRawMaterials.CurrentCell.RowIndex, false);
                _InGrid.ProductGridShowLocationSettGrid(gridBatchList1, tempRect.Left, tempRect.Top + tempRect.Height - 10); 
                gridBatchList1.Columns[0].Width = gridBatchList1.Width - 10;

                if (getFill == true && GridRawMaterials.Rows[rowIndex1].Cells["clnitemname1"].Tag != null)
                {
                    string itemid;
                    itemid = GridRawMaterials.Rows[rowIndex1].Cells["clnitemname1"].Tag.ToString();
                    gridBatchList1.Visible = true;
                    DS = _DBTask.ExecuteQuery("select * from Tblbatch where itemid='" + itemid + "'");
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        gridBatchList1.Rows.Add(1);
                        string batchlist;
                        batchlist = DS.Tables[0].Rows[i]["bcode"].ToString();
                        gridBatchList1.Rows[i].Cells[0].Value = batchlist;

                    }
                }
            }
        }

        public void LoadBatches1(string Search)
        {

            gridBatchList1.CellBorderStyle = DataGridViewCellBorderStyle.None;                        //+ 34 * 3//
            CommonClass._Batch.BatchlistshowBaseonItem(ItemId, gridBatchList1, Search);
            Rectangle tempRect = GridRawMaterials.GetCellDisplayRectangle(GridRawMaterials.CurrentCell.ColumnIndex, GridRawMaterials.CurrentCell.RowIndex, false);
            _InGrid.ProductGridShowLocationSettGrid(gridBatchList1, tempRect.Left, tempRect.Top + tempRect.Height + 20);
            gridBatchList1.Columns[0].Width = gridBatchList1.Width - 10;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GridPackedMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }

            if (e.KeyValue == 122)/*For F11 Barcode*/
            {
                if (SBatch == true)
                {
                    if (clnbatch.ReadOnly == true)
                        clnbatch.ReadOnly = false;
                    else
                        clnbatch.ReadOnly = true;
                }
            }
        }

        private void GridPackedMaterial_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridPackedMaterial.Columns[columnIndex].Name.ToString() == "clnbatch")
                {
                    GridBatchlist.Visible = false;
                    if (IsinBatchList == true)
                    {
                        GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value = BatchCode;
                        GridPackedMaterial.NotifyCurrentCellDirty(false);
                        IsinBatchList = false;
                    }
                    Batch = GridPackedMaterial.Rows[rowIndex].Cells["clnbatch"].Value.ToString();
                    string TempBatch = CommonClass._Dbtask.ExecuteScalar("select distinct bcode from tblbatch where bcode='" + Batch + "'");
                    string TempItemName = CommonClass._Dbtask.znllString(GridPackedMaterial.Rows[rowIndex].Cells["clnitemname"].Value);
                    if (TempBatch != "" || TempItemName == "")
                    {
                        ItemId = _DBTask.ExecuteScalar("select distinct itemid from tblbatch where bcode='" + Batch + "'");
                        _Purchase.RefillingRow(GridPackedMaterial, ItemId, rowIndex, TempBatch);
                        GridPackedMaterial.NotifyCurrentCellDirty(false);
                    }
                    if (Batch == "")
                        GridPackedMaterial.Rows[rowIndex].Cells["clnAmount"].Value = CommonClass._Dbtask.SetintoDecimalpoint(0);
                }


                if (SBatch == false)
                {
                    if (GridPackedMaterial.Columns[columnIndex].Name.ToString() == "clnItemCode")
                    {
                        gridBatchList1.Visible = false;

                        GridPackedMaterial.NotifyCurrentCellDirty(false);
                        Itemcode = uscGridshow1.GridProductShow.SelectedRows[0].Index;
                        string SelectItem = Convert.ToString(uscGridshow1.GridProductShow.Rows[Itemcode].Cells["itemcode"].Value);

                        GridPackedMaterial.Rows[rowIndex].Cells["clnItemCode"].Value = SelectItem;

                    }
                }
            }
            catch
            {

            }
        }

        private void cmdback_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Tag) - 1).ToString(), false);
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
                    DS = _DBTask.ExecuteQuery("select * from tblRepacking where vno='" + PreIssuecode + "'");
                    DS2 = _DBTask.ExecuteQuery("select *  from TblRepackingDetails where vno='" + PreIssuecode + "'");

                    if (DS.Tables[0].Rows.Count != 0 || DS2.Tables[0].Rows.Count!=0)
                    {
                        GridPackedMaterial.Rows.Clear();
                        GridRawMaterials.Rows.Clear();
                        EditMode = true;
        
                        if (DS.Tables[0].Rows[0]["vno"] != null)
                        {
                            txtvno.Text = DS.Tables[0].Rows[0]["vno"].ToString();
                            PreIssuecode = DS.Tables[0].Rows[0]["vno"].ToString();
                            txtvno.Tag = PreIssuecode.ToString();
                        }
                        else
                        {
                            txtvno.Text = DS2.Tables[0].Rows[0]["vno"].ToString();
                            PreIssuecode = DS2.Tables[0].Rows[0]["vno"].ToString();
                            txtvno.Tag = PreIssuecode.ToString();
                        }
                            
             

                        CommonClass._Inventory.Vcode = PreIssuecode.ToString();

                        dtdate.Value = Convert.ToDateTime(DS.Tables[0].Rows[0]["VDate"]);
                        dtPackingdate.Value = Convert.ToDateTime(DS.Tables[0].Rows[0]["PackDate"]);
                        txtNaretion.Text=DS.Tables[0].Rows[0]["Narretion"].ToString();
                        string DepoId = DS.Tables[0].Rows[0]["DepoId"].ToString();
                        comTodepo.Text = _DBTask.ExecuteScalar("select Dname from tbldepot where Dcode='" + DepoId + "'");
                        comTodepo.Tag = DepoId;
                     //   string Depoid1 = DS2.Tables[0].Rows[0]["DepoId"].ToString();
                      //  comfromdepo.Text = _DBTask.ExecuteScalar("select Dname from tbldepot where Dcode='" + Depoid1 + "'");
                      //  comfromdepo.Tag = Depoid1;
                        double Labourcharge =Convert.ToDouble(DS.Tables[0].Rows[0]["LabourCharge"]);
                        txtLabourCharge.Text=Labourcharge.ToString();
                        double Costfactor =Convert.ToDouble(DS.Tables[0].Rows[0]["CostFactor"]);
                        txtCostFactor.Text = Costfactor.ToString();
                        if(SBatch==true)
                        {
                            //comfromsettproduct.SelectedValue = _DBTask.znllString(DS.Tables[0].Rows[0]["batchcode"]);


                            txtfinishproduct.Text= _DBTask.znllString(DS.Tables[0].Rows[0]["batchcode"]);
                            txtbarcode.Tag = _DBTask.znllString(DS.Tables[0].Rows[0]["itemid"]);
                            txtbarcode.Text = CommonClass._Itemmaster.SpecificField(_DBTask.znllString(txtbarcode.Tag), "itemname");
                        
                        
                        }
                            else
                            {

                                txtfinishproduct.Tag = _DBTask.znllString(DS.Tables[0].Rows[0]["itemid"]);
                                txtbarcode.Tag = _DBTask.znllString(DS.Tables[0].Rows[0]["itemid"]);
                                txtbarcode.Text = CommonClass._Itemmaster.SpecificField(_DBTask.znllString(txtbarcode.Tag), "itemcode");
                                txtfinishproduct.Text = CommonClass._Itemmaster.SpecificField(_DBTask.znllString(txtbarcode.Tag), "itemname");

                            }


                        gridmaintwo.Visible = false;

                        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        {
                            GridEdit=true;

                            GridPackedMaterial.Rows.Add(1);
                                string tempSlno = (i + 1).ToString();
                            string tempitemid = DS.Tables[0].Rows[i]["Itemid"].ToString();
                            double tempQty = Convert.ToDouble(DS.Tables[0].Rows[i]["QTY"].ToString());
                            double tempPrate = Convert.ToDouble(DS.Tables[0].Rows[i]["PRate"].ToString());
                            double tempCrate = Convert.ToDouble(DS.Tables[0].Rows[i]["CRate"].ToString());
                            string Itemname = _DBTask.ExecuteScalar("select Itemname from tblitemmaster where itemid='" + tempitemid + "'");
                            string Itemcode = _DBTask.ExecuteScalar("select Itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                            double tempsRate = Convert.ToDouble(DS.Tables[0].Rows[i]["SRate"].ToString());
                            double tempNetAmt = Convert.ToDouble(DS.Tables[0].Rows[i]["Amount"].ToString());
                            string tempBatchid = DS.Tables[0].Rows[i]["Batchcode"].ToString();


                            GridPackedMaterial.Rows[i].Cells["clnbatch"].Value = tempBatchid;
                            GridPackedMaterial.Rows[i].Cells["clnSlno"].Value = tempSlno;
                            GridPackedMaterial.Rows[i].Cells["clnCrate"].Value = tempCrate;
                            GridPackedMaterial.Rows[i].Cells["clnSrate"].Value = tempsRate;
                            GridPackedMaterial.Rows[i].Cells["clnAmount"].Value = tempNetAmt;
                            GridPackedMaterial.Rows[i].Cells["clnItemname"].Value = Itemname;
                            GridPackedMaterial.Rows[i].Cells["clnItemname"].Tag = tempitemid;
                            comfromsettproduct.SelectedValue = tempitemid;
                            GridPackedMaterial.Rows[i].Cells["clnItemcode"].Value = Itemcode;
                            GridPackedMaterial.Rows[i].Cells["clnItemcode"].Tag = tempitemid;

                            NQTY = tempQty;
                            GridPackedMaterial.Rows[i].Cells["clnQTY"].Value = _DBTask.SetintoDecimalpointStock(tempQty);

                            NPRATE=tempPrate;
                            GridPackedMaterial.Rows[i].Cells["clnPrate"].Value = _DBTask.SetintoDecimalpoint(tempPrate);
         
                            GridPackedMaterial.Rows[i].Cells["clnPrate"].Tag = _DBTask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");

                            Templedouble = Convert.ToDouble(GridPackedMaterial.Rows[i].Cells["clnPrate"].Value) * Convert.ToDouble(GridPackedMaterial.Rows[i].Cells["clnqty"].Value);
                            rowIndex = i;

                            cellEnterCalculationpart();
                            RowValidation();
                           
                        }
                        TotalcalcPacked();
                       GridEdit = false;
                        for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                        {
                            GridRawMaterials.Rows.Add(1);
                                string tempSlno = (i + 1).ToString();
                            string tempitemid = DS2.Tables[0].Rows[i]["Itemid"].ToString();
                            double tempQty = Convert.ToDouble(DS2.Tables[0].Rows[i]["QTY"].ToString());
                            double tempPrate = Convert.ToDouble(DS2.Tables[0].Rows[i]["PRate"].ToString());
                            double tempCrate = Convert.ToDouble(DS2.Tables[0].Rows[i]["CRate"].ToString());
                            string Itemname = _DBTask.ExecuteScalar("select Itemname from tblitemmaster where itemid='" + tempitemid + "'");
                            string Itemcode = _DBTask.ExecuteScalar("select Itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                            double tempsRate = Convert.ToDouble(DS2.Tables[0].Rows[i]["SRate"].ToString());
                            double tempNetAmt = Convert.ToDouble(DS2.Tables[0].Rows[i]["Amount"].ToString());
                            string tempBatchid = DS2.Tables[0].Rows[i]["Batchcode"].ToString(); ;

                            GridRawMaterials.Rows[i].Cells["clnslno1"].Value = tempSlno;
                            GridRawMaterials.Rows[i].Cells["clnbatchcode1"].Value = tempBatchid;

                            GridRawMaterials.Rows[i].Cells["clnprate1"].Value =tempPrate;
                            GridRawMaterials.Rows[i].Cells["clnsrate1"].Value = tempsRate ;
                            GridRawMaterials.Rows[i].Cells["clnamount1"].Value = tempNetAmt;
                            GridRawMaterials.Rows[i].Cells["clnitemname1"].Value = Itemname;
                            GridRawMaterials.Rows[i].Cells["clnitemname1"].Tag = tempitemid;
                            GridRawMaterials.Rows[i].Cells["clnitemcode1"].Value = Itemcode;
                            GridRawMaterials.Rows[i].Cells["clnitemcode1"].Tag = tempitemid;

                            NQTY1 = tempQty;
                            GridRawMaterials.Rows[i].Cells["clnqty1"].Value = _DBTask.SetintoDecimalpointStock(tempQty);

                            NCRATE = tempPrate;
                            GridRawMaterials.Rows[i].Cells["clncrate1"].Value =_DBTask.SetintoDecimalpoint(tempCrate);
                           
                 
                            GridRawMaterials.Rows[i].Cells["clnprate1"].Tag = _DBTask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");

                            Templedouble1 = Convert.ToDouble(GridRawMaterials.Rows[i].Cells["clncrate1"].Value) * Convert.ToDouble(GridRawMaterials.Rows[i].Cells["clnqty1"].Value);
                            rowIndex1 = i;

                            cellEnterCalculationRowmeterials();
                            RowValidation();
                        }

                        TotalRowmeterials();
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

        private void cmdFront_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Tag) + 1).ToString(), false);
        }

        private void comTodepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepoToid = comTodepo.SelectedValue.ToString();
        }

        private void comfromdepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepoFromId = comfromdepo.SelectedValue.ToString();
        }

        private void txtLabourCharge_TextChanged(object sender, EventArgs e)
        {
            txtLabourCharge.Select();
            
          //  Totalcalculation();
        }

        private void cmdSetproduct_Click(object sender, EventArgs e)
        {
           CommonClass._Forms.Showsettproduct();
        }
        public void ItemCrateCalculate()
        {
            double x;
            double xCostFact = _DBTask.znullDouble(txtCostFactor.Text);
            double xLabourcharge = _DBTask.znullDouble(txtLabourCharge.Text);
            double xx = xCostFact + xLabourcharge;
            double xnetAmt =_DBTask.znullDouble(txttotaiPacked.Text) - xx;
            double TRaw = _DBTask.znullDouble(txttotalRaw.Text)+xLabourcharge;

            for (int i = 0; i < GridPackedMaterial.Rows.Count; i++)  /* For Row NetAmount*/
            {
                if (GridPackedMaterial.Rows[i].Cells["clnItemname"].Tag != null)
                {
                    if (GridPackedMaterial.Rows[i].Cells["clnItemname"].Tag != "")
                    {
                        double TNetAmt = _DBTask.znullDouble(GridPackedMaterial.Rows[i].Cells["clnAmount"].Value.ToString());
                        double xPerc = TNetAmt * 100 / xnetAmt;
                        double xQty = _DBTask.znlldoubletoobject(GridPackedMaterial.Rows[i].Cells["clnqty"].Value);
                        double xPrate = _DBTask.znullDouble(GridPackedMaterial.Rows[i].Cells["clnPrate"].Value.ToString());
                        double XPerAmt = xx * xPerc / 100;
                        double XxtCrate = XPerAmt / xQty;
                        // double Xcrate = XxtCrate + xPrate;
                        double Xcrate = TRaw / xQty;
                        GridPackedMaterial.Rows[i].Cells["clnCrate"].Value = _DBTask.SetintoDecimalpoint(Xcrate);
                        GridPackedMaterial.Rows[i].Cells["clnprate"].Value = _DBTask.SetintoDecimalpoint(Xcrate);
                    }
                }
            }
            GridEdit = true;
        }

        private void txtCostFactor_TextChanged(object sender, EventArgs e)
        {
            txtCostFactor.Select();
           // Totalcalculation();
        }

        private void GridRawMaterials_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridRawMaterials.Columns[columnIndex1].Name.ToString() == "clnbatchcode1")
                {
                    gridBatchList1.Visible = false;
                    if (IsinBatchList == true)
                    {
                        GridRawMaterials.Rows[rowIndex1].Cells["clnbatchcode1"].Value = BatchCode;
                        GridRawMaterials.NotifyCurrentCellDirty(false);
                        IsinBatchList = false;
                    }
                    Batch = _DBTask.znllString(GridRawMaterials.Rows[rowIndex1].Cells["clnbatchcode1"].Value);
                    string TempBatch = CommonClass._Dbtask.ExecuteScalar("select distinct bcode from tblbatch where bcode='" + Batch + "'");
                    string TempItemName = CommonClass._Dbtask.znllString(GridRawMaterials.Rows[rowIndex1].Cells["clnitemname1"].Value);
                    if (TempBatch != "" || TempItemName == "")
                    {
                        ItemId = _DBTask.ExecuteScalar("select distinct itemid from tblbatch where bcode='" + Batch + "'");
                        GridRawMaterials.NotifyCurrentCellDirty(false);
                    }
                    if (Batch == "")
                        GridRawMaterials.Rows[rowIndex1].Cells["clnamount1"].Value = CommonClass._Dbtask.SetintoDecimalpoint(0);
                    if (columnName1 == "clncrate1" || columnName1 == "clnsrate1")
                    {
                        double Value = _DBTask.znlldoubletoobject(GridRawMaterials.Rows[rowIndex1].Cells[columnName1].Value);
                        GridRawMaterials.Rows[rowIndex1].Cells[columnName1].Value = Value;
                        
                    }
                }


                if (SBatch == false)
                {
                    if (GridRawMaterials.Columns[columnIndex1].Name.ToString() == "clnitemcode1")
                    {
                        gridBatchList1.Visible = false;

                        GridRawMaterials.NotifyCurrentCellDirty(false);
                        Itemcode = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                        string SelectItem = Convert.ToString(uscGridshow2.GridProductShow.Rows[Itemcode].Cells["itemcode"].Value);

                        GridRawMaterials.Rows[rowIndex1].Cells["clnitemcode1"].Value = SelectItem;

                    }
                }
            }
            catch
            {
            }
        }

     

        private void FrmRepacking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DeleteVoucher();
            clear();
        }

        private void comfromsettproduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtfinishproduct_TextChanged(object sender, EventArgs e)
        {
            
            if (SBatch== false)
            {
                dset = _DBTask.ExecuteQuery("select itemname,itemid,itemcode from tblitemmaster where itemid in(select item from tblproductsett)    and itemname like N'%" + _DBTask.znllString(txtfinishproduct.Text) + "%' or itemcode like N'%" + _DBTask.znllString(txtfinishproduct.Text) + "%'");
            }
            else
            {
                dset = CommonClass._Itemmaster.getbatchwiseprodctionitem(_DBTask.znllString(txtfinishproduct.Text));
            }

            gridmaintwo.Columns.Clear();
            gridmaintwo.DataSource = null;
            gridmaintwo.Visible = true;
            //***table********//
            gridmaintwo.DataSource = dset.Tables[0];

            for (int i = 0; i < gridmaintwo.Columns.Count; i++)
            {
                if (gridmaintwo.Columns[i].Name.ToString() == "itemid")
                    gridmaintwo.Columns[i].Visible = false;
            }
            if (SBatch == true)
            {
                gridmaintwo.Columns["BCODE"].Width = 180;
                gridmaintwo.Columns["itemname"].Width = 190;
            }
            else
            {
                gridmaintwo.Columns["itemcode"].Width = 180;
                gridmaintwo.Columns["itemname"].Width = 190;
            }

            this.gridmaintwo.Location = new System.Drawing.Point(6, 39); 
        }

        private void txtfinishproduct_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            {
            try
            {

                if (gridmaintwo.SelectedRows.Count > 0)
                {
                    selectedRow = gridmaintwo.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && gridmaintwo.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (gridmaintwo.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            gridmaintwo.Rows[selectedRow + 1].Selected = true;
                            gridmaintwo.Rows[selectedRow].Selected = false;
                            gridmaintwo.CurrentCell = gridmaintwo.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        gridmaintwo.Rows[selectedRow - 1].Selected = true;
                        gridmaintwo.Rows[selectedRow].Selected = false;
                        gridmaintwo.CurrentCell = gridmaintwo.SelectedRows[0].Cells[0];
                    }
                }

                if (e.KeyValue == 13)
                {
                    if (gridmaintwo.SelectedRows.Count > 0 && gridmaintwo.Visible == true)
                    {
                        string ITEMNAME = "";
                        ITEMNAME = gridmaintwo.SelectedRows[0].Cells["itemname"].Value.ToString();
                        if (_DBTask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
                        {

                            txtfinishproduct.Text = _DBTask.znllString(gridmaintwo.SelectedRows[0].Cells["bcode"].Value);
                            txtbarcode.Tag = _DBTask.znllString(gridmaintwo.SelectedRows[0].Cells["itemid"].Value);
                            txtbarcode.Text = _DBTask.znllString(gridmaintwo.SelectedRows[0].Cells["itemname"].Value);
                            gridmaintwo.Visible = false;

                        }
                        else
                        {

                             txtfinishproduct.Tag  = _DBTask.znllString(gridmaintwo.SelectedRows[0].Cells["itemid"].Value);

                             txtfinishproduct.Text = _DBTask.znllString(gridmaintwo.SelectedRows[0].Cells["itemname"].Value);
                            txtbarcode.Text = _DBTask.znllString(gridmaintwo.SelectedRows[0].Cells["itemcode"].Value);

                            gridmaintwo.Visible = false;

                        }

                    }
                }
                if (e.KeyValue == 27)
                {
                    gridmaintwo.Visible = false;

                }

            }

            catch
            {
            }
        }

       
    }
}
 