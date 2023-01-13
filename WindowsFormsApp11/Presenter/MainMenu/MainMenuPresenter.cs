using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.API.Enums;
using WindowsFormsApp11.API.genericResponse;
using WindowsFormsApp11.API.request;
using WindowsFormsApp11.API.response;
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

        public void getDataUsers() {

            UsersResponse data = MainMenuService.getUsersList();
            this._mainMenuView.UsersUserControl.setUsers(data);


        
        }


        // MENU ADMINISTRACION OPCION EQUIPO , API ES EquipmentTypes GET
        public async Task<string> getEquipmentTypesAsync() {

            string data = await MainMenuServiceAsync.getEquipmentTypes();



            return data;

        }

            //POST GENERIC
        public async Task<string> makePostGeneric(string jsonRequest, EndPointsAPI endpoint, HttpType accion, string id=null) {
            string data = await MainMenuServiceAsync.makePost(jsonRequest,endpoint,accion,id);
            return data;

        }

        public async Task<string> makeDeleteGeneric(string jsonRequest, EndPointsAPI endpoint, HttpType accion)
        {
            string data = await MainMenuServiceAsync.makePost(jsonRequest, endpoint, accion);
            return data;

        }






    }
}
