﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.API.request;
using WindowsFormsApp11.Service;
using WindowsFormsApp11.View.MainMenu;

namespace WindowsFormsApp11.Presenter.MainMenu
{
    public class MainMenuPresenter
    {
        private readonly IMainMenuView _mainMenuView;

        public MainMenuPresenter(IMainMenuView menuView) {
                
            _mainMenuView = menuView;
        
        }

        public void getDataAttendances() {

          AttendancesResponse data = MainMenuService.getAttandances();
          this._mainMenuView.listViewUserControl.setAttendances(data);
        
        
        }
        





    }
}
