using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Clsselectreport
    {
        DBTask _Dbtask = new DBTask();
        DataSet Ds;
        public string Temp;
        public double DbTemp=0;
        String Strarry;
        public static string agvnolid = "";
        public static string RTypeSecond;
        public static string RType ;
        public static string RQuery ;
        public static string RQueryTemp ;
        public static string RQueryDetail ;
        public static DateTime RDtfrom;
        public static DateTime   Rdtto;
        public static string SCoundition;

        public void Fillinlist(ListBox Lst,string Str)
        {
            Temp = "";
            Lst.Items.Clear();
            for (int i = 0; i <Str.Length; i++)
            {
                if (Str.Substring(i, 1) != ",")
                {
                    Temp = Temp + Str.Substring(i, 1);
                }
                else
                {
                    if (Temp != "")
                        Lst.Items.Add(Temp);
                    Temp = "";
                }
                
            }
            if (Temp != "" || Temp != ",")
                Lst.Items.Add(Temp);
            
        }

        public string ShowSelectedinGrid(DataGridView Gridmain,bool Insertsing)
        {
           // Gridmain.Refresh();
            
            Temp = "";
            for (int i = 0; i < Gridmain.Rows.Count; i++)
            {
                string Value;
                if (Gridmain.Rows[i].Cells[0].Value != null)
                {
                    Value = Gridmain.Rows[i].Cells[0].Value.ToString();

                    //DataGridViewRow row = new DataGridViewRow();

                    //var ch1 = new DataGridViewCheckBoxCell();
                    //ch1 = (DataGridViewCheckBoxCell)row.Cells[0];

                    if (Insertsing == false)
                    {
                        if (Value == "1" && Gridmain.Rows[i].Cells[1].Tag != null)
                        {
                            string Id = _Dbtask.znllString(Gridmain.Rows[i].Cells[1].Tag);
                            if (Insertsing == true)
                            {
                                Temp = Temp + "," + "'" + Id + "'";
                            }
                            else
                            {
                                Temp = Temp + "," + Id;
                            }
                        }
                    }

                    else
                    {
                        if (Value == "1" && Gridmain.Rows[i].Cells[1].Value != "")
                        {
                            if (Gridmain.Rows[i].Cells[1].Value != null)
                            {
                                string Id = _Dbtask.znllString(Gridmain.Rows[i].Cells[1].Value);
                                if (Insertsing == true)
                                {
                                    Temp = Temp + "," + "'" + Id + "'";
                                }
                                else
                                {
                                    Temp = Temp + "," + Id;
                                }
                            }
                        }
                    }
                }
            }
            if(Temp.Length>0)
                Temp=Temp.Substring(1,Temp.Length-1);
            return Temp;
        }

        public string ShowSelectedinList(ListBox Lst)
        {
            Temp = "";
            for (int i = 0; i < Lst.Items.Count; i++)
            {
                string Value;
                if (Lst.Items[i] != null)
                {
                    Value = Lst.Items[i].ToString();
                    Temp = Temp + "," + Value;
                }
            }
            if (Temp.Length > 0)
                Temp = Temp.Substring(1, Temp.Length - 1);
            return Temp;
        }

        public void SelectAllCheckinGrid(DataGridView Grid)
        {
            for (int i = 0; i < Grid.Rows.Count; i++)
            {
                Grid.Rows[i].Cells[0].Value = 1;
            }
        }
        public string ShowFirstandLast(string Query)
        {
            Temp = "";
            Ds = _Dbtask.ExecuteQuery(Query);
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Temp = Ds.Tables[0].Rows[0][0].ToString();
                if (Temp == "")
                    Temp = "1";

                Temp = Temp + "/" + Ds.Tables[0].Rows[Ds.Tables[0].Rows.Count-1][0].ToString();
            }
            return Temp;
        }

        public bool Reportselect(double Amount)
        {
            if (DbTemp > 0)
            {
                if (Amount > DbTemp)
                    return true;
                else
                    return false;
            }
            if (Amount == 0)
                return false;
            return true;
        }

        public string Showindataset(string Query)
        {
            Temp = "";
            Ds = _Dbtask.ExecuteQuery(Query);
            for (int i = 0; i <Ds.Tables[0].Rows.Count; i++)
            {
                    string Id = _Dbtask.znllString(Ds.Tables[0].Rows[i][0]);
                    Temp = Temp + "," + Id;  
            }
            if (Temp.Length > 0)
                Temp = Temp.Substring(1, Temp.Length - 1);
            return Temp;
        }
        public string ShowindatasetForString(string Query)
        {
            Temp = "";
            Ds = _Dbtask.ExecuteQuery(Query);
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                string Id = _Dbtask.znllString(Ds.Tables[0].Rows[i][0]);
                Temp = Temp + "," + "'"+Id+"'";
            }
            if (Temp.Length > 0)
                Temp = Temp.Substring(1, Temp.Length - 1);
            return Temp;
        }
        
        public void TreeviewBeforeSelect(TreeView TreeMain)
        {
            if (TreeMain.SelectedNode != null)
                TreeMain.SelectedNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
        }
        
        public void TreeviewAfterSelect(TreeView TreeMain)
        {
            if(TreeMain.SelectedNode !=null)
            TreeMain.SelectedNode.BackColor = System.Drawing.Color.Plum;
        }

        //public String ReturnToarray(string Str)
        //{
        //    foreach (var item in checkedListBox1.CheckedItems)
        //    {
        //        var row = (item as DataRowView).Row;
        //        MessageBox.Show(row["ID"] + ": " + row["CompanyName"]);
        //    }
        //    return Strarry;
        //}
    }
}
