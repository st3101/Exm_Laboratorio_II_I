namespace InterfazGrafica
{
    partial class FrmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblMetodoDePago = new System.Windows.Forms.Label();
            this.CkbEstacionamiento = new System.Windows.Forms.CheckBox();
            this.GpbFacturacion = new System.Windows.Forms.GroupBox();
            this.BtnCerraCuenta = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CmbMetodoDePago = new System.Windows.Forms.ComboBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblPrecioAlimento = new System.Windows.Forms.Label();
            this.GpbAlimentos = new System.Windows.Forms.GroupBox();
            this.DtgAlimentos = new System.Windows.Forms.DataGridView();
            this.GpbFacturacion.SuspendLayout();
            this.GpbAlimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAlimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMetodoDePago
            // 
            this.LblMetodoDePago.AutoSize = true;
            this.LblMetodoDePago.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblMetodoDePago.Location = new System.Drawing.Point(47, 31);
            this.LblMetodoDePago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMetodoDePago.Name = "LblMetodoDePago";
            this.LblMetodoDePago.Size = new System.Drawing.Size(122, 20);
            this.LblMetodoDePago.TabIndex = 0;
            this.LblMetodoDePago.Text = "Metodo de pago";
            // 
            // CkbEstacionamiento
            // 
            this.CkbEstacionamiento.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CkbEstacionamiento.AutoSize = true;
            this.CkbEstacionamiento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CkbEstacionamiento.ForeColor = System.Drawing.Color.MediumPurple;
            this.CkbEstacionamiento.Location = new System.Drawing.Point(47, 94);
            this.CkbEstacionamiento.Margin = new System.Windows.Forms.Padding(2);
            this.CkbEstacionamiento.Name = "CkbEstacionamiento";
            this.CkbEstacionamiento.Size = new System.Drawing.Size(141, 24);
            this.CkbEstacionamiento.TabIndex = 2;
            this.CkbEstacionamiento.Text = "Estacionamiento";
            this.CkbEstacionamiento.UseVisualStyleBackColor = true;
            this.CkbEstacionamiento.CheckedChanged += new System.EventHandler(this.CkbEstacionamiento_CheckedChanged);
            // 
            // GpbFacturacion
            // 
            this.GpbFacturacion.Controls.Add(this.BtnCerraCuenta);
            this.GpbFacturacion.Controls.Add(this.BtnCancelar);
            this.GpbFacturacion.Controls.Add(this.CmbMetodoDePago);
            this.GpbFacturacion.Controls.Add(this.LblTotal);
            this.GpbFacturacion.Controls.Add(this.LblPrecioAlimento);
            this.GpbFacturacion.Controls.Add(this.CkbEstacionamiento);
            this.GpbFacturacion.Controls.Add(this.LblMetodoDePago);
            this.GpbFacturacion.Location = new System.Drawing.Point(10, 10);
            this.GpbFacturacion.Margin = new System.Windows.Forms.Padding(2);
            this.GpbFacturacion.Name = "GpbFacturacion";
            this.GpbFacturacion.Padding = new System.Windows.Forms.Padding(2);
            this.GpbFacturacion.Size = new System.Drawing.Size(230, 240);
            this.GpbFacturacion.TabIndex = 3;
            this.GpbFacturacion.TabStop = false;
            this.GpbFacturacion.Text = "Facturacion";
            // 
            // BtnCerraCuenta
            // 
            this.BtnCerraCuenta.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCerraCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerraCuenta.ForeColor = System.Drawing.Color.Black;
            this.BtnCerraCuenta.Location = new System.Drawing.Point(103, 206);
            this.BtnCerraCuenta.Name = "BtnCerraCuenta";
            this.BtnCerraCuenta.Size = new System.Drawing.Size(121, 29);
            this.BtnCerraCuenta.TabIndex = 16;
            this.BtnCerraCuenta.Text = "Cerrar Cuenta";
            this.BtnCerraCuenta.UseVisualStyleBackColor = true;
            this.BtnCerraCuenta.Click += new System.EventHandler(this.BtnCerraCuenta_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(6, 206);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(91, 29);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar ";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CmbMetodoDePago
            // 
            this.CmbMetodoDePago.BackColor = System.Drawing.Color.SlateBlue;
            this.CmbMetodoDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMetodoDePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbMetodoDePago.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmbMetodoDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.CmbMetodoDePago.Location = new System.Drawing.Point(50, 54);
            this.CmbMetodoDePago.Name = "CmbMetodoDePago";
            this.CmbMetodoDePago.Size = new System.Drawing.Size(130, 28);
            this.CmbMetodoDePago.TabIndex = 7;
            this.CmbMetodoDePago.SelectedIndexChanged += new System.EventHandler(this.CmbMetodoDePago_SelectedIndexChanged_1);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.SlateBlue;
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotal.Location = new System.Drawing.Point(30, 170);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(139, 28);
            this.LblTotal.TabIndex = 4;
            this.LblTotal.Text = "Precio final: $0";
            // 
            // LblPrecioAlimento
            // 
            this.LblPrecioAlimento.AutoSize = true;
            this.LblPrecioAlimento.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblPrecioAlimento.Location = new System.Drawing.Point(30, 150);
            this.LblPrecioAlimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrecioAlimento.Name = "LblPrecioAlimento";
            this.LblPrecioAlimento.Size = new System.Drawing.Size(130, 20);
            this.LblPrecioAlimento.TabIndex = 3;
            this.LblPrecioAlimento.Text = "Precio Alimento: 0";
            // 
            // GpbAlimentos
            // 
            this.GpbAlimentos.Controls.Add(this.DtgAlimentos);
            this.GpbAlimentos.Location = new System.Drawing.Point(244, 10);
            this.GpbAlimentos.Margin = new System.Windows.Forms.Padding(2);
            this.GpbAlimentos.Name = "GpbAlimentos";
            this.GpbAlimentos.Padding = new System.Windows.Forms.Padding(2);
            this.GpbAlimentos.Size = new System.Drawing.Size(819, 240);
            this.GpbAlimentos.TabIndex = 4;
            this.GpbAlimentos.TabStop = false;
            this.GpbAlimentos.Text = "Alimentos";
            // 
            // DtgAlimentos
            // 
            this.DtgAlimentos.AllowUserToAddRows = false;
            this.DtgAlimentos.AllowUserToDeleteRows = false;
            this.DtgAlimentos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgAlimentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgAlimentos.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DtgAlimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgAlimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgAlimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAlimentos.EnableHeadersVisualStyles = false;
            this.DtgAlimentos.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DtgAlimentos.Location = new System.Drawing.Point(12, 22);
            this.DtgAlimentos.Margin = new System.Windows.Forms.Padding(2);
            this.DtgAlimentos.Name = "DtgAlimentos";
            this.DtgAlimentos.ReadOnly = true;
            this.DtgAlimentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgAlimentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgAlimentos.RowHeadersVisible = false;
            this.DtgAlimentos.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgAlimentos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgAlimentos.RowTemplate.Height = 33;
            this.DtgAlimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgAlimentos.Size = new System.Drawing.Size(801, 213);
            this.DtgAlimentos.TabIndex = 0;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1073, 255);
            this.Controls.Add(this.GpbAlimentos);
            this.Controls.Add(this.GpbFacturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmFacturacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.GpbFacturacion.ResumeLayout(false);
            this.GpbFacturacion.PerformLayout();
            this.GpbAlimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgAlimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMetodoDePago;
        private System.Windows.Forms.CheckBox CkbEstacionamiento;
        private System.Windows.Forms.GroupBox GpbFacturacion;
        private System.Windows.Forms.GroupBox GpbAlimentos;
        private System.Windows.Forms.DataGridView DtgAlimentos;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblPrecioAlimento;
        private System.Windows.Forms.ComboBox CmbMetodoDePago;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCerraCuenta;
    }
}