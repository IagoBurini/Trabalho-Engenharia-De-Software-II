using System;
using System.Windows;
using System.Windows.Controls;

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
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo numéro. ", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTelefone.Focus();
            }
            else if (TxtCpf.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CPF. ", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtCpf.Focus();
            }
            else if (TxtEndereco.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo endereço. ", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtEndereco.Focus();
            }
            else if (TxtCpf.Text.Length < 14)
            {
                MessageBox.Show("O CPF está errado, Porfavor informar os 14 digitos. ", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtCpf.Focus();
            }
            else if (txtTelefone.Text.Length < 14)
            {
                MessageBox.Show("O número de Telefone está errado, Porfavor informar os 14 digitos. ", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTelefone.Focus();
            }
        }
    }
}
