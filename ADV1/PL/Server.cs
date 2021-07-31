using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ADV1.PL
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var sv = textBox1.Text;
            const string qu = "\"";
            var conctionstring = @"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=" + qu + ";data source=" + sv + ";initial catalog=ADV;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\";";
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["ADVEntities"].ConnectionString = conctionstring;
            config.Save();
            ConfigurationManager.RefreshSection("connectionString");
            var strl = config.ConnectionStrings.ConnectionStrings["ADVEntities"].ConnectionString;
            MessageBox.Show(strl);
            Application.Restart();
        }
    }
}
