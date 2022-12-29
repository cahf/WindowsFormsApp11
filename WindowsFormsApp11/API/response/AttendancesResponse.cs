using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace WindowsFormsApp11.API.request
{


    public partial class AttendancesResponse
    {
        [JsonProperty("hasError")]
        public bool HasError { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("model")]
        public Model[] Model { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public partial class Model
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
