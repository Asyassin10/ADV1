using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADV1
{
    

    public partial class Home : Form
    {
        utili tb_uti = new utili();
        ADVEntities db = new ADVEntities();
        PL.CAT frm_cat = new PL.CAT();
        PL.Main frm_home = new PL.Main();
        PL.FOUR frm_four = new PL.FOUR();
        PL.ACHAT frm_achat = new PL.ACHAT();
        PL.Client frm_client = new PL.Client();
        PL.Ventes frm_ventes = new PL.Ventes();
        PL.Utili frm_utili = new PL.Utili();
        PL.frm_report frm_report = new PL.frm_report();

        public Home()
        {
            InitializeComponent();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 236)
            {
                panel1.Width = 47;
                pl_titelnabvar.Visible = false;
                pl_titelnabvar.Height = 170;

            }
            else
            {
                panel1.Width = 236;
                pl_titelnabvar.Visible = true;
                pl_titelnabvar.Height = 178;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
             pl_center.Controls.Clear();
            pl_center.Controls.Add(frm_home.panel_main);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            pl_center.Controls.Clear();
            pl_center.Controls.Add(frm_cat.panel_CAT);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            pl_center.Controls.Clear();
            pl_center.Controls.Add(frm_four.panel_FOUR);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pl_center.Controls.Clear();
            pl_center.Controls.Add(frm_home.panel_main);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            pl_center.Controls.Clear();
            pl_center.Controls.Add(frm_achat.panel_client);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            pl_center.Controls.Clear();
            pl_center.Controls.Add(frm_client.panel_client1);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            pl_center.Controls.Clear();
            pl_center.Controls.Add(frm_ventes.panel_ventes);
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            pl_center.Controls.Clear();
            pl_center.Controls.Add(frm_utili.panel_utili);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            PL.Server server = new PL.Server();
            server.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            PL.Login log = new PL.Login();
            tb_uti = db.utilis.Where(x => x.utili_state == "True").FirstOrDefault();
            tb_uti.utili_state = "False";
            db.Entry(tb_uti).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Enabled = false;

            log.Show();
            this.Hide();

        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            pl_center.Controls.Clear();
            pl_center.Controls.Add(frm_report.panel_report);
        }
    }
}
