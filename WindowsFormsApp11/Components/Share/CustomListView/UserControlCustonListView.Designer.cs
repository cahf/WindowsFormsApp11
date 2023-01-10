namespace WindowsFormsApp11.Components.Share.CustomListView
{
    partial class UserControlCustonListView
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(510, 54);
            this.radButton1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(309, 81);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Agregar";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(900, 54);
            this.radButton2.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(320, 81);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Actualizar";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(1278, 54);
            this.radButton3.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(327, 81);
            this.radButton3.TabIndex = 1;
            this.radButton3.Text = "Eliminar";
            // 
            // radListView1
            // 
            this.radListView1.GroupIndent = 86;
            this.radListView1.GroupItemSize = new System.Drawing.Size(675, 68);
            this.radListView1.HeaderHeight = 118.125F;
            this.radListView1.ItemSize = new System.Drawing.Size(675, 68);
            this.radListView1.Location = new System.Drawing.Point(482, 310);
            this.radListView1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(688, 213);
            this.radListView1.TabIndex = 2;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(232, 186);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(83, 28);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "radLabel1";
            // 
            // UserControlCustonListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radListView1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton1);
            this.Name = "UserControlCustonListView";
            this.Size = new System.Drawing.Size(1233, 476);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
