using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsServiceDaysOfCode.EndPoints
{
    public class IniciarHttp
    {
        private static string Url = "https://api.thecatapi.com/";

        public HttpClient _client = null;


        public void InicializaClient()
        {

            if (_client == null)
            {
                _client = new HttpClient();
                _client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", "live_xMranoMOh98oUCR7IqM21A9lkKdXVyCJb21tS8ulW4deVXTIbGvynXKF0NeQmGUs");

                _client.BaseAddress = new Uri(Url);
            }

        }

    }
}
