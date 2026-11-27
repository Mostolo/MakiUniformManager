using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MakiUniformManager
{
    public partial class FrmNuovoDipendente : Form
    {
        public FrmNuovoDipendente()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cognome = txtCognome.Text.Trim();

            if (nome == "" ||  cognome == "")
            {
                MessageBox.Show("inserisci un nome e un cognome valido!", "ops, you did it again!");
                return;
            }

            Database.AddDipendente(nome, cognome);

            DialogResult = DialogResult.OK;
        }
    }
}
