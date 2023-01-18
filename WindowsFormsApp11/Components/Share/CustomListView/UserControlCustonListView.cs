using Newtonsoft.Json;
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
   

        public void buildScreen(List<GenericRequest> genericRequest, string data,string HeaderText, EndPointsAPI endpoint,HttpType accion) {

            this.HeaderText = HeaderText;
            getMeasurements(genericRequest, data);
            arrangeListView(genericRequest, data);
            arrangeButtons();
            arrangeLabel();
            setDataTable(data, endpoint,accion);
            this.formFields = genericRequest;
        }

        public void setDataTable(string data,EndPointsAPI endpoint ,HttpType accion)
        {
            ListViewDataItem dataItem = null;
            this.radListView1.Items.Clear();
            switch (endpoint) {

                case EndPointsAPI.EquipmentTypes:
                    if (accion == HttpType.GET) {
                        GenericResponse<EquipmentTypesResponse> equipmentResponse = JsonConvert.DeserializeObject<GenericResponse<EquipmentTypesResponse>>(data); ;
                        for (int i = 0; i < equipmentResponse.ModelGeneric.Length; i++)
                        {
                            EquipmentTypesResponse model = equipmentResponse.ModelGeneric[i];
                            dataItem = new ListViewDataItem("ListView" + i, new string[] {
                        model.Name,
                        model.Description,
                        model.Id.ToString()
                        });
                            dataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                            this.radListView1.Items.Add(dataItem);
                        }
                    }
                    break;
                    case EndPointsAPI.MembersShips:
                    if (accion == HttpType.GET)
                    {
                        GenericResponse<MemberShipsResponse> equipmentResponse = JsonConvert.DeserializeObject<GenericResponse<MemberShipsResponse>>(data); ;
                        for (int i = 0; i < equipmentResponse.ModelGeneric.Length; i++)
                        {
                            MemberShipsResponse model = equipmentResponse.ModelGeneric[i];
                            dataItem = new ListViewDataItem("ListView" + i, new string[] {
                        model.Name,
                        model.Cost,
                        model.Duration,
                        model.CreatedOn,
                        model.Id.ToString()
                        });
                            dataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                            this.radListView1.Items.Add(dataItem);
                        }
                    }
                    break;

                case EndPointsAPI.Members:
                    if (accion == HttpType.GET) {
                        GenericResponse<MembersResponse> equipmentResponse = JsonConvert.DeserializeObject<GenericResponse<MembersResponse>>(data);
                        for (int i = 0; i < equipmentResponse.ModelGeneric.Length; i++)
                        {
                            MembersResponse model = equipmentResponse.ModelGeneric[i];
                            dataItem = new ListViewDataItem("ListView" + i, new string[] {
                        model.name,
                        model.lastName,
                        model.birthDay,
                        model.email,
                        model.allowNewsLetter,
                        model.registeredOn,
                        model.membershipEnd,
                        "1", //Todo siempre va Queretaro por que el API siempre regrese 0 
                        "3",//Todo siempre va la membresia con id igual a 3 por el API solo regresa 0
                        model.Id.ToString()
                        });
                            dataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                            this.radListView1.Items.Add(dataItem);
                        }
                    }
                    break;
                case EndPointsAPI.Attendance:
                    if (accion == HttpType.GET)
                    {
                        GenericResponse<AttendanceResponse> equipmentResponse = JsonConvert.DeserializeObject<GenericResponse<AttendanceResponse>>(data); ;
                        for (int i = 0; i < equipmentResponse.ModelGeneric.Length; i++)
                        {
                            Member model = equipmentResponse.ModelGeneric[i].Member;
                            dataItem = new ListViewDataItem("ListView" + i, new string[] {
                        model.Name,
                        model.LastName,
                        model.BirthDay.ToString(),
                        model.MembershipEnd.ToString(),
                        model.Id.ToString()
                        });
                            dataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                            this.radListView1.Items.Add(dataItem);
                        }
                    }
                    break;

                case EndPointsAPI.Users:
                    if (accion == HttpType.GET)
                    {
                        GenericResponse<UsersResponse> equipmentResponse = JsonConvert.DeserializeObject<GenericResponse<UsersResponse>>(data); ;
                        for (int i = 0; i < equipmentResponse.ModelGeneric.Length; i++)
                        {
                            UsersResponse model = equipmentResponse.ModelGeneric[i];
                            dataItem = new ListViewDataItem("ListView" + i, new string[] {
                        model.UserName,
                        model.PhoneNumber,
                        model.Email,
                        model.Id.ToString()
                        });
                            dataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                            this.radListView1.Items.Add(dataItem);
                        }
                    }
                    break;

            }
        }

        private void getMeasurements(List<GenericRequest> headersColumns, Object data)
        {

            float columnWidth = (int)((this.Size.Width * 0.75))/headersColumns.Count;
            float columnTotalWidth = columnWidth * headersColumns.Count;
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
