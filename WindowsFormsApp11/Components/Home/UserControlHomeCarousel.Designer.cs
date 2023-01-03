namespace WindowsFormsApp11.Components.Home
{
    partial class UserControlHomeCarousel
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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHomeCarousel));
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radCarousel1
            // 
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(50D, 50D, 0D);
            carouselEllipsePath1.FinalAngle = -100D;
            carouselEllipsePath1.InitialAngle = -90D;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(-20D, -17D, -50D);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(37.978863936591807D, -21.092077087794433D, -60D);
            carouselEllipsePath1.ZScale = 500D;
            this.radCarousel1.CarouselPath = carouselEllipsePath1;
            this.radCarousel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCarousel1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2,
            this.radButtonElement3,
            this.radButtonElement4});
            this.radCarousel1.Location = new System.Drawing.Point(0, 0);
            this.radCarousel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.Size = new System.Drawing.Size(1603, 908);
            this.radCarousel1.TabIndex = 0;
            this.radCarousel1.Text = "radCarousel1";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.radButtonElement1.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement1.Image")));
            this.radButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "elemento1";
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement2.Image")));
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "radButtonElement2";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement3.Image")));
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.Text = "radButtonElement3";
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement4.Image")));
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.Text = "radButtonElement4";
            // 
            // UserControlHomeCarousel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radCarousel1);
            this.Name = "UserControlHomeCarousel";
            this.Size = new System.Drawing.Size(1603, 908);
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarousel1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
    }
}
