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
    public partial class Frmstockadjustmentgroup : Form
    {
        public Frmstockadjustmentgroup()
        {
            InitializeComponent();
        }
        ClsSAgroup _StockAdjustmentGroup = new ClsSAgroup();

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
        private void Frmstockadjustmentgroup_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
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
        private bool ValidationFu()
        {
            if (TxtGroupName.Text == "")
            {
                MessageBox.Show("Please Enter the Group Name","Qplex",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TxtGroupName.Focus();
                return false;
            }
            return true;
        }
        
        public void NextgInitialize()
        {
            _StockAdjustmentGroup.GidLng = Convert.ToInt64(TxtId.Text);
            _StockAdjustmentGroup.GnameStr = TxtGroupName.Text;
            _StockAdjustmentGroup.GunderInt =Convert.ToInt16(ComUnder.SelectedText);
        }
        public void Clear()
        {
            GetVno();
            ClearControles();
        }
        public void ClearControles()
        {
        
        }
        public void GetVno()
        {
            _StockAdjustmentGroup.IdStockAdjustmentGroup();
            TxtId.Text = Convert.ToString(_StockAdjustmentGroup.GidLng);
        }
        public void Insert()
        {
            _StockAdjustmentGroup.InsertStockAdjustmentGroup();
        }

        private void Frmstockadjustmentgroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void Frmstockadjustmentgroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComUnder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Main();
            }
        }

    }
}
