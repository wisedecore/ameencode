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
    public partial class Frmstockadjustment : Form
    {
        public Frmstockadjustment()
        {
            InitializeComponent();
        }
        public double TottalAmount;
        ClsDepot _Depot = new ClsDepot();
        ClsInventory _Inventory = new ClsInventory();
        ClsBusinessIssue _Businessissue = new ClsBusinessIssue();
        ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        ClsIssueDetails _Issuedetails = new ClsIssueDetails();
        ClsReceiptDetails _ReceiptDetails = new ClsReceiptDetails();
        ClsInGrid _InGrid = new ClsInGrid();
        NextGFuntion _Nextg = new NextGFuntion();
        DBTask _Dbtask = new DBTask();

        public DataSet Ds2;
        public DataSet Ds;

        public bool Editmode=false;
        public int rowindex;
        public int columnindex;
        public static string Columnname;
        public static string ItemId;
        double NetTottal;
        double NetQty;
        double Qty;
        double Rate;
        int selectedRow;
        int Slno;
        public bool IsEnter;
        public string SelDepot="0";
        public static string Vtype;
        public string Heading;

        string tempitemcode;
        string tempBatch = "";
        double tempqty ;
        double temprate ;

        /*Settings*/

        public bool SDepot = false;
        public bool Sbatch = false;
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)//TxtProduct,Txtqty,TxtAmt,panel2/*
            {

                if (this.ActiveControl.Name != "Gridbatchlist")
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
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void Frmstockadjustment_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        public void FillCombo()
        {
            _Depot.FillCombo(ComDepot);
            ComDepot.SelectedIndex = 0;
           // ComType.SelectedIndex = 0;
        }
       
       
        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }
        public void DeleteFu()
        {
            if (Vtype == "Ireceipt")
            {
                _Dbtask.ExecuteNonQuery("delete from tblinventory where Vcode='" + txtvno.Tag + "' and Ireceipt !=0");
                _Dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where ReptCode='" + txtvno.Tag + "' and recpttype='"+Vtype+"'");
                _Dbtask.ExecuteNonQuery("delete from tblreceiptdetails where RecptCode='" + txtvno.Tag + "' and vtype='"+Vtype+"'");
            }
            else if (Vtype == "Sh")
            {

                _Dbtask.ExecuteNonQuery("delete from tblinventory where Vcode='" + txtvno.Tag + "' and sh!=0");
                _Dbtask.ExecuteNonQuery("delete from tblbusinessissue where IssueCode='" + txtvno.Tag + "' and issuetype='" + Vtype + "'");
                _Dbtask.ExecuteNonQuery("delete from tblissuedetails where IssueCode='" + txtvno.Tag + "' and vtype='"+Vtype+"'");
            }
            

        }



        private bool ValidationFu()
        {
            try
            {
                if (ComDepot.SelectedValue.ToString() == "")
                {
                    return false;
                }
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        private bool Main()
        {
            RowValidation();
            if (ValidationFu())
            {
                try
                {
                    if (Editmode == true)
                    {
                        DeleteFu();
                    }
                    NextgInitialize();
                    Insert();
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

      
        public void GetMenusettings()
        {
            string temp;
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=13");
            if (temp == "1")
            {
                SDepot = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=103");
            if (temp == "1")
            {
                Sbatch = true;
            }
        }
        public void SetGridColumn()
        {
            GetMenusettings();
            if (SDepot == false)
            {
                ComDepot.Visible = false;
                Lblstockarea.Visible = false;
            }
            if (Sbatch == false)
            {
                clnbatch.Visible = false;
            }
        }
        public void GetVno()
        {
            if (Vtype == "Ireceipt")
            {
                _TransactionReceipt.IdTransactionReceiptPurticular("Ireceipt");
                txtvno.Tag = Convert.ToString(_TransactionReceipt.RcptCodeLng);
                txtvno.Text = Convert.ToString(_TransactionReceipt.RcptCodeLng);
            }
            if (Vtype == "Sh")
            {
                _Businessissue.IdPurticular("Sh");
                txtvno.Tag = _Businessissue.IdPurticular("Sh");
                txtvno.Text = _Businessissue.IdPurticular("Sh");
            }
        }
        public void NextgInitialize()
        {
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        tempitemcode = gridmain.Rows[i].Cells["ClnItemName"].Tag.ToString();
                        tempqty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value.ToString());
                        temprate = Convert.ToDouble(gridmain.Rows[i].Cells["clnrate"].Value.ToString());
                        if (Sbatch == true)
                        {
                            tempBatch = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();
                        }
                        /*For Inventory */

                        _Inventory.DCodeStr = ComDepot.SelectedValue.ToString();
                        _Inventory.InvDateDt = dtdate.Value;
                        _Inventory.PcodeStr = tempitemcode;
                        _Inventory.Batchcode = tempBatch;
                        _Inventory.Vcode = txtvno.Tag.ToString();
                        if (Vtype == "Sh")
                        {
                            _Inventory.Sh = tempqty;
                            _Inventory.Ireceipt = 0;
                        }
                        else
                        {
                            _Inventory.Ireceipt = tempqty;

                            _Inventory.Sh = 0;
                        }

                        _Inventory.InsertInventory();



                        if (Vtype == "Ireceipt")
                        {
                            /*For Receipt Details*/
                            _ReceiptDetails.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                            _ReceiptDetails.SlNoLng = Convert.ToInt64(gridmain.Rows[i].Cells["Clnslno"].Value);
                            _ReceiptDetails.PCodeStr = ItemId;
                            _ReceiptDetails.UnitIdLng = 0;
                            _ReceiptDetails.MultiRateIdLng = 0;
                            _ReceiptDetails.QtyDb = tempqty;
                            _ReceiptDetails.RateDb = temprate;
                            _ReceiptDetails.NetAmtDb = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                            _ReceiptDetails.Vtype = Vtype;
                            _ReceiptDetails.InsertReceiptDetails();
                        }
                        else if (Vtype == "Sh")
                        {
                            _Issuedetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                            _Issuedetails.SlNoLng = Convert.ToInt64(gridmain.Rows[i].Cells["Clnslno"].Value);
                            _Issuedetails.PCodeStr = ItemId;
                            _Issuedetails.UnitIdLng = Convert.ToInt64(gridmain.Rows[i].Cells["Clnunit"].Value);
                            _Issuedetails.MultiRateIdLng = 0;
                            _Issuedetails.QtyDb = tempqty;
                            _Issuedetails.RateDb = temprate;
                            _Issuedetails.NetAmtDb = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                            _Issuedetails.Vtype = Vtype;
                            _Issuedetails.InsertIssueDetails();
                        }
                    }
                }
            }
          
            /*For Transaction Receipt */
            if (Vtype == "Ireceipt")
            {
                _TransactionReceipt.RcptCodeLng =Convert.ToInt64(txtvno.Tag);
                
                _TransactionReceipt.VNoStr = txtvno.Text;
                _TransactionReceipt.RCptTypeStr = Vtype;
                _TransactionReceipt.DcodeStr = ComDepot.SelectedValue.ToString();
                _TransactionReceipt.RcptDateDt = dtdate.Value;
                _TransactionReceipt.AMTDb =Convert.ToDouble(txttnetamount.Text);
               
                _TransactionReceipt.RemarkStr = TxtRemark.Text;
            }

            /*For Businessissue*/
            if (Vtype == "Sh")
            {
                _Businessissue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
               
                _Businessissue.VnoStr = txtvno.Text;
                _Businessissue.IssueTypeStr = Vtype;
                _Businessissue.DCode = ComDepot.SelectedValue.ToString();
                _Businessissue.IssueDateDt = dtdate.Value;
                _Businessissue.AMTDb = Convert.ToDouble(txttnetamount.Text);
                _Businessissue.RemarkStr = TxtRemark.Text;
            }
        
        }
        public void Insert()
        {
            if (Vtype == "Ireceipt")
            {
                _TransactionReceipt.InsertTransactionReceipt();
            }
            else if (Vtype == "Sh")
            {
                _Businessissue.InsertBusinessIssue();
            }
        }
        public void GetPrevious(long vno)
        {
            try
            {
                long PreIssuecode = vno;
                if (Vtype == "Ireceipt")
                {
                    Ds2 = _Dbtask.ExecuteQuery("select * from TblTransactionReceipt where ReptCode='" + PreIssuecode + "' and RecptType='" + Vtype + "' ");
                }
                else if (Vtype == "Sh")
                {
                    Ds2 = _Dbtask.ExecuteQuery("select * from tblbusinessissue where issuecode='" + PreIssuecode + "' and issuetype='" + Vtype + "' ");
                }
                if (Ds2.Tables[0].Rows.Count != 0)
                {
                    gridmain.Rows.Clear();
                    Editmode = true;

                    if (Ds2.Tables[0].Rows[0]["pvno"].ToString() != "")
                    {
                        txtvno.Text = Ds2.Tables[0].Rows[0]["pvno"].ToString() + Ds2.Tables[0].Rows[0]["vno"].ToString();
                    }
                    else
                    {
                        txtvno.Text = Ds2.Tables[0].Rows[0]["vno"].ToString();
                    }
                    txtvno.Tag = PreIssuecode.ToString();


                    if (Vtype == "Ireceipt")
                    {
                        dtdate.Value = Convert.ToDateTime(Ds2.Tables[0].Rows[0]["recptdate"]);
                    }
                    else if (Vtype == "Sh")
                    {
                        dtdate.Value = Convert.ToDateTime(Ds2.Tables[0].Rows[0]["Issuedate"]);
                    }
                    ComDepot.SelectedValue = Ds2.Tables[0].Rows[0]["Dcode"];
                    TxtRemark.Text = Ds2.Tables[0].Rows[0]["Remarks"].ToString();

                    if (Vtype == "Ireceipt")
                    {
                        Ds = _Dbtask.ExecuteQuery("select * from TblReceiptDetails where RecptCode='" + PreIssuecode + "'and vtype='" + Vtype + "' order by slno asc");
                    }
                    if (Vtype == "Sh")
                    {
                        Ds = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + PreIssuecode + "'and vtype='" + Vtype + "' order by slno asc");
                    }
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        gridmain.Rows.Add(1);

                        string tempSlno = Ds.Tables[0].Rows[i]["slno"].ToString();
                        string tempitemid = Ds.Tables[0].Rows[i]["pcode"].ToString();
                        double tempQty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());
                        // double tempfree = Convert.ToDouble(Ds.Tables[0].Rows[i]["freeqty"].ToString());
                        double temppRate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Rate"].ToString());
                        //double tempsrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["sRate"].ToString());
                        //double tempdiscrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["DiscRate"].ToString());
                        // double temptaxrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Taxrate"].ToString());
                        double tempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["NetAMT"].ToString());

                        if (Sbatch == true)
                        {
                            string tempbatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();
                            string tempbatchidTag = _Dbtask.ExecuteScalar("select bid from tblbatch where Bcode='" + tempbatchid + "'");
                            gridmain.Rows[i].Cells["clnbatch"].Value = tempbatchid;
                            gridmain.Rows[i].Cells["clnbatch"].Tag = tempbatchidTag;
                        }
                        //double tempsrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["srate"].ToString());
                        //double tempcrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["crate"].ToString());
                        //double tempmrp = Convert.ToDouble(Ds.Tables[0].Rows[i]["mrp"].ToString());

                        gridmain.Rows[i].Cells["clnslno1"].Value = i + 1;

                        gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                        gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);


                        gridmain.Rows[i].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpointStock(temppRate);
                        // gridmain.Rows[i].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpointStock(tempsrate);
                        //gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpointStock(temptaxrate);
                        rowindex = i;
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
        public void Clear()
        {
            lblheading.Text = Heading;
            GetVno();
            _Nextg.ClearControles(this);
            gridmain.Rows.Clear();

            FillCombo();
            ComDepot.Focus();
        }

        private void Frmstockadjustment_Load(object sender, EventArgs e)
        {
           // gridmain.Controls.Add(TxtProduct);
            Editmode = false;
            SetGridColumn();
            gridmain.Controls.Add(ComMultiRate);
            gridmain.Controls.Add(ComMultiUnit);
            Clear();
            CommonClass._Nextg.FormIcon(this);

        }

       


        private void TxtProduct_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtProduct_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (Columnname == "clnitemcode")
            {
                gridmain.Rows[rowindex].Cells["clnitemcode"].Value = (sender as TextBox).Text;
                _InGrid.PreviewKeyDownInGrid(e.KeyValue, uscGridshow2, uscGridshow2.GridProductShow, gridmain, IsEnter, (sender as TextBox).Text, Convert.ToInt64(ItemId), rowindex, columnindex, "Clnsrate", "srate",SelDepot);
                uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_InGrid.Stock);
                if (e.KeyValue == 13)
                {
                    ItemId = gridmain.Rows[rowindex].Cells["ClnItemName"].Tag.ToString();
                    IsEnter = false;
                    (sender as TextBox).Text = gridmain.Rows[rowindex].Cells["clnitemcode"].Value.ToString();
                    uscGridshow2.Visible = false;
                }
            }
       
        }
        

       
        public void ProductGridShow(string WhereCondition)
        {
            _InGrid.ProductGridShowFixed(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, ComDepot.SelectedValue.ToString());
            IsEnter = true;
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            _InGrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height + 27 * 2);

        }
        void txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gridmain.Rows[rowindex].Cells[columnindex].Value = (sender as TextBox).Text;
                string Temp = gridmain.Rows[rowindex].Cells[columnindex].Value.ToString();
                if (Columnname == "clnitemcode")
                {
                    ProductGridShow(Temp);
                    uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_InGrid.Stock);
                }
                CellEnterCalculationPart();
                TottalAmountCalculate();
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
                    if (gridmain.Rows[rowindex].Cells["clnitemname"].Tag == null)
                    {
                        gridmain.Rows[rowindex].Tag = -1;
                        // gridmain.Rows[rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        gridmain.Rows[rowindex].Tag = 1;
                        gridmain.Rows[rowindex].DefaultCellStyle.BackColor = default(Color);
                    }
                    if (Sbatch == false)
                    {
                        if (gridmain.Rows[i].Cells["clnitemname"].Tag == null || gridmain.Rows[i].Cells["clnqty"].Value == null || gridmain.Rows[i].Cells["clnrate"].Value == null || gridmain.Rows[i].Cells["clnnettamount"].Value == null)
                        {

                            gridmain.Rows[i].Tag = -1;
                            gridmain.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            gridmain.Rows[i].Tag = 1;
                            gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                        }
                    }
                }
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
                        NetTottal = Convert.ToDouble(NetTottal) + Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);

                        NetQty = NetQty + Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                    }
                }
                txttnetamount.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(NetTottal));
                txttqty.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(NetQty));
            }
            catch
            {
            }
        }
        public void CellEnterCalculationPart()
        {
            try
            {
                gridmain.Rows[rowindex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value));
               
                gridmain.Rows[rowindex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnrate"].Value));
               

                double Qty = Convert.ToDouble(Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value));
                double Rate = Convert.ToDouble(_Dbtask.SetintoDecimalpointStock(Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnrate"].Value)));
                Rate = Qty * Rate;

                gridmain.Rows[rowindex].Cells["clnnettamount"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Rate));
             
            }
            catch
            {
            }
        }

        private void Frmstockadjustment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void ComDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelDepot = ComDepot.SelectedValue.ToString();
        }
        public void Showstockadjustmentgroup()
        {
            Frmstockadjustmentgroup _Stgroup = new Frmstockadjustmentgroup();
            _Stgroup.ShowDialog();
        }
        private void cmdcreategroup_Click(object sender, EventArgs e)
        {
            Showstockadjustmentgroup();
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            long tempvno=Convert.ToInt64(txtvno.Text)-1;
            GetPrevious(tempvno);
        }

        private void CmdForward_Click(object sender, EventArgs e)
        {
            long tempvno = Convert.ToInt64(txtvno.Text) + 1;
            GetPrevious(tempvno);
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DeleteFu();
            Clear();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridmain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);

            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);
        }

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                columnindex = gridmain.SelectedCells[0].ColumnIndex;
                rowindex = gridmain.SelectedCells[0].RowIndex;
                Columnname = gridmain.Columns[columnindex].Name.ToString();
                if (gridmain.Rows[rowindex].Cells[columnindex].ReadOnly == true)
                {
                    SendKeys.Send("{Tab}");
                    // return true;
                }

                if (Columnname == "ClnMRate")
                {
                    _InGrid.ControleSettEnter(ComMultiRate, gridmain);
                    ComMultiRate.SelectedValue = gridmain.Rows[rowindex].Cells[columnindex].Tag;
                }
                if (Columnname == "ClnUnit")
                {
                    _InGrid.ControleSettEnter(ComMultiUnit, gridmain);
                    ComMultiUnit.SelectedValue = gridmain.Rows[rowindex].Cells[columnindex].Tag;
                }
                if (Columnname == "clnitemcode")
                {
                    IsEnter = true;
                }
                if (Columnname == "clnqty" || Columnname == "Clnrate")
                {
                    gridmain.BeginEdit(true);
                }
            }
            catch
            {
            }
        }

        private void gridmain_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                columnindex = gridmain.SelectedCells[0].ColumnIndex;
                rowindex = gridmain.SelectedCells[0].RowIndex;



                if (gridmain.Columns[columnindex].Name.ToString() == "clnitemcode")
                {
                    if (gridmain.Focused == false)
                    {
                        gridmain.Focus();

                    }
                }
                if (gridmain.Columns[columnindex].Name.ToString() == "clnitemname")
                {
                    if (gridmain.Focused == false)
                    {
                        gridmain.Focus();

                    }

                }

                IsEnter = false;

            }
            catch
            {
            }
        }   
    }
}
