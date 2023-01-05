namespace WindowsFormsApp11.Components.Home
{
    partial class UserControlHomeWelcome
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radClock1 = new Telerik.WinControls.UI.RadClock();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.radLabel1.Location = new System.Drawing.Point(0, 0);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(1222, 91);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Bienvenido Carlos Alberto Hernandez Flores";
            // 
            // radClock1
            // 
            this.radClock1.Location = new System.Drawing.Point(1339, 4);
            this.radClock1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radClock1.Name = "radClock1";
            this.radClock1.Size = new System.Drawing.Size(201, 203);
            this.radClock1.TabIndex = 2;
            // 
            // UserControlHomeWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radClock1);
            this.Controls.Add(this.radLabel1);
            this.Name = "UserControlHomeWelcome";
            this.Size = new System.Drawing.Size(1656, 216);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadClock radClock1;
    }
}
