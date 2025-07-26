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
    public partial class Frmcustomerprojects : Form
    {
        public Frmcustomerprojects()
        {
            InitializeComponent();
        }
        public bool EditMode;
        public bool Isinotherwindow;
        public long Pid;
        public string PName;
        public long PartyId;
        public string Mobile;
        public string Address;


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
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);

            }
        }

        private void Frmcustomerprojects_Load(object sender, EventArgs e)
        {

            if (Isinotherwindow == true)
            {
                Fillcombo();
                txtvno.Text = Pid.ToString();
                txtproject.textBox1.Text = CommonClass._Partyproject.GetspecifField("pname", Pid.ToString());
                txtaddress.textBox1.Text = Address;
                txtmobile.textBox1.Text = Mobile;
                comcustomer.SelectedValue = PartyId;
            }
            else
            {
                Clear();
            }
            ChangeLanguage();


            CommonClass._Nextg.FormIcon(this);
        }

        public void Fillcombo()
        {
            CommonClass._Ledger.FillComboSupplierandCustomer(comcustomer);
        }

        public void DeleteItems()
        {
            CommonClass._Dbtask.ExecuteNonQuery("delete from Tblpartyproject where pid='" + txtvno.Text + "'");
        }
        
        public void getVno()
        {
            txtvno.Text = CommonClass._Partyproject.Getvno();
        }

        public void Clear()
        {
            txtproject.textBox1.Text = "";
            txtaddress.textBox1.Text = "";
            txtmobile.textBox1.Text = "";
            txtproject.Focus();
            Isinotherwindow = false;
            getVno();
            Fillcombo();
        }

        public void NextgInitialize()
        {
            if(Isinotherwindow==false)
            getVno();
            Pid = Convert.ToInt64(txtvno.Text);
            PName = txtproject.textBox1.Text;
            PartyId = Convert.ToInt64(comcustomer.SelectedValue);
            Mobile = txtmobile.textBox1.Text;
            Address = txtaddress.textBox1.Text;

            CommonClass._Partyproject.Pid = Pid;
            CommonClass._Partyproject.ProjectName = PName;
            CommonClass._Partyproject.PartyId = PartyId;
            CommonClass._Partyproject.Mobile = Mobile;
            CommonClass._Partyproject.Address = Address;
            CommonClass._Partyproject.InsertParty();
        }

        private bool ValidationFu()
        {
            PName = txtproject.textBox1.Text;
            if (txtproject.textBox1.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Enter the Project Name", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtproject.textBox1.Focus();
                return false;
            }
            if (Isinotherwindow == false)
            {
                CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery("select * from Tblpartyproject where pname ='"+PName+"'");
                if (CommonClass.Ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Project Name Already Exist", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtproject.textBox1.Focus();
                    return false;
                }
            }


            return true;
        }
        private bool Main()
        {

            if (ValidationFu())
            {
                try
                {
                    if (Isinotherwindow == true)
                    {
                        DeleteItems();
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

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void Frmcustomerprojects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();

            if (e.KeyValue == 116)
                Main();
        }

        private void txtproject_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("pname", "Tblpartyproject", txtproject.textBox1);

        }

        private void txtmobile_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Mobile", "Tblpartyproject",txtmobile.textBox1);

        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Address", "Tblpartyproject",  txtaddress.textBox1);

        }

       
    }
}
