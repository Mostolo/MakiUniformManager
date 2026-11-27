namespace MakiUniformManager
{
    partial class FrmNuovoDipendente
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
            lblNome = new Label();
            lblCognome = new Label();
            txtNome = new TextBox();
            txtCognome = new TextBox();
            btnSalva = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Location = new Point(12, 83);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(91, 25);
            lblCognome.TabIndex = 1;
            lblCognome.Text = "Cognome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(463, 31);
            txtNome.TabIndex = 2;
            txtNome.Text = "Inserisci nome";
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(12, 111);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(463, 31);
            txtCognome.TabIndex = 3;
            txtCognome.Text = "Inserisci cognome";
            // 
            // btnSalva
            // 
            btnSalva.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalva.Location = new Point(345, 148);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(112, 34);
            btnSalva.TabIndex = 4;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            // 
            // FrmNuovoDipendente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 194);
            Controls.Add(btnSalva);
            Controls.Add(txtCognome);
            Controls.Add(txtNome);
            Controls.Add(lblCognome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmNuovoDipendente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MUM - Nuovo Dipendente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCognome;
        private TextBox txtNome;
        private TextBox txtCognome;
        private Button btnSalva;
    }
}