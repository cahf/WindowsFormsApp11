using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp11.Components.MainView;

namespace WindowsFormsApp11.Components.Usuarios.Add
{
    public partial class AddUsersForm : Form
    {

        UserControlUsers userControlUser;

        public AddUsersForm(UserControlUsers userControlUser)
        {
            InitializeComponent();
            this.userControlUser = userControlUser; 
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string numero = this.radTextBox1.Text;
            string correo = this.radTextBox2.Text;
            string password = this.radTextBox3.Text;
            string[] data = new string[] {numero,correo,password };
            this.userControlUser.getDataUserAddForm(data);
            this.Close();



        }
    }
}
