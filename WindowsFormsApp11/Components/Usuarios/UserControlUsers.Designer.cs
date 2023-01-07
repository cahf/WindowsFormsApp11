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
            this.radButtonAddUsers = new Telerik.WinControls.UI.RadButton();
            this.radButtonEditUsers = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radListViewGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtoRemoveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEditUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // radListViewGeneral
            // 
            this.radListViewGeneral.GroupIndent = 129;
            this.radListViewGeneral.GroupItemSize = new System.Drawing.Size(1013, 102);
            this.radListViewGeneral.HeaderHeight = 177.1875F;
            this.radListViewGeneral.ItemSize = new System.Drawing.Size(1013, 102);
            this.radListViewGeneral.Location = new System.Drawing.Point(1048, 486);
            this.radListViewGeneral.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.radListViewGeneral.Name = "radListViewGeneral";
            this.radListViewGeneral.Size = new System.Drawing.Size(1462, 760);
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
            this.radButtoRemoveUsers.Location = new System.Drawing.Point(772, 279);
            this.radButtoRemoveUsers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radButtoRemoveUsers.Name = "radButtoRemoveUsers";
            this.radButtoRemoveUsers.Size = new System.Drawing.Size(165, 36);
            this.radButtoRemoveUsers.TabIndex = 2;
            this.radButtoRemoveUsers.Text = "Borrar";
            this.radButtoRemoveUsers.Click += new System.EventHandler(this.radButtoRemoveUsers_Click);
            // 
            // radButtonAddUsers
            // 
            this.radButtonAddUsers.Location = new System.Drawing.Point(772, 346);
            this.radButtonAddUsers.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.radButtonAddUsers.Name = "radButtonAddUsers";
            this.radButtonAddUsers.Size = new System.Drawing.Size(165, 39);
            this.radButtonAddUsers.TabIndex = 3;
            this.radButtonAddUsers.Text = "Agregar";
            this.radButtonAddUsers.Click += new System.EventHandler(this.radButtonAddUsers_Click);
            // 
            // radButtonEditUsers
            // 
            this.radButtonEditUsers.Location = new System.Drawing.Point(772, 412);
            this.radButtonEditUsers.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.radButtonEditUsers.Name = "radButtonEditUsers";
            this.radButtonEditUsers.Size = new System.Drawing.Size(165, 43);
            this.radButtonEditUsers.TabIndex = 4;
            this.radButtonEditUsers.Text = "Editar";
            this.radButtonEditUsers.Click += new System.EventHandler(this.radButtonEditUsers_Click);
            // 
            // UserControlUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.radButtonEditUsers);
            this.Controls.Add(this.radButtonAddUsers);
            this.Controls.Add(this.radButtoRemoveUsers);
            this.Controls.Add(this.userControlHomeWelcome1);
            this.Controls.Add(this.radListViewGeneral);
            this.Name = "UserControlUsers";
            this.Size = new System.Drawing.Size(1348, 484);
            ((System.ComponentModel.ISupportInitialize)(this.radListViewGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtoRemoveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEditUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListViewGeneral;
        private Home.UserControlHomeWelcome userControlHomeWelcome1;
        private Telerik.WinControls.UI.RadButton radButtoRemoveUsers;
        private Telerik.WinControls.UI.RadButton radButtonAddUsers;
        private Telerik.WinControls.UI.RadButton radButtonEditUsers;
    }
}
