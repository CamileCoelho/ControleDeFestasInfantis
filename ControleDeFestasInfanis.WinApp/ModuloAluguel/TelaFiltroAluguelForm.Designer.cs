namespace ControleDeFestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaFiltroAluguelForm
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
            rdbFinalizados = new RadioButton();
            rdbEmAndamento = new RadioButton();
            rdbTodos = new RadioButton();
            btnFiltrar = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rdbFinalizados
            // 
            rdbFinalizados.AutoSize = true;
            rdbFinalizados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFinalizados.Location = new Point(25, 129);
            rdbFinalizados.Name = "rdbFinalizados";
            rdbFinalizados.Size = new Size(172, 25);
            rdbFinalizados.TabIndex = 14;
            rdbFinalizados.TabStop = true;
            rdbFinalizados.Text = "Alugueis Finalizados.";
            rdbFinalizados.UseVisualStyleBackColor = true;
            // 
            // rdbEmAndamento
            // 
            rdbEmAndamento.AutoSize = true;
            rdbEmAndamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbEmAndamento.Location = new Point(25, 85);
            rdbEmAndamento.Name = "rdbEmAndamento";
            rdbEmAndamento.Size = new Size(270, 25);
            rdbEmAndamento.TabIndex = 13;
            rdbEmAndamento.TabStop = true;
            rdbEmAndamento.Text = "Visualizar Alugueis Em Andamento";
            rdbEmAndamento.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize = true;
            rdbTodos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTodos.Location = new Point(25, 42);
            rdbTodos.Name = "rdbTodos";
            rdbTodos.Size = new Size(203, 25);
            rdbTodos.TabIndex = 12;
            rdbTodos.TabStop = true;
            rdbTodos.Text = "Visualizar Todos Alugueis";
            rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltrar.ImageAlign = ContentAlignment.BottomRight;
            btnFiltrar.Location = new Point(150, 239);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 41);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbEmAndamento);
            groupBox1.Controls.Add(rdbTodos);
            groupBox1.Controls.Add(rdbFinalizados);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(39, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 170);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Escolha o Filtro:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(266, 239);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 71;
            button1.Text = "Cancelar";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 317);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnFiltrar);
            MaximizeBox = false;
            MaximumSize = new Size(419, 356);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(419, 356);
            Name = "TelaFiltroAluguelForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro Para Alugueis";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdbFinalizados;
        private RadioButton rdbEmAndamento;
        private RadioButton rdbTodos;
        private Button btnFiltrar;
        private GroupBox groupBox1;
        private Button button1;
    }
}