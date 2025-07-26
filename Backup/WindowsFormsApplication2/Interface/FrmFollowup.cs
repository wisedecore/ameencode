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
    public partial class FrmFollowup : Form
    {
        public FrmFollowup()
        {
            InitializeComponent();



        }
        DataSet Ds;
        public string CusId = "";
        public bool newcus = false;
        DBTask _dbtask = new DBTask();
        Clsfollowup _follo = new Clsfollowup();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        public void clear()
        {
            _AccountLedger.IdAccountLedger();
           txtcusidentr.textBox1.Text = Convert.ToString(_AccountLedger.LidLng);
           txtCustmrname.Tag = Convert.ToString(_AccountLedger.LidLng); 
            txtCustmrname.Text = "";
           txtmobile.textBox1.Text = "";
           txtaddresss.textBox1.Text = "";
           txtcustype.Text = "";
           newcus = false;
           uscitemshowsimple2.Visible = false;
           CommonClass._Nextg.FormIcon(this);
        }
        public bool validation()
        {
            if (txtcusidentr.textBox1.Text=="")
            {
                MessageBox.Show("Id is empty");
                return false;
            }
            if (txtCustmrname.Text == "")
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            if (txtCustmrname.Text != "" && txtcusidentr.textBox1.Text != "")
            {
                if(newcus==true)
                {
                if (_AccountLedger.alreadyexistcustomer(_dbtask.znllString( txtcusidentr.textBox1.Text))==true)
                {
                    MessageBox.Show("Id Already Exist");
                    return false;
                }
                }

            }

            namecheck(_dbtask.znllString(txtCustmrname.Text));
            
            return true;

        }
        public void CreateNewCustomer(string cname,string id)
        {

            _AccountLedger.LidLng = Convert.ToInt64(id);
            _AccountLedger.LNameStr = cname;
            _AccountLedger.LAliasNameStr = cname;
            _AccountLedger.GidLng = 18;
            _AccountLedger.AddressStr = "";
            _AccountLedger.PhoneStr = "";
            _AccountLedger.MobileStr = "";
            _AccountLedger.DiscDb = 0;
            _AccountLedger.TaxRegNoStr = "";
            _AccountLedger.EmailStr = "";
            _AccountLedger.AreaStr = "";
            _AccountLedger.CreditDaysInt = 0;
            _AccountLedger.CreditLimitDb = 0;
            _AccountLedger.OtherStr = "";
            _AccountLedger.Commision = 0;
            _AccountLedger.CST = "";
            _AccountLedger.Cplan = 0;
            _AccountLedger.InsertLedger();
        }
        public bool namecheck(string name)
        {
            if (newcus == true && _dbtask.znllString(txtCustmrname.Text)!="")
            {
                Ds = _dbtask.ExecuteQuery("select lname from tblaccountledger where lname=N'" + name + "'");
                if ( Ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("customer name  Is Already Exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCustmrname.Focus();
                    return false;
                }
            }
            return true;
        }
        public void Insertdata()
        {
            if(newcus==true)
            {

                CreateNewCustomer(_dbtask.znllString(txtCustmrname.Text), _dbtask.znllString(txtCustmrname.Tag));
            }
            _follo.cusid = _dbtask.znllString(txtCustmrname.Tag);
            _follo.cusname =_dbtask.znllString(  txtCustmrname.Text);
            _follo.cusmob =_dbtask.znllString(  txtmobile.textBox1.Text);
            _follo.cusaddress =_dbtask.znllString(  txtaddresss.textBox1.Text);
            _follo.custype =_dbtask.znllString(  txtcustype.Text);
            _follo.Insertfollowup();

        }
        public void Main()
        {
            if(validation()==true)
            {
                Insertdata();
                clear();

            }
        }

        private void FrmFollowup_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void txtCustmrname_TextChanged(object sender, EventArgs e)
        {
            CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtCustmrname.Text, uscitemshowsimple2, 1);
        }

        private void txtCustmrname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CommonClass._Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtCustmrname);

            uscitemshowsimple2.Location = new System.Drawing.Point(110, 80);
            if (e.KeyValue == 13)
            {

                if (_AccountLedger.alreadyexistcustomer(_dbtask.znllString(txtCustmrname.Tag)) == true)
                {
                    if (_dbtask.znllString(txtCustmrname.Tag) != "")
                    {
                        CusId = txtCustmrname.Tag.ToString();
                    }
                }
                else
                {
                    uscitemshowsimple2.Visible = false;
                    if (_dbtask.znllString(txtCustmrname.Tag) != "")
                    {

                        newcus = true;
                        CusId = _dbtask.znllString(txtcusidentr.textBox1.Text);
                    }
                }

            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
