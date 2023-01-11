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
        string[] formFields;
        public PostFormGeneric(string[] formFields)
        {

            InitializeComponent();
            this.AdjustFormScrollbars(true);
            formFields = new string[] { "nombre","apellido", "edad","inicio","final"};
            this.formFields = formFields;
            this.buildForm();
        }

        private void buildForm() {
            Telerik.WinControls.UI.RadTextBox radTexbox;
            Telerik.WinControls.UI.RadLabel radLabel;  
            Telerik.WinControls.UI.RadButton radButton;
            int formWidth = this.Size.Width;
            int formHeight = this.Size.Height;
            int radTextboxWidth = 150;
            int verticalSpace = 0;
            int zindex = -1;
            verticalSpace += (int)(formHeight * 0.15);
            for (int i = 0; i < formFields.Length; i++) {
                radLabel = new Telerik.WinControls.UI.RadLabel();
                radTexbox = new Telerik.WinControls.UI.RadTextBox();
                ((System.ComponentModel.ISupportInitialize)(radLabel)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(radTexbox)).BeginInit();
                this.SuspendLayout();
                zindex++;
                verticalSpace += 36;
                //radlabel
                radLabel.Location = new System.Drawing.Point((int)((formWidth * 0.5) - radTextboxWidth), verticalSpace);
                radLabel.Name = formFields[i];
                radLabel.Size = new System.Drawing.Size(radTextboxWidth, 36);
                radLabel.TabIndex = zindex;
                radLabel.Text = formFields[i];
                //radTextbox
                verticalSpace += 36;
                zindex++;
                radTexbox.Location = new System.Drawing.Point((int)((formWidth * 0.5) - radTextboxWidth), verticalSpace);
                radTexbox.Name = formFields[i];
                radTexbox.Size = new System.Drawing.Size(radTextboxWidth, 36);
                radTexbox.TabIndex = zindex;
                radTexbox.Text = "";
                //radButton.Click += new System.EventHandler(this.radButton1_Click);

                this.Controls.Add(radLabel);
                this.Controls.Add(radTexbox);
                ((System.ComponentModel.ISupportInitialize)(radTexbox)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(radLabel)).EndInit();
            }

            verticalSpace += 50;
            zindex++;
            radButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(radButton)).BeginInit();
            this.SuspendLayout();
            radButton.Location = new System.Drawing.Point((int)((formWidth * 0.5) - radTextboxWidth), verticalSpace);
            radButton.Name = "radButtonAgregar";
            radButton.Size = new System.Drawing.Size((int)(radTextboxWidth * 0.75), 20);
            radButton.TabIndex = zindex;
            radButton.Text = "agregar";
            radButton.Click += new EventHandler(radButtonAgregar_Click);
            this.Controls.Add(radButton);
            ((System.ComponentModel.ISupportInitialize)(radButton)).EndInit();

            this.Size = new Size(this.Size.Width, 400);


            this.ResumeLayout(false);
            this.PerformLayout();
        }

  

        private void radButtonAgregar_Click(object sender, EventArgs e)
        {

            Dictionary<string,string> fieldValuePairs = new Dictionary<string,string>();

            for (int i = 0; i < this.formFields.Length; i++) {

                string fieldName = this.formFields[i];
                string fieldNameValue = getFieldNameValue(fieldName);
                fieldValuePairs.Add(fieldName, fieldNameValue);
            }

            Console.WriteLine(fieldValuePairs);
            PostDataHandler.Invoke("Carlos alberto", null);
        }

        private string getFieldNameValue(string fieldName)
        {
            var controls = this.Controls;
            var value = "";
            foreach (var control in controls) {
                if (control.GetType().ToString() == "Telerik.WinControls.UI.RadTextBox") {

                    Telerik.WinControls.UI.RadTextBox radTextbox = (Telerik.WinControls.UI.RadTextBox)control;
                    if (radTextbox.Name == fieldName) {

                        value = radTextbox.Text;

                    }

                
                }
            }
            return value;
        }
    }
}
