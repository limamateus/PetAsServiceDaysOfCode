using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsServiceDaysOfCode.Models
{
    public class Util
    {


        public  async Task<PictureBox> BuscarGif(string nomeDoArquivo)
        {
            PictureBox pictureBox = new PictureBox();            

            // Combine o diretório do projeto com o caminho relativo da pasta "Gifs".
            string caminhoDoGif = Path.Combine(Application.StartupPath, "Gifs", nomeDoArquivo);

            // Verifique se o arquivo GIF existe antes de carregá-lo.
            if (File.Exists(caminhoDoGif))
            {
                // Carregue o GIF e atribua-o ao controle PictureBox.
                pictureBox.Image = Image.FromFile(caminhoDoGif);

                // Defina a propriedade SizeMode para Automatic para que o controle se ajuste ao tamanho do GIF.
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                return pictureBox;

            }

            return pictureBox;
        }
    }
}
