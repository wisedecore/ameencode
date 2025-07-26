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
    public partial class FrmCreateItemclass : Form
    {
        public FrmCreateItemclass()
        {
            InitializeComponent();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreateItemclass_Load(object sender, EventArgs e)
        {
            CommonClass._Nextg.FormIcon(this);
        }
    }
}
