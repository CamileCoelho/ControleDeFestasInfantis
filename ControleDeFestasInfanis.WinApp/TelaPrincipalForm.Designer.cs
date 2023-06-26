namespace ControleDeFestasInfantis.WinApp
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            clientesMenuItem = new ToolStripMenuItem();
            festasToolStripMenuItem = new ToolStripMenuItem();
            alugueisMenuItem = new ToolStripMenuItem();
            itensParaLocaçãoMenuItem = new ToolStripMenuItem();
            temasMenuItem = new ToolStripMenuItem();
            rodape = new StatusStrip();
            lableRodape = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAdicionarItens = new ToolStripButton();
            btnRemoverItens = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnFinalizarPgto = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnConfigDesconto = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnVisualizar = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            btnHome = new ToolStripButton();
            labelTipoDoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            rodape.SuspendLayout();
            toolStrip1.SuspendLayout();
            panelRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem, festasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMenuItem });
            cadastrosMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(71, 20);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // clientesMenuItem
            // 
            clientesMenuItem.Image = (Image)resources.GetObject("clientesMenuItem.Image");
            clientesMenuItem.Name = "clientesMenuItem";
            clientesMenuItem.Size = new Size(116, 22);
            clientesMenuItem.Text = "Clientes";
            clientesMenuItem.Click += contatosMenuItem_Click;
            // 
            // festasToolStripMenuItem
            // 
            festasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alugueisMenuItem, itensParaLocaçãoMenuItem, temasMenuItem });
            festasToolStripMenuItem.Name = "festasToolStripMenuItem";
            festasToolStripMenuItem.Size = new Size(51, 20);
            festasToolStripMenuItem.Text = "Festas";
            // 
            // alugueisMenuItem
            // 
            alugueisMenuItem.Image = (Image)resources.GetObject("alugueisMenuItem.Image");
            alugueisMenuItem.Name = "alugueisMenuItem";
            alugueisMenuItem.Size = new Size(169, 22);
            alugueisMenuItem.Text = "Alugueis";
            alugueisMenuItem.Click += alugueisMenuItem_Click;
            // 
            // itensParaLocaçãoMenuItem
            // 
            itensParaLocaçãoMenuItem.Image = (Image)resources.GetObject("itensParaLocaçãoMenuItem.Image");
            itensParaLocaçãoMenuItem.Name = "itensParaLocaçãoMenuItem";
            itensParaLocaçãoMenuItem.Size = new Size(169, 22);
            itensParaLocaçãoMenuItem.Text = "Itens para locação";
            itensParaLocaçãoMenuItem.Click += itensParaLocaçãoMenuItem_Click;
            // 
            // temasMenuItem
            // 
            temasMenuItem.Image = (Image)resources.GetObject("temasMenuItem.Image");
            temasMenuItem.Name = "temasMenuItem";
            temasMenuItem.Size = new Size(169, 22);
            temasMenuItem.Text = "Temas";
            temasMenuItem.Click += temasMenuItem_Click;
            // 
            // rodape
            // 
            rodape.Items.AddRange(new ToolStripItem[] { lableRodape });
            rodape.Location = new Point(0, 635);
            rodape.Name = "rodape";
            rodape.Size = new Size(1184, 26);
            rodape.TabIndex = 1;
            rodape.Text = "statusStrip1";
            // 
            // lableRodape
            // 
            lableRodape.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lableRodape.Name = "lableRodape";
            lableRodape.Size = new Size(50, 21);
            lableRodape.Text = "          ";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator2, btnAdicionarItens, btnRemoverItens, toolStripSeparator3, btnFinalizarPgto, toolStripSeparator4, btnConfigDesconto, toolStripSeparator5, btnVisualizar, toolStripSeparator6, btnHome, labelTipoDoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1184, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled = false;
            btnInserir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInserir.Image = (Image)resources.GetObject("btnInserir.Image");
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(6);
            btnInserir.Size = new Size(32, 32);
            btnInserir.Text = "Inserir";
            btnInserir.Visible = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(6);
            btnEditar.Size = new Size(32, 32);
            btnEditar.Text = "Editar";
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(6);
            btnExcluir.Size = new Size(32, 32);
            btnExcluir.Text = "Excluir";
            btnExcluir.Visible = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            toolStripSeparator1.Visible = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled = false;
            btnFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(6);
            btnFiltrar.Size = new Size(32, 32);
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Visible = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            toolStripSeparator2.Visible = false;
            // 
            // btnAdicionarItens
            // 
            btnAdicionarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItens.Enabled = false;
            btnAdicionarItens.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionarItens.Image = (Image)resources.GetObject("btnAdicionarItens.Image");
            btnAdicionarItens.ImageTransparentColor = Color.Magenta;
            btnAdicionarItens.Name = "btnAdicionarItens";
            btnAdicionarItens.Padding = new Padding(6);
            btnAdicionarItens.Size = new Size(32, 32);
            btnAdicionarItens.Visible = false;
            btnAdicionarItens.Click += btnAdicionarItens_Click;
            // 
            // btnRemoverItens
            // 
            btnRemoverItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRemoverItens.Enabled = false;
            btnRemoverItens.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverItens.Image = (Image)resources.GetObject("btnRemoverItens.Image");
            btnRemoverItens.ImageTransparentColor = Color.Magenta;
            btnRemoverItens.Name = "btnRemoverItens";
            btnRemoverItens.Padding = new Padding(6);
            btnRemoverItens.Size = new Size(32, 32);
            btnRemoverItens.Visible = false;
            btnRemoverItens.Click += btnConcluirItens_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 35);
            toolStripSeparator3.Visible = false;
            // 
            // btnFinalizarPgto
            // 
            btnFinalizarPgto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFinalizarPgto.Enabled = false;
            btnFinalizarPgto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizarPgto.Image = (Image)resources.GetObject("btnFinalizarPgto.Image");
            btnFinalizarPgto.ImageTransparentColor = Color.Magenta;
            btnFinalizarPgto.Name = "btnFinalizarPgto";
            btnFinalizarPgto.Padding = new Padding(6);
            btnFinalizarPgto.Size = new Size(32, 32);
            btnFinalizarPgto.Visible = false;
            btnFinalizarPgto.Click += btnFinalizarPgto_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 35);
            toolStripSeparator4.Visible = false;
            // 
            // btnConfigDesconto
            // 
            btnConfigDesconto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConfigDesconto.Enabled = false;
            btnConfigDesconto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfigDesconto.Image = (Image)resources.GetObject("btnConfigDesconto.Image");
            btnConfigDesconto.ImageTransparentColor = Color.Magenta;
            btnConfigDesconto.Name = "btnConfigDesconto";
            btnConfigDesconto.Padding = new Padding(6);
            btnConfigDesconto.Size = new Size(32, 32);
            btnConfigDesconto.Visible = false;
            btnConfigDesconto.Click += btnConfigDesconto_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 35);
            toolStripSeparator5.Visible = false;
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Enabled = false;
            btnVisualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVisualizar.Image = (Image)resources.GetObject("btnVisualizar.Image");
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(6);
            btnVisualizar.Size = new Size(32, 32);
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.Visible = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            toolStripSeparator6.Visible = false;
            // 
            // btnHome
            // 
            btnHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageTransparentColor = Color.Magenta;
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(23, 22);
            btnHome.Text = "Home";
            btnHome.Click += btnHome_Click;
            // 
            // labelTipoDoCadastro
            // 
            labelTipoDoCadastro.Name = "labelTipoDoCadastro";
            labelTipoDoCadastro.Size = new Size(76, 22);
            labelTipoDoCadastro.Text = "                       ";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Controls.Add(pictureBox1);
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 49);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1184, 586);
            panelRegistros.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1184, 586);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(rodape);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1200, 700);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(1200, 700);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festas Infantis ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            rodape.ResumeLayout(false);
            rodape.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem clientesMenuItem;
        private StatusStrip rodape;
        private ToolStripStatusLabel lableRodape;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel labelTipoDoCadastro;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAdicionarItens;
        private ToolStripButton btnRemoverItens;
        private ToolStripMenuItem festasToolStripMenuItem;
        private ToolStripMenuItem alugueisMenuItem;
        private ToolStripMenuItem itensParaLocaçãoMenuItem;
        private ToolStripMenuItem temasMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnConfigDesconto;
        private ToolStripButton btnFinalizarPgto;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnVisualizar;
        private ToolStripSeparator toolStripSeparator6;
        private PictureBox pictureBox1;
        private ToolStripButton btnHome;
    }
}