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
    public partial class frmcustomercard : Form
    {
        public frmcustomercard()
        {
            InitializeComponent();
        }
        Clscustomerpoint _Customerpoint = new Clscustomerpoint();
        DBTask _dbtask = new DBTask();
        public bool EditMode;

        public long Cpid;
        public string CardName;
        public DateTime ValidFrom;
        public DateTime ValidTo;
        public double SalesValue;
        public double Point;
        public double Discount;

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

        public void GetVno()
        {
            _Customerpoint.IdCustomerPoint();
            txtid.Text = (_Customerpoint.Cpid).ToString();
        }

        public void Clear()
        {
            GetVno();
            Txtcardname.Text = "";
            txtdiscount.Text = _dbtask.SetintoDecimalpoint(0);
            txtpoint.Text = _dbtask.SetintoDecimalpoint(0);
            txtsalevalue.Text = _dbtask.SetintoDecimalpoint(0);
            CommonClass._Nextg.FormIcon(this);
        
        }

        private void frmcustomercard_Load(object sender, EventArgs e)
        {
            Clear();
        }
        private bool ValidationFu()
        {

            if (Txtcardname.Text == "")
            {
                MessageBox.Show("Enter the Card Name", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txtcardname.Focus();
                return false;
            }

            if (txtsalevalue.Text == "")
            {
                MessageBox.Show("Enter Sale Value", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsalevalue.Focus();
                return false;
            }
            if (txtpoint.Text == "")
            {
                MessageBox.Show("Enter Point", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpoint.Focus();
                return false;
            }
            if (txtdiscount.Text == "")
            {
                MessageBox.Show("Enter Discount Value", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiscount.Focus();
                return false;
            }
            if (EditMode == false)
            {
                string tempitemcode = _dbtask.ExecuteScalar("select cpid from tblcustomerpoint where cpid='" + txtid.Text + "'");
                if (tempitemcode != "")
                {
                    MessageBox.Show("Item Code Is Already Exist", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txtcardname.Focus();
                    return false;
                }
            }
            return true;
        }
        public void DeleteItems()
        {
        
        }
        public void NextgInitialize()
        {
            Cpid=Convert.ToInt64(txtid.Text);
            CardName=Txtcardname.Text;
            ValidFrom = dtfrom.Value;
            ValidTo = dtto.Value;
            SalesValue = _dbtask.znullDouble(txtsalevalue.Text);
            Point = _dbtask.znullDouble(txtpoint.Text);
            Discount = _dbtask.znullDouble(txtdiscount.Text);
            SalesValue = _dbtask.znullDouble(txtsalevalue.Text);

            _Customerpoint.Cpid = Cpid;
            _Customerpoint.CardName = CardName;
            _Customerpoint.ValidFrom=ValidFrom;
            _Customerpoint.ValidTo = ValidTo;
            _Customerpoint.SalesValue = SalesValue;
            _Customerpoint.Point = Point;
            _Customerpoint.Discount = Discount;
            _Customerpoint.SalesValue = SalesValue;

        }
        public void Insert()
        {
            _Customerpoint.InsertCustomerPoint();
        }
        private bool Main()
        {

            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
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
        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void frmcustomercard_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
    }
}
