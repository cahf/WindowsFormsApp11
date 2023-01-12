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
            this.userControlHome1.Show();
            this.userControlCustonListView1.Hide();
            mainMenuPresenter = new MainMenuPresenter(this);
            screenWidth = Screen.FromControl(this).Bounds.Width;
            screenHeigh = Screen.FromControl(this).Bounds.Height;

  

            //mainMenuPresenter.getDataAttendances();
        }

        public UserControlListViewMembers listViewUserControl { get { return this.userControlListViewMembers1; } set { this.userControlListViewMembers1 = value; } }

        public UserControlUsers UsersUserControl { get { return this.userControlUsers1; } set { this.userControlUsers1 = value; } }

        public MainMenuPresenter MainMenuPresenter => mainMenuPresenter;

        private void radMenuItem2_Click(object sender, EventArgs e)
        {

        }
        // MIEMBROS MIEMBROS
        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            this.userControlHome1.Hide();
            this.userControlListViewMembers1.Hide();
            this.userControlUsers1.Hide();
            //Construct  LISTVIEW 
            //this.userControlCustonListView1.buildScreen(new List<GenericRequest> { new GenericRequest("nombre", null, "name", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), new GenericRequest("Descripcion", null, "description", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), }, null, "Miembros", API.Enums.HttpType.NONE);
            //POSITION 
            this.userControlCustonListView1.Size = new Size((int)(this.screenWidth * 1), (int)(this.screenHeigh * 0.50));
            this.userControlCustonListView1.Location = new Point(0, 50);
            this.userControlCustonListView1.Show();

        }
        // MIEMBROS RENOVACION DE MEMBRESIAS
        private void radMenuItem5_Click(object sender, EventArgs e)
        {

        }

        // MIEMBROS ENTRADAS Y SALIDAS
        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            MainMenuPresenter.getDataAttendances();
            this.userControlHome1.Hide();
            this.userControlUsers1.Hide();
            this.userControlCustonListView1.Hide();
            this.userControlListViewMembers1.Show();
            this.userControlListViewMembers1.Width = (int)(Screen.FromControl(this).Bounds.Width * 0.80);
        }
        // ADMINISTRACION USUARIOS
        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            

            this.userControlHome1.Hide();
            this.userControlListViewMembers1.Hide();
            this.userControlCustonListView1.Hide();
            this.userControlUsers1.Size = new Size((int)(this.screenWidth * 0.50), (int)(this.screenHeigh * 0.50));
            this.userControlUsers1.Location = new Point(0,50);
            MainMenuPresenter.getDataUsers();
            this.userControlUsers1.Show();

        }


         // ADMINISTRACION TIPOS 
        private void radMenuItem10_Click(object sender, EventArgs e)
        {
            this.userControlHome1.Hide();
            this.userControlListViewMembers1.Hide();
            this.userControlUsers1.Hide();
            //Construct  LISTVIEW 
            //this.userControlCustonListView1.buildScreen(new List<GenericRequest> { new GenericRequest("nombre", null, "name", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), new GenericRequest("Descripcion", null, "description", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), }, null,"Tipos de equipamento", API.Enums.HttpType.NONE);
            //POSITION 
            this.userControlCustonListView1.Size = new Size((int)(this.screenWidth * 1), (int)(this.screenHeigh * 0.50));
            this.userControlCustonListView1.Location = new Point(0,50);
            this.userControlCustonListView1.Show();

        }
        // ADMINISTRACION MEMEBRESIAS
        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            this.userControlHome1.Hide();
            this.userControlListViewMembers1.Hide();
            this.userControlUsers1.Hide();
            //Construct  LISTVIEW 
            //this.userControlCustonListView1.buildScreen(new List<GenericRequest> { new GenericRequest("nombre", null, "name", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), new GenericRequest("Descripcion", null, "description", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), }, null, "Membresias", API.Enums.HttpType.NONE);
            //POSITION 
            this.userControlCustonListView1.Size = new Size((int)(this.screenWidth * 1), (int)(this.screenHeigh * 0.50));
            this.userControlCustonListView1.Location = new Point(0, 50);
            this.userControlCustonListView1.Show();
        }
        // ADMINISTRACION EQUIPO
        private async void radMenuItem8_Click(object sender, EventArgs e)
        {
            this.userControlHome1.Hide();
            this.userControlListViewMembers1.Hide();
            this.userControlUsers1.Hide();
            string data = await  MainMenuPresenter.getEquipmentTypesAsync();
            //Construct  LISTVIEW 
            this.userControlCustonListView1.buildScreen(new List<GenericRequest>  { new GenericRequest("nombre",null,"name",API.Enums.EndPointsAPI.EquipmentTypes,API.Enums.HttpType.POST), new GenericRequest("Descripcion", null, "description", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), new GenericRequest("id", null, "id", API.Enums.EndPointsAPI.EquipmentTypes, API.Enums.HttpType.POST), }, data, "Tipos de equipamento" ,API.Enums.EndPointsAPI.EquipmentTypes ,API.Enums.HttpType.GET);
            this.userControlCustonListView1.PostDataHandler += new EventHandler(PostDataAsync);
            //POSITION 
            this.userControlCustonListView1.Size = new Size((int)(this.screenWidth * 1), (int)(this.screenHeigh * 0.50));
            this.userControlCustonListView1.Location = new Point(0, 50);
            this.userControlCustonListView1.Show();
        }

        public void DeleteData(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public async void PostDataAsync(object sender, EventArgs e)
        {

            List<GenericRequest> lista = (List<GenericRequest>)sender;
            HttpType httpType =  lista[0].HttpType;
            EndPointsAPI endpoint = lista[0].EndPointsAPI;

            switch (endpoint) {

                case EndPointsAPI.EquipmentTypes:

                    if (httpType == HttpType.POST) {

                        string jsonRequest = createRequest(lista,HttpType.POST);
                        string data = await MainMenuPresenter.makePostGeneric(jsonRequest, EndPointsAPI.EquipmentTypes,HttpType.POST);
                        string dataTable = await MainMenuPresenter.getEquipmentTypesAsync();
                        this.userControlCustonListView1.setDataTable(dataTable,EndPointsAPI.EquipmentTypes,HttpType.GET);
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
