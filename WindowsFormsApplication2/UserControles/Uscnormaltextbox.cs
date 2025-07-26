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
    public partial class Uscnormaltextbox : UserControl
    {
        public Uscnormaltextbox()
        {
            InitializeComponent();
        }
        public delegate void DelTextChanged(object Sender, EventArgs e);
        public delegate void DelKeyPressEventArgs(object Sender, EventArgs e);
        public delegate void DelKeyDown(object Sender, EventArgs e);
        public delegate void DelPreviewKeyDownEventArgs(object Sender, EventArgs e);

        [Browsable(true)]
        public new event DelTextChanged TextChanged;
        public new event KeyPressEventHandler KeyPress;
        public new event PreviewKeyDownEventHandler PreviewKeyDown;

        private delegate void SelectAllDelegate();
        private IAsyncResult _selectAllar = null;
        private void Uscnormaltextbox_Load(object sender, EventArgs e)
        {

        }
        public void Enetersett(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.AntiqueWhite;
            txt.ForeColor = System.Drawing.Color.Black;
        }
        public void Leavesett(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.White;
            txt.ForeColor = System.Drawing.Color.Black;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            this._selectAllar = this.BeginInvoke(new SelectAllDelegate(this._SelectAll));
            Enetersett(textBox1);
        }

        private void _SelectAll()
        {
            try
            {
                //Clean-up the BeginInvoke
                if (this._selectAllar != null)
                {
                    this.EndInvoke(this._selectAllar);
                }
                //Now select everything.
                this.textBox1.SelectAll();
            }
            catch
            {
            }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.KeyPress != null)
                this.KeyPress(sender, e);
            //this.KeyPress(
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Leavesett(textBox1);
        }

        private void Uscnormaltextbox_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.Focus();
            textBox1.Select();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (this.PreviewKeyDown != null)
                this.PreviewKeyDown(sender, e);
        }

        
    }
}
