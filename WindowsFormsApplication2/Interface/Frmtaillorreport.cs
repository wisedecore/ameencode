using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Text;

using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frmtaillorreport : Form
    {
        public Frmtaillorreport()
        {
            InitializeComponent();
        }
        public string CusId = "";
        public  static bool only = false;
        private void Frmtaillorreport_Load(object sender, EventArgs e)
        {

            //this.dtarrivd.cul = new System.Globalization.CultureInfo("ar-sa");
            
            //hijriMain();
            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SY");
            //    //new System.Globalization.CultureInfo("ar-sa");
            //dtarrivd.CustomFormat = Application.CurrentCulture.DateTimeFormat.LongDatePattern;
            CusId = "";
            only = false;
            CommonClass._Nextg.FormIcon(this);
            //dtarrivd.Format = DateTimePickerFormat.Custom;
            //dtarrivd.CustomFormat= Application.CurrentCulture.DateTimeFormat.LongDatePattern;

        }
        public static void hijriMain()
        {
            HijriCalendar hijri = new HijriCalendar();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SY");

            CultureInfo current = CultureInfo.CurrentCulture;
           current.DateTimeFormat.Calendar = hijri;

            string dFormat = current.DateTimeFormat.ShortDatePattern;

            current.DateTimeFormat.ShortDatePattern = dFormat;
            DateTime date2 = new DateTime(1431, 9, 9, hijri);
            Console.WriteLine(current);
            Console.WriteLine(hijri);
            Console.WriteLine(date2);

        }

        private void txtsuppluer_TextChanged(object sender, EventArgs e)
        {
            CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtsuppluer.Text, uscitemshowsimple2, 1);
        }

        private void txtsuppluer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CommonClass._Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtsuppluer);

            uscitemshowsimple2.Location = new System.Drawing.Point(70, 110);
            if (e.KeyValue == 13)
            {
                CusId = txtsuppluer.Tag.ToString();
                
            }
        }

        private void chkcuist_CheckedChanged(object sender, EventArgs e)
        {
            if(chkcuist.Checked==true)
            {
                only = true;
            }
            else
            {
                only = false;
            }
        }

        private void cmdshow_Click(object sender, EventArgs e)
        {
            FrmReport _Form = new FrmReport();
            _Form.ReportType = "Dress Details";
            _Form.DTFrom = dtarrivd.Value;
            _Form.DTTo = dtto.Value;
            _Form.cuson = CusId.ToString();

            _Form.Show();
        }

        private void uscitemshowsimple2_Load(object sender, EventArgs e)
        {

        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            CusId = "";
            txtsuppluer.Text = ""; chkcuist.Checked = false;
        }
    }
}
