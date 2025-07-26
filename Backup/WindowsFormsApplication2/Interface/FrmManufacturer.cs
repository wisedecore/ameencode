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
    public partial class FrmManufacturer : Form
    {
        public FrmManufacturer()
        {
            InitializeComponent();
        }
        ClsManufacturer _Manufacturer = new ClsManufacturer();
        public static bool Isinotherwindow;
        public string Vno;
        DataSet Ds;
        private void FrmManufacturer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
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

                    SendKeys.Send("{Tab}");
                    return true;

                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private bool Main()
        {
            if (ValidationFu()==true)
            {
                try
                {
                    CommonClass._Dbtask.ExecuteNonQuery("delete from tblmanufacturer where mid='"+TxtId.Text+"'");
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
        public void NextgInitialize()
        {
            _Manufacturer.Mid = Convert.ToInt64(TxtId.Text);
            _Manufacturer.Mname = TxtManName.Text;
            _Manufacturer.Phone = TxtPhone.Text;
            _Manufacturer.Address = TxtAddress.Text;
            _Manufacturer.InsertManufacturer();
        }
        public void Clear()
        {
            ClearControles();
            GetID();

            CommonClass._Nextg.FormIcon(this);

        }
        public void GetID()
        {
            _Manufacturer.IdManufacturer();
            TxtId.Text =Convert.ToString(_Manufacturer.Mid);
        }
        public void ClearControles()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text = "";
                }
            }
        }
        private bool ValidationFu()
        {
            if (TxtManName.Text == "")
            {
                MessageBox.Show("Please Type Name");
                TxtManName.Focus();
                return false;
            }
            return true;
        }

        private void FrmManufacturer_Load(object sender, EventArgs e)
        {
            if (Isinotherwindow == true)
            {
                Ds=CommonClass._Dbtask.ExecuteQuery("select * from tblmanufacturer where mid='"+Vno+"'");
                TxtId.Text = Vno;
                if(Ds.Tables[0].Rows.Count>0)
                {
                    TxtManName.Text = Ds.Tables[0].Rows[0]["Mname"].ToString();
                    TxtAddress.Text = Ds.Tables[0].Rows[0]["Address"].ToString();
                    TxtPhone.Text = Ds.Tables[0].Rows[0]["Phone"].ToString();
                }
            }
            else
            {
                Clear();
            }
        }

        private void TxtManName_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Mname", "TblManufacturer", TxtManName);

        }

        private void TxtPhone_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Phone", "TblManufacturer", TxtPhone);


        }

        private void TxtAddress_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Address", "TblManufacturer", TxtAddress);

        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                Main();
            }

        }

    }
}
