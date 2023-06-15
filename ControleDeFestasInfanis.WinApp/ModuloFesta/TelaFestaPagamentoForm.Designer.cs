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
            label2 = new Label();
            label1 = new Label();
            cmbPagamento = new ComboBox();
            lbPagamento = new Label();
            lbValor = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtValorRest = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtValorEnt = new TextBox();
            txtValorTotal = new TextBox();
            cmbCliente = new ComboBox();
            cmbTema = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 53);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 28;
            label2.Text = "Tema:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 27;
            label1.Text = "Cliente:";
            // 
            // cmbPagamento
            // 
            cmbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagamento.FormattingEnabled = true;
            cmbPagamento.Location = new Point(127, 189);
            cmbPagamento.Name = "cmbPagamento";
            cmbPagamento.Size = new Size(154, 24);
            cmbPagamento.TabIndex = 35;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbPagamento.Location = new Point(25, 196);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(80, 16);
            lbPagamento.TabIndex = 34;
            lbPagamento.Text = "Pagamento:";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbValor.Location = new Point(279, 123);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(42, 16);
            lbValor.TabIndex = 32;
            lbValor.Text = "Valor:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(441, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 44);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(333, 235);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(86, 44);
            btnGravar.TabIndex = 36;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtValorRest
            // 
            txtValorRest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorRest.Location = new Point(333, 116);
            txtValorRest.Name = "txtValorRest";
            txtValorRest.Size = new Size(113, 29);
            txtValorRest.TabIndex = 38;
            txtValorRest.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 90);
            label3.Name = "label3";
            label3.Size = new Size(92, 16);
            label3.TabIndex = 39;
            label3.Text = "Valor Entrada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 123);
            label4.Name = "label4";
            label4.Size = new Size(76, 16);
            label4.TabIndex = 40;
            label4.Text = "Valor Total:";
            // 
            // txtValorEnt
            // 
            txtValorEnt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorEnt.Location = new Point(127, 75);
            txtValorEnt.Name = "txtValorEnt";
            txtValorEnt.Size = new Size(113, 29);
            txtValorEnt.TabIndex = 41;
            txtValorEnt.Text = "0.00";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(127, 110);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(113, 29);
            txtValorTotal.TabIndex = 42;
            txtValorTotal.Text = "0.00";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(127, 15);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 24);
            cmbCliente.TabIndex = 43;
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(127, 45);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(121, 24);
            cmbTema.TabIndex = 44;
            // 
            // TelaFestaPagamentoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 291);
            Controls.Add(cmbTema);
            Controls.Add(cmbCliente);
            Controls.Add(txtValorTotal);
            Controls.Add(txtValorEnt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtValorRest);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cmbPagamento);
            Controls.Add(lbPagamento);
            Controls.Add(lbValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "TelaFestaPagamentoForm";
            Text = "TelaFestaPagamentoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private ComboBox cmbPagamento;
        private Label lbPagamento;
        private Label lbValor;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtValorRest;
        private Label label3;
        private Label label4;
        private TextBox txtValorEnt;
        private TextBox txtValorTotal;
        private ComboBox cmbCliente;
        private ComboBox cmbTema;
    }
}