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
    public partial class FrmFeedback : Form
    {
        public FrmFeedback()
        {
            InitializeComponent();
        }
        Clsfeedback _feed = new Clsfeedback();
        public string   CusId="";
        DBTask _dbtask = new DBTask();
        public void clear()
        {
           txtvno.Text = Generalfunction.getnextid("fid", "Tblfeedback");
           txtCustmrname.Tag = "";
           txtCustmrname.Text = "";
            txtfeedback.textBox1.Text = "";
            uscitemshowsimple2.Visible = false;
            CommonClass._Nextg.FormIcon(this);
        }
        public void insert()
        {
            _feed.fid = _dbtask.znllString(txtvno.Text);
            _feed.fcustomer = _dbtask.znllString(txtCustmrname.Tag);
            _feed.fcalling = _dbtask.znllString(combostatus.SelectedIndex);
            _feed.ffeedback = _dbtask.znllString(txtfeedback.textBox1.Text);
            _feed.insertfeedback();
        
        }
        public void Main()
        {
       if(validation()==true)
       {
           insert();

           clear();
      }
 
        }
        public bool validation()
        {
            if (_dbtask.znllString(txtCustmrname.Tag) == "")
            {
                MessageBox.Show("enter a valid  customer ");
                return false;
            }
            return true;
        }

        private void FrmFeedback_Load(object sender, EventArgs e)
        {
            clear();
        }

        //private void txtcustmr_TextChanged(object Sender, EventArgs e)
        //{
        //    CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtcustmr.textBox1.Text, uscitemshowsimple2, 1);
        //}

        //private void txtcustmr_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    CommonClass._Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtcustmr.textBox1);
        //    uscitemshowsimple2.Location = new System.Drawing.Point(110, 60);
        //    if (e.KeyValue == 13)
        //    {


        //        if (_dbtask.znllString(txtcustmr.textBox1.Tag) != "")
        //        {
        //            CusId = _dbtask.znllString(txtcustmr.textBox1.Tag);
        //            uscitemshowsimple2.Visible = false;
        //        }
        //    }
        //}

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void FrmFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustmrname_TextChanged(object sender, EventArgs e)
        {
            CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtCustmrname.Text, uscitemshowsimple2, 1);
        }

        private void txtCustmrname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CommonClass._Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtCustmrname);
            uscitemshowsimple2.Location = new System.Drawing.Point(110, 60);
            if (e.KeyValue == 13)
            {


                if (_dbtask.znllString(txtCustmrname.Tag) != "")
                {
                    CusId = _dbtask.znllString(txtCustmrname.Tag);
                    uscitemshowsimple2.Visible = false;
                }
            }
        }
         
             }
         
}
