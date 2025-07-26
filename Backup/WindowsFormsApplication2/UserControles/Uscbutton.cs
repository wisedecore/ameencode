using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2.UserControles
{
    public partial class Uscbutton : UserControl
    {
        public Uscbutton()
        {
            InitializeComponent();
        }

        public delegate void Delbuttonclick(object Sender, EventArgs e);
        [Browsable(true)]
        public new event Delbuttonclick Click;

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Click != null)
                this.Click(sender, e);
        }

      
    }
}
