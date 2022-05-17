namespace InterfazGrafica
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAutoLoginAdmin = new System.Windows.Forms.Button();
            this.BntLoginUsuario = new System.Windows.Forms.Button();
            this.lblAutologin = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblTituloUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TxtUsuario, "TxtUsuario");
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TxtUsuario.Name = "TxtUsuario";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TxtPassword, "TxtPassword");
            this.TxtPassword.Name = "TxtPassword";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAceptar.BackgroundImage = global::InterfazGrafica.Properties.Resources.righarrow_87553;
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnAceptar.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAutoLoginAdmin
            // 
            resources.ApplyResources(this.btnAutoLoginAdmin, "btnAutoLoginAdmin");
            this.btnAutoLoginAdmin.FlatAppearance.BorderSize = 0;
            this.btnAutoLoginAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAutoLoginAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnAutoLoginAdmin.Name = "btnAutoLoginAdmin";
            this.btnAutoLoginAdmin.UseVisualStyleBackColor = true;
            this.btnAutoLoginAdmin.Click += new System.EventHandler(this.btnAutoLoginAdmin_Click);
            // 
            // BntLoginUsuario
            // 
            this.BntLoginUsuario.BackgroundImage = global::InterfazGrafica.Properties.Resources.user_icon_150670__1_;
            resources.ApplyResources(this.BntLoginUsuario, "BntLoginUsuario");
            this.BntLoginUsuario.FlatAppearance.BorderSize = 0;
            this.BntLoginUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BntLoginUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BntLoginUsuario.Name = "BntLoginUsuario";
            this.BntLoginUsuario.UseVisualStyleBackColor = true;
            this.BntLoginUsuario.Click += new System.EventHandler(this.BntLoginUsuario_Click);
            // 
            // lblAutologin
            // 
            resources.ApplyResources(this.lblAutologin, "lblAutologin");
            this.lblAutologin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblAutologin.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblAutologin.Name = "lblAutologin";
            // 
            // LblTitulo
            // 
            resources.ApplyResources(this.LblTitulo, "LblTitulo");
            this.LblTitulo.Name = "LblTitulo";
            // 
            // LblTituloUsuario
            // 
            resources.ApplyResources(this.LblTituloUsuario, "LblTituloUsuario");
            this.LblTituloUsuario.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LblTituloUsuario.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblTituloUsuario.Name = "LblTituloUsuario";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Name = "label3";
            // 
            // FrmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTituloUsuario);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.lblAutologin);
            this.Controls.Add(this.BntLoginUsuario);
            this.Controls.Add(this.btnAutoLoginAdmin);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAutoLoginAdmin;
        private System.Windows.Forms.Button BntLoginUsuario;
        private System.Windows.Forms.Label lblAutologin;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblTituloUsuario;
        private System.Windows.Forms.Label label3;
    }
}
