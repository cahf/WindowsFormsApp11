using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.Components.Home
{
    public partial class UserControlHomeCarousel : UserControl
    {
        public UserControlHomeCarousel()
        {
            InitializeComponent();
            this.Width = Screen.FromControl(this).Bounds.Width;
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {

        }
    }
}
