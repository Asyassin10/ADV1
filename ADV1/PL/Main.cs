using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADV1.PL
{
    public partial class Main : Form
    {
        ADVEntities db = new ADVEntities();
        public Main()
        {
            InitializeComponent();
            List<TB_CAT> list_cat = db.TB_CAT.ToList();
            lb_cat.Text = list_cat.Count.ToString();

            List<fournisseur> list_four = db.fournisseurs.ToList();
            lb_four.Text = list_four.Count.ToString();

            List<client> list_cli = db.clients.ToList();
            lbl_cll.Text = list_cli.Count.ToString();

            List<achat> list_acht = db.achats.ToList();
            lbl_achat.Text = list_acht.Count.ToString();

            List<vente> list_vant = db.ventes.ToList();
            lb_vent.Text = list_vant.Count.ToString();


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
