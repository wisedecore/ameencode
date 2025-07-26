using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using Microsoft.Win32;
//using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
namespace WindowsFormsApplication2
{
    public class Generalfunction
    {
        ClsReports _SeleReport = new ClsReports();
       // DBTask _Dbtask = new DBTask();
        /*For Sizes Forms*/
        string Temp;
        public string MsgBxValue = "Zunico";
        public static int vnoint = 0;
        public static int slno = 0;
        public static bool lngnum = false;
        public static bool Newformsales;
        public static bool BlnLogin;
        public static int MdiHieght;
        public static int Mdiwidth;
        public int oldprnt = 0;
        public static int EditFun;
        public static DataGridView Dtgrid;
        public static int BindingRow;
        public static bool IsSize;
        public  DataTable dtt;
        public static string OpCompany;
        /**********************************/
        public static string ActiveForm;
        /***********************************/
      
        DateTime FyearFrom;
        DBTask _dbtask = new DBTask();
        public static string DB_Name = "";
        public static string Server_Name = "";
        public static DataTable dt;
        public DateTimePicker Dt;
        public static DBTask objtsk = new DBTask();
        public static string frmula_status = "";
        public static string frmula_stage = "";

        public static string reporttitle = "";
        public static string defaultcurcode;

        public static string sql = "";
        public static DataSet ds;
        public static string Comeform;
        public static bool Check;
        public static string TempCompanyname = "";
        public static string dateformat = "dd/MMM/yyyy";
        public static bool BlShowEst=true;
        public Control Frm;
        public Control Txt;

        /*For CRM USE*/
        public static string lblChange;
        public static string combselect;
        /*For Sizes*/
        public static int InvoiceColumn;
        DataSet Ds;

        RegistryKey regKey = Registry.CurrentUser;
        //----------------------
        /*Static Settings*/
        public static string StockDeci;
        public static string CurreDeci;
        public static bool EMRate;
        public static bool EMunit;
        public static bool EDepot;
        public static bool ETax;
        public static bool ESalesestimation;
        public static bool ESalesreturn;
        public static bool EPurchasereturn;
        public static bool ECRM;
        public static bool EWmachine;
        public static bool EPharmacy;
        public static bool openy;

        public static void setcolor(ToolStrip tsp)
        {
            tsp.BackColor = Color.SlateGray;

        }
        public bool chkother()
        {
            FormCollection fc = Application.OpenForms;
            int ss = 0;
            for (int i = 0; i < fc.Count;i++ )
            {
                Form frm =fc[i];
                if (frm.Name == "frmsalesinvoice")
                {
                    ss = ss + 1;
                }
            }

            if (ss > 1)
            {
             return  openy = true;
            }
            else
            {
             return   openy = false;
            }
        }
        public void chksaleshold()
        {
            FormCollection fc = Application.OpenForms;
            int sh = fc.Count; int hold = 0;
            if (sh>0)
            {
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmsalesinvoice")
                {
                    hold = hold + 1;
                }
                
            }
                if(hold>1)
                {
                    FrmHoldpopup.numbttn = hold;
                    FrmHoldpopup.holdnum = hold.ToString() + "  sales bill holding";
                    FrmHoldpopup _form = new FrmHoldpopup();
                    _form.ShowDialog();
                }
            }

        }
        public bool splcharacter(string word)
        {
            string spl = @"\|!#$%&/()+?><@*{}[];.-,~=";
            foreach(var item in spl)
            {
                if (word.Contains(item.ToString())) return true;
            }
            return false;
        }


        //public void MaxforSettAll(Form Frm)
        //{
        //    // Frm.Size = new System.Drawing.Size(this.Width - 40, this.Size.Height - 130 - toolStrip.Height);
        //    Frm.Location = new Point(0, 0);
        //    Frm.Size =,975);

        //    // Frm.Size = new System.Drawing.Size(
        //}

        public void FillActivePrinter(ComboBox Combo)
            {
            try
            {
                Combo.Items.Clear();
               
                foreach (string printname in PrinterSettings.InstalledPrinters)
                {
                    Combo.Items.Add(printname);
                }
                //CommonClass.temp = CommonClass._Paramlist.GetParamvalue("SPrintSelect");
               //if (FrmbarcodePrinting.prnt == false)
               // {
               //     CommonClass.temp = CommonClass._Dbtask.GetPrinterName();
               // } 
                
                if(FrmbarcodePrinting.prnt == true)
                {
                    
                    CommonClass.temp = CommonClass._Dbtask.GetPrinterNamebcode();
                }
                else if (Frmpurchase.Purprint == true)
                {
                    CommonClass.temp = CommonClass._Dbtask.GetPrinterPurchase();
                }
                else
                {
                    if (FrmbarcodePrinting.prnt == false && Frmpurchase.Purprint ==false)
                    {
                        CommonClass.temp = CommonClass._Dbtask.GetPrinterName();
                    }
                }

                
                if (CommonClass.temp != "")
                    Combo.Text = CommonClass.temp;
                else
                    Combo.SelectedIndex = 0;

             //string defaultPrinterName = settings.PrinterName;

            }
            catch
            {
            }
        }

        public static string GetKSAEncriptedText(string BranchName, string VATNO, DateTime InvDate, decimal NetTotal, decimal VatTotal)
        {
            //string rt = Convert.ToString(Convert.ToChar(1)) + Convert.ToString(Convert.ToChar(BranchName.Length)) + BranchName +
            //    Convert.ToString(Convert.ToChar(2)) + Convert.ToString(Convert.ToChar(VATNO.Length)) + VATNO + Convert.ToString(Convert.ToChar(3)) + Convert.ToString(Convert.ToChar(InvDate.ToString("yyyy-MM-dd HH:mm:ss").Length)) +

            //    InvDate.ToString("yyyy-MM-dd HH:mm:ss") + Convert.ToString(Convert.ToChar(4)) + Convert.ToString(Convert.ToChar(NetTotal.ToString("N2").Length)) +
            //     NetTotal.ToString("N2") + Convert.ToString(Convert.ToChar(5)) + Convert.ToString(Convert.ToChar(VatTotal.ToString("N2").Length)) + VatTotal.ToString("N2")
            //    ;


            //return Base64Encode(rt);
            
            KSATLV tlv = new KSATLV(BranchName, VATNO, InvDate.ToString("yyyy-MM-dd") + "T" + InvDate.ToString("HH:mm:ss") + "Z", NetTotal.ToString("N2"), VatTotal.ToString("N2"));
            return tlv.ToBase64();
        }

        public class KSATLV
        {
            byte[] BranchName;
            byte[] VatNo;
            byte[] InvDate;
            byte[] Total;
            byte[] Tax;

            public KSATLV(String BranchName, String TaxNo, String dateTime, String Total, String Tax)
            {
                this.BranchName = Encoding.UTF8.GetBytes(BranchName);
                this.VatNo = Encoding.UTF8.GetBytes(TaxNo);

                this.InvDate = Encoding.UTF8.GetBytes(dateTime);
                this.Total = Encoding.UTF8.GetBytes(Total);
                this.Tax = Encoding.UTF8.GetBytes(Tax);
            }
            private byte[] getBytes(int id, byte[] Value)
            {
                byte[] val = new byte[2 + Value.Length];
                val[0] = (byte)id;
                val[1] = (byte)Value.Length;
                Value.CopyTo(val, 2);
                return val;
            }





