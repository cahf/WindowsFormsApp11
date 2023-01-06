namespace WindowsFormsApp11.Components.Usuarios.Add
{
    partial class AddUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(43, 65);
            this.radTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(150, 31);
            this.radTextBox1.TabIndex = 0;
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(43, 146);
            this.radTextBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(150, 31);
            this.radTextBox2.TabIndex = 1;
            // 
            // radTextBox3
            // 
            this.radTextBox3.Location = new System.Drawing.Point(43, 223);
            this.radTextBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radTextBox3.Name = "radTextBox3";
            this.radTextBox3.Size = new System.Drawing.Size(150, 31);
            this.radTextBox3.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(43, 29);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(72, 28);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Numero";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(43, 106);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(61, 28);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Correo";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(43, 192);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(50, 28);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Clave";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(43, 295);
            this.radButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Agregar";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // AddUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 646);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radTextBox3);
            this.Controls.Add(this.radTextBox2);
            this.Controls.Add(this.radTextBox1);
            this.Name = "AddUsersForm";
            this.Text = "AddUsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBox3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}