using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.Service;
using WindowsFormsApp11.View.Login;

namespace WindowsFormsApp11.Presenter.Login
{
    public class LoginPresenter
    {
        private readonly ILoginView _loginView;
        public LoginPresenter(ILoginView loginView)
        {
            _loginView = loginView;
            _loginView.loginError += (o, e) => {
                MessageBox.Show("Error de login debido a: " + e.ToString());
            };
        }

        public bool IsLoggedIn()
        {
            String user = _loginView.UserText;
            String password = _loginView.PasswordText;

            bool isLoggedIn = LoginService.login(user, password);

            return isLoggedIn == true;


        }


    }
}
