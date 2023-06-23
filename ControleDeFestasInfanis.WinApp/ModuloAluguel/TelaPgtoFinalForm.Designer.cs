namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaPgtoFinalForm
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
            txtValorFinal = new TextBox();
            lbValor = new Label();
            txtCliente = new TextBox();
            label1 = new Label();
            txtValorTotal = new TextBox();
            label4 = new Label();
            cmbPagamento = new ComboBox();
            lbPagamento = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // txtValorFinal
            // 
            txtValorFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorFinal.Location = new Point(231, 142);
            txtValorFinal.Name = "txtValorFinal";
            txtValorFinal.ReadOnly = true;
            txtValorFinal.Size = new Size(229, 29);
            txtValorFinal.TabIndex = 51;
            txtValorFinal.Text = "0.00";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbValor.Location = new Point(83, 145);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(125, 21);
            lbValor.TabIndex = 50;
            lbValor.Text = "Valor a ser pago:";
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.Location = new Point(231, 30);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(229, 29);
            txtCliente.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(147, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 57;
            label1.Text = "Cliente:";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(231, 84);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(229, 29);
            txtValorTotal.TabIndex = 56;
            txtValorTotal.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(123, 92);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 55;
            label4.Text = "Valor Total:";
            // 
            // cmbPagamento
            // 
            cmbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPagamento.FormattingEnabled = true;
            cmbPagamento.Location = new Point(231, 198);
            cmbPagamento.Name = "cmbPagamento";
            cmbPagamento.Size = new Size(229, 29);
            cmbPagamento.TabIndex = 53;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPagamento.Location = new Point(46, 198);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(162, 21);
            lbPagamento.TabIndex = 52;
            lbPagamento.Text = "Forma de pagamento:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(366, 276);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 60;
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
            btnGravar.Location = new Point(251, 276);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 59;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaPgtoFinalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 361);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Controls.Add(txtValorTotal);
            Controls.Add(label4);
            Controls.Add(cmbPagamento);
            Controls.Add(lbPagamento);
            Controls.Add(txtValorFinal);
            Controls.Add(lbValor);
            MaximizeBox = false;
            MaximumSize = new Size(530, 400);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(530, 400);
            Name = "TelaPgtoFinalForm";
            Text = "TelaPgtoFinalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorFinal;
        private Label lbValor;
        private TextBox txtCliente;
        private Label label1;
        private TextBox txtValorTotal;
        private Label label4;
        private ComboBox cmbPagamento;
        private Label lbPagamento;
        private Button btnCancelar;
        private Button btnGravar;
    }
}