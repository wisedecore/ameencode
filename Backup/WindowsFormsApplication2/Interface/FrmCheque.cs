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
    public partial class FrmCheque : Form
    {
        public FrmCheque()
        {
            InitializeComponent();
        }

        int SelectedRow;
        int Count;
        DBTask _DbTask = new DBTask();
        public int mode;

        public bool WidrawMode = false;
        public static bool Isinotherwindow;
        public bool IsComboFilling = false;

        int CrtIndex = 0;
        long Id;
        DateTime PDate;
        long ALid;
        string AName;
        long BLid;
        string BName;
        double Amount;
        string ChequeNo;
        string Status;
        DateTime CDate;
        DateTime CollectionDate;
        string Note;
        int CMode;
        double totamtt = 0;
        double discountamtt = 0;
        string OldData = "";
        string NewData = "";
        string Action = "NEW";

        public string Vno;
        public bool EditMode;



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

        public void ShowGrid()
        {
            gridmain.Rows.Clear();
            CommonClass.Ds = CommonClass._ClsCheque.Show(" where cmode='" + mode + "' and status != 'Collected'");

            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                Count = gridmain.Rows.Add(1);
                Id = Convert.ToInt64(CommonClass.Ds.Tables[0].Rows[i]["id"]);
                PDate = Convert.ToDateTime(CommonClass.Ds.Tables[0].Rows[i]["pdate"]);
                ALid = Convert.ToInt64(CommonClass.Ds.Tables[0].Rows[i]["alid"]);
                AName = CommonClass._Ledger.GetspecifField("lname", CommonClass.Ds.Tables[0].Rows[i]["alid"].ToString());
                BLid = Convert.ToInt64(CommonClass.Ds.Tables[0].Rows[i]["blid"]);
                BName = CommonClass._Ledger.GetspecifField("lname", CommonClass.Ds.Tables[0].Rows[i]["blid"].ToString());
                Amount = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[i]["amount"]);
                ChequeNo = CommonClass.Ds.Tables[0].Rows[i]["chequeno"].ToString();
                Status = CommonClass.Ds.Tables[0].Rows[i]["status"].ToString();
                CDate = Convert.ToDateTime(CommonClass.Ds.Tables[0].Rows[i]["cdate"]);
                CollectionDate = Convert.ToDateTime(CommonClass.Ds.Tables[0].Rows[i]["colldate"]);
                Note = CommonClass.Ds.Tables[0].Rows[i]["note"].ToString();

                gridmain.Rows[Count].Cells["clnvno"].Value = Id;
                gridmain.Rows[Count].Cells["clndate"].Value = PDate;
                gridmain.Rows[Count].Cells["clnparty"].Value = AName;
                gridmain.Rows[Count].Cells["clnparty"].Tag = ALid;
                gridmain.Rows[Count].Cells["clnbank"].Value = BName;
                gridmain.Rows[Count].Cells["clnbank"].Tag = BLid;
                gridmain.Rows[Count].Cells["clnamount"].Value = Amount;
                gridmain.Rows[Count].Cells["clnchequeno"].Value = ChequeNo;
                gridmain.Rows[Count].Cells["clnstatus"].Value = Status;
                gridmain.Rows[Count].Cells["clncqdate"].Value = CDate.ToString("dd/MM/yyyy");
                gridmain.Rows[Count].Cells["clncolldate"].Value = CollectionDate.ToString("dd/MM/yyyy");
                gridmain.Rows[Count].Cells["clnnote"].Value = Note;

            }
        }

        public void Insert()
        {
           CommonClass._ClsCheque.InsertCheque();

            if (GrdBillSett.Visible == true)
            {
                for (int i = 0; i < GrdBillSett.Rows.Count; i++)
                {
                    if (GrdBillSett.Rows[i].Tag.ToString() == "1")
                    {

                        // CommonClass._BillSett.InsertBillsettlement(txtvno.textBox1.Text.ToString(), "ChR", Convert.ToInt64(ALid), _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value), 0, GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString(), Dtcollecteddate.Value, Convert.ToInt16(ComStaff.SelectedValue));
                        if (mode == 0)
                        {
                            //CommonClass._ChequeAgainstBill.InsertValues(txtvno.textBox1.Text, GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString(), "ChR", _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value), _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value));
                        }
                        if (mode == 1)
                        {
                            //CommonClass._ChequeAgainstBill.InsertValues(txtvno.textBox1.Text, GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString(), "ChP", _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value), _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value));
                        }
                    }
                }
                if (comstatus.Text == "Collected")
                {
                    //   CommonClass._BillSett.InsertBillsettlement(txtvno.textBox1.Text.ToString(), "ChR", Convert.ToInt64(ALid), Convert.ToDouble(txtamount.textBox1.Text), 0, Txtagainstbillno.textBox1.Text, Dtcollecteddate.Value, Convert.ToInt16(ComStaff.SelectedValue));
                    //  txtvno.textBox1.Tag

                    for (int i = 0; i < GrdBillSett.Rows.Count; i++)
                    {
                        if (GrdBillSett.Rows[i].Tag.ToString() == "1")
                        {
                            if (mode == 0)
                            {
                                // CommonClass._BillSett.InsertBillsettlement(txtvno.textBox1.Text.ToString(), "ChR", Convert.ToInt64(ALid), _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value), 0, GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString(), Dtcollecteddate.Value, Convert.ToInt16(ComStaff.SelectedValue));
                            }
                            if (mode == 1)
                            {
                               // CommonClass._PurchaseBillSett.InsertBillSet(Dtcollecteddate.Value, txtvno.textBox1.Text.ToString(), "ChP", ALid.ToString(), _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value), 0, GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString());
                            }
                            //CommonClass._ChequeAgainstBill.InsertValues(txtvno.textBox1.Text, GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString (), "ChR", _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value), _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value));
                        }                                                             
                    }
                }
            }
        }

        public string GenerateNaration()
        {
            return "Cheque No:" + TxtCheqNo.Text + " ,Cheque Date :" + Dtpaiddate.Value.ToString("dd/MM/yyyy");
        }

        public void InsertAccounts()
        {
            if (Status == "Collected")
            {
                CommonClass._GenLedger.VnoStr = txtvno.textBox1.Text;
                CommonClass._GenLedger.VdateDt = Dtcollecteddate.Value;

                CommonClass._GenLedger.SlNoLng = 1;
                CommonClass._GenLedger.Naration = GenerateNaration();
                CommonClass._GenLedger.RefnoStr = "";

                CommonClass._GenLedger.PurticularsStr = "";

                CommonClass._ClsCheque.GenId = Convert.ToInt64(CommonClass._GenLedger.VnoStr);

                /*For Bank Receipt*/
                if (mode == 0)
                {
                    CommonClass._GenLedger.VTypeStr = "ChR";
                    CommonClass._GenLedger.LedCodeStr = BLid.ToString();
                    CommonClass._GenLedger.DbAmtDb = Amount;
                    CommonClass._GenLedger.CrAmt = 0;
                    CommonClass._GenLedger.InsertGeneralLedger();

                    CommonClass._GenLedger.LedCodeStr = ALid.ToString();
                    CommonClass._GenLedger.DbAmtDb = 0;
                    CommonClass._GenLedger.CrAmt = totamtt;
                    CommonClass._GenLedger.Discount = discountamtt;
                    CommonClass._GenLedger.InsertGeneralLedger();
                    CommonClass._auditlog.SaveNewAuditLog(Action, "", "Cheque Receipt", NewData, OldData);


                    if (discountamtt > 0)
                    {
                        string disallwd = CommonClass._Ledger.ReturnLedid("DISCOUNT ALLOWED");


                        CommonClass._GenLedger.VTypeStr = "ChR";
                        //CommonClass._GenLedger.LedCodeStr = BLid.ToString();
                        CommonClass._GenLedger.LedCodeStr = disallwd;
                        CommonClass._GenLedger.DbAmtDb = discountamtt;
                        CommonClass._GenLedger.CrAmt = 0;
                        CommonClass._GenLedger.InsertGeneralLedger();
                    }







                }

                 /*For Bank Payment*/
                else if (mode == 1)
                {
                    CommonClass._GenLedger.VTypeStr = "ChP";
                    CommonClass._GenLedger.LedCodeStr = BLid.ToString();
                    CommonClass._GenLedger.DbAmtDb = 0;
                    CommonClass._GenLedger.CrAmt = Amount;
                    CommonClass._GenLedger.InsertGeneralLedger();


                    CommonClass._GenLedger.LedCodeStr = ALid.ToString();
                    CommonClass._GenLedger.DbAmtDb = Amount;
                    CommonClass._GenLedger.CrAmt = 0;
                    CommonClass._GenLedger.InsertGeneralLedger();
                    CommonClass._auditlog.SaveNewAuditLog(Action, "", "Cheque Payment", NewData, OldData);
                }
            }
            else
            {
                CommonClass._ClsCheque.GenId = 0;
            }
        }



        public void Clear()
        {
            EditMode = false;
            GetVno();
            FillCombo();
            Mnusettings();

            txtamount.textBox1.Text = _DbTask.SetintoDecimalpoint(0);
            TxtCheqNo.Text = "";
            Dtchequedate.Value = DateTime.Now;
            comstatus.SelectedIndex = -1;
            Dtcollecteddate.Value = DateTime.Now;
            txtnote.textBox1.Text = "";
            GrdBillSett.Rows.Clear();
            txtdiscount.textBox1.Text = "0";

            ShowGrid();
            if (Vno != null)
            {

                Search(Vno.ToString(), mode.ToString());
            }
        }

        public void DeleteLedger()
        {
            CommonClass._ClsCheque.DeleteCheque(txtvno.textBox1.Text, mode.ToString());
        }

        public void NextgInitialize()
        {
            NewData = "";
            Id = Convert.ToInt64(txtvno.textBox1.Text);
            PDate = Dtpaiddate.Value;
            ALid = Convert.ToInt64(TxtAccount.Tag);
            BLid = Convert.ToInt64(Combankaccount.SelectedValue);

            //Amount = CommonClass._Dbtask.znullDouble(txtamount.textBox1.Text);
            Amount = CommonClass._Dbtask.znullDouble(txtrecvdamtt.textBox1.Text);
            ChequeNo = TxtCheqNo.Text;
            Status = comstatus.Text;
            CDate = Dtchequedate.Value;
            Note = txtnote.textBox1.Text;
            CMode = mode;
            CollectionDate = Convert.ToDateTime(Dtcollecteddate.Value);
            discountamtt = CommonClass._Dbtask.znullDouble(txtdiscount.textBox1.Text);
            totamtt = CommonClass._Dbtask.znullDouble(txtamount.textBox1.Text);



            NewData = "Vno : " + Id.ToString() + ", Party : " + TxtAccount.Tag.ToString() + ",Date : " + Dtcollecteddate.Value.ToString() + ",Amount : " + txtamount.textBox1.Text;

            CommonClass._ClsCheque.Id = Id;
            CommonClass._ClsCheque.PDate = PDate;
            CommonClass._ClsCheque.ALid = ALid;
            CommonClass._ClsCheque.BLid = BLid;
            //CommonClass._ClsCheque.Amount = Amount;
            CommonClass._ClsCheque.ChequeNo = ChequeNo;
            CommonClass._ClsCheque.Status = Status;
            CommonClass._ClsCheque.CDate = CDate;
            CommonClass._ClsCheque.Note = Note;
            CommonClass._ClsCheque.CMode = CMode;
            CommonClass._ClsCheque.CollDate = CollectionDate;
            CommonClass._ClsCheque.Agvno = "";
            CommonClass._ClsCheque.Emp = Convert.ToInt16(ComStaff.SelectedValue);
            CommonClass._ClsCheque.DISAmount = discountamtt;
            CommonClass._ClsCheque.totalAmount = totamtt;
            CommonClass._ClsCheque.Amount = Amount;




        }

        public void FillCombo()
        {
            //CommonClass._Ledger.FillComboWhereNormal(Combankaccount, " where   AGroupId=24 ");
            //CommonClass._Ledger.FillComboSupplierandCustomer(comaccount);   
            IsComboFilling = true;
            Generalfunction.FillCombo(Combankaccount, "LName", "Lid", "TblAccountLedger", "None", "where   AGroupId=24");
            //Generalfunction.FillCombo(comaccount, "LName", "Lid", "TblAccountLedger", "None", "where   AGroupId=19 Or AGroupId=18");
            Generalfunction.FillCombo(ComStaff, "LName", "Lid", "TblAccountLedger", "None", "where AGroupId=22");
            IsComboFilling = false;
        }

        private bool Main()
        {
            //if (SaveUserPrevilage() == false)
            //{
            //    return false;
            //}
            if (ValidationFu() && billlgridvalidation())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteLedger();
                    }
                    else
                    {
                        GetVno();
                    }
                    NextgInitialize();
                    InsertAccounts();
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

        public void GetVno()
        {
            txtvno.textBox1.Text = CommonClass._ClsCheque.GetMax(mode.ToString()).ToString();
        }

        public void Mnusettings()
        {
            if (mode == 0)
            {
                this.Text = "Cheque Receipt";
            }
            else if (mode == 1)
            {
                this.Text = "Cheque Payment";
            }
        }
        //public bool EditUserPrevilage()
        //{
        //    bool Permission = true;
        //    if (mode == 0)
        //    {
        //        if (ClsUserAccess.HavePermission("34", "Edit") == false)
        //        {
        //            MessageBox.Show("You Don't Have Permission To Edit Cheque Receipt. Please Contact With Admin...", NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            Permission = false;
        //        }
        //    }
        //    if (mode == 1)
        //    {
        //        if (ClsUserAccess.HavePermission("36", "Edit") == false)
        //        {
        //            MessageBox.Show("You Don't Have Permission To Edit Cheque Payment. Please Contact With Admin...", NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            Permission = false;
        //        }
        //    }
        //    return Permission;
        //}
        //public bool SaveUserPrevilage()
        //{
        //    bool Permission = true;
        //    if (mode == 0)
        //    {
        //        if (ClsUserAccess.HavePermission("34", "New") == false)
        //        {
        //            MessageBox.Show("You Don't Have Permission To Save Cheque Receipt. Please Contact With Admin...", NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            Permission = false;
        //        }
        //    }
        //    if (mode == 1)
        //    {
        //        if (ClsUserAccess.HavePermission("36", "New") == false)
        //        {
        //            MessageBox.Show("You Don't Have Permission To Save Cheque Payment. Please Contact With Admin...", NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            Permission = false;
        //        }
        //    }
        //    return Permission;
        //}
        public void LoadPartyOnGrid(string GroupId, string NameLike)
        {
            string Sql = "Select * From TblAccountLedger Where AgroupId in (" + GroupId + ") And LName Like '%" + NameLike + "%'";
            DataSet Ds = CommonClass._Dbtask.ExecuteQuery(Sql);
            GridAccount.Location = new Point(TxtAccount.Location.X, TxtAccount.Location.Y + TxtAccount.Size.Height);
            GridAccount.Visible = true;
            GridAccount.Rows.Clear();
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    GridAccount.Rows.Add(1);
                    GridAccount.Rows[i].Cells["ClnAccount"].Value = Ds.Tables[0].Rows[i]["LName"];
                    GridAccount.Rows[i].Cells["ClnAccount"].Tag = Ds.Tables[0].Rows[i]["Lid"];
                    GridAccount.Rows[i].Selected = false;
                }
                GridAccount.Rows[0].Selected = true;
            }
        }
        private void FrmCheque_Load(object sender, EventArgs e)
        {
            CommonClass._Nextg.FormIcon(this);
            Clear();
            if (mode == 0)
            {
                GrdBillSett.Visible = true;
            }
            if (mode == 1)
            {
                GrdBillSett.Visible = true;
            }


            CommonClass._Nextg.FormIcon(this);
        }
        public void ShowMessage(string Text)
        {
            MessageBox.Show(Text, NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool AgainstBillValidation()
        {
            double NetAgAmt = 0;

            for (int i = 0; i < GrdBillSett.Rows.Count; i++)
            {
                NetAgAmt = NetAgAmt + _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value);

                if (_DbTask.znllString(GrdBillSett.Rows[i].Cells["ClnBillVno"].Value) == "" || _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value) == 0)
                {
                    GrdBillSett.Rows[i].Tag = "0";
                }
                else
                {
                    GrdBillSett.Rows[i].Tag = "1";
                }
            }
            if (NetAgAmt > _DbTask.znlldoubletoobject(txtamount.textBox1.Text))
            {
                MessageBox.Show("Cannot Save While Total BillAgainst Amount Is GratorThan Bill Amount...", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtamount.textBox1.Focus();
                return false;
            }

            return true;
        }

        public bool billlgridvalidation()
        {
            double sumofbillset = 0;
            double value = 0;
            try
            {
                for (int i = 0; i < GrdBillSett.Rows.Count; i++)
                {
                    if (GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value != null)
                    {
                        GrdBillSett.Rows[i].Tag = "1";
                        double billsetamt = _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value);
                        sumofbillset = sumofbillset + billsetamt;
                    }
                    else
                    {
                        if (GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value == null || _DbTask.znlldoubletoobject(GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value) == 0)
                        {
                            GrdBillSett.Rows[i].Tag = "0";
                        }

                    }

                    value = _DbTask.znlldoubletoobject(txtamount.textBox1.Text);
                    //if(value>sumofbillset)
                    // {
                    //  MessageBox.Show("Billsettled amount is grater than cheque amount", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //  GrdBillSett.Rows[i].DefaultCellStyle.BackColor = Color.Goldenrod;
                    //  return false;

                    //}


                }



                if (value < sumofbillset)
                {
                    MessageBox.Show("Billsettled amount is grater than cheque amount", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //GrdBillSett.Rows[row].DefaultCellStyle.BackColor = Color.Goldenrod;
                    GrdBillSett.DefaultCellStyle.BackColor = Color.Goldenrod;
                    return false;

                }





            }
            catch
            {
            }
            return true;

        }


        private bool ValidationFu()
        {
            Amount = CommonClass._Dbtask.znlldoubletoobject(txtamount.textBox1.Text);
            ChequeNo = TxtCheqNo.Text;

            if (_DbTask.znlldoubletoobject(TxtAccount.Tag) == 0)
            {
                ShowMessage("Select Account");
                TxtAccount.Focus();
                return false;
            }
            if (Combankaccount.SelectedValue.ToString() == "0")
            {
                ShowMessage("Select Bank Account");
                Combankaccount.Focus();
                return false;
            }

            if (Amount == 0)
            {
                MessageBox.Show("Please Enter Amount", NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtamount.textBox1.Focus();
                return false;
            }

            if (ChequeNo == "")
            {
                MessageBox.Show("Please Enter ChequeNo", NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCheqNo.Focus();
                return false;
            }
            if (comstatus.Text == "")
            {
                ShowMessage("Select Status Of The Cheque");
                comstatus.Focus();
                return false;
            }
            if (EditMode == false)
            {
                DataSet DsChq = CommonClass._Dbtask.ExecuteQuery("select * from Tblchqreceived where ChequeNo='" + ChequeNo + "'");
                if (DsChq.Tables[0].Rows.Count > 0)
                {
                    ShowMessage("Cheque No Already Exist");
                    TxtCheqNo.Focus();
                    return false;
                }
            }




            //if (AgainstBillValidation() == false)
            //{
            //    return false;
            //}
            return true;
        }
        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Search(string TempId, string TempMode)
        {
            //if (EditUserPrevilage() == false)
            //{
            //    return;
            //}
            if (_DbTask.znlldoubletoobject(TempId) != 0)
            {
                string Sql = "Select * From TblChqReceived Where Id = " + TempId + " And CMode = " + TempMode;
                DataSet DS = _DbTask.ExecuteQuery(Sql);
                if (DS.Tables[0].Rows.Count > 0 || Convert.ToInt32(TempId) > 0)
                {
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        WidrawMode = true;
                        EditMode = true;
                        OldData = "";

                        Id = Convert.ToInt64(DS.Tables[0].Rows[0]["id"].ToString());
                        PDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["Pdate"].ToString());
                        ALid = Convert.ToInt64(DS.Tables[0].Rows[0]["ALid"].ToString());
                        BLid = Convert.ToInt64(DS.Tables[0].Rows[0]["BLid"].ToString());
                        Amount = CommonClass._Dbtask.znlldoubletoobject(DS.Tables[0].Rows[0]["totamt"].ToString());
                        ChequeNo = DS.Tables[0].Rows[0]["ChequeNo"].ToString();
                        Status = DS.Tables[0].Rows[0]["Status"].ToString();
                        CDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["CDate"].ToString());
                        CollectionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["CollDate"].ToString());
                        string empidd = _DbTask.znllString(DS.Tables[0].Rows[0]["emp"]);

                        ComStaff.Text = CommonClass._Employee.GetspecifField("empname", empidd).ToString();

                        Note = _DbTask.znllString( DS.Tables[0].Rows[0]["Note"]);
                        discountamtt = CommonClass._Dbtask.znlldoubletoobject(DS.Tables[0].Rows[0]["discount"].ToString());

                        txtrecvdamtt.textBox1.Text = CommonClass._Dbtask.znlldoubletoobject(DS.Tables[0].Rows[0]["amount"]).ToString();
                        txtdiscount.textBox1.Text = CommonClass._Dbtask.znlldoubletoobject(discountamtt).ToString();


                        txtvno.textBox1.Text = Id.ToString();
                        Dtpaiddate.Value = PDate;
                        //comaccount.SelectedValue = ALid;
                        TxtAccount.Tag = ALid;
                        TxtAccount.Text = CommonClass._Ledger.GetspecifField("LName", ALid.ToString());
                        GridAccount.Visible = false;
                        Combankaccount.SelectedValue = BLid;
                        txtamount.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Amount);
                        comstatus.Text = Status;
                        Dtchequedate.Value = CDate;
                        TxtCheqNo.Text = ChequeNo;
                        Dtcollecteddate.Value = CollectionDate;
                        txtnote.textBox1.Text = Note;

                        if (mode == 0)
                        {
                            //FillAgainstVnoGrid();
                        }
                        if (mode == 1)
                        {
                            //FillPurchaseAgainstVnoInGrid();
                        }
                        OldData = "Vno : " + Id.ToString() + ", Party : " + TxtAccount.Text + ",Date : " + Dtcollecteddate.Value.ToString() + ",Amount : " + txtamount.textBox1.Text;

                        if (comstatus.Text == "Collected")
                        {
                            Action = "UPDATE";
                        }
                        else
                        {
                            Action = "NEW";
                        }
                        WidrawMode = false;
                    }
                    else
                    {
                        Clear();
                        if (Convert.ToInt32(TempId) < CommonClass._ClsCheque.GetMax(mode.ToString()))
                        {
                            txtvno.textBox1.Text = TempId;
                            EditMode = true;
                        }
                    }
                }

            }
        }

        public void DoubleClick()
        {
            //if (EditUserPrevilage() == false)
            //{
            //    return;
            //}
            SelectedRow = gridmain.SelectedRows[0].Index;
            if (gridmain.Rows[SelectedRow].Cells["clnvno"].Value != null)
            {
                Search(gridmain.Rows[SelectedRow].Cells["clnvno"].Value.ToString(), mode.ToString());

                //Id =Convert.ToInt64(gridmain.Rows[SelectedRow].Cells["clnvno"].Value.ToString());
                //PDate = Convert.ToDateTime(gridmain.Rows[SelectedRow].Cells["clndate"].Value);
                //ALid =Convert.ToInt64(gridmain.Rows[SelectedRow].Cells["clnparty"].Tag);
                //BLid =Convert.ToInt64(gridmain.Rows[SelectedRow].Cells["clnbank"].Tag);
                //Amount = CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[SelectedRow].Cells["clnamount"].Value);
                //ChequeNo = gridmain.Rows[SelectedRow].Cells["clnchequeno"].Value.ToString();
                //Status = gridmain.Rows[SelectedRow].Cells["clnstatus"].Value.ToString();
                //CDate = Convert.ToDateTime(gridmain.Rows[SelectedRow].Cells["clncQdate"].Value);
                //CollectionDate = Convert.ToDateTime(gridmain.Rows[SelectedRow].Cells["clncolldate"].Value);
                //Note=gridmain.Rows[SelectedRow].Cells["clnnote"].Value.ToString();


                //txtvno.textBox1.Text = Id.ToString();
                //Dtpaiddate.Value = PDate;
                //comaccount.SelectedValue = ALid;
                //Combankaccount.SelectedValue = BLid;
                //txtamount.textBox1.Text = CommonClass._Dbtask.SetintoDecimalpoint(Amount);
                //comstatus.Text = Status;
                //Dtchequedate.Value = CDate;
                //TxtCheqNo.Text = ChequeNo;
                //Dtcollecteddate.Value = CollectionDate;
                //txtnote.textBox1.Text = Note;
                //EditMode = true;
            }
        }

        private void gridmain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DoubleClick();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FrmCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            Search((Convert.ToInt32(txtvno.textBox1.Text) - 1).ToString(), mode.ToString());
        }
        public void FillPurchaseAgainstVnoInGrid()
        {
            if (IsComboFilling == true)
            {
                return;
            }
            GrdBillSett.Rows.Clear();
            //ComboBox TempCmb = new ComboBox();
            if (WidrawMode == false && CommonClass._ClsCheque.GetSpesificField("ALid", txtvno.textBox1.Text, mode.ToString()) != TxtAccount.Tag.ToString())
            {
                DataSet Ds = CommonClass._PurchaseBillSett.GetPendingBillListOfSupplier(TxtAccount.Tag.ToString());

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    GrdBillSett.Rows.Add(1);
                    GrdBillSett.Rows[i].Cells["ClnBillVno"].Value = Ds.Tables[0].Rows[i]["Vno"].ToString();
                    GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._PurchaseBillSett.GetBillWiseBalence(GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString()));
                    GrdBillSett.Rows[i].Cells["ClnBillBalence"].Tag = GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value;
                }
            }
            else
            {
                GrdBillSett.Rows.Clear();
                DataSet Ds = CommonClass._ChequeAgainstBill.GetSettleMentDetails(txtvno.textBox1.Text, "ChP");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        GrdBillSett.Rows.Add(1);

                        GrdBillSett.Rows[i].Cells["ClnBillVno"].Value = Ds.Tables[0].Rows[i]["BillVno"];
                        GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value = _DbTask.SetintoDecimalpoint(_DbTask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Balence"]));
                        GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value = _DbTask.SetintoDecimalpoint(_DbTask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Amount"]));
                        GrdBillSett.Rows[i].Cells["ClnBillBalence"].Tag = _DbTask.SetintoDecimalpoint(_DbTask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Balence"]) + _DbTask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Amount"]));
                    }
                }
                else
                {
                    //GrdBillSett.Rows.Add(1);

                    //GrdBillSett.Rows[0].Cells["ClnBillVno"].Value = Txtagainstbillno.textBox1.Text;
                    //GrdBillSett.Rows[0].Cells["ClnBillBalence"].Value = "(UnKnown)";
                    //GrdBillSett.Rows[0].Cells["ClnAgAmt"].Value = _DbTask.SetintoDecimalpoint(_DbTask.znlldoubletoobject(txtamount.textBox1.Text));
                    //GrdBillSett.Rows[0].Cells["ClnBillBalence"].Tag = 0;
                    Ds = CommonClass._PurchaseBillSett.GetPendingBillListOfSupplier(TxtAccount.Tag.ToString());

                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        GrdBillSett.Rows.Add(1);
                        GrdBillSett.Rows[i].Cells["ClnBillVno"].Value = Ds.Tables[0].Rows[i]["Vno"].ToString();
                        GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._PurchaseBillSett.GetBillWiseBalence(GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString()));
                        GrdBillSett.Rows[i].Cells["ClnBillBalence"].Tag = GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value;
                    }
                }
            }
        }
        public void FillAgainstVnoGrid()
        {
            if (IsComboFilling == true)
            {
                return;
            }
            GrdBillSett.Rows.Clear();
            ComboBox TempCmb = new ComboBox();
            if (WidrawMode == false && CommonClass._ClsCheque.GetSpesificField("ALid", txtvno.textBox1.Text, mode.ToString()) != TxtAccount.Tag.ToString())
            {
                CommonClass._BillSett.FillpendingbillCombo(TxtAccount.Tag.ToString(), TempCmb);
                for (int i = 0; i < TempCmb.Items.Count; i++)
                {
                    GrdBillSett.Rows.Add(1);
                    GrdBillSett.Rows[i].Cells["ClnBillVno"].Value = TempCmb.Items[i].ToString();
                    GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._BillSett.GetBillWiseBalence(GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString()));
                    GrdBillSett.Rows[i].Cells["ClnBillBalence"].Tag = GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value;
                }
            }
            else
            {
                GrdBillSett.Rows.Clear();
                DataSet Ds = CommonClass._ChequeAgainstBill.GetSettleMentDetails(txtvno.textBox1.Text, "ChR");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        GrdBillSett.Rows.Add(1);

                        GrdBillSett.Rows[i].Cells["ClnBillVno"].Value = Ds.Tables[0].Rows[i]["BillVno"];
                        GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value = _DbTask.SetintoDecimalpoint(_DbTask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Balence"]));
                        GrdBillSett.Rows[i].Cells["ClnAgAmt"].Value = _DbTask.SetintoDecimalpoint(_DbTask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Amount"]));
                        GrdBillSett.Rows[i].Cells["ClnBillBalence"].Tag = _DbTask.SetintoDecimalpoint(_DbTask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Balence"]) + _DbTask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Amount"]));
                    }
                }
                else
                {
                    //GrdBillSett.Rows.Add(1);

                    //GrdBillSett.Rows[0].Cells["ClnBillVno"].Value = Txtagainstbillno.textBox1.Text;
                    //GrdBillSett.Rows[0].Cells["ClnBillBalence"].Value = "(UnKnown)";
                    //GrdBillSett.Rows[0].Cells["ClnAgAmt"].Value = _DbTask.SetintoDecimalpoint(_DbTask.znlldoubletoobject(txtamount.textBox1.Text));
                    //GrdBillSett.Rows[0].Cells["ClnBillBalence"].Tag = 0;
                    CommonClass._BillSett.FillpendingbillCombo(TxtAccount.Tag.ToString(), TempCmb);
                    for (int i = 0; i < TempCmb.Items.Count; i++)
                    {
                        GrdBillSett.Rows.Add(1);
                        GrdBillSett.Rows[i].Cells["ClnBillVno"].Value = TempCmb.Items[i].ToString();
                        GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._BillSett.GetBillWiseBalence(GrdBillSett.Rows[i].Cells["ClnBillVno"].Value.ToString()));
                        GrdBillSett.Rows[i].Cells["ClnBillBalence"].Tag = GrdBillSett.Rows[i].Cells["ClnBillBalence"].Value;
                    }
                }

            }
        }
        public void LoadPartyFromGridToBox()
        {

            if (GridAccount.SelectedRows.Count > 0)
            {
                int Index = GridAccount.SelectedRows[0].Index;
                if (CommonClass._Dbtask.znlldoubletoobject(GridAccount.Rows[Index].Cells["ClnAccount"].Tag) != 0)
                {
                    TxtAccount.Tag = CommonClass._Dbtask.znllString(GridAccount.Rows[Index].Cells["ClnAccount"].Tag);
                    TxtAccount.Text = CommonClass._Dbtask.znllString(GridAccount.Rows[Index].Cells["ClnAccount"].Value);
                    GridAccount.Visible = false;
                }
            }
        }
        private void CmdFront_Click(object sender, EventArgs e)
        {
            Search((Convert.ToInt32(txtvno.textBox1.Text) + 1).ToString(), mode.ToString());
        }
        void txt_TextChanged(object sender, EventArgs e)
        {
            string ColName = GrdBillSett.Columns[GrdBillSett.CurrentCell.ColumnIndex].Name.ToString();
            GrdBillSett.Rows[CrtIndex].Cells[ColName].Value = (sender as TextBox).Text;

            if (ColName == "ClnAgAmt")
            {
                GrdBillSett.Rows[CrtIndex].Cells["ClnBillBalence"].Value = _DbTask.znlldoubletoobject(GrdBillSett.Rows[CrtIndex].Cells["ClnBillBalence"].Tag) - _DbTask.znlldoubletoobject(GrdBillSett.Rows[CrtIndex].Cells["ClnAgAmt"].Value);
            }
        }
        private void GrdBillSett_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            //txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            //txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);


            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);
        }

        private void GrdBillSett_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CrtIndex = e.RowIndex;
        }

        private void comaccount_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mode == 0)
            {
               // FillAgainstVnoGrid();
            }
            if (mode == 1)
            {
                //FillPurchaseAgainstVnoInGrid();
            }

        }

        private void txtdiscount_TextChanged(object Sender, EventArgs e)
        {
            double amount = _DbTask.znlldoubletoobject(txtamount.textBox1.Text);
            double disamt = _DbTask.znlldoubletoobject(txtdiscount.textBox1.Text);
            double finlamt = amount - disamt;

            txtrecvdamtt.textBox1.Text = finlamt.ToString();
        }

        private void txtamount_TextChanged(object Sender, EventArgs e)
        {
            double amount = _DbTask.znlldoubletoobject(txtamount.textBox1.Text);
            txtrecvdamtt.textBox1.Text = _DbTask.znlldoubletoobject(txtamount.textBox1.Text).ToString();
            double disamt = _DbTask.znlldoubletoobject(txtdiscount.textBox1.Text);
            if (disamt > 0)
            {
                txtrecvdamtt.textBox1.Text = (amount - disamt).ToString();

            }

        }

        private void TxtAccount_TextChanged(object sender, EventArgs e)
        {
            LoadPartyOnGrid("18,19", TxtAccount.Text);
        }

        private void TxtAccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            {
            if (e.KeyValue == 13)
            {
                LoadPartyFromGridToBox();

                if (mode == 0)
                {
                   
                    //FillAgainstVnoGrid();
                }
                if (mode == 1)
                {

                    //FillPurchaseAgainstVnoInGrid();
                }
            }

            else
            {
                Generalfunction.ChangeGridSelection(GridAccount, e.KeyValue);
            }
        }
    }
}
