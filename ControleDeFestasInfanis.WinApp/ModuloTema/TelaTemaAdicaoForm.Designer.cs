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
            cmbItensTema = new ComboBox();
            btnAdicionar = new Button();
            label3 = new Label();
            label4 = new Label();
            numQuantidadeItem = new NumericUpDown();
            panelItensTema = new Panel();
            ((System.ComponentModel.ISupportInitialize)numQuantidadeItem).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(321, 562);
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
            btnGravar.Location = new Point(206, 562);
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
            txtTema.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTema.Location = new Point(115, 53);
            txtTema.Name = "txtTema";
            txtTema.ReadOnly = true;
            txtTema.Size = new Size(300, 26);
            txtTema.TabIndex = 25;
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(115, 21);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(99, 26);
            txtId.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 56);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 23;
            label2.Text = "Tema:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 24);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 22;
            label1.Text = "Id:";
            // 
            // cmbItensTema
            // 
            cmbItensTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItensTema.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbItensTema.FormattingEnabled = true;
            cmbItensTema.Location = new Point(115, 86);
            cmbItensTema.Name = "cmbItensTema";
            cmbItensTema.Size = new Size(300, 28);
            cmbItensTema.TabIndex = 29;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(327, 120);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(88, 29);
            btnAdicionar.TabIndex = 28;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 89);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 27;
            label3.Text = "Item:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 124);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 30;
            label4.Text = "Quantidade:";
            // 
            // numQuantidadeItem
            // 
            numQuantidadeItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numQuantidadeItem.Location = new Point(115, 120);
            numQuantidadeItem.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numQuantidadeItem.Name = "numQuantidadeItem";
            numQuantidadeItem.Size = new Size(192, 29);
            numQuantidadeItem.TabIndex = 37;
            // 
            // panelItensTema
            // 
            panelItensTema.Location = new Point(115, 155);
            panelItensTema.Name = "panelItensTema";
            panelItensTema.Size = new Size(300, 361);
            panelItensTema.TabIndex = 38;
            // 
            // TelaTemaAdicaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 650);
            Controls.Add(panelItensTema);
            Controls.Add(numQuantidadeItem);
            Controls.Add(label4);
            Controls.Add(cmbItensTema);
            Controls.Add(btnAdicionar);
            Controls.Add(label3);
            Controls.Add(txtTema);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaTemaAdicaoForm";
            ShowIcon = false;
            Text = "Adição de Itens";
            ((System.ComponentModel.ISupportInitialize)numQuantidadeItem).EndInit();
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
        private Label label4;
        private NumericUpDown numQuantidadeItem;
        private DataGridView gridtensTema;
        private Panel panelItensTema;
    }
}