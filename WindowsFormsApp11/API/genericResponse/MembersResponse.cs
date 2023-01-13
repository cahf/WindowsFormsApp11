using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11.API.genericResponse
{
    public class MembersResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("lastName")]
        public string lastName { get; set; }

        [JsonProperty("birthDay")]
        public string birthDay { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("allowNewsLetter")]
        public string allowNewsLetter { get; set; }

        [JsonProperty("registeredOn")]
        public string registeredOn { get; set; }

        [JsonProperty("membershipEnd")]
        public string membershipEnd { get; set; }

        [JsonProperty("cityId")]
        public string cityId { get; set; }

        [JsonProperty("membershipTypeId")]
        public string membershipTypeId { get; set; }



    }

}
