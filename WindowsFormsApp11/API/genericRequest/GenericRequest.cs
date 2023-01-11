using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.API.Enums;

namespace WindowsFormsApp11.API.genericRequest
{
    public class GenericRequest
    {
        private string textLabel;
        private string value;
        private string key;
        private EndPointsAPI endPointsAPI;
        private HttpType httpType;

        public GenericRequest() {
        }

        public GenericRequest(string textLabel, string value, string key,EndPointsAPI endPointsAPI ,HttpType httpType)
        {   
            this.textLabel = textLabel;
            this.value = value;
            this.key = key;
            this.endPointsAPI = endPointsAPI;
            this.httpType = httpType;  
        }

        public string TextLabel { get => textLabel; set => textLabel = value; }
        public string Value { get => value; set => this.value = value; }
        public string Key { get => key; set => key = value; }
        public EndPointsAPI EndPointsAPI { get => endPointsAPI; set => endPointsAPI = value; }
        public HttpType HttpType { get => httpType; set => httpType = value; }
    }
}
