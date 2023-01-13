using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.Components;
using WindowsFormsApp11.Components.Usuarios;

namespace WindowsFormsApp11.View.MainMenu
{
    public interface IMainMenuView
    {
        UserControlListViewMembers listViewUserControl { get; set; }

        UserControlUsers UsersUserControl { get; set; }
         void DeleteData(object sender, EventArgs e);
         void requestHandler(object sender, EventArgs e);
         void UpdateData(object sender, EventArgs e);
    }
}
