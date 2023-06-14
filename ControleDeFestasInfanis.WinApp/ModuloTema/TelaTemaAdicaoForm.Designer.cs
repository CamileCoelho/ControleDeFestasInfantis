namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    partial class TelaTemaAdicaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new Button();
            btnGravar = new Button();
            txtTema = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listItensTema = new ListBox();
            cmbItensTema = new ComboBox();
            btnAdicionar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(292, 462);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.BottomRight;
            btnGravar.Location = new Point(177, 462);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(86, 54);
            txtTema.Name = "txtTema";
            txtTema.ReadOnly = true;
            txtTema.Size = new Size(300, 23);
            txtTema.TabIndex = 25;
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(99, 23);
            txtId.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 23;
            label2.Text = "Tema:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 28);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 22;
            label1.Text = "Id:";
            // 
            // listItensTema
            // 
            listItensTema.FormattingEnabled = true;
            listItensTema.ItemHeight = 15;
            listItensTema.Location = new Point(86, 132);
            listItensTema.Name = "listItensTema";
            listItensTema.Size = new Size(300, 289);
            listItensTema.TabIndex = 26;
            // 
            // cmbItensTema
            // 
            cmbItensTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItensTema.FormattingEnabled = true;
            cmbItensTema.Location = new Point(86, 84);
            cmbItensTema.Name = "cmbItensTema";
            cmbItensTema.Size = new Size(219, 23);
            cmbItensTema.TabIndex = 29;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(311, 83);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 28;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 89);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 27;
            label3.Text = "Item:";
            // 
            // TelaTemaAdicaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 531);
            Controls.Add(cmbItensTema);
            Controls.Add(btnAdicionar);
            Controls.Add(label3);
            Controls.Add(listItensTema);
            Controls.Add(txtTema);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaTemaAdicaoForm";
            ShowIcon = false;
            Text = "Adição de Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtTema;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private ListBox listItensTema;
        private ComboBox cmbItensTema;
        private Button btnAdicionar;
        private Label label3;
    }
}