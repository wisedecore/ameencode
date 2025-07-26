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
    public partial class Frmselectproduction : Form
    {
        public Frmselectproduction()
        {
            InitializeComponent();
        }
        FrmReport _Report = new FrmReport();
        DBTask _Dbtask = new DBTask();
        ClsEmployeeMaster _EmployeeMaster = new ClsEmployeeMaster();
        NextGFuntion _Nextg = new NextGFuntion();

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.TreeViewConvertion(TreeMain);
                CommonClass._Language.FormBasedConversion(this);
            }
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }

        public void NextgInitialize()
        {

            _Report.DTFrom = Convert.ToDateTime(Dtfrom.Value);
            _Report.DTTo = Convert.ToDateTime(DtTo.Value);

            if (CommonClass._report.ReportType == "Productionitemstatus")
            {
               
                    if (Chkallemployee.Checked==false)
                    {
                        string EmployeeId = comemployee.SelectedValue.ToString();
                        _Report.Query = "select * from tblissueproduct where employee='" + EmployeeId + "' and ";
                    }
                    else
                    {
                        _Report.Query = "select * from tblissueproduct where  ";
                    }
            }


            if (CommonClass._report.ReportType == "Issuereport")
            {
                if (chkstatus.Checked == false)
                {
                    if (Chkallemployee.Checked == false)
                    {
                        string EmployeeId = comemployee.SelectedValue.ToString();
                        _Report.Query = "select * from tblissueproduct where employee='" + EmployeeId + "' and istatus=-1 and ";
                    }
                    else
                    {
                        _Report.Query = "select * from tblissueproduct where istatus=-1 and ";
                    }
                }
                else
                {

                    if (Chkallemployee.Checked == false)
                    {
                        string EmployeeId = comemployee.SelectedValue.ToString();
                        _Report.Query = "select * from tblissueproduct where employee='" + EmployeeId + "' and ";
                    }
                    else
                    {
                        _Report.Query = "select * from tblissueproduct where  ";
                    }
                }
            }

            if (CommonClass._report.ReportType == "Receivedreport")
            {
                if (Chkallemployee.Checked == false)
                {
                    string EmployeeId = comemployee.SelectedValue.ToString();
                    _Report.Query = "select *  from tblreceivedproduct ";
                }
                else
                {
                    _Report.Query = "select * from tblreceivedproduct ";
                }
            }

            // if (FrmReport.ReportType == "Issuereport")
            //{
            //    if (comemployee.SelectedValue != null)
            //    {
            //        string EmployeeId = comemployee.SelectedValue.ToString();
            //        FrmReport.Query = "select * from tblissueproduct where employee='" + EmployeeId + "' and status=-1 ";
            //    }
            //    else
            //    {
            //        FrmReport.QueryTemp = "select * from tblissueproduct where status=-1 ";
            //    }
            //}



        }

        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    // NextgInitialize();
                    ShowReport();

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
        public void ShowReport()
        {
            if (_Report.IsDisposed == true)
            {
                _Report = new FrmReport();
                NextgInitialize();
                _Report.Show();
            }
            else
            {

                NextgInitialize();
                _Report.Show();
            }

        }
        private bool ValidationFu()
        {
            return true;
        }
        public void TreeviewSelect()
        {
            if (TreeMain.SelectedNode.Name.ToString() == "Ndissuereport")
            {
                CommonClass._report.ReportType = "Issuereport";
                chkstatus.Visible = true;
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndreceived")
            {
                CommonClass._report.ReportType = "Receivedreport";
                chkstatus.Visible = false;
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Nditemstatus")
            {
                CommonClass._report.ReportType = "Productionitemstatus";
            }

        }
        private void TreeMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeviewSelect();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmselectproduction_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void Frmselectproduction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void Chkallemployee_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkallemployee.Checked == true)
            {
                comemployee.Enabled = false;
            }
            else
            {
                comemployee.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Clear()
        {
            TreeMain.SelectedNode = TreeMain.Nodes[0];
            Fillcombo();
        }
        public void Fillcombo()
        {
            _EmployeeMaster.FillCombo(comemployee);
            if (comemployee.Items.Count > 0)
            {
                comemployee.SelectedIndex = 0;
            }
        }
        private void Frmselectproduction_Load(object sender, EventArgs e)
        {
            Clear();
            _Nextg.FormStylesett(this);
           // _Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
            //_Nextg.FormHeadStyle(pnlHead);
            //_Nextg.FormImage(pnlImage);
            ChangeLanguage();
        }

    }
}
