using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Clsdotmetrixprintsettings
    {

        

        LPrinter MyPrinter;
        ClsParamlist _Paramlist = new ClsParamlist();

       

        public  string BackScroll;
        public  string FScroll;
        
        public void SaveDotMetrix()
        {
            _Paramlist.UpdateParamlist("Bscroll", "1", BackScroll.ToString());
            _Paramlist.UpdateParamlist("Fscroll", "1", FScroll.ToString());
        }
        public int WorkBackscroll()
        {
            BackScroll =(_Paramlist.GetParamvalue("Bscroll"));
            return Convert.ToInt16(BackScroll);
        }
        public string WorkFrontScroll()
        {
            FScroll =_Paramlist.GetParamvalue("Fscroll");
            CommonClass.temp="";
            for (int i = 0; i <Convert.ToInt16(FScroll); i++)
            {
                CommonClass.temp = CommonClass.temp +"\n";
            }
            return CommonClass.temp;
        }

         public string PrintInvoiceHead(string Vtype)
        {
            if (Vtype == "SI")
                CommonClass.temp = "Sales Invoice";
            if (Vtype == "SR")
                CommonClass.temp = "Sales Return";
            if (Vtype == "PR")
                CommonClass.temp = "Purchase Return";
            if (Vtype == "PI")
                CommonClass.temp = "Purchase Invoice";

            return CommonClass.temp;
        }
    }
}
