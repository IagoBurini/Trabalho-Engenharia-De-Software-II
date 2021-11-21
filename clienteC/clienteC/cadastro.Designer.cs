
namespace clienteC
{
    partial class cadastro
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.funcionario1 = new clienteC.funcionario();
            this.userControl11 = new clienteC.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.btnFechar.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 110);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cadastrar Funcionário";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(0, 100);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(200, 110);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cadastrar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.Controls.Add(this.funcionario1);
            this.btnFechar.Controls.Add(this.userControl11);
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFechar.Location = new System.Drawing.Point(200, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(800, 600);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnFechar_Paint);
            // 
            // funcionario1
            // 
            this.funcionario1.BackColor = System.Drawing.Color.White;
            this.funcionario1.Location = new System.Drawing.Point(0, 0);
            this.funcionario1.Name = "funcionario1";
            this.funcionario1.Size = new System.Drawing.Size(800, 600);
            this.funcionario1.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(800, 600);
            this.userControl11.TabIndex = 1;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cadastro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.btnFechar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnFechar;
        private System.Windows.Forms.Button btnCliente;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button button2;
        private funcionario funcionario1;
    }
}

