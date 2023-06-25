namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    partial class TelaPgtoEntradaForm
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
            label3 = new Label();
            label4 = new Label();
            txtValorTotal = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label1 = new Label();
            txtCliente = new TextBox();
            txtValorEntrada = new TextBox();
            SuspendLayout();
            // 
            // cmbPagamento
            // 
            cmbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPagamento.FormattingEnabled = true;
            cmbPagamento.Location = new Point(226, 195);
            cmbPagamento.Name = "cmbPagamento";
            cmbPagamento.Size = new Size(229, 29);
            cmbPagamento.TabIndex = 35;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPagamento.Location = new Point(41, 195);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(162, 21);
            lbPagamento.TabIndex = 34;
            lbPagamento.Text = "Forma de pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(95, 143);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 39;
            label3.Text = "Valor Entrada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(118, 94);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 40;
            label4.Text = "Valor Total:";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(226, 86);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(229, 29);
            txtValorTotal.TabIndex = 42;
            txtValorTotal.Text = "0.00";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(361, 275);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MinimumSize = new Size(94, 41);
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
            btnGravar.Location = new Point(246, 275);
            btnGravar.Margin = new Padding(4);
            btnGravar.MinimumSize = new Size(94, 41);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 45;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 47;
            label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.Location = new Point(226, 32);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(229, 29);
            txtCliente.TabIndex = 48;
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorEntrada.Location = new Point(226, 140);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.Size = new Size(229, 29);
            txtValorEntrada.TabIndex = 50;
            txtValorEntrada.Text = "0.00";
            txtValorEntrada.KeyPress += txtValorEntrada_KeyPress;
            // 
            // TelaPgtoEntradaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 361);
            Controls.Add(txtValorEntrada);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtValorTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbPagamento);
            Controls.Add(lbPagamento);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MaximumSize = new Size(530, 400);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(530, 400);
            Name = "TelaPgtoEntradaForm";
            Text = "Pagamento Da Entrada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbPagamento;
        private Label lbPagamento;
        private Label label3;
        private Label label4;
        private TextBox txtValorTotal;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label1;
        private TextBox txtCliente;
        private TextBox txtValorEntrada;
    }
}