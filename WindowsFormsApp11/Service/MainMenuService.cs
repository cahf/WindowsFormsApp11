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

namespace WindowsFormsApp11.Service
{
    public class MainMenuService
    {
        private static readonly String _urlAttendace = "https://localhost:44308/api/Attendance";
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


    }
}
