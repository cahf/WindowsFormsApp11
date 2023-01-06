using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11.API.request
{
    public class UserAddResquest
    {
        private string phoneNumber;
        private string password;
        private string email;

        public UserAddResquest() { 
        }

        public UserAddResquest(string number, string password, string correo) {
            
            this.phoneNumber = number;
            this.email = correo;
            this.password = password;
        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}
