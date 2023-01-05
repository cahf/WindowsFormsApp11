namespace WindowsFormsApp11.Components.Usuarios
{
    partial class UserControlUsers
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.radListViewGeneral = new Telerik.WinControls.UI.RadListView();
            this.userControlHomeWelcome1 = new WindowsFormsApp11.Components.Home.UserControlHomeWelcome();
            this.radButtoRemoveUsers = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radListViewGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtoRemoveUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // radListViewGeneral
            // 
            this.radListViewGeneral.GroupIndent = 86;
            this.radListViewGeneral.GroupItemSize = new System.Drawing.Size(675, 68);
            this.radListViewGeneral.HeaderHeight = 118.125F;
            this.radListViewGeneral.ItemSize = new System.Drawing.Size(675, 68);
            this.radListViewGeneral.Location = new System.Drawing.Point(699, 324);
            this.radListViewGeneral.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.radListViewGeneral.Name = "radListViewGeneral";
            this.radListViewGeneral.Size = new System.Drawing.Size(975, 507);
            this.radListViewGeneral.TabIndex = 0;
            this.radListViewGeneral.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.radListViewGeneral_ItemCheckedChanged);
            // 
            // userControlHomeWelcome1
            // 
            this.userControlHomeWelcome1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlHomeWelcome1.Location = new System.Drawing.Point(0, 0);
            this.userControlHomeWelcome1.Name = "userControlHomeWelcome1";
            this.userControlHomeWelcome1.Size = new System.Drawing.Size(1348, 144);
            this.userControlHomeWelcome1.TabIndex = 1;
            // 
            // radButtoRemoveUsers
            // 
            this.radButtoRemoveUsers.Location = new System.Drawing.Point(515, 186);
            this.radButtoRemoveUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radButtoRemoveUsers.Name = "radButtoRemoveUsers";
            this.radButtoRemoveUsers.Size = new System.Drawing.Size(110, 24);
            this.radButtoRemoveUsers.TabIndex = 2;
            this.radButtoRemoveUsers.Text = "Remove";
            this.radButtoRemoveUsers.Click += new System.EventHandler(this.radButtoRemoveUsers_Click);
            // 
            // UserControlUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.radButtoRemoveUsers);
            this.Controls.Add(this.userControlHomeWelcome1);
            this.Controls.Add(this.radListViewGeneral);
            this.Name = "UserControlUsers";
            this.Size = new System.Drawing.Size(1348, 484);
            ((System.ComponentModel.ISupportInitialize)(this.radListViewGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtoRemoveUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListViewGeneral;
        private Home.UserControlHomeWelcome userControlHomeWelcome1;
        private Telerik.WinControls.UI.RadButton radButtoRemoveUsers;
    }
}
