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
    public partial class achat_add : Form
    {
        public int id;
        double buy, sell, qt, tbuy, tsell, trev;
        ADVEntities db = new ADVEntities();
        achat tb_achat = new achat();
        PL.ACHAT frm_achat = new ACHAT();
        BL.metod metode = new BL.metod();

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void qt_txt_ValueChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void Cliet_ADD_Activated(object sender, EventArgs e)
        {
            cat_txt.DataSource = db.TB_CAT.Select(x => x.cat_name).ToList();
            four_txt.DataSource = db.fournisseurs.Select(x => x.four_name).ToList();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FOUR_ADD four_add = new FOUR_ADD();
            four_add.btn_add.Text = "Ajoute";
            four_add.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.CAT_ADD Cat_add = new CAT_ADD();
            Cat_add.btn_add.Text = "Ajoute";
            Cat_add.Show();
        }

        private void cat_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void details_txt_TextChanged(object sender, EventArgs e)
        {

        }

        public achat_add()
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
            if (achat_nom.Text == "")
            {
                MessageBox.Show("Entrez le Nome");
               
            }
            else if (cat_txt.Text == "")
            {
                MessageBox.Show("Entrez categories");
            }
            else {
                if (id == 0)
                {
                    //ADD
                    //add
                    tb_achat.achat_name = achat_nom.Text;
                    tb_achat.achat_cat = cat_txt.Text; ;
                    tb_achat.achat_four = four_txt.Text;
                    tb_achat.achat_det = details_txt.Text;
                    tb_achat.achat_type = type_txt.Text;
                    tb_achat.achat_buy = Convert.ToInt32( prix_txt.Text);
                    tb_achat.achat_sell =Convert.ToInt32( vente_txt.Text);
                    tb_achat.achat_qt = Convert.ToInt32(qt_txt.Text);
                    db.achats.Add(tb_achat);
                    db.SaveChanges();
                    db = new ADVEntities();
                    frm_achat.gridControl1.DataSource = db.fournisseurs.ToList();
                    toast.txt_caption.Text = "Added successfully";
                    toast.ShowDialog();
                    this.Close();
                }
                else
                {
                    tb_achat.achat_name = achat_nom.Text;
                    tb_achat.achat_cat = cat_txt.Text; ;
                    tb_achat.achat_four = four_txt.Text;
                    tb_achat.achat_det = details_txt.Text;
                    tb_achat.achat_type = type_txt.Text;
                    tb_achat.achat_buy = Convert.ToInt32(prix_txt.Text);
                    tb_achat.achat_sell = Convert.ToInt32(vente_txt.Text);
                    tb_achat.achat_qt = Convert.ToInt32(qt_txt.Text);
                    db.SaveChanges();
                    tb_achat.id = id;
                    db.Entry(tb_achat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "Modifier successfully";
                    toast.ShowDialog();
                    frm_achat.gridControl1.DataSource = db.fournisseurs.ToList();
                    this.Close();
                }




            }

            
        }
        private void pro_cal()
        {
            try {
                buy = Convert.ToDouble(prix_txt.Text);
                sell = Convert.ToDouble(vente_txt.Text);
                qt = Convert.ToDouble(qt_txt.Value);
                tsell = sell * qt;
                tbuy = buy * qt;
                trev = tsell - tbuy;
                t_buy.Text = tbuy.ToString();
                t_sell.Text = tsell.ToString();
                t_rev.Text = trev.ToString();
            }
            catch { }
        
            
        }
    }
}

