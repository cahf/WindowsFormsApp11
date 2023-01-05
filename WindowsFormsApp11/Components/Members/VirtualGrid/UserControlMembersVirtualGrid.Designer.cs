namespace WindowsFormsApp11.Components.Members.VirtualGrid
{
    partial class UserControlMembersVirtualGrid
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
            this.radVirtualGrid1 = new Telerik.WinControls.UI.RadVirtualGrid();
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // radVirtualGrid1
            // 
            this.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVirtualGrid1.Location = new System.Drawing.Point(0, 0);
            this.radVirtualGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radVirtualGrid1.MasterViewInfo.ColumnWidth = 225;
            this.radVirtualGrid1.MasterViewInfo.MinColumnWidth = 8;
            this.radVirtualGrid1.MasterViewInfo.MinRowHeight = 8;
            this.radVirtualGrid1.MasterViewInfo.Padding = new System.Windows.Forms.Padding(14);
            this.radVirtualGrid1.Name = "radVirtualGrid1";
            this.radVirtualGrid1.Size = new System.Drawing.Size(1570, 534);
            this.radVirtualGrid1.TabIndex = 0;
            // 
            // UserControlMembersVirtualGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radVirtualGrid1);
            this.Name = "UserControlMembersVirtualGrid";
            this.Size = new System.Drawing.Size(1570, 534);
            ((System.ComponentModel.ISupportInitialize)(this.radVirtualGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radVirtualGrid1;
    }
}
