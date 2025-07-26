using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Frmissuetable : Form
    {
        public Frmissuetable()
        {
            InitializeComponent();
        }

        string TempBathcode;
        /*For Settings*/
        bool Sbatch;
        /*****************************/

        public bool Editmode;
        Clsissueproduct _Issueproduct = new Clsissueproduct();
        Clsissueproductdetail _Issueproductdetail = new Clsissueproductdetail();
        ClsEmployeeMaster _EmployeeMaster = new ClsEmployeeMaster();
        ClsBusinessIssue _Businessissue = new ClsBusinessIssue();
        ClsIssueDetails _Issuedetails = new ClsIssueDetails();
        NextGFuntion _Nextg = new NextGFuntion();
        ClsInventory _Inventory = new ClsInventory();
        ClsInGrid _Ingrid = new ClsInGrid();

        DBTask _Dbtask = new DBTask();
        DataSet Ds;
        DataSet Ds1;
        public bool Isenter;
        public int selectedRow;
        public string Barcode;
        public long ItemId;
        public int columnindex;
        public int rowindex;
        public string ColumnName;
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
                    if (uscGridshow2.GridProductShow.Visible == true)
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
        private bool ValidationFu()
        {
            Ds1 = _Dbtask.ExecuteQuery("select * from tblreceivedproduct where issueid='" + txtvno.Text + "'");
            if (Ds1.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Already Used", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (comemployee.SelectedValue == null)
            {
                MessageBox.Show("Please Select Employee", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comemployee.Focus();
                return false;
            }
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                double tempQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);

                if (Sbatch == true)
                {
                    if (gridmain.Rows[i].Cells["clnitem"].Tag != null && tempQty > 0 && gridmain.Rows[i].Cells["clnbatch"].Tag != null)
                    {
                        return true;
                    }
                }
                else
                {
                    if (gridmain.Rows[i].Cells["clnitem"].Tag != null && tempQty > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Rowvalidation()
        {
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Cells["clnqty"].Value != null)
                {
                    double tempQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                    if (Sbatch == true)
                    {
                        if (gridmain.Rows[i].Cells["clnitem"].Tag != null && tempQty > 0 && gridmain.Rows[i].Cells["clnbatch"].Tag != null)
                        {
                            gridmain.Rows[i].Tag = "1";
                        }
                        else
                        {
                            gridmain.Rows[i].Tag = "-1";
                        }
                    }
                    else
                    {
                        if (gridmain.Rows[i].Cells["clnitem"].Tag != null && tempQty > 0)
                        {
                            gridmain.Rows[i].Tag = "1";
                        }
                        else
                        {
                            gridmain.Rows[i].Tag = "-1";
                        }
                    }
                }
            }

        }

        public void NextgInitialize()
        {
            try
            {
                long Vno = Convert.ToInt64(txtvno.Text);
                long Employee = Convert.ToInt64(comemployee.SelectedValue);
                DateTime Issuedate = dtissuedate.Value;
                string Remarks = txtremarks.Text;
                int Istatus = -1;
                double Mrate = 0;

                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString().ToString() != "-1")
                        {
                            long Slno = Convert.ToInt64(gridmain.Rows[i].Cells["clnslno"].Value);
                            long Itemid = Convert.ToInt64(gridmain.Rows[i].Cells["clnitem"].Tag);
                            double Qty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                            double Rate = Convert.ToDouble(gridmain.Rows[i].Cells["clnrate"].Value);
                            
                            double temprate = Qty * Rate;
                            Mrate = Mrate + temprate;
                            /*For Inventory Insert(Issue)*/
                            _Inventory.DCodeStr = "0";
                            _Inventory.InvDateDt = Issuedate;
                            _Inventory.PcodeStr = Itemid.ToString();
                            _Inventory.Vcode = Convert.ToString(txttvno.Text);
                            _Inventory.Iissue = Qty;

                            if (Sbatch == true)
                            {
                                Barcode=gridmain.Rows[i].Cells["clnbatch"].Value.ToString();

                                _Inventory.Batchcode = Barcode;
                                _Issuedetails.BatchIdStr = Barcode;
                                _Issueproductdetail.Bcode = Barcode;
                            }
                            _Inventory.InsertInventory();
                            /*********************************************/

                            /*Receipt Details (Issue)*/
                            _Issuedetails.IssueCodeLng = Convert.ToInt64(txttvno.Text);
                            _Issuedetails.SlNoLng = Slno;
                            _Issuedetails.PCodeStr = Itemid.ToString();
                            _Issuedetails.UnitIdLng = 0;
                            _Issuedetails.MultiRateIdLng = 0;
                            _Issuedetails.QtyDb = Qty;
                            _Issuedetails.RateDb = Rate;
                            _Issuedetails.NetAmtDb = Qty * Rate;
                            _Issuedetails.Vtype = "IIsues";
                            _Issuedetails.InsertIssueDetails();

                            /************************************************/
                            //_Issueproduct.Tvno = Convert.ToInt64(txttvno.Text);
                            _Issueproductdetail.Issueid = Vno;
                            _Issueproductdetail.Slno = Slno;
                            _Issueproductdetail.Itemid = Itemid;
                            _Issueproductdetail.Qty = Qty;
                            _Issueproductdetail.Rate = Rate;
                            _Issueproductdetail.Insertissueproductdetail();
                        }
                    }
                }
                _Issueproduct.Vno = Vno;
                _Issueproduct.Employeeid = Employee;
                _Issueproduct.Issuedate = Issuedate;
                _Issueproduct.Remarks = Remarks;
                _Issueproduct.IStatus = Istatus;
                _Issueproduct.Tvno = Convert.ToInt64(txttvno.Text);
                _Issueproduct.Insertissueproduct();

                /*BusinessIssue (IIsue)*/

                _Businessissue.IssueCodeLng = Convert.ToInt64(txttvno.Text);

                _Businessissue.VnoStr = txttvno.Text;
                _Businessissue.IssueTypeStr = "IIssue";
                _Businessissue.DCode = "0";
                _Businessissue.IssueDateDt = dtissuedate.Value;
                _Businessissue.AMTDb = Mrate;
                _Businessissue.RemarkStr = Remarks;
                _Businessissue.InsertBusinessIssue();
            }
            catch
            {
            }
        }

        public void Menusettings()
        {
            if (CommonClass._Menusettings.GetMnustatus("103") == "1")
            {
                Sbatch = true;
                clnbatch.Visible = true;
            }
        }

        public void Clear()
        {
            try
            {
                Menusettings();
                Editmode = false;
                gridmain.Rows.Clear();
                txtvno.Text = _Issueproduct.VnoIssueproduct().ToString();/*For Vno of Issue Product*/

                txttvno.Tag = _Businessissue.IdPurticular("IIssue");
                txttvno.Text = _Businessissue.IdPurticular("IIssue");
                txtremarks.Text = "";
                Fiilcombo();
                comemployee.Focus();

                CommonClass._Nextg.FormIcon(this);
            }
            catch
            {
            }
        }
        
        public void Fiilcombo()
        {
            _EmployeeMaster.FillCombo(comemployee);
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
        public void Delete()
        {
        string Vno=txtvno.Text;
        _Dbtask.ExecuteNonQuery("delete from tblissueproduct where vno='"+Vno+"'");
        _Dbtask.ExecuteNonQuery("delete from tblissueproductdetail where issueid='" + Vno + "'");
        _Dbtask.ExecuteNonQuery("delete from tblissuedetails where issuecode='" + txttvno.Tag + "' and vtype='IIsue'");
        _Dbtask.ExecuteNonQuery("delete from tblbusinessissue where issuecode='" + txttvno.Tag + "' and issuetype='IIsue'");
        }
        private bool Main()
        {

            if (ValidationFu())
            {
                try
                {
                    Rowvalidation();
                    if (Editmode == true)
                    {
                        Delete();
                    }
                    NextgInitialize();
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

        private void Frmissuetable_Load(object sender, EventArgs e)
        {
            Clear();
           // _Nextg.FormStylesett(this);
           // _Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlBottom);
           // _Nextg.FormHeadStyle(pnlHead);
           // _Nextg.FormImage(pnlImage);
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                columnindex = gridmain.CurrentCell.ColumnIndex;
                rowindex = gridmain.CurrentCell.RowIndex;
                ColumnName = gridmain.Columns[columnindex].Name.ToString();
                Isenter = true;
                long Slno = rowindex + 1;
                gridmain.Rows[rowindex].Cells["clnslno"].Value = Slno;
                Isenter = true;
            }
            catch
            {

            }
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
                if (ColumnName == "clnitem"||ColumnName=="clnbatch")
            {
                gridmain.Rows[rowindex].Cells["clnitem"].Value = (sender as TextBox).Text;
                if (e.KeyValue == 27)
                {
                    if (uscGridshow2.GridProductShow.Visible == true)
                    {
                       uscGridshow2.GridProductShow.Visible = false;
                    }
                }

                if (e.KeyValue == 13)
                {
                    try
                    {
                        if (ColumnName == "clnitemname")
                        {
                            if (uscGridshow2.GridProductShow.SelectedRows.Count != 0)
                            {
                                if (Isenter == true)
                                {
                                    ProductIntoMainGrid();
                                }
                                ItemId = Convert.ToInt64(gridmain.Rows[rowindex].Cells["clnitem"].Tag);
                                Isenter = false;
                                (sender as TextBox).Text = gridmain.Rows[rowindex].Cells["clnitem"].Value.ToString();
                            }
                        }
                        else if (ColumnName == "clnbatch")
                        {

                            if (CommonClass._Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value) != "" || uscGridshow2.Visible == true)
                            {
                                int NowselectedRow;

                                if (uscGridshow2.Visible == true && uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                                {
                                    NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                                    TempBathcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                                }
                                else
                                {
                                    TempBathcode = CommonClass._Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                                }



                                Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + TempBathcode + "'");
                                if (Ds.Tables[0].Rows.Count > 0)
                                {
                                    string Tempitemid = CommonClass._Dbtask.ExecuteScalar("select itemid from tblbatch where bcode='" + TempBathcode + "'");
                                    ItemId = Convert.ToInt64(Tempitemid);
                                    //gridmain.Rows[rowindex].Cells["ClnItemCode"].Value = CommonClass._Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Tempitemid + "'");
                                    gridmain.Rows[rowindex].Cells["clnitem"].Tag = Tempitemid;

                                    gridmain.Rows[rowindex].Cells["clnitem"].Value = CommonClass._Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Tempitemid + "'");
                                    double TempPrate = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "prate"));
                                    gridmain.Rows[rowindex].Cells["clnrate"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TempPrate);

                                    gridmain.Rows[rowindex].Cells["clnbatch"].Value = TempBathcode;
                                    gridmain.Rows[rowindex].Cells["clnbatch"].Tag = TempBathcode;
                                    gridmain.NotifyCurrentCellDirty(false);
                                    uscGridshow2.Visible = false;
                                }
                                else
                                {
                                    MessageBox.Show("Batchcode Not exsting");

                                }

                            }
                        }
                    }
                    catch
                    {
                    }
                }


                try
                {
                    if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                    {
                        selectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                        int gridmainSelect = gridmain.CurrentCell.RowIndex;
                        if (uscGridshow2.GridProductShow.Visible == true)
                        {
                            if (e.KeyValue == 40 && uscGridshow2.GridProductShow.Rows[selectedRow].Cells[0].Value != null)
                            {

                                if (uscGridshow2.GridProductShow.Rows[selectedRow + 1].Cells[0].Value != null)
                                {
                                    uscGridshow2.GridProductShow.Rows[selectedRow + 1].Selected = true;
                                    uscGridshow2.GridProductShow.Rows[selectedRow].Selected = false;
                                    uscGridshow2.GridProductShow.CurrentCell = uscGridshow2.GridProductShow.SelectedRows[0].Cells[2];
                                }
                            }

                            if (e.KeyValue == 38 && selectedRow != 0)
                            {

                                gridmain.Rows[gridmainSelect + 1].Selected = true;
                                uscGridshow2.GridProductShow.Rows[selectedRow - 1].Selected = true;
                                uscGridshow2.GridProductShow.Rows[selectedRow].Selected = false;
                                uscGridshow2.GridProductShow.CurrentCell = uscGridshow2.GridProductShow.SelectedRows[0].Cells[2];
                            }
                        }
                    }
                }
                catch
                {
                }
            }
        
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            gridmain.Rows[rowindex].Cells[columnindex].Value = (sender as TextBox).Text;
            if (ColumnName == "clnitem" && gridmain.Rows[rowindex].Cells["clnitem"].Value != null &&Isenter==true)
            {
                string Temp = gridmain.Rows[rowindex].Cells["clnitem"].Value.ToString();
                ProductGridShow(Temp);
            }

            if (ColumnName == "clnbatch" && gridmain.Rows[rowindex].Cells["clnbatch"].Value != null)
            {
                string Temp = gridmain.Rows[rowindex].Cells["clnbatch"].Value.ToString();
                ProductGridShowWithBatch("where  TblItemMaster.itemCode Like N'%" + Temp + "%' OR  TblItemMaster.ItemName Like N'%" + Temp + "%' or Tblbatch.bcode like '%" + Temp + "%'");
            }
        }

        public void ProductGridShowWithBatch(string WhereCondition)
        {
            try
            {
                _Ingrid.BatchGridShow(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, "0",true,true,"");
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);

                if (tempRect.Top > 400)
                    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top - tempRect.Height + 6 * 3);
                else
                    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height + 31 * 3);

                if (uscGridshow2.Visible == false)
                {
                    uscGridshow2.Visible = true;
                }
            }
            catch
            {
            }
        }

        public void ProductIntoMainGrid()
        {
            try
            {
                selectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                string Itemname = uscGridshow2.GridProductShow.Rows[selectedRow].Cells["itemcode"].Value.ToString();
                string Itemid = uscGridshow2.GridProductShow.Rows[selectedRow].Cells["itemid"].Value.ToString();

                gridmain.Rows[rowindex].Cells["clnitem"].Value = Itemname;
                gridmain.Rows[rowindex].Cells["clnitem"].Tag = Itemid;

                double Prate = Convert.ToDouble(_Dbtask.ExecuteScalar("select prate from tblitemmaster where itemid='" + Itemid + "'"));

                gridmain.Rows[rowindex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpointStock(Prate);
                if (uscGridshow2.Visible == true)
                {
                    uscGridshow2.Visible = false;
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
                _Ingrid.ProductGridShowFixed(uscGridshow2,WhereCondition, uscGridshow2.GridProductShow, "0");

                // IsEnter = true;
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
                _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height + 15 * 6);
               
                if (uscGridshow2.GridProductShow.Visible == false)
                {
                    uscGridshow2.GridProductShow.Visible = true;
                }
            }
            catch
            {
            }
        }
        public void ShowPrevious(string vno)
        {
            try
            {
                Ds = _Dbtask.ExecuteQuery("select * from tblissueproduct where vno='" + vno + "'");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    gridmain.Rows.Clear();
                    Editmode = true;
                    vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                    string tempemployeeid = Ds.Tables[0].Rows[i]["employee"].ToString();
                    DateTime Issuedate = Convert.ToDateTime(Ds.Tables[0].Rows[i]["issuedate"]);
                    string Remarks = Ds.Tables[0].Rows[i]["remarks"].ToString();
                    string Tvno = Ds.Tables[0].Rows[i]["tvno"].ToString();


                    txtvno.Text = vno;
                    comemployee.SelectedValue = tempemployeeid;
                    dtissuedate.Value = Issuedate;
                    txtremarks.Text = Remarks;
                    txttvno.Text = Tvno;

                    Ds1 = _Dbtask.ExecuteQuery("select * from tblissueproductdetail where issueid='" + vno + "' order by slno");
                    for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                    {
                        gridmain.Rows.Add(1);
                        string Slno = Ds1.Tables[0].Rows[ii]["slno"].ToString();
                        string ttItemid = Ds1.Tables[0].Rows[ii]["item"].ToString();
                        string Itemname = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + ttItemid + "'");
                        double tQty = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["qty"]);
                        double trate = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["rate"]);
                        Barcode = Ds1.Tables[0].Rows[ii]["Bcode"].ToString();

                        gridmain.Rows[ii].Cells["clnslno"].Value = Slno;
                        gridmain.Rows[ii].Cells["clnitem"].Value = Itemname;
                        gridmain.Rows[ii].Cells["clnbatch"].Value = Barcode;
                        gridmain.Rows[ii].Cells["clnitem"].Tag = ttItemid;
                        gridmain.Rows[ii].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tQty);
                        gridmain.Rows[ii].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpointStock(trate);

                    }
                   

                }
                if (Ds.Tables[0].Rows.Count == 0)
                {
                    long temp =Convert.ToInt64(vno) - 1;
                    ShowPrevious(temp.ToString());
                }

            }
            catch
            {
                Clear();
            }
        }

        private void cmdback_Click(object sender, EventArgs e)
        {
            long temp = Convert.ToInt64(txtvno.Text) - 1;
            ShowPrevious(temp.ToString());
        }

        private void Frmissuetable_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void cmdforward_Click(object sender, EventArgs e)
        {
            long temp = Convert.ToInt64(txtvno.Text) + 1;
            ShowPrevious(temp.ToString());
        }

        private void Frmissuetable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to Delete?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result.ToString() == "Yes")
            {
                Ds = _Dbtask.ExecuteQuery("select * from tblreceivedproduct where issueid='" + txtvno.Text + "'");
                if (Ds.Tables[0].Rows.Count == 0)
                {
                    Delete();
                    Clear();
                }
                else
                {
                    MessageBox.Show("It is Already Used", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Showsetproduct()
        {

            Frmsetmainproduct _Setproduct = new Frmsetmainproduct();
            _Setproduct.ShowDialog();
        }
        public void Showreceivedproduct()
        {
            Frmreceivedproduct _Received = new Frmreceivedproduct();
            _Received.ShowDialog();
        }
        private void linksetproduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Showsetproduct();
        }

        private void linkissueproduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Showreceivedproduct();
        }

        private void gridmain_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (ColumnName == "clnbatch")
            {
                gridmain.Rows[rowindex].Cells[ColumnName].Value = TempBathcode;
                gridmain.Rows[rowindex].Cells[ColumnName].Tag = TempBathcode;
            }
        }
    }
}
