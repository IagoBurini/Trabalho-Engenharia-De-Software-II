﻿using System;
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

        //ESTABELECENDO CONEXAO COM O BANCO DE DADOS 

        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-6MFH4M9\SQLEXPRESS ;Database=trab ;User Id=sa ;Password = 12345; ");
        
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
            userControl11.UserControl1_Load(sender, e);
            userControl11.BringToFront();
            button1.BringToFront();
        }

        private void btnFechar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            funcionario1.funcionario_Load_1(sender, e);
            funcionario1.BringToFront();
            button1.BringToFront();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            userControl21.UserControl2_Load(sender, e);
            userControl21.BringToFront();
            button1.BringToFront();
        }

        public void btn_cadastrarCompra_Click(object sender, EventArgs e)
        {
            compra1.compra_Load(sender,e);
            compra1.BringToFront();
            button1.BringToFront();
        }
    }
}
