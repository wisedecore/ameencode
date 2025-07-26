using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;
using System.IO;
namespace WindowsFormsApplication2
{
    class ClsCompanyCreate

    {
        string sql = "";
        DBTask _Dbtask = new DBTask();
        ClsUserDetails _UserDetails = new ClsUserDetails();
        RegistryKey regKey = Registry.CurrentUser;
        DataSet Ds = new DataSet();
        ClsManufacturer _Manfacturer = new ClsManufacturer();
        ClsEmployeeMaster _Employeemaster = new ClsEmployeeMaster();
        ClsAccountLedger _Ledger = new ClsAccountLedger();
        ClsDepot _Depot = new ClsDepot();
        ClsAccountGroup _AccountGroup = new ClsAccountGroup();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        clsitemCategory _ItemCategory = new clsitemCategory();
      //  MDIParent1 _Mdi = new MDIParent1();
        ClsParamlist _Paramlist = new ClsParamlist();
        clsmnusettings _Mnusettings = new clsmnusettings();
        ClsMultiRates _Multirate = new ClsMultiRates();
        Clsfields _fileds = new Clsfields();
        ClsCurrency _Currency = new ClsCurrency();
        ClsStatus _status = new ClsStatus();

        Generalfunction _Gen = new Generalfunction();
        NextGFuntion _Nextg = new NextGFuntion();
        DateTimePicker dt;
        
        public DataSet LoadCompany()
        {
            //_Dbtask.Form = "master";
            Generalfunction.TempCompanyname = "master";
            Ds = _Dbtask.ExecuteQuery("SELECT * FROM sys.sysdatabases where name !='master' and name !='tempdb' and name !='model' and name !='msdb'");
            return Ds;
        }

        
      
        public void CompanyCreate(string DataBaseNameStr,bool Bak)
        { 
                DataBaseNameStr = DataBaseNameStr.Replace(" ", "");
                
                _Dbtask.ExecuteNonQuery("create database " + DataBaseNameStr + "");
                //che
                
               // dt.Value = DateTime.Now.Date;
            SetLegistry(DataBaseNameStr, "", "", "", 0,dt);
                Generalfunction.TempCompanyname = "";
                CreateTable();
               // _Mdi.PrgMain.Value = 30;
                CreateProcedure();
                //CommonClass._Nextg.RefreshDB();
                //CommonClass._Nextg.RefreshProcedure();

               // _Mdi.PrgMain.Value = 60;
            string temp;
            if(Bak==true)
            {
            temp="0";
            }
            else
            {
            temp="1";
            }
            DefaultInsert(temp);
            
            //catch(Exception exe)
            //{
            // //   MessageBox.Show(exe.ToString());
            //}
        }
        public void SetLegistry(string  DataBaseNameStr,string ServerName,string UserName,string Pwd,int check,DateTimePicker DtVale)
        {
            string Backc;
          // regKey= regKey.CreateSubKey("Software\\Techno");
            if (File.Exists(DataBaseNameStr))
            {
                //MessageBox.Show("come to temp");
                DBTask.DbFile = true;
            }
            else
            {
                DBTask.DbFile = false;
            }

            Generalfunction.OpCompany = DataBaseNameStr;
           
            //regKey.SetValue("opcompany", DataBaseNameStr);
            _Dbtask.SetServerName(ServerName);
           // regKey.CreateSubKey("Software\\Techno");
            if (check == 1)
            {
               
                regKey.SetValue("Savepwd", "1");
                regKey.SetValue("Opcompany", DataBaseNameStr);
                regKey.SetValue("Username",UserName);
                regKey.SetValue("Pwd", Pwd);
              
            }
            else
            {
                regKey.SetValue("Savepwd", "0");
               
            }
        }
        public string CompanyName(string ComName)
        {
            ComName = CommonClass._Dbtask.ExecuteScalar(" use "+ComName+" select cname from tblcompanymaster");
            return ComName;
        }
        public void Defaultinsertcurrency()     /*   ABDUL SAMEEH  */
        {
            //_Currency.InsertCurrency();
            Ds = _Dbtask.ExecuteQuery("select * from TblCurrency");

            if (Ds.Tables[0].Rows.Count == 0)
            {
                _Currency.CurrId = 1;
                _Currency.Code = "AED";
                _Currency.Description = "United Arab Emirates";
                _Currency.Currency = "Dirham";
                _Currency.Change = "Fils";
                _Currency.InsertCurrency();

                _Currency.CurrId = 2;
                _Currency.Code = "AFN";
                _Currency.Description = "Afghanistan";
                _Currency.Currency = "Afghani";
                _Currency.Change = "Puls";
                _Currency.InsertCurrency();

                _Currency.CurrId = 3;
                _Currency.Code = "ALL";
                _Currency.Description = "Albania";
                _Currency.Currency = "Lek";
                _Currency.Change = "Qindarka";
                _Currency.InsertCurrency();

                _Currency.CurrId = 4;
                _Currency.Code = "AMD";
                _Currency.Description = "Armenia";
                _Currency.Currency = "Dram";
                _Currency.Change = "Luma";
                _Currency.InsertCurrency();

                _Currency.CurrId = 5;
                _Currency.Code = "ANG";
                _Currency.Description = "Netherlands Antilles";
                _Currency.Currency = "Guilder";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 6;
                _Currency.Code = "AOA";
                _Currency.Description = "Angola";
                _Currency.Currency = "New Kwanza";
                _Currency.Change = "Lwei";
                _Currency.InsertCurrency();

                _Currency.CurrId = 7;
                _Currency.Code = "ARS";
                _Currency.Description = "Argentina";
                _Currency.Currency = "Peso";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 8;
                _Currency.Code = "AUD";
                _Currency.Description = "Australia";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 9;
                _Currency.Code = "AUD1";
                _Currency.Description = "Canton and Enderbury Islands";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 10;
                _Currency.Code = "AUD2";
                _Currency.Description = "Christmas Island";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 11;
                _Currency.Code = "AUD3";
                _Currency.Description = "Cocos Islands";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 12;
                _Currency.Code = "AUD4";
                _Currency.Description = "Heard and McDonald Islands";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 13;
                _Currency.Code = "AUD5";
                _Currency.Description = "Kiribati";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 14;
                _Currency.Code = "AUD6";
                _Currency.Description = "Nauru";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 15;
                _Currency.Code = "AUD7";
                _Currency.Description = "Norfolk Island";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 16;
                _Currency.Code = "AUD8";
                _Currency.Description = "Tuvalu";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 17;
                _Currency.Code = "AWG";
                _Currency.Description = "Aruba";
                _Currency.Currency = "Guilder";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 18;
                _Currency.Code = "AZM";
                _Currency.Description = "Azerbaijan";
                _Currency.Currency = "Manat";
                _Currency.Change = "Gopik";
                _Currency.InsertCurrency();

                _Currency.CurrId = 19;
                _Currency.Code = "BAM";
                _Currency.Description = "Bosnia-Herzegovina";
                _Currency.Currency = "Convertible Mark";
                _Currency.Change = "Fennig";
                _Currency.InsertCurrency();

                _Currency.CurrId = 20;
                _Currency.Code = "BBD";
                _Currency.Description = "Barbados";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 21;
                _Currency.Code = "BDT";
                _Currency.Description = "Bangladesh";
                _Currency.Currency = "Taka";
                _Currency.Change = "Paisa";
                _Currency.InsertCurrency();

                _Currency.CurrId = 22;
                _Currency.Code = "BGN";
                _Currency.Description = "Bulgaria";
                _Currency.Currency = "New Lev";
                _Currency.Change = "Stotinki";
                _Currency.InsertCurrency();

                _Currency.CurrId = 23;
                _Currency.Code = "BHD";
                _Currency.Description = "Bahrain";
                _Currency.Currency = "Dinar";
                _Currency.Change = "Fils";
                _Currency.InsertCurrency();

                _Currency.CurrId = 24;
                _Currency.Code = "BIF";
                _Currency.Description = "Burundi";
                _Currency.Currency = "Franc";
                _Currency.Change = "Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 25;
                _Currency.Code = "BMD";
                _Currency.Description = "Bermuda";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 26;
                _Currency.Code = "BND";
                _Currency.Description = "Brunei";
                _Currency.Currency = "Ringgit";
                _Currency.Change = "Sen";
                _Currency.InsertCurrency();

                _Currency.CurrId = 27;
                _Currency.Code = "BOB";
                _Currency.Description = "Bolivia";
                _Currency.Currency = "Boliviano";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 28;
                _Currency.Code = "BRL";
                _Currency.Description = "Brazil";
                _Currency.Currency = "Real";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 29;
                _Currency.Code = "BSD";
                _Currency.Description = "Bahamas";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 30;
                _Currency.Code = "BTN";
                _Currency.Description = "Bhutan";
                _Currency.Currency = "Ngultrum";
                _Currency.Change = "Chetrum";
                _Currency.InsertCurrency();

                _Currency.CurrId = 31;
                _Currency.Code = "BWP";
                _Currency.Description = "Botswana";
                _Currency.Currency = "Pula";
                _Currency.Change = "Thebe";
                _Currency.InsertCurrency();

                _Currency.CurrId = 32;
                _Currency.Code = "BYR";
                _Currency.Description = "Belarus";
                _Currency.Currency = "Ruble";
                _Currency.Change = "Ruble";
                _Currency.InsertCurrency();

                _Currency.CurrId = 33;
                _Currency.Code = "BZD";
                _Currency.Description = "Belize";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 34;
                _Currency.Code = "CAD";
                _Currency.Description = "Canada";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 35;
                _Currency.Code = "CDF";
                _Currency.Description = "Congo, Dem. Rep";
                _Currency.Currency = "Franc";
                _Currency.Change = "Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 36;
                _Currency.Code = "CHF";
                _Currency.Description = "Liechtenstein";
                _Currency.Currency = "Franc";
                _Currency.Change = "Rappen/Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 37;
                _Currency.Code = "CHF1";
                _Currency.Description = "Switzerland";
                _Currency.Currency = "Franc";
                _Currency.Change = "Rappen";
                _Currency.InsertCurrency();

                _Currency.CurrId = 38;
                _Currency.Code = "CLP";
                _Currency.Description = "Chile";
                _Currency.Currency = "Peso";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 39;
                _Currency.Code = "CNY";
                _Currency.Description = "China";
                _Currency.Currency = "Yuan Renminbi";
                _Currency.Change = "Jiao";
                _Currency.InsertCurrency();

                _Currency.CurrId = 40;
                _Currency.Code = "COP";
                _Currency.Description = "Colombia";
                _Currency.Currency = "Peso";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 41;
                _Currency.Code = "CRC";
                _Currency.Description = "Costa Rica";
                _Currency.Currency = "Colon";
                _Currency.Change = "Centimos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 42;
                _Currency.Code = "CUP";
                _Currency.Description = "Cuba";
                _Currency.Currency = "Peso";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 43;
                _Currency.Code = "CVE";
                _Currency.Description = "Cape Verde Island";
                _Currency.Currency = "Escudo";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 44;
                _Currency.Code = "CYP";
                _Currency.Description = "Cyprus";
                _Currency.Currency = "Pound";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 45;
                _Currency.Code = "CZK";
                _Currency.Description = "Czech Republic";
                _Currency.Currency = "Koruna";
                _Currency.Change = "Haleru";
                _Currency.InsertCurrency();

                _Currency.CurrId = 46;
                _Currency.Code = "DJF";
                _Currency.Description = "Djibouti";
                _Currency.Currency = "Franc";
                _Currency.Change = "Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 47;
                _Currency.Code = "DKK";
                _Currency.Description = "Denmark";
                _Currency.Currency = "Krone";
                _Currency.Change = "Øre";
                _Currency.InsertCurrency();

                _Currency.CurrId = 48;
                _Currency.Code = "DKK1";
                _Currency.Description = "Faeroe Islands";
                _Currency.Currency = "Krone";
                _Currency.Change = "Øre";
                _Currency.InsertCurrency();

                _Currency.CurrId = 49;
                _Currency.Code = "DKK2";
                _Currency.Description = "Greenland";
                _Currency.Currency = "Krone";
                _Currency.Change = "Øre";
                _Currency.InsertCurrency();

                _Currency.CurrId = 50;
                _Currency.Code = "DOP";
                _Currency.Description = "Dominican Rep.";
                _Currency.Currency = "Peso";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 51;
                _Currency.Code = "DZD";
                _Currency.Description = "Algeria";
                _Currency.Currency = "Dinar";
                _Currency.Change = "Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 52;
                _Currency.Code = "EEK";
                _Currency.Description = "Estonia";
                _Currency.Currency = "Kroon";
                _Currency.Change = "Senti";
                _Currency.InsertCurrency();

                _Currency.CurrId = 53;
                _Currency.Code = "EGP";
                _Currency.Description = "Egypt";
                _Currency.Currency = "Pound";
                _Currency.Change = "Piasters";
                _Currency.InsertCurrency();

                _Currency.CurrId = 54;
                _Currency.Code = "ERN";
                _Currency.Description = "Eritrea";
                _Currency.Currency = "Nakfa";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 55;
                _Currency.Code = "ETB";
                _Currency.Description = "Ethiopia";
                _Currency.Currency = "Birr";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 56;
                _Currency.Code = "EUR";
                _Currency.Description = "European Union";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 57;
                _Currency.Code = "EUR1";
                _Currency.Description = "Andorra";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 58;
                _Currency.Code = "EUR10";
                _Currency.Description = "Ireland";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 59;
                _Currency.Code = "EUR11";
                _Currency.Description = "Italy";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 60;
                _Currency.Code = "EUR12";
                _Currency.Description = "Luxembourg";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 61;
                _Currency.Code = "EUR13";
                _Currency.Description = "Martinique";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 62;
                _Currency.Code = "EUR14";
                _Currency.Description = "Monaco";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 63;
                _Currency.Code = "EUR15";
                _Currency.Description = "Netherlands";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 64;
                _Currency.Code = "EUR16";
                _Currency.Description = "Portugal (1999-)";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 65;
                _Currency.Code = "EUR17";
                _Currency.Description = "Reunion";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 66;
                _Currency.Code = "EUR18";
                _Currency.Description = "San Marino";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 67;
                _Currency.Code = "EUR19";
                _Currency.Description = "Spain";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 68;
                _Currency.Code = "EUR2";
                _Currency.Description = "Austria";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 69;
                _Currency.Code = "EUR20";
                _Currency.Description = "Vatican";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 70;
                _Currency.Code = "EUR21";
                _Currency.Description = "Western Sahara";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 71;
                _Currency.Code = "EUR3";
                _Currency.Description = "Belgium";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 72;
                _Currency.Code = "EUR4";
                _Currency.Description = "Finland";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 73;
                _Currency.Code = "EUR5";
                _Currency.Description = "France";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 74;
                _Currency.Code = "EUR6";
                _Currency.Description = "French Guiana";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 75;
                _Currency.Code = "EUR7";
                _Currency.Description = "Germany";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 76;
                _Currency.Code = "EUR8";
                _Currency.Description = "Greece";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 77;
                _Currency.Code = "EUR9";
                _Currency.Description = "Guadeloupe";
                _Currency.Currency = "Euro";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 78;
                _Currency.Code = "FJD";
                _Currency.Description = "Fiji";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 79;
                _Currency.Code = "FKP";
                _Currency.Description = "Falkland Islands";
                _Currency.Currency = "Pound";
                _Currency.Change = "Pence";
                _Currency.InsertCurrency();

                _Currency.CurrId = 80;
                _Currency.Code = "GBP";
                _Currency.Description = "Great Britain";
                _Currency.Currency = "Pound";
                _Currency.Change = "Pence";
                _Currency.InsertCurrency();

                _Currency.CurrId = 81;
                _Currency.Code = "GBP1";
                _Currency.Description = "Guernsey";
                _Currency.Currency = "Pound";
                _Currency.Change = "Pence";
                _Currency.InsertCurrency();

                _Currency.CurrId = 82;
                _Currency.Code = "GBP2";
                _Currency.Description = "Isle of Man";
                _Currency.Currency = "Pound";
                _Currency.Change = "Pence";
                _Currency.InsertCurrency();

                _Currency.CurrId = 83;
                _Currency.Code = "GBP3";
                _Currency.Description = "Jersey";
                _Currency.Currency = "Pound";
                _Currency.Change = "Pence";
                _Currency.InsertCurrency();

                _Currency.CurrId = 84;
                _Currency.Code = "GBP4";
                _Currency.Description = "United Kingdom";
                _Currency.Currency = "Pound";
                _Currency.Change = "Pence";
                _Currency.InsertCurrency();

                _Currency.CurrId = 85;
                _Currency.Code = "GEL";
                _Currency.Description = "Georgia";
                _Currency.Currency = "Lari";
                _Currency.Change = "Tetri";
                _Currency.InsertCurrency();

                _Currency.CurrId = 86;
                _Currency.Code = "GHC";
                _Currency.Description = "Ghana";
                _Currency.Currency = "New Cedi";
                _Currency.Change = "Psewas";
                _Currency.InsertCurrency();

                _Currency.CurrId = 87;
                _Currency.Code = "GIP";
                _Currency.Description = "Gibraltar";
                _Currency.Currency = "Pound";
                _Currency.Change = "Pence";
                _Currency.InsertCurrency();

                _Currency.CurrId = 88;
                _Currency.Code = "GMD";
                _Currency.Description = "Gambia";
                _Currency.Currency = "Dalasi";
                _Currency.Change = "Butut";
                _Currency.InsertCurrency();

                _Currency.CurrId = 89;
                _Currency.Code = "GNS";
                _Currency.Description = "Guinea";
                _Currency.Currency = "Syli";
                _Currency.Change = "Francs";
                _Currency.InsertCurrency();

                _Currency.CurrId = 90;
                _Currency.Code = "GQE";
                _Currency.Description = "Equatorial Guinea";
                _Currency.Currency = "Franc";
                _Currency.Change = "Centimos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 91;
                _Currency.Code = "GTQ";
                _Currency.Description = "Guatemala";
                _Currency.Currency = "Quetzal";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 92;
                _Currency.Code = "GYD";
                _Currency.Description = "Guyana";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 93;
                _Currency.Code = "HKD";
                _Currency.Description = "Hong Kong";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 94;
                _Currency.Code = "HNL";
                _Currency.Description = "Honduras";
                _Currency.Currency = "Lempira";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 95;
                _Currency.Code = "HRK";
                _Currency.Description = "Croatia";
                _Currency.Currency = "Kuna";
                _Currency.Change = "Lipas";
                _Currency.InsertCurrency();

                _Currency.CurrId = 96;
                _Currency.Code = "HTG";
                _Currency.Description = "Haiti";
                _Currency.Currency = "Gourde";
                _Currency.Change = "Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 97;
                _Currency.Code = "HUF";
                _Currency.Description = "Hungary";
                _Currency.Currency = "Forint";
                _Currency.Change = "Forint";
                _Currency.InsertCurrency();

                _Currency.CurrId = 98;
                _Currency.Code = "IDR";
                _Currency.Description = "Indonesia";
                _Currency.Currency = "Rupiah";
                _Currency.Change = "Sen";
                _Currency.InsertCurrency();

                _Currency.CurrId = 99;
                _Currency.Code = "IDR1";
                _Currency.Description = "East Timor";
                _Currency.Currency = "Rupiah";
                _Currency.Change = "Sen";
                _Currency.InsertCurrency();

                _Currency.CurrId = 100;
                _Currency.Code = "ILS";
                _Currency.Description = "Israel";
                _Currency.Currency = "New Shekel";
                _Currency.Change = "New Agorot";
                _Currency.InsertCurrency();

                _Currency.CurrId = 101;
                _Currency.Code = "ILS1";
                _Currency.Description = "Gaza";
                _Currency.Currency = "New Shekel";
                _Currency.Change = "New Agorot";
                _Currency.InsertCurrency();

                _Currency.CurrId = 102;
                _Currency.Code = "INR";
                _Currency.Description = "India";
                _Currency.Currency = "Rupee";
                _Currency.Change = "Paise";
                _Currency.InsertCurrency();

                _Currency.CurrId = 103;
                _Currency.Code = "IQD";
                _Currency.Description = "Iraq";
                _Currency.Currency = "Dinar";
                _Currency.Change = "Fils";
                _Currency.InsertCurrency();

                _Currency.CurrId = 104;
                _Currency.Code = "IRR";
                _Currency.Description = "Iran";
                _Currency.Currency = "Iran";
                _Currency.Change = "Rials";
                _Currency.InsertCurrency();

                _Currency.CurrId = 105;
                _Currency.Code = "ISK";
                _Currency.Description = "Iceland";
                _Currency.Currency = "Króna";
                _Currency.Change = "Aurar";
                _Currency.InsertCurrency();

                _Currency.CurrId = 106;
                _Currency.Code = "JMD";
                _Currency.Description = "Jamaica";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 107;
                _Currency.Code = "JOD";
                _Currency.Description = "Jordan";
                _Currency.Currency = "Dinar";
                _Currency.Change = "Fils";
                _Currency.InsertCurrency();

                _Currency.CurrId = 108;
                _Currency.Code = "JPY";
                _Currency.Description = "Japan";
                _Currency.Currency = "Yen";
                _Currency.Change = "Sen";
                _Currency.InsertCurrency();

                _Currency.CurrId = 109;
                _Currency.Code = "KES";
                _Currency.Description = "Kenya";
                _Currency.Currency = "Shilling";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 110;
                _Currency.Code = "KGS";
                _Currency.Description = "Kyrgyzstan";
                _Currency.Currency = "Som";
                _Currency.Change = "Tyyn";
                _Currency.InsertCurrency();

                _Currency.CurrId = 111;
                _Currency.Code = "KHR";
                _Currency.Description = "Kampuchea";
                _Currency.Currency = "New Riel";
                _Currency.Change = "Sen";
                _Currency.InsertCurrency();

                _Currency.CurrId = 112;
                _Currency.Code = "KHR1";
                _Currency.Description = "Cambodia";
                _Currency.Currency = "New Riel";
                _Currency.Change = "Sen";
                _Currency.InsertCurrency();

                _Currency.CurrId = 113;
                _Currency.Code = "KMF";
                _Currency.Description = "Comoros";
                _Currency.Currency = "Franc";
                _Currency.Change = "Franc";
                _Currency.InsertCurrency();

                _Currency.CurrId = 114;
                _Currency.Code = "KPW";
                _Currency.Description = "Korea, North";
                _Currency.Currency = "Won";
                _Currency.Change = "Chon";
                _Currency.InsertCurrency();

                _Currency.CurrId = 115;
                _Currency.Code = "KRW1";
                _Currency.Description = "Korea, South";
                _Currency.Currency = "Won";
                _Currency.Change = "Chon";
                _Currency.InsertCurrency();

                _Currency.CurrId = 116;
                _Currency.Code = "KWD";
                _Currency.Description = "Kuwait";
                _Currency.Currency = "Dinar";
                _Currency.Change = "Fils";
                _Currency.InsertCurrency();

                _Currency.CurrId = 117;
                _Currency.Code = "KYD";
                _Currency.Description = "Cayman Islands";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 118;
                _Currency.Code = "KZT";
                _Currency.Description = "Kazakhstan";
                _Currency.Currency = "Tenge";
                _Currency.Change = "Tiyn";
                _Currency.InsertCurrency();

                _Currency.CurrId = 119;
                _Currency.Code = "LAK";
                _Currency.Description = "Laos";
                _Currency.Currency = "New Kip";
                _Currency.Change = "At";
                _Currency.InsertCurrency();

                _Currency.CurrId = 120;
                _Currency.Code = "LBP";
                _Currency.Description = "Lebanon";
                _Currency.Currency = "Livre";
                _Currency.Change = "Piastres";
                _Currency.InsertCurrency();

                _Currency.CurrId = 121;
                _Currency.Code = "LKR";
                _Currency.Description = "Sri Lanka";
                _Currency.Currency = "Rupee";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 122;
                _Currency.Code = "LRD";
                _Currency.Description = "Liberia";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 123;
                _Currency.Code = "LSL";
                _Currency.Description = "Lesotho";
                _Currency.Currency = "Loti";
                _Currency.Change = "Lisente";
                _Currency.InsertCurrency();

                _Currency.CurrId = 124;

                _Currency.Code = "LTL";
                _Currency.Description = "Lithuania";
                _Currency.Currency = "Litas";
                _Currency.Change = "Centu";
                _Currency.InsertCurrency();

                _Currency.CurrId = 125;
                _Currency.Code = "LVL";
                _Currency.Description = "Latvia";
                _Currency.Currency = "Lat";
                _Currency.Change = "Santims";
                _Currency.InsertCurrency();

                _Currency.CurrId = 126;
                _Currency.Code = "LYD";
                _Currency.Description = "Libya";
                _Currency.Currency = "Dinar";
                _Currency.Change = "Dirhams";
                _Currency.InsertCurrency();

                _Currency.CurrId = 127;
                _Currency.Code = "MAD";
                _Currency.Description = "Morocco";
                _Currency.Currency = "Dirham";
                _Currency.Change = "Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 128;
                _Currency.Code = "MDL";
                _Currency.Description = "Moldova";
                _Currency.Currency = "Leu";
                _Currency.Change = "Leu";
                _Currency.InsertCurrency();

                _Currency.CurrId = 129;
                _Currency.Code = "MGF";
                _Currency.Description = "Madagascar";
                _Currency.Currency = "Ariayry";
                _Currency.Change = "Francs";
                _Currency.InsertCurrency();

                _Currency.CurrId = 130;
                _Currency.Code = "MKD";
                _Currency.Description = "Macedonia";
                _Currency.Currency = "Denar";
                _Currency.Change = "Deni";
                _Currency.InsertCurrency();

                _Currency.CurrId = 131;
                _Currency.Code = "MMK";
                _Currency.Description = "Myanmar";
                _Currency.Currency = "Kyat";
                _Currency.Change = "Pyas";
                _Currency.InsertCurrency();

                _Currency.CurrId = 132;
                _Currency.Code = "MNT";
                _Currency.Description = "Mongolia";
                _Currency.Currency = "Tugrik";
                _Currency.Change = "Mongos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 133;
                _Currency.Code = "MOP";
                _Currency.Description = "Macao";
                _Currency.Currency = "Pataca";
                _Currency.Change = "Avos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 134;
                _Currency.Code = "MRO";
                _Currency.Description = "Mauritania";
                _Currency.Currency = "Ouguiya";
                _Currency.Change = "Khoums";
                _Currency.InsertCurrency();

                _Currency.CurrId = 135;
                _Currency.Code = "MTL";
                _Currency.Description = "Malta";
                _Currency.Currency = "Lira";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 136;
                _Currency.Code = "MUR";
                _Currency.Description = "Mauritius";
                _Currency.Currency = "Rupee";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 137;
                _Currency.Code = "MVR";
                _Currency.Description = "Maldives";
                _Currency.Currency = "Rufiyaa";
                _Currency.Change = "Lari";
                _Currency.InsertCurrency();

                _Currency.CurrId = 138;
                _Currency.Code = "MWK";
                _Currency.Description = "Malawi";
                _Currency.Currency = "Kwacha";
                _Currency.Change = "Tambala";
                _Currency.InsertCurrency();

                _Currency.CurrId = 139;
                _Currency.Code = "MXN";
                _Currency.Description = "Mexico";
                _Currency.Currency = "Peso";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 140;
                _Currency.Code = "MYR";
                _Currency.Description = "Malaysia";
                _Currency.Currency = "Ringgit";
                _Currency.Change = "Sen";
                _Currency.InsertCurrency();

                _Currency.CurrId = 141;
                _Currency.Code = "MZM";
                _Currency.Description = "Mozambique";
                _Currency.Currency = "Metical";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 142;
                _Currency.Code = "NAD";
                _Currency.Description = "Namibia";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 143;
                _Currency.Code = "NGN";
                _Currency.Description = "Nigeria";
                _Currency.Currency = "Naira";
                _Currency.Change = "Kobo";
                _Currency.InsertCurrency();

                _Currency.CurrId = 144;
                _Currency.Code = "NIO";
                _Currency.Description = "Nicaragua";
                _Currency.Currency = "Gold Cordoba";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 145;
                _Currency.Code = "NOK";
                _Currency.Description = "Norway";
                _Currency.Currency = "Krone";
                _Currency.Change = "Øre";
                _Currency.InsertCurrency();

                _Currency.CurrId = 146;
                _Currency.Code = "NOK1";
                _Currency.Description = "Dronning Maud Land";
                _Currency.Currency = "Krone";
                _Currency.Change = "Øre";
                _Currency.InsertCurrency();

                _Currency.CurrId = 147;
                _Currency.Code = "NOK2";
                _Currency.Description = "Svalbard and Jan Mayen Islands";
                _Currency.Currency = "Krone";
                _Currency.Change = "Øre";
                _Currency.InsertCurrency();

                _Currency.CurrId = 148;
                _Currency.Code = "NPR";
                _Currency.Description = "Nepal";
                _Currency.Currency = "Rupee";
                _Currency.Change = "Paise";
                _Currency.InsertCurrency();

                _Currency.CurrId = 149;
                _Currency.Code = "NZD";
                _Currency.Description = "New Zealand";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 150;
                _Currency.Code = "NZD1";
                _Currency.Description = "Cook Islands";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 151;
                _Currency.Code = "NZD2";
                _Currency.Description = "Niue";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 152;
                _Currency.Code = "NZD3";
                _Currency.Description = "Pitcairn Island";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 153;
                _Currency.Code = "NZD4";
                _Currency.Description = "Tokelau";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 154;
                _Currency.Code = "OMR";
                _Currency.Description = "Oman";
                _Currency.Currency = "Rial";
                _Currency.Change = "Baizas";
                _Currency.InsertCurrency();

                _Currency.CurrId = 155;
                _Currency.Code = "PAB";
                _Currency.Description = "Panama";
                _Currency.Currency = "Balboa";
                _Currency.Change = "Centesimos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 156;
                _Currency.Code = "PEI";
                _Currency.Description = "Peru";
                _Currency.Currency = "Inti";
                _Currency.Change = "Centimos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 157;
                _Currency.Code = "PEN";
                _Currency.Description = "Peru";
                _Currency.Currency = "New Sol";
                _Currency.Change = "Centimos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 158;
                _Currency.Code = "PGK";
                _Currency.Description = "Papua New Guinea";
                _Currency.Currency = "Kina";
                _Currency.Change = "Toeas";
                _Currency.InsertCurrency();

                _Currency.CurrId = 159;
                _Currency.Code = "PHP";
                _Currency.Description = "Philippines";
                _Currency.Currency = "Peso";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 160;
                _Currency.Code = "PKR";
                _Currency.Description = "Pakistan";
                _Currency.Currency = "Rupee";
                _Currency.Change = "Paisa";
                _Currency.InsertCurrency();

                _Currency.CurrId = 161;
                _Currency.Code = "PLN";
                _Currency.Description = "Poland";
                _Currency.Currency = "Zloty";
                _Currency.Change = "Groszy";
                _Currency.InsertCurrency();

                _Currency.CurrId = 162;
                _Currency.Code = "PTE";
                _Currency.Description = "Portugal (-1998)";
                _Currency.Currency = "Escudo";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 163;
                _Currency.Code = "PYG";
                _Currency.Description = "Paraguay";
                _Currency.Currency = "Guarani";
                _Currency.Change = "Centimos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 164;
                _Currency.Code = "QAR";
                _Currency.Description = "Qatar";
                _Currency.Currency = "Riyal";
                _Currency.Change = "Dirhams";
                _Currency.InsertCurrency();

                _Currency.CurrId = 165;
                _Currency.Code = "ROL";
                _Currency.Description = "Romania";
                _Currency.Currency = "Leu";
                _Currency.Change = "Bani";
                _Currency.InsertCurrency();

                _Currency.CurrId = 166;
                _Currency.Code = "RUB";
                _Currency.Description = "Russia (1998-)";
                _Currency.Currency = "Ruble";
                _Currency.Change = "Kopecks";
                _Currency.InsertCurrency();

                _Currency.CurrId = 167;
                _Currency.Code = "RWF";
                _Currency.Description = "Rwanda";
                _Currency.Currency = "Franc";
                _Currency.Change = "Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 168;
                _Currency.Code = "SAR";
                _Currency.Description = "Saudi Arabia";
                _Currency.Currency = "Riyal";
                _Currency.Change = "Halalat";
                _Currency.InsertCurrency();

                _Currency.CurrId = 169;
                _Currency.Code = "SBD";
                _Currency.Description = "Solomon Island";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 170;
                _Currency.Code = "SCR";
                _Currency.Description = "Seychelles";
                _Currency.Currency = "Rupee";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 171;
                _Currency.Code = "SDP";
                _Currency.Description = "Sudan";
                _Currency.Currency = "Dinar";
                _Currency.Change = "Piastres";
                _Currency.InsertCurrency();

                _Currency.CurrId = 172;
                _Currency.Code = "SEK";
                _Currency.Description = "Sweden";
                _Currency.Currency = "Krona";
                _Currency.Change = "Ören";
                _Currency.InsertCurrency();

                _Currency.CurrId = 173;
                _Currency.Code = "SGD";
                _Currency.Description = "Singapore";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 174;
                _Currency.Code = "SHP";
                _Currency.Description = "St. Helena";
                _Currency.Currency = "Pound";
                _Currency.Change = "New Pence";
                _Currency.InsertCurrency();

                _Currency.CurrId = 175;
                _Currency.Code = "SIT";
                _Currency.Description = "Slovenia";
                _Currency.Currency = "Tolar";
                _Currency.Change = "Stotinov";
                _Currency.InsertCurrency();

                _Currency.CurrId = 176;
                _Currency.Code = "SKK";
                _Currency.Description = "Slovakia";
                _Currency.Currency = "Koruna";
                _Currency.Change = "Halierov";
                _Currency.InsertCurrency();

                _Currency.CurrId = 177;
                _Currency.Code = "SLL";
                _Currency.Description = "Sierra Leone";
                _Currency.Currency = "Leone";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 178;
                _Currency.Code = "SOS";
                _Currency.Description = "Somalia";
                _Currency.Currency = "Shilling";
                _Currency.Change = "Centesimi";
                _Currency.InsertCurrency();

                _Currency.CurrId = 179;
                _Currency.Code = "SRD";
                _Currency.Description = "Suriname";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 180;
                _Currency.Code = "STD";
                _Currency.Description = "Sao Tome & Principe";
                _Currency.Currency = "Dobra";
                _Currency.Change = "Centimos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 181;
                _Currency.Code = "SVC";
                _Currency.Description = "El Salvador";
                _Currency.Currency = "Colon";
                _Currency.Change = "Centavos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 182;
                _Currency.Code = "SYP";
                _Currency.Description = "Syria";
                _Currency.Currency = "Pound";
                _Currency.Change = "Piasters";
                _Currency.InsertCurrency();

                _Currency.CurrId = 183;
                _Currency.Code = "SZL";
                _Currency.Description = "Swaziland";
                _Currency.Currency = "Lilangeni";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 184;
                _Currency.Code = "THB";
                _Currency.Description = "Thailand";
                _Currency.Currency = "Baht";
                _Currency.Change = "Stang";
                _Currency.InsertCurrency();

                _Currency.CurrId = 185;
                _Currency.Code = "TJS";
                _Currency.Description = "Tajikistan";
                _Currency.Currency = "Somoni";
                _Currency.Change = "Dirams";
                _Currency.InsertCurrency();

                _Currency.CurrId = 186;
                _Currency.Code = "TMM";
                _Currency.Description = "Turkmenistan";
                _Currency.Currency = "Manat";
                _Currency.Change = "Tenga";
                _Currency.InsertCurrency();

                _Currency.CurrId = 187;
                _Currency.Code = "TND";
                _Currency.Description = "Tunisia";
                _Currency.Currency = "Dinar";
                _Currency.Change = "Millimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 188;
                _Currency.Code = "TOP";
                _Currency.Description = "Tonga";
                _Currency.Currency = "PaAnga";
                _Currency.Change = "Seniti";
                _Currency.InsertCurrency();

                _Currency.CurrId = 189;
                _Currency.Code = "TRY";
                _Currency.Description = "Turkey";
                _Currency.Currency = "New Lira";
                _Currency.Change = "New Kurus";
                _Currency.InsertCurrency();

                _Currency.CurrId = 190;
                _Currency.Code = "TRY1";
                _Currency.Description = "Cyprus (Northern)";
                _Currency.Currency = "New Lira";
                _Currency.Change = "New Kurus";
                _Currency.InsertCurrency();

                _Currency.CurrId = 191;
                _Currency.Code = "TTD";
                _Currency.Description = "Trinidad and Tobago";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 192;
                _Currency.Code = "TWD";
                _Currency.Description = "Taiwan";
                _Currency.Currency = "New Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 193;
                _Currency.Code = "TZS";
                _Currency.Description = "Tanzania";
                _Currency.Currency = "Shilling";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 194;
                _Currency.Code = "UAH";
                _Currency.Description = "Ukraine";
                _Currency.Currency = "Hryvnia";
                _Currency.Change = "Kopiykas";
                _Currency.InsertCurrency();

                _Currency.CurrId = 195;
                _Currency.Code = "UGS";
                _Currency.Description = "Uganda";
                _Currency.Currency = "Shilling";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 196;
                _Currency.Code = "USD";
                _Currency.Description = "United States of America";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 197;
                _Currency.Code = "USD1";
                _Currency.Description = "American Samoa";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 198;
                _Currency.Code = "USD10";
                _Currency.Description = "Panama Canal Zone";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 199;
                _Currency.Code = "USD11";
                _Currency.Description = "Puerto Rico";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 200;
                _Currency.Code = "USD12";
                _Currency.Description = "Samoa (America)";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 201;
                _Currency.Code = "USD13";
                _Currency.Description = "Timor-Leste";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 202;
                _Currency.Code = "USD14";
                _Currency.Description = "Turks and Caicos Islands";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 203;
                _Currency.Code = "USD15";
                _Currency.Description = "Virgin Islands";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 204;
                _Currency.Code = "USD16";
                _Currency.Description = "Wake Island";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 205;
                _Currency.Code = "USD2";
                _Currency.Description = "British Indian Ocean Territory";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 206;
                _Currency.Code = "USD3";
                _Currency.Description = "British Virgin Islands";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 207;
                _Currency.Code = "USD4";
                _Currency.Description = "Ecuador";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 208;
                _Currency.Code = "USD5";
                _Currency.Description = "Guam";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 209;
                _Currency.Code = "USD6";
                _Currency.Description = "Johnston Island";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 210;
                _Currency.Code = "USD7";
                _Currency.Description = "Micronesia";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 211;
                _Currency.Code = "USD8";
                _Currency.Description = "Midway Islands";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 212;
                _Currency.Code = "USD9";
                _Currency.Description = "Palau";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 213;
                _Currency.Code = "UYU";
                _Currency.Description = "Uruguay";
                _Currency.Currency = "Peso Uruguayo";
                _Currency.Change = "Centésimos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 214;
                _Currency.Code = "UZS";
                _Currency.Description = "Uzbekistan";
                _Currency.Currency = "Som";
                _Currency.Change = "Tiyin";
                _Currency.InsertCurrency();

                _Currency.CurrId = 215;
                _Currency.Code = "VEB";
                _Currency.Description = "Venezuela";
                _Currency.Currency = "Bolivar";
                _Currency.Change = "Centimos";
                _Currency.InsertCurrency();

                _Currency.CurrId = 216;
                _Currency.Code = "VND";
                _Currency.Description = "Vietnam";
                _Currency.Currency = "Dong";
                _Currency.Change = "Dong";
                _Currency.InsertCurrency();

                _Currency.CurrId = 217;
                _Currency.Code = "XOF";
                _Currency.Description = "Ivory Coast";
                _Currency.Currency = "Franc";
                _Currency.Change = "Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 218;
                _Currency.Code = "XOF7";
                _Currency.Description = "Senegal";
                _Currency.Currency = "Franc";
                _Currency.Change = "Centimes";
                _Currency.InsertCurrency();

                _Currency.CurrId = 219;
                _Currency.Code = "YER";
                _Currency.Description = "Yemen";
                _Currency.Currency = "Rial";
                _Currency.Change = "Fils";
                _Currency.InsertCurrency();

                _Currency.CurrId = 220;
                _Currency.Code = "YUM";
                _Currency.Description = "Yugoslavia";
                _Currency.Currency = "Dinar";
                _Currency.Change = "Paras";
                _Currency.InsertCurrency();

                _Currency.CurrId = 221;
                _Currency.Code = "ZAR";
                _Currency.Description = "South Africa";
                _Currency.Currency = "Rand";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

                _Currency.CurrId = 222;
                _Currency.Code = "ZMK";
                _Currency.Description = "Zambia";
                _Currency.Currency = "Kwacha";
                _Currency.Change = "Ngwee";
                _Currency.InsertCurrency();

                _Currency.CurrId = 223;
                _Currency.Code = "ZWD";
                _Currency.Description = "Zimbabwe";
                _Currency.Currency = "Dollar";
                _Currency.Change = "Cents";
                _Currency.InsertCurrency();

            }

        }

