using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.API.request;
using WindowsFormsApp11.API.response;

namespace WindowsFormsApp11.Service
{
    public class MainMenuService
    {
        private static readonly String _urlAttendace = "https://localhost:44308/api/Attendance";
        private static readonly string _urlUsers = "https://localhost:44308/api/Users";
        private static readonly HttpClient client = new HttpClient();

        public static AttendancesResponse getAttandances() {
            
            var httpRequest = (HttpWebRequest)WebRequest.Create(_urlAttendace);
            httpRequest.Method = "GET";
            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";
            AttendancesResponse response = new AttendancesResponse();
            try {

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();
                response = JsonConvert.DeserializeObject<AttendancesResponse>(result);
            }
            catch (Exception ex)
            {
                throw  new Exception();
            }



            return response;
        }

        public static UsersResponse getUsersList()
        {

            var httpRequest = (HttpWebRequest)WebRequest.Create(_urlUsers);
            httpRequest.Method = "GET";
            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";
            UsersResponse response = new UsersResponse();
            try
            {

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();
                response = JsonConvert.DeserializeObject<UsersResponse>(result);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }


            
            return response;
        }

        public static UsersDeleteResponse  deleterUser(string id)
        {

            var httpRequest = (HttpWebRequest)WebRequest.Create(_urlUsers+"/"+id);
            httpRequest.Method = "DELETE";
            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";
            UsersDeleteResponse response = new UsersDeleteResponse();
            try
            {

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();
                response = JsonConvert.DeserializeObject<UsersDeleteResponse>(result);
            }
            catch (ProtocolViolationException ex)
            {
                throw new ProtocolViolationException();
            }
            catch (NotSupportedException ex)
            {
                throw new NotSupportedException();
            }
            catch (WebException ex)
            {
                throw new WebException();
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException();
            }



            return response;
        }

        public static UsersAddResponse AddUser(UserAddResquest dataUser)
        {
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44308/api/Users");
            string dataJson = JsonConvert.SerializeObject(dataUser);
            var data = Encoding.ASCII.GetBytes(dataJson);
            httpRequest.Method = "POST";
            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";
            Stream stream = httpRequest.GetRequestStream();
            stream.Write(data,0,data.Length);
            try { 
            var response = (HttpWebResponse)httpRequest.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                }
            }



            return null;
            
        }




    }
}
