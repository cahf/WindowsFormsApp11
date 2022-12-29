using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.Components;

namespace WindowsFormsApp11.View.MainMenu
{
    public interface IMainMenuView
    {
        UserControlListViewMembers listViewUserControl { get; set; }
    }
}
