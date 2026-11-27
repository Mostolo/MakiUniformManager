namespace MakiUniformManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDipendenti = new DataGridView();
            cmbDipendenti = new ComboBox();
            btnNuovoDipendente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDipendenti).BeginInit();
            SuspendLayout();
            // 
            // dgvDipendenti
            // 
            dgvDipendenti.AllowUserToAddRows = false;
            dgvDipendenti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDipendenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDipendenti.ColumnHeadersHeight = 34;
            dgvDipendenti.Location = new Point(12, 12);
            dgvDipendenti.Name = "dgvDipendenti";
            dgvDipendenti.ReadOnly = true;
            dgvDipendenti.RowHeadersWidth = 62;
            dgvDipendenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDipendenti.Size = new Size(776, 381);
            dgvDipendenti.TabIndex = 0;
            // 
            // cmbDipendenti
            // 
            cmbDipendenti.FormattingEnabled = true;
            cmbDipendenti.Location = new Point(12, 405);
            cmbDipendenti.Name = "cmbDipendenti";
            cmbDipendenti.RightToLeft = RightToLeft.No;
            cmbDipendenti.Size = new Size(718, 33);
            cmbDipendenti.TabIndex = 1;
            cmbDipendenti.Text = "-";
            // 
            // btnNuovoDipendente
            // 
            btnNuovoDipendente.Location = new Point(736, 405);
            btnNuovoDipendente.Name = "btnNuovoDipendente";
            btnNuovoDipendente.Size = new Size(52, 34);
            btnNuovoDipendente.TabIndex = 2;
            btnNuovoDipendente.Text = "+";
            btnNuovoDipendente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuovoDipendente);
            Controls.Add(cmbDipendenti);
            Controls.Add(dgvDipendenti);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDipendenti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDipendenti;
        private ComboBox cmbDipendenti;
        private Button btnNuovoDipendente;
    }
}
