using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11.API.genericResponse
{
    public partial class AttendanceResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("dateIn")]
        public DateTimeOffset DateIn { get; set; }

        [JsonProperty("dateOut")]
        public DateTimeOffset DateOut { get; set; }

        [JsonProperty("member")]
        public Member Member { get; set; }
    }

    public partial class Member
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("birthDay")]
        public DateTimeOffset BirthDay { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("allowNewsLetter")]
        public bool AllowNewsLetter { get; set; }

        [JsonProperty("registeredOn")]
        public DateTimeOffset RegisteredOn { get; set; }

        [JsonProperty("membershipEnd")]
        public DateTimeOffset MembershipEnd { get; set; }

        [JsonProperty("cityId")]
        public long CityId { get; set; }

        [JsonProperty("membershipTypeId")]
        public long MembershipTypeId { get; set; }
    }

}
