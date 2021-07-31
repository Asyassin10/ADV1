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
    public partial class CAT_ADD : Form
    {
        public int id;
        BL.metod metode = new BL.metod();
        ADVEntities db = new ADVEntities();
        TB_CAT tb_cat = new TB_CAT();
        PL.CAT CAT = new CAT();
        public CAT_ADD()
        {
            InitializeComponent();
        }

        private void CAT_ADD_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            EBL.dailog dailog = new EBL.dailog();
            EBL.toast toast = new EBL.toast();
            //add or edit
            if (txt_cat.Text == "")
            {
                MessageBox.Show("Entre categories");
               
            }
            else
            {
                if (id == 0)
                {

                    //add
                    pictureEdit1.Image.Save(metode.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.cat_name = txt_cat.Text;
                    tb_cat.cat_cover = metode.convert_byte();
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    toast.txt_caption.Text = "Added successfully";
                    toast.ShowDialog();
                    this.Close();



                }
                else
                {
                    pictureEdit1.Image.Save(metode.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.cat_name = txt_cat.Text;
                    tb_cat.cat_cover = metode.convert_byte();
                    tb_cat.id = id;
                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "Modifier successfully";
                    toast.ShowDialog();
                    CAT.gridControl1.DataSource = db.TB_CAT.ToList();
                    this.Close();
                }
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