            public String ToBase64()
            {
                List<byte> TLV_Bytes = new List<byte>();
                TLV_Bytes.AddRange(getBytes(1, this.BranchName));
                TLV_Bytes.AddRange(getBytes(2, this.VatNo));
                TLV_Bytes.AddRange(getBytes(3, this.InvDate));
                TLV_Bytes.AddRange(getBytes(4, this.Total));
                TLV_Bytes.AddRange(getBytes(5, this.Tax));
                return Convert.ToBase64String(TLV_Bytes.ToArray());
            }
        }
        public string FuReturnArabic(string PName)
        {
            if (PName == "Cus Name")
            {
                return "اسم العميل";
            }
            else if (PName == "Vat Cus")
            {
                return "رقم الضريبي العميل";
            }
            else if (PName == "Address")
            {
                return "العنوان";
            }
            else if (PName == "Phone")
            {
                return "الهاتف";
            }
            else if (PName == "Mobile")
            {
                return "جوال";
            }

            else if (PName == "Slno")
            {
                return "رقم";
            }
            else if (PName == "Item Code")
            {
                return "رمز الصنف";
            }
            else if (PName == "Item Name")
            {
                return "الوصف";
            }
            else if (PName == "Qty")
            {
                return "الكمية";
            }
            else if (PName == "Unit")
            {
                return "الوحدة";
            }
            if (PName == "Unit Rate")
            {
                return "سعر الوحدة";
            }
            else if (PName == "Gross")
            {
                return "الـمجموع";
            }
            else if (PName == "Tax 15%")
            {
                return "ضريبة٪١٥";
            }
            else if (PName == "Amount")
            {
                return "مقدار";
            }


            else if (PName == "Discount")
            {
                return "مجموع الخصومات";
            }
            if (PName == "Excl Vat")
            {
                return "   من   ألإجمالي غير الضريبة";
            }
            else if (PName == "Total Vat")
            {
                return "مجموع ضريبةالقيمة المضافة";
            }
            else if (PName == "Amount Total")
            {
                return "إجمالي المبلغ المستحق";
            }
            else if (PName == "Amount in words")
            {
                return "الـمبلغ الإجمالي";
            }
            else if (PName == "Excl Vat")
            {
                return "من";
            }
            else if (PName == "Supplier")
            {
                return "المورد";
            }


            return "";
        }


        public bool dataintable(string param, string tablewhere)
        {
            DataSet dd; DataSet dIn;
            string vtype = "";
            string Accnt = "";
            if (tablewhere == "MaxofSI" || tablewhere == "MaxofSIwh" || tablewhere == "MaxofSO" || tablewhere == "MaxofDN" || tablewhere == "MaxofSQ")
            {

                if (tablewhere == "MaxofSI")
                {
                    vtype = "SI";
                    Accnt = "and ledcode ='2'";
                }
                if (tablewhere == "MaxofSIwh")
                {
                    vtype = "SI";
                    Accnt = "and ledcode !='2'";
                }
                if (tablewhere == "MaxofSO")
                {
                    vtype = "SO";
                    Accnt = "and ledcode ='2'";
                }
                if (tablewhere == "MaxofDN")
                {
                    vtype = "DN";
                    Accnt = "and ledcode ='2'";
                }
                if (tablewhere == "MaxofSQ")
                {
                    vtype = "SQ";
                    Accnt = "and ledcode ='2'";
                }
                dd = _dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + param + "'  and vtype ='" + vtype + "'" + Accnt);
                if (dd.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                dIn = _dbtask.ExecuteQuery("select * from tblinventory where vcode='" + param + "'  and vtype ='" + vtype + "'");
                if (dIn.Tables[0].Rows.Count > 0)
                {
                    return true;
                }


            }

            if (tablewhere == "MaxofSR")
            {

                vtype = "SR";
                Accnt = "and ledcode ='2'";

                dd = _dbtask.ExecuteQuery("select * from tblRECEIPTDETAILS where RECPTCODE='" + param + "'  and vtype ='" + vtype + "'" + Accnt);
                if (dd.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                dIn = _dbtask.ExecuteQuery("select * from tblinventory where vcode='" + param + "'  and vtype ='" + vtype + "'");
                if (dIn.Tables[0].Rows.Count > 0)
                {
                    return true;
                }

            }

            if (tablewhere == "MaxofPI" || tablewhere == "MaxofPO" || tablewhere == "MaxofDNR")
            {
                if (tablewhere == "MaxofPI")
                {
                    vtype = "PI";
                    Accnt = "and ledcode ='3'";
                }
                if (tablewhere == "MaxofPO")
                {
                    vtype = "PO";
                    Accnt = "and ledcode ='3'";
                }
                if (tablewhere == "MaxofDNR")
                {
                    vtype = "DNR";
                    Accnt = "and ledcode ='3'";
                }


                dd = _dbtask.ExecuteQuery("select * from tblRECEIPTDETAILS where RECPTCODE='" + param + "'  and vtype ='" + vtype + "'" + Accnt);
                if (dd.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                dIn = _dbtask.ExecuteQuery("select * from tblinventory where vcode='" + param + "'  and vtype ='" + vtype + "'");
                if (dIn.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
            }

            if (tablewhere == "MaxofPR")
            {
                vtype = "PR";
                Accnt = "and ledcode ='3'";
                dd = _dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + param + "'  and vtype ='" + vtype + "'" + Accnt);
                if (dd.Tables[0].Rows.Count > 0)
                {
                    return true;
                }


                dIn = _dbtask.ExecuteQuery("select * from tblinventory where vcode='" + param + "'  and vtype ='" + vtype + "'");
                if (dIn.Tables[0].Rows.Count > 0)
                {
                    return true;
                }

            }

            return false;

        }

        public bool dataintableAzure(string param, string tablewhere)
        {
            DataSet dd; DataSet dIn;
            string vtype = "";
            string Accnt = "";
            if (tablewhere == "MaxofSI" || tablewhere == "MaxofSIwh" || tablewhere == "MaxofSO" || tablewhere == "MaxofDN" || tablewhere == "MaxofSQ")
            {

                if (tablewhere == "MaxofSI")
                {
                    vtype = "SI";
                    Accnt = "and ledcode ='2'";
                }
                if (tablewhere == "MaxofSIwh")
                {
                    vtype = "SI";
                    Accnt = "and ledcode !='2'";
                }
                if (tablewhere == "MaxofSO")
                {
                    vtype = "SO";
                    Accnt = "and ledcode ='2'";
                }
                if (tablewhere == "MaxofDN")
                {
                    vtype = "DN";
                    Accnt = "and ledcode ='2'";
                }
                if (tablewhere == "MaxofSQ")
                {
                    vtype = "SQ";
                    Accnt = "and ledcode ='2'";
                }
                dd = _dbtask.ExecuteQueryAzureServer("select * from tblissuedetails where issuecode='" + param + "'  and vtype ='" + vtype + "'" + Accnt);
                if (dd.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                dIn = _dbtask.ExecuteQueryAzureServer("select * from tblinventory where vcode='" + param + "'  and vtype ='" + vtype + "'");
                if (dIn.Tables[0].Rows.Count > 0)
                {
                    return true;
                }


            }

            if (tablewhere == "MaxofSR")
            {

                vtype = "SR";
                Accnt = "and ledcode ='2'";

                dd = _dbtask.ExecuteQueryAzureServer("select * from tblRECEIPTDETAILS where RECPTCODE='" + param + "'  and vtype ='" + vtype + "'" + Accnt);
                if (dd.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                dIn = _dbtask.ExecuteQueryAzureServer("select * from tblinventory where vcode='" + param + "'  and vtype ='" + vtype + "'");
                if (dIn.Tables[0].Rows.Count > 0)
                {
                    return true;
                }

            }

            if (tablewhere == "MaxofPI" || tablewhere == "MaxofPO" || tablewhere == "MaxofDNR")
            {
                if (tablewhere == "MaxofPI")
                {
                    vtype = "PI";
                    Accnt = "and ledcode ='3'";
                }
                if (tablewhere == "MaxofPO")
                {
                    vtype = "PO";
                    Accnt = "and ledcode ='3'";
                }
                if (tablewhere == "MaxofDNR")
                {
                    vtype = "DNR";
                    Accnt = "and ledcode ='3'";
                }


                dd = _dbtask.ExecuteQueryAzureServer("select * from tblRECEIPTDETAILS where RECPTCODE='" + param + "'  and vtype ='" + vtype + "'" + Accnt);
                if (dd.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                dIn = _dbtask.ExecuteQueryAzureServer("select * from tblinventory where vcode='" + param + "'  and vtype ='" + vtype + "'");
                if (dIn.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
            }

            if (tablewhere == "MaxofPR")
            {
                vtype = "PR";
                Accnt = "and ledcode ='3'";
                dd = _dbtask.ExecuteQueryAzureServer("select * from tblissuedetails where issuecode='" + param + "'  and vtype ='" + vtype + "'" + Accnt);
                if (dd.Tables[0].Rows.Count > 0)
                {
                    return true;
                }


                dIn = _dbtask.ExecuteQueryAzureServer("select * from tblinventory where vcode='" + param + "'  and vtype ='" + vtype + "'");
                if (dIn.Tables[0].Rows.Count > 0)
                {
                    return true;
                }

            }

            return false;

        }

        public void checkmaxtableandparamvalAzure(string param, string tablewhere)
        {
            string maxtbl = ""; double val = 0;
            //si
            if (tablewhere.ToLower() == "maxofsi")
            {


                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalarAzureServer("select max( cast ( vno as int))+1 from tblbusinessissue where issuetype='SI'"));

                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintableAzure(param, tablewhere) == true)
                {
                    if (maxtbl != param)
                    {

                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param)));

                        }
                
                    }
                    else
                    {
                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param)));

                        }
                    }


                }
            }

            //whole
            if (tablewhere.ToLower() == "maxofsiwh")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalarAzureServer("select max( cast ( vno as int))+1 from tblbusinessissue where issuetype='SI' and ledcodecr not in('2','3')"));


                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintableAzure(param, tablewhere) == true)
                {
                    if (maxtbl != param)
                    {

                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param)));

                        }

                      
                    }
                    else
                    {
                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param)));

                        }
                    }

                }

            }

            //so

            if (tablewhere.ToLower() == "maxofso")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalarAzureServer("select max( cast ( vno as int))+1 from tblbusinessissue where issuetype='SO'"));

                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintableAzure(param, tablewhere) == true)
                {

                    if (maxtbl != param)
                    {

                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param)));

                        }

                      
                    }
                    else
                    {
                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param)));

                        }
                    }

                }

            }

            //SQ

            if (tablewhere.ToLower() == "maxofsq")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalarAzureServer("select max( cast ( vno as int))+1 from tblbusinessissue where issuetype='SQ'"));

                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintableAzure(param, tablewhere) == true)
                {

                    if (maxtbl != param)
                    {

                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param)));

                        }

                  
                    }
                    else
                    {
                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param)));

                        }
                    }

                }


            }

            //SR
            if (tablewhere.ToLower() == "maxofsr")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalarAzureServer("select max( cast ( Reptcode as int))+1 from tbltransactionreceipt where Recpttype='SR'"));
                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintableAzure(param, tablewhere) == true)
                {


                    if (maxtbl != param)
                    {
                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param)));

                        }

                        
                    }
                    else
                    {
                            if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                    }

                }

            }


            //pi

            if (tablewhere.ToLower() == "maxofpi")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalarAzureServer("select max( cast ( Reptcode as int))+1 from tbltransactionreceipt where Recpttype='PI'"));

                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintableAzure(param, tablewhere) == true)
                {


                    if (maxtbl != param)
                    {

                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                  
                    }
                    else
                    {

                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                    
                    }


                }


            }

            //PR
            if (tablewhere.ToLower() == "maxofpr")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalarAzureServer("select max( cast ( vno as int))+1 from tblBUSINESSISSUE where issuetype='PR'"));

                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintableAzure(param, tablewhere) == true)
                {


                    if (maxtbl != param)
                    {

                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                       
                    }
                    else
                    {
                        if (dataintableAzure(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNOAzure(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                    }

                }

            }


        }
        public void checkmaxtableandparamval(string param, string tablewhere)
        {
            string maxtbl = ""; double val = 0;
 //si
            if (tablewhere.ToLower()=="maxofsi")
            {

               
            maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalar("select max( cast ( vno as int))+1 from tblbusinessissue where issuetype='SI'"));

            if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintable(param, tablewhere) == true)
            {
                if (maxtbl != param)
                {

                    if (dataintable(param, tablewhere) == true)
                    {
                        CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param)));

                    }
                    //if (_dbtask.znlldoubletoobject(param) == (_dbtask.znlldoubletoobject(maxtbl) - 1))
                    //{
                    //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;

                    //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                    //}
                    //else
                    //{
                    //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                    //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                    //}
                }
                else
                {
                    if (dataintable(param, tablewhere) == true)
                    {
                        CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param)));

                    }
                }


            }
            }

