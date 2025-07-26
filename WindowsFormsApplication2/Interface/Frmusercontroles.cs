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
    public partial class Frmusercontroles : Form
    {
        public Frmusercontroles()
        {
            InitializeComponent();
        }
        public bool IsArabic;

        public void DetectLanguage()
        {
            string lng = CommonClass._Paramlist.GetParamvalue("Language");
            if (lng == "Arabic")
            {
                IsArabic = true;
            }
            else
            {
                IsArabic = false;
            }
        }
        public void ChangeLanguage()
        {
            DetectLanguage();
            if (IsArabic == true)
            {
                CommonClass._Language.PanelBasedButtunConversion(PNl);
                 //CommonClass._Language.PanelBasedConversion(pnlcommon);
                //CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.PanelBasedConversion(panel5);
                //CommonClass._Language.PanelBasedConversion(PnlPrintOptions);
            }
        }
        private void picitems_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).simpleItemToolStripMenuItem.PerformClick();
        }

        private void Picpurchase_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnupurchase.PerformClick();
        }

        private void cmdpurchase_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnupurchase.PerformClick();
        }

        private void picpayment_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnupayment.PerformClick();
        }

        private void cmdpayment_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnupayment.PerformClick();
        }

        private void picsales_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnusales.PerformClick();
        }

        private void cmdsales_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnusales.PerformClick();
        }

        private void picreceipt_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnureceipt.PerformClick();
        }

        private void cmdreceipt_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnureceipt.PerformClick();
        }

        private void picedit_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnueditwindow.PerformClick();
        }

        public void MousLeave(Control Cnt)
        {
            Cnt.Size = new System.Drawing.Size(60, 47);
        }

        public void MousLeaveButton(Control Cnt)
        {
            Cnt.Size = new System.Drawing.Size(94, 74);
        }

        private void cmdeditt_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnueditwindow.PerformClick();
        }

        private void cmdreportshow_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnumainreport.PerformClick();
        }

        private void picreport_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnumainreport.PerformClick();
        }

        public void Mousover(Control Cnt)
        {
            Cnt.Size = new System.Drawing.Size(200, 150);
        }

        private void cmdlogout_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnulogout.PerformClick();
        }

        private void picsupplier_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2). mnusuppliercreate.PerformClick();
        }

        private void piccustomer_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnucustomercreate.PerformClick();
        }

        private void picemployee_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnuemployeecreate.PerformClick();
        }

        private void picledger_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2). mnuledgercreate.PerformClick();
        }

        private void picbackup_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).backupAndRestoreToolStripMenuItem.PerformClick();
        }

        private void pilogout_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnulogout.PerformClick();  
        }
        private void Frmusercontroles_Load(object sender, EventArgs e)
        {
            visiblefalse();
            RegistrationCheck();
            ChangeLanguage();
        }

        public void RegistrationCheck()
        {
            //if (Clsregistration.IsRegistred == true)
            //    pnldemo.Visible = false;
        }

        public void visiblefalse()
        {
            try
            {
                RegistrationCheck();
                CommonClass.temp =CommonClass._Dbtask.currentcompany();
                if (CommonClass.temp != "master" && CommonClass.temp != null)
                {
                   CommonClass.Ds =CommonClass._Dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=21 and lname='WHOLESALE'");
                   if (CommonClass.Ds.Tables[0].Rows.Count > 0)
                    {
                        Picwholesale.Visible = true;
                        Cmdwholsale.Visible = true;
                    }
                    else
                    {
                        Picwholesale.Visible = false;
                        Cmdwholsale.Visible = false;
                    }
                }

                string stsservce = CommonClass._Dbtask.ExecuteScalar("select status from tblmnusettings where menuname='enableservice'and menuid='2022'").ToString();
                if (stsservce == "1")
                {
                    cmdservice.Visible = true;
                    picbxservices.Visible = true;

                }
                else
                {
                    cmdservice.Visible = false;
                    picbxservices.Visible = false;
                    //cmdlogout.Location =new Point( 108,455);
                    //pilogout.Location =new Point( 124,458);

                }

                if (ClsUserDetails.UserGroupid == "100" || ClsUserDetails.UserGroupid == "101")
                {
                    cmditems.Visible = false;
                   
                    cmdpayment.Visible = false;
                    cmdreceipt.Visible = false;
                    cmdcustomercreate.Visible = false;
                    cmdeditt.Visible = false;
                    cmdsearch.Visible = false;
                    cmdbackup.Visible = false;
                     
                    cmdreportshow.Visible = false;
                    cmdsuppliercreate.Visible = false;
                    cmdemployeecreate.Visible = false;
                    cmdledgercreate.Visible = false;
                    //  cmdlogout.Visible = false;
                    Cmdwholsale.Visible = false;

                    picitems.Visible = false;
                    Picpurchase.Visible = false;
                    picpayment.Visible = false;
                    picreceipt.Visible = false;
                    piccustomer.Visible = false;
                    picedit.Visible = false;
                    picsearch.Visible = false;
                    picbackup.Visible = false;
                    picreport.Visible = false;
                    picsupplier.Visible = false;
                    picemployee.Visible = false;
                    picledger.Visible = false;
                    Picwholesale.Visible = false;

                    if (ClsUserDetails.UserGroupid == "100")
                    {
                         Picpurchase.Visible = false;
                         cmdpurchase.Visible = false;
                        cmdsales.Visible = true;
                    }
                    if (ClsUserDetails.UserGroupid == "101")
                    {
                        cmdsales.Visible = true;
                        cmdpurchase.Visible = true;
                        picsales.Visible = true;
                         Picpurchase.Visible = true;
                    }


                }
                //else
                //{

                if (ClsUserDetails.UserGroupid == "0")
                {

                    cmditems.Visible = true;
                    cmdpurchase.Visible = true;
                    cmdpayment.Visible = true;
                    cmdreceipt.Visible = true;
                    cmdcustomercreate.Visible = true;
                    cmdeditt.Visible = true;
                    //  cmdsearch.Visible = true;
                    cmdbackup.Visible = true;
                    // cmdsales.Visible = false;
                    cmdreportshow.Visible = true;
                    cmdsuppliercreate.Visible = true;
                    cmdemployeecreate.Visible = true;
                    cmdledgercreate.Visible = true;
                    //  cmdlogout.Visible = false;
                    Cmdwholsale.Visible = true;

                    picitems.Visible = true;
                    Picpurchase.Visible = true;
                    picpayment.Visible = true;
                    picreceipt.Visible = true;
                    piccustomer.Visible = true;
                    picedit.Visible = true;
                    // picsearch.Visible = true;
                    picbackup.Visible = true;
                    picreport.Visible = true;
                    picsupplier.Visible = true;
                    picemployee.Visible = true;
                    picledger.Visible = true;
                    Picwholesale.Visible = true;
                }
                //}

                Picwholesale.Visible = false;
                Cmdwholsale.Visible = false;
               string tailor="";
                tailor=CommonClass._Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='302011'").ToString();
                if (tailor == "1")
                {
                    pictureBox1.Visible = true;
                    button1.Visible = true;
                }
                else
                {

                    pictureBox1.Visible = false;
                    button1.Visible = false;
                }


            }
            catch
            {
            }
        }
        private void Picwholesale_Click_1(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnusaleswholesale.PerformClick(); 
        }
      

        private void picsearch_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnuitemsearchquick.PerformClick();  
        }

        private void Cmdwholsale_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnusaleswholesale.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).simpleItemToolStripMenuItem.PerformClick();
        }

        private void cmdledgercreate_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnuledgercreate.PerformClick();
        }

        private void cmdemployeecreate_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnuemployeecreate.PerformClick();
        }

        private void cmdsuppliercreate_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnusuppliercreate.PerformClick();
        }

        private void cmdsearch_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnuitemsearchquick.PerformClick();  
        }

        private void cmdservice_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnuservices.PerformClick();
        }

        private void PNl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnldemo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picbxservices_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnuservices.PerformClick(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).taillorDetailsToolStripMenuItem.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).taillorDetailsToolStripMenuItem.PerformClick(); 
        }

        private void cmdphysical_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnuphysicalstock.PerformClick();
        }

    }
}
