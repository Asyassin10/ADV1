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
    public partial class utili_add : Form
    {
        public int id;
        ADVEntities db = new ADVEntities();
        utili tb_uti = new utili();
        PL.Utili frm_utili = new Utili();
        BL.metod metode = new BL.metod();
        public utili_add()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            EBL.toast toast = new EBL.toast();
            EBL.dailog dailog = new EBL.dailog();
            if (nome_txt.Text == "")
            {
                MessageBox.Show("Entrez le nome");

            }
            else if (statu_txt.Text == "")
            {
                MessageBox.Show("Entrez le statu");
            }
            else if (motpass_txt.Text == "")
            {
                MessageBox.Show("Entrez mot de pass");
            }
            else
            {
                if (id == 0)
                {
                    //ADD
                    //add
                    tb_uti.utili_user = nome_txt.Text;
                    tb_uti.utili_pass = motpass_txt.Text;
                    tb_uti.utili_state = statu_txt.Text;
                    db.utilis.Add(tb_uti);
                    db.SaveChanges();
                    db = new ADVEntities();
                    frm_utili.gridControl1.DataSource = db.fournisseurs.ToList();
                    toast.txt_caption.Text = "Added successfully";
                    toast.ShowDialog();
                    this.Close();
                }
                else
                {
                    //edit
                    tb_uti.utili_user = nome_txt.Text;
                    tb_uti.utili_pass = motpass_txt.Text;
                    tb_uti.utili_state = statu_txt.Text;
                    tb_uti.id = id;
                    db.Entry(tb_uti).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "Modifier successfully";
                    toast.ShowDialog();
                    frm_utili.gridControl1.DataSource = db.fournisseurs.ToList();
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
