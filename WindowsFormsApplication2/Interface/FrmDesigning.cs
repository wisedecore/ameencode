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
    public partial class FrmDesigning : Form
    {
        public FrmDesigning()
        {
            InitializeComponent();
        }
        public string CusId = "";
       
        public string Columnname;
        public int rowindex; public bool EditMode = false;
        public int columnindex; public string StockareaId = "0";
        Clsinserttaillor _taillor = new Clsinserttaillor();
        public int Countrow; public  bool Isinotherwindow = false;
        NextGFuntion _NextgFunction = new NextGFuntion();
        DBTask _Dbtask = new DBTask();
        ClsInGrid _InGrid = new ClsInGrid();
        DataSet Ds = new DataSet();
        ClsItemMaster _materialclss = new ClsItemMaster();
        clsitemCategory _clsmodel = new clsitemCategory();
        Clscolor _colorss = new Clscolor();
        DataSet Db = new DataSet(); ClsInGrid _Ingrid = new ClsInGrid();
        Generalfunction _Gen = new Generalfunction();
        public int selectedRow; public int mode;

        Clstailordetails _Tdetails = new Clstailordetails();

        public string modelid = "";
        public string materialid = "";
        public string colorid = "";



        bool IsEnter;
        private void FrmDesigning_Load(object sender, EventArgs e)
        {
            Frmcash.lbool = false;
           if(Isinotherwindow==true)
           {
               Retreive(txtvno.Text.ToString());
           }
               if(EditMode==false)
             {
            Clear();
             }
               CommonClass._Nextg.FormIcon(this);
            //txtsuppluer.Focus();

        }
        public void LedgerIntoMainGrid()
        {
            if (uscLedgershow1.GridProductShow.SelectedRows.Count > 0)
            {
                int SubSelectRow = uscLedgershow1.GridProductShow.SelectedRows[0].Index;
                if (uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells[0].Value != null && uscLedgershow1.Visible == true)
                    gridmain.Rows[rowindex].Cells["clnmaterial"].Value = uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells["material"].Value;
                gridmain.Rows[rowindex].Cells["clnmaterial"].Tag = uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells["itemid"].Value;
                {
                    uscLedgershow1.Visible = false;
                    gridmain.NotifyCurrentCellDirty(false);
                }
            }
        }
        public void modelingrid()
        {
            if (uscLedgershow1.GridProductShow.SelectedRows.Count > 0)
            {
                int SubSelectRow = uscLedgershow1.GridProductShow.SelectedRows[0].Index;
                if (uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells[0].Value != null && uscLedgershow1.Visible == true)
                    gridmain.Rows[rowindex].Cells["clnmodel"].Value = uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells["model"].Value;
                gridmain.Rows[rowindex].Cells["clnmodel"].Tag = uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells["categoryid"].Value;
                {
                    uscLedgershow1.Visible = false;
                    gridmain.NotifyCurrentCellDirty(false);
                }
            }
        }

        public void coloringrid()
        {
            if (uscLedgershow1.GridProductShow.SelectedRows.Count > 0)
            {
                int SubSelectRow = uscLedgershow1.GridProductShow.SelectedRows[0].Index;
                if (uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells[0].Value != null && uscLedgershow1.Visible == true)
                    gridmain.Rows[rowindex].Cells["clncolor"].Value = uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells["Color"].Value;
                gridmain.Rows[rowindex].Cells["clncolor"].Tag = uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells["cid"].Value;
                {
                    uscLedgershow1.Visible = false;
                    gridmain.NotifyCurrentCellDirty(false);
                }
            }
        }
        //txt
        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Columnname == "clnamount")
            {
                //Generalfunction.allowNumeric(sender, e, false);
            }
        }
        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            {
            if (Columnname == "clnmaterial")
            {
                if (e.KeyValue != 13)
                {
                    _Ingrid.RowUpDownSelectDress(e.KeyValue, uscLedgershow1.GridProductShow, selectedRow, uscLedgershow1, gridmain);
                    
                }

                if (e.KeyValue == 27)
                {
                    if (gridmain.Visible == false)
                    {
                        this.Close();
                    }
                    else
                    {
                        gridmain.Visible = true;
                    }
                }

                if (e.KeyValue == 13)
                {
                    LedgerIntoMainGrid();
                }

            }
            if (e.KeyValue == 114) /*For F3  Insert Rows */
            {
                gridmain.Rows.Insert(rowindex, 1);
                //_Gen.SlSetfunction(gridmain, "clnslno");
            }
            if (Columnname == "clnmodel")
            {
                if (e.KeyValue != 13)
                {
                    _Ingrid.RowUpDownSelectDress(e.KeyValue, uscLedgershow1.GridProductShow, selectedRow, uscLedgershow1, gridmain);
                }

                if (e.KeyValue == 27)
                {
                    if (gridmain.Visible == false)
                    {
                        this.Close();
                    }
                    else
                    {
                        gridmain.Visible = true;
                    }
                }

                if (e.KeyValue == 13)
                {
                    modelingrid(); 
                }


            }

            if (Columnname == "clncolor")
            {
                if (e.KeyValue != 13)
                {
                    _Ingrid.RowUpDownSelectDress(e.KeyValue, uscLedgershow1.GridProductShow, selectedRow, uscLedgershow1, gridmain);
                }

                if (e.KeyValue == 27)
                {
                    if (gridmain.Visible == false)
                    {
                        this.Close();
                    }
                    else
                    {
                        gridmain.Visible = true;
                    }
                }

                if (e.KeyValue == 13)
                {
                    coloringrid(); 
                }


            }




        }
        void txt_TextChanged(object sender, EventArgs e)
                {
            gridmain.Rows[rowindex].Cells[Columnname].Value = (sender as TextBox).Text;
            CommonClass.temp = _Dbtask.znllString(gridmain.Rows[rowindex].Cells[Columnname].Value);
            if (Columnname == "clnmaterial")
            {
                if (Isinotherwindow == false)
                {


                    if (Columnname == "clnmaterial")
                   {
                        CommonClass._Ingrid.DRESSshow(uscLedgershow1, " where itemname like N'%" + CommonClass.temp + "%'", uscLedgershow1.GridProductShow);
                       
                    }
                    else
                    {
                        CommonClass._Ingrid.DRESSshow(uscLedgershow1, " where itemname like N'%" + CommonClass.temp + "%'", uscLedgershow1.GridProductShow);
                       
                    }
                    Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
                    if (tempRect.Top > 180)
                    {
                        CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left, 0);
                    }
                    else
                    {
                        CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left, tempRect.Top + tempRect.Height - 9);
                    }
                   
                }
            }

            if (Columnname == "clnmodel")
            {

                if (Columnname == "clnmodel")
                {
                    CommonClass._Ingrid.drssmodel(uscLedgershow1, " where category like N'%" + CommonClass.temp + "%'", uscLedgershow1.GridProductShow);

                }
                else
                {
                    CommonClass._Ingrid.drssmodel(uscLedgershow1, " where category like N'%" + CommonClass.temp + "%'", uscLedgershow1.GridProductShow);

                }
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
                if (tempRect.Top > 180)
                {
                    CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left, 0);
                }
                else
                {
                    CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left, tempRect.Top + tempRect.Height - 9);
                }
                
                
            }
            if (Columnname == "clncolor")
            {
                if (Columnname == "clncolor")
                {
                    CommonClass._Ingrid.showcolor(uscLedgershow1, " where cname like N'%" + CommonClass.temp + "%'", uscLedgershow1.GridProductShow);

                }
                else
                {
                    CommonClass._Ingrid.showcolor(uscLedgershow1, " where cname like N'%" + CommonClass.temp + "%'", uscLedgershow1.GridProductShow);

                }
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
                if (tempRect.Top > 180)
                {
                    CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left, 0);
                }
                else
                {
                    CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left, tempRect.Top + tempRect.Height - 9);
                }

            }


        }
       
        public void ProductGridShowLocationSett(UserControl UserControleName, int Left, int Top)
        {
            UserControleName.Left = Left;

            UserControleName.Top = Top + 10;
        }


        //txt
        public void Clear()
        {
            txtvno.Text = Generalfunction.getnextid("vno", "Tbltaillor");
            txtvno.Tag = txtvno.Text.ToString();
            txtIDNo.Text = "";
            txtsuppluer.Text = "";
            combsleeve.SelectedIndex = 5;
            combcollor.SelectedIndex = 4;
            comboButton.SelectedIndex = 6;
            combttbtype.SelectedIndex = 4;
            txtlength.textBox1.Text = "";
            txtchest.textBox1.Text = "";
            txtbottom.textBox1.Text ="";
            txtsleeve.textBox1.Text = "";
            txtsholder.textBox1.Text = "";
            txtwaist.textBox1.Text = "";
            txtneck.textBox1.Text = ""; EditMode = false;
            gridmain.Rows.Clear();
            uscitemshowsimple2.Visible = false;
            uscLedgershow1.Visible = false;
          

        }

        public void nextginitail2()
        {
            _Tdetails.vno = Convert.ToInt64(txtvno.Text);
            _Tdetails.lid = txtIDNo.Tag.ToString();
            _Tdetails.length = txtlength.textBox1.Text.ToString();
            _Tdetails.chest = txtchest.textBox1.Text.ToString();
            _Tdetails.Bottom = txtbottom.textBox1.Text.ToString();
            _Tdetails.sleevL = txtsleeve.textBox1.Text.ToString();
            _Tdetails.sholder = txtsholder.textBox1.Text.ToString();
            _Tdetails.waist = txtwaist.textBox1.Text.ToString();
            _Tdetails.neck = txtneck.textBox1.Text.ToString();

            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        materialid = _Dbtask.znllString(gridmain.Rows[i].Cells["clnmaterial"].Tag);
                        modelid = _Dbtask.znllString(gridmain.Rows[i].Cells["clnmodel"].Tag);
                        colorid = _Dbtask.znllString(gridmain.Rows[i].Cells["clncolor"].Tag);
                    
                    }
                }
            }


            _Tdetails.material = materialid.ToString();
            _Tdetails.model = modelid.ToString();
            _Tdetails.color = colorid.ToString();
            _Tdetails.Inserttaillordetails();

        }

        public void nextginitial1()
        {
            _taillor.vno =Convert.ToInt64( txtvno.Text);
            _taillor.cname = txtsuppluer.Text.ToString();
            _taillor.ledcode = txtIDNo.Tag.ToString();
            _taillor.sleev = combsleeve.SelectedIndex.ToString();
            _taillor.collor = combcollor.SelectedIndex.ToString();
            _taillor.bttn = comboButton.SelectedIndex.ToString();
            _taillor.bttntype = combttbtype.SelectedIndex.ToString();
            _taillor.delydate =Convert.ToDateTime( dtdate.Value.ToString());
            _taillor.Arrdate =Convert.ToDateTime( dtarrivd.Value.ToString());
            _taillor.Inserttaillor();


        }
        public bool gridvalidation()
        {
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["clnmaterial"].Tag == null)
                    {
                        gridmain.Rows[i].Tag = -1;
                    }
                    else
                    {
                        if (gridmain.Rows[i].Cells["clnmodel"].Value == "")
                        {
                            MessageBox.Show("Fill model", CommonClass._Nextg.changecompanynameinmsgboxx(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gridmain.CurrentCell = gridmain.Rows[i].Cells["clnmodel"];
                            return false;
                        }
                        else
                        {
                            gridmain.Rows[i].Tag = 1;
                            gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                        }

                        if (gridmain.Rows[i].Cells["clncolor"].Value == "")
                        {
                            MessageBox.Show("Fill color", CommonClass._Nextg.changecompanynameinmsgboxx(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gridmain.CurrentCell = gridmain.Rows[i].Cells["clncolor"];
                            return false;
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
            return true;

        }
        public void Delete()
        {
            _Dbtask.ExecuteNonQuery("delete from tbltaillor where vno='"+txtvno.Text.ToString()+"'");
            _Dbtask.ExecuteNonQuery("delete from TbltaillorDetails where vno='"+txtvno.Text.ToString()+"'");
        }
        public void main()
        {
            try
            {
                if(EditMode==false)
                {
                    txtvno.Text = Generalfunction.getnextid("vno", "Tbltaillor");
                    txtvno.Tag = txtvno.Text.ToString();
                }
                if (Validation1() == true && gridvalidation() == true && measurmntvalidate()==true)
                {
                    if(EditMode==true)
                    {
                        Delete();
                    }


                    nextginitial1();
                    nextginitail2();
                    Clear();
                }
            }
            catch
            { 
            }

        }
        public void Retreive(string tvno)
        {
            string mid = ""; string mdlid = ""; string clid = "";
            Ds = _Dbtask.ExecuteQuery("select * from tbltaillor where vno='"+tvno+"'");

            if (Convert.ToInt32(tvno) != 0)
            {

                if (Ds.Tables[0].Rows.Count > 0 || Convert.ToInt32(tvno) > 1)
                {
                    txtvno.Text = tvno.ToString();
                    txtvno.Tag = tvno.ToString();
                    txtsuppluer.Tag = _Dbtask.ExecuteScalar("select lid from tbltaillor where vno='" + tvno + "'").ToString();
                    txtIDNo.Tag = txtsuppluer.Tag.ToString();
                    txtIDNo.Text = CommonClass._Ledger.GetspecifField("laliasname", txtsuppluer.Tag.ToString()).ToString();
                    txtsuppluer.Text = CommonClass._Ledger.GetspecifField("Lname", txtsuppluer.Tag.ToString()).ToString();
                    combsleeve.SelectedIndex = Convert.ToInt32(_Dbtask.ExecuteScalar("select sleev from tbltaillor where vno='" + tvno + "'"));
                    combcollor.SelectedIndex = Convert.ToInt32(_Dbtask.ExecuteScalar("select collor from tbltaillor where vno='" + tvno + "'"));
                    combttbtype.SelectedIndex = Convert.ToInt32(_Dbtask.ExecuteScalar("select bttntype from tbltaillor where vno='" + tvno + "'"));
                    comboButton.SelectedIndex = Convert.ToInt32(_Dbtask.ExecuteScalar("select bttn from tbltaillor where vno='" + tvno + "'"));
                    dtarrivd.Value = _Dbtask.ZnullDatetime(_Dbtask.ExecuteScalar("select Ardate from tbltaillor where vno='" + tvno + "'"));
                    dtdate.Value = _Dbtask.ZnullDatetime(_Dbtask.ExecuteScalar("select Deldate from tbltaillor where vno='" + tvno + "'"));

                    Db = _Dbtask.ExecuteQuery("select * from TbltaillorDetails where vno ='" + tvno + "'");

                    if (Db.Tables[0].Rows.Count > 0)
                    {

                        txtlength.textBox1.Text = _Dbtask.ExecuteScalar("select length  from TbltaillorDetails where vno ='" + tvno + "'").ToString();
                        txtchest.textBox1.Text = _Dbtask.ExecuteScalar("select chest  from TbltaillorDetails where vno ='" + tvno + "'").ToString();
                        txtbottom.textBox1.Text = _Dbtask.ExecuteScalar("select bottom  from TbltaillorDetails where vno ='" + tvno + "'").ToString();
                        txtsleeve.textBox1.Text = _Dbtask.ExecuteScalar("select sleevL  from TbltaillorDetails where vno ='" + tvno + "'").ToString();

                        txtsholder.textBox1.Text = _Dbtask.ExecuteScalar("select Sholder  from TbltaillorDetails where vno ='" + tvno + "'").ToString();
                        txtwaist.textBox1.Text = _Dbtask.ExecuteScalar("select waist  from TbltaillorDetails where vno ='" + tvno + "'").ToString();
                        txtneck.textBox1.Text = _Dbtask.ExecuteScalar("select neck  from TbltaillorDetails where vno ='" + tvno + "'").ToString();
                        gridmain.Rows.Clear();

                        for (int i = 0; i < Db.Tables[0].Rows.Count; i++)
                        {

                            gridmain.Rows.Add(1);
                            rowindex = i;

                            mid = Db.Tables[0].Rows[i]["material"].ToString();
                            mdlid = Db.Tables[0].Rows[i]["model"].ToString();
                            clid = Db.Tables[0].Rows[i]["color"].ToString();

                            gridmain.Rows[i].Cells["clnmaterial"].Tag = mid.ToString();
                            gridmain.Rows[i].Cells["clnmodel"].Tag = mdlid.ToString();
                            gridmain.Rows[i].Cells["clncolor"].Tag = clid.ToString();

                            gridmain.Rows[i].Cells["clnmaterial"].Value = _materialclss.SpecificField(mid, "itemname").ToString();
                            gridmain.Rows[i].Cells["clnmodel"].Value = _clsmodel.SpecificField(mdlid, "category").ToString();
                            gridmain.Rows[i].Cells["clncolor"].Value = _colorss.getcolor(clid).ToString();



                        }
                    }

                    EditMode = true;

                }
                else
                {
                    Clear();

                    if (Convert.ToInt64(tvno) < Convert.ToInt32(Generalfunction.getnextid("vno", "tbltaillor")))
                    {
                        txtvno.Text = tvno.ToString();
                        txtvno.Tag = tvno.ToString();

                        EditMode = true;

                    }
                }
            }

            uscitemshowsimple2.Visible = false;
        }
        public bool Validation1()
        {
            
             if(txtvno.Text==""||txtvno.Tag=="")
             {
                 MessageBox.Show("vno is empty");
                 txtvno.Focus();
                 return false;
             }
             if(txtsuppluer.Text==""||txtsuppluer.Tag==""||txtsuppluer.Text==""&&txtsuppluer.Tag=="")
             {
                 MessageBox.Show("Select customer correctly");
                 txtsuppluer.Focus();
                 return false;
             }
             if(txtIDNo.Text=="")
             {
                MessageBox.Show("ID is empty");
                txtIDNo.Focus();
                return false;
             }
           


             return true;
            
        }
        public bool measurmntvalidate()
        {
            if(txtlength.textBox1.Text=="0"||txtlength.textBox1.Text=="")
            {
                MessageBox.Show("Add length");
                txtlength.textBox1.Focus();
                return false;
            }
            if (txtchest.textBox1.Text == "0" || txtchest.textBox1.Text == "")
            {
                MessageBox.Show("Add chest measurement");
                txtchest.textBox1.Focus();
                return false;
            }
            if (txtbottom.textBox1.Text == "0" || txtbottom.textBox1.Text == "")
            {
                MessageBox.Show("Add bottom measurement");
                txtbottom.textBox1.Focus();
                return false;
            }
            if (txtwaist.textBox1.Text == "0" || txtwaist.textBox1.Text == "")
            {
                MessageBox.Show("Add waist measurement");
                txtwaist.textBox1.Focus();
                return false;
            }
            if (txtsleeve.textBox1.Text == "0" || txtsleeve.textBox1.Text == "")
            {
                MessageBox.Show("Add sleeve measurement");
                txtsleeve.textBox1.Focus();
                return false;
            }
            if (txtsholder.textBox1.Text == "0" || txtsholder.textBox1.Text == "")
            {
                MessageBox.Show("Add shoulder measurement");
                txtsholder.textBox1.Focus();
                return false;
            }
            if (txtneck.textBox1.Text == "0" || txtneck.textBox1.Text == "")
            {
                MessageBox.Show("Add neck measurement");
                txtneck.textBox1.Focus();
                return false;
            }
            return true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIDNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlcusdetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void CmdaddCus_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnucustomercreate.PerformClick();
        }

        private void txtsuppluer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CommonClass._Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtsuppluer);

            uscitemshowsimple2.Location = new System.Drawing.Point(84, 93);
            if (e.KeyValue == 13)
            {
               CusId  = txtsuppluer.Tag.ToString();
               txtIDNo.Tag = CusId.ToString();
               txtIDNo.Text = CommonClass._Ledger.GetspecifField("laliasname", CusId).ToString();
                
                
                string mob ="";
              mob = CommonClass._Ledger.GetspecifField("mobile",CusId).ToString();
              lblmobile.Text = "Mob ( " + mob + "  )";


            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtsuppluer_TextChanged(object sender, EventArgs e)
        {
            CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtsuppluer.Text, uscitemshowsimple2, 1);
        }

        private void uscnuemerictextbox1_Load(object sender, EventArgs e)
        {

        }

        private void uscnuemerictextbox1_Load_1(object sender, EventArgs e)
        {

        }

        private void uscnuemerictextbox1_Load_2(object sender, EventArgs e)
        {

        }

        private void uscitemshowsimple2_Load(object sender, EventArgs e)
        {

        }

        private void pnlmaterialdetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindex = gridmain.CurrentCell.RowIndex;
                columnindex = gridmain.CurrentCell.ColumnIndex;
                Columnname = gridmain.Columns[columnindex].Name.ToString();
               // gridmain.Rows[rowindex].Cells["clnmaterial"].Value = rowindex + 1;
                if (gridmain.Rows[rowindex].Cells[columnindex].ReadOnly == true)
                {
                    SendKeys.Send("{Tab}");
                }
                if (Columnname == "clncolor")
                {
                    gridmain.BeginEdit(true);
                }

            }
            catch
            {
            }
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)//TxtProduct,Txtqty,TxtAmt,panel2/*
            {


                if ( this.ActiveControl.Name != "panelsearch"||this.ActiveControl.Name != "gridmain")
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Enter)
                    {
                        SendKeys.Send("{Tab}");
                        return true;
                    }
                    if (uscLedgershow1.Visible == true)
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
                    if (uscitemshowsimple2.Visible == true)
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
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void gridmain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);

            txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);

            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);
        }

        private void pnlmeasure_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridmain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            main();
        }

        private void FrmDesigning_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==27)
            {
                panelsearch.Visible = true;
            }
        }

        private void txtsearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyValue==13)
            {
                Retreive(txtsearch.Text.ToString());
                panelsearch.Visible = false;
            }
        }

        private void FrmDesigning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue== 27)
            {
                panelsearch.Visible = true;
            }
        }

        private void FrmDesigning_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                panelsearch.Visible = true;
            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdback_Click(object sender, EventArgs e)
        {
            Retreive((Convert.ToInt64(txtvno.Text) - 1).ToString());
        }

        private void cmdfrnt_Click(object sender, EventArgs e)
        {
            Retreive((Convert.ToInt64(txtvno.Text) + 1).ToString());
        }

        private void FrmDesigning_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void uscLedgershow1_Load(object sender, EventArgs e)
        {

        }
    }
}
