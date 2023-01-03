using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.Components.Share
{
    public partial class UserControlFooter : UserControl
    {
        public UserControlFooter()
        {
            InitializeComponent();
            this.Width = Screen.FromControl(this).Bounds.Width;
        }


    }
}