//whole
            if (tablewhere.ToLower() == "maxofsiwh")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalar("select max( cast ( vno as int))+1 from tblbusinessissue where issuetype='SI' and ledcodecr not in('2','3')"));


                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintable(param, tablewhere) == true)
                {
                    if (maxtbl != param)
                    {

                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param)));

                        }

                        //if (_dbtask.znlldoubletoobject(param) == (_dbtask.znlldoubletoobject(maxtbl) - 1))
                        //{

                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;


                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                        //else
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                    }
                    else
                    {
                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param)));

                        }
                    }

                }

            }

//so

            if (tablewhere.ToLower() == "maxofso")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalar("select max( cast ( vno as int))+1 from tblbusinessissue where issuetype='SO'"));

                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintable(param, tablewhere) == true)
                {

                    if (maxtbl != param)
                    {

                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param)));

                        }

                        //if (_dbtask.znlldoubletoobject(param) == (_dbtask.znlldoubletoobject(maxtbl) - 1))
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                        //else
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                    }
                    else
                    {
                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param)));

                        }
                    }

                }

            }

//SQ

            if (tablewhere.ToLower() == "maxofsq")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalar("select max( cast ( vno as int))+1 from tblbusinessissue where issuetype='SQ'"));

                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintable(param, tablewhere) == true)
                {

                    if (maxtbl != param)
                    {

                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param)));

                        }

                        //if (_dbtask.znlldoubletoobject(param) == (_dbtask.znlldoubletoobject(maxtbl) - 1))
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                        //else
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                    }
                    else
                    {
                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param)));

                        }
                    }

                }


            }

//SR
            if (tablewhere.ToLower() == "maxofsr")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalar("select max( cast ( Reptcode as int))+1 from tbltransactionreceipt where Recpttype='SR'"));
                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintable(param, tablewhere) == true)
                {


                    if (maxtbl != param)
                    {
                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param)));

                        }

                        //if (_dbtask.znlldoubletoobject(param) == (_dbtask.znlldoubletoobject(maxtbl) - 1))
                        //{

                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                        //else
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                    }
                    else
                    {
                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                    }

                }

            }


//pi

            if (tablewhere.ToLower() == "maxofpi")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalar("select max( cast ( Reptcode as int))+1 from tbltransactionreceipt where Recpttype='PI'"));

                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintable(param, tablewhere) == true)
                {


                    if (maxtbl != param)
                    {

                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                        //if (_dbtask.znlldoubletoobject(param) == (_dbtask.znlldoubletoobject(maxtbl) - 1))
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                        //else
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                    }
                    else
                    {

                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                        //if (dataintable(param, tablewhere) == true)
                        //{
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param) + 1));
                        //}
                    }


                }


            }

