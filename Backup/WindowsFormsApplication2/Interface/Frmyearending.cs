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
    public partial class Frmyearending : Form
    {
        public Frmyearending()
        {
            InitializeComponent();
        }
        /*Settings*/
        /*For Using Identified Minus Stock*/
        bool RemoveMinusStock;
        
            long TCode;
        string Sql;
        string temp;
        bool SBatch;
        string FromDb;
        string ToDb;
        DateTime YearEndingDate;
        string ID;
        string Batch;
        double Balance;
        double DBAmt;
        double CRAmt;
        string Depocode = "0";
        double qty;
        double Prate;
        double Srate;
        double TAmount;public int minvnn = 0;
        public string Pproject;
        DataSet Ds;
        private void cmdok_Click(object sender, EventArgs e)
        {
            Main();
        }
        private void Main()
        {
            DialogResult Result = MessageBox.Show("Are You Sure to Countinue Year Ending?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result.ToString() == "Yes")
            {
                if (ValidationFu())
                {
                    Nextginitilize();
                    
                }  
            }
        }

        public void TransferingAccountBalance()
        {
            Generalfunction.OpCompany = FromDb;
            DateTime dtt = dtNextyr.Value;
            string dtdatwise = dtt.ToString("MM/dd/yyyy") + " 00:00:00";
            CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblaccountledger");
            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                 Generalfunction.OpCompany = FromDb;
                ID = CommonClass._Dbtask.znllString(   CommonClass.Ds.Tables[0].Rows[i]["lid"]);
                CommonClass.Ds1 = CommonClass._Partyproject.Showpartyproject(false, ID);

               

                if (CommonClass.Ds1.Tables[0].Rows.Count > 0)
                {
                    for (int k = 0; k < CommonClass.Ds1.Tables[0].Rows.Count; k++)
                    {
                        Generalfunction.OpCompany = FromDb;
                        Pproject = CommonClass._Dbtask.znllString(CommonClass.Ds1.Tables[0].Rows[k]["pid"]);
                        long pprjct = Convert.ToInt64(CommonClass.Ds1.Tables[0].Rows[k]["pid"]);

                        long slnn = 1;

                        Balance = CommonClass._Ledger.BalanceofledgerWISEDATE(ID, Pproject, "vdate < '" + dtdatwise + "' ");

                        
                        ID =CommonClass._Dbtask.znllString( CommonClass.Ds.Tables[0].Rows[i]["lid"]);

                        string Vno;
                        if (Balance != 0)
                        {
                            DBAmt = 0;
                            CRAmt = 0;
                            double tx = 0; double txper = 0;
                            double recvddesk = 0;
                            if (Balance > 0)
                            {
                                DBAmt = Balance;

                                if (DBAmt > 999999999)
                                {
                                    DBAmt = 0;
                                }
                            }
                            else
                            {
                                CRAmt = Balance *(-1);

                                if (CRAmt > 999999999)
                               {
                                   CRAmt = 0;
                               }


                            }

                            //DBAmt = CommonClass._commenevent.RemoveMInesinAmount(DBAmt);
                            //CRAmt = CommonClass._commenevent.RemoveMInesinAmount(CRAmt);
                            if (CRAmt > 0 || DBAmt>0)
                            {
                           CommonClass._GenLedger.IdGeneralLedger(" where vtype='OB'");
                            Vno = CommonClass._GenLedger.VnoStr;
                            CommonClass._GenLedger.VdateDt = dtt;
                            CommonClass._GenLedger.VTypeStr = "OB";
                            CommonClass._GenLedger.VnoStr = Vno;
                            CommonClass._GenLedger.SlNoLng = slnn;
                            CommonClass._GenLedger.LedCodeStr = ID;
                            CommonClass._GenLedger.PurticularsStr = "Opening Balance";
                            CommonClass._GenLedger.RefnoStr = "1001";
                            CommonClass._GenLedger.DbAmtDb = DBAmt;
                            CommonClass._GenLedger.CrAmt = CRAmt;
                            CommonClass._GenLedger.Pproject = pprjct;
                            CommonClass._GenLedger.RPtaxamt = tx;
                            CommonClass._GenLedger.RPtaxperc = txper;
                            CommonClass._GenLedger.cashdskRcvamt = recvddesk;
                            CommonClass._GenLedger.billbalance = recvddesk;
                            CommonClass._GenLedger.Discount = recvddesk;
                            Generalfunction.OpCompany = ToDb;
                            CommonClass._GenLedger.InsertGeneralLedger();
                            }
                        }
                    }
                }
                else
                {
                    Generalfunction.OpCompany = FromDb;
                        Balance = CommonClass._Ledger.Balanceofledger(ID);

                      

                        string Vno;
                        if (Balance != 0)
                        {
                            DBAmt = 0;
                            CRAmt = 0;

                            if (Balance > 0)
                                DBAmt = Balance;
                            else
                                CRAmt = Balance;

                            DBAmt = CommonClass._commenevent.RemoveMInesinAmount(DBAmt);
                            CRAmt = CommonClass._commenevent.RemoveMInesinAmount(CRAmt);

                            CommonClass._GenLedger.IdGeneralLedger(" where vtype='OB'");
                            Vno = CommonClass._GenLedger.VnoStr;
                            CommonClass._GenLedger.VdateDt = YearEndingDate;
                            CommonClass._GenLedger.VTypeStr = "OB";
                            CommonClass._GenLedger.VnoStr = Vno;
                            CommonClass._GenLedger.SlNoLng = Convert.ToInt64("1");
                            CommonClass._GenLedger.LedCodeStr = ID;
                            CommonClass._GenLedger.PurticularsStr = "Opening Balance";
                            CommonClass._GenLedger.RefnoStr = "1001";
                            CommonClass._GenLedger.DbAmtDb = DBAmt;
                            CommonClass._GenLedger.CrAmt = CRAmt;
                            CommonClass._GenLedger.Pproject =0;

                            Generalfunction.OpCompany = ToDb;
                            CommonClass._GenLedger.InsertGeneralLedger();

                        }
                    }
                
            }
        }
        public void InsertAllBatches()
        {
            if (SBatch == true)
            {
                string sql2;
                string Batchcode;
                string Pcode;
                sql2 = "  SELECT         TblInventory.batchcode, TblInventory.pcode,0,0,0,0,0,0,0,0 FROM  " + FromDb + ".. " +
                " TblInventory LEFT OUTER JOIN " +
                       " Tblbatch ON  TblInventory.batchcode=Tblbatch.Bcode GROUP BY  TBLBATCH.BCODE ,TBLINVENTORY.BATCHCODE,TblInventory.PCode " +
                       " having   TBLBATCH.BCODE IS NULL AND TblInventory.batchcode NOT IN('','0')";
                Ds = CommonClass._Dbtask.ExecuteQuery(sql2);
                for (int k = 0; k < Ds.Tables[0].Rows.Count; k++)
                {
                    Batchcode = Ds.Tables[0].Rows[k]["batchcode"].ToString();
                    Pcode = Ds.Tables[0].Rows[k]["pcode"].ToString();

                    Sql = "insert into " + ToDb + "..tblbatch(bcode,itemid,costcenter,depo,bid,ledcode,mrp,srate,prate,recptcode)  values" +
            "('" + Batchcode + "'," + Pcode + ",0,0,'0','0',0,0,0,0) ";
                    CommonClass._Dbtask.ExecuteNonQuery(Sql);
                }
            }
        }
        public void TransferingStockBalance()
        {
            Generalfunction.OpCompany = FromDb;
            TAmount = 0;
            DateTime dtt = dtNextyr.Value;
            string AA = dtt.ToString("MM/dd/yyyy") + " 00:00:00";
            InsertAllBatches();
            CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblitemmaster");
            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                Generalfunction.OpCompany = ToDb;
                CommonClass._Transactionreceipt.IdOpeningStockFu();
                TCode = CommonClass._Transactionreceipt.RcptCodeLng;
           
                ID = CommonClass.Ds.Tables[0].Rows[i]["itemid"].ToString();
                if (SBatch == true)
                {
                    
                    Generalfunction.OpCompany = FromDb;
                    Sql = "select * from tblbatch where itemid='" + ID + "'";
                    CommonClass.Ds1 = CommonClass._Dbtask.ExecuteQuery(Sql);
                    for (int k = 0; k < CommonClass.Ds1.Tables[0].Rows.Count; k++)
                    {
                        Generalfunction.OpCompany = FromDb;
                        
                        Batch = CommonClass.Ds1.Tables[0].Rows[k]["bcode"].ToString();


                        Balance = Convert.ToDouble(CommonClass._Inventory.GetStock(" where pcode='" + ID + "' and batchcode='" + Batch + "'  AND invdate>'" + AA + "'"));


                        if (Balance != 0)
                        {
                            if (RemoveMinusStock == true)
                            {
                                if (Balance > 0)
                                {
                                    Generalfunction.OpCompany = ToDb;
                                    CommonClass._Inventory.Vcode = TCode.ToString();
                                    CommonClass._Inventory.DCodeStr = Depocode;
                                    CommonClass._Inventory.InvDateDt = dtt;
                                    CommonClass._Inventory.PcodeStr = ID;
                                    CommonClass._Inventory.Os = Balance;
                                    CommonClass._Inventory.Batchcode = Batch;
                                    CommonClass._Inventory.InsertInventory();

                                    /*For Receipt Details*/
                                    CommonClass._ReceiptDetails.RcptCodeLng = Convert.ToInt64(TCode);
                                    CommonClass._ReceiptDetails.SlNoLng = i + 1;
                                    CommonClass._ReceiptDetails.PCodeStr = ID;
                                    CommonClass._ReceiptDetails.UnitIdLng = 0;
                                    CommonClass._ReceiptDetails.MultiRateIdLng = 0;
                                    CommonClass._ReceiptDetails.QtyDb = Balance;
                                    CommonClass._ReceiptDetails.SRate = Convert.ToDouble(Srate);
                                    CommonClass._ReceiptDetails.RateDb = Convert.ToDouble(Prate);
                                    CommonClass._ReceiptDetails.BatchIdstr = Batch;
                                    CommonClass._ReceiptDetails.NetAmtDb = qty * Prate;
                                    CommonClass._ReceiptDetails.Vtype = "OS";
                                    CommonClass._ReceiptDetails.InsertReceiptDetails();
                                }
                            }
                            else
                            {
                                Generalfunction.OpCompany = ToDb;
                                CommonClass._Inventory.Vcode = TCode.ToString();
                                CommonClass._Inventory.DCodeStr = Depocode;
                                CommonClass._Inventory.InvDateDt = dtt;
                                CommonClass._Inventory.PcodeStr = ID;
                                CommonClass._Inventory.Os = Balance;
                                CommonClass._Inventory.Batchcode = Batch;
                                CommonClass._Inventory.InsertInventory();

                                /*For Receipt Details*/
                                CommonClass._ReceiptDetails.RcptCodeLng = Convert.ToInt64(TCode);
                                CommonClass._ReceiptDetails.SlNoLng = i + 1;
                                CommonClass._ReceiptDetails.PCodeStr = ID;
                                CommonClass._ReceiptDetails.UnitIdLng = 0;
                                CommonClass._ReceiptDetails.MultiRateIdLng = 0;
                                CommonClass._ReceiptDetails.QtyDb = Balance;
                                CommonClass._ReceiptDetails.SRate = Convert.ToDouble(Srate);
                                CommonClass._ReceiptDetails.RateDb = Convert.ToDouble(Prate);
                                CommonClass._ReceiptDetails.BatchIdstr = Batch;
                                CommonClass._ReceiptDetails.NetAmtDb = qty * Prate;
                                CommonClass._ReceiptDetails.Vtype = "OS";
                                CommonClass._ReceiptDetails.InsertReceiptDetails();
                            }
                       }
                    }
                }
                else
                {
                        Generalfunction.OpCompany = FromDb;
                        Balance = Convert.ToDouble(CommonClass._Inventory.GetStock(" where pcode='" + ID + "' "));
                        if (Balance != 0)
                        {
                            if (RemoveMinusStock == true)
                            {
                                if (Balance > 0)
                                {
                                    Generalfunction.OpCompany = ToDb;
                                    CommonClass._Inventory.Vcode = TCode.ToString();
                                    CommonClass._Inventory.DCodeStr = Depocode;
                                    CommonClass._Inventory.InvDateDt = dtt;
                                    CommonClass._Inventory.PcodeStr = ID;
                                    CommonClass._Inventory.Os = Balance;
                                    CommonClass._Inventory.Batchcode = Batch;
                                    CommonClass._Inventory.InsertInventory();

                                    /*For Receipt Details*/
                                    CommonClass._ReceiptDetails.RcptCodeLng = Convert.ToInt64(TCode);
                                    CommonClass._ReceiptDetails.SlNoLng = i + 1;
                                    CommonClass._ReceiptDetails.PCodeStr = ID;
                                    CommonClass._ReceiptDetails.UnitIdLng = 0;
                                    CommonClass._ReceiptDetails.MultiRateIdLng = 0;
                                    CommonClass._ReceiptDetails.QtyDb = Balance;
                                    CommonClass._ReceiptDetails.SRate = Convert.ToDouble(Srate);
                                    CommonClass._ReceiptDetails.RateDb = Convert.ToDouble(Prate);
                                    CommonClass._ReceiptDetails.BatchIdstr = Batch;
                                    CommonClass._ReceiptDetails.NetAmtDb = qty * Prate;
                                    CommonClass._ReceiptDetails.Vtype = "OS";
                                    CommonClass._ReceiptDetails.InsertReceiptDetails();
                                    TAmount = TAmount + qty * Prate;
                                }
                            }
                            else
                            {
                                Generalfunction.OpCompany = ToDb;
                                CommonClass._Inventory.Vcode = TCode.ToString();
                                CommonClass._Inventory.DCodeStr = Depocode;
                                CommonClass._Inventory.InvDateDt = dtt;
                                CommonClass._Inventory.PcodeStr = ID;
                                CommonClass._Inventory.Os = Balance;
                                CommonClass._Inventory.Batchcode = Batch;
                                CommonClass._Inventory.InsertInventory();

                                /*For Receipt Details*/
                                CommonClass._ReceiptDetails.RcptCodeLng = Convert.ToInt64(TCode);
                                CommonClass._ReceiptDetails.SlNoLng = i + 1;
                                CommonClass._ReceiptDetails.PCodeStr = ID;
                                CommonClass._ReceiptDetails.UnitIdLng = 0;
                                CommonClass._ReceiptDetails.MultiRateIdLng = 0;
                                CommonClass._ReceiptDetails.QtyDb = Balance;
                                CommonClass._ReceiptDetails.SRate = Convert.ToDouble(Srate);
                                CommonClass._ReceiptDetails.RateDb = Convert.ToDouble(Prate);
                                CommonClass._ReceiptDetails.BatchIdstr = Batch;
                                CommonClass._ReceiptDetails.NetAmtDb = qty * Prate;
                                CommonClass._ReceiptDetails.Vtype = "OS";
                                CommonClass._ReceiptDetails.InsertReceiptDetails();
                                TAmount = TAmount + qty * Prate;
                            }
                        }
                    }
                }
                    if (TAmount > 0)
                    {
                        Generalfunction.OpCompany = ToDb;
                        CommonClass._Transactionreceipt.RcptCodeLng = TCode;
                        CommonClass._Transactionreceipt.VNoStr = TCode.ToString();
                        CommonClass._Transactionreceipt.RCptTypeStr = "OS";
                        CommonClass._Transactionreceipt.DcodeStr = Depocode;
                        CommonClass._Transactionreceipt.RcptDateDt = dtt;
                        CommonClass._Transactionreceipt.AMTDb = TAmount;
                        CommonClass._Transactionreceipt.RemarkStr = "";
                        CommonClass._Transactionreceipt.LedCodeCr = Convert.ToString(0);
                        CommonClass._Transactionreceipt.LedCodeDr = Convert.ToString(0);
                        CommonClass._Transactionreceipt.EmpId = Convert.ToString(0);
                        CommonClass._Transactionreceipt.InsertTransactionReceipt();
                        
                    }

            }
        
        public void TransferingTableData()
        {
            Generalfunction.OpCompany = ToDb;
            CommonClass._Dbtask.ExecuteNonQuery("if exists(select * from sys.columns "+
            " where Name = N'lstatu1' and Object_ID = Object_ID(N'tblaccountledger'))"+
            " begin "+
            " alter table tblaccountledger DROP COLUMN lstatus1 "+
            " end ");

            CommonClass._Gen.TableTransferOneDBToOther("TblAccountGroup", FromDb, ToDb);
            
            CommonClass._Gen.TableTransferOneDBToOther("TblAccountLedger", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblAgent", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("tblauditlog", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("Tblbatch", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblCompanyMaster", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("tblcustomerpoint", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblDepartment", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblDepot", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblEmployeemaster", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblInternelTransfer", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblItemCategory", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblItemMaster", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblManufacturer", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("Tblmnusettings", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblMultiRates", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblMultiUnits", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("Tblparamlist", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblProductRate", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("Tblproductsett", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblProductUnits", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblSAGroup", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("Tblsizes", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblsizesDetail", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblSlabmaster", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("tblslnotracking", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("tbltempcontact", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("TblUserDetails", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("tblpartyproject", FromDb, ToDb);
            CommonClass._Gen.TableTransferOneDBToOther("tblarea", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("TblBusinessIssue", FromDb, ToDb);          
//CommonClass._Gen.TableTransferOneDBToOther("TblGeneralLedger", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("TblInventory", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("TblIssuedetails", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("Tblissueproduct", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("Tblissueproductdetail", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("Tblproductsettdetail", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("TblReceiptDetails", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("Tblreceivedproduct", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("Tblreceivedproductdetail", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("TblTransactionReceipt", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("TblTransferDetails", FromDb, ToDb);
            //CommonClass._Gen.TableTransferOneDBToOther("TblUserDetails", FromDb, ToDb);
            DateTime dtt = dtNextyr.Value;
            string AA = dtt.ToString("MM/dd/yyyy") + " 00:00:00";
           //**si
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblBusinessIssue", FromDb, ToDb, " where issuedate >= '"+AA+"' AND issuetype='SI' " );
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblGeneralledger", FromDb, ToDb, " where vdate >= '" + AA + "' and vtype='SI' ");
            //int 
            minvnn = 0;
            minvnn = CommonClass._Gen.MINvoget("TblBusinessIssue where ISSUEDATE >'" + AA + "' AND issuetype='SI'");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("Tblissuedetails", FromDb, ToDb, " where issuecode >= '" + minvnn + "' AND  vtype='SI' ");
            if (minvnn > 0)
            {
                if(chkVOUCHER.Checked==true)
                {
                CommonClass._Gen.updateInvoicenumbers(minvnn, ToDb, "SI");
                }
            }
                
           //**so
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblBusinessIssue", FromDb, ToDb, " where issuedate >= '" + AA + "' AND issuetype='SO' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblGeneralledger", FromDb, ToDb, " where vdate >= '" + AA + "' and vtype='SO' ");
             minvnn = 0;
            minvnn = CommonClass._Gen.MINvoget("TblBusinessIssue where ISSUEDATE >'" + AA + "' AND issuetype='SO' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("Tblissuedetails", FromDb, ToDb, " where issuecode >= '" + minvnn + "' AND  vtype='SO' ");
            if (minvnn > 0)
            {
                if (chkVOUCHER.Checked == true)
                {
                    CommonClass._Gen.updateInvoicenumbers(minvnn, ToDb, "SO");
                }
                }
            //**SQ
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblBusinessIssue", FromDb, ToDb, " where issuedate >= '" + AA + "' AND issuetype='SQ' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblGeneralledger", FromDb, ToDb, " where vdate >= '" + AA + "' and vtype='SQ' ");
             minvnn = 0;
            minvnn = CommonClass._Gen.MINvoget("TblBusinessIssue where ISSUEDATE >'" + AA + "' AND issuetype='SQ' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("Tblissuedetails", FromDb, ToDb, " where issuecode >= '" + minvnn + "' AND  vtype='SQ' ");
            if (minvnn>0)
            {

                if (chkVOUCHER.Checked == true)
                {
                    CommonClass._Gen.updateInvoicenumbers(minvnn, ToDb, "SQ");
                }
            }
            //**PR
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblBusinessIssue", FromDb, ToDb, " where issuedate >= '" + AA + "' AND issuetype='PR' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblGeneralledger", FromDb, ToDb, " where vdate >= '" + AA + "' and vtype='PR' ");
            minvnn = 0;
            minvnn = CommonClass._Gen.MINvoget("TblBusinessIssue where ISSUEDATE >'" + AA + "' AND issuetype='PR' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("Tblissuedetails", FromDb, ToDb, " where issuecode >= '" + minvnn + "' AND  vtype='PR' ");
            if (minvnn > 0)
            {
                if (chkVOUCHER.Checked == true)
                {
                    CommonClass._Gen.updateInvoicenumbers(minvnn, ToDb, "PR");
                }
                
                }

            //-------------------------------------------------------------------
            //*pi
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("Tbltransactionreceipt", FromDb, ToDb, " where recptdate >= '" + AA + "' AND recpttype='PI' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblGeneralledger", FromDb, ToDb, " where vdate >= '" + AA + "' and vtype='PI' ");
            minvnn = 0;
            minvnn = CommonClass._Gen.MINvoget("Tbltransactionreceipt where recptdate >'" + AA + "' AND recpttype='PI' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblRECEIPTDETAILS", FromDb, ToDb, " where recptcode >= '" + minvnn + "' AND  vtype='PI' ");
            if (minvnn > 0)
            {
                if (chkVOUCHER.Checked == true)
                {
                    CommonClass._Gen.updateInvoicenumbers(minvnn, ToDb, "PI");
                }
                }
            //PO
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("Tbltransactionreceipt", FromDb, ToDb, " where recptdate >= '" + AA + "' AND recpttype='PO' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblGeneralledger", FromDb, ToDb, " where vdate >= '" + AA + "' and vtype='PO' ");
            minvnn = 0;
            minvnn = CommonClass._Gen.MINvoget("Tbltransactionreceipt where recptdate >'" + AA + "' AND recpttype='PO' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblRECEIPTDETAILS", FromDb, ToDb, " where recptcode >= '" + minvnn + "' AND  vtype='PO' ");
            if (minvnn > 0)
            {
                if (chkVOUCHER.Checked == true)
                {
                    CommonClass._Gen.updateInvoicenumbers(minvnn, ToDb, "PO");
                }
            }

            //PO
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("Tbltransactionreceipt", FromDb, ToDb, " where recptdate >= '" + AA + "' AND recpttype='SR' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblGeneralledger", FromDb, ToDb, " where vdate >= '" + AA + "' and vtype='SR' ");
            minvnn = 0;
            minvnn = CommonClass._Gen.MINvoget("Tbltransactionreceipt where recptdate >'" + AA + "' AND recpttype='SR' ");
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblRECEIPTDETAILS", FromDb, ToDb, " where recptcode >= '" + minvnn + "' AND  vtype='SR' ");
            if (minvnn > 0)
            {
                if (chkVOUCHER.Checked == true)
                {
                    CommonClass._Gen.updateInvoicenumbers(minvnn, ToDb, "SR");
                }
            }
            //---------------------------------------------------------------
            //R
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblGeneralledger", FromDb, ToDb, " where vdate >= '" + AA + "' and vtype='R' ");
            minvnn = 0;
            minvnn = CommonClass._Gen.MINvoget("TblGeneralledger where Vdate >'" + AA + "' AND Vtype='R' ");
            if (minvnn > 0)
            {
                if (chkVOUCHER.Checked == true)
                {
                    CommonClass._Gen.updateInvoicenumbers(minvnn, ToDb, "R");
                }
            }

            //P
            CommonClass._Gen.TableTransferOneDBToOtherbyDATE("TblGeneralledger", FromDb, ToDb, " where vdate >= '" + AA + "' and vtype='P' ");
            minvnn = 0;
            minvnn = CommonClass._Gen.MINvoget("TblGeneralledger where Vdate >'" + AA + "' AND Vtype='P' ");
            if (minvnn > 0)
            {
                if (chkVOUCHER.Checked == true)
                {
                    CommonClass._Gen.updateInvoicenumbers(minvnn, ToDb, "P");
                }
            }



        }
        public void Nextginitilize()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            FromDb = CommonClass._Dbtask.currentcompany();
            Createcompany();
            ToDb = txtcompanyname.Text;
            Generalfunction.OpCompany = FromDb;
            TransferingAccountBalance();
            TransferingTableData();

            CommonClass._GenF.maxvnoupdates(ToDb);
            CommonClass._GenF.MINVALUEvnoupdates(ToDb);
            if (CHKSTOKTRANSFER.Checked == true)
            {
                TransferingStockBalance();
            }

            //TransferingAccountBalance();

            this.Cursor = System.Windows.Forms.Cursors.Default;
            MessageBox.Show("Successfully Transfer your openings?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("compleated");
           // Application.Restart();
        }
        public void SetdefaultCompanyName()
        {
            txtcompanyname.Text = Generalfunction.OpCompany +  DateTime.Now.Year.ToString() +"To" +DateTime.Now.AddYears(1).Year;
        }
        public void Createcompany()
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            txtcompanyname.Text = txtcompanyname.Text.Replace(" ", "");
            txtcompanyname.Text = txtcompanyname.Text.ToUpper();
           CommonClass. _ComCreate.CompanyCreate(txtcompanyname.Text.Replace(" ", ""), false);

           CommonClass._Nextg.RefreshDB();
           CommonClass._Nextg.RefreshProcedure();
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private bool ValidationFu()
        {
            if (txtcompanyname.Text=="")
            {
                MessageBox.Show("Enter Company Name", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtcompanyname.Focus();
                return false;
            }
            return true;
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.PanelBasedConversion(pnlottom);
                CommonClass._Language.TabBasedConversion(tbgeneral);
                CommonClass._Language.TabBasedConversion(tbaccounts);
                CommonClass._Language.TabBasedConversion(tbmasters);
                //CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.GridHeaderConversion(gridmain);
            }
        }
        private void Frmyearending_Load(object sender, EventArgs e)
            {
            ChangeLanguage();
            temp =CommonClass._Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=103");
            if (temp == "1")
            {
                SBatch = true;
            }
            YearEndingDate = DateTime.Now;
            SetdefaultCompanyName();

            CommonClass._Nextg.FormIcon(this);
        }

        private void txtcompanyname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

        }

        private void chkremoveminusstock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkremoveminusstock.Checked == true)
            {
                RemoveMinusStock = true;
            }
            else
            {
                RemoveMinusStock = false;
            }
        }

        private void CHKSTOKTRANSFER_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKSTOKTRANSFER.Checked == true)
            {
                chkremoveminusstock.Enabled = true;
            }
            else
            {
                chkremoveminusstock.Enabled = false;
                chkremoveminusstock.Checked = false;
                RemoveMinusStock = false;
            }
        }
        
    }
}
