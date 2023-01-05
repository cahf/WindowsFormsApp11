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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Nombre ");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn7 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Fecha de nacimiento");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn8 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Entrada");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn9 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Salida");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn10 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 6", "Id");
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.label1 = new System.Windows.Forms.Label();
            this.radButtonAttendanceDelete = new Telerik.WinControls.UI.RadButton();
            this.userControlHomeWelcome1 = new WindowsFormsApp11.Components.Home.UserControlHomeWelcome();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAttendanceDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            listViewDetailColumn6.HeaderText = "Nombre ";
            listViewDetailColumn6.MaxWidth = 195F;
            listViewDetailColumn6.MinWidth = 195F;
            listViewDetailColumn6.Width = 195F;
            listViewDetailColumn7.HeaderText = "Fecha de nacimiento";
            listViewDetailColumn7.MaxWidth = 195F;
            listViewDetailColumn7.MinWidth = 195F;
            listViewDetailColumn7.Width = 195F;
            listViewDetailColumn8.HeaderText = "Entrada";
            listViewDetailColumn8.MaxWidth = 195F;
            listViewDetailColumn8.MinWidth = 195F;
            listViewDetailColumn8.Width = 195F;
            listViewDetailColumn9.HeaderText = "Salida";
            listViewDetailColumn9.MaxWidth = 195F;
            listViewDetailColumn9.MinWidth = 195F;
            listViewDetailColumn9.Width = 195F;
            listViewDetailColumn10.HeaderText = "Id";
            listViewDetailColumn10.MaxWidth = 195F;
            listViewDetailColumn10.MinWidth = 195F;
            listViewDetailColumn10.Width = 195F;
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn6,
            listViewDetailColumn7,
            listViewDetailColumn8,
            listViewDetailColumn9,
            listViewDetailColumn10});
            this.radListView1.GroupIndent = 25223;
            this.radListView1.GroupItemSize = new System.Drawing.Size(197235, 19926);
            this.radListView1.HeaderHeight = 34484.15F;
            this.radListView1.ItemSize = new System.Drawing.Size(197235, 19926);
            this.radListView1.ItemSpacing = -1;
            this.radListView1.Location = new System.Drawing.Point(17, 338);
            this.radListView1.Margin = new System.Windows.Forms.Padding(48, 48, 48, 48);
            this.radListView1.Name = "radListView1";
            this.radListView1.ShowCheckBoxes = true;
            this.radListView1.Size = new System.Drawing.Size(1273, 565);
            this.radListView1.TabIndex = 0;
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.radListView1.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.radListView1_ItemCheckedChanged);
            ((Telerik.WinControls.UI.DetailListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).GroupIndent = 25223;
            ((Telerik.WinControls.UI.DetailListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).ItemSize = new System.Drawing.Size(197235, 19926);
            ((Telerik.WinControls.UI.DetailListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).GroupItemSize = new System.Drawing.Size(197235, 19926);
            ((Telerik.WinControls.UI.DetailListViewElement)(this.radListView1.GetChildAt(0).GetChildAt(0))).DefaultSize = new System.Drawing.Size(100, 100);
            ((Telerik.WinControls.UI.DetailListViewColumnContainer)(this.radListView1.GetChildAt(0).GetChildAt(0).GetChildAt(3))).AutoSize = true;
            ((Telerik.WinControls.UI.DetailListViewColumnContainer)(this.radListView1.GetChildAt(0).GetChildAt(0).GetChildAt(3))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.DetailListViewColumnContainer)(this.radListView1.GetChildAt(0).GetChildAt(0).GetChildAt(3))).StretchHorizontally = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Asistencias";
            // 
            // radButtonAttendanceDelete
            // 
            this.radButtonAttendanceDelete.Location = new System.Drawing.Point(1431, 439);
            this.radButtonAttendanceDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radButtonAttendanceDelete.Name = "radButtonAttendanceDelete";
            this.radButtonAttendanceDelete.Size = new System.Drawing.Size(110, 24);
            this.radButtonAttendanceDelete.TabIndex = 4;
            this.radButtonAttendanceDelete.Text = "Remove";
            this.radButtonAttendanceDelete.Click += new System.EventHandler(this.radButtonAttendanceDelete_Click);
            // 
            // userControlHomeWelcome1
            // 
            this.userControlHomeWelcome1.Location = new System.Drawing.Point(115, 3);
            this.userControlHomeWelcome1.Name = "userControlHomeWelcome1";
            this.userControlHomeWelcome1.Size = new System.Drawing.Size(1212, 113);
            this.userControlHomeWelcome1.TabIndex = 3;
            // 
            // UserControlListViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radButtonAttendanceDelete);
            this.Controls.Add(this.userControlHomeWelcome1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radListView1);
            this.Name = "UserControlListViewMembers";
            this.Size = new System.Drawing.Size(1640, 1048);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAttendanceDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private System.Windows.Forms.Label label1;
        private Home.UserControlHomeWelcome userControlHomeWelcome1;
        private Telerik.WinControls.UI.RadButton radButtonAttendanceDelete;
    }
}
