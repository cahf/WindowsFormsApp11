using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApp11.Presenter.MainMenu;
using WindowsFormsApp11.View.MainMenu;

namespace WindowsFormsApp11.Components.MainView
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm, IMainMenuView
    {
        readonly MainMenuPresenter mainMenuPresenter = null;
       
        public MainForm()
        {
            InitializeComponent();
            this.userControlListViewMembers1.Hide();
            this.userControlHome1.Show();
            mainMenuPresenter = new MainMenuPresenter(this);
            //mainMenuPresenter.getDataAttendances();
        }

        public UserControlListViewMembers listViewUserControl { get { return this.userControlListViewMembers1; } set { this.userControlListViewMembers1 = value; } }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            mainMenuPresenter.getDataAttendances();
            this.userControlHome1.Hide();
            this.userControlListViewMembers1.Show();
        }
    }  
}
