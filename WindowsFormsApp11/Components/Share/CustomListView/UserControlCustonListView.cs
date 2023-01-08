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

namespace WindowsFormsApp11.Components.Share.CustomListView
{
    public partial class UserControlCustonListView : UserControl
    {

        float columnWidth;
        float columnTotalWidth;
        float heighCenter;
        public UserControlCustonListView()
        {
            InitializeComponent();
        }
   

        public void buildScreen(string[] headersColumns, Object data) {

            getMeasurements(headersColumns, data);
            arrangeListView(headersColumns, data);
            arrangeButtons();
        }








        private void getMeasurements(string[] headersColumns, Object data)
        {

            float columnWidth = (int)((this.Size.Width * 0.75))/headersColumns.Length;
            float columnTotalWidth = columnWidth * headersColumns.Length;
            float heighCenter = this.Size.Height * 0.5F;

            this.columnWidth = columnWidth;
            this.columnTotalWidth = columnTotalWidth;
            this.heighCenter = heighCenter;



        }

        private void arrangeListView(string[] headersColumns, Object data) {

            this.radListView1.ViewType = ListViewType.DetailsView;
            this.radListView1.ShowCheckBoxes = true;
            ListViewDetailColumn listViewDetailColumn;
            for (int i = 0; i < headersColumns.Length; i++) {

                string columnName = headersColumns[i];
                listViewDetailColumn = new ListViewDetailColumn(columnName, columnName);
                listViewDetailColumn.HeaderText = columnName.ToUpper();
                listViewDetailColumn.MaxWidth = this.columnWidth;
                listViewDetailColumn.MinWidth = this.columnWidth;
                listViewDetailColumn.Width = this.columnWidth;
                this.radListView1.Columns.Add(listViewDetailColumn);
                
            }

            


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
                    Console.WriteLine(control.GetType().ToString());
                    RadButton button = (RadButton)control;
                    button.Size = new System.Drawing.Size((int)(this.columnWidth * 0.75F), (int)(this.columnWidth * 0.15F));
                    button.Location = new System.Drawing.Point((int)(this.columnTotalWidth + this.columnWidth * 0.10),(int)this.heighCenter + (verticalSpaceButtons += (int)(this.columnWidth * 0.20F)));
                }
            }


          



        }
    }
}
