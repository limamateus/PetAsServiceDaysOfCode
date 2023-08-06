using Newtonsoft.Json;
using PetAsServiceDaysOfCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsServiceDaysOfCode.EndPoints.Breeds
{
    public class Breeds
    {
        public async Task<List<Breed>> Get(int limit= 10, int page = 0 )
        {
            string conteudo = "";

            var http = new IniciarHttp();

            http.InicializaClient();
            try
            {
                var xRetorno = await http._client.GetAsync($"v1/breeds?limit={limit}&page={page}");

                if (xRetorno != null)
                {
                    conteudo = await xRetorno.Content.ReadAsStringAsync();

                }
                var retorno = JsonConvert.DeserializeObject<List<Breed>>(conteudo);

                return retorno;
            }
            catch (Exception e) // Preciso criar algumas Execptions 
            {

                return null;
            }



        } public async Task<Breed> GetById(string breed_id)
        {
            string conteudo = "";

            var http = new IniciarHttp();

            http.InicializaClient();
            try
            {
                var xRetorno = await http._client.GetAsync($"v1/breeds/:{breed_id}");

                if (xRetorno != null)
                {
                    conteudo = await xRetorno.Content.ReadAsStringAsync();

                }
                var retorno = JsonConvert.DeserializeObject<Breed>(conteudo);

                return retorno;
            }
            catch (Exception e) // Preciso criar algumas Execptions 
            {

                return null;
            }



        }



    }
}
