using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.API.request;
using WindowsFormsApp11.API.response;

namespace WindowsFormsApp11.Service
{
    public class MainMenuServiceAsync
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string _urlBase = "https://localhost:44308/api";

        public static async Task<string> AddUser(UserAddResquest dataUser)
        {
            string result = "vacio";
            try {
                var json = JsonConvert.SerializeObject(dataUser);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(_urlBase + "/Users", data);
                 result = await response.Content.ReadAsStringAsync();
            } 
            catch (HttpRequestException e) {

                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
               



            return result;
        
        }






        }
}
