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
    public partial class Frmitemgroup : Form
    {
        public Frmitemgroup()
        {
            InitializeComponent();
        }
        DBTask _Dbtask = new DBTask();
        Generalfunction _Gen = new Generalfunction();
        clsitemCategory _ItemCategory = new clsitemCategory();
        DataSet Ds = new DataSet();
        public string showinsummery = "No";
        public string ontable = "No";
        public bool Isinotherwindow = false;
        public bool EditMode = false;
       public string Id;
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
        private void Frmitemgroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        public void Retrive()
        {
            string ds = _Dbtask.ExecuteScalarAzureServer("select * from tblitemcategory where categoryid='" + Id + "'");

            if (ds != "")
            {
                Ds = _Dbtask.ExecuteQueryAzureServer("select * from tblitemcategory where categoryid='" + Id + "'");
            }
            else
            {


                Ds = _Dbtask.ExecuteQuery("select * from tblitemcategory where categoryid='" + Id + "'");
            }

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                TxtId.Text = Id;
                TxtGroupname.textBox1.Text = Ds.Tables[0].Rows[0]["category"].ToString();
                TxtRemark.textBox1.Text = Ds.Tables[0].Rows[0]["remarks"].ToString();
                showinsummery = _Dbtask.znllString(Ds.Tables[0].Rows[0]["showinsummery"]);
                
                if (showinsummery == "No" || showinsummery == "")
                {
                    Chkshowinsummery.Checked = false;
                }
                else
                {
                    Chkshowinsummery.Checked = true;
                }

                


            
            }
        }
        public void DeleteGroup()
        {
            _Dbtask.ExecuteNonQuery("Delete from tblitemcategory where categoryid='" + TxtId.Text + "'");
           
        }
        public void DeleteGroupAzure()
        {
            _Dbtask.ExecuteNonQueryAzureServer("Delete from tblitemcategory where categoryid='" + TxtId.Text + "'");

        }
        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            try
            {
                TxtId.Text = Generalfunction.getnextid("CategoryId", "Tblitemcategory");
                TxtGroupname.textBox1.Text = "";
                TxtRemark.textBox1.Text = "";
                EditMode = false;
                Isinotherwindow = false;
                TxtGroupname.Focus();
            }
            catch
            {
            }
        }
        public void Insert()
        {
            _ItemCategory.InsertItemCategory();
            _ItemCategory.InsertItemCategoryAzure();
        }

        private void Frmitemgroup_Load(object sender, EventArgs e)
        {
          CommonClass._Nextg.FormStylesett(this);
          CommonClass._Nextg.ClearControles(this);
          if (EditMode == false)
          {
              Clear();
          }
          else
          {
              Retrive();
          }
            TxtGroupname.textBox1.Focus();

            CommonClass._Nextg.FormIcon(this);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteGroup();
                        DeleteGroupAzure();
                    }
                    NextgInitialize();
                    Insert();
                    Clear();
                    TxtGroupname.Focus();
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

        public bool ValidationFu()
        {

            if (TxtGroupname.textBox1.Text.ToString() != "")
            {
                if (CommonClass._GenF.splcharacter(TxtGroupname.textBox1.Text.ToString()) == true)
                {
                    MessageBox.Show("Splecial characters are not allowed ", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtGroupname.textBox1.Focus();
                    return false;
                }
            }

            if (TxtGroupname.textBox1.Text == "")
            {
                MessageBox.Show("Please Enter the Groupe Name", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtGroupname.textBox1.Focus();
                return false;
            }
            string GgroupName = _Dbtask.ExecuteScalar("select Category from tblitemcategory where category=N'" + TxtGroupname.textBox1.Text.ToString() + "'").ToString();
            if (GgroupName != "")//&&EditMode==false
            {
                MessageBox.Show("Group Name Is Already Exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtGroupname.textBox1.Focus();
                return false;
            }
        
            return true;
        }
        public void NextgInitialize()
        {
            _ItemCategory.CategoryIdLng = Convert.ToInt64(TxtId.Text);
            _ItemCategory.CategoryNameStr = TxtGroupname.textBox1.Text;
            _ItemCategory.RemarkStr = TxtRemark.textBox1.Text;
            _ItemCategory.showinsummery = showinsummery;
            _ItemCategory.ontable = ontable;

        }

        private void TxtRemark_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Main();
            }
        }

        private void TxtGroupname_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Category", "tblitemcategory", TxtGroupname.textBox1);

            TxtRemark.textBox1.Text = TxtGroupname.textBox1.Text;
        }

        private void Frmitemgroup_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Frmitemgroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void TxtRemark_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Remarks", "tblitemcategory", TxtRemark.textBox1);

        }

        private void Chkshowinsummery_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkshowinsummery.Checked==false)
             {
                showinsummery = "No";
             }
           else
            {
                showinsummery = "Yes";
            }
        }

        private void chkontable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkontable.Checked == false)
            {
               ontable = "No";
            }
            else
            {
                ontable = "Yes";
            }
        }
       
    }
}
