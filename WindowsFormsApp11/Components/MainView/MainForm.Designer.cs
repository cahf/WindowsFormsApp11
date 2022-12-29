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
            this.userControlListViewMembers1 = new WindowsFormsApp11.Components.UserControlListViewMembers();
            this.userControlHome1 = new WindowsFormsApp11.Components.UserControlHome();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
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
            this.radMenuItem5});
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "MIEMBROS";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Miembros o Usuarios Cliente";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Renovación de membresías";
            // 
            // userControlListViewMembers1
            // 
            this.userControlListViewMembers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlListViewMembers1.Location = new System.Drawing.Point(0, 32);
            this.userControlListViewMembers1.Name = "userControlListViewMembers1";
            this.userControlListViewMembers1.Size = new System.Drawing.Size(1369, 906);
            this.userControlListViewMembers1.TabIndex = 1;
            // 
            // userControlHome1
            // 
            this.userControlHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlHome1.Location = new System.Drawing.Point(0, 32);
            this.userControlHome1.Name = "userControlHome1";
            this.userControlHome1.Size = new System.Drawing.Size(1369, 906);
            this.userControlHome1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 938);
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
    }
}
