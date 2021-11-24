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
    public partial class compra : UserControl
    {
        public compra()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-6MFH4M9\SQLEXPRESS;Database=trab ;User Id=sa ;Password = 12345; ");
        SqlConnection cn1 = new SqlConnection(@"Server=DESKTOP-6MFH4M9\SQLEXPRESS;Database=trab ;User Id=sa ;Password = 12345; ");
        SqlConnection cn2 = new SqlConnection(@"Server=DESKTOP-6MFH4M9\SQLEXPRESS;Database=trab ;User Id=sa ;Password = 12345; ");
        SqlCommand cf = new SqlCommand(); //Comando Funcionário
        SqlCommand cm = new SqlCommand(); //Comando Cliente
        SqlCommand cp = new SqlCommand(); //Comando Produto



        SqlDataReader dt;

        private void HabilitaCamposC()
        {
            cb_cliente.Enabled = true;
            cb_vendedor.Enabled = true;
            btn_cadastrar.Enabled = true;
            btn_novo.Enabled = false;
            btn_editar.Enabled = true;
            btn_remover.Enabled = true;
            btn_cancelar.Enabled = true;
        
           
            //dgvF.DataSource = null;
        }

     
        private void manipularDadosC()
        {
            btn_editar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_remover.Enabled = true;
            btn_cadastrar.Enabled = false;
            btn_novo.Enabled = false;
            cb_cliente.Enabled = true;
            cb_vendedor.Enabled = true;


        }


        private void DesabilitaCamposC()
        {
            cb_cliente.Enabled = false;
            cb_vendedor.Enabled = false;
            btn_editar.Enabled = false;
            btn_remover.Enabled = false;
            btn_novo.Enabled = true;
            btn_cancelar.Enabled = false;
            btn_cadastrar.Enabled = false;
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void compra_Load(object sender, EventArgs e)
        {
           //ComboBox Cliente
            cn.Open();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from cliente";
            SqlDataAdapter da = new SqlDataAdapter();

            var ds = new DataSet();

            da.SelectCommand = cm;
            da.Fill(ds);
            DataTable dtDatabases = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cb_cliente.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                cn.Close();
            }
          //ComboBox Funcionário
            cn.Close();
            cn1.Open();
            cf.Connection = cn1;
            cf.CommandText = "select * from funcionarios";
            cf.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new SqlDataAdapter();
            var ds1 = new DataSet();
            da1.SelectCommand = cf;
            da1.Fill(ds1);
            DataTable dtDatabases2 = ds1.Tables[0];
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                cb_vendedor.Items.Add(ds1.Tables[0].Rows[i][1].ToString());
                cn1.Close();
            }
            //ComboBox Produto
            cn1.Close();
            cn2.Open();
            cp.Connection = cn2;
            cp.CommandText = "select * from produtos";
            cp.CommandType = CommandType.Text;
            SqlDataAdapter da2 = new SqlDataAdapter();
            var ds2 = new DataSet();
            da2.SelectCommand = cp;
            da2.Fill(ds2);
            DataTable dtDatabases3 = ds2.Tables[0];
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                cb_produto.Items.Add(ds2.Tables[0].Rows[i][1].ToString());
                cn2.Close();
            }



        }

        private void cb_produto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            HabilitaCamposC();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DesabilitaCamposC();

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (cb_cliente.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Cliente. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_cliente.Focus();
            }
            else if (cb_vendedor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Vendedor. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_vendedor.Focus();
            }
          
            else
            {
                try
                {
                    string cliente = cb_cliente.Text;
                    string vendedor = cb_vendedor.Text;


                    string strSql = "insert into compra(cliente,vendedor)values(@cliente, @vendedor)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@cliente", System.Data.SqlDbType.VarChar).Value = cliente;
                    cm.Parameters.Add("@vendedor", System.Data.SqlDbType.VarChar).Value = vendedor;
            
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();

                   
                    MessageBox.Show("Os dados foram salvos com sucesso. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    cn.Close();
                }

                finally
                {
                    cn.Close();
                     
                }

            }
        }
    }
}
