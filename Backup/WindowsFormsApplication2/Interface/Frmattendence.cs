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
    public partial class Frmattendence : Form
    {
        public Frmattendence()
        {
            InitializeComponent();
        }
        public bool Isinotherwindow;
        /*For totalcalculation*/
        double Totalattendence;
        double Totalsalary;
        double Totaloverduty;
        double Totalextra;
        double Totalextra2;
        double Totalamount;

        /*For Cell calculation*/
        double Csalary;
        double Cextra;
        double Cextra2;
        double Ctotal;

        string Columnname;
        int Rowindex;


        public bool EditMode;

       public float Vno;
        float Amode;
        DateTime Adate;

        float Slno;
        float Lid;
        int Amark;
        int ovmark;
        double salary;
        double extra;
        double extra2;
        string Note;
        bool Isinedit;

        public void Clear()
        {
            try
            {
                Isinotherwindow = false;
                EditMode = false;
                GetVno();
                gridmain.Rows.Clear();
                lbltotal.Text = CommonClass._Dbtask.SetintoDecimalpoint(0);
                lbltotalattendence.Text = CommonClass._Dbtask.SetintoDecimalpoint(0);
                lbltotalextra.Text = CommonClass._Dbtask.SetintoDecimalpoint(0);
                lbltotalextra2.Text = CommonClass._Dbtask.SetintoDecimalpoint(0);
                lbltotalsalary.Text = CommonClass._Dbtask.SetintoDecimalpoint(0);
                lbloverdutyno.Text = CommonClass._Dbtask.SetintoDecimalpoint(0);
            }
            catch
            {
            }
        }

        public void Showgrid()
        {
        }

        private bool Main()
        {
             //GetVno();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                Rowindex = i;
                Cellentercalculation();
            }
            if (RowValidation()&&ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteVoucher();
                    }

                    NextgInitialize();

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

        public void NextgInitialize()
        {
           Vno=Convert.ToInt64(txtvno.Text);
           Amode = comodeofpayment.SelectedIndex;
           Adate=dtdate.Value;

           for (int i = 0; i < gridmain.Rows.Count; i++)
           {

               if (gridmain.Rows[i].Tag != null)
               {
                   if (gridmain.Rows[i].Tag.ToString() == "1")
                   {
                       Slno=Convert.ToInt64(gridmain.Rows[i].Cells["Clnslno"].Value);
                       Lid = Convert.ToInt64(gridmain.Rows[i].Cells["clnempcode"].Tag);
                       Amark = Convert.ToInt16(gridmain.Rows[i].Cells["clnmark"].Value);
                       ovmark = Convert.ToInt16(gridmain.Rows[i].Cells["clnmarkover"].Value);
                       salary =CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnsalary"].Value);
                       extra = CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnexsalary"].Value);
                       extra2 = CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnextra2"].Value);
                       Note = Convert.ToString(gridmain.Rows[i].Cells["clnnote"].Value);

                       CommonClass._attendencedetail.slno = Slno;
                       CommonClass._attendencedetail.vno = Vno;
                       CommonClass._attendencedetail.lid = Lid;
                       CommonClass._attendencedetail.amark = Amark;
                       CommonClass._attendencedetail.salary = salary;
                       CommonClass._attendencedetail.extra = extra;
                       CommonClass._attendencedetail.note = Note;
                       CommonClass._attendencedetail.extra2 = extra2;
                       CommonClass._attendencedetail.ovmark = ovmark;
                       CommonClass._attendencedetail.Insertattendancedetail();
                       if (i == 61)
                       {
                       }

                       if (salary > 0&&Amark==1||extra>0&&Amark==1||extra2>0&&Amark==1)
                       {
                           CommonClass._GenLedger.VnoStr = txtvno.Text;
                           CommonClass._GenLedger.VdateDt = dtdate.Value;
                           CommonClass._GenLedger.VTypeStr = "At";
                           
                           CommonClass._GenLedger.SlNoLng = Convert.ToInt64("1");
                           CommonClass._GenLedger.LedCodeStr = Lid.ToString();
                           CommonClass._GenLedger.PurticularsStr = "For Salary Extra:" + extra + ",Extra2:"+extra2+"";


                           CommonClass._GenLedger.DbAmtDb =0;
                           CommonClass._GenLedger.CrAmt = salary+extra+extra2;
                           CommonClass._GenLedger.Naration = "";
                           CommonClass._GenLedger.RefnoStr = "";
                           CommonClass._GenLedger.InsertGeneralLedger();

                          
                       }
                   }

                   Totalamount = CommonClass._Dbtask.znullDouble(lbltotal.Text);
                   
               }
           }


           if (Totalamount > 0)
           {
               CommonClass._GenLedger.LedCodeStr = "26";
               CommonClass._GenLedger.PurticularsStr = "For Salary Extra:" + extra + ",Extra2:" + extra2 + "";
               CommonClass._GenLedger.DbAmtDb = Totalamount;
               CommonClass._GenLedger.CrAmt = 0;
               CommonClass._GenLedger.InsertGeneralLedger();
           }

           CommonClass._attendence.vno = Vno;
           CommonClass._attendence.adate = Adate;
           CommonClass._attendence.amode = Amode;
           CommonClass._attendence.Insertattendancemain();
        }

        public void GetVno()
        {
            txtvno.Text = CommonClass._attendence.Getvno();
        }

        public void DeleteVoucher()
        {
            CommonClass._Dbtask.ExecuteNonQuery("delete from tblattendancedetail where vno='"+txtvno.Text+"'");
            CommonClass._Dbtask.ExecuteNonQuery("delete from tblattendancemain where vno='" + txtvno.Text + "'");
            CommonClass._Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vno='" + txtvno.Text + "' and vtype='At'");

        }

        private bool ValidationFu()
        {
            if (txtvno.Text == "")
            {
                MessageBox.Show("Type Vno");
                txtvno.Focus();
                return false;
            }
            
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {

                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        if (txtvno.Text != "")
                        {
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool RowValidation()
        {
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {

                    if (gridmain.Rows[i].Cells["clnempcode"].Tag != null)
                        {
                            gridmain.Rows[i].Tag = 1;
                        }
                        else
                        {
                            gridmain.Rows[i].Tag = -1;
                        }

                }
            }
            catch
            {
            }
            return true;
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.GridHeaderConversion(gridmain);
                CommonClass._Language.PanelBasedConversion(pnltop);
                CommonClass._Language.PanelBasedConversion(pnlbottom);
                CommonClass._Language.PanelBasedConversion(panel2);
                CommonClass._Language.PanelBasedConversion(panel1);
                CommonClass._Language.PanelBasedConversion(Pnlright);
                CommonClass._Language.PanelBasedConversion(panel2);
            }
        }
        private void Frmattendence_Load(object sender, EventArgs e)
        {
            if (Isinotherwindow == true)
            {
                Retrive(Vno);
            }
            else
            {
                Clear();
            }
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }

        public void Retrive(float pvno)
        {
            try
            {
                gridmain.Rows.Clear();
                Isinedit = true;
                CommonClass.Ds = CommonClass._attendence.show(" where vno='" + pvno + "'");
                EditMode = true;
                Vno = pvno;
                Adate = Convert.ToDateTime(CommonClass.Ds.Tables[0].Rows[0]["adate"]);
                Amode = Convert.ToInt64(CommonClass.Ds.Tables[0].Rows[0]["amode"]);

                txtvno.Text = Vno.ToString();
                dtdate.Value = Adate;
                comodeofpayment.SelectedIndex = Convert.ToInt16(Amode);

                CommonClass.Ds = CommonClass._attendencedetail.show(" where vno='" + Vno + "' order by cast(slno as int) asc ");

                for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
                {
                    gridmain.Rows.Add(1);
                    gridmain.Rows[i].Cells["clnslno"].Value = i + 1;
                    Lid = Convert.ToInt64(CommonClass.Ds.Tables[0].Rows[i]["lid"].ToString());
                    gridmain.Rows[i].Cells["clnempcode"].Tag = Lid; 
                    gridmain.Rows[i].Cells["clnempcode"].Value = CommonClass._Employee.GetspecifField("empcode", Lid.ToString());
                    gridmain.Rows[i].Cells["clnempname"].Value = CommonClass._Employee.GetspecifField("empname", Lid.ToString());
                    gridmain.Rows[i].Cells["clnmobile"].Value = CommonClass._Employee.GetspecifField("mobile", Lid.ToString());
                    gridmain.Rows[i].Cells["clndepartment"].Value = CommonClass._Department.Getspecificfield(CommonClass._Employee.GetspecifField("department", Lid.ToString()), "Depname");

                    if (CommonClass.Ds.Tables[0].Rows[i]["amark"].ToString() == "1")
                    {
                        gridmain.Rows[i].Cells["clnmark"].Value = 1; ;
                    }
                    else
                    {
                        gridmain.Rows[i].Cells["clnmark"].Value = 0;
                    }

                    gridmain.Rows[i].Cells["clnsalary"].Value = CommonClass.Ds.Tables[0].Rows[i]["salary"].ToString();
                    gridmain.Rows[i].Cells["clnexsalary"].Value = CommonClass.Ds.Tables[0].Rows[i]["extra"].ToString();
                    gridmain.Rows[i].Cells["clnnote"].Value = CommonClass.Ds.Tables[0].Rows[i]["note"].ToString();


                        gridmain.Rows[i].Cells["clnextra2"].Value = CommonClass.Ds.Tables[0].Rows[i]["extra2"].ToString();


                    gridmain.Rows[i].Cells["clnmarkover"].Value = CommonClass.Ds.Tables[0].Rows[i]["ovmark"].ToString();
                }
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    Rowindex = i;
                    Cellentercalculation();
                }
                Isinedit = false;
            }
            catch
            {
            }
        }
        public void Cellentercalculation()
        {
            try
            {
                if (gridmain.Rows[Rowindex].Cells["clnmark"].Value.ToString() == "1")
                {
                    Csalary = CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[Rowindex].Cells["clnsalary"].Value);
                    Cextra = CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[Rowindex].Cells["clnexsalary"].Value);
                    Cextra2 = CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[Rowindex].Cells["clnextra2"].Value);
                    Ctotal = Csalary + Cextra + Cextra2;
                    gridmain.Rows[Rowindex].Cells["clntotal"].Value = CommonClass._Dbtask.SetintoDecimalpoint(Ctotal);
                }
                else
                {
                    gridmain.Rows[Rowindex].Cells["clntotal"].Value = CommonClass._Dbtask.SetintoDecimalpoint(0);
                }
                Totalamountcalculation();
            }
            catch
            {
            }
        }
        public void Totalamountcalculation()
        {
            try
            {
                RowValidation();
                Totalattendence=0;
                Totalsalary=0;
                Totalextra=0;
                Totalextra2=0;
                Totaloverduty=0;
                Totalamount=0;
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            if (gridmain.Rows[i].Cells["clnmark"].Value != null)
                            {
                                if (gridmain.Rows[i].Cells["clnmark"].Value.ToString() == "1")
                                    Totalattendence = Totalattendence + 1;
                            }

                            Totalsalary = Totalsalary +CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnsalary"].Value);

                            Totalextra = Totalextra +CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnexsalary"].Value);

                            Totalextra2 = Totalextra2 +CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnextra2"].Value);

                            if (gridmain.Rows[i].Cells["clnmarkover"].Value !=null)
                            {

                                if (gridmain.Rows[i].Cells["clnmarkover"].Value.ToString() == "1")
                                {

                                    Totaloverduty = Totaloverduty + 1;
                                }
                            }
                            Totalamount = Totalamount + CommonClass._Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clntotal"].Value);

                        
                        }
                    }

                }
                lbltotalattendence.Text = Totalattendence.ToString();
                lbltotalsalary.Text =CommonClass._Dbtask.SetintoDecimalpoint(Totalsalary);
                lbltotalextra.Text =CommonClass._Dbtask.SetintoDecimalpoint(Totalextra);
                lbltotalextra2.Text =CommonClass._Dbtask.SetintoDecimalpoint( Totalextra2);
                lbloverdutyno.Text =CommonClass._Dbtask.SetintoDecimalpoint( Totaloverduty);
                lbltotal.Text = CommonClass._Dbtask.SetintoDecimalpoint(Totalamount);
            }
            catch
            {
            }
        }

        public void Fillstaff()
        {
            try
            {
                if (Isinedit == false)
                {
                    gridmain.Rows.Clear();
                    string where;
                    if (comodeofpayment.SelectedIndex == 0)
                        where = "";
                    else
                        where = " where mpayment ='" + comodeofpayment.Text + "'";

                    CommonClass.Ds = CommonClass._Employee.ShowEmployeeInGrid(" order by empname asc");

                    for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
                    {
                        gridmain.Rows.Add(1);
                        gridmain.Rows[i].Cells["clnslno"].Value = i + 1;
                        gridmain.Rows[i].Cells["clnempcode"].Tag = CommonClass.Ds.Tables[0].Rows[i]["empid"].ToString();
                      
                        gridmain.Rows[i].Cells["clnempcode"].Value = CommonClass.Ds.Tables[0].Rows[i]["empcode"].ToString();
                        gridmain.Rows[i].Cells["clnempname"].Value = CommonClass.Ds.Tables[0].Rows[i]["empname"].ToString();
                        gridmain.Rows[i].Cells["clnmobile"].Value = CommonClass.Ds.Tables[0].Rows[i]["mobile"].ToString();
                        gridmain.Rows[i].Cells["clndepartment"].Value = CommonClass._Department.Getspecificfield(CommonClass.Ds.Tables[0].Rows[i]["Department"].ToString(), "depname");
                        gridmain.Rows[i].Cells["clnmark"].Value = 0;
                        gridmain.Rows[i].Cells["clnsalary"].Value = CommonClass.Ds.Tables[0].Rows[i]["salary"].ToString(); ;
                    }
                }
            }
            catch
            {
            }
        }

        private void Comemployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fillstaff();
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            Retrive(Convert.ToInt64(txtvno.Text) - 1);
        }

        private void CmdForward_Click(object sender, EventArgs e)
        {
            Retrive(Convert.ToInt64(txtvno.Text) + 1);
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DeleteVoucher();
            Clear();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmattendence_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Frmattendence_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void chkmark_CheckedChanged(object sender, EventArgs e)
        {
            int Mark;
            if (chkmark.Checked == true)
            {
                Mark = 1;
            }
            else
            {
                Mark = 0;
            }

            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                if (gridmain.Rows[i].Cells["clnempcode"].Tag != null)
                {
                    gridmain.Rows[i].Cells["clnmark"].Value = Mark;
                }
            }
        }

        private void chkmarkovertime_CheckedChanged(object sender, EventArgs e)
        {
            int Mark;
            if (chkmarkovertime.Checked == true)
            {
                Mark = 1;
            }
            else
            {
                Mark = 0;
            }

            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                if (gridmain.Rows[i].Cells["clnempname"].Tag != null)
                {
                    gridmain.Rows[i].Cells["clnmarkover"].Value = Mark;
                }
            }
        }

       

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Rowindex = gridmain.CurrentCell.RowIndex;
                Columnname =gridmain.Columns[gridmain.CurrentCell.ColumnIndex].Name.ToString();
                if(gridmain.Rows[Rowindex].Cells["clnempname"].Tag !=null)
                Lid =Convert.ToInt64(gridmain.Rows[Rowindex].Cells["clnempname"].Tag.ToString());
            }
            catch
            {
            }
        }

        
        

       

        private void gridmain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Columnname == "clnmarkover")
                {
                    if (gridmain.Rows[Rowindex].Cells[Columnname].Value.ToString() == "1")
                    {
                       // gridmain.Rows[Rowindex].Cells["clnexsalary"].Value = CommonClass._Employee.GetspecifField("commi", Lid.ToString());
                    }
                    else
                    {
                       // gridmain.Rows[Rowindex].Cells["clnexsalary"].Value = "0.00";
                    }
                }
            }
            catch
            {
            }
        }

        private void gridmain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (gridmain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void gridmain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            gridmain.Rows[Rowindex].Cells[Columnname].Value = (sender as TextBox).Text;
            Cellentercalculation();
        }

        private void cmdrefresh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                Rowindex = i;
                Cellentercalculation();
            }
        }

       
    }
}
