using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WindowsFormsApp11.API.Enums;
using WindowsFormsApp11.API.genericRequest;
using WindowsFormsApp11.API.genericResponse;
using WindowsFormsApp11.Components.PostPutDelGeneric;

namespace WindowsFormsApp11.Components.Share.CustomListView
{
    public partial class UserControlCustonListView : UserControl
    {

        float columnWidth;
        float columnTotalWidth;
        float heighCenter;
        string HeaderText;
        public event EventHandler requestHandler;
        List<GenericRequest> formFields;


        public UserControlCustonListView()
        {
            InitializeComponent();
        }


        public void buildScreen(List<GenericRequest> genericRequest, string data, string HeaderText, EndPointsAPI endpoint, HttpType accion) {

            this.formFields = genericRequest;
            this.HeaderText = HeaderText;
            getMeasurements(genericRequest, data);
            arrangeListView(genericRequest, data);
            arrangeButtons();
            arrangeLabel();
            setDataTable(data, endpoint, accion);
        }


 

        public void setDataTable(string data,EndPointsAPI endpoint ,HttpType accion)
        {
            Console.WriteLine("Response API:");
            Utils.Utils.printValues(data);
            this.radListView1.Items.Clear();
            switch (endpoint) {

                case EndPointsAPI.EquipmentTypes:
                    if (accion == HttpType.GET) {
                        GenericResponse<EquipmentTypesResponse> response = JsonConvert.DeserializeObject<GenericResponse<EquipmentTypesResponse>>(data); ;
                        setValuesOnTable(JsonConvert.SerializeObject(response));

                    }
                    break;
                    case EndPointsAPI.MembersShips:
                    if (accion == HttpType.GET)
                    {
                        GenericResponse<MemberShipsResponse> response = JsonConvert.DeserializeObject<GenericResponse<MemberShipsResponse>>(data); ;
                        setValuesOnTable(JsonConvert.SerializeObject(response));

                    }
                    break;

                case EndPointsAPI.Members:
                    if (accion == HttpType.GET) {
                        GenericResponse<MembersResponse> response = JsonConvert.DeserializeObject<GenericResponse<MembersResponse>>(data);
                        setValuesOnTable(JsonConvert.SerializeObject(response));
                    }
                    break;
                case EndPointsAPI.Attendance:
                    if (accion == HttpType.GET)
                    {
                        //TODO aqui como tiene el json response un segundo nievel habria que hacer algo recursivo
                        GenericResponse<AttendanceResponse> response = JsonConvert.DeserializeObject<GenericResponse<AttendanceResponse>>(data); ;
                        setValuesOnTable(JsonConvert.SerializeObject(response));

                    }
                    break;

                case EndPointsAPI.Users:
                    if (accion == HttpType.GET)
                    {
                        GenericResponse<UsersResponse> response = JsonConvert.DeserializeObject<GenericResponse<UsersResponse>>(data);
                        setValuesOnTable(JsonConvert.SerializeObject(response));

                    }
                    break;

            }
        }

        private void setValuesOnTable(string jsonResponse)
        {

            //Tipo de objeto para agregar filas al listView control
            ListViewDataItem dataItem = null;
            //Convierto el modelo de cada response
            Dictionary<string,object> dic = JsonConvert.DeserializeObject<Dictionary<string,object>>(jsonResponse);
            // Se extrae el puedo modelo que contiene la lista de valores 
            List<Dictionary<string, object>> modelMap =  JArray.Parse(JsonConvert.SerializeObject(dic["model"])).ToObject<List<Dictionary<string, object>>>();
            //Obtengo el filtro para ver cuales campos se van a ver en la tabla
            List<GenericRequest> fieldsOnTable = formFields.Where(genericRequest => genericRequest.ControlSeccion.Contains(ControlSeccion.TABLE)).ToList();
            //Diccionario aux para ir guardando los valores de la fila
            Dictionary<string, string> keyValues;
            //Lista donde se van guardando los diccionarios
            List<Dictionary<string,string>> keyValuesList = new List<Dictionary<string,string>>();

            foreach (var mapResponse in modelMap) {

                keyValues = new Dictionary<string, string>();

                foreach (var fieldOnTable in fieldsOnTable) {
                    
                       string fieldOnTableKey = fieldOnTable.Key;

                    searchDeep(fieldOnTableKey,mapResponse, keyValues);

                    //foreach (var keyMapResponse in mapResponse.Keys) {

                    //    if (fieldOnTableKey == keyMapResponse ) {
                    //        keyValues.Add(keyMapResponse, (string)mapResponse[keyMapResponse].ToString());

                    //    }
                    //}
                }
                keyValuesList.Add(keyValues);
            }

            for (int i = 0; i < keyValuesList.Count; i++)
            {

                var dicc = keyValuesList[i];
                dataItem = new ListViewDataItem("ListView" + i, dicc.Values.ToArray());
                dataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                this.radListView1.Items.Add(dataItem);

            }



        }


