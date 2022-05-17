namespace InterfazGrafica
{
    partial class FrmAlimentoAltaEditar
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnAltaEditar = new System.Windows.Forms.Button();
            this.LblLitros = new System.Windows.Forms.Label();
            this.TxtLitro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.Location = new System.Drawing.Point(20, 23);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(210, 37);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Agregar/Editar";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblNombre.Location = new System.Drawing.Point(26, 72);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(64, 20);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Nombre";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblDescripcion.Location = new System.Drawing.Point(26, 135);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(87, 20);
            this.LblDescripcion.TabIndex = 6;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblPrecio.Location = new System.Drawing.Point(26, 201);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(50, 20);
            this.LblPrecio.TabIndex = 7;
            this.LblPrecio.Text = "Precio";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblCantidad.Location = new System.Drawing.Point(136, 201);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(69, 20);
            this.LblCantidad.TabIndex = 8;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Location = new System.Drawing.Point(26, 96);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(194, 27);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.Location = new System.Drawing.Point(26, 159);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(194, 27);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantidad.Location = new System.Drawing.Point(136, 225);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(69, 27);
            this.TxtCantidad.TabIndex = 4;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecio.Location = new System.Drawing.Point(26, 225);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(69, 27);
            this.TxtPrecio.TabIndex = 3;
            // 
            // BtnAltaEditar
            // 
            this.BtnAltaEditar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnAltaEditar.BackgroundImage = global::InterfazGrafica.Properties.Resources.righarrow_87553;
            this.BtnAltaEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAltaEditar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnAltaEditar.FlatAppearance.BorderSize = 0;
            this.BtnAltaEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnAltaEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.BtnAltaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltaEditar.ForeColor = System.Drawing.Color.MediumPurple;
            this.BtnAltaEditar.Location = new System.Drawing.Point(110, 277);
            this.BtnAltaEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAltaEditar.Name = "BtnAltaEditar";
            this.BtnAltaEditar.Size = new System.Drawing.Size(95, 51);
            this.BtnAltaEditar.TabIndex = 6;
            this.BtnAltaEditar.UseVisualStyleBackColor = false;
            this.BtnAltaEditar.Click += new System.EventHandler(this.BtnAltaEditar_Click);
            // 
            // LblLitros
            // 
            this.LblLitros.AutoSize = true;
            this.LblLitros.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblLitros.Location = new System.Drawing.Point(26, 267);
            this.LblLitros.Name = "LblLitros";
            this.LblLitros.Size = new System.Drawing.Size(45, 20);
            this.LblLitros.TabIndex = 20;
            this.LblLitros.Text = "Litros";
            // 
            // TxtLitro
            // 
            this.TxtLitro.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtLitro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLitro.Location = new System.Drawing.Point(26, 291);
            this.TxtLitro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtLitro.Name = "TxtLitro";
            this.TxtLitro.Size = new System.Drawing.Size(69, 27);
            this.TxtLitro.TabIndex = 5;
            // 
            // FrmAlimentoAltaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(245, 347);
            this.Controls.Add(this.TxtLitro);
            this.Controls.Add(this.LblLitros);
            this.Controls.Add(this.BtnAltaEditar);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAlimentoAltaEditar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAlimentoAltaEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnAltaEditar;
        private System.Windows.Forms.Label LblLitros;
        private System.Windows.Forms.TextBox TxtLitro;
    }
}