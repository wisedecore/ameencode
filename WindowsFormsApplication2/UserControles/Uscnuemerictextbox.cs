using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Uscnuemerictextbox : UserControl
    {
        public Uscnuemerictextbox()
        {
            InitializeComponent();
        }
        public delegate void DelTextChanged(object Sender, EventArgs e);
        [Browsable(true)]

        public new event DelTextChanged TextChanged;
        public new event PreviewKeyDownEventHandler PreviewKeyDown;

        private delegate void SelectAllDelegate();
        private IAsyncResult _selectAllar = null;
        private void Uscnormaltextbox_Load(object sender, EventArgs e)
        {

        }

       
        private void _SelectAll()
        {
            //Clean-up the BeginInvoke
            if (this._selectAllar != null)
            {
                this.EndInvoke(this._selectAllar);
            }
            //Now select everything.
            this.textBox1.SelectAll();
        }



      

        public void Clear()
        {
            this.textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.TextChanged != null)
                this.TextChanged(sender, e);
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (this.PreviewKeyDown != null)
                this.PreviewKeyDown(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this._selectAllar = this.BeginInvoke(new SelectAllDelegate(this._SelectAll));
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        

       

    }
}
