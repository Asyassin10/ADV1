using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADV1.PL;
namespace ADV1.PL
{
    public partial class FOUR_ADD : Form
    {
        public int id;
        ADVEntities db = new ADVEntities();
        fournisseur tb_four = new fournisseur();
        PL.FOUR frm_four = new FOUR();
        BL.metod metode = new BL.metod();
        public FOUR_ADD()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FOUR_ADD_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            EBL.toast toast = new EBL.toast();
            EBL.dailog dailog = new EBL.dailog();
            if (name_txt.Text == "")
            {

                MessageBox.Show("Entrez le nome");
            }
            else if (email_txt.Text == "")
            {
                MessageBox.Show("Entrez email");
            }
            else
            {
                if (id == 0)
                {
                    //ADD
                    //add
                    pictureEdit1.Image.Save(metode.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_four.four_name = name_txt.Text;
                    tb_four.four_phone = Convert.ToInt32(phone_txt.Text);
                    tb_four.four_email = email_txt.Text;
                    tb_four.four_cover = metode.convert_byte();
                    db.fournisseurs.Add(tb_four);
                    db.SaveChanges();
                    db = new ADVEntities();
                    frm_four.gridControl1.DataSource = db.fournisseurs.ToList();
                    toast.txt_caption.Text = "Added successfully";
                    toast.ShowDialog();
                    this.Close();

                }
                else
                {
                    //edit
                    pictureEdit1.Image.Save(metode.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_four.four_name = name_txt.Text;
                    tb_four.four_phone = Convert.ToInt32(phone_txt.Text);
                    tb_four.four_email = email_txt.Text;
                    tb_four.four_cover = metode.convert_byte();
                    tb_four.id = id;
                    db.Entry(tb_four).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "Modifier successfully";
                    toast.ShowDialog();
                    frm_four.gridControl1.DataSource = db.fournisseurs.ToList();
                    this.Close();

                }
            }
        }
    }
}
