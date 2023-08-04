
namespace Aplicação_11_04_as_1_29
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenudasBarras = new System.Windows.Forms.MenuStrip();
            this.Cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.PessoaJuridica = new System.Windows.Forms.ToolStripMenuItem();
            this.PessoaFisica = new System.Windows.Forms.ToolStripMenuItem();
            this.Fornecimento = new System.Windows.Forms.ToolStripMenuItem();
            this.Colaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.Produto = new System.Windows.Forms.ToolStripMenuItem();
            this.Separador = new System.Windows.Forms.ToolStripSeparator();
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Fornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.Funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.Produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.Ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.Ajuda2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.MenudasBarras.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenudasBarras
            // 
            this.MenudasBarras.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenudasBarras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastrar,
            this.Consultar,
            this.toolStripTextBox1,
            this.toolStripComboBox1,
            this.Ajuda});
            this.MenudasBarras.Location = new System.Drawing.Point(0, 0);
            this.MenudasBarras.Name = "MenudasBarras";
            this.MenudasBarras.Size = new System.Drawing.Size(800, 27);
            this.MenudasBarras.TabIndex = 0;
            this.MenudasBarras.Tag = "";
            this.MenudasBarras.Text = "Menu das barras";
            this.MenudasBarras.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenudasBarras_ItemClicked);
            // 
            // Cadastrar
            // 
            this.Cadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clientes,
            this.Fornecimento,
            this.Colaboradores,
            this.Produto,
            this.Separador,
            this.Sair});
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(69, 23);
            this.Cadastrar.Text = "Cadastrar";
            // 
            // Clientes
            // 
            this.Clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PessoaJuridica,
            this.PessoaFisica});
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(145, 22);
            this.Clientes.Text = "Clientes";
            // 
            // PessoaJuridica
            // 
            this.PessoaJuridica.Name = "PessoaJuridica";
            this.PessoaJuridica.Size = new System.Drawing.Size(153, 22);
            this.PessoaJuridica.Text = "Pessoa Juridica";
            // 
            // PessoaFisica
            // 
            this.PessoaFisica.Name = "PessoaFisica";
            this.PessoaFisica.Size = new System.Drawing.Size(153, 22);
            this.PessoaFisica.Text = "Pessoa Fisica";
            // 
            // Fornecimento
            // 
            this.Fornecimento.Name = "Fornecimento";
            this.Fornecimento.Size = new System.Drawing.Size(145, 22);
            this.Fornecimento.Text = "Fornecedores";
            // 
            // Colaboradores
            // 
            this.Colaboradores.Name = "Colaboradores";
            this.Colaboradores.Size = new System.Drawing.Size(145, 22);
            this.Colaboradores.Text = "Funcionarios";
            // 
            // Produto
            // 
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(145, 22);
            this.Produto.Text = "Produtos";
            // 
            // Separador
            // 
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(142, 6);
            // 
            // Sair
            // 
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(145, 22);
            this.Sair.Text = "Sair";
            // 
            // Consultar
            // 
            this.Consultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cliente,
            this.Fornecedor,
            this.Funcionario,
            this.Produtos});
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(70, 23);
            this.Consultar.Text = "Consultar";
            // 
            // Cliente
            // 
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(137, 22);
            this.Cliente.Text = "Cliente";
            // 
            // Fornecedor
            // 
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(137, 22);
            this.Fornecedor.Text = "Fornecedor";
            // 
            // Funcionario
            // 
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.Size = new System.Drawing.Size(137, 22);
            this.Funcionario.Text = "Funcionario";
            // 
            // Produtos
            // 
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(137, 22);
            this.Produtos.Text = "Produtos";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // Ajuda
            // 
            this.Ajuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ajuda2,
            this.toolStripSeparator1,
            this.Sobre});
            this.Ajuda.Name = "Ajuda";
            this.Ajuda.Size = new System.Drawing.Size(50, 23);
            this.Ajuda.Text = "Ajuda";
            // 
            // Ajuda2
            // 
            this.Ajuda2.Name = "Ajuda2";
            this.Ajuda2.Size = new System.Drawing.Size(113, 22);
            this.Ajuda2.Text = "Ajuda";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // Sobre
            // 
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(113, 22);
            this.Sobre.Text = "Sobre...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenudasBarras);
            this.MainMenuStrip = this.MenudasBarras;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenudasBarras.ResumeLayout(false);
            this.MenudasBarras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenudasBarras;
        private System.Windows.Forms.ToolStripMenuItem Cadastrar;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem PessoaJuridica;
        private System.Windows.Forms.ToolStripMenuItem PessoaFisica;
        private System.Windows.Forms.ToolStripMenuItem Fornecimento;
        private System.Windows.Forms.ToolStripMenuItem Colaboradores;
        private System.Windows.Forms.ToolStripMenuItem Produto;
        private System.Windows.Forms.ToolStripMenuItem Sair;
        private System.Windows.Forms.ToolStripSeparator Separador;
        private System.Windows.Forms.ToolStripMenuItem Consultar;
        private System.Windows.Forms.ToolStripMenuItem Cliente;
        private System.Windows.Forms.ToolStripMenuItem Fornecedor;
        private System.Windows.Forms.ToolStripMenuItem Funcionario;
        private System.Windows.Forms.ToolStripMenuItem Produtos;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem Ajuda;
        private System.Windows.Forms.ToolStripMenuItem Ajuda2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Sobre;
    }
}

