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
    public partial class Frmsettpricecode : Form
    {
        public Frmsettpricecode()
        {
            InitializeComponent();
        }

        public void SettDefault()
        {
            txtpoint.textBox1.Text = "Pre";
            txtpoint.textBox1.Text = ".";
            txt0.textBox1.Text = "0";
            txt1.textBox1.Text = "1";
            txt2.textBox1.Text = "2";
            txt3.textBox1.Text = "3";
            txt4.textBox1.Text = "4";
            txt5.textBox1.Text = "5";
            txt6.textBox1.Text = "6";
            txt7.textBox1.Text = "7";
            txt8.textBox1.Text = "8";
            txt9.textBox1.Text = "9";
        }

        private void Frmsettpricecode_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            SettDefault();
            Show();
            CommonClass._Nextg.FormIcon(this);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.PanelBasedConversion(panel1);
                //CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.GridHeaderConversion(gridmain);
            }
        }

        public void Show()
        {
        txtpreD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("Pre");
        txtpointD.textBox1.Text=CommonClass._Clspricecode.RetriveCode(".");
        txtzeroD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("0");
        txtoneD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("1");
        txttwoD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("2");
        txtthreeD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("3");
        txtfourD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("4");
        txtfiveD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("5");
        txtsixD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("6");
        txtsevenD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("7");
        txteightD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("8");
        txtninghtD.textBox1.Text = CommonClass._Clspricecode.RetriveCode("9");
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }

        public void Delete()
        {
            CommonClass._Clspricecode.Delete();
        }

        public void NextgInitialize()
        {
            CommonClass._Clspricecode.Field = "Pre";
            CommonClass._Clspricecode.Code = txtpreD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = ".";
            CommonClass._Clspricecode.Code = txtpointD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "0";
            CommonClass._Clspricecode.Code = txtzeroD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "1";
            CommonClass._Clspricecode.Code = txtoneD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "2";
            CommonClass._Clspricecode.Code = txttwoD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "3";
            CommonClass._Clspricecode.Code = txtthreeD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "4";
            CommonClass._Clspricecode.Code = txtfourD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "5";
            CommonClass._Clspricecode.Code = txtfiveD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "6";
            CommonClass._Clspricecode.Code = txtsixD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "7";
            CommonClass._Clspricecode.Code = txtsevenD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "8";
            CommonClass._Clspricecode.Code = txteightD.textBox1.Text;
            Insert();

            CommonClass._Clspricecode.Field = "9";
            CommonClass._Clspricecode.Code = txtninghtD.textBox1.Text;
            Insert();
        }

        private bool ValidationFu()
        {
            return true;
        }

        public void Insert()
        {
            CommonClass._Clspricecode.InsertpriceCode();
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    Delete();
                    NextgInitialize();
                   
                    return true;
                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
