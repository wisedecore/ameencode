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
    public partial class UscPopup : UserControl
    {
        public UscPopup()
        {
            InitializeComponent();
        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
