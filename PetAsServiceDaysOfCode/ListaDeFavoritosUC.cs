using PetAsServiceDaysOfCode.EndPoints.Breeds;
using PetAsServiceDaysOfCode.EndPoints.Favourites;
using PetAsServiceDaysOfCode.EndPoints.Images;
using PetAsServiceDaysOfCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAsServiceDaysOfCode
{
    public partial class   ListaDeFavoritosUC : UserControl
    {

        public Favourites favourites = new Favourites();

        public List<Breed> listaDeBreends = new List<Breed>();

        public Breed breend = new Breed();

        public Images images = new Images();

        public Util util = new Util();

        public List<Favorite> listaDeFavorite = new List<Favorite>();

        public Favorite favorite = new Favorite();


        public Breeds breeds = new Breeds();

        public string ImagemId { get; set; }

        public string favoriteId { get; set; }
        public ListaDeFavoritosUC()
        {
            InitializeComponent();
        }

        private async void ListaDeFavoritosUC_Load(object sender, EventArgs e)
        {
            PreencheLista();
        }


        public async void PreencheLista()
        {

            listaDeFavorite = await favourites.Get();

            listaDeBreends = await breeds.Get();

            DGV.Rows.Clear();

            foreach (var item in listaDeFavorite)         
            {

                this.breend = listaDeBreends.FirstOrDefault(p => p.Reference_Image_Id == item.Image_Id);
              

                if (this.breend != null)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DGV);
                    row.Cells[0].Value = this.breend.Id;
                    row.Cells[1].Value = this.breend.Name;
                    row.Cells[2].Value = this.breend.Origin;
                    row.Cells[3].Value = this.breend.Reference_Image_Id;                
                    row.Cells[4].Value = item.Id.ToString();                


                    DGV.Rows.Add(row);
                }



            }
           



        }


        private async void DGV_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                row = DGV.SelectedRows[0];
                ImagemId = row.Cells[3].Value.ToString();
                favoriteId = row.Cells[4].Value.ToString();

                if (ImagemId != null)
                {

                    var xRetornoImagem = await images.GetById(ImagemId); ;

                    if (xRetornoImagem.Url != null)
                    {
                        var xImagem = await util.BaixarImagem(xRetornoImagem.Url.ToString());

                        try
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = xImagem.Image;
                            pictureBox1.Show();
                        }
                        catch (Exception)
                        {
                            pictureBox1.Image = xImagem.Image;
                            pictureBox1.Show();

                        }
                    }


                }

            }
            catch (Exception error)
            {

                MessageBox.Show($"Ouve um erro ao carregar a imagem: {error.Message}");
            }
        }

        private async void btnFavoritar_Click(object sender, EventArgs e)
        {
            var xRetorno = await favourites.Delete(favoriteId);
            if(xRetorno)
            {
              MessageBox.Show("Deletado com sucesso!");
                PreencheLista();
               
            }
            else
            {
                MessageBox.Show($"O Id {favoriteId}");
            }
        }
    }
}
