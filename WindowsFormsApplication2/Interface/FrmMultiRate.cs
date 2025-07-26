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
    public partial class FrmMultiRate : Form
    {
        public FrmMultiRate()
        {
            InitializeComponent();
        }
        ClsMultiRates _MultiRates = new ClsMultiRates();
        NextGFuntion _Nextg = new NextGFuntion();
        public int RateIn;
        private void FrmMultiRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
        private bool ValidationFu()
        {
            if (TxtRateName.Text == "")
            {
                MessageBox.Show("Please Type Rate Name", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtRateName.Focus();
                return false;
            }
            return true;
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
        public void Insert()
        {
            _MultiRates.InsertMultiRate();
        }
        public void Clear()
        {
            GetItemId();
            ClearControles();
            TxtRateName.Text = "";
            TxtDescription.Text = "";
            TxtRateName.Focus();
        }
        public void ClearControles()
        {
        }
        public void GetItemId()
        {
            _MultiRates.IdMultiRate();
            TxtRateId.Text =Convert.ToString(_MultiRates.RateIdLng);
        }
        public void NextgInitialize()
        {
            _MultiRates.RateNameStr = TxtRateName.Text;
            _MultiRates.DescriptionStr = TxtDescription.Text;
            _MultiRates.RateIdLng =Convert.ToInt64(TxtRateId.Text);
            _MultiRates.RateInInt = RateIn;
        }

        private void RadAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (RadAmount.Checked == true)
            {
                RateIn = 1;
            }
            else
            {
                RateIn = -1;
            }
        }

        private void FrmMultiRate_Load(object sender, EventArgs e)
        {
            Clear();
            _Nextg.FormStylesett(this);
            CommonClass._Nextg.FormIcon(this);
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        

    }
}