        public void RefreshParmacy()
        {
            if (_Nextg.KnowTableexsting("tblop") == false)
            {  /*Add Enqiury*/
                sql = "CREATE TABLE [Tbladdenquiry] (" +
                    "[enqvno] [nvarchar](20) NOT NULL," +
                    "[Enqname] [nvarchar](50)," +
                    "[company] [nvarchar](100)," +
                    "[address] [nvarchar](100)," +
                    "[telephone] [nvarchar](20)," +
                    "[mobile] [nvarchar](20)," +
                    "[city] [nvarchar](50)," +
                    "[state] [nvarchar](70)," +
                    "[CId] float," +
                    "[email] [nvarchar](30)," +
                    "[enqdate] datetime," +
                    "[enqtime] datetime," +
                    "[Empid] [float] NOT NULL," +
                    "[enquiryabout] [nvarchar](70)," +
                    "[response] [nvarchar](50)," +
                    "[status] float," +
                    "[remarks] [nvarchar](100)," +
                    "[Aid] [float] NOT NULL," +
                    "[description][nvarchar](100)," +
                    "[Lid] [float] NOT NULL," +
                    "[ItemId] [float] NOT NULL," +
                    "[Userfld1] [nvarchar](250)," +
                    "[Userfld2] [nvarchar](250)," +
                    "[Userfld3] [nvarchar](250)," +
                    "[Userfld4] [nvarchar](250)," +
                    "[Userfld5] [nvarchar](250)," +
                    "[ProductVno][nvarchar](50)," +
                    "[VType][nvarchar](50))";
                _Dbtask.ExecuteNonQuery(sql);

                /*For Add Enquiry  ABDUL SAMEEH */
                sql = "CREATE PROCEDURE [dbo].[InsertEnquiry]" +
                   " @enqvno nvarchar(20)," +
                   " @Enqname nvarchar(50)," +
                   " @company nvarchar(100)," +
                   " @address nvarchar(100)," +
                   " @telephone nvarchar(20)," +
                   " @mobile nvarchar(20)," +
                   " @city nvarchar(50)," +
                   " @state nvarchar(70)," +
                   " @CId float," +
                   " @email nvarchar(30)," +
                   " @enqdate datetime," +
                   " @enqtime datetime," +
                   " @Empid float," +
                   " @enquiryabout nvarchar(70)," +
                   " @response nvarchar(50)," +
                   " @status float," +
                   " @remarks nvarchar(100)," +
                   " @Aid float," +
                   " @Lid float ," +
                   " @ItemId float," +
                   " @description nvarchar(250)," +
                   " @Userfld1 nvarchar(250)," +
                   " @Userfld2 nvarchar(250)," +
                   " @Userfld3 nvarchar(250)," +
                   " @Userfld4 nvarchar(250)," +
                   " @Userfld5 nvarchar(250)," +
                   " @ProductVno nvarchar(50)," +
                   " @VType nvarchar(50)" +
                   " AS" +
                   " BEGIN" +
                   " insert into Tbladdenquiry (enqvno,Enqname,company,address,telephone,mobile,city,state,CId,email,enqdate,enqtime,Empid,enquiryabout,response,status,remarks,Aid,Lid,ItemId,description,Userfld1,Userfld2,Userfld3,Userfld4,Userfld5,ProductVno,VType) values (@enqvno,@Enqname,@company,@address,@telephone,@mobile,@city,@state,@CId,@email,@enqdate,@enqtime,@Empid,@enquiryabout,@response,@status,@remarks,@Aid,@Lid,@ItemId,@description,@Userfld1,@Userfld2,@Userfld3,@Userfld4,@Userfld5,@ProductVno,@VType)" +
                   " END";
                _Dbtask.ExecuteNonQuery(sql);


                /*OP(OutPatient)*/
                sql = "CREATE TABLE [dbo].[tblop](" +
        "[opno] [float] NULL," +
        "[opdate] [datetime] NULL," +
        "[optime] [datetime] NULL," +
        "[staffid] [float] NULL," +
        "[doctor] [float] NULL," +
        "[gender] [int] NULL," +
        "[age] [decimal](18, 5) NULL," +
        "[patient] [float] NULL," +
        "[opnote] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
        "[ramount] [decimal](18, 5) NULL," +
        "[gno] [float] NULL" +
    ") ON [PRIMARY]";
                _Dbtask.ExecuteNonQuery(sql);

                /*OP Detail*/
                sql = "CREATE TABLE [dbo].[tblopdetails](" +
        "[opno] [float] NOT NULL," +
        "[serviceitem] [float] NOT NULL," +
        "[qty] [decimal](18, 5) NOT NULL," +
        "[rate] [decimal](18, 5) NOT NULL," +
        "[amount] [decimal](18, 5) NOT NULL," +
        "CONSTRAINT [PK_tblopdetails] PRIMARY KEY CLUSTERED " +
        "(" +
        "[opno] ASC" +
        ")WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]" +
        ") ON [PRIMARY]";
                _Dbtask.ExecuteNonQuery(sql);


                sql = " CREATE TABLE [Tbladvance](" +
              "[OpNo] [decimal](18, 0) NULL," +
   "[Weight] [decimal](18, 0) NULL," +
   "[Height] [decimal](18, 0) NULL," +
   "[Standingbp] [decimal](18, 0) NULL," +
   "[Heartrate] [decimal](18, 0) NULL," +
   "[temperature] [decimal](18, 0) NULL," +
   "[BMI] [decimal](18, 0) NULL," +
   "[Respiration] [decimal](18, 0) NULL," +
   "[Residenceinfo] [nvarchar](250)  NULL," +
   "[Note] [nchar](250)  NULL)";
                _Dbtask.ExecuteNonQuery(sql);


        sql = "CREATE PROCEDURE [dbo].[Insertopdetails] @opno float, @serviceitem  float,@qty   [decimal](18,5)," +
             " @rate [decimal](18,5), @amount [decimal](18,5) " +
             " AS BEGIN INSERT INTO tblopdetails(opno,serviceitem,qty,rate,amount)" +
             " VALUES(@opno,@serviceitem,@qty,@rate,@amount) END";
        _Dbtask.ExecuteNonQuery(sql);

        sql = "CREATE PROCEDURE [dbo].[Insertop] @opno float, @opdate datetime,@optime  datetime," +
        " @staffid float, @doctor float,@patient  float,@Gender  int,@Age  [decimal](18, 5),@opnote nvarchar(50), @ramount [decimal](18,5),@gno  float " +
        " AS BEGIN INSERT INTO tblop(opno,opdate,optime,staffid,doctor,patient,opnote,ramount,gno)" +
        " VALUES(@opno,@opdate,@optime,@staffid,@doctor,@patient,@opnote,@ramount,@gno) END";
        _Dbtask.ExecuteNonQuery(sql);


        sql = "CREATE PROCEDURE [dbo].[InsertAdvance]" +
        " @OpNo decimal(18, 0)," +
        " @Weight decimal(18, 0)," +
        " @Height decimal(18, 0)," +
        " @Standingbp decimal(18, 0)," +
        " @Heartrate decimal(18, 0)," +
        " @Temperature decimal(18, 0)," +
        " @BMI decimal(18, 0)," +
        " @Respiration decimal(18, 0)," +
        " @Residenceinfo nvarchar(250)," +
        " @Note nvarchar(250)" +

        " AS" +
        " BEGIN" +
                    /* INSERT INTO SomeTable(SomeColumn, AnotherColumn) VALUES(@SomeParam, @AnotherParam)*/
        " insert into Tbladvance (OpNo,Weight,Height,Standingbp,Heartrate,Temperature,BMI,Respiration,Residenceinfo,Note)" +
        " values (@OpNo,@Weight,@Height,@Standingbp,@Heartrate,@Temperature,@BMI,@Respiration,@Residenceinfo,@Note)" +
        " END";
                _Dbtask.ExecuteNonQuery(sql);


                sql = "CREATE PROCEDURE [dbo].[Insertguest] @lstatus int,@Lid float, @Lname nvarchar(50), @Aliasname nvarchar(50)," +
" @address1 nvarchar(200),@address2 nvarchar(200),@city nvarchar(50),@phone nvarchar(50),@email nvarchar(50),@age nvarchar(50)," +
" @ttype float,@nationality nvarchar(50),@purpose nvarchar(50),@gender int,@creditlimit decimal(18,5),@bloodgroup nvarchar(20)," +
" @visano nvarchar(50),@visaexpiry datetime,@bankaccountno nvarchar(50),@Mstatus int,@familydetails nvarchar(200)," +
" @foodtype float,@Note nvarchar(200),@noteofproof nvarchar(200) " +
" AS BEGIN insert into" +
" tblguest (lstatus,lid,lname,Aliasname,address1,address2,city,phone,email,age,ttype,nationality,purpose,gender,creditlimit,bloodgroup,visano,visaexpiry," +
" bankaccountno,mstatus,familydetails,foodtype,note,noteofproof)" +
" values (@lstatus,@lid,@lname,@Aliasname,@address1,@address2,@city,@phone,@email,@age,@ttype,@nationality,@purpose,@gender,@creditlimit,@bloodgroup,@visano,@visaexpiry," +
" @bankaccountno,@mstatus,@familydetails,@foodtype,@note,@noteofproof) RETURN END";
                _Dbtask.ExecuteNonQuery(sql);


              

                sql = "CREATE TABLE [dbo].[tblguest](" +
                "[Lstatus] [float] NULL," +
                 "[Lid] [float] NULL," +
                "[Lname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[Aliasname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[address1] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[address2] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[city] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[phone] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[email] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[age] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[ttype] [float] NULL," +
                "[nationality] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[purpose] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[gender] [int] NULL," +
                "[creditLimit] [decimal](18, 5) NULL," +
                "[bloodgroup] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[visano] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[visaexpiry] [datetime] NULL," +
                "[bankaccountno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[mstatus] [int] NULL," +
                "[familydetails] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[foodtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                "[note] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +

                "[noteofproof] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
              "[proofimg] image," +
                "[guestimg] image" +
                ") ON [PRIMARY]";
                _Dbtask.ExecuteNonQuery(sql);

        CommonClass._Department.IdDepartment();
        CommonClass._Department.DepName = "Doctor";
        CommonClass._Department.InsertDepartment();

            }
        }

