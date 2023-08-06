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
    public partial class TelaDeBemVindoUC : UserControl
    {
        public Util util = new Util();
        public TelaDeBemVindoUC()
        {
            InitializeComponent();
        }

        private async void TelaDeBemVindoUC_Load(object sender, EventArgs e)
        {

            var xBuscarGif = await util.BuscarGif("cat.gif");

            if (xBuscarGif !=  null )
            {
                pictureBox1.Image = xBuscarGif.Image;
            }
            else
            {
                MessageBox.Show("Arquivo GIF não encontrado!");
            }


           
        }
    }
}
