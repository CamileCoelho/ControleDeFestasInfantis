namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            txtTermino = new DateTimePicker();
            txtInicio = new DateTimePicker();
            label2 = new Label();
            txtData = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            groupBoxLocalizacao = new GroupBox();
            label9 = new Label();
            label4 = new Label();
            txtCidade = new TextBox();
            label3 = new Label();
            txtNumero = new TextBox();
            label1 = new Label();
            txtRua = new TextBox();
            txtId = new TextBox();
            label8 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            cmbClientes = new ComboBox();
            cmbTemas = new ComboBox();
            groupBoxLocalizacao.SuspendLayout();
            SuspendLayout();
            // 
            // txtTermino
            // 
            txtTermino.CustomFormat = "HH:mm";
            txtTermino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTermino.Format = DateTimePickerFormat.Custom;
            txtTermino.Location = new Point(184, 273);
            txtTermino.Name = "txtTermino";
            txtTermino.ShowUpDown = true;
            txtTermino.Size = new Size(195, 29);
            txtTermino.TabIndex = 64;
            txtTermino.Value = new DateTime(2023, 5, 24, 0, 0, 0, 0);
            // 
            // txtInicio
            // 
            txtInicio.CustomFormat = "HH:mm";
            txtInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInicio.Format = DateTimePickerFormat.Custom;
            txtInicio.Location = new Point(184, 223);
            txtInicio.Name = "txtInicio";
            txtInicio.ShowUpDown = true;
            txtInicio.Size = new Size(195, 29);
            txtInicio.TabIndex = 63;
            txtInicio.Value = new DateTime(2020, 2, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 177);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 62;
            label2.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(184, 177);
            txtData.Name = "txtData";
            txtData.Size = new Size(195, 29);
            txtData.TabIndex = 61;
            txtData.Value = new DateTime(2023, 6, 2, 17, 15, 5, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 223);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 60;
            label6.Text = "Horário de Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 273);
            label5.Name = "label5";
            label5.Size = new Size(147, 21);
            label5.TabIndex = 59;
            label5.Text = "Horário de Término:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(35, 72);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 65;
            label7.Text = "Cliente:";
            // 
            // groupBoxLocalizacao
            // 
            groupBoxLocalizacao.BackColor = SystemColors.Control;
            groupBoxLocalizacao.Controls.Add(cmbTemas);
            groupBoxLocalizacao.Controls.Add(label9);
            groupBoxLocalizacao.Controls.Add(label4);
            groupBoxLocalizacao.Controls.Add(txtCidade);
            groupBoxLocalizacao.Controls.Add(txtInicio);
            groupBoxLocalizacao.Controls.Add(label6);
            groupBoxLocalizacao.Controls.Add(txtTermino);
            groupBoxLocalizacao.Controls.Add(label3);
            groupBoxLocalizacao.Controls.Add(txtNumero);
            groupBoxLocalizacao.Controls.Add(label5);
            groupBoxLocalizacao.Controls.Add(label2);
            groupBoxLocalizacao.Controls.Add(label1);
            groupBoxLocalizacao.Controls.Add(txtData);
            groupBoxLocalizacao.Controls.Add(txtRua);
            groupBoxLocalizacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxLocalizacao.Location = new Point(102, 131);
            groupBoxLocalizacao.Name = "groupBoxLocalizacao";
            groupBoxLocalizacao.Size = new Size(395, 382);
            groupBoxLocalizacao.TabIndex = 66;
            groupBoxLocalizacao.TabStop = false;
            groupBoxLocalizacao.Text = "Informações da Festa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(116, 324);
            label9.Name = "label9";
            label9.Size = new Size(49, 21);
            label9.TabIndex = 72;
            label9.Text = "Tema:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(104, 41);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 72;
            label4.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(184, 38);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(195, 29);
            txtCidade.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(94, 88);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 70;
            label3.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(184, 85);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(195, 29);
            txtNumero.TabIndex = 69;
            txtNumero.KeyPress += txtNuemro_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(125, 134);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 68;
            label1.Text = "Rua:";
            // 
            // txtRua
            // 
            txtRua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRua.Location = new Point(184, 131);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(195, 29);
            txtRua.TabIndex = 67;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(102, 37);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(201, 29);
            txtId.TabIndex = 68;
            txtId.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(70, 37);
            label8.Name = "label8";
            label8.Size = new Size(26, 21);
            label8.TabIndex = 67;
            label8.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(403, 569);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 70;
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
            btnGravar.Location = new Point(288, 569);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 69;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(102, 72);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(395, 28);
            cmbClientes.TabIndex = 71;
            // 
            // cmbTemas
            // 
            cmbTemas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTemas.FormattingEnabled = true;
            cmbTemas.Location = new Point(184, 322);
            cmbTemas.Name = "cmbTemas";
            cmbTemas.Size = new Size(195, 28);
            cmbTemas.TabIndex = 72;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 656);
            Controls.Add(cmbClientes);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(groupBoxLocalizacao);
            Controls.Add(label7);
            Name = "TelaAluguelForm";
            Text = "TelaAluguelForm";
            groupBoxLocalizacao.ResumeLayout(false);
            groupBoxLocalizacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker txtTermino;
        private DateTimePicker txtInicio;
        private Label label2;
        private DateTimePicker txtData;
        private Label label6;
        private Label label5;
        private Label label7;
        private GroupBox groupBoxLocalizacao;
        private Label label4;
        private TextBox txtCidade;
        private Label label3;
        private TextBox txtNumero;
        private Label label1;
        private TextBox txtRua;
        private TextBox txtId;
        private Label label8;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label9;
        private ComboBox cmbTemas;
        private ComboBox cmbClientes;
    }
}