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
    public partial class frmAddenquiry : Form
    {
        public frmAddenquiry()
        {
            InitializeComponent();
        }
        NextGFuntion _Nextg = new NextGFuntion();
        ClsAddenquiry _Addenq = new ClsAddenquiry();
        ClsAccountLedger _AccLed = new ClsAccountLedger();
        Clsfields _Fileds = new Clsfields();
        DBTask _Dbtask = new DBTask();
        DataSet Ds = new DataSet();
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
        public string ProductVno;


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
            }
            
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void frmAddenquiry_Load(object sender, EventArgs e)
        {
            showingrid();
            _Nextg.FormStylesett(this);
            _Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlBottom);
            _Nextg.FormHeadStyle(pnlHead);
            //_Nextg.FormImage(pnlImage);
            Fillstatus();
            Fillcountry();
            FillAllEmployee();
            FillCombo();
            FillallAgent();
            Textsett();
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
                    {
                        sql = "UPDATE  TblAddenquiry SET Enqname='" + txtName.Text.Replace("'", "") + "' ,company='" + txtAliasName.Text.Replace("'", "") + "' ,address='" + txtAddress.Text.Replace("'", "") + "' where enqvno='" + txtvno.Text + "'";
                        Ds = _Dbtask.ExecuteQuery(sql);
                        Generalfunction.EditFun = 0;
                        MessageBox.Show("Updated successfully", "Qplex", MessageBoxButtons.OK);
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

        public void NextgInitialize()
        {
            _Addenq.Vno = Convert.ToInt64(txtvno.Text);
            _Addenq.LidLng = Convert.ToInt64(txtLid.Text);
            _Addenq.Name = txtName.Text;
            _Addenq.Company = txtAliasName.Text;
            _Addenq.Address = txtAddress.Text;
            _Addenq.Telephone = txtTelephone.Text;
            _Addenq.Mobile = txtMobile.Text;
            _Addenq.City = txtCity.Text;
            _Addenq.State = txtState.Text;
            _Addenq.CountryId = Convert.ToInt64(cbxCountry.SelectedValue);
            _Addenq.Email = txtemail.Text;
            _Addenq.Date = dtpDate.Value;
            _Addenq.Time = dtpTime.Value;
            _Addenq.EmpidLng = Convert.ToInt64(cbxEmployee.SelectedValue);
            _Addenq.Enquiryabout = cbxEnquiryabout.Text;
            _Addenq.Response = cbxResponse.Text;
            _Addenq.StatusId = Convert.ToInt64(cbxStatus.SelectedValue);
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
           // _Addenq.ProductVno = ProductVno;
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
            txtState.Text="";
            txtRemarks.Text="";
            txtSearch.Text = "";
            cbxCountry.SelectedIndex = -1;
            cbxEmployee.SelectedIndex = -1;
            cbxEnquiryabout.SelectedIndex=-1;
            cbxResponse.SelectedIndex = -1;
            cbxStatus.SelectedValue = -1;
            txtDescription.Text = "";
          //  cbxProduct.SelectedIndex = -1;
            cbxAgent.SelectedIndex = -1;
            txtUserfield1.Text = "";
            txtUserfield2.Text = "";
            txtUserfield3.Text = "";
            txtUserfield4.Text = "";
            txtUserfield5.Text = "";
            Gridcustomerlist.Visible = false;
            EditMode = false;
            NextVno();
            NextLid();
            showingrid();
            Enable();
            txtName.Focus();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        public void Fillstatus()
        {
            _Addenq.FillStatus(cbxStatus, Status);
        }

        public void Fillcountry()
        {
            _Addenq.FillComboWhere(cbxCountry, WhereCountryList);
        }

        public void FillAllEmployee()
        {
            _Addenq.FillEmployee(cbxEmployee,AllEmployee);
        }

        public void FillallAgent()
        {
            _Addenq.FillAgent(cbxAgent, AllAgent); 
        }

        //public void FillProducts()
        //{
        //    _Addenq.FillProduct(cbxProduct, AllProduct); 
        //}

        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    if (EditMode == false)
                    {
                        DeleteEnquiry();
                    }
                    NextgInitialize();
                    Insert();
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

        public void inserLedger()
        {
            sql="insert into TblAccountLedger(Lid,LName,AGroupId,Address,Phone,Mobile,Email)values('" + txtLid.Text.Replace("'", "") + "','" + txtName.Text.Replace("'","") + "','18','" + txtAddress.Text.Replace("'","") + "','" + txtTelephone.Text.Replace("'","") + "','" + txtMobile.Text.Replace("'","") + "','" + txtemail.Text.Replace("'","") +"')";
            _Dbtask.ExecuteQuery(sql);
        }

        public void Insert()
        {
            if (cbxStatus.SelectedIndex == 1)
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
        }

        public void Clear1()
        {
            ClearControls();
            Fillcountry();
            NextVno();
        }

        public void DeleteEnquiry()
        {
            _Dbtask.ExecuteNonQuery("delete from Tbladdenquiry where enqvno ='" + txtvno.Text + "'");
            _Dbtask.ExecuteNonQuery("delete from TblAccountLedger where Lid ='" + txtLid.Text + "'");
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
            catch 
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
            Ds = _Dbtask.ExecuteQuery("select * from TblAccountLedger where LName like '%" + txtName.Text + "%' and AGroupId='18'");
           
            Gridcustomerlist.Visible = true;
            Gridcustomerlist.Rows.Clear();
            if (Generalfunction.Comeform == "")
            {
                Ds = _Dbtask.ExecuteQuery("select * from Tbladdenquiry where Enqname like '%" + txtName.Text + "%'");
            }

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Gridcustomerlist.Rows.Add(1);
                Gridcustomerlist.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["LName"];
                Gridcustomerlist.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["lid"];
            }
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
                        txtName.Tag = Gridcustomerlist.Rows[selectedRow].Cells[0].Tag.ToString(); 
                        txtName.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();
                        
                        Gridcustomerlist.Visible = false;
                        AlreadyExist();
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
                       "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "', Tbladdenquiry.Aid AS '" + lblAgent.Text + "'FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId ";

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

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Showstatus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           //sql = "SELECT enqvno as SINo,Enqname AS '" + lblName.Text + "',company AS '" + lblCompanyname.Text + "',address AS '" + lblAddress.Text + "',telephone AS '" + lblTelephone.Text + "',mobile AS '" + lblMobile.Text + "',city AS '" + lblCity.Text + "',state AS '" + lblState.Text + "'," +
           //"CId AS '" + lblCountry.Text + "',email AS '" + lblEmail.Text + "',enqdate AS '" + lblDate.Text + "',enqtime AS '" + lblTime.Text + "',Empid as '" + lblEmployee.Text + "',enquiryabout AS '" + lblEnquiryabout.Text + "',response AS '" + lblResponse.Text +
           //"',status AS '" + lblStatus.Text + "',remarks AS '" + lblRemarks.Text + "',description AS '" + lblDescription.Text + "',ItemId AS '" + lblProduct.Text + "',Aid AS '" + lblAgent.Text + 
           //"' FROM Tbladdenquiry where Enqname like '%" + txtSearch.Text + "%' or company like '%" + txtSearch.Text + "%' or telephone like '%" + txtSearch.Text + "%' or mobile like '%" + txtSearch.Text + "%' or city like '%" + txtSearch.Text + "%' ";

            sql = "SELECT Tbladdenquiry.enqvno AS 'SINo',Tbladdenquiry.Enqname AS '" + lblName.Text + "', Tbladdenquiry.company AS '" + lblAliasname.Text + "', Tbladdenquiry.address AS '" + lblAddress.Text + "'," +
                     "Tbladdenquiry.telephone AS '" + lblTelephone.Text + "', Tbladdenquiry.mobile AS '" + lblMobile.Text + "', Tbladdenquiry.city AS '" + lblCity.Text + "', Tbladdenquiry.state AS '" + lblState.Text + "'," +
                     "TblCurrency.description AS  '" + lblCountry.Text + "', Tbladdenquiry.email AS '" + lblEmail.Text + "', Tbladdenquiry.enqdate AS '" + lblDate.Text + "', Tbladdenquiry.enqtime AS '" + lblTime.Text + "'," +
                     "Tbladdenquiry.Empid AS '" + lblEmployee.Text + "', Tbladdenquiry.enquiryabout AS '" + lblEnquiryabout.Text + "', Tbladdenquiry.response AS '" + lblResponse.Text + "', Tbladdenquiry.status AS '" + lblStatus.Text + "'," +
                     "Tbladdenquiry.remarks AS '" + lblRequirment.Text + "', Tbladdenquiry.description AS '" + lblDescription.Text + "', Tbladdenquiry.Aid AS '" + lblAgent.Text + "'FROM Tbladdenquiry INNER JOIN TblCurrency ON Tbladdenquiry.CId = TblCurrency.CId where Enqname like '%" + txtSearch.Text + "%' or company like '%" + txtSearch.Text + "%' or telephone like '%" + txtSearch.Text + "%' or mobile like '%" + txtSearch.Text + "%' or city like '%" + txtSearch.Text + "%' ";


            Ds = _Dbtask.ExecuteQuery(sql);
            Gridmain.DataSource = Ds.Tables[0];
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
            if (Gridmain.SelectedRows.Count > 0 && Gridmain.SelectedRows[0].Cells[0].Value != DBNull.Value)
            {
                txtvno.Text = Gridmain.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = Gridmain.SelectedRows[0].Cells[1].Value.ToString();
                txtAliasName.Text = Gridmain.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text = Gridmain.SelectedRows[0].Cells[3].Value.ToString();
                txtTelephone.Text = Gridmain.SelectedRows[0].Cells[4].Value.ToString();
                txtMobile.Text = Gridmain.SelectedRows[0].Cells[5].Value.ToString();
                txtCity.Text = Gridmain.SelectedRows[0].Cells[6].Value.ToString();
                txtState.Text = Gridmain.SelectedRows[0].Cells[7].Value.ToString();
                cbxCountry.Text = Gridmain.Rows[0].Cells[8].Value.ToString();
                txtemail.Text = Gridmain.SelectedRows[0].Cells[9].Value.ToString();
                dtpDate.Text = Gridmain.SelectedRows[0].Cells[10].Value.ToString();
                dtpTime.Text = Gridmain.SelectedRows[0].Cells[11].Value.ToString();
                cbxEmployee.Text = Gridmain.SelectedRows[0].Cells[12].Value.ToString();
                cbxEnquiryabout.Text = Gridmain.SelectedRows[0].Cells[13].Value.ToString();
                cbxResponse.Text = Gridmain.SelectedRows[0].Cells[14].Value.ToString();
                cbxStatus.SelectedValue = Gridmain.SelectedRows[0].Cells[15].Value.ToString();
                txtRemarks.Text = Gridmain.SelectedRows[0].Cells[16].Value.ToString();
                txtDescription.Text = Gridmain.SelectedRows[0].Cells[17].Value.ToString();
                //cbxProductType.SelectedValue = Gridmain.SelectedRows[0].Cells[17].Value.ToString();
               // cbxProduct.Text = Gridmain.SelectedRows[0].Cells[18].Value.ToString();
                cbxAgent.SelectedValue = Gridmain.SelectedRows[0].Cells[19].Value.ToString();
                txtUserfield1.Text = Gridmain.SelectedRows[0].Cells[20].Value.ToString();
                txtUserfield2.Text = Gridmain.SelectedRows[0].Cells[21].Value.ToString();
                txtUserfield3.Text = Gridmain.SelectedRows[0].Cells[22].Value.ToString();
                txtUserfield4.Text = Gridmain.SelectedRows[0].Cells[23].Value.ToString();
                txtUserfield5.Text = Gridmain.SelectedRows[0].Cells[24].Value.ToString();
                Gridcustomerlist.Visible = false;
            }
        }
        private void Gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Cellclick();
            disable();
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
            cbxCountry.Enabled = false;
            txtemail.Enabled = false;
            dtpDate.Enabled = false;
            dtpTime.Enabled = false;
            cbxEmployee.Enabled = false;
            cbxEnquiryabout.Enabled = false;
            cbxResponse.Enabled = false;
            cbxStatus.Enabled = false;
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
        }

        public void Enable()
        {
            txtName.Enabled = true;
            txtAliasName.Enabled = true;
            txtAddress.Enabled = true;
            txtTelephone.Enabled = true;
            txtMobile.Enabled = true;
            txtCity.Enabled = true;
            txtState.Enabled = true;
            cbxCountry.Enabled = true;
            txtemail.Enabled = true;
            dtpDate.Enabled = true;
            dtpTime.Enabled = true;
            cbxEmployee.Enabled = true;
            cbxEnquiryabout.Enabled = true;
            cbxResponse.Enabled = true;
            cbxStatus.Enabled = true;
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteFields();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            Enable();
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
            _pos.ShowDialog();
            
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

                       
     }
}
