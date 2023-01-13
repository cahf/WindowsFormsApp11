using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApp11.API.Enums;
using WindowsFormsApp11.API.genericRequest;
using WindowsFormsApp11.API.genericResponse;
using WindowsFormsApp11.Components.Usuarios;
using WindowsFormsApp11.Presenter.MainMenu;
using WindowsFormsApp11.View.MainMenu;

namespace WindowsFormsApp11.Components.MainView
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm, IMainMenuView
    {
        readonly MainMenuPresenter mainMenuPresenter = null;
        readonly int screenWidth;
        readonly int screenHeigh;

      

        public MainForm()
        {
            InitializeComponent();
            this.userControlListViewMembers1.Hide();
            this.userControlUsers1.Hide();
            this.userControlCustonListView1.Hide();
            this.userControlHome1.Show();
            mainMenuPresenter = new MainMenuPresenter(this);
            screenWidth = Screen.FromControl(this).Bounds.Width;
            screenHeigh = Screen.FromControl(this).Bounds.Height;
            this.userControlCustonListView1.requestHandler += new EventHandler(requestHandler);



            //mainMenuPresenter.getDataAttendances();
        }

        public UserControlListViewMembers listViewUserControl { get { return this.userControlListViewMembers1; } set { this.userControlListViewMembers1 = value; } }

        public UserControlUsers UsersUserControl { get { return this.userControlUsers1; } set { this.userControlUsers1 = value; } }

        public MainMenuPresenter MainMenuPresenter => mainMenuPresenter;

        private void radMenuItem2_Click(object sender, EventArgs e)
        {

        }
        // MIEMBROS MIEMBROS
        private  async void radMenuItem4_Click(object sender, EventArgs e)
        {
            this.userControlHome1.Hide();
            string data = await MainMenuPresenter.makeRequest("", EndPointsAPI.Members, HttpType.GET);
            this.userControlCustonListView1.buildScreen(new List<GenericRequest> {
                new GenericRequest("Nombre", null, "name", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.POST),
                new GenericRequest("Apellido(s)", null, "lastName", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.POST),
                new GenericRequest("Fecha nacimiento", null, "birthDay", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.POST),
                new GenericRequest("Correo", null, "email", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.POST),
                new GenericRequest("Publicidad", null, "allowNewsLetter", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.POST),
                new GenericRequest("Fecha registro", null, "registeredOn", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.POST),
                new GenericRequest("Termina membresia", null, "membershipEnd", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.POST),
                new GenericRequest("ciudadId", null, "cityId", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.POST),
                new GenericRequest("membershipId", null, "membershipTypeId", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.POST),

            }, data, "Miembros", API.Enums.EndPointsAPI.Members, API.Enums.HttpType.GET);

            //POSITION 
            this.userControlCustonListView1.Size = new Size((int)(this.screenWidth * 1), (int)(this.screenHeigh * 0.50));
            this.userControlCustonListView1.Location = new Point(0, 50);
            this.userControlCustonListView1.Show();
        }
        // MIEMBROS RENOVACION DE MEMBRESIAS
        private async void radMenuItem5_Click(object sender, EventArgs e)
        {
            this.userControlHome1.Hide();
            string data = await MainMenuPresenter.makeRequest("", EndPointsAPI.MembersShips, HttpType.GET);
            this.userControlCustonListView1.buildScreen(new List<GenericRequest> {
                new GenericRequest("Nombre", null, "name", API.Enums.EndPointsAPI.MembersShips, API.Enums.HttpType.POST),
                new GenericRequest("Costo", null, "cost", API.Enums.EndPointsAPI.MembersShips, API.Enums.HttpType.POST),
                new GenericRequest("Duracion", null, "duration", API.Enums.EndPointsAPI.MembersShips, API.Enums.HttpType.POST),
                new GenericRequest("Fecha cracion", null, "createdOn", API.Enums.EndPointsAPI.MembersShips, API.Enums.HttpType.POST),
                new GenericRequest("id", null, "id", API.Enums.EndPointsAPI.MembersShips, API.Enums.HttpType.POST),

            }, data, "Membresias", API.Enums.EndPointsAPI.MembersShips, API.Enums.HttpType.GET);

            //POSITION 
            this.userControlCustonListView1.Size = new Size((int)(this.screenWidth * 1), (int)(this.screenHeigh * 0.50));
            this.userControlCustonListView1.Location = new Point(0, 50);
            this.userControlCustonListView1.Show();

        }
        // MIEMBROS ENTRADAS Y SALIDAS
        private  async void radMenuItem6_Click(object sender, EventArgs e)
        {

        }
        // ADMINISTRACION USUARIOS
        private void radMenuItem11_Click(object sender, EventArgs e)
        {

        }
         // ADMINISTRACION TIPOS 
        private void radMenuItem10_Click(object sender, EventArgs e)
        {
  

        }
        // ADMINISTRACION MEMEBRESIAS
        private void radMenuItem9_Click(object sender, EventArgs e)
        {

        }
        // ADMINISTRACION EQUIPO
        private async void radMenuItem8_Click(object sender, EventArgs e)
        {
            this.userControlHome1.Hide();
            string data = await  MainMenuPresenter.makeRequest("",EndPointsAPI.EquipmentTypes,HttpType.GET);
            //Construct  LISTVIEW 
            this.userControlCustonListView1.buildScreen(new List<GenericRequest>  { new GenericRequest("nombre",null,"name",API.Enums.EndPointsAPI.EquipmentTypes,API.Enums.HttpType.POST), new GenericRequest("Descripcion", null, "description", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), new GenericRequest("id", null, "id", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), }, data, "Tipos de equipamento" ,API.Enums.EndPointsAPI.EquipmentTypes ,API.Enums.HttpType.GET);
            //POSITION 
            this.userControlCustonListView1.Size = new Size((int)(this.screenWidth * 1), (int)(this.screenHeigh * 0.50));
            this.userControlCustonListView1.Location = new Point(0, 50);
            this.userControlCustonListView1.Show();
        }

        public void DeleteData(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public async void requestHandler(object sender, EventArgs e)
        {

            List<GenericRequest> lista = (List<GenericRequest>)sender;
            HttpType httpType =  lista[0].HttpType;
            EndPointsAPI endpoint = lista[0].EndPointsAPI;

            switch (endpoint) {

                case EndPointsAPI.EquipmentTypes:

                    if (httpType == HttpType.POST) {

                        string jsonRequest = createRequest(lista, HttpType.POST);
                        string response = await MainMenuPresenter.makeRequest(jsonRequest, EndPointsAPI.EquipmentTypes, HttpType.POST);
                        string dataTable = await MainMenuPresenter.getEquipmentTypesAsync();
                        this.userControlCustonListView1.setDataTable(dataTable, EndPointsAPI.EquipmentTypes, HttpType.GET);
                    } else if (httpType == HttpType.DELETE) {

                        string response = await MainMenuPresenter.makeRequest(lista[0].Value, EndPointsAPI.EquipmentTypes, HttpType.DELETE);
                        string dataTable = await MainMenuPresenter.getEquipmentTypesAsync();
                        this.userControlCustonListView1.setDataTable(dataTable, EndPointsAPI.EquipmentTypes, HttpType.GET);
                    } else if (httpType == HttpType.PUT) {

                        string id = "";
                        Dictionary<string, object> dic = new Dictionary<string, object>();
                        lista.ForEach((element)=>{
                            if (element.Key == "id")
                                id = element.Value;
                            else
                                dic.Add(element.Key, element.Value);
                        });
                        string jsonRequest = JsonConvert.SerializeObject(dic);
                        string response = await MainMenuPresenter.makeRequest(jsonRequest, EndPointsAPI.EquipmentTypes, HttpType.PUT, id);
                        string dataTable = await MainMenuPresenter.getEquipmentTypesAsync();
                        this.userControlCustonListView1.setDataTable(dataTable, EndPointsAPI.EquipmentTypes, HttpType.GET);

                    }

                    
                    break;
                case EndPointsAPI.MembersShips:

                    if (httpType == HttpType.POST) {
                        string jsonRequest = createRequest(lista, HttpType.POST);
                        string response = await MainMenuPresenter.makeRequest(jsonRequest, EndPointsAPI.MembersShips, HttpType.POST);
                        string dataTable = await MainMenuPresenter.makeRequest("", EndPointsAPI.MembersShips, HttpType.GET);
                        this.userControlCustonListView1.setDataTable(dataTable, EndPointsAPI.MembersShips, HttpType.GET);
                    }
                    else if (httpType == HttpType.DELETE) {
                        string response = await MainMenuPresenter.makeRequest(lista[0].Value, EndPointsAPI.MembersShips, HttpType.DELETE);
                        string dataTable = await MainMenuPresenter.makeRequest("", EndPointsAPI.MembersShips, HttpType.GET);
                        this.userControlCustonListView1.setDataTable(dataTable, EndPointsAPI.MembersShips, HttpType.GET);
                    }
                    else if (httpType == HttpType.PUT) {
                        string id = "";
                        Dictionary<string, object> dic = new Dictionary<string, object>();
                        lista.ForEach((element) => {
                            if (element.Key == "id")
                                id = element.Value;
                            else
                                dic.Add(element.Key, element.Value);
                        });
                        string jsonRequest = JsonConvert.SerializeObject(dic);
                        string response = await MainMenuPresenter.makeRequest(jsonRequest, EndPointsAPI.MembersShips, HttpType.PUT, id);
                        string dataTable = await MainMenuPresenter.makeRequest("", EndPointsAPI.MembersShips, HttpType.GET);
                        this.userControlCustonListView1.setDataTable(dataTable, EndPointsAPI.MembersShips, HttpType.GET);

                    }



                    break;
            }


        }

        private string createRequest(List<GenericRequest> lista, HttpType accion)
        {
            Dictionary<string,string> jsonRequest  = new Dictionary<string,string>();
            string jsonRequestString = "";
            foreach (GenericRequest item in lista) {
                jsonRequest.Add(item.Key, item.Value);

            }

            if (accion != HttpType.PUT)
                jsonRequest.Remove("id");

            return jsonRequestString =   JsonConvert.SerializeObject(jsonRequest);

        }

        public void UpdateData(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }  
}
