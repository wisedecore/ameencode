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
    public partial class Frmlabelprinting : Form
    {
        public Frmlabelprinting()
        {
            InitializeComponent();
        }
        DataSet Ds;
        private void cmdprint_Click(object sender, EventArgs e)
        {

            Mainprint();
           
        }

        public void Mainprint()
        {
            if (pnlprintsettings.Visible == false)
            {
                pnlprintsettings.Visible = true;
                CommonClass._Gen.FillActivePrinter(comprint);
            }
            else
            {
                pnlprintsettings.Visible = false;
            }
        }

        public void SettSettings()
        {
        
        }
        public void Main()
        {
            BarcodeSettings();
            this.barCodeCtrl1.RupeeImgaeFu = Picrupee.BackgroundImage;
            this.barCodeCtrl1.StrDate = DateTime.Now.ToString("dd/MM/yy");
            this.barCodeCtrl1.IfInnextpage = false;
            this.barCodeCtrl1.SRows = 0;
            this.barCodeCtrl1.CurrentRecord = 0;
            this.barCodeCtrl1.k = 0;
            this.barCodeCtrl1.yTop = 0;
            this.barCodeCtrl1.StartingColumn = Convert.ToInt16(txtstartingColumn.Text);
            this.barCodeCtrl1.StartingRow = Convert.ToInt16(txtStartingRow.Text);
            this.barCodeCtrl1.totalnumber = 0;
            // this.barCodeCtrl1.
            this.barCodeCtrl1.StartingRow = Convert.ToInt16(txtStartingRow.Text);
            this.barCodeCtrl1.StartingColumn = Convert.ToInt16(txtstartingColumn.Text);
            this.barCodeCtrl1.PageSettings();
            // this.barCodeCtrl1.Barcodeprintingin, "Laser", false
           // this.barCodeCtrl1.Print(gridmain, this.barCodeCtrl1.Barcodeprintingin, "Laser", false, comprint.Text);
          //  this.barCodeCtrl1.Print(gridmain, this.barCodeCtrl1.Barcodeprintingin, "Laser", false);

        }
        public void FillCombo()
        {
            CommonClass._Dbtask.fillDatainCombowithQuery(comvno, "reptcode", "vno", "tbltransactionreceipt", "select * from tbltransactionreceipt where recpttype='PI'");
        }

        private void Frmlabelprinting_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            Clear();
        }
        public void Clear()
        {
            FillCombo();
            CommonClass._Nextg.FormIcon(this);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.GridHeaderConversion(gridmain);
                //CommonClass._Language.PanelBasedConversion(pnltotal);
                //CommonClass._Language.PanelBasedConversion(Pnlbottom);
            }
        }
        private void comvno_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillInvoice();
        }
        
        public void BarcodeSettings()
        {
            this.barCodeCtrl1.Barcodeprintingin = CommonClass._Paramlist.GetParamvalue("printbarcodein");
            this.barCodeCtrl1.ThemalTopmargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LaserTop"));
            this.barCodeCtrl1.LeftMargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LeftBarcode"));
            this.barCodeCtrl1.Noofcpies = 1;
           // this.barCodeCtrl1.XValue = this.barCodeCtrl1.LeftMargin;
            if (CommonClass._settings.FunSettings1("Pitemnote1") == true)
            {
                this.barCodeCtrl1.Showitemnote1 = true;
            }
            
        }
       
        public void FillInvoice()
        {
            gridmain.Rows.Clear();
            string RecptCode=comvno.SelectedValue.ToString();
            CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery("select * from tbltransactionreceipt where recpttype='PI' and reptcode='" + RecptCode + "' order by vno asc");
            
            if (CommonClass.Ds.Tables[0].Rows.Count > 0)
            {
                Ds =CommonClass._Dbtask.ExecuteQuery("select * from TblReceiptDetails where RecptCode='" + RecptCode + "'and vtype='PI' order by slno asc");

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    gridmain.Rows.Add(1);

                    string tempSlno = (i + 1).ToString();
                    string tempitemid = Ds.Tables[0].Rows[i]["pcode"].ToString();
                    double tempQty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());
                    double temppRate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Rate"].ToString());
                    double tempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["NetAMT"].ToString());

                    string tempbatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();
                    gridmain.Rows[i].Cells["clnbatch"].Value = tempbatchid;

                    double tempsrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["srate"].ToString());
                    double tempcrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["crate"].ToString());
                    double tempmrp = Convert.ToDouble(Ds.Tables[0].Rows[i]["mrp"].ToString());

                    //gridmain.Rows[i].Cells["clnslno"].Value = tempSlno;
                    
                    gridmain.Rows[i].Cells["clnitemcode"].Value = CommonClass._Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                    gridmain.Rows[i].Cells["clnitemname"].Value = CommonClass._Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
                    gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;

                    int NO=1;
                    //if (tempQty > 5)
                    //    NO =Convert.ToInt16( tempQty /Convert.ToDouble(5));
                    gridmain.Rows[i].Cells["clnno"].Value = NO;
                    gridmain.Rows[i].Cells["clnqty"].Value = CommonClass._Dbtask.SetintoDecimalpointStock(tempQty);
                    gridmain.Rows[i].Cells["clnmrp"].Value = CommonClass._Dbtask.SetintoDecimalpoint(tempsrate);
                    gridmain.Rows[i].Cells["clnsrate"].Value = CommonClass._Dbtask.SetintoDecimalpoint(tempsrate);

                    gridmain.Rows[i].Cells["clnitemnote"].Value = Ds.Tables[0].Rows[i]["itemnote"].ToString();
                    gridmain.Rows[i].Cells["clnitemnote1"].Value = Ds.Tables[0].Rows[i]["itemnote1"].ToString();
                    gridmain.Rows[i].Tag = 1;
                }
            }
        }

        private void cmdadprint_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void cmdpnlsettingsclose_Click(object sender, EventArgs e)
        {
            pnlprintsettings.Visible = false;
        }

    }
}
