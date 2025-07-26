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
    public partial class FrmTools : Form
    {
        public FrmTools()
        {
            InitializeComponent();
        }
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        ClsBusinessIssue _Businessissue = new ClsBusinessIssue();
        DBTask _dbtask = new DBTask();
        DataSet Ds;
        DataSet Ds1;

        string Stbcode;
        string Temp;
        string SelectType;
        string SelectAccount;
        int Count;
        private void cmdsave_Click(object sender, EventArgs e)
        {
           
            string Startingindex=txtstartingindex.Text;
            Ds = _dbtask.ExecuteQuery("select * from tblbusinessissue order by cast(vno as float) asc");
            for(int i=0;i<Ds.Tables[0].Rows.Count;i++)
            {
                Startingindex = (Convert.ToInt16(Startingindex) + 1).ToString();

                string Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                string Pvno = Ds.Tables[0].Rows[i]["pvno"].ToString();
                
                string IssueCode = _dbtask.ExecuteScalar("select distinct issuecode from tblbusinessissue where vno='"+Vno+"'");
                _dbtask.ExecuteNonQuery(" update tblgeneralledger set vno='" + Startingindex + "' where vtype='SI' and vno='" + Vno + "' and Refno='2' ");
                _dbtask.ExecuteNonQuery(" update tblbusinessissue set vno='" + Startingindex + "',pvno='' where issuecode='" + IssueCode + "' and vno='" + Vno + "' and pvno='"+Pvno+"' and issuetype='SI' and Ledcodecr='2'");
            }
            MessageBox.Show("Completd", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmTools_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmdupdate_Click(object sender, EventArgs e)
        {
            UpdateDefaultTax();
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                //CommonClass._Language.PanelBasedConversion(panel1);
                //CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.GridHeaderConversion(gridmain);
                CommonClass._Language.GroupBoxConvertion(grpreindexing);
                CommonClass._Language.GroupBoxConvertion(GrpTaxsettings);
            }
        }
        private void FrmTools_Load(object sender, EventArgs e)
        {
            CommonClass._ItemCategory.FillCombo(comcategory, false);
            Chkallcategory.Visible = true;
            Chkallcategory.Checked = true;
            ChangeLanguage();
        }

        public void UpdateDefaultTax()
        {
            double Old;
            double NewValue;
            if (txtexstingvat.Text != "" && txtupdatevat.Text != "")
            {
                Old = _dbtask.znullDouble(txtexstingvat.Text);
                NewValue = _dbtask.znullDouble(txtupdatevat.Text);
                CommonClass._Item.ExNonQuery("update tblitemmaster set vat ='" + NewValue + "' where vat='" + Old + "'");
                MessageBox.Show("Update");
            }

            if (txtexstingcst.Text != "" && txtupdatecst.Text != "")
            {
                Old = _dbtask.znullDouble(txtexstingcst.Text);
                NewValue = _dbtask.znullDouble(txtupdatecst.Text);
                CommonClass._Item.ExNonQuery("update tblitemmaster set cst ='" + Old + "' where cst='" + NewValue + "'");
            }

            if (txtexstingptax.Text != "" && txtupdateptax.Text != "")
            {
                Old = _dbtask.znullDouble(txtexstingptax.Text);
                NewValue = _dbtask.znullDouble(txtupdateptax.Text);
                CommonClass._Item.ExNonQuery("update tblitemmaster set purtax ='" + Old + "' where purtax='" + NewValue + "'");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ds = _dbtask.ExecuteQuery("select * from tblitemmaster");
            for(int i=0;i<Ds.Tables[0].Rows.Count;i++)
            {
                string Itemcode = Ds.Tables[0].Rows[i]["itemcode"].ToString();
                string Itemname = Ds.Tables[0].Rows[i]["itemname"].ToString();
                string Itemid=Ds.Tables[0].Rows[i]["itemid"].ToString();
                Ds1 = _dbtask.ExecuteQuery("select * from tblitemmaster where itemcode='" + Itemcode + "'");

                if (Ds1.Tables[0].Rows.Count > 1)
                {
                    _dbtask.ExecuteNonQuery("update tblitemmaster set itemcode='" + Itemcode + "1' , itemname='" + Itemname + "1' where itemid='" + Itemid + "'");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridmain.Columns.Clear();
            Ds=CommonClass._Dbtask.ExecuteQuery("select bcode,itemid from tblbatch where bcode in( "+
                " select bcode from tblbatch group by bcode having count(bcode)>1) order by bcode asc" );

             gridmain.Columns.Add("clnitemid","itemid");
             gridmain.Columns.Add("clnitem","Item");
             gridmain.Columns.Add("clnbcode","Bcode");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                string Bcode;
                string Itemid;
                
                Bcode = Ds.Tables[0].Rows[i]["bcode"].ToString();
                Itemid= Ds.Tables[0].Rows[i]["itemid"].ToString();

                if (Bcode == "7616100527212")
                {
                
                }

                Ds1 = _dbtask.ExecuteQuery("select * from tblbatch where itemid !='"+Itemid+"' and bcode= '"+Bcode+"'");

                if (Ds1.Tables[0].Rows.Count > 0)
                {
                    Count = gridmain.Rows.Add(1);
                    gridmain.Rows[Count].Cells["clnitemid"].Value = Itemid;
                    gridmain.Rows[Count].Cells["clnitem"].Value = CommonClass._Itemmaster.SpecificField(Itemid, "itemname");
                    gridmain.Rows[Count].Cells["clnbcode"].Value = Bcode;

                    if (ChkdeleteMultibarcode.Checked == true && Stbcode != Bcode)
                    {
                        Stbcode = Bcode;
                        _dbtask.ExecuteNonQuery("delete from tblbatch where itemid !='" + Itemid + "' and bcode= '" + Bcode + "'");
                    }

                }

            }
        }

        private void cmdupdatenew_Click(object sender, EventArgs e)
        {
            CommonClass._Paramlist.UpdateParamlist("MaxBcode", "", txtupdatebarcode.Text);
            MessageBox.Show("Update success");
        }

        private void cmdremovenottax_Click(object sender, EventArgs e)
        {
            try
            {
                _dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where taxid=0");
                _dbtask.ExecuteNonQuery("delete from tblreceiptdetails where Taxrate=0");

                _dbtask.ExecuteNonQuery("delete from tblbusinessissue where taxid=0");
                _dbtask.ExecuteNonQuery("delete from tblissuedetails where Taxrate=0");

                Ds = _dbtask.ExecuteQuery("select * from tbltransactionreceipt where taxid=0");

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Temp = Ds.Tables[0].Rows[i]["vno"].ToString();
                    _dbtask.ExecuteNonQuery("delete from tblinventory where ledcode=3 and vno='" + Temp + "' and purchase !=0");
                    _dbtask.ExecuteNonQuery("delete from tblgeneralledger where ledcode=3 and vno='" + Temp + "' and vtype='PI'");
                }
                _dbtask.ExecuteNonQuery("delete from tblinventory where ledcode=31");
                _dbtask.ExecuteNonQuery("delete from tblgeneralledger where ledcode=31");
                _dbtask.ExecuteNonQuery("update   tblparamlist set paramvalue=1 where paramname='SDelete'");

                MessageBox.Show("Completed");
            }
            catch
            {
            }
        }

        private void Cmdupdatesrateperc_Click(object sender, EventArgs e)
        {
            string Bcode;
            string Itemid;
            string Prate;
            string Srate;
            double Neprate;
            double Percprofit;

            Percprofit = _dbtask.znullDouble(Txtupdatesalerateperc.Text);
            if (Chkallcategory.Checked == false)
            {
                Ds = _dbtask.ExecuteQuery("select * from tblbatch where itemid in (select itemid from tblitemmaster where categoryid="+comcategory.SelectedValue+")");
            }
            else
            {
                Ds = _dbtask.ExecuteQuery("select * from tblbatch");
            }
                for(int i=0;i<Ds.Tables[0].Rows.Count;i++)
                {
                    Bcode =_dbtask.znllString(Ds.Tables[0].Rows[i]["Bcode"]);
                    Itemid = _dbtask.znllString(Ds.Tables[0].Rows[i]["itemid"]);
                    Prate = _dbtask.znllString(Ds.Tables[0].Rows[i]["prate"]);
                    Srate = _dbtask.znllString(Ds.Tables[0].Rows[i]["srate"]);
                    Srate =Convert.ToString (_dbtask.znullDouble( Prate) * Percprofit / 100);
                    Neprate = _dbtask.znullDouble(Prate) + _dbtask.znullDouble(Srate);
                    _dbtask.ExecuteScalar("update tblbatch set srate=" + Neprate + " where itemid='" + Itemid + "' and bcode='" + Bcode + "'");
                }
                MessageBox.Show("Successful");
        }

        private void Chkallcategory_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkallcategory.Checked == true)
            {
                comcategory.Enabled = false;
            }
            else
            {
                comcategory.Enabled = true;
            }
        }

        private void CMDdeletetable_Click(object sender, EventArgs e)
        {
            _dbtask.ExecuteNonQuery("DROP TABLE TblTransferDetails ");
            _dbtask.ExecuteNonQuery("DROP PROCEDURE dbo.InsertTransferDetails ");
            MessageBox.Show("Completed. ");
            this.Close();
            Application.Exit();
        }

        private void CMDdoubleentry_Click(object sender, EventArgs e)
        {

            DataSet ddb; int nowmxvno = 0; DataSet dis; string oldvno = "";
            ddb = _dbtask.ExecuteQuery("SELECT vno, COUNT(vno) FROM tblbusinessissue " +
              " GROUP BY vno HAVING COUNT(vno) > 1 order by cast (vno as int ) desc");
            nowmxvno =Convert.ToInt32( _dbtask.ExecuteScalar("select max( cast (vno as int )) from tblbusinessissue where issuetype='si'"));
            
            if (ddb.Tables[0].Rows.Count>0)
            {
            
            for (int i = 0; i < ddb.Tables[0].Rows.Count; i++)
            {

                dis = _dbtask.ExecuteQuery("");

            }
            }




        }
        


    }
}
