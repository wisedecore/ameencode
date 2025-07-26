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
    public partial class FrmAddDepot : Form
    {
        public FrmAddDepot()
        {
            InitializeComponent();
        }

        public string Type;
        ClsDepot _Depot = new ClsDepot();
        NextGFuntion _NextgFunction = new NextGFuntion();
        public DataSet Ds;
        DBTask _Dbtask = new DBTask();


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
        public void Enetersett(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.Black;
            txt.ForeColor = System.Drawing.Color.White;
        }
        public void Leavesett(TextBox txt)
        {

            txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            txt.ForeColor = System.Drawing.Color.Black;
        }
        private void FrmAddDepot_Load(object sender, EventArgs e)
        {
            Clear();
        }
        public void Settcontrolltext()
        {
            lblstockareaheading.Text ="Create " +NextGFuntion.StockAreaName;
            LblName.Text = NextGFuntion.StockAreaName + "Name";
            RadWarehouse.Text = NextGFuntion.StockAreaName;
        }
        private void RadWarehouse_CheckedChanged(object sender, EventArgs e)
        {
            if (RadWarehouse.Checked == true)
            {
               // GrpWareHouse.Enabled = true;
               // GrpVehicle.Enabled = false;
                Type = "W";
            }
            
        }

        private void RadVehicle_CheckedChanged(object sender, EventArgs e)
        {
            //if (RadVehicle.Checked == true)
            //{
            //    GrpWareHouse.Enabled = false;
            //    GrpVehicle.Enabled = true;
            //    Type = "V";
            //}
        }

        private void FrmAddDepot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    NextgInitialize();
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
        public void Insert()
        {
            _Depot.InsertDepot();
        }
        public void Clear()
        {
            Settcontrolltext();
            _NextgFunction.SetControlesBehave(this);
            _NextgFunction.ClearControles(this);
            GetVno();
            CommonClass._Nextg.FormIcon(this);
        }
        public void GetVno()
        {
            _Depot.IdDepot();
            TxtId.Text =Convert.ToString(_Depot.Dcode);
        }
        
        public void NextgInitialize()
        {
            _Depot.Dcode = Convert.ToInt64(TxtId.Text);
           
            _Depot.Address = TxtAddress.Text;
            _Depot.City = TxtCity.Text;
            _Depot.Pin = TxtPostalCode.Text;
            _Depot.PhoneNo = TxtTelephone.Text;
            _Depot.RegNo = TxtRegNo.Text;
            _Depot.Lisenseno = TxtLicenceNo.Text;
            _Depot.Description = TxtDescription.Text;
            if(RadWarehouse.Checked)
            {
                _Depot.VehicleNo = -1;
                _Depot.Dname = TxtWareName.Text;
            }
            else
            {
            _Depot.VehicleNo=1;
            _Depot.Dname = TxtVehicleName.Text;

            }
            _Depot.Cpersone = TxtCpersone.Text;    
        }
        public bool ValidationFu()
        {
            if (Type == "W")
            {
                _Depot.VehicleNo = 0;
                _Depot.Lisenseno = TxtLicenceNo.Text;
                _Depot.Dname = TxtWareName.Text;
                _Depot.Mobile = TxtMobile.Text;
                _Depot.Cpersone = TxtCpersone.Text;
                _Depot.Description = TxtDescription.Text;

                Ds = _Dbtask.ExecuteQuery("select * from tbldepot where dname='"+TxtWareName.Text+"'");

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Already exsting WareHousename ");
                    TxtWareName.Focus();
                    return false;
                }
                if (TxtWareName.Text == "")
                {
                    MessageBox.Show("Please Type WareHousename ");
                    TxtWareName.Focus();
                    return false;
                }
            }
            if (Type == "V")
            {
                _Depot.VehicleNo = 1;
                _Depot.VehicleNo =Convert.ToInt32(TxtVehicleNo.Text);
                _Depot.Dname = TxtVehicleName.Text;
                _Depot.Mobile = TxtVehicleMobile.Text;
                _Depot.Cpersone = TxtVehicleCPersone.Text;
                _Depot.Description = TxtVehicleDescription.Text;
                if (TxtVehicleName.Text == "")
                {
                    MessageBox.Show("Please Type VehicleName ");
                    TxtVehicleName.Focus();
                    return false;
                }
                if (TxtVehicleNo.Text == "")
                {
                    MessageBox.Show("Please Type VehicleNo ");
                    TxtVehicleNo.Focus();
                    return false;
                }

            }

            else
            {
                Ds = _Dbtask.ExecuteQuery("select * from tbldepot where dname='" + TxtWareName.Text + "'");

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Already exsting WareHousename ");
                    TxtWareName.Focus();
                    return false;
                }
                if (TxtWareName.Text == "")
                {
                    MessageBox.Show("Please Type WareHousename ");
                    TxtWareName.Focus();
                    return false;
                }
            }


            return true;
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddDepot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void TxtWareName_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtWareName);
        }

        private void TxtCity_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtCity);
        }

        private void TxtTelephone_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtTelephone);
        }

        private void TxtCpersone_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtCpersone);
        }

        private void TxtLicenceNo_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtLicenceNo);
        }

        private void TxtAddress_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtAddress);
        }

        private void TxtPostalCode_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtPostalCode);
        }

        private void TxtMobile_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtMobile);
        }

        private void TxtRegNo_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtRegNo);
        }

        private void TxtDescription_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtDescription);
        }

        private void TxtDescription_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtDescription);
            Main();
        }

        private void TxtRegNo_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtRegNo);
        }

        private void TxtMobile_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtMobile);
        }

        private void TxtPostalCode_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtPostalCode);
        }

        private void TxtAddress_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtAddress);
        }

        private void TxtLicenceNo_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtLicenceNo);
        }

        private void TxtCpersone_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtCpersone);
        }

        private void TxtTelephone_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtTelephone);
        }

        private void TxtCity_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtCity);
        }

        private void TxtWareName_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtWareName);
        }

    }
}
