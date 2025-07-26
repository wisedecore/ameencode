using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.Win32;
using System.IO;
using System.Drawing.Printing;

namespace WindowsFormsApplication2
{
    public class DBTask
    {
        public string _ConnectionString;
        public string _Server;
        public string _DataBase;
        public string _UID;
        public string _PWD;


        public string Form;
        public int intSqlExceptionNumber = 0;
        RegistryKey regKey = Registry.CurrentUser;

        public static bool DbFile;
        public DBTask()
        {
        }

        public string GetLogicalName()
        {
            string Temp = currentcompany();
            Temp=CommonClass._Dbtask.ExecuteScalar("SELECT  name AS LogicalFileName, physical_name AS PhysicalFileName "+
            " FROM sys.master_files AS mf where DB_NAME(database_id)='"+Temp+"'");
            return Temp;
        }

        public string currentcompany()
        {
            if (regKey.ValueCount <= 2)
            {
                regKey = regKey.CreateSubKey("Software\\Techno");
            }
            string Temp = Generalfunction.OpCompany;
            return Temp;
        }
        public string Setmodeofpayment(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\modeofpayment.ini"))
            {
                File.Create((Application.StartupPath + "\\modeofpayment.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\modeofpayment.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\modeofpayment.ini"), ServerName);
            _Server = ServerName;
            if (_Server == "")
            {
                _Server = " ";
            }


            return _Server;

        }

        public string Getmodeofpayment()
        {
            if (!File.Exists(Application.StartupPath + "\\modeofpayment.ini"))
            {
                File.Create((Application.StartupPath + "\\modeofpayment.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\modeofpayment.ini"), "CASH");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\modeofpayment.ini");
            if (_Server == "")
            {
                _Server = "CASH";
            }


            return _Server;
        }
        public string GetServerName()
        {
            if(!File.Exists(Application.StartupPath+"\\ServerName.ini"))
            {
                File.Create((Application.StartupPath + "\\ServerName.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\ServerName.ini"),"Localhost\\sqlexpress");
            }
            _Server= System.IO.File.ReadAllText(Application.StartupPath+"\\ServerName.ini");
            if (_Server == "")
                _Server = "Localhost\\sqlexpress";
            return _Server; 
        }

        public string SetServerName(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\ServerName.ini"))
            {
                File.Create((Application.StartupPath + "\\ServerName.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\ServerName.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\ServerName.ini"),ServerName);
            return _Server;

        }

        public string GetInvoiceHeaderinprint()
        {
            if (!File.Exists(Application.StartupPath + "\\TaxinvoiceHeading.ini"))
            {
                File.Create((Application.StartupPath + "\\TaxinvoiceHeading.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\TaxinvoiceHeading.ini"), "Simplified Tax Invoice   فاتورة ضربيية مبسطة");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\TaxinvoiceHeading.ini");

            return _Server;
        }
        public string SetTaxinvoiceHeading(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\TaxinvoiceHeading.ini"))
            {
                File.Create((Application.StartupPath + "\\TaxinvoiceHeading.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\TaxinvoiceHeading.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\TaxinvoiceHeading.ini"), ServerName);
            return _Server;

        }
        public bool fillDatainCombowithQuery1(ComboBox cmbControl, string DisplayFieldName, string tablename, string qry)
        {
            try
            {
                DataSet ds = new DataSet();
                //string qry = "";
                DBTask theDBTask = new DBTask();

                ds = theDBTask.ExecuteQuery(qry);
                cmbControl.DisplayMember = DisplayFieldName;
                cmbControl.ValueMember = DisplayFieldName;
                cmbControl.DataSource = ds.Tables[0];
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void setconstr()
        {

            // RegistryKey regKey = Registry.LocalMachine.GetValueNames("Software\\Techno");

            regKey = regKey.CreateSubKey("Software\\Techno");
            //regKey = regKey.GetSubKeyNames();
            // regKey.SetValue("Opcompany", DataBaseNameStr);
            //string se = regKey.GetValue("Attackserver", 0).ToString();
            //string db = regKey.GetValue("Attackdb", 0).ToString();

            //_Server = "localhost";// ConfigurationSettings.AppSettings["server"].ToString();
            //_DataBase = "profit";// ConfigurationSettings.AppSettings["database"].ToString();

            //_Server = Generalfunction.Server_Name;
            //_DataBase = Generalfunction.DB_Name;
            if (Generalfunction.TempCompanyname == "")
            {
               // _DataBase = regKey.GetValue("Opcompany", 0).ToString();
                _DataBase = Generalfunction.OpCompany;
                //_DataBase = "ARAND";

                _Server = GetServerName();
            }
            else
            {
                _DataBase = Generalfunction.TempCompanyname;
                _Server = GetServerName();
            }
            if (_DataBase == "" && _DataBase==null)
            {
                _DataBase = "master";
            }
            if (_Server == "")
            {
                _Server = "localhost\\sqlexpress";
            }

            //Stream stream = typeof(Program).Assembly.GetManifestResourceStream("easyg.Resources.FilePath.Ini");
            //_Server = _Server; ;
            _UID = "sa";
            _PWD = "hello";

          
            if(DbFile==true)
            _ConnectionString =@"Data Source=.\SQLEXPRESS;AttachDbFilename="+_DataBase+";Integrated Security=True;Connect Timeout=500;User Instance=True";
            else
                _ConnectionString = @"Data Source= " + _Server + ";Initial Catalog=" + _DataBase + ";Max Pool Size=500;Connect Timeout=500;Persist Security Info=True;User ID=" + _UID + ";Password=" + _PWD + "";

          //  _ConnectionString = "Server=159.65.147.232/phpmyadmin;Database=mysql;Uid=root;Pwd=wisedecore@;";
        }

        public DataSet  AccessConectionDS(string Pqry)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\SUN\Desktop\Mechine\POS.mdb;;Jet OLEDB:Database Password=sil123";

               
                conn.ConnectionString = connection;
                conn.Open();
               

                BindingSource bSource = new BindingSource();
                OleDbDataAdapter adapter = new OleDbDataAdapter(Pqry, conn);
                adapter.Fill(CommonClass.Ds);
                return CommonClass.Ds;
                
            }

            catch
            {
                return CommonClass.Ds;
            }
        }

        public void AccessConection(string Pqry)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                String connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\SUN\Desktop\Mechine\POS.mdb;;Jet OLEDB:Database Password=sil123";


                conn.ConnectionString = connection;
                conn.Open();


                OleDbCommand cmdMaxid = new OleDbCommand();
                cmdMaxid.CommandText = Pqry;
                cmdMaxid.Connection = conn;
                cmdMaxid.ExecuteNonQuery();
            
            }

            catch
            {
                
            }
        }

        public void setconstrsecondary()
        {

            // RegistryKey regKey = Registry.LocalMachine.GetValueNames("Software\\Techno");

            regKey = regKey.CreateSubKey("Software\\Techno");
            //regKey = regKey.GetSubKeyNames();
            // regKey.SetValue("Opcompany", DataBaseNameStr);
            //string se = regKey.GetValue("Attackserver", 0).ToString();
            //string db = regKey.GetValue("Attackdb", 0).ToString();

            //_Server = "localhost";// ConfigurationSettings.AppSettings["server"].ToString();
            //_DataBase = "profit";// ConfigurationSettings.AppSettings["database"].ToString();

            //_Server = Generalfunction.Server_Name;
            //_DataBase = Generalfunction.DB_Name;
            if (Generalfunction.TempCompanyname == "")
            {
                _DataBase = "master";
               // _DataBase = regKey.GetValue("Opcompany", 0).ToString();
            }
            else
            {
                _DataBase = Generalfunction.TempCompanyname;
            }
            if (_DataBase == "")
            {
                _DataBase = "master";
            }
            _Server = "localhost\\sqlexpress";
            // _DataBase = "17-jun-2013";         

            //Generalfunction.DB_Name
            _UID = "sa";
            _PWD = "hello";

            //_ConnectionString = "Server=myServerName\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword";

            //_ConnectionString = "Server = "+_Server+"; Database = "+_DataBase+"; Trusted_Connection = True";
           // _ConnectionString = "server=" + _Server + ";uid=" + _UID + ";pwd=" + _PWD + ";database=" + _DataBase;
            //_ConnectionString ="Data Source=JA-PC\\SQLEXPRESS;User ID=GUEST;Password=007008";
            // _ConnectionString = @"Data Source=localhost;Initial Catalog='"+_DataBase+"';Integrated Security=True";
            // _ConnectionString = "Data Source="+_Server+"\\SQLEXPRESS;Initial Catalog="+_DataBase+";Integrated Security=True;port=1400";
           // MessageBox.Show(DbFile.ToString());
            if (DbFile == true)
                _ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + _DataBase + ";Integrated Security=True;Connect Timeout=500;User Instance=True";
            else
                _ConnectionString = @"Data Source=" + _Server + ";Initial Catalog=" + _DataBase + ";Max Pool Size=500;Pooling='True';Connect Timeout=500;Integrated Security=True";
        }
        public void setconstrMaster()
        {
            _Server = ConfigurationSettings.AppSettings["server"].ToString();
            _DataBase = "master";
            _UID = "sa";
            _PWD = "otbipmna#123";
            _ConnectionString = "server=" + _Server + ";uid=" + _UID + ";pwd=" + _PWD + ";database=" + _DataBase;
        }

        public string Getsecondprintmodel()
        {
            if (!File.Exists(Application.StartupPath + "\\secondprintmodel.ini"))
            {
                File.Create((Application.StartupPath + "\\secondprintmodel.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\secondprintmodel.ini"), "0");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\secondprintmodel.ini");
            if (_Server == "")
            {
                _Server = "None";
            }
            if (_Server.ToLower() != "none" && _Server.ToLower() != "thermal" && _Server.ToLower() != "a4" && _Server.ToLower() != "a4 other" && _Server.ToLower() != "no tax a4 code + name" && _Server.ToLower() != "no tax a4 name")
            {
                _Server = "None";
            }


            return _Server;
        }

        public string Setsecondprintmodel(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\secondprintmodel.ini"))
            {
                File.Create((Application.StartupPath + "\\secondprintmodel.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\secondprintmodel.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\secondprintmodel.ini"), ServerName);
            _Server = ServerName;
            if (_Server == "")
            {
                _Server = "None";
            }
            if (_Server.ToLower() != "none" && _Server.ToLower() != "thermal" && _Server.ToLower() != "a4")
            {
                _Server = "None";
            }
            else
            {
                _Server = ServerName;
            }

            return _Server;

        }

        public string GetvaliditydurationSelect()
        {
            if (!File.Exists(Application.StartupPath + "\\ValiditySelect.ini"))
            {
                File.Create((Application.StartupPath + "\\ValiditySelect.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\ValiditySelect.ini"), "");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\ValiditySelect.ini");
            if (_Server == "")
                _Server = "Nil";
            return _Server;
        }



        /***********************************/
        public string Setvalidityduration(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\ValiditySelect.ini"))
            {
                File.Create((Application.StartupPath + "\\ValiditySelect.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\ValiditySelect.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\ValiditySelect.ini"), ServerName);
            return _Server;

        }



        /**************Print Select******************/
        public string SetPrinterSelect(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\PrinterSelect.ini"))
            {
                File.Create((Application.StartupPath + "\\PrinterSelect.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterSelect.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterSelect.ini"), ServerName);
            return _Server;

        }

        public string GetPrinterSelect()
        {
            if (!File.Exists(Application.StartupPath + "\\PrinterSelect.ini"))
            {
                File.Create((Application.StartupPath + "\\PrinterSelect.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterSelect.ini"), "4");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\PrinterSelect.ini");
            if (_Server == "")
                _Server = "4";
            return _Server;
        }

        //eeeee
        public string SetPrinterSelectpurchaseseting(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\PrinterSelectpurchase.ini"))
            {
                File.Create((Application.StartupPath + "\\PrinterSelectpurchase.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterSelectpurchase.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterSelectpurchase.ini"), ServerName);
            return _Server;

        }

        public string GetPrinterSelectpurchaseseting()
        {
            if (!File.Exists(Application.StartupPath + "\\PrinterSelectpurchase.ini"))
            {
                File.Create((Application.StartupPath + "\\PrinterSelectpurchase.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterSelectpurchase.ini"), "4");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\PrinterSelectpurchase.ini");
            if (_Server == "")
                _Server = "4";
            return _Server;
        }
        //eeee

        /***********************************/

        public string SetPrinterName(string ServerName)
         {
            if (!File.Exists(Application.StartupPath + "\\PrinterName.ini"))
            {
                File.Create((Application.StartupPath + "\\PrinterName.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterName.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterName.ini"), ServerName);
            return _Server;

        }

        public string SetPrinterName2(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\PrinterName2.ini"))
            {
                File.Create((Application.StartupPath + "\\PrinterName2.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterName2.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterName2.ini"), ServerName);
            return _Server;

        }

        //bcode
        public string GetPrinterSelectbcode()
        {
            if (!File.Exists(Application.StartupPath + "\\bcodeselect.ini"))
            {
                File.Create((Application.StartupPath + "\\bcodeselect.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\bcodeselect.ini"), "3");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\bcodeselect.ini");
            if (_Server == "")
                _Server = "3";
            return _Server;
        }
        public string SetPrinterSelectbcode(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\bcodeselect.ini"))
            {
                File.Create((Application.StartupPath + "\\bcodeselect.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\bcodeselect.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\bcodeselect.ini"), ServerName);
            return _Server;

        }
        public string SetPrinterNamebcode(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\bcodeprint.ini"))
            {
                File.Create((Application.StartupPath + "\\bcodeprint.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\bcodeprint.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\bcodeprint.ini"), ServerName);
            return _Server;

        }
        
        public string GetPrinterNamebcode()
        {
            if (!File.Exists(Application.StartupPath + "\\bcodeprint.ini"))
            {
                File.Create((Application.StartupPath + "\\bcodeprint.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\bcodeprint.ini"), "Localhost\\sqlexpress");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\bcodeprint.ini");
            if (_Server == "")
                _Server = "Localhost\\sqlexpress";
            return _Server;
        }
        //bcode


        //PURCHASEPRINT
        public string GetPrinterPurchase()
        {
            if (!File.Exists(Application.StartupPath + "\\Purchsprint.ini"))
            {
                File.Create((Application.StartupPath + "\\Purchsprint.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\Purchsprint.ini"), "Localhost\\sqlexpress");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\Purchsprint.ini");
            if (_Server == "")
                _Server = "Localhost\\sqlexpress";
            return _Server;
        }
        public string SetPrinterpurchase(string ServerName)
            {
            if (!File.Exists(Application.StartupPath + "\\Purchsprint.ini"))
            {
                File.Create((Application.StartupPath + "\\Purchsprint.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\Purchsprint.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\Purchsprint.ini"), ServerName);
            return _Server;

        }
        public string SetPrinterSelectpurchase(string ServerName)
        {
            if (!File.Exists(Application.StartupPath + "\\purchaseselect.ini"))
            {
                File.Create((Application.StartupPath + "\\purchaseselect.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\purchaseselect.ini"), ServerName);
            }
            System.IO.File.WriteAllText((Application.StartupPath + "\\purchaseselect.ini"), ServerName);
            return _Server;

        }

        public string GetPrinterSelectpurchase()
        {
            if (!File.Exists(Application.StartupPath + "\\purchaseselect.ini"))
            {
                File.Create((Application.StartupPath + "\\purchaseselect.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\purchaseselect.ini"), "3");
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\purchaseselect.ini");
            if (_Server == "")
                _Server = "3";
            return _Server;
        }

        //PURCHASEPRINT
        public string GetPrinterName()
        {
            if (!File.Exists(Application.StartupPath + "\\PrinterName.ini"))
            {
                PrinterSettings settings = new PrinterSettings();
             

                File.Create((Application.StartupPath + "\\PrinterName.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterName.ini"), settings.PrinterName);
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\PrinterName.ini");
            if (_Server == "")
                _Server = "Localhost\\sqlexpress";
            return _Server;
        }

        public string GetPrinterName2()
        {
            if (!File.Exists(Application.StartupPath + "\\PrinterName2.ini"))
            {
                PrinterSettings settings = new PrinterSettings();


                File.Create((Application.StartupPath + "\\PrinterName2.ini")).Close();
                System.IO.File.WriteAllText((Application.StartupPath + "\\PrinterName2.ini"), settings.PrinterName);
            }
            _Server = System.IO.File.ReadAllText(Application.StartupPath + "\\PrinterName2.ini");
            if (_Server == "")
                _Server = "Localhost\\sqlexpress";
            return _Server;
        }

        public bool fillDatainCombowithQuery(ComboBox cmbControl, string ValueFieldName, string DisplayFieldName, string tablename, string qry)
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
            catch (Exception ex)
            {
                return false;
            }
        }


        public DataTable ExecuteQuerydatatable(string strQuery)
        {
            if (SQLCON.SQlCon != null)
            {
                if (SQLCON.SQlCon.State.ToString() == "Open")
                {
                    SQLCON.SQlCon.Close();
                }

            }

            SQLCON.SQlConopen();
            SqlConnection SQlCon = new SqlConnection();
            DataTable DT = new DataTable();


            SqlDataAdapter SQLDA = new SqlDataAdapter(strQuery, SQLCON.SQlCon);

            SQLDA.Fill(DT);

            return DT;
        }
        public DataSet ExecuteQuery(string strQuery)
        {
            if (SQLCON.SQlCon != null)
            {
                if (SQLCON.SQlCon.State.ToString() == "Open")
                {
                    SQLCON.SQlCon.Close();
                }

            }
       

            SQLCON.SQlConopen();
            SqlConnection SQlCon = new SqlConnection();
          
            DataSet DS = new DataSet();
            SqlCommand cmdMaxid = new SqlCommand();
            cmdMaxid.CommandText = strQuery;
            cmdMaxid.CommandTimeout = 0;
            cmdMaxid.Connection = SQLCON.SQlCon;
            //SqlDataAdapter SQLDA = new SqlDataAdapter(strQuery, SQLCON.SQlCon, cmdMaxid);
            SqlDataAdapter SQLDA = new SqlDataAdapter(cmdMaxid);

           // using (SqlCommand sqlCmd = new SqlCommand(sqlQueryString, sqlConnection))
           //{
           //   sqlCmd.CommandTimeout = 0; // 0 = give it as much time as it needs to complete
          
           // }

            SQLDA.Fill(DS);

            return DS;
        }

        public bool ExecuteNonQuery_SP(string ProcedureName, object[,] ParamArrayName)
        {
            SQLCON.SQlConopen();

            SqlCommand SQLCmd = new SqlCommand();
            SQLCmd.Connection = SQLCON.SQlCon;
            SQLCmd.CommandText = ProcedureName;
            SQLCmd.CommandType = CommandType.StoredProcedure;

            SqlTransaction SqlTran;
            SqlTran = SQLCON.SQlCon.BeginTransaction();

            SQLCmd.Transaction = SqlTran;

            // Attach Paremeter 

            string ParameterName;
            object ParemeterValue;

            for (int i = 0; i < ParamArrayName.Length / 2; i++)
            {
                ParameterName = ParamArrayName[i, 0].ToString();
                ParemeterValue = ParamArrayName[i, 1];
                SQLCmd.Parameters.AddWithValue(ParameterName, ParemeterValue);
            }
            SQLCmd.ExecuteNonQuery();

            SqlTran.Commit();
            // SQlCon.Close();
            return true;
        }

        public bool ExecuteNonQuery_SP(string ProcedureName)
        {
            //--try
            //--{
            SqlCommand SQLCmd = new SqlCommand();
            SQLCmd.Connection = SQLCON.SQlCon;
            SQLCmd.CommandText = ProcedureName;
            SQLCmd.CommandType = CommandType.StoredProcedure;

            SqlTransaction SqlTran;
            SqlTran = SQLCON.SQlCon.BeginTransaction();

            SQLCmd.Transaction = SqlTran;

            SQLCmd.ExecuteNonQuery();

            SqlTran.Commit();
            // SQlCon.Close();
            return true;

            //--}
            //--catch (Exception ex)
            //--{
            // SQlCon.Close();
            //LateException.CurrentException = ex;
            //--}

        }

        //public bool ExecuteNonQuery_SP_OUTPUT(string ProcedureName, object[,] ParamNameValueType, ref int output)
        //{
        //    //SqlConnection SQlCon = new SqlConnection();
        //    //SQlCon.ConnectionString = _ConnectionStrng;
        //    //--try
        //    //--{
        //        //SQlCon.Open();

        //    MySqlCommand SQLCmd = new MySqlCommand();
        //        SQLCmd.Connection = SQLCON.SQlCon;
        //        SQLCmd.CommandText = ProcedureName;
        //        SQLCmd.CommandType = CommandType.StoredProcedure;

        //        MySqlTransaction SqlTran;
        //        SqlTran = SQLCON.SQlCon.BeginTransaction();

        //        SQLCmd.Transaction = SqlTran;

        //        string Type;

        //        MySqlParameter SQLP;

        //        for (int i = 0; i < (ParamNameValueType.Length / 3) - 1; i++)
        //        {
        //            SQLP = new MySqlParameter();
        //            SQLP.ParameterName = ParamNameValueType[i, 0].ToString();
        //            SQLP.Value = ParamNameValueType[i, 1];

        //            Type = ParamNameValueType[i, 2].ToString();

        // Fn call for Set Parameter Type
        // this.SetParameterType(Type, ref SQLP);

        // SQLCmd.Parameters.Add(SQLP);

        //}

        //        for (int j = ((ParamNameValueType.Length / 3) - 1); j < (ParamNameValueType.Length / 3); j++)
        //        {
        //            SQLP = new SqlParameter();
        //            SQLP.ParameterName = ParamNameValueType[j, 0].ToString();
        //            SQLP.Value = ParamNameValueType[j, 1];

        //            Type = ParamNameValueType[j, 2].ToString();
        //            // Fn call for Set Parameter Type
        //            this.SetParameterType(Type, ref SQLP);

        //            SQLP.Size = 0;
        //            SQLP.Direction = ParameterDirection.Output;
        //            SQLP.IsNullable = false;
        //            SQLP.Precision = 0;
        //            SQLP.Scale = 0;
        //            SQLP.SourceVersion = DataRowVersion.Default;


        //            string SColoumn = ParamNameValueType[j, 0].ToString();
        //            string pp = ParamNameValueType[j, 0].ToString();
        //            string[] p = SColoumn.Split('@');
        //            SQLP.SourceColumn = p[1].ToString();
        //            SQLCmd.Parameters.Add(SQLP);


        //                SQLCmd.ExecuteNonQuery();
        //                output = (int)SQLCmd.Parameters[pp].Value;

        //                SqlTran.Commit();
        //                // SQlCon.Close();
        //                return true;
        //        }
        //    //--}
        //        //--catch (Exception ex)
        //    //--{
        //        // SQlCon.Close();
        //        //LateException.CurrentException = ex;
        //    //--}

        //    return false;
        //}
        public bool fillDatainlistboxwithQuery(ListBox cmbControl, string ValueFieldName, string DisplayFieldName, string tablename, string qry)
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
            catch (Exception ex)
            {
                // exceptionMessage = ex.Message;
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void SetParameterType(string Type, ref SqlParameter SQLP)
        {
            //--try
            //--{
            //switch (Type)
            //{
            //case "datetime":
            //    SQLP.MySqlDbType = MySqlDbType.DateTime;
            //    break;
            //case "decimal":
            //    SQLP.MySqlDbType = MySqlDbType.Decimal;
            //    break;
            //case "numeric":
            //    SQLP.MySqlDbType = MySqlDbType.Decimal;
            //    break;
            //case "varchar":
            //    SQLP.MySqlDbType = MySqlDbType.VarChar;
            //    break;
            //case "int":
            //    SQLP.MySqlDbType = MySqlDbType.Int;
            //    break;
            //case "integer":
            //    SQLP.MySqlDbType = MySqlDbType.Int;
            //    break;
            //case "smallint":
            //    SQLP.MySqlDbType = MySqlDbType.Int;
            //    break;
            //case "nchar":
            //    SQLP.MySqlDbType = MySqlDbType.NChar;
            //    break;
            //case "nvarchar":
            //    SQLP.MySqlDbType = MySqlDbType.NVarChar;
            //    break;
            //case "smalldatetime":
            //    SQLP.MySqlDbType = MySqlDbType.SmallDateTime;
            //    break;
            //default:
            //    SQLP.MySqlDbType = MySqlDbType.NVarChar;
            //    break;
            //}

        }

        public DataSet ExecuteQuery_SP(string ProcedureName)
        {
            SqlConnection SQlCon = new SqlConnection();
            DataSet DS = new DataSet();

            //--try
            //--{

            SQlCon.ConnectionString = @"Data Source=JA-PC\SQLEXPRESS;Initial Catalog=MASTER;Integrated Security=True";
            SQlCon.Open();

            SqlCommand SQLCmd = new SqlCommand();
            SQLCmd.Connection = SQLCON.SQlCon;

            SQLCmd.CommandText = ProcedureName;
            SQLCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter SQLDA = new SqlDataAdapter(SQLCmd);

            SQLDA.Fill(DS);
            // SQlCon.Close();

            //--}
            //--catch (Exception ex)
            //--{
            // SQlCon.Close();
            //LateException.CurrentException = ex;
            //--}

            return DS;
        }

        public DataSet ExecuteQuery_SP(string ProcedureName, object[,] ParameterNameValue)
        {
            //SqlConnection SQlCon = new SqlConnection();
            DataSet DS = new DataSet();
            //--try
            //--{
            //SQlCon.ConnectionString = _ConnectionString;// _ConnectionStrng;
            //SQlCon.Open();
            SQLCON.SQlConopen();

            SqlCommand SQLCmd = new SqlCommand();
            SQLCmd.Connection = SQLCON.SQlCon;
            //SQLCmd.Connection = SQLCON.SQlCon;
            SQLCmd.CommandText = ProcedureName;
            SQLCmd.CommandType = CommandType.StoredProcedure;

            // Attach Paremeter 

            string ParameterName;
            object ParemeterValue;

            for (int i = 0; i < ParameterNameValue.Length / 2; i++)
            {
                ParameterName = ParameterNameValue[i, 0].ToString();
                ParemeterValue = ParameterNameValue[i, 1];
                SQLCmd.Parameters.AddWithValue(ParameterName, ParemeterValue);
            }


            SqlDataAdapter SQLDA = new SqlDataAdapter(SQLCmd);

            SQLDA.Fill(DS);

            return DS;
        }

        public object ExecuteScalar_SP(string ProcedureName, object[,] ParameterNameValue)
        {
            //SqlConnection SQlCon = new SqlConnection();
            object objValue = "";
            //--try
            //--{
            //SQlCon.ConnectionString = _ConnectionStrng;
            //SQlCon.Open();
            SQLCON.SQlConopen();
            SqlCommand SQLCmd = new SqlCommand();
            SQLCmd.Connection = SQLCON.SQlCon;
            SQLCmd.CommandText = ProcedureName;
            SQLCmd.CommandType = CommandType.StoredProcedure;

            // Attach Paremeter 

            string ParameterName;
            object ParemeterValue;

            for (int i = 0; i < ParameterNameValue.Length / 2; i++)
            {
                ParameterName = ParameterNameValue[i, 0].ToString();
                ParemeterValue = ParameterNameValue[i, 1];
                SQLCmd.Parameters.AddWithValue(ParameterName, ParemeterValue);
            }

            objValue = SQLCmd.ExecuteScalar();

            return objValue;
        }

        public object ExecuteScalar_SP(string ProcedureName)
        {
            //SqlConnection SQlCon = new SqlConnection();
            object objValue = "";
            //--try
            //--{
            //SQlCon.ConnectionString = _ConnectionStrng;
            //SQlCon.Open();

            SqlCommand SQLCmd = new SqlCommand();
            SQLCmd.Connection = SQLCON.SQlCon;
            SQLCmd.CommandText = ProcedureName;
            SQLCmd.CommandType = CommandType.StoredProcedure;
            objValue = SQLCmd.ExecuteScalar();
            //--}
            //--catch (Exception ex)
            //--{
            //--ex.Message.ToString();
            // SQlCon.Close();
            //LateException.CurrentException = ex;
            //--}

            return objValue;

        }

        public string ExecuteScalar(string qry)
        {
            if (SQLCON.SQlCon != null)
            {
                if (SQLCON.SQlCon.State.ToString() == "Open")
                {
                    SQLCON.SQlCon.Close();
                }
            }
            SQLCON.SQlConopen();
            string maxid = "";
            SqlCommand cmdMaxid = new SqlCommand();
            cmdMaxid.CommandText = qry;
            cmdMaxid.Connection = SQLCON.SQlCon;
            if (cmdMaxid.ExecuteScalar() != null)
            {
                maxid = cmdMaxid.ExecuteScalar().ToString();
            }
            return maxid;
        }

        public bool ExecuteNonQuery(string qry)
        {
            if (SQLCON.SQlCon != null)
            {
                if (SQLCON.SQlCon.State.ToString() == "Open")
                {
                    SQLCON.SQlCon.Close();
                }
            }
            SQLCON.SQlConopen();

            SqlCommand cmdMaxid = new SqlCommand();
            cmdMaxid.CommandText = qry;
            cmdMaxid.Connection = SQLCON.SQlCon;
            cmdMaxid.ExecuteNonQuery();
            return true;
        }

        public bool ExecuteNonQuerySecondary(string qry)
        {
            if (SQLCON.SQlCon != null)
            {
                if (SQLCON.SQlCon.State.ToString() == "Open")
                {
                    SQLCON.SQlCon.Close();
                }

            }
            SQLCON.SQlConopensecondary();

            SqlCommand cmdMaxid = new SqlCommand();
            cmdMaxid.CommandText = qry;
            cmdMaxid.Connection = SQLCON.SQlCon;
            cmdMaxid.ExecuteNonQuery();
            return true;
        }

        public bool MasterDBExecuteNonQuery(string qry)
        {
            try
            {
                if (SQLCON.SQlCon != null)
                {
                    if (SQLCON.SQlCon.State.ToString() == "Open")
                    {
                        SQLCON.SQlCon.Close();
                    }

                }
                SQLCON.MasterSQlConopen();

                SqlCommand cmdMaxid = new SqlCommand();
                cmdMaxid.CommandText = qry;
                cmdMaxid.Connection = SQLCON.SQlCon;
                cmdMaxid.ExecuteNonQuery();
                SQLCON.SQlCon.Close();

                return true;
            }
            catch (Exception ex) { return false; }
        }
        public DataSet MasterDBExecuteQuery(string strQuery)
        {

            //SqlConnection SQlCon = new SqlConnection();
            DataSet DS = new DataSet();

            //--try
            //--{
            if (SQLCON.SQlCon != null)
            {
                if (SQLCON.SQlCon.State.ToString() == "Open")
                {
                    SQLCON.SQlCon.Close();
                }
            }
            SQLCON.MasterSQlConopen();
            SqlDataAdapter SQLDA = new SqlDataAdapter(strQuery, SQLCON.SQlCon);

            SQLDA.Fill(DS);
            SQLCON.SQlCon.Close();
            // SQlCon.Close();
            //--}
            //--catch (Exception ex)
            //--{
            // SQlCon.Close();
            //LateException.CurrentException = ex;
            //--ex.Message.ToString();
            //--}

            return DS;
        }




        public double gridnul(Object obj)
        {
            try
            {
                if (obj == null)
                {
                    obj = 0;
                }
                if (obj.ToString() == ".")
                {
                    obj = 0;
                }
                double temp = Convert.ToDouble(obj);
                return temp;
            }
            catch
            {
                return 0;
            }
        }


        public decimal znull(string sArg)
        {
            if (sArg == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(sArg);
            }

        }

        public double znlldoubletoobject(Object objArg)
        {
            try
            {
                if (objArg == null)
                {
                    return 0;
                }
                else
                {
                    if (Convert.ToString(objArg) == "" || Convert.ToString(objArg)==" ")
                    {
                        objArg = 0;
                    }
                    return Convert.ToDouble(objArg);
                }
            }
            catch
            {
                return 0;
            }
        }

        public string ZnullRemovepoint(string Amt)
        {
            try
            {
                if (Convert.ToDouble(Amt)!= 0)
                {
                    return (Convert.ToDouble(Amt)).ToString();
                }
                else
                {
                   return "0";
                }
            }
            catch
            {
                return "0";
            }
        }

        public string znllString(Object objArg)
        {
            try
            {
                if (objArg == null || objArg.ToString()=="")
                {
                    return "";
                }
                else
                {
                    return objArg.ToString();
                }
            }
            catch
            {
                return "";
            }
        }
        
        public DateTime ZnullDatetime(Object objArg)
        {
            DateTime Dt=Convert.ToDateTime("01-01-1900");
            try
            {
                if (objArg == null)
                {
                    return Dt;
                }
                else
                {
                    Dt = Convert.ToDateTime(objArg);
                }
            }
            catch
            {
                return Dt;
            }
            return Dt;
        }

        public double znullDouble(string sArg)
        {
            try
            {
                if (sArg == "" || sArg == "NaN"||sArg==" ")
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(sArg);
                }
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public string SetintoDecimalpoint(double Value)
        {

            string temp = Value.ToString();
            if (temp == "NaN")
            {
                Value = 0;
            }
            string TempValue = Value.ToString(Generalfunction.CurreDeci);
            return TempValue;
        }
        public string SetintoDecimalpointStock(double Value)
        {
            string TempValue = Value.ToString(Generalfunction.StockDeci);
            return TempValue;
        }
    }
}
