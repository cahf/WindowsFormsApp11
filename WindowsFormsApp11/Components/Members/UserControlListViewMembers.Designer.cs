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
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("ListViewItem 1", new string[] {
            "Carlos ",
            "18",
            "Calle #413 Col.San pedro martir",
            "ayer"});
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            listViewDetailColumn1.HeaderText = "Nombre ";
            listViewDetailColumn1.MinWidth = 67.5F;
            listViewDetailColumn1.Width = 675F;
            listViewDetailColumn2.HeaderText = "Fecha de nacimiento";
            listViewDetailColumn2.MinWidth = 67.5F;
            listViewDetailColumn2.Width = 675F;
            listViewDetailColumn3.HeaderText = "Correo";
            listViewDetailColumn3.MinWidth = 67.5F;
            listViewDetailColumn3.Width = 675F;
            listViewDetailColumn4.HeaderText = "Fecha registro";
            listViewDetailColumn4.MinWidth = 67.5F;
            listViewDetailColumn4.Width = 675F;
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.GroupIndent = 86;
            this.radListView1.GroupItemSize = new System.Drawing.Size(675, 68);
            this.radListView1.HeaderHeight = 118.125F;
            listViewDataItem1.Text = "ListViewItem 1";
            listViewDataItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radListView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1});
            this.radListView1.ItemSize = new System.Drawing.Size(675, 68);
            this.radListView1.ItemSpacing = -1;
            this.radListView1.Location = new System.Drawing.Point(0, 0);
            this.radListView1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.radListView1.Name = "radListView1";
            this.radListView1.ShowCheckBoxes = true;
            this.radListView1.Size = new System.Drawing.Size(1463, 779);
            this.radListView1.TabIndex = 0;
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // UserControlListViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radListView1);
            this.Name = "UserControlListViewMembers";
            this.Size = new System.Drawing.Size(1463, 779);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
    }
}
