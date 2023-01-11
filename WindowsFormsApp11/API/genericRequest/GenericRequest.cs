using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11.API.genericRequest
{
    public class GenericRequest
    {
        private string textLabel;
        private string value;
        private string key;

        public GenericRequest() {
        }

        public GenericRequest(string textLabel, string value, string key)
        {   
            this.textLabel = textLabel;
            this.value = value;
            this.key = key;
        }

        public string TextLabel { get => textLabel; set => textLabel = value; }
        public string Value { get => value; set => this.value = value; }
        public string Key { get => key; set => key = value; }
    }
}
