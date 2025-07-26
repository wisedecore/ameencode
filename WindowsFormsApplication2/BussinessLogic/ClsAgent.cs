using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class ClsAgent
    {

        public long Aid;
        public string Aname;
        public string Acode;
        public double Comm;
        public int Post;

        DBTask _Dbtask = new DBTask();
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        //public void InsertAgent()
        //{
        //    object[,] ObjArg = new object[5, 2]
        //    {
        //    {"@Aid",Aid},
        //    {"@Aname",Aname},
        //    {"@Acode",Acode},  
        //    //{"@Slno",Slno},
        //    {"@Comm",Comm},
        //    {"@post",Post}
        //};
        //    _Dbtask.ExecuteNonQuery_SP("InsertAgent", ObjArg);
        //    return;
        //}

        //public void IdAgent()
        //{
        //    Aid = Convert.ToInt64(Generalfunction.getnextid("Aid", "Tblagent"));
        //}
        //public void FillCombo(ComboBox Cmb)
        //{
        //    Generalfunction.fillDatainCombowithQuery(Cmb, "Aid", "Aname", "Tblagent", "SELECT * FROM Tblagent");
        //}
        public void NextgInitializeAndInsertDr(string AgentCode,string Purticulars,double AgentAmt,string purchase)
        {
            _GeneralLedger.LedCodeStr =AgentCode;
            _GeneralLedger.PurticularsStr = Purticulars;
            _GeneralLedger.DbAmtDb = 0;
            _GeneralLedger.CrAmt =AgentAmt;
            _GeneralLedger.RefnoStr = purchase;
            _GeneralLedger.InsertGeneralLedger();
        }

        public void NextgInitializeAndInsertCr(string AgentCode, string DebitedCode, string Purticulars, double CrAmt,double DrAmt, double AgentAmt)
        {
            _GeneralLedger.LedCodeStr = DebitedCode;
            _GeneralLedger.PurticularsStr = Purticulars;
            _GeneralLedger.DbAmtDb = DrAmt;
            _GeneralLedger.CrAmt = 0;
            _GeneralLedger.InsertGeneralLedger();

            _GeneralLedger.LedCodeStr = AgentCode;
            _GeneralLedger.PurticularsStr = Purticulars;
            _GeneralLedger.DbAmtDb = 0;
            _GeneralLedger.CrAmt = AgentAmt;
            _GeneralLedger.InsertGeneralLedger();
        }
    }
}
