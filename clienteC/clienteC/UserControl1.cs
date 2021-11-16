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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        //ESTABELECENDO CONEXAO COM O BANCO DE DADOS 

        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-89VMO42\SQLEXPRESS ;Database=trab ;User Id=sa ;Password = 12345; ");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;



        private void DesabilitaCampos()
        {
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            TxtCpf.Enabled = false;
            TxtEndereco.Enabled = false;
            btnEditar.Enabled = false;
            btnNovo.Enabled = false;
            btnRemover.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            TxtCpf.Enabled = true;
            TxtEndereco.Enabled = true;
            btnEditar.Enabled = true;
            btnNovo.Enabled = true;
            btnRemover.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            TxtCpf.Clear();
            TxtEndereco.Clear();
            txtNome.Focus();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            DesabilitaCampos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (TxtEndereco.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo endereço. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEndereco.Focus();
            }
            else if (txtTelefone.Text.Length < 14)
            {
                MessageBox.Show("O número de Telefone está errado, Porfavor informar os 14 digitos. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone.Focus();
            }
            else if (TxtCpf.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CPF. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCpf.Focus();
            }
            else if (TxtCpf.Text.Length < 12)
            {
                MessageBox.Show("O CPF está errado, Porfavor informar os 12 digitos. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCpf.Focus();
            }

            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string telefone = txtTelefone.Text;
                    string cpf = TxtCpf.Text;
                    string endereco = TxtEndereco.Text;

                    string strSql = "insert into cliente(nome,telefone,cpf,endereco)values(@nome,@telefone,@cpf,@endereco)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@telefone", System.Data.SqlDbType.VarChar).Value = telefone;
                    cm.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar).Value = cpf;
                    cm.Parameters.Add("@endereco", System.Data.SqlDbType.VarChar).Value = endereco;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    LimparCampos();
                    MessageBox.Show("Os Dados Foram gravados com sucesso. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtBusca.Text != "")
                {
                    try
                    {
                        cn.Open();
                        cm.CommandText = "select * from cliente where nome like ('%" + txtBusca.Text + "%')";
                        cm.Connection = cn;

                        SqlDataAdapter da = new SqlDataAdapter();

                        DataTable dt = new DataTable();

                        da.SelectCommand = cm;
                        da.Fill(dt);
                        DgvFunc.DataSource = dt;
                        cn.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    DgvFunc.DataSource = null;
                }
            }
        }
    }
}
