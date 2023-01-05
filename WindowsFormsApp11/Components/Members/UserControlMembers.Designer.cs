namespace WindowsFormsApp11.Components.Members
{
    partial class UserControlMembers
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
            this.userControlHomeWelcome1 = new WindowsFormsApp11.Components.Home.UserControlHomeWelcome();
            this.SuspendLayout();
            // 
            // userControlHomeWelcome1
            // 
            this.userControlHomeWelcome1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlHomeWelcome1.Location = new System.Drawing.Point(0, 0);
            this.userControlHomeWelcome1.Name = "userControlHomeWelcome1";
            this.userControlHomeWelcome1.Size = new System.Drawing.Size(1487, 113);
            this.userControlHomeWelcome1.TabIndex = 0;
            // 
            // UserControlMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlHomeWelcome1);
            this.Name = "UserControlMembers";
            this.Size = new System.Drawing.Size(1487, 714);
            this.ResumeLayout(false);

        }

        #endregion

        private Home.UserControlHomeWelcome userControlHomeWelcome1;
    }
}
