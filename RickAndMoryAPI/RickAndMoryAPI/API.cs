using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace RickAndMoryAPI
{
    public class API
    {
        public  int IdCharacter;

        public  async Task<Response> GetResponse()
        {


            HttpResponseMessage message;
            using (HttpClient httpClient = new())
            {
                message = await httpClient.GetAsync($"https://rickandmortyapi.com/api/character/{IdCharacter}");
            }

            string jsonText = await message.Content.ReadAsStringAsync();

            Response response = JsonConvert.DeserializeObject<Response>(jsonText);
            TryThrowExceptions(response);
            return response;


        }

        private static void TryThrowExceptions(Response response)
        {
            if(response.Error != null)
            {
                throw new APIException(response.Error);
            }
        }



    }
}
