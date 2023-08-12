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

        public void BemVindo_Load(object sender, EventArgs e)
        {
            CarregarTelaDeBemVindo();
        }


        private void buscarRaçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarTelaDeBuscaRaca();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarTelaDeFavoritos();
        }


        private void CarregarTelaDeBemVindo()
        {
            pOriginal.Controls.Add(telaDeBemVindoUC);
            pOriginal.Show();
        }
        private void CarregarTelaDeBuscaRaca()
        {
            pOriginal.Controls.Clear();
            pOriginal.Controls.Add(buscaRacas);
            pOriginal.Show();

            if (buscaRacas.Resposta == false)
            {
                CarregarTelaDeBemVindo();
            }

        }
        private void CarregarTelaDeFavoritos()
        {
            pOriginal.Controls.Clear();
            pOriginal.Controls.Add(listaDeFavoritosUC);
            pOriginal.Show();
        }

    }
}