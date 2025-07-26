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
    public partial class Frmsetmainproduct : Form
    {
        public Frmsetmainproduct()
        {
            InitializeComponent();
        }
        ClsItemMaster _Itemmaster = new ClsItemMaster();
        Clsproductsett _Productsett = new Clsproductsett();
        Clsproductsettdetail _Productsettdetail = new Clsproductsettdetail();
        ClsInGrid _Ingrid = new ClsInGrid();
        NextGFuntion _Nextg = new NextGFuntion();

        DBTask _dbtask = new DBTask();
        DataSet Ds;
        DataSet Ds1;

        string TempBathcode;
        /*For Settings*/
        public bool Sbatch;

        /*****************************/

        public bool Editmode;
        public bool Isenter;
        public int selectedRow;
        public string ItemId;
       public int columnindex ;
       public int rowindex  ;
       public string ColumnName;
       public string Bcode;

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
       public void ChangeLanguage()
       {
           if (ClsLanguage.IsArabic())
           {
               CommonClass._Language.FormBasedConversion(this);
               CommonClass._Language.GridHeaderConversion(gridmain);

           }
       }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
        public void DeleteItems()
        {
            try
            {
                string Id = txtid.Text;
                _dbtask.ExecuteNonQuery("delete from tblproductsett where id='" + Id + "'");
                _dbtask.ExecuteNonQuery("delete from tblproductsettdetail where id='" + Id + "'");
            }
            catch
            {
            }
        }
        public void NextgInitialize()
        {
            try
            {
                long ID = Convert.ToInt64(txtid.Text);
                //long Mainitemid = Convert.ToInt64(comitem.SelectedValue);
                double Mrate = Convert.ToDouble(txtmrate.Text);
                long Mainitemid = 0;
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() != "-1")
                        {

                            long Slno = Convert.ToInt64(gridmain.Rows[i].Cells["clnslno"].Value);
                            long Itemid = Convert.ToInt64(gridmain.Rows[i].Cells["clnitemname"].Tag);
                            double Qty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                            double Rate = Convert.ToDouble(gridmain.Rows[i].Cells["clnprate"].Value);
                            Bcode = "";
                            if(Sbatch==true)
                            {
                                Bcode = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();
                          
                            }
                            _Productsettdetail.Id = ID;
                            _Productsettdetail.Slno = Slno;
                            _Productsettdetail.Itemid = Itemid;
                            _Productsettdetail.Qty = Qty;
                            _Productsettdetail.Rate = Rate;
                            _Productsettdetail.Bcode = Bcode;
                            _Productsettdetail.Insertproductsettdetail();

                        }
                    }
                }
                if (Sbatch == true)
                {
                    Bcode =_dbtask.znllString( txtfinishproduct.Text );
                     Mainitemid =Convert.ToInt64(txtbarcode.Tag);
                    _Productsett.Bcode = Bcode;
                }
                else
                {
                    Mainitemid = Convert.ToInt64(txtfinishproduct.Text);
                }
                _Productsett.Id = ID;
                _Productsett.Itemid = Mainitemid;
                _Productsett.Mrate = Mrate;
                _Productsett.Insertproductsett();
                // _Productsett.Id=
            }
            catch
            {
            }
        }
        private bool ValidationFu()
        {
            if (txtfinishproduct.Text== null)
            {
                MessageBox.Show("Select Item !","Qplex",MessageBoxButtons.OK,MessageBoxIcon.Information);
                comitem.Focus();
                return false;
            }
            //if (Convert.ToDouble(txtmrate.Text) == 0)
            //{
            //    MessageBox.Show("Please enter Labour Charge","Qplex",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    txtmrate.Focus();
            //    return false;
            //}
            string VAL = "";
            if (Sbatch == true)
            {
                VAL =_dbtask.znllString( txtfinishproduct.Text);
                Ds = _dbtask.ExecuteQuery("select id from tblproductsett where BCODE='" + VAL + "'");
            }
            else
            {
                VAL = _dbtask.znllString(txtfinishproduct.Text);
                Ds = _dbtask.ExecuteQuery("select id from tblproductsett where item='" + VAL + "'");
            }
           
            if(Ds.Tables[0].Rows.Count>0 &&Editmode==false)
            {
                MessageBox.Show("Finished Goods Already Set Vno: "+Ds.Tables[0].Rows[0]["id"].ToString()+"");
                txtmrate.Focus();
                return false;
            }
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                //string tempItemid = gridmain.Rows[i].Cells["clnitem"].Tag.ToString();
                double tempQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);

                if (Sbatch == true)
                {
                    if (gridmain.Rows[i].Cells["clnbatch"].Tag != null && tempQty > 0 && gridmain.Rows[i].Cells["clnitemname"].Tag != null)
                    {
                        return true;
                    }
                }
                else
                {
                    if (gridmain.Rows[i].Cells["clnitemname"].Tag != null && tempQty > 0)
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
                //string tempItemid = gridmain.Rows[i].Cells["clnitem"].Tag.ToString();
                if (gridmain.Rows[i].Cells["clnqty"].Value != null)
                {
                    double tempQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);

                    if (Sbatch == true)
                    {

                        if (gridmain.Rows[i].Cells["clnitemname"].Tag != null && tempQty > 0 && gridmain.Rows[i].Cells["clnbatch"].Tag!=null)
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
                        if (gridmain.Rows[i].Cells["clnitemname"].Tag != null && tempQty > 0)
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

        public void Menusettings()
        {
            if (CommonClass._Menusettings.GetMnustatus("103") == "1")
            {
                Sbatch = true;
                clnbatch.Visible = true;
                lblbarcode.Visible = true;
                lblbarcodedot.Visible = true;
                combarcode.Visible = true;
            }
        }


        public void Insert()
        {
        }
        public void Clear()
       {
            GetId();
            Menusettings();
            txtmrate.Text = _dbtask.SetintoDecimalpoint(0);
            gridmain.Rows.Clear();
            Fillcombo();
            comitem.Focus();
            //this.txtid.ForeColor = System.Drawing.Color.White;
            ChangeLanguage();

            linkissue.Visible = false;
        }
        public void GetId()
        {
            _Productsett.Idproductsett();
            txtid.Text = _Productsett.Id.ToString();
        }
        public void Fillcombo()
        {
            _dbtask.fillDatainCombowithQuery(comitem, "itemid", "itemname", "tblitemmaster", "select * from tblitemmaster where  itemclass='Finished Product' or  itemclass='Finished Product2'");
            
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
                        DeleteItems();
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
        public void setings()
        {
            ClsInGrid.WGmitemcode = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemcode"));

            ClsInGrid.WGmitemname = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemname"));
            ClsInGrid.WGmsrate = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmsrate"));
            ClsInGrid.WGmmrp = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmmrp"));
            ClsInGrid.WGmrack = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmrack"));
            ClsInGrid.WGmprate = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmprate"));
            ClsInGrid.WGmbcode = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmbcode"));

        }

        private void Frmsetmainproduct_Load(object sender, EventArgs e)
        {
            Clear();
            _Nextg.FormStylesett(this);
            setings();
            CommonClass._Nextg.FormIcon(this);
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
                long Slno=rowindex+1;
                gridmain.Rows[rowindex].Cells["clnslno"].Value = Slno;
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

            txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (ColumnName == "clnitemname"||ColumnName=="clnbatch")
            {
                gridmain.Rows[rowindex].Cells[ColumnName].Value = (sender as TextBox).Text;
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
                            _Ingrid.PreviewKeyDownInGrid(e.KeyValue, uscGridshow2, uscGridshow2.GridProductShow, gridmain, Isenter, (sender as TextBox).Text, Convert.ToInt64(ItemId), rowindex, columnindex, "Clnprate", "prate", "0");
                            uscGridshow2.lblstock.Text = _dbtask.SetintoDecimalpointStock(_Ingrid.Stock);

                            ItemId = gridmain.Rows[rowindex].Cells["ClnItemName"].Tag.ToString();
                            Isenter = false;
                            (sender as TextBox).Text = gridmain.Rows[rowindex].Cells["ClnItemName"].Value.ToString();
                            uscGridshow2.Visible = false;
                        }
                        else
                        {
                            if (e.KeyValue == 13)
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


                                
                                    Ds =CommonClass._Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + TempBathcode + "'");
                                    if (Ds.Tables[0].Rows.Count > 0)
                                    {
                                        string Tempitemid = CommonClass._Dbtask.ExecuteScalar("select itemid from tblbatch where bcode='" + TempBathcode + "'");
                                        ItemId = Tempitemid;
                                        gridmain.Rows[rowindex].Cells["ClnItemCode"].Value = CommonClass._Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Tempitemid + "'");
                                        gridmain.Rows[rowindex].Cells["ClnItemName"].Tag = Tempitemid;

                                        gridmain.Rows[rowindex].Cells["ClnItemName"].Value = CommonClass._Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Tempitemid + "'");
                                        double TempPrate = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "prate"));


                                        gridmain.Rows[rowindex].Cells["clnprate"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TempPrate);

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
                                    // gridmain.CurrentCell = gridmain.Rows[rowindex].Cells[columnindex];
                                    //Upanddown = 1;
                                }
                            }

                            if (e.KeyValue == 38 && selectedRow != 0)
                            {

                                gridmain.Rows[gridmainSelect + 1].Selected = true;
                                uscGridshow2.GridProductShow.Rows[selectedRow - 1].Selected = true;
                                uscGridshow2.GridProductShow.Rows[selectedRow].Selected = false;
                                uscGridshow2.GridProductShow.CurrentCell = uscGridshow2.GridProductShow.SelectedRows[0].Cells[2];
                                // gridmain.CurrentCell = gridmain.Rows[rowindex].Cells[columnindex];
                                // Upanddown = -1;
                            }
                        }
                    }
                }
                catch
                {
                }
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

        public void ProductGridShow(string WhereCondition)
        {
            try
            {
                _Ingrid.ProductGridShowFixed(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, "0");

                // IsEnter = true;
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
                _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height + 15 * 7);

                if (uscGridshow2.GridProductShow.Visible == false)
                {
                    uscGridshow2.GridProductShow.Visible = true;
                }
            }
            catch
            {
            }
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
                gridmain.Rows[rowindex].Cells[columnindex].Value = (sender as TextBox).Text;
                if (Isenter == true)
                {
                    if (ColumnName == "clnitemname" && gridmain.Rows[rowindex].Cells["clnitemname"].Value != null)
                    {
                    string Temp = gridmain.Rows[rowindex].Cells["clnitemname"].Value.ToString();
                    ProductGridShow(Temp);
                    }
                    if (ColumnName == "clnbatch" && gridmain.Rows[rowindex].Cells["clnbatch"].Value != null)
                    {
                        string Temp = gridmain.Rows[rowindex].Cells["clnbatch"].Value.ToString();
                        ProductGridShowWithBatch("where  TblItemMaster.itemCode Like N'%" + Temp + "%' OR  TblItemMaster.ItemName Like N'%" + Temp + "%' or Tblbatch.bcode like '%" + Temp + "%'");
                    }
              }
        }

        private void txtmrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e,false);
        }
        public void ShowPrevious(string vno)
        {
            try
            {

                Ds = _dbtask.ExecuteQuery("select * from tblproductsett where id='" + vno + "'");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    gridmain.Rows.Clear();
                    Editmode = true;
                    vno = Ds.Tables[0].Rows[i]["ID"].ToString();
                    string tempItemid = Ds.Tables[0].Rows[i]["item"].ToString();
                    double Rate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Mrate"]);

                    txtid.Text = vno;
                    txtmrate.Text = _dbtask.SetintoDecimalpoint(Rate);
                    //comitem.SelectedValue = tempItemid;
                    //Bcode = combarcode.Text;


                    if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
                    {

                        txtfinishproduct.Text = _dbtask.znllString(Ds.Tables[0].Rows[i]["bcode"]);
                        txtbarcode.Tag = _dbtask.znllString(tempItemid);
                        txtbarcode.Text = CommonClass._Itemmaster.SpecificField(_dbtask.znllString(txtbarcode.Tag), "itemname");
                       
                    }
                    else
                    {
                        txtfinishproduct.Tag = _dbtask.znllString(tempItemid);


                        txtfinishproduct.Text = CommonClass._Itemmaster.SpecificField(_dbtask.znllString(txtfinishproduct.Tag), "itemname");

                        txtbarcode.Text = CommonClass._Itemmaster.SpecificField(_dbtask.znllString(txtfinishproduct.Tag), "itemcode");

                       
                    }



                    gridmaintwo.Visible = false;

                    Ds1 = _dbtask.ExecuteQuery("select * from tblproductsettdetail where id='" + vno + "'");
                    for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                    {
                        int count= gridmain.Rows.Add(1);
                       // string Slno = i;
                        string ttItemid = Ds1.Tables[0].Rows[ii]["item"].ToString();
                        string Itemname = _dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + ttItemid + "'");
                        double tQty = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["qty"]);
                        double trate = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["rate"]);
                        Bcode = Ds1.Tables[0].Rows[ii]["bcode"].ToString();
                        gridmain.Rows[count].Cells["clnslno"].Value = ii + 1; ;
                        gridmain.Rows[count].Cells["clnbatch"].Value = Bcode;
                        gridmain.Rows[count].Cells["clnbatch"].Tag = Bcode;
                        gridmain.Rows[count].Cells["clnitemname"].Value = Itemname;
                        gridmain.Rows[count].Cells["clnitemname"].Tag = ttItemid;
                        gridmain.Rows[count].Cells["clnqty"].Value = _dbtask.SetintoDecimalpointStock(tQty);
                        gridmain.Rows[count].Cells["clnprate"].Value = _dbtask.SetintoDecimalpointStock(trate);
                    }

                }
                if (Ds.Tables[0].Rows.Count == 0)
                {
                    long temp = Convert.ToInt64(vno) - 1;
                    ShowPrevious(temp.ToString());
                }


            }
            catch
            {
                Clear();
            }
        }
        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdback_Click(object sender, EventArgs e)
        {
            
            long tempvno=Convert.ToInt64(txtid.Text)-1;
            ShowPrevious(tempvno.ToString());
        }

        private void Frmsetmainproduct_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void cmdforward_Click(object sender, EventArgs e)
        {
            long tempvno = Convert.ToInt64(txtid.Text) + 1;
            ShowPrevious(tempvno.ToString());
        }

        private void Frmsetmainproduct_KeyDown(object sender, KeyEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            string tempitem=comitem.SelectedValue.ToString();
            Ds=_dbtask.ExecuteQuery("select * from tblreceivedproduct where item='"+tempitem+"'");
            if (Ds.Tables[0].Rows.Count == 0)
            {
                DeleteItems();
                Clear();
            }
            else
            {
                MessageBox.Show("Transaction already exists","Qplex",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void Showreceivedproduct()
        {
            Frmreceivedproduct _Rece = new Frmreceivedproduct();
            _Rece.ShowDialog();
        }
        public void Showissueproduct()
        {
            Frmissuetable _Issueproduct = new Frmissuetable();
            _Issueproduct.ShowDialog();
        }
        private void linksetproduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Showissueproduct();
        }

        private void linkreceived_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Showreceivedproduct();
        }

        private void comitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sbatch == true)
            {
               // ItemId=comitem.SelectedValue.ToString();
               //CommonClass._Dbtask.fillDatainCombowithQuery(combarcode, "bid", "bcode", "tblbatch", "select * from tblbatch where itemid='" + ItemId + "'");
            }
        }

        private void gridmain_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (ColumnName == "clnbatch")
            {
                gridmain.Rows[rowindex].Cells[ColumnName].Value = TempBathcode;
                gridmain.Rows[rowindex].Cells[ColumnName].Tag = TempBathcode;
            }
        }

        private void txtfinishproduct_TextChanged(object sender, EventArgs e)
        {
            if (Sbatch == true)
            {
             Ds = CommonClass._Itemmaster.getfinishedproduct(_dbtask.znllString(txtfinishproduct.Text));
            }
            else
            {
                Ds = _dbtask.ExecuteQuery("select itemid,itemname,itemcode from tblitemmaster where  itemclass='Finished Product' or  itemclass='Finished Product2'  and  itemname like N'%" + _dbtask.znllString(txtfinishproduct.Text) + "%'  or itemcode like N'%" + _dbtask.znllString(txtfinishproduct.Text) + "%'");
            }

            gridmaintwo.Columns.Clear();
            gridmaintwo.DataSource = null;
            gridmaintwo.Visible = true;
            //***table********//
            gridmaintwo.DataSource = Ds.Tables[0];

            for (int i = 0; i < gridmaintwo.Columns.Count; i++)
            {
                if (gridmaintwo.Columns[i].Name.ToString() == "itemid")
                    gridmaintwo.Columns[i].Visible = false;
            }
            if (Sbatch == true)
            {
                gridmaintwo.Columns["BCODE"].Width = 180;
                gridmaintwo.Columns["itemname"].Width = 190;
            }
            else
            {
                gridmaintwo.Columns["itemcode"].Width = 180;
                gridmaintwo.Columns["itemname"].Width = 190;
            }

            this.gridmaintwo.Location = new System.Drawing.Point(134, 77); 
        
           
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
                        if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
                        {

                            txtfinishproduct.Text = _dbtask.znllString(gridmaintwo.SelectedRows[0].Cells["bcode"].Value);
                            txtbarcode.Tag = _dbtask.znllString(gridmaintwo.SelectedRows[0].Cells["itemid"].Value);
                            txtbarcode.Text = _dbtask.znllString(gridmaintwo.SelectedRows[0].Cells["itemname"].Value);
                            gridmaintwo.Visible = false;

                        }
                        else
                        {

                            txtfinishproduct.Text = _dbtask.znllString(gridmaintwo.SelectedRows[0].Cells["itemid"].Value);

                            txtfinishproduct.Tag = _dbtask.znllString(gridmaintwo.SelectedRows[0].Cells["itemname"].Value);
                            txtbarcode.Text = _dbtask.znllString(gridmaintwo.SelectedRows[0].Cells["itemcode"].Value);

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
