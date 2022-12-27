using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11.Service
{
    public class LoginService
    {
        private static readonly String _url = "https://localhost:44308/api/Account";
        private static readonly HttpClient client = new HttpClient();

        public static bool login(String user, String password)
        {
            return true;
            //var httpRequest = (HttpWebRequest)WebRequest.Create(_url);
            //LoginRequest loginRequest = new LoginRequest { 
            //password = password,
            //userName = user,
            //};


            //string json = JsonConvert.SerializeObject(loginRequest);
            //httpRequest.Method = "POST";
            //httpRequest.Accept = "application/json";
            //httpRequest.ContentType = "application/json";

            //using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            //{
            //    streamWriter.Write(json);
            //}


            //try
            //{
            //    var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            //    var streamReader = new StreamReader(httpResponse.GetResponseStream());

            //    var result = streamReader.ReadToEnd();

            //    LoginResponse response = JsonConvert.DeserializeObject<LoginResponse>(result);

            //    if (response.Message.Equals("Authorized")) {
            //        return true;
            //    }else 
            //            return false;

            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
        }


        public static string loginWithID(String user, String password)
        {

            string idCarlos = "a6ff377a-4af2-40de-aadd-adc8e8b07590";
            string _url = "https://localhost:44308/api/Users/a6ff377a-4af2-40de-aadd-adc8e8b07590";
            var httpRequest = (HttpWebRequest)WebRequest.Create(_url);
            httpRequest.Method = "GET";
            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";
            try
            {
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());

                var result = streamReader.ReadToEnd();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }





        }


    }
}
