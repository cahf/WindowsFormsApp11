using System.Windows.Forms;

namespace WindowsFormsApp11.Components.MainView
{
    partial class MainForm
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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            this.userControlHome1 = new WindowsFormsApp11.Components.UserControlHome();
            this.userControlListViewMembers1 = new WindowsFormsApp11.Components.UserControlListViewMembers();
            this.userControlCustonListView1 = new WindowsFormsApp11.Components.Share.CustomListView.UserControlCustonListView();
            this.userControlUsers1 = new WindowsFormsApp11.Components.Usuarios.UserControlUsers(screenWidth, screenHeigh);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem7});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Margin = new System.Windows.Forms.Padding(162, 162, 162, 162);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1369, 32);
            this.radMenu1.TabIndex = 0;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "GYM MANAGER";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "HOME";
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem4,
            this.radMenuItem5,
            this.radMenuItem6});
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "MIEMBROS";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Miembros o usuarios cliente";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Renovacion de membresias";
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Entrada y Salida";
            this.radMenuItem6.Click += new System.EventHandler(this.radMenuItem6_Click);
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem8,
            this.radMenuItem9,
            this.radMenuItem10,
            this.radMenuItem11});
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Administracion";
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Equipo";
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Membresias";
            this.radMenuItem9.Click += new System.EventHandler(this.radMenuItem9_Click);
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "Tipos";
            this.radMenuItem10.Click += new System.EventHandler(this.radMenuItem10_Click);
            // 
            // radMenuItem11
            // 
            this.radMenuItem11.Name = "radMenuItem11";
            this.radMenuItem11.Text = "Usuarios";
            this.radMenuItem11.Click += new System.EventHandler(this.radMenuItem11_Click);
            // 
            // userControlHome1
            // 
            this.userControlHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlHome1.Location = new System.Drawing.Point(0, 32);
            this.userControlHome1.Name = "userControlHome1";
            this.userControlHome1.Size = new System.Drawing.Size(1369, 906);
            this.userControlHome1.TabIndex = 2;
            // 
            // userControlListViewMembers1
            // 
            this.userControlListViewMembers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlListViewMembers1.Location = new System.Drawing.Point(0, 32);
            this.userControlListViewMembers1.Name = "userControlListViewMembers1";
            this.userControlListViewMembers1.Size = new System.Drawing.Size(1369, 906);
            this.userControlListViewMembers1.TabIndex = 1;
            // 
            // userControlCustonListView1
            // 
            this.userControlCustonListView1.Location = new System.Drawing.Point(22, 361);
            this.userControlCustonListView1.Name = "userControlCustonListView1";
            this.userControlCustonListView1.Size = new System.Drawing.Size(1233, 476);
            this.userControlCustonListView1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 938);
            this.Controls.Add(this.userControlCustonListView1);
            this.Controls.Add(this.userControlHome1);
            this.Controls.Add(this.userControlListViewMembers1);
            this.Controls.Add(this.radMenu1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private UserControlListViewMembers userControlListViewMembers1;
        private UserControlHome userControlHome1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem11;
        private Usuarios.UserControlUsers userControlUsers1;
        private Share.CustomListView.UserControlCustonListView userControlCustonListView1;
    }
}
