using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApp11.Components.MainView;
using WindowsFormsApp11.Presenter.Login;
using WindowsFormsApp11.View.Login;

namespace WindowsFormsApp11.Components.Login
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm,ILoginView
    {
        public event EventHandler<string> loginError;
        readonly LoginPresenter loginPresenter = null;
        public LoginForm()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter(this);
        }

        public string UserText { get { return radTextBoxUser.Text; } set { radTextBoxUser.Text = value; } }

        public string PasswordText { get { return radTextBoxPassword.Text; } set { radTextBoxPassword.Text = value; } }

        private void radButtonLogin_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();


            if (loginPresenter.IsLoggedIn())
            {
                this.Hide();
                mainForm.Show();
                mainForm.WindowState = FormWindowState.Maximized;
            }
            else
            {

                loginError.Invoke(this, "Error en las credenciales");

            }
        }
    }
}
