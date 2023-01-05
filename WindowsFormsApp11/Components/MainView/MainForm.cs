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
            this.userControlUsers1.Hide();
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
           

        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            mainMenuPresenter.getDataAttendances();
            this.userControlHome1.Hide();
            this.userControlUsers1.Hide();
            this.userControlListViewMembers1.Show();
            this.userControlListViewMembers1.Width = (int)(Screen.FromControl(this).Bounds.Width * 0.80);
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            //Vista DE ADMINISTRACION USUARIOS

            this.userControlHome1.Hide();
            this.userControlListViewMembers1.Hide();
            this.userControlUsers1.Show();

        }
    }  
}
