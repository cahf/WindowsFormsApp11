using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.API.genericResponse;
using WindowsFormsApp11.API.request;
using WindowsFormsApp11.API.response;

namespace WindowsFormsApp11.Service
{
    public class MainMenuServiceAsync
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string _urlBase = "https://localhost:44308/api";


    //USERS


        //AGREGAR USUARIO POST
        public static async Task<string> AddUser(UserAddResquest dataUser, string idUser)
        {
            string result = "vacio";
            try {
                var json = JsonConvert.SerializeObject(dataUser);
                Console.WriteLine("RequestBody");
                Console.WriteLine(json);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response;
                if (idUser == null)
                {
                    response = await client.PostAsync(_urlBase + "/Users", data);
                }
                else {
                    response = await client.PutAsync(_urlBase + "/Users" + "/" + idUser, data);
                }
                
                
                
                result = await response.Content.ReadAsStringAsync();
            } 
            catch (HttpRequestException e) {

                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
               



            return result;
        
        }

        public static async Task<GenericResponse<EquipmentTypesResponse>> getEquipmentTypes()
        {

            var result = new GenericResponse<EquipmentTypesResponse>();

            try {

                HttpResponseMessage response = await client.GetAsync(_urlBase + "/EquipmentTypes");
                string responseString = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<GenericResponse<EquipmentTypesResponse>>(responseString);
                EquipmentTypesResponse responseEquipment = (EquipmentTypesResponse)result.ModelGeneric.First();
                Console.WriteLine("DATOS EQUIPMENT");
                Console.WriteLine(responseEquipment.Name);


            } 
            
            catch (HttpRequestException e) {


                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }


            return result;
        }

        //EDITAR USUARIO POST
        public static async Task<string> AddUserEditar(UserAddEditRequest dataUser, string idUser)
        {
            string result = "vacio";
            try
            {
                var json = JsonConvert.SerializeObject(dataUser);
                Console.WriteLine("RequestBody");
                Console.WriteLine(json);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response;
                if (idUser == null)
                {
                    response = await client.PostAsync(_urlBase + "/Users", data);
                }
                else
                {
                    response = await client.PutAsync(_urlBase + "/Users" + "/" + idUser, data);
                }



                result = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }




            return result;

        }

        //OBTENER  USUARIO BY ID 

        public static async Task<string> UpdateUser(UserAddResquest dataUser, int idUser)
        {
            string result = "vacio";
            try
            {
                var json = JsonConvert.SerializeObject(dataUser);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(_urlBase + "/Users" + "/" + idUser, data);
                result = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }




            return result;

        }





    }
}
