using Newtonsoft.Json;
using PetAsServiceDaysOfCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsServiceDaysOfCode.EndPoints.Images
{
    public class Images
    {
        public string conteudo = "";

        public IniciarHttp http = new IniciarHttp();

        public async Task<List<ImageCat>> Get()
        {

            http.InicializaClient();
            try
            {
                var xRetorno = await http._client.GetAsync($"v1/images/search");

                if (xRetorno != null)
                {
                    conteudo = await xRetorno.Content.ReadAsStringAsync();

                }
                var retorno = JsonConvert.DeserializeObject<List<ImageCat>>(conteudo);

                return retorno;
            }
            catch (Exception e) // Preciso criar algumas Execptions 
            {

                return null;
            }



        }
        public async Task<ImageCat> GetById(string image_id)
        {


            http.InicializaClient();
            try
            {
                var xRetorno = await http._client.GetAsync($"v1/images/{image_id}");

                if (xRetorno != null)
                {
                    conteudo = await xRetorno.Content.ReadAsStringAsync();

                }
                var retorno = JsonConvert.DeserializeObject<ImageCat>(conteudo);

                return retorno;
            }
            catch (Exception e) // Preciso criar algumas Execptions 
            {

                return null;
            }



        }

    }
}
