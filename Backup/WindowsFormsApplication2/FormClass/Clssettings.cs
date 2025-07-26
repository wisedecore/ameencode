using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clssettings
    {
        DataSet Ds;
        DBTask _Dbtask = new DBTask();
        public string Temp;
        public static bool ActiveCompany;
        public bool RBool=true;
        public static bool SDeactiveLedger;
        public static string ItemSearch;
        public string Menuid;
        public DateTime Dt;
        NextGFuntion _Nextg = new NextGFuntion();
        /*For Include Settings*/
        public static bool Sbatch;
        public static bool EProduction;

        ClsParamlist _ParamList = new ClsParamlist();
      //  Clssettings _settings = new Clssettings();
        public DateTime GetFyearFrom()
        {
            Dt =Convert.ToDateTime(_ParamList.GetParamvalue("periodfrom"));
            return Dt;
        }
        public DateTime GetFyearTo()
        {
            Dt = Convert.ToDateTime(_ParamList.GetParamvalue("periodto"));
            return Dt;
        }
        public bool FunSettings2(string Menuid)
        {
            Temp =_Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='"+Menuid+"'");
            if (Temp == "-1")
            {
                RBool = false;
                return false;
            }
            return true;
        }
        public string ReturnStatus(string Menuid)
        {
            Temp = _Dbtask.znllString(  _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='" + Menuid + "'"));
            return Temp;
        }
        public bool ReturnStatusBoolenvalue(string Menuid)
        {
            Temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='" + Menuid + "'");
            if (Temp == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }
        public void SetDecc()
        {
            string tempstock = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='StockDecc'");
            string temocurr = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='CurDecc'");
            tempstock = _Nextg.Decconvertion(tempstock);
            temocurr = _Nextg.Decconvertion(temocurr);
            Generalfunction.CurreDeci = temocurr;
            Generalfunction.StockDeci = tempstock;
        }
        public void RefreshMenusettings()
        {
            SetDecc();
            Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                bool IsVisible;
                string MenuId = Ds.Tables[0].Rows[i]["Menuid"].ToString();
                string Status = Ds.Tables[0].Rows[i]["status"].ToString();
                if (Status == "1")
                {
                    IsVisible = true;
                }
                else
                {
                    IsVisible = false;
                }
                //  MDIParent1 frm = this.MdiParent as MDIParent1;

                
                //(this.MdiParent as MDIParent1).Toolmnu.Enabled = true;  
                if (MenuId == "11")/*Multi Rate*/
                {
                    Generalfunction.EMRate = IsVisible;
                    //(this.MdiParent as MDIParent1).mnumultiratec.Visible = IsVisible;   
                }
                if (MenuId == "12")/*Multi Unit*/
                {
                    Generalfunction.EMunit = IsVisible;
                    //(this.MdiParent as MDIParent1).mnuunitsc.Visible = IsVisible;
                }
                if (MenuId == "13")/*Stock Area*/
                {
                    Generalfunction.EDepot = IsVisible;
                    // (this.MdiParent as MDIParent1).mnustockareac.Visible = IsVisible;
                }
                if (MenuId == "14")/*Tax */
                {
                    Generalfunction.ETax = IsVisible;
                    //(this.MdiParent as MDIParent1).mnutaxc.Visible = IsVisible;
                }
                if (MenuId == "105")/*Producttion */
                {
                    Clssettings.EProduction = IsVisible;
                    //(this.MdiParent as MDIParent1).mnutaxc.Visible = IsVisible;
                }

                if (MenuId == "21")/*Sales Estimation*/
                {
                    Generalfunction.ESalesestimation = IsVisible;
                    //(this.MdiParent as MDIParent1).mnusalesestimationt.Visible = IsVisible;
                }

                if (MenuId == "22")/*Sales Return*/
                {
                    Generalfunction.ESalesreturn = IsVisible;
                    //(this.MdiParent as MDIParent1).mnusalesreturnt.Visible = IsVisible;
                }

                if (MenuId == "24")/*Purchase Return*/
                {
                    Generalfunction.EPurchasereturn = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                if (MenuId == "103")/*Purchase Return*/
                {
                    Clssettings.Sbatch = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                if (MenuId == "105")/*Production*/
                {
                    Clssettings.EProduction = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                if (MenuId == "137")/*Purchase Return*/
                {
                    Clssettings.SDeactiveLedger = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                if (MenuId == "140")/*Purchase Return*/
                {
                    Generalfunction.ECRM = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                if (MenuId == "144")/*Purchase Return*/
                {
                    Generalfunction.EWmachine = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                if (MenuId == "145")/*Purchase Return*/
                {
                    Generalfunction.EPharmacy = IsVisible;
                    // (this.MdiParent as MDIParent1).mnupurchasereturnt.Visible = IsVisible;
                }
                /*For ItemDeactive Settings*/
                Clssettings.ItemSearch = _ParamList.GetParamvalue("ItemSearch");
            }
        }
        public bool FunSettings1(string MenuName)
        {
            if (MenuName == "Pitemnote1")
                Menuid = "127";
            if (MenuName == "Pitemnote2")
                Menuid = "128";
            if(MenuName=="Batch")
                Menuid = "103";
            if (MenuName == "customerpoint")
                Menuid = "129";
            if (MenuName == "MdateBPrint")
                Menuid = "131";
            if (MenuName == "Note1BPrint")
                Menuid = "132";
            if (MenuName == "Note2BPrint")
                Menuid = "133";
            if (MenuName == "SuppliercodeBPrint")
                Menuid = "134";
            if (MenuName == "Batch")
                Menuid = "103";
            return FunSettings2(Menuid);
        }
    }
}
