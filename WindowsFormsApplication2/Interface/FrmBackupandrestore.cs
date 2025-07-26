using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class FrmBackupandrestore : Form
    {
        public FrmBackupandrestore()
        {
            InitializeComponent();
        }
        DBTask _Dbtask = new DBTask();
        DataSet Ds;
        Generalfunction _genf = new Generalfunction();
        string Move;
        private void button1_Click(object sender, EventArgs e)
        {
            //MDIParent1 _Mdi1 = new MDIParent1();
            //_Mdi1.Restore();
            Restore();
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                //CommonClass._Language.PanelBasedConversion(panel1);
                //CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.GridHeaderConversion(gridmain);
            }
        }
        private void cmdbackup_Click(object sender, EventArgs e)
        {
            //MDIParent1 _Mdi1 = new MDIParent1();
            //_Mdi1.Backup();
            Backup();
        }

        private void FrmBackupandrestore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
        public void Restore()
        {
            CommonClass._commenevent.WaitCursor(this);
            string _DataBase = _Dbtask.currentcompany();

            Generalfunction.TempCompanyname = "master";
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Qplex Backup File";
            theDialog.Filter = "Qplex Back file|*.Bak";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
               // lblprogress.Visible = true;
                //lblprogress.Text = "Restore Progress wait.......";
                string Filepath = theDialog.FileName;
                // Generalfunction.TempCompanyname = "master";
                // var onlyFileName = System.IO.Path.GetFileName(theDialog.FileName);
                // _Dbtask.ExecuteNonQuery("RESTORE DATABASE ["+_DataBase+"] FROM  DISK = N'"+Filepath+"' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10");
                //string Move = theDialog.SafeFileName.Replace(".Bak"," ");
                Move = theDialog.SafeFileName;
                Move = Move.Substring(0, Move.Length - 4);

                //_Dbtask.ExecuteNonQuery("use master");
                string Applicationfilepath = Application.ExecutablePath.ToString();
                Applicationfilepath = Applicationfilepath.Substring(0, Application.ExecutablePath.Length - 7);

                Applicationfilepath = Applicationfilepath + "Backups\\";
                Applicationfilepath = Applicationfilepath + Move + ".Bak";
                // File.Move(Filepath, Applicationfilepath);

                string CurrentDbpath = _Dbtask.ExecuteScalar("SELECT  physical_name AS current_file_location FROM sys.master_files  where name='" + _DataBase + "'");
                string CurrentDbpathOrg = _Dbtask.ExecuteScalar("SELECT  physical_name AS current_file_location FROM sys.master_files  where name='" + _DataBase + "'");
                int dnamelength = _DataBase.Length + 9;
                CurrentDbpath = CurrentDbpath.Substring(0, CurrentDbpath.Length - dnamelength);
                // string Applicationfilepath = Application.ExecutablePath.ToString();
                //File.Move(Filepath, Applicationfilepath);
                // CurrentDbpath = CurrentDbpath.Substring(0, CurrentDbpath.Length-1 );
                //Applicationfilepath = Applicationfilepath.Substring(0, Application.ExecutablePath.Length - 7);
                Applicationfilepath = CurrentDbpath + "Backup\\";

                //Applicationfilepath = Applicationfilepath + "Backups\\";
                Applicationfilepath = Applicationfilepath + Move + ".Bak";


                _Dbtask.ExecuteNonQuery("ALTER DATABASE [" + _DataBase + "] SET Single_User WITH Rollback Immediate");
                File.Exists(Applicationfilepath);
                {
                    File.Delete(Applicationfilepath);
                }
                File.Copy(Filepath, Applicationfilepath);
                //File.Move(Filepath, Applicationfilepath);
                Ds = _Dbtask.ExecuteQuery("RESTORE FILELISTONLY from disk= '" + Applicationfilepath + "'");
                string tempname = Ds.Tables[0].Rows[0][0].ToString();
                string templogname = Ds.Tables[0].Rows[1][0].ToString();

                // string CurrentDbpath = _Dbtask.ExecuteScalar("SELECT  physical_name AS current_file_location FROM sys.master_files  where name='" + _DataBase + "'");



                //File.Move(Filepath, Applicationfilepath);
                // string temppath="C:\\";
                
                _Dbtask.ExecuteNonQuery("RESTORE DATABASE [" + _DataBase + "] FROM  DISK = N'" + Applicationfilepath + "' WITH  FILE = 1,  MOVE N'" + tempname + "' TO N'" + CurrentDbpathOrg + "',  MOVE N'" + templogname + "' TO N'" + CurrentDbpathOrg.Substring(0, CurrentDbpathOrg.Length - 4) + "_log.LDF',  NOUNLOAD,  REPLACE,  STATS = 10");
                //_Dbtask.ExecuteNonQuery("ALTER DATABASE [" + _DataBase + "] SET EMERGENCY");
                _Dbtask.ExecuteNonQuery("ALTER DATABASE [" + _DataBase + "] SET Multi_User");
                _Dbtask.ExecuteNonQuery("ALTER DATABASE [" + _DataBase + "] MODIFY FILE (NAME=N'" + tempname + "', NEWNAME=N'" + _DataBase + "')");
                _Dbtask.ExecuteNonQuery("ALTER DATABASE [" + _DataBase + "] MODIFY FILE (NAME=N'" + templogname + "', NEWNAME=N'" + _DataBase + "_log')");
                //File.Move(Applicationfilepath, Filepath);
                File.Delete(Applicationfilepath);
                Application.Restart();
                Generalfunction.TempCompanyname = "";
                MessageBox.Show("Restore Successfully", _genf.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lblprogress.Visible = false;
                CommonClass._commenevent.NormalCursor(this);
            }


        }
        public void Backup()
        {
            try
            {

                string _DataBase =_Dbtask.currentcompany();

                //Generalfunction.TempCompanyname = "master";


                SaveFileDialog theDialog = new SaveFileDialog();
                theDialog.Title = "Save Qplex Backup File";
                theDialog.Filter = "Qplex Back file|*.Bak";
                theDialog.InitialDirectory = @"C:\";
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                  //  lblprogress.Visible = true;
                   // lblprogress.Text = "Backup Progress wait.......";
                    string Filepath = theDialog.FileName;
                    string Move = System.IO.Path.GetFileName(Filepath);
                    Move = Move.Substring(0, Move.Length - 4);

                    //_Dbtask.ExecuteNonQuery("ALTER DATABASE [" + _DataBase + "] MODIFY FILE (NAME=N'" + _DataBase + "', NEWNAME=N'" + Move + "')");
                    //_Dbtask.ExecuteNonQuery("ALTER DATABASE [" + _DataBase + "] MODIFY FILE (NAME=N'" + _DataBase + "_log', NEWNAME=N'" + Move + "_log')");
                    string CurrentDbpath = _Dbtask.ExecuteScalar("SELECT  physical_name AS current_file_location FROM sys.master_files  where name='" + _DataBase + "'");
                    int dnamelength = _DataBase.Length + 4;
                    CurrentDbpath = CurrentDbpath.Substring(0, CurrentDbpath.Length - dnamelength);
                    // string Applicationfilepath = Application.ExecutablePath.ToString();
                    //File.Move(Filepath, Applicationfilepath);

                    //Applicationfilepath = Applicationfilepath.Substring(0, Application.ExecutablePath.Length - 7);
                    string Applicationfilepath = CurrentDbpath;

                    //Applicationfilepath = Applicationfilepath + "Backups\\";
                    Applicationfilepath = Applicationfilepath + Move + ".Bak";
                    if (File.Exists(Applicationfilepath))/*File Already Exstiit Its Remove*/
                        File.Delete(Applicationfilepath);
                    _Dbtask.ExecuteNonQuery("use master BACKUP DATABASE [" + _DataBase + "] TO  DISK = N'" + Applicationfilepath + "' WITH NOFORMAT, INIT,  NAME = N'" + Move + "Full Database Backup',SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
                    //_Dbtask.ExecuteNonQuery("ALTER DATABASE [" + _DataBase + "] MODIFY FILE (NAME=N'" + Move + "', NEWNAME=N'" + _DataBase + "')");
                    //_Dbtask.ExecuteNonQuery("ALTER DATABASE [" + _DataBase + "] MODIFY FILE (NAME=N'" + Move + "_log', NEWNAME=N'" + _DataBase + "_log')");
                    File.Move(Applicationfilepath, Filepath);
                    // File.Create(Filepath);
                    Generalfunction.TempCompanyname = "";
                    MessageBox.Show("Backup Successfully", _genf.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                 //   lblprogress.Visible = false;
                    CommonClass._commenevent.NormalCursor(this);
                }
            }
            catch (Exception Exe)
            {
                MessageBox.Show(Exe.ToString());
            }
        }

        private void FrmBackupandrestore_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }

    }
}
