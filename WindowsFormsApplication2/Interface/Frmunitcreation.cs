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
    public partial class Frmunitcreation : Form
    {
        public Frmunitcreation()
        {
            InitializeComponent();
        }
        DBTask _DBTask = new DBTask();
        ClsUnitcreation _UnitCreation = new ClsUnitcreation();
        public bool Isinotherwindow;

        public long Id;
        public string Unitname;
        public double Count;

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

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                Initialize();
                Clear();
            }
            return true;
        }

        public bool ValidationFu()
        {
            if (_DBTask.znullDouble(Txtcount.textBox1.Text) <= 0)
            {
                MessageBox.Show("Enter Valid Count", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txtcount.textBox1.Focus();
                return false;    
            }
            return true;
        }
        public void Initialize()
        {
            _DBTask.ExecuteNonQuery("delete tblUnitcreation where id='"+txtId.textBox1.Text+"'");
            string Name = txtUnitName.textBox1.Text;
            txtUnitName.textBox1.Tag = Id;

            _UnitCreation.Id = Id;
            _UnitCreation.Name = Name;
            _UnitCreation.Ucount =_DBTask.znullDouble(Txtcount.textBox1.Text);
            _UnitCreation.InsertUnit();
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
            }
        }
        private void Frmunitcreation_Load(object sender, EventArgs e)
        {
            if (Isinotherwindow == false)
            {
                Clear();
            }
            else
            {
                Retrive(Id.ToString());
            }
            ChangeLanguage();

            CommonClass._Nextg.FormIcon(this);
        }

        public void Retrive(string Vno)
        {
            CommonClass.Ds = CommonClass._Unitcreation.LoadUnit(" where id='"+Vno+"'");
            if (CommonClass.Ds.Tables[0].Rows.Count > 0)
            {
                Id =Convert.ToInt64(CommonClass.Ds.Tables[0].Rows[0]["id"].ToString());
                Unitname = CommonClass.Ds.Tables[0].Rows[0]["name"].ToString();
                Count =_DBTask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[0]["ucount"]);
                txtId.textBox1.Text = Id.ToString();
                txtUnitName.textBox1.Text = Unitname;
                Txtcount.textBox1.Text =_DBTask.SetintoDecimalpointStock(Count);
            }
        }

        public void GetVno()
        {
            Id = Convert.ToInt64(Generalfunction.getnextid("Id", "tblUnitcreation"));
            txtId.textBox1.Text = Id.ToString();
            txtId.textBox1.Text= Id.ToString();
        }
        public void Clear()
        {
            Isinotherwindow = false;
            txtUnitName.textBox1.Text = "";
            Txtcount.textBox1.Text = "0";
            txtUnitName.textBox1.Focus();
            GetVno();
        }

        private void Txtcount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
                Main();
        }

        private void Frmunitcreation_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtUnitName_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Name", "tblUnitcreation", txtUnitName.textBox1);

        }

    }
}
