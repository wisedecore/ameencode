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
    public partial class Frmusermonitore : Form
    {
        public Frmusermonitore()
        {
            InitializeComponent();
        }
        string Systemname;
        string Username;
        string Action;
        string Form;
        string Where;
       // DateTime Dtfrom;
        //DateTime DtTo;
        private void Frmusermonitore_Load(object sender, EventArgs e)
        {

            Clear();
            CommonClass._Nextg.FormIcon(this);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                
                CommonClass._Language.GridHeaderConversion(gridmain);
                CommonClass._Language.PanelBasedConversion(pnlleft);
                CommonClass._Language.PanelBasedConversion(pnlright);
            }
        }
        private void Frmusermonitore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        public void ShowLogindetails()
        {
            CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery("select Mdate as Date,userid 'User',computername as Computer,actiontype1 'Action'" +
                ",mformname as Form,Olddata,Newdata from tblauditlog "+WhereCondition()+"");
            gridmain.DataSource = CommonClass.Ds.Tables[0];

            gridmain.Columns["Date"].Width = 150;
            gridmain.Columns["User"].Width = 150;
            gridmain.Columns["Computer"].Width = 150;
            gridmain.Columns["Action"].Width = 100;
            gridmain.Columns["Form"].Width = 150;
            gridmain.Columns["Olddata"].Width = 300;
            gridmain.Columns["Newdata"].Width = 300;
            gridmain.Columns["Newdata"].DefaultCellStyle.Font = new Font(gridmain.DefaultCellStyle.Font, FontStyle.Bold);
            ChangeLanguage();
        }
        public void Clear()
        {
            FillCombo();
            ChangeLanguage();
        }
        public void FillCombo()
        {
            CommonClass._Dbtask.fillDatainCombowithQuery(comuser, "userid", "username", "tbluserdetails", "select * from tbluserdetails");
            CommonClass._Dbtask.fillDatainCombowithQuery(comsystemname, "computername", "computername", "tblauditlog", "select distinct computername  from tblauditlog");
        }
        public string WhereCondition()
        {
            Where = " where mdate between '" + Dtfrom.Value.ToString("MM/dd/yyyy") + " 00:00:00'  and   '" + dtto.Value.ToString("MM/dd/yyyy") + " 23:59:59'";
            
            if (chkallcomputername.Checked == false)
            {
                Systemname=comsystemname.Text;
                Where = Where + " and computername ='" + Systemname + "'";
            }

            if (chkalluser.Checked == false)
            {
                Username = comuser.Text;
                Where = Where + " and userid ='" + Username + "'";
            }

            if (chkallaction.Checked == false)
            {
                Action = comaction.Text;
                Where = Where + " and actiontype1 ='" + Action + "'";
            }

            if (chkallform.Checked == false)
            {
                Form = comform.Text;
                Where = Where + " and mformname ='" + Form + "'";
            }
            Where = Where + " order by mdate asc";
            return Where;
        }
        private void cmdshow_Click(object sender, EventArgs e)
        {
            ShowLogindetails();
        }

        private void cmdexporttoexcel_Click(object sender, EventArgs e)
        {
            //CommonClass. CommonClass._Clreport.Exporttoexcel(gridmain);
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
