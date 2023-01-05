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

namespace WindowsFormsApp11.Components.Usuarios
{
    public partial class UserControlUsers : UserControl
    {
        public UserControlUsers(int mainFormWidth,int mainFormHeigh)
        {
            InitializeComponent();
            string[] columns = new string[] {"Nombre","Apellido","Edad"};
            ListViewDetailColumn listViewDetailColumn;
            this.radListViewGeneral.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            float tableWidth = 0;

            for (int i = 0; i < columns.Length; i++) {

                string column = columns[i];
                listViewDetailColumn = new ListViewDetailColumn(column, column);
                listViewDetailColumn.HeaderText = column.ToUpper();
                listViewDetailColumn.MaxWidth = 195F;
                listViewDetailColumn.MinWidth = 195F;
                listViewDetailColumn.Width = 195F;
                this.radListViewGeneral.Columns.Add(listViewDetailColumn);
                tableWidth += listViewDetailColumn.Width;

            }

            this.radListViewGeneral.Size = new  System.Drawing.Size((int)tableWidth, this.radListViewGeneral.Size.Height);
            this.radListViewGeneral.Location = new System.Drawing.Point(0, 100);
            //this.Size = new System.Drawing.Size(50, 50);
            //this.Width = 50;
            //this.Size = new System.Drawing.Size(600, 484);






        }
    }
}
