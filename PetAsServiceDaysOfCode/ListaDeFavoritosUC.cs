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
    public partial class ListaDeFavoritosUC : UserControl
    {

        public Favourites favourites = new Favourites();

        public List<Breed> listaDeBreends = new List<Breed>();

        public Breed breend = new Breed();

        public Images images = new Images();

        public Util util = new Util();

        public List<Favorite> listaDeFavorite = new List<Favorite>();

        public Breeds breeds = new Breeds();
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

            var xLista = await favourites.Get();

            listaDeBreends = await breeds.Get();

            foreach (var x in xLista)
            {

                this.breend = listaDeBreends.FirstOrDefault(p => p.Reference_Image_Id == x.Image_Id);

                if (this.breend != null)
                {
                    LV.Items.Add(this.breend.Name);
                }



            }



        }



        private async void LV_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private async void LV_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                if (LV.SelectedItems.Count > 0)
                {
                    this.breend = listaDeBreends.Find(x => x.Name == LV.FocusedItem.Text);

                    if (this.breend != null)
                    {
                        var xRetornoImagem = await images.GetById(this.breend.Reference_Image_Id); ;

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
                
            }
            catch (Exception error)
            {

                MessageBox.Show("Erro ao realizar ao baixar a imagem");
            }
        }

        
    }
}
