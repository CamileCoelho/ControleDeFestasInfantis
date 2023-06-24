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
            SuspendLayout();
            // 
            // rdbConcluidas
            // 
            rdbConcluidas.AutoSize = true;
            rdbConcluidas.Location = new Point(77, 139);
            rdbConcluidas.Name = "rdbConcluidas";
            rdbConcluidas.Size = new Size(37, 19);
            rdbConcluidas.TabIndex = 14;
            rdbConcluidas.TabStop = true;
            rdbConcluidas.Text = "xx";
            rdbConcluidas.UseVisualStyleBackColor = true;
            // 
            // rdbPendentes
            // 
            rdbPendentes.AutoSize = true;
            rdbPendentes.Location = new Point(77, 101);
            rdbPendentes.Name = "rdbPendentes";
            rdbPendentes.Size = new Size(229, 19);
            rdbPendentes.TabIndex = 13;
            rdbPendentes.TabStop = true;
            rdbPendentes.Text = "VisualizarVisualizar Alugueis em aberto";
            rdbPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize = true;
            rdbTodos.Location = new Point(77, 64);
            rdbTodos.Name = "rdbTodos";
            rdbTodos.Size = new Size(170, 19);
            rdbTodos.TabIndex = 12;
            rdbTodos.TabStop = true;
            rdbTodos.Text = "Visualizar Todos os alugueis";
            rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(297, 254);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(201, 254);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 50);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(rdbConcluidas);
            Controls.Add(rdbPendentes);
            Controls.Add(rdbTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Name = "TelaFiltroAluguelForm";
            ShowIcon = false;
            Text = "Filtro de Aluguel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbConcluidas;
        private RadioButton rdbPendentes;
        private RadioButton rdbTodos;
        private Button btnCancelar;
        private Button btnFiltrar;
    }
}