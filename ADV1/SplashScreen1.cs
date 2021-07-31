using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraSplashScreen;

namespace ADV1
{
    public partial class SplashScreen1 : SplashScreen
    {
        utili tb_uti = new utili();
        ADVEntities db = new ADVEntities();
        PL.Login log = new PL.Login();
        Home FRM_home = new Home();

        public SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_uti = db.utilis.Where(x => x.utili_state == "True").FirstOrDefault();
            if(tb_uti !=null)
            {
                FRM_home.label2.Text = tb_uti.utili_user;
                FRM_home.label3.Text = tb_uti.utili_roll;
                FRM_home.Show();
            }
            else
            {
                log.Show();
            }
            this.Hide();
            timer1.Enabled = false;
        }
    }
}