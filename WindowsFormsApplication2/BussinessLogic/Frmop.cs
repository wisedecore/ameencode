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
    public partial class Frmop : Form
    {
        public Frmop()
        {
            InitializeComponent();
        }

        public int RowIndex;
        public string ColumnName;

        RichTextBox RichTextBox1 = new RichTextBox();
        Declare _Declare = new Declare();
        StringFormat Str;
        private SolidBrush BlackBrush = new SolidBrush(Color.Black);
     
        /*For Printing*/
        public string Invoicename;
        public static long LedId;
        public string Opno;
        public DateTime VDate;
        public DateTime VTime;
        public long Staffid;
        public long Doctor;
        public string Patient;
        public string Note;
        public int Gender;
        public int Age;

        public int Slno;
        public string ServiceItem;
        public double Qty;
        public double Rate;
        public double Amount;

        public double BillAmount;
        public double RecivedAmount;
        public double Balance;
        public static long GenNo;
        public string Voucher;

     public long Patientid;
     public static string PatientName ;
     public static string PPhone;
     public static string PAddress;
     public static string PMobile;
     public static string PCity;
     public static string PEmail;

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)
            {
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }

                if (Gridproductlist.Visible == true)
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Down)
                    {
                        return true;
                    }
                    if (msg.WParam.ToInt32() == (int)Keys.Up)
                    {
                        return true;
                    }
                }
            }


            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void Frmop_Load(object sender, EventArgs e)
        {
            Clear();
        }
        public void GetVno()
        {
            txtopno.Text = Declare._OP.IdOp();
        }

        

        private bool ValidationFu()
        {
            Opno =txtopno.Text;
            Patient = txtpatient.Text;
            if (Opno == "")
            {
                MessageBox.Show("Opno is null", "ZAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Patient == "")
            {
                MessageBox.Show("Type Patient", "ZAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpatient.Focus();
                return false;
            }
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        

        public void CellEnterCalculation()
        {
            try
            {
                Qty = Declare._Dbtask.znullDoubleforobject(gridmain.Rows[RowIndex].Cells["clnqty"].Value);
                Rate = Declare._Dbtask.znullDoubleforobject(gridmain.Rows[RowIndex].Cells["clnrate"].Value);
                Amount = Qty * Rate;
                gridmain.Rows[RowIndex].Cells["clnamount"].Value = Declare._Dbtask.SetintoDecimalpoint(Amount);
            }
            catch
            {
            }
        }

        public void TotalAmountCalculation()
        {
            try
            {
                BillAmount = 0;
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["clnitems"].Tag != null)
                    {
                        if (gridmain.Rows[i].Cells["clnamount"].Value == null)
                        {
                            gridmain.Rows[i].Cells["clnamount"].Value = 0;
                        }
                        double CellAmt = Convert.ToDouble(Declare._GenF.SettNulltoZerogrid(gridmain.Rows[i].Cells["clnamount"].Value.ToString(), true));
                        BillAmount = BillAmount + CellAmt;
                    }


                }
                lbltotalamount.Text = Declare._Dbtask.SetintoDecimalpoint(BillAmount);
                RecivedAmount = Declare._Dbtask.znullDouble(lbltotalamount.Text);
                //Balance = BillAmount - RecivedAmount;
                Balance = Declare._Dbtask.znullDouble(lbltotalamount.Text);
                lblbalanceamount.Text = Declare._Dbtask.SetintoDecimalpoint(Balance);
                txtreceivedamount.Text= Declare._Dbtask.SetintoDecimalpoint(Balance);
            }
            catch
            {

            }
        }
        
        public void GenderSelect()
        {
            if (radmale.Checked == true)
                Gender = 1;
            else
                Gender = -1;
        }
        
        public void NextgInitialize()
        {
            Voucher = "OP";
            if (Declare.EditMode == 0)
            {
                Opno = Declare._OP.IdOp();
                Declare._Ledger.IdAccountLedger();
                LedId = Declare._Ledger.LidLng;
                 Declare._Gen.IdGeneralLedger(" where vtype='R'");
                 GenNo =Convert.ToInt64(Declare._Gen.VnoStr);
            }
            else
            {
                Opno = txtopno.Text;
                LedId = Convert.ToInt64(txtpatient.Tag);
                GenNo = Convert.ToInt64(txtreceivedamount.Tag);
            }

            PatientName=txtpatient.Text ;
            PPhone=txtphone.Text;
            PAddress=txtaddress.Text;
            PMobile=txtmobile.Text;
            PCity=txtcity.Text;
            PEmail=txtemail.Text;
            
            if (Declare.EditMode == 0)
            {
                Declare._Formop.InsertLedger(LedId, PatientName, PEmail, PAddress, PCity, PPhone, PMobile);
            }
           
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        ServiceItem=gridmain.Rows[i].Cells["clnitems"].Tag.ToString();
                        Qty=Declare._Dbtask.znullDoubleforobject(gridmain.Rows[i].Cells["clnqty"].Value);
                        Rate = Declare._Dbtask.znullDoubleforobject(gridmain.Rows[i].Cells["clnrate"].Value);
                        Amount = Declare._Dbtask.znullDoubleforobject(gridmain.Rows[i].Cells["clnamount"].Value);

                        Declare._Opdetails.opno =Convert.ToInt64(Opno);
                        Declare._Opdetails.Serviceitem =Convert.ToInt64(ServiceItem);
                        Declare._Opdetails.Qty = Qty;
                        Declare._Opdetails.Rate = Rate;
                        Declare._Opdetails.Amount = Amount;
                        Declare._Opdetails.InsertOpdetails();
                    }
                }
            }

            BillAmount =Declare._Dbtask.znullDouble(lbltotalamount.Text);
            RecivedAmount = Declare._Dbtask.znullDouble(txtreceivedamount.Text);
            Staffid =Convert.ToInt64(comstaff.SelectedValue);
            Doctor =Convert.ToInt64(comdoctor.SelectedValue);
            Staffid = Convert.ToInt64(comstaff.SelectedValue);
            Doctor = Convert.ToInt64(comdoctor.SelectedValue);

            Note = txtnote.Text;
            GenderSelect();
            

            Declare._OP.opno = Convert.ToInt64(Opno);
            Declare._OP.Opdate = Dtdate.Value;
            Declare._OP.Optime = Dttime.Value;
            Declare._OP.staffid = Staffid;
            Declare._OP.Doctor = Doctor;
            Declare._OP.Patientid =Convert.ToInt64(LedId);
            Declare._OP.OpNote = Note;
            Declare._OP.Gender = Gender;
            Declare._OP.Age = Age;
            Declare._OP.InsertOp();

            /*For Cash Recipt*/
           // RecivedAmount = 100;
           // Declare._Formop.PatientChecking();
            if (RecivedAmount > 0)
            {
                Declare._Gen.IdGeneralLedger(" where vtype='R'");
                Declare._Gen.VdateDt = Dtdate.Value;
                Declare._Gen.VTypeStr = "R";
                Declare._Gen.SlNoLng = 1;

                Declare._Gen.RefnoStr = "";
                Declare._Gen.LedCodeStr = LedId.ToString();
                Declare._Gen.PurticularsStr = "Amount In OutPatient";
                Declare._Gen.CrAmt = RecivedAmount;
                Declare._Gen.CrAmt = 0;
                Declare._Gen.InsertGeneralLedger();

                Declare._Gen.RefnoStr = "";
                Declare._Gen.LedCodeStr = "1";
                Declare._Gen.PurticularsStr = "Amount In OutPatient";
                Declare._Gen.CrAmt = 0;
                Declare._Gen.CrAmt = RecivedAmount;
                Declare._Gen.InsertGeneralLedger();
            }
        }
        public void Clear()
        {
            Declare._Nextg.ClearControles(this);
            gridmain.Rows.Clear();
            GetVno();
            FillCombo();
            lblbalanceamount.Text = Declare._Dbtask.SetintoDecimalpoint(0);
            lbltotalamount.Text = Declare._Dbtask.SetintoDecimalpoint(0);
            Declare.EditMode = 0;
            ShowGrid("");
        }
        public void GetRetrive()
        {
            int Selectrow = Gridsearch.SelectedCells[0].RowIndex;
            if (Gridsearch.Rows[Selectrow].Cells[0].Value != null)
            {
                Opno = Gridsearch.Rows[Selectrow].Cells[0].Value.ToString();
                Declare.Ds = Declare._Dbtask.ExecuteQuery("select * from tblop where opno='" + Opno + "'");
                for (int i = 0; i < Declare.Ds.Tables[0].Rows.Count; i++)
                {
                    Declare.EditMode = 1;
                    VDate = Convert.ToDateTime(Declare.Ds.Tables[0].Rows[0]["opdate"]);
                    VTime = Convert.ToDateTime(Declare.Ds.Tables[0].Rows[0]["optime"]);
                    Staffid = Convert.ToInt64(Declare.Ds.Tables[0].Rows[0]["staffid"]);
                    Doctor = Convert.ToInt64(Declare.Ds.Tables[0].Rows[0]["doctor"]);
                    Patient = Convert.ToString(Declare.Ds.Tables[0].Rows[0]["patient"]);

                    Declare._Formop.FillPatientDetails(Patient);

                    Note = Declare.Ds.Tables[0].Rows[0]["opnote"].ToString();

                    RecivedAmount = Declare._Dbtask.znullDoubleforobject(Declare.Ds.Tables[0].Rows[0]["patient"]);
                    GenNo = Convert.ToInt64(Declare.Ds.Tables[0].Rows[0]["gno"]);


                    txtopno.Text = Opno;
                    Dtdate.Value = VDate;
                    Dttime.Value = VTime;
                    comstaff.SelectedValue = Staffid;
                    comdoctor.SelectedValue = Doctor;
                    txtpatient.Tag = Patient;
                    txtpatient.Text = PatientName;
                    txtaddress.Text = PAddress;
                    txtcity.Text = PCity;
                    txtphone.Text = PPhone;
                    txtmobile.Text = PMobile;
                    txtemail.Text = PEmail;
                    txtnote.Text = Note;
                    txtreceivedamount.Text = Declare._Dbtask.SetintoDecimalpoint(RecivedAmount);
                    txtreceivedamount.Tag = GenNo;


                    /*For OP Detail*/
                    Declare.Ds1 = Declare._Dbtask.ExecuteQuery("select * from tblopdetails where opno='" + Opno + "'");
                    Gridproductlist.Rows.Clear();
                    for (int k = 0; k < Declare.Ds1.Tables[0].Rows.Count; k++)
                    {
                        string ItemName;
                        Slno=k+1;
                        ServiceItem = Declare.Ds1.Tables[0].Rows[k]["serviceitem"].ToString();
                        ItemName = Declare._Item.GetSpecificField("itemname", ServiceItem);
                        Qty = Declare._Dbtask.znullDoubleforobject(Declare.Ds1.Tables[0].Rows[k]["qty"]);
                        Rate = Declare._Dbtask.znullDoubleforobject(Declare.Ds1.Tables[0].Rows[k]["rate"]);
                        Amount = Declare._Dbtask.znullDoubleforobject(Declare.Ds1.Tables[0].Rows[k]["amount"]);

                        gridmain.Rows[k].Cells["clnslno"].Value = Slno;
                        gridmain.Rows[k].Cells["clnitems"].Value = ItemName;
                        gridmain.Rows[k].Cells["clnitems"].Tag = ServiceItem;
                        gridmain.Rows[k].Cells["clnqty"].Value = Qty;
                        gridmain.Rows[k].Cells["clnrate"].Value = Rate;
                        gridmain.Rows[k].Cells["clnamount"].Value = Amount;
                        CellEnterCalculation();
                    }
                    TotalAmountCalculation();
                }
            }
        }
        private bool Main()
        {
            Declare._Grid.RowValidationOP(gridmain);
            if (ValidationFu())
            {
                try
                {
                    if (Declare.EditMode == 1)
                    {
                        Opno = txtopno.Text;
                        Declare._Formop.DeleteVoucher(txtreceivedamount.Tag.ToString(), Opno);
                    }
                    NextgInitialize();
              
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

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Columnindex;
                RowIndex = gridmain.CurrentCell.RowIndex;
                Columnindex = gridmain.CurrentCell.ColumnIndex;
                ColumnName = gridmain.Columns[Columnindex].Name.ToString();
                gridmain.Rows[RowIndex].Cells["clnslno"].Value = RowIndex + 1;
            }
            catch
            {

            }
        }

        private void gridmain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);

            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);

            txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
           // throw new NotImplementedException();
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            gridmain.Rows[RowIndex].Cells[ColumnName].Value = (sender as TextBox).Text;
            if (ColumnName == "clnitems")
                ProductGridShow((sender as TextBox).Text);
            CellEnterCalculation();
            TotalAmountCalculation();
        }

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Declare._Formop.GridKeyDow(e.KeyValue, Gridproductlist, gridmain, RowIndex, ColumnName);
            if (e.KeyValue == 13&&ColumnName=="clnitems")
            {
                int selectedRow = Gridproductlist.SelectedRows[0].Index;
                string SelectName = Gridproductlist.Rows[selectedRow].Cells[0].Value.ToString();
                string SelectId = Gridproductlist.Rows[selectedRow].Cells[0].Tag.ToString();
                gridmain.Rows[RowIndex].Cells[ColumnName].Value = SelectName;
                gridmain.Rows[RowIndex].Cells[ColumnName].Tag = SelectId;
                gridmain.NotifyCurrentCellDirty(false);
                Gridproductlist.Visible = false;
            }
        }

        public void ProductGridShowLocationSett()
        {
              Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
              Gridproductlist.Left = tempRect.Left;
              Gridproductlist.Top = tempRect.Top + tempRect.Height+350;
        }

        public void FillCombo()
        {
            /*ForDoctor*/
            Declare._Dbtask.fillDatainCombowithQuery(comdoctor, "empid", "empname", "tblemployeemaster", "select * from tblemployeemaster where department=1");
            /*For Staff*/
            Declare._Dbtask.fillDatainCombowithQuery(comstaff, "empid", "empname", "tblemployeemaster", "select * from tblemployeemaster where department !=1");
        }

        public void ProductGridShowItemname(string Where)
        {
           // Gridproductlist.DataSource = null;
            Gridproductlist.Rows.Clear();
           // Gridproductlist.Columns.Add(1);
            Declare.Ds = Declare._Dbtask.ExecuteQuery("select * from tblitemmaster " + Where + "");
            for (int i = 0; i < Declare.Ds.Tables[0].Rows.Count; i++)
            {
                Gridproductlist.Rows.Add(1);
                ServiceItem = Declare.Ds.Tables[0].Rows[i]["itemid"].ToString();
                Gridproductlist.Rows[i].Cells[0].Tag = ServiceItem;
                ServiceItem = Declare.Ds.Tables[0].Rows[i]["itemname"].ToString();
                Gridproductlist.Rows[i].Cells[0].Value = ServiceItem;
            }
            ProductGridShowLocationSett();
            Gridproductlist.Visible = true;
        }
        public void ProductGridShow(string ItemName)
        {
            ProductGridShowItemname(" where  itemName Like '%" + ItemName + "%' and itemclass='Services'");
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            ShowGrid(txtsearch.Text);
        }

        public void ShowGrid(string Txt)
        {
            Declare.Ds = Declare._Dbtask.ExecuteQuery("SELECT   op.opno as OPno,ledger.LName as Patient,(select lname from tblaccountledger where lid=op.doctor) as Doctor " +
            " FROM     TblEmployeemaster INNER JOIN tblop AS op ON TblEmployeemaster.Empid = op.doctor LEFT OUTER JOIN "+
            " TblAccountLedger AS ledger ON op.patient = ledger.Lid "+
            " GROUP BY ledger.LName, op.doctor,op.opno,op.opdate " +
            " HAVING      (ledger.LName LIKE '%"+Txt+"%') and op.opdate between '"+Dtsfrom.Value.ToString("MM/dd/yyyy")+" 00:00:00' and "+
            "  '" + Dtsto.Value.ToString("MM/dd/yyyy") + " 23:59:59' order by op.opno asc");
            Gridsearch.DataSource = Declare.Ds.Tables[0];
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
            if (chkprintwhilesave.Checked == true)
                MainPrint();
            Clear();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure to Delete Voucher?", "ZAT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result.ToString() == "Yes")
            {
                Opno = txtopno.Text;
                Declare._Formop.DeleteVoucher(txtreceivedamount.Tag.ToString(), Opno);
                Clear();
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void OPBill()
        {
            string StrVno = txtopno.Text;
            Invoicename = "Out PatientBill";
            string PInvoiceName = Invoicename.PadLeft(40, ' ');
            string Cusnam = txtpatient.Text.Replace("\r\n"," ");
            string CusAddress = txtaddress.Text;
            string CusAge = txtage.Text;
            string CusMobile = txtmobile.Text;
            string Gender;
            if (radfemail.Checked == true)
                Gender = "Mail";
            else
                Gender = "Female";
            string Doctor = comdoctor.Text;

            string Datestr ="Date : "+Dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                                               " + Datestr;
         
            RichTextBox1.Text = "OPno :" + StrVno + "" + PInvoiceName + "\nPatient:"+Cusnam+"\n" + Datestr + " \n\nAddress" + 
                CusAddress + "\n\nMobile" + CusMobile +"\n\n"+ "Gender" +Gender + "\n\n"+"Doctor"+Doctor;
            vouchertypewholesalesother();
        }
        public void MainPrint()
        {
            OPBill();
        }
        public void vouchertypewholesalesother()
        {
            printDocument1.Print();
        }
        public void DotPrint(string Stringname,string ValueName,int XX,int YY,PaintEventArgs e)
        {
            Font headerFont;
            Font mainheaderFont;
            Font normalFont;

           
            headerFont = new System.Drawing.Font("Lucida Console", 10F);
            normalFont = new System.Drawing.Font("Calibri", 12, FontStyle.Regular);

            e.Graphics.DrawString(Stringname, normalFont, Brushes.Black, XX, YY);
            e.Graphics.DrawString(":", normalFont, Brushes.Black, XX+100, YY);
            e.Graphics.DrawString(ValueName, normalFont, Brushes.Black, XX+120, YY);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            string FieldValue = "";
            int CurrentRecord = 0;
            int RecordsPerPage = 25; // twenty items in a page
            int xSlno;
            decimal Amount = 0;
            bool StopReading = false;

            
             int YY = 200;
             int XX = 25;
                Font headerFont;
                Font mainheaderFont;
                Font normalFont;

                    headerFont = new System.Drawing.Font("Lucida Console", 10F);

                    normalFont = new System.Drawing.Font("Calibri", 12, FontStyle.Regular);
                    mainheaderFont = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);
                    string Gender;
                    if (radfemail.Checked == true)
                        Gender = "Mail";
                    else
                        Gender = "Femail";

            string StrVno =txtopno.Text;
            Invoicename = "Out PatientBill";
            string PInvoiceName= Invoicename;

            string Vdate      = Dtdate.Value.ToString("dd-MM-yyyy");
            string Vtime      =Dttime.Value.ToString("hh-mm-ss");
            string Cusnam     =txtpatient.Text;
                   Gender     = Gender;
            string CusMobile  = txtmobile.Text;
            string CusAddress =txtaddress.Text;

            string CusAge     =txtage.Text;
            string Doctor     = comdoctor.Text;

             CusMobile = txtmobile.Text;


            string Datestr =Dtdate.Value.ToString("dd/MM/yyyy");
            //Datestr = "" + Datestr;

            XX = 200;
            e.Graphics.DrawString(PInvoiceName, mainheaderFont, Brushes.Black, XX, YY);
            YY = YY + 25;
            XX = 10;
            DotPrint("OPno", StrVno,XX,YY,e);

            YY = YY + 25;
            DotPrint("Patient Name", Cusnam, XX, YY, e);

            YY = YY + 25;
            DotPrint("Gender", Gender, XX, YY, e);

            YY = YY + 25;
            DotPrint("Mobile", CusMobile, XX, YY, e);

            YY = YY + 25;
            DotPrint("Address", CusAddress, XX, YY, e);
            YY = YY + 25;
            DotPrint("Doctor", Doctor, XX, YY, e);

            YY =225;
            XX = 300;
            DotPrint("Date", Datestr, XX, YY, e);

            YY = YY + 50;
            DotPrint("Time", Vtime, XX, YY, e);

            YY = YY + 25;
            DotPrint("Age", CusAge, XX, YY, e);


            YY = YY + 100;
            XX = 10;
            e.Graphics.DrawLine(Pens.Black, 10, YY, XX + 500, YY);
            YY = YY + 10;

            xSlno = 10;
            
            e.Graphics.DrawString("Sl", normalFont, Brushes.Black, xSlno, YY);
            XX = XX + 25;
           
            int xProductName = xSlno + (int)e.Graphics.MeasureString("SlNo", normalFont).Width + 4;
            e.Graphics.DrawString("Services", normalFont, Brushes.Black, xProductName, YY);
            XX = XX + 200;
            int xRate = xProductName + (int)e.Graphics.MeasureString("Services", normalFont).Width + 200;
            e.Graphics.DrawString("Rate", normalFont, Brushes.Black, xRate, YY);
            XX = XX + 100;
            int xNetamt = xRate + (int)e.Graphics.MeasureString("Rate", normalFont).Width + 75;
            e.Graphics.DrawString("Amount", normalFont, Brushes.Black, xNetamt, YY);
            YY = YY + 25;

            e.Graphics.DrawLine(Pens.Black, 10, YY, 510, YY);

            YY = YY + 10;
            for (int i = 0; i < gridmain.Rows.Count ; i++)
            {

                if (CommonClass._Dbtask.znllString(gridmain.Rows[i].Tag) == "1")
                {
                   

                        FieldValue = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        e.Graphics.DrawString(FieldValue, headerFont, BlackBrush, xSlno, YY);

                        FieldValue = gridmain.Rows[i].Cells["clnitems"].Value.ToString();
                        if (FieldValue.Length > 35)
                            FieldValue = FieldValue.Substring(0, 35);
                        e.Graphics.DrawString(FieldValue, headerFont, BlackBrush, xProductName, YY);
                       // ItemNote = CommonClass._Dbtask.znllString(gridmain.Rows[i].Cells["clnserialno"].Value);


                        //FieldValue = String.Format("{0:0.00}", CommonClass._Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                        //e.Graphics.DrawString(FieldValue, headerFont, BlackBrush, xQty + 20, YY, Str);


                        FieldValue = String.Format("{0:0.00}", CommonClass._Dbtask.gridnul(gridmain.Rows[i].Cells["clnrate"].Value));
                        e.Graphics.DrawString(FieldValue, headerFont, BlackBrush, xRate, YY, Str);



                        FieldValue = String.Format("{0:0.00}", CommonClass._Dbtask.gridnul(gridmain.Rows[i].Cells["clnamount"].Value));
                        e.Graphics.DrawString(FieldValue, headerFont, BlackBrush, xNetamt , YY, Str);


                        //Amount = Convert.ToDecimal(rdrInvoice["ExtendedPrice"]);
                        //// Format Extended Price and Align to Right:
                        //FieldValue = String.Format("{0:0.00}", Amount);
                        //int xAmount = AmountPosition + (int)g.MeasureString("Extended Price", InvoiceFont).Width;
                        //xAmount = xAmount - (int)g.MeasureString(FieldValue, InvoiceFont).Width;
                        //g.DrawString(FieldValue, InvoiceFont, BlackBrush, xAmount, CurrentY);
                        //if (SSlnotracking == true)
                        //    CurrentY = CurrentY + InvoiceFontHeight * 2 + 4;
                        //else
                        //    CurrentY = CurrentY + InvoiceFontHeight + 2;
                        //StopReading = true;

                        //if (!rdrInvoice.Read())
                        //{
                        //    StopReading = true;
                        //    break;
                        //}

                        CurrentRecord++;
                        YY = YY + 25;
                       // TRowcounting = i;
                        //TempRowcounting = TempRowcounting + 1;
                    
                }

            }
            
            if (CurrentRecord < RecordsPerPage)
            {
                for (int i = CurrentRecord; i < RecordsPerPage; i++)
                {
                    e.Graphics.DrawString("",headerFont,BlackBrush,XX,YY);
                    YY = YY + 10;
                }
            }
            e.Graphics.DrawLine(Pens.Black, 10, YY, 510, YY);
            YY = YY + 10;
            e.Graphics.DrawString("Total Amount       :", normalFont, Brushes.Black, 200, YY);
            e.Graphics.DrawString(lbltotalamount.Text ,normalFont, Brushes.Black, xNetamt, YY);
            YY = YY + 25;
            e.Graphics.DrawLine(Pens.Black, 10, YY, 510, YY);
            //else
            //{
            //    e.HasMorePages = true;

            //    TempRowcounting = 0;
            //    TRowcounting = TRowcounting + 1;
            //    // TRowcounting = TRowcounting + 1;
            //}
            //if (StopReading)
            //{
            //    //rdrInvoice.Close();
            //    //cnn.Close();
            //    SetInvoiceTotal(g);
            //}

            //g.Dispose();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            pictureBox1_Paint(sender, new PaintEventArgs(e.Graphics, this.ClientRectangle));
        }

        private void cmdprint_Click(object sender, EventArgs e)
        {
            MainPrint();
        }

        private void Gridsearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRetrive();
        }

        private void txtpatient_TextChanged(object sender, EventArgs e)
        {
            //Declare._Formop.ShowinGrid("select* from tblaccountledger where lname like '%" + txtpatient.Text + "%' and agroupid=18", Gridproductlist, txtpatient);
        }

        private void txtpatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               if (Gridproductlist.Visible == true && Gridproductlist.SelectedRows.Count > 0)
            {
                int SlRow=Gridproductlist.SelectedRows[0].Index;
                if (Gridproductlist.Rows[SlRow].Cells[0].Value != null)
                {
                    Declare._Formop.FillPatientDetails(Gridproductlist.Rows[SlRow].Cells[0].Tag.ToString());
                }
            }
            }
        }

        private void txtpatient_Leave(object sender, EventArgs e)
        {
            Gridproductlist.Visible = false;
        }

        private void Frmop_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

    }
}
