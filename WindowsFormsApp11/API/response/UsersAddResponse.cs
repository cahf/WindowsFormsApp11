using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WindowsFormsApp11.API.response
{
    public partial class UsersAddResponse
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
        public Guid Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
