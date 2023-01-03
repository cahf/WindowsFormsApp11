namespace WindowsFormsApp11.Components
{
    partial class UserControlHome
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
            this.userControlHomeCarousel1 = new WindowsFormsApp11.Components.Home.UserControlHomeCarousel();
            this.userControlWelcome1 = new WindowsFormsApp11.Components.Home.UserControlHomeWelcome();
            this.userControlFooter1 = new WindowsFormsApp11.Components.Share.UserControlFooter();
            this.SuspendLayout();
            // 
            // userControlHomeCarousel1
            // 
            this.userControlHomeCarousel1.Location = new System.Drawing.Point(3, 107);
            this.userControlHomeCarousel1.Name = "userControlHomeCarousel1";
            this.userControlHomeCarousel1.Size = new System.Drawing.Size(1413, 570);
            this.userControlHomeCarousel1.TabIndex = 1;
            // 
            // userControlWelcome1
            // 
            this.userControlWelcome1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlWelcome1.Location = new System.Drawing.Point(0, 0);
            this.userControlWelcome1.Name = "userControlWelcome1";
            this.userControlWelcome1.Size = new System.Drawing.Size(1633, 113);
            this.userControlWelcome1.TabIndex = 0;
            // 
            // userControlFooter1
            // 
            this.userControlFooter1.Location = new System.Drawing.Point(0, 694);
            this.userControlFooter1.Name = "userControlFooter1";
            this.userControlFooter1.Size = new System.Drawing.Size(1627, 408);
            this.userControlFooter1.TabIndex = 2;
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlFooter1);
            this.Controls.Add(this.userControlHomeCarousel1);
            this.Controls.Add(this.userControlWelcome1);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(1633, 1176);
            this.ResumeLayout(false);

        }

        #endregion

        private Home.UserControlHomeWelcome userControlWelcome1;
        private Home.UserControlHomeCarousel userControlHomeCarousel1;
        private Share.UserControlFooter userControlFooter1;
    }
}
