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
            rdbConcluidas = new RadioButton();
            rdbPendentes = new RadioButton();
            rdbTodos = new RadioButton();
            btnCancelar = new Button();
            btnFiltrar = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rdbConcluidas
            // 
            rdbConcluidas.AutoSize = true;
            rdbConcluidas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbConcluidas.Location = new Point(25, 109);
            rdbConcluidas.Name = "rdbConcluidas";
            rdbConcluidas.Size = new Size(143, 21);
            rdbConcluidas.TabIndex = 14;
            rdbConcluidas.TabStop = true;
            rdbConcluidas.Text = "Aluguéis Concluídos";
            rdbConcluidas.UseVisualStyleBackColor = true;
            // 
            // rdbPendentes
            // 
            rdbPendentes.AutoSize = true;
            rdbPendentes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPendentes.Location = new Point(25, 71);
            rdbPendentes.Name = "rdbPendentes";
            rdbPendentes.Size = new Size(254, 21);
            rdbPendentes.TabIndex = 13;
            rdbPendentes.TabStop = true;
            rdbPendentes.Text = "VisualizarVisualizar Alugueis em aberto";
            rdbPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize = true;
            rdbTodos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTodos.Location = new Point(25, 34);
            rdbTodos.Name = "rdbTodos";
            rdbTodos.Size = new Size(191, 21);
            rdbTodos.TabIndex = 12;
            rdbTodos.TabStop = true;
            rdbTodos.Text = "Visualizar Todos os alugueis";
            rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(274, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(178, 210);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 50);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbPendentes);
            groupBox1.Controls.Add(rdbTodos);
            groupBox1.Controls.Add(rdbConcluidas);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(51, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 147);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Escolha o Filtro:";
            // 
            // TelaFiltroAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 313);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Name = "TelaFiltroAluguelForm";
            ShowIcon = false;
            Text = "Filtro de Aluguel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdbConcluidas;
        private RadioButton rdbPendentes;
        private RadioButton rdbTodos;
        private Button btnCancelar;
        private Button btnFiltrar;
        private GroupBox groupBox1;
    }
}