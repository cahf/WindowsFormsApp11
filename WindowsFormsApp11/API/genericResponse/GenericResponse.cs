using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WindowsFormsApp11.API.genericRequest;

namespace WindowsFormsApp11.API.genericResponse
{
    public partial class GenericResponse<T>
    {
        [JsonProperty("hasError")]
        public bool HasError { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("model")]
        public T[] ModelGeneric { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        public static implicit operator GenericResponse<T>(GenericRequest v)
        {
            throw new NotImplementedException();
        }
    }

 
}
