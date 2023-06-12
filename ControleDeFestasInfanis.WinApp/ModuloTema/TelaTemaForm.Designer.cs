namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    partial class TelaTemaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtTema = new TextBox();
            btnAdicionar = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            listTema = new ListBox();
            cmbItem = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 74);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 106);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 1;
            label2.Text = "Tema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 141);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 2;
            label3.Text = "Item ";
            // 
            // txtId
            // 
            txtId.Location = new Point(94, 68);
            txtId.Name = "txtId";
            txtId.Size = new Size(99, 23);
            txtId.TabIndex = 3;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(94, 100);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(300, 23);
            txtTema.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(319, 135);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(238, 367);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(319, 367);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listTema
            // 
            listTema.FormattingEnabled = true;
            listTema.ItemHeight = 15;
            listTema.Location = new Point(94, 176);
            listTema.Name = "listTema";
            listTema.Size = new Size(300, 154);
            listTema.TabIndex = 9;
            // 
            // cmbItem
            // 
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(94, 136);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(219, 23);
            cmbItem.TabIndex = 10;
            cmbItem.SelectedIndexChanged += cmbItem_SelectedIndexChanged;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(cmbItem);
            Controls.Add(listTema);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTema);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaTemaForm";
            ShowIcon = false;
            Text = "Cadastro de Temas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtTema;
        private Button btnAdicionar;
        private Button btnGravar;
        private Button btnCancelar;
        private ListBox listTema;
        private ComboBox cmbItem;
    }
}