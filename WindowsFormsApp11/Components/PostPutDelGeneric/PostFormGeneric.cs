using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11.Components.PostPutDelGeneric
{
    public partial class PostFormGeneric : Form
    {
        public event EventHandler PostDataHandler;
        public PostFormGeneric()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            PostDataHandler.Invoke("Carlos alberto", null);
        }
    }
}
