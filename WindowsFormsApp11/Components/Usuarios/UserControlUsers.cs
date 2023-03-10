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
using WindowsFormsApp11.API.response;
using WindowsFormsApp11.Components.Usuarios.Add;
using WindowsFormsApp11.Service;

namespace WindowsFormsApp11.Components.Usuarios
{
    public partial class UserControlUsers : UserControl
    {
        public UserControlUsers(int mainFormWidth,int mainFormHeigh)
        {
            InitializeComponent();
            string[] columns = new string[] {"Nombre","Correo","Celular","id"};
            ListViewDetailColumn listViewDetailColumn;
            this.radListViewGeneral.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.radListViewGeneral.ShowCheckBoxes = true;
            float tableWidth = 0;
            



            for (int i = 0; i < columns.Length; i++) {

                string column = columns[i];
                listViewDetailColumn = new ListViewDetailColumn(column, column);
                listViewDetailColumn.HeaderText = column.ToUpper();
                listViewDetailColumn.MaxWidth = 195F;
                listViewDetailColumn.MinWidth = 195F;
                listViewDetailColumn.Width = 195F;
                this.radListViewGeneral.Columns.Add(listViewDetailColumn);
                if(column != "id")
                tableWidth += listViewDetailColumn.Width;

            }

            this.radListViewGeneral.Size = new  System.Drawing.Size((int)tableWidth, this.radListViewGeneral.Size.Height);
            this.radListViewGeneral.Location = new System.Drawing.Point(0, 100);
            //this.Size = new System.Drawing.Size(50, 50);
            //this.Width = 50;
            //this.Size = new System.Drawing.Size(600, 484);

            this.radListViewGeneral.Columns.ElementAt(this.radListViewGeneral.Columns.Count - 1).Visible = false;
            //this.radButtoRemoveUsers.Location = new System.Drawing.Point(new Size(this.radListViewGeneral.Size.Width, this.radListViewGeneral.Size.Height));
            this.radButtoRemoveUsers.Location = new Point(this.radListViewGeneral.Size.Width + 10 ,(int)(this.Size.Height * 0.75));
            this.radButtonAddUsers.Location = new Point(this.radListViewGeneral.Size.Width + 10, (int)(this.Size.Height * 0.85));
            this.radButtonEditUsers.Location = new Point(this.radListViewGeneral.Size.Width + 10, (int)(this.Size.Height * 0.95));

            foreach (ListViewDetailColumn column in this.radListViewGeneral.Columns)
            {
                column.Owner.HeaderHeight = 40.00F;
            }



        }


        public void setUsers(UsersResponse data)
        {
            ListViewDataItem listViewDataItem = null;
            this.radListViewGeneral.Items.Clear();
            //"Nombre "
            //"Correo"
            //"Celuar"
            //"ID"
            for (int i = 0; i < data.ModelUser.Length; i++)
            {
                ModelUser model = data.ModelUser[i];
                listViewDataItem = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem" + i, new string[] {
                    model.UserName,
                    model.Email,
                    model.PhoneNumber,
                    model.Id.ToString(),

                    });
                listViewDataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                this.radListViewGeneral.Items.Add(listViewDataItem);
            }
          


        }

        private void radButtoRemoveUsers_Click(object sender, EventArgs e)
        {
            ListViewCheckedItemCollection itemsChecked = this.radListViewGeneral.CheckedItems;
            ListViewDataItem item = itemsChecked[0];
            string id = (string)item[item.FieldCount - 1];
           UsersDeleteResponse response  = MainMenuService.deleterUser(id);
            UsersResponse dataListView = MainMenuService.getUsersList();
            this.setUsers(dataListView);


        }

        private void radListViewGeneral_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            
        }

        private void radButtonAddUsers_Click(object sender, EventArgs e)
        {
            AddUsersForm mainForm = new AddUsersForm(this);
            mainForm.ShowDialog();
        }

        public async Task getDataUserAddFormAsync(string[] data,string idUser) {

            string numero = data[0];
            string correo = data[1];
            string password = data[2];
            string response = "";
            //string numero = "4425091809";
            //string correo = "carlos.hernandez@puntosingular.com";
            //string password = "{}{}CarlosAlberto246";

            UserAddResquest userData = new UserAddResquest(numero,password,correo);
            UserAddEditRequest userDataEdit = new UserAddEditRequest(numero,password,correo);
            if (idUser == null)
            {
                response = await MainMenuServiceAsync.AddUser(userData, idUser);
            }
            else {

                response = await MainMenuServiceAsync.AddUserEditar(userDataEdit, idUser);
            }
            UsersResponse dataListView = MainMenuService.getUsersList();
            this.setUsers(dataListView);
            Console.WriteLine("Respuesta post");
            Console.WriteLine(response);



        
        }

        private void radButtonEditUsers_Click(object sender, EventArgs e)
        {
            ListViewCheckedItemCollection itemsChecked = this.radListViewGeneral.CheckedItems;
            ListViewDataItem item = itemsChecked[0];
            string correo = (string)item[item.FieldCount - 4];
            string telefono = (string)item[item.FieldCount - 2];
            string password = " ";
            string id = (string)item[item.FieldCount - 1];
            AddUsersForm addUserForm = new AddUsersForm(this,telefono,password,correo,id);
            addUserForm.ShowDialog();


        }
    }
}
