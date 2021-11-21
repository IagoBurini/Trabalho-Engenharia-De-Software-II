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

        private void DesabilitaCamposF()
        {
            txtNomeF.Enabled = false;
            txtTelefoneF.Enabled = false;
            txtCpfF.Enabled = false;
            txtEnderecoF.Enabled = false;
            editarFunc.Enabled = false;
            novoFunc.Enabled = false;
            removerFunc.Enabled = false;
            novoFunc.Enabled = true;
            cancelarFunc.Enabled = false;
            salvarFunc.Enabled = false;
        }

        private void HabilitaCamposF()
        {
            txtNomeF.Enabled = true;
            txtTelefoneF.Enabled = true;
            txtCpfF.Enabled = true;
            txtEnderecoF.Enabled = true;
            editarFunc.Enabled = true;
            novoFunc.Enabled = true;
            removerFunc.Enabled = true;
            novoFunc.Enabled = false;
            cancelarFunc.Enabled = true;
            salvarFunc.Enabled = true;
            txtNomeF.Focus();
            buscaF.Text = "";
            //dgvF.DataSource = null;
        }

        private void LimparCamposF()
        {
            txtNomeF.Clear();
            txtTelefoneF.Clear();
            txtCpfF.Clear();
            txtEnderecoF.Clear();
            txtNomeF.Focus();

        }

        private void manipularDadosF()
        {
            editarFunc.Enabled = true;
            cancelarFunc.Enabled = true;
            removerFunc.Enabled = true;
            novoFunc.Enabled = false;
            salvarFunc.Enabled = false;
            txtNomeF.Enabled = true;
            txtTelefoneF.Enabled = true;
            txtCpfF.Enabled = true;
            txtEnderecoF.Enabled = true;

        }





        private void funcionario_Load(object sender, EventArgs e)
        {
            DesabilitaCamposF();
            MostrarTodosFuncionarios();
        }

        private void MostrarTodosFuncionarios()
        {
            try
            {
                cn.Open();
                cm.CommandText = "select * from funcionarios";
                cm.Connection = cn;
                SqlDataAdapter da = new SqlDataAdapter();

                DataTable dt = new DataTable();

                da.SelectCommand = cm;
                da.Fill(dt);
                dgvF.DataSource = dt;
                cn.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void novoFunc_Click(object sender, EventArgs e)
        {
            HabilitaCamposF();
        }

        private void removerFunc_Click(object sender, EventArgs e)
        {
            if (txtNomeF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeF.Focus();
            }
            else if (txtEnderecoF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo endereço. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnderecoF.Focus();
            }
            else if (txtTelefoneF.Text.Length < 14)
            {
                MessageBox.Show("O número de Telefone está errado, Porfavor informar os 14 digitos. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefoneF.Focus();
            }
            else if (txtCpfF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CPF. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpfF.Focus();
            }
            else if (txtCpfF.Text.Length < 12)
            {
                MessageBox.Show("O CPF está errado, Porfavor informar os 12 digitos. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpfF.Focus();
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
                        string cpf = txtCpfF.Text;
                        cn.Open();
                        string strSql = "delete from funcionarios where cpf=@cpf";
                        cm.CommandText = strSql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar).Value = cpf;


                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        LimparCamposF();
                        MessageBox.Show("Os dados foram removidos com sucesso. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }
                    finally
                    {
                        cn.Close();
                        MostrarTodosFuncionarios();
                    }
                }
            }
        }



        private void editarFunc_Click(object sender, EventArgs e)
        {
            if (txtNomeF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeF.Focus();
            }
            else if (txtEnderecoF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo endereço. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnderecoF.Focus();
            }
            else if (txtTelefoneF.Text.Length < 14)
            {
                MessageBox.Show("O número de Telefone está errado, Porfavor informar os 14 digitos. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefoneF.Focus();
            }
            else if (txtCpfF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CPF. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpfF.Focus();
            }
            else if (txtCpfF.Text.Length < 12)
            {
                MessageBox.Show("O CPF está errado, Porfavor informar os 12 digitos. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpfF.Focus();
            }

            else
            {
                try
                {
                    string nome = txtNomeF.Text;
                    string telefone = txtTelefoneF.Text;
                    string cpf = txtCpfF.Text;
                    string endereco = txtEnderecoF.Text;


                    string strSql = "update funcionarios set nome=@nome, telefone=@telefone, cpf=@cpf, endereco=@endereco where cpf=@cpf ";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@telefone", System.Data.SqlDbType.VarChar).Value = telefone;
                    cm.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar).Value = cpf;
                    cm.Parameters.Add("@endereco", System.Data.SqlDbType.VarChar).Value = endereco;


                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    LimparCamposF();
                    MessageBox.Show("Os dados foram alterados com sucesso. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    cn.Close();
                }

                finally
                {
                    cn.Close();
                    MostrarTodosFuncionarios();
                }

            }
        }

        private void cancelarFunc_Click(object sender, EventArgs e)
        {
            DesabilitaCamposF();
            LimparCamposF();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNomeF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneF_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarFunc_Click(object sender, EventArgs e)
        {
            if (txtNomeF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeF.Focus();
            }
            else if (txtEnderecoF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo endereço. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnderecoF.Focus();
            }
            else if (txtTelefoneF.Text.Length < 14)
            {
                MessageBox.Show("O número de Telefone está errado, Porfavor informar os 14 digitos. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefoneF.Focus();
            }
            else if (txtCpfF.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CPF. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpfF.Focus();
            }
            else if (txtCpfF.Text.Length < 12)
            {
                MessageBox.Show("O CPF está errado, Porfavor informar os 12 digitos. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpfF.Focus();
            }

            else
            {
                try
                {
                    string nome = txtNomeF.Text;
                    string telefone = txtTelefoneF.Text;
                    string cpf = txtCpfF.Text;
                    string endereco = txtEnderecoF.Text;

                    string strSql = "insert into funcionarios(nome,telefone,cpf,endereco)values(@nome,@telefone,@cpf,@endereco)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@telefone", System.Data.SqlDbType.VarChar).Value = telefone;
                    cm.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar).Value = cpf;
                    cm.Parameters.Add("@endereco", System.Data.SqlDbType.VarChar).Value = endereco;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();

                    LimparCamposF();
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
                    MostrarTodosFuncionarios();
                }

            }
        }

        private void carregaFuncionario()
        {
            txtNomeF.Text = dgvF.SelectedRows[0].Cells[1].Value.ToString();
            txtEnderecoF.Text = dgvF.SelectedRows[0].Cells[4].Value.ToString();
            txtTelefoneF.Text = dgvF.SelectedRows[0].Cells[2].Value.ToString();
            txtCpfF.Text = dgvF.SelectedRows[0].Cells[3].Value.ToString();
            manipularDadosF();
        }
        private void dgvF_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaFuncionario();
        }

        private void buscaF_TextChanged(object sender, EventArgs e)
        {
            {
                if (buscaF.Text != "")
                {
                    try
                    {
                        cn.Open();
                        cm.CommandText = "select * from funcionarios where nome like ('%" + buscaF.Text + "%')";
                        cm.Connection = cn;

                        SqlDataAdapter da = new SqlDataAdapter();

                        DataTable dt = new DataTable();

                        da.SelectCommand = cm;
                        da.Fill(dt);
                        dgvF.DataSource = dt;
                        cn.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    MostrarTodosFuncionarios();
                }
            }
        }
    }
}

