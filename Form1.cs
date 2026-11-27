namespace MakiUniformManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvDipendenti.DataSource = Database.GetDipendenti(); //datasource è la tabella da usa

            MessageBox.Show($"Database pronto! \n{Database.FilePath}", "Maki Divise");
        }

        private void btnNuovoDipendente_Click(object sender, EventArgs e) //che suz quando clicco il +
        {
            using var form = new FrmNuovoDipendente(); //apre il form

            form.ShowDialog(this); //blocca tutto finche non hai finito
        }
    }
}
