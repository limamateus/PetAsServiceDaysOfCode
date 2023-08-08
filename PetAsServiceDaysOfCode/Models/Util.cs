using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PetAsServiceDaysOfCode.Models
{
    public class Util
    {


        public async Task<PictureBox> BuscarGif(string nomeDoArquivo)
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



        public async Task<PictureBox> BaixarImagem(string urlDaImagem)
        {
            try
            {
                PictureBox pictureBox = new PictureBox();

                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(urlDaImagem);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox.Image = image;
                    }

                    return pictureBox;
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Ocorreu um erro ao baixar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}





 