namespace ControleDeFestasInfantis.WinApp.ModuloTema
{
    partial class TabelaItensTema
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gridtensTema = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridtensTema).BeginInit();
            SuspendLayout();
            // 
            // gridtensTema
            // 
            gridtensTema.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridtensTema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridtensTema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridtensTema.Location = new Point(0, 0);
            gridtensTema.MultiSelect = false;
            gridtensTema.Name = "gridtensTema";
            gridtensTema.RowHeadersVisible = false;
            gridtensTema.RowTemplate.Height = 25;
            gridtensTema.Size = new Size(860, 468);
            gridtensTema.TabIndex = 1;
            // 
            // TabelaItensTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridtensTema);
            Name = "TabelaItensTema";
            Size = new Size(860, 468);
            ((System.ComponentModel.ISupportInitialize)gridtensTema).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid;
        private DataGridView gridtensTema;
    }
}
