namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    partial class TelaFestaPagamentoForm
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
            cmbPagamento = new ComboBox();
            lbPagamento = new Label();
            lbValor = new Label();
            txtValorRest = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtValorEnt = new TextBox();
            txtValorTotal = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // cmbPagamento
            // 
            cmbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagamento.FormattingEnabled = true;
            cmbPagamento.Location = new Point(195, 143);
            cmbPagamento.Name = "cmbPagamento";
            cmbPagamento.Size = new Size(378, 24);
            cmbPagamento.TabIndex = 35;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbPagamento.Location = new Point(41, 143);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(140, 16);
            lbPagamento.TabIndex = 34;
            lbPagamento.Text = "Forma de pagamento:";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbValor.Location = new Point(355, 92);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(74, 16);
            lbValor.TabIndex = 32;
            lbValor.Text = "Valor Final:";
            // 
            // txtValorRest
            // 
            txtValorRest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorRest.Location = new Point(452, 85);
            txtValorRest.Name = "txtValorRest";
            txtValorRest.Size = new Size(121, 29);
            txtValorRest.TabIndex = 38;
            txtValorRest.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(337, 38);
            label3.Name = "label3";
            label3.Size = new Size(92, 16);
            label3.TabIndex = 39;
            label3.Text = "Valor Entrada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 92);
            label4.Name = "label4";
            label4.Size = new Size(76, 16);
            label4.TabIndex = 40;
            label4.Text = "Valor Total:";
            // 
            // txtValorEnt
            // 
            txtValorEnt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorEnt.Location = new Point(452, 31);
            txtValorEnt.Name = "txtValorEnt";
            txtValorEnt.Size = new Size(121, 29);
            txtValorEnt.TabIndex = 41;
            txtValorEnt.Text = "0.00";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(195, 85);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(121, 29);
            txtValorTotal.TabIndex = 42;
            txtValorTotal.Text = "0.00";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(479, 204);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.BottomRight;
            btnGravar.Location = new Point(364, 204);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 45;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(123, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 47;
            label1.Text = "Cliente:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(195, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 29);
            textBox1.TabIndex = 48;
            // 
            // TelaFestaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 279);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtValorTotal);
            Controls.Add(txtValorEnt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtValorRest);
            Controls.Add(cmbPagamento);
            Controls.Add(lbPagamento);
            Controls.Add(lbValor);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "TelaFestaPagamentoForm";
            Text = "TelaFestaPagamentoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbPagamento;
        private Label lbPagamento;
        private Label lbValor;
        private TextBox txtValorRest;
        private Label label3;
        private Label label4;
        private TextBox txtValorEnt;
        private TextBox txtValorTotal;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label1;
        private TextBox textBox1;
    }
}