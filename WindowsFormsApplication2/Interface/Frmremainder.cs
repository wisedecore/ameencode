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
    public partial class Frmremainder : Form
    {
        public Frmremainder()
        {
            InitializeComponent();
        }

        public bool EditMode;
        public long Rid;
        public string Rheading;
        public DateTime RDate;
        public int RActive;
        public string Rsubject;
        public bool Fillform;

        DataSet Ds;
        public void FuActive(string Value)
        {
            if (Value == "")
            {
                if (chkactive.Checked == true)
                    RActive = 1;
                else
                    RActive = -1;
            }
            else
            {
                if (Value == "1")
                    chkactive.Checked = true;
                else
                    chkactive.Checked = false;
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        public void Clear()
        {
            EditMode = false;
            GetId();
            Txtremandername.textBox1.Text = "";
            Txtremaindersubject.textBox1.Text = "";
            Dtremainder.Value = DateTime.Now;
            Txtremaindersubject.textBox1.Focus();
        }

        public void GetId()
        {
            txtid.textBox1.Text = CommonClass._Remainder.Getid();
        }

        public void Delete()
        {
        CommonClass._Dbtask.ExecuteNonQuery("delete from tblremainder where rid='"+txtid.textBox1.Text+"'");
        }

        private bool Main()
        {

            if (ValidationFu())
            {
                try
                {
                    if (EditMode == false)
                        GetId();

                    if (EditMode == true)
                    {
                        Delete();
                    }
                    NextgInitialize();
                    Insert();
                    Clear();
                    return true;
                }
                catch
                {
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
            CommonClass._Remainder.InsertRemainder();
        }

        public void NextgInitialize()
        {
            Rid=Convert.ToInt64(txtid.textBox1.Text);
            Rheading = Txtremandername.textBox1.Text;
            Rsubject = Txtremaindersubject.textBox1.Text;
            RDate = Dtremainder.Value;
            FuActive("");
            CommonClass._Remainder.LngRId = Rid;
            CommonClass._Remainder.StrRName = Rheading;
            CommonClass._Remainder.StrRsubject = Rsubject;
            CommonClass._Remainder.Dtrdate = RDate;
            CommonClass._Remainder.Rstatus = RActive;

        }

        private bool ValidationFu()
        {
            if (Txtremandername.textBox1.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Enter Remainder Heading", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txtremandername.textBox1.Focus();
                return false;
            }

            if (Dtremainder.Value<DateTime.Now)
            {
                MessageBox.Show("Invalid Remainder Date", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dtremainder.Focus();
                return false;
            }

            return true;
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                //CommonClass._Language.GridHeaderConversion(gridmain);
                //CommonClass._Language.PanelBasedConversion(pnltotal);
                //CommonClass._Language.PanelBasedConversion(Pnlbottom);
            }
        }
        private void Frmremainder_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            if (Fillform == false)
                Clear();
            else
                GetPre();


            CommonClass._Nextg.FormIcon(this);
        }

        public void GetPre()
        {
            Ds=CommonClass._Remainder.ShowRemainder(" where rid='"+Rid+"' ");
            EditMode = true;
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Rheading = Ds.Tables[0].Rows[0]["rname"].ToString();
                Dtremainder.Value =Convert.ToDateTime(Ds.Tables[0].Rows[0]["rdate"].ToString());
                Rsubject = Ds.Tables[0].Rows[0]["rsubject"].ToString();
                FuActive(Ds.Tables[0].Rows[0]["rstatus"].ToString());

                Txtremandername.textBox1.Text = Rheading;
                Dtremainder.Value = Dtremainder.Value;
                Txtremaindersubject.textBox1.Text = Rsubject;
                txtid.textBox1.Text = Rid.ToString();
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
