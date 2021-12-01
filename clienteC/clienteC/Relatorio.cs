using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clienteC
{
    public partial class Relatorio : UserControl
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            dtp.Visible = false;
            cb_selecionar.Items.Add("clientes que realizaram compras");
            cb_selecionar.Items.Add("compras realizadas em período selecionado");
            cb_selecionar.Items.Add("produtos abaixo do estoque mínimo");
            cb_selecionar.Items.Add("folha de pagamento dos salários dos funcionários vendedores");
        }

        private void cb_selecionar_TextUpdate(object sender, EventArgs e)
        {
        }

        private void cb_selecionar_TextChanged(object sender, EventArgs e)
        {
            if (cb_selecionar.Text == "compras realizadas em período selecionado")
            {
                dtp.Visible = true;
            }
            else
            {
                dtp.Visible = false;
            }
            }
    }
}
