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
    public partial class FrmSlabMaster : Form
    {
        public FrmSlabMaster()
        {
            InitializeComponent();
        }
        ClSSlabMaster _SlabMaster = new ClSSlabMaster();
        NextGFuntion _Nextg = new NextGFuntion();
        DBTask _Dbtask = new DBTask();
        private void FrmSlabMaster_Load(object sender, EventArgs e)
        {
            Clear();
            
        }
       
        private void Txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtDiscription.Focus();
            }
        }

        private void TxtDiscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Main();
            }
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
            if (Txtname.Text == "")
            {
                MessageBox.Show("Please Type Taxname ");
                Txtname.Focus();
            return false;
            }
        return true;
        }

        public void NextgInitialize()
        {
            _SlabMaster.Slid =Convert.ToInt64(TxtID.Text);
            _SlabMaster.Slname = Txtname.Text;
            _SlabMaster.Discri = TxtDiscription.Text;
            _SlabMaster.Perc =Convert.ToDouble(TxtPercentage.Text);

            _SlabMaster.Efffrom =Convert.ToDateTime(DateTime.Now.ToString("dd/MMM/yyyy"));
           // _SlabMaster.
           }

        public void Insert()
        {
            _SlabMaster.InsertSlabMaster();
        }
        public void Clear()
        {
            _Nextg.ClearControles(this);
            _Nextg.SetControlesBehave(this);
            GetVno();
           // SetDecimal();
            Txtname.Focus();
        }
        public void GetVno()
        {
             _SlabMaster.IdSlabMaster();
            TxtID.Text =Convert.ToString(_SlabMaster.Slid);
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
        private void FrmSlabMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void CmdClose_Click(object sender, EventArgs e)
        {

        }
    }
}
