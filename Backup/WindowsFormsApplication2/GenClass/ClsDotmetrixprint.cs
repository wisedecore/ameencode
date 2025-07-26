using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class ClsPrint
    {
        DBTask _DBTask = new DBTask();
        ClsCompanyMaster _CompanyMaster = new ClsCompanyMaster();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        frmsalesinvoice _Sales = new frmsalesinvoice();

       public string ReturnValue;
       public string ItemTag;
       public string Vno;
       public int i;
       public double grandTotal;
       public double RoundOff = 0.00;
       public string narretion = "";
      
       public string DotMetrixPrinter(string Tag,DataGridView Grid,string Vno,string CustomerTag,int RowIndex)
       {
          ReturnValue = "";
              switch (Tag)
              {
                  case "hTinNo": ReturnValue = _CompanyMaster.GetspecifField("TaxNo1");
                      break;
                  case "hCSTNo": ReturnValue = _CompanyMaster.GetspecifField("VATNo");
                      break;
                  case "hInvoiceHeader": ReturnValue = _CompanyMaster.GetspecifField("Cname");
                      break;
                  case "PPartyName": ReturnValue = _AccountLedger.GetspecifField("Lname", CustomerTag);
                      break;
                  case "PPartyAddress": ReturnValue = _AccountLedger.GetspecifField("Address", CustomerTag);
                      break;
                  case "PPartyPhone": ReturnValue = _AccountLedger.GetspecifField("Phone", CustomerTag);
                      break;
                  case "PPartyMoile": ReturnValue = _AccountLedger.GetspecifField("Mobile", CustomerTag);
                      break;
                  case "PPartyTaxNo": ReturnValue = _AccountLedger.GetspecifField("TaxRegNo", CustomerTag);
                      break;
                  case "PInvDate": ReturnValue = _DBTask.ExecuteScalar("select IssueDate from TblBusinessIssue where VNo='" + Vno + "' and IssueType='SI'");
                      break;
                  case "PInvNo": ReturnValue = Vno;
                      break;
                  case "ISl": string slno = _DBTask.znllString(Grid.Rows[RowIndex].Cells["ClnSlno"].Value.ToString());
                      ReturnValue = ReturnValue + slno;
                      break;
                  case "IItemName": string ItemName = Grid.Rows[RowIndex].Cells["clnitemname"].Value.ToString();
                      ReturnValue = ReturnValue + ItemName;
                      break;
                  case "IItemCode": string ItemCode = Grid.Rows[RowIndex].Cells["clnitemcode"].Value.ToString();
                      ReturnValue = ReturnValue +  ItemCode;
                      break;
                  case "IBatchCode": string BatchCode = Grid.Rows[RowIndex].Cells["clnbatch"].Value.ToString();
                      ReturnValue = ReturnValue +  BatchCode;
                      break;
                  case "IMRP": double MRP = _DBTask.znlldoubletoobject(Grid.Rows[RowIndex].Cells["ClnMRP"].Value.ToString());
                      ReturnValue =_DBTask.SetintoDecimalpoint(MRP);
                      break;
                  case "ITPer(TaxPercentage)": double TaxPer = _DBTask.znlldoubletoobject(Grid.Rows[RowIndex].Cells["ClntaxPer"].Value.ToString());
                      ReturnValue = _DBTask.SetintoDecimalpoint(TaxPer);
                      break;
                  case "ITax": double Tax = _DBTask.znlldoubletoobject(Grid.Rows[RowIndex].Cells["clntax"].Value.ToString());
                      ReturnValue =_DBTask.SetintoDecimalpoint(Tax);
                      break;
                  case "IRate": double Rate = _DBTask.znlldoubletoobject(Grid.Rows[RowIndex].Cells["clnsrate"].Value.ToString());
                      ReturnValue =_DBTask.SetintoDecimalpoint(Rate);
                      break;
                  case "IQty": double QTY = _DBTask.znlldoubletoobject(Grid.Rows[RowIndex].Cells["clnqty"].Value.ToString());
                      ReturnValue =_DBTask.SetintoDecimalpoint(QTY);
                      break;
                  case "IFree": double Free = _DBTask.znlldoubletoobject(Grid.Rows[RowIndex].Cells["clnfree"].Value.ToString());
                      ReturnValue =_DBTask.SetintoDecimalpoint(Free);
                      break;
                  case "IGross(Rate*Qty)": double GrossRate = _DBTask.znlldoubletoobject(Grid.Rows[RowIndex].Cells["ClnGross"].Value.ToString());
                      ReturnValue = _DBTask.SetintoDecimalpoint(GrossRate);
                      break;
                  case "IIDiscP(ItemDiscPercentage)": double DiscPer = _DBTask.znlldoubletoobject(Grid.Rows[RowIndex].Cells["ClnDiscPer"].Value.ToString());
                      ReturnValue = ReturnValue + DiscPer;
                      break;
                  case "IItemDis(Amt)": double DiscAmt = _DBTask.znlldoubletoobject(Grid.Rows[RowIndex].Cells["clndiscount"].Value.ToString());
                      ReturnValue =_DBTask.SetintoDecimalpoint(DiscAmt);
                      break;
                  case "FQtyTot":
                      double tqty = 0;
                      for (int i = 0; i < Grid.Rows.Count; i++)
                      {
                          if (Grid.Rows[i].Tag != null)
                          {
                              if (Grid.Rows[i].Tag.ToString() == "1")
                              {
                                  tqty = tqty + _DBTask.znlldoubletoobject(Grid.Rows[i].Cells["clnqty"].Value.ToString());
                              }
                          }
                      }
                      ReturnValue =_DBTask.SetintoDecimalpoint(tqty);
                      break;
                  case "FFQtyTot":
                      double Tfqty = 0;
                      for (int i = 0; i < Grid.Rows.Count; i++)
                      {
                          if (Grid.Rows[i].Tag != null)
                          {
                              if (Grid.Rows[i].Tag.ToString() == "1")
                              {
                                  Tfqty = Tfqty + _DBTask.znlldoubletoobject(Grid.Rows[i].Cells["clnqty"].Value.ToString());
                              }
                          }
                      }
                      ReturnValue =_DBTask.SetintoDecimalpoint(Tfqty);
                      break;
                  case "FGramt(GrossAmt)": string total = _DBTask.SetintoDecimalpointStock(grandTotal);
                      ReturnValue = total;
                      //double GrossAmt = 0;
                      //for (int i = 0; i < Grid.Rows.Count; i++)
                      //{
                      //    if (Grid.Rows[i].Tag != null)
                      //    {
                      //        if (Grid.Rows[i].Tag.ToString() == "1")
                      //        {
                      //            GrossAmt = GrossAmt + _DBTask.znlldoubletoobject(Grid.Rows[i].Cells["ClnGross"].Value.ToString());
                      //        }
                      //    }
                      //}
                      //ReturnValue = _DBTask.SetintoDecimalpoint(GrossAmt);
                      break;
                  case "FItemDisc":
                      double Discunt = 0;
                      for (int i = 0; i < Grid.Rows.Count; i++)
                      {
                          if (Grid.Rows[i].Tag != null)
                          {
                              if (Grid.Rows[i].Tag.ToString() == "1")
                              {
                                  Discunt = Discunt + _DBTask.znlldoubletoobject(Grid.Rows[i].Cells["clndiscount"].Value.ToString());
                              }
                          }
                      }
                      ReturnValue =_DBTask.SetintoDecimalpoint(Discunt);
                      break;
                  case "FTTa(TaxTotal)":
                      double TTax = 0;
                      for (int i = 0; i < Grid.Rows.Count; i++)
                      {
                          if (Grid.Rows[i].Tag != null)
                          {
                              if (Grid.Rows[i].Tag.ToString() == "1")
                              {
                                  TTax = TTax + _DBTask.znlldoubletoobject(Grid.Rows[i].Cells["clntax"].Value.ToString());
                                
                              }
                          }
                      }
                      ReturnValue =_DBTask.SetintoDecimalpoint(TTax);
                      break;
                  case "FDiscount": string Discnt = _DBTask.ExecuteScalar("select invdisc from TblBusinessIssue where VNo='" + Vno + "' and  IssueType='SI'");
                      double DiscunTotl = _DBTask.znullDouble(Discnt);
                      ReturnValue = _DBTask.SetintoDecimalpoint(DiscunTotl);
                      break;
                  case "FCashDiscount": string cash = _DBTask.ExecuteScalar("select DiscAmt from TblBusinessIssue where VNo='" + Vno + "' and  IssueType='SI'");
                      double CashDiscTotl = _DBTask.znullDouble(cash);
                      ReturnValue = _DBTask.SetintoDecimalpoint(CashDiscTotl);
                      break;
                  case "FOtherExpense": string Other = _DBTask.ExecuteScalar("select Cooly from TblBusinessIssue where VNo='" + Vno + "' and  IssueType='SI'");
                      double OtherExpnce = _DBTask.znullDouble(Other);
                      ReturnValue = _DBTask.SetintoDecimalpoint(OtherExpnce);
                      break;
                  case "FSalesman": string EmpId = _DBTask.ExecuteScalar("select EmpId from TblBusinessIssue where VNo='" + Vno + "' and  IssueType='SI'");
                      ReturnValue = _DBTask.ExecuteScalar("select LName from TblAccountLedger where Lid='" + EmpId + "' and AGroupId='22'");
                      break;
                  case "FInwords": ReturnValue = "";
                      break;
                  case "FRoundoff": double Roundof = RoundOff;
                      ReturnValue = _DBTask.SetintoDecimalpoint(RoundOff);
                      break;
                  case "FNarration": ReturnValue = narretion;
                      break;
                      
                  default: break;

              }
         // }
           return (ReturnValue);
       }
        
    }
}
