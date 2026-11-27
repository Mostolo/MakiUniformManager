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
    }
}
