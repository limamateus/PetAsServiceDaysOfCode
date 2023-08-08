using Newtonsoft.Json;
using PetAsServiceDaysOfCode.EndPoints.Breeds;
using PetAsServiceDaysOfCode.EndPoints.Categories;
using PetAsServiceDaysOfCode.EndPoints.Favourites;
using PetAsServiceDaysOfCode.EndPoints.Images;
using PetAsServiceDaysOfCode.Models;


namespace PetAsServiceDaysOfCode
{
    public partial class BuscaRacas : UserControl
    {
        public Util util = new Util();      


        public Breeds breeds = new Breeds();

        public Favourites favourites = new Favourites();

        public Images images = new Images();
        public List<Breed> ListaDeBreends { get; set; }

        public Breed Breed { get; set; }

        public bool abrirListaDeFavoritos = false;



        public BuscaRacas()
        {
            InitializeComponent();
        }

        private void BuscaRacas_Load(object sender, EventArgs e)
        {
            CarregarGif();
            CarregarComboBox();
        }


        public async void CarregarGif()
        {
            var xBuscarGif = await util.BuscarGif("gatinhoNoPC.gif");

            if (xBuscarGif != null)
            {
                pictureBox1.Image = xBuscarGif.Image;
            }
            else
            {
                MessageBox.Show("Arquivo GIF não encontrado!");
            }
        }

        /// <summary>
        /// Esse Método irá carregar o comboBox com as informações da API
        /// </summary>
        public async void CarregarComboBox()
        {

            CB.Text = "Seleciona uma Raça";

            ListaDeBreends = await breeds.Get();        

            if (ListaDeBreends != null)
            {

                foreach (var breend in ListaDeBreends)
                {
                    CB.Items.Add(breend.Name);  
                    
                   
                }

            }


        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {
            var xSelecionado = CB.SelectedItem;

            this.Breed = ListaDeBreends.Find(x => x.Name == xSelecionado);

            var body = new PostFavorite()
            {
                Image_Id = this.Breed.Reference_Image_Id,
                Sub_Id = "Testes"

            };


            var xRet = favourites.Post(body);

            if(xRet == null)
            {
                MessageBox.Show("Ouve um erro ao favoritar", "Erro");
            }

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                
            
        }

        private async void CB_SelectedValueChanged(object sender, EventArgs e)
        {
            var xSelecionado = CB.SelectedItem;

            this.Breed = ListaDeBreends.Find(x => x.Name == xSelecionado);

            txtTemperament.Text = this.Breed.Temperament;

            txtOrigem.Text = this.Breed.Origin;

            txtDescricao.Text = this.Breed.Description;

            try
            {
                var xRetornoImagem = await images.GetById(this.Breed.Reference_Image_Id);

                if (xRetornoImagem.Url != null)
                {
                    var xImagem = await util.BaixarImagem(xRetornoImagem.Url.ToString());
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = xImagem.Image;
                    pictureBox1.Show();
                    
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Erro ao realizar ao baixar a imagem");
            }

           





        }

        
    }
}
