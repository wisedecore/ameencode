using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    
    class ClsLanguage
    {
        string id = "";
        string English = "";
        string Arabic = "";

        public void InsertLanguage()
        {
            object[,] objArg = new object[3, 2]
              {
                {"@id",id},
                {"@English",English},
                {"@Arabic",Arabic}
              };
            CommonClass._Dbtask.ExecuteNonQuery_SP("InsertLanguage", objArg);
            return;
        }
        public void DeleteLanguage()
        {
            try
            {
                
                string qry = "Delete from  TblLanguage";
                CommonClass._Dbtask.ExecuteNonQuery(qry);

                //qry = "DROP PROCEDURE InsertLanguage";
                //CommonClass._Dbtask.ExecuteNonQuery(qry);

                //CommonClass._Paramlist.UpdateParamlist("Language", "0", "English");

                //Application.Restart();

                CommonClass._Language.InsertValuesToTable();
            }
            catch 
            {
                MessageBox.Show("Cannot Update The Language At This Time...", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool IsArabic()
        {

            string lng = CommonClass._Paramlist.GetParamvalue("Language");
            if (lng == "Arabic")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetMax()
        {
            int Max;
            string sql = "Select IsNull(Max(id)+1,1) from TblLanguage";
            Max = Convert.ToInt32(CommonClass._Dbtask.ExecuteScalar(sql));
            return Max;
        }
        public string GetArabicString(string English)
        {
            string Arb;
            English = English.Replace("'", "");
            string Qry = "Select isnull(Arabic,'" + English + "') From TblLanguage Where English = '" + English + "'";
            Arb = CommonClass._Dbtask.ExecuteScalar(Qry);
            if (Arb == "")
            {
              return English;
            }
            else
            {
                return Arb;
            }
        }

        public void insert()
        {
            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "";
            CommonClass._Language.Arabic = "";
            CommonClass._Language.InsertLanguage();
        }

        public void Getlangague(Label Lbl)
        {
            string Arabic = GetArabicString(Lbl.Text);
            Lbl.Text = Arabic;
        }
        public void FormBasedConversion(Form Frm)
        {
            for (int i = 0; i < Frm.Controls.Count; i++)
            {
                if (Frm.Controls[i] is Label)
                {
                    Frm.Controls[i].Text = GetArabicString(Frm.Controls[i].Text);
                }
                if (Frm.Controls[i] is CheckBox)
                {
                    Frm.Controls[i].Text = GetArabicString(Frm.Controls[i].Text);
                }
                if (Frm.Controls[i] is Button)
                {
                    Frm.Controls[i].Text = GetArabicString(Frm.Controls[i].Text);
                }
                if (Frm.Controls[i] is RadioButton)
                {
                    Frm.Controls[i].Text = GetArabicString(Frm.Controls[i].Text);
                }
            }
        }
        public void TreeViewConvertion(TreeView Tree)
        {
            for (int i = 0; i < Tree.Nodes.Count; i++)
            {
                Tree.Nodes[i].Text = GetArabicString(Tree.Nodes[i].Text);
                for (int j = 0; j < Tree.Nodes[i].Nodes.Count; j++)
                {
                    Tree.Nodes[i].Nodes[j].Text = GetArabicString(Tree.Nodes[i].Nodes[j].Text);
                }
                //Tree.Nodes[i].Text = GetArabicString(Tree.Nodes[i]);
            }
        }
        public void GridHeaderConversion(DataGridView Dg)
        {
            for (int i = 0; i < Dg.Columns.Count; i++)
            {
                Dg.Columns[i].HeaderText = GetArabicString(Dg.Columns[i].HeaderText);
            }
        }
        public void TabBasedConversion(TabPage tb)
        {
            tb.Text = GetArabicString(tb.Text);
            for (int i = 0; i < tb.Controls.Count; i++)
            {
                if (tb.Controls[i] is Label)
                {
                    tb.Controls[i].Text = GetArabicString(tb.Controls[i].Text);
                }
                if (tb.Controls[i] is Button)
                {
                    tb.Controls[i].Text = GetArabicString(tb.Controls[i].Text);
                }
                if (tb.Controls[i] is CheckBox)
                {
                    tb.Controls[i].Text = GetArabicString(tb.Controls[i].Text);
                }
                if (tb.Controls[i] is RadioButton)
                {
                    tb.Controls[i].Text = GetArabicString(tb.Controls[i].Text);
                }
            }
        }
        public void GroupBoxConvertion(GroupBox Grp)
        {
            Grp.Text = GetArabicString(Grp.Text);
            for (int i = 0; i < Grp.Controls.Count; i++)
            {
                if (Grp.Controls[i] is Label)
                {
                    Grp.Controls[i].Text = GetArabicString(Grp.Controls[i].Text);
                }
                if (Grp.Controls[i] is CheckBox)
                {
                    Grp.Controls[i].Text = GetArabicString(Grp.Controls[i].Text);
                }
                if (Grp.Controls[i] is Button)
                {
                    Grp.Controls[i].Text = GetArabicString(Grp.Controls[i].Text);
                }
                if (Grp.Controls[i] is RadioButton)
                {
                    Grp.Controls[i].Text = GetArabicString(Grp.Controls[i].Text);
                }
            }
        }
        public void PanelBasedConversion(Panel Pnl)
        {
            for (int i = 0; i < Pnl.Controls.Count; i++)
            {
                if (Pnl.Controls[i] is Label)
                {
                    Pnl.Controls[i].Text = GetArabicString(Pnl.Controls[i].Text);
                }
                if (Pnl.Controls[i] is CheckBox)
                {
                    Pnl.Controls[i].Text = GetArabicString(Pnl.Controls[i].Text);
                }
                if (Pnl.Controls[i] is Button)
                {
                    Pnl.Controls[i].Text = GetArabicString(Pnl.Controls[i].Text);
                }
                if (Pnl.Controls[i] is RadioButton)
                {
                    Pnl.Controls[i].Text = GetArabicString(Pnl.Controls[i].Text);
                }
            }
        }
        public void MenuConversion(MenuStrip Mnu)
        {
            for (int i = 0; i < Mnu.Items.Count; i++)
            {
              /** for Submenus*/
                string Submenu;
               Submenu= Mnu.Items[i].Name;
              // for( int k=0;k<=Mnu
               TextBox tt = new TextBox();
               MenuStrip Smenu = new MenuStrip();
               Smenu.Name = Submenu;
               //foreach (DataRow drmaster in dtDBRoleControl.Rows)
               //{
               //    ProcessDropDown(menuStrip1.Items[i], drmaster["rprevformname"].ToString(), Convert.ToInt32(drmaster["rprevview"]));
               //}
            }
        }
        public void PanelBasedButtunConversion(Panel Pnl)
        {
            for (int i = 0; i < Pnl.Controls.Count; i++)
            {
                if (Pnl.Controls[i] is Button)
                {
                    Pnl.Controls[i].Text = GetArabicString(Pnl.Controls[i].Text);
                }
            }
        }
        public void InsertValues(string English, string Arabic)
        {
            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = English;
            CommonClass._Language.Arabic = Arabic;
            CommonClass._Language.InsertLanguage();
            //CommonClass._Language.InsertValues("", "");
        }
        
        public void InsertValuesToTable()
        {

            //*Headings Code From JAFAR*/
            CommonClass._Language.InsertValues("file", " ملفات ");
            CommonClass._Language.InsertValues("create", " خلق");
            CommonClass._Language.InsertValues("transacitons", " عملية تجارية ");
            CommonClass._Language.InsertValues("view", " رأي ");
            CommonClass._Language.InsertValues("search", " بحث  ");
            CommonClass._Language.InsertValues("report", " أبلغ عن ");
            CommonClass._Language.InsertValues("accounts", " حسابات ");
            CommonClass._Language.InsertValues("tools", " أدوات  ");
            CommonClass._Language.InsertValues("user admin", " مشرف المستخدم  ");
            CommonClass._Language.InsertValues("help", " مساعدة  ");
            CommonClass._Language.InsertValues("Halala", " هللة  ");
            CommonClass._Language.InsertValues("Riyal", " ريال  ");
            //jj


            //*Set product and finished product CODE FROM JAFAR.T*/
            CommonClass._Language.InsertValues("id", " هوية ");
            CommonClass._Language.InsertValues("finished product", " منتج منتهي ");
            CommonClass._Language.InsertValues("labour charge", " تهمة العمالة  ");
            CommonClass._Language.InsertValues("sl", " مسلسل  ");

            CommonClass._Language.InsertValues("batch", " الباركود  ");
            CommonClass._Language.InsertValues("qty", " كمية  ");
            CommonClass._Language.InsertValues("rate", " معدل  ");
            CommonClass._Language.InsertValues("save", " حفظ ");

            CommonClass._Language.InsertValues("clear", " واضح  ");
            CommonClass._Language.InsertValues("close", " أغلق  ");
            CommonClass._Language.InsertValues("vno", " رقم القسيمة ");

            CommonClass._Language.InsertValues("Tailor", "خياط");
            

            CommonClass._Language.InsertValues("date", " تاريخ ");
            CommonClass._Language.InsertValues("packing date", " تاريخ التعبئة ");
            CommonClass._Language.InsertValues("narration/order details", " ملحوظة / ترتيب التفاصيل ");
            CommonClass._Language.InsertValues("fill from sett product", " ملء  ");

            CommonClass._Language.InsertValues("fill", " ملء  ");
            CommonClass._Language.InsertValues("setproduct", " تعيين المنتج ");
            CommonClass._Language.InsertValues("to depo", " إلى ديبو ");

            CommonClass._Language.InsertValues("finished materials", " فينيش المواد ");
            CommonClass._Language.InsertValues("itemcode", " رمز الصنف  ");
            CommonClass._Language.InsertValues("batchcode", " الباركود ");

            CommonClass._Language.InsertValues("from depo", " من ديبو ");
            CommonClass._Language.InsertValues("cost factor", " عامل التكلفة  ");
            CommonClass._Language.InsertValues("packed material cost", " معبأة تكلفة المواد ");
            CommonClass._Language.InsertValues("raw material cost", " تكلفة المواد الخام ");

            CommonClass._Language.InsertValues("srate", " معدل المبيعات  ");
            CommonClass._Language.InsertValues("crate", " معدل التكلفة ");
            CommonClass._Language.InsertValues("prate", " سعر الشراء ");

            CommonClass._Language.InsertValues("       Sales Order INVOICE", "فاتورة طلب المبيعات");


            CommonClass._Language.InsertValues("       Sales INVOICE", "فاتورة المبيعات");

            CommonClass._Language.InsertValues("       Sales Return INVOICE", "فاتورة إرجاع المبيعات");


            // For Sales...

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "Narration";
            CommonClass._Language.Arabic = "ملحوظة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "cooly/other expense";
            CommonClass._Language.Arabic = " نفقات أخرى";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "cash discount";
            CommonClass._Language.Arabic = " الخصم النقدي";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "invoice discount";
            CommonClass._Language.Arabic = " خصم الفاتورة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "total.qty";
            CommonClass._Language.Arabic = " الكمية الإجمالية";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "total.free qty";
            CommonClass._Language.Arabic = " مجموع كمية الحرة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "discount(total)";
            CommonClass._Language.Arabic = " إجمالي الخصم";
            CommonClass._Language.InsertLanguage();

            //CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            //CommonClass._Language.English = "(+/-)round off";
            //CommonClass._Language.Arabic = "";
            //CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "print while saving";
            CommonClass._Language.Arabic = " الطباعة أثناء الحفظ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "show preview";
            CommonClass._Language.Arabic = " عرض المعاينة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "print confirmation";
            CommonClass._Language.Arabic = " تأكيد الطباعة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "recieved amount";
            CommonClass._Language.Arabic = " تلقى مبلغ من المال ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "amount";
            CommonClass._Language.Arabic = " مبلغ من المال";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "item disc";
            CommonClass._Language.Arabic = " البند الخصم";
            CommonClass._Language.InsertLanguage();


            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "gross";
            CommonClass._Language.Arabic = " إجمالي";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "tax";
            CommonClass._Language.Arabic = " ضريبة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "bill discount";
            CommonClass._Language.Arabic = " خصم الفاتورة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "other/exp(cooly)";
            CommonClass._Language.Arabic = " نفقات أخرى";
            CommonClass._Language.InsertLanguage();

            //CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            //CommonClass._Language.English = "";
            //CommonClass._Language.Arabic = "";
            //CommonClass._Language.InsertLanguage();

            //CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            //CommonClass._Language.English = "";
            //CommonClass._Language.Arabic = "";
            //CommonClass._Language.InsertLanguage();

            //For Purchase

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "tot.free";
            CommonClass._Language.Arabic = " مجموع مجانا";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "tot.amount";
            CommonClass._Language.Arabic = " المبلغ الإجمالي";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "tot.tax";
            CommonClass._Language.Arabic = " مجموع الضريبة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "item disc";
            CommonClass._Language.Arabic = " البند الخصم";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "tot.disc";
            CommonClass._Language.Arabic = " إجمالي الخصم";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "tot.CRate";
            CommonClass._Language.Arabic = " التكلفة الإجمالية";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "tot.gross";
            CommonClass._Language.Arabic = " المجموع الإجمالي ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "print 1by 1";
            CommonClass._Language.Arabic = " طباعة واحدا تلو الآخر ";
            CommonClass._Language.InsertLanguage();

            //CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            //CommonClass._Language.English = "";
            //CommonClass._Language.Arabic = "";
            //CommonClass._Language.InsertLanguage();

            //CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            //CommonClass._Language.English = "";
            //CommonClass._Language.Arabic = "";
            //CommonClass._Language.InsertLanguage();

            //For Menus

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "create company";
            CommonClass._Language.Arabic = " إنشاء الشركة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "delete company";
            CommonClass._Language.Arabic = " حذف الشركة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "software settings";
            CommonClass._Language.Arabic = " إعدادات البرامج";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "company profile";
            CommonClass._Language.Arabic = " ملف الشركة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "edit window";
            CommonClass._Language.Arabic = " تحرير الإطار";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "exit";
            CommonClass._Language.Arabic = " أغلق";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "item create";
            CommonClass._Language.Arabic = " عنصر إنشاء";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "item category";
            CommonClass._Language.Arabic = " مجموعة العناصر";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "customer";
            CommonClass._Language.Arabic = " زبون";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "supplier";
            CommonClass._Language.Arabic = " المورد";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "employee";
            CommonClass._Language.Arabic = " موظف";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "agent";
            CommonClass._Language.Arabic = " وكيل";
            CommonClass._Language.InsertLanguage();

            //CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            //*CommonClass._Language.English = "ledger";
            //CommonClass._Language.Arabic = "";
            //CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "ledger group";
            CommonClass._Language.Arabic = " مجموعة دفتر الأستاذ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "stock area";
            CommonClass._Language.Arabic = " منطقة الأسهم";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "contacts";
            CommonClass._Language.Arabic = " جهات الاتصال";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "price codesett";
            CommonClass._Language.Arabic = " مجموعة رمز السعر";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "party project";
            CommonClass._Language.Arabic = " مشروع";//only wrd project
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "voucher type";
            CommonClass._Language.Arabic = " نوع القسيمة";//wrd coupon type
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "commission slab";
            CommonClass._Language.Arabic = " عمولة لوح";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "party area";
            CommonClass._Language.Arabic = " منطقة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "discount slab";
            CommonClass._Language.Arabic = " خصملوح ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "manufacturer";
            CommonClass._Language.Arabic = " الصانع";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "sale";
            CommonClass._Language.Arabic = " مبيعات ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "services";
            CommonClass._Language.Arabic = " خدمات";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "pos";
            CommonClass._Language.Arabic = " نقطة المبيعات ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "sales quatation";
            CommonClass._Language.Arabic = " مبيعات  اقتباس ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "sales order";
            CommonClass._Language.Arabic = " طلب المبيعات";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "purchase";
            CommonClass._Language.Arabic = " الشرائية";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = " purchase return";
            CommonClass._Language.Arabic = " الشرائية  إرجاع ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "purchase order";
            CommonClass._Language.Arabic = " أمر شراء ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "receipt ";
            CommonClass._Language.Arabic = " إيصال ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "cheque receipt";
            CommonClass._Language.Arabic = " تحقق من استلام ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "payment";
            CommonClass._Language.Arabic = " المدفوعات";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "cheque payment";
            CommonClass._Language.Arabic = " تحقق المدفوعات ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "debit note";
            CommonClass._Language.Arabic = " مدين  ملاحظات";//tie two wrds
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "credit note";
            CommonClass._Language.Arabic = " ملاحظات الائتمان ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "journal receipt";
            CommonClass._Language.Arabic = " إيصال دفتر اليومية";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "contra entry";
            CommonClass._Language.Arabic = " كونترا الإدخالات";//wrd entries
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "opening stock";
            CommonClass._Language.Arabic = " افتتاح  مخزون";// tie two words
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "stock transfer";
            CommonClass._Language.Arabic = " نقل  مخزون";//tie two words
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "deliverynote";
            CommonClass._Language.Arabic = " مذكرة تسليم";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "deliverynote return";
            CommonClass._Language.Arabic = " مذكرات التسليم  إرجاع";// tie two words
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "job card";
            CommonClass._Language.Arabic = " بطاقة عمل ";//wrd  bussines card
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "customer profile";
            CommonClass._Language.Arabic = "  زبون  الشخصي ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "repacking";
            CommonClass._Language.Arabic = " إعادة التعبئة ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "physical stock";
            CommonClass._Language.Arabic = " المخزونات المادية ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "waranty bill";
            CommonClass._Language.Arabic = " فواتير  ضمان ";//wrd guaranty bill
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "daily expence";
            CommonClass._Language.Arabic = " المصروف اليومي ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "show items";
            CommonClass._Language.Arabic = " عرض العناصر";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "show customers";
            CommonClass._Language.Arabic = " عرض العملاء";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "show suppliers";
            CommonClass._Language.Arabic = " عرض الموردين";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "sett product";
            CommonClass._Language.Arabic = " تعيين المنتج";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "finish product";
            CommonClass._Language.Arabic = " الانتهاء من المنتج";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "item search";
            CommonClass._Language.Arabic = " عنصر البحث";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "stock report";
            CommonClass._Language.Arabic = " مخزون  أبلغ عن";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "sales report";
            CommonClass._Language.Arabic = " تقرير المبيعات";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "purchase report";
            CommonClass._Language.Arabic = " تقرير الشراء";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "ledger report";
            CommonClass._Language.Arabic = " تقرير دفتر الأستاذ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "stock transfer";
            CommonClass._Language.Arabic = " نقل  مخزون";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "quick report";
            CommonClass._Language.Arabic = " تقرير سريع";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "cash book";
            CommonClass._Language.Arabic = " دفتر النقدية";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "cash gadjet";
            CommonClass._Language.Arabic = " نافذة نقدية";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "qplex profitloss";
            CommonClass._Language.Arabic = " الربح والخسارة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "qplexpl";
            CommonClass._Language.Arabic = " الربح والخسارة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "main report";
            CommonClass._Language.Arabic = " التقرير الرئيسي";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "stock book";
            CommonClass._Language.Arabic = " كتاب الأسهم";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "reorder report";
            CommonClass._Language.Arabic = " إعادة ترتيب التقرير";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "expiry report";
            CommonClass._Language.Arabic = " تقرير انتهاء الصلاحية";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "cheque report";
            CommonClass._Language.Arabic = " تقرير الاختيار";//not crrct word
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "day book";
            CommonClass._Language.Arabic = " كتاب اليوم ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "trial balance";
            CommonClass._Language.Arabic = " ميزان المراجعة";
            CommonClass._Language.InsertLanguage();


            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "balancesheet";
            CommonClass._Language.Arabic = " ورقة التوازن";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "profit and loss account";
            CommonClass._Language.Arabic = " حساب الربح والخسارة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "import";
            CommonClass._Language.Arabic = " استيراد";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "year end";
            CommonClass._Language.Arabic = " نهاية العام";
            CommonClass._Language.InsertLanguage();
            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "command window";
            CommonClass._Language.Arabic = " نافذة الأمر";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "calculator";
            CommonClass._Language.Arabic = " آلة حاسبة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "db transfering";
            CommonClass._Language.Arabic = " بنقلها db";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "price updater";
            CommonClass._Language.Arabic = " سعر التحديث";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "software tools";
            CommonClass._Language.Arabic = " أدوات البرمجيات";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "refresh";
            CommonClass._Language.Arabic = " تحديث";//word update	
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "print barcode sheet";
            CommonClass._Language.Arabic = " طباعة ورقة الباركود";
            CommonClass._Language.InsertLanguage();

            //CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            //CommonClass._Language.English = "";
            //CommonClass._Language.Arabic = "";
            //CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "backup and restore";
            CommonClass._Language.Arabic = " النسخ الاحتياطي واستعادة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "transfer window";
            CommonClass._Language.Arabic = " شكل  نقل";//tie  2 word	
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "label printing";
            CommonClass._Language.Arabic = " طباعة الملصقات";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "sms";
            CommonClass._Language.Arabic = " خدمة الرسائل القصيرة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "item search";
            CommonClass._Language.Arabic = " بحث البند";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "add remainder";
            CommonClass._Language.Arabic = " تذكر ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "attendence";
            CommonClass._Language.Arabic = " حضور";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "product transfering";
            CommonClass._Language.Arabic = " نقل المنتج";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "dress making";
            CommonClass._Language.Arabic = " يصنع فستان";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "electric mechine";
            CommonClass._Language.Arabic = " آلة كهربائية";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "invoice design dotmetrix";
            CommonClass._Language.Arabic = " فاتورة تصميم دوتميتريكس";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "user groups";
            CommonClass._Language.Arabic = " مجموعات المستخدمين";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "new user";
            CommonClass._Language.Arabic = " مستخدم جديد";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "change password";
            CommonClass._Language.Arabic = " تغيير كلمة السر";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "logout";
            CommonClass._Language.Arabic = " الخروج";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "audit log";
            CommonClass._Language.Arabic = " سجل التدقيق";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "toolbar";
            CommonClass._Language.Arabic = " شريط الأدوات";
            CommonClass._Language.InsertLanguage();
            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "status bar";
            CommonClass._Language.Arabic = " شريط الحالة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "&About ... ...";
            CommonClass._Language.Arabic = " حول";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "registration";
            CommonClass._Language.Arabic = " التسجيل";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "cash";
            CommonClass._Language.Arabic = " السيولة النقدية ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "total";
            CommonClass._Language.Arabic = " المبلغ الإجمالي ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "balance";
            CommonClass._Language.Arabic = " توازن  ";
            CommonClass._Language.InsertLanguage();
               
            //Balance words
            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "items";
            CommonClass._Language.Arabic = " بند";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "backup";
            CommonClass._Language.Arabic = " النسخ الاحتياطي ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "wholesale";
            CommonClass._Language.Arabic = " بالجملة";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "sales";
            CommonClass._Language.Arabic = " مبيعات";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "report";
            CommonClass._Language.Arabic = " أبلغ عن";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "edit";
            CommonClass._Language.Arabic = " تصحيح";
            CommonClass._Language.InsertLanguage();

            //CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            //CommonClass._Language.English = "ledger";
            //*CommonClass._Language.Arabic = "";
            //CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "search";
            CommonClass._Language.Arabic = " بحث";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "tot.qty";
            CommonClass._Language.Arabic = " الكمية الإجمالية";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "cooly/other exp";
            CommonClass._Language.Arabic = " نفقات أخرى ";
            CommonClass._Language.InsertLanguage();
            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "stock in hand";
            CommonClass._Language.Arabic = " المخزون المتوفر ";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "\r\nEmployee";
            CommonClass._Language.Arabic = " موظف";
            CommonClass._Language.InsertLanguage();

            CommonClass._Language.id = CommonClass._Language.GetMax().ToString();
            CommonClass._Language.English = "Qplex Search";
            CommonClass._Language.Arabic = " عنصر البحث";
            CommonClass._Language.InsertLanguage();


            CommonClass._Language.InsertValues("item name", " اسم العنصر");

            CommonClass._Language.InsertValues("item code", " رمز الصنف");

            CommonClass._Language.InsertValues("item class", " البند كلاس");

            CommonClass._Language.InsertValues("p.rate", " سعر الشراء");

            CommonClass._Language.InsertValues("s.rate", " معدل المبيعات");

            CommonClass._Language.InsertValues("profit(%)", " الأرباح");

            CommonClass._Language.InsertValues("wrate", " معدل الجملة");

            CommonClass._Language.InsertValues("mrp", " أقصى سعر التجزئة");

            CommonClass._Language.InsertValues("active", " صالح للإستعمال");

            CommonClass._Language.InsertValues("unit", " وحدة ");

            CommonClass._Language.InsertValues("stock", " مخزون");

            CommonClass._Language.InsertValues("rack", " رف");

            CommonClass._Language.InsertValues("reorder", " مخزون  الحد الأدنى");// tie 2 wrds

            CommonClass._Language.InsertValues("agent commission", " عمولة  وكيل ");// tie 2 wrds

            CommonClass._Language.InsertValues("description", " الوصف ");

            CommonClass._Language.InsertValues("second language", " اللغة الثانية ");

            CommonClass._Language.InsertValues("discount", " خصم ");

            CommonClass._Language.InsertValues("production report", " تقرير الإنتاج ");

            CommonClass._Language.InsertValues("stock transfer report", " تقرير نقل المخزون ");

            CommonClass._Language.InsertValues("analysis report", " تقرير التحليل ");

            CommonClass._Language.InsertValues("daybook", " كتاب اليوم");

            CommonClass._Language.InsertValues("balance sheet", " ورقة التوازن");

            CommonClass._Language.InsertValues("vno", " رقم القسيمة");

            CommonClass._Language.InsertValues("credit ledger", " دفتر الأستاذ");

            CommonClass._Language.InsertValues("date", " تاريخ");

            CommonClass._Language.InsertValues("slno", " رقم سري  ");

            CommonClass._Language.InsertValues("ledger name", " اسم دفتر الأستاذ");

            CommonClass._Language.InsertValues("note", " ملحوظة");

            CommonClass._Language.InsertValues("ref no", " رقم المرجع");

            CommonClass._Language.InsertValues("inventory report", " تقرير المخزونات");

            CommonClass._Language.InsertValues("transactional report", " تقرير المعاملات");

            CommonClass._Language.InsertValues("datareview report", " تقرير داتاريفيو");

            CommonClass._Language.InsertValues("name", " اسم");

            CommonClass._Language.InsertValues("alias name", " اسم مستعار");

            CommonClass._Language.InsertValues("a/c group", " مجموعات الحساب");

            CommonClass._Language.InsertValues("opening balance", " الرصيد الافتتاحي");

            CommonClass._Language.InsertValues("use card", " استخدام بطاقة ");

            CommonClass._Language.InsertValues("address", " العنوان");

            CommonClass._Language.InsertValues("phone", " هاتف");

            CommonClass._Language.InsertValues("mobile", " التليفون المحمول");

            CommonClass._Language.InsertValues("disc  (%)", " خصم ٪");

            CommonClass._Language.InsertValues("tin no", " رقم الفاتورة الضريبية");

            CommonClass._Language.InsertValues("email", " البريد الإلكتروني");

            CommonClass._Language.InsertValues("area", " منطقة");

            CommonClass._Language.InsertValues("credit days", " أيام الائتمان");

            CommonClass._Language.InsertValues("credit limit", " الحد الائتماني");

            CommonClass._Language.InsertValues("other", " الآخرين");

            CommonClass._Language.InsertValues("commission", " عمولة");

            CommonClass._Language.InsertValues("backup", " دعم ");

            CommonClass._Language.InsertValues("restore", " استعادة");

            CommonClass._Language.InsertValues("debit ledger", " دفتر الأستاذ ");

            CommonClass._Language.InsertValues("employee", " موظف ");

            CommonClass._Language.InsertValues("emp.code", " رمز الموظف ");

            CommonClass._Language.InsertValues("sex", " جنس ");

            CommonClass._Language.InsertValues("male", " الذكر ");

            CommonClass._Language.InsertValues("female", " إناثا ");

            CommonClass._Language.InsertValues("department", " قسم  ");

            CommonClass._Language.InsertValues("date of joining", " تاريخ الانضمام ");

            CommonClass._Language.InsertValues("active employee", " موظف نشط ");

            CommonClass._Language.InsertValues("salary", " راتب ");

            CommonClass._Language.InsertValues("telephone", " هاتف ");

            CommonClass._Language.InsertValues("passport no", " ");

            CommonClass._Language.InsertValues("visa no", " رقم الفيزا ");

            CommonClass._Language.InsertValues("payment.mode", " طريقة الدفع ");

            CommonClass._Language.InsertValues("Opening Cash", "الافتتاح");
            CommonClass._Language.InsertValues("Opening Bank", " افتتاح البنك");
            CommonClass._Language.InsertValues("Total Purchase", " إجمالي الشراء");
            CommonClass._Language.InsertValues("Cash Purchase", " شراء نقدا");
            CommonClass._Language.InsertValues("Credit", "تنسب إليه");

            CommonClass._Language.InsertValues("CREDIT", "(دائن)");


            CommonClass._Language.InsertValues("Purchase Return", "عودة شراء");
            CommonClass._Language.InsertValues("Total Sales Tax", "إجمالي ضريبة المبيعات");
            CommonClass._Language.InsertValues("Total Purchase Tax", "إجمالي ضريبة الشراء");
            CommonClass._Language.InsertValues("Sales Tax-Purchase Tax", "ضريبة  المبيعات - ضريبة الشراء");
            CommonClass._Language.InsertValues("Total Gross Sale", "إجمالي البيع الإجمالي");

            CommonClass._Language.InsertValues("Total Gross Purchase", "إجمالي إجمالي الشراء");
            CommonClass._Language.InsertValues("Total Gross Purchase-sales", "إجمالي مبيعات الشراء الإجمالية");
            CommonClass._Language.InsertValues("Total Sale", "إجمالي البيع");
            CommonClass._Language.InsertValues("Total Mada", " مجموع مدى");
            CommonClass._Language.InsertValues("Total Visa/Master", "إجمالي التأشيرة / الماجستير");

            CommonClass._Language.InsertValues("Total Cash Sale", "إجمالي البيع النقدي");
            CommonClass._Language.InsertValues("Sales Credit", " ائتمان المبيعات");
            CommonClass._Language.InsertValues("Sales return", "عائد المبيعات");
            CommonClass._Language.InsertValues("Payment", " قسط");
            CommonClass._Language.InsertValues("Receipt", "إيصال");

            CommonClass._Language.InsertValues("Bank Balance", "رصيد البنك");
            CommonClass._Language.InsertValues("Transaction Balance", "رصيد المعاملات");
            CommonClass._Language.InsertValues("Total cash balance", "إجمالي الرصيد النقدي");
            CommonClass._Language.InsertValues("Bank to Cash", "إجمالي الرصيد النقدي");
            CommonClass._Language.InsertValues("Cash to Bank", "نقدا للبنك");
            CommonClass._Language.InsertValues("Customers remaining Amount", "المبلغ المتبقي للعملاء");
            CommonClass._Language.InsertValues("Supplier remaining Amount", "المبلغ المتبقي للمورد");

            CommonClass._Language.InsertValues("create", " خلق  ");
            CommonClass._Language.InsertValues("visa no", " رقم الفيزا ");
            CommonClass._Language.InsertValues("suppliers", " الموردين ");
            CommonClass._Language.InsertValues("units", " وحدة ");
            CommonClass._Language.InsertValues("commision slab", " لوح  عمولة  ");
            CommonClass._Language.InsertValues("area slab", " لوح  منطقة ");
            CommonClass._Language.InsertValues("transactions", " المعاملات ");
            CommonClass._Language.InsertValues("sales return", " عائد المبيعات ");
            CommonClass._Language.InsertValues("delivery note", " مذكرة تسليم ");
            CommonClass._Language.InsertValues("purchase return", " الشرائية ");
            CommonClass._Language.InsertValues("cash receipt", "  إيصال السيولة النقدية  ");
            CommonClass._Language.InsertValues("cash payment", " دفع نقدا  ");
            CommonClass._Language.InsertValues("journal receipt", " إيصال دفتر اليومية  ");
            CommonClass._Language.InsertValues("journal payment", " دفع دفتر اليومية  ");
            CommonClass._Language.InsertValues("ledger", " حسابات  ");
            
            CommonClass._Language.InsertValues("purchase rate", " سعر الشراء ");
            CommonClass._Language.InsertValues("sale rate", " معدل المبيعات  ");
            CommonClass._Language.InsertValues("from", " من عند ");
            CommonClass._Language.InsertValues("to", " إلى ");
            CommonClass._Language.InsertValues("in and  out stock report", " داخل وخارج تقرير الأسهم ");
            CommonClass._Language.InsertValues("category type", "اكتب الفئة ");
            CommonClass._Language.InsertValues("supplier type", " اكتب المورد ");
            CommonClass._Language.InsertValues("stock value report", " تقرير قيمة الأسهم ");
            CommonClass._Language.InsertValues("item type", " نوع العنصر ");
            CommonClass._Language.InsertValues("supplier type stock", " المورد نوع الأسهم ");
            CommonClass._Language.InsertValues("stock level", "مستوى المخزون  ");
            CommonClass._Language.InsertValues("all", "الكل  ");
            CommonClass._Language.InsertValues("all units", "جميع الوحدات  ");
            CommonClass._Language.InsertValues("&Show(F6)", " رأي  ");
            CommonClass._Language.InsertValues("C&lose", " أغلق ");
            CommonClass._Language.InsertValues("group", " المجمو ");
            CommonClass._Language.InsertValues("groupbase", " قاعدة  المجمو ");
            CommonClass._Language.InsertValues("item base", " قاعد بند ");
            CommonClass._Language.InsertValues("supplier wise", " المورد مقرها ");
            CommonClass._Language.InsertValues("barcode", " الباركود ");
            CommonClass._Language.InsertValues("barcode type", " نوع الباركود  ");
            CommonClass._Language.InsertValues("issue report", " نشر  ");
            CommonClass._Language.InsertValues("received report", " تلقى التقرير   ");
            CommonClass._Language.InsertValues("item status", " حالة العنصر   ");
            CommonClass._Language.InsertValues("all employee", " جميع الموظفين  ");
            CommonClass._Language.InsertValues("from stock area", " منطقة الأسهم  من عند ");
            CommonClass._Language.InsertValues("to stock area", " إلى منطقة الأسهم   ");


            CommonClass._Language.InsertValues("minus stock", " ناقص الأسهم  ");
            CommonClass._Language.InsertValues("zero stock", " مخزون صفر   ");
            CommonClass._Language.InsertValues("select", " يختار  ");
            CommonClass._Language.InsertValues("for", " إلى عن على   ");
            CommonClass._Language.InsertValues("purchase and sales", " الشراء والمبيعات  ");

            CommonClass._Language.InsertValues("normal", " عادي ");
            CommonClass._Language.InsertValues("customer wise", " العملاء على أساس ");
            CommonClass._Language.InsertValues("item wise", " البند القائم ");
            CommonClass._Language.InsertValues("item category wise", " قاعدة  الفئة  بند  ");
            CommonClass._Language.InsertValues("manfacture wise", " قاعدة  الصانع  ");
            CommonClass._Language.InsertValues("salesman wise", " البند  بائع ");
            CommonClass._Language.InsertValues("agent wise", "  قاعدة  وكيل ");
            CommonClass._Language.InsertValues("area wise", " قاعدة  منطقة ");

            CommonClass._Language.InsertValues("more profitable items", " أكثر ربحية البنود ");
            CommonClass._Language.InsertValues("all voucher type", " نوع القسيمة  الكل  ");
            CommonClass._Language.InsertValues("date wise(detail)", " (تفاصيل) قاعدة  تاريخ ");

            CommonClass._Language.InsertValues("date wise(summury)", "( ملخص) قاعدة  تاريخ  ");
            CommonClass._Language.InsertValues("month wise (summury)", " (ملخص) قاعدة شهر  ");
            CommonClass._Language.InsertValues("none", " لا شيء ");
            CommonClass._Language.InsertValues("vtype", "  اكتب v");
            CommonClass._Language.InsertValues("item wise count", " البند قاعدة العد  ");
            CommonClass._Language.InsertValues("item wise value", " البند قيمة الحكمة  ");
            CommonClass._Language.InsertValues("all item", " بند  الكل ");
            CommonClass._Language.InsertValues("item list count", " عد  قائمة البند  ");
            CommonClass._Language.InsertValues("salesman", " بائع ");
            CommonClass._Language.InsertValues("show more profitable items", " عرض أكثر ربحية البنود ");
            CommonClass._Language.InsertValues("show item discounts", " البند الخصم  رأي ");

            CommonClass._Language.InsertValues("mode of payment", " طريقة الدفع ");
            CommonClass._Language.InsertValues("category", " الفئة ");
            CommonClass._Language.InsertValues("sales tax", " ضريبة المبيعات ");
            CommonClass._Language.InsertValues("sales tax summury", " ملخص  ضريبة المبيعات  ");
            CommonClass._Language.InsertValues("mode 1", " الوضع 1 ");
            CommonClass._Language.InsertValues("mode 2", " الوضع 2  ");
            CommonClass._Language.InsertValues("mode 3", " الوضع 3  ");
            CommonClass._Language.InsertValues("mode 4", " الوضع 4 ");
            CommonClass._Language.InsertValues("purchase tax", " ضريبة الشراء  ");


            CommonClass._Language.InsertValues("sum qty", " المبلغ الإجمالي  ");
            CommonClass._Language.InsertValues("detail", " التفاصيل ");
            CommonClass._Language.InsertValues("trail balance as on", " ميزان المراجعة");
            CommonClass._Language.InsertValues("laibilities", " المطلوبات ");
            CommonClass._Language.InsertValues("assets", " الأصول ");
            CommonClass._Language.InsertValues("ledger report", " تقرير دفتر الأستاذ ");
            CommonClass._Language.InsertValues("ledger wise", " قاعدة  الحساب ");
            CommonClass._Language.InsertValues("group wise", " قاعدة  المجموعة ");
            CommonClass._Language.InsertValues("outstanding report", " تقرير المدينين ");
            CommonClass._Language.InsertValues("group wise", " المجموعة ");
            CommonClass._Language.InsertValues("bill wiseprofit", " مشروع قانون الربح الحكيم ");
            CommonClass._Language.InsertValues("bill wise settlement", " فواتير المستوطنات الحكيمة  ");
            CommonClass._Language.InsertValues("payment and receipt", " الدفع والاستلام ");
            CommonClass._Language.InsertValues("select ledger", " حدد دفتر الأستاذ ");
            CommonClass._Language.InsertValues("project name", " اسم المشروع  ");
            CommonClass._Language.InsertValues("all project", " كل المشروع ");
            CommonClass._Language.InsertValues("amount grater", " مبلغ أكبر ");
            CommonClass._Language.InsertValues("summary", " ملخص  ");

            CommonClass._Language.InsertValues("new", " الجديد ");
            CommonClass._Language.InsertValues("delete", " حذف ");
            CommonClass._Language.InsertValues("excel", " إكسل ");
            CommonClass._Language.InsertValues("print", " طباعة ");
            CommonClass._Language.InsertValues("settings", " إعدادات ");

            CommonClass._Language.InsertValues("amount greater", " مبلغ أكبر ");
            CommonClass._Language.InsertValues("select group", " اختر مجموعة  ");


            CommonClass._Language.InsertValues("save(F5)", " حفظ ");
            CommonClass._Language.InsertValues("S.Return", " عائد المبيعات ");

            CommonClass._Language.InsertValues("Total.sales Qty", "إجمالي كمية المبيعات");

            CommonClass._Language.InsertValues("user", " المستعمل");
            CommonClass._Language.InsertValues("freeqty", " كمية مجانية");
            CommonClass._Language.InsertValues("netamount", " المبلغ الإجمالي");
            CommonClass._Language.InsertValues("UID", " المستعمل ");
            CommonClass._Language.InsertValues("refno", " رقم المرجع ");
            CommonClass._Language.InsertValues("party", "شخص");
            CommonClass._Language.InsertValues("TaxAmt", "ضريبة");
            CommonClass._Language.InsertValues("NetAmt", " المبلغ الإجمالي ");
            CommonClass._Language.InsertValues("production", " إنتاج");
            CommonClass._Language.InsertValues("narretion/order details", "ملحوظة");
            CommonClass._Language.InsertValues("fill from sett product", "ملء من مجموعة المنتج ");
            CommonClass._Language.InsertValues("Raw Materials", "مواد أولية");


            CommonClass._Language.InsertValues("TIN", " رقم الفاتورة الضريبية");
            CommonClass._Language.InsertValues("VDate", " تاريخ ");
            CommonClass._Language.InsertValues("Tottal Tax", "مجموع الضريبة");
            CommonClass._Language.InsertValues("0%Taxable", "0٪ خاضع للضريبة");
            CommonClass._Language.InsertValues("total taxable", "إجمالي الضريبة");

            CommonClass._Language.InsertValues("0%Taxable Amt", "0٪ خاضع للضريبة ");
            CommonClass._Language.InsertValues("city", "مدينة ");
            CommonClass._Language.InsertValues("invoice.no", "رقم الفاتورة ");



            CommonClass._Language.InsertValues("item wise agent commission ", " البند حكيم عمولة الوكيل ");
            CommonClass._Language.InsertValues("enable pos ", " تمكين نقطة البيع  ");
            CommonClass._Language.InsertValues("enable payroll", " تمكين الرواتب  ");
            CommonClass._Language.InsertValues("enable party project", " تمكين مشروع الحزب  ");
            CommonClass._Language.InsertValues("single barcode", " الباركود واحد ");
            CommonClass._Language.InsertValues("enable barcode", " تمكين الباركود  ");
            CommonClass._Language.InsertValues("use as barcode ", " استخدام الباركود ");
            CommonClass._Language.InsertValues("decimal", " عدد عشري ");
            CommonClass._Language.InsertValues("currency.deci ", " عشري العملة  ");
            CommonClass._Language.InsertValues("major symbol", "  رمز رئيسي   ");
            CommonClass._Language.InsertValues("minor symbol", " رمز طفيف ");
            CommonClass._Language.InsertValues("stock.deci", " عدد عشري  مخزون ");
            CommonClass._Language.InsertValues("ok ", " حسنا ");
            CommonClass._Language.InsertValues("cancel ", " إلغاء  ");
            CommonClass._Language.InsertValues("apply ", " للتقديم ");
            CommonClass._Language.InsertValues("general settings ", " الاعدادات العامة ");


            CommonClass._Language.InsertValues("Opening", " افتتاح ");
            CommonClass._Language.InsertValues("totalvalue ", " القيمة الإجمالية  ");
            CommonClass._Language.InsertValues("itemname ", " اسم العنصر  ");
            CommonClass._Language.InsertValues("item ", " بند  ");
            CommonClass._Language.InsertValues("sr ", " عوائد المبيعات  ");
            CommonClass._Language.InsertValues("mr", " إيصالات المواد  ");
            CommonClass._Language.InsertValues("ireceipt", " استلام داخلي ");
            CommonClass._Language.InsertValues("ps", " المخزونات المادية ");
            CommonClass._Language.InsertValues("dnr", " تسليم مذكرة العودة ");
            CommonClass._Language.InsertValues("pr", " شراء العوائد ");
            CommonClass._Language.InsertValues("dn", " مذكرة تسليم ");
            CommonClass._Language.InsertValues("iissue", " قضية داخلية  ");
            CommonClass._Language.InsertValues("dmg", " ضرر ");
            CommonClass._Language.InsertValues("free", " حر  ");
            CommonClass._Language.InsertValues("naration ", " ملحوظة ");
            CommonClass._Language.InsertValues("party name", " اسم الحزب ");
            CommonClass._Language.InsertValues("p.amount", " مبلغ الشراء ");
            CommonClass._Language.InsertValues("vno", " رقم القسيمة  ");

            CommonClass._Language.InsertValues("company name ", " اسم الشركة  ");
            CommonClass._Language.InsertValues("save(f5) ", " حفظ  ");
            CommonClass._Language.InsertValues("clear", " واضح  ");
            CommonClass._Language.InsertValues("close", " أغلق ");
            CommonClass._Language.InsertValues("general ", " جنرال لواء  ");
            CommonClass._Language.InsertValues("default settings", " الإعدادات الافتراضية ");
            CommonClass._Language.InsertValues("printer settings", " إعدادات الطابعة ");
            CommonClass._Language.InsertValues("auto backup", " نسخ إحتياطي آلي ");
            CommonClass._Language.InsertValues("show startup", " تظهر بدء التشغيل ");


            CommonClass._Language.InsertValues("enable multirate", " تمكين مولتيرات  ");
            CommonClass._Language.InsertValues("enable multiunit", " وحدة متعددة  مكن ");
            CommonClass._Language.InsertValues("enable tax", " تمكين الضرائب ");
            CommonClass._Language.InsertValues("enable costcenter", " تمكين مركز التكلفة  ");
            CommonClass._Language.InsertValues("serialno tracking", " تتبع الرقم التسلسلي ");
            CommonClass._Language.InsertValues("zero tax amount", " صفر مبلغ الضريبة ");
            CommonClass._Language.InsertValues("first key search", "  البحث عن طريق المفتاح الأول ");
            CommonClass._Language.InsertValues("last key search", " البحث عن طريق المفتاح الأخير ");
            CommonClass._Language.InsertValues("any key search", " البحث عن طريق أي مفتاح ");
            CommonClass._Language.InsertValues("warnings", " تحذيرات ");


            CommonClass._Language.InsertValues("item discount", " البند الخصم ");
            CommonClass._Language.InsertValues("edit salerate", " تحرير معدل بيع ");
            CommonClass._Language.InsertValues("update sale.rate", " تحديث معدل البيع  ");
            CommonClass._Language.InsertValues("focus firstrow", " التركيز الصف الأول ");
            CommonClass._Language.InsertValues("deactive customer(zerobalance)", " إلغاء تنشيط العميل (رصيد صفر) ");
            CommonClass._Language.InsertValues("cash desk", " مكتب النقد  ");
            CommonClass._Language.InsertValues("edit grossamt", " تحرير المبلغ الإجمالي ");
            CommonClass._Language.InsertValues("visible srate", " مرئية معدل المبيعات ");
            CommonClass._Language.InsertValues("save zero rate", " حفظ معدل الصفر  ");

            CommonClass._Language.InsertValues("edit purchaserate", " تحرير معدل الشراء ");
            CommonClass._Language.InsertValues("update purchase.rate", " تحديث سعر الشراء ");
            CommonClass._Language.InsertValues("update mrp", " تحديث التسويق سعر التجزئة ");
            CommonClass._Language.InsertValues("excise duty", " رسوم الاستهلاك ");
            CommonClass._Language.InsertValues("item note1", " البند 1 ");
            CommonClass._Language.InsertValues("item note2", " البند 2 ");
            CommonClass._Language.InsertValues("visible prate", " معدل الشراء مرئية ");
            CommonClass._Language.InsertValues("set sale rate (include tax)", " تعيين معدل بيع (تشمل الضرائب) ");
            CommonClass._Language.InsertValues("billing date", " تاريخ الفواتير  ");
            CommonClass._Language.InsertValues("item expiry date", " البند تاريخ انتهاء الصلاحية");
            CommonClass._Language.InsertValues("editqty", " تحرير الكمية ");
            CommonClass._Language.InsertValues("remove dublicate entry", " إزالة الإدخال المكرر ");
            CommonClass._Language.InsertValues("prefixvno", " رقم القسيمة  البادئات ");


            CommonClass._Language.InsertValues("sales estimation", " تقدير المبيعات ");
            CommonClass._Language.InsertValues("material receipt", " إيصالات المواد  ");
            CommonClass._Language.InsertValues("purchase estimation", " شراء تقدير ");

            CommonClass._Language.InsertValues("StockArea", " مخزون منطقة ");
            CommonClass._Language.InsertValues("Mode of Payment(Purchase)", " طريقة الدفع (الشراء)");
            CommonClass._Language.InsertValues("Mode of Payment(Sales)", " طريقة الدفع (المبيعات)");
            CommonClass._Language.InsertValues("Language", " لغة");


            CommonClass._Language.InsertValues("Negetive Cash", " النقدية السلبية");
            CommonClass._Language.InsertValues("Negetive stock", " سلبي الأسهم");
            CommonClass._Language.InsertValues("Minimum Stock", " الحد الأدنى مخزون");
            CommonClass._Language.InsertValues("Reorder Stock", " إعادة ترتيب الأسهم");
            CommonClass._Language.InsertValues("Maximum Stock", " الحد الأقصى للمخزون");
            CommonClass._Language.InsertValues("Sale rate Less than P.rate", " معدل المبيعات أقل من سعر الشراء");

            CommonClass._Language.InsertValues("Auto Backup", " نسخ إحتياطي آلي");
            CommonClass._Language.InsertValues("Browse", " تصفح");

            CommonClass._Language.InsertValues("Show Stock", " عرض الأسهم");
            CommonClass._Language.InsertValues("Show CashBalance", " إظهار الرصيد النقدي");

            CommonClass._Language.InsertValues("name in home", " الاسم في المنزل");
            CommonClass._Language.InsertValues("Address 1", "1  عنوان");
            CommonClass._Language.InsertValues("Address 2", " 2 عنوان");
            CommonClass._Language.InsertValues("State", " حالة");
            CommonClass._Language.InsertValues("postal Code", " الرمز البريدي");
            CommonClass._Language.InsertValues("telephone No", " رقم هاتف");
            CommonClass._Language.InsertValues("fax", " الفاكس");
            CommonClass._Language.InsertValues("WebSite", " موقع الكتروني");
            CommonClass._Language.InsertValues("Account No", " رقم الحساب");
            CommonClass._Language.InsertValues("Tax 1 No", " ضريبة 1 رقم");
            CommonClass._Language.InsertValues("Tax 2 No", " ضريبة 2 رقم");
            CommonClass._Language.InsertValues("VAT No", " VAT  رقم");
            CommonClass._Language.InsertValues("Country(Currency)", " كونتري (العملة)");
            CommonClass._Language.InsertValues("No of decimal Curr", " عدد عشري، عملة ");
            CommonClass._Language.InsertValues("No of decimal  Stock", " عدد عشري، الأسهم ");
            CommonClass._Language.InsertValues("Finacial Year", " السنة المالية ");
            CommonClass._Language.InsertValues("Tax Applicable", " الضرائب المطبقة");


            CommonClass._Language.InsertValues("Password", " كلمه السر ");
            CommonClass._Language.InsertValues("User Name", " اسم المستخدم ");

            CommonClass._Language.InsertValues("group name", " أسم المجموعة ");
            CommonClass._Language.InsertValues("under", " تحت  ");

            CommonClass._Language.InsertValues("printer", " طابعة ");
            CommonClass._Language.InsertValues("voucher name", " اسم القسيمة  ");
            CommonClass._Language.InsertValues("moble", " التليفون المحمول  ");

            CommonClass._Language.InsertValues("paid date", " تاريخ المدفوعة");
            CommonClass._Language.InsertValues("account", " حسابات");
            CommonClass._Language.InsertValues("bank", " بنك");
            CommonClass._Language.InsertValues("cheque no", " رقم الشيك");
            CommonClass._Language.InsertValues("cheque date", " تاريخ الشيكات");
            CommonClass._Language.InsertValues("status", " الحالة");
            CommonClass._Language.InsertValues("collected date", " تاريخ جمعها");
            CommonClass._Language.InsertValues("chequeno", " رقم الشيك ");
            CommonClass._Language.InsertValues("chq.date", " تاريخ الشيكات");
            CommonClass._Language.InsertValues("Colle.Date", " تاريخ جمعها");
            CommonClass._Language.InsertValues("under voucher", " تحت قسيمة");

            CommonClass._Language.InsertValues("create units", " إنشاء وحدات");
            CommonClass._Language.InsertValues("count", " عد");
            CommonClass._Language.InsertValues("unit name", " إسم الوحدة");

            CommonClass._Language.InsertValues("update arabic", "تحديث العربية");
            CommonClass._Language.InsertValues("quick report", "تقرير سريع");
            CommonClass._Language.InsertValues("stock transfer", "الأسهم نقل");
            CommonClass._Language.InsertValues("summary", "ملخص");
            CommonClass._Language.InsertValues("summury", "ملخص");
            CommonClass._Language.InsertValues("profit", "الأرباح");
            CommonClass._Language.InsertValues("profit%", "الأرباح٪");
            CommonClass._Language.InsertValues("bill", "فواتير");
            CommonClass._Language.InsertValues("bill pending", "فاتورة معلقة");
            CommonClass._Language.InsertValues("fromdepot", "من المستودع");
            CommonClass._Language.InsertValues("todepot", "إلى مستودع");
            CommonClass._Language.InsertValues("vno", "رقم القسيمة");
            CommonClass._Language.InsertValues("show(f6)", "عرض (F6)");

            CommonClass._Language.InsertValues("journal payment", " دفع دفتر اليومية ");
            CommonClass._Language.InsertValues("manfacturer wise ", " الصانع ");
            CommonClass._Language.InsertValues("particulars", " بصفة خاصة ");
            CommonClass._Language.InsertValues("debit", " مدين  ");
            CommonClass._Language.InsertValues("credit", " ائتمان ");
            CommonClass._Language.InsertValues("days", " أيام  ");
            CommonClass._Language.InsertValues("voucher", " إيصال  ");


            CommonClass._Language.InsertValues("discount name", " اسم الخصم  ");
            CommonClass._Language.InsertValues("Discount (%)", " خصم (٪)  ");
            CommonClass._Language.InsertValues("from amount", " كمية  من عند  ");
            CommonClass._Language.InsertValues("to amount", " لكمية  ");
            CommonClass._Language.InsertValues("Commision for", " العمولات ل "); 
            CommonClass._Language.InsertValues("area name", " اسم المنطقة ");
            CommonClass._Language.InsertValues("Commision (%)", " عمولة ٪ ");
            CommonClass._Language.InsertValues("Commision Name", " اسم العمولة ");

            CommonClass._Language.InsertValues("open excel", " فتح التفوق ");
            CommonClass._Language.InsertValues("insert product", " إدراج المنتج  ");

            CommonClass._Language.InsertValues("Insert Opening Stock", " إدراج الافتتاح ");
            CommonClass._Language.InsertValues("update product", " تحديث المنتج ");
            CommonClass._Language.InsertValues("update barcode", " تحديث الباركود ");
            CommonClass._Language.InsertValues("Update  O.P Barcode", " تحديث الباركود الافتتاح ");
            CommonClass._Language.InsertValues("Insert Supplierr", "إدراج المورد  ");
            CommonClass._Language.InsertValues("update srate", "تحديث معدل البيع  ");
            CommonClass._Language.InsertValues("update prate", " تحديث سعر الشراء ");
            CommonClass._Language.InsertValues("Update field", " تحديث الحقل ");

            CommonClass._Language.InsertValues("erase stock", "محو الأسهم ");
            CommonClass._Language.InsertValues("include batch", "وتشمل الدفعة ");
            CommonClass._Language.InsertValues("masters", " سادة ");
            CommonClass._Language.InsertValues("new company name", " اسم الشركة الجديد ");
            CommonClass._Language.InsertValues("year end as on", " نهاية العام ");
            CommonClass._Language.InsertValues("remove minus stock", " إزالة ناقص الأسهم ");
            CommonClass._Language.InsertValues("itemid", " معرف العنصر ");
            CommonClass._Language.InsertValues("Update Srate Base on Size", " تحديث قاعدة معدل البيع ");
            
            CommonClass._Language.InsertValues("update", " تحديث ");

            //CommonClass._Language.InsertValues("b.update", " ");
            CommonClass._Language.InsertValues("reindexing", " إعادة الفهرسة ");
            CommonClass._Language.InsertValues("starting", " ابتداء ");
            CommonClass._Language.InsertValues("taxsettings", " إعداد الضرائب");
            CommonClass._Language.InsertValues("Change Repeated Itemcode", " تغيير المتكررة ");
            CommonClass._Language.InsertValues("update.maxbcode", " تحديث الباركود الأقصى ");
            CommonClass._Language.InsertValues("check multi barcode", " تحقق الباركود متعددة ");
            CommonClass._Language.InsertValues("remove invoice", " إزالة الفاتورة ");
            CommonClass._Language.InsertValues("insert ledger", " إدراج دفتر الأستاذ ");

            CommonClass._Language.InsertValues("reorder", " إعادة الطلب");
            CommonClass._Language.InsertValues("category", " الفئة ");
            CommonClass._Language.InsertValues("from date", " من التاريخ ");
            CommonClass._Language.InsertValues("to date", " تاريخ");
            CommonClass._Language.InsertValues("select supplier", " حدد المورد");
            CommonClass._Language.InsertValues("search", " بحث ");
            CommonClass._Language.InsertValues("batch code", " رمز الدفعة ");
            CommonClass._Language.InsertValues("ex.date", " تاريخ انتهاء الصلاحية ");
            CommonClass._Language.InsertValues("rack", " رف ");
            CommonClass._Language.InsertValues("stock", " مخزون ");
            CommonClass._Language.InsertValues("in amount", " في المبلغ");
            CommonClass._Language.InsertValues("out amount", " مبلغ الخروج ");


            CommonClass._Language.InsertValues("man.date", " تاريخ التصنيع ");
            CommonClass._Language.InsertValues("stock area", " الأسهم");
            CommonClass._Language.InsertValues("stockconsolidated", " الأسهم الموحدة ");
            CommonClass._Language.InsertValues("stock value", " قيمة السهم ");
            CommonClass._Language.InsertValues("stock transfer summury", " ملخصتحويل المخزن ");
            //CommonClass._Language.InsertValues("sales", " ");
            CommonClass._Language.InsertValues("salesdaybook", " المبيعات اليومية ");
            CommonClass._Language.InsertValues("purchasedaybook", " كتاب اليوم   شراء ");
            CommonClass._Language.InsertValues("Purchasetaxsummery", " ملخص ضريبة الشراء ");
            CommonClass._Language.InsertValues("Salestaxsummery", " ملخص ضريبة المبيعات ");
            CommonClass._Language.InsertValues("daybook", " كتاب اليوم   ");
            CommonClass._Language.InsertValues("accountreport", " تقرير الحساب ");
            CommonClass._Language.InsertValues("groupreportsummury", " ملخص تقرير المجموعة ");
            CommonClass._Language.InsertValues("outstandingreportsummery", " ملخص التقرير المتميز ");
            CommonClass._Language.InsertValues("billwiseprofitstatement", " فاتورة الحكم الحكيم الربح ");
            CommonClass._Language.InsertValues("billwisesettlement", " فاتورة تسوية حكيمة ");
            CommonClass._Language.InsertValues("payment and receipt report", " الدفع واستلام التقرير ");
            CommonClass._Language.InsertValues("trailbalance", " ميزان المراجعة ");
            CommonClass._Language.InsertValues("balancesheet", " ورقة التوازن ");
            CommonClass._Language.InsertValues("1% tax", " 1٪ ضريبة ");
            CommonClass._Language.InsertValues("2% tax", " 2٪ ضريبة ");
            CommonClass._Language.InsertValues("5% tax", " 5٪ ضريبة ");
            CommonClass._Language.InsertValues("14.5% tax", " 14.5٪ ضريبة ");
            CommonClass._Language.InsertValues("tottal vat", " إجمالي ضريبة القيمة المضافة ");
            CommonClass._Language.InsertValues("grand total", " المبلغ الإجمالي");
            CommonClass._Language.InsertValues("20% tax", "20٪ ضريبة ");
            CommonClass._Language.InsertValues("total vat", "جمالي ضريبة القيمة المضافة ");
            CommonClass._Language.InsertValues("0% tax", "0٪ ضريبة ");

            CommonClass._Language.InsertValues("update", " تحديث ");
            CommonClass._Language.InsertValues("no", " رقم ");
            CommonClass._Language.InsertValues("starting row", " صف  ابتداء ");
            CommonClass._Language.InsertValues("starting column", " أعمدة  ابتداء ");
            CommonClass._Language.InsertValues("update srate base", " تحديث قاعدة معدل المبيعات ");

            CommonClass._Language.InsertValues("Remainder heading", " عنوان  ا المتبقية  ");
            CommonClass._Language.InsertValues("remainder date", " وتذكر التواريخ ");
            CommonClass._Language.InsertValues("subject", " موضوع ");
            CommonClass._Language.InsertValues("select mode", " حدد النموذج");
            CommonClass._Language.InsertValues("All(Marking attendence)", " كل (بمناسبة الحضور) ");
            CommonClass._Language.InsertValues("all(marking extra)", " كل (بمناسبة اضافية) ");

            CommonClass._Language.InsertValues("&Export", " تصدير ");
            CommonClass._Language.InsertValues("export cutomers", " عملاء التصدير");
            CommonClass._Language.InsertValues("export items", " تصدير البند ");
            CommonClass._Language.InsertValues("with closing balance", " مع التوازن الختامي ");
            CommonClass._Language.InsertValues("with closing stock", " مع إغلاق الأسهم ");
            CommonClass._Language.InsertValues("import sales", " مبيعات الاستيراد ");

            CommonClass._Language.InsertValues("extra2", " إضافي 2 ");
            CommonClass._Language.InsertValues("total attendence", " مجموع الحضور ");
            CommonClass._Language.InsertValues("total salary", " كامل الراتب ");
            CommonClass._Language.InsertValues("over duty(no)", " أكثر من واجب (عدد) ");
            CommonClass._Language.InsertValues("total extra", " مجموع اضافية");
            CommonClass._Language.InsertValues("total extra2", " مجموع إضافي 2 ");


            CommonClass._Language.InsertValues("extra", " إضافي");
            CommonClass._Language.InsertValues("mark(atte)", " بمناسبة الحضور ");
            CommonClass._Language.InsertValues("mark(ov duty)", " بمناسبة واجب إضافي ");
            CommonClass._Language.InsertValues("password", " كلمه السر ");
            CommonClass._Language.InsertValues("confirm password", " تأكيد كلمة المرور ");
            CommonClass._Language.InsertValues("acess status", " حالة الوصول ");
            CommonClass._Language.InsertValues("user", " المستعمل  ");
            CommonClass._Language.InsertValues("old password", " كلمة المرور القديمة ");
            CommonClass._Language.InsertValues("new password", " كلمة السر الجديدة ");
            CommonClass._Language.InsertValues("change", " التغييرات ");
            CommonClass._Language.InsertValues("user name", " اسم المستخدم ");
            CommonClass._Language.InsertValues("system name", " اسم النظام ");
            CommonClass._Language.InsertValues("action", " عمل ");
            CommonClass._Language.InsertValues("form", " شكل ");
            CommonClass._Language.InsertValues("export to excel", " تصدير إلى Excel ");
            CommonClass._Language.InsertValues("open excel", " فتح التفوق ");
            CommonClass._Language.InsertValues("insert product", " إدراج المنتج  ");


            CommonClass._Language.InsertValues("&Show", " تظهر");

            CommonClass._Language.InsertValues("change(f5)", " تغيير (F5)");
            CommonClass._Language.InsertValues("select barcode", " حدد الباركود ");
            CommonClass._Language.InsertValues("total qty in", " الكمية الإجمالية في ");
            CommonClass._Language.InsertValues("total qty out", " الكمية الإجمالية خارج ");
            CommonClass._Language.InsertValues("select item", " حدد العنصر ");
            CommonClass._Language.InsertValues("qty in", " الكمية في  ");
            CommonClass._Language.InsertValues("qty out", " كمية خارج  ");

            CommonClass._Language.InsertValues("computer", " الحاسوب ");
            CommonClass._Language.InsertValues("olddata", " البيانات القديمة ");
            CommonClass._Language.InsertValues("newdata", " بيانات جديدة ");
            CommonClass._Language.InsertValues("show", "  بدا");

            CommonClass._Language.InsertValues("cashcadjet", " أداة النقدية ");
            CommonClass._Language.InsertValues("total cash balance", " مجموع الرصيد النقدي");
            CommonClass._Language.InsertValues("todays balance", " توازن اليوم");
            CommonClass._Language.InsertValues("cash purchase", " شراء نقدا");

            CommonClass._Language.InsertValues("Barcode Tools", "أداة الباركود");


            CommonClass._Language.InsertValues("Barcode Settings", " إعدادات الباركود");
            CommonClass._Language.InsertValues("Udate Barcode", " تحديث الباركود");

            CommonClass._Language.InsertValues("Updated Barcode", " تحديث الباركود ");
            CommonClass._Language.InsertValues("delete selected barcode", " حذف الباركود المحدد");

        }
    }
}
