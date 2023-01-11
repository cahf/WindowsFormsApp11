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
        public event EventHandler PostDataHandler;
        public event EventHandler DeleteDataHandler;
        public event EventHandler PutDataHandler;
        List<GenericRequest> formFields;


        public UserControlCustonListView()
        {
            InitializeComponent();
        }
   

        public void buildScreen(List<GenericRequest> genericRequest, string data,string HeaderText, EquipmentType equipmentType) {

            this.HeaderText = HeaderText;
            getMeasurements(genericRequest, data);
            arrangeListView(genericRequest, data);
            arrangeButtons();
            arrangeLabel();
            setDataTable(data, equipmentType);
            this.formFields = genericRequest;
        }

        private void setDataTable(string data, EquipmentType equipmentType)
        {
            ListViewDataItem dataItem = null;
            switch (equipmentType) {

                case EquipmentType.GET:
                    GenericResponse<EquipmentTypesResponse> equipmentResponse = JsonConvert.DeserializeObject<GenericResponse<EquipmentTypesResponse>>(data); ;
                    for (int i = 0; i < equipmentResponse.ModelGeneric.Length; i++) {
                        EquipmentTypesResponse model = equipmentResponse.ModelGeneric[i];
                        dataItem = new ListViewDataItem("ListView"+i,new string[] {
                        model.Name,
                        model.Description,
                        model.Id.ToString()
                        });
                        dataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                        this.radListView1.Items.Add(dataItem);
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
            this.radListView1.ShowCheckBoxes = true;
            ListViewDetailColumn listViewDetailColumn;
            for (int i = 0; i < headersColumns.Count; i++) {

                GenericRequest columnName = headersColumns.ElementAt(i);
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


        private void postDataGeneric(object sender, EventArgs e ) {

           if(this.PostDataHandler != null)
                this.PostDataHandler(sender, e);
        
        
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            PostFormGeneric postForm = new PostFormGeneric(formFields);
            postForm.PostDataHandler += new EventHandler(postDataGeneric);
            postForm.ShowDialog();
        }
    }
}
