using PetAsServiceDaysOfCode.EndPoints.Breeds;
using PetAsServiceDaysOfCode.EndPoints.Favourites;
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

        public List<Favorite> listaDeFavorite = new List<Favorite>();

        public Breeds breeds = new Breeds();
        public ListaDeFavoritosUC()
        {
            InitializeComponent();
        }

        private void ListaDeFavoritosUC_Load(object sender, EventArgs e)
        {
            PreencheLista();
        }


        public async void PreencheLista()
        {

            var xLista = await favourites.Get();

            var xListaDeBreends = await breeds.Get();

            foreach (var x in xLista)
            {

                var xConulta = xListaDeBreends.FirstOrDefault(p => p.Reference_Image_Id == x.Image_Id);

                if (xConulta != null)
                {
                    LV.Items.Add(xConulta.Name);
                }



            }



        }
    }
}
