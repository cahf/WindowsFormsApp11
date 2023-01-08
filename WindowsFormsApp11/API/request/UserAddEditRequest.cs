using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11.API.request
{
    public class UserAddEditRequest
    {
        private string phoneNumber;
        private string password;
        private string userName;

        public UserAddEditRequest()
        {
        }

        public UserAddEditRequest(string number, string password, string userName)
        {

            this.PhoneNumber = number;
            this.UserName = userName;
            this.Password = password;
        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Password { get => password; set => password = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
