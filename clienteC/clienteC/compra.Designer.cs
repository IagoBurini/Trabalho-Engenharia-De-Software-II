
namespace clienteC
{
    partial class compra
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.cb_vendedor = new System.Windows.Forms.ComboBox();
            this.dgv_carrinho = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_valortotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.NumericUpDown();
            this.cb_produto = new System.Windows.Forms.ComboBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cb_dinheiro = new System.Windows.Forms.CheckBox();
            this.cb_cartao = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_pacelas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.dgv_compras = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_removerProduto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrinho)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 36F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(289, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 65);
            this.label4.TabIndex = 4;
            this.label4.Text = "Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(261, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendedor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carrinho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(289, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(250, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantidade:";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(336, 490);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(100, 30);
            this.btn_adicionar.TabIndex = 6;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(635, 168);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 30);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(635, 221);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(100, 30);
            this.btn_remover.TabIndex = 8;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            // 
            // cb_cliente
            // 
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(373, 140);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(188, 21);
            this.cb_cliente.TabIndex = 9;
            this.cb_cliente.SelectedIndexChanged += new System.EventHandler(this.cb_cliente_SelectedIndexChanged);
            // 
            // cb_vendedor
            // 
            this.cb_vendedor.FormattingEnabled = true;
            this.cb_vendedor.Location = new System.Drawing.Point(373, 208);
            this.cb_vendedor.Name = "cb_vendedor";
            this.cb_vendedor.Size = new System.Drawing.Size(188, 21);
            this.cb_vendedor.TabIndex = 10;
            this.cb_vendedor.SelectedIndexChanged += new System.EventHandler(this.cb_vendedor_SelectedIndexChanged);
            // 
            // dgv_carrinho
            // 
            this.dgv_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carrinho.Location = new System.Drawing.Point(25, 352);
            this.dgv_carrinho.Name = "dgv_carrinho";
            this.dgv_carrinho.Size = new System.Drawing.Size(215, 231);
            this.dgv_carrinho.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 35);
            this.panel2.TabIndex = 12;
            // 
            // txt_valortotal
            // 
            this.txt_valortotal.Location = new System.Drawing.Point(617, 486);
            this.txt_valortotal.Name = "txt_valortotal";
            this.txt_valortotal.ReadOnly = true;
            this.txt_valortotal.Size = new System.Drawing.Size(165, 20);
            this.txt_valortotal.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(275, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label7.Location = new System.Drawing.Point(553, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valor Total:";
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(350, 464);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(188, 20);
            this.txt_qtd.TabIndex = 17;
            // 
            // cb_produto
            // 
            this.cb_produto.FormattingEnabled = true;
            this.cb_produto.Location = new System.Drawing.Point(350, 422);
            this.cb_produto.Name = "cb_produto";
            this.cb_produto.Size = new System.Drawing.Size(189, 21);
            this.cb_produto.TabIndex = 18;
            this.cb_produto.SelectedIndexChanged += new System.EventHandler(this.cb_produto_SelectedIndexChanged);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(635, 115);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 30);
            this.btn_novo.TabIndex = 19;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(632, 271);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 30);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cb_dinheiro
            // 
            this.cb_dinheiro.AutoSize = true;
            this.cb_dinheiro.Location = new System.Drawing.Point(635, 423);
            this.cb_dinheiro.Name = "cb_dinheiro";
            this.cb_dinheiro.Size = new System.Drawing.Size(65, 17);
            this.cb_dinheiro.TabIndex = 21;
            this.cb_dinheiro.Text = "Dinheiro";
            this.cb_dinheiro.UseVisualStyleBackColor = true;
            // 
            // cb_cartao
            // 
            this.cb_cartao.AutoSize = true;
            this.cb_cartao.Location = new System.Drawing.Point(715, 423);
            this.cb_cartao.Name = "cb_cartao";
            this.cb_cartao.Size = new System.Drawing.Size(57, 17);
            this.cb_cartao.TabIndex = 23;
            this.cb_cartao.Text = "Cartão";
            this.cb_cartao.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label8.Location = new System.Drawing.Point(632, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Forma De Pagamento";
            // 
            // cb_pacelas
            // 
            this.cb_pacelas.FormattingEnabled = true;
            this.cb_pacelas.Location = new System.Drawing.Point(617, 450);
            this.cb_pacelas.Name = "cb_pacelas";
            this.cb_pacelas.Size = new System.Drawing.Size(165, 21);
            this.cb_pacelas.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label9.Location = new System.Drawing.Point(564, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Parcelas:";
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(654, 512);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(95, 23);
            this.btn_pagar.TabIndex = 27;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(373, 271);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(100, 30);
            this.btn_cadastrar.TabIndex = 28;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // dgv_compras
            // 
            this.dgv_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compras.Location = new System.Drawing.Point(25, 147);
            this.dgv_compras.Name = "dgv_compras";
            this.dgv_compras.Size = new System.Drawing.Size(215, 154);
            this.dgv_compras.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Pesquisar Compra:";
            // 
            // btn_removerProduto
            // 
            this.btn_removerProduto.Location = new System.Drawing.Point(442, 490);
            this.btn_removerProduto.Name = "btn_removerProduto";
            this.btn_removerProduto.Size = new System.Drawing.Size(100, 30);
            this.btn_removerProduto.TabIndex = 33;
            this.btn_removerProduto.Text = "Remover";
            this.btn_removerProduto.UseVisualStyleBackColor = true;
            // 
            // compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_removerProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_compras);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_pacelas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_cartao);
            this.Controls.Add(this.cb_dinheiro);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.cb_produto);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_valortotal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_carrinho);
            this.Controls.Add(this.cb_vendedor);
            this.Controls.Add(this.cb_cliente);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "compra";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.compra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrinho)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.ComboBox cb_vendedor;
        private System.Windows.Forms.DataGridView dgv_carrinho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_valortotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txt_qtd;
        private System.Windows.Forms.ComboBox cb_produto;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox cb_dinheiro;
        private System.Windows.Forms.CheckBox cb_cartao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_pacelas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.DataGridView dgv_compras;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_removerProduto;
    }
}
