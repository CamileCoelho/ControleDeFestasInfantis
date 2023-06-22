namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaConfiguracaoDescontoForm
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
            numPorcentagemDesconto = new NumericUpDown();
            numDescontoMaximo = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            ((System.ComponentModel.ISupportInitialize)numPorcentagemDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDescontoMaximo).BeginInit();
            SuspendLayout();
            // 
            // numPorcentagemDesconto
            // 
            numPorcentagemDesconto.DecimalPlaces = 2;
            numPorcentagemDesconto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numPorcentagemDesconto.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            numPorcentagemDesconto.Location = new Point(321, 35);
            numPorcentagemDesconto.Name = "numPorcentagemDesconto";
            numPorcentagemDesconto.Size = new Size(94, 29);
            numPorcentagemDesconto.TabIndex = 0;
            numPorcentagemDesconto.Value = new decimal(new int[] { 100, 0, 0, 131072 });
            // 
            // numDescontoMaximo
            // 
            numDescontoMaximo.DecimalPlaces = 2;
            numDescontoMaximo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numDescontoMaximo.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            numDescontoMaximo.Location = new Point(321, 95);
            numDescontoMaximo.Name = "numDescontoMaximo";
            numDescontoMaximo.Size = new Size(94, 29);
            numDescontoMaximo.TabIndex = 1;
            numDescontoMaximo.Value = new decimal(new int[] { 1500, 0, 0, 131072 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(275, 21);
            label1.TabIndex = 2;
            label1.Text = "Porcentagem de desconto por aluguel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 97);
            label2.Name = "label2";
            label2.Size = new Size(245, 21);
            label2.TabIndex = 3;
            label2.Text = "Pocentagem máxima de desconto:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(321, 176);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 72;
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
            btnGravar.Location = new Point(206, 176);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 71;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // TelaConfiguracaoDescontoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 252);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numDescontoMaximo);
            Controls.Add(numPorcentagemDesconto);
            Name = "TelaConfiguracaoDescontoForm";
            Text = "Configurar Desconto";
            ((System.ComponentModel.ISupportInitialize)numPorcentagemDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDescontoMaximo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numPorcentagemDesconto;
        private NumericUpDown numDescontoMaximo;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
        private Button btnGravar;
    }
}