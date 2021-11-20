using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Controls;
using System.Data.SqlClient;

namespace clienteC
{
    public partial class funcionario : UserControl
    {
        public funcionario()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-6MFH4M9\SQLEXPRESS ;Database=trab ;User Id=sa ;Password = 12345; ");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;


        private void novoFunc_Click(object sender, EventArgs e)
        {

        }

        private void removerFunc_Click(object sender, EventArgs e)
        {

        }

        private void editarFunc_Click(object sender, EventArgs e)
        {

        }

        private void cancelarFunc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UserControl1.BringToFront();
        }
    }
}
