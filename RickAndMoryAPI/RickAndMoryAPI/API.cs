using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace RickAndMoryAPI
{
    public class API
    {
        public static int IdCharacter;

        public static async Task<Response> GetResponse()
        {

            try
            {
                HttpResponseMessage message;
                using (HttpClient httpClient = new HttpClient())
                {
                    message = await httpClient.GetAsync($"https://rickandmortyapi.com/api/character/{IdCharacter}");
                }

                string jsonText = await message.Content.ReadAsStringAsync();

                Response response = JsonConvert.DeserializeObject<Response>(jsonText);
                return response;
            }
            catch
            {
                throw new APIException("Херня какая та");
            }

        }



    }
}
