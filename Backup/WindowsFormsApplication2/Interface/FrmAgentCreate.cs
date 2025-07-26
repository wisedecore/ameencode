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
    public partial class FrmAgentCreate : Form
    {
        public FrmAgentCreate()
        {
            InitializeComponent();
        }
        ClsAgent _Agent = new ClsAgent();
        NextGFuntion _Nextg = new NextGFuntion();
        DBTask _Dbtask = new DBTask();
        ClsAccountLedger _Ledger = new ClsAccountLedger();
        public int PostAccount;
        private void cmdsave_Click(object sender, EventArgs e)
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
            if (TxtAgentName.Text == "")
            {
                MessageBox.Show("Please Enter AgentName");
                TxtAgentName.Focus();
                return false;
            }
            return true;
        }
        public void NextgInitialize()
        {
            _Agent.Acode = TxtAgentCode.Text;
            _Agent.Aid =Convert.ToInt64(Txtid.Text);
            _Agent.Aname = TxtAgentName.Text;
            _Agent.Comm =Convert.ToDouble(TxtCommission.Text);

            //_Ledger.IdAccountLedger();
            //_Ledger.LNameStr = TxtAgentName.Text;
            //_Ledger.LAliasNameStr = TxtAgentCode.Text;
            //_Ledger.GidLng = Convert.ToInt64(23);
            //_Ledger.AddressStr = "";
            //_Ledger.PhoneStr = "";
            //_Ledger.MobileStr = "";
            //_Ledger.DiscDb = Convert.ToDouble(0);
            //_Ledger.TaxRegNoStr = "";
            //_Ledger.EmailStr = TxtEmail.Text;

            //_Ledger.AreaStr = TxtArea.Text;
            //_Ledger.CreditDaysInt = Convert.ToInt16(TxtCreditDays.Text);
            //_Ledger.CreditLimitDb = Convert.ToDouble(TxtCreditLimit.Text);
            //_Ledger.OtherStr = TxtOther.Text;
        }

        public void Clear()
        {
            _Nextg.ClearControles(this);
          // TxtCommission.Text= _Dbtask.SetintoDecimalpointStock(0);
           GetVno();
           CommonClass._Nextg.FormIcon(this);
        }

        public void Insert()
        {
           // _Agent.InsertAgent();
        }
        public void GetVno()
        {
           // _Agent.IdAgent();
            Txtid.Text = _Agent.Aid.ToString();
        }

        private void FrmAgentCreate_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkAccountsInclude_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAccountsInclude.Checked == true)
            {
                PostAccount = 1;
            }
            else
            {
                PostAccount = -1;
            }
        }

        private void FrmAgentCreate_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmAgentCreate_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}