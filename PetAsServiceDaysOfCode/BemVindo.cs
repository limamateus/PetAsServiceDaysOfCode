namespace PetAsServiceDaysOfCode
{
    public partial class BemVindo : Form
    {
        TelaDeBemVindoUC telaDeBemVindoUC = new TelaDeBemVindoUC();
        BuscaRacas buscaRacas = new BuscaRacas();
        ListaDeFavoritosUC listaDeFavoritosUC = new ListaDeFavoritosUC();

        public BemVindo()
        {
            InitializeComponent();
        }

        private void BemVindo_Load(object sender, EventArgs e)
        {


            pOriginal.Controls.Add(telaDeBemVindoUC);
            pOriginal.Show();
        }

        private void buscarRaçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pOriginal.Controls.Clear();          
            pOriginal.Controls.Add(buscaRacas);
            pOriginal.Show();

           
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pOriginal.Controls.Clear();
            pOriginal.Controls.Add(listaDeFavoritosUC);
            pOriginal.Show();
        }
    }
}