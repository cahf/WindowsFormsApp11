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

                




        }

        public void setAttendances(AttendancesResponse data) {
            ListViewDataItem listViewDataItem = null;
            
                for (int i = 0; i < data.Model.Length; i++) {
                    Model model = data.Model[i];
                    listViewDataItem = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem " + i , new string[] {
                    model.Member.Name + " " + model.Member.LastName ,
                    model.Member.BirthDay.ToString(),
                    model.Member.Email,
                    model.Member.RegisteredOn.ToString()});
            }
            listViewDataItem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radListView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem});


        }


    }
}
