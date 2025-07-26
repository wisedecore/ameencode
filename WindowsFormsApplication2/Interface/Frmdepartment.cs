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
    public partial class Frmdepartment : Form
    {
        public Frmdepartment()
        {
            InitializeComponent();
        }
        ClsDepartment _Department = new ClsDepartment();
        public void Clear()
        {
            GetVno();
            TxtGroupName.Text = "";
            CommonClass._Nextg.FormIcon(this);
        }
        public void GetVno()
        {
            _Department.IdDepartment();
            TxtId.Text = Convert.ToString(_Department.DepId);
        }
        public void Insert()
        {
            _Department.InsertDepartment();
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
            if (TxtGroupName.Text == "")
            {
                MessageBox.Show("Please Type GroupName");
                TxtGroupName.Focus();
                return false;
            }
            return true;
        }
        public void NextgInitialize()
        {
            _Department.DepId =Convert.ToInt64(TxtId.Text);
            _Department.DepName = TxtGroupName.Text;
        }

        private void Frmdepartment_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Frmdepartment_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtGroupName_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Depname", "tbldepartment", TxtGroupName);

        }

      
    }
}