//PR
            if (tablewhere.ToLower() == "maxofpr")
            {
                maxtbl = CommonClass._Dbtask.znllString(_dbtask.ExecuteScalar("select max( cast ( vno as int))+1 from tblBUSINESSISSUE where issuetype='PR'"));

                if (_dbtask.znlldoubletoobject(maxtbl) > 0 && dataintable(param, tablewhere) == true)
                {


                    if (maxtbl != param)
                    {

                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                        //if (_dbtask.znlldoubletoobject(param) == (_dbtask.znlldoubletoobject(maxtbl) - 1))
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                        //else
                        //{
                        //    val = _dbtask.znlldoubletoobject(maxtbl) - 1;
                        //    CommonClass._Paramlist.updateparamvalueVNO(tablewhere, Convert.ToInt32(val));

                        //}
                    }
                    else
                    {
                        if (dataintable(param, tablewhere) == true)
                        {
                            CommonClass._Paramlist.updateparamvalueVNO(tablewhere, (Convert.ToInt32(param) + 1));
                        }
                    }

                }

            }


        }


        public static string Base64Encode(string text)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public string FureturnQrValue(string PSllersname,string PVatno,string PBillNo,DateTime PBillDate,string PTaxAmount,string PBillamount)
        {
            string Ptxt;
            Ptxt = "Seller's Name=" + PSllersname + "\n";
            Ptxt = Ptxt + "VAT NO=" + PVatno + "\nBill No=" + PBillNo + "\nDate=" + PBillDate.ToString("dd/MM/yyyy") + "\nTime=" + PBillDate.ToString("hh:mm:ss") + "\nVAT Amount=" + PTaxAmount + "\nTotal Amount=" + PBillamount;
            if (CommonClass._settings.ReturnStatusBoolenvalue("180") == true)
            {
                Ptxt = Generalfunction.GetKSAEncriptedText(PSllersname, PVatno, PBillDate, Convert.ToDecimal(CommonClass._Dbtask.znullDouble(PBillamount)), Convert.ToDecimal(CommonClass._Dbtask.znullDouble(PTaxAmount)));
            }
            return Ptxt;
        }

        public void FunotificationTRNandVat()
        {
            if(CommonClass._compMaster.GetspecifField("TRN")==""||CommonClass._compMaster.GetspecifField("sellersname")=="")
            {
               MessageBox.Show("Enter Tax Details", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Error);
               FrmCreateCompany _CompanyProf = new FrmCreateCompany();
               _CompanyProf.ShowDialog();
            }
        }

        public void SlSetfunction(DataGridView Grid, string Columnname)
        {
            for (int i = 0; i < Grid.Rows.Count - 1; i++)
            {
                Grid.Rows[i].Cells[Columnname].Value = i + 1;
            }
        }
        public static void ShowMessage(string Text)
        {
            MessageBox.Show(Text, NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GetFilelocation()
        {
            return Application.StartupPath;
        }
        public static void FillCombo(ComboBox Cmb, string DisplayMember, string ValueMember, string TableName, string ZeroMember, string Where)
        {
            string Sql = "Select 0 As " + ValueMember + ",'" + ZeroMember + "' As " + DisplayMember + " Union All Select  " + ValueMember + ", " + DisplayMember + " From " + TableName + " " + Where + " Order By " + DisplayMember + " Asc";
            DataSet DS = CommonClass._Dbtask.ExecuteQuery(Sql);
            Cmb.DisplayMember = DisplayMember;
            Cmb.ValueMember = ValueMember;
            Cmb.DataSource = DS.Tables[0];

            Cmb.SelectedValue = 0;
        }
        public static void ChangeGridSelection(DataGridView Grid, int KeyValue)
        {
            if (Grid.SelectedRows.Count > 0)
            {
                int Index = Grid.SelectedRows[0].Index;
                if (KeyValue == 40)
                {
                    if (Index < Grid.Rows.Count - 1)
                    {
                        Grid.Rows[Index + 1].Selected = true;
                        Grid.Rows[Index].Selected = false;
                        Grid.CurrentCell = Grid.SelectedRows[0].Cells[0];
                    }
                }
                else if (KeyValue == 38)
                {
                    if (Index > 0)
                    {
                        Grid.Rows[Index - 1].Selected = true;
                        Grid.Rows[Index].Selected = false;
                        Grid.CurrentCell = Grid.SelectedRows[0].Cells[0];
                    }
                }
            }
        }
        public DateTime FuFromdateReportdef()
        {
            if (DateTime.Now.Hour < 5)
            {
                DateTime DT;
                DT = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 05:00:00"));
                DT = DT.AddDays(-1);
                return DT;
            }
            else
            {
                return Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 05:00:00"));
            }
        }

        public DateTime FuTodateReportdef()
        {
             DateTime DT;
             if (DateTime.Now.Hour < 5)
             {
                 DT = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 02:00:00"));
             }
             else
             {

                 DT = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 02:00:00"));
                 DT = DT.AddDays(1);
             }
            return DT;
        }
        public void ExportToWieghtMechine()
        {
           
           // ds = _SeleReport.StockListBaseonBarcode("", "srate", true);
           // String RowcCount = "";
           // string Startuppath = Application.StartupPath + "/";           
           // StringBuilder sb = new StringBuilder();
           // string columnsHeader = "";
           // for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
           // {
           //     columnsHeader += ds.Tables[0].Columns[i] + ",";
           // }
           // sb.Append(columnsHeader + Environment.NewLine);
           // DataGridView Dtgrid=new DataGridView();
           // Dtgrid.DataSource = ds.Tables[0];
           // foreach (DataGridViewRow dgvRow in Dtgrid.Rows)
           // {
           //     // Make sure it's not an empty row.
           //     if (!dgvRow.IsNewRow)
           //     {
           //         for (int c = 0; c < dgvRow.Cells.Count; c++)
           //         {
           //             // Append the cells data followed by a comma to delimit.

           //             sb.Append(dgvRow.Cells[c].Value + ",");
           //         }
           //         // Add a new line in the text file.
           //         sb.Append(Environment.NewLine);
           //     }
           // }
           // // Load up the save file dialog with the default option as saving as a .csv file.
           // //SaveFileDialog sfd = new SaveFileDialog();
           // //sfd.Filter = "CSV files (*.csv)|*.csv";
           // //if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           // //{
           //     // If they've selected a save location...
           // string Destinationpath = Startuppath + "ZATWmachine.csv";
           //     using (StreamWriter Streamwrite = File.CreateText(Destinationpath))
           //     {
           //         for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
           //         {
           //             RowcCount = "";
           //             for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
           //             {
           //                 if (RowcCount.Length > 0)
           //                 {
           //                     RowcCount = RowcCount + "," +CommonClass._Dbtask.znllString(ds.Tables[0].Rows[i][j].ToString());
           //                 }
           //                 else
           //                 {
           //                     RowcCount = CommonClass._Dbtask.znllString(ds.Tables[0].Rows[i][j].ToString());
           //                 }
           //             }

           //             Streamwrite.WriteLine(RowcCount);
           //         }
           //         //sw.WriteLine(sb.ToString());
           //     }
           // //}
           // // Confirm to the user it has been completed.
           //// MessageBox.Show("CSV file saved.");   
            
           // //ds = _SeleReport.StockListBaseonBarcode("", "srate", true);
           //     //String RowcCount = "";
           //     //string Startuppath = Application.StartupPath + "/";
           //     //string ColumnName;
               
           //     //string Destinationpath = Startuppath + "ZATWMACHINE.txt";
           //     //using (StreamWriter Streamwrite = File.CreateText(Destinationpath))
           //     //{
           //     //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
           //     //    {
           //     //        RowcCount = "";
           //     //        for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
           //     //        {
           //     //                if (RowcCount.Length > 0)
           //     //                {
           //     //                    RowcCount = RowcCount + "," + _Dbtask.znllString(ds.Tables[0].Rows[i][j].ToString());
           //     //                }
           //     //                else
           //     //                {
           //     //                    RowcCount = _Dbtask.znllString(ds.Tables[0].Rows[i][j].ToString());
           //     //                }
           //     //         }
                        
           //     //        Streamwrite.WriteLine(RowcCount);
           //     //    }
           //     //    Streamwrite.WriteLine(Streamwrite.NewLine);
           //     //    Streamwrite.Close();
           //     //}
        }

        public string returnmaxvnonumber(string table,string vtype)
        {
            string maxBill = "";
            string retbill = "";
            if (vtype == "PO" || vtype == "PI" || vtype == "SR")
            {
                maxBill =CommonClass._Dbtask.znllString( CommonClass._Dbtask.ExecuteScalar("SELECT isnull(max(cast( vno as int)),0)+1     " +
            " FROM   " + table + " where recpttype='" + vtype + "' "));
            }

            if (vtype == "SO" || vtype == "DN" || vtype == "SQ" )
            {
                maxBill = CommonClass._Dbtask.znllString( CommonClass._Dbtask.ExecuteScalar("SELECT isnull(max(cast( vno as int)),0)+1     " +
                " FROM   " + table + " where Issuetype='" + vtype + "' "));
            }

            retbill =CommonClass._Dbtask.znllString( CommonClass._Dbtask.znlldoubletoobject(maxBill) - 1 );
            return retbill;

        }




        public void StartUpWindow()
        {
            try
            {
                /************Remainder*************/
                DateTime DtNow = DateTime.Now;
                Ds = CommonClass._Remainder.ShowRemainder(" where rdate between '" + DtNow.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DtNow.ToString("MM/dd/yyyy") + " 23:59:59'");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    Frmremainder _Remainder = new Frmremainder();
                    _Remainder.Rid = Convert.ToInt64(Ds.Tables[0].Rows[0]["rid"]);
                    _Remainder.Fillform = true;
                    _Remainder.ShowDialog();
                }
                //00:00:00'  and '11-05-2015 23:59:59'



                /*****************Balance**********/
                if (CommonClass._Menusettings.GetMnustatus("159") == "1")
                {
                    Clsselectreport.RType = "OutstandingReport";
                    Clsselectreport.RQuery = " having IMS.ItemId in(select itemid from tblitemmaster ) and  IMS.Itemclass in ('Stock Item','Services','Finished Product','')     AND SUM(INV.Os+INV.purchase+INV.Mr+INV.Sr+INV.Ireceipt+INV.bmr+INV.freepre)-SUM(INV.sales+INV.dn+INV.pr+INV.iissue+INV.sh+INV.dmg+INV.bmi+INV.freeiss )  <=0   and  inv.dcode in(0) ";
                    CommonClass._SelectReport.DbTemp = CommonClass._Dbtask.znullDouble(CommonClass._Paramlist.GetParamvalue("Strbalance"));
                    FrmReport _report = new FrmReport();
                    _report.ReportType = Clsselectreport.RType;
                    _report.Query = Clsselectreport.RQuery;
                    _report.QueryTemp = "select * from tblaccountledger where agroupid in(18) or agroupid in (select agroupid from tblaccountgroup where aunder='18') ";
                    _report.DTFrom = Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
                    _report.DTTo = DateTime.Now;
                    _report.WindowState = FormWindowState.Maximized;
                    _report.ShowDialog();
                }
                /***********Stock******************/
                if (CommonClass._Menusettings.GetMnustatus("158") == "1")
                {
                    Clsselectreport.RType = "Stock Value";
                    Clsselectreport.RQuery = " having IMS.ItemId in(select itemid from tblitemmaster ) and  IMS.Itemclass in ('Stock Item','Services','Finished Product','')     AND SUM(INV.Os+INV.purchase+INV.Mr+INV.Sr+INV.Ireceipt+INV.bmr+INV.freepre)-SUM(INV.sales+INV.dn+INV.pr+INV.iissue+INV.sh+INV.dmg+INV.bmi+INV.freeiss )  <=" + CommonClass._Paramlist.GetParamvalue("Strstock") + "   and  inv.dcode in(0) ";
                    FrmReport.Secondcondition = "Prate";
                    FrmReport _report = new FrmReport();
                    _report.ReportType = Clsselectreport.RType;
                    _report.Query = Clsselectreport.RQuery;
                    _report.WindowState = FormWindowState.Maximized;
                    _report.ShowDialog();
                }
            }
            catch
            {
            }
        }

        public double GetOpeningBalance(string Query,DateTime DTTO)
        {
            //if (Generalfunction.BlShowEst == true)
                Ds = objtsk.ExecuteQuery(Query);
            
            double TDebit = 0;
            double TCredit = 0;

            double DrOB = 0;
            double CrOB = 0;
            string Gid;
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {

                /*21 =Sales Groupid*/
                /*26 =Purchase*/
                /*24 =Bank*/
                /*25 =Cash*/
     
                Gid = objtsk.ExecuteScalar("select agroupid from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcode"] + "'");

                string Vtype = Ds.Tables[0].Rows[i]["vtype"].ToString();
                if (Vtype == "PI" || Vtype == "SI" || Vtype == "DN" || Vtype == "DNR" || Vtype == "SR" || Vtype == "PR")
                {
                    //if (Vtype == "SR")
                    //{
                    //}

                    double Debit = Convert.ToDouble(Ds.Tables[0].Rows[i]["cramt"]);
                    double Credit = Convert.ToDouble(Ds.Tables[0].Rows[i]["dbamt"]);
                    if (Debit > 0)
                    {
                        if (Vtype == "SR" && Ds.Tables[0].Rows[i]["ledcode"].ToString() == "7")
                        {
                        }
                    }
                    else
                    {
                        if (Vtype == "SR" && Ds.Tables[0].Rows[i]["ledcode"].ToString()=="7")
                        {
                        }
                    }
                    if (Gid != "25" && Gid != "24")
                    {

                        TDebit = TDebit + Debit;
                        TCredit = TCredit + Credit;
                    }
                }
                if (Vtype == "P" || Vtype == "R"||Vtype=="JP"||Vtype=="JR")
                {
                    if (Gid != "25")
                    {

                        double Debit = Convert.ToDouble(Ds.Tables[0].Rows[i]["cramt"]);
                        double Credit = Convert.ToDouble(Ds.Tables[0].Rows[i]["dbamt"]);
                        TDebit = TDebit + Debit;
                        TCredit = TCredit + Credit;
                    }
                }
            }
            Gid = CommonClass._SelectReport.Showindataset("select lid from tblaccountledger where agroupid in(25)");
            DrOB = CommonClass._Dbtask.znullDouble(objtsk.ExecuteScalar("select isnull(sum(dbamt),0)  from tblgeneralledger where vtype='OB' and vDate < '"+DTTO.ToString("MM/dd/yyyy 23:59:59")+"' and  ledcode in("+Gid+")"));
            CrOB = CommonClass._Dbtask.znullDouble(objtsk.ExecuteScalar("select isnull(sum(cramt),0)  from tblgeneralledger where vtype='OB' and vDate < '" + DTTO.ToString("MM/dd/yyyy 23:59:59") + "' and  ledcode in(" + Gid + ")"));
            TDebit = TDebit + DrOB;
            TCredit = TCredit + CrOB;
            return TDebit - TCredit;
        }
        public DateTimePicker Dateformate()
        {
                regKey = regKey.CreateSubKey("Software\\Techno");

                string Date = regKey.GetValue("MDate", 0).ToString();
                string Day =Convert.ToString(Date.Substring(0,2));
                string Month = Convert.ToString(Date.Substring(2, 2));
                string Year = Convert.ToString(Date.Substring(6, 4));
                // DateTime Dttemp = Convert.ToDateTime(Date);
                DateTime Dn = Convert.ToDateTime(DateTime.Now);
                Dt.Value =Convert.ToDateTime(Dn.ToString());
               //Convert.ToDateTime(Ds2.Tables[0].Rows[0]["issuedate"]
               // Dt.Value = new DateTime(2014, 06, 05);
                Dt.Format = DateTimePickerFormat.Custom;
                Dt.CustomFormat = "dd MMM yyyy";

                return Dt;

                
             
        }

        public string ReadWaranty()
        {
            if (!File.Exists(Application.StartupPath + "\\Waranty.ini"))
            {
                File.Create((Application.StartupPath + "\\Waranty.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\Waranty.ini"), "");
            }
            Temp = System.IO.File.ReadAllText(Application.StartupPath + "\\Waranty.ini");
           
            return Temp; 
        }

        public static bool fillDatainCombowithQuery(ComboBox cmbControl, string ValueFieldName, string DisplayFieldName, string tablename, string qry)
        {
            try
            {
                DataSet ds = new DataSet();
                //string qry = "";
                DBTask theDBTask = new DBTask();

                ds = theDBTask.ExecuteQuery(qry);
                cmbControl.DisplayMember = DisplayFieldName;
                cmbControl.ValueMember = ValueFieldName;
                cmbControl.DataSource = ds.Tables[0];
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public static string BatchEnamble = "0";

        public static string getnextid(string strfiled, string tble)
        {

            string str = "SELECT isnull(max(cast("+strfiled+" as int)),0)+1     AS Expr1 " +
                 " FROM         " + tble + "";

            return objtsk.ExecuteScalar(str);

        }
        public static string getnextidAzure(string strfiled, string tble)
        {

            string str = "SELECT isnull(max(cast(" + strfiled + " as int)),0)+1     AS Expr1 " +
                 " FROM         " + tble + "";

            return objtsk.ExecuteScalarAzureServer(str);

        }

        public static string getnextidCondition(string strfiled, string tble,string where)
        {
            string str = "SELECT     { fn IFNULL(MAX(" + strfiled + "), 0) } + 1 AS Expr1 " +
                 " FROM         " + tble +  "  " + where+" ";

            return objtsk.ExecuteScalar(str);

        }

        public static string getnextidConditionAzure(string strfiled, string tble, string where)
        {
            string str = "SELECT     { fn IFNULL(MAX(" + strfiled + "), 0) } + 1 AS Expr1 " +
                 " FROM         " + tble + "  " + where + " ";

            return objtsk.ExecuteScalarAzureServer(str);

        }

        public static string getnextidConditionforgeneralledger(string strfiled, string tble, string where)
        {

            string str = "SELECT     isnull(max(cast("+strfiled+" as int)),0)+1 AS Expr1 " +
                 " FROM         " + tble + where + " ";

            str= objtsk.ExecuteScalar(str);
            //Int64 temp1 = Convert.ToInt64(str) + 1;
            //return temp1.ToString();
            return str;

        }
        public static string getnextidConditionforgeneralledgerAzure(string strfiled, string tble, string where)
        {

            string str = "SELECT     isnull(max(cast(" + strfiled + " as int)),0)+1 AS Expr1 " +
                 " FROM         " + tble + where + " ";

            str = objtsk.ExecuteScalarAzureServer(str);
            //Int64 temp1 = Convert.ToInt64(str) + 1;
            //return temp1.ToString();
            return str;

        }

        public void CHECKCHARACTER(string feild, string tbl, TextBox txtt)
        {
            int legthdata = 0;
            legthdata = Convert.ToInt32(CommonClass._Dbtask.ExecuteScalar("SELECT COL_LENGTH('dbo." + tbl + "', '" + feild + "') AS Result"));

            if (txtt.Text.Length > (legthdata / 2))
            {
                MessageBox.Show("Only  " + (legthdata / 2).ToString() + " Allowed");
                txtt.Focus();


            }



        }




        public static DataSet gds = new DataSet();

        public string Getmajorsymbol()
        {
            string temp = objtsk.ExecuteScalar("select paramvalue from tblparamlist where paramname='majorsymbol'");
            return temp;
        }
        public string Getminerymbol()
        {
            string temp = objtsk.ExecuteScalar("select paramvalue from tblparamlist where paramname='minersymbol'");
            return temp;
        }

        public static void allowNumeric(object sender, KeyPressEventArgs e,bool Isstock)
            {
            try
            {
                int Deci;
                if (Isstock == true)
                {
                    string TempValue = (Generalfunction.StockDeci).ToString();
                    Deci = TempValue.Length - 1;
                }
                else
                {
                    string TempValue = (Generalfunction.CurreDeci).ToString();

                    Deci = TempValue.Length - 1;
                }
                if (char.IsDigit(e.KeyChar))
                {
                    int len = ((TextBox)sender).Text.Length;
                    int pos = ((TextBox)sender).Text.IndexOf('.');
                    int index = ((TextBox)sender).SelectionStart;
                    if (pos == 0 && len == Deci && index > pos)
                    {
                        e.Handled = true;
                    }

                    //if(lngnum==false)
                    //{
                    if(len==12  ||  len>12)
                    {
                        ((TextBox)sender).Text = "0";
                        e.Handled = true;
                    }
                    //}
                    
                    if (pos == 0 && len == Deci && index > pos)
                    {
                        e.Handled = true;
                    }



                    if (pos > 0)
                    {
                        index = ((TextBox)sender).SelectionStart;
                        if (len - pos == Deci) //there are alreay two numbers after the dot
                        {
                            if (index > pos) // and the cursor is after the dot
                            {
                                e.Handled = true; // then do not allow the input
                            }
                        }
                    }
                }
                else if (e.KeyChar == '.')
                {
                    //if (((TextBox)sender).Text.IndexOf('.') != -1) //there's alreay a dot exist
                    //{
                    //    e.Handled = true;
                    //}
                }
                else if (e.KeyChar == '-')
                {
                    if (((TextBox)sender).Text.IndexOf('-') != -1) //there's alreay a dot exist
                    {
                        e.Handled = true;
                    }
                }
                else if (e.KeyChar != '\b') //backspace
                {
                    e.Handled = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal static void fillDatainCombowithQuery(ComboBox comboBox30, string p, string p_3, string p_4, string p_5, string p_6)
        {
            throw new NotImplementedException();
        }
        public void treeview(TreeView TreeMain, string nodee,int num)
        {
            TreeNode[] tn = TreeMain.Nodes[num].Nodes.Find(nodee, true);
            for (int i = 0; i < tn.Length; i++)
            {
                TreeMain.SelectedNode = tn[i];
                TreeMain.SelectedNode.BackColor = Color.Yellow;
            }
        }
      
        public static void formproperty(Form frm)
        {
            frm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //frm.Icon = System.Drawing.Icon.ExtractAssociatedIcon("C:\\Documents and Settings\\Main\\Desktop\\Payroll_21_3_2013\\Payroll\\icon.ico");

            frm.BackColor = System.Drawing.Color.WhiteSmoke;
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frm.MaximizeBox = false;
            // frm.Icon = ((System.Drawing.Icon)(Payroll.Propert.GetObject("$this.Icon")));


            //  System.Drawing.Icon.ExtractAssociatedIcon(Application.StartupPath+"\\"+"this.ico");
        }

        public static void frmbuttons(Button btn)
        {
            //btn.BackColor = System.Drawing.Color.WhiteSmoke;
            //btn.Font.Bold = false;

            //// btn.FlatStyle
        }
        public string avoidnullDecimal(string NullValue)//Avoid Null value
        {
            if (NullValue == "")
            {
                NullValue = "0";

                objtsk.SetintoDecimalpoint(0);
            }
            return NullValue;
        }

        public string Getproducttype()
        {
            regKey = regKey.CreateSubKey("Software\\Techno");
            string Producttype = regKey.GetValue("Ptype", 1).ToString();
            return Producttype;
        }
        public DateTime GetFyearFrom()
        {
            FyearFrom = Convert.ToDateTime(objtsk.ExecuteScalar("select fyearfrom from tblcompanymaster "));
            return FyearFrom;
        }

        public void SetBahavQuries()
        {
            sql = "USE [master] ALTER LOGIN [sa] WITH PASSWORD=N'hello'";
            objtsk.ExecuteNonQuerySecondary(sql);

            sql = "USE [master] EXEC xp_instance_regwrite N'HKEY_LOCAL_MACHINE', N'Software\\Microsoft\\MSSQLServer\\MSSQLServer', N'LoginMode', REG_DWORD, 2";
            objtsk.ExecuteNonQuerySecondary(sql);

            sql = "use master alter login [sa] enable";
            objtsk.ExecuteNonQuerySecondary(sql);
        }

        public string avoidnullStock(string NullValue)//Avoid Null value
        {
            if (NullValue == "")
            {
                NullValue = "0";

                objtsk.SetintoDecimalpointStock(0);
            }
            return NullValue;
        }
        public static void accountstore(ComboBox cmb)
        {
            objtsk.fillDatainCombowithQuery(cmb, "headcode", "headname", "accounthead", "SELECT * FROM accounthead");
            cmb.SelectedIndex = 0;
        }
        //  public static void accountsinsert(DateTime VDate,DateTime VTime,string SlNo,string VType,string VNo,string LedCode,string Particulars,string DbAmt,string CrAmt,string Remark,string ExRate,string CurrencyCode,stringDbCrAmtFC) ///insert accounts part to atacc
        //{
        //    sql = " INSERT INTO GeneralLedger (VDate,VTime,SlNo,VType,VNo,LedCode,Particulars,DbAmt,CrAmt,Remark,ExRate,CurrencyCode,DbCrAmtFC) " +
        //         " VALUES ('" + VDate + "','" + VTime + "','" + SlNo + "','" + VType + "','" + VNo + "','" + LedCode + "','" + Particulars + "','" + DbAmt + "','" + CrAmt + "','" + Remark + "','" + ExRate + "','" + CurrencyCode + "','" + DbCrAmtFC + "')";
        //    objtsk.ExecuteQuery(sql);

        //}
        // public static void accountsformula() ///insert accounts part to atacc(plus or minus);
        //{
        //    sql = " Update AccountLedger set Balance=balance "+formula+" " + balance + " where LedCode='" + LedCode+ "'";
        //    objtsk.ExecuteQuery(sql);
        //}



        //public void Delete(string TableName, string Code, string fixedCode)
        //{
        //    _sqlcon.Costate();
        //    sql = "delete from " + TableName + " where " + Code + "=" + fixedCode + "";
        //    _sqlcon._cmd.CommandText = sql;
        //    _sqlcon._cmd.ExecuteNonQuery();
        //}
        public DataSet checkExisting(string TableName, string code, string FixedCode)
        {
            sql = "select * from " + TableName + " where " + code + " ='" + FixedCode + "'";
            ds = objtsk.ExecuteQuery(sql);
            return ds;
        }

        public bool LoginCheckking()
        {
            sql = "select * from TblUserdetails where username='' and UPassword='' ";
            Check = objtsk.ExecuteNonQuery(sql);
            return true;
        }
        public void updateInvoicenumbers(int minvno,string ToDB,string vtype)
        {
            if (vtype == "SI" || vtype == "SO" || vtype == "SQ" || vtype == "PR")
            {
                CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "Tblbusinessissue" + " " +
               " set issuecode = (vno - " + minvno + "+1),vno=(vno - " + minvno + "+1 )    where  Issuetype ='" + vtype + "'");


                CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "Tblissuedetails" + " " +
              " set issuecode = (issuecode - " + minvno + "+1)  where  vtype ='" + vtype + "'");
            
            
            }
            if (vtype == "PI" || vtype == "PO" ||  vtype == "SR")
            {
                CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "TblTRANSACTIONRECEIPT" + " " +
               " set reptcode = (vno - " + minvno + "+1),vno=(vno - " + minvno + "+1 )    where  recpttype ='" + vtype + "'");


                CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "TblRECEIPTDETAILS" + " " +
              " set recptcode = (recptcode - " + minvno + "+1)  where  vtype ='" + vtype + "'");


            }
            //if (vtype == "R" || vtype == "P" )
            //{
            //    CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "TblGENERALLEDGER" + " " +
            //     " set vno=(vno - " + minvno + "+1 )    where  Vtype ='" + vtype + "'");

            //}



            CommonClass._Dbtask.ExecuteNonQuery("UPDATE " + ToDB + ".." + "Tblgeneralledger" + " " +
             " set vno = (vno - " + minvno + "+1)  where  vtype ='"+vtype+"'");
            
        }
        public void maxvnoupdates(string NEWDB )
        {
            if (CommonClass._Paramlist.IsParamNameExist("MaxofSI") == true)
            {

                CommonClass._Paramlist.ParamName = "MaxofSI";
                string MAXVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM  " + NEWDB + ".." + "TblBusinessIssue where IssueType='SI' and ledcodeCr='2'");
                MAXVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                if (MAXVNO == "" || MAXVNO == "0")
                {
                    MAXVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MAXVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MaxofSI", MAXVNO);
                //InsertParamlist();
            }
            if (CommonClass._Paramlist.IsParamNameExist("MaxofSO") == true)
            {

                CommonClass._Paramlist.ParamName = "MaxofSO";
                string MAXVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM " + NEWDB + ".." + " TblBusinessIssue where IssueType='SO' and ledcodeCr='2'");
                MAXVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                if (MAXVNO == "" || MAXVNO == "0")
                {
                    MAXVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MAXVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MaxofSO", MAXVNO);
               // CommonClass._Paramlist.InsertParamlist();
            }
            if (CommonClass._Paramlist.IsParamNameExist("MaxofSQ") == true)
            {

                CommonClass._Paramlist.ParamName = "MaxofSQ";
                string MAXVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM " + NEWDB + ".." + " TblBusinessIssue where IssueType='SQ' and ledcodeCr='2'");
                MAXVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                if (MAXVNO == "" || MAXVNO == "0")
                {
                    MAXVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MAXVNO;
                //CommonClass._Paramlist.InsertParamlist();

                CommonClass._Paramlist.UPDATEPARAMVALUE("MaxofSQ", MAXVNO);


            }

            if (CommonClass._Paramlist.IsParamNameExist("MaxofSR") == true)
            {

                CommonClass._Paramlist.ParamName = "MaxofSR";
                string MAXVNO = CommonClass._Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(ReptCode), 0) } AS Expr1  FROM  " + NEWDB + ".." + "TbltransactionReceipt where RecptType='SR' and LedcodeDr='2'");
                MAXVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                if (MAXVNO == "" || MAXVNO == "0")
                {
                    MAXVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MAXVNO;
                //CommonClass._Paramlist.InsertParamlist();

                CommonClass._Paramlist.UPDATEPARAMVALUE("MaxofSR", MAXVNO);
            }

            if (CommonClass._Paramlist.IsParamNameExist("MaxofPI") == true)
            {

                CommonClass._Paramlist.ParamName = "MaxofPI";
                string MAXVNO = CommonClass._Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(ReptCode), 0) } AS Expr1  FROM " + NEWDB + ".." + "TbltransactionReceipt where RecptType='PI' and LedcodeDr='3'");
                MAXVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                if (MAXVNO == "" || MAXVNO == "0")
                {
                    MAXVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MAXVNO;
                //CommonClass._Paramlist.InsertParamlist();
                CommonClass._Paramlist.UPDATEPARAMVALUE("MaxofPI", MAXVNO);

            }

            if (CommonClass._Paramlist.IsParamNameExist("MaxofPO") == true)
            {

                CommonClass._Paramlist.ParamName = "MaxofPI";
                string MAXVNO = CommonClass._Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(ReptCode), 0) } AS Expr1  FROM " + NEWDB + ".." + "TbltransactionReceipt where RecptType='PO' and LedcodeDr='3'");
                MAXVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                if (MAXVNO == "" || MAXVNO == "0")
                {
                    MAXVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MAXVNO;
                //CommonClass._Paramlist.InsertParamlist();
                CommonClass._Paramlist.UPDATEPARAMVALUE("MaxofPO", MAXVNO);

            }




            if (CommonClass._Paramlist.IsParamNameExist("MaxofPR") == true)
            {

                CommonClass._Paramlist.ParamName = "MaxofPR";
                string MAXVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM " + NEWDB + ".." + " TblBusinessIssue where IssueType='PR' and ledcodeCr='3'");
                MAXVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                if (MAXVNO == "" || MAXVNO == "0")
                {
                    MAXVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MAXVNO;
                //CommonClass._Paramlist.InsertParamlist();

                CommonClass._Paramlist.UPDATEPARAMVALUE("MaxofPR", MAXVNO);


            }

            if (CommonClass._Paramlist.IsParamNameExist("MaxofSIwh") == true)
            {

                CommonClass._Paramlist.ParamName = "MaxofSIwh";
                string MAXVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM  " + NEWDB + ".." + "TblBusinessIssue where IssueType='SI' and ledcodeCr!='2'");
                MAXVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                if (MAXVNO == "" || MAXVNO == "0")
                {
                    MAXVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MAXVNO;
                //CommonClass._Paramlist.InsertParamlist();

                CommonClass._Paramlist.UPDATEPARAMVALUE("MaxofSIwh", MAXVNO);

            }


        }

        public void MINVALUEvnoupdates(string NEWDB)
        {
            if (CommonClass._Paramlist.IsParamNameExist("MINofSI") == true)
            {

                CommonClass._Paramlist.ParamName = "MINofSI";
                string MINvalVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM " + NEWDB + ".." + "TblBusinessIssue where IssueType='SI' and ledcodeCr='2'");
                MINvalVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MINvalVNO));
                if (MINvalVNO == "" || MINvalVNO == "0")
                {
                    MINvalVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MINvalVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MINofSI", MINvalVNO);
            }
            if (CommonClass._Paramlist.IsParamNameExist("MINofSO") == true)
            {

                CommonClass._Paramlist.ParamName = "MINofSO";
                string MINvalVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM " + NEWDB + ".." + " TblBusinessIssue where IssueType='SO' and ledcodeCr='2'");
                MINvalVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MINvalVNO));
                if (MINvalVNO == "" || MINvalVNO == "0")
                {
                    MINvalVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MINvalVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MINofSO", MINvalVNO);
            }
            if (CommonClass._Paramlist.IsParamNameExist("MINofSQ") == true)
            {

                CommonClass._Paramlist.ParamName = "MINofSQ";
                string MINvalVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM " + NEWDB + ".." + " TblBusinessIssue where IssueType='SQ' and ledcodeCr='2'");
                MINvalVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MINvalVNO));
                if (MINvalVNO == "" || MINvalVNO == "0")
                {
                    MINvalVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MINvalVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MINofSQ", MINvalVNO);
            }

            if (CommonClass._Paramlist.IsParamNameExist("MINofSR") == true)
            {

                CommonClass._Paramlist.ParamName = "MINofSR";
                string MINvalVNO = CommonClass._Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MIN(ReptCode), 0) } AS Expr1  FROM " + NEWDB + ".." + "TbltransactionReceipt where RecptType='SR' and LedcodeDr='2'");
                MINvalVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MINvalVNO));
                if (MINvalVNO == "" || MINvalVNO == "0")
                {
                    MINvalVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MINvalVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MINofSR", MINvalVNO);
            }

            if (CommonClass._Paramlist.IsParamNameExist("MINofPI") == true)
            {

                CommonClass._Paramlist.ParamName = "MINofPI";
                string MINvalVNO = CommonClass._Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MIN(ReptCode), 0) } AS Expr1  FROM " + NEWDB + ".." + " TbltransactionReceipt where RecptType='PI' and LedcodeDr='3'");
                MINvalVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MINvalVNO));
                if (MINvalVNO == "" || MINvalVNO == "0")
                {
                    MINvalVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MINvalVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MINofPI", MINvalVNO);
            }

            if (CommonClass._Paramlist.IsParamNameExist("MINofPO") == true)
            {

                CommonClass._Paramlist.ParamName = "MINofPO";
                string MINvalVNO = CommonClass._Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MIN(ReptCode), 0) } AS Expr1  FROM " + NEWDB + ".." + " TbltransactionReceipt where RecptType='PO' and LedcodeDr='3'");
                MINvalVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MINvalVNO));
                if (MINvalVNO == "" || MINvalVNO == "0")
                {
                    MINvalVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MINvalVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MINofPO", MINvalVNO);
            }



            if (CommonClass._Paramlist.IsParamNameExist("MINofPR") == true)
            {

                CommonClass._Paramlist.ParamName = "MINofPR";
                string MINvalVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM " + NEWDB + ".." + " TblBusinessIssue where IssueType='PR' and ledcodeCr='3'");
                MINvalVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MINvalVNO));
                if (MINvalVNO == "" || MINvalVNO == "0")
                {
                    MINvalVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MINvalVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MINofPR", MINvalVNO);
            }

            if (CommonClass._Paramlist.IsParamNameExist("MINofSIwh") == true)
            {

                CommonClass._Paramlist.ParamName = "MINofSIwh";
                string MINvalVNO = CommonClass._Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM " + NEWDB + ".." + " TblBusinessIssue where IssueType='SI' and ledcodeCr!='2'");
                MINvalVNO = CommonClass._Dbtask.znllString(Convert.ToInt32(MINvalVNO));
                if (MINvalVNO == "" || MINvalVNO == "0")
                {
                    MINvalVNO = "1";
                }
                CommonClass._Paramlist.Paramtype = "";
                CommonClass._Paramlist.ParamValue = MINvalVNO;
                CommonClass._Paramlist.UPDATEPARAMVALUE("MINofSIwh", MINvalVNO);
            }


        }



        public int MINvoget(string condtn)
        {
            int minvn = 0; string minvouchr = "";
            minvouchr = CommonClass._Dbtask.znllString (CommonClass._Dbtask.ExecuteScalar("select Min( CAST(vno as int)) AS vno " +
             " from  " + condtn));
            if (minvouchr != "")
            {
                minvn = Convert.ToInt32(minvouchr);
            }
            else
            {
                minvn = 0;
            }

            return minvn;

        }
        public void TableTransferOneDBToOtherbyDATE(string TableName, string FromDB, string ToDB,string dateVAL)
        {
            CommonClass._Dbtask.ExecuteNonQuery("delete from " + ToDB + ".." + TableName  +"" + dateVAL);
            string Sql = "select column_name from INFORMATION_SCHEMA.COLUMNS " +
                         " where TABLE_NAME='" + TableName + "'";
            string Temp = CommonClass._SelectReport.Showindataset(Sql);
            CommonClass._Dbtask.ExecuteNonQuery("INSERT INTO " + ToDB + ".." + TableName + " (" + Temp + ") " +
                                 " SELECT " + Temp + " FROM  " + FromDB + ".." + TableName + ""+ dateVAL   );
        }


        public void TableTransferOneDBToOther(string TableName, string FromDB, string ToDB)
        {
            CommonClass._Dbtask.ExecuteNonQuery("delete from " + ToDB + ".." + TableName + "");
          string Sql = "select column_name from INFORMATION_SCHEMA.COLUMNS "+
                       " where TABLE_NAME='"+TableName+"'";
          string  Temp = CommonClass._SelectReport.Showindataset(Sql);
          CommonClass._Dbtask.ExecuteNonQuery("INSERT INTO " + ToDB + ".." + TableName + " (" + Temp + ") " +
                               " SELECT " + Temp + " FROM  " + FromDB + ".." + TableName + "");
        }
        
        public string SettNulltoZerogrid(string Value,bool IsCurrency)
        {
            if (Value == "")
           {
               Value = "0";
           }
            return Value;
        }
        //public void MaxVno(string id, string TableName)
        //{
        //    {


        //        sql = "SELECT     { fn IFNULL(MAX(" + id + "), 0) } + 1 AS Expr1 " +
        //        " FROM         " + TableName + "";

        //        objtsk.ExecuteNonQuery(sql);
        //        maxvno = _sqlcon._cmd.ExecuteScalar().ToString();

        //    }


        //}

    }
}