        private void searchDeep(string keyTable,Dictionary<string,object> model, Dictionary<string, string> keyValues) {


            foreach (var modelKey in model.Keys) {
                        
                Object value = model[modelKey];
                if (value.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                {


                    JObject jObject = (JObject)value;
                    Dictionary<string,object> dic =   jObject.ToObject<Dictionary<string, object>>();

                    searchDeep(keyTable, dic, keyValues);
                }
                else {

                    if (keyTable == modelKey) {

                        if(!keyValues.ContainsKey(keyTable))
                            keyValues.Add(modelKey,(string)model[modelKey].ToString());

                    }
                
                }
            
            
            }



        
        }

        private void getMeasurements(List<GenericRequest> headersColumns, Object data)
        {

             IEnumerable<GenericRequest> headersColumnsAux = headersColumns.Where((genericRequest) => genericRequest.ControlSeccion.Contains(ControlSeccion.TABLE)); 
            
            float columnWidth = (int)((this.Size.Width * 0.75))/ headersColumnsAux.ToList().Count;
            float columnTotalWidth = columnWidth * headersColumnsAux.ToList().Count;
            float heighCenter = this.Size.Height * 0.5F;

            this.columnWidth = columnWidth;
            this.columnTotalWidth = columnTotalWidth;
            this.heighCenter = heighCenter;



        }

        private void arrangeListView(List<GenericRequest> headersColumns, Object data) {

            this.radListView1.ViewType = ListViewType.DetailsView;
            this.radListView1.Columns.Clear();
            this.radListView1.ShowCheckBoxes = true;
            ListViewDetailColumn listViewDetailColumn;
            for (int i = 0; i < headersColumns.Count; i++) {

                

                GenericRequest columnName = headersColumns.ElementAt(i);
                if (!columnName.ControlSeccion.Contains(ControlSeccion.TABLE))
                    continue;

                listViewDetailColumn = new ListViewDetailColumn(columnName.TextLabel, columnName.TextLabel);
                listViewDetailColumn.HeaderText = columnName.TextLabel.ToUpper();
                listViewDetailColumn.MaxWidth = this.columnWidth;
                listViewDetailColumn.MinWidth = this.columnWidth;
                listViewDetailColumn.Width = this.columnWidth;
                this.radListView1.Columns.Add(listViewDetailColumn);
                
            }

            


            columnTotalWidth -= this.columnWidth;
            this.radListView1.Size = new Size((int)columnTotalWidth,(int)(columnTotalWidth * 0.50));
            this.radListView1.Location = new Point((int)(this.columnWidth * 0.05),(int)this.heighCenter);
            this.radListView1.Columns.ElementAt(this.radListView1.Columns.Count - 1).Visible = false;
            foreach (ListViewDetailColumn column in this.radListView1.Columns)
            {
                column.Owner.HeaderHeight = 40.00F;
            }

        }


        private void arrangeButtons() {

            var controls = this.Controls;
            int verticalSpaceButtons = 0;
            foreach (var control in controls) {

                if (control.GetType().ToString() == "Telerik.WinControls.UI.RadButton")
                {
                    RadButton button = (RadButton)control;
                    button.Size = new System.Drawing.Size((int)(this.columnWidth * 0.75F), (int)(this.columnWidth * 0.15F));
                    button.Location = new System.Drawing.Point((int)(this.columnTotalWidth + this.columnWidth * 0.10),(int)this.heighCenter + (verticalSpaceButtons += (int)(this.columnWidth * 0.20F)));
                }
            }

        }

        private void arrangeLabel()
        {

            this.radLabel1.Text = this.HeaderText;
            this.radLabel1.Font = new Font(radLabel1.Font.FontFamily, 24);
            this.radLabel1.Location = new Point((int)(this.columnWidth * 0.05), (int)(this.heighCenter * 0.5));

        }


        private void requestHandlerUserControlListViewGeneric(object sender, EventArgs e ) {

           if(this.requestHandler != null)
                this.requestHandler(sender, e);
        
        
        }

        //BUTTON ADD
        private void radButton1_Click(object sender, EventArgs e)
        {
            PostFormGeneric postForm = new PostFormGeneric(formFields);
            postForm.requestHandler += new EventHandler(requestHandlerUserControlListViewGeneric);

            if (this.formFields.First().EndPointsAPI != EndPointsAPI.Attendance)
            {
              
                postForm.ShowDialog();
            }
            else {
                var itemsChecked = this.radListView1.CheckedItems;
                var firstItem = itemsChecked.First();
                string id = (string)firstItem[firstItem.FieldCount - 1];


                GenericRequest genericRequest = new GenericRequest("id", id, "id", this.formFields.First().EndPointsAPI, HttpType.POST);
                requestHandler.Invoke(new List<GenericRequest> { genericRequest }, null);


            }
        }

        //BUTTON DELETE
        private void radButton3_Click(object sender, EventArgs e)
        {
            var itemsChecked = this.radListView1.CheckedItems;
            string id = "";
            foreach (var itemChecked in itemsChecked) {
                       id = (string)itemChecked[itemChecked.FieldCount - 1];
            }

            GenericRequest genericRequest = new GenericRequest("id",id,"id",this.formFields.First().EndPointsAPI,HttpType.DELETE);
            requestHandler.Invoke(new List<GenericRequest> { genericRequest },null);
            

        }
        // BUTTON PUT   
        private void radButton2_Click(object sender, EventArgs e)
        {
            var itemsChecked = this.radListView1.CheckedItems; 

            GenericRequest genericRequest;
            List<GenericRequest> genericRequestList = new List<GenericRequest>();
            for (int i = 0; i < formFields.Count; i ++) {
                string columnName = formFields.ElementAt(i).TextLabel;//TextLabel es el nombre del campo en la tabla
                string key = formFields.ElementAt(i).Key;
                string value =(string) itemsChecked.First()[columnName];
                genericRequest = new GenericRequest(columnName,value,key,this.formFields.First().EndPointsAPI,HttpType.PUT);
                genericRequestList.Add(genericRequest);
                
            }

            
             string jsonRequest = JsonConvert.SerializeObject(genericRequestList);


            PostFormGeneric postForm = new PostFormGeneric(genericRequestList);
            postForm.requestHandler += new EventHandler(requestHandlerUserControlListViewGeneric);
            postForm.ShowDialog();


        }
    }
}