        public void RefreshCRm()
        {
            if (_Nextg.KnowTableexsting("Tbladdenquiry") == false)
            {
            CreateTableCRM();
            CreateProcedureCRM();
            Defaultinsertcurrency();
           DefaultInsertstatus();
           DefaultInsertfileds();
            }
        }
        public void DefinsertMnusettings()
        {
            _Mnusettings.Menuid = "2";
            _Mnusettings.MenuName = "Create";
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "3";
            _Mnusettings.MenuName = "Items";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "4";
            _Mnusettings.MenuName = "ItemsGroup";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "5";
            _Mnusettings.MenuName = "Customer";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "6";
            _Mnusettings.MenuName = "Supplier";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "7";
            _Mnusettings.MenuName = "Staff";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "8";
            _Mnusettings.MenuName = "Agent";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "9";
            _Mnusettings.MenuName = "Ledger";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "10";
            _Mnusettings.MenuName = "LedgerGroup";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "11";
            _Mnusettings.MenuName = "Multirate";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "12";
            _Mnusettings.MenuName = "Munits";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "13";
            _Mnusettings.MenuName = "Depo";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "14";
            _Mnusettings.MenuName = "Tax";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();


            _Mnusettings.Menuid = "15";
            _Mnusettings.MenuName = "Transaction";
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();


            _Mnusettings.Menuid = "16";
            _Mnusettings.MenuName = "BankReceipt";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "17";
            _Mnusettings.MenuName = "Bankpayment";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "18";
            _Mnusettings.MenuName = "Cashreceipt";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "19";
            _Mnusettings.MenuName = "Cashpayment";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "20";
            _Mnusettings.MenuName = "BankReceipt";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "21";
            _Mnusettings.MenuName = "Salesestimation";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "22";
            _Mnusettings.MenuName = "Salesreturn";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "23";
            _Mnusettings.MenuName = "Purchase";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "24";
            _Mnusettings.MenuName = "Purchasereturn";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "25";
            _Mnusettings.MenuName = "Openingstock";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "26";
            _Mnusettings.MenuName = "Damege";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "27";
            _Mnusettings.MenuName = "Excess";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "28";
            _Mnusettings.MenuName = "Stocktransfer";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "29";
            _Mnusettings.MenuName = "Stockcorrector";
            _Mnusettings.Parentid = "15";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "100";
            _Mnusettings.MenuName = "Updatesrate";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "101";
            _Mnusettings.MenuName = "Updateprate";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();


            _Mnusettings.Menuid = "102";
            _Mnusettings.MenuName = "Itemwiseagentcommision";
            _Mnusettings.Parentid = "3";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "103";
            _Mnusettings.MenuName = "Batch";
            _Mnusettings.Parentid = "2";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "104";
            _Mnusettings.MenuName = "Pos";
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "105";
            _Mnusettings.MenuName = "Production";
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "106";
            _Mnusettings.MenuName = "Payroll";
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "107";
            _Mnusettings.MenuName = "Roundoff";
            _Mnusettings.Parentid = "100";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "108";
            _Mnusettings.MenuName = "sitemdisc";
            _Mnusettings.Parentid = "20";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "109";
            _Mnusettings.MenuName = "Pitemdisc";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();



            _Mnusettings.Menuid = "110";
            _Mnusettings.MenuName = "Sfree";
            _Mnusettings.Parentid = "20";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "111";
            _Mnusettings.MenuName = "Pfree";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "112";
            _Mnusettings.MenuName = "Editsrate";
            _Mnusettings.Parentid = "20";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "113";
            _Mnusettings.MenuName = "Editprate";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "114";
            _Mnusettings.MenuName = "UpdateMRP";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "115";
            _Mnusettings.MenuName = "Sagent";
            _Mnusettings.Parentid = "20";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "116";
            _Mnusettings.MenuName = "Semployee";
            _Mnusettings.Parentid = "20";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "117";
            _Mnusettings.MenuName = "Pagent";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "118";
            _Mnusettings.MenuName = "Pemployee";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "119";
            _Mnusettings.MenuName = "Pexciseduty";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "120";
            _Mnusettings.MenuName = "Peditgrossamt";
            _Mnusettings.Parentid = "23";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();


            _Mnusettings.Menuid = "121";
            _Mnusettings.MenuName = "Useasbarcode";
            _Mnusettings.Parentid = "103";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "122";
            _Mnusettings.MenuName = "AB";/*For Auto Backup*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "123";
            _Mnusettings.MenuName = "Sizes";/*For Sizes*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "124";
            _Mnusettings.MenuName = "Updatesrateinsale";/*For Update Sale Rate in Sale*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "125";
            _Mnusettings.MenuName = "Flex";/*For Update Sale Rate in Sale*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "126";
            _Mnusettings.MenuName = "Sfocusfirstrow";/*Focus First Row In Sale*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "127";
            _Mnusettings.MenuName = "Pitemnote1";/*Itemnote1 in Purchase*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "128";
            _Mnusettings.MenuName = "Pitemnote2";/*Itemnote1 in Purchase*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "129";
            _Mnusettings.MenuName = "Customerpoint";/*Itemnote1 in Purchase*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "130";
            _Mnusettings.MenuName = "SelBarcode";/*Select Barcode Printing Mode*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "131";
            _Mnusettings.MenuName = "MdateBPrint";/*Select Barcode Printing Mode*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "132";
            _Mnusettings.MenuName = "Note1BPrint";/*Select Barcode Printing Mode*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "133";
            _Mnusettings.MenuName = "Note2BPrint";/*Select Barcode Printing Mode*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "134";
            _Mnusettings.MenuName = "SuppliercodeBPrint";/*Select Barcode Printing Mode*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "135";
            _Mnusettings.MenuName = "Sprintwhilesaving";/*Print While Saving In S.I*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";//-1 is Roll 1 is Laser
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "136";
            _Mnusettings.MenuName = "Sprintconfirmation";/*Print Confirmation in S.I*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "137";
            _Mnusettings.MenuName = "DeactiveCustomer";/*Print Confirmation in S.I*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "138";
            _Mnusettings.MenuName = "Sprintpreview";/*Print Preview in S.I*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "139";
            _Mnusettings.MenuName = "CashDesk";/*Print Preview in S.I*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "140";
            _Mnusettings.MenuName = "Scrm";/*CRM*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "141";
            _Mnusettings.MenuName = "Serialnotracking";/*Serial No Tracking*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "142";
            _Mnusettings.MenuName = "barcodeheadinguseascompanyname";/*Barcode Heading Use As Company Name*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "143";
            _Mnusettings.MenuName = "Salesinvdiscount";/*Sales Invoice*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "144";
            _Mnusettings.MenuName = "Wmachine";/*Wieght Mechine*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "145";
            _Mnusettings.MenuName = "Pharmacy";/*Pharmacy*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "146";
            _Mnusettings.MenuName = "VPrateinP";/*Visible Prate in Purchase*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "147";
            _Mnusettings.MenuName = "ESGross";/*Edit Gross in Sale*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "148";
            _Mnusettings.MenuName = "VSSrate";/*Visible SalesRate in Sales*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "149";
            _Mnusettings.MenuName = "Supitem";/*Visible SalesRate in Sales*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "150";
            _Mnusettings.MenuName = "PrintBalance";/*Print Old Balance*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "151";
            _Mnusettings.MenuName = "Printwhilesavingcash";/*Print Old Balance*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "152";
            _Mnusettings.MenuName = "VSSrate";/*Save Zero P.Rate*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "153";
            _Mnusettings.MenuName = "SRemDubli";/*Allow Dublicate*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            //_Mnusettings.Menuid = "154";
            //_Mnusettings.MenuName = "Rprintwhilesaving";/*Allow Dublicate*/
            //_Mnusettings.Parentid = "0";
            //_Mnusettings.Status = "-1";
            //_Mnusettings.InsertMnusettings();

            //_Mnusettings.Menuid = "155";
            //_Mnusettings.MenuName = "Pprintwhilesaving";/*Allow Dublicate*/
            //_Mnusettings.Parentid = "0";
            //_Mnusettings.Status = "-1";
            //_Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "156";
            _Mnusettings.MenuName = "Spproject";/*Allow Dublicate*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "157";
            _Mnusettings.MenuName = "SBarcodelogo";/*Allow Dublicate*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "158";
            _Mnusettings.MenuName = "Strstock";/*Remainder of Stock Balance*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "159";
            _Mnusettings.MenuName = "StrBalance";/*Remainder of Account Balance*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "160";
            _Mnusettings.MenuName = "Editsqty";/*For Edit Qty in sale*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "161";
            _Mnusettings.MenuName = "Printl";/*Print multi langague*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "162";
            _Mnusettings.MenuName = "Printcon";/*Print multi langague*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "163";
            _Mnusettings.MenuName = "Setsalerateincludetax";/*Print multi langague*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "164";
            _Mnusettings.MenuName = "Zerotaxamount";/*Zero tax save*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "165";
            _Mnusettings.MenuName = "Bdate";/*Billing date in PURCHASE*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "166";
            _Mnusettings.MenuName = "Singlebarcode";/*Single barcode*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "167";
            _Mnusettings.MenuName = "CArea";/*Customer Area in Sales*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();


            _Mnusettings.Menuid = "168";
            _Mnusettings.MenuName = "Savezeroratesale";/*Customer Area in Sales*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();


            _Mnusettings.Menuid = "169";
            _Mnusettings.MenuName = "PrintSecondlngue";/*Print Second langague in Barcode*/
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "-1";
            _Mnusettings.InsertMnusettings();
            /*Report Field visible*/


            _Mnusettings.Menuid = "1000";
            _Mnusettings.MenuName = "Report";
            _Mnusettings.Parentid = "0";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "1001";
            _Mnusettings.MenuName = "Clnbalance";
            _Mnusettings.Parentid = "1000";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "1002";
            _Mnusettings.MenuName = "Clnopening";
            _Mnusettings.Parentid = "1000";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "1003";
            _Mnusettings.MenuName = "Clnpurchase";
            _Mnusettings.Parentid = "1000";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "1004";
            _Mnusettings.MenuName = "Clnsr";
            _Mnusettings.Parentid = "1000";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "1005";
            _Mnusettings.MenuName = "Clnsales";
            _Mnusettings.Parentid = "1000";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            _Mnusettings.Menuid = "1006";
            _Mnusettings.MenuName = "Clnpr";
            _Mnusettings.Parentid = "1000";
            _Mnusettings.Status = "1";
            _Mnusettings.InsertMnusettings();

            //Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='302010'");
            //if (Ds.Tables[0].Rows.Count == 0)
            //{
                _Mnusettings.Menuid = "302010";
                _Mnusettings.MenuName = "baseunit";/*CRM*/
                _Mnusettings.Parentid = "0";
                _Mnusettings.Status = "-1";
                _Mnusettings.InsertMnusettings();
            //}


            /*Report Field visible*/
        }
        public void InsertMenus()
        {
            CommonClass._menus.Id = 1;
            CommonClass._menus.MenuName = "Items";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 2;
            CommonClass._menus.MenuName = "Item Group";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 3;
            CommonClass._menus.MenuName = "Customer";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 4;
            CommonClass._menus.MenuName = "Supplier";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 5;
            CommonClass._menus.MenuName = "Employee";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 6;
            CommonClass._menus.MenuName = "Ledger";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 7;
            CommonClass._menus.MenuName = "Ledger Group";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 8;
            CommonClass._menus.MenuName = "Sales";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 9;
            CommonClass._menus.MenuName = "Purchase";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 10;
            CommonClass._menus.MenuName = "Receipt";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 11;
            CommonClass._menus.MenuName = "Payment";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 12;
            CommonClass._menus.MenuName = "Debit Note";
            CommonClass._menus.InsertMenus();


            CommonClass._menus.Id = 13;
            CommonClass._menus.MenuName = "Credit Note";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 14;
            CommonClass._menus.MenuName = "Journal Receipt";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 15;
            CommonClass._menus.MenuName = "Journal Payment";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 16;
            CommonClass._menus.MenuName = "Opening Stock";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 17;
            CommonClass._menus.MenuName = "Repacking";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 18;
            CommonClass._menus.MenuName = "CRM";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 19;
            CommonClass._menus.MenuName = "Stock Report";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 20;
            CommonClass._menus.MenuName = "Sales Report";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 21;
            CommonClass._menus.MenuName = "Purchase Report";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 22;
            CommonClass._menus.MenuName = "Ledger Report";
            CommonClass._menus.InsertMenus();


            CommonClass._menus.Id = 23;
            CommonClass._menus.MenuName = "Cash Book";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 24;
            CommonClass._menus.MenuName = "DayBook";
            CommonClass._menus.InsertMenus();

            CommonClass._menus.Id = 25;
            CommonClass._menus.MenuName = "Trail Balance";
            CommonClass._menus.InsertMenus();


        }
        public void DefaultInsert(string Sdelete)
        {

            InsertMenus();

            CommonClass._Unitcreation.Id = 1;
            CommonClass._Unitcreation.Name = "PC";
            CommonClass._Unitcreation.Ucount = 1;
            CommonClass._Unitcreation.InsertUnit();
            

            _UserDetails.UserId = 1;
            _UserDetails.UserName = "ADMIN";
            _UserDetails.Password = "admin";
            _UserDetails.AStatus = -1;
            _UserDetails.Groupid = 0;
            _UserDetails.InserUser();

            ///*For Agent*/
            //_Ledger.LidLng = 0;
            //_Ledger.LNameStr = "None";
            //_Ledger.GidLng = 72;
            //_Ledger.InsertLedger();
             
            ///*For Employee*/
            //_Employeemaster.EmpidLng = 0;
            //_Employeemaster.EmpNameStr = "None";
            //_Employeemaster.InsertEmployeeMaster();

            /*Manfacturer*/

            _Manfacturer.Mid = 0;
            _Manfacturer.Mname = "None";
            _Manfacturer.InsertManufacturer();

            /*Depot*/
            _Depot.Dcode = 0;
            _Depot.Dname = "Default";
            _Depot.InsertDepot();

         

            /*Item Category*/

            _ItemCategory.CategoryIdLng = 0;
            _ItemCategory.CategoryNameStr = "None";
            _ItemCategory.InsertItemCategory();

            _Multirate.RateIdLng = 0;
            _Multirate.RateInInt = 0;
            _Multirate.RateNameStr = "Retail Rate";
           
            _Multirate.InsertMultiRate();

            CommonClass._Area.Aid = 0;
            CommonClass._Area.Aname = "None";
            CommonClass._Area.InsertArea();
        
        
           DefInsertManAccount();
           DefInsertParamlist(Sdelete);
           DefinsertMnusettings();
        }
        public void CreateTableCRM()
        {
            /*CRM Status*/
            sql = "CREATE TABLE [Tblstatus] (" +
               "[Id] [int]," +
               "[Name] [nvarchar](100) NOT NULL)";
            _Dbtask.ExecuteNonQuery(sql);

            /* CRM Fields*/
            sql = "CREATE TABLE [TblFields] (" +
                "[Id] [int]," +
                "[Name] [nvarchar](100) NOT NULL)";
            _Dbtask.ExecuteNonQuery(sql);

            /*Currency*/
            sql = "CREATE TABLE [TblCurrency] (" +
                "[CId] [float]," +
                "[code] [nvarchar](20) NOT NULL," +
                "[description] [nvarchar](50) NOT NULL," +
                "[currency] [nvarchar](30) NOT NULL," +
                "[change] [nvarchar](30) NOT NULL)";
            _Dbtask.ExecuteNonQuery(sql);

            /*Add Enqiury*/
            sql = "CREATE TABLE [Tbladdenquiry] (" +
                "[enqvno] [nvarchar](20) NOT NULL," +
                "[Enqname] [nvarchar](50)," +
                "[company] [nvarchar](100)," +
                "[address] [nvarchar](100)," +
                "[telephone] [nvarchar](20)," +
                "[mobile] [nvarchar](20)," +
                "[city] [nvarchar](50)," +
                "[state] [nvarchar](70)," +
                "[CId] float," +
                "[email] [nvarchar](30)," +
                "[enqdate] datetime," +
                "[enqtime] datetime," +
                "[Empid] [float] NOT NULL," +
                "[enquiryabout] [nvarchar](70)," +
                "[response] [nvarchar](50)," +
                "[status] float," +
                "[remarks] [nvarchar](100)," +
                "[Aid] [float] NOT NULL," +
                "[description][nvarchar](100)," +
                "[Lid] [float] NOT NULL," +
                "[ItemId] [float] NOT NULL," +
                "[Userfld1] [nvarchar](250)," +
                "[Userfld2] [nvarchar](250)," +
                "[Userfld3] [nvarchar](250)," +
                "[Userfld4] [nvarchar](250)," +
                "[Userfld5] [nvarchar](250)," +
                "[ProductVno][nvarchar](50)," +
                "[VType][nvarchar](50))";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [dbo].[tblCustomerLedger](" +
                  "[Lid] [float] NULL," +
                  "[RegNo] [nvarchar](50) NULL," +
                  "[MakersName] [nvarchar](50)NULL," +
                  "[MakersModel] [nvarchar](50) NULL," +
                  "[EngNo] [nvarchar](50) NULL," +
                  "[ChasNo] [nvarchar](50) NULL," +
                  "[FuelType] [nvarchar](50) NULL," +
                  "[Colour] [nvarchar](50) NULL," +
                  "[YrOfMnfr] [datetime] NULL," +
                  "[TypeOfBody] [nvarchar](50)NULL," +
                  "[ClsOfVehicle] [nvarchar](50) NULL," +
                  "[CC][nvarchar](50) NULL," +
                  "[SeatingCapacity] [int] NULL," +
                  "[GrossWeight] [decimal](18, 0) NULL," +
                  "[NoofCylinder] [int] NULL)";
            _Dbtask.ExecuteNonQuery(sql);

          
        }
        public void CreateProcedureCRM()
        {
            /* For CRM Status ABDUL SAMEEH */
            sql = "CREATE PROCEDURE [dbo].[Insertstatus]" +
                " @Id int," +
                " @Name nvarchar(100)" +
                " AS" +
                " BEGIN" +
                " insert into Tblstatus(Id,Name) values(@Id,@Name)" +
                " END";
            _Dbtask.ExecuteNonQuery(sql);


            /* For CRM LabelChange ABDUL SAMEEH */
            sql = "CREATE PROCEDURE [dbo].[Insertfields]" +
                " @Id int," +
                " @Name nvarchar(100)" +
                " AS" +
                " BEGIN" +
                " insert into TblFields(Id,Name) values(@Id,@Name)" +
                " END";
            _Dbtask.ExecuteNonQuery(sql);

            /* For Currency  ABDUL SAMEEH */
            sql = "CREATE PROCEDURE [dbo].[InsertCurrency]" +
                " @CId float," +
                " @code nvarchar(20)," +
                " @description nvarchar(50)," +
                " @currency nvarchar(30)," +
                " @change nvarchar(30)" +
                " AS" +
                " BEGIN" +
                " insert into TblCurrency (CId,code,description,currency,change) values (@CId,@code,@description,@currency,@change)" +
                " END";
            _Dbtask.ExecuteNonQuery(sql);

            /*For Add Enquiry  ABDUL SAMEEH */
            sql = "CREATE PROCEDURE [dbo].[InsertEnquiry]" +
               " @enqvno nvarchar(20)," +
               " @Enqname nvarchar(50)," +
               " @company nvarchar(100)," +
               " @address nvarchar(100)," +
               " @telephone nvarchar(20)," +
               " @mobile nvarchar(20)," +
               " @city nvarchar(50)," +
               " @state nvarchar(70)," +
               " @CId float," +
               " @email nvarchar(30)," +
               " @enqdate datetime," +
               " @enqtime datetime," +
               " @Empid float," +
               " @enquiryabout nvarchar(70)," +
               " @response nvarchar(50)," +
               " @status float," +
               " @remarks nvarchar(100)," +
               " @Aid float," +
               " @Lid float ," +
               " @ItemId float," +
               " @description nvarchar(250)," +
               " @Userfld1 nvarchar(250)," +
               " @Userfld2 nvarchar(250)," +
               " @Userfld3 nvarchar(250)," +
               " @Userfld4 nvarchar(250)," +
               " @Userfld5 nvarchar(250)," +
               "@ProductVno nvarchar(50)," +
               "@VType nvarchar(50)" +
               " AS" +
               " BEGIN" +
               " insert into Tbladdenquiry (enqvno,Enqname,company,address,telephone,mobile,city,state,CId,email,enqdate,enqtime,Empid,enquiryabout,response,status,remarks,Aid,Lid,ItemId,description,Userfld1,Userfld2,Userfld3,Userfld4,Userfld5,ProductVno,VType) values (@enqvno,@Enqname,@company,@address,@telephone,@mobile,@city,@state,@CId,@email,@enqdate,@enqtime,@Empid,@enquiryabout,@response,@status,@remarks,@Aid,@Lid,@ItemId,@description,@Userfld1,@Userfld2,@Userfld3,@Userfld4,@Userfld5,@ProductVno,@VType)" +
               " END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE PROCEDURE [dbo].[InsertCustomerLedger]" +
                  " @Lid float," +
                  " @RegNo nvarchar(50)," +
                  " @MakersName nvarchar(50)," +
                  " @MakersModel nvarchar(50)," +
                  " @EngNo nvarchar(50)," +
                  " @ChasNo nvarchar(50)," +
                  " @FuelType nvarchar(50)," +
                  " @Colour nvarchar(50)," +
                  " @YrOfMnfr datetime," +
                  " @TypeOfBody nvarchar(50)," +
                  " @ClsOfVehicle nvarchar(50)," +
                  " @CC nvarchar(50)," +
                  " @SeatingCapacity int," +
                  " @GrossWeight decimal(18,5)," +
                  " @NoofCylinder int" +
                  " AS" +
                  " BEGIN" +
                  " insert into tblCustomerLedger(Lid,RegNo,MakersName,MakersModel,EngNo,ChasNo,FuelType,Colour,YrOfMnfr,TypeOfBody,ClsOfVehicle,CC,SeatingCapacity,GrossWeight,NoofCylinder)" +
                  " values (@Lid,@RegNo,@MakersName,@MakersModel,@EngNo,@ChasNo,@FuelType,@Colour,@YrOfMnfr,@TypeOfBody,@ClsOfVehicle,@CC,@SeatingCapacity,@GrossWeight,@NoofCylinder)" +
                  "END";

            _Dbtask.ExecuteNonQuery(sql);
            
        }
        public void DefaultInsertstatus()
        {
            _status.ID = 0;
            _status.Name = "Pending";
            _status.Insertstatus();

            _status.ID = 1;
            _status.Name = "Completed";
            _status.Insertstatus();

        }
        public void DefaultInsertfileds()
        {
            _fileds.ID = 11;
            _fileds.Name = "Vno";
            _fileds.Insertfields();

            _fileds.ID = 12;
            _fileds.Name = "Name";
            _fileds.Insertfields();

            _fileds.ID = 13;
            _fileds.Name = "Company Name";
            _fileds.Insertfields();

            _fileds.ID = 14;
            _fileds.Name = "Address";
            _fileds.Insertfields();

            _fileds.ID = 15;
            _fileds.Name = "Telephone";
            _fileds.Insertfields();

            _fileds.ID = 16;
            _fileds.Name = "Mobile";
            _fileds.Insertfields();

            _fileds.ID = 17;
            _fileds.Name = "City";
            _fileds.Insertfields();

            _fileds.ID = 18;
            _fileds.Name = "State";
            _fileds.Insertfields();

            _fileds.ID = 19;
            _fileds.Name = "Country";
            _fileds.Insertfields();

            _fileds.ID = 20;
            _fileds.Name = "E-mail";
            _fileds.Insertfields();

            _fileds.ID = 21;
            _fileds.Name = "Date";
            _fileds.Insertfields();

            _fileds.ID = 22;
            _fileds.Name = "Time";
            _fileds.Insertfields();

            _fileds.ID = 23;
            _fileds.Name = "Employee";
            _fileds.Insertfields();

            _fileds.ID = 24;
            _fileds.Name = "Enquiry About";
            _fileds.Insertfields();

            _fileds.ID = 25;
            _fileds.Name = "Response";
            _fileds.Insertfields();

            _fileds.ID = 26;
            _fileds.Name = "Status";
            _fileds.Insertfields();

            _fileds.ID = 27;
            _fileds.Name = "Remarks";
            _fileds.Insertfields();

            _fileds.ID = 28;
            _fileds.Name = "Description";
            _fileds.Insertfields();

            _fileds.ID = 29;
            _fileds.Name = "Product";
            _fileds.Insertfields();

            _fileds.ID = 30;
            _fileds.Name = "Agent";
            _fileds.Insertfields();

            _fileds.ID = 31;
            _fileds.Name = "Userfield1";
            _fileds.Insertfields();

            _fileds.ID = 32;
            _fileds.Name = "Userfield2";
            _fileds.Insertfields();

            _fileds.ID = 33;
            _fileds.Name = "Userfield3";
            _fileds.Insertfields();

            _fileds.ID = 34;
            _fileds.Name = "Userfield4";
            _fileds.Insertfields();

            _fileds.ID = 35;
            _fileds.Name = "Userfield5";
            _fileds.Insertfields();

        }
        public void DefInsertParamlist(string Sdelete)
        {
            _Paramlist.ParamName = "Descriptor";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Descriptor";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Deviceid";
            _Paramlist.Paramtype = "0";
           // _Paramlist.ParamValue = System.PlatformID
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "LastBackup";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Periodfrom";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = DateTime.Now.ToString(); 
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Periodto";
            _Paramlist.Paramtype = "0";
            DateTime Dttemp;
            Dttemp = DateTime.Now.AddDays(-1);
            _Paramlist.ParamValue = Dttemp.AddYears(1).ToString();
            _Paramlist.InsertParamlist();


            _Paramlist.ParamName = "Version";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "2.0.1000";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "CurDecc";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "2";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "StockDecc";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "2";
            _Paramlist.InsertParamlist();


            _Paramlist.ParamName = "Majorsymbol";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "Riyal";
            _Paramlist.InsertParamlist();


            _Paramlist.ParamName = "Minersymbol";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "Halala";
            _Paramlist.InsertParamlist();
            //footer
            _Paramlist.ParamName = "Footer1";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = " ";
            _Paramlist.InsertParamlist();
            _Paramlist.ParamName = "Footer2";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = " ";
            _Paramlist.InsertParamlist();
            _Paramlist.ParamName = "Footer3";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = " ";
            _Paramlist.InsertParamlist();
            _Paramlist.ParamName = "Footer4";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = " ";
            _Paramlist.InsertParamlist();
            _Paramlist.ParamName = "Footer5";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = " ";
            _Paramlist.InsertParamlist();
            
            _Paramlist.ParamName = "BankDef";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();


            _Paramlist.ParamName = "SalesmanDef";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

             _Paramlist.ParamName = "DepotDef";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

             _Paramlist.ParamName = "CashDef";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "SDelete";
            _Paramlist.Paramtype = "0";
            _Paramlist.ParamValue = Sdelete;
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "TaxDef";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "VAT";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "product";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = _Gen.Getproducttype();
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Pselect";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "3";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "AB1";
            _Paramlist.Paramtype = "1";
            string temp = Application.StartupPath + "\\Backup";
            _Paramlist.ParamValue = temp;
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "AB2";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "AB3";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "AB4";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Printbarcodein";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "Srate";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Prebarcode";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "ItemSearch";/*For ItemSear 1=First,2=Second,3=Any Key*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "3";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "SB";/*For ItemSear 1=First,2=Second,3=Any Key*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "0";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Bscroll";/*For Back Scroll*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "6";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Fscroll";/*For Front Scroll*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "16";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "LaserTop";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "30";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "LeftBarcode";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "10";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Sprefix";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "2";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "SPrintSelect";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "MaxBcode";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "100";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "CreditLimit";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "Allow";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "MinusCash";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "Allow";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Nocopies";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "1";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "BarcodeHeading";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Pfooter";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Fscroll";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "16";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Reverse";/*For Topof Barcode Print*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "6";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Dissticker";/*ForDistance of Barcode*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "160";
            _Paramlist.InsertParamlist();


            _Paramlist.ParamName = "StrBarcode";/* Add Starting Barcode*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "StrSrate";/* Add String Replace of S.Rate*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "S.Rate";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "PMpayment";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "0";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "PSpayment";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "0";
            _Paramlist.InsertParamlist();


            /*For Grid Column settings */
            _Paramlist.ParamName = "Gmitemname";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "200";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Gmitemcode";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "200";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Gmsrate";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "100";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Gmmrp";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "100";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Gmrack";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "100";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Gmbcode";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "150";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Gmprate";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "100";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Gmbcode";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "150";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Gmprate";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "100";
            _Paramlist.InsertParamlist();

            /**********************************************/
            _Paramlist.ParamName = "Strstock";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "0";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Strbalance";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "0";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Leftleser";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "5";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "Toplaser";
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "0";
            _Paramlist.InsertParamlist();


            /*********Warning************************/
            _Paramlist.ParamName = "WNstock"; /*Warning negetive stock*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "-1";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "WMstock"; /*Warning Minimum stock*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "-1";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "WRstock"; /*Warning Reorder stock*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "-1";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "WMXstock"; /*Warning Maximum stock*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "-1";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "WS<P"; /*Warning  sales rate Less Prate*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = "-1";
            _Paramlist.InsertParamlist();

            _Paramlist.ParamName = "RgDate"; /*Warning  sales rate Less Prate*/
            _Paramlist.Paramtype = "1";
            _Paramlist.ParamValue = DateTime.Now.Date.ToString("dd-MM-yyyy");
            _Paramlist.InsertParamlist();
          /****************************************/


        }
        public void DefInsertManAccount()
        {
             /*Account Group*/

            _AccountGroup.AccountGroupIDLng = 1;
            _AccountGroup.GroupNameStr = "Asset";
            _AccountGroup.UnderInt = 4;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 2;
            _AccountGroup.GroupNameStr = "Liability";
            _AccountGroup.UnderInt = 4;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 3;
            _AccountGroup.GroupNameStr = "Profit & Loss A/C";
            _AccountGroup.UnderInt = 0;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 4;
            _AccountGroup.GroupNameStr = "Balansheet";
            _AccountGroup.UnderInt = 0;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 6;
            _AccountGroup.GroupNameStr = "Expense";
            _AccountGroup.UnderInt = 3;
            _AccountGroup.InsertAccountsGroup();


            _AccountGroup.AccountGroupIDLng = 7;
            _AccountGroup.GroupNameStr = "Income";
            _AccountGroup.UnderInt = 3;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 10;
            _AccountGroup.GroupNameStr = "Current Assets";
            _AccountGroup.UnderInt = 1;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 11;
            _AccountGroup.GroupNameStr = "Current Liability";
            _AccountGroup.UnderInt = 2;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 12;
            _AccountGroup.GroupNameStr = "Direct Expense";
            _AccountGroup.UnderInt = 6;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 13;
            _AccountGroup.GroupNameStr = "Direct Income";
            _AccountGroup.UnderInt = 7;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 14;
            _AccountGroup.GroupNameStr = "Fixed Assets";
            _AccountGroup.UnderInt = 1;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 15;
            _AccountGroup.GroupNameStr = "Indirect Expense";
            _AccountGroup.UnderInt = 6;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 16;
            _AccountGroup.GroupNameStr = "Indirect Income";
            _AccountGroup.UnderInt = 7;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 17;
            _AccountGroup.GroupNameStr = "Long Term Liability";
            _AccountGroup.UnderInt = 2;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 18;
            _AccountGroup.GroupNameStr = "Customer";
            _AccountGroup.UnderInt = 10;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 19;
            _AccountGroup.GroupNameStr = "Supplier";
            _AccountGroup.UnderInt = 11;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 20;
            _AccountGroup.GroupNameStr = "Services";
            _AccountGroup.UnderInt = 13;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 21;
            _AccountGroup.GroupNameStr = "Sales";
            _AccountGroup.UnderInt = 13;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 22;
            _AccountGroup.GroupNameStr = "Employee";
            _AccountGroup.UnderInt = 15;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 23;
            _AccountGroup.GroupNameStr = "TAX Colloected";
            _AccountGroup.UnderInt = 11;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 24;
            _AccountGroup.GroupNameStr = "BANK";
            _AccountGroup.UnderInt = 10;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 25;
            _AccountGroup.GroupNameStr = "CASH";
            _AccountGroup.UnderInt = 10;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 26;
            _AccountGroup.GroupNameStr = "Purchase";
            _AccountGroup.UnderInt = 12;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 27;
            _AccountGroup.GroupNameStr = "Opening Stock";
            _AccountGroup.UnderInt = 12;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 28;
            _AccountGroup.GroupNameStr = "Capital";
            _AccountGroup.UnderInt = 17;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 29;
            _AccountGroup.GroupNameStr = "Agent";
            _AccountGroup.UnderInt = 11;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 30;
            _AccountGroup.GroupNameStr = "Salaries AND Incentives";
            _AccountGroup.UnderInt = 15;
            _AccountGroup.InsertAccountsGroup();

            _AccountGroup.AccountGroupIDLng = 31;
            _AccountGroup.GroupNameStr = "Salaries";
            _AccountGroup.UnderInt = 30;
            _AccountGroup.InsertAccountsGroup();

            /*Account Ledger*/

            _Ledger.LidLng = 1;
            _Ledger.LNameStr = "Cash";
            _Ledger.GidLng = 25;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 2;
            _Ledger.LNameStr = "Sales";
            _Ledger.GidLng = 21;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 3;
            _Ledger.LNameStr = "Purchase";
            _Ledger.GidLng = 26;
            _Ledger.InsertLedger();


            _Ledger.LidLng = 6;
            _Ledger.LNameStr = "Discount Received";
            _Ledger.GidLng = 16;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 7;
            _Ledger.LNameStr = "Discount Allowed";
            _Ledger.GidLng = 15;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 8;
            _Ledger.LNameStr = "VAT Paid";
            _Ledger.GidLng = 23;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 9;
            _Ledger.LNameStr = "VAT Collected";
            _Ledger.GidLng = 23;
            _Ledger.InsertLedger();


            _Ledger.LidLng = 10;
            _Ledger.LNameStr = "Excise Duty";
            _Ledger.GidLng = 16;
            _Ledger.InsertLedger();


            _Ledger.LidLng = 11;
            _Ledger.LNameStr = "Round Off Received";
            _Ledger.GidLng = 15;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 12;
            _Ledger.LNameStr = "Round Off Allowed";
            _Ledger.GidLng = 13;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 13;
            _Ledger.LNameStr = "Profit or Loss for Previous Year";
            _Ledger.GidLng = 2;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 14;
            _Ledger.LNameStr = "Service Account";
            _Ledger.GidLng = 20;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 15;
            _Ledger.LNameStr = "Service Tax";
            _Ledger.GidLng = 20;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 16;
            _Ledger.LNameStr = "Discount on Service";
            _Ledger.GidLng = 15;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 17;
            _Ledger.LNameStr = "Sales Return Account";
            _Ledger.GidLng = 21;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 18;
            _Ledger.LNameStr = "Purchase Return Account";
            _Ledger.GidLng = 26;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 19;
            _Ledger.LNameStr = "Opening Stock";
            _Ledger.GidLng = 27;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 20;
            _Ledger.LNameStr = "Capital";
            _Ledger.GidLng = 28;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 21;
            _Ledger.LNameStr = "Cheques Received";
            _Ledger.GidLng = 10;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 22;
            _Ledger.LNameStr = "Credit Card Received";
            _Ledger.GidLng = 10;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 23;
            _Ledger.LNameStr = "Agent Commission";
            _Ledger.GidLng = 15;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 24;
            _Ledger.LNameStr = "CST Received";
            _Ledger.GidLng = 21;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 25;
            _Ledger.LNameStr = "CST Paid";
            _Ledger.GidLng = 26;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 26;
            _Ledger.LNameStr = "Otherexpenseonsales";
            _Ledger.GidLng = 15;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 27;
            _Ledger.LNameStr = "Cooly";
            _Ledger.GidLng = 12;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 28;
            _Ledger.LNameStr = "BANK";
            _Ledger.GidLng = 24;
            _Ledger.InsertLedger();

            _Ledger.LidLng = 29;
            _Ledger.LNameStr = "Salary";
            _Ledger.GidLng = 30;
            _Ledger.InsertLedger();
        }

        public void CreateProcedure()
        {
            sql = "CREATE   PROCEDURE [dbo].[Insertunitssrates] @Uid float,@itemid float,"+
           " @Prate  decimal(18, 5),@Srate  decimal(18, 5),@Mrp  decimal(18, 5),@Wrate  decimal(18, 5), " +
          " @Wrate1  decimal(18, 5), @Wrate2  decimal(18, 5), @Wrate3  decimal(18, 5) "+
          " AS BEGIN insert into Tblunitsrates (Uid,Itemid,Prate,Srate,Mrp,Wrate,Wrate1,Wrate2,wrate3) values " +
          "(@Uid,@Itemid,@Prate,@Srate,@Mrp,@Wrate,@Wrate1,@Wrate2,@wrate3)  END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE   PROCEDURE [dbo].[Insertarea] @Aid float, @Aname [nvarchar](50) " +
            " AS BEGIN insert into Tblarea (Aid,Aname) values " +
            "(@Aid,@Aname) END";
            _Dbtask.ExecuteNonQuery(sql);



            sql = "CREATE   PROCEDURE [dbo].[insertAMCdetails] " +
           " @Amccdkey [nvarchar](500) ," +
           " @Amcproductid [nvarchar](500) ," +
           " @Amcregnumber  [nvarchar](500) " +

           " AS BEGIN insert into TblAMCdetails (Amccdkey,Amcproductid,Amcregnumber) values " +
           "(@Amccdkey,@Amcproductid,@Amcregnumber)  END";
            _Dbtask.ExecuteNonQuery(sql);








            sql = "create PROCEDURE [dbo].[Inserttaillor]" +
  "@vno float," +
  "@Cname [nvarchar](50)," +
  "@lid [nvarchar](50)," +
  "@sleev [nvarchar](50)," +
  "@collor [nvarchar](50)," +
  "@bttntype [nvarchar](50)," +
  "@bttn [nvarchar](50)," +
  "@Deldate [datetime] ," +
  "@Ardate [datetime] " +
  " AS" +
  " BEGIN" +
  " insert into Tbltaillor(vno,Cname,lid,sleev,collor,bttntype,bttn,Deldate,Ardate) values (@vno,@Cname,@lid,@sleev,@collor,@bttntype,@bttn,@Deldate,@Ardate)" +
  " END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "create PROCEDURE [dbo].[Inserttaillordetails]" +
            "@vno float," +
            "@lid [nvarchar](50)," +
            "@length [nvarchar](50)," +
            "@chest [nvarchar](50)," +
            "@bottom [nvarchar](50)," +
            "@sleevL [nvarchar](50)," +
            "@Sholder [nvarchar](50)," +
            "@waist [nvarchar](50)," +
            "@neck [nvarchar](50)," +
            "@material [nvarchar](50)," +
            "@model [nvarchar](50)," +
            "@color [nvarchar](50)" +

            " AS" +
            " BEGIN" +
            " insert into TbltaillorDetails(vno,lid,length,chest,bottom,sleevL,Sholder,waist,neck,material,model,color) " +
            "values (@vno,@lid,@length,@chest,@bottom,@sleevL,@Sholder,@waist,@neck,@material,@model,@color)" +
            " END";
            _Dbtask.ExecuteNonQuery(sql);


            sql = "CREATE   PROCEDURE [dbo].[Insertcolor] @cid float, @cname [nvarchar](50) " +
                          " AS BEGIN insert into Tblcolor (cid,cname) values " +
                         "(@cid,@cname) END";
            _Dbtask.ExecuteNonQuery(sql);



            //icon
            sql = "CREATE   PROCEDURE [dbo].[Inserticon] @xvalue float,@yvalue float, @icon [nvarchar](50) " +
        " AS BEGIN insert into Tblicon (xvalue,yvalue,icon) values " +
        "(@xvalue,@yvalue,@icon) END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE   PROCEDURE [dbo].[Insertcommision] @Cid float, @Cname [nvarchar](50) " +
            ",@Cperc  decimal(18, 5),@Cfromamount  decimal(18, 5), " +
            "@Ctoamount  decimal(18, 5),@Cfor [nvarchar](50) " +
            " AS BEGIN insert into Tblcommision (Cid,Cname,Cperc,Cfromamount,Ctoamount,Cfor) values " +
            "(@Cid,@Cname,@Cperc,@Cfromamount,@Ctoamount,@Cfor) END";
            _Dbtask.ExecuteNonQuery(sql);

            /*For Dress Making*/
            sql = "CREATE   PROCEDURE [dbo].[Insertdressmaster] @vno float, @Customer float, "+
            "@Vdate datetime,@ddate datetime,@Chest  decimal(18, 5),@Waist  decimal(18, 5), "+
            "@Neck  decimal(18, 5),@Height  decimal(18, 5),@Shapping  decimal(18, 5), "+
            "@Length  decimal(18, 5),@Loose  decimal(18, 5),@Sholder  decimal(18, 5),@SholderL  decimal(18, 5)," +
            "@Sholderw  decimal(18, 5),@NeckF  decimal(18, 5),@NeckB  decimal(18, 5),@PantL  decimal(18, 5)," +
            "@PantW  decimal(18, 5),@Pant  [nvarchar](50)," +
             "@itemid  float,@Qty  decimal(18, 5),@rate  decimal(18, 5),@adamount  decimal(18, 5),@Dl int " +
            " AS BEGIN insert into tbldressmaster (vno,Customer,Vdate,Ddate,Chest,Waist,Neck, "+
            " Height,Shapping,Length,Loose,Sholder,SholderL,Sholderw,NeckF,NeckB,PantL,Pantw,pant,itemid,Qty,rate,adamount,Dl) values "+
            "(@vno,@Customer,@Vdate,@Ddate,@Chest,@Waist,@Neck, "+
            "@Height,@Shapping,@Length,@Loose,@Sholder,@SholderL,@Sholderw,@NeckF,@NeckB,@PantL,@Pantw,@pant,@itemid,@Qty,@rate,@adamount,@Dl) END";
            _Dbtask.ExecuteNonQuery(sql);

            ///*For Dress Making*/
            //sql = "CREATE   PROCEDURE [dbo].[Insertdressdetails] @vno float, @item float " +
            //",@Qty  decimal(18, 5),@srate  decimal(18, 5), " +
            //"@amount  decimal(18, 5) " +
            //" AS BEGIN insert into Tbldressdetail (vno,item,Qty,srate,Amount) values " +
            //"(@vno,@item,@Qty,@srate,@Amount) END";
            //_Dbtask.ExecuteNonQuery(sql);



            /*********************************************************/
            sql = "create PROCEDURE [dbo].[Insertattendancemain]" +
             "@vno [nvarchar](50)," +
             "@amode float," +
             "@adate [datetime] " +
             " AS" +
             " BEGIN" +
             " insert into tblattendancemain(vno,amode,adate) values (@vno,@amode,@adate)" +
             " END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "create PROCEDURE [dbo].[Insertattendancedetail]" +
             "@vno [nvarchar](50)," +
             "@slno [nvarchar](50)," +
             "@lid float," +
             "@amark int ," +
             "@ovmark int ," +
             "@salary [decimal](18, 5), " +
             "@extra [decimal](18, 5), " +
             "@extra2 [decimal](18, 5), " +
             "@note [nvarchar](200) " +
             " AS" +
             " BEGIN" +
             " insert into tblattendancedetail(vno,slno,lid,amark,ovmark,salary,extra,extra2,note) values (@vno,@slno,@lid,@amark,@ovmark,@salary,@extra,@extra2,@note)" +
             " END";
            _Dbtask.ExecuteNonQuery(sql);

            /****************************************************/

            sql = "create PROCEDURE [dbo].[InsertBillsett] @vno nvarchar (50), @vtype nvarchar (50), @ledcode float, "+
                    " @Dbamt decimal(18,5),@cramt decimal(18,5),@agvno nvarchar(50),@dt datetime,@Emp float " +
                    " AS BEGIN INSERT INTO tblbillsett(vno,vtype,ledcode,dbamt,cramt,agvno,Dt,Emp)  " +
                    " VALUES(@vno,@vtype,@ledcode,@dbamt,@cramt,@agvno,@dt,@Emp) END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "create PROCEDURE [dbo].[InsertRemainder]" +
                "@Rid float," +
                "@Rname [nvarchar](50)," +
                "@Rsubject [nvarchar](250)," +
                "@Rdate [datetime] ," +
                "@Rstatus int " +
                " AS" +
                " BEGIN" +
                " insert into Tblremainder(Rid,Rname,Rsubject,Rdate,Rstatus) values (@Rid,@Rname,@Rsubject,@Rdate,@Rstatus)" +
                " END";
            _Dbtask.ExecuteNonQuery(sql);


            sql = "create PROCEDURE [dbo].[Insertpartyproject]" +
                "@pid float," +
                "@pname [nvarchar](50)," +
                "@partyid float" +
                " AS" +
                " BEGIN" +
                " insert into Tblpartyproject(pid,pname,partyid) values (@pid,@pname,@partyid)" +
                " END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "create PROCEDURE [dbo].[Insertpricecode]" +
                    "@field [nvarchar](50)," +
                    "@code [nvarchar](50)" +
                    " AS" +
                    " BEGIN" +
                    " insert into Tblpricecode(field,code) values (@field,@code)" +
                    " END";
            _Dbtask.ExecuteNonQuery(sql);


            sql = "create PROCEDURE [dbo].[Insertchequereceived]" +
                      "@Id float," +
                      "@Pdate datetime," +
                      "@Alid float," +
                      "@Blid float," +
                      "@Amount [decimal](18, 5)," +
                      "@ChequeNo [nvarchar](50)," +
                      "@Status [nvarchar](50)," +
                      "@CDate datetime," +
                      "@CollDate datetime," +
                      "@Note [nvarchar](50)," +
                      "@CMode int," +
                      "@Genid float," +
                      "@Discount [decimal](18, 5)," +
                      "@Emp float," +
                      "@Agvno [nvarchar](50)," +
                      "@TotAmt [decimal](18, 5)" +
                      " AS" +
                      " BEGIN" +
                      " insert into Tblchqreceived(Id,Pdate,Alid,Blid,Amount,ChequeNo," +
                      " Status,CDate,CollDate,Note,CMode,Genid,Discount,Emp,Agvno,TotAmt " +
                      " ) values (@Id,@Pdate,@Alid,@Blid,@Amount,@ChequeNo,@Status,@CDate,@CollDate,@Note,@CMode,@Genid,@Discount,@Emp,@Agvno,@TotAmt)" +
                      " END";
            _Dbtask.ExecuteNonQuery(sql);


             sql = "create PROCEDURE [dbo].[InsertUnitcreation]" +
                "@Id float," +
                "@Name nvarchar(200)," +
                "@ucount [decimal](18, 5)" +
                " AS" +
                " BEGIN" +
                " insert into tblUnitcreation(Id,Name,ucount) values (@id,@Name,@ucount)" +
                " END";
            _Dbtask.ExecuteNonQuery(sql);


            sql = "create PROCEDURE [dbo].[InsertBaseunit]" +
               "@Id float," +
               "@Name nvarchar(200)" +
              
               " AS" +
               " BEGIN" +
               " insert into tblbaseunit(Id,Name) values (@id,@Name)" +
               " END";
            _Dbtask.ExecuteNonQuery(sql);

            /*For VoucherType*/
            sql = "create PROCEDURE [dbo].[InsertVoucherType]" +
                "@Vname nvarchar(200)," +
                "@UndrVouchr nvarchar(200)," +
                "@ItemCategryId int," +
                "@ItemClass nvarchar(100)," +
                "@Printer nvarchar(200)," +
                "@Lid int" +
                " AS" +
                " BEGIN" +
                " insert into tblVoucherType (Vname,UndrVouchr,ItemCategryId,ItemClass,Printer,Lid)" +
                " values (@Vname,@UndrVouchr,@ItemCategryId,@ItemClass,@Printer,@Lid)" +
                " END";
            _Dbtask.ExecuteNonQuery(sql);


            sql = "create PROCEDURE [dbo].[InsertMenus]" +
            "@id float," +
            "@MenuName [nvarchar](200)" +
            " AS" +
            " BEGIN" +
            " insert into tblmenus (id,menuname)" +
            " values (@id,@menuname)" +
            " END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "create PROCEDURE [dbo].[Insertrepacking]" +
            "@VNo float," +
            "@VDate datetime," +
            "@PackDate datetime," +
            "@Narretion nvarchar(200)," +
            "@SlNo nvarchar(50)," +
            "@ItemId float," +
            "@BatchCode nvarchar(50)," +
            "@QTY decimal(18,5)," +
            "@PRate decimal(18,5)," +
            "@CRate decimal(18,5)," +
            "@SRate decimal(18,5)," +
            "@MRP decimal(18,5)," +
            "@Amount decimal(18,5), " +
            "@DepoId decimal(18,5), " +
            "@LabourCharge decimal(18,5)," +
            "@CostFactor decimal(18,5) " +
            " AS" +
            " BEGIN" +
            " insert into tblRepacking (VNo,VDate,PackDate,Narretion,SlNo,ItemId,BatchCode,QTY,PRate,CRate,SRate,MRP,Amount,DepoId,LabourCharge,CostFactor)" +
            " values (@VNo,@VDate,@PackDate,@Narretion,@SlNo,@ItemId,@BatchCode,@QTY,@PRate,@CRate,@SRate,@MRP,@Amount,@DepoId,@LabourCharge,@CostFactor)" +
            " END";
            _Dbtask.ExecuteNonQuery(sql);

            /*For RepackingDetails*/
            /*For RepackingDetails*/
            sql = "create PROCEDURE [dbo].[Insertrepackingdetails]" +
            "@Vno float," +
            "@SlNo nvarchar(50)," +
            "@ItemId float," +
            "@BatchCode nvarchar(50)," +
            "@QTY decimal(18,5)," +
            "@PRate decimal(18,5)," +
            "@CRate decimal(18,5)," +
            "@SRate decimal(18,5)," +
            "@MRP decimal(18,5)," +
            "@Amount decimal(18,5)," +
            "@DepoId decimal(18,5) " +
            " AS" +
            " BEGIN" +
            " insert into TblRepackingDetails (Vno,SlNo,ItemId,BatchCode,QTY,PRate,CRate,SRate,MRP,Amount,DepoId)" +
            " values (@Vno,@SlNo,@ItemId,@BatchCode,@QTY,@PRate,@CRate,@SRate,@MRP,@Amount,@DepoId)" +
            " END";
            _Dbtask.ExecuteNonQuery(sql);


            /*For  /*For TempContacts */
           sql= "create PROCEDURE [dbo].[Inserttempcontact]" +
       " @tid float," +
       " @tname nvarchar(50)," +
       " @tmobile nvarchar(50)," +
       " @taddress nvarchar(200)," +
       " @area nvarchar(50), " +
       " @temail nvarchar(50) " +
       " AS" +
       " BEGIN" +
       " insert into   tbltempcontact (tid,tname,tmobile,taddress,area,temail) " +
       "values   (@tid,@tname,@tmobile,@taddress,@area,@temail)" +
       " RETURN" +
       " END";
            _Dbtask.ExecuteNonQuery(sql);

            /*For Slno Tracking*/
        sql = "CREATE PROCEDURE [dbo].[Insertslnotracking]" +
        " @itemid float," +
        " @Slno  nvarchar(50)," +
        " @vtype  nvarchar(50)," +
        " @vno  nvarchar(50)," +
        " @slstatus  int " +
        " AS" +
        " BEGIN" +
        " insert into tblslnotracking (itemid,Slno,vtype,vno,slstatus)" +
        " values (@itemid,@Slno,@vtype,@vno,@slstatus)" +
        " END";
        _Dbtask.ExecuteNonQuery(sql);

        /*For Customer Point*/
        sql = "CREATE PROCEDURE [dbo].[Insertcustomerpoint]" +
        " @cpid float," +
        " @cardname  nvarchar(50)," +
        " @validfrom  datetime," +
        " @validto  datetime," +
        " @salevalue  decimal(18,5)," +
        " @point  decimal(18,5)," +
        " @discount  decimal(18,5)"+
        " AS" +
        " BEGIN" +
        " insert into tblcustomerpoint (cpid,cardname,validfrom,validto,salevalue,point,discount)" +
        " values (@cpid,@cardname,@validfrom,@validto,@salevalue,@point,@discount)" +
        " END";
        _Dbtask.ExecuteNonQuery(sql);

        /*For Size Detail*/
         sql = "CREATE PROCEDURE [dbo].[Insertsizesdetail]" +
        " @ItemSizename nvarchar(50)," +
        " @Sname  nvarchar(50)" +
        " AS" +
        " BEGIN" +
        " insert into TblsizesDetail (ItemSizename,Sname) values (@ItemSizename,@Sname)" +
        " END";
        _Dbtask.ExecuteNonQuery(sql);
        /*For Size*/
        sql = "CREATE PROCEDURE [dbo].[Insertsizes]" +
        " @Sid float," +
        " @Sname  nvarchar(50)," +
        " @sremarks  nvarchar(200)" +
        " AS" +
        " BEGIN" +
        " insert into tblsizes (sid,sname,sremarks) values (@sid,@sname,@sremarks)" +
        " END";
        _Dbtask.ExecuteNonQuery(sql);

        /*Production Product Sett*/

        sql = "CREATE PROCEDURE [dbo].[Insertproductsett]" +
        " @id float," +
        " @Bcode nvarchar(50),"+
        " @item float," +
        " @mrate decimal(18,5)" +
        " AS" +
        " BEGIN" +
        " insert into tblproductsett (id,Bcode,item,mrate) values (@id,@Bcode,@item,@mrate)" +
        " END";
        _Dbtask.ExecuteNonQuery(sql);

        sql = "CREATE PROCEDURE [dbo].[Insertproductsettdetail]" +
        " @id float," +
        " @slno float," +
        " @Bcode nvarchar(50)," +
        " @item float," +
        " @qty decimal(18,5)," +
        " @rate decimal(18,5)" +
        " AS" +
        " BEGIN" +
        " insert into tblproductsettdetail (id,slno,bcode,item,qty,rate) values (@id,@slno,@Bcode,@item,@qty,@rate)" +
        " END";
        _Dbtask.ExecuteNonQuery(sql);

        /*Production Issue Product*/

        sql = "CREATE PROCEDURE [dbo].[Insertissueproduct]" +
        " @vno float," +
        " @employee float," +
        " @issuedate datetime," +
        " @remarks nvarchar(50)," +
        " @istatus int," +
        " @tvno float" +
        " AS" +
        " BEGIN" +
        " insert into tblissueproduct (vno,employee,issuedate,remarks,istatus,tvno) values (@vno,@employee,@issuedate,@remarks,@istatus,@tvno)" +
        " END";
        _Dbtask.ExecuteNonQuery(sql);

        sql = "CREATE PROCEDURE [dbo].[Insertissueproductdetail]" +
        " @issueid float," +
        " @slno float," +
        " @Bcode nvarchar(50)," +
        " @item float," +
        " @qty decimal(18,5)," +
        " @rate decimal(18,5)" +
        " AS" +
        " BEGIN" +
        " insert into tblissueproductdetail (issueid,slno,Bcode,item,qty,rate) values (@issueid,@slno,@Bcode,@item,@qty,@rate)" +
        " END";
            _Dbtask.ExecuteNonQuery(sql);
            /******************************************************/
           
            /*For Received Product*/

        sql = "CREATE PROCEDURE [dbo].[Insertreceivedproduct]" +
        " @gvno float," +
        " @Bvno float," +
        " @issueid float," +
        " @id float," +
        " @Recdate datetime," +
        " @item decimal(18,5)," +
        " @qty decimal(18,5)" +
        " AS" +
        " BEGIN" +
        " insert into tblreceivedproduct (gvno,bvno,issueid,id,Recdate,item,qty) values (@gvno,@bvno,@issueid,@id,@Recdate,@item,@qty)" +
        " END";
            _Dbtask.ExecuteNonQuery(sql);

        sql = "CREATE PROCEDURE [dbo].[Insertreceivedproductdetail]" +
        " @id float," +
        " @slno float," +
        " @Bcode nvarchar(50),"+
        " @item decimal(18,5)," +
        " @qty decimal(18,5)," +
        " @rate decimal(18,5)" +
        " AS" +
        " BEGIN" +
        " insert into tblreceivedproductdetail (id,slno,Bcode,item,qty,rate) values (@id,@slno,@Bcode,@item,@qty,@rate)" +
        " END";
            _Dbtask.ExecuteNonQuery(sql);


            /******************************************************************************/
/*Insert AccountGroup*/

sql="CREATE PROCEDURE [dbo].[InsertAccount]"+
" @AGroupId float,"+
" @AGroupName nvarchar(50),"+
" @AUnder int"+
" AS"+
" BEGIN"+
" insert into tblaccountGroup (AgroupId,AgroupName,AUnder) values (@AGroupId,@AGroupName,@AUnder)"+
" END";
_Dbtask.ExecuteNonQuery(sql);
/*Insert Agent*/


sql="CREATE PROCEDURE [dbo].[InsertAgent]"+
" @Aid float,"+
" @Aname nvarchar (50),"+
" @Acode nvarchar(50),"+
" @Comm decimal(18,5),"+
" @Post int"+
" AS"+
" BEGIN"+
" INSERT INTO SomeTable(Aid,Aname,Acode,Comm,Post) VALUES(@Aid,@Aname,@Acode,@Comm,@Post)"+
" END";
_Dbtask.ExecuteNonQuery(sql);

/*Insert Businessissue*/


//" @cpdiscount nvarchar(50)," +
//" @Mpayment nvarchar(50)" +

sql = "create PROCEDURE [dbo].[InsertBusinessIssue]" +
" @opno int," +
" @IssueCode float," +
" @Vno nvarchar(50)," +
" @IssueType nvarchar(50)," +
" @Dcode nvarchar(50)," +
" @IssueDate datetime," +
" @LedcodeCr nvarchar(50)," +
" @LedcodeDr nvarchar(50)," +
" @Amt decimal(18, 5)," +
" @Remarks nvarchar(200)," +
" @Empid nvarchar(50)," +
" @DiscAmt decimal(18, 5)," +
" @invdisc decimal(18, 5)," +
" @TaxAmt decimal(18, 5)," +
" @Cooly decimal(18, 5)," +
" @AdAmount decimal(18, 5)," +
" @Agent nvarchar(50)," +
" @pvno nvarchar(50)," +
" @Taxid nvarchar(50)," +
" @Tename nvarchar(50)," +
" @cpdiscount nvarchar(50)," +
" @Mpayment int,"+
" @CashReceived nvarchar(50)," +
" @SR nvarchar(50)," +
" @Uid nvarchar(50) ," +
" @Pproject float ," +
" @warranty nvarchar(50) " +
" AS" +
" BEGIN" +
" INSERT INTO TblbusinessIssue(opno,IssueCode,Vno,IssueType,Dcode,IssueDate,LedcodeCr,LedcodeDr,Amt,Remarks,Empid,DiscAmt,invdisc,TaxAmt,Cooly,AdAmount,Agent,pvno,taxid,Tename,cpdiscount,Mpayment,CashReceived,SR,Uid,pproject,warranty )" +
"					   VALUES(@opno,@IssueCode,@Vno,@IssueType,@Dcode,@IssueDate,@LedcodeCr,@LedcodeDr,@Amt,@Remarks,@Empid,@DiscAmt,@invdisc,@TaxAmt,@Cooly,@AdAmount,@Agent,@pvno,@Taxid,@Tename,@cpdiscount,@Mpayment,@CashReceived,@SR,@Uid,@pproject,@warranty )" +
" END";

_Dbtask.ExecuteNonQuery(sql);
/*Insert CompanyMaster*/

sql = "create  PROCEDURE [dbo].[Insertcompanymaster]" +
               " @cname nvarchar(50)," +
               " @tax int ," +
               " @Address1 nvarchar(100)," +
               " @Address2 nvarchar(100)," +
               " @city nvarchar(50) ," +
               " @state nvarchar(50)," +
               " @pcode nvarchar(50) ," +
               " @telephone nvarchar(50)," +
               " @mobile nvarchar(50)," +
               " @Fax nvarchar(50) ," +
               " @Email nvarchar(50)," +
               " @website nvarchar(50)," +
               " @accountno nvarchar(50)," +
               " @taxno1 nvarchar(50)," +
               " @taxno2 nvarchar(50)," +
               " @VATno nvarchar(50)," +
               " @country nvarchar(50)," +
               " @NoOfDecimal nvarchar(50)," +
               " @FYearFrom datetime," +
               " @FYearTo datetime," +
               " @CStatus int, " +
               " @Nameinhome nvarchar(50)," +
               " @CusId nvarchar(50)," +
               " @CusArea nvarchar(50)," +
               " @Sellersname nvarchar(50)," +
               " @TRN nvarchar(50)" +

               " AS" +
               " BEGIN" +
               " insert into tblcompanymaster(Cname,tax,address1,address2,city,state,pcode,Telephone,mobile,Fax,email,website," +
               " accountNo,Taxno1,Taxno2,Vatno,Country,NoOfDecimal,FYearFrom,FYearto,cstatus,Nameinhome,CusId,CusArea,Sellersname,TRN) values(@cname,@tax,@address1,@address2,@city,@state,@pcode," +
               " @telephone,@Mobile,@fax,@Email,@Website,@accountno,@taxno1,@taxno2,@vatno,@country,@noofdecimal,@fyearfrom,@fyearTo,@CStatus,@Nameinhome,@CusId,@CusArea,@Sellersname,@TRN)" +
               " END";
_Dbtask.ExecuteNonQuery(sql);
/*Insert Department*/

sql="CREATE PROCEDURE [dbo].[InsertDepartment]"+
" @Depid float,"+
" @Depname nvarchar (50)"+
" AS"+
" BEGIN"+
" INSERT INTO TblDepartment(Depid, Depname) VALUES(@Depid,@Depname)"+
" END";
 _Dbtask.ExecuteNonQuery(sql); 


/*Insert Depot*/


sql="CREATE PROCEDURE [dbo].[InsertDepot]"+
" @Dcode float,"+
" @Dname nvarchar(50),"+
" @VehicleNo int,"+
" @Address nvarchar(200),"+
" @City nvarchar(50),"+
" @Pin nvarchar(50),"+
" @Phoneno nvarchar(50),"+
" @Mobile nvarchar(50),"+
" @Cperson nvarchar(50),"+
" @RegNo nvarchar(50),"+
" @Lisenseno nvarchar(50),"+
" @Description nvarchar(50)"+
" AS"+
" BEGIN"+
" INSERT INTO TblDepot(Dcode,Dname,VehicleNo,Address,City,Pin,Phoneno,Mobile,Cperson,RegNo,Lisenseno,Description)"+
" VALUES(@Dcode,@Dname,@VehicleNo,@Address,@City,@Pin,@Phoneno,@Mobile,@Cperson,@RegNo,@Lisenseno,@Description)"+
" END";
              _Dbtask.ExecuteNonQuery(sql); 
/*Insert Employeemaster*/


sql=" CREATE PROCEDURE [dbo].[InsertEmployeeMaster]"+
 " @EmpId float,"+
 " @Empname nvarchar (50),"+
" @Sex nvarchar (10),"+
" @Department nvarchar(50),"+
" @mobile nvarchar(50),"+
" @Address nvarchar(50),"+
" @Email nvarchar(50),"+
" @DJoining datetime,"+
" @Salary decimal(18, 5),"+
" @Phone nvarchar(50),"+
" @PassportNo nvarchar(50),"+
" @VisaNo nvarchar(50),"+
" @EStatus int,"+
" @EmpCode nvarchar(50),"+
" @Commi decimal(18, 5),"+
" @mpayment nvarchar(50)" +
" AS"+
" BEGIN"+
" INSERT INTO TblEmployeemaster (EmpId,Empname,Sex,Department,mobile,Address,Email,DJoining,Salary,Phone,PassportNo,VisaNo,EStatus,EmpCode,Commi,mpayment)"+
" VALUES (@EmpId,@Empname,@Sex,@Department,@mobile,@Address,@Email,@DJoining,@Salary,@Phone,@PassportNo,@VisaNo,@EStatus,@EmpCode,@Commi,@mpayment)" +
" END";

 _Dbtask.ExecuteNonQuery(sql); 
/*Insert Generalledger*/


sql="CREATE PROCEDURE [dbo].[InsertGeneralLedger]"+
" @vdate datetime,"+
" @vtype nvarchar (50),"+
" @vno nvarchar(50),"+
" @Slno float,"+
" @Ledcode nvarchar(50),"+
" @purticulars nvarchar(50),"+
" @DbAmt decimal(18, 5),"+
" @CrAmt decimal(18, 5),"+
" @Naration2 nvarchar(200)," +
" @Naration nvarchar(200),"+
" @RefNo nvarchar(50),"+
" @Employee nvarchar(50),"+
" @Uid nvarchar(50)," +
" @pproject float," + 
" @discount  decimal(18, 5)," +
" @BillBalance  decimal(18, 5)," + 
" @RecvdAmt decimal(18,5)"+

" AS"+
" BEGIN"+
" insert into Tblgeneralledger(vdate,vtype,vno,Slno,Ledcode,purticulars,DbAmt,CrAmt,Naration2,Naration,RefNo,Employee,Uid,pproject,discount,BillBalance,RecvdAmt) values" +
" (@vdate,@vtype,@vno,@Slno,@Ledcode,@purticulars,@DbAmt,@CrAmt,@Naration2,@Naration,@RefNo,@Employee,@Uid,@pproject,@discount,@BillBalance,@RecvdAmt)" +
" END";

 _Dbtask.ExecuteNonQuery(sql); 
/*Insert Interneltransfer*/

sql="CREATE PROCEDURE [dbo].[InsertInternelTransfer]"+
" @TCode float,"+
" @Dcodefrom int,"+
" @DcodeTo int,"+
" @TDate datetime,"+
" @Remarks nvarchar(200)"+

" AS"+
" BEGIN"+
" INSERT INTO TblInterneltransfer(Tcode,Dcodefrom,DcodeTo,TDate,Remarks)"+
" VALUES(@Tcode,@Dcodefrom,@DcodeTo,@TDate,@Remarks)"+
" END";
  _Dbtask.ExecuteNonQuery(sql); 
/*Insert Inventory*/


  sql = "create PROCEDURE [dbo].[InsertInventory]" +
  " @Dcode nvarchar(50)," +
  " @InvDate datetime," +
  " @Pcode nvarchar(50)," +
  " @Os decimal(18, 5)," +
  " @Purchase decimal(18, 5)," +
  " @Mr decimal(18, 5)," +
  " @Sr decimal(18, 5)," +
  " @Ireceipt decimal(18, 5)," +
  " @bmr decimal(18, 5)," +
  " @Sales decimal(18, 5)," +
  " @dn decimal(18, 5)," +
  " @dnr decimal(18, 5)," +
  " @ps decimal(18, 5)," +
  " @pr decimal(18, 5)," +
  " @iissue decimal(18, 5)," +
  " @Sh decimal(18, 5)," +
  " @dmg decimal(18, 5)," +
  " @bmi decimal(18, 5)," +
  " @vcode nvarchar(50)," +
  " @Ledcode nvarchar(50)," +
  " @costcenter nvarchar(50)," +
  " @freepre decimal(18, 5)," +
  " @freeiss decimal(18, 5)," +
  " @batchcode nvarchar(50)," +
  " @Slno nvarchar(50)," +
  " @UC  decimal(18, 5)," +
  " @Exdate  datetime" +
  " AS" +
  " BEGIN" +
   " insert into Tblinventory (Dcode,InvDate,Pcode,Os,Purchase,Mr,Sr,Ireceipt,bmr,Sales,dn,dnr,ps,pr,iissue,Sh,dmg,bmi,vcode,ledcode,costcenter,batchcode,freepre,freeiss,Slno,UC,Exdate)" +
   " values (@Dcode,@InvDate,@Pcode,@Os,@Purchase,@Mr,@Sr,@Ireceipt,@bmr,@Sales,@dn,@dnr,@ps,@pr,@iissue,@Sh,@dmg,@bmi,@vcode,@ledcode,@costcenter,@batchcode,@freepre,@freeiss,@Slno,@UC,@Exdate)" +

  " END";
 _Dbtask.ExecuteNonQuery(sql); 

/*Insert Issuedetails*/

 sql = "create PROCEDURE [dbo].[InsertIssueDetails]" +
 " @IssueCode float," +
 " @Slno float," +
 " @Pcode nvarchar(50)," +
 " @Unitid float," +
 " @BatchId nvarchar(50)," +
 " @MultirateId float," +
 " @Qty decimal(18, 5)," +
 " @Qty1 decimal(18, 5)," +
 " @Qty2 decimal(18, 5)," +
 " @pnum float," +
 " @FreeQty decimal(18, 5)," +
 " @Rate decimal(18, 5)," +
 " @CRate decimal(18, 5)," +
 " @DiscRate decimal(18, 5)," +
 " @billdisc decimal(18, 5)," +
 " @Taxrate decimal(18, 5)," +
 " @NetAmt decimal(18, 5)," +
 " @ItemNote nvarchar(50)," +
 " @Mrp decimal(18, 5)," +
 " @Ledcode nvarchar(50)," +
 " @Vtype nvarchar(50)," +
 " @Taxper decimal(18, 5)," +
 " @lth decimal(18, 5)," +
 " @wth decimal(18, 5)," +
 " @Slnotracking nvarchar(50)," +
 " @Exdate Datetime" +
 " AS" +
 " BEGIN" +
 " INSERT INTO TblIssuedetails(IssueCode,Slno,Pcode,Unitid,BatchId,MultirateId,Qty,Qty1,Qty2,pnum,FreeQty,Rate,Crate,DiscRate,billdisc,Taxrate,NetAmt,ItemNote,ledcode,Mrp,vtype,Taxper,lth,wth,Slnotracking,Exdate)" +

 " VALUES" +
 " (@IssueCode, @Slno,@Pcode,@Unitid,@BatchId,@MultirateId,@Qty,@Qty1,@Qty2,@pnum,@FreeQty,@Rate,@Crate,@DiscRate,@billdisc,@Taxrate,@NetAmt,@ItemNote,@Ledcode,@Mrp,@Vtype,@Taxper,@lth,@wth,@Slnotracking,@Exdate)" +
 " END";
             _Dbtask.ExecuteNonQuery(sql); 
/*Insert ItemCategory*/

sql="CREATE PROCEDURE [dbo].[InsertItemCategory]"+
" @CategoryId float,"+
" @Category nvarchar(50),"+
" @Remarks nvarchar(50) ,"+
" @showinsummery nvarchar(50)" +

" AS"+
" BEGIN"+
" insert into   TblItemCategory (CategoryId,Category,Remarks,showinsummery) values (@CategoryId,@Category,@Remarks,@showinsummery)" +

" RETURN"+

" END";

 _Dbtask.ExecuteNonQuery(sql); 
/*Insert Itemmaster*/


 sql = "create PROCEDURE [dbo].[InsertItemMaster]" +
 " @ItemId float," +
 " @ItemCode nvarchar(50)," +
 " @ItemName nvarchar(50)," +
 " @CategoryId int ," +
 " @Description nvarchar(200)," +
 " @MRP decimal(18, 5) ," +
 " @SRate decimal(18, 5)," +
 " @Prate decimal(18, 5)," +
 " @Manufacturer nvarchar(50) ," +
 " @Status int," +
 " @AgentCommision decimal(18, 5)," +
 " @cooly decimal(18, 5)," +
 " @Minstock decimal(18, 5)," +
 " @reorder decimal(18, 5)," +
 " @maximum decimal(18, 5)," +
 " @taxslabid int," +
 " @Balance decimal(18, 5)," +
 " @Itemclass nvarchar(50)," +
 " @rack nvarchar(50)," +
 " @Unit nvarchar(50)," +
 " @VAT decimal(18, 5)," +
 " @CST decimal(18, 5)," +
 " @Purtax decimal(18, 5)," +
 " @Incs int," +
 " @Incp int," +
 " @Sizelessname nvarchar(50)," +
 " @plu nvarchar(50)," +
 " @Unit2 nvarchar(50)," +
 " @UnitAmount1 decimal(18,5)," +
 " @UnitAmount2 decimal(18,5)," +
 " @Ledid float," +
 " @llang nvarchar(50) " +
 " AS" +
 " BEGIN" +
 " insert into tblitemmaster(itemid,itemcode,itemname,categoryid,description,mrp,srate,prate," +
 " manufacturer,status,agentcommision,cooly,minstock,reorder,maximum,slabid,Balance,itemclass,rack,Unit,VAT,CST,Purtax,Incs,Incp,Sizelessname,plu,Unit2,UnitAmount1,UnitAmount2,Ledid,llang) values(@ItemId,@ItemCode," +
 " @ItemName,@CategoryId,@Description,@MRP,@SRate,@Prate,@Manufacturer,@Status,@AgentCommision,@cooly," +
 " @Minstock,@reorder,@maximum,@taxslabid,@Balance,@itemclass,@rack,@Unit,@VAT,@CST,@Purtax,@Incs,@Incp,@Sizelessname,@plu,@Unit2,@UnitAmount1,@UnitAmount2,@Ledid,@llang)" +

 " RETURN" +

 " END";
 _Dbtask.ExecuteNonQuery(sql); 


/*Insert Ledger*/

 sql = "create PROCEDURE [dbo].[InsertLedger]" +
 " @Lid float," +
 " @Lname nvarchar(150)," +
 " @LAliasName nvarchar(150)," +
 " @AGroupId int," +
 " @Address nvarchar(200)," +
 " @Phone nvarchar(50)," +
 " @Mobile nvarchar(50)," +
 " @DiscPer float," +
 " @TaxregNo nvarchar(50)," +
 " @email nvarchar(50)," +
 " @Area nvarchar(50)," +
 " @CreditDays nvarchar(50)," +
 " @CreditLimit nvarchar(50)," +
 " @Other nvarchar(50)," +
 " @Balance decimal(18, 5)," +
 " @commision decimal(18, 5)," +
 " @Cplan float," +
 " @Lstatus int," +
 " @Lstatus2 int," +
 " @CST nvarchar(50)," +
 " @cpbalance decimal(18, 5)," +
 " @usecard int ," +
 " @customercode nvarchar(250) ," +
 " @cityy nvarchar(500) ," +
  " @Lcountryname nvarchar(500) ," +
  " @postcode nvarchar(500) ," +
  " @LDistrict nvarchar(500) " +


   " AS" +
   " BEGIN" +
   " insert into   TblAccountLedger (lid,Lname,LAliasName,AGroupId,Address,phone,mobile,DiscPer,TaxRegNo,Email,CreditDays,CreditLimit,Other,area,balance,commision,cplan,lstatus,lstatus2,cst,cpbalance,usecard,customercode,cityy,Lcountryname,postcode,LDistrict) " +
    "values (@Lid,@Lname,@LaliasName,@AGroupId,@Address,@Phone,@Mobile,@DiscPer,@TaxregNo,@email,@CreditDays,@CreditLimit,@Other,@area,@balance,@commision,@cplan,@lstatus,@lstatus2,@cst,@cpbalance,@usecard,@customercode,@cityy,@Lcountryname,@postcode,@LDistrict)" +


 " RETURN" +

 " END";

 _Dbtask.ExecuteNonQuery(sql); 

/*Insert Manfacturer*/


sql= "CREATE PROCEDURE [dbo].[InsertManufacturer]"+
" @Mid float,"+
" @MName nvarchar (50),"+
" @Address nvarchar (200),"+
" @Phone nvarchar(50)"+
" AS"+
" BEGIN"+
" INSERT INTO TblManufacturer(Mid,MName,Address,Phone) VALUES(@Mid,@MName,@Address,@Phone)"+
" END";
            _Dbtask.ExecuteNonQuery(sql); 


/*Insert MultiRate*/


sql= "CREATE PROCEDURE [dbo].[InsertMultirates]"+
" @RateId float,"+
" @Ratename nvarchar (50),"+
" @Description nvarchar (50),"+
" @Ratein int"+
" AS"+
" BEGIN"+
" insert into TblMultiRates (RateId,Ratename,Description,Ratein)"+
" values (@RateId,@Ratename,@Description,@Ratein)"+
" END";
_Dbtask.ExecuteNonQuery(sql); 

/*Insert multiUnit*/

sql= "CREATE PROCEDURE [dbo].[InsertMultiunits]"+
" @UnitId float,"+
" @Base nvarchar (50),"+
" @UName nvarchar (50),"+
" @CF decimal(18, 5)"+
" AS"+
" BEGIN"+
" insert into TblMultiunits (Unitid,Base,UName,CF)"+
" values (@UnitId,@Base,@UName,@CF)"+
" END";

_Dbtask.ExecuteNonQuery(sql); 

/*Insert ProductRate*/

sql= "CREATE PROCEDURE [dbo].[InsertProductrate]"+
" @Pcode nvarchar(50),"+
" @Unitid float,"+
" @Rateid float,"+
" @Rate decimal(18, 5),"+
" @batchid nvarchar(50)" +
" AS"+
" BEGIN"+
/* INSERT INTO SomeTable(SomeColumn, AnotherColumn) VALUES(@SomeParam, @AnotherParam)*/
" insert into Tblproductrate (Pcode,Unitid,Rateid,Rate,batchid)"+
" values (@Pcode,@Unitid,@Rateid,@Rate,@batchid)"+
" END";
 _Dbtask.ExecuteNonQuery(sql); 



/*Insert ProductUnit*/


//sql="CREATE PROCEDURE [dbo].[InsertProductunits]"+
//" @Pcode nvarchar(50),"+
//" @Unitid float,"+
//" @Unit nvarchar(50),"+
//" @CF float"+
//" AS"+
//" BEGIN"+
///* INSERT INTO SomeTable(SomeColumn, AnotherColumn) VALUES(@SomeParam, @AnotherParam)*/
//" insert into Tblproductunits (Pcode,Unitid,Unit,CF)"+
//" values (@Pcode,@Unitid,@Unit,@CF)"+
//" END";
//_Dbtask.ExecuteNonQuery(sql); 


/*Insert Receipt Details*/

 sql = "Create PROCEDURE [dbo].[InsertReceiptDetails]" +
                " @RecptCode float," +
                " @Slno float," +
                " @Pcode nvarchar(50)," +
                " @Unitid float," +
                " @BatchId nvarchar(50)," +
                " @MultirateId float," +
                " @Qty decimal(18, 5)," +
                " @FreeQty decimal(18, 5)," +
                " @Rate decimal(18, 5)," +
                " @DiscRate decimal(18, 5)," +
                " @billdisc decimal(18, 5)," +
                " @profit decimal(18, 5)," +
                " @Taxrate decimal(18, 5)," +
                " @NetAmt decimal(18, 5)," +
                " @ItemNote nvarchar(50)," +
                " @ItemNote1 nvarchar(50)," +
                " @ManDate datetime," +
                " @ExDate datetime," +
                " @srate decimal(18, 5)," +
                " @crate decimal(18, 5)," +
                " @Mrp decimal(18, 5)," +
                " @Ledcode nvarchar(50)," +
                 "@Vtype nvarchar(50)," +
               "@Taxper decimal(18, 5)," +
               "@Exciseduty decimal(18, 5)," +
               " @Wrate nvarchar(50)" +
                " AS" +
                " BEGIN" +
                " INSERT INTO TblReceiptDetails(RecptCode,Slno,Pcode,Unitid,BatchId,MultirateId,Qty,FreeQty,Rate,DiscRate,billdisc,profit,Taxrate,NetAmt,ItemNote,ItemNote1,mandate,exdate,srate,crate,ledcode,Mrp,vtype,Taxper,exciseduty,wrate)" +

                "VALUES" +
                "(@RecptCode,@Slno,@Pcode,@Unitid,@BatchId,@MultirateId,@Qty,@FreeQty,@Rate,@DiscRate,@billdisc,@profit,@Taxrate,@NetAmt,@ItemNote,@ItemNote1,@mandate,@exdate,@srate,@crate,@Ledcode,@mrp,@Vtype,@Taxper,@Exciseduty,@wrate)" +
                " END";

 _Dbtask.ExecuteNonQuery(sql); 
/*Insert SAGroup*/

sql="CREATE PROCEDURE [dbo].[InsertSagroup]"+
" @Gid float,"+
" @Gname nvarchar (50),"+
" @Gunder int"+
" AS"+
" BEGIN"+
/* INSERT INTO SomeTable(SomeColumn, AnotherColumn) VALUES(@SomeParam, @AnotherParam)*/
" insert into TblSagroup(Gid,Gname,Gunder) values (@Gid,@Gname,@Gunder)"+
" END";
_Dbtask.ExecuteNonQuery(sql); 

/*Insert SlabMaster*/


sql= "CREATE PROCEDURE [dbo].[InsertSlabMaster]"+
" @Slid float,"+
" @Slname nvarchar(50),"+
" @Discri nvarchar (50),"+
" @Efffrom datetime,"+
" @Perc decimal(18, 5)"+
" AS"+
" BEGIN"+
" INSERT INTO Tblslabmaster(Slid,Slname,Discri,Efffrom,Perc) VALUES(@Slid,@Slname, @Discri,@Efffrom,@Perc)"+
" END";

_Dbtask.ExecuteNonQuery(sql); 
/*Insert TransactionReceipt*/


sql = "Create PROCEDURE [dbo].[InsertTransactionReceipt]" +
       " @ReptCode float," +
       " @Vno nvarchar(50)," +
       " @RecptType nvarchar(50)," +
       " @Dcode nvarchar(50)," +
       " @Bdate datetime," +
       " @RecptDate datetime," +
       " @LedcodeCr nvarchar(50)," +
       " @LedcodeDr nvarchar(50)," +
       " @Amt decimal(18, 5)," +
       " @Remarks nvarchar(200)," +
       " @Empid nvarchar(50)," +
       " @DiscAmt decimal(18, 5)," +
       " @invdisc decimal(18, 5)," +
       " @TaxAmt decimal(18, 5)," +
       " @Cooly decimal(18, 5)," +
       " @Adamount decimal(18, 5)," +
       " @agent decimal(18, 5)," +
       " @pvno nvarchar(50)," +
       " @srate decimal(18, 5)," +
       " @crate  decimal(18, 5)," +
       " @Taxid  nvarchar(50)," +
       " @Refno  nvarchar(50)," +
       " @Tename  nvarchar(50)," +
       " @Billimg  image," +
       " @Mpayment  int," +
       " @Uid  nvarchar(50)," +
       " @pproject  float" +
       " AS" +
       " BEGIN" +
       " INSERT INTO TbltransactionReceipt(ReptCode,Vno,RecptType,Dcode,Bdate,RecptDate,LedcodeCr,LedcodeDr,Amt,Remarks,Empid,DiscAmt,invdisc,TaxAmt,Cooly,adamount,agent,pvno,srate,crate,taxid,Refno,Tename,Billimg,Mpayment,Uid,pproject)" +
           "VALUES(@ReptCode,@Vno,@RecptType,@Dcode,@Bdate,@RecptDate,@LedcodeCr,@LedcodeDr,@Amt,@Remarks,@Empid,@DiscAmt,@invdisc,@TaxAmt,@Cooly,@adamount,@agent,@pvno,@srate,@crate,@taxid,@Refno,@Tename,@Billimg,@Mpayment,@Uid,@pproject)" +
       " END";
_Dbtask.ExecuteNonQuery(sql);  

/*Insert TransferDetails*/


sql="CREATE PROCEDURE [dbo].[InsertTransferDetails]"+
" @TCode float,"+
" @Slno int,"+
" @Pcode nvarchar(50),"+
" @ItemDesc nvarchar(50),"+
" @UnitId int,"+
" @BatchId int,"+
" @MultiRateId int,"+
" @CF decimal(18, 5),"+
" @Qty decimal(18, 5),"+
" @Rate decimal(18, 5),"+
" @Comment nvarchar(50),"+
" @ShelfCode int,"+
" @Dcode int,"+
" @Supcode nvarchar(50)"+
" AS"+
" BEGIN"+
" INSERT INTO TblTransferdetails(Tcode,Slno,Pcode,ItemDesc,UnitId,Batchid,MultiRateId,CF,Qty,Rate,Comment,ShelfCode,Dcode,Supcode)"+
" VALUES(@Tcode,@Slno,@Pcode,@ItemDesc,@UnitId,@Batchid,@MultiRateId,@CF,@Qty,@Rate,@Comment,@ShelfCode,@Dcode,@Supcode)"+
" END";

  _Dbtask.ExecuteNonQuery(sql);      



            /*User Details*/


            
sql="CREATE PROCEDURE [dbo].[InsertUserdetails]"+
    "@userid float,"+
    "@username nvarchar(50),"+
    "@upassword nvarchar(50),"+
    "@Ugroup float," +
    "@astatus int " +
    "AS "+
    "BEGIN "+
    "INSERT INTO tbluserdetails(userid,username,upassword,Ugroup,astatus) "+
    "VALUES(@userid,@username,@upassword,@Ugroup,@astatus) " +
    "END";
_Dbtask.ExecuteNonQuery(sql);

sql = "create PROCEDURE [dbo].[InsertBatch] " +
             " @bcode nvarchar(50), " +
             " @itemid nvarchar (50)," +
             " @costcenter nvarchar(50)," +
             " @depo nvarchar (50)," +
             " @Bid nvarchar (50) ," +
             " @Ledcode nvarchar (50)," +
             " @Recptcode nvarchar (50)," +
             " @Mrp decimal(18, 5)," +
             " @Srate decimal(18, 5)," +
             " @mandate datetime," +
             " @Exdate datetime," +
             " @Prate decimal(18, 5), " +
             " @unconv decimal(18, 5) " +
             " AS" +
             " BEGIN" +
             "   INSERT INTO tblbatch(bcode,itemid,costcenter,depo,bid,ledcode,Recptcode,mrp,srate,mandate,exdate,prate,unconv) " +
             "   VALUES(@bcode,@itemid,@costcenter,@depo,@bid,@ledcode,@Recptcode,@mrp,@srate,@mandate,@exdate,@prate,@unconv)" +
             "END";

   _Dbtask.ExecuteNonQuery(sql);


   sql = "CREATE PROCEDURE [dbo].[UpdateParamList]"+
    "  @paramname nvarchar(50),"+
    "  @paramtype nvarchar(50)," +
    "  @paramvalue  nvarchar(50)" +
    "  AS"+
    "  BEGIN"+
    "  update tblparamlist set paramvalue=@paramvalue,paramtype=@paramtype where paramname=@paramname "+
    "  END";
   _Dbtask.ExecuteNonQuery(sql);

   sql = "CREATE PROCEDURE [dbo].[InsertParamlist] "+
        "  @paramname nvarchar(50),"+
        "  @paramtype nvarchar(50),"+
        "  @paramvalue nvarchar(50)"+
        "  AS "+
        "  BEGIN"+
        "  insert into   tblparamlist (paramname,paramtype,paramvalue)"+
        "  values (@paramname,@paramtype,@paramvalue)"+
        "  RETURN "+

        " END";
   _Dbtask.ExecuteNonQuery(sql);

   sql = "CREATE PROCEDURE [dbo].[Insertmnusettings]"+
        "   @Menuid float,"+
        "	@MenuName nvarchar(50),"+
        "   @Parentid float,"+
        "	@Status float"+
        "   AS"+
        "   BEGIN"+
        "	insert into   Tblmnusettings (Menuid,MenuName,Parentid,Status)"+
        "   values (@Menuid,@MenuName,@Parentid,@Status)"+
        "   RETURN"+    
        "  END";
   _Dbtask.ExecuteNonQuery(sql);

   sql = "create PROCEDURE [Insertauditlog] @mdate datetime, @userid nvarchar (50), @computername nvarchar(50), " +
       "@actiontype nvarchar(30),@actiontype1 nvarchar(30), @mformname nvarchar(50), @description nvarchar(200)," +
       "@olddata nvarchar(200), @newdata nvarchar(200) " +
       "AS BEGIN INSERT INTO tblauditlog(mdate,userid,computername,actiontype,actiontype1,mformname,description,olddata,newdata) VALUES" +
       "(@mdate,@userid,@computername,@actiontype,@actiontype1,@mformname,@description,@olddata,@newdata) END";
   _Dbtask.ExecuteNonQuery(sql);
        }
        
        
        public void CreateTable()
        {
            sql = "CREATE TABLE [dbo].[Tblunitsrates]("+
	"[Uid] [float] NULL, "+
	"[Itemid] [float] NULL,"+
	"[Prate] [decimal](18, 5) NULL,"+
	"[Srate] [decimal](18, 5) NULL,"+
	"[Mrp] [decimal](18, 5) NULL,"+
    "[Wrate] [decimal](18, 5) NULL," +
    "[Wrate1] [decimal](18, 5) NULL," +
    "[Wrate2] [decimal](18, 5) NULL," +
    "[Wrate3] [decimal](18, 5) NULL" +
") ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [dbo].[Tblcolor]( " +
        "[cid] [float] NULL, " +
        "[cname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
           " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);



            sql = "CREATE TABLE [dbo].[TblAMCdetails](" +
                     "[Amccdkey] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                     "[Amcproductid] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                     "[Amcregnumber] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL  " +

                  ") ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

           



            sql = "CREATE TABLE [dbo].[Tbltaillor]( " +
 "[Vno] [float] NULL, " +
 "[Cname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
 "[lid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
 "[bttntype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
 "[bttn] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
 "[sleev] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
 "[collor] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
 "[Deldate] [datetime] NULL, " +
 "[Ardate] [datetime] NULL " +
 
 " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [dbo].[TbltaillorDetails]( " +
           "[Vno] [float] NULL, " +
           "[lid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[length] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[chest] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[bottom] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[sleevL] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[Sholder] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[waist] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[neck] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[material] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[model] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
           "[color] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
           " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);




            //icon
            sql = "CREATE TABLE [dbo].[Tblicon]( " +
     "[xvalue] [float] NULL, " +
      "[yvalue] [float] NULL, " +
     "[icon] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
     " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);


            sql = "CREATE TABLE [dbo].[Tblarea]( " +
       "[Aid] [float] NULL, " +
       "[Aname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL "+
       " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [dbo].[Tblcommision]( " +
          "[cid] [float] NULL, " +
          "[Cname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
          "[Cperc] [decimal](18, 5) NULL, " +
          "[Cfromamount] [decimal](18, 5) NULL, " +
          "[Ctoamount] [decimal](18, 5) NULL, "+
          "[Cfor] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
          " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            /*For dress making*/

            sql = "CREATE TABLE [dbo].[Tbldressmaster]( "+
            "[vno] [float] NULL, "+
            "[customer] [float] NULL, "+
            "[Vdate] [datetime] NULL, "+
            "[Ddate] [datetime] NULL, "+
            "[Chest] [decimal](18, 5) NULL, "+
            "[Waist] [decimal](18, 5) NULL, "+
            "[Neck] [decimal](18, 5) NULL, "+
            "[Height] [decimal](18, 5) NULL, "+
            "[Shapping] [decimal](18, 5) NULL, "+

            "[Length] [decimal](18, 5) NULL, "+
            "[Loose] [decimal](18, 5) NULL, "+
            "[sholder] [decimal](18, 5) NULL, "+
            "[sholderL] [decimal](18, 5) NULL, "+
            "[sholderw] [decimal](18, 5) NULL, "+

            "[NeckF] [decimal](18, 5) NULL, "+
            "[NeckB] [decimal](18, 5) NULL, "+
            "[pantL] [decimal](18, 5) NULL, "+
            "[pantW] [decimal](18, 5) NULL, "+
            "[pant] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +

            "[Itemid] [float] NULL, " +
            "[Qty] [decimal](18, 5) NULL, " +
            "[Rate] [decimal](18, 5) NULL, " +
            "[adamount] [decimal](18, 5) NULL, " +
            "[Dl] int " +
            " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);


         


           // sql = "CREATE TABLE [dbo].[Tbldressdetail]( " +
           //"[vno] [float] NULL, " +
           //"[item] [float] NULL, " +
           //"[Qty] [decimal](18, 5) NULL, " +
           //"[Srate] [decimal](18, 5) NULL, " +
           //"[Amount] [decimal](18, 5) NULL " +
           //" ) ON [PRIMARY]";
           // _Dbtask.ExecuteNonQuery(sql);
            /*For Payroll attendence **************/

            sql = "CREATE TABLE [dbo].[tblattendancemain]( " +
              " [vno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
              " [amode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
              " [adate] [datetime] NULL " +
              " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [dbo].[tblattendancedetail]( " +
              " [vno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
              " [slno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
              " [lid] [float] NULL, " +
              " [amark] int , " +
              " [ovmark] int , " +
              " [salary] [decimal](18, 5) NULL," +
              " [extra] [decimal](18, 5) NULL," +
              " [extra2] [decimal](18, 5) NULL," +
              " [note]  [nvarchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
              " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            /********************************************************/
          

            sql = "CREATE TABLE [dbo].[tblbillsett]( "+
                " [vno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, "+
                " [vtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, "+
                " [Ledcode] [float] NULL, "+
                " [Dbamt] [decimal](18, 5) NULL, "+
                " [Cramt] [decimal](18, 5) NULL,"+
                " [Agvno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, "+
                " [Dt] [datetime] NULL ,"+
                " [Emp] [float] NULL " +
                " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [dbo].[Tblremainder]( " +
                 " [Rid] float, " +
                 " [Rname] [nvarchar](50), " +
                 " [Rsubject] [nvarchar](250), " +
                 " [Rdate] [datetime] NULL,  " +
                 " [Rstatus] int )";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [dbo].[Tblpartyproject]( " +
                   " [pid] float, " +
                   " [pname] [nvarchar](50), "+
                   " [Address] [nvarchar](250), " +
                   " [mobile] [nvarchar](50), " +
                   " [partyid] float )";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [dbo].[Tblpricecode]( " +
                           " [field] [nvarchar](50), " +
                           " [code] [nvarchar](50))";
            _Dbtask.ExecuteNonQuery(sql);



            sql = "CREATE TABLE [dbo].[Tblchqreceived]( " +
               " [Id] [float] NOT NULL, " +
               " [Pdate] [datetime] NULL, " +
               " [Alid] [float] NULL, " +
               " [Blid] [float] NULL, " +
               " [Amount] [decimal](18, 5) NULL, " +
               " [ChequeNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
               " [Status] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
               " [CDate] [datetime] NULL, " +
               " [Note] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
               " [CMode] Int, " +
               " [CollDate] [datetime] NULL, " +
               " [Genid] float, " +
               " [Discount] [decimal](18, 5) NULL, " +
               " [Emp ][nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
               " [Agvno] [nvarchar](50)," +
               " [TotAmt] [decimal](18, 5) NULL " +
               
               " CONSTRAINT [PK_Tblchqreceived] PRIMARY KEY CLUSTERED  " +
               " ([Id] ASC " +
               " )WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY] " +
               " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

        

            /*For Unitcreation*/
            sql = "CREATE TABLE [dbo].[tblUnitcreation]( "+
	            " [id] [float] NULL, "+
	            " [name] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, "+
	            " [ucount] [decimal](18, 5) NULL "+
                " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [dbo].[tblbaseunit]( " +
                " [id] [float] NULL, " +
                " [name] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
                
                " ) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            /*For VoucherType*/

            sql = "CREATE TABLE [dbo].[tblVoucherType](" +
                "[Vname][nvarchar](200) NULL," +
                "[UndrVouchr][nvarchar](200) NULL," +
                "[ItemCategryId][int] NULL," +
                "[ItemClass][nvarchar](100) NULL," +
                "[Printer][nvarchar](200) NULL," +
                "[Lid][int] NULL)";
            _Dbtask.ExecuteNonQuery(sql);

            /*For Repacking*/

            sql = "CREATE TABLE [dbo].[tblmenus](" +
            "[ID][float] NOT NULL," +
            "[MenuName][nvarchar](200) NULL)";
            _Dbtask.ExecuteNonQuery(sql);


            sql = "CREATE TABLE [dbo].[tblRepacking](" +
                "[VNo][float] NOT NULL," +
                "[VDate][datetime] NULL," +
                "[PackDate][datetime] NULL," +
                "[Narretion][nvarchar](200) NULL," +
                "[SlNo][nvarchar](50) NULL," +
                "[ItemId][float] NULL," +
                "[BatchCode][nvarchar](50)NULL," +
                "[QTY][decimal](18,5) NULL," +
                "[PRate][decimal](18,5) NULL," +
                "[CRate][decimal](18,5) NULL," +
                "[SRate][decimal](18,5) NULL," +
                "[MRP][decimal](18,5) NULL," +
                "[Amount][decimal](18,5) NULL," +
                "[DepoId][decimal](18,5) NULL," +
                "[LabourCharge][decimal](18,5) NULL," +
                "[CostFactor][decimal](18,5)NULL)";
            _Dbtask.ExecuteNonQuery(sql);

            /*For RepackingDetails*/
            sql = "CREATE TABLE [dbo].[TblRepackingDetails](" +
                "[Vno][float] NOT NULL," +
                "[SlNo][nvarchar](50) NULL," +
                "[ItemId][float] NULL," +
                "[BatchCode][nvarchar](50) NULL," +
                "[QTY][decimal](18,5) NULL," +
                "[PRate][decimal](18,5) NULL," +
                "[CRate][decimal](18,5) NULL," +
                "[SRate][decimal](18,5) NULL," +
                "[MRP][decimal](18,5) NULL," +
                "[Amount][decimal](18,5) NULL," +
            "[DepoId][decimal](18,5) NULL)";
            _Dbtask.ExecuteNonQuery(sql);

            /*For  /*For TempContacts */
            sql = "CREATE TABLE [dbo].[tbltempcontact](" +
    "[tid] [float] NULL," +
    "[tname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[tmobile] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[taddress] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
      "[Area] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[temail] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL" +
") ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            //SerialNO Tracking*/
            sql = "CREATE TABLE [dbo].[tblslnotracking](" +
    "[itemid] [float] NULL," +
    "[Slno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[vtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[vno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[slstatus] int "+
") ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);
            /************************************/

            /*Size Master */
            sql = "CREATE TABLE [dbo].[tblcustomerpoint]("+
	"[cpid] [float] NULL,"+
	"[cardname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[validfrom] [datetime] NULL,"+
	"[validto] [datetime] NULL,"+
	"[salevalue] [decimal](18, 5) NULL,"+
	"[point] [decimal](18, 5) NULL,"+
	"[discount] [decimal](18, 5) NULL"+
") ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            /*Size Master */
            sql = "CREATE TABLE [Tblsizes](" +
            "[Sid] [float] NOT NULL," +
            "[Sname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
            "[Sremarks]  [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL)";         
            _Dbtask.ExecuteNonQuery(sql);

            /*Size Detail */
            sql = "CREATE TABLE [TblsizesDetail](" +
            "[ItemSizename] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
            "[Sname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL)";
            _Dbtask.ExecuteNonQuery(sql);

            /*Item Master Sett For Production*/
            sql = "CREATE TABLE [Tblproductsett](" +
            "[id] [float] NOT NULL," +
            "[Bcode] nvarchar(50)," +
            "[item] [float] NOT NULL,"+
            "[qty]  [decimal](18, 5) NULL,"+
            "[mrate]  [decimal](18, 5) NULL)";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [Tblproductsettdetail](" +
            "[id] [float] NOT NULL," +
            "[slno] [float] NOT NULL,"+
            "[Bcode] nvarchar(50)," +
            "[item] [float] NOT NULL," +
            "[qty]  [decimal](18, 5) NULL," +
            "[Rate]  [decimal](18, 5) NULL)";
            _Dbtask.ExecuteNonQuery(sql);
            /**********************************************/

            /*Issue Product For Production*/
            sql = "CREATE TABLE [Tblissueproduct](" +
            "[vno] [float] NOT NULL," +
            "[employee] [float] NOT NULL," +
            "[issuedate] [datetime] NOT NULL," +
            "[remarks] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
            "[istatus] [int],"+
            "[Tvno] [float])";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [Tblissueproductdetail](" +
            "[issueid] [float] NOT NULL," +
            "[slno] [float] NOT NULL,"+
            "[Bcode] nvarchar(50)," +
            "[item] [float] NOT NULL," +
            "[qty]  [decimal](18, 5) NULL," +
            "[Rate]  [decimal](18, 5) NULL)";
            _Dbtask.ExecuteNonQuery(sql);
            /*************************************************/

            /*Received Product For Production*/
            sql = "CREATE TABLE [Tblreceivedproduct](" +
            "[issueid] [float] NOT NULL," +
            "[id] [float] NOT NULL," +
            "[Recdate] [datetime] NOT NULL," +
            "[item] [float] NOT NULL," +
            "[Qty] [decimal](18, 5) NULL,"+
            "[Bvno] [float] NOT NULL,"+
            "[gvno] [float] NOT NULL,)" ;
            _Dbtask.ExecuteNonQuery(sql);

            sql = "CREATE TABLE [Tblreceivedproductdetail](" +
            "[id] [float] NOT NULL," +
            "[slno] [float] NOT NULL,"+
            "[bcode] nvarchar(50)," +
            "[item] [float] NOT NULL," +
            "[qty]  [decimal](18, 5) NULL," +
            "[Rate]  [decimal](18, 5) NULL)";
            _Dbtask.ExecuteNonQuery(sql);
            /*************************************************/
            /*Account Group*/
            sql="CREATE TABLE [TblAccountGroup]("+
            "[AGroupId] [float] NOT NULL,"+
            "[AGroupName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
            "[AUnder] [int] NULL,"+
            "CONSTRAINT [PK_TblAccountGroup] PRIMARY KEY CLUSTERED "+
            "([AGroupId] ASC"+
            ")WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]"+
            ") ON [PRIMARY]";

            _Dbtask.ExecuteNonQuery(sql);

            sql="CREATE PROCEDURE [dbo].[CheckUser]"+
   " @UserName nvarchar(50),"+
   " @Password nvarchar (50)"+
" AS"+
" BEGIN"+
   /* INSERT INTO SomeTable(SomeColumn, AnotherColumn) VALUES(@SomeParam, @AnotherParam)*/
" SELECT * FROM TbluserDetails where username=@UserName and upassword=@Password"+
" END";
    _Dbtask.ExecuteNonQuery(sql);
/*Account Ledger*/


sql="CREATE TABLE [dbo].[TblAccountLedger]("+
	"[Lid] [float] NOT NULL,"+
	"[LName] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[LAliasName] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[AGroupId] [int] NULL,"+
	"[Balance] [decimal](18, 5) NULL,"+
	"[Address] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Phone] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Mobile] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[DiscPer] [decimal](18, 5) NULL,"+
	"[TaxRegNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Email] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[CreditDays] [decimal](18, 5) NULL,"+
	"[CreditLimit] [decimal](18, 5) NULL,"+
	"[Other] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Area] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Commision] [decimal](18, 5) NULL,"+
    "[cplan] float," +
    "[lstatus] int," +
    "[lstatus2] int," +
    "[usecard] int," +
    "[CST][nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
    "[cpbalance] [decimal](18, 5) NULL," +
    "[customercode] [nvarchar](250) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
    "[cityy] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
    "[Lcountryname] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
    "[postcode] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
    "[LDistrict] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +




 "CONSTRAINT [PK_TblAccountLedger] PRIMARY KEY CLUSTERED "+
"([Lid] ASC)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

/*Agent*/

sql=" CREATE TABLE [dbo].[TblAgent]([Aid] [float] NULL,[Aname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Acode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Comm] [decimal](18, 5) NULL,"+
	"[Post] [int] NULL) ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);

            /*BusinessIssue*/


sql=" CREATE TABLE [dbo].[TblBusinessIssue]("+
    "[opno] [int] NULL," +
	"[IssueCode] [float] NULL,"+
    "[VNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
	"[IssueDate] [datetime] NULL,"+
	"[IssueType] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[DCode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[LedcodeCr] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[LedcodeDr] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[AMT] [decimal](18, 5) NULL,"+
	"[Remarks] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[EmpId] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
    "[invdisc] [decimal](18, 5) NULL," +
	"[DiscAmt] [decimal](18, 5) NULL,"+
	"[TaxAmt] [decimal](18, 5) NULL,"+
    "[Adamount] [decimal](18, 5) NULL," +
	"[Cooly] [decimal](18, 5) NULL,"+
	"[agent] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[pvno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Taxid] [nchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
    "[Tename] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[cpdiscount] [decimal](18, 5) NULL," +
    "[Mpayment] int," +
    "[CashReceived] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[SR] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[Uid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[pproject] [float] NULL ," +
    "[warranty] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL" +
") ON [PRIMARY]";

_Dbtask.ExecuteNonQuery(sql);

            /*Company Master*/


sql=" CREATE TABLE [dbo].[TblCompanyMaster]("+
	"[Cname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Tax] [int] NULL,"+
	"[Address1] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Address2] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[City] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[State] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Pcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Telephone] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Mobile] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Fax] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Email] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Website] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[AccountNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[TaxNo1] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[TaxNo2] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[VATNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Country] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[NoOfDecimal] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[FYearFrom] [datetime] NULL,"+
	"[FYearTo] [datetime] NULL,"+
    "[Nameinhome] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
	"[CStatus] [int] NULL,"+
    "[CusId] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[CusArea] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[Sellersname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[TRN] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL" +
            ") ON [PRIMARY]";
            _Dbtask.ExecuteNonQuery(sql);


/*Department*/


sql="CREATE TABLE [dbo].[TblDepartment]([DepId] [float] NULL,[DepName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL) ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);


/*Depot*/


sql=" CREATE TABLE [dbo].[TblDepot]([Dcode] [float] NULL,[DName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[VehicleNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Address] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[City] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Pin] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[PhoneNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Mobile] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[CPerson] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[RegNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[LisenseNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Description] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL) ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);

/*Employeemaster*/


sql="CREATE TABLE [dbo].[TblEmployeemaster]("+
"	[Empid] [float] NULL,"+
"	[EmpName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Sex] [int] NULL,"+
"	[Department] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Mobile] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Address] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Email] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Djoining] [datetime] NULL,"+
"	[Salary] [decimal](18, 5) NULL,"+
"	[Phone] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[PassportNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[VisaNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[EStatus] [int] NULL,"+
"	[EmpCode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[mpayment] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[Commi] [decimal](18, 5) NULL) ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);

/*GeneralLedger*/

sql="CREATE TABLE [dbo].[TblGeneralLedger]("+
"	[VDate] [datetime] NULL,"+
"	[VType] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[VNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[SlNo] [int] NULL,"+
"	[LedCode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Purticulars] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[DbAmt] decimal(18, 5)," +
"	[CrAmt] decimal(18, 5)," +
"	[Naration2] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[Naration] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[RefNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[pproject] [float] NULL," +
"	[Uid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[Employee] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[discount] decimal(18, 5)," +
"	[BillBalance] decimal(18, 5)," +
"   [RecvdAmt] decimal(18,5)"+
          "  ) ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);

/*Internel Transfer*/


sql="CREATE TABLE [dbo].[TblInternelTransfer]("+
"	[Tcode] [float] NULL,"+
"	[DcodeFrom] [int] NULL,"+
"	[DcodeTo] [int] NULL,"+
"	[TDate] [datetime] NULL,"+
"	[Remarks] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL) ON [PRIMARY]";

_Dbtask.ExecuteNonQuery(sql);

/*Inventory*/

sql="CREATE TABLE [dbo].[TblInventory]("+
"	[DCode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[InvDate] [datetime] NULL,"+
"	[PCode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Os] [decimal](18, 5) NULL,"+
"	[Purchase] [decimal](18, 5) NULL,"+
"	[Mr] [decimal](18, 5) NULL,"+
"	[Sr] [decimal](18, 5) NULL,"+
"	[Ireceipt] [decimal](18, 5) NULL,"+
"	[bmr] [decimal](18, 5) NULL,"+
"	[Sales] [decimal](18, 5) NULL,"+
"	[ps] [decimal](18, 5) NULL," +
"	[dn] [decimal](18, 5) NULL,"+
"	[pr] [decimal](18, 5) NULL,"+
"	[iissue] [decimal](18, 5) NULL,"+
"	[sh] [decimal](18, 5) NULL,"+
"	[Dnr] [decimal](18, 5) NULL," +
"	[dmg] [decimal](18, 5) NULL,"+
"	[bmi] [decimal](18, 5) NULL,"+
"	[freepre] [decimal](18, 5) NULL," +
"	[freeiss] [decimal](18, 5) NULL," +
"	[Vcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Ledcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[costcenter] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[batchcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Slno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[UC] [decimal](18, 5) NULL," +
"	[Exdate] [datetime] NULL " +
 " )ON [PRIMARY]";

_Dbtask.ExecuteNonQuery(sql);

/*Issuedetails*/


sql = " CREATE TABLE [dbo].[TblIssuedetails](" +
    "[IssueCode] [float] NULL," +
"	[Slno] [float] NULL," +
"	[Pcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[UnitId] [int] NULL," +
"	[BatchId] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[MultiRateId] [int] NULL," +
"	[Qty] [decimal](18, 5) NULL," +
"	[Qty1] [decimal](18, 5) NULL," +
"	[Qty2] [decimal](18, 5) NULL," +
"	[pnum] [float] NULL," +
"	[FreeQty] [decimal](18, 5) NULL," +
"	[Rate] [decimal](18, 5) NULL," +
"	[Crate] [decimal](18, 5) NULL," +
"	[DiscRate] [decimal](18, 5) NULL," +
"	[Billdisc] [decimal](18, 5) NULL," +
"	[TaxRate] [decimal](18, 5) NULL," +
"	[mrp] [decimal](18, 5) NULL," +
"	[Taxper] [decimal](18, 5) NULL," +
"	[NetAMT] [decimal](18, 5) NULL," +
"	[ItemNote] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[Ledcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
"	[Vtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,"+
"	[lth] [decimal](18, 5) NULL," +
"	[wth] [decimal](18, 5) NULL," +
"	[Slnotracking] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,"+
"   [Exdate] Datetime " +          
" ) ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);

/*Item Category*/


sql="CREATE TABLE [dbo].[TblItemCategory]("+
"	[CategoryId] [float] NOT NULL,"+
"	[Category] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Remarks] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"   [showinsummery] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," + 

" CONSTRAINT [PK_TblItemCategory] PRIMARY KEY CLUSTERED "+
"("+
"	[CategoryId] ASC"+
")WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]"+
") ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);

/*Item Master*/


sql="CREATE TABLE [dbo].[TblItemMaster]("+
"	[ItemId] [float] NOT NULL,"+
"	[Status] [int] NULL,"+
"	[Itemcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[ItemName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[CategoryId] [int] NULL,"+
"	[Description] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[MRP] [float] NULL,"+
"	[SRate] [decimal](18, 5) NULL," +
"	[PRate] [decimal](18, 5) NULL," +
"	[Manufacturer] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[AgentCommision] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Cooly] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[MinStock] [float] NULL,"+
"	[Reorder] [float] NULL,"+
"	[Maximum] [float] NULL,"+
"	[SlabId] [int] NULL,"+
"	[Balance] [decimal](18, 5) NULL,"+
"	[Unit] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[VAT] [decimal](18, 5) NULL,"+
"	[CST] [decimal](18, 5) NULL,"+
"	[PurTax] [decimal](18, 5) NULL,"+
"	[Incs] [int] NULL,"+
"	[IncP] [int] NULL,"+
"	[Itemclass]  [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[rack]  [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[CRate] [decimal](18, 5) NULL,"+
"	[Sizelessname]  [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[plu]  [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"   [Unit2][nvarchar](50) NULL," +
"   [UnitAmount1][decimal](18,5) NULL," +
"   [UnitAmount2][decimal](18,5)NULL," +
"   [Ledid] [float] NULL," +
"	[llang]  [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
" CONSTRAINT [PK_TblItemMaster] PRIMARY KEY CLUSTERED "+
"("+
"	[ItemId] ASC"+
")WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]"+
") ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);

/*Manufacturer*/


sql="CREATE TABLE [dbo].[TblManufacturer]("+
"	[Mid] [float] NULL,"+
"	[MName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Address] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Phone] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL) ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);



/*Multi Rates*/

sql=" CREATE TABLE [dbo].[TblMultiRates]("+
"	[RateId] [float] NULL,"+
"	[RateName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Description] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[RateIn] [int] NULL,"+
"	[MStatus] [int] NULL"+
") ON [PRIMARY]";

_Dbtask.ExecuteNonQuery(sql);
/*Multi Units*/


sql=" CREATE TABLE [dbo].[TblMultiUnits]("+
	"[UnitId] [float] NULL,"+
	"[Base] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[UName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[CF] [decimal](18, 5) NULL"+
") ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);


/*Param List*/
  //COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+

sql="CREATE TABLE [dbo].[Tblparamlist]("+
"	[Paramname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Paramtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Paramvalue] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
") ON [PRIMARY]";
 _Dbtask.ExecuteNonQuery(sql);
/*Product Rate*/


sql=" CREATE TABLE [dbo].[TblProductRate]("+
"	[Pcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[UnitId] [float] NULL,"+
"	[RateId] [float] NULL,"+
"	[Rate][decimal](18, 5) NULL," +
"	[batchid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +

") ON [PRIMARY]";

_Dbtask.ExecuteNonQuery(sql);

/*Product Units*/


sql="CREATE TABLE [dbo].[TblProductUnits]("+
"	[Pcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[UnitId] [float] NULL,"+
"	[PRate] [decimal](18, 5) NULL,"+
"	[SRate] [decimal](18, 5) NULL,"+
"	[MRP] [decimal](18, 5) NULL) ON [PRIMARY]";
 _Dbtask.ExecuteNonQuery(sql);

/*Receipt Details*/

 sql = "CREATE TABLE [dbo].[TblReceiptDetails]( " +
    "[RecptCode] [float] NOT NULL," +
    "[Slno] [int] NULL," +
    "[Pcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[UnitId] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[BatchId] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[MultiRateId] [int] NULL," +
    "[Qty] [decimal](18, 5) NULL," +
    "[FreeQty] [decimal](18, 5) NULL," +
    "[Rate] [decimal](18, 5) NULL," +
    "[DiscRate] [decimal](18, 5) NULL," +
    "[Billdisc] [decimal](18, 5) NULL," +
    "[Profit] [decimal](18, 5) NULL," +
    "[TaxRate] [decimal](18, 5) NULL," +
    "[NetAMT] [decimal](18, 5) NULL, " +
    "[ItemNote] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[ItemNote1] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[mandate] [datetime] NULL," +
    "[exdate] [datetime] NULL," +
    "[srate] [decimal](18, 5) NULL," +
    "[crate] [decimal](18, 5) NULL," +
    "[mrp] [decimal](18, 5) NULL," +
    "[Ledcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
     "[vtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
    "[Taxper] [decimal](18, 5) NULL," +
     "[exciseduty] [decimal](18, 5) NULL," +
    "[wrate] [decimal](18, 5) NULL" +
" ) ON [PRIMARY]";
 _Dbtask.ExecuteNonQuery(sql);

sql=" CREATE TABLE [dbo].[TblSAGroup]("+
	"[Gid] [float] NULL,"+
	"[Gname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[Gunder] [int] NULL"+
") ON [PRIMARY]";

_Dbtask.ExecuteNonQuery(sql);

/*Slab Master*/


sql=" CREATE TABLE [dbo].[TblSlabmaster]("+
"	[Slname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Discri] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[slno] [float] NULL,"+
"	[Efffrom] [datetime] NULL,"+
"	[Perc] [decimal](18, 5) NULL,"+
"	[SlId] [float] NULL"+
") ON [PRIMARY]";

_Dbtask.ExecuteNonQuery(sql);

/*Transaction Receipt*/

sql= " CREATE TABLE [dbo].[TblTransactionReceipt]("+
"	[ReptCode] [float] NULL,"+
"	[VNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[RecptDate] [datetime] NULL,"+
"	[BDate] [datetime] NULL," +
"	[Refno] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[RecptType] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Dcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[LedcodeCr] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[LedcodeDr] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[AMT] [decimal](18, 5) NULL,"+
"	[Remarks] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Empid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[DiscAmt] [decimal](18, 5) NULL,"+
"	[Invdisc] [decimal](18, 5) NULL," +
"	[TaxAmt] [decimal](18, 5) NULL,"+
"	[Cooly] [decimal](18, 5) NULL,"+
"	[adamount] [decimal](18, 5) NULL," +
"	[agent] [decimal](18, 5) NULL,"+
"	[Pvno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Tename] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[srate] [decimal](18, 5) NULL,"+
"	[crate] [decimal](18, 5) NULL,"+
"	[pproject] float NULL," + 
"	[Billimg] image null," +
"	[Taxid] [nvarchar](50),"+
"	[Uid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
"	[Mpayment] int"+
") ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);
 
            /*Transfer Details*/

sql="CREATE TABLE [dbo].[TblTransferDetails]("+
"	[Tcode] [float] NULL,"+
"	[Slno] [int] NULL,"+
"	[Pcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[ItemDesc] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[UnitId] [int] NULL,"+
"	[BatchId] [int] NULL,"+
"	[MultiRateId] [int] NULL,"+
"	[CF] [decimal](18, 5) NULL,"+
"	[Qty] [decimal](18, 5) NULL,"+
"	[Rate] [decimal](18, 5) NULL,"+
"	[Comment] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[ShelfCode] [int] NULL,"+
"	[DCode] [int] NULL,"+
"	[SupCode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL) ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);

/*User Details*/

sql=" CREATE TABLE [dbo].[TblUserDetails]("+
	"[UserId] [float] NULL,"+
	"[UserName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
	"[UPassword] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
    "[Ugroup] [float] NULL,"+
    "[astatus] int" +
") ON [PRIMARY]";
_Dbtask.ExecuteNonQuery(sql);

            /*Batch*/

sql = "CREATE TABLE [dbo].[Tblbatch]( "+
"	[Bcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[itemid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[costcenter] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, "+
"	[depo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,"+
"	[Bid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
"	[Ledcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
"	[mrp] [decimal](18, 5) NULL," +
"	[srate] [decimal](18, 5) NULL," +
"	[mandate] datetime," +
"	[exdate] datetime," +
"	[prate] [decimal](18, 5) NULL," +
"	[unconv] [decimal](18, 5) NULL," +
"	[Recptcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
" ) ON [PRIMARY]";

    _Dbtask.ExecuteNonQuery(sql);

            /*Mnu Settings*/
  sql = "CREATE TABLE [dbo].[Tblmnusettings]( "+
"	[Menuid] [float] NULL,"+
"	[Menuname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,"+
"	[Parentid] [float] NULL,"+
"	[Status] [float] NULL"+
" ) ON [PRIMARY]";
  _Dbtask.ExecuteNonQuery(sql);

            /*Audit Log*/
  sql = " CREATE TABLE tblauditlog (" +
      "Mdate datetime DEFAULT NULL," +
      "UserId varchar(30) DEFAULT NULL," +
      "Computername varchar(50) DEFAULT NULL," +
      "ActionType varchar(30) DEFAULT NULL," +
      "ActionType1 varchar(30) DEFAULT NULL," +
      "Mformname varchar(50) DEFAULT NULL," +
      "olddata varchar(200) DEFAULT NULL," +
      "newdata  varchar(200) DEFAULT NULL," +
      "Description varchar(200) DEFAULT NULL)";
  _Dbtask.ExecuteNonQuery(sql);
}
}
}
