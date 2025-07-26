using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Frmrack : Form
    {
        public Frmrack()
        {
            InitializeComponent();
        }

        public bool EditMode;
        public bool Isinotherwindow;

        public long rid;
        public string rack = "";
        DataSet Ds;
        Clsrack _rack = new Clsrack();
        private void Frmrack_Load(object sender, EventArgs e)
        {
            if (Isinotherwindow == false)
            {
                Clear();
            }
            else
            {
                Retrive();
            }
            txtrack.Focus();
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
        public void NextgInitialize()
        {
            _rack.Rid= Convert.ToInt64(TxtId.Text);
            _rack.Rack= CommonClass._Dbtask.znllString(txtrack.Text);
            _rack.Insertrack();
        }
        public bool ValidationFu()
        {
            if (txtrack.Text == "")
            {
                MessageBox.Show("Please Enter the Rack", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtrack.Focus();
                return false;
            }
            rack = CommonClass._Dbtask.ExecuteScalar("select rid from tblrack where rack='" + txtrack.Text + "'");
            if (rack != "" && EditMode == false)
            {
                MessageBox.Show("Rack Is Already Exist", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtrack.Focus();
                return false;
            }

            return true;
        }


        public void Clear()
        {
            try
            {
                TxtId.Text = Generalfunction.getnextid("rid", "Tblrack");
                txtrack.Text = "";

                EditMode = false;
                Isinotherwindow = false;
                txtrack.Focus();
            }
            catch
            {
            }
        }
        public void Deleterack()
        {
            CommonClass._Dbtask.ExecuteNonQuery("Delete from Tblrack where rid='" + TxtId.Text + "'");
        }

        public void Retrive()
        {
            Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblrack where rid='" + rid + "'");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                TxtId.Text = CommonClass._Dbtask.znllString(rid);
                txtrack.Text = CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[0]["rack"]);

                EditMode = true;
            }
        }

        private bool Main()
        {
            if (ValidationFu() == true)
            {
                try
                {
                    if (EditMode == true)
                    {
                        Deleterack();
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

        private void txtrack_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Main();
            }
        }

        private void txtrack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Main();
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }



    }
}
