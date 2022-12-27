using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11.View.Login
{
    public interface ILoginView
    {
        event EventHandler<string> loginError;
        string UserText { get; set; }
        string PasswordText { get; set; }
    }
}
