using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace ADV1.PL
{
    public partial class frm_report : Form
    {
        public frm_report()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            PL.rp_cli rp = new rp_cli();
            rp.ShowDesigner();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.rp_cat rp4 = new rp_cat();
            rp4.ShowDesigner();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PL.rp_four rp3 = new rp_four();
            rp3.ShowDesigner();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PL.rp_achat rp2 = new rp_achat();
            rp2.ShowDesigner();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            PL.rp_vent rp1 = new rp_vent();
            rp1.ShowDesigner();
        }
    }
}
