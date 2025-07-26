using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net.sf.saxon.functions;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

using System.Xml;
using ZatcaIntegrationSDK;
using ZatcaIntegrationSDK.APIHelper;
using ZatcaIntegrationSDK.BLL;
using ZatcaIntegrationSDK.HelperContracts;
using ZXing;
using ZXing.Common;
using WindowsFormsApplication2.Interface;

namespace WindowsFormsApplication2
{
    class Clssecondphase
    {


        ClsPHASEtwocompanyprofile _PhaseTwocompanyprof = new ClsPHASEtwocompanyprofile();
        public static string StrInvstatus;
        private Mode mode = Mode.developer;
        public static string Strqrcodesecondphase;
        private string GetPaymentMethod(string StrPaymentMethod)
        {
            //PaymentMeansCode payment method codes
            //10 In cash
            //30 Credit
            //42 Payment to bank account
            //48 Bank card
            //1 Instrument Not defined(Free text)
            string PaymentCode = "";
            if (StrPaymentMethod == "cash")//Cash
                PaymentCode = "10";
            else if (StrPaymentMethod == "credit")//Credit
                PaymentCode = "30";
            else if (StrPaymentMethod == "bank")//Bank
                PaymentCode = "42";
            else if (StrPaymentMethod == "bank Card")//Bank Card
                PaymentCode = "48";
            else if (StrPaymentMethod == "free of charge")//Free of Charge
                PaymentCode = "1";
            else
                PaymentCode = "";
            return PaymentCode;
        }
        private int GetInvoiceType(string StrInvType)
        {
            int InvoiceType = 388;
            if (StrInvType == "Simplified inv")
                InvoiceType = 388;
            else if (StrInvType == "Standerd inv")
                InvoiceType = 388;
            else if (StrInvType == "Simplified debit note")
                InvoiceType = 383;
            else if (StrInvType == "Standerd debit note")
                InvoiceType = 383;
            else if (StrInvType == "Simplified credit note")
                InvoiceType = 381;
            else if (StrInvType == "Standerd credit note")
                InvoiceType = 381;

            return InvoiceType;
        }

