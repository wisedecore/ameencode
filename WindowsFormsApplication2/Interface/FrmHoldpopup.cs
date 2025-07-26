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
    public partial class FrmHoldpopup : Form
    {
        public FrmHoldpopup()
        {
            InitializeComponent();
        }

        public static int numbttn = 0;
        public static string holdnum = "";
        private void FrmHoldpopup_Load(object sender, EventArgs e)
        {

            //for (numbttn > 0; numbttn++; )
            //{
            //    Button mybuttn = new Button();
            //    mybuttn.AutoSize = true;
            //    this.Controls.Add(mybuttn);
            //}
            
            //cmdpopup.Text = holdnum;
        }
    }
}
