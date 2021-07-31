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
    public partial class Login : Form
    {
        utili tb_uti = new utili();
        ADVEntities db = new ADVEntities();
        Home FRM_home = new Home();
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Activated(object sender, EventArgs e)
        {
            
                // Set to no text.
                pass_txt.Text = "";
                // The password character is an asterisk.
                pass_txt.PasswordChar = '*';
                // The control will allow no more than 14 characters.
                pass_txt.MaxLength = 14;
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(user_txt.Text=="")
            {
                MessageBox.Show("Entre Nom d'utilisateur ");
            }
            else if (pass_txt.Text == "")
            {
                MessageBox.Show("Entre le Mot se pass ");
            }
            else
            {
                // conect
                tb_uti = db.utilis.Where(x => x.utili_user == user_txt.Text && x.utili_pass == pass_txt.Text).FirstOrDefault();
               
                if (tb_uti!= null)
                {
                    tb_uti.utili_state = "True";
                    db.Entry(tb_uti).State = System.Data.Entity.EntityState.Modified;
                    FRM_home.label2.Text = tb_uti.utili_user;
                    FRM_home.label3.Text = tb_uti.utili_roll;
                    FRM_home.Enabled = true;
                    db.SaveChanges();
                    FRM_home.Show();
                    this.Close();




                }
                else
                {
                    label4.Visible = true;
                }

                 
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
