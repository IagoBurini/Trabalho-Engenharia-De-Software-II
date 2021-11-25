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

        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-89VMO42\SQLEXPRESS;Database=trab ;User Id=sa ;Password = 12345; ");
        SqlConnection cn1 = new SqlConnection(@"Server=DESKTOP-89VMO42\SQLEXPRESS;Database=trab ;User Id=sa ;Password = 12345; ");
        SqlConnection cn2 = new SqlConnection(@"Server=DESKTOP-89VMO42\SQLEXPRESS;Database=trab ;User Id=sa ;Password = 12345; ");
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

        private void CarregarIdcliente() { 
          
        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void MostrarTodasCompras()
        {
            try
            {
                cn.Open();
                cm.CommandText = "select * from compra";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter();

                DataTable dt = new DataTable();

                da.SelectCommand = cm;
                da.Fill(dt);
                dgv_compras.DataSource = dt;
                cn.Close();
                //DgvFunc.DataSource = null;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


       

        private void preencherCBCliente()
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
        }

        private void textboxClienteID()
        {
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
                if (cb_cliente.Text == ds.Tables[0].Rows[i][1].ToString())
                {
                    txt_idcliente.Text = ds.Tables[0].Rows[i][0].ToString();
                }
                cn.Close();
            }
        }

        private void LimparCamposCompras()
        {
            cb_cliente.Text = "";
            cb_vendedor.Text = "";
            txt_idcliente.Clear();
            txt_idvendedor.Clear();
        }


        private void preencherCBFuncionario()
        {
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
        }

        private void textboxFuncionarioID()
        {
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
                if (cb_vendedor.Text == ds1.Tables[0].Rows[i][1].ToString())
                {
                    txt_idvendedor.Text = ds1.Tables[0].Rows[i][0].ToString();
                }
                cn.Close();
            }
        }

        private void preencherCBProduto()
        {
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

        private void textboxProdutoID()
        {
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
                if (cb_produto.Text == ds2.Tables[0].Rows[i][1].ToString())
                {
                    txt_produtoID.Text = ds2.Tables[0].Rows[i][0].ToString();
                }
                cn2.Close();
            }
        }

        private void compra_Load(object sender, EventArgs e)
        {
            preencherCBProduto();
            preencherCBFuncionario();
            preencherCBCliente();
            DesabilitaCamposC();
            MostrarTodasCompras();

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
                    string cliente = txt_idcliente.Text;
                    string funcionarios = txt_idvendedor.Text;


                    string strSql = "insert into compra(idcliente,idfuncionarios)values(@cliente, @funcionarios)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@cliente", System.Data.SqlDbType.Int).Value = cliente;
                    cm.Parameters.Add("@funcionarios", System.Data.SqlDbType.Int).Value = funcionarios;

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
                    MostrarTodasCompras();
                }

            }
        }

        private void txt_idcliente_TextChanged(object sender, EventArgs e)
        {
            //txt_idcliente.Text = (ds.Tables[0].Rows[i][0].ToString());
        }

        private void dgv_idcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_cliente_Click(object sender, EventArgs e)
        {
        }

        private void cb_cliente_TextChanged(object sender, EventArgs e)
        {
            textboxClienteID();
        }

        private void cb_vendedor_TextChanged(object sender, EventArgs e)
        {
            textboxFuncionarioID();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cb_produto_TextChanged(object sender, EventArgs e)
        {
            textboxProdutoID();
        }

        private void btn_remover_Click(object sender, EventArgs e)
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
                DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover esse registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }

                else
                {
                    try
                    {
                        string id = dgv_compras.SelectedRows[0].Cells[0].Value.ToString();
                        cn.Open();
                        string strSql = "delete from compra where id=@id";
                        cm.CommandText = strSql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;


                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        LimparCamposCompras();
                        MessageBox.Show("Os dados foram removidos com sucesso. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                        cn.Close();
                    }

                    finally
                    {
                        cn.Close();
                        MostrarTodasCompras();
                    }

                }
            }
        }

        private void dgv_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carregaCompra()
        {
            txt_idvendedor.Text = dgv_compras.SelectedRows[0].Cells[1].Value.ToString();
            txt_idcliente.Text = dgv_compras.SelectedRows[0].Cells[2].Value.ToString();

            /* //Cliente LOGICA PARA MOSTRAR O NOME DO CLIENTE ATRAVES DO ID DELE
            if (txt_idcliente.Text == dgv_compras.SelectedRows[0].Cells[2].Value.ToString())
            {
                cn.Open();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from cliente";
                SqlDataAdapter da = new SqlDataAdapter();

                var ds = new DataSet();

                da.SelectCommand = cm;
                da.Fill(ds);
                DataTable dtDatabases = ds.Tables[0];
                if (txt_idcliente.Text == dgv_compras.SelectedRows[0].Cells[2].Value.ToString())
                {
                        cb_cliente.Text = ds.Tables[0].Rows[0][1].ToString();
                }
                cn.Close();
            }
            //manipularDados(); */
        }
        private void dgv_compras_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaCompra();
        }
    }
}
