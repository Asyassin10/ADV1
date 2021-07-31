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
     
    public partial class ventes_add : Form
    {
        public int id;
        ADVEntities db = new ADVEntities();
        vente tb_vente = new vente();
        PL.Ventes frm_vant = new Ventes();
        BL.metod metode = new BL.metod();
        achat tb_achat = new achat();
        client tb_client = new client();
        double qtp, qtn, qtr; 
        public ventes_add()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            EBL.toast toast = new EBL.toast();
            EBL.dailog dailog = new EBL.dailog();
            qtp = Convert.ToDouble(txt_qt.Text);
            qtn = Convert.ToDouble(qt_txt.Value);
            qtr = qtp - qtn;
            if (achat_txt.Text == "")
            {
                MessageBox.Show("Entrez le article");
            }
            else
            {
                if(id==0)
                {
                    if (qtr >= 0)
                    {
                        tb_vente.vent_name = achat_txt.Text;
                        tb_vente.vent_cli = client_txt.Text; ;
                        tb_vente.vent_prix =Convert.ToDouble( vent_txt.Text);
                        tb_vente.vent_qt = Convert.ToDouble(qt_txt.Value);
                        tb_vente.vent_Tprix = Convert.ToDouble(vent_txt.Text) * Convert.ToDouble(qt_txt.Value);
                        tb_vente.vent_date = DateTime.Now;
                        db.ventes.Add(tb_vente);
                        tb_achat.achat_qt = qtr;
                        db.Entry(tb_achat).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt_caption.Text = "Added successfully";
                        toast.ShowDialog();
                        this.Close();
                        
                    }
                    else
                    {
                        label1.Visible = true;
                    }
                }
                    
                  
            }
        }

        private void ventes_add_Activated(object sender, EventArgs e)
        {
            var rs1= db.achats.Select(x => x.achat_name).ToList();
            var rs2= db.clients.Select(x => x.cli_name).ToList();

            achat_txt.DataSource = rs1;
            client_txt.DataSource = rs2;
            AutoCompleteStringCollection acs1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acs2 = new AutoCompleteStringCollection();
            acs1.AddRange(rs1.ToArray());
            acs2.AddRange(rs2.ToArray());
            achat_txt.AutoCompleteCustomSource = acs1;
            client_txt.AutoCompleteCustomSource = acs2;
            tb_achat = db.achats.Where(x => x.achat_name == achat_txt.Text).FirstOrDefault();
            txt_achat.Text = tb_achat.achat_buy.ToString();
            txt_vent.Text = tb_achat.achat_sell.ToString();
            txt_qt.Text = tb_achat.achat_qt.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void achat_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_achat = db.achats.Where(x => x.achat_name == achat_txt.Text).FirstOrDefault();
            txt_achat.Text = tb_achat.achat_buy.ToString();
            txt_vent.Text = tb_achat.achat_sell.ToString();
            txt_qt.Text = tb_achat.achat_qt.ToString();
        }
    }
}
