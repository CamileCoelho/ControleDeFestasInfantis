namespace ControleDeFestasInfantis.WinApp.ModuloCliente
{
    partial class TelaAlugueisClienteForm
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
            panelAlugueisCliente = new Panel();
            SuspendLayout();
            // 
            // panelAlugueisCliente
            // 
            panelAlugueisCliente.Location = new Point(12, 12);
            panelAlugueisCliente.MaximumSize = new Size(776, 426);
            panelAlugueisCliente.MinimumSize = new Size(776, 426);
            panelAlugueisCliente.Name = "panelAlugueisCliente";
            panelAlugueisCliente.Size = new Size(776, 426);
            panelAlugueisCliente.TabIndex = 39;
            // 
            // TelaAlugueisClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAlugueisCliente);
            Name = "TelaAlugueisClienteForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAlugueisCliente;
    }
}