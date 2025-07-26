using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace WindowsFormsApplication2
{
    public partial class Frmmessege : Form
    {
        public Frmmessege()
        {
            InitializeComponent();
        }
        public bool SearchArea;
        public bool FillLedgers;
        public bool FillContacts;
        WebClient client = new WebClient();
        DBTask _Dbtask = new DBTask();
        Frmwebbrowser _WebBrowser = new Frmwebbrowser();
        NextGFuntion _Nextg = new NextGFuntion();
        ClsAccountLedger _Ledger = new ClsAccountLedger();
        ClsAccountGroup _AccountGroup = new ClsAccountGroup();
        ClsParamlist _Pramlist = new ClsParamlist();

        
        public string LoginUserName = "Mouscore";
        public string LoginPwd = "zatadmin";
        public string FilePath;

        public bool BulkSms;
        public string MobileNo;
        public string LName;
        public string Lid;
        public string Balance;
        public string Subject;
        public string Areain;
        public string Groupin;
        public string Groupid;
        public string SubjectOption="Subject";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        

        private void Frmmessege_Load(object sender, EventArgs e)
        {
             Clear();
            //_Nextg.FormStylesett(this);
            //_Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlBottom);
            //_Nextg.FormHeadStyle(pnlHead);
            //_Nextg.FormImage(pnlImage);
        }

        public void SmsSendingRefresh()
        {
            lblsmspending.Text ="SMS Balance = "+ _Pramlist.GetParamvalue("SB");
        }
        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }
        private bool ValidationFu()
        {
          
            if (radsubject.Checked == true && richsubject.Text=="")
            {
                MessageBox.Show("Enter Subject", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richsubject.Focus();
                return false;
            }
            string SmsBalance = _Pramlist.GetParamvalue("SB");
            if (Convert.ToDouble(SmsBalance) == 0)
            {
                MessageBox.Show("Your SMS Package Not Activated please Contact Our Support Team", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void FillGroup()
        {
            GridAccountgroup.Rows.Clear();
            CommonClass.Ds = _AccountGroup.DsShowSupplierAndCustomerAccount("");
            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                GridAccountgroup.Rows.Add(1);
                string GroupName = CommonClass.Ds.Tables[0].Rows[i]["agroupname"].ToString();
                string Groupid = CommonClass.Ds.Tables[0].Rows[i]["agroupid"].ToString();
                GridAccountgroup.Rows[i].Cells[1].Value = GroupName;
                GridAccountgroup.Rows[i].Cells[1].Tag = Groupid;
            }
        }
        public void FillArea()
        {
            Gridarea.Rows.Clear();
            CommonClass.Ds = null;
            if(FillLedgers==true)
            CommonClass.Ds = _Ledger.ShowSpecifcFiled("area"," where area !='' group by area");
            if (FillContacts == true)
                CommonClass.Ds = CommonClass._tempcontacts.ShowSpecifcFiled("area", "");
            if (CommonClass.Ds != null)
            {
                for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
                {
                    Gridarea.Rows.Add(1);
                    Areain = CommonClass.Ds.Tables[0].Rows[i]["area"].ToString();
                    Gridarea.Rows[i].Cells[1].Value = Areain;
                    Gridarea.Rows[i].Cells[1].Tag = Areain;
                }
            }
        }
        public void ShowContacts(string where)
        {
            if (FillContacts == true)
            {
                gridmain.Rows.Clear();
                CommonClass.Ds = CommonClass._tempcontacts.ShowContactList(where);
                for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
                {
                    CommonClass.RowCount = gridmain.Rows.Add(1);
                    string Lid = CommonClass.Ds.Tables[0].Rows[i]["slno"].ToString();
                    string Lname = CommonClass.Ds.Tables[0].Rows[i]["name"].ToString();
                    string Mobile = CommonClass.Ds.Tables[0].Rows[i]["mobile"].ToString();
                    double Balance = _Ledger.Balanceofledger(Lid);
                    gridmain.Rows[i].Cells["clnledname"].Value = Lname;
                    gridmain.Rows[i].Cells["clnledname"].Tag = Lid;
                    gridmain.Rows[i].Cells["clnmobile"].Value = Mobile;
                   // gridmain.Rows[i].Cells["clnbalance"].Value = _Dbtask.SetintoDecimalpoint(Balance);
                }
            }
        }

        public void ShowCustomer(string where)
        {
            if (FillLedgers == true)
            {
                gridmain.Rows.Clear();
                CommonClass.Ds = _Ledger.ShowLedger(where);
                for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
                {
                    CommonClass.RowCount = gridmain.Rows.Add(1);
                    string Lid = CommonClass.Ds.Tables[0].Rows[i]["lid"].ToString();
                    string Lname = CommonClass.Ds.Tables[0].Rows[i]["lname"].ToString();
                    string Mobile = CommonClass.Ds.Tables[0].Rows[i]["mobile"].ToString();
                    double Balance = _Ledger.Balanceofledger(Lid);
                    gridmain.Rows[i].Cells["clnledname"].Value = Lname;
                    gridmain.Rows[i].Cells["clnledname"].Tag = Lid;
                    gridmain.Rows[i].Cells["clnmobile"].Value = Mobile;
                    gridmain.Rows[i].Cells["clnbalance"].Value = _Dbtask.SetintoDecimalpoint(Balance);
                }
            }
        }
        public bool GetBalanceOfSms()
        {
            string BalanceSms = _Pramlist.GetParamvalue("SB");
            if (Convert.ToDouble(BalanceSms) > 0)
                return true;
            return false;
        }
        public void Clear()
        {
            CommonClass.temp =_AccountGroup.ShowSupplierAndCustomerAccount("");
            ShowCustomer(" where agroupid in(" + CommonClass.temp + ")");
            FillArea();
            FillGroup();
            richsubject.Text = "";
            radsinglesms.Checked = true;
            FillLedgers = true;
            SmsSendingRefresh();
        }
        public void Main()
        {
            if (ValidationFu())
            {
                //this.webBrowser1.Refresh();
                //FilePath = "http://www.mouscore.com";
              
               // this.webBrowser1.Url = new System.Uri("http://" + FilePath, System.UriKind.Absolute);
                // txturl.Text = "http://" + FilePath;
                //this.webBrowser1.Refresh();
                SendSms();
            }
        }
        public string FindingSubject(string Lname,string Balance)
        {
            if (SubjectOption == "Subject")
                CommonClass.temp = richsubject.Text;
            else
                CommonClass.temp = richsubject.Text + Balance;

            return CommonClass.temp;
        }
        public void CallSend()
        {
            if (GetBalanceOfSms())
            {
               // Frmwebbrowser.Filepath = FilePath;
                //_WebBrowser.ShowDialog();
             //this.webBrowser1.Refresh();
                //this.webBrowser1.Url = new System.Uri("http://" + FilePath, System.UriKind.Absolute);
                //client.OpenRead("http://" + FilePath);

                Stream data = client.OpenRead("http://" + FilePath);
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();
                data.Close();
                reader.Close();
                //return (s);
                // txturl.Text = "http://" + FilePath;
               // this.webBrowser1.Refresh();
                string PendingSMS = _Pramlist.GetParamvalue("SB");
              _Pramlist.UpdateParamlist("SB", "-1", (Convert.ToInt64(PendingSMS) - 1).ToString());
            }
        }

        public void SendBulkSms()
        {
            if (BulkSms == true)
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells[0].Value != null)
                        if (gridmain.Rows[i].Cells[0].Value.ToString()=="True")
                        {
                            MobileNo = gridmain.Rows[i].Cells["clnmobile"].Value.ToString();
                            LName = gridmain.Rows[i].Cells["clnledname"].Value.ToString();
                            Balance = _Dbtask.znllString(gridmain.Rows[i].Cells["clnbalance"].Value);
                            Subject = FindingSubject(LName, Balance);
                            FilePath = "sapteleservices.in/SMS_API/sendsms.php?username="+LoginUserName+"&password="+LoginPwd+"&mobile=" + MobileNo + "&sendername=UPDATE&message=" + Subject + "&routetype=0";
                            CallSend();
                        }
                }
                MessageBox.Show("Messege Send Successfully", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SendSingleSms()
        {
            MobileNo = txtsinglesmsmobile.Text;
            LName = _Dbtask.ExecuteScalar("select lname from  tblaccountledger  where mobile ='" + MobileNo + "'");
            Lid = _Dbtask.ExecuteScalar("select lid from  tblaccountledger  where mobile ='" + MobileNo + "'");
            Balance = (_Ledger.Balanceofledger(Lid)).ToString();
            Subject = FindingSubject(LName, Balance);
            FilePath = "sapteleservices.in/SMS_API/sendsms.php?username="+LoginUserName+"&password="+LoginPwd+"&mobile=" + MobileNo + "&sendername=UPDATE&message=" + Subject + "&routetype=0";
            CallSend();
            MessageBox.Show("Messege Send Successfully", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SendSms()
        {
            CommonClass._commenevent.WaitCursor(this);
            if (BulkSms == true)
                SendBulkSms();
            else
                SendSingleSms();
            SmsSendingRefresh();
            CommonClass._commenevent.NormalCursor(this);
        }

        private void radbulksms_CheckedChanged(object sender, EventArgs e)
        {
            if (radbulksms.Checked == true)
            {
                BulkSms = true;
                txtsinglesmsmobile.Enabled = false;
                txtsearch.Enabled = true;
            }
        }

        private void radsinglesms_CheckedChanged(object sender, EventArgs e)
        {
            if (radsinglesms.Checked == true)
            {
                BulkSms = false;
                txtsinglesmsmobile.Enabled = true;
                txtsearch.Enabled = false;
                radsubject.Checked = true;
            }
        }
        public void Search()
        {
            try
            {
                //if (radall.Checked == true)
                //    CommonClass.temp = _AccountGroup.ShowSupplierAndCustomerAccount("");
                //if (radcustomer.Checked == true)
                //    CommonClass.temp = _AccountGroup.ShowCustomerAccount("");
                //if (radsupplier.Checked == true)
                //    CommonClass.temp = _AccountGroup.ShowSupplierAccount("");

                if (FillLedgers== true)
                {
                    CommonClass.temp = CommonClass._SelectReport.ShowSelectedinGrid(GridAccountgroup, false);/*For Group Binding*/
                    CommonClass.Sql = " where  agroupid in(" + CommonClass.temp + ")";
                    CommonClass.temp = txtsearch.Text;

                    CommonClass.Sql = CommonClass.Sql + " and lname like'%" + CommonClass.temp + "%'";
                    if (SearchArea == true)
                    {
                        Areain = CommonClass._SelectReport.ShowSelectedinGrid(Gridarea, true);
                        if (Areain.Length > 0)
                            CommonClass.Sql = CommonClass.Sql + "and area in (" + Areain + ")";
                    }
                    ShowCustomer(CommonClass.Sql);
                }
                if (FillContacts == true)
                {
                    CommonClass.Sql = "";
                    if (SearchArea == true)
                    {
                        Areain = CommonClass._SelectReport.ShowSelectedinGrid(Gridarea, true);
                        if (Areain.Length > 0)
                            CommonClass.Sql =" where  area in (" + Areain + ")";
                    }
                    ShowContacts(CommonClass.Sql);
                }
            }
            catch
            {
            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void radsubject_CheckedChanged(object sender, EventArgs e)
        {
            if (radsubject.Checked == true)
                SubjectOption = "Subject";
        }

        private void radaccountbalance_CheckedChanged(object sender, EventArgs e)
        {
            if (radaccountbalance.Checked == true)
                SubjectOption = "AccountBalance";
        }

        private void chksearcharea_CheckedChanged(object sender, EventArgs e)
        {
            if(chksearcharea.Checked==true)
            {
            SearchArea=true;
            Gridarea.Enabled=true;
            }
            else
            {
            SearchArea=false;
            Gridarea.Enabled=true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void cmdfillarea_Click(object sender, EventArgs e)
        {
            FillArea();
        }

        private void radfillledgers_CheckedChanged(object sender, EventArgs e)
        {
            if (radfillledgers.Checked == true)
                FillLedgers = true;
            else
                FillLedgers = false;
        }

        private void radfillcontacts_CheckedChanged(object sender, EventArgs e)
        {
            if (radfillcontacts.Checked == true)
                FillContacts = true;
            else
                FillContacts = false;
        }

    }
}
