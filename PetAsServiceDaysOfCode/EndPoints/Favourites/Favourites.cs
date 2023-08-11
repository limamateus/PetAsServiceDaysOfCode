using Newtonsoft.Json;
using PetAsServiceDaysOfCode.Models;
using System.Text;

namespace PetAsServiceDaysOfCode.EndPoints.Favourites
{
    public class Favourites
    {
        public string conteudo = "";

        public IniciarHttp http = new IniciarHttp();
        public async Task<List<Favorite>> Get()
        {
            http.InicializaClient();
            try
            {
                var xRetorno = await http._client.GetAsync($"v1/favourites");

                if (xRetorno != null)
                {
                    conteudo = await xRetorno.Content.ReadAsStringAsync();

                }
                var retorno = JsonConvert.DeserializeObject<List<Favorite>>(conteudo);

                return retorno;
            }
            catch (Exception e) // Preciso criar algumas Execptions 
            {

                return null;
            }



        }
        public async Task<Favorite> GetById(string favourite_id)
        {


            http.InicializaClient();
            try
            {
                var xRetorno = await http._client.GetAsync($"v1/favourites/{favourite_id}");

                if (xRetorno != null)
                {
                    conteudo = await xRetorno.Content.ReadAsStringAsync();

                }
                var retorno = JsonConvert.DeserializeObject<Favorite>(conteudo);

                return retorno;
            }
            catch (Exception e) // Preciso criar algumas Execptions 
            {

                return null;
            }



        }


        public async Task<ResponsePostFavorite> Post(PostFavorite body)
        {

            http.InicializaClient();
            try
            {

                var url = "v1/favourites";

                var xRetorno = await http._client.PostAsync(url, new StringContent(
                    JsonConvert.SerializeObject(new
                    {
                        image_id = body.Image_Id,
                        sub_id = body.Sub_Id

                    }), Encoding.UTF8, "application/json")); ;

                if (xRetorno != null)
                {
                    conteudo = await xRetorno.Content.ReadAsStringAsync();

                    if (!xRetorno.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"{conteudo}", $"{xRetorno.StatusCode}");
                        return null;
                    }

                    return JsonConvert.DeserializeObject<ResponsePostFavorite>(conteudo);

                }

                return null;

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ouve um erro ao favoritar: {error.Message}", "Erro");
                return null;
            }

        }


        public async Task<bool> Delete(string favourite_id)
        {
            var xConsulta = await GetById(favourite_id);

            if (xConsulta != null)
            {
                http.InicializaClient();

                var xRetorno = await http._client.DeleteAsync($"v1/favourites/{favourite_id}");

                if (xRetorno.IsSuccessStatusCode)
                {
                    return true;

                }
                return false;

            }

            return false;
        }


    }
}
