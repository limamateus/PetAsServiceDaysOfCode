using Newtonsoft.Json;
using PetAsServiceDaysOfCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsServiceDaysOfCode.EndPoints.Categories
{
    public class Categories
    {


        public async Task<List<Gatos>> Get()
        {
            string conteudo = "";

            var http = new IniciarHttp();

            http.InicializaClient();
            try
            {
                var xRetorno = await http._client.GetAsync("v1/categories");

                if(xRetorno != null)
                {
                    conteudo = await xRetorno.Content.ReadAsStringAsync();

                }
                var retorno = JsonConvert.DeserializeObject<List<Gatos>>(conteudo);

                return retorno;
            }
            catch (Exception e ) // Preciso criar algumas Execptions 
            {

                return null ;
            }
           

           
        }


    }
}
