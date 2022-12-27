namespace WindowsFormsApp11.Components.Login
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radTextBoxUser = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabelUser = new Telerik.WinControls.UI.RadLabel();
            this.radLabelPassword = new Telerik.WinControls.UI.RadLabel();
            this.radButtonLogin = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBoxUser
            // 
            this.radTextBoxUser.Location = new System.Drawing.Point(206, 130);
            this.radTextBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTextBoxUser.Name = "radTextBoxUser";
            this.radTextBoxUser.Size = new System.Drawing.Size(100, 31);
            this.radTextBoxUser.TabIndex = 0;
            // 
            // radTextBoxPassword
            // 
            this.radTextBoxPassword.Location = new System.Drawing.Point(206, 222);
            this.radTextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTextBoxPassword.Name = "radTextBoxPassword";
            this.radTextBoxPassword.Size = new System.Drawing.Size(100, 31);
            this.radTextBoxPassword.TabIndex = 1;
            // 
            // radLabelUser
            // 
            this.radLabelUser.Location = new System.Drawing.Point(206, 84);
            this.radLabelUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabelUser.Name = "radLabelUser";
            this.radLabelUser.Size = new System.Drawing.Size(44, 28);
            this.radLabelUser.TabIndex = 2;
            this.radLabelUser.Text = "User";
            // 
            // radLabelPassword
            // 
            this.radLabelPassword.Location = new System.Drawing.Point(206, 197);
            this.radLabelPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabelPassword.Name = "radLabelPassword";
            this.radLabelPassword.Size = new System.Drawing.Size(81, 28);
            this.radLabelPassword.TabIndex = 3;
            this.radLabelPassword.Text = "Password";
            // 
            // radButtonLogin
            // 
            this.radButtonLogin.Location = new System.Drawing.Point(206, 320);
            this.radButtonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radButtonLogin.Name = "radButtonLogin";
            this.radButtonLogin.Size = new System.Drawing.Size(110, 24);
            this.radButtonLogin.TabIndex = 4;
            this.radButtonLogin.Text = "Log in";
            this.radButtonLogin.Click += new System.EventHandler(this.radButtonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 444);
            this.Controls.Add(this.radButtonLogin);
            this.Controls.Add(this.radLabelPassword);
            this.Controls.Add(this.radLabelUser);
            this.Controls.Add(this.radTextBoxPassword);
            this.Controls.Add(this.radTextBoxUser);
            this.Name = "LoginForm";
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBoxUser;
        private Telerik.WinControls.UI.RadTextBox radTextBoxPassword;
        private Telerik.WinControls.UI.RadLabel radLabelUser;
        private Telerik.WinControls.UI.RadLabel radLabelPassword;
        private Telerik.WinControls.UI.RadButton radButtonLogin;
    }
}
