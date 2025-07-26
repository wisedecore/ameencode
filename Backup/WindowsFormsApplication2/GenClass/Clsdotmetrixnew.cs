using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clsdotmetrixnew
    {
        DataSet Ds;
        DataGridView Grid;
        /*Header*/
        public string Invheader;
        public string Invcash;
        public string Cusid;
        public DateTime Invdate;
        public string Invvno;

        /*Footer*/
        string Tqty;
        string Tfqty;
        string TGrossamt;
        string Titemdisc;
        string Ttaxable;
        string Tnontaxable;
        string Ttax;
        string Tamount;
        string TDiscount;
        string Tcashdiscount;
        string Troundoff;   
        string Totherexpence; 
        string Tbillamount;
        string Inwords;
        string Salesman;
        string TMrpvalue;
        string Naration;

        StringBuilder _Pt = new StringBuilder(); //_Pt(Print Text)

        string Format="";

        string _Header;
        string _Deatils ;
        string _Footer ;


        public string Readheader()
        {
            _Header= _Header.Replace("<h Tin No>",CommonClass._compMaster.GetspecifField("TaxNo1"));
            _Header = _Header.Replace("<h CST No>", CommonClass._compMaster.GetspecifField("VATno"));
            _Header = _Header.Replace("<h Invoice Header>", Invheader);
            _Header = _Header.Replace("<h Cash Bill>", Invcash);

            _Header = _Header.Replace("<P Page No>", "Tin No");

            if (Cusid != "")
            {
                Ds = CommonClass._Ledger.ShowLedger(" where lid='" + Cusid + "'");
                _Header = _Header.Replace("<P Party Name>", Ds.Tables[0].Rows[0]["lname"].ToString());
                _Header = _Header.Replace("<P Party Address>", Ds.Tables[0].Rows[0]["address"].ToString());
                _Header = _Header.Replace("<P Party Address1>", "C Bill");
               // _Header = _Header.Replace("<P Party Address2>", "Inv.Header");
                //_Header = _Header.Replace("<P Party Address3>", "C Bill");
                _Header = _Header.Replace("<P Party Phone>", Ds.Tables[0].Rows[0]["phone"].ToString());
                _Header = _Header.Replace("<P Party Mobile>", Ds.Tables[0].Rows[0]["mobile"].ToString());
                _Header = _Header.Replace("<P Party Tax No>", Ds.Tables[0].Rows[0]["TaxregNo"].ToString());
                _Header = _Header.Replace("<P PCD(Party Credit Days)>", Ds.Tables[0].Rows[0]["creditdays"].ToString());
               // _Header = _Header.Replace("<P Delivery Note No>", Ds.Tables[0].Rows[0]["Taxregno"].ToString());
               // _Header = _Header.Replace("<P Order Details>", "CST");
            }

           
            //_Header = _Header.Replace("<P Dispacth Details>", "Inv.Header");

            _Header = _Header.Replace("<P InvDate>", Invdate.ToString("dd/MM/yyy"));
            _Header = _Header.Replace("<P InvNo>", Invvno);
           // _Header = _Header.Replace("<P InvTime>", Invdate.TimeOfDay.ToString("hh:mm:ss"));
           // _Header = _Header.Replace("<P Term of Delivery>", "Tin No");
           // _Header = _Header.Replace("<P Agent>", "CST");
            //_Header = _Header.Replace("<P Ref No>", "Inv.Header");
            return _Header;
        }

        public string Readdetails()
        {
            string details = "";
            for (int i = 0;i < Grid.Rows.Count; i++)
            {
               
                details += "\n" + _Deatils.Replace("<I SlNo>", i.ToString());
                //details = details.Replace("<I ShedueleNo>", Grid.Rows[i].Cells["clnitemname"].Value.ToString());
                details = details.Replace("<I Item Name>", Grid.Rows[i].Cells["clnitemname"].Value.ToString());
                details = details.Replace("<I Item Code>", Grid.Rows[i].Cells["clnitemcode"].Value.ToString());
                details = details.Replace("<I Batch Code>", Grid.Rows[i].Cells["clnbatch"].Value.ToString());

               // details = details.Replace("<I Serial Number>", "Item-" + i.ToString());
              //  details = details.Replace("<I Description>", (i * 2 + 1).ToString());
                details = details.Replace("<I MRP>", Grid.Rows[i].Cells["clnmrp"].Value.ToString());
                details = details.Replace("<I Unit>", Grid.Rows[i].Cells["clnunit"].Value.ToString());
                details = details.Replace("<I TPer>", Grid.Rows[i].Cells["ClntaxPer"].Value.ToString());
                details = details.Replace("<I Tax>", Grid.Rows[i].Cells["clntax"].Value.ToString());
                details = details.Replace("<I Rate>", Grid.Rows[i].Cells["clnsrate"].Value.ToString());
               // details = details.Replace("<I Rate Inc(Rate Inclusive)>", (i * 2 + 1).ToString());

                details = details.Replace("<I Qty>", Grid.Rows[i].Cells["clnqty"].Value.ToString());
                details = details.Replace("<I Free>", Grid.Rows[i].Cells["clnfree"].Value.ToString());
                details = details.Replace("<I Gross(Rate*Qty)>", Grid.Rows[i].Cells["clngross"].Value.ToString());
                details = details.Replace("<I IDiscP(Item DiscPercentage)>", Grid.Rows[i].Cells["clnfree"].Value.ToString());
                details = details.Replace("<I Item Dis(Amt)>", Grid.Rows[i].Cells["clndiscount"].Value.ToString());
                //details = details.Replace("<I Txble>", (i * 2 + 1).ToString());
                //details = details.Replace("<I Tax Amt(Tax Amount)>", "Item-" + i.ToString());
                //details = details.Replace("<I CessP>", (i * 2 + 1).ToString());

                //details = details.Replace("<I Cess Amt>", (i * 2 + 1).ToString());
                //details = details.Replace("<I Totta(Tottal Without)>", "Item-" + i.ToString());
                //details = details.Replace("<I Tottalc(Toottal Without cess)>", (i * 2 + 1).ToString());
                //details = details.Replace("<I Tottal Without Bill>", "Item-" + i.ToString());
                //details = details.Replace("<I ISaving(Saving Item Wise)>", (i * 2 + 1).ToString());
            }
            return details;
        }

        public string Readfooter()
        {
            _Footer = _Footer.Replace("<F Qty Tot>", Tqty);
            _Footer = _Footer.Replace("<F FQtyTot>", Tfqty);
            _Footer = _Footer.Replace("<F Gramt(Gross Amt)>",TGrossamt);
            _Footer = _Footer.Replace("<F Item Disc>", TDiscount);
            _Footer = _Footer.Replace("<F Txblt(Taxable Total)>", Ttaxable);
            _Footer = _Footer.Replace("<F Nontxblt(Non Taxable total)>", Tnontaxable);

            _Footer = _Footer.Replace("<F TTa(Tax Total)>",Ttax);
            _Footer = _Footer.Replace("<F TotAmt(Total Amount)>", "My Conay");
            _Footer = _Footer.Replace("<F Total Amtw(Total Amount Without)>", "My Conay");
            _Footer = _Footer.Replace("<F Cessontax>", "My Conay");
            _Footer = _Footer.Replace("<F Discper>", TDiscount);
            _Footer = _Footer.Replace("<F Discount>", TDiscount);

            _Footer = _Footer.Replace("<F Cash Discount>", Tcashdiscount);
            _Footer = _Footer.Replace("<F ServiceTax>", "");
            _Footer = _Footer.Replace("<F Service Amt>", "My Conay");
            _Footer = _Footer.Replace("<F TotAmtB>", "My Conay");
            _Footer = _Footer.Replace("<F TotalAmount>", "My Conay");
            _Footer = _Footer.Replace("<F Roundoff>", Troundoff);

            _Footer = _Footer.Replace("<F OtherExpense>", Totherexpence);
            _Footer = _Footer.Replace("<F Accounts>", "My Conay");
            _Footer = _Footer.Replace("<F BillAmount>", "My Conay");
            _Footer = _Footer.Replace("<F Inwords>", "My Conay");
            _Footer = _Footer.Replace("<F Savings>", "My Conay");
            _Footer = _Footer.Replace("<F Salesman>", "My Conay");

            _Footer = _Footer.Replace("<F OutstandingAmt>", "My Conay");
            _Footer = _Footer.Replace("<F Narration>", "My Conay");
            _Footer = _Footer.Replace("<F MRPvalue>", "My Conay");
            _Footer = _Footer.Replace("<F TaxSplit>", "My Conay");
            _Footer = _Footer.Replace("<F AccountDet>", "My Conay");
            return _Footer;
        }

        public string FuRead()
        {
            int ints = Format.IndexOf("#", 0);
            int intE = Format.IndexOf("#", ints + 1);

            _Header = Format.Substring(0, ints);
            _Deatils = Format.Substring(ints + 1, intE - ints - 1);
            _Footer = Format.Substring(intE + 1);

            _Pt.Append(Readheader());
            _Pt.Append(Readdetails());
            _Pt.Append(Readfooter());

            return _Pt.ToString();
        }
    }
}
