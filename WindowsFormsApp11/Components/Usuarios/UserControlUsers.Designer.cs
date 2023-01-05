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
            ((System.ComponentModel.ISupportInitialize)(this.radListViewGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // radListViewGeneral
            // 
            this.radListViewGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListViewGeneral.GroupIndent = 38;
            this.radListViewGeneral.GroupItemSize = new System.Drawing.Size(300, 30);
            this.radListViewGeneral.HeaderHeight = 52.5F;
            this.radListViewGeneral.ItemSize = new System.Drawing.Size(300, 30);
            this.radListViewGeneral.Location = new System.Drawing.Point(0, 0);
            this.radListViewGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radListViewGeneral.Name = "radListViewGeneral";
            this.radListViewGeneral.Size = new System.Drawing.Size(1348, 484);
            this.radListViewGeneral.TabIndex = 0;
            // 
            // UserControlUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radListViewGeneral);
            this.Name = "UserControlUsers";
            this.Size = new System.Drawing.Size(1348, 484);
            ((System.ComponentModel.ISupportInitialize)(this.radListViewGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListViewGeneral;
    }
}
