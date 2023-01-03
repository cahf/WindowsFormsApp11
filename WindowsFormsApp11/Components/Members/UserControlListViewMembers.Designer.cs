namespace WindowsFormsApp11.Components
{
    partial class UserControlListViewMembers
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Nombre ");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Fecha de nacimiento");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Correo");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Fecha registro");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 6", "Id");
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.userControlListViewMembersActions1 = new WindowsFormsApp11.Components.Members.UserControlListViewMembersActions();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            listViewDetailColumn1.HeaderText = "Nombre ";
            listViewDetailColumn1.MinWidth = 227.8125F;
            listViewDetailColumn1.Width = 2278.125F;
            listViewDetailColumn2.HeaderText = "Fecha de nacimiento";
            listViewDetailColumn2.MinWidth = 227.8125F;
            listViewDetailColumn2.Width = 2278.125F;
            listViewDetailColumn3.HeaderText = "Correo";
            listViewDetailColumn3.MinWidth = 227.8125F;
            listViewDetailColumn3.Width = 2278.125F;
            listViewDetailColumn4.HeaderText = "Fecha registro";
            listViewDetailColumn4.MinWidth = 227.8125F;
            listViewDetailColumn4.Width = 2278.125F;
            listViewDetailColumn5.HeaderText = "Id";
            listViewDetailColumn5.MinWidth = 227.8125F;
            listViewDetailColumn5.Width = 2278.125F;
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5});
            this.radListView1.GroupIndent = 291;
            this.radListView1.GroupItemSize = new System.Drawing.Size(2280, 230);
            this.radListView1.HeaderHeight = 398.6719F;
            this.radListView1.ItemSize = new System.Drawing.Size(2280, 230);
            this.radListView1.ItemSpacing = -1;
            this.radListView1.Location = new System.Drawing.Point(0, 162);
            this.radListView1.Margin = new System.Windows.Forms.Padding(21, 21, 21, 21);
            this.radListView1.Name = "radListView1";
            this.radListView1.ShowCheckBoxes = true;
            this.radListView1.Size = new System.Drawing.Size(738, 442);
            this.radListView1.TabIndex = 0;
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.radListView1.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.radListView1_ItemCheckedChanged);
            ((Telerik.WinControls.UI.DetailListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).GroupIndent = 291;
            ((Telerik.WinControls.UI.DetailListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).ItemSize = new System.Drawing.Size(2280, 230);
            ((Telerik.WinControls.UI.DetailListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).GroupItemSize = new System.Drawing.Size(2280, 230);
            ((Telerik.WinControls.UI.DetailListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).DefaultSize = new System.Drawing.Size(100, 100);
            ((Telerik.WinControls.UI.DetailListViewColumnContainer)(this.radListView1.GetChildAt(0).GetChildAt(0).GetChildAt(3))).AutoSize = true;
            ((Telerik.WinControls.UI.DetailListViewColumnContainer)(this.radListView1.GetChildAt(0).GetChildAt(0).GetChildAt(3))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.DetailListViewColumnContainer)(this.radListView1.GetChildAt(0).GetChildAt(0).GetChildAt(3))).StretchHorizontally = true;
            // 
            // userControlListViewMembersActions1
            // 
            this.userControlListViewMembersActions1.Location = new System.Drawing.Point(1192, 204);
            this.userControlListViewMembersActions1.Name = "userControlListViewMembersActions1";
            this.userControlListViewMembersActions1.Size = new System.Drawing.Size(230, 348);
            this.userControlListViewMembersActions1.TabIndex = 1;
            // 
            // UserControlListViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlListViewMembersActions1);
            this.Controls.Add(this.radListView1);
            this.Name = "UserControlListViewMembers";
            this.Size = new System.Drawing.Size(1640, 779);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Members.UserControlListViewMembersActions userControlListViewMembersActions1;
    }
}