        public string GetInvoiceTypeName(string StrInvTypeName)
        {
            string InvoiceTypeName = "0100000";
            if (StrInvTypeName == "Simplified inv")
                InvoiceTypeName = "0200000";
            else if (StrInvTypeName == "Standerd inv")
                InvoiceTypeName = "0100000";
            else if (StrInvTypeName == "Simplified debit note")
                InvoiceTypeName = "0200000";
            else if (StrInvTypeName == "Standerd debit note")
                InvoiceTypeName = "0100000";
            else if (StrInvTypeName == "Simplified credit note")
                InvoiceTypeName = "0200000";
            else if (StrInvTypeName == "Standerd credit note")
                InvoiceTypeName = "0100000";
            return InvoiceTypeName;
        }
        public void FuSend(string StrVno, DateTimePicker DtDate, string StrDisc, string StrTotalamount, DataGridView Gridmain, int InTestingpart, string Ledcode, string vtype, string modeofpay, string saleuid,string Strsivnonaration)
        {

            //this method is not needed in integration (this is just for calculate Amounts in this screen)
            //Calculate();


            UBLXML ubl = new UBLXML();
            Invoice inv = new Invoice();
            ZatcaIntegrationSDK.Result res = new ZatcaIntegrationSDK.Result();

            inv.ID = StrVno; // invoice number in your system example= SME00010

            inv.IssueDate = DtDate.Value.ToString("yyyy-MM-dd"); //invoice issue date with format yyyy-MM-dd example "2023-02-07"
            inv.IssueTime = DtDate.Value.ToString("HH:mm:ss"); // invoice issue date with format HH:mm:ss example "09:32:40"
            //all needed codes for invoiceTypeCode id
            // 388 sales invoice  
            // 383 debit note
            // 381 credit note
            // get invoice type 

            string invocetype = "";
            if (vtype == "SI")
            {
                if (modeofpay.ToLower() == "cash")
                {
                    invocetype = "Simplified inv";
                }
                if (modeofpay.ToLower() == "credit")
                {
                    invocetype = "Standerd inv";
                }
            }
            if (vtype == "SR")
            {
                if (modeofpay.ToLower() == "cash")
                {
                    invocetype = "Simplified credit note";
                }
                if (modeofpay.ToLower() == "credit")
                {
                    invocetype = "Standerd credit note";
                }
            }







            inv.invoiceTypeCode.id = GetInvoiceType(invocetype);



            //GetInvoiceType("SI");
            // inv.invoiceTypeCode.Name based on format NNPNESB
            // NN 01 standard invoice 
            // NN 02 simplified invoice
            // P فى حالة فاتورة لطرف ثالث نكتب 1 فى الحالة الاخرى نكتب 0
            // N فى حالة فاتورة اسمية نكتب 1 وفى الحالة الاخرى نكتب 0
            // E فى حالة فاتورة للصادرات نكتب 1 وفى الحالة الاخرى نكتب 0
            // S فى حالة فاتورة ملخصة نكتب 1 وفى الحالة الاخرى نكتب 0
            // B فى حالة فاتورة ذاتية نكتب 1
            // B فى حالة ان الفاتورة صادرات=1 لايمكن ان تكون الفاتورة ذاتية =1
            // 
            inv.invoiceTypeCode.Name = GetInvoiceTypeName(invocetype);            // GetInvoiceTypeName("SI");
            inv.DocumentCurrencyCode = "SAR"; // Document Currency Code (invoice currency example SAR or USD) 
            inv.TaxCurrencyCode = "SAR";// Tax Currency Code it must be with SAR
            //inv.CurrencyRate = 3.75m; // incase of DocumentCurrencyCode equal any currency code not SAR we must mention CurrencyRate value
            if (inv.invoiceTypeCode.id == 383 || inv.invoiceTypeCode.id == 381)
            {
                // فى حالة ان اشعار دائن او مدين فقط هانكتب رقم الفاتورة اللى اصدرنا الاشعار ليها
                // in case of return sales invoice or debit notes we must mention the original sales invoice number
                InvoiceDocumentReference invoiceDocumentReference = new InvoiceDocumentReference();
                invoiceDocumentReference.ID = CommonClass._Transactionreceipt.getfeildsbyvtype(StrVno, "SIretvno", vtype);
                //invoiceDocumentReference.ID = "Invoice Number: 354; Invoice Issue Date: 2021-02-10";
                invoiceDocumentReference.ID = Strsivnonaration;
                inv.billingReference.invoiceDocumentReferences.Add(invoiceDocumentReference);
                //"Invoice Number: 354; Invoice Issue Date: 2021-02-10"; // mandatory in case of return sales invoice or debit notes




                inv.billingReference.invoiceDocumentReferences.Add(invoiceDocumentReference);
            }


            // هنا ممكن اضيف ال pih من قاعدة البيانات  
            //this is previous invoice hash (the invoice hash of last invoice ) res.InvoiceHash

            // for the first invoice and because there is no previous hash we must write this code "NWZlY2ViNjZmZmM4NmYzOGQ5NTI3ODZjNmQ2OTZjNzljMmRiYzIzOWRkNGU5MWI0NjcyOWQ3M2EyN2ZiNTdlOQ=="
            inv.AdditionalDocumentReferencePIH.EmbeddedDocumentBinaryObject = "NWZlY2ViNjZmZmM4NmYzOGQ5NTI3ODZjNmQ2OTZjNzljMmRiYzIzOWRkNGU5MWI0NjcyOWQ3M2EyN2ZiNTdlOQ==";



            string hashvno = "";
            hashvno = CommonClass._Dbtask.znllString(Convert.ToInt32(StrVno) - 1);

            string hascode = "";
            hascode = CommonClass._Businessissue.getfeildsbyvtype(hashvno, "Hascode", vtype);



            if (hascode == "")
            {
                inv.AdditionalDocumentReferencePIH.EmbeddedDocumentBinaryObject = "NWZlY2ViNjZmZmM4NmYzOGQ5NTI3ODZjNmQ2OTZjNzljMmRiYzIzOWRkNGU5MWI0NjcyOWQ3M2EyN2ZiNTdlOQ==";
            }
            else
            {
                inv.AdditionalDocumentReferencePIH.EmbeddedDocumentBinaryObject = hascode;
            }



            // قيمة عداد الفاتورة
            // Invoice counter (1,2,3,4) this counter must start from 1 for each CSID
            inv.AdditionalDocumentReferenceICV.UUID = Convert.ToInt32(saleuid);  //Int32.Parse("234"); // لابد ان يكون ارقام فقط must be numbers only

            if (inv.invoiceTypeCode.Name.Substring(0, 2) == "01")
            {
                //supply date mandatory only for standard invoices
                // فى حالة فاتورة مبسطة وفاتورة ملخصة هانكتب تاريخ التسليم واخر تاريخ التسليم
                inv.delivery.ActualDeliveryDate = DtDate.Value.ToString("yyyy-MM-dd");
                inv.delivery.LatestDeliveryDate = DtDate.Value.ToString("yyyy-MM-dd"); //"2022-10-23";
            }
            // 
            // بيانات الدفع 
            // اكواد معين
            // اختيارى كود الدفع
            // payment methods mandatory for return invoice and debit notes and optional for invoices
            string paymentcode = GetPaymentMethod(modeofpay.ToLower());//GetPaymentMethod("Cash");
            if (!string.IsNullOrEmpty(paymentcode))
            {
                PaymentMeans paymentMeans = new PaymentMeans();
                paymentMeans.PaymentMeansCode = paymentcode; // optional for invoices - mandatory for return invoice - debit notes
                if (inv.invoiceTypeCode.id == 383 || inv.invoiceTypeCode.id == 381)
                {
                    paymentMeans.InstructionNote = "dameged items"; //the reason of return invoice - debit notes // manatory only for return invoice - debit notes 
                }
                inv.paymentmeans.Add(paymentMeans);
            }

            // بيانات البائع 
            //seller date
            //other identifier for seller like commercial registration number
            inv.SupplierParty.partyIdentification.ID = ClsPHASEtwocompanyprofile.PHcrn;// _PhaseTwocompanyprof.GetspecifField("CRN"); // رقم السجل التجارى الخاض بالبائعCRN number
            //other identifier scheme id example CRN for commercial registration number
            inv.SupplierParty.partyIdentification.schemeID = ClsPHASEtwocompanyprofile.PHschemeID; //_PhaseTwocompanyprof.GetspecifField("CRN");//"CRN"; // رقم السجل التجارى
            //seller street name mandatory
            inv.SupplierParty.postalAddress.StreetName = ClsPHASEtwocompanyprofile.PHStreetName; //_PhaseTwocompanyprof.GetspecifField("PostelCode"); // اجبارى
                                                                                                 //inv.SupplierParty.postalAddress.AdditionalStreetName = ""; // اختيارى
                                                                                                 //seller buliding number mandatory must be 4 digits
            inv.SupplierParty.postalAddress.BuildingNumber = ClsPHASEtwocompanyprofile.PHBuildingNumber; //_PhaseTwocompanyprof.GetspecifField("BuildingNo"); // اجبارى رقم المبنى
                                                                                                         // inv.SupplierParty.postalAddress.PlotIdentification = "9833"; //اختيارى
                                                                                                         //seller city name 
            inv.SupplierParty.postalAddress.CityName = ClsPHASEtwocompanyprofile.PHCityName; //_PhaseTwocompanyprof.GetspecifField("City"); // اسم المدينة
            //seller postal zone must be 5 digits 
            inv.SupplierParty.postalAddress.PostalZone = ClsPHASEtwocompanyprofile.PHPostalZone; //_PhaseTwocompanyprof.GetspecifField("PostelCode"); // الرقم البريدي
            //inv.SupplierParty.postalAddress.CountrySubentity = "Riyadh Region"; // اسم المحافظة او المدينة مثال (مكة) اختيارى
            //seller City Subdivision Name
            inv.SupplierParty.postalAddress.CitySubdivisionName = ClsPHASEtwocompanyprofile.PHCitySubdivisionName; //_PhaseTwocompanyprof.GetspecifField("SubDivision"); // اسم المنطقة او الحى 
            //SA for Saudi it must be SA with seller data
            inv.SupplierParty.postalAddress.country.IdentificationCode = "SA";
            // seller company name
            inv.SupplierParty.partyLegalEntity.RegistrationName = ClsPHASEtwocompanyprofile.PHRegistrationName; //_PhaseTwocompanyprof.GetspecifField("firmname"); // اسم الشركة المسجل فى الهيئة
                                                                                                                //seller vat registration number must be 15 digits and start with 3 and end with 3
            inv.SupplierParty.partyTaxScheme.CompanyID = ClsPHASEtwocompanyprofile.PHCompanyID;//_PhaseTwocompanyprof.GetspecifField("vatnumber");  // رقم التسجيل الضريبي

            //if (inv.invoiceTypeCode.Name == "0100000")
            //{

            // بيانات المشترى

            string CusId = ""; string CusCityName = "";
            string cusschemeId = ""; string CusPostalZone = "";
            string CusStreetName = ""; string CusCitySubdivisionName = "";
            string CusBuildingNumber = ""; string CusIdentificationCode = "";
            string CusRegistrationName = ""; string CusCompanyID = "";

            //if (CommonClass._Ledger.GetspecifField("Agroupid", Ledcode) == "18")
            //{
            //    CusId = Ledcode;
            //   // CusCityName = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("cityy", Ledcode));
            //   // cusschemeId = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("schemeID", Ledcode));
            //   // CusPostalZone = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("postcode", Ledcode));
            //   // CusStreetName = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("StreetName", Ledcode));

            //   ////// CusCitySubdivisionName = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("", Ledcode));

            //   // CusBuildingNumber = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("BuildingNumber", Ledcode));

            //   // CusIdentificationCode = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("IdentificationCode", Ledcode));

            //    CusRegistrationName = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("RegistrationName", Ledcode));
            //    // CusCompanyID = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("CompanyID", Ledcode));



            //    /******************************/
            //    CusCityName = "aaa";
            //    cusschemeId = "aa";
            //    CusPostalZone = "aa";
            //    CusStreetName ="aaa";

            //    CusCitySubdivisionName ="adsdsad";

            //    CusBuildingNumber = "dsad";

            //    CusIdentificationCode ="3123";

            //    CusRegistrationName = "sasaa";
            //    CusCompanyID = "313131";


            //    inv.CustomerParty.partyIdentification.ID = CusId; // رقم السجل التجارى الخاص بالمشترى
            //    inv.CustomerParty.partyIdentification.schemeID = cusschemeId; //رقم السجل التجارى
            //    inv.CustomerParty.postalAddress.StreetName = CusStreetName; // اجبارى
            //                                                                //inv.CustomerParty.postalAddress.AdditionalStreetName = "street name"; // اختيارى
            //    inv.CustomerParty.postalAddress.BuildingNumber = CusBuildingNumber; // اجبارى رقم المبنى
            //                                                                        // inv.CustomerParty.postalAddress.PlotIdentification = "9833"; // اختيارى رقم القطعة
            //    inv.CustomerParty.postalAddress.CityName = CusCityName; // اسم المدينة
            //    inv.CustomerParty.postalAddress.PostalZone = CusPostalZone; // الرقم البريدي
            //                                                                //inv.CustomerParty.postalAddress.CountrySubentity = "Makkah"; // اسم المحافظة او المدينة مثال (مكة) اختيارى
            //    inv.CustomerParty.postalAddress.CitySubdivisionName = CusCitySubdivisionName; // اسم المنطقة او الحى 
            //    inv.CustomerParty.postalAddress.country.IdentificationCode = "SA";
            //    inv.CustomerParty.partyLegalEntity.RegistrationName = CusRegistrationName; // اسم الشركة المسجل فى الهيئة
            //    inv.CustomerParty.partyTaxScheme.CompanyID = CusCompanyID; // رقم التسجيل الضريبي

            //    /////
            //    inv.CustomerParty.partyIdentification.ID = "6218"; // رقم السجل التجارى الخاص بالمشترى
            //    inv.CustomerParty.partyIdentification.schemeID = "CRN"; //رقم السجل التجارى
            //    inv.CustomerParty.postalAddress.StreetName = ""; // اجبارى
            //                                                                 //inv.CustomerParty.postalAddress.AdditionalStreetName = "street name"; // اختيارى
            //    inv.CustomerParty.postalAddress.BuildingNumber = ""; // اجبارى رقم المبنى
            //                                                                     // inv.CustomerParty.postalAddress.PlotIdentification = "9833"; // اختيارى رقم القطعة
            //    inv.CustomerParty.postalAddress.CityName = ""; // اسم المدينة
            //    inv.CustomerParty.postalAddress.PostalZone = ""; // الرقم البريدي
            //                                                                 //inv.CustomerParty.postalAddress.CountrySubentity = "Makkah"; // اسم المحافظة او المدينة مثال (مكة) اختيارى
            //    inv.CustomerParty.postalAddress.CitySubdivisionName = ""; // اسم المنطقة او الحى 
            //    inv.CustomerParty.postalAddress.country.IdentificationCode = "SA";
            //    inv.CustomerParty.partyLegalEntity.RegistrationName = ""; // اسم الشركة المسجل فى الهيئة
            //    inv.CustomerParty.partyTaxScheme.CompanyID =""; // رقم التسجيل الضريبي
            //}


            if (CommonClass._Ledger.GetspecifField("Agroupid", Ledcode) == "18")
            {
                inv.CustomerParty.partyIdentification.ID = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("schemeID", Ledcode)); // رقم السجل التجارى الخاص بالمشترى
                inv.CustomerParty.partyIdentification.schemeID = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("OTHER", Ledcode)); //رقم السجل التجارى
                inv.CustomerParty.postalAddress.StreetName = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("Area", Ledcode)); // اجبارى
                                                                             //inv.CustomerParty.postalAddress.AdditionalStreetName = "street name"; // اختيارى
                inv.CustomerParty.postalAddress.BuildingNumber = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("BuildingNumber", Ledcode)); // اجبارى رقم المبنى
                                                                                 // inv.CustomerParty.postalAddress.PlotIdentification = "9833"; // اختيارى رقم القطعة
                inv.CustomerParty.postalAddress.CityName = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("cityy", Ledcode)); // اسم المدينة
                inv.CustomerParty.postalAddress.PostalZone = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("postcode", Ledcode)); // الرقم البريدي
                                                                             //inv.CustomerParty.postalAddress.CountrySubentity = "Makkah"; // اسم المحافظة او المدينة مثال (مكة) اختيارى
                inv.CustomerParty.postalAddress.CitySubdivisionName = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("CitySubdivisionName", Ledcode)); // اسم المنطقة او الحى 
                inv.CustomerParty.postalAddress.country.IdentificationCode = "SA";
                inv.CustomerParty.partyLegalEntity.RegistrationName = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("RegistrationName", Ledcode)); ; // اسم الشركة المسجل فى الهيئة
                inv.CustomerParty.partyTaxScheme.CompanyID = CommonClass._Dbtask.znllString(CommonClass._Ledger.GetspecifField("TaxregNo", Ledcode)); ;
            }



            //}
            //inv.CustomerParty.contact.Name = "Amr Sobhy";  
            //inv.CustomerParty.contact.Telephone = "0555252";
            //inv.CustomerParty.contact.ElectronicMail = "amr@amr.com";
            //inv.CustomerParty.contact.Note = "notes other notes";
            decimal invoicediscount = 0;
            Decimal.TryParse(StrDisc, out invoicediscount);
            if (invoicediscount > 0)
            {
                //this code incase of there is a discount in invoice level 
                AllowanceCharge allowance = new AllowanceCharge();
                //ChargeIndicator = false means that this is discount
                //ChargeIndicator = true means that this is charges(like cleaning service - transportation)
                allowance.ChargeIndicator = false;
                //write this lines in case you will make discount as percentage
                allowance.MultiplierFactorNumeric = 0; //dscount percentage like 10
                allowance.BaseAmount = 0; // the amount we will apply percentage on example (MultiplierFactorNumeric=10 ,BaseAmount=1000 then AllowanceAmount will be 100 SAR)

                // in case we will make discount as Amount 
                allowance.Amount = invoicediscount; // 
                allowance.AllowanceChargeReasonCode = ""; //discount or charge reason code
                allowance.AllowanceChargeReason = "discount"; //discount or charge reson
                allowance.taxCategory.ID = "S";// كود الضريبة tax code (S Z O E )
                allowance.taxCategory.Percent = 15;// نسبة الضريبة tax percentage (0 - 15 - 5 )
                //فى حالة عندى اكثر من خصم بعمل loop على الاسطر السابقة
                inv.allowanceCharges.Add(allowance);
            }

            decimal payableamount = CommonClass._Dbtask.znull("0");
            Decimal.TryParse(StrTotalamount, out payableamount);
            //this is the invoice total amount (invoice total with vat) and you can set its value with Zero and i will calculate it from sdk
            inv.legalMonetaryTotal.PayableAmount = payableamount;
            // فى حالة فى اكتر من منتج فى الفاتورة هانعمل ليست من invoiceline مثال الكود التالى
            //here we will mention all invoice lines data
            for (int i = 0; i < Gridmain.Rows.Count; i++)
            {
                if (Gridmain.Rows[i].Tag != null)
                {
                    if (Gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        InvoiceLine invline = new InvoiceLine();
                        //Product Quantity
                        invline.InvoiceQuantity = Convert.ToDecimal(CommonClass._Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells["clnqty"].Value));
                        //Product Name
                        invline.item.Name = CommonClass._Dbtask.znllString(Gridmain.Rows[i].Cells["clnitemcode"].Value);

                        if (CommonClass._Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells["clntaxper"].Value) == 0)
                        {
                            //item Tax code
                            invline.item.classifiedTaxCategory.ID = "Z"; // كود الضريبة
                                                                         //item Tax code
                            invline.taxTotal.TaxSubtotal.taxCategory.ID = "Z"; // كود الضريبة
                                                                               //item Tax Exemption Reason Code mentioned in zatca pdf page(32-33)
                            invline.taxTotal.TaxSubtotal.taxCategory.TaxExemptionReasonCode = "VATEX-SA-HEA"; // كود الضريبة
                                                                                                              //item Tax Exemption Reason mentioned in zatca pdf page(32-33)
                            invline.taxTotal.TaxSubtotal.taxCategory.TaxExemptionReason = "Private healthcare to citizen"; // كود الضريبة
                        }
                        else
                        {
                            //item Tax code
                            invline.item.classifiedTaxCategory.ID = "S"; // كود الضريبة
                                                                         //item Tax code
                            invline.taxTotal.TaxSubtotal.taxCategory.ID = "S"; // كود الضريبة
                        }
                        //item Tax percentage
                        invline.item.classifiedTaxCategory.Percent = Convert.ToDecimal(CommonClass._Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells["clntaxper"].Value)); // نسبة الضريبة
                        invline.taxTotal.TaxSubtotal.taxCategory.Percent = Convert.ToDecimal(CommonClass._Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells["clntaxper"].Value)); // نسبة الضريبة
                                                                                                                                                                                 //EncludingVat = false this flag will be false in case you will give me Product Price not including vat
                                                                                                                                                                                 //EncludingVat = true this flag will be true in case you will give me Product Price including vat
                        invline.price.EncludingVat = false;
                        //Product Price
                        invline.price.PriceAmount = Convert.ToDecimal(CommonClass._Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells["clnsrate"].Value));

                        if (CommonClass._Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells["clndiscount"].Value) > 0)
                        {
                            // incase there is discount in invoice line level
                            AllowanceCharge allowanceCharge = new AllowanceCharge();
                            // فى حالة الرسوم incase of charges
                            // allowanceCharge.ChargeIndicator = true;
                            // فى حالة الخصم incase of discount
                            allowanceCharge.ChargeIndicator = false;

                            allowanceCharge.AllowanceChargeReason = "discount"; // سبب الخصم على مستوى المنتج
                                                                                // allowanceCharge.AllowanceChargeReasonCode = "90"; // سبب الخصم على مستوى المنتج
                            allowanceCharge.Amount = Convert.ToDecimal(CommonClass._Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells["clntax"].Value)); // قيم الخصم discount amount or charge amount

                            allowanceCharge.MultiplierFactorNumeric = 0;
                            allowanceCharge.BaseAmount = 0;
                            invline.allowanceCharges.Add(allowanceCharge);
                        }
                        inv.InvoiceLines.Add(invline);
                    }
                }
            }
            //this calculation just for test invoice calculation and you may don't need this lines
            //start
            InvoiceTotal invoiceTotal = ubl.CalculateInvoiceTotal(inv.InvoiceLines, inv.allowanceCharges);
            //TextBox1.Text = invoiceTotal.LineExtensionAmount.ToString("0.00");
            //TextBox3.Text = invoiceTotal.TaxExclusiveAmount.ToString("0.00");
            //TextBox6.Text = invoiceTotal.TaxInclusiveAmount.ToString("0.00");
            //TextBox5.Text = (invoiceTotal.TaxInclusiveAmount - invoiceTotal.TaxExclusiveAmount).ToString("0.00");
            //end

            // here you can pass csid data
            //this is csid or publickey
            //inv.cSIDInfo.CertPem = @"MIIFADCCBKWgAwIBAgITbQAAGw/UXgsmTms9LgABAAAbDzAKBggqhkjOPQQDAjBiMRUwEwYKCZImiZPyLGQBGRYFbG9jYWwxEzARBgoJkiaJk/IsZAEZFgNnb3YxFzAVBgoJkiaJk/IsZAEZFgdleHRnYXp0MRswGQYDVQQDExJQRVpFSU5WT0lDRVNDQTItQ0EwHhcNMjMwOTIxMDgxODAyWhcNMjUwOTIxMDgyODAyWjBcMQswCQYDVQQGEwJTQTEMMAoGA1UEChMDVFNUMRYwFAYDVQQLEw1SaXlhZGggQnJhbmNoMScwJQYDVQQDEx5UU1QtMjA1MDAxMjA5NS0zMDAwMDAxMzUyMjAwMDMwVjAQBgcqhkjOPQIBBgUrgQQACgNCAASbUK/x5nG7tMATY9Z/u60/eKzfGtdM2WbAFe654OPM1Fb1aBj/JEqgSp5dJQtuahldiKPfJ8aCH8I1tN0cbRxBo4IDQTCCAz0wJwYJKwYBBAGCNxUKBBowGDAKBggrBgEFBQcDAjAKBggrBgEFBQcDAzA8BgkrBgEEAYI3FQcELzAtBiUrBgEEAYI3FQiBhqgdhND7EobtnSSHzvsZ08BVZoGc2C2D5cVdAgFkAgETMIHNBggrBgEFBQcBAQSBwDCBvTCBugYIKwYBBQUHMAKGga1sZGFwOi8vL0NOPVBFWkVJTlZPSUNFU0NBMi1DQSxDTj1BSUEsQ049UHVibGljJTIwS2V5JTIwU2VydmljZXMsQ049U2VydmljZXMsQ049Q29uZmlndXJhdGlvbixEQz1leHRnYXp0LERDPWdvdixEQz1sb2NhbD9jQUNlcnRpZmljYXRlP2Jhc2U/b2JqZWN0Q2xhc3M9Y2VydGlmaWNhdGlvbkF1dGhvcml0eTAdBgNVHQ4EFgQU6PKLogVxfkECr0gYpM0CSaBn1m8wDgYDVR0PAQH/BAQDAgeAMIGtBgNVHREEgaUwgaKkgZ8wgZwxOzA5BgNVBAQMMjEtVFNUfDItVFNUfDMtOTVjNjRhZjgtYTI4NS00ZGFlLTg4MDMtYWYwNzNhZmU4ZjBkMR8wHQYKCZImiZPyLGQBAQwPMzAwMDAwMTM1MjIwMDAzMQ0wCwYDVQQMDAQxMTAwMQ4wDAYDVQQaDAVNYWtrYTEdMBsGA1UEDwwUTWVkaWNhbCBMYWJvcmF0b3JpZXMwgeQGA1UdHwSB3DCB2TCB1qCB06CB0IaBzWxkYXA6Ly8vQ049UEVaRUlOVk9JQ0VTQ0EyLUNBKDEpLENOPVBFWkVpbnZvaWNlc2NhMixDTj1DRFAsQ049UHVibGljJTIwS2V5JTIwU2VydmljZXMsQ049U2VydmljZXMsQ049Q29uZmlndXJhdGlvbixEQz1leHRnYXp0LERDPWdvdixEQz1sb2NhbD9jZXJ0aWZpY2F0ZVJldm9jYXRpb25MaXN0P2Jhc2U/b2JqZWN0Q2xhc3M9Y1JMRGlzdHJpYnV0aW9uUG9pbnQwHwYDVR0jBBgwFoAUgfKje3J7vVCjap/x6NON1nuccLUwHQYDVR0lBBYwFAYIKwYBBQUHAwIGCCsGAQUFBwMDMAoGCCqGSM49BAMCA0kAMEYCIQD52GbWVIWpbdu7B4BnDe+fIKlrAxRUjnGtcc8HiKCEDAIhAJqHLuv0Krp5+HiNCB6w5VPXBPhTKbKidRkZHeb2VTJ+";
            //inv.cSIDInfo.PrivateKey = @"MHQCAQEEIFMxGrBBfmGxmv3rAmuAKgGrqnyNQYAfKqr7OVKDzgDYoAcGBSuBBAAKoUQDQgAEm1Cv8eZxu7TAE2PWf7utP3is3xrXTNlmwBXuueDjzNRW9WgY/yRKoEqeXSULbmoZXYij3yfGgh/CNbTdHG0cQQ==";
            //string secretkey = "lHntHtEGWi+ZJtssv167Dy+R64uxf/PTMXg3CEGYfvM=";
            CSIDInfo info = MainSettings.GetCSIDInfo();
            //this keys is CSID information you can generate it from AutoGenerateCSR form
            //this keys you will generate it one time and it will be valid in simulation for 2 years - for production 5 years

            inv.cSIDInfo.CertPem = info.PublicKey;
            inv.cSIDInfo.PrivateKey = info.PrivateKey;
            inv.cSIDInfo.Secret = info.SecretKey;
            string secretkey = info.SecretKey;

            try
            {
                //string g=Guid.NewGuid().ToString();
                //if you need to save xml file true if not false;
                bool savexmlfile = true;
                // this method is used to generate xml file with invoice data 
                //Directory.GetCurrentDirectory() or Directory that you need to save xml file 
                res = ubl.GenerateInvoiceXML(inv, Directory.GetCurrentDirectory(), savexmlfile);
                // res.IsVali must equal true to be ready to send to zatca api
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\n\n" + ex.InnerException.ToString());
            }
            //

            //Registration Code//
            //if (!res.IsValid)
            //{
            //    //
            //    MessageBox.Show(res.ErrorMessage);
            //    return;
            //}
            //Sending modes
            // developer mode (for developers only)
                    if (InTestingpart == 0)
                mode = Mode.Simulation; //simulation mode (for test)
            else if (InTestingpart == 1)
                mode = Mode.Production;//production mode for live
            else
                mode = Mode.developer;

            // zatca call api
            ApiRequestLogic apireqlogic = new ApiRequestLogic(mode, Directory.GetCurrentDirectory(), true);

            InvoiceReportingRequest invrequestbody = new InvoiceReportingRequest();
            invrequestbody.invoice = res.EncodedInvoice;

            //invrequestbody.invoiceHash = GetInvoiceHash("");
            invrequestbody.invoiceHash = res.InvoiceHash;
            invrequestbody.uuid = res.UUID;
            if (InTestingpart == 2)
            {
                ComplianceCsrResponse tokenresponse = new ComplianceCsrResponse();
                string csr = @"-----BEGIN CERTIFICATE REQUEST-----
MIIB5DCCAYoCAQAwVTELMAkGA1UEBhMCU0ExFjAUBgNVBAsMDUVuZ2F6YXRCcmFu
Y2gxEDAOBgNVBAoMB0VuZ2F6YXQxHDAaBgNVBAMME1RTVC0zMDAzMDA4Njg2MDAw
MDMwVjAQBgcqhkjOPQIBBgUrgQQACgNCAARYvqwxwBzinhARQZYQnWBoSr8wMmmw
CdfTSleD+rZoh/NeJMF8reXaBFrMCrlPK0hTRXmCyXuc6nFUfjSvZU/goIHVMIHS
BgkqhkiG9w0BCQ4xgcQwgcEwIgYJKwYBBAGCNxQCBBUTE1RTVFpBVENBQ29kZVNp
Z25pbmcwgZoGA1UdEQSBkjCBj6SBjDCBiTE7MDkGA1UEBAwyMS1UU1R8Mi1UU1R8
My1lZDIyZjFkOC1lNmEyLTExMTgtOWI1OC1kOWE4ZjExZTQ0NWYxHzAdBgoJkiaJ
k/IsZAEBDA8zMDAzMDA4Njg2MDAwMDMxDTALBgNVBAwMBDExMDAxDDAKBgNVBBoM
A1RTVDEMMAoGA1UEDwwDVFNUMAoGCCqGSM49BAMCA0gAMEUCIQDRroaukEGwwRXW
RhOudGrd/OGrcUnnn2ftb6Jk4dDGFgIgaV+sXmaZlKbxR7k/lMhnf/2j95XHDkso
hup1ROPc+cc=
-----END CERTIFICATE REQUEST-----
";
                tokenresponse = apireqlogic.GetComplianceCSIDAPI("12345", csr);
                if (String.IsNullOrEmpty(tokenresponse.ErrorMessage))
                {
                    InvoiceReportingResponse responsemodel = apireqlogic.CallComplianceInvoiceAPI(tokenresponse.BinarySecurityToken, tokenresponse.Secret, invrequestbody);
                    if (responsemodel.IsSuccess)
                    {
                        if (responsemodel.StatusCode == 202)
                        {
                            //save warning message in database to solve for next invoices
                            MessageBox.Show(responsemodel.WarningMessage);
                        }
                        MessageBox.Show(responsemodel.ReportingStatus + responsemodel.ClearanceStatus); //REPORTED
                        Strqrcodesecondphase = res.QRCode;
                        StrInvstatus = responsemodel.ReportingStatus;
                        // PictureBox1.Image = QrCodeImage(res.QRCode, 200, 200);

                    }
                    else
                    {
                        MessageBox.Show(responsemodel.ErrorMessage);
                        StrInvstatus = responsemodel.ErrorMessage;
                    }
                }
                else
                {
                    MessageBox.Show(tokenresponse.ErrorMessage);
                    StrInvstatus = tokenresponse.ErrorMessage;
                }
            }
            else if (InTestingpart == 0|| InTestingpart==1)


            {
                //this code is for simulation and production mode

                if (inv.invoiceTypeCode.Name.Substring(0, 2) == "01")
                {
                    try
                    {
                        // to send standard invoices for clearing
                        //this this the calling of api 
                        InvoiceClearanceResponse responsemodel = apireqlogic.CallClearanceAPI(Utility.ToBase64Encode(inv.cSIDInfo.CertPem), secretkey, invrequestbody);
                        //if responsemodel.IsSuccess = true this means that your xml is successfully sent to zatca 
                        if (responsemodel.IsSuccess)
                        {
                            //if status code =202 it means that xml accespted but with warning 
                            //no need to sent xml again but you must solve that warning messages for the next invoices
                            if (responsemodel.StatusCode == 202)
                            {
                                //save warning message in database to solve for next invoices
                                StrInvstatus = responsemodel.WarningMessage;
                                MessageBox.Show(responsemodel.WarningMessage);

                            }
                            Strqrcodesecondphase = res.QRCode;
                            StrInvstatus = responsemodel.ClearanceStatus;
                            MessageBox.Show(responsemodel.ClearanceStatus); // Cleared
                            MessageBox.Show(responsemodel.QRCode);

                        }
                        else
                        {
                            StrInvstatus = responsemodel.ErrorMessage;
                            MessageBox.Show(responsemodel.ErrorMessage);

                        }
                    }
                    catch (Exception ex)
                    {
                        StrInvstatus = ex.Message;
                        MessageBox.Show(ex.Message.ToString() + "\n\n" + ex.InnerException.ToString());

                    }
                    //  PictureBox1.Image = QrCodeImage(responsemodel.QRCode);
                }
                else
                {
                    //to send simplified invoices for reporting
                    //this this the calling of api 
                    try
                    {
                        string json = JsonConvert.SerializeObject(inv);
                        InvoiceReportingResponse responsemodel = apireqlogic.CallReportingAPI(Utility.ToBase64Encode(inv.cSIDInfo.CertPem), secretkey, invrequestbody);



                   

                    //string json = JsonConvert.SerializeObject(inv);
                    //InvoiceReportingResponse responsemodel = apireqlogic.CallReportingAPI(Utility.ToBase64Encode(inv.cSIDInfo.CertPem), secretkey, invrequestbody);

                    if (responsemodel.IsSuccess)
                    {
                        //if status code =202 it means that xml accespted but with warning 
                        //no need to sent xml again but you must solve that warning messages for the next invoices
                        if (responsemodel.StatusCode == 202)
                        {
                            //save warning message in database to solve for next invoices
                            //responsemodel.WarningMessage
                        }
                        StrInvstatus = responsemodel.ReportingStatus;
                        MessageBox.Show(responsemodel.ReportingStatus);// Reported

                        // PictureBox1.Image = QrCodeImage(res.QRCode);
                    }
                    else
                    {
                        MessageBox.Show(responsemodel.ErrorMessage);
                        StrInvstatus = responsemodel.ErrorMessage;
                    }
                }

                    catch (Exception ex)
                    {
                        Console.WriteLine("API Error: " + ex.Message);
                    }

                }
            }


          


        }
    }
}

