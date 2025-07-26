using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Frmcommandwindow : Form
    {
        DBTask _dbtask = new DBTask();
        public  string sql;
        public DataSet Ds;
        string Count;
        ClsParamlist _paramlist = new ClsParamlist();
        NextGFuntion _Nextg = new NextGFuntion();
        Generalfunction _genf = new Generalfunction();
        public Frmcommandwindow()
        {
            InitializeComponent();
        }

        public string Fusettingsvalue(CheckBox Chk)
        {
            if (Chk.Checked == true)
            {
                return "1";
            }
            return "-1";
        }

        private void Frmcommandwindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void cmdexecute_Click(object sender, EventArgs e)
        { 
            sql=Richmain.Text.Replace("\n"," ");
            
          
            /*Check Is Select Query*/
            if (sql.Length > 6)
            {
                if (sql.Substring(0, 6).ToLower() == "select")
                {
                    CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery(sql);
                    Gridmain.DataSource = CommonClass.Ds.Tables[0];
                }
                else
                {
                    _dbtask.ExecuteNonQuery(sql);
                }
            }
            MessageBox.Show("Query executed Successfully", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdcleartransaction_Click(object sender, EventArgs e)
        {
            CommonClass._commenevent.CheckinAdminUser("ClearTransaction",CheckInclude(Chkincludebatch));
        }
        public bool CheckInclude(CheckBox Chk)
        {
            if (Chk.Checked == true)
                return true;
            else
                return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO [Tblmnusettings] "
           +"([Menuid]"
           +",[Menuname]"
           +",[Parentid]"
           +",[Status])"
     +"VALUES"
           +"(119"
           +",'Pexciseduty'"
           +",23"
           +",-1)";
            _dbtask.ExecuteNonQuery(sql);

            sql = "update tblaccountledger set lname='Excise Duty' where lid=10";
            _dbtask.ExecuteNonQuery(sql);

            sql = "ALTER TABLE tblreceiptdetails "
 +" ADD exciseduty decimal(18, 5)";
            _dbtask.ExecuteNonQuery(sql);

            sql="ALTER PROCEDURE [dbo].[InsertReceiptDetails] @RecptCode float, @Slno float, @Pcode nvarchar(50), @Unitid float,"
 +"@BatchId float, @MultirateId float, @Qty decimal(18, 5), @FreeQty decimal(18, 5), @Rate decimal(18, 5), @DiscRate decimal(18, 5),"
 +"@Taxrate decimal(18, 5), @NetAmt decimal(18, 5), @ItemNote float, @srate decimal(18, 5), @crate decimal(18, 5), @Mrp decimal(18, 5),"
 +"@Ledcode nvarchar(50),@Vtype nvarchar(50),@Taxper decimal(18, 5),@Exciseduty decimal(18, 5) AS BEGIN INSERT INTO TblReceiptDetails(RecptCode,Slno,Pcode,Unitid,"
+"BatchId,MultirateId,Qty,FreeQty,Rate,DiscRate,Taxrate,NetAmt,ItemNote,srate,crate,ledcode,Mrp,vtype,Taxper,exciseduty)VALUES(@RecptCode,@Slno,@Pcode,"
+"@Unitid,@BatchId,@MultirateId,@Qty,@FreeQty,@Rate,@DiscRate,@Taxrate,@NetAmt,@ItemNote,@srate,@crate,@Ledcode,@mrp,@Vtype,@Taxper,@Exciseduty) END";
            _dbtask.ExecuteNonQuery(sql);
            MessageBox.Show("Execute Successfully", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            PrintDocument document = new PrintDocument();
            PrintDialog dialog = new PrintDialog();
            dialog.UseEXDialog = true; // or false
            dialog.Document = document;
            try
            {
                dialog.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exporttoexcel(Gridmain);
        }

        public void Exporttoexcel(DataGridView Grid)
        {

            try
            {
                int cols;
                SaveFileDialog theDialog = new SaveFileDialog();
                theDialog.Title = "Save File";
                theDialog.Filter = "Excel File|*.xls";
                theDialog.InitialDirectory = @"C:\";
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    string Filepath = theDialog.FileName;

                    //open file
                    StreamWriter wr = new StreamWriter(Filepath, true, Encoding.Unicode);

                    //determine the number of columns and write columns to file
                    cols = Grid.Columns.Count;
                    wr.Write("" + CommonClass._compMaster.GetspecifField("cname") + "\n\n\n");
                   // wr.Write(DTFrom.ToString("dd-MM-yyyy") + "  To " + DTTo.ToString("dd-MM-yyyy") + " \n\n");

                    //wr.Write(LblHeading.Text + "\n\n");

                    for (int i = 0; i < cols; i++)
                    {
                        wr.Write(Grid.Columns[i].HeaderText.ToString() + "\t");
                    }
                    wr.WriteLine();
                    // write rows to excel file
                    for (int i = 0; i < (Grid.Rows.Count); i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (Grid.Rows[i].Cells[j].Value != null)
                            {
                                Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\n", "");
                                Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\r", "");
                                wr.Write(Grid.Rows[i].Cells[j].Value + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        wr.WriteLine();
                    }
                    wr.Close();
                }
            }
            catch
            {
            }
        }

        private void CmdtoolData_Click(object sender, EventArgs e)
        {
            double StrAmt;
            string Strissuecode;
            Count = CommonClass._Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                   " SYSOBJECTS.NAME = 'tblissuedetails' AND SYSCOLUMNS.NAME = 'Netamtsum'");
            if (Count == "0")
            {
                CommonClass._Dbtask.ExecuteNonQuery("alter table tblissuedetails add Netamtsum decimal(18, 5)");
            }

            Ds = _dbtask.ExecuteQuery("SELECT     TblIssuedetails.IssueCode, SUM(TblIssuedetails.NetAMT) AS 'Amount' " +
" FROM         TblIssuedetails INNER JOIN TblBusinessIssue ON TblIssuedetails.IssueCode = TblBusinessIssue.IssueCode AND TblIssuedetails.Vtype = TblBusinessIssue.IssueType " +
" WHERE     (TblIssuedetails.Vtype = 'SI') GROUP BY TblIssuedetails.IssueCode, TblIssuedetails.Vtype,tblbusinessissue.issuedate " +
" having  tblbusinessissue.issuedate between'" + DtFrom.Value.ToString("MM-dd-yyyy hh:mm tt") + " ' and '" + DtTo.Value.ToString("MM-dd-yyyy hh:mm tt") + "' " +
" ORDER BY TblIssuedetails.IssueCode ");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                StrAmt = CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Amount"]);
                Strissuecode=_dbtask.znllString(Ds.Tables[0].Rows[i]["issuecode"]);
                _dbtask.ExecuteNonQuery("update TblIssuedetails set netamtsum=" + StrAmt + " where issuecode='" + Strissuecode + "' and vtype='SI'");
            }
            Clsselectreport.RType = "Tool Data";
            CommonClass._report.DTFrom = Convert.ToDateTime(DtFrom.Value.ToString("dd/MMM/yyyy hh:mm tt"));
            CommonClass._report.DTTo = Convert.ToDateTime(DtTo.Value.ToString("dd/MMM/yyyy hh:mm tt"));
            Clsselectreport.RDtfrom = CommonClass._report.DTFrom;
            Clsselectreport.Rdtto = CommonClass._report.DTTo;
            CommonClass._Clreport.ShowReport(this, true);

        }
        
        public void Menusettings()
        {
            Chksenableprinterselection.Checked = CommonClass._settings.ReturnStatusBoolenvalue("175");/*Enable Printer in Sales*/
            Chkenablecustomerid.Checked = CommonClass._settings.ReturnStatusBoolenvalue("176");/*Enable Customer Id*/
            Chkenableregistrationdetails.Checked = CommonClass._settings.ReturnStatusBoolenvalue("177");/*Enable Registration Details*/
           chkdeletesales.Checked = CommonClass._settings.ReturnStatusBoolenvalue("178");
          chksaleedit.Checked = CommonClass._settings.ReturnStatusBoolenvalue("179");
          Chkenableencriptqrcode.Checked = CommonClass._settings.ReturnStatusBoolenvalue("180");


         chknickname.Checked = CommonClass._settings.ReturnStatusBoolenvalue("212");
         chkvalidity.Checked = CommonClass._settings.ReturnStatusBoolenvalue("213");

         txtvalidatnfrom.Text = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("validatnfrom"));
         txtvalidtnto.Text = _dbtask.znllString(CommonClass._Paramlist.GetParamvalue("validatnTO"));


        
        }

        private void Frmcommandwindow_Load(object sender, EventArgs e)
        {
            DtFrom.Value =Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 00:00:01"));
            DtTo.Value = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 23:59:59"));
            Menusettings();
            CommonClass._Nextg.FormIcon(this);
        }

        private void Chksenableprinterselection_CheckedChanged(object sender, EventArgs e)
        {
           CommonClass._Menusettings.UpdateMenusettings("175", Fusettingsvalue(Chksenableprinterselection));
        }

        private void Chkenablecustomerid_CheckedChanged(object sender, EventArgs e)
        {
            CommonClass._Menusettings.UpdateMenusettings("176", Fusettingsvalue(Chkenablecustomerid));

        }

        private void Chkenableregistrationdetails_CheckedChanged(object sender, EventArgs e)
        {
            CommonClass._Menusettings.UpdateMenusettings("177", Fusettingsvalue(Chkenableregistrationdetails));

        }

        private void chkdeletesales_CheckedChanged(object sender, EventArgs e)
        {
            CommonClass._Menusettings.UpdateMenusettings("178", Fusettingsvalue(chkdeletesales));
        }

        private void chksaleedit_CheckedChanged(object sender, EventArgs e)
        {
        CommonClass._Menusettings.UpdateMenusettings("179", Fusettingsvalue(chksaleedit));
        }

        private void Chkenableencriptqrcode_CheckedChanged(object sender, EventArgs e)
        {
            CommonClass._Menusettings.UpdateMenusettings("180", Fusettingsvalue(Chkenableencriptqrcode));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmd_set_Vno_Click(object sender, EventArgs e)
        {
            int minvno = 0;
            minvno = 0;
            string ToDB = "";

            string Smallvno = "";
            Smallvno = _dbtask.ExecuteScalar("select min(vno)-1 from tblbusinessissue where issuetype='SI'");

            minvno = Convert.ToInt32(txtSiVno.Text); //CommonClass._Gen.MINvoget("TblBusinessIssue where ISSUEDATE >'" + AA + "' AND issuetype='SI'");
            ToDB = Generalfunction.OpCompany;
            if (minvno > 0)
            {
                minvno = minvno - 1;
                
                    CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "Tblbusinessissue" + " " +
                   " set issuecode = ((vno - " + Smallvno + ")+ " + minvno + " +1  ),vno=((vno - " + Smallvno + ")+ " + minvno + " +1  )    where  Issuetype ='SI'");


                    CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "Tblissuedetails" + " " +
                  " set issuecode = ((issuecode - " + Smallvno + ")+ " + minvno + " +1  )  where  vtype ='SI'");


                    CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "Tblgeneralledger" + " " +
                " set vno = ((vno - " + Smallvno + ")+ " + minvno + " +1)  where  vtype ='SI'");

                    CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "TblINVENTORY" + " " +
                   " set Vcode = ((Vcode - " + Smallvno + ")+ " + minvno + " +1)  where  vtype ='SI'");




                
            }

            string maxvno = "";
            maxvno = _dbtask.ExecuteScalar("select max(vno)+1 from tblbusinessissue where issuetype='SI'");
            string minimumvno = "";
            minimumvno = _dbtask.ExecuteScalar("select min(vno) from tblbusinessissue where issuetype='SI'");



            _paramlist.UPDATEPARAMVALUE("maxofsi", maxvno);

            _paramlist.UPDATEPARAMVALUE("MINofSI", minimumvno);

           // _paramlist.UPDATEPARAMVALUE("maxofpi", _dbtask.znllString(txtPiVno.Text));

            //Close(); 
            Application.Restart();
            Generalfunction.TempCompanyname = "";
            MessageBox.Show("Restore Successfully", _genf.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //lblprogress.Visible = false;
            CommonClass._commenevent.NormalCursor(this);

        }

        private void chknickname_CheckedChanged(object sender, EventArgs e)
        {
            CommonClass._Menusettings.UpdateMenusettings("212", Fusettingsvalue(chknickname));
        }

        private void chkvalidity_CheckedChanged(object sender, EventArgs e)
        {
            CommonClass._Menusettings.UpdateMenusettings("213", Fusettingsvalue(chkvalidity));
        }

        private void cmdsetvali_Click(object sender, EventArgs e)
        {
            _dbtask.ExecuteNonQuery("Update tblparamlist set paramvalue ='" + _dbtask.znllString(txtvalidatnfrom.Text) + "'  where paramname ='validatnfrom'");
            _dbtask.ExecuteNonQuery("Update tblparamlist set paramvalue ='" + _dbtask.znllString(txtvalidtnto.Text) + "'  where paramname ='validatnTO'");
        }

        private void CMDUPDATELASTSRATE_Click(object sender, EventArgs e)
        {
          CommonClass._Batch.updatelastesalerateratezeroitemsFN();
        }

        private void CMDnegetivestockremove_Click(object sender, EventArgs e)
        {
            CommonClass._physical.AutomaticFillBatchNEGETIVE();
        }
        
    }
}
