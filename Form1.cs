namespace MakiUniformManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvDipendenti.DataSource = Database.GetDipendenti(); //datasource è la tabella da usa
        }

        private void btnNuovoDipendente_Click(object sender, EventArgs e) //che suz quando clicco il +
        {
            using var form = new FrmNuovoDipendente(); //apre il form

            if (form.ShowDialog(this) == DialogResult.OK) //showdialog impedisce di fare altro
            {                                             //dialogresult.ok fa progredire solo se clicchi salva
                dgvDipendenti.DataSource = Database.GetDipendenti();
            }
        }
    }
}
