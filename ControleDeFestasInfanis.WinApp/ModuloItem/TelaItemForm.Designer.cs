namespace ControleDeFestasInfantis.WinApp.ModuloItem
{
    partial class TelaItemForm
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
            txtId = new TextBox();
            label1 = new Label();
            txtDescricao = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtValor = new TextBox();
            numQtdDisponivel = new NumericUpDown();
            numQtdLocada = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numQtdDisponivel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQtdLocada).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(605, 243);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 17;
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
            btnGravar.Location = new Point(490, 243);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(181, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(112, 29);
            txtId.TabIndex = 19;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 27);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 18;
            label1.Text = "Id:";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Location = new Point(181, 81);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(518, 29);
            txtDescricao.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(95, 81);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 20;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(432, 138);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 29;
            label3.Text = "Valor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 138);
            label6.Name = "label6";
            label6.Size = new Size(169, 21);
            label6.TabIndex = 32;
            label6.Text = "Quantidade disponível:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 196);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 34;
            label4.Text = "Quantidade locada:";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(490, 138);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(209, 29);
            txtValor.TabIndex = 35;
            txtValor.Text = "0.00";
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // numQtdDisponivel
            // 
            numQtdDisponivel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numQtdDisponivel.Location = new Point(181, 136);
            numQtdDisponivel.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numQtdDisponivel.Name = "numQtdDisponivel";
            numQtdDisponivel.Size = new Size(209, 29);
            numQtdDisponivel.TabIndex = 36;
            // 
            // numQtdLocada
            // 
            numQtdLocada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numQtdLocada.Location = new Point(181, 194);
            numQtdLocada.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numQtdLocada.Name = "numQtdLocada";
            numQtdLocada.Size = new Size(209, 29);
            numQtdLocada.TabIndex = 37;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 313);
            Controls.Add(numQtdLocada);
            Controls.Add(numQtdDisponivel);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            MaximumSize = new Size(850, 550);
            Name = "TelaItemForm";
            ShowIcon = false;
            Text = "Cadastro De Itens";
            ((System.ComponentModel.ISupportInitialize)numQtdDisponivel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQtdLocada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtId;
        private Label label1;
        private TextBox txtDescricao;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox txtQtdDisponivel;
        private Label label4;
        private TextBox txtQtdLocada;
        private TextBox txtValor;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numQtdDisponivel;
        private NumericUpDown numQtdLocada;
    }
}