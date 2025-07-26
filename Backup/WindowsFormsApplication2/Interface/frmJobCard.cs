using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class frmJobCard : Form
    {
        public frmJobCard()
        {
            InitializeComponent();
        }
        NextGFuntion _Nextg = new NextGFuntion();
        ClsAddenquiry _Addenq = new ClsAddenquiry();
        ClsAccountLedger _AccLed = new ClsAccountLedger();
        Clsfields _Fileds = new Clsfields();
        Clssales _sales = new Clssales();
        ClsIssueDetails _Issuedetails = new ClsIssueDetails();
        DBTask _Dbtask = new DBTask();
        ClsInGrid _ingrid = new ClsInGrid();
        ClsBusinessIssue _Bussinessissue = new ClsBusinessIssue();
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        DataSet Ds = new DataSet();
        DataSet Ds2 = new DataSet();
     //   Frmsalespos _Frmpos = new Frmsalespos();


        public bool EditMode = false;
        bool IsEnter = false;
        public bool Isinotherwindow = false;
        public string WhereCountryList;
        public string Status;
        public string AllEmployee;
        public string AllProduct;
        public string AllAgent;
        int selectedRow;
        public string sql = "";
        public static string ProductVno="0";
        public int Retrivemode = 0;
        public string AgentId;
        public string EmpId;
        public string VType = "JOB";
        public bool cusprof;

        public string StockAreaid = "0";
        public string columname;
        public int columIndex;
        public int rowIndex;
        public bool searchbarcode = true;
        public string Itemname;
        public string itemcode;
        public string Srate;
        public string ItemId;
        public string batchcode;
        public int retrivemode = 0;
        public int selectedrow1;
        public string temp;
        public string jobcardId;
        public int select1;

        public double NQTY;
        public double NRATE;
        public double NAMOUNT;
        public double NTOTAL = 0;
        public double Nntotal;

        public double Netqty = 0;
        public double NetAmount = 0;
        public double NetRate = 0;
        public double NetTotal = 0;
        public string SalesAccount;
        public double Stock1;
        
        /*menu settings*/
        public string Printerselect;
        public bool Sitemwiseagentcommision = false;
        public bool SBatch = false;
        public bool SSitemDiscount = false;
        public bool SSfree = false;
        public bool Seditsrate = false;
        public bool STax = false;
        public bool SDepo = false;
        public bool Smrate = false;
        public bool Smunit = false;
        public bool Sagent = false;
        public bool Bmode;
        public bool Semployee = false;
        public bool Supdatesrate = false;
        public bool Useasbarcode = false;
        public bool SSsizes = false;
        public bool Sprintwhilesaving = false;
        public bool Spconfirmation = false;
        public bool SprintPreview = false;
        public bool SFlex;
        public bool SCashDesk;
        public bool SSerialnotracking;
        public bool Sinvoicediscount;

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
                if (Gridcustomerlist.Visible == true)
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Down)
                    {
                        // SendKeys.Send("{Tab}");
                        return true;
                    }
                    if (msg.WParam.ToInt32() == (int)Keys.Up)
                    {
                        //SendKeys.Send("{Tab}");
                        return true;

                    }
                }

                if (uscitemshowsimple1.Visible == true)
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Down)
                    {
                        // SendKeys.Send("{Tab}");
                        return true;
                    }
                    if (msg.WParam.ToInt32() == (int)Keys.Up)
                    {
                        //SendKeys.Send("{Tab}");
                        return true;

                    }
                }
                if (uscGridshow2.Visible == true)
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Down)
                    {
                        // SendKeys.Send("{Tab}");
                        return true;
                    }
                    if (msg.WParam.ToInt32() == (int)Keys.Up)
                    {
                        //SendKeys.Send("{Tab}");
                        return true;

                    }
                }
            }
            
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void frmAddenquiry_Load(object sender, EventArgs e)
        {
            showingrid();
            _Nextg.FormStylesett(this);
            _Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlBottom);
            _Nextg.FormHeadStyle(pnlHead);
          //  _Nextg.FormImage(pnlImage);
            Fillstatus();
            FillCountry();
            FillState();
           // Fillcountry();
            FillAllEmployee();
            FillCombo();
            //FillProducts();
            FillallAgent();
           // Textsett();
            Clear();
            txtName.Focus();
            CommonClass._Nextg.FormIcon(this); 
            
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearControls()
        {
            _Nextg.ClearControles(this); 
        }

        private void lnkMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generalfunction.combselect = "mode";
            _Addenq.pnlLocation(pnlCreate, 525, 119);
            sql = "select Name from TblFields where id=41";
            Ds = _Dbtask.ExecuteQuery(sql);
            lbxAdd.Items.Clear();
            txtadd.Text = "";
            for (int i = 0; i <= Ds.Tables[0].Rows.Count - 1; i++)
            {
                lbxAdd.Items.Add(Ds.Tables[0].Rows[i][0]);
            }
            txtadd.Focus();
            txtadd.Clear();

        }

        private void cmdClosepanel_Click(object sender, EventArgs e)
        {
            pnlCreate.Visible = false;
        }

        private void lnkEnquiry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generalfunction.combselect = "About";
            _Addenq.pnlLocation(pnlCreate, 525, 125); 
            sql = "select Name from TblFields where id=42";
            Ds = _Dbtask.ExecuteQuery(sql);
            lbxAdd.Items.Clear();
            txtadd.Text = "";
            for (int i = 0; i <= Ds.Tables[0].Rows.Count - 1; i++)
            {
                lbxAdd.Items.Add(Ds.Tables[0].Rows[i][0]);
            }
            txtadd.Focus();
            txtadd.Clear();
        }

        private void lnkResponse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generalfunction.combselect = "Response";
            _Addenq.pnlLocation(pnlCreate, 525, 152);
            sql = "select Name from TblFields where id=43";
            Ds = _Dbtask.ExecuteQuery(sql);
            lbxAdd.Items.Clear();
            txtadd.Text = "";
            for (int i = 0; i <= Ds.Tables[0].Rows.Count - 1; i++)
            {
                lbxAdd.Items.Add(Ds.Tables[0].Rows[i][0]);
            }
            txtadd.Focus();
            txtadd.Clear(); 
        }
        private bool ValidationFu()
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(txtemail.Text, pattern) || txtemail.Text == "")
            {

                if (txtName.Text == "")
                {
                    MessageBox.Show("Please Enter the Customer", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                }

                if (txtTelephone.Text == "" || txtMobile.Text == "")
                {
                    MessageBox.Show("Enter a valid Number", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtTelephone.Text == "")
                    {
                        txtTelephone.Focus();
                    }
                    else
                    {
                        txtMobile.Focus();
                    }
                    return false;
                }
                if (Generalfunction.EditFun == 1)
                {
                    //Ds = _Dbtask.ExecuteQuery("select * from Tbladdenquiry where Enqname='" + txtName.Text + "'");
                    //if (Ds.Tables[0].Rows.Count > 0)
                    {
                        sql = "UPDATE  TblAddenquiry SET Enqname='" + txtName.Text.Replace("'", "") + "' ,company='" + txtAliasName.Text.Replace("'", "") + "' ,address='" + txtAddress.Text.Replace("'", "") + "' where enqvno='" + txtvno.Text + "'";
                        Ds = _Dbtask.ExecuteQuery(sql);
                        Generalfunction.EditFun = 0;
                        MessageBox.Show("Updated successfully", "Qplex", MessageBoxButtons.OK);

                        //MessageBox.Show("Enquiry is already exist", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a valid E-mail address", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
                return false;
            }

            return true;
        }

        private bool EditFun()
        {
            if (EditMode == false)
            {
                sql = "UPDATE  TblAddenquiry SET Enqname='" + txtName.Text + "' ,company='" + txtAliasName.Text + "' ,address='" + txtAddress.Text + "' where enqvno='" + txtvno.Text + "'";
                Ds = _Dbtask.ExecuteQuery(sql);
                MessageBox.Show("Updated successfully", "Qplex", MessageBoxButtons.OK);
            }
            return true;
        }

        public void RowValidation()
        {
            try
            {
                for (int i = 0; i < GridMain1.Rows.Count; i++)
                {
                    if (GridMain1.Rows[i].Cells["clnitemname"].Tag == null || Convert.ToDouble(GridMain1.Rows[i].Cells["clnamount"].Value) == Convert.ToDouble(0))
                    {
                        GridMain1.Rows[i].Tag = -1;
                        // gridmain.Rows[rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        GridMain1.Rows[i].Tag = 1;
                        GridMain1.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }

            }
            catch
            {
            }
        }

        public void NextgInitialize()
        {
            ProductVno = txtvno1.Text;


            for (int i = 0; i < GridMain1.Rows.Count; i++)
            {
                if (GridMain1.Rows[i].Tag != null)
                {
                    if (GridMain1.Rows[i].Tag.ToString() == "1")
                    {
                        //StrPurticulars = _GeneralLedger.PurticularsCreate(txttotal.Text, txtvno.Text);
                        //StrPurticularsForLedger = _GeneralLedger.PurticularsCreateForLedger(this.Text, txtvno);

                        long Slno = Convert.ToInt64(i);
                        //string SlTracking = _Dbtask.znllString(gridmain.Rows[i].Cells["clnserialno"].Value);
                        string pid = GridMain1.Rows[i].Cells["clnitemname"].Tag.ToString();
                        if (GridMain1.Columns["clnbatch"].Visible != false)
                        {
                            string batchcode = _Dbtask.znllString(GridMain1.Rows[i].Cells["clnbatch"].Value);
                        }
                        double qty = _Dbtask.gridnul(GridMain1.Rows[i].Cells["clnqty"].Value);
                        double Srate = _Dbtask.gridnul(GridMain1.Rows[i].Cells["clnrate"].Value);
                        double NetAmt = _Dbtask.gridnul(GridMain1.Rows[i].Cells["clnamount"].Value);

                        if (SBatch == true)
                        {
                            batchcode =_Dbtask.znllString(GridMain1.Rows[i].Cells["clnbatch"].Value);
                        }
                        
                            //CommonClass._Inventory.Ledcode = SalesAccount;
                            //CommonClass._Inventory.DCodeStr = StockAreaid;
                            //CommonClass._Inventory.InvDateDt = dtpDate.Value;
                            //CommonClass._Inventory.PcodeStr = pid;
                            //if (GridMain1.Columns["clnbatch"].Visible != false)
                            //{
                            //    CommonClass._Inventory.Batchcode = batchcode;
                            //}
                            //else
                            //{
                            //    CommonClass._Inventory.Batchcode = "0";
                            //}
                            //CommonClass._Inventory.Sales = qty;
                            //CommonClass._Inventory.Sr = 0;
                            //CommonClass._Inventory.Dn = 0;
                            //CommonClass._Inventory.InsertInventory();

                            _Issuedetails.IssueCodeLng =Convert.ToInt64(ProductVno);
                            _Issuedetails.SlNoLng = Slno;
                            _Issuedetails.PCodeStr = pid;
                            _Issuedetails.QtyDb = qty;
                            _Issuedetails.RateDb = Srate;
                            _Issuedetails.NetAmtDb = Convert.ToDouble(txttotal1.Text);
                            if (GridMain1.Columns["clnbatch"].Visible != false)
                            {
                                _Issuedetails.BatchIdStr = batchcode;
                            }
                            else
                            {
                                _Issuedetails.BatchIdStr = "0";
                            }
                            _Issuedetails.Ledcode = SalesAccount;
                            _Issuedetails.Vtype = VType;
                            _Issuedetails.InsertIssueDetails();
                        
                     
                    }
                }
            }
            CommonClass._Nextg.SetVno(txtvno.Text);
            CommonClass._Nextg.SetVno(txtvno1.Text);

           
                _Bussinessissue.VnoStr = CommonClass._Nextg.vno;
                _Bussinessissue.IssueCodeLng =Convert.ToInt64(ProductVno);
                _Bussinessissue.Pvno = CommonClass._Nextg.pvno;
                _Bussinessissue.IssueTypeStr = VType;
                _Bussinessissue.DCode = StockAreaid;
                _Bussinessissue.IssueDateDt = dtpDate.Value;
                _Bussinessissue.LedCodeCr = SalesAccount.ToString();
                _Bussinessissue.AMTDb = _Dbtask.znullDouble(txttotal1.Text);
                _Bussinessissue.InsertBusinessIssue();


                _GeneralLedger.VdateDt = dtpDate.Value;
                _GeneralLedger.RefnoStr = SalesAccount;
                _GeneralLedger.SlNoLng = Convert.ToInt64(txtvno.Tag);
                _GeneralLedger.LedCodeStr = SalesAccount.ToString(); ;
                _GeneralLedger.CrAmt = 0;
                _GeneralLedger.VTypeStr = VType;
                _GeneralLedger.VnoStr = txtvno.Text;
                _GeneralLedger.CrAmt = _Dbtask.znullDouble(txttotal1.Text);
                _GeneralLedger.InsertGeneralLedger();

               // ProductVno = txtvno1.Text;

            
            
            _Addenq.Vno = Convert.ToInt64(txtvno.Text);
            _Addenq.LidLng = Convert.ToInt64(txtLid.Text);
            _Addenq.Name = txtName.Text;
            _Addenq.Company = txtAliasName.Text;
            _Addenq.Address = txtAddress.Text;
            _Addenq.Telephone = txtTelephone.Text;
            _Addenq.Mobile = txtMobile.Text;
            _Addenq.City = txtCity.Text;
            _Addenq.State = txtState.Text;
            _Addenq.CountryId = Convert.ToInt64(txtcountry.Tag);
            _Addenq.Email = txtemail.Text;
            _Addenq.Date = dtpDate.Value;
            _Addenq.Time = dtpTime.Value;
            _Addenq.EmpidLng = Convert.ToInt64(cbxEmployee.SelectedValue);
            _Addenq.Enquiryabout = cbxEnquiryabout.Text;
            _Addenq.Response = cbxResponse.Text;
            _Addenq.StatusId = Convert.ToInt64(comstatus.SelectedValue);
            _Addenq.Remarks = txtRemarks.Text;
            _Addenq.Aid = Convert.ToInt64(cbxAgent.SelectedValue);
            //_Addenq.CategoryIdLng = Convert.ToInt64(cbxProductType.SelectedValue);
            _Addenq.Description = txtDescription.Text;
           // _Addenq.ItemIdLng = Convert.ToInt64(cbxProduct.SelectedValue);
            _Addenq.Userfield1 = txtUserfield1.Text;
            _Addenq.Userfield2 = txtUserfield2.Text;
            _Addenq.Userfield3 = txtUserfield3.Text;
            _Addenq.Userfield4 = txtUserfield4.Text;
            _Addenq.Userfield5 = txtUserfield5.Text;
            _Addenq.ProductVno = ProductVno;
            _Addenq.VType = VType;

          //  _Addenq.InsertaddEnquiry();
        }

        public void GetVno()
        {
            _Bussinessissue.PVno2(SalesAccount.ToString(), VType);
            if (_Bussinessissue.Pvno != "")
            {
                txtvno1.Text = Convert.ToString(_Bussinessissue.Pvno);
                txtvno1.Text = txtvno1.Text + Convert.ToString(_Bussinessissue.VnoStr);
            }
            else
            {
                txtvno1.Text = Convert.ToString(_Bussinessissue.VnoStr);
            }
            txtvno1.Tag = _Bussinessissue.IdSalesFu(SalesAccount, VType);

            _Issuedetails.IssueCodeLng = Convert.ToInt64(txtvno1.Tag);
            _Bussinessissue.IssueCodeLng = Convert.ToInt64(txtvno1.Tag);
            CommonClass._Inventory.Vcode = txtvno1.Tag.ToString();
        }

        public void Clear()
        {
            Generalfunction.EditFun = 0;
            EditMode = false;
            txtvno.Text = "";
            txtName.Text = "";
            txtAliasName.Text = "";
            txtAddress.Text = "";
            txtTelephone.Text="";
            txtMobile.Text="";
            txtemail.Text = "";
            txtCity.Text="";
           // txtState.Text="";
            txtRemarks.Text="";
            txtSearch.Text = "";
            //txtcountry.Text = "";
            cbxEmployee.SelectedIndex = -1;
            cbxEnquiryabout.SelectedIndex=-1;
            cbxResponse.SelectedIndex = -1;
            comstatus.SelectedValue = -1;
            txtDescription.Text = "";
          //  cbxProduct.SelectedIndex = -1;
            cbxAgent.SelectedIndex = -1;
            txtUserfield1.Text = "";
            txtUserfield2.Text = "";
            txtUserfield3.Text = "";
            txtUserfield4.Text = "";
            txtUserfield5.Text = "";
            txttotal1.Text = "";
            Gridcustomerlist.Visible = false;
            CommonClass._Nextg.ClearControles(pnlVehicleprofile);
            GridMain1.Rows.Clear();
           // CommonClass._Nextg.ClearControles(pnlgridmain1);
            EditMode = false;
            SalesAccount = "2";
            NextVno();
            GetVno();
            NextLid();
            showingrid();
            Enable();
            SetGridColumn();
            txtName.Focus();
            pnlVehicleprofile.Visible = false;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        public void SendSMS()
        {
            if (chksms.Checked == true)
            {
                string Mob=txtMobile.Text;
                string LedNa=txtName.Text;
                string Sub=cbxResponse.Text;
                CommonClass._Sms.SendSms(Mob, LedNa, "Status :" + Sub);
            }
        }

        public void Fillstatus()
        {
            _Addenq.FillStatus(comstatus, Status);
        }

        //public void Fillcountry()
        //{
        //    _Addenq.FillComboWhere(cbxCountry, WhereCountryList);
        //}

        public void FillAllEmployee()
        {
            _Addenq.FillEmployee(cbxEmployee,AllEmployee);
            //cbxEmployee.Tag = _Addenq.EmpidLng;
            //EmpId =Convert.ToString(cbxEmployee.Tag);
        }

        public void FillallAgent()
        {
            _Addenq.FillAgent(cbxAgent, AllAgent);
            //cbxAgent.Tag = _Dbtask.ExecuteQuery("select Lid from TblAccountLedger where AGroupId=29 and Lname='" + cbxAgent.Text + "'");
            //AgentId =Convert.ToString(cbxAgent.Tag);
        }

        //public void FillProducts()
        //{
        //    _Addenq.FillProduct(cbxProduct, AllProduct); 
        //}

        private bool Main()
            {
            RowValidation();
            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteEnquiry();
                    }


                    if (Retrivemode == 1)
                    {
                       // ProductVno = _Dbtask.ExecuteScalar("select ProductVno from Tbladdenquiry where enqvno='" + txtvno.Text + "'");
                        // UpdateTable();
                       // EditMode = false;
                    }
                        NextgInitialize();
                    
                    Insert();
                    SendSMS();
                    Clear();
                    //  MessageBox.Show("Saved Successfully");
                    if (Isinotherwindow == false)
                    {
                        Clear();
                    }
                    if (Isinotherwindow == true)
                    {
                        this.Close();
                    }
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
        public void UpdateTable()
        {
            Ds = _Dbtask.ExecuteQuery("delete Tbladdenquiry where enqvno='" + txtvno.Text + "'");
        }

        public void inserLedger()
        {
            sql="insert into TblAccountLedger(Lid,LName,AGroupId,Address,Phone,Mobile,Email)values('" + txtLid.Text.Replace("'", "") + "','" + txtName.Text.Replace("'","") + "','18','" + txtAddress.Text.Replace("'","") + "','" + txtTelephone.Text.Replace("'","") + "','" + txtMobile.Text.Replace("'","") + "','" + txtemail.Text.Replace("'","") +"')";
            _Dbtask.ExecuteQuery(sql);
        }

        public void Insert()
        {
            if (comstatus.SelectedIndex == 1)
            {
                if (EditMode == false)
                {
                    inserLedger();
                }                
            }
            _Addenq.InsertaddEnquiry();
        }

        public void InsertFields()
        {
            _Fileds.Insertfields();
        }

        public void NextLid()
        {
            _Addenq.NextLid();
            txtLid.Text = _Addenq.LidLng.ToString();
        }

        public void NextVno()
        {
           _Addenq.Nextid();
            txtvno.Text = _Addenq.Vno.ToString();
           // txtvno1.Text = _Addenq.ProductVno.ToString();
     
        }

        public void Clear1()
        {
            ClearControls();
            //Fillcountry();
            NextVno();
            GetVno();
        }

        public void DeleteEnquiry()
        {
            _Dbtask.ExecuteNonQuery("delete from Tbladdenquiry where enqvno ='" + txtvno.Text + "'");
           // _Dbtask.ExecuteNonQuery("delete from TblAccountLedger where Lid ='" + txtLid.Text + "'");
            _Dbtask.ExecuteNonQuery("delete from TblIssuedetails where IssueCode='" + ProductVno + "' and Vtype='JOB'");
            _Dbtask.ExecuteNonQuery("delete from TblBusinessIssue where VNo='" + txtvno.Text + "' and IssueType='JOB'");
            _Dbtask.ExecuteNonQuery("delete from TblGeneralLedger where VNo='" + txtvno.Text + "'and VType='JOB'");
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtAliasName.Text == "")
                {
                    MessageBox.Show("No Row Selected", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult Result = MessageBox.Show("Do you want to Delete the Customer", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Result.ToString() == "Yes")
                    {
                        DeleteEnquiry();
                        txtName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
            Clear();
        }

        private void lblName_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblName, txtLabelchange,lblName.Tag.ToString());           
        }

        private void lblCompanyname_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblAliasname, txtLabelchange, lblAliasname.Tag.ToString());
        }

        private void lblAddress_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblAddress, txtLabelchange, lblAddress.Tag.ToString());
        }

        private void lblTelephone_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblTelephone, txtLabelchange, lblTelephone.Tag.ToString());
        }

        private void lblMobile_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblMobile, txtLabelchange, lblMobile.Tag.ToString());
        }

        private void lblCity_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblCity, txtLabelchange, lblCity.Tag.ToString());
        }

        private void lblState_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblState, txtLabelchange, lblState.Tag.ToString());
        }

        private void lblCountry_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblCountry, txtLabelchange, lblCountry.Tag.ToString());
        }

        private void lblEmail_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblEmail, txtLabelchange, lblEmail.Tag.ToString());
        }

        private void lblDate_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblDate, txtLabelchange, lblDate.Tag.ToString());
        }

        private void lblTime_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblTime, txtLabelchange, lblTime.Tag.ToString());
        }

        private void lblModeofenquiry_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblEmployee, txtLabelchange, lblEmployee.Tag.ToString());
        }

        private void lblEnquiryabout_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblEnquiryabout, txtLabelchange, lblEnquiryabout.Tag.ToString());
        }

        private void lblResponse_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblResponse, txtLabelchange, lblResponse.Tag.ToString());
        }

        private void lblRemarks_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblRequirment, txtLabelchange, lblRequirment.Tag.ToString());
        }

        private void lblProducttype_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblDescription, txtLabelchange, lblDescription.Tag.ToString());
        }

        //private void lblProduct_DoubleClick(object sender, EventArgs e)
        //{
        //    _Addenq.LblLocation(lblProduct, txtLabelchange, lblProduct.Tag.ToString());
        //}

        private void lblAgent_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblAgent, txtLabelchange, lblAgent.Tag.ToString());
        }

        private void lblVNo_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblVNo, txtLabelchange, lblVNo.Tag.ToString());
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ShowCustomer();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            Gridcustomerlist.Visible = false;
        }

        public void showingrid()
        {
            //sql = "SELECT enqvno as SINo,Enqname AS '" + lblName.Text + "',company AS '" + lblCompanyname.Text + "',address AS '" + lblAddress.Text + "',telephone AS '" + lblTelephone.Text + "',mobile AS '" + lblMobile.Text + "',city AS '" + lblCity.Text + "',state AS '" + lblState.Text + "'," +
            //"CId AS '" + lblCountry.Text.Replace("'", "") + "',email AS '" + lblEmail.Text + "',enqdate AS '" + lblDate.Text + "',enqtime AS '" + lblTime.Text + "',Empid as '" + lblEmployee.Text + "',enquiryabout AS '" + lblEnquiryabout.Text + "',response AS '" + lblResponse.Text + "'," +
            //"status AS '" + lblStatus.Text + "',remarks AS '" + lblRemarks.Text + "',description AS '" + lblDescription.Text + "',ItemId AS '" + lblProduct.Text + "',Aid AS '" + lblAgent.Text + "',Userfld1 AS '" + lblUserfield1.Text + "',Userfld2 AS '" + lblUserfield2.Text + "'," +
            //"Userfld3 AS '" + lblUserfield3.Text + "',Userfld4 AS '" + lblUserfield4.Text + "',Userfld5 AS '" + lblUserfield5.Text + "' FROM Tbladdenquiry order by enqvno asc";

            //sql = "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblCompanyname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
            //          "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
            //          "TblCurrency.description AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
            //          "TblEmployeemaster.EmpName AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
            //          "Tbladdenquiry.remarks AS '" + lblRemarks.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "', TblItemMaster.ItemName AS '" + lblProduct.Text + "', Tbladdenquiry.Aid AS '" + lblAgent.Text + "'," +
            //          "Tbladdenquiry.Userfld1 AS '" + lblUserfield1.Text + "', Tbladdenquiry.Userfld2 AS '" + lblUserfield2.Text + "', Tbladdenquiry.Userfld3 AS '" + lblUserfield3.Text + "', Tbladdenquiry.Userfld4 AS '" + lblUserfield4.Text + "'," +
            //          "Tbladdenquiry.Userfld5 AS '" + lblUserfield5.Text + "'" +
            //          "FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId INNER JOIN TblEmployeemaster ON Tbladdenquiry.Empid = TblEmployeemaster.Empid " +
            //          "INNER JOIN TblItemMaster ON Tbladdenquiry.ItemId = TblItemMaster.ItemId ORDER BY enqvno asc";

         sql= "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblAliasname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
                      "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
                      "TblCurrency.description AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
                      "TblEmployeemaster.EmpName AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
                      "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "',  Tbladdenquiry.Aid AS '" + lblAgent.Text + "'FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId " +
                      "INNER JOIN TblEmployeemaster ON Tbladdenquiry.Empid = TblEmployeemaster.Empid INNER JOIN TblItemMaster ON Tbladdenquiry.ItemId=TblItemMaster.ItemId";

            Ds = _Dbtask.ExecuteQuery(sql);
            Gridmain.DataSource = Ds.Tables[0];            
        }               

        public void SelectCell()
        { 
        }

        
        public void TxtNameEnter()
        {
            if (EditMode == true)
            {
                Ds = _Dbtask.ExecuteQuery("select * from Tbladdenquiry where Enqname='" + txtName.Text + "'");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    txtName.Text = Ds.Tables[0].Rows[0]["Enqname"].ToString();
                    txtAliasName.Text = Ds.Tables[0].Rows[0]["company"].ToString();
                    txtAddress.Text = Ds.Tables[0].Rows[0]["address"].ToString();
                    txtMobile.Text = Ds.Tables[0].Rows[0]["mobile"].ToString();
                    txtemail.Text = Ds.Tables[0].Rows[0]["email"].ToString();
                }
            }
        }
                
        private void txtName_Enter(object sender, EventArgs e)
        {
            TxtNameEnter();
        }

        private void txtName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (Gridcustomerlist.Visible == true)
            {
                if (Gridcustomerlist.SelectedRows.Count > 0)
                {
                    selectedRow = Gridcustomerlist.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridcustomerlist.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridcustomerlist.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridcustomerlist.Rows[selectedRow + 1].Selected = true;
                            Gridcustomerlist.Rows[selectedRow].Selected = false;
                            Gridcustomerlist.CurrentCell = Gridcustomerlist.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridcustomerlist.Rows[selectedRow - 1].Selected = true;
                        Gridcustomerlist.Rows[selectedRow].Selected = false;
                        Gridcustomerlist.CurrentCell = Gridcustomerlist.SelectedRows[0].Cells[0];
                    }
                }
                if (e.KeyValue == 13)
                {

                    if (Gridcustomerlist.SelectedRows.Count > 0)
                    {

                        IsEnter = false;

                        pnlVehicleprofile.Visible = true;
                        txtMakersname.Text = Ds.Tables[0].Rows[selectedRow]["MakersName"].ToString();
                        txtmakersmodel.Text = Ds.Tables[0].Rows[selectedRow]["MakersModel"].ToString();
                        txtEngno.Text = Ds.Tables[0].Rows[selectedRow]["EngNo"].ToString();
                        txtChasno.Text = Ds.Tables[0].Rows[selectedRow]["ChasNo"].ToString();
                        comFuelType.Text = Ds.Tables[0].Rows[selectedRow]["FuelType"].ToString();
                        txtColour.Text = Ds.Tables[0].Rows[selectedRow]["Colour"].ToString();
                        dtYearofMnfr.Value = Convert.ToDateTime(Ds.Tables[0].Rows[selectedRow]["YrOfMnfr"]);

                        txtName.Tag = Gridcustomerlist.Rows[selectedRow].Cells[0].Tag.ToString();
                        txtName.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();
                        Ds2 = _Dbtask.ExecuteQuery("select * from TblAccountLedger where Lid='" + txtName.Tag + "' and AgroupId='18'");
                        // selectedRow1=
                        txtAliasName.Text = Ds2.Tables[0].Rows[0]["LName"].ToString();
                        txtAddress.Text = Ds2.Tables[0].Rows[0]["Address"].ToString();
                        txtTelephone.Text = Ds2.Tables[0].Rows[0]["phone"].ToString();
                        txtMobile.Text = Ds2.Tables[0].Rows[0]["mobile"].ToString();
                        txtemail.Text = Ds2.Tables[0].Rows[0]["Email"].ToString();
                        txtCity.Text = Ds2.Tables[0].Rows[0]["Area"].ToString();
                        // txtAliasName



                        Gridcustomerlist.Visible = false;
                        //  AlreadyExist();
                    }
                }
            }
        }
        public void AlreadyExist()
        {
            Ds = _Dbtask.ExecuteQuery("select * from TblAccountLedger where lid='" + txtName.Tag + "'");

            txtAliasName.Text = Ds.Tables[0].Rows[0]["LAliasName"].ToString();
            txtAddress.Text = Ds.Tables[0].Rows[0]["Address"].ToString();
            txtTelephone.Text = Ds.Tables[0].Rows[0]["Phone"].ToString();
            txtMobile.Text = Ds.Tables[0].Rows[0]["Mobile"].ToString();
            txtCity.Text = Ds.Tables[0].Rows[0]["Area"].ToString();
            txtemail.Text = Ds.Tables[0].Rows[0]["Email"].ToString();
        }


        private void cmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Textsett()
        {
            sql = "select Name from TblFields where id=11";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblVNo.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=12";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblName.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=13";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblAliasname.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=14";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblAddress.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=15";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblTelephone.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=16";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblMobile.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=17";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblCity.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=18";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblState.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=19";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblCountry.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=20";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblEmail.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=21";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblDate.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=22";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblTime.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=23";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblEmployee.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=24";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblEnquiryabout.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=25";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblResponse.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=26";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblStatus.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=27";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblRequirment.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=28";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblDescription.Text = Ds.Tables[0].Rows[0][0].ToString();

            //sql = "select Name from TblFields where id=29";
            //Ds = _Dbtask.ExecuteQuery(sql);
            //lblProduct.Text = Ds.Tables[0].Rows[0][0].ToString();

            sql = "select Name from TblFields where id=30";
            Ds = _Dbtask.ExecuteQuery(sql);
            lblAgent.Text = Ds.Tables[0].Rows[0][0].ToString();

            //sql = "select Name from TblFields where id=31";
            //Ds = _Dbtask.ExecuteQuery(sql);
            //lblUserfield1.Text = Ds.Tables[0].Rows[0][0].ToString();

            //sql = "select Name from TblFields where id=32";
            //Ds = _Dbtask.ExecuteQuery(sql);
            //lblUserfield2.Text = Ds.Tables[0].Rows[0][0].ToString();

            //sql = "select Name from TblFields where id=33";
            //Ds = _Dbtask.ExecuteQuery(sql);
            //lblUserfield3.Text = Ds.Tables[0].Rows[0][0].ToString();

            //sql = "select Name from TblFields where id=34";
            //Ds = _Dbtask.ExecuteQuery(sql);
            //lblUserfield4.Text = Ds.Tables[0].Rows[0][0].ToString();

            //sql = "select Name from TblFields where id=35";
            //Ds = _Dbtask.ExecuteQuery(sql);
            //lblUserfield5.Text = Ds.Tables[0].Rows[0][0].ToString();
        }

        private void txtLabelchange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtLabelchange.Text != "")
                {
                    if (Generalfunction.lblChange == lblVNo.Name)
                    {
                        _Dbtask.ExecuteNonQuery("update TblFields set Name='" + txtLabelchange.Text.Replace("'", "") + "'  where id=11");
                    }

                    if (Generalfunction.lblChange == lblName.Name)
                    {
                        sql = "update TblFields set Name='" + txtLabelchange.Text.Replace("'", "") + "'  where id=12";
                        _Dbtask.ExecuteNonQuery(sql);
                    }

                    if (Generalfunction.lblChange == lblAliasname.Name)
                    {
                        _Dbtask.ExecuteNonQuery("update TblFields set Name='" + txtLabelchange.Text.Replace("'", "") + "'  where id=13"); 
                    }

                    Textsett();
                    txtLabelchange.Visible = false;
                    txtName.Focus();
                }
            }
        }

        private void cbxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        public void Showstatus()
        {
           //sql = "SELECT enqvno as SINo,Enqname AS '" + lblName.Text + "',company AS '" + lblCompanyname.Text + "',address AS '" + lblAddress.Text + "',telephone AS '" + lblTelephone.Text + "',mobile AS '" + lblMobile.Text + "',city AS '" + lblCity.Text + "',state AS '" + lblState.Text + "'," +
           //"CId AS '" + lblCountry.Text + "',email AS '" + lblEmail.Text + "',enqdate AS '" + lblDate.Text + "',enqtime AS '" + lblTime.Text + "',Empid as '" + lblEmployee.Text + "',enquiryabout AS '" + lblEnquiryabout.Text + "',response AS '" + lblResponse.Text + "',status AS '" + lblStatus.Text + "'," +
           //"remarks AS '" + lblRemarks.Text + "',description AS '" + lblDescription.Text + "',ItemId AS '" + lblProduct.Text + "',Aid AS '" + lblAgent.Text + "',Userfld1 AS '" + lblUserfield1.Text + "',Userfld2 AS '" + lblUserfield2.Text + "',Userfld3 AS '" + lblUserfield3.Text + "'," +
           //"Userfld4 AS '" + lblUserfield4.Text + "',Userfld5 AS '" + lblUserfield5.Text + "' FROM Tbladdenquiry";

            sql = "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblAliasname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
                       "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
                       "TblCurrency.description AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
                       "Tbladdenquiry.Empid AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
                       "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "',Tbladdenquiry.Aid AS '" + lblAgent.Text + "',Tbladdenquiry.description AS '" + lblDescription.Text + "'FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId ";

            if (cbxstatsearch.SelectedIndex == 0)
            {
                sql += " where status in (0,1) ";
            }
            if (cbxstatsearch.SelectedIndex == 1)
            {
                sql += " where status='0'";
            }
            if (cbxstatsearch.SelectedIndex == 2)
            {
                sql += " where status='1'";
            }
            Ds = _Dbtask.ExecuteQuery(sql);
            Gridmain.DataSource = Ds.Tables[0];
                      
        }

        public void insertMOde()
        {
            _Fileds.ID = 41;
            _Fileds.Name = txtadd.Text;
            InsertFields();            
        }

        public void insertAbout()
        {
            _Fileds.ID = 42;
            _Fileds.Name = txtadd.Text;
            InsertFields();
        }

        public void insertResponse()
        {
            _Fileds.ID = 43;
            _Fileds.Name = txtadd.Text;
            InsertFields();
        }

        public void FillCombo()
        {
            _Dbtask.fillDatainCombowithQuery(cbxEmployee, "Empid", "EmpName", "TblEmployeemaster", "SELECT * FROM TblEmployeemaster");
            _Dbtask.fillDatainCombowithQuery(cbxEnquiryabout, "Id", "Name", "TblFields", "SELECT * FROM TblFields WHERE id=42");
            _Dbtask.fillDatainCombowithQuery(cbxResponse, "Id", "Name", "TblFields", "SELECT * FROM TblFields WHERE id=43");

            cbxAgent.Tag = _Dbtask.ExecuteQuery("select Lid from TblAccountLedger where AGroupId=29 and Lname='" + cbxAgent.Text + "'");
            AgentId = Convert.ToString(cbxAgent.Tag);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtadd.Text != "" && txtadd.Text != "'" && txtadd.Text != "\\")
            {
                if (Generalfunction.combselect == "mode")
                {
                    insertMOde();
                }
                else if (Generalfunction.combselect == "About")
                {
                    insertAbout();
                }
                else if (Generalfunction.combselect == "Response")
                {
                    insertResponse();
                }
                lbxAdd.Items.Add(txtadd.Text);
                txtadd.Text = "";
                FillCombo();

            }
        }

        private void lblStatus_DoubleClick(object sender, EventArgs e)
        {
            _Addenq.LblLocation(lblStatus, txtLabelchange, lblStatus.Tag.ToString());
        }

       

      

        private void txtLabelchange_Leave(object sender, EventArgs e)
        {
            if (txtLabelchange.Text != "")
            {
                
               _Dbtask.ExecuteNonQuery("update TblFields set Name='" + txtLabelchange.Text.Replace("'", "") + "'  where id='"+ClsAddenquiry.SelLabelID+"'");
                                
                Textsett();
                txtLabelchange.Visible = false;
                txtName.Focus();
            }
        }
        public void Cellclick()
        {
            if (Gridmain.SelectedRows.Count > 0 && Gridmain.SelectedRows[0].Cells[0].Value != null)
            {
                try
                {
                    long ConId = Convert.ToInt64(Gridmain.Rows[0].Cells[8].Value.ToString());
                    string CountryName = _Dbtask.ExecuteScalar("select description from TblCurrency where CId='" + ConId + "'");
                    string Vno = Gridmain.SelectedRows[0].Cells[0].Value.ToString();
                    txtvno.Text = Vno;
                    txtName.Text = Gridmain.SelectedRows[0].Cells[1].Value.ToString();
                    txtAliasName.Text = Gridmain.SelectedRows[0].Cells[2].Value.ToString();
                    txtAddress.Text = Gridmain.SelectedRows[0].Cells[3].Value.ToString();
                    txtTelephone.Text = Gridmain.SelectedRows[0].Cells[4].Value.ToString();
                    txtMobile.Text = Gridmain.SelectedRows[0].Cells[5].Value.ToString();
                    txtCity.Text = Gridmain.SelectedRows[0].Cells[6].Value.ToString();
                    txtState.Text = Gridmain.SelectedRows[0].Cells[7].Value.ToString();
                    txtcountry.Text = CountryName;
                    txtemail.Text = Gridmain.SelectedRows[0].Cells[9].Value.ToString();
                    dtpDate.Text = Gridmain.SelectedRows[0].Cells[10].Value.ToString();
                    dtpTime.Text = Gridmain.SelectedRows[0].Cells[11].Value.ToString();
                    cbxEmployee.SelectedValue = Gridmain.SelectedRows[0].Cells[12].Value.ToString();
                    cbxEnquiryabout.Text = Gridmain.SelectedRows[0].Cells[13].Value.ToString();
                    cbxResponse.Text = Gridmain.SelectedRows[0].Cells[14].Value.ToString();
                    comstatus.SelectedValue = Gridmain.SelectedRows[0].Cells[15].Value.ToString();
                    txtRemarks.Text = Gridmain.SelectedRows[0].Cells[16].Value.ToString();
                    cbxAgent.SelectedValue = Gridmain.SelectedRows[0].Cells[17].Value.ToString();
                    txtDescription.Text = Gridmain.SelectedRows[0].Cells[18].Value.ToString();
                    //cbxProductType.SelectedValue = Gridmain.SelectedRows[0].Cells[17].Value.ToString();
                    // cbxProduct.Text = Gridmain.SelectedRows[0].Cells[18].Value.ToString();


                    txtUserfield1.Text = _Addenq.Getspecificfield("userfld1", Vno);
                    txtUserfield2.Text = _Addenq.Getspecificfield("userfld2", Vno);
                    txtUserfield3.Text = _Addenq.Getspecificfield("userfld3", Vno);
                    txtUserfield4.Text = _Addenq.Getspecificfield("userfld4", Vno);
                    txtUserfield5.Text = _Addenq.Getspecificfield("userfld5", Vno);

                    
                        pnlVehicleprofile.Visible = true;
                        Ds = _Dbtask.ExecuteQuery("select * from tblCustomerLedger where RegNo='" + txtName.Text + "'");
                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            txtMakersname.Text = Ds.Tables[0].Rows[0]["MakersName"].ToString();
                            txtmakersmodel.Text = Ds.Tables[0].Rows[0]["MakersModel"].ToString();
                            txtEngno.Text = Ds.Tables[0].Rows[0]["EngNo"].ToString();
                            txtChasno.Text = Ds.Tables[0].Rows[0]["ChasNo"].ToString();
                            comFuelType.Text = Ds.Tables[0].Rows[0]["FuelType"].ToString();
                            txtColour.Text = Ds.Tables[0].Rows[0]["Colour"].ToString();
                            dtYearofMnfr.Value = Convert.ToDateTime(Ds.Tables[0].Rows[0]["YrOfMnfr"]);

                        }
                        else
                        {
                            pnlVehicleprofile.Visible = false;
                        }
                    

                    //ProductVno = _Dbtask.ExecuteScalar("select ProductVno from Tbladdenquiry where enqvno='" + txtvno.Text + "'");
                    Gridcustomerlist.Visible = false;

                    jobcardId =_Dbtask.ExecuteScalar("select ProductVno from Tbladdenquiry where enqvno='" + Vno + "' and vtype='JOB'");
                    Ds2 = _Dbtask.ExecuteQuery("select * from TblIssuedetails where Issuecode='" + jobcardId + "' and Vtype='JOB'");
                    GridMain1.Rows.Clear();
                    for (int i = 0; i < Ds2.Tables[0].Rows.Count; i++)
                    {
                        GridMain1.Rows.Add(1);
                        string TempSlno = (i + 1).ToString();
                        string Lid = Ds2.Tables[0].Rows[i]["pcode"].ToString();
                        string Itemname = _Dbtask.ExecuteScalar("select Itemname from TblItemMaster where itemId='" + Lid + "'");
                
                        string Itemcode = _Dbtask.ExecuteScalar("select Itemcode from TblItemMaster where itemid='" + Lid + "'");
                        
                        double rate = _Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[i]["Rate"]);
                        double Qty = _Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[i]["QTY"]);
                        if (SBatch == true)
                        {
                            string batch = _Dbtask.ExecuteScalar("select Bcode from Tblbatch where itemid='" + Lid + "'");
                            GridMain1.Rows[i].Cells["clnbatch"].Tag = _Dbtask.ExecuteScalar("select Bid from Tblbatch where itemid='" + Lid + "'");
                            GridMain1.Rows[i].Cells["clnbatch"].Value = batch;

                        }

                        GridMain1.Rows[i].Cells["clnItemname"].Tag = Lid;
                        GridMain1.Rows[i].Cells["clnItemname"].Value = Itemname;
                        GridMain1.Rows[i].Cells["clnitemcode"].Value = Itemcode;
                        GridMain1.Rows[i].Cells["clnslno"].Value = TempSlno;

                        NQTY = Qty;
                        GridMain1.Rows[i].Cells["clnqty"].Value = Qty;

                        NRATE = rate;
                        GridMain1.Rows[i].Cells["clnrate"].Value = rate;
                        
                        rowIndex = i;
                         
                        cellEnterCalculationpart();
                        RowValidation();
                    }
                    Totalcalculation();

                    pnlSearch.Visible = false;
                    
                }
                catch
                {

                }
            }
        }
       

        public void deleteFields()
        {
            if (lbxAdd.SelectedItems.Count > 0)
            {
                if (Generalfunction.combselect == "mode")
                {
                    sql = "delete from TblFields where Name='" + lbxAdd.SelectedItem.ToString() + "'and id='41'";
                }
                else if (Generalfunction.combselect == "About")
                {
                    sql = "delete from TblFields where Name='" + lbxAdd.SelectedItem.ToString() + "'and id='42'";
                }
                else if (Generalfunction.combselect == "Response")
                {
                    sql = "delete from TblFields where Name='" + lbxAdd.SelectedItem.ToString() + "'and id='43'";
                }
                _Dbtask.ExecuteNonQuery(sql);
                FillCombo(); 
                lbxAdd.Items.Remove(lbxAdd.SelectedItem);
            }
        }

        public void disable()
        {
            txtName.Enabled = false;
            txtAliasName.Enabled = false;
            txtAddress.Enabled = false;
            txtTelephone.Enabled = false;
            txtMobile.Enabled = false;
            txtCity.Enabled = false;
            txtState.Enabled = false;
            txtcountry.Enabled = false;
            txtemail.Enabled = false;
            dtpDate.Enabled = false;
            dtpTime.Enabled = false;
            cbxEmployee.Enabled = false;
            cbxEnquiryabout.Enabled = false;
            cbxResponse.Enabled = false;
            comstatus.Enabled = false;
            txtRemarks.Enabled = false;
            txtDescription.Enabled = false;
            //cbxProductType.Enabled = false;
           // cbxProduct.Enabled = false;
            cbxAgent.Enabled = false;
            lnkEnquiry.Enabled = false;
           // lnkMode.Enabled = false;
            lnkResponse.Enabled = false;
            txtUserfield1.Enabled = false;
            txtUserfield2.Enabled = false;
            txtUserfield3.Enabled = false;
            txtUserfield4.Enabled = false;
            txtUserfield5.Enabled = false;
            pnlVehicleprofile.Enabled = false;
            GridMain1.Enabled = false;
            cmdItem.Enabled = false;
        }

        public void Enable()
        {
        //    cmdItem.Visible = false;
        //    cmdEdititem.Visible = true;
            txtName.Enabled = true;
            txtAliasName.Enabled = true;
            txtAddress.Enabled = true;
            txtTelephone.Enabled = true;
            txtMobile.Enabled = true;
            txtCity.Enabled = true;
            txtState.Enabled = true;
            txtcountry.Enabled = true;
            txtemail.Enabled = true;
            dtpDate.Enabled = true;
            dtpTime.Enabled = true;
            cbxEmployee.Enabled = true;
            cbxEnquiryabout.Enabled = true;
            cbxResponse.Enabled = true;
            comstatus.Enabled = true;
            txtRemarks.Enabled = true;
            //cbxProductType.Enabled = true;
            //cbxProduct.Enabled = true;
            txtDescription.Enabled = true;
            cbxAgent.Enabled = true;
            lnkEnquiry.Enabled = true;
           // lnkMode.Enabled = true;
            lnkResponse.Enabled = true;
            txtUserfield1.Enabled = true;
            txtUserfield2.Enabled = true;
            txtUserfield3.Enabled = true;
            txtUserfield4.Enabled = true;
            txtUserfield5.Enabled = true;
            cmdItem.Enabled = true;
            GridMain1.Enabled = true;
            pnlVehicleprofile.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteFields();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            Retrivemode = 1;
            Enable();
            EditMode = true;
        }

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void lnkMode_Click(object sender, EventArgs e)
        {

        }

        //private void lblUserfield1_DoubleClick(object sender, EventArgs e)
        //{
        //    _Addenq.LblLocation(lblUserfield1, txtLabelchange, lblUserfield1.Tag.ToString());
        //}

        //private void lblUserfield2_DoubleClick(object sender, EventArgs e)
        //{
        //    _Addenq.LblLocation(lblUserfield2, txtLabelchange, lblUserfield2.Tag.ToString());
        //}

        //private void lblUserfield3_DoubleClick(object sender, EventArgs e)
        //{
        //    _Addenq.LblLocation(lblUserfield3, txtLabelchange, lblUserfield3.Tag.ToString());
        //}

        //private void lblUserfield4_DoubleClick(object sender, EventArgs e)
        //{
        //    _Addenq.LblLocation(lblUserfield4, txtLabelchange, lblUserfield4.Tag.ToString());
        //}

        //private void lblUserfield5_DoubleClick(object sender, EventArgs e)
        //{
        //    _Addenq.LblLocation(lblUserfield5, txtLabelchange, lblUserfield5.Tag.ToString());
        //}

        private void cmdItem_Click(object sender, EventArgs e)
        {
            Frmsalespos _pos = new Frmsalespos();
            _pos.Vtype = "CRM";
            if (Retrivemode == 1)
            {
                _pos.Retrivemode1 = 1;
                _pos.Vnoenq = txtvno.Text;
               
               // _pos.ShowDialog();
            }
            _pos.SelectedValue1 = cbxAgent.Text;
            _pos.SelectedValue = cbxEmployee.Text;
            _pos.ShowDialog();
           
            
        }

       
        private void Gridcustomerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridCustomernameClick();
        }
        public void gridCustomernameClick()
        {
            if (Gridcustomerlist.SelectedRows.Count > 0)
            {
                IsEnter = false;
                txtName.Tag = Gridcustomerlist.Rows[selectedRow].Cells[0].Tag.ToString();
                txtName.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();

                Gridcustomerlist.Visible = false;
                AlreadyExist();
            }
        }
        public void ShowCustomer()
        {
            Gridcustomerlist.Location = new System.Drawing.Point(132, 66);
            //int i;
            //Ds = _Dbtask.ExecuteQuery("select * from TblAccountLedger where LName like '%" + txtName.Text + "%' and AGroupId='18'");

            //Gridcustomerlist.Visible = true;
            //Gridcustomerlist.Rows.Clear();
            //for (i = 0; i < Ds.Tables[0].Rows.Count; i++)
            //{
            //    Gridcustomerlist.Rows.Add(1);
            //    Gridcustomerlist.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["LName"];
            //    Gridcustomerlist.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["lid"];
            //}

            Ds = _Dbtask.ExecuteQuery("select * from tblCustomerLedger where RegNo like '%" + txtName.Text + "%'");

            Gridcustomerlist.Visible = true;
            Gridcustomerlist.Rows.Clear();
            //if (Generalfunction.Comeform == "")
            //{
            //    Ds = _Dbtask.ExecuteQuery("select * from Tbladdenquiry where Enqname like '%" + txtName.Text + "%'");
            //}

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Gridcustomerlist.Rows.Add(1);
                Gridcustomerlist.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["RegNo"];
                Gridcustomerlist.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["Lid"];
            }
        }
        public void ShowCountry()
        {
            Gridcustomerlist.Visible = true;
            Gridcustomerlist.Location = new System.Drawing.Point(254, 390);
            Ds = _Dbtask.ExecuteQuery("select * from TblCurrency where description like '%" + txtcountry.Text + "%' ");

            Gridcustomerlist.Visible = true;
            Gridcustomerlist.Rows.Clear();
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Gridcustomerlist.Rows.Add(1);
                Gridcustomerlist.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["description"];
                Gridcustomerlist.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["CId"];
            }
        }
       
        public void FillCountry()
        {
            //ShowCountry(); 
            Ds = _Dbtask.ExecuteQuery("select * from TblCurrency where cid='102'");
            txtcountry.Text = Ds.Tables[0].Rows[0]["description"].ToString();
            txtcountry.Tag = Ds.Tables[0].Rows[0]["cid"].ToString();
        }

        private void txtcountry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (Gridcustomerlist.Visible == true)
            {
                if (Gridcustomerlist.SelectedRows.Count > 0)
                {
                    selectedRow = Gridcustomerlist.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridcustomerlist.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridcustomerlist.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridcustomerlist.Rows[selectedRow + 1].Selected = true;
                            Gridcustomerlist.Rows[selectedRow].Selected = false;
                            Gridcustomerlist.CurrentCell = Gridcustomerlist.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridcustomerlist.Rows[selectedRow - 1].Selected = true;
                        Gridcustomerlist.Rows[selectedRow].Selected = false;
                        Gridcustomerlist.CurrentCell = Gridcustomerlist.SelectedRows[0].Cells[0];
                    }
                }
                if (e.KeyValue == 13)
                {

                    if (Gridcustomerlist.SelectedRows.Count > 0)
                    {
                        IsEnter = false;
                        txtcountry.Tag = Gridcustomerlist.Rows[selectedRow].Cells[0].Tag.ToString();
                        txtcountry.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();

                        Gridcustomerlist.Visible = false;
                       // AlreadyExist();
                    }
                }
            }
        }

        private void frmJobCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }


        void txt1_Enter(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }

        void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();

            if (columname == "clnqty" || columname == "clnrate")
            {
                Generalfunction.allowNumeric(sender, e, false);
            }
        }

        //public void RowClick(string Value, int KeyValue)
        //{
        //    try
        //    {
        //        if (columname == "clnitemcode")
        //        {
        //            if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
        //            {
        //                selectedrow1 = uscGridshow2.GridProductShow.SelectedRows[0].Index;
        //                string selectedItem = Convert.ToString(uscGridshow2.GridProductShow.Rows[selectedrow1].Cells["itemid"].Value);

        //                Itemname = CommonClass._Itemmaster.SpecificField(selectedItem, "itemname");
        //                Srate = CommonClass._Itemmaster.SpecificField(selectedItem, "srate");
        //                GridMain1.Rows[rowIndex].Cells["clnitemname"].Value = Itemname;
        //                GridMain1.Rows[rowIndex].Cells["clnrate"].Value = Srate;
        //                GridMain1.Rows[rowIndex].Cells["clnbatch"].Value = uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["bcode"].Value;
        //                GridMain1.Rows[rowIndex].Cells["clnitemcode"].Value = uscGridshow2.GridProductShow.Rows[selectedrow1].Cells["itemcode"].Value;

        //                uscGridshow2.Visible = false;
        //            }

        //            if (GridMain1.Columns[columIndex].Name == "clnitemcode")
        //            {
        //                int NowselectedRow;
        //                string TempItemcode;
        //                if (uscGridshow2.Visible == true)
        //                {
        //                    NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
        //                    TempItemcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["itemcode"].Value.ToString();
        //                }
        //                else
        //                {
        //                    TempItemcode = _Dbtask.znllString(GridMain1.Rows[rowIndex].Cells["clnitemcode"].Value);
        //                }

        //                GridMain1.NotifyCurrentCellDirty(true);
        //                Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where itemcode='" + TempItemcode + "'");
        //                if (Ds.Tables[0].Rows.Count > 0)
        //                {
        //                    string TemItemid = _Dbtask.ExecuteScalar("select itemid from TblItemMaster where itemcode='" + TempItemcode + "'");
        //                    ItemId = TemItemid;

        //                   // GridMain1.Rows[rowIndex].Cells["clnitemcode"].Value = TempItemcode;
        //                    //GridMain1.Rows[rowIndex].Cells["clnitemcode"].Tag = TemItemid;
        //                    GridMain1.Rows[rowIndex].Cells["clnitemname"].Tag = TemItemid;
        //                    GridMain1.Rows[rowIndex].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from Tblitemmaster where itemid='" + TemItemid + "'");
        //                    GridMain1.Rows[rowIndex].Cells["clnqty"].Value = 1;
        //                    double TempSrate = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(ItemId, "srate"));
        //                    GridMain1.Rows[rowIndex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);

        //                    NQTY = Convert.ToDouble(GridMain1.Rows[rowIndex].Cells["clnqty"].Value);
        //                    NRATE = Convert.ToDouble(GridMain1.Rows[rowIndex].Cells["clnrate"].Value);
        //                    uscGridshow2.Visible = false;

        //                    cellEnterCalculationpart();
        //                    Totalcalculation();

        //                }
        //                else
        //                {
        //                    MessageBox.Show("Itemcode Not exsting");

        //                }
        //            }

        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        void txt1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //throw new NotImplementedException();


            try
            {
                if (columname == "clnbatch")
                {
                    //RowClick((sender as TextBox).Text, e.KeyValue);
                    //(sender as TextBox).Text = GridMain.Rows[Rowindex].Cells[Columnidex].Value.ToString();
                    //if (e.KeyValue == 40)
                    //{
                    _ingrid.RowUpDownSelect(e.KeyValue, uscitemshowsimple1.GridProductShow, selectedRow, uscitemshowsimple1, GridMain1);
                    // }

                    if (uscitemshowsimple1.GridProductShow.SelectedRows.Count > 0)
                    {
                        select1 = uscitemshowsimple1.GridProductShow.SelectedRows[0].Index;
                        string SelectItem1 = Convert.ToString(uscitemshowsimple1.GridProductShow.Rows[select1].Cells["itemid"].Value);
                        //string ItemId=_DBTask.ExecuteScalar("select itemid from tblItemmaster where ")
                        Stock1 = Convert.ToDouble(CommonClass._Inventory.GetStock("where Pcode='" + SelectItem1 + "'"));

                        //uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(Stock1);
                    }

                    if (e.KeyValue == 13)
                    {
                        if (Stock1 <= 0)
                        {
                            DialogResult Result = MessageBox.Show("No Stock", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            uscGridshow2.Visible = false;
                        }
                        else
                        {

                            if (uscitemshowsimple1.GridProductShow.SelectedRows.Count > 0)
                            {
                                selectedrow1 = uscitemshowsimple1.GridProductShow.SelectedRows[0].Index;
                                string selectedItem = Convert.ToString(uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["itemid"].Value);

                                Itemname = CommonClass._Itemmaster.SpecificField(selectedItem, "itemname");
                                Srate = CommonClass._Itemmaster.SpecificField(selectedItem, "srate");
                                itemcode = CommonClass._Itemmaster.SpecificField(selectedItem, "itemcode");
                                GridMain1.Rows[rowIndex].Cells["clnitemname"].Value = Itemname;
                                GridMain1.Rows[rowIndex].Cells["clnrate"].Value = Srate;
                                GridMain1.Rows[rowIndex].Cells["clnitemcode"].Value = itemcode;
                                GridMain1.Rows[rowIndex].Cells["clnbatch"].Value = uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["bcode"].Value;
                                //GridMain.Rows[Rowindex].Cells["clnitemcode"].Value = uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["itemcode"].Value;

                                uscitemshowsimple1.Visible = false;
                            }

                            // }
                            if (searchbarcode == false)
                            {
                                GridMain1.Rows[rowIndex].Cells["clnbatch"].Value = (sender as TextBox).Text;
                            }

                            if (GridMain1.Columns[columIndex].Name == "clnbatch")
                            {
                                // if (e.KeyValue == 13)
                                //{
                                int NowselectedRow;
                                string TempBathcode;
                                if (uscitemshowsimple1.Visible == true)
                                {
                                    NowselectedRow = uscitemshowsimple1.GridProductShow.SelectedRows[0].Index;
                                    TempBathcode = uscitemshowsimple1.GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                                }
                                else
                                {
                                    TempBathcode = _Dbtask.znllString(GridMain1.Rows[rowIndex].Cells["clnbatch"].Value);
                                }

                                GridMain1.NotifyCurrentCellDirty(false);
                                Ds = _Dbtask.ExecuteQuery("select * from Tblbatch where bcode='" + TempBathcode + "'");
                                if (Ds.Tables[0].Rows.Count > 0)
                                {
                                    string TemItemid = _Dbtask.ExecuteScalar("select itemid from Tblbatch where bcode='" + TempBathcode + "'");
                                    ItemId = TemItemid;
                                    GridMain1.Rows[rowIndex].Cells["clnitemname"].Tag = TemItemid;
                                    GridMain1.Rows[rowIndex].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from Tblitemmaster where itemid='" + TemItemid + "'");
                                    GridMain1.Rows[rowIndex].Cells["clnqty"].Value = 1;
                                    double TempSrate = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "srate"));
                                    GridMain1.Rows[rowIndex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);

                                    NQTY = Convert.ToDouble(GridMain1.Rows[rowIndex].Cells["clnqty"].Value);
                                    NRATE = Convert.ToDouble(GridMain1.Rows[rowIndex].Cells["clnrate"].Value);
                                    uscitemshowsimple1.Visible = false;

                                    cellEnterCalculationpart();
                                    Totalcalculation();

                                    if (searchbarcode == false)
                                    {
                                        GridMain1.Rows.Add(1);
                                        GridMain1.CurrentCell = GridMain1.Rows[rowIndex + 1].Cells[0];
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Batchcode Not exsting");
                                    //if (Useasbarcode == true)
                                    //{
                                    //    gridmain.CurrentCell = gridmain.Rows[rowindex].Cells["clnbatch"];
                                    //}
                                }


                                //  }

                            }
                        }
                    
                    }
                
                }

                if (columname == "clnitemcode")
                {
                    if (SBatch == true)
                    {
                        uscGridshow2.Visible = false;
                    }

                        _ingrid.RowUpDownSelect(e.KeyValue, uscGridshow2.GridProductShow, selectedRow, uscGridshow2, GridMain1);
                   

                    if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                    {
                        select1 = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                        string SelectItem1 = Convert.ToString(uscGridshow2.GridProductShow.Rows[select1].Cells["itemid"].Value);
                        //string ItemId=_DBTask.ExecuteScalar("select itemid from tblItemmaster where ")
                        Stock1 = Convert.ToDouble(CommonClass._Inventory.GetStock("where Pcode='" + SelectItem1 + "'"));

                        uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(Stock1);
                    }


                    if (e.KeyValue == 13)
                    {
                        if (Stock1 <= 0)
                        {
                            DialogResult Result = MessageBox.Show("No Stock", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            uscGridshow2.Visible = false;
                        }

                        else
                        {

                            if (uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                            {
                                selectedrow1 = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                                string selectedItem = Convert.ToString(uscGridshow2.GridProductShow.Rows[selectedrow1].Cells["itemid"].Value);

                                Itemname = CommonClass._Itemmaster.SpecificField(selectedItem, "itemname");
                                Srate = CommonClass._Itemmaster.SpecificField(selectedItem, "srate");
                                GridMain1.Rows[rowIndex].Cells["clnitemname"].Value = Itemname;
                                GridMain1.Rows[rowIndex].Cells["clnrate"].Value = Srate;
                                // GridMain.Rows[Rowindex].Cells["clnbatch"].Value = uscitemshowsimple1.GridProductShow.Rows[selectedrow1].Cells["bcode"].Value;
                                GridMain1.Rows[rowIndex].Cells["clnitemcode"].Value = uscGridshow2.GridProductShow.Rows[selectedrow1].Cells["itemcode"].Value;

                                uscGridshow2.Visible = false;
                            }


                            //  }

                            if (GridMain1.Columns[columIndex].Name == "clnitemcode")
                            {
                                //if (e.KeyValue == 13)
                                //{
                                int NowselectedRow;
                                string TempItemcode;
                                if (uscGridshow2.Visible == true)
                                {
                                    NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                                    TempItemcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["itemcode"].Value.ToString();
                                }
                                else
                                {
                                    TempItemcode = _Dbtask.znllString(GridMain1.Rows[rowIndex].Cells["clnitemcode"].Value);
                                }

                                GridMain1.NotifyCurrentCellDirty(false);
                                Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where itemcode='" + TempItemcode + "'");
                                if (Ds.Tables[0].Rows.Count > 0)
                                {
                                    string TemItemid = _Dbtask.ExecuteScalar("select itemid from TblItemMaster where itemcode='" + TempItemcode + "'");
                                    ItemId = TemItemid;
                                    GridMain1.Rows[rowIndex].Cells["clnitemname"].Tag = TemItemid;
                                    GridMain1.Rows[rowIndex].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from Tblitemmaster where itemid='" + TemItemid + "'");
                                    GridMain1.Rows[rowIndex].Cells["clnqty"].Value = 1;
                                    double TempSrate = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(ItemId, "srate"));
                                    GridMain1.Rows[rowIndex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);

                                    NQTY = Convert.ToDouble(GridMain1.Rows[rowIndex].Cells["clnqty"].Value);
                                    NRATE = Convert.ToDouble(GridMain1.Rows[rowIndex].Cells["clnrate"].Value);
                                    uscGridshow2.Visible = false;

                                    cellEnterCalculationpart();
                                    Totalcalculation();

                                }
                                else
                                {
                                    MessageBox.Show("Itemcode Not exsting");

                                }


                                //}


                            }
                        }
                    
                    }
              
              
                }
            }


            catch
            {
            }
            if (e.KeyValue == 113 && ItemId != null) /*For F2  Delete Rows */
            {
                try
                {
                    DialogResult Result = MessageBox.Show("Do You Want to Delete This Row?", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result.ToString() == "Yes")
                    {

                        int selectedIndex = GridMain1.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            GridMain1.Rows.RemoveAt(selectedIndex);
                            Totalcalculation();
                        }
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Unable to remove selected row at this time");
                }
            }

        }

        public void Textalignsett()
        {
            GridMain1.Columns["clnqty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain1.Columns["clnbatch"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain1.Columns["clnslno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain1.Columns["clnrate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain1.Columns["clnitemname"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridMain1.Columns["clnamount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        void txt1_TextChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();

            if ((sender as TextBox).Text == "")
            {
                if (columname != "clnitemname" && columname != "clnbatch" && columname != "clnslno" && columname != "clnitemcode")
                {
                    (sender as TextBox).Text = "0";

                }

            }
            GridMain1.Rows[rowIndex].Cells[columIndex].Value = (sender as TextBox).Text;

            NQTY = _Dbtask.znlldoubletoobject(GridMain1.Rows[rowIndex].Cells["clnqty"].Value);
            NRATE = _Dbtask.znlldoubletoobject(GridMain1.Rows[rowIndex].Cells["clnrate"].Value);

            string temp = _Dbtask.znllString(GridMain1.Rows[rowIndex].Cells[columIndex].Value);

            if (columname == "clnbatch")
            {
                
                if (searchbarcode == true)
                {

                    ProductGridShowWithBatch("where Tblbatch.bcode like N'%" + temp + "%'");
                    //uscitemshowsimple1.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_ingrid.Stock);
                }


            }
            if (columname == "clnitemcode")
            {
                if (SBatch == true)
                {
                    uscGridshow2.Visible = false;
                }
                else
                {
                    ProductGridShow(temp);
                    //("where TblItemMaster.Itemcode like '%" + temp + "%'");
                }
            }

            //if (ComTax.Text!=null)
            //{
            //    retrivemode = 0;
            //}

            if (columname == "clnqty")
            {

            }


            cellEnterCalculationpart();
            //TaxCalcPart();
            Totalcalculation();
        }

        public void cellEnterCalculationpart()
        {
            try
            {
                InsertZeroValue();
                //GridMain.Rows[Rowindex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(NQTY);
                //GridMain.Rows[Rowindex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpointStock(NRATE);
                //  GridMain.Rows[Rowindex].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpointStock(NAMOUNT);

                NAMOUNT = NQTY * NRATE;
               // NAMOUNT = NAMOUNT + NCooly - NDiscAmnt;
                //  NAMOUNT = NAMOUNT - NDiscAmnt;



                //if (retrivemode == 0)
                //{
                //    TaxCalcPart();
                //}
                GridMain1.Rows[rowIndex].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpointStock(NAMOUNT);


            }
            catch
            {
            }
        }

        public void InsertZeroValue()
        {
            if (GridMain1.Rows[rowIndex].Cells["clnqty"] == null)
            {
                GridMain1.Rows[rowIndex].Cells["clnqty"].Value = 0;
            }
            if (GridMain1.Rows[rowIndex].Cells["clnrate"].Value == null)
            {
                GridMain1.Rows[rowIndex].Cells["clnrate"].Value = 0;
            }
            if (GridMain1.Rows[rowIndex].Cells["clnamount"].Value == null)
            {
                GridMain1.Rows[rowIndex].Cells["clnamount"].Value = 0;
            }


        } 

        public void Totalcalculation()
        {

            try
            {
                if (rowIndex < GridMain1.Rows.Count)
                {
                    GridMain1.Rows[rowIndex].Cells["clnslno"].Value = rowIndex + 1;/* For SlNo*/
                    Netqty = 0;
                    NetRate = 0;
                    NetAmount = 0;
                    NetTotal = 0;

                    for (int i = 0; i < GridMain1.Rows.Count; i++)  /* For Row NetAmount*/
                    {
                        if (GridMain1.Rows[i].Cells["clnamount"].Value != null)
                        {
                            NetAmount = NetAmount + Convert.ToDouble(GridMain1.Rows[i].Cells["clnamount"].Value);
                        }
                    }
                    //NetDiscount = _Dbtask.znullDouble(Txtdiscount.Text);
                    //NetCooly = _Dbtask.znullDouble(Txtcooly.Text);

                    txttotal1.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(NetAmount));
                }
            }
            catch
            {
            }
        }


        public void ProductGridShow(string WhereCondition)
        {
            try
            {
                _ingrid.ProductGridShowFixed(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, StockAreaid);

                // IsEnter = true;
                Rectangle tempRect = GridMain1.GetCellDisplayRectangle(GridMain1.CurrentCell.ColumnIndex, GridMain1.CurrentCell.RowIndex, false);


                _ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left+120, tempRect.Top + tempRect.Height*15-20);

                if (uscGridshow2.Visible == false)
                {
                    uscGridshow2.Visible = true;
                }
            }
            catch
            {
            }
        }

        public void ProductGridShowWithBatch(string WhereCondition)
        {
            try
            {
                _ingrid.BatchGridShow(uscitemshowsimple1, WhereCondition, uscitemshowsimple1.GridProductShow, StockAreaid,false,false,"");

                Rectangle temprect = GridMain1.GetCellDisplayRectangle(GridMain1.CurrentCell.ColumnIndex, GridMain1.CurrentCell.RowIndex, false);
                //if (temprect.Top > 400)
                //{
                //    _ingrid.ProductGridShowLocationSett(uscitemshowsimple1, temprect.Left, temprect.Top - temprect.Height + 6 * 3);
                //}
                //else
                //{
                    _ingrid.ProductGridShowLocationSett(uscitemshowsimple1, temprect.Left, temprect.Top + temprect.Height-10);
                //}

                if (uscitemshowsimple1.Visible == false)
                {
                    uscitemshowsimple1.Visible = true;
                }
            }
            catch
            {
            }
        }

        public void SetGridColumn()
        {
            try
            {
                GetMenusettings();

                Generalfunction.ActiveForm = this.Name.ToString();
                //retrivemode = 0;
               // Textalignsett();

                Bmode = true;
                if (SBatch == false)/*For Batch Enabled*/
                {
                    clnbatch.Visible = false;
                    clnitemname.ReadOnly = false;
                }
                if (Seditsrate == false)
                {
                    clnrate.ReadOnly = true;
                }
                //if (STax == false)
                //{
                //    //  clntax.Visible = false;
                //    //ClntaxPer.Visible = false;
                //    ComTax.Visible = false;
                //    lbltax.Visible = false;
                //}
            }
            catch
            {
            }
        }
        public void GetMenusettings()
        {
            try
            {
                _sales.FuFocusfirstRow();
                /*Batch*/
                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=103");
                if (temp == "1")
                {
                    SBatch = true;
                }
                /*Edit SalesRate*/
                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=112");
                if (temp == "1")
                {
                    Seditsrate = true;
                }
                /*Tax */
                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=14");
                if (temp == "1")
                {
                    STax = true;
                }

                /*Stock Area*/

                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=13");
                if (temp == "1")
                {
                    SDepo = true;
                }

                /*For Batch is Second*/

                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=121");
                if (temp == "1")
                {
                    Useasbarcode = true;
                }
                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=124");
                if (temp == "1")
                {
                    Supdatesrate = true;
                }
            }
            catch
            {
            }
        }

        private void GridMain1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columIndex = GridMain1.CurrentCell.ColumnIndex;
            rowIndex = GridMain1.CurrentCell.RowIndex;
            columname = GridMain1.Columns[columIndex].Name.ToString();

            cellEnter();
        }

        public void cellEnter()
        {
            if (columname == "clnslno")
            {
                SendKeys.Send("{Tab}");
            }
            if (columname == "clnitemname")
            {
                SendKeys.Send("{Tab}");
            }
            if (columname == "clnamount")
            {
                SendKeys.Send("{Enter}");
            }
            if (columname == "clnrate" || columname == "clnqty")
            {
                //  GridMain.Rows[Rowindex].Cells["clnbatch"].Value = _Dbtask.znlldoubletoobject(GridMain.Rows[Rowindex].Cells["clnbatch"].Value);
                GridMain1.BeginEdit(true);
            }
        }

        private void GridMain1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt1 = e.Control as TextBox;

            txt1.TextChanged -= new EventHandler(txt1_TextChanged);
            txt1.TextChanged += new EventHandler(txt1_TextChanged);

            txt1.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt1_PreviewKeyDown);
            txt1.PreviewKeyDown += new PreviewKeyDownEventHandler(txt1_PreviewKeyDown);

            txt1.KeyPress -= new KeyPressEventHandler(txt1_KeyPress);
            txt1.KeyPress += new KeyPressEventHandler(txt1_KeyPress);

            txt1.Enter -= new EventHandler(txt1_Enter);
            txt1.Enter += new EventHandler(txt1_Enter);
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void FillState()
        {
            txtState.Text = "KERALA";
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Showstatus();
        }

        private void cmdSearch1_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill; 
            txtEngNo1.Text = "";
            txtSearch.Text = "";
            cbxstatsearch.Text = "";
            txtchasis.Text = "";
            txtparty1.Text = "";
            txtpartymob.Text = "";
            showingrid();
           // Gridmain.Rows.Clear();

            
        }

        private void cbxstatsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxstatsearch.Text == "All")
            {
                
                Ds = _Dbtask.ExecuteQuery("select * from Tbladdenquiry");
                
                Gridmain.DataSource = Ds.Tables[0];
            }
            if (cbxstatsearch.Text == "Pending")
            {
                Ds = _Dbtask.ExecuteQuery("select * from Tbladdenquiry where status='0'");
                Gridmain.DataSource = Ds.Tables[0];
            }
            if (cbxstatsearch.Text == "Completed")
            {
                Ds = _Dbtask.ExecuteQuery("select * from Tbladdenquiry where status='1'");
                Gridmain.DataSource = Ds.Tables[0];
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //sql = "SELECT enqvno as SINo,Enqname AS '" + lblName.Text + "',company AS '" + lblCompanyname.Text + "',address AS '" + lblAddress.Text + "',telephone AS '" + lblTelephone.Text + "',mobile AS '" + lblMobile.Text + "',city AS '" + lblCity.Text + "',state AS '" + lblState.Text + "'," +
            //"CId AS '" + lblCountry.Text + "',email AS '" + lblEmail.Text + "',enqdate AS '" + lblDate.Text + "',enqtime AS '" + lblTime.Text + "',Empid as '" + lblEmployee.Text + "',enquiryabout AS '" + lblEnquiryabout.Text + "',response AS '" + lblResponse.Text +
            //"',status AS '" + lblStatus.Text + "',remarks AS '" + lblRemarks.Text + "',description AS '" + lblDescription.Text + "',ItemId AS '" + lblProduct.Text + "',Aid AS '" + lblAgent.Text + 
            //"' FROM Tbladdenquiry where Enqname like '%" + txtSearch.Text + "%' or company like '%" + txtSearch.Text + "%' or telephone like '%" + txtSearch.Text + "%' or mobile like '%" + txtSearch.Text + "%' or city like '%" + txtSearch.Text + "%' ";

            //string aid=_Dbtask.ExecuteScalar("select ")
            //string agent=_Dbtask.ExecuteScalar("select Lname from TblAccountLedger where AGroupId=29 and lid='"++"'")
            // sql = "Select * from Tbladdenquiry where enqname='" + txtSearch.Text + "'";

            sql = "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblAliasname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
            "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
            "TblCurrency.CId AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
            "Tbladdenquiry.Empid AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
            "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "', Tbladdenquiry.Aid AS '" + lblAgent.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "' FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId where Enqname like '%" + txtSearch.Text + "%'";


            Ds = _Dbtask.ExecuteQuery(sql);
            Gridmain.DataSource = Ds.Tables[0];
            //ShowInGrid1();
        }

        public void ShowInGrid1()
        {
            sql = "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblAliasname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
                     "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
                     "TblCurrency.CId AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
                     "Tbladdenquiry.Empid AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
                     "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "', Tbladdenquiry.Aid AS '" + lblAgent.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "' FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId where Enqname like '%" + txtSearch.Text + "%' or company like '%" + txtSearch.Text + "%' or telephone like '%" + txtSearch.Text + "%' or mobile like '%" + txtSearch.Text + "%' or city like '%" + txtSearch.Text + "%'or state like'%" + txtSearch.Text + "%'";


            Ds = _Dbtask.ExecuteQuery(sql);
            Gridmain.DataSource = Ds.Tables[0];
        }
       
        private void cmdclose1_Click(object sender, EventArgs e)
        {
            try
            {
                if(Gridmain.Rows.Count>1)
                Gridmain.Rows.Clear();
                txtSearch.Text = "";
                cbxstatsearch.Text = "";
                txtchasis.Text = "";
                txtpartymob.Text = "";
                txtparty1.Text = "";
                txtEngNo1.Text = "";
                pnlSearch.Visible = false;
            }
            catch
            {
            }
            
        }



        private void txtparty1_TextChanged(object sender, EventArgs e)
        {
            //Showstatus();
            //ShowInGrid1();
            sql = "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblAliasname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
                    "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
                    "TblCurrency.CId AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
                    "Tbladdenquiry.Empid AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
                    "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "', Tbladdenquiry.Aid AS '" + lblAgent.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "' FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId where company like '%" + txtparty1.Text + "%'";


            Ds = _Dbtask.ExecuteQuery(sql);
            Gridmain.DataSource = Ds.Tables[0];
        }

        private void txtpartymob_TextChanged(object sender, EventArgs e)
        {
            //Showstatus();
            //ShowInGrid1();
            sql = "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblAliasname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
                    "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
                    "TblCurrency.CId AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
                    "Tbladdenquiry.Empid AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
                    "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "', Tbladdenquiry.Aid AS '" + lblAgent.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "' FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId where mobile like '%" + txtpartymob.Text + "%'";


            Ds = _Dbtask.ExecuteQuery(sql);
            Gridmain.DataSource = Ds.Tables[0];
        }

        private void Gridmain_DoubleClick(object sender, EventArgs e)
        {
            Cellclick();
            disable();
        }

        //private void txtEngNo1_TextChanged(object sender, EventArgs e)
        //{
        //    sql = "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblAliasname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
        //           "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
        //           "TblCurrency.CId AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
        //           "Tbladdenquiry.Empid AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
        //           "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "', Tbladdenquiry.Aid AS '" + lblAgent.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "' FROM Tbladdenquiry INNER JOIN TblCurrency,tblCustomerLedger ON Tbladdenquiry.Enqname = tblCustomerLedger.RegNo and Tbladdenquiry.CId=TblCurrency.CId where tblCustomerLedger.EngNo like '%" + txtEngNo1.Text + "%'";


        //    Ds = _Dbtask.ExecuteQuery(sql);
        //    Gridmain.DataSource = Ds.Tables[0];
        //}

      


        //private void txtEngNo1_TextChanged(object sender, EventArgs e)
        //{
        //    sql = "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblAliasname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
        //            "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
        //            "TblCurrency.CId AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
        //            "Tbladdenquiry.Empid AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
        //            "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "', Tbladdenquiry.Aid AS '" + lblAgent.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "' FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId where Enqname like '%" + txtSearch.Text + "%' or company like '%" + txtSearch.Text + "%' or telephone like '%" + txtSearch.Text + "%' or mobile like '%" + txtSearch.Text + "%' or city like '%" + txtSearch.Text + "%'or state like'%" + txtSearch.Text + "%' or tblCustomerLedger.EngNo like'%" + txtEngNo1.Text + "%'";


        //    Ds = _Dbtask.ExecuteQuery(sql);
        //    Gridmain.DataSource = Ds.Tables[0];
        //}

        //private void pnlSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (e.KeyValue == 27)
        //    {
        //        if (pnlSearch.Visible = true)
        //        {
        //            pnlSearch.Visible = false;
        //        }
        //    }
        //}

      
     }
}
