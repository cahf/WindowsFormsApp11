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
using WindowsFormsApp11.API.request;

namespace WindowsFormsApp11.Components
{
    public partial class UserControlListViewMembers : UserControl
    {
        public UserControlListViewMembers()
        {
            InitializeComponent();

            ListViewColumnCollection columns = this.radListView1.Columns;

            int screenWidth = Screen.FromControl(this).Bounds.Width;
            int screenHeigh = Screen.FromControl(this).Bounds.Height;
            



            foreach (ListViewDetailColumn column in columns) {

                column.MaxWidth = 100.00F;
                column.Width = 100.00F;
                column.Owner.HeaderHeight = 40.00F;                
            }

            ListViewDataItemCollection rows = this.radListView1.Items;

            this.radListView1.ItemSize = new Size(0,50);
            this.radListView1.Height = (int)(screenHeigh * 0.50);

            foreach (ListViewDataItem row in rows) {
            
                   //row.wi
            
            }

            this.radListView1.Columns.ElementAt(this.radListView1.Columns.Count - 1).Visible = false;
            this.radListView1.Width = (int)(screenWidth * 0.90);
            this.radButtonAttendanceDelete.Location = new Point(new Size((int)(screenWidth * 0.92), (int)(screenHeigh * 0.22)));


            this.radListView1.Location = new System.Drawing.Point(17, 200);





        }

        public void setAttendances(AttendancesResponse data) {
            ListViewDataItem listViewDataItem = null;
            //"Nombre "
            //"Fecha de nacimiento"
            //"Entrada"
            //"Salida"
            //"Id"
                for (int i = 0; i < data.Model.Length; i++) {
                    Model model = data.Model[i];
                    listViewDataItem = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem " + i , new string[] {
                    model.Member.Name + " " + model.Member.LastName ,
                    model.Member.BirthDay.ToString(),
                    model.DateIn.ToString(),
                    model.DateOut.ToString(),
                    model.Member.Id.ToString()
                    
                    });
            }
            listViewDataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radListView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem});


        }

        private void radListView1_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
                
          

            ListViewDataItem dataItem = e.Item;
            string value =  (string) dataItem[dataItem.FieldCount - 1];
        }

        private void radButtonAttendanceDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
