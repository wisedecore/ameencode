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
    public partial class FrmUnits : Form
    {
        public FrmUnits()
        {
            InitializeComponent();
        }
        ClsMultiUnits _MultiUnits = new ClsMultiUnits();
        DBTask _Dbtask = new DBTask();
        NextGFuntion _Nextg = new NextGFuntion();
        private void FrmUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private bool ValidationFu()
        {
            if (TxtBaseUnit.Text == "")
            {
                MessageBox.Show("Please Type BaseUnit");
                TxtBaseUnit.Focus();
                return false;
            }
            if (TxtUnitName1.Text == "")
            {
                MessageBox.Show("Please Type Unitname");
                TxtUnitName1.Focus();
                return false;
            }
            return true;
        }
        public void NextgInitialize()
        {

             _MultiUnits.IdMultiUnits();
            _MultiUnits.BaseStr = TxtId.Text;
            _MultiUnits.UnameStr = TxtBaseUnit.Text;
            _MultiUnits.CF = Convert.ToDouble(1);

            Insert();
            _MultiUnits.IdMultiUnits();
            _MultiUnits.BaseStr = TxtId.Text;
            _MultiUnits.UnameStr = TxtUnitName1.Text;
            _MultiUnits.CF =Convert.ToDouble(TxtUnitCF1.Text);

            Insert();
            _MultiUnits.IdMultiUnits();
            _MultiUnits.BaseStr = TxtId.Text;
            _MultiUnits.UnameStr = TxtUnitName2.Text;
            double ThirdQty = Convert.ToDouble(TxtUnitCF2.Text) * Convert.ToDouble(TxtUnitCF1.Text);
            _MultiUnits.CF = Convert.ToDouble(ThirdQty);
            Insert();
        }
        public void Insert()
        {
            _MultiUnits.InsertMultiUnit();
        }
        public void Clear()
        {
            _Nextg.ClearControles(this);
            //ClearControles();
            GetVno();
           // SetDecimal();
            TxtBaseUnit.Focus();
        }
        public void GetVno()
        {
        _MultiUnits.IdMultiUnits();
        TxtId.Text =Convert.ToString(_MultiUnits.UnitIdLng);
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
        public void GetId()
        {
            _MultiUnits.IdMultiUnits();
            TxtId.Text =Convert.ToString(_MultiUnits.UnitIdLng);
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    NextgInitialize();
                    //Insert();
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

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void FrmUnits_Load(object sender, EventArgs e)
        {
            Clear();

        }

        private void TxtUnitCF2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtUnitCF2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e,false);
        }

        private void FrmUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }
    }
}
