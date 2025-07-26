using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace WindowsFormsApplication2
{
    class Clssms
    {
        string LoginName;
        string LoginPwd;
        string MobileNo;
        string LName;
        string Subject;
        string FilePath;

        WebClient client = new WebClient();

        public void SendSms(string IMobileNo,string ILedName,string ISubject)
        {
            MobileNo = IMobileNo;
            LName = ILedName;
           // Balance = _Dbtask.znllString(gridmain.Rows[i].Cells["clnbalance"].Value);
            Subject = ISubject;
          LoginName = "Mouscore";
         LoginPwd = "zatadmin";
            FilePath = "sapteleservices.in/SMS_API/sendsms.php?username=" + LoginName + "&password=" + LoginPwd + "&mobile=" + MobileNo + "&sendername=UPDATE&message=" + Subject + "&routetype=0";
            CallSend();
        }
        public void CallSend()
        {
            if (GetBalanceOfSms())
            {
              
                Stream data = client.OpenRead("http://" + FilePath);
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();
                data.Close();
                reader.Close();
                string PendingSMS = CommonClass._Paramlist.GetParamvalue("SB");
                CommonClass._Paramlist.UpdateParamlist("SB", "-1", (Convert.ToInt64(PendingSMS) - 1).ToString());
            }
        }
        public bool GetBalanceOfSms()
        {
            string BalanceSms = CommonClass._Paramlist.GetParamvalue("SB");
            if (Convert.ToDouble(BalanceSms) > 0)
                return true;
            return false;
        }
    }
}
