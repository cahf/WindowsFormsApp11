namespace WindowsFormsApp11.Components.Share
{
    partial class UserControlFooter
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
            this.userControlFooterSeccion21 = new WindowsFormsApp11.Components.Share.Footer.UserControlFooterSeccion2();
            this.userControlFooterSecion11 = new WindowsFormsApp11.Components.Share.Footer.UserControlFooterSecion1();
            this.SuspendLayout();
            // 
            // userControlFooterSeccion21
            // 
            this.userControlFooterSeccion21.Location = new System.Drawing.Point(1074, 60);
            this.userControlFooterSeccion21.Name = "userControlFooterSeccion21";
            this.userControlFooterSeccion21.Size = new System.Drawing.Size(427, 301);
            this.userControlFooterSeccion21.TabIndex = 1;
            // 
            // userControlFooterSecion11
            // 
            this.userControlFooterSecion11.Location = new System.Drawing.Point(456, 55);
            this.userControlFooterSecion11.Name = "userControlFooterSecion11";
            this.userControlFooterSecion11.Size = new System.Drawing.Size(376, 306);
            this.userControlFooterSecion11.TabIndex = 2;
            // 
            // UserControlFooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlFooterSecion11);
            this.Controls.Add(this.userControlFooterSeccion21);
            this.Name = "UserControlFooter";
            this.Size = new System.Drawing.Size(1664, 420);
            this.ResumeLayout(false);

        }

        #endregion
        private Footer.UserControlFooterSeccion2 userControlFooterSeccion21;
        private Footer.UserControlFooterSecion1 userControlFooterSecion11;
    }
}
