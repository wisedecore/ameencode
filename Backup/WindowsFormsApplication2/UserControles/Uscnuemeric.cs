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
    public partial class Uscnuemeric : UserControl
    {
        public Uscnuemeric()
        {
            InitializeComponent();
            //txtnuemeric.GotFocus += new EventHandler(txtnuemeric_GotFocus);

            txtnuemeric.GotFocus += delegate { txtnuemeric.Select(txtnuemeric.Text.Length,txtnuemeric.Text.Length); }; 
        }

        //void txtnuemeric_GotFocus(object sender, EventArgs e)
        //{
        //    txtnuemeric.Select(txtnuemeric.Text.Length, txtnuemeric.Text.Length);
        //}
        
        private void txtnuemeric_Enter(object sender, EventArgs e)
        {
        }

        private void Uscnuemeric_Click(object sender, EventArgs e)
        {
            //textbo
        }

        //protected override void OnGotFocus(EventArgs e)
        //{
        //    base.OnGotFocus(e);
        //    if (!this.selectionSet)
        //    {
        //        this.selectionSet = true;
        //        if ((this.SelectionLength == 0) && (Control.MouseButtons == MouseButtons.None))
        //        {
        //            base.SelectAll();
        //        }
        //    }
        //}
    }
}
