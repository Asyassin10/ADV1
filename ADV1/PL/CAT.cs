﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ADV1.PL
{
    
    public partial class CAT : Form
    {
        TB_CAT tb_cat = new TB_CAT();
        int id;
        ADVEntities db = new ADVEntities();
        BL.metod metod = new BL.metod();

        public CAT()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            ADV1.ADVEntities dbContext = new ADV1.ADVEntities();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.TB_CAT.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = dbContext.TB_CAT.Local.ToBindingList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.CAT_ADD Cat_add = new CAT_ADD();
            Cat_add.id = 0;
            Cat_add.btn_add.Text = "Ajoute";
            Cat_add.Show();
        }

        private void CAT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDVDataSet.TB_CAT' table. You can move, or remove it, as needed.
            this.tB_CATTableAdapter.Fill(this.aDVDataSet.TB_CAT);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PL.CAT_ADD cat_add = new CAT_ADD();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id"));
            tb_cat = db.TB_CAT.Where(x => x.id == id).FirstOrDefault();
            cat_add.txt_cat.Text = tb_cat.cat_name.ToString();
            metod.by = tb_cat.cat_cover;
            cat_add.pictureEdit1.Image = System.Drawing.Image.FromStream(metod.convert_image());
            cat_add.id = id;
            cat_add.btn_add.Text = "Modifier";
            cat_add.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = MessageBox.Show("Processus de suppression", "Voulez-vous supprimer?", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    EBL.toast toast = new EBL.toast();
                    id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id"));
                    tb_cat = db.TB_CAT.Where(x => x.id == id).FirstOrDefault();
                    db.Entry(tb_cat).State = EntityState.Deleted;
                    db.SaveChanges();
                    updte_data();
                    toast.txt_caption.Text = "Supprimer";
                    toast.ShowDialog();
                    updte_data();
                }
                else { }
            }
            catch { }
        }
        public void updte_data()
        {
            db = new ADVEntities();
            gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            db = new ADVEntities();
            gridControl1.DataSource = db.TB_CAT.ToList();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var search = textBox1.Text;
            gridControl1.DataSource = db.TB_CAT.Where(x => x.cat_name.Contains(search)).ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
