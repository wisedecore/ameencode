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
    public partial class Frmdressmakers : Form
    {
        public Frmdressmakers()
        {
            InitializeComponent();
        }
        DataSet Ds;

        public int rowindex;
        public int columnindex;
        public string Columnname;
        public bool EditMode;

        long Vno;
        long Customer;
        DateTime Vdate;
        DateTime DDate;

        double Chest;
        double Waist;
        double Neck;
        double Height;
        double Shapping;

        double Length;
        double Loose;
        double Sholder;
        double SholderL;
        double SholderW;
        double NeckF;
        double NeckB;
        double PantL;
        double PantW;
        string Pant;



        long Itemid;
        double Qty;
        double Srate;
        double Amount;


        double Nqty;
        double Namount;
        double ReceivedAmount;
        double Balance;

        int Delivery;
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)
            {
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                    if (this.ActiveControl.Name != "txtvno")
                    {
                        if (this.ActiveControl.Name != "GrpOpeningStock")
                        {
                            if (this.ActiveControl.Name != "GrpUnit")
                            {
                                if (this.ActiveControl.Name != "GridProductList")
                                {
                                    if (this.ActiveControl.Name != "Gridmain")
                                    {
                                        SendKeys.Send("{Tab}");
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        public void GetVno()
        {
        
        }


       

      

        private bool ValidationFu()
        {
            try
            {
                if (txtvno.Text == "")
                {
                    MessageBox.Show("Type Vno");
                    txtvno.Focus();
                    return false;
                }
                string CustomerID =CommonClass._Dbtask.znllString(Comcustomer.SelectedValue);
                if (CustomerID == "")
                {
                    MessageBox.Show("Select Customer", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    Comcustomer.Focus();
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool Main()
        {

            if (EditMode == false)
                GetVno();

            if ( ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteVoucher();
                    }
                    NextgInitialize();
                    Clear();
                    if (chkprintwhilesave.Checked == true)
                        Print();
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
            return true;
        }

        public void Retrive(string Vno)
        {
            try
            {
                Ds = CommonClass._Dbtask.ExecuteQuery("select * from Tbldressmaster where vno='" + Vno + "'");

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    EditMode = true;
                    txtvno.Text = Ds.Tables[0].Rows[i]["vno"].ToString();
                    Comcustomer.SelectedValue = Ds.Tables[0].Rows[i]["customer"].ToString();
                    Dtdate.Value = Convert.ToDateTime(Ds.Tables[0].Rows[i]["vdate"]);
                    Dtdeliverydate.Value = Convert.ToDateTime(Ds.Tables[0].Rows[i]["ddate"]);
                    txtchest.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["chest"])).ToString();
                    Txtwaist.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["waist"])).ToString();
                    Txtneck.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["neck"])).ToString();
                    Txtheight.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["height"])).ToString();
                    Txtshapping.textBox1.Text =( CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["shapping"]).ToString());
                    Comitem.SelectedValue = (CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["itemid"])).ToString();
                    txtqty.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["qty"])).ToString();
                    txtrate.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["rate"])).ToString();
                    Txtreceived.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["adamount"])).ToString();

                    Txtlength.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["length"])).ToString();
                    txtloose.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["loose"])).ToString();
                    txtsholder.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["sholder"])).ToString();
                    txtsholderl.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["sholderl"])).ToString();
                    txtsholderw.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["sholderw"])).ToString();
                    txtneckf.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["neckf"])).ToString();
                    txtneckb.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["neckb"])).ToString();
                    txtpantl.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["pantl"])).ToString();
                    txtpantw.textBox1.Text = (CommonClass._Dbtask.znllString(Ds.Tables[0].Rows[i]["pantw"])).ToString();
                    Compant.Text =Ds.Tables[0].Rows[i]["pant"].ToString();
                    Delivery =Convert.ToInt16(Ds.Tables[0].Rows[i]["Dl"]);
                    Deliverycheck(true);
                }
            }
            catch
            {
                Clear();
            }
        }

        public void Fillcombo()
        {
            CommonClass._Ledger.FillComboCustomer(Comcustomer);
            CommonClass._Itemmaster.FillCombo(Comitem);

            Comcustomer.SelectedIndex = 0;
            Comitem.SelectedIndex = 0;
        }

        public void Clear()
        {
            EditMode = false;
            txtvno.Text = CommonClass._dress.Getid();
            Fillcombo();
            Dtdate.Value = DateTime.Now;
            Dtdeliverydate.Value = DateTime.Now;
            Txtreceived.textBox1.Text="0";
            txtqty.textBox1.Text = "0";
            txtrate.textBox1.Text = "0";
            txtchest.textBox1.Text="0";
            Txtwaist.textBox1.Text = "0";
            Txtneck.textBox1.Text = "0";
            Txtheight.textBox1.Text = "0";
            Txtshapping.textBox1.Text = "0";

            Txtlength.textBox1.Text = "0";
            txtloose.textBox1.Text = "0";
            txtsholder.textBox1.Text = "0";
            txtsholderl.textBox1.Text = "0";
            txtsholderw.textBox1.Text = "0";
            txtneckf.textBox1.Text = "0";
            txtneckb.textBox1.Text = "0";
            txtpantl.textBox1.Text = "0";
            txtpantw.textBox1.Text = "0";
            Compant.SelectedIndex = 0;

            Showreport();
            TotalAmountcalculation();
            Comcustomer.Focus();
        }

        public void Cellentercalculation()
        {
        
        }

        public void TotalAmountcalculation()
        {
            try
            {
                //if (rowindex < gridmain.Rows.Count)
                //{
                //    gridmain.Rows[rowindex].Cells["clnslno"].Value = rowindex + 1; /* For SlNo*/

                //    Nqty = 0;
                //    Namount = 0;

                //    for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
                //    {
                //        if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
                //        {
                //            Namount = Convert.ToDouble(Namount) + Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                //            Nqty = Nqty + Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                //        }
                //    }
                Srate=CommonClass._Dbtask.znullDouble(txtrate.textBox1.Text);
                Qty=CommonClass._Dbtask.znullDouble(txtqty.textBox1.Text);
                Namount=Qty*Srate;

                Txttotal.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpointStock(Namount);
                ReceivedAmount = CommonClass._Dbtask.znullDouble(Txtreceived.textBox1.Text);
                Balance = Namount - ReceivedAmount;
                Txtbalance.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Balance);


                   
                //}
            }
            catch
            {
            }
        }

        public void DeleteVoucher()
        {
            Vno=Convert.ToInt64(txtvno.Text);
            CommonClass._dress.Delete(Vno.ToString());
            CommonClass._Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='R' and Refno='14' and purticulars='Received In Dress making' and slno='" + Vno + "'");
            CommonClass._Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='DM' and Refno='14'   and vno='" + Vno + "'");

        }

        public void Deliverycheck(bool isinretrive)
        {
            if (isinretrive == true)
            {
                if (Delivery == 1)
                    chkdelivery.Checked = true;
                else
                    chkdelivery.Checked = false;
            }
            else
            {
                if (chkdelivery.Checked == true)
                    Delivery=1;
                else
                    Delivery = -1;
            }
        }

        public void NextgInitialize()
        {
            Vno = Convert.ToInt64(txtvno.Text);
            Deliverycheck(false);
            Customer = Convert.ToInt64(Comcustomer.SelectedValue);
            Vdate = Dtdate.Value;
            DDate = Dtdeliverydate.Value;
            Chest = CommonClass._Dbtask.znullDouble(txtchest.textBox1.Text);
            Waist = CommonClass._Dbtask.znullDouble(Txtwaist.textBox1.Text);
            Neck = CommonClass._Dbtask.znullDouble(Txtneck.textBox1.Text);
            Height = CommonClass._Dbtask.znullDouble(Txtheight.textBox1.Text);
            Shapping = CommonClass._Dbtask.znullDouble(Txtshapping.textBox1.Text);
            Itemid =Convert.ToInt64(Comitem.SelectedValue);
            Qty = CommonClass._Dbtask.znullDouble(txtqty.textBox1.Text);
            Srate = CommonClass._Dbtask.znullDouble(txtrate.textBox1.Text);
            ReceivedAmount = CommonClass._Dbtask.znullDouble(Txtreceived.textBox1.Text);


            Length = CommonClass._Dbtask.znullDouble(Txtlength.textBox1.Text);
            Loose = CommonClass._Dbtask.znullDouble(txtloose.textBox1.Text);
            Sholder = CommonClass._Dbtask.znullDouble(txtsholder.textBox1.Text);
            SholderL = CommonClass._Dbtask.znullDouble(txtsholderl.textBox1.Text);
            SholderW = CommonClass._Dbtask.znullDouble(txtsholderw.textBox1.Text);
            NeckF = CommonClass._Dbtask.znullDouble(txtneckf.textBox1.Text);
            NeckB = CommonClass._Dbtask.znullDouble(txtneckb.textBox1.Text);
            PantL = CommonClass._Dbtask.znullDouble(txtpantl.textBox1.Text);
            PantW = CommonClass._Dbtask.znullDouble(txtpantw.textBox1.Text);
            Pant = Compant.Text;
            

            CommonClass._dress.Vno = Vno;
            CommonClass._dress.Delivery = Delivery;
            CommonClass._dress.Customer = Customer;
            CommonClass._dress.Vdate = Vdate;
            CommonClass._dress.Ddate = DDate;
            CommonClass._dress.Chest = Chest;
            CommonClass._dress.Waist = Waist;
            CommonClass._dress.Neck = Neck;
            CommonClass._dress.Height = Height;
            CommonClass._dress.Shapping = Shapping;

            CommonClass._dress.Length = Length;
            CommonClass._dress.Loose = Loose;
            CommonClass._dress.Sholder = Sholder;
            CommonClass._dress.SholderL = SholderL;
            CommonClass._dress.SholderW = SholderW;
            CommonClass._dress.NeckF = NeckF;
            CommonClass._dress.NeckB = NeckB;
            CommonClass._dress.PantL = PantL;
            CommonClass._dress.PantW = PantW;
            CommonClass._dress.Pant = Pant;

            CommonClass._dress.Itemid = Itemid;
            CommonClass._dress.Qty = Qty;
            CommonClass._dress.Rate = Srate;
            CommonClass._dress.Adamount = ReceivedAmount;
            CommonClass._dress.Insertdressmaster();
           
            
            //    /*Advance Paid*/

            CommonClass._GenLedger.VdateDt = Vdate;
           CommonClass._GenLedger.Naration = "";
           CommonClass._GenLedger.RefnoStr = "14";

            if (ReceivedAmount > 0)
            {
                CommonClass._GenLedger.VTypeStr = "R";
                CommonClass._GenLedger.IdGeneralLedger(" where vtype='R'");
                CommonClass._GenLedger.SlNoLng = Convert.ToInt64(txtvno.Text);
                CommonClass._GenLedger.LedCodeStr = "1";
                CommonClass._GenLedger.PurticularsStr = "Received In Dress making";
                CommonClass._GenLedger.DbAmtDb = ReceivedAmount;
                CommonClass._GenLedger.CrAmt = 0;
                CommonClass._GenLedger.InsertGeneralLedger();

                CommonClass._GenLedger.LedCodeStr = Comcustomer.SelectedValue.ToString();
                CommonClass._GenLedger.PurticularsStr = "Received In Dress making";
                CommonClass._GenLedger.DbAmtDb = 0;
                CommonClass._GenLedger.CrAmt = ReceivedAmount;
                CommonClass._GenLedger.InsertGeneralLedger();
            }
            //    /*****************************/
            //    /*For Debit*/

            CommonClass._GenLedger.VTypeStr = "DM";
            CommonClass._GenLedger.VnoStr = txtvno.Text;
            CommonClass._GenLedger.SlNoLng = Convert.ToInt64("1");
            CommonClass._GenLedger.LedCodeStr = Customer.ToString();
            CommonClass._GenLedger.PurticularsStr = "Dress Making";
            CommonClass._GenLedger.DbAmtDb = Namount;
            CommonClass._GenLedger.CrAmt = 0;
            CommonClass._GenLedger.InsertGeneralLedger();

            //    /*For Credit */
            CommonClass._GenLedger.LedCodeStr = "14";
            CommonClass._GenLedger.PurticularsStr = "Dress Making";
            CommonClass._GenLedger.DbAmtDb = 0;

            CommonClass._GenLedger.CrAmt = Namount;
            CommonClass._GenLedger.InsertGeneralLedger();
            //}

            

        }

        private void Frmdressmakers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();

            
        }

        private void Frmdressmakers_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Comitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Itemid =Convert.ToInt64(Comitem.SelectedValue);
                Srate =CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid.ToString(), "srate"));
                txtrate.textBox1.Text =CommonClass._Dbtask.SetintoDecimalpoint(Srate);
            }
            catch
            {
            }
        }

        private void txtqty_TextChanged(object Sender, EventArgs e)
        {
            TotalAmountcalculation();
        }

        private void txtrate_TextChanged(object Sender, EventArgs e)
        {
            TotalAmountcalculation();
        }

        private void Txtadvance_TextChanged(object Sender, EventArgs e)
        {
            TotalAmountcalculation();
        }

        public void Showreport()
        {
            
            Ds = CommonClass._Dbtask.ExecuteQuery("SELECT     Tbldressmaster.vno, Tbldressmaster.Dl, Tbldressmaster.Vdate AS " +
                          "  'Date', Tbldressmaster.Ddate, " +
                          " TblAccountLedger.LName, TblItemMaster.ItemName,Tbldressmaster.qty*Tbldressmaster.rate as 'Amount' " +
                          " FROM         Tbldressmaster INNER JOIN " +
                          " TblItemMaster ON Tbldressmaster.Itemid = TblItemMaster.ItemId INNER JOIN " +
                          "  TblAccountLedger ON Tbldressmaster.customer = TblAccountLedger.Lid " +
                          "GROUP BY Tbldressmaster.vno, TblAccountLedger.LName, Tbldressmaster.Dl, Tbldressmaster.Vdate, Tbldressmaster.Ddate, TblItemMaster.ItemName,  " +
                          "   Tbldressmaster.Qty * Tbldressmaster.Rate HAVING      (Tbldressmaster.vno LIKE '%"+txtsearch.textBox1.Text+"%') OR (TblAccountLedger.LName LIKE '%"+txtsearch.textBox1.Text+"%')");
            GridMain.DataSource = Ds.Tables[0];
        }

        private void cmdshow_Click(object sender, EventArgs e)
        {
            Showreport();
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DeleteVoucher();
            Clear();
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            Retrive((Convert.ToInt64(txtvno.Text) - 1).ToString());
        }

        private void Cmdforward_Click(object sender, EventArgs e)
        {
            Retrive((Convert.ToInt64(txtvno.Text) + 1).ToString());
        }

        private void txtsearch_TextChanged(object Sender, EventArgs e)
        {
            Showreport();
        }

        private void GridMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                rowindex=GridMain.SelectedRows[0].Index;
                Vno =Convert.ToInt64(GridMain.Rows[rowindex].Cells["vno"].Value);
                Retrive(Vno.ToString());
            }
            catch
            {
            }
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdprint_Click(object sender, EventArgs e)
        {
            Print();
        }

        public void Print()
        {
            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.RichTextBox1.Text = "\n\n\nVno            : " + txtvno.Text + "\n\nCustomer       : " + Comcustomer.Text + "\n\nDate           : " + Dtdate.Value.ToString("dd/MM/yyyy") +
                                         "\n\nDelivery Date  : " + Dtdeliverydate.Value.ToString("dd/MM/yyyy") +
                                         "\n\nServices       : " + Dtdeliverydate.Value.ToString("dd/MM/yyyy") + "    Qty : " + CommonClass._Dbtask.znullDouble(txtqty.textBox1.Text) + "     Rate :" + txtrate.textBox1.Text + "   Amount :" + Txttotal.textBox1.Text +
                                       "\n\n Length    : " + CommonClass._Dbtask.znullDouble(Txtlength.textBox1.Text) + "       Sholder   : " + CommonClass._Dbtask.znullDouble(Txtwaist.textBox1.Text) + "       L :" + CommonClass._Dbtask.znullDouble(txtsholderl.textBox1.Text) + "       L :" + CommonClass._Dbtask.znullDouble(txtsholderw.textBox1.Text) +
                                       "\n\n Chest     : " + CommonClass._Dbtask.znullDouble(txtchest.textBox1.Text) + "        Neck      : " + "       F :" + CommonClass._Dbtask.znullDouble(txtneckf.textBox1.Text) + "       B :" + CommonClass._Dbtask.znullDouble(txtneckb.textBox1.Text) +
                                       "\n\n Waist     : " + CommonClass._Dbtask.znullDouble(Txtwaist.textBox1.Text) + "        Pants     : " + "       L :" + CommonClass._Dbtask.znullDouble(txtpantl.textBox1.Text) + "       W :" + CommonClass._Dbtask.znullDouble(txtpantw.textBox1.Text) +
                                       "\n\n Loose     : " + CommonClass._Dbtask.znullDouble(txtloose.textBox1.Text) +

                                       "\n\n Pant      : " + Compant.Text +

                                       "\n\n\n\n\n\n\n\n\n\n\n\n=========================================================================" +
                                       "\n\n                                FANTACY  Bill                                      " +
                                       "\n\n\nVno            : " + txtvno.Text + "\n\nCustomer       : " + Comcustomer.Text + "\n\nDate           : " + Dtdate.Value.ToString("dd/MM/yyyy") +
                                         "\n\nDelivery Date  : " + Dtdeliverydate.Value.ToString("dd/MM/yyyy") +
                                         "\n\nServices       : " + Dtdeliverydate.Value.ToString("dd/MM/yyyy") + "    Qty : " + txtqty.textBox1.Text + "     Rate :" + txtrate.textBox1.Text +
                                         "\n\n\n   Amount         : " + Txttotal.textBox1.Text +
                                         "\n\n   Advance        : " + Txtreceived.textBox1.Text +
                                         "\n\n   Balance        : " + Txtbalance.textBox1.Text;


            _Sales.RichTextBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            CommonClass.ETailering = true;
            _Sales.vouchertypewholesalesother();
        }

        private void GridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
       
    }
}
