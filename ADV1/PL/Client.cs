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
    public partial class Client : Form
    {
        public int id;
        ADVEntities db = new ADVEntities();
        BL.metod metod = new BL.metod();
        client tb_cli = new client();
        public Client()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            ADV1.ADVEntities dbContext = new ADV1.ADVEntities();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.clients.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = dbContext.clients.Local.ToBindingList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.CLIENT_ADD client_add = new CLIENT_ADD();
            client_add.id = 0;
            client_add.btn_add.Text = "Ajoute";
            client_add.Show();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDVDataSet3.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.aDVDataSet3.client);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PL.CLIENT_ADD frm_add = new CLIENT_ADD();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id"));
            tb_cli = db.clients.Where(x => x.id == id).FirstOrDefault();
            frm_add.nam_txt.Text = tb_cli.cli_name.ToString();
            frm_add.phon_txt.Text = tb_cli.cli_phone.ToString();
            frm_add.email_txt.Text = tb_cli.cli_email.ToString();
            metod.by = tb_cli.cli_cover;
            frm_add.pictureEdit1.Image = System.Drawing.Image.FromStream(metod.convert_image());
            frm_add.id = id;
            frm_add.btn_add.Text = "Modifier";
            frm_add.Show();
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
                    tb_cli = db.clients.Where(x => x.id == id).FirstOrDefault();
                    db.Entry(tb_cli).State = EntityState.Deleted;
                    db.SaveChanges();
                    updte_data();
                    toast.txt_caption.Text = "Supprimer";
                    toast.ShowDialog();
                }
                else { }
            }
            catch { }
        }
            public void updte_data()
            {
            db = new ADVEntities();
            gridControl1.DataSource = db.clients.ToList();
            }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            db = new ADVEntities();
            gridControl1.DataSource = db.clients.ToList();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var search = textBox1.Text;
            gridControl1.DataSource = db.clients.Where(x => x.cli_name.Contains(search)).ToList();
        }
    }
}