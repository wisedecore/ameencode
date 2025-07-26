using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class NextGFuntion
    {
        Generalfunction _Gen = new Generalfunction();
        ClsParamlist _Paramlist = new ClsParamlist();
        clsmnusettings _Mnusettings = new clsmnusettings();

        DBTask _Dbtask = new DBTask();
        public string sql;
        public int CountValidfield;
        public int GridvalidationRow;
        public long Registration;
        public  string pvno="";
        public string LogoImg = "";
        public string vno="";
        public static string StockAreaName="Stock Area";
        public static string SoftwareName = "Click";
        RegistryKey regKey = Registry.CurrentUser;

        SqlConnection cnn;
        string connectionString = null;
        //TextBox TxtS = new TextBox();
        //ComboBox CmbS = new ComboBox();
      //  DateTimePicker DtS = new DateTimePicker();


        public static string Salesreturnstring="";
        public static double SalesReturnAmount;
        public static string SalesReturnVno="";
        public static bool IsinSalesReturn;

        public DataSet Ds;
        public static int slno = 0;
        string Count;

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddDepot));

        public void ClearUsercontroles(Form frm)
        {
            for (int k = 0; k < frm.Controls.Count; k++)
            {
                if (frm.Controls[k] is Uscnormaltextbox)
                {
                    Uscnormaltextbox _obj = frm.Controls[k] as Uscnormaltextbox;
                    for (int i = 0; i < _obj.Controls.Count; i++)
                    {
                        TextBox clearTextBox = _obj.Controls[i] as TextBox;
                        clearTextBox.Text = String.Empty;
                    }
                }

                if (frm.Controls[k] is Uscnuemerictextbox)
                {
                    Uscnuemerictextbox _obj = frm.Controls[k] as Uscnuemerictextbox;
                    for (int i = 0; i < _obj.Controls.Count; i++)
                    {
                        TextBox clearTextBox = _obj.Controls[i] as TextBox;
                        clearTextBox.Text = "0.00";
                    }
                }
            }

        }

        public void ClearControles(Control Frm )
        {
            try
            {
                for (int i = 0; i < Frm.Controls.Count; i++)
                {
                    if (Frm.Controls[i] is TextBox)
                    {
                        if ((Frm.Controls[i] as TextBox).Tag == null)/*For Text*/
                        {
                            Frm.Controls[i].Text = "";
                        }
                        else if ((Frm.Controls[i] as TextBox).Tag.ToString() == "1")/*For Amount*/
                        {
                            Frm.Controls[i].Text = _Dbtask.SetintoDecimalpoint(0);
                        }
                        else if ((Frm.Controls[i] as TextBox).Tag.ToString() == "2")/*For Qty*/
                        {
                            Frm.Controls[i].Text = _Dbtask.SetintoDecimalpointStock(0);
                        }
                        (Frm.Controls[i] as TextBox).BackColor = System.Drawing.Color.White;

                        // (Frm.Controls[i] as TextBox).BackColor = System.Drawing.Color.InactiveBorder;
                        (Frm.Controls[i] as TextBox).BorderStyle = System.Windows.Forms.BorderStyle.None;
                    }
                    if (Frm.Controls[i] is ComboBox)
                    {
                        (Frm.Controls[i] as ComboBox).SelectedValue = 0;
                    }
                    if (Frm.Controls[i] is DateTimePicker)
                    {
                        (Frm.Controls[i] as DateTimePicker).Value = DateTime.Now;
                    }
                }
            }
            catch
            {
            }
        }

        //public void SetDecimalNullValue(Form Frm,Control Cnt)
        //{
        //    Frm.Controls.Add(Cnt);
        //    Cnt.Text = "0.00";
        //}
        public bool DeleteTransaction()
        {
            return true;
        
        }
        
        public void SetControlesBehave(Form Frm)
        {
           
            //for (int i = 0; i < Frm.Controls.Count; i++)
            //{
            //    if (Frm.Controls[i] is TextBox) /* IS A TextBox */
            //    {
            //       // (Frm.Controls[i] as TextBox).BackColor = System.Drawing.Color.Red; 
            //    }
            //}
        }

        public void Reader()
        {
            try
            {
                // Create an instance of StreamReader to read from a file. 
                // The using statement also closes the StreamReader. 
                using (Stream s = new FileStream(@"C:\Windows\System32\technno.txt", 
                                 FileMode.Open,
                                 FileAccess.Read,
                                 FileShare.ReadWrite))
            {

            }

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            
        }

        public void Registrationinsert(int cout)
        {
            //try
            //{
            //    if (regKey.ValueCount < 2)
            //    {
            //        regKey = regKey.CreateSubKey("Software\\Techno");
            //    }
            //    // regKey.SetValue("Val", "0");
            //    Registration = Convert.ToInt64(regKey.GetValue("Val", 0).ToString());
            //    Registration = Registration + 1;
            //    regKey.SetValue("Val", Registration);
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("A Error Occurred :" + e);
            //}
    
    
        }
        public void CloseNormal(Form Frm)
        {
            CountValidfield=0;
            for (int i = 0; i < Frm.Controls.Count; i++)
            {
                if (Frm.Controls[i] is TextBox) /* IS A TextBox */
                {
                    if (Frm.Controls[i].Text != "")
                    {
                        CountValidfield += 1;
                    }
                }
            }
            if (CountValidfield > 2)
            {
                DialogResult Result = MessageBox.Show("Are you Sure to Exit Application?", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result.ToString() == "Yes")
                {
                    Frm.Close();
                }
            }
            else
            {
                Frm.Close();
            }
          }

        public Image DisplayImages(string Id, string str)
        {
           
                connectionString = SQLCON.SQlCon.ConnectionString;

                cnn = new SqlConnection(connectionString);

                MemoryStream stream = new MemoryStream();
                cnn.Open();
                SqlCommand command = new SqlCommand(str, cnn);
                byte[] image = (byte[])command.ExecuteScalar();
                stream.Write(image, 0, image.Length);
                cnn.Close();
                Bitmap bitmap = new Bitmap(stream);
                return bitmap;
            
        }
        public byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                return stream.ToArray();
            }

            return stream.ToArray();
        }

        public Image ByteToImage(byte[] Bt)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(Bt, 0, Bt.Length);
            Bitmap bitmap = new Bitmap(stream);
            return bitmap;
        }

        public void FormShowNromal(Form FormName)
        {
            try
            {
               
                FormName.WindowState = System.Windows.Forms.FormWindowState.Normal;
                FormName.Show();
            }
            catch
            {
            }
        }
        public void FormIcon(Form frm)
        {
            frm.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.ico")));
            frm.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + @"\Icon\" + "ZUNICO.ico");
        
        
        
        }

        public static void AutoBackup()
        {
            try
            {
                string FilePath;
                string AB;
                AB = CommonClass._Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=122 ");

                if (AB == "1")
                {
                    FilePath = CommonClass._Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='AB1'");
                    string _DataBase = CommonClass._Dbtask.currentcompany();
                    string Move = _DataBase + DateTime.Now.Date.ToString("dd/MM/yyyy");
                    FilePath = FilePath + "\\" + Move + ".Bak";
                    string CurrentDbpath = CommonClass._Dbtask.ExecuteScalar("SELECT  physical_name AS current_file_location FROM sys.master_files  where name='" + _DataBase + "'");
                    int dnamelength = _DataBase.Length + 4;

                    CurrentDbpath = CurrentDbpath.Substring(0, CurrentDbpath.Length - dnamelength);
                    string Applicationfilepath = CurrentDbpath;

                    if (CurrentDbpath != "")
                    {
                        Applicationfilepath = Applicationfilepath + Move + ".Bak";
                        CommonClass._Dbtask.ExecuteNonQuery("BACKUP DATABASE [" + _DataBase + "] TO  DISK = N'" + Applicationfilepath + "' WITH NOFORMAT, INIT,  NAME = N'" + Move + "Full Database Backup',SKIP, NOREWIND, NOUNLOAD,  STATS = 10");

                        /*For Auto Backup1*/
                        //if (File.Exists(FilePath)==true)
                        if (File.Exists(Applicationfilepath) == true)
                        {
                            if (File.Exists(FilePath)==false)
                            {
                            File.Copy(Applicationfilepath, FilePath);
                           //File.Move(Applicationfilepath, FilePath);
                             }
                        }
                        else
                        {
                           //File.Move(Applicationfilepath, FilePath);
                        }
                        ///////////////////***************************//////////////

                        FilePath = CommonClass._Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='AB2'");
                        if (FilePath != "")
                        {
                            FilePath = FilePath + "\\" + Move + ".Bak";
                            /*For Auto Backup2*/
                            if (File.Exists(Applicationfilepath) == true)
                            {
                                if (File.Exists(FilePath) == false)
                                {
                                    //File.Delete(FilePath);
                                    //}
                                    File.Copy(Applicationfilepath, FilePath);
                                }
                                //File.Move(Applicationfilepath, FilePath);
                            }
                        }          

                        FilePath = CommonClass._Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='AB3'");
                        if (FilePath != "")
                        {
                            FilePath = FilePath + "\\" + Move + ".Bak";
                            /*For Auto Backup3*/
                            if (File.Exists(Applicationfilepath) == true)
                            {
                                if (File.Exists(FilePath) == false)
                                {
                                    //File.Delete(FilePath);
                                    //}
                                    File.Copy(Applicationfilepath, FilePath);
                                }
                                //File.Move(Applicationfilepath, FilePath);
                            }
                        }

                        /*For Auto Backup4*/
                        FilePath = CommonClass._Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='AB4'");
                        if (FilePath!="")
                        {
                        
                        FilePath = FilePath + "\\" + Move + ".Bak";
                        if (File.Exists(Applicationfilepath) == true)
                        {
                            if (File.Exists(FilePath) == false)
                            {
                                //File.Delete(FilePath);

                                File.Copy(Applicationfilepath, FilePath);
                            }
                                
                                //File.Move(Applicationfilepath, FilePath);
                        }
                        }
                    }
                }
            }
            catch
            {

            }
        }



        public void FormStylesett(Form frm)
        {
            frm.BackColor = System.Drawing.SystemColors.Control;
            //frm.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        }

        public void FormBorderStyle(Panel Top,Panel Left,Panel Right,Panel Bottom)
        {
            Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        }
        
        public void FormHeadStyle(Panel Head)
        {
            Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
        }

        public void FormCentreStyle(Panel Line)
        {
            Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
        }

        public void Dateformatsett()
        {
            // RegistryKey, represents a key-level node at windows registry
            // Registry, represents a root keys in windows registry
            // CurrentUser, reads windows registry base key HKEY_CURRENT_USER
            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);

            // Set value for short Date Format
            rkey.SetValue("sShortDate", "dd-MM-yyyy");

            // Set value for Long Date Format
            rkey.SetValue("sLongDate", "dd-MM-yyyy");

            //  MessageBox.Show("System dateFormat Is changed");
        }
        public void RefreshOnFunctions()
        {
            CommonClass._Ledger.CheCkForLedgerUpdation();
            RefreshonCamapany();
        }
        public string changecompanynameinmsgboxx()
        {

            //string companyy = @"D:\Images\MDI.jpg");

            //string[] nnme = File.ReadAllLines(@"D:\CompanyName\company.txt");
            ////string companyy = Application.StartupPath + @"D:\CompanyName\company.txt";
            //string secnnme = nnme[0].ToString();
            //return secnnme;
            //// if(frm=="Qplex")
            //{
            //    //MessageBox = secnnme.ToString();

            //}

            return "Nesma POS";

        }
        public void RefreshonCamapany()
        {
            _Dbtask.ExecuteNonQuery("ALTER DATABASE [" + Generalfunction.OpCompany + "] SET Multi_User");
            CommonClass.temp = CommonClass._Dbtask.currentcompany();
            CommonClass.temp1 = CommonClass._Dbtask.GetLogicalName();
            if (CommonClass.temp != null && CommonClass.temp != "" && CommonClass.temp != "master" && CommonClass.temp != CommonClass.temp1)
            {
                _Dbtask.ExecuteNonQuery("ALTER DATABASE [" + CommonClass.temp + "] MODIFY FILE (NAME=N'" + CommonClass.temp1 + "', NEWNAME=N'" + CommonClass.temp + "')");
                _Dbtask.ExecuteNonQuery("ALTER DATABASE [" + CommonClass.temp + "] MODIFY FILE (NAME=N'" + CommonClass.temp1 + "_log', NEWNAME=N'" + CommonClass.temp + "_log')");
            }
        }
        public bool KnowTableexsting(string TableName)
        {
            Ds=_Dbtask.ExecuteQuery("SELECT * "+
                    " FROM INFORMATION_SCHEMA.TABLES "+
                    " where  TABLE_NAME = '"+TableName+"'");
            if (Ds.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }
        public void RefreshProcedure()
        {
            sql = "alter   PROCEDURE [dbo].[Insertunitssrates] @Uid float,@itemid float," +
           " @Prate  decimal(18, 5),@Srate  decimal(18, 5),@Mrp  decimal(18, 5),@Wrate  decimal(18, 5), " +
          " @Wrate1  decimal(18, 5), @Wrate2  decimal(18, 5), @Wrate3  decimal(18, 5) " +
          " AS BEGIN insert into Tblunitsrates (Uid,Itemid,Prate,Srate,Mrp,Wrate,Wrate1,Wrate2,wrate3) values " +
          "(@Uid,@Itemid,@Prate,@Srate,@Mrp,@Wrate,@Wrate1,@Wrate2,@wrate3)  END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "alter PROCEDURE [dbo].[Insertcolor] @cid float, @cname [nvarchar](50) " +
" AS BEGIN insert into Tblcolor (cid,cname) values " +
"(@cid,@cname) END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "alter PROCEDURE [dbo].[Insertattendancedetail]" +
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


            sql = "alter PROCEDURE [dbo].[insertOtherprintsets] " +
                      " @OPname [nvarchar](500) ," +
                      " @OPstatus  int " +

                      " AS BEGIN insert into TblOtherprintsets (OPname,OPstatus) values " +
                      "(@OPname,@OPstatus)  END";
            _Dbtask.ExecuteNonQuery(sql);



            sql = "alter   PROCEDURE [dbo].[InsertRack] " +
               " @Rid float," +
               " @Rack [nvarchar](500) " +
                      " AS BEGIN insert into Tblrack (Rid,Rack) values " +
                      "(@Rid,@Rack) END";
            _Dbtask.ExecuteNonQuery(sql);





            sql = "alter   PROCEDURE [dbo].[insertAMCdetails] " +
         " @Amccdkey [nvarchar](500) ," +
         " @Amcproductid [nvarchar](500) ," +
         " @Amcregnumber  [nvarchar](500) " +

         " AS BEGIN insert into TblAMCdetails (Amccdkey,Amcproductid,Amcregnumber) values " +
         "(@Amccdkey,@Amcproductid,@Amcregnumber)  END";
            _Dbtask.ExecuteNonQuery(sql);



            sql = "alter   PROCEDURE [dbo].[insertMostMoving] " +
                        " @MMbcode [nvarchar](500) ," +
                        " @MMpcode [nvarchar](500) ," +
                        " @MMname  [nvarchar](500) " +

                        " AS BEGIN insert into TblMostMoving (MMbcode,MMpcode,MMname) values " +
                        "(@MMbcode,@MMpcode,@MMname)  END";
            _Dbtask.ExecuteNonQuery(sql);



            sql = "alter PROCEDURE [dbo].[Insertfollowup] "+
                        " @cusid [nvarchar](200) ," +
                        " @cusname [nvarchar](50), " +
                        " @cusmob [nvarchar](50) ," +
                        " @cusaddress [nvarchar](200)," +
                        " @custype [nvarchar](200)" +
                         " AS BEGIN insert into tblfollowup (cusid,cusname,cusmob,cusaddress,custype) values " +
                         "(@cusid,@cusname,@cusmob,@cusaddress,@custype) END";
            _Dbtask.ExecuteNonQuery(sql);


            sql = "alter   PROCEDURE [dbo].[insertfeedback] "+
                        " @fid [nvarchar](50) ," +
                        " @fcustomer [nvarchar](200) ," +
                        " @fcalling  [nvarchar](100) ," +
                        " @ffeedback  [nvarchar](800) " +
                        " AS BEGIN insert into Tblfeedback (fid,fcustomer,fcalling,ffeedback) values " +
                        "(@fid,@fcustomer,@fcalling,@ffeedback)  END";
                       // _Dbtask.ExecuteNonQuery(sql);
                    


            sql = "alter PROCEDURE [dbo].[Inserttaillor]" +
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



            sql = "alter PROCEDURE [dbo].[Inserttaillordetails]" +
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

            sql = "alter PROCEDURE [dbo].[InsertBillsett] @vno nvarchar (50), @vtype nvarchar (50), @ledcode float, " +
                          " @Dbamt decimal(18,5),@cramt decimal(18,5),@agvno nvarchar(50),@dt datetime , @Due nvarchar(500) " +
                          " AS BEGIN INSERT INTO tblbillsett(vno,vtype,ledcode,dbamt,cramt,agvno,Dt,Due)  " +
                          " VALUES(@vno,@vtype,@ledcode,@dbamt,@cramt,@agvno,@dt,@Due) END";
            _Dbtask.ExecuteNonQuery(sql);
            //sql = "alter PROCEDURE [dbo].[InsertBillsett] @vno nvarchar (50), @vtype nvarchar (50), @ledcode float, " +
            //              " @Dbamt decimal(18,5),@cramt decimal(18,5),@agvno nvarchar(50),@dt datetime " +
            //              " AS BEGIN INSERT INTO tblbillsett(vno,vtype,ledcode,dbamt,cramt,agvno,Dt)  " +
            //              " VALUES(@vno,@vtype,@ledcode,@dbamt,@cramt,@agvno,@dt) END";
            //_Dbtask.ExecuteNonQuery(sql);





            sql = "alter PROCEDURE [dbo].[InsertRemainder]" +
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

            sql = "alter PROCEDURE [dbo].[Insertpartyproject]" +
                       "@pid float," +
                       "@pname [nvarchar](50)," +
                       "@Address [nvarchar](250)," +
                       "@Mobile [nvarchar](50)," +
                       "@partyid float" +
                       " AS" +
                       " BEGIN" +
                       " insert into Tblpartyproject(pid,pname,address,mobile,partyid) values (@pid,@pname,@address,@mobile,@partyid)" +
                       " END";
            _Dbtask.ExecuteNonQuery(sql);

            sql = "ALTER PROCEDURE [dbo].[InsertUnitcreation]" +
               "@Id float," +
               "@Name nvarchar(200)," +
               "@ucount decimal(18,5)" +
               " AS" +
               " BEGIN" +
               " insert into tblUnitcreation(Id,Name,ucount) values (@id,@Name,@ucount)" +
               " END";
            _Dbtask.ExecuteNonQuery(sql);


            sql = "ALTER PROCEDURE [dbo].[InsertBaseunit]" +
              "@Id float," +
              "@Name nvarchar(200)" +
              
              " AS" +
              " BEGIN" +
              " insert into tblbaseunit(Id,Name) values (@id,@Name)" +
              " END";
            _Dbtask.ExecuteNonQuery(sql);




                /*For  /*For TempContacts */
                sql = "alter  PROCEDURE [dbo].[Inserttempcontact]" +
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
                //sql = "alter  PROCEDURE [dbo].[Insertslnotracking]" +
                //" @itemid float," +
                //" @Slno  nvarchar(50)," +
                //" @vtype  nvarchar(50)," +
                //" @vno  nvarchar(50)," +
                //" @slstatus  int " +
                //" AS" +
                //" BEGIN" +
                //" insert into tblslnotracking (itemid,Slno,vtype,vno,slstatus)" +
                //" values (@itemid,@Slno,@vtype,@vno,@slstatus)" +
                //" END";
                //_Dbtask.ExecuteNonQuery(sql);

                /*For Customer Point*/
                sql = "alter  PROCEDURE [Insertcustomerpoint]" +
                " @cpid float," +
                " @cardname  nvarchar(50)," +
                " @validfrom  datetime," +
                " @validto  datetime," +
                " @salevalue  decimal(18,5)," +
                " @point  decimal(18,5)," +
                " @discount  decimal(18,5)" +
                " AS" +
                " BEGIN" +
                " insert into tblcustomerpoint (cpid,cardname,validfrom,validto,salevalue,point,discount)" +
                " values (@cpid,@cardname,@validfrom,@validto,@salevalue,@point,@discount)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);

                /*For Size Detail*/
                sql = "alter  PROCEDURE [Insertsizesdetail]" +
               " @ItemSizename nvarchar(50)," +
               " @Sname  nvarchar(50)" +
               " AS" +
               " BEGIN" +
               " insert into TblsizesDetail (ItemSizename,Sname) values (@ItemSizename,@Sname)" +
               " END";
                _Dbtask.ExecuteNonQuery(sql);
                /*For Size*/
                sql = "alter PROCEDURE [Insertsizes]" +
                " @Sid float," +
                " @Sname  nvarchar(50)," +
                " @sremarks  nvarchar(200)" +
                " AS" +
                " BEGIN" +
                " insert into tblsizes (sid,sname,sremarks) values (@sid,@sname,@sremarks)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);

                /*Production Product Sett*/

                //sql = "alter PROCEDURE [dbo].[Insertproductsett]" +
                //" @id float," +
                //" @Bcode nvarchar(50)," +
                //" @item float," +
                //" @mrate decimal(18,5)" +
                //" AS" +
                //" BEGIN" +
                //" insert into tblproductsett (id,Bcode,item,mrate) values (@id,@Bcode,@item,@mrate)" +
                //" END";
                //_Dbtask.ExecuteNonQuery(sql);

                //sql = "alter PROCEDURE [dbo].[Insertproductsettdetail]" +
                //" @id float," +
                //" @slno float," +
                //" @Bcode nvarchar(50)," +
                //" @item float," +
                //" @qty decimal(18,5)," +
                //" @rate decimal(18,5)" +
                //" AS" +
                //" BEGIN" +
                //" insert into tblproductsettdetail (id,slno,Bcode,item,qty,rate) values (@id,@slno,@Bcode,@item,@qty,@rate)" +
                //" END";
                //_Dbtask.ExecuteNonQuery(sql);

                ///*Production Issue Product*/

                //sql = "alter PROCEDURE [dbo].[Insertissueproduct]" +
                //" @vno float," +
                //" @employee float," +
                //" @issuedate datetime," +
                //" @remarks nvarchar(50)," +
                //" @istatus int," +
                //" @tvno float" +
                //" AS" +
                //" BEGIN" +
                //" insert into tblissueproduct (vno,employee,issuedate,remarks,istatus,tvno) values (@vno,@employee,@issuedate,@remarks,@istatus,@tvno)" +
                //" END";
                //_Dbtask.ExecuteNonQuery(sql);

                //sql = "alter PROCEDURE [dbo].[Insertissueproductdetail]" +
                //" @issueid float," +
                //" @slno float," +
                //" @Bcode nvarchar(50)," +
                //" @item float," +
                //" @qty decimal(18,5)," +
                //" @rate decimal(18,5)" +
                //" AS" +
                //" BEGIN" +
                //" insert into tblissueproductdetail (issueid,slno,Bcode,item,qty,rate) values (@issueid,@slno,@Bcode,@item,@qty,@rate)" +
                //" END";
                //_Dbtask.ExecuteNonQuery(sql);
                ///******************************************************/

                ///*For Received Product*/

                //sql = "alter PROCEDURE [dbo].[Insertreceivedproduct]" +
                //" @gvno float," +
                //" @Bvno float," +
                //" @issueid float," +
                //" @id float," +
                //" @Recdate datetime," +
                //" @item decimal(18,5)," +
                //" @qty decimal(18,5)" +
                //" AS" +
                //" BEGIN" +
                //" insert into tblreceivedproduct (gvno,bvno,issueid,id,Recdate,item,qty) values (@gvno,@bvno,@issueid,@id,@Recdate,@item,@qty)" +
                //" END";
                //_Dbtask.ExecuteNonQuery(sql);

                //sql = "alter PROCEDURE [dbo].[Insertreceivedproductdetail]" +
                //" @id float," +
                //" @slno float," +
                //" @Bcode nvarchar(50)," +
                //" @item decimal(18,5)," +
                //" @qty decimal(18,5)," +
                //" @rate decimal(18,5)" +
                //" AS" +
                //" BEGIN" +
                //" insert into tblreceivedproductdetail (id,slno,Bcode,item,qty,rate) values (@id,@slno,@Bcode,@item,@qty,@rate)" +
                //" END";
                //_Dbtask.ExecuteNonQuery(sql);


                /******************************************************************************/
                /*Insert AccountGroup*/

                sql = "alter   PROCEDURE [InsertAccount]" +
                " @AGroupId float," +
                " @AGroupName nvarchar(50)," +
                " @AUnder int" +
                " AS" +
                " BEGIN" +
                " insert into tblaccountGroup (AgroupId,AgroupName,AUnder) values (@AGroupId,@AGroupName,@AUnder)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);
                /*Insert Agent*/


                sql = "alter   PROCEDURE [dbo].[InsertAgent]" +
                " @Aid float," +
                " @Aname nvarchar (50)," +
                " @Acode nvarchar(50)," +
                " @Comm decimal(18,5)," +
                " @Post int" +
                " AS" +
                " BEGIN" +
                " INSERT INTO SomeTable(Aid,Aname,Acode,Comm,Post) VALUES(@Aid,@Aname,@Acode,@Comm,@Post)" +
                " END";

                _Dbtask.ExecuteNonQuery(sql);

                /*Insert Businessissue*/
                sql = "alter PROCEDURE [dbo].[InsertBusinessIssue]" +
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
     " @Mpayment int," +
     " @CashReceived nvarchar(50)," +
     " @SR nvarchar(50)," +
     " @Uid nvarchar(50)," +
     " @Pproject float ," +
     " @warranty nvarchar(50) ," +
     " @Tmobile nvarchar(20) ," +
     " @Taddres nvarchar(100) ," +
     " @Tvat nvarchar(50) ," +
     " @vehiclenum nvarchar(50) ," +
     " @Mtrread nvarchar(50) ," +
     " @Twopayment nvarchar(50) ," +
     " @twopayAmt decimal(18, 5) ," +
     " @LBLaccnt nvarchar(500)  ," +
     " @vehiclename nvarchar(500) ," +
     " @POnum nvarchar(500) ," +
     " @Deliverynote nvarchar(500) ," +
     " @Attention nvarchar(500) ," +
     " @MRFPRnum nvarchar(500) ," +
     " @Projcts nvarchar(500) ," +
     " @Due   nvarchar(500) " +


     " AS" +
     " BEGIN" +
     " INSERT INTO TblbusinessIssue(opno,IssueCode,Vno,IssueType,Dcode,IssueDate,LedcodeCr,LedcodeDr,Amt,Remarks,Empid,DiscAmt,invdisc,TaxAmt,Cooly,AdAmount,Agent,pvno,taxid,Tename,cpdiscount,Mpayment,CashReceived,SR,Uid,pproject,warranty,Tmobile,Taddres,Tvat,vehiclenum,Mtrread,Twopayment,twopayAmt,LBLaccnt,vehiclename,POnum,Deliverynote,Attention,MRFPRnum,Projcts,Due)" +
     "					   VALUES(@opno,@IssueCode,@Vno,@IssueType,@Dcode,@IssueDate,@LedcodeCr,@LedcodeDr,@Amt,@Remarks,@Empid,@DiscAmt,@invdisc,@TaxAmt,@Cooly,@AdAmount,@Agent,@pvno,@Taxid,@Tename,@cpdiscount,@Mpayment,@CashReceived,@SR,@Uid,@pproject,@warranty,@Tmobile,@Taddres,@Tvat,@vehiclenum,@Mtrread, @Twopayment,@twopayAmt,@LBLaccnt,@vehiclename,@POnum,@Deliverynote,@Attention,@MRFPRnum,@Projcts,@Due)" +
     " END";

                _Dbtask.ExecuteNonQuery(sql);

               

                /*Insert CompanyMaster*/
                sql = "alter  PROCEDURE [dbo].[Insertcompanymaster]" +
                " @cname nvarchar(500)," +
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
                " @Nameinhome nvarchar(500),"+
                " @CusId nvarchar(50)," +
                " @CusArea nvarchar(50)," +
                " @Sellersname nvarchar(50)," +
                " @TRN nvarchar(50)," +
                " @District nvarchar(250)," +
                " @countryname nvarchar(500) ," +
                " @validityduration   nvarchar(500) ," +
                " @nickname   nvarchar(500) " +


                " AS" +
                " BEGIN" +
                " insert into tblcompanymaster(Cname,tax,address1,address2,city,state,pcode,Telephone,mobile,Fax,email,website," +
                " accountNo,Taxno1,Taxno2,Vatno,Country,NoOfDecimal,FYearFrom,FYearto,cstatus,Nameinhome,CusId,CusArea,Sellersname,TRN,District,countryname,validityduration,nickname) values(@cname,@tax,@address1,@address2,@city,@state,@pcode," +
                " @telephone,@Mobile,@fax,@Email,@Website,@accountno,@taxno1,@taxno2,@vatno,@country,@noofdecimal,@fyearfrom,@fyearTo,@CStatus,@Nameinhome,@CusId,@CusArea,@Sellersname,@TRN,@District,@countryname,@validityduration,@nickname)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);

                /*Insert Department*/

                sql = "alter   PROCEDURE [dbo].[InsertDepartment]" +
                " @Depid float," +
                " @Depname nvarchar (50)" +
                " AS" +
                " BEGIN" +
                " INSERT INTO TblDepartment(Depid, Depname) VALUES(@Depid,@Depname)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);


                /*Insert Depot*/


                sql = "alter   PROCEDURE [dbo].[InsertDepot]" +
                " @Dcode float," +
                " @Dname nvarchar(50)," +
                " @VehicleNo int," +
                " @Address nvarchar(200)," +
                " @City nvarchar(50)," +
                " @Pin nvarchar(50)," +
                " @Phoneno nvarchar(50)," +
                " @Mobile nvarchar(50)," +
                " @Cperson nvarchar(50)," +
                " @RegNo nvarchar(50)," +
                " @Lisenseno nvarchar(50)," +
                " @Description nvarchar(50)" +
                " AS" +
                " BEGIN" +
                " INSERT INTO TblDepot(Dcode,Dname,VehicleNo,Address,City,Pin,Phoneno,Mobile,Cperson,RegNo,Lisenseno,Description)" +
                " VALUES(@Dcode,@Dname,@VehicleNo,@Address,@City,@Pin,@Phoneno,@Mobile,@Cperson,@RegNo,@Lisenseno,@Description)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);
                /*Insert Employeemaster*/


                sql = "alter   PROCEDURE [dbo].[InsertEmployeeMaster]" +

                 " @EmpId float," +
                 " @Empname nvarchar (50)," +
                " @Sex nvarchar (10)," +
                " @Department nvarchar(50)," +
                " @mobile nvarchar(50)," +
                " @Address nvarchar(50)," +
                " @Email nvarchar(50)," +
                " @DJoining datetime," +
                " @Salary decimal(18, 5)," +
                " @Phone nvarchar(50)," +
                " @PassportNo nvarchar(50)," +
                " @VisaNo nvarchar(50)," +
                " @EStatus int," +
                " @EmpCode nvarchar(50)," +
                " @Commi decimal(18, 5)," +
                " @mpayment nvarchar(50)" +
                " AS" +
                " BEGIN" +
                " INSERT INTO TblEmployeemaster (EmpId,Empname,Sex,Department,mobile,Address,Email,DJoining,Salary,Phone,PassportNo,VisaNo,EStatus,EmpCode,Commi,mpayment)" +
                " VALUES (@EmpId,@Empname,@Sex,@Department,@mobile,@Address,@Email,@DJoining,@Salary,@Phone,@PassportNo,@VisaNo,@EStatus,@EmpCode,@Commi,@mpayment)" +
                " END";

                _Dbtask.ExecuteNonQuery(sql);
                /*Insert Generalledger*/


 //               sql = "alter PROCEDURE [dbo].[InsertGeneralLedger]" +
 //" @vdate datetime," +
 //" @vtype nvarchar (50)," +
 //" @vno nvarchar(50)," +
 //" @Slno float," +
 //" @Ledcode nvarchar(50)," +
 //" @purticulars nvarchar(50)," +
 //" @DbAmt decimal(18, 5)," +
 //" @CrAmt decimal(18, 5)," +
 //" @Naration2 nvarchar(200)," +
 //" @Naration nvarchar(200)," +
 //" @RefNo nvarchar(50)," +
 //" @Employee nvarchar(50)," +
 //" @Uid nvarchar(50)," +
 //" @pproject float" +


 //" AS" +
 //" BEGIN" +
 //" insert into Tblgeneralledger(vdate,vtype,vno,Slno,Ledcode,purticulars,DbAmt,CrAmt,Naration2,Naration,RefNo,Employee,Uid,pproject) values" +
 //" (@vdate,@vtype,@vno,@Slno,@Ledcode,@purticulars,@DbAmt,@CrAmt,@Naration2,@Naration,@RefNo,@Employee,@Uid,@pproject)" +
 //" END";

 //               _Dbtask.ExecuteNonQuery(sql); 
     sql = "alter PROCEDURE [dbo].[InsertGeneralLedger]" +
     " @vdate datetime," +
     " @vtype nvarchar (50)," +
     " @vno nvarchar(50)," +
     " @Slno float," +
     " @Ledcode nvarchar(50)," +
     " @purticulars nvarchar(50)," +
     " @DbAmt decimal(18, 5)," +
     " @CrAmt decimal(18, 5)," +
     " @Naration2 nvarchar(200)," +
     " @Naration nvarchar(200)," +
     " @RefNo nvarchar(50)," +
     " @Employee nvarchar(50)," +
     " @Uid nvarchar(50)," +
     " @pproject float," +
     " @discount decimal(18, 5)," +
     " @BillBalance decimal(18, 5)," +
     " @RecvdAmt decimal(18,5),"+
     " @RPtaxperc decimal(18, 5)," +
     " @RPtaxamt decimal(18,5) ," +
     " @Agvno nvarchar(500) " +


     " AS" +
     " BEGIN" +
     " insert into Tblgeneralledger(vdate,vtype,vno,Slno,Ledcode,purticulars,DbAmt,CrAmt,Naration2,Naration,RefNo,Employee,Uid,pproject,discount,BillBalance,RecvdAmt,RPtaxperc,RPtaxamt,Agvno) values" +
     " (@vdate,@vtype,@vno,@Slno,@Ledcode,@purticulars,@DbAmt,@CrAmt,@Naration2,@Naration,@RefNo,@Employee,@Uid,@pproject,@discount,@BillBalance,@RecvdAmt,@RPtaxperc,@RPtaxamt,@Agvno)" +
     " END";

                _Dbtask.ExecuteNonQuery(sql);
                /*Insert Interneltransfer*/

                sql = "alter   PROCEDURE [dbo].[InsertInternelTransfer]" +
                " @TCode float," +
                " @Dcodefrom int," +
                " @DcodeTo int," +
                " @TDate datetime," +
                " @Remarks nvarchar(200)" +

                " AS" +
                " BEGIN" +
                " INSERT INTO TblInterneltransfer(Tcode,Dcodefrom,DcodeTo,TDate,Remarks)" +
                " VALUES(@Tcode,@Dcodefrom,@DcodeTo,@TDate,@Remarks)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);
                /*Insert Inventory*/


                sql = "alter   PROCEDURE [dbo].[InsertInventory]" +
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
                " @UC decimal(18, 5)," +
                " @ExDate datetime   ," +
                " @Vtype nvarchar(50)" +


                " AS" +
                " BEGIN" +
                 " insert into Tblinventory (Dcode,InvDate,Pcode,Os,Purchase,Mr,Sr,Ireceipt,bmr,Sales,dn,dnr,ps,pr,iissue,Sh,dmg,bmi,vcode,ledcode,costcenter,batchcode,freepre,freeiss,Slno,UC,Exdate,Vtype)" +
                 " values (@Dcode,@InvDate,@Pcode,@Os,@Purchase,@Mr,@Sr,@Ireceipt,@bmr,@Sales,@dn,@dnr,@ps,@pr,@iissue,@Sh,@dmg,@bmi,@vcode,@ledcode,@costcenter,@batchcode,@freepre,@freeiss,@Slno,@UC,@Exdate,@Vtype)" +

                " END";
                _Dbtask.ExecuteNonQuery(sql);

                /*Insert Issuedetails*/

                
  sql = "Alter PROCEDURE [dbo].[InsertIssueDetails]" +
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
   " @Itemnote2 nvarchar(50)," +
   " @Exdate Datetime  ," +
    " @billtot decimal(18, 5)," +
  " @billtime nvarchar(50)" +
  
  " AS" +
  " BEGIN" +
  " INSERT INTO TblIssuedetails(IssueCode,Slno,Pcode,Unitid,BatchId,MultirateId,Qty,Qty1,Qty2,pnum,FreeQty,Rate,Crate,DiscRate,billdisc,Taxrate,NetAmt,ItemNote,ledcode,Mrp,vtype,Taxper,lth,wth,Slnotracking,Itemnote2,Exdate,billtot,billtime)" +

  " VALUES" +
  " (@IssueCode, @Slno,@Pcode,@Unitid,@BatchId,@MultirateId,@Qty,@Qty1,@Qty2,@pnum,@FreeQty,@Rate,@Crate,@DiscRate,@billdisc,@Taxrate,@NetAmt,@ItemNote,@Ledcode,@Mrp,@Vtype,@Taxper,@lth,@wth,@Slnotracking,@Itemnote2,@Exdate,@billtot,@billtime)" +
  " END";
                _Dbtask.ExecuteNonQuery(sql); 
                /*Insert ItemCategory*/

                sql = "alter   PROCEDURE [dbo].[InsertItemCategory]" +
                " @CategoryId float," +
                " @Category nvarchar(50)," +
                " @Remarks nvarchar(50)," +
                " @showinsummery nvarchar(50) " +
               


                " AS" +
                " BEGIN" +
                " insert into   TblItemCategory (CategoryId,Category,Remarks,showinsummery) values (@CategoryId,@Category,@Remarks,@showinsummery)" +

                " RETURN" +

                " END";

                _Dbtask.ExecuteNonQuery(sql);
                /*Insert Itemmaster*/


                sql = "alter PROCEDURE [dbo].[InsertItemMaster]" +
                 " @ItemId float," +
                 " @ItemCode nvarchar(50)," +
                 " @ItemName nvarchar(50)," +
                 " @Itemnote nvarchar(50)," +
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
                 " @llang nvarchar(50)," +
                 " @Bunit nvarchar(50)," +
                 " @Usingmechine int  ," +
                 " @rackname nvarchar(500) " +

               
                 " AS" +
                 " BEGIN" +
                 " insert into tblitemmaster(itemid,itemcode,itemname,Itemnote,categoryid,description,mrp,srate,prate," +
                 " manufacturer,status,agentcommision,cooly,minstock,reorder,maximum,slabid,Balance,itemclass,rack,Unit,VAT,CST,Purtax,Incs,Incp,Sizelessname,plu,Unit2,UnitAmount1,UnitAmount2,Ledid,llang,Bunit,Usingmechine,rackname) values(@ItemId,@ItemCode," +
                 " @ItemName,@Itemnote,@CategoryId,@Description,@MRP,@SRate,@Prate,@Manufacturer,@Status,@AgentCommision,@cooly," +
                 " @Minstock,@reorder,@maximum,@taxslabid,@Balance,@itemclass,@rack,@Unit,@VAT,@CST,@Purtax,@Incs,@Incp,@Sizelessname,@plu,@Unit2,@UnitAmount1,@UnitAmount2,@Ledid,@llang,@Bunit,@Usingmechine,@rackname)" +

                 " RETURN" +

                 " END";
                _Dbtask.ExecuteNonQuery(sql); 
                /*Insert Ledger*/

                sql = "alter   PROCEDURE [dbo].[InsertLedger]" +
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
                " @usecard int," +
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


                sql = "alter   PROCEDURE [dbo].[InsertManufacturer]" +
                " @Mid float," +
                " @MName nvarchar (50)," +
                " @Address nvarchar (200)," +
                " @Phone nvarchar(50)" +
                " AS" +
                " BEGIN" +
                " INSERT INTO TblManufacturer(Mid,MName,Address,Phone) VALUES(@Mid,@MName,@Address,@Phone)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);


                /*Insert MultiRate*/


                sql = "alter   PROCEDURE [dbo].[InsertMultirates]" +
                " @RateId float," +
                " @Ratename nvarchar (50)," +
                " @Description nvarchar (50)," +
                " @Ratein int" +
                " AS" +
                " BEGIN" +
                " insert into TblMultiRates (RateId,Ratename,Description,Ratein)" +
                " values (@RateId,@Ratename,@Description,@Ratein)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);

                /*Insert multiUnit*/

                sql = "alter   PROCEDURE [dbo].[InsertMultiunits]" +
                " @UnitId float," +
                " @Base nvarchar (50)," +
                " @UName nvarchar (50)," +
                " @CF decimal(18, 5)" +
                " AS" +
                " BEGIN" +
                " insert into TblMultiunits (Unitid,Base,UName,CF)" +
                " values (@UnitId,@Base,@UName,@CF)" +
                " END";

                _Dbtask.ExecuteNonQuery(sql);

                /*Insert ProductRate*/

                sql = "alter   PROCEDURE [dbo].[InsertProductrate]" +
                " @Pcode nvarchar(50)," +
                " @Unitid float," +
                " @Rateid float," +
                " @Rate decimal(18, 5)," +
                " @batchid nvarchar(50)" +
                " AS" +
                " BEGIN" +
                " insert into Tblproductrate (Pcode,Unitid,Rateid,Rate,batchid)" +
                " values (@Pcode,@Unitid,@Rateid,@Rate,@batchid)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);

                /*Insert Receipt Details*/


                sql = "alter PROCEDURE [dbo].[InsertReceiptDetails]" +
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
                " @Wrate nvarchar(50)  ," +
                " @billtot decimal(18, 5) " +


                 " AS" +
                 " BEGIN" +
                 " INSERT INTO TblReceiptDetails(RecptCode,Slno,Pcode,Unitid,BatchId,MultirateId,Qty,FreeQty,Rate,DiscRate,billdisc,profit,Taxrate,NetAmt,ItemNote,ItemNote1,mandate,exdate,srate,crate,ledcode,Mrp,vtype,Taxper,exciseduty,wrate,billtot)" +

                 "VALUES" +
                 "(@RecptCode,@Slno,@Pcode,@Unitid,@BatchId,@MultirateId,@Qty,@FreeQty,@Rate,@DiscRate,@billdisc,@profit,@Taxrate,@NetAmt,@ItemNote,@ItemNote1,@mandate,@exdate,@srate,@crate,@Ledcode,@mrp,@Vtype,@Taxper,@Exciseduty,@wrate,@billtot)" +
                 " END";

                _Dbtask.ExecuteNonQuery(sql); 

                /*Insert SAGroup*/

                sql = "alter   PROCEDURE [dbo].[InsertSagroup]" +
                " @Gid float," +
                " @Gname nvarchar (50)," +
                " @Gunder int" +
                " AS" +
                " BEGIN" +
                " insert into TblSagroup(Gid,Gname,Gunder) values (@Gid,@Gname,@Gunder)" +
                " END";
                _Dbtask.ExecuteNonQuery(sql);

                /*Insert SlabMaster*/


                sql = "alter   PROCEDURE [dbo].[InsertSlabMaster]" +
                " @Slid float," +
                " @Slname nvarchar(50)," +
                " @Discri nvarchar (50)," +
                " @Efffrom datetime," +
                " @Perc decimal(18, 5)" +
                " AS" +
                " BEGIN" +
                " INSERT INTO Tblslabmaster(Slid,Slname,Discri,Efffrom,Perc) VALUES(@Slid,@Slname, @Discri,@Efffrom,@Perc)" +
                " END";

                _Dbtask.ExecuteNonQuery(sql);
                /*Insert TransactionReceipt*/
                sql = "alter PROCEDURE [dbo].[InsertTransactionReceipt]" +
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
        " @pproject  float ," +
        " @Agvno nvarchar(50)," +
        " @Tmobile nvarchar(20) ," +
        " @Taddres nvarchar(100) ," +
        " @Tvat nvarchar(50) ," +
        " @LBLaccnt  nvarchar(500) " +

        " AS" +
        " BEGIN" +
        " INSERT INTO TbltransactionReceipt(ReptCode,Vno,RecptType,Dcode,Bdate,RecptDate,LedcodeCr,LedcodeDr,Amt,Remarks,Empid,DiscAmt,invdisc,TaxAmt,Cooly,adamount,agent,pvno,srate,crate,taxid,Refno,Tename,Billimg,Mpayment,Uid,pproject,Agvno,Tmobile,Taddres,Tvat,LBLaccnt)" +
            "VALUES(@ReptCode,@Vno,@RecptType,@Dcode,@Bdate,@RecptDate,@LedcodeCr,@LedcodeDr,@Amt,@Remarks,@Empid,@DiscAmt,@invdisc,@TaxAmt,@Cooly,@adamount,@agent,@pvno,@srate,@crate,@taxid,@Refno,@Tename,@Billimg,@Mpayment,@Uid,@pproject,@Agvno,@Tmobile,@Taddres,@Tvat,@LBLaccnt)" +
        " END";
                _Dbtask.ExecuteNonQuery(sql);
                /*Insert TransferDetails*/
                //tbltransactionreceipt


                //sql = "alter   PROCEDURE [dbo].[InsertTransferDetails]" +
                //" @TCode float," +
                //" @Slno int," +
                //" @Pcode nvarchar(50)," +
                //" @ItemDesc nvarchar(50)," +
                //" @UnitId int," +
                //" @BatchId int," +
                //" @MultiRateId int," +
                //" @CF decimal(18, 5)," +
                //" @Qty decimal(18, 5)," +
                //" @Rate decimal(18, 5)," +
                //" @Comment nvarchar(50)," +
                //" @ShelfCode int," +
                //" @Dcode int," +
                //" @Supcode nvarchar(50)" +
                //" AS" +
                //" BEGIN" +
                //" INSERT INTO TblTransferdetails(Tcode,Slno,Pcode,ItemDesc,UnitId,Batchid,MultiRateId,CF,Qty,Rate,Comment,ShelfCode,Dcode,Supcode)" +
                //" VALUES(@Tcode,@Slno,@Pcode,@ItemDesc,@UnitId,@Batchid,@MultiRateId,@CF,@Qty,@Rate,@Comment,@ShelfCode,@Dcode,@Supcode)" +
                //" END";

                //_Dbtask.ExecuteNonQuery(sql);

                /*User Details*/
                sql = "alter   PROCEDURE [dbo].[InsertUserdetails]" +
                    "@userid float," +
                    "@username nvarchar(50)," +
                    "@upassword nvarchar(50)," +
                    "@Ugroup float," +
                    "@astatus int " +
                    "AS " +
                    "BEGIN " +
                    "INSERT INTO tbluserdetails(userid,username,upassword,Ugroup,astatus) " +
                    "VALUES(@userid,@username,@upassword,@Ugroup,@astatus) " +
                    "END";
                _Dbtask.ExecuteNonQuery(sql);

                sql = "alter PROCEDURE [dbo].[InsertBatch] " +
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
                " @unconv decimal(18, 5), " +
                " @Lastrate decimal(18, 5) ," +
                " @baseU nvarchar (500) ," +
                " @prateperc decimal(18, 5)  ," +
                " @ONtable nvarchar(50) " +


                " AS" +
                " BEGIN" +
                "   INSERT INTO tblbatch(bcode,itemid,costcenter,depo,bid,ledcode,Recptcode,mrp,srate,mandate,exdate,prate,unconv,Lastrate,baseU,prateperc,ONtable) " +
                "   VALUES(@bcode,@itemid,@costcenter,@depo,@bid,@ledcode,@Recptcode,@mrp,@srate,@mandate,@exdate,@prate,@unconv,@Lastrate,@baseU,@prateperc,@ONtable)" +
                "END";

                _Dbtask.ExecuteNonQuery(sql);


                sql = "alter   PROCEDURE [dbo].[UpdateParamList]" +
                 "  @paramname nvarchar(50)," +
                 "  @paramtype nvarchar(50)," +
                 "  @paramvalue  nvarchar(50)" +
                 "  AS" +
                 "  BEGIN" +
                 "  update tblparamlist set paramvalue=@paramvalue,paramtype=@paramtype where paramname=@paramname " +
                 "  END";
                _Dbtask.ExecuteNonQuery(sql);

                sql = "alter   PROCEDURE [dbo].[InsertParamlist] " +
                 "  @paramname nvarchar(50)," +
                 "  @paramtype nvarchar(50)," +
                 "  @paramvalue nvarchar(50)" +
                 "  AS " +
                 "  BEGIN" +
                 "  insert into   tblparamlist (paramname,paramtype,paramvalue)" +
                 "  values (@paramname,@paramtype,@paramvalue)" +
                 "  RETURN " +
                 " END";
                _Dbtask.ExecuteNonQuery(sql);

                sql = "alter   PROCEDURE [dbo].[Insertmnusettings]" +
                 "  @Menuid float," +
                 "	@MenuName nvarchar(50)," +
                 "  @Parentid float," +
                 "	@Status float" +
                 "  AS" +
                 "  BEGIN" +
                 "	insert into   Tblmnusettings (Menuid,MenuName,Parentid,Status)" +
                 "  values (@Menuid,@MenuName,@Parentid,@Status)" +
                 "  RETURN" +
                 "  END";
                _Dbtask.ExecuteNonQuery(sql);


                sql = "alter PROCEDURE [Insertauditlog] @mdate datetime, @userid nvarchar (50), @computername nvarchar(50), " +
                "@actiontype nvarchar(30),@actiontype1 nvarchar(30), @mformname nvarchar(50), @description nvarchar(200)," +
                "@olddata nvarchar(200), @newdata nvarchar(200) " +
                "AS BEGIN INSERT INTO tblauditlog(mdate,userid,computername,actiontype,actiontype1,mformname,description,olddata,newdata) VALUES" +
                "(@mdate,@userid,@computername,@actiontype,@actiontype1,@mformname,@description,@olddata,@newdata) END";
                _Dbtask.ExecuteNonQuery(sql);

             sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                    " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    " SYSOBJECTS.NAME = 'Insertrepacking' ";
                    string ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp != "0")
                    {
                        /*For Repacking*/
                        sql = "alter PROCEDURE [dbo].[Insertrepacking]" +
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
                        sql = "alter PROCEDURE [dbo].[Insertrepackingdetails]" +
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

                        sql = "alter PROCEDURE [dbo].[Insertchequereceived]" +
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
                          " ) values (@Id,@Pdate,@Alid,@Blid,@Amount,@ChequeNo,@Status,@CDate,@CollDate,@Note,@CMode,@Genid,@Discount,@Emp,@Agvno,@TotAmt " +
                          " )END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }
                    if (CommonClass._Menusettings.IsMenuAlreadyExist("enableservice") == false)
                    {
                        CommonClass._Menusettings.AddNewMenu("2022", "enableservice", "0", "-1");
                    }
                    if (CommonClass._Menusettings.IsMenuAlreadyExist("printfooter") == false)
                    {
                        CommonClass._Menusettings.AddNewMenu("2024", "printfooter", "0", "-1");
                    }
                    if (CommonClass._Menusettings.IsMenuAlreadyExist("warrantyEnbl") == false)
                    {
                        CommonClass._Menusettings.AddNewMenu("2026", "warrantyEnbl", "0", "-1");
                    }
                    if (CommonClass._Menusettings.IsMenuAlreadyExist("footerStart") == false)
                    {
                        CommonClass._Menusettings.AddNewMenu("102030", "footerStart", "0", "-1");
                    }
                    if (CommonClass._Menusettings.IsMenuAlreadyExist("footermidd") == false)
                    {
                        CommonClass._Menusettings.AddNewMenu("8000", "footermidd", "0", "-1");
                    }
                    if (CommonClass._Menusettings.IsMenuAlreadyExist("QRshow") == false)
                    {
                        CommonClass._Menusettings.AddNewMenu("9000", "QRshow", "0", "1");
                    }
                    if (CommonClass._Menusettings.IsMenuAlreadyExist("Sf12") == false)
                    {
                        CommonClass._Menusettings.AddNewMenu("4000", "Sf12", "0", "-1");
                    }
                    if (CommonClass._Menusettings.IsMenuAlreadyExist("POldBlnc") == false)
                    {
                        CommonClass._Menusettings.AddNewMenu("112233", "POldBlnc", "0", "-1");
                    }
                
        }

       public void CreateColumnInTable(string TableName, string ColName, string DataType, string InitialValue)
       {
            sql = " SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                  " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                  " SYSOBJECTS.NAME = '" + TableName + "' AND SYSCOLUMNS.NAME = '" + ColName + "'";
            string ttemp = _Dbtask.ExecuteScalar(sql);
            if (ttemp == "0")
            {
                _Dbtask.ExecuteNonQuery("alter table " + TableName + " add " + ColName + " " + DataType);
                _Dbtask.ExecuteNonQuery("Update  " + TableName + " Set " + ColName + " = " + InitialValue);
            }
        }

       public static bool IsValueFoundInTable(string Value, string Table, string Field)
       {
           string Qry = "Select * From " + Table + " Where " + Field + " = " + Value;
           DataSet Ds = CommonClass._Dbtask.ExecuteQuery(Qry);
           if (Ds.Tables[0].Rows.Count > 0)
           {
               return true;
           }
           return false;
       }





        public void RefreshDB()
        {
            try
            {
                CommonClass.temp = _Dbtask.currentcompany();
                if (CommonClass.temp != "master" && CommonClass.temp != null)
                {

                    if (CommonClass._Paramlist.IsParamNameExist("Language") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Language";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "English";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (KnowTableexsting("Tbltaillor") == false)
                    {
                        sql = "CREATE TABLE [dbo].[Tbltaillor]( " +
                              "[Vno] [float] NULL, " +
                              "[Cname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                              "[lid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                              "[sleev] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                              "[collor] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                              "[bttntype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                              "[Deldate] [datetime] NULL, " +
                              "[Ardate] [datetime] NULL, " +
                              "[bttn] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
                              " ) ON [PRIMARY]";
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
                    }

                    if (KnowTableexsting("TbltaillorDetails") == false)
                    {
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
                    }
                    if (KnowTableexsting("tblbaseunit") == false)
                    {
                        sql = "CREATE TABLE [dbo].[tblbaseunit]( " +
                         " [id] [float] NULL, " +
                         " [name] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +

                         " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "create PROCEDURE [dbo].[InsertBaseunit]" +
                        "@Id float," +
                         "@Name nvarchar(200)" +

                        " AS" +
                        " BEGIN" +
                        " insert into tblbaseunit(Id,Name) values (@id,@Name)" +
                        " END";
                        _Dbtask.ExecuteNonQuery(sql);

                    }
                    if (KnowTableexsting("Tblcolor") == false)
                    {
                        sql = "CREATE TABLE [dbo].[Tblcolor]( " +
                    "[cid] [float] NULL, " +
                    "[cname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
                       " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE   PROCEDURE [dbo].[Insertcolor] @cid float, @cname [nvarchar](50) " +
                           " AS BEGIN insert into Tblcolor (cid,cname) values " +
                          "(@cid,@cname) END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }
                    if (KnowTableexsting("TblLanguage") == false)
                    {
                        sql = "CREATE TABLE [dbo].[TblLanguage](" +
                              "[id] [float] NULL, " +
                              "[English] [Nvarchar](50) NULL," +
                              "[Arabic] [Nvarchar](50) NULL" +
                              ") ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);


                        sql = "  CREATE PROCEDURE [dbo].[InsertLanguage] " +
                              "  @id float," +
                              "  @English nvarchar(50)," +
                              "  @Arabic nvarchar(50)" +
                              "  AS " +
                              "  BEGIN" +
                              "  insert into   TblLanguage (id,English,Arabic)" +
                              "  values (@id,@English,@Arabic)" +
                              "  RETURN " +
                              "  END";
                        _Dbtask.ExecuteNonQuery(sql);

                        CommonClass._Language.InsertValuesToTable();
                    }


                    CreateColumnInTable("tblreceiptdetails", "profit", "decimal(18,5)", "0");

                    /*Item master Rack*/
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                    " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    " SYSOBJECTS.NAME = 'tblitemmaster' AND SYSCOLUMNS.NAME = 'rack'";
                    string ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster add rack nvarchar(50)");
                    }


                    Ds = _Dbtask.ExecuteQuery("select * from Tblmnusettings where menuid=119");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        sql = "INSERT INTO [Tblmnusettings] "
                      + "([Menuid]"
                      + ",[Menuname]"
                      + ",[Parentid]"
                      + ",[Status])"
                      + "VALUES"
                      + "(119"
                      + ",'Pexciseduty'"
                      + ",23"
                      + ",-1)";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "update tblaccountledger set lname='Excise Duty' where lid=10";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "ALTER TABLE tblreceiptdetails "
                      + " ADD exciseduty decimal(18, 5)";
                        _Dbtask.ExecuteNonQuery(sql);
                    }
                    /*For Edit Gross Amt in Purchase*/
                    Ds = _Dbtask.ExecuteQuery("select * from Tblmnusettings where menuid=120");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        sql = "INSERT INTO [Tblmnusettings] "
                      + "([Menuid]"
                      + ",[Menuname]"
                      + ",[Parentid]"
                      + ",[Status])"
                      + "VALUE"
                      + "(120"
                      + ",'Peditgrossamt'"
                      + ",23"
                      + ",-1)";
                        _Dbtask.ExecuteNonQuery(sql);
                    }




                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='Pselect'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        sql = "INSERT INTO [tblparamlist] "
                    + "([paramname]"
                    + ",[paramtype]"
                    + ",[paramvalue])"
                    + "VALUES"
                    + "('Pselect'"
                    + ",'1'"
                    + ",'4')";
                        _Dbtask.ExecuteNonQuery(sql);
                    }


                    Count = _Dbtask.ExecuteScalar("SELECT count(*) " +
                                         "FROM INFORMATION_SCHEMA.TABLES " +
                                         " WHERE TABLE_NAME = 'tblissueproduct'");
                    if (Count == "0")
                    {
                        /*Item Master Sett For Production*/
                        sql = "CREATE TABLE [Tblproductsett](" +
                        "[id] [float] NOT NULL," +
                        "[item] [float] NOT NULL," +
                        "[qty]  [decimal](18, 5) NULL," +
                        "[mrate]  [decimal](18, 5) NULL)";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE TABLE [Tblproductsettdetail](" +
                        "[id] [float] NOT NULL," +
                        "[slno] [float] NOT NULL," +
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
                        "[istatus] [int]," +
                        "[Tvno] [float])";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE TABLE [Tblissueproductdetail](" +
                        "[issueid] [float] NOT NULL," +
                        "[slno] [float] NOT NULL," +
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
                        "[Qty] [decimal](18, 5) NULL," +
                        "[Bvno] [float] NOT NULL," +
                        "[gvno] [float] NOT NULL,)";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE TABLE [Tblreceivedproductdetail](" +
                        "[id] [float] NOT NULL," +
                        "[slno] [float] NOT NULL," +
                        "[item] [float] NOT NULL," +
                        "[qty]  [decimal](18, 5) NULL," +
                        "[Rate]  [decimal](18, 5) NULL)";
                        _Dbtask.ExecuteNonQuery(sql);
                        /*************************************************/



                        /*Production Product Sett*/


                        sql = "CREATE PROCEDURE [dbo].[Insertproductsett]" +
                        " @id float," +
                        " @item float," +
                         " @mrate decimal(18,5)" +
                        " AS" +
                        " BEGIN" +
                        " insert into tblproductsett (id,item,mrate) values (@id,@item,@mrate)" +
                        " END";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE PROCEDURE [dbo].[Insertproductsettdetail]" +
                         " @id float," +
                         " @slno float," +
                         " @item float," +
                         " @qty decimal(18,5)," +
                         " @rate decimal(18,5)" +
                         " AS" +
                         " BEGIN" +
                         " insert into tblproductsettdetail (id,slno,item,qty,rate) values (@id,@slno,@item,@qty,@rate)" +
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
                                " @item float," +
                                " @qty decimal(18,5)," +
                                " @rate decimal(18,5)" +
                                " AS" +
                                " BEGIN" +
                                " insert into tblissueproductdetail (issueid,slno,item,qty,rate) values (@issueid,@slno,@item,@qty,@rate)" +
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
                        " @item decimal(18,5)," +
                        " @qty decimal(18,5)," +
                        " @rate decimal(18,5)" +
                        " AS" +
                        " BEGIN" +
                        " insert into tblreceivedproductdetail (id,slno,item,qty,rate) values (@id,@slno,@item,@qty,@rate)" +
                        " END";
                        _Dbtask.ExecuteNonQuery(sql);


                        /******************************************************************************/
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='Pselect'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        sql = "INSERT INTO [tblparamlist] "
                    + "([paramname]"
                    + ",[paramtype]"
                    + ",[paramvalue])"
              + "VALUES"
                    + "('Pselect'"
                    + ",'1'"
                    + ",'4')";
                        _Dbtask.ExecuteNonQuery(sql);
                    }
                    /*For Edit Gross Amt in Purchase*/
                    Ds = _Dbtask.ExecuteQuery("select * from Tblmnusettings where menuid=120");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        sql = "INSERT INTO [Tblmnusettings] "
                      + "([Menuid]"
                      + ",[Menuname]"
                      + ",[Parentid]"
                      + ",[Status])"
                + "VALUES"
                      + "(120"
                      + ",'Peditgrossamt'"
                      + ",23"
                      + ",-1)";
                        _Dbtask.ExecuteNonQuery(sql);
                    }

                    /*For Excise Duty*/

                    Ds = _Dbtask.ExecuteQuery("select * from Tblmnusettings where menuid=119");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        sql = "INSERT INTO [Tblmnusettings] "
                      + "([Menuid]"
                      + ",[Menuname]"
                      + ",[Parentid]"
                      + ",[Status])"
                + "VALUES"
                      + "(119"
                      + ",'Pexciseduty'"
                      + ",23"
                      + ",-1)";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "update tblaccountledger set lname='Excise Duty' where lid=10";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "ALTER TABLE tblreceiptdetails "
                    + " ADD exciseduty decimal(18, 5)";
                        _Dbtask.ExecuteNonQuery(sql);
                    }

                    //FF
                    Count = _Dbtask.ExecuteScalar("select paramname from tblparamlist where  paramname IN('footer1','footer2','footer3','footer4','footer5') ");
                    if (Count == "")
                    {
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

                    }


                    Count = _Dbtask.ExecuteScalar("select isnull(status,5) from tblmnusettings where menuid=122");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "AB1";
                        _Paramlist.Paramtype = "1";
                        string temp = Application.StartupPath + "\\Backups";
                        _Paramlist.ParamValue = temp;
                        _Paramlist.InsertParamlist();

                        _Mnusettings.Menuid = "122";
                        _Mnusettings.MenuName = "AB";/*For Auto Backup*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "1";
                        _Mnusettings.InsertMnusettings();
                    }


                    Count = _Dbtask.ExecuteScalar("select isnull(status,5) from tblmnusettings where menuid=121");
                    if (Count == "")
                    {
                        _Mnusettings.Menuid = "121";
                        _Mnusettings.MenuName = "Useasbarcode";
                        _Mnusettings.Parentid = "103";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }


                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                    " SYSOBJECTS.NAME = 'tblproductrate' AND SYSCOLUMNS.NAME = 'batchid'");
                    if (Count == "0")
                    {

                        _Dbtask.ExecuteNonQuery("alter table TblProductRate add Batchid nvarchar(50)");
                    }



                    Count = _Dbtask.ExecuteScalar("select paramname from tblparamlist where paramname='Printbarcodein'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "Printbarcodein";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "Srate";
                        _Paramlist.InsertParamlist();
                    }


                    Count = _Dbtask.ExecuteScalar("select isnull(status,5) from tblmnusettings where menuid=123");
                    if (Count == "")
                    {
                        _Mnusettings.Menuid = "123";
                        _Mnusettings.MenuName = "Sizes";/*For Sizes*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();


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

                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster add Sizelessname nvarchar(50)");
                        RefreshonCamapany();

                    }



                    /*For Cheking Itemclass is exsting in Itemmaster*/
                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    " SYSOBJECTS.NAME = 'tblitemmaster' AND SYSCOLUMNS.NAME = 'itemclass'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster add Itemclass nvarchar(50)");
                    }

                    /*For Add Update Srate in Sales*/
                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=124");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "124";
                        _Mnusettings.MenuName = "Updatesrateinsale";/*For Update Sale Rate in Sale*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();

                    }



                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                   " SYSOBJECTS.NAME = 'tbluserdetails' AND SYSCOLUMNS.NAME = 'Ugroup'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tbluserdetails add Ugroup float");
                        _Dbtask.ExecuteNonQuery("alter table tbluserdetails add astatus int");
                        _Dbtask.ExecuteNonQuery("delete from tbluserdetails");
                        sql = "alter PROCEDURE [dbo].[InsertUserdetails]" +
                              "@userid float," +
                              "@username nvarchar(50)," +
                              "@upassword nvarchar(50)," +
                              "@Ugroup float," +
                              "@astatus int " +
                              "AS " +
                              "BEGIN " +
                              "INSERT INTO tbluserdetails(userid,username,upassword,Ugroup,astatus) " +
                              "VALUES(@userid,@username,@upassword,@Ugroup,@astatus) " +
                              "END";
                        _Dbtask.ExecuteNonQuery(sql);

                        CommonClass._UserDetails.UserId = 1;
                        CommonClass._UserDetails.UserName = "ADMIN";
                        CommonClass._UserDetails.Password = "admin";
                        CommonClass._UserDetails.AStatus = -1;
                        CommonClass._UserDetails.Groupid = 0;
                        CommonClass._UserDetails.InserUser();
                    }



                    /*Add Groupid and Astatus in userdetails*/

                    /*For Add Update Srate in Sales*/
                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=126");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "126";
                        _Mnusettings.MenuName = "Sfocusfirstrow";/*Focus First Row In Sale*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();

                    }


                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                        " SYSOBJECTS.NAME = 'tblreceiptdetails' AND SYSCOLUMNS.NAME = 'itemnote1'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblreceiptdetails add itemnote1 nvarchar(50)");
                    }


                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='127'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
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
                    }



                    /*For ItemNote1 Add*/
                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='129'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "129";
                        _Mnusettings.MenuName = "Customerpoint";/*Itemnote1 in Purchase*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                        _Dbtask.ExecuteNonQuery("alter table TblAccountLedger add Cplan float");
                    }


                    /*For Barcode Settings Add*/
                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='130'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "130";
                        _Mnusettings.MenuName = "SelBarcode";/*Itemnote1 in Purchase*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
                        _Mnusettings.InsertMnusettings();
                    }


                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='131'");
                    /*For Add Printing Addition Manfacturing.Date,Note1,Note2*/
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
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
                    }


                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='134'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "134";
                        _Mnusettings.MenuName = "SuppliercodeBPrint";/*Select Barcode Printing Mode*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
                        _Mnusettings.InsertMnusettings();
                    }


                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='135'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "135";
                        _Mnusettings.MenuName = "Sprintwhilesaving";/*Print While Saving In S.I*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
                        _Mnusettings.InsertMnusettings();

                        _Mnusettings.Menuid = "136";
                        _Mnusettings.MenuName = "Sprintconfirmation";/*Print Confirmation in S.I*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
                        _Mnusettings.InsertMnusettings();
                    }


                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'Prebarcode'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "Prebarcode";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "";
                        _Paramlist.InsertParamlist();
                    }


                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                   " SYSOBJECTS.NAME = 'tblbusinessissue' AND SYSCOLUMNS.NAME = 'adamount'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblbusinessissue add adamount decimal(18, 5)");
                        _Dbtask.ExecuteNonQuery("alter table tbltransactionreceipt add adamount decimal(18, 5)");
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                            " SYSOBJECTS.NAME = 'tblaccountledger' AND SYSCOLUMNS.NAME = 'lstatus'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblaccountledger add lstatus int");
                        _Mnusettings.Menuid = "137";
                        _Mnusettings.MenuName = "DeactiveCustomer";/*Print Confirmation in S.I*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
                        _Mnusettings.InsertMnusettings();
                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'ItemSearch'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "ItemSearch";/*For ItemSear 1=First,2=Second,3=Any Key*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "3";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'SB'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "SB";/*For ItemSear 1=First,2=Second,3=Any Key*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "0";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'Bscroll'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "Bscroll";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "6";
                        _Paramlist.InsertParamlist();

                        _Paramlist.ParamName = "Fscroll";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "16";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'LaserTop'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "LaserTop";/*For ItemSear 1=First,2=Second,3=Any Key*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "30";
                        _Paramlist.InsertParamlist();

                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'LeftBarcode'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "LeftBarcode";/*For Left of Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "10";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'Sprefix'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "Sprefix";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "2";
                        _Paramlist.ParamValue = "";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'SPrintSelect'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "SPrintSelect";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'MaxBcode'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "MaxBcode";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "100";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                           " SYSOBJECTS.NAME = 'tblaccountledger' AND SYSCOLUMNS.NAME = 'lstatus2'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblaccountledger add lstatus2 int");
                    }

                    //Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    //                        " SYSOBJECTS.NAME = 'tblaccountledger' AND SYSCOLUMNS.NAME = 'lstatus1'");
                    //if (Count == "0")
                    //{
                    //    _Dbtask.ExecuteNonQuery("alter table tblaccountledger add lstatus1 int");
                    //}


                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='138'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "138";
                        _Mnusettings.MenuName = "Sprintpreview";/*Print Confirmation in S.I*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
                        _Mnusettings.InsertMnusettings();
                    }


                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='139'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "139";
                        _Mnusettings.MenuName = "CashDesk";/*Print Preview in S.I*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";//-1 is Roll 1 is Laser
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='140'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "140";
                        _Mnusettings.MenuName = "Scrm";/*CRM*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='302010'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "302010";
                        _Mnusettings.MenuName = "baseunit";/*CRM*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='302011'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "302011";
                        _Mnusettings.MenuName = "tailor";/*CRM*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid='141'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "141";
                        _Mnusettings.MenuName = "Serialnotracking";/*Serial No TTRackin*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                           " SYSOBJECTS.NAME = 'TblIssuedetails' AND SYSCOLUMNS.NAME = 'Slnotracking'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table TblIssuedetails add Slnotracking nvarchar(50)");
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                           " SYSOBJECTS.NAME = 'tblcustomerpoint' ");
                    if (Count == "0")
                    {
                        sql = "CREATE TABLE [dbo].[tblcustomerpoint](" +
                            "[cpid] [float] NULL," +
                            "[cardname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                            "[validfrom] [datetime] NULL," +
                            "[validto] [datetime] NULL," +
                            "[salevalue] [decimal](18, 5) NULL," +
                            "[point] [decimal](18, 5) NULL," +
                            "[discount] [decimal](18, 5) NULL" +
                        ") ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE PROCEDURE [dbo].[Insertcustomerpoint]" +
                           " @cpid float," +
                           " @cardname  nvarchar(50)," +
                           " @validfrom  datetime," +
                           " @validto  datetime," +
                           " @salevalue  decimal(18,5)," +
                           " @point  decimal(18,5)," +
                           " @discount  decimal(18,5)" +
                           " AS" +
                           " BEGIN" +
                           " insert into tblcustomerpoint (cpid,cardname,validfrom,validto,salevalue,point,discount)" +
                           " values (@cpid,@cardname,@validfrom,@validto,@salevalue,@point,@discount)" +
                           " END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                            " SYSOBJECTS.NAME = 'tblinventory' AND SYSCOLUMNS.NAME = 'Slno'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblinventory add Slno nvarchar(50)");
                        sql = "CREATE TABLE [dbo].[tblslnotracking](" +
                              "[itemid] [float] NULL," +
                              "[Slno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                              "[slstatus] int " +
                            ") ON [PRIMARY]";


                        _Dbtask.ExecuteNonQuery(sql);

                        /*For Slno Tracking*/
                        sql = "CREATE PROCEDURE [dbo].[Insertslnotracking]" +
                            " @itemid float," +
                            " @Slno  nvarchar(50)," +
                            " @slstatus  int " +
                            " AS" +
                            " BEGIN" +
                            " insert into tblslnotracking (itemid,Slno,slstatus)" +
                            " values (@itemid,@Slno,@slstatus)" +
                            " END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                            " SYSOBJECTS.NAME = 'tblaccountledger' AND SYSCOLUMNS.NAME = 'cst'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblaccountledger add cst nvarchar(50)");
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                                 " SYSOBJECTS.NAME = 'tbltempcontact' ");
                    if (Count == "0")
                    {
                        /*For TempContacts */
                        sql = "CREATE TABLE [dbo].[tbltempcontact](" +
                        "[tid] [float] NULL," +
                        "[tname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                        "[tmobile] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                        "[taddress] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                        "[Area] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                        "[temail] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL" +
                        ") ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        /*For TempContacts */
                        sql = "create PROCEDURE [dbo].[Inserttempcontact]" +
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

                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='CreditLimit'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Paramlist.ParamName = "CreditLimit";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "Allow";
                        _Paramlist.InsertParamlist();

                        _Paramlist.ParamName = "MinusCash";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "Allow";
                        _Paramlist.InsertParamlist();
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                    " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    " SYSOBJECTS.NAME = 'tblaccountledger' AND SYSCOLUMNS.NAME = 'cpbalance'";
                    ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblaccountledger add cpbalance decimal(18, 5)");
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                       " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                       " SYSOBJECTS.NAME = 'TblbusinessIssue' AND SYSCOLUMNS.NAME = 'cpdiscount'";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table TblbusinessIssue add cpdiscount decimal(18, 5)");
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                                " SYSOBJECTS.NAME = 'tbltempcontact'  AND SYSCOLUMNS.NAME = 'area'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tbltempcontact add area nvarchar(50)");
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='Nocopies'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Paramlist.ParamName = "Nocopies";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "1";
                        _Paramlist.InsertParamlist();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='BarcodeHeading'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Paramlist.ParamName = "BarcodeHeading";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "";
                        _Paramlist.InsertParamlist();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=142");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "142";
                        _Mnusettings.MenuName = "barcodeheadinguseascompanyname";/*Serial No Tracking*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                                " SYSOBJECTS.NAME = 'tblauditlog' ");
                    if (Count == "0")
                    {
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

                        sql = "CREATE PROCEDURE [Insertauditlog] @mdate datetime, @userid nvarchar (50), @computername nvarchar(50), " +
                        "@actiontype nvarchar(30),@actiontype1 nvarchar(30), @mformname nvarchar(50), @description nvarchar(200)," +
                        "@olddata nvarchar(200), @newdata nvarchar(200) " +
                        "AS BEGIN INSERT INTO tblauditlog(mdate,userid,computername,actiontype,actiontype1,mformname,description,olddata,newdata) VALUES" +
                        "(@mdate,@userid,@computername,@actiontype,@actiontype1,@mformname,@description,@olddata,@newdata) END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }
                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                                 " SYSOBJECTS.NAME = 'tblauditlog' AND SYSCOLUMNS.NAME = 'actiontype1'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblauditlog add olddata nvarchar(200)");
                        _Dbtask.ExecuteNonQuery("alter table tblauditlog add newdata nvarchar(200)");
                        _Dbtask.ExecuteNonQuery("alter table tblauditlog add actiontype1 nvarchar(30)");
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=143");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "143";
                        _Mnusettings.MenuName = "Salesinvdiscount";/*Serial No Tracking*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                                 " SYSOBJECTS.NAME = 'tblbusinessissue' AND SYSCOLUMNS.NAME = 'invdisc'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblbusinessissue add invdisc decimal(18, 5)");
                        _Dbtask.ExecuteNonQuery("alter table tbltransactionreceipt add invdisc decimal(18, 5) ");
                        _Dbtask.ExecuteNonQuery("alter table tblissuedetails add Billdisc decimal(18, 5)");
                        _Dbtask.ExecuteNonQuery("alter table tblreceiptdetails add Billdisc decimal(18, 5)");
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=144");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "144";
                        _Mnusettings.MenuName = "Wmachine";/*Wieght Machine*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=146");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "146";
                        _Mnusettings.MenuName = "VPrateinP";/*Serial No Tracking*/
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

                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                                 " SYSOBJECTS.NAME = 'tblitemmaster' AND SYSCOLUMNS.NAME = 'plu'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster add plu nvarchar(50)");
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='Pfooter'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Paramlist.ParamName = "Pfooter";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                                 " SYSOBJECTS.NAME = 'tblbatch' AND SYSCOLUMNS.NAME = 'exdate'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblbatch add exdate datetime");
                        _Dbtask.ExecuteNonQuery("alter table tblbatch add mandate datetime");
                        _Dbtask.ExecuteNonQuery("alter table tblreceiptdetails add exdate datetime");
                        _Dbtask.ExecuteNonQuery("alter table tblreceiptdetails add mandate datetime");
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                          " SYSOBJECTS.NAME = 'tblinventory' AND SYSCOLUMNS.NAME = 'ps'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblinventory add ps decimal(18,5)");//decimal(18,5)
                        _Dbtask.ExecuteNonQuery("alter table tblissuedetails add qty1 decimal(18,5)");
                        _Dbtask.ExecuteNonQuery("alter table tblissuedetails add qty2 decimal(18,5)");

                        _Dbtask.ExecuteNonQuery("update  tblinventory set ps=0");
                        _Dbtask.ExecuteNonQuery("update tblissuedetails set  qty2=0");
                        _Dbtask.ExecuteNonQuery("update tblissuedetails  set qty1=0");
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                   " SYSOBJECTS.NAME = 'tblbusinessissue' AND SYSCOLUMNS.NAME = 'opno'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblbusinessissue add opno int");//decimal(18,5)
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                 " SYSOBJECTS.NAME = 'tblRepacking' ");
                    if (Count == "0")
                    {
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
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                 " SYSOBJECTS.NAME = 'tblRepacking' AND SYSCOLUMNS.NAME = 'DepoId'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblRepacking  add DepoId decimal(18,5)");//decimal(18,5)
                        _Dbtask.ExecuteNonQuery("alter table tblRepacking  add LabourCharge decimal(18,5)");//decimal(18,5)
                        _Dbtask.ExecuteNonQuery("alter table tblRepacking  add CostFactor decimal(18,5)");//decimal(18,5)
                        _Dbtask.ExecuteNonQuery("alter table TblRepackingDetails   add DepoId decimal(18,5)");//decimal(18,5)

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
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                 " SYSOBJECTS.NAME = 'tblmenus' ");
                    if (Count == "0")
                    {
                        sql = "CREATE TABLE [dbo].[tblmenus](" +
                       "[ID][float] NOT NULL," +
                       "[MenuName][nvarchar](200) NULL)";
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

                        CommonClass._CompanyCreate.InsertMenus();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                " SYSOBJECTS.NAME = 'tblissuedetails'  AND SYSCOLUMNS.NAME = 'pnum'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblissuedetails  add pnum float");//decimal(18,5)
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from Tblmnusettings where menuid=149");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        sql = "INSERT INTO [Tblmnusettings] "
                      + "([Menuid]"
                      + ",[Menuname]"
                      + ",[Parentid]"
                      + ",[Status])"
                      + "VALUES"
                      + "(149"
                      + ",'Supitem'"
                      + ",0"
                      + ",-1)";
                        _Dbtask.ExecuteNonQuery(sql);

                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster  add ledid float");//decimal(18,5)

                    }
                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                  " SYSOBJECTS.NAME = 'TblReceiptDetails'  AND SYSCOLUMNS.NAME = 'wrate'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table TblReceiptDetails  add wrate decimal(18,5)");//decimal(18,5)
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                   " SYSOBJECTS.NAME = 'tblitemmaster'  AND SYSCOLUMNS.NAME = 'UnitAmount1'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster  add UnitAmount1 decimal(18,5)");//decimal(18,5)
                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster  add UnitAmount2 decimal(18,5)");//decimal(18,5)
                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster  add Unit2 nvarchar(50)");//decimal(18,5)
                    }
                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                    " SYSOBJECTS.NAME = 'Tbladdenquiry'  ");
                    if (Count == "0")
                    {
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
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                     " SYSOBJECTS.NAME = 'tblUnitcreation'  ");
                    if (Count == "0")
                    {
                        /*For Unitcreation*/
                        sql = "CREATE TABLE [dbo].[tblUnitcreation](" +
                            "[Id][float] NOT NULL," +
                            "[Name][nvarchar](200) NULL)";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "create PROCEDURE [dbo].[InsertUnitcreation]" +
                        "@Id float," +
                        "@Name nvarchar(200)" +
                        " AS" +
                        " BEGIN" +
                        " insert into tblUnitcreation(Id,Name) values (@id,@Name)" +
                        " END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname ='Fscroll'");

                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Paramlist.ParamName = "Fscroll";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "16";
                        _Paramlist.InsertParamlist();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname ='Reverse'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Paramlist.ParamName = "Reverse";/*For Topof Barcode Print*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "6";
                        _Paramlist.InsertParamlist();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid ='150'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "150";
                        _Mnusettings.MenuName = "PrintBalance";/*Print Old Balance*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname ='Dissticker'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Paramlist.ParamName = "Dissticker";/*ForDistance of Barcode*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "160";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                        " SYSOBJECTS.NAME = 'tblbusinessissue' AND SYSCOLUMNS.NAME = 'Mpayment'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblbusinessissue add Mpayment int");
                        _Dbtask.ExecuteNonQuery("alter table tbltransactionreceipt add Mpayment int");
                        _Dbtask.ExecuteNonQuery("alter table tblaccountledger add usecard int");
                    }



                    //BILLAGNST

                    //Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    //                       " SYSOBJECTS.NAME = 'tblBILLAGAINSTT' ");
                    //if (Count == "0")
                    //{

                    //    sql = "CREATE TABLE [dbo].[TblChequeAgainstBill](" +
                    //        "[Chqvno] [float] NULL," +
                    //        "[Billvno] [float] NULL," +
                    //        "[Vtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                    //        "[Balence] [decimal](18, 5) NULL," +
                    //        "[Amount] [decimal](18, 5) NULL" +
                    //        ") ON [PRIMARY]";
                    //    _Dbtask.ExecuteNonQuery(sql);

                    //    sql = "CREATE PROCEDURE [dbo].[InsertChequeAgainstBill]" +
                    //       " @Chqvno float," +
                    //       " @Billvno  float," +
                    //       " @Vtype  nvarchar(50)," +
                    //       " @Balence  decimal(18,5)," +
                    //       " @Amount  decimal(18,5)" +

                    //       " AS" +
                    //       " BEGIN" +
                    //       " insert into TblChequeAgainstBill (Chqvno,Billvno,Vtype,Balence,Amount)" +
                    //       " values (@Chqvno,@Billvno ,@Vtype ,@Balence,@Amount)" +
                    //       " END";
                    //    _Dbtask.ExecuteNonQuery(sql);

                    //}


                    /*For CheQue*/
                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                      " SYSOBJECTS.NAME = 'Tblchqreceived' ");
                    if (Count == "0")
                    {
                        sql = "CREATE TABLE [dbo].[Tblchqreceived]( " +
                        " [Id] [float] NOT NULL, " +
                        " [Pdate] [datetime] NULL, " +
                        " [Alid] [float] NULL, " +
                        " [Blid] [float] NULL, " +
                        " [Amount] [decimal](18, 5) NULL, " +
                        " [ChequeNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                        " [Status] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                        " [CDate] [datetime] NULL, " +
                        " [CollDate] [datetime] NULL, " +
                        " [Note] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                        " [CMode] int, " +
                        " [Genid] float, " +
                        " CONSTRAINT [PK_Tblchqreceived] PRIMARY KEY CLUSTERED  " +
                        " ([Id] ASC " +
                        " )WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY] " +
                        " ) ON [PRIMARY]";
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
                        "@Genid float" +
                        " AS" +
                        " BEGIN" +
                        " insert into Tblchqreceived(Id,Pdate,Alid,Blid,Amount,ChequeNo," +
                        " Status,CDate,CollDate,Note,CMode,Genid " +
                        " ) values (@Id,@Pdate,@Alid,@Blid,@Amount,@ChequeNo,@Status,@CDate,@CollDate,@Note,@CMode,@Genid)" +
                        " END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname='AB2'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
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



                        _Mnusettings.Menuid = "152";
                        _Mnusettings.MenuName = "VSSrate";/*Save Zero P.Rate*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();

                        _Paramlist.ParamName = "StrBarcode";/* Add Starting Barcode*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "";
                        _Paramlist.InsertParamlist();

                        _Paramlist.ParamName = "StrSrate";/* Add String Replace of S.Rate*/
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "S.Rate";
                        _Paramlist.InsertParamlist();

                        _Mnusettings.Menuid = "153";
                        _Mnusettings.MenuName = "SRemDubli";/*Remove Dublicate in Sales*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                   " SYSOBJECTS.NAME = 'tblproductsett' AND SYSCOLUMNS.NAME = 'Bcode'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblproductsett add Bcode [nvarchar](50)");
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                   " SYSOBJECTS.NAME = 'Tblchqreceived' AND SYSCOLUMNS.NAME = 'CollDate'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table Tblchqreceived add CollDate datetime");
                        _Dbtask.ExecuteNonQuery("alter table Tblchqreceived add Genid float");
                    }
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                    " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    " SYSOBJECTS.NAME = 'Tblchqreceived' AND SYSCOLUMNS.NAME = 'Discount'";
                    ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table Tblchqreceived add discount [decimal](18, 5)");
                    }


                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                  " SYSOBJECTS.NAME = 'Tblpricecode'");
                    if (Count == "0")
                    {
                        sql = "CREATE TABLE [dbo].[Tblpricecode]( " +
                           " [field] [nvarchar](50), " +
                           " [code] [nvarchar](50))";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "create PROCEDURE [dbo].[Insertpricecode]" +
                              "@field [nvarchar](50)," +
                              "@code [nvarchar](50)" +
                              " AS" +
                              " BEGIN" +
                              " insert into Tblpricecode(field,code) values (@field,@code)" +
                              " END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='PMpayment'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Paramlist.ParamName = "PMpayment";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "0";
                        _Paramlist.InsertParamlist();

                        _Paramlist.ParamName = "PSpayment";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "0";
                        _Paramlist.InsertParamlist();
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                   " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                   " SYSOBJECTS.NAME = 'tblbusinessissue' AND SYSCOLUMNS.NAME = 'SR'";
                    ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        //_Dbtask.ExecuteNonQuery("alter table tblbusinessissue add CashReceived nvarchar(50)");
                        _Dbtask.ExecuteNonQuery("alter table tblbusinessissue add SR nvarchar(50)");
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                      " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                      " SYSOBJECTS.NAME = 'Tblpartyproject' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        sql = "CREATE TABLE [dbo].[Tblpartyproject]( " +
                          " [pid] float, " +
                          " [pname] [nvarchar](50), " +
                          " [partyid] float )";
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

                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                      " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                      " SYSOBJECTS.NAME = 'Tblpartyproject' AND SYSCOLUMNS.NAME = 'Address' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table Tblpartyproject add Address nvarchar(250)");
                        _Dbtask.ExecuteNonQuery("alter table Tblpartyproject add Mobile nvarchar(50)");
                        _Dbtask.ExecuteNonQuery("alter table tblbusinessissue add pproject float");
                        _Dbtask.ExecuteNonQuery("alter table tblgeneralledger add pproject float");

                        _Mnusettings.Menuid = "156";
                        _Mnusettings.MenuName = "Spproject";/*Allow Dublicate*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=157");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "157";
                        _Mnusettings.MenuName = "SBarcodelogo";/*For Print Logo in Barcode*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=158");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {


                        sql = "CREATE TABLE [dbo].[Tblremainder]( " +
                                        " [Rid] float, " +
                                        " [Rname] [nvarchar](50), " +
                                        " [Rsubject] [nvarchar](250), " +
                                        " [Rdate] [datetime] NULL,  " +
                                        " [Rstatus] int )";
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

                        _Paramlist.ParamName = "Strstock";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "0";
                        _Paramlist.InsertParamlist();

                        _Paramlist.ParamName = "Strbalance";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "0";
                        _Paramlist.InsertParamlist();



                        _Mnusettings.Menuid = "158";
                        _Mnusettings.MenuName = "Strstock";/*Remainder of Stock Balance*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "1";
                        _Mnusettings.InsertMnusettings();

                        _Mnusettings.Menuid = "159";
                        _Mnusettings.MenuName = "StrBalance";/*Remainder of Account Balance*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='Gmitemname'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
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
                    }
                    sql = "SELECT * FROM SYSOBJECTS  " +
                         " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                         " SYSOBJECTS.NAME = 'tblUnitcreation' AND SYSCOLUMNS.NAME = 'ucount' ";
                    Ds = _Dbtask.ExecuteQuery(sql);

                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblUnitcreation add ucount [decimal](18, 5)");
                    }

                    sql = "SELECT * FROM SYSOBJECTS  " +
                          " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                          " SYSOBJECTS.NAME = 'tblbatch' AND SYSCOLUMNS.NAME = 'unconv' ";
                    Ds = _Dbtask.ExecuteQuery(sql);

                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblbatch add unconv [decimal](18, 5)");
                    }

                    sql = "SELECT * FROM SYSOBJECTS  " +
                             " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                             " SYSOBJECTS.NAME = 'tblbillsett' ";
                    Ds = _Dbtask.ExecuteQuery(sql);

                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "160";
                        _Mnusettings.MenuName = "Editsqty";/*For Edit Qty in sale*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();


                        sql = "CREATE TABLE [dbo].[tblbillsett]( " +
                        " [vno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                        " [vtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                        " [Ledcode] [float] NULL, " +
                        " [Dbamt] [decimal](18, 5) NULL, " +
                        " [Cramt] [decimal](18, 5) NULL," +
                        " [Agvno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                        " [Dt] [datetime] NULL " +
                        " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "create PROCEDURE [dbo].[InsertBillsett] @vno nvarchar (50), @vtype nvarchar (50), @ledcode float, " +
                        " @Dbamt decimal(18,5),@cramt decimal(18,5),@agvno nvarchar(50),@dt datetime " +
                        " AS BEGIN INSERT INTO tblbillsett(vno,vtype,ledcode,dbamt,cramt,agvno,Dt)  " +
                        " VALUES(@vno,@vtype,@ledcode,@dbamt,@cramt,@agvno,@dt) END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }

                    sql = "SELECT * FROM SYSOBJECTS  " +
                         " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                         " SYSOBJECTS.NAME = 'tblinventory' AND SYSCOLUMNS.NAME = 'UC' ";
                    Ds = _Dbtask.ExecuteQuery(sql);

                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblinventory add UC [decimal](18, 5)");
                    }

                    /*Item master Leangag*/
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                    " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    " SYSOBJECTS.NAME = 'tblitemmaster' AND SYSCOLUMNS.NAME = 'llang'";
                    ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster add llang nvarchar(50)");
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=161");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "161";
                        _Mnusettings.MenuName = "Printl";/*Print multi langague*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=162");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "162";
                        _Mnusettings.MenuName = "Printcon";/*Print multi langague*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                         " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                         " SYSOBJECTS.NAME = 'TblTransactionReceipt' AND SYSCOLUMNS.NAME = 'pproject' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table TblTransactionReceipt add pproject float");
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                             " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                             " SYSOBJECTS.NAME = 'TblEmployeemaster' AND SYSCOLUMNS.NAME = 'mpayment' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table TblEmployeemaster add mpayment  nvarchar(50)");
                    }

                    /*********************************************************/
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                " SYSOBJECTS.NAME = 'tblattendancemain'  ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
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

                    }

                    /********************************************************/
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                 " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                 " SYSOBJECTS.NAME = 'tblissuedetails' AND SYSCOLUMNS.NAME = 'lth'  ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tbltransactionreceipt add Billimg image");
                        _Dbtask.ExecuteNonQuery("alter table tblissuedetails add lth [decimal](18, 5)");
                        _Dbtask.ExecuteNonQuery("alter table tblissuedetails add wth [decimal](18, 5)");
                    }

                    /********************************************************/
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                 " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                 " SYSOBJECTS.NAME = 'tblgeneralledger' AND SYSCOLUMNS.NAME = 'naration2'  ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblgeneralledger add naration2 nvarchar(200)");
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=163");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "163";
                        _Mnusettings.MenuName = "Setsalerateincludetax";/*Print multi langague*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='Leftleser'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Paramlist.ParamName = "Leftleser";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "5";
                        _Paramlist.InsertParamlist();

                        _Paramlist.ParamName = "Toplaser";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "0";
                        _Paramlist.InsertParamlist();
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                 " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                 " SYSOBJECTS.NAME = 'tblattendancedetail'  AND SYSCOLUMNS.NAME = 'ovmark'";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblattendancedetail add ovmark int");
                        _Dbtask.ExecuteNonQuery("alter table tblattendancedetail add extra2 [decimal](18, 5)");
                    }

                    sql = "SELECT count(*) from tblaccountgroup where agroupid=30";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        CommonClass._AccountGroup.AccountGroupIDLng = 30;
                        CommonClass._AccountGroup.GroupNameStr = "Salaries AND Incentives";
                        CommonClass._AccountGroup.UnderInt = 15;
                        CommonClass._AccountGroup.InsertAccountsGroup();

                        CommonClass._AccountGroup.AccountGroupIDLng = 31;
                        CommonClass._AccountGroup.GroupNameStr = "Salaries";
                        CommonClass._AccountGroup.UnderInt = 30;
                        CommonClass._AccountGroup.InsertAccountsGroup();

                        //CommonClass._Ledger.LidLng = 29;
                        //CommonClass._Ledger.LNameStr = "Salary";
                        //CommonClass._Ledger.GidLng = 30;
                        //CommonClass._Ledger.InsertLedger();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=164");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "164";
                        _Mnusettings.MenuName = "Zerotaxamount";/*Print multi langague*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                               " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                               " SYSOBJECTS.NAME = 'TblTransactionReceipt' AND SYSCOLUMNS.NAME = 'Bdate'  ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table TblTransactionReceipt add Bdate datetime");
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=165");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "165";
                        _Mnusettings.MenuName = "Bdate";/*Billing date in Purchase*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                               " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                               " SYSOBJECTS.NAME = 'Tblbusinessissue' AND SYSCOLUMNS.NAME = 'Uid'  ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table TblTransactionReceipt add Uid nvarchar(50)");
                        _Dbtask.ExecuteNonQuery("alter table Tblbusinessissue add Uid nvarchar(50)");
                        _Dbtask.ExecuteNonQuery("alter table Tblgeneralledger add Uid nvarchar(50)");
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                " SYSOBJECTS.NAME = 'Tblcommision' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        sql = "CREATE TABLE [dbo].[Tblcommision]( " +
                      "[cid] [float] NULL, " +
                      "[Cname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                      "[Cperc] [decimal](18, 5) NULL, " +
                      "[Cfromamount] [decimal](18, 5) NULL, " +
                      "[Ctoamount] [decimal](18, 5) NULL, " +
                      "[Cfor] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
                      " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE   PROCEDURE [dbo].[Insertcommision] @Cid float, @Cname [nvarchar](50) " +
                    ",@Cperc  decimal(18, 5),@Cfromamount  decimal(18, 5), " +
                    "@Ctoamount  decimal(18, 5),@Cfor [nvarchar](50) " +
                    " AS BEGIN insert into Tblcommision (Cid,Cname,Cperc,Cfromamount,Ctoamount,Cfor) values " +
                    "(@Cid,@Cname,@Cperc,@Cfromamount,@Ctoamount,@Cfor) END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }



                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                " SYSOBJECTS.NAME = 'Tblarea' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {

                        sql = "CREATE TABLE [dbo].[Tblarea]( " +
                         "[Aid] [float] NULL, " +
                         "[Aname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
                         " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE   PROCEDURE [dbo].[Insertarea] @Aid float, @Aname [nvarchar](50) " +
               " AS BEGIN insert into Tblarea (Aid,Aname) values " +
               "(@Aid,@Aname) END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }


                    //chqq gnltbl
                    CreateColumnInTable("Tblchqreceived", "TotAmt", "Decimal(18,5)", "0");
                    CreateColumnInTable("Tblgeneralledger", "BillBalance", "Decimal(18,5)", "0");
                    CreateColumnInTable("Tblgeneralledger", "RecvdAmt", "Decimal(18,5)", "0");



                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=166");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "166";
                        _Mnusettings.MenuName = "Singlebarcode";/*Single barcode*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }



                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='WNstock'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {

                        /*Warning*/
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
                        /***********************************/

                        _Mnusettings.Menuid = "167";
                        _Mnusettings.MenuName = "CArea";/*Customer Area in Sales*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblarea where aid=0");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        CommonClass._Area.Aid = 0;
                        CommonClass._Area.Aname = "None";
                        CommonClass._Area.InsertArea();

                        CommonClass._Area.Updatecustomerfield();
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                " SYSOBJECTS.NAME = 'Tblunitsrates' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        sql = "CREATE TABLE [dbo].[Tblunitsrates](" +
                      "[Uid] [float] NULL, " +
                      "[Itemid] [float] NULL," +
                      "[Prate] [decimal](18, 5) NULL," +
                      "[Srate] [decimal](18, 5) NULL," +
                      "[Mrp] [decimal](18, 5) NULL" +
                   ") ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE   PROCEDURE [dbo].[Insertunitssrates] @Uid float,@itemid float," +
                        " @Prate  decimal(18, 5),@Srate  decimal(18, 5),@Mrp  decimal(18, 5) " +
                        " AS BEGIN insert into Tblunitsrates (Uid,Itemid,Prate,Srate,Mrp) values " +
                        "(@Uid,@Itemid,@Prate,@Srate,@Mrp)  END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                   " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                   " SYSOBJECTS.NAME = 'tblgeneralledger' AND SYSCOLUMNS.NAME = 'Discount'";
                    ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblgeneralledger add discount [decimal](18, 5)");
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                " SYSOBJECTS.NAME = 'Tblunitsrates' AND SYSCOLUMNS.NAME = 'Rid'";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table Tblunitsrates add Rid float");
                    }
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                 " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                 " SYSOBJECTS.NAME = 'Tblunitsrates' AND SYSCOLUMNS.NAME = 'Wrate1'";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table Tblunitsrates add Wrate [decimal](18, 5)");
                        _Dbtask.ExecuteNonQuery("alter table Tblunitsrates add Wrate1 [decimal](18, 5)");
                        _Dbtask.ExecuteNonQuery("alter table Tblunitsrates add Wrate2 [decimal](18, 5)");
                        _Dbtask.ExecuteNonQuery("alter table Tblunitsrates add wrate3 [decimal](18, 5)");

                    }


                    Ds = _Dbtask.ExecuteQuery("select * from tblmnusettings where menuid=168");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "167";
                        _Mnusettings.MenuName = "Savezeroratesale";/*Save zero rate in Sales*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                           " SYSOBJECTS.NAME = 'TblIssuedetails' AND SYSCOLUMNS.NAME = 'Crate'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table TblIssuedetails add Crate [decimal](18, 5)");
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                           " SYSOBJECTS.NAME = 'tblcompanymaster' AND SYSCOLUMNS.NAME = 'Nameinhome'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblcompanymaster add Nameinhome [nvarchar](50)");
                    }

                    /*Print Second Langague in Barcode sticker*/
                    Ds = _Dbtask.ExecuteQuery("select * from Tblmnusettings where menuid=169");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        _Mnusettings.Menuid = "169";
                        _Mnusettings.MenuName = "PrintSecondlngue";/*Print Second Langague in Barcode sticker*/
                        _Mnusettings.Parentid = "0";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                        " SYSOBJECTS.NAME = 'tblinventory' AND SYSCOLUMNS.NAME = 'exdate'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblinventory add exdate datetime");
                        _Dbtask.ExecuteNonQuery("update tblinventory set exdate='01-01-1900'");
                    }
                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'LessAmount'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "LessAmount";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "100";
                        _Paramlist.InsertParamlist();
                    }
                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                         " SYSOBJECTS.NAME = 'tblissuedetails' AND SYSCOLUMNS.NAME = 'Exdate'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblissuedetails add exdate datetime");
                    }


                    CommonClass._Menusettings.InsertMnusettingsIsnotexsting("1007", "EditPurchaseItemName", "0", "1");
                    CommonClass._Menusettings.InsertMnusettingsIsnotexsting("1008", "EditPurchaseItemCode", "0", "1");

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'Staxinclusive'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "Staxinclusive";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "Yes";
                        _Paramlist.InsertParamlist();
                    }

                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'PrintTaxpurchase'");
                    if (Count == "")
                    {
                        _Paramlist.ParamName = "PrintTaxpurchase";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = "1";
                        _Paramlist.InsertParamlist();
                    }
                    //Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    //                       " SYSOBJECTS.NAME = 'TblitemMastersimple' ");
                    //if (Count == "0")
                    //{
                    //    sql = "CREATE TABLE [dbo].[TblitemMastersimple](" +
                    //        "[id] [float] NULL," +
                    //        "[itemid] [float] NULL," +
                    //        "[Barcode][nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
                    //    ") ON [PRIMARY]";
                    //    _Dbtask.ExecuteNonQuery(sql);

                    //    sql = "CREATE PROCEDURE [dbo].[Insertsimpleitem]" +
                    //       " @id float," +
                    //       " @itemid  float," +
                    //       " @Barcode  [nvarchar](50) "+
                    //       " AS" +
                    //       " BEGIN" +
                    //       " insert into TblitemMastersimple (id,itemid,barcode)" +
                    //       " values (@id,@itemid,@barcode)" +
                    //       " END";
                    //    _Dbtask.ExecuteNonQuery(sql);

                    //    _Dbtask.ExecuteNonQuery("alter table tblitemmaster add Sid float");
                    //    _Dbtask.ExecuteNonQuery("alter table tblbatch add Sid float");
                    //}


                    //icon

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                          " SYSOBJECTS.NAME = 'tblicon' ");
                    if (Count == "0")
                    {
                        sql = "CREATE TABLE [dbo].[Tblicon]( " +
      "[xvalue] [float] NULL, " +
       "[yvalue] [float] NULL, " +
      "[icon] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
      " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE   PROCEDURE [dbo].[Inserticon] @xvalue float,@yvalue float, @icon [nvarchar](50) " +
          " AS BEGIN insert into Tblicon (xvalue,yvalue,icon) values " +
          "(@xvalue,@yvalue,@icon) END";
                        _Dbtask.ExecuteNonQuery(sql);
                        CommonClass._iconset.defaultvalues();

                    }
                 //   sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                 //" INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                 //" SYSOBJECTS.NAME = 'tblbillsett' AND SYSCOLUMNS.NAME = 'Emp'";
                 //   ttemp = _Dbtask.ExecuteScalar(sql);
                 //   if (ttemp == "0")
                 //   {
                 //       _Dbtask.ExecuteNonQuery("alter table tblbillsett add emp float");
                 //   }
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                  " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                  " SYSOBJECTS.NAME = 'Tblchqreceived' AND SYSCOLUMNS.NAME = 'Emp'";
                    ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table Tblchqreceived add emp float");
                    }
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                  " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                  " SYSOBJECTS.NAME = 'Tblchqreceived' AND SYSCOLUMNS.NAME = 'Agvno'";
                    ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table Tblchqreceived add Agvno nvarchar(50)");
                    }

                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                   " SYSOBJECTS.NAME = 'TblGENERALLEDGER'  AND SYSCOLUMNS.NAME = 'RecvdAmt'");
                    if (Count == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table TblGENERALLEDGER  add RecvdAmt decimal(18,5)");//decimal(18,5)
                    }




                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                   " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                   " SYSOBJECTS.NAME = 'tbltransactionreceipt' AND SYSCOLUMNS.NAME = 'Agvno'";
                    ttemp = _Dbtask.ExecuteScalar(sql);


                    //CreateColumnInTable("tblmnusettings", "EST", "decimal(18,5)", "0");


                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tbltransactionreceipt add Agvno nvarchar(50)");
                    }

                    /***For Special Cause Waranty and Print Footer and Services Disable****/
                    _Dbtask.ExecuteNonQuery("update tblmnusettings set status=-1 where menuid in(2022,2024,2026)");
                    _Dbtask.ExecuteNonQuery("update tblmnusettings set status=-1 where menuid in(102030)");
                    /**********************************/

                    CreateColumnInTable("tblbusinessissue", "warranty", "[nvarchar](50)", " ");
                    CreateColumnInTable("tblBUSINESSISSUE", "CashReceived", "[nvarchar](50)", " ");
                    Generalfunction.TempCompanyname = "DEMOCOMPANY";
                    Ds = _Dbtask.ExecuteQuery("select * from tblparamlist where paramname='RgDate'");
                    if (Ds.Tables[0].Rows.Count == 0)
                    {
                        /*For registration*/
                        _Paramlist.ParamName = "RgDate";
                        _Paramlist.Paramtype = "1";
                        _Paramlist.ParamValue = DateTime.Now.Date.ToString("dd-MM-yyyy");
                        _Paramlist.InsertParamlist();
                    }
                    Generalfunction.TempCompanyname = "";


                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                    " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                    " SYSOBJECTS.NAME = 'tblitemmaster' AND SYSCOLUMNS.NAME = 'Itemnote'";
                    ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table tblitemmaster add Itemnote nvarchar(50)");
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("SPrintRate") == false)
                    {
                        CommonClass._Paramlist.ParamName = "SPrintRate";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "Srate";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    /*F12 Edit*/
                    Count = _Dbtask.ExecuteScalar("select isnull(status,5) from tblmnusettings where menuid=173");
                    if (Count == "")
                    {
                        _Mnusettings.Menuid = "173";
                        _Mnusettings.MenuName = "SearcBarcodesales";
                        _Mnusettings.Parentid = "103";
                        _Mnusettings.Status = "-1";
                        _Mnusettings.InsertMnusettings();
                    }

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                   " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                   " SYSOBJECTS.NAME = 'Tblitemmaster' AND SYSCOLUMNS.NAME = 'Bunit'";
                    ttemp = _Dbtask.ExecuteScalar(sql);
                    if (ttemp == "0")
                    {
                        _Dbtask.ExecuteNonQuery("alter table Tblitemmaster add Bunit nvarchar(50)");
                    }
                  
                    /*Insert Psc to Base Unit*/
                    Ds=CommonClass._base.LoadUnit("");
                    if(Ds.Tables[0].Rows.Count==0)
                    {
                        CommonClass._base.Id = 1;
                        CommonClass._base.Name="Psc";
                        CommonClass._base.InserBasetUnit();
                    }

                    /*For wieght Mechine Add Column*/
                    CreateColumnInTable("tblitemmaster", "Usingmechine", "int", "0");

                    _Mnusettings.InsertMnusettingsIsnotexsting("175", "EnableprinterselectionSI", "0", "1");/*Printer Selection in Sales*/

                    CreateColumnInTable("TblCompanyMaster", "CusId", "nvarchar(50)", "''");/*Customer Id Add */
                    CreateColumnInTable("TblCompanyMaster", "CusArea", "nvarchar(50)", "''");/*Customer Area Add */

                    _Mnusettings.InsertMnusettingsIsnotexsting("176", "EnableCustomerId", "0", "1");

                    _Mnusettings.InsertMnusettingsIsnotexsting("177", "Enableregdetails", "0", "1");/*Enable Registration Details*/

                    _Mnusettings.InsertMnusettingsIsnotexsting("178", "EnableDelete", "0", "-1");/* enable permission delete transactn  */
                    _Mnusettings.InsertMnusettingsIsnotexsting("179", "Enablesalesedit", "0", "-1");/* enable sale edit  */

                    _Mnusettings.InsertMnusettingsIsnotexsting("180", "EnableEncriptQrcode", "0", "1");/* enable Encript QrCode */
                    _Mnusettings.InsertMnusettingsIsnotexsting("181", "Enablesecondprinter", "0", "-1");/* enable Second Printer*/


                    _Mnusettings.InsertMnusettingsIsnotexsting("193", "EnableSalesitemnote", "0", "-1");/* enable itemnote in Sales*/
                    CreateColumnInTable("tblissuedetails", "Itemnote2", "nvarchar(50)", "''");/*Sellers Name Add*/
                    
                    CreateColumnInTable("TblCompanyMaster", "Sellersname", "nvarchar(50)", "''");/*Sellers Name Add*/
                    CreateColumnInTable("TblCompanyMaster", "TRN", "nvarchar(50)", "''");/*TRN */

                    _Mnusettings.InsertMnusettingsIsnotexsting("194", "EnableSalesitemnote", "0", "-1");/* Not Tax Print Settings*/

                    CreateColumnInTable("TblBUSINESSISSUE", "Tmobile", "nvarchar(20)", "''");
                    CreateColumnInTable("TblBUSINESSISSUE", "Taddres", "nvarchar(100)", "''");
                    CreateColumnInTable("TblBUSINESSISSUE", "Tvat", "nvarchar(50)", "''");

                    CreateColumnInTable("TblTRANSACTIONRECEIPT", "Tmobile", "nvarchar(20)", "''");
                    CreateColumnInTable("TblTRANSACTIONRECEIPT", "Taddres", "nvarchar(100)", "''");
                    CreateColumnInTable("TblTRANSACTIONRECEIPT", "Tvat", "nvarchar(50)", "''");



                    CreateColumnInTable("Tblgeneralledger", "RPtaxperc", "Decimal(18,5)", "0");
                    CreateColumnInTable("Tblgeneralledger", "RPtaxamt", "Decimal(18,5)", "0");
                    
                    if (CommonClass._Paramlist.IsParamNameExist("R&Pprint") == false)
                    {
                        CommonClass._Paramlist.ParamName = "R&Pprint";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "0";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("AmtWords") == false)
                    {
                        CommonClass._Paramlist.ParamName = "AmtWords";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "1";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("codewidthSI") == false)
                    {
                        CommonClass._Paramlist.ParamName = "codewidthSI";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "46";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("BcodeH") == false)
                    {
                        CommonClass._Paramlist.ParamName = "BcodeH";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "30";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("BitemSize") == false)
                    {
                        CommonClass._Paramlist.ParamName = "BitemSize";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "10";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("BcompnySize") == false)
                    {
                        CommonClass._Paramlist.ParamName = "BcompnySize";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "8";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("Bratesize") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Bratesize";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "10";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    _Mnusettings.InsertMnusettingsIsnotexsting("195", "BcodeSrate", "0", "1");
                    _Mnusettings.InsertMnusettingsIsnotexsting("196", "langinbcode", "0", "-1");
                    _Mnusettings.InsertMnusettingsIsnotexsting("197", "itemcodeinbcod", "0", "-1");

                    if (CommonClass._Paramlist.IsParamNameExist("Bitemcodesize") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Bitemcodesize";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "10";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("Blangsize") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Blangsize";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "10";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    _Mnusettings.InsertMnusettingsIsnotexsting("198", "crlimitOn", "0", "-1");
                    CreateColumnInTable("TblBUSINESSISSUE", "vehiclenum", "nvarchar(50)", "''");
                    CreateColumnInTable("TblBUSINESSISSUE", "Mtrread", "nvarchar(50)", "''");
                    _Mnusettings.InsertMnusettingsIsnotexsting("199", "vehiclenum", "0", "-1");
                    _Mnusettings.InsertMnusettingsIsnotexsting("200", "Mtrread", "0", "-1");

                    if (CommonClass._Paramlist.IsParamNameExist("itemcodeprintsize") == false)
                    {
                        CommonClass._Paramlist.ParamName = "itemcodeprintsize";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "10";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    _Mnusettings.InsertMnusettingsIsnotexsting("201", "EmpSale", "0", "-1");
                    CreateColumnInTable("TblBUSINESSISSUE", "Twopayment", "nvarchar(50)", "''");
                    CreateColumnInTable("TblBUSINESSISSUE", "twopayAmt", "Decimal(18,5)", "0");

                    if (CommonClass._Paramlist.IsParamNameExist("Iconsize") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Iconsize";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "60";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("Iconstart") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Iconstart";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "50";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("Iconend") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Iconend";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "120";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("bcodeprefix") == false)
                    {
                        CommonClass._Paramlist.ParamName = "bcodeprefix";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("bcodedigit") == false)
                    {
                        CommonClass._Paramlist.ParamName = "bcodedigit";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    //follwp
                    Count = _Dbtask.ExecuteScalar("SELECT count(*) AS [Column Exists] FROM SYSOBJECTS   INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                          " SYSOBJECTS.NAME = 'tblfollowup' ");
                    if (Count == "0")
                    {
                        sql = "CREATE TABLE [dbo].[tblfollowup]( " +
                         "[cusid] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                         "[cusname] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                         "[cusmob] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
                         "[cusaddress] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ," +
                         "[custype] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
                         " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE PROCEDURE [dbo].[Insertfollowup] " +
                       " @cusid [nvarchar](200) ," +
                       " @cusname [nvarchar](50), " +
                       " @cusmob [nvarchar](50) ," +
                       " @cusaddress [nvarchar](200)," +
                       " @custype [nvarchar](200)" +
                        " AS BEGIN insert into tblfollowup (cusid,cusname,cusmob,cusaddress,custype) values " +
                        "(@cusid,@cusname,@cusmob,@cusaddress,@custype) END";
                        _Dbtask.ExecuteNonQuery(sql);
                        

                    }
                    //feedback
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                               " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                               " SYSOBJECTS.NAME = 'Tblfeedback' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        sql = "CREATE TABLE [dbo].[Tblfeedback](" +
                      "[fid] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                      "[fcustomer] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                      "[fcalling] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                      "[ffeedback] [nvarchar](800) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
                   ") ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE   PROCEDURE [dbo].[insertfeedback] "+
                        " @fid [nvarchar](50) ," +
                        " @fcustomer [nvarchar](200) ," +
                        " @fcalling  [nvarchar](100) ," +
                        " @ffeedback  [nvarchar](800) " + 
                        " AS BEGIN insert into Tblfeedback (fid,fcustomer,fcalling,ffeedback) values " +
                        "(@fid,@fcustomer,@fcalling,@ffeedback)  END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("taxpercset") == false)
                    {
                        CommonClass._Paramlist.ParamName = "taxpercset";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "15";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    _Mnusettings.InsertMnusettingsIsnotexsting("202", "itemlistview", "0", "-1");
                    _Mnusettings.InsertMnusettingsIsnotexsting("203", "dtexmanbcode", "0", "-1");
                    _Mnusettings.InsertMnusettingsIsnotexsting("204", "productTop", "0", "-1");
                    _Mnusettings.InsertMnusettingsIsnotexsting("205", "headervisibl", "0", "1");

                    _Mnusettings.InsertMnusettingsIsnotexsting("206", "saleitemroundoff", "0", "-1");


                    CreateColumnInTable("Tblaccountledger", "customercode", "nvarchar(250)", "''");
                    CreateColumnInTable("Tblbatch", "Lastrate", "Decimal(18,5)", "0");

                    if (CommonClass._Paramlist.IsParamNameExist("LR<SR") == false)
                    {
                        CommonClass._Paramlist.ParamName = "LR<SR";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "Allow";
                        CommonClass._Paramlist.InsertParamlist();
                    }


                    if (CommonClass._Paramlist.IsParamNameExist("MaxofSI") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MaxofSI";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='SI' and ledcodeCr='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("MaxofSO") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MaxofSO";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='SO' and ledcodeCr='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("MaxofSQ") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MaxofSQ";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='SQ' and ledcodeCr='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("MaxofSR") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MaxofSR";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(ReptCode), 0) } AS Expr1  FROM TbltransactionReceipt where RecptType='SR' and LedcodeDr='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("MaxofPI") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MaxofPI";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(ReptCode), 0) } AS Expr1  FROM TbltransactionReceipt where RecptType='PI' and LedcodeDr='3'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("MaxofPO") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MaxofPO";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(ReptCode), 0) } AS Expr1  FROM TbltransactionReceipt where RecptType='PO' and LedcodeDr='3'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("MaxofPR") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MaxofPR";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='PR' and ledcodeCr='3'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("MaxofSIwh") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MaxofSIwh";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='SI' and ledcodeCr!='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }


                    if (CommonClass._Paramlist.IsParamNameExist("defSaleDiscAMT") == false)
                    {
                        CommonClass._Paramlist.ParamName = "defSaleDiscAMT";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "0";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    _Mnusettings.InsertMnusettingsIsnotexsting("207", "prateinitemlist", "0", "1");
                    _Mnusettings.InsertMnusettingsIsnotexsting("208", "weignRate", "0", "1");
                    _Mnusettings.InsertMnusettingsIsnotexsting("209", "weignQTY", "0", "1");

                    if (CommonClass._Paramlist.IsParamNameExist("weignbcodestrt") == false)
                    {
                        CommonClass._Paramlist.ParamName = "weignbcodestrt";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "0";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("weignbcodeend") == false)
                    {
                        CommonClass._Paramlist.ParamName = "weignbcodeend";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "0";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("weignratestrt") == false)
                    {
                        CommonClass._Paramlist.ParamName = "weignratestrt";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "0";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("weignrateend") == false)
                    {
                        CommonClass._Paramlist.ParamName = "weignrateend";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "0";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("weignQtystrt") == false)
                    {
                        CommonClass._Paramlist.ParamName = "weignQtystrt";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "0";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("weignQtyend") == false)
                    {
                        CommonClass._Paramlist.ParamName = "weignQtyend";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "0";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("weignQtyDIVI") == false)
                    {
                        CommonClass._Paramlist.ParamName = "weignQtyDIVI";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "1000";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("weignRateDIVI") == false)
                    {
                        CommonClass._Paramlist.ParamName = "weignRateDIVI";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "1000";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    //TBLOTHERPRINT
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                               " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                               " SYSOBJECTS.NAME = 'TblOtherprintsets' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        sql = "CREATE TABLE [dbo].[TblOtherprintsets](" +
                                              "[OPname] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                                              "[OPstatus] int  " +

                                           ") ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE   PROCEDURE [dbo].[insertOtherprintsets] " +
                        " @OPname [nvarchar](500) ," +
                        " @OPstatus  int " +

                        " AS BEGIN insert into TblOtherprintsets (OPname,OPstatus) values " +
                        "(@OPname,@OPstatus)  END";
                        _Dbtask.ExecuteNonQuery(sql);

                        CommonClass._otherPrint.defaultvalsetotherprint();


                    }

                    _Mnusettings.InsertMnusettingsIsnotexsting("215", "automaticmodeSET", "0", "1");


                    //_Mnusettings.InsertMnusettingsIsnotexsting("210", "automaticmodeSET", "0", "1");

                    _Mnusettings.InsertMnusettingsIsnotexsting("211", "RPdetails", "0", "-1");

                    CreateColumnInTable("TblCompanyMaster", "District", "nvarchar(250)", "''");
                    CreateColumnInTable("TblCompanyMaster", "countryname", "nvarchar(500)", "''");

                    CreateColumnInTable("TblCompanyMaster", "validityduration", "nvarchar(500)", "''");
                    CreateColumnInTable("TblCompanyMaster", "nickname", "nvarchar(500)", "''");



                    CreateColumnInTable("Tblaccountledger", "cityy", "nvarchar(500)", "''");
                    CreateColumnInTable("Tblaccountledger", "Lcountryname", "nvarchar(500)", "''");
                    CreateColumnInTable("Tblaccountledger", "postcode", "nvarchar(500)", "''");
                    CreateColumnInTable("Tblaccountledger", "LDistrict", "nvarchar(500)", "''");

                    if (CommonClass._Paramlist.IsParamNameExist("THheadfnt") == false)
                    {
                        CommonClass._Paramlist.ParamName = "THheadfnt";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "15";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("THinhomefnt") == false)
                    {
                        CommonClass._Paramlist.ParamName = "THinhomefnt";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "12";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("THtaxfnt") == false)
                    {
                        CommonClass._Paramlist.ParamName = "THtaxfnt";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "10";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("THaddphfnt") == false)
                    {
                        CommonClass._Paramlist.ParamName = "THaddphfnt";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "10";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("printstyletype") == false)
                    {
                        CommonClass._Paramlist.ParamName = "printstyletype";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "1";
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    Count = _Dbtask.ExecuteScalar("select * from tblparamlist where paramname= 'BCodeCreatePRFX'");
                    if (Count == "")
                    {
                        CommonClass._Paramlist.ParamName = "BCodeCreatePRFX";/*For Topof Barcode Print*/
                        CommonClass._Paramlist.Paramtype = "1";
                        CommonClass._Paramlist.ParamValue = "";
                        CommonClass._Paramlist.InsertParamlist();
                    }


                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                               " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                               " SYSOBJECTS.NAME = 'TblAMCdetails' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        sql = "CREATE TABLE [dbo].[TblAMCdetails](" +
                      "[Amccdkey] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                      "[Amcproductid] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                      "[Amcregnumber] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL  " +
                      
                   ") ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE   PROCEDURE [dbo].[insertAMCdetails] " +
                        " @Amccdkey [nvarchar](500) ," +
                        " @Amcproductid [nvarchar](500) ," +
                        " @Amcregnumber  [nvarchar](500) " +

                        " AS BEGIN insert into TblAMCdetails (Amccdkey,Amcproductid,Amcregnumber) values " +
                        "(@Amccdkey,@Amcproductid,@Amcregnumber)  END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }





                    CreateColumnInTable("TblBUSINESSISSUE", "LBLaccnt", "nvarchar(500)", "''");
                    CreateColumnInTable("Tbltransactionreceipt", "LBLaccnt", "nvarchar(500)", "''");

                    //minvnovall

                    if (CommonClass._Paramlist.IsParamNameExist("MINofSI") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MINofSI";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='SI' and ledcodeCr='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO));
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("MINofSO") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MINofSO";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='SO' and ledcodeCr='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO));
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    if (CommonClass._Paramlist.IsParamNameExist("MINofSQ") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MINofSQ";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='SQ' and ledcodeCr='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO));
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("MINofSR") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MINofSR";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MIN(ReptCode), 0) } AS Expr1  FROM TbltransactionReceipt where RecptType='SR' and LedcodeDr='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO));
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }







                    if (CommonClass._Paramlist.IsParamNameExist("MINofPI") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MINofPI";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MIN(ReptCode), 0) } AS Expr1  FROM TbltransactionReceipt where RecptType='PI' and LedcodeDr='3'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO));
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("MINofPO") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MINofPO";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MIN(ReptCode), 0) } AS Expr1  FROM TbltransactionReceipt where RecptType='PO' and LedcodeDr='3'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO));
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }



                    if (CommonClass._Paramlist.IsParamNameExist("MINofPR") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MINofPR";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='PR' and ledcodeCr='3'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO));
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("MINofSIwh") == false)
                    {

                        CommonClass._Paramlist.ParamName = "MINofSIwh";
                        string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='SI' and ledcodeCr!='2'");
                        MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO));
                        if (MAXVNO == "" || MAXVNO == "0")
                        {
                            MAXVNO = "1";
                        }
                        CommonClass._Paramlist.Paramtype = "";
                        CommonClass._Paramlist.ParamValue = MAXVNO;
                        CommonClass._Paramlist.InsertParamlist();
                    }
                    //minvnovall

                    _Mnusettings.InsertMnusettingsIsnotexsting("212", "Enablenickname", "0", "-1");/* enable Second Printer*/
                    _Mnusettings.InsertMnusettingsIsnotexsting("213", "Enablevalidityduration", "0", "-1");/* enable Second Printer*/


                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                             " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                             " SYSOBJECTS.NAME = 'TblMostMoving' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        sql = "CREATE TABLE [dbo].[TblMostMoving](" +
                      "[MMbcode] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                      "[MMpcode] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                      "[MMname] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL  " +

                   ") ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "CREATE   PROCEDURE [dbo].[insertMostMoving] " +
                        " @MMbcode [nvarchar](500) ," +
                        " @MMpcode [nvarchar](500) ," +
                        " @MMname  [nvarchar](500) " +


                        " AS BEGIN insert into TblMostMoving (MMbcode,MMpcode,MMname) values " +
                        "(@MMbcode,@MMpcode,@MMname)  END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }


                    _Mnusettings.InsertMnusettingsIsnotexsting("214", "EnableMostmove", "0", "-1");


                    _Mnusettings.InsertMnusettingsIsnotexsting("216", "bcoderaterounding", "0", "-1");


                    _Mnusettings.InsertMnusettingsIsnotexsting("217", "userwisedisc", "0", "-1");
                    if (CommonClass._Paramlist.IsParamNameExist("userdiscvalue") == false)
                    {
                        CommonClass._Paramlist.ParamName = "userdiscvalue";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "0";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    _Mnusettings.InsertMnusettingsIsnotexsting("218", "purchprintwhile", "0", "-1");

                    CreateColumnInTable("TblBATCH", "baseU", "nvarchar(500)", "''");


                    CreateColumnInTable("tblgeneralledger", "Agvno", "nvarchar(500)", "''");

                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                               " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                               " SYSOBJECTS.NAME = 'tblpurchasebillsett' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {

                        sql = "CREATE TABLE [dbo].[tblpurchasebillsett]( " +
                            " [vno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                            " [vtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                            " [Ledcode] [float] NULL, " +
                            " [Dbamt] [decimal](18, 5) NULL, " +
                            " [Cramt] [decimal](18, 5) NULL," +
                            " [Agvno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                            " [Dt] [datetime] NULL " +
                            " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "create PROCEDURE [dbo].[Insertpurchasebillsett] @vno nvarchar (50), @vtype nvarchar (50), @ledcode float, " +
                        " @Dbamt decimal(18,5),@cramt decimal(18,5),@agvno nvarchar(50),@Dt datetime " +
                        " AS BEGIN INSERT INTO tblpurchasebillsett(vno,vtype,ledcode,dbamt,cramt,agvno,dt)  " +
                        " VALUES(@vno,@vtype,@ledcode,@dbamt,@cramt,@agvno,@Dt) END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }



                    //returbillset
                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                              " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                              " SYSOBJECTS.NAME = 'tblSRbillsett' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {

                        sql = "CREATE TABLE [dbo].[tblSRbillsett]( " +
                            " [vno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                            " [vtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                            " [Ledcode] [float] NULL, " +
                            " [Dbamt] [decimal](18, 5) NULL, " +
                            " [Cramt] [decimal](18, 5) NULL," +
                            " [Agvno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                            " [Dt] [datetime] NULL " +
                            " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "create PROCEDURE [dbo].[InsertSRbillsett] @vno nvarchar (50), @vtype nvarchar (50), @ledcode float, " +
                        " @Dbamt decimal(18,5),@cramt decimal(18,5),@agvno nvarchar(50),@dt datetime " +
                        " AS BEGIN INSERT INTO tblSRbillsett(vno,vtype,ledcode,dbamt,cramt,agvno,Dt)  " +
                        " VALUES(@vno,@vtype,@ledcode,@dbamt,@cramt,@agvno,@dt) END";
                        _Dbtask.ExecuteNonQuery(sql);


                        //PR
                        sql = "CREATE TABLE [dbo].[tblPRbillsett]( " +
                           " [vno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                           " [vtype] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                           " [Ledcode] [float] NULL, " +
                           " [Dbamt] [decimal](18, 5) NULL, " +
                           " [Cramt] [decimal](18, 5) NULL," +
                           " [Agvno] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
                           " [Dt] [datetime] NULL " +
                           " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);

                        sql = "create PROCEDURE [dbo].[InsertPRbillsett] @vno nvarchar (50), @vtype nvarchar (50), @ledcode float, " +
                        " @Dbamt decimal(18,5),@cramt decimal(18,5),@agvno nvarchar(50),@dt datetime " +
                        " AS BEGIN INSERT INTO tblPRbillsett(vno,vtype,ledcode,dbamt,cramt,agvno,Dt)  " +
                        " VALUES(@vno,@vtype,@ledcode,@dbamt,@cramt,@agvno,@dt) END";
                        _Dbtask.ExecuteNonQuery(sql);


                    }



                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                            " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                            " SYSOBJECTS.NAME = 'TblTransferDetails' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {

                        sql = "CREATE TABLE [dbo].[TblTransferDetails](" +
                         "	[Tcode] [float] NULL," +
                         "	[Slno] [int] NULL," +
                         "	[Pcode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                         "	[ItemDesc] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                         "	[UnitId] [int] NULL," +
                         "	[BatchId] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                         "	[MultiRateId] [int] NULL," +
                         "	[CF] [decimal](18, 5) NULL," +
                         "	[Qty] [decimal](18, 5) NULL," +
                         "	[Rate] [decimal](18, 5) NULL," +
                         "	[Comment] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                         "	[ShelfCode] [int] NULL," +
                         "	[DCode] [int] NULL," +
                          "	[SupCode] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);


                        sql = "CREATE PROCEDURE [dbo].[InsertTransferDetails]" +
" @TCode float," +
" @Slno int," +
" @Pcode nvarchar(50)," +
" @ItemDesc nvarchar(50)," +
" @UnitId int," +
" @BatchId nvarchar(500)," +
" @MultiRateId int," +
" @CF decimal(18, 5)," +
" @Qty decimal(18, 5)," +
" @Rate decimal(18, 5)," +
" @Comment nvarchar(500)," +
" @ShelfCode int," +
" @Dcode int," +
" @Supcode nvarchar(50)" +
" AS" +
" BEGIN" +
" INSERT INTO TblTransferdetails(Tcode,Slno,Pcode,ItemDesc,UnitId,Batchid,MultiRateId,CF,Qty,Rate,Comment,ShelfCode,Dcode,Supcode)" +
" VALUES(@Tcode,@Slno,@Pcode,@ItemDesc,@UnitId,@Batchid,@MultiRateId,@CF,@Qty,@Rate,@Comment,@ShelfCode,@Dcode,@Supcode)" +
" END";

                        _Dbtask.ExecuteNonQuery(sql);



                    }


                    _Mnusettings.InsertMnusettingsIsnotexsting("219", "Stockshow", "0", "-1");

                  _Mnusettings.InsertMnusettingsIsnotexsting("220", "stockbottom", "0", "-1");

                  _Mnusettings.InsertMnusettingsIsnotexsting("221", "automodepurchase", "0", "-1");

                  CreateColumnInTable("Tblissuedetails", "billtot", "Decimal(18,5)", "0");
                  CreateColumnInTable("Tblissuedetails", "billtime", "nvarchar(500)", "''");
                  CreateColumnInTable("Tblreceiptdetails", "billtot", "Decimal(18,5)", "0");

                  if (CommonClass._Paramlist.IsParamNameExist("validatnfrom") == false)
                  {
                      CommonClass._Paramlist.ParamName = "validatnfrom";
                      CommonClass._Paramlist.Paramtype = "0";
                      CommonClass._Paramlist.ParamValue = " ";
                      CommonClass._Paramlist.InsertParamlist();
                  }
                  if (CommonClass._Paramlist.IsParamNameExist("validatnTO") == false)
                  {
                      CommonClass._Paramlist.ParamName = "validatnTO";
                      CommonClass._Paramlist.Paramtype = "0";
                      CommonClass._Paramlist.ParamValue = " ";
                      CommonClass._Paramlist.InsertParamlist();
                  }


                  _Mnusettings.InsertMnusettingsIsnotexsting("222", "customerwisetax", "0", "-1");

                  _Mnusettings.InsertMnusettingsIsnotexsting("223", "bcodeBold", "0", "1");

                  _Dbtask.ExecuteNonQuery("ALTER TABLE tblcompanymaster ALTER COLUMN cname nvarchar (500)  COLLATE SQL_Latin1_General_CP1_CI_AS ");
                  _Dbtask.ExecuteNonQuery("ALTER TABLE tblcompanymaster ALTER COLUMN Nameinhome nvarchar (500)  COLLATE SQL_Latin1_General_CP1_CI_AS ");


                  _Mnusettings.InsertMnusettingsIsnotexsting("225", "datetwoline", "0", "-1");


                  if (CommonClass._Paramlist.IsParamNameExist("QRwidth") == false)
                  {
                      CommonClass._Paramlist.ParamName = "QRwidth";
                      CommonClass._Paramlist.Paramtype = "0";
                      CommonClass._Paramlist.ParamValue = "140";
                      CommonClass._Paramlist.InsertParamlist();
                  }
                  if (CommonClass._Paramlist.IsParamNameExist("QRheight") == false)
                  {
                      CommonClass._Paramlist.ParamName = "QRheight";
                      CommonClass._Paramlist.Paramtype = "0";
                      CommonClass._Paramlist.ParamValue = "120";
                      CommonClass._Paramlist.InsertParamlist();
                  }


                  if (CommonClass._Paramlist.IsParamNameExist("batchwidthinpurchase") == false)
                  {
                      CommonClass._Paramlist.ParamName = "batchwidthinpurchase";
                      CommonClass._Paramlist.Paramtype = "0";
                      CommonClass._Paramlist.ParamValue = "116";
                      CommonClass._Paramlist.InsertParamlist();
                  }


                  if (CommonClass._Paramlist.IsParamNameExist("MaxofPOS") == false)
                  {

                      CommonClass._Paramlist.ParamName = "MaxofPOS";
                      string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='POS' and ledcodeCr='2'");
                      MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO) + 1);
                      if (MAXVNO == "" || MAXVNO == "0")
                      {
                          MAXVNO = "1";
                      }
                      CommonClass._Paramlist.Paramtype = "";
                      CommonClass._Paramlist.ParamValue = MAXVNO;
                      CommonClass._Paramlist.InsertParamlist();
                  }

                  if (CommonClass._Paramlist.IsParamNameExist("MINofPOS") == false)
                  {

                      CommonClass._Paramlist.ParamName = "MINofPOS";
                      string MAXVNO = _Dbtask.ExecuteScalar("SELECT { fn IFNULL(MIN(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='POS' and ledcodeCr='2'");
                      MAXVNO = _Dbtask.znllString(Convert.ToInt32(MAXVNO));
                      if (MAXVNO == "" || MAXVNO == "0")
                      {
                          MAXVNO = "1";
                      }
                      CommonClass._Paramlist.Paramtype = "";
                      CommonClass._Paramlist.ParamValue = MAXVNO;
                      CommonClass._Paramlist.InsertParamlist();
                   }



                    CreateColumnInTable("TblItemCategory", "Showinsummery", "nvarchar(50)", "'No'");
                    CreateColumnInTable("tblbatch", "prateperc", "Decimal(18,5)", "0");
                    CreateColumnInTable("TBLBATCH", "ONtable", "nvarchar(50)", "'No'");
                    _Mnusettings.InsertMnusettingsIsnotexsting("226", "ctrlQdatewise", "0", "-1");


                    if (CommonClass._Paramlist.IsParamNameExist("Cashsymbol") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Cashsymbol";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "";
                        CommonClass._Paramlist.InsertParamlist();
                    }



                    CreateColumnInTable("TblINVENTORY", "Vtype", "nvarchar(50)", "''");
                    CreateColumnInTable("Tblbusinessissue", "vehiclename", "nvarchar(500)", "''");





                    sql = "SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
                                " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
                                " SYSOBJECTS.NAME = 'Tblrack' ";
                    ttemp = _Dbtask.ExecuteScalar(sql);

                    if (ttemp == "0")
                    {
                        sql = "CREATE TABLE [dbo].[Tblrack](" +
                      "[Rid] [float] NULL, " +
                      "[Rack] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL " +
                         " ) ON [PRIMARY]";
                        _Dbtask.ExecuteNonQuery(sql);


                        sql = "CREATE   PROCEDURE [dbo].[InsertRack] @Rid float, @Rack [nvarchar](500) " +
                        " AS BEGIN insert into Tblrack (Rid,Rack) values " +
                        "(@Rid,@Rack) END";
                        _Dbtask.ExecuteNonQuery(sql);
                    }




                    CreateColumnInTable("Tblitemmaster", "rackname", "nvarchar(500)", "''");


                    if (CommonClass._Paramlist.IsParamNameExist("Itemwidthinsale") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Itemwidthinsale";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "150";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("seclangwidthinsale") == false)
                    {
                        CommonClass._Paramlist.ParamName = "seclangwidthinsale";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "150";
                        CommonClass._Paramlist.InsertParamlist();
                    }

                    if (CommonClass._Paramlist.IsParamNameExist("Batchwidthsale") == false)
                    {
                        CommonClass._Paramlist.ParamName = "Batchwidthsale";
                        CommonClass._Paramlist.Paramtype = "0";
                        CommonClass._Paramlist.ParamValue = "200";
                        CommonClass._Paramlist.InsertParamlist();
                    }


                    CreateColumnInTable("Tblbusinessissue", "POnum", "nvarchar(500)", "''");

                    CreateColumnInTable("Tblbusinessissue", "Deliverynote", "nvarchar(500)", "''");


                    CreateColumnInTable("Tblbusinessissue", "Attention", "nvarchar(500)", "''");

                    CreateColumnInTable("Tblbusinessissue", "MRFPRnum", "nvarchar(500)", "''");
                    CreateColumnInTable("Tblbusinessissue", "Projcts", "nvarchar(500)", "''");


                    _Mnusettings.InsertMnusettingsIsnotexsting("227", "prefixinSR", "0", "-1");


                    _Mnusettings.InsertMnusettingsIsnotexsting("229", "RPoldbalance", "0", "-1");



                    CreateColumnInTable("Tblbusinessissue", "Due", "nvarchar(500)", "''");



                    CreateColumnInTable("tblbillsett", "Due", "nvarchar(500)", "''");
                    //CreateColumnInTable("Tblbusinessissue", "Due", "nvarchar(500)", "''");
                    //CreateColumnInTable("Tblbusinessissue", "Due", "nvarchar(500)", "''");
                    //CreateColumnInTable("Tblbusinessissue", "Due", "nvarchar(500)", "''");




                    RefreshProcedure();
                    Dateformatsett();
                    RefreshOnFunctions();

                    //CARD
                    rfrshcard();


                }
            }
            catch
            {
            }
        }
        public void rfrshcard()
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblbusinessissue where ledcodedr='24' and issuetype='si' ");
        if (Ds.Tables[0].Rows.Count > 0)
            {
                _Dbtask.ExecuteNonQuery("update tblbusinessissue set ledcodedr='28' where issuetype='si' and ledcodedr='24'");

                _Dbtask.ExecuteNonQuery("update tblgeneralledger set ledcode='28' where vtype='si' and ledcode='24'");
        
        }
       
        DataSet dsr;
        dsr = _Dbtask.ExecuteQuery("select * from tbltransactionreceipt where ledcodecr='24' and recpttype='sr'");
        if (dsr.Tables[0].Rows.Count > 0)
        {
            _Dbtask.ExecuteNonQuery("update tbltransactionreceipt set ledcodecr='28' where recpttype='sr' and ledcodecr='24'");
            
            _Dbtask.ExecuteNonQuery("update tblgeneralledger set ledcode='28' where vtype='sr' and ledcode='24'");
        }


        }
        //public void CreateColumnInTable(string TableName, string ColName, string DataType, string InitialValue)
        //{
        //    sql = " SELECT count(*) AS [Column Exists] FROM SYSOBJECTS  " +
        //          " INNER JOIN SYSCOLUMNS ON SYSOBJECTS.ID = SYSCOLUMNS.ID WHERE " +
        //          " SYSOBJECTS.NAME = '" + TableName + "' AND SYSCOLUMNS.NAME = '" + ColName + "'";
        //    string ttemp = _Dbtask.ExecuteScalar(sql);
        //    if (ttemp == "0")
        //    {
        //        _Dbtask.ExecuteNonQuery("alter table " + TableName + " add " + ColName + " " + DataType);
        //        _Dbtask.ExecuteNonQuery("Update  " + TableName + " Set " + ColName + " = " + InitialValue);
        //    }
        //}
       

        public bool NextgRegistration()
        {
            CommonClass._Reg.Checkisregistred();
            string temp;
            Generalfunction.TempCompanyname = "DEMOCOMPANY";
            CommonClass.temp = _Dbtask.ExecuteScalar("SELECT paramvalue FROM TBLPARAMLIST where paramname='RgDate'");
            Generalfunction.TempCompanyname = "";

            temp = _Dbtask.ExecuteScalar("select count(*)+ (select count (*) from tbltransactionreceipt)from tblbusinessissue ");
            /**Transaction Base******/
            //if (Convert.ToDouble(temp) > 200 && Clsregistration.IsRegistred == false)
            //{
            //    MessageBox.Show("Trail Expired", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //Application.Exit();
            //    return true;
            //}
            /*********Day Base***********/
            //CommonClass.temp = (DateTime.Now.Date - Convert.ToDateTime(CommonClass.temp)).TotalDays.ToString();
            //if (Convert.ToDouble(CommonClass.temp) > 90 && Clsregistration.IsRegistred == false)
            //{
            //    MessageBox.Show("Trail Expired", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Application.Exit();
            //}
            CommonClass.temp = (DateTime.Now.Date - _Dbtask.ZnullDatetime(CommonClass.temp)).TotalDays.ToString();
            if (Convert.ToDouble(CommonClass.temp) > 30 && Clsregistration.IsRegistred == false)
            {
                MessageBox.Show("Trail Expired", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Trail Expired", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Generalfunction.BlnLogin = false;
                Application.Exit();
                //return true;
            }
            _Gen.FunotificationTRNandVat();
            return true;
        }

        public void CloseGriddetail(DataGridView Grid,Form Frm)
        {
            try
            {
                if (Grid.Rows.Count > 2)
                {
                    DialogResult Result = MessageBox.Show("Close Invoice", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result.ToString() == "Yes")
                    {
                        Frm.Close();
                    }
                }
                else
                {
                    Frm.Close();
                }
            }
            catch
            {
            }
        }

        public string stringLoadIn(DataSet Dss,string Codein,string Showfiled)
        {
            Codein = "";
            for (int i = 0; i < Dss.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    Codein = Dss.Tables[0].Rows[i][Showfiled].ToString();
                }
                else
                {
                    Codein =Codein+ "," + Dss.Tables[0].Rows[i][Showfiled].ToString();
                }
            }
            return Codein;
        }

      

        public string ShowSingleWantField(string TableName,string Name,string Gid,string GidValue)
        {
            string Temp = _Dbtask.ExecuteScalar("select " + Name + " from " + TableName + " where " + Gid + "=" + GidValue + "");
            return Temp;
        }


        public void SetVno(string Txt)
        {
            vno = "";
            pvno = "";
            for (int i = 0; i < Txt.Length; i++)
            {
                if (char.IsDigit(Txt[i]))
                {
                   vno += Txt[i].ToString();
                }
                else
                {
                pvno += Txt[i].ToString();
                }
             }
        }
        public string Decconvertion(string temp)
        {
            if (temp == "1")
            {
                temp = "0.0";
            }
            if (temp == "2")
            {
                temp = "0.00";
            }
            if (temp == "3")
            {
                temp = "0.000";
            }
            if (temp == "4")
            {
                temp = "0.0000";
            }
            if (temp == "5")
            {
                temp = "0.00000";
            }
            return temp;
        }
        public string VtypeDescription(string vtype)
        {
            if (vtype == "R")
            {
                vtype = "Receipt";
            }
            if (vtype == "P")
            {
                vtype = "Payment";
            }
            if (vtype == "PI")
            {
                vtype = "Purchase";
            }
           
            if (vtype == "PI")
            {
                vtype = "Purchase";
            }
            if (vtype == "OS")
            {
                vtype = "Opening Stock";
            }
            if (vtype == "Mr")
            {
                vtype = "Meterial Receipt";
            }
            if (vtype == "SR")
            {
                vtype = "Sales return";
            }
            if (vtype == "Dnr")
            {
                vtype = "Delivery note return";
            }

            if (vtype == "SI")
            {
                vtype = "Sales";
            }
            if (vtype == "Dn")
            {
                vtype = "Delivery note";
            }
            if (vtype == "PR")
            {
                vtype = "Purchase return";
            }
            if (vtype == "SO")
            {
                vtype = "Sales Order";
            }
            if (vtype == "PO")
            {
                vtype = "Purchase Order";
            }
             if (vtype == "JNR")
            {
                vtype = "Journel Receipt";
            }
            if(vtype=="JNP")
            {
                vtype="Journel payment";
            }
            if(vtype=="DBN")
            {
                vtype="Debit Note";
            }
            if(vtype=="CRN")
            {
                vtype="Credit Note";
            }
            if (vtype == "DE")
            {
                vtype = "Daily Expence";
            }
            return vtype;
        }

        public double IsitBarcodeorNot(string bcode)
            {
            double Isit = 0;
            if (bcode.Length >= 13 || bcode.Length >= 8)
            {
                if (_Dbtask.znlldoubletoobject(bcode) >= 10000000)
                {
                    Isit = 0;
                }
            }
            else
            {
                if (bcode.Length <= 8 && _Dbtask.znllString( bcode) != "")
                {
                    Isit = _Dbtask.znlldoubletoobject(bcode);
                }
            }
            return Isit;

        }



    }
}
