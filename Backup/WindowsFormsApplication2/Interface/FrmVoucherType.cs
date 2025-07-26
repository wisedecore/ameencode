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
    public partial class FrmVoucherType : Form
    {
        public FrmVoucherType()
        {
            InitializeComponent();
        }

        DBTask _DBTask = new DBTask();
        ClsVoucherType _VouchrType = new ClsVoucherType();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        DataSet DS = new DataSet();

        public int selectedRow;

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
                if (GridItem.Visible == true)
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

        private bool Main()
        {
            if (ValidationFu())
            {
                Initialize();
                clear();
            }
            return true;
        }
        public void clear()
        {
            GridItem.Visible = false;
            GetLedCode();
            txtVname.textBox1.Text = "";
            txtPrinter.textBox1.Text = "";
            txtItemClass.textBox1.Text = "";
            txtItemCategry.textBox1.Text = "";
            comUnderVucr.Text = "SELECT";
            ChangeLanguage();

            CommonClass._Nextg.FormIcon(this);
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
        public void GetLedCode()
        {
            _AccountLedger.IdAccountLedger();
            TxtLedId.textBox1.Text = Convert.ToString(_AccountLedger.LidLng);
        }
        public void Initialize()
        {
            String Lid = TxtLedId.textBox1.Text;
            string GroupId=_DBTask.ExecuteScalar("select AGroupId from TblAccountGroup where AGroupName='"+comUnderVucr.Text+"'");
           string Tag =_DBTask.ExecuteScalar("select CategoryId from TblItemCategory where Category='"+txtItemCategry.textBox1.Text+"'");
            txtItemCategry.textBox1.Tag=Tag;
            _VouchrType.Vname = txtVname.textBox1.Text;
            _VouchrType.UnderVuchr = comUnderVucr.Text;
            _VouchrType.ItemCategryId =Convert.ToInt16(txtItemCategry.textBox1.Tag);
            _VouchrType.ItemClass = txtItemClass.textBox1.Text;
            _VouchrType.Printer = txtPrinter.textBox1.Text;
            _VouchrType.Lid =Convert.ToInt16(Lid);
            _VouchrType.InsertVouchrType();

            _AccountLedger.LidLng = Convert.ToInt64(Lid);
            _AccountLedger.LNameStr = txtVname.textBox1.Text;
            _AccountLedger.GidLng = Convert.ToInt64(GroupId);
            _AccountLedger.InsertLedger();
        }

        public bool ValidationFu()
        {
            return true;
        }

        private void cmdBrows_Click(object sender, EventArgs e)
        {
            Brows();
        }
        public void Brows()
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Invoice Design File";
            theDialog.Filter = "Invoice Design File|*.rtf";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
               // this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                string Filepath = theDialog.FileName;
                txtPrinter.textBox1.Text = Filepath;

            }
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
            }
        }
        private void FrmVoucherType_Load(object sender, EventArgs e)
        {
            clear();
        }

       
        private void txtItemCategry_TextChanged(object Sender, EventArgs e)
        {
            
            showItemCategory();
        }
        public void showItemCategory()
        {
            GridItem.Visible = true;
            GridItem.Location = new System.Drawing.Point(138, 139);
            DS = _DBTask.ExecuteQuery("select * from TblItemCategory where Category like '%" + txtItemCategry.textBox1.Text + "%'");

            GridItem.Rows.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                GridItem.Rows.Add(1);
                GridItem.Rows[i].Cells[0].Value = DS.Tables[0].Rows[i]["Category"];
                GridItem.Rows[i].Cells[0].Tag = DS.Tables[0].Rows[i]["CategoryId"];
            }
        }

        private void txtItemClass_TextChanged(object Sender, EventArgs e)
        {
            ShowItemClass();
        }
        public void ShowItemClass()
        {
            GridItem.Visible = true;
            GridItem.Location = new System.Drawing.Point(138, 175);
            DS = _DBTask.ExecuteQuery("select distinct Itemclass from TblItemMaster where Itemclass like '%" + txtItemClass.textBox1.Text + "%'");

            GridItem.Rows.Clear();

            for (int i = 0; i <DS.Tables[0].Rows.Count; i++)
            {
                GridItem.Rows.Add(1);
                GridItem.Rows[i].Cells[0].Value = DS.Tables[0].Rows[i]["Itemclass"];
               // GridItem.Rows[i].Cells[0].Tag = DS.Tables[0].Rows[i]["Lid"];
            }
        }

        private void txtItemClass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (GridItem.Visible == true)
            {
                if (GridItem.SelectedRows.Count > 0)
                {
                    selectedRow = GridItem.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && GridItem.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (GridItem.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            GridItem.Rows[selectedRow + 1].Selected = true;
                            GridItem.Rows[selectedRow].Selected = false;
                            GridItem.CurrentCell = GridItem.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        GridItem.Rows[selectedRow - 1].Selected = true;
                        GridItem.Rows[selectedRow].Selected = false;
                        GridItem.CurrentCell = GridItem.SelectedRows[0].Cells[0];
                    }
                }
                if (e.KeyValue == 13)
                {

                    if (GridItem.SelectedRows.Count > 0)
                    {
                        txtItemClass.textBox1.Text=GridItem.Rows[selectedRow].Cells[0].Value.ToString();
                       // txtItemCategry.textBox1.Tag=GridItem.Rows[selectedRow].Cells[0].Tag.ToString();
                    
                        GridItem.Visible = false;
                        //  AlreadyExist();
                    }
                }
            }
        }

        private void txtItemClass_Leave(object sender, EventArgs e)
        {
            GridItem.Visible=false;
        }

      
        private void txtItemCategry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (GridItem.Visible == true)
            {
                if (GridItem.SelectedRows.Count > 0)
                {
                    selectedRow = GridItem.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && GridItem.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (GridItem.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            GridItem.Rows[selectedRow + 1].Selected = true;
                            GridItem.Rows[selectedRow].Selected = false;
                            GridItem.CurrentCell = GridItem.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        GridItem.Rows[selectedRow - 1].Selected = true;
                        GridItem.Rows[selectedRow].Selected = false;
                        GridItem.CurrentCell = GridItem.SelectedRows[0].Cells[0];
                    }
                }
                if (e.KeyValue == 13)
                {

                    if (GridItem.SelectedRows.Count > 0)
                    {
                        txtItemCategry.textBox1.Tag = GridItem.Rows[selectedRow].Cells[0].Tag;
                        txtItemCategry.textBox1.Text = GridItem.Rows[selectedRow].Cells[0].Value.ToString();
                        GridItem.Visible = false;
                        //  AlreadyExist();
                    }
                }
            }
        }

        private void txtItemCategry_Load(object sender, EventArgs e)
        {

        }

        private void txtItemCategry_Leave(object sender, EventArgs e)
        {
            //CommonClass._GenF.CHECKCHARACTER("CategoryId", "tblVoucherType", txtItemCategry.textBox1);

            GridItem.Visible = false;
        }

        private void GridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtVname_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Vname", "tblVoucherType", txtVname.textBox1);

        }

        private void txtPrinter_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Printer", "tblVoucherType", txtPrinter.textBox1);

        }

      

    }
}
