namespace WindowsFormsApp11.Components.Members
{
    partial class UserControlListViewMembersActions
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
            this.radButtonRemoveMemeber = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemoveMemeber)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonRemoveMemeber
            // 
            this.radButtonRemoveMemeber.Location = new System.Drawing.Point(18, 64);
            this.radButtonRemoveMemeber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radButtonRemoveMemeber.Name = "radButtonRemoveMemeber";
            this.radButtonRemoveMemeber.Size = new System.Drawing.Size(110, 24);
            this.radButtonRemoveMemeber.TabIndex = 0;
            this.radButtonRemoveMemeber.Text = "Remove";
            // 
            // UserControlListViewMembersActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radButtonRemoveMemeber);
            this.Name = "UserControlListViewMembersActions";
            this.Size = new System.Drawing.Size(151, 348);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRemoveMemeber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonRemoveMemeber;
    }
}
