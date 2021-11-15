using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace clienteC
{
    /// <summary>
    /// Interação lógica para frmFuncionario.xam
    /// </summary>
    public partial class frmFuncionario : UserControl
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        //ESTABELECENDO CONEXAO COM O BANCO DE DADOS 

        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-6MFH4M9\SQLEXPRESS ;Database=trab ;User Id=sa ;Password = 12345; ");

        SqlDataReader dt;



        private void DesabilitaCampos()
        {
            txtNome.IsEnabled = false;
            txtTelefone.IsEnabled = false;
            TxtCpf.IsEnabled = false;
            TxtEndereco.IsEnabled = false;
            btnEditar.IsEnabled = false;
            btnNovo.IsEnabled = false;
            btnRemover.IsEnabled = false;
            btnNovo.IsEnabled = true;
            btnCancelar.IsEnabled = false;
            btnSalvar.IsEnabled = false;
        }

        private void HabilitaCampos()
        {
            txtNome.IsEnabled = true;
            txtTelefone.IsEnabled = true;
            TxtCpf.IsEnabled = true;
            TxtEndereco.IsEnabled = true;
            btnEditar.IsEnabled = true;
            btnNovo.IsEnabled = true;
            btnRemover.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            btnSalvar.IsEnabled = true;
            btnNovo.IsEnabled = false;
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HabilitaCampos();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DesabilitaCampos();
            LimparCampos();
        }

        private void frmFuncionario_load(object sender, EventArgs e)
        {
            DesabilitaCampos();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome. ", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                txtNome.Focus();
            }
            else if (TxtEndereco.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo endereço. ", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtEndereco.Focus();
            }
            else if (txtTelefone.Text.Length < 14)
            {
                MessageBox.Show("O número de Telefone está errado, Porfavor informar os 14 digitos. ", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTelefone.Focus();
            }

            else if (TxtCpf.Text.Length < 12)
            {
                MessageBox.Show("O CPF está errado, Porfavor informar os 12 digitos. ", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
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

                    string sql = "insert into cliente(nome,endereco,telefone,cpf)values(@nome,@endereco,@telefone,@cpf)";

                    SqlCommand cm = new SqlCommand(sql, cn);
                    cm.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@endereco", System.Data.SqlDbType.VarChar).Value = endereco;
                    cm.Parameters.Add("@telefone", System.Data.SqlDbType.VarChar).Value = telefone;
                    cm.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar).Value = cpf;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    LimparCampos();
                    MessageBox.Show("Os Dados Foram gravados com sucesso. ", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
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
