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
    public partial class FrmBaseunit : Form
    {
        public FrmBaseunit()
        {
            InitializeComponent();
        }
        DBTask _DBTask = new DBTask();
        ClsBaseunit _baseuni = new ClsBaseunit();
        public bool Isinotherwindow;

        public long Id;
        public string Unitname;
        public double Count;
        public bool editmode = false;

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
        public void Initialize()
        {
           // _DBTask.ExecuteNonQuery("delete tblbaseunit where id='" + txtId.textBox1.Text + "'");
            string Name = txtUnitName.textBox1.Text;
            txtUnitName.textBox1.Tag = Id;

            _baseuni.Id = Id;
            _baseuni.Name = Name;

            _baseuni.InserBasetUnit();
        }
        public void delete()
        {
            _DBTask.ExecuteNonQuery("delete from tblbaseunit where id='"+Id+"'");
        }
        public void main()
        {
            if (ValidationFu()==true)
            {
                if(editmode==true)
                {
                    delete();
                }
                Initialize();
                Clear();
            }

        }
        public bool ValidationFu()
        {


            if (txtUnitName.textBox1.Text == "")
            {
                MessageBox.Show("Enter baseunit", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitName.textBox1.Focus();
                return false;
            }
          
           
            return true;
        }
        public void GetVno()
        {
            Id = Convert.ToInt64(Generalfunction.getnextid("Id", "tblbaseunit"));
            txtId.textBox1.Text = Id.ToString();
            txtId.textBox1.Text = Id.ToString();
        }
        public void Clear()
        {
            Isinotherwindow = false;
            txtUnitName.textBox1.Text = "";
           
            txtUnitName.textBox1.Focus();
            GetVno();
        }
        public void Retrive(string Vno)
        {
            CommonClass.Ds = _baseuni.LoadUnit(" where id='" + Vno + "'");
            if (CommonClass.Ds.Tables[0].Rows.Count > 0)
            {
                Id = Convert.ToInt64(CommonClass.Ds.Tables[0].Rows[0]["id"].ToString());
                Unitname = CommonClass.Ds.Tables[0].Rows[0]["name"].ToString();
                
                txtId.textBox1.Text = Id.ToString();
                txtUnitName.textBox1.Text = Unitname;
               
            }
        }
        private void FrmBaseunit_Load(object sender, EventArgs e)
        {
            if (Isinotherwindow == false)
            {
                Clear();
            }
            else
            {
                Retrive(Id.ToString());
            }
            CommonClass._Nextg.FormIcon(this);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            main();
        }

        private void txtUnitName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if (e.KeyValue == 13)
            //    main();
        }

        private void txtUnitName_Leave(object sender, EventArgs e)
        
        {
            CommonClass._GenF.CHECKCHARACTER("Name", "tblbaseunit", txtUnitName.textBox1);

            //string sample = txtUnitName.textBox1.Text.ToString();

        }
    }
}
