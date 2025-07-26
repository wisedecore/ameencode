using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using Microsoft.Win32;
//using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Clscommenevent
    {
        public DataSet Ds;       
        public string Temp;
        public double DTemp=0;

        public int selectedRow;
        DBTask _Dbtask = new DBTask();
        public string DatasetToString(string Sql,string Field)
        {
            Ds = _Dbtask.ExecuteQuery(Sql);
            Temp = "";
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                string Get = Ds.Tables[0].Rows[i][Field].ToString();
                Temp = Temp + "," + Get;
            }
            if (Temp.Length > 0)
            {
                Temp = Temp.Substring(1, Temp.Length - 1);
            }
            return Temp;
        }

        public DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }


        public double RemoveMInesinAmount(double Amt)
        {
            DTemp = Math.Abs(Amt);
            return DTemp;
        }
      
        public string ItemSearch(string PassingString)
        {
            if (Clssettings.ItemSearch == "1")
                PassingString = "'" + PassingString + "%'";
            if (Clssettings.ItemSearch == "2")
                PassingString = "'%" + PassingString + "'"; 
            if (Clssettings.ItemSearch == "3")
                PassingString = "'%" + PassingString+"%'";
            return PassingString;
        }

        public void WaitCursor(Form Frm)
        {
            Frm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
        }

        public void NormalCursor(Form Frm)
        {
            Frm.Cursor = System.Windows.Forms.Cursors.Default;
        }

        public void CheckinAdminUser(string Vtype,bool IncBatc)
        {
            FrmCheckinuser _Chekinuser = new FrmCheckinuser();
            _Chekinuser.Vtype = Vtype;
            _Chekinuser.IncludeBatch = IncBatc;
            
        _Chekinuser.ShowDialog();
        }
        
       

        public void TextboxSelect(TextBox txt)
        {
            txt.SelectAll();
           // txt.SelectionStart = 0;
            txt.Select(0, txt.Text.Length - 1);
        }

        public void UpDowninGridList(DataGridView SubGridview, int KeyValue, DataGridView Gridmain)
        {
            try
            {
                if (SubGridview.SelectedRows.Count > 0)
                {
                    selectedRow = SubGridview.SelectedRows[0].Index;
                    int gridmainSelect = Gridmain.CurrentCell.RowIndex;
                    if (SubGridview.Visible == true)
                    {
                        if (KeyValue == 40 && SubGridview.Rows[selectedRow].Cells[0].Value != null)
                        {
                            if (SubGridview.Rows[selectedRow + 1].Cells[0].Value != null)
                            {
                                SubGridview.Rows[selectedRow + 1].Selected = true;
                                SubGridview.Rows[selectedRow].Selected = false;
                                SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[0];
                            }
                        }
                        if (KeyValue == 38 && selectedRow != 0)
                        {
                           // Gridmain.Rows[gridmainSelect + 1].Selected = true;
                            SubGridview.Rows[selectedRow - 1].Selected = true;
                            SubGridview.Rows[selectedRow].Selected = false;
                            SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[0];
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}
