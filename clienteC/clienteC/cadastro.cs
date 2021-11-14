using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clienteC
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-6MFH4M9\SQLEXPRESS ;Database=cliente ;User Id=sa ;Password = 12345; ");
        
        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
