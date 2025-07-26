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
    public partial class FrmStockTRansfer : Form
    {
        public FrmStockTRansfer()
        {
            InitializeComponent();
        }
        /*Settings*/
        public bool SBatch;

        public static string WGmitemcode = "";

        public static string WGmitemname = "";
        public static string WGmsrate = "";
        public static string WGmrack = "";
        public static string WGmmrp = "";
        public static string WGmbcode = "";
        public static string WGmprate = "";
        /*Unit*/
        public string SecUnit = "";
        public string FirUnit = "";
        public double Convrt = 0;
        public double Unitamount1 = 0;
        public double UnitAmount2 = 0;
        public string UnitCode = "";
        string Unitid;
        string UnitName;
        public string Pcode;
        public double Gross = 0;
        public int MunitId = 0;
        public bool Isinother;
        public long Temvno;

        ClsTransferDetails _TransferDetails = new ClsTransferDetails();
        ClsInternelTransfer _InternelTransfer = new ClsInternelTransfer();
        NextGFuntion _Nextg = new NextGFuntion();
        ClsInventory _Inventory = new ClsInventory();
        ClsItemMaster _ItemMaster = new ClsItemMaster();
        ClsDepot _Depot = new ClsDepot();
        ClsMultiUnits _MultiUnit = new ClsMultiUnits();
        ClsMultiRates _MultiRates = new ClsMultiRates();
        ClsInGrid _InGrid = new ClsInGrid();
        DBTask _Dbtask = new DBTask();
        DataSet DS3 = new DataSet();
        ClsInGrid _Ingrid = new ClsInGrid();
        public bool EditMode = false;
        bool IsEnter;
        public int rowindex;
        public int columnindex;
        double NetTottal;
        double NetQty;
        int selectedRow;
        public bool SUnit = false;
        string ColumnName;
        public DataSet Ds;
        public DataSet Ds2;
        string Itemid;
        string Bcode;

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)//TxtProduct,Txtqty,TxtAmt,panel2/*
            {


                if (this.ActiveControl.Name != "Gridbatchlist" || this.ActiveControl.Name != "pnlbill")
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
                            // SendKeys.Send("{Tab}");
                            return true;
                        }
                        if (msg.WParam.ToInt32() == (int)Keys.Up)
                        {
                            //SendKeys.Send("{Tab}");
                            return true;

                        }
                    }
                    if (Gridbatchlist.Visible == true)
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
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        public void LeaveBatch()
        {
            if (SBatch == true)
            {
                Bcode = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                Itemid = _Dbtask.ExecuteScalar("select distinct itemid from tblbatch where bcode='" + Bcode + "'");
                gridmain.Rows[rowindex].Cells["clnitemcode"].Value = CommonClass._Itemmaster.SpecificField(Itemid, "itemcode");
                gridmain.Rows[rowindex].Cells["clnitemname"].Value = CommonClass._Itemmaster.SpecificField(Itemid, "itemname");
                gridmain.Rows[rowindex].Cells["clnitemname"].Tag = Itemid;
                gridmain.Rows[rowindex].Cells["clnrate"].Value =_Dbtask.znullDouble(CommonClass._Batch.GetSpecificFieldofBatch(Bcode, "prate"));

                CellEnterCalculationPart();
                gridmain.NotifyCurrentCellDirty(false);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void FrmStockTRansfer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                _Nextg.CloseGriddetail(gridmain, this);
            }
        }
        public void setval()
        {
            ClsInGrid.WGmitemcode = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemcode"));

            ClsInGrid.WGmitemname = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemname"));
            ClsInGrid.WGmsrate = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmsrate"));
            ClsInGrid.WGmmrp = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmmrp"));
            ClsInGrid.WGmrack = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmrack"));
            ClsInGrid.WGmprate = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmprate"));
            ClsInGrid.WGmbcode = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmbcode"));

        }

        public void Clear()
        {
            EditMode = false;
          
            _Nextg.ClearControles(this);
            _Nextg.SetControlesBehave(this);
            gridmain.Rows.Clear();
            FillCombo();
            SetGridColumn();
            GetVno();
            TxtVno.Focus();
            setval();
            ComFromDepot.Select();
        }
        public void FillCombo()
        {
            _Depot.FillCombo(ComFromDepot);
            _Depot.FillCombo(ComToDepot);
            _MultiUnit.FillCombo(ComMultiUnit);
            _MultiRates.FillCombo(ComMultiRate);
        }
        public void GetVno()
        {
            _TransferDetails.IdStockTransfer();
            TxtVno.Text =Convert.ToString(_TransferDetails.TCode);
        }
        public void DeleteVoucher()
        {
            _Dbtask.ExecuteNonQuery("delete from tblinterneltransfer where tcode='"+TxtVno.Text+"'");
            _Dbtask.ExecuteNonQuery("delete from tbltransferdetails where tcode='"+TxtVno.Text+"'");
            _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='"+TxtVno.Text+"' and ireceipt !=0 or iissue !=0" );
        }
        private bool Main()
                        {
            RowValidation();
            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteVoucher();
                    }
                    NextgInitialize();
                    Insert();
                    //MessageBox.Show("Save Successfully");
                    Clear();
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
        public bool ValidationFu()
        {

            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag.ToString() == "1")
                {
                    return true;
                }
            }
            return false;
        }

        void gridmain_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            throw new NotImplementedException();
        }
        public void NextgInitialize()
        {
            _InternelTransfer.TCode =Convert.ToInt64(TxtVno.Text);
            _InternelTransfer.DCodeFrom =Convert.ToInt32(ComFromDepot.SelectedValue);

            _InternelTransfer.DCodeTo =Convert.ToInt32(ComToDepot.SelectedValue);
            _InternelTransfer.TDate = dtdate.Value;
            _InternelTransfer.Remarks = TxtRemark.Text;

            for (int i = 0; i < gridmain.Rows.Count; i++)
            {

                if (gridmain.Rows[i].Tag.ToString() == "1")
                {
                    if (SUnit == true)
                    {
                        MunitId = Convert.ToInt32(_Dbtask.gridnul(gridmain.Rows[i].Cells["Clnunit"].Tag));

                        
                    }
                    if (SBatch == true)
                    {
                        Bcode = _Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value);
                    }

                    _TransferDetails.TCode = Convert.ToInt64(TxtVno.Text);
                    _TransferDetails.Slno = Convert.ToInt32(gridmain.Rows[i].Cells["ClnSlno"].Value);
                    _TransferDetails.Pcode = Convert.ToString(gridmain.Rows[i].Cells["Clnitemname"].Tag);
                    _TransferDetails.Unitid = Convert.ToInt32(gridmain.Rows[i].Cells["ClnUnit"].Tag);
                    //_TransferDetails.Unitid = MunitId;
                    _TransferDetails.Batchid = Bcode;
                    _TransferDetails.MultiRateid = 0;
                    _TransferDetails.MultiRateid = 0;
                    _TransferDetails.CF = 0;
                    _TransferDetails.Qty = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnQty"].Value);
                    _TransferDetails.Rate = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnRate"].Value);
                    _TransferDetails.Comment = "";
                    _TransferDetails.ShelfCode = 0;
                    _TransferDetails.Dcode = Convert.ToInt32(ComToDepot.SelectedValue);
                    _TransferDetails.SupCode = "";
                    _TransferDetails.InsertTransferDetails();

                   
                    _Inventory.Vcode = TxtVno.Text;
                    _Inventory.DCodeStr = Convert.ToString(ComFromDepot.SelectedValue);
                    _Inventory.InvDateDt = dtdate.Value;
                    _Inventory.PcodeStr = gridmain.Rows[i].Cells["Clnitemname"].Tag.ToString();
                    _Inventory.Iissue = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["Clnqty"].Value.ToString());
                    _Inventory.Batchcode = Bcode;
                    _Inventory.InsertInventory();
                    _Inventory.Iissue = 0;
                    _Inventory.UC = _Dbtask.znlldoubletoobject(CommonClass._Unitcreation.Getspesificfield("ucount",_Dbtask.znllString( MunitId)));

                    _Inventory.DCodeStr = Convert.ToString(ComToDepot.SelectedValue);
                    _Inventory.InvDateDt = dtdate.Value;
                    _Inventory.PcodeStr = gridmain.Rows[i].Cells["Clnitemname"].Tag.ToString();
                    _Inventory.Ireceipt = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["Clnqty"].Value.ToString());
                    
                    _Inventory.InsertInventory();
                    _Inventory.Ireceipt = 0;

                    _Inventory.UC = _Dbtask.znlldoubletoobject(CommonClass._Unitcreation.Getspesificfield("ucount", _Dbtask.znllString(MunitId)));
                }
            }

        }
        public void Insert()
        {
            _InternelTransfer.InsertInternelTransfer();
        }

       
        private void FrmStockTRansfer_Load(object sender, EventArgs e)
                {
            if (Isinother == false)
            {
                Clear();
            }
            else
            {
                GetPrevious(Temvno); 
            }

            CommonClass._Nextg.FormIcon(this);
        }

        public void UnitAmountCalc()
        {
            DS3 = _Dbtask.ExecuteQuery("select * from tblItemmaster where ItemId='" + Itemid + "'");
            //for (int i = 0; i < Ds2.Tables[0].Rows.Count; i++)
            //{
            if (DS3.Tables[0].Rows.Count > 0)
            {
                SecUnit = DS3.Tables[0].Rows[0]["Unit2"].ToString();
                FirUnit = DS3.Tables[0].Rows[0]["Unit"].ToString();
                Unitamount1 = _Dbtask.znullDouble(DS3.Tables[0].Rows[0]["UnitAmount1"].ToString());
                UnitAmount2 = _Dbtask.znullDouble(DS3.Tables[0].Rows[0]["UnitAmount2"].ToString());
                if (UnitName == SecUnit)
                {
                    Convrt = Unitamount1;
                }
                if (UnitName == FirUnit)
                {
                    Convrt = Unitamount1 * UnitAmount2;
                }

            }
            // }
        }

        public void GetMenusettings()
        {
            string temp;
            
            /*Unit*/
            if (CommonClass._settings.ReturnStatus("12") == "1")
            {
                SUnit = true;
            }

            if (CommonClass._settings.ReturnStatus("103") == "1")
            {
                SBatch = true;
            }
        }


        public void SetGridColumn()
        {
            GetMenusettings();
           
            if (SUnit == false)/*For Unit*/
            {
                ClnUnit.Visible = false;
            }
            if (SBatch == true)
            {
                clnbatch.Visible = true;
                clnitemcode.ReadOnly = false;
                clnitemname.ReadOnly = true;
            }
        }

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                columnindex = gridmain.CurrentCell.ColumnIndex;
                rowindex = gridmain.CurrentCell.RowIndex;
                ColumnName = gridmain.Columns[columnindex].Name.ToString();
                if (gridmain.Rows[rowindex].Cells[columnindex].ReadOnly == true)
                {
                    SendKeys.Send("{Tab}");
                    // return true;
                }
                if (ColumnName== "ClnMRate")
                {
                    ControleSettEnter(ComMultiRate);
                    ComMultiRate.SelectedValue = gridmain.Rows[rowindex].Cells[columnindex].Tag;
                }
                if (gridmain.Columns[columnindex].Name.ToString() == "ClnUnit")
                {
                    //ControleSettEnter(ComMultiUnit);
                    //ComMultiUnit.SelectedValue = gridmain.Rows[rowindex].Cells[columnindex].Tag;
                }
                //if (ColumnName == "clnitemcode")
                //{
                //    ControleSettEnter(TxtProduct);
                //    TxtProduct.Text = gridmain.Rows[rowindex].Cells[columnindex].Value.ToString();
                //}
                if (ColumnName == "clnqty" || ColumnName == "clnrate")
                {
                    gridmain.Rows[rowindex].Cells["clnitemcode"].Value=_Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='"+Itemid+"'");
                    gridmain.BeginEdit(true);
                    //gridmain.Columns[columnindex].be
                }
            }
            catch
            {
            }
        }

        public void ControleSettEnter(Control Cnt)
        {
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);

            Cnt.Height = tempRect.Height;
            Cnt.Width = tempRect.Width;
            Cnt.Location = tempRect.Location;
            Cnt.Visible = true;
            Cnt.Focus();
        }
        private void gridmain_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                columnindex = gridmain.CurrentCell.ColumnIndex;
                rowindex = gridmain.CurrentCell.RowIndex;
                //if (gridmain.Columns[columnindex].Name.ToString() == "ClnMRate")
                //{
                //    if (gridmain.Focused == false)
                //    {
                //        gridmain.Focus();
                //    }
                //    CellLeave(ComMultiRate);
                //}
                //if (gridmain.Columns[columnindex].Name.ToString() == "ClnUnit")
                //{
                //    if (gridmain.Focused == false)
                //    {
                //        gridmain.Focus();

                //    }
                //    CellLeave(ComMultiUnit);
                //}

                if (gridmain.Columns[columnindex].Name.ToString().ToLower() == "clnunit")
                {
                    if (SUnit == true)
                    {
                        if (UnitName == FirUnit)
                        {
                            gridmain.Rows[rowindex].Cells["clnunit"].Value = UnitName + " " + "(" + Unitamount1 + FirUnit + "=" + UnitAmount2 + SecUnit + ")";
                        }
                        else
                        {
                            gridmain.Rows[rowindex].Cells["clnunit"].Value = UnitName;
                        }
                        gridmain.Rows[rowindex].Cells["clnunit"].Tag = Unitid;
                        gridmain.NotifyCurrentCellDirty(false);

                    }
                }


                if (gridmain.Columns[columnindex].Name.ToString() == "clnitemcode")
                {
                    if (gridmain.Focused == false)
                    {
                        gridmain.Focus();
                    }
                    // CellLeave(TxtProduct);
                }
                if (gridmain.Columns[columnindex].Name.ToString() == "clnitemname")
                {
                    if (gridmain.Focused == false)
                    {
                        gridmain.Focus();

                    }
                    // CellLeave(TxtProduct);
                }

                if (gridmain.Columns[columnindex].Name.ToString() == "clnbatch")
                {
                    LeaveBatch();
                }

                CellEnterCalculationPart();
                TottalAmountCalculate();
                RowValidation();
            }
            catch
            {
            }
        }

        public void CellEnterCalculationPart()
        {
            try
            {
                double Qty = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                double Rate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnrate"].Value);
                gridmain.Rows[rowindex].Cells["clnnettamount"].Value = Qty * Rate; /* For Cell Net Amount*/
                double NetAmunt = _Dbtask.znullDouble(gridmain.Rows[rowindex].Cells["clnnettamount"].Value.ToString());
                Gross = NetAmunt;
                if (SUnit == true)
                {
                    string BCODE="";
                    BCODE =  _Dbtask.znllString( gridmain.Rows[rowindex].Cells["clnbatch"].Value );
                    Convrt = _Dbtask.znlldoubletoobject(CommonClass._Batch.GetSpecificFieldByBarcode("unconv", BCODE));
                    double UnitAmt = Gross * Convrt;
                    Gross = UnitAmt;
                }
                gridmain.Rows[rowindex].Cells["clnnettamount"].Value = Gross;
            }
            catch
            {
            }
        }
        public void TottalAmountCalculate()
        {
            try
            {
                gridmain.Rows[rowindex].Cells["ClnSlno"].Value = rowindex + 1; /* For SlNo*/
                NetTottal = 0;
                NetQty = 0;
                for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
                {
                    if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
                    {
                        NetTottal = NetTottal + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        NetQty = NetQty + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                    }
                }
                txtbillamount.Text = Convert.ToString(NetTottal);
                txttqty.Text = Convert.ToString(NetQty);
            }
            catch
            {
            }

        }
        public void RowValidation()
        {
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {

                    if (gridmain.Rows[i].Cells["clnitemname"].Tag == null || Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value) == Convert.ToDouble(0))
                    {
                        gridmain.Rows[i].Tag = -1;
                        // gridmain.Rows[rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        gridmain.Rows[i].Tag = 1;
                        gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }
            }
            catch
            {
            }
        }

        public void GetPrevious(long Temvno)
        {
            try
            {
                long PreIssuecode = Temvno;
                Ds2 = _Dbtask.ExecuteQuery("select * from tblinterneltransfer where tcode='" + PreIssuecode + "'");
                if (Ds2.Tables[0].Rows.Count != 0)
                {
                    gridmain.Rows.Clear();
                    EditMode = true;

                    if (Ds2.Tables[0].Rows[0]["tcode"].ToString() != "")
                    {
                        TxtVno.Text = Ds2.Tables[0].Rows[0]["tcode"].ToString();
                    }



                    _InternelTransfer.TCode = PreIssuecode;
                    _TransferDetails.TCode = PreIssuecode;
                    _Inventory.Vcode = PreIssuecode.ToString();

                    dtdate.Value = Convert.ToDateTime(Ds2.Tables[0].Rows[0]["tdate"]);
                    ComFromDepot.SelectedValue = Ds2.Tables[0].Rows[0]["dcodefrom"];
                    ComToDepot.SelectedValue = Ds2.Tables[0].Rows[0]["dcodeto"];

                    TxtRemark.Text = Ds2.Tables[0].Rows[0]["remarks"].ToString();
                    Ds = _Dbtask.ExecuteQuery("select * from tbltransferdetails where tcode='" + PreIssuecode + "' order by slno asc");
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        gridmain.Rows.Add(1);

                        string tempSlno = Ds.Tables[0].Rows[i]["slno"].ToString();
                        string tempitemid = Ds.Tables[0].Rows[i]["pcode"].ToString();
                        double tempQty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());

                        double temppRate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Rate"].ToString());
                        Pcode = Ds.Tables[0].Rows[i]["Pcode"].ToString();
                        Bcode = Ds.Tables[0].Rows[i]["batchid"].ToString();

                        long tempunitid = 0;
                        long tempmrateid = 0;

                        gridmain.Rows[i].Cells["clnslno"].Value = tempSlno;

                        gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                        gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);

                        gridmain.Rows[i].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpointStock(temppRate);
                        gridmain.Rows[i].Cells["clnbatch"].Value = Bcode;

                        //gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpointStock(temptaxrate);
                        rowindex = i;

                        if (SUnit == true)
                        {
                            Unitid = _Dbtask.ExecuteScalar("select UnitId from TblTransferDetails where Tcode='" + TxtVno.Text + "' and pcode='" + Pcode + "'");
                            string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                            gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                            gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                            Itemid = tempitemid;
                            UnitName = Unit;
                            UnitAmountCalc();
                        }
                        CellEnterCalculationPart();
                    }
                    TottalAmountCalculate();
                }
                else
                {
                    GetPrevious(Convert.ToInt64(PreIssuecode) - 1);
                }
            }
            catch
            {
                Clear();
            }
        }

        public void ProductGridShow(string WhereCondition)
        {
            _Ingrid.ProductGridShowFixed(uscGridshow2,WhereCondition, uscGridshow2.GridProductShow,ComFromDepot.SelectedValue.ToString());
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height + 19 * 3);

           // GridProductShow.Visible = true;
            IsEnter = true;
        }

        public void ProductGridShowLocationSett()
        {
           // _InGrid.ProductGridShowLocationSett(GridProductShow, TxtProduct,64);
        }
       
        public void ProductIntoMainGrid()
                {

                selectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
            _InGrid.ProductIntoMainGrid(gridmain, uscGridshow2.GridProductShow, selectedRow, rowindex, "Clnrate", "prate");
            Itemid = gridmain.Rows[rowindex].Cells["ClnItemName"].Tag.ToString();

            Bcode =_Dbtask.znllString( gridmain.Rows[rowindex].Cells["clnbatch"].Value);
            uscGridshow2.Visible = false;
        }
       

        private void gridmain_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                string ColumnName = gridmain.Columns[columnindex].Name;
                if ( ColumnName == "clnsrate" || ColumnName == "clnfree" || ColumnName == "clndiscount" || ColumnName == "clnTax")
                {
                    Generalfunction.allowNumeric(sender, e,false);
                }
                if (ColumnName == "clnqty")
                {
                    Generalfunction.allowNumeric(sender, e, true);
                }
            }
            catch
            {
            }
        }

        private void TxtProduct_TextChanged(object sender, EventArgs e)
        {
            if (gridmain.Columns[columnindex].Name == "clnitemcode")
            {
                ProductGridShow(" where itemCode Like '%" + TxtProduct.Text + "%' or itemName Like '%" + TxtProduct.Text + "%'");
            }
        }

        private void TxtProduct_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                if (TxtProduct.Text == "")
                {
                    this.Close();
                }
                else
                {
                    TxtProduct.Text = "";
                }
            }

            try
            {
             //   selectedRow = GridProductShow.SelectedRows[0].Index;
                //if (e.KeyValue == 40 && GridProductShow.Rows[selectedRow].Cells[0].Value != null)
                //{

                //    //if (GridProductShow.Rows[selectedRow + 1].Cells[0].Value != null)
                //    //{
                //    //    GridProductShow.Rows[selectedRow + 1].Selected = true;
                //    //    GridProductShow.Rows[selectedRow].Selected = false;
                //    //}
                //}

                if (e.KeyValue == 38 && selectedRow != 0)
                {


                   // GridProductShow.Rows[selectedRow - 1].Selected = true;
                    //GridProductShow.Rows[selectedRow].Selected = false;
                }

                if (e.KeyValue == 13)
                {
                    ProductIntoMainGrid();
                }
            }
            catch
            {
            }
        
        }

        private void ComMultiUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ComMultiRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ComMultiUnit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                gridmain.Rows[rowindex].Cells["clnunit"].Tag = ComMultiUnit.SelectedValue;
                gridmain.Rows[rowindex].Cells["clnunit"].Value = ComMultiUnit.SelectedText;

            }
        }

        private void ComMultiRate_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                gridmain.Rows[rowindex].Cells["ClnMRate"].Tag = ComMultiRate.SelectedValue;
                gridmain.Rows[rowindex].Cells["ClnMRate"].Value = ComMultiRate.SelectedText;

            }
        }

        private void ComFromDepot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComToDepot.Focus();
            }
        }

        private void TxtRemark_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                GridSelect();
            }
        }
        public void GridSelect()
        {
            gridmain.Focus();
            gridmain.Rows[0].Cells[1].Selected = true;
            gridmain.CurrentCell = gridmain.Rows[0].Cells[1];
        }

        private void ComToDepot_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                dtdate.Focus();
            }
        }

        private void dtdate_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtRemark.Focus();
            }
        }

        private void gridmain_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (gridmain.Columns[columnindex].Name == "clnrate")
            {
                string TempString = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnrate"].Value));
                gridmain.Rows[rowindex].Cells["clnrate"].Value = TempString;

                CellEnterCalculationPart();
                TottalAmountCalculate();
                RowValidation();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtVno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComFromDepot.Focus();
            }
        }

        private void dtdate_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                gridmain.Focus();
            }
        }

        private void TxtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gridmain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
        }

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                if (TxtProduct.Text == "")
                {
                    this.Close();
                }
                else
                {
                    TxtProduct.Text = "";
                }
            }

            try
            {
                if(ColumnName=="clnitemcode")
                {
                    //if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                    //{
                    //    selectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                    //    if (e.KeyValue == 40 && uscGridshow2.GridProductShow.Rows[selectedRow].Cells[0].Value != null)
                    //    {

                    //        if (uscGridshow2.GridProductShow.Rows[selectedRow + 1].Cells[0].Value != null)
                    //        {
                    //            uscGridshow2.GridProductShow.Rows[selectedRow + 1].Selected = true;
                    //            uscGridshow2.GridProductShow.Rows[selectedRow].Selected = false;
                    //        }
                    //    }

                    //    if (e.KeyValue == 38 && selectedRow != 0)
                    //    {


                    //        uscGridshow2.GridProductShow.Rows[selectedRow - 1].Selected = true;
                    //        uscGridshow2.GridProductShow.Rows[selectedRow].Selected = false;
                    //    }
                    //}
                    
                     if (SUnit == true)
                    {

                        Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where ItemId='" + Itemid + "'");

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            SecUnit = Ds.Tables[0].Rows[0]["Unit2"].ToString();
                            Unitamount1 = _Dbtask.znullDouble(Ds.Tables[0].Rows[0]["UnitAmount1"].ToString());
                            gridmain.Rows[rowindex].Cells["ClnUnit"].Value = SecUnit;
                            Convrt = Unitamount1;
                        }

                    }


                        if (e.KeyValue == 13)
                        {
                            ProductIntoMainGrid();
                        }


                        if (e.KeyValue != 13)
                        {
                            _Ingrid.RowUpDownSelect(e.KeyValue, uscGridshow2.GridProductShow, selectedRow, uscGridshow2, gridmain);
                            //  _Ingrid.RowUpDownSelect(e.KeyValue, uscGridshow2.GridProductShow, selectedRow, uscGridshow2, gridmain);
                            //uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);
                            //uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);

                        }

                    }
                if (ColumnName == "ClnUnit")
                {
                    Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where ItemId='" + Itemid + "'");
                    CommonClass._commenevent.UpDowninGridList(Gridbatchlist, e.KeyValue, gridmain);
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {

                        if (e.KeyValue == 13 && Gridbatchlist.SelectedRows.Count > 0)
                        {

                            int select = Gridbatchlist.SelectedRows[0].Index;
                            UnitName = Gridbatchlist.Rows[select].Cells[0].Value.ToString();
                            Unitid = Gridbatchlist.Rows[select].Cells[0].Tag.ToString();
                            // gridmain.Rows[i].Cells["ClnUnit"].Value = UnitName;
                            // gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                            if (Ds.Tables[0].Rows.Count > 0)
                            {
                                SecUnit = Ds.Tables[0].Rows[i]["Unit2"].ToString();
                                FirUnit = Ds.Tables[0].Rows[i]["Unit"].ToString();
                                Unitamount1 = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["UnitAmount1"].ToString());
                                UnitAmount2 = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["UnitAmount2"].ToString());
                                if (UnitName == SecUnit)
                                {
                                    Convrt = Unitamount1;
                                }
                                if (UnitName == FirUnit)
                                {
                                    Convrt = Unitamount1 * UnitAmount2;
                                }

                            }
                            Gridbatchlist.Visible = false;
                        }
                        //CellEnterCalculationPart();

                    }
                    // TottalAmountCalculate();

                }
                
            }
            catch
            {
            }
        }

        void txt_TextChanged(object sender, EventArgs e)
                {
            gridmain.Rows[rowindex].Cells[columnindex].Value = (sender as TextBox).Text;
            string temp = gridmain.Rows[rowindex].Cells[columnindex].Value.ToString();
            if (ColumnName == "clnitemcode")
            {
                temp = "where TblItemMaster.itemCode Like N'%" + temp + "%' OR  TblItemMaster.ItemName Like N'%" + temp + "%'  or  TblItemMaster.llang Like N'%" + temp + "%'  or Tblbatch.Bcode like N'%" + temp + "%' ";
                    ProductGridShow(temp);
            }
            if (ColumnName == "clnitemname")
            {
                ProductGridShow(temp);
            }
            if (ColumnName == "ClnUnit")
            {
                //LoadUnits((sender as TextBox).Text);
                Gridbatchlist.Visible = true;
                LoadUnits();
            }
            CellEnterCalculationPart();
            TottalAmountCalculate();
            //RowValidation();  
        }

        public void LoadUnits()
        {
            Gridbatchlist.Location = new System.Drawing.Point(599, 155);
            Gridbatchlist.CellBorderStyle = DataGridViewCellBorderStyle.None;
            // CommonClass._Itemmaster.BatchlistshowBaseonItem(ItemId, Gridbatchlist, Search);
            Ds2 = _Dbtask.ExecuteQuery("select * from tblUnitcreation");
            for (int i = 0; i < Ds2.Tables[0].Rows.Count; i++)
            {
                Gridbatchlist.Rows.Add(1);

                Gridbatchlist.Rows[i].Cells[0].Value = Ds2.Tables[0].Rows[i]["Name"].ToString();
                Gridbatchlist.Rows[i].Cells[0].Tag = Ds2.Tables[0].Rows[i]["Id"].ToString();
            }
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            _Ingrid.ProductGridShowLocationSettGrid(Gridbatchlist, tempRect.Left, tempRect.Top + tempRect.Height + 32 * 2 - 6);
            Gridbatchlist.Columns[0].Width = Gridbatchlist.Width - 10;
        }

        private void cmdsave_Click(object sender, EventArgs e)
            {
            Main();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStockTRansfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
             Temvno = Convert.ToInt64(TxtVno.Text) - 1;
            GetPrevious(Temvno); 
        }

        private void Cmdforward_Click(object sender, EventArgs e)
        {
            long Temvno = Convert.ToInt64(TxtVno.Text) - 1;
            GetPrevious(Temvno); 
        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            DeleteVoucher();
            Clear();
        }    

    }
}
