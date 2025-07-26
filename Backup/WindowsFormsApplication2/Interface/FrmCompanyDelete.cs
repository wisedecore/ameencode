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
    public partial class frmdeletecomp : Form
    {
        public frmdeletecomp()
        {
            InitializeComponent();
        }
        int Count;

        ClsCompanyMaster _CompanyMaster = new ClsCompanyMaster();
        ClsUserDetails _UserDetails = new ClsUserDetails();
        ClsCompanyCreate _ComCreate = new ClsCompanyCreate();
        NextGFuntion _Nextg = new NextGFuntion();
        DataSet DsCompanyList;
        DBTask _Dbtask = new DBTask();

        string SelCompany;
        string Sql;
        private void frmdeletecomp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            DeleteCompany();
      
            this.Close();
        }


        public void DeleteCompany()
        {
            for (int i = 0; i < GridCheck.Rows.Count; i++)
            {
               if(_Dbtask.znllString(GridCheck.Rows[i].Cells[0].Value) =="1")
                {
                    if (GridCheck.Rows[i].Cells[1].Value != null)
                    {
                        SelCompany = GridCheck.Rows[i].Cells[1].Value.ToString();
                        Sql = "use master alter database "+SelCompany+" set single_user with rollback immediate drop database "+SelCompany+"";
                        _Dbtask.ExecuteNonQuery(Sql);
                       
                    }
                  
                }
        
            }
            MessageBox.Show(" Company Deleted");
        }

        public void LoadCompany()
        {
            DsCompanyList = _ComCreate.LoadCompany();
            //ChkListCompany.DataBindings.
            try
            {
                GridCheck.Rows.Clear();
               // ChkListCompany.Items.Clear();
                for (int i = 0;i< DsCompanyList.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        string TempCompanyName = DsCompanyList.Tables[0].Rows[i]["name"].ToString();
                        // ChkListCompany.Items.Add(TempCompanyName); 
                        Generalfunction.TempCompanyname = TempCompanyName;
                        string Temp = _Dbtask.ExecuteScalar("select paramvalue from Tblparamlist where paramname='SDelete'");

                        if (TempCompanyName != "DEMOCOMPANY" && TempCompanyName != Generalfunction.OpCompany)
                        {
                            if (Temp == "1" || Temp == "-1")
                            {
                                Count = GridCheck.Rows.Add(1);
                                GridCheck.Rows[Count].Cells["clntext"].Value = TempCompanyName;
                                //ChkListCompany.Items.Add(TempCompanyName);
                                GridCheck.Rows[Count].Cells["clnaddress1"].Value = _Dbtask.ExecuteScalar("select address1 from tblcompanymaster  ");
                                GridCheck.Rows[Count].Cells["clntelephoneno"].Value = _Dbtask.ExecuteScalar("select Telephone from tblcompanymaster  ");
                                GridCheck.Rows[Count].Cells["clnemail"].Value = _Dbtask.ExecuteScalar("select Email from tblcompanymaster  ");
                                GridCheck.Rows[Count].Cells["clnweb"].Value = _Dbtask.ExecuteScalar("select website from tblcompanymaster  ");
                                //GridCheck.Rows[Count].Cells["clnacccount"].Value = _Dbtask.ExecuteScalar("select account from tblcompanymaster  ");
                            }
                        }
                    }
                    catch
                    {
                    }
                    
                }
            }
            catch
            {
            }
        }

   
        private void frmdeletecomp_Load(object sender, EventArgs e)
        {
            _Nextg.ClearControles(this);
            _Nextg.FormStylesett(this);
            LoadCompany();
            CommonClass._Nextg.FormIcon(this);
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridCheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
       

      
    }
}
