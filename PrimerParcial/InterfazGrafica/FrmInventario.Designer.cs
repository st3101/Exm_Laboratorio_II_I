namespace InterfazGrafica
{
    partial class FrmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvComida = new System.Windows.Forms.DataGridView();
            this.BtnAgregarComida = new System.Windows.Forms.Button();
            this.BtnEditarComida = new System.Windows.Forms.Button();
            this.BtnBorrarComida = new System.Windows.Forms.Button();
            this.DgvBebida = new System.Windows.Forms.DataGridView();
            this.BtnEliminarBebida = new System.Windows.Forms.Button();
            this.BtnEditarBebida = new System.Windows.Forms.Button();
            this.GpbEmpleado = new System.Windows.Forms.GroupBox();
            this.GpbBebida = new System.Windows.Forms.GroupBox();
            this.BtnAgregarBebida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBebida)).BeginInit();
            this.GpbEmpleado.SuspendLayout();
            this.GpbBebida.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvComida
            // 
            this.DgvComida.AllowUserToAddRows = false;
            this.DgvComida.AllowUserToDeleteRows = false;
            this.DgvComida.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvComida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvComida.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DgvComida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvComida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvComida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvComida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvComida.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvComida.EnableHeadersVisualStyles = false;
            this.DgvComida.GridColor = System.Drawing.Color.SlateBlue;
            this.DgvComida.Location = new System.Drawing.Point(135, 19);
            this.DgvComida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvComida.Name = "DgvComida";
            this.DgvComida.ReadOnly = true;
            this.DgvComida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvComida.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvComida.RowHeadersVisible = false;
            this.DgvComida.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvComida.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvComida.RowTemplate.Height = 25;
            this.DgvComida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvComida.Size = new System.Drawing.Size(894, 209);
            this.DgvComida.TabIndex = 0;
            // 
            // BtnAgregarComida
            // 
            this.BtnAgregarComida.BackgroundImage = global::InterfazGrafica.Properties.Resources._;
            this.BtnAgregarComida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarComida.FlatAppearance.BorderSize = 0;
            this.BtnAgregarComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarComida.Location = new System.Drawing.Point(31, 45);
            this.BtnAgregarComida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAgregarComida.Name = "BtnAgregarComida";
            this.BtnAgregarComida.Size = new System.Drawing.Size(43, 39);
            this.BtnAgregarComida.TabIndex = 1;
            this.BtnAgregarComida.UseVisualStyleBackColor = true;
            this.BtnAgregarComida.Click += new System.EventHandler(this.BtnAgregarComida_Click);
            // 
            // BtnEditarComida
            // 
            this.BtnEditarComida.BackgroundImage = global::InterfazGrafica.Properties.Resources.pen_edit_pencil_modify_icon_149413;
            this.BtnEditarComida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarComida.FlatAppearance.BorderSize = 0;
            this.BtnEditarComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarComida.Location = new System.Drawing.Point(31, 108);
            this.BtnEditarComida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditarComida.Name = "BtnEditarComida";
            this.BtnEditarComida.Size = new System.Drawing.Size(43, 39);
            this.BtnEditarComida.TabIndex = 2;
            this.BtnEditarComida.UseVisualStyleBackColor = true;
            this.BtnEditarComida.Click += new System.EventHandler(this.BtnEditarComida_Click);
            // 
            // BtnBorrarComida
            // 
            this.BtnBorrarComida.BackgroundImage = global::InterfazGrafica.Properties.Resources.minus_gross_horizontal_straight_line_symbol_icon_icons_com_74137;
            this.BtnBorrarComida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBorrarComida.FlatAppearance.BorderSize = 0;
            this.BtnBorrarComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarComida.Location = new System.Drawing.Point(31, 167);
            this.BtnBorrarComida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBorrarComida.Name = "BtnBorrarComida";
            this.BtnBorrarComida.Size = new System.Drawing.Size(43, 39);
            this.BtnBorrarComida.TabIndex = 3;
            this.BtnBorrarComida.UseVisualStyleBackColor = true;
            this.BtnBorrarComida.Click += new System.EventHandler(this.BtnBorrarComida_Click);
            // 
            // DgvBebida
            // 
            this.DgvBebida.AllowUserToAddRows = false;
            this.DgvBebida.AllowUserToDeleteRows = false;
            this.DgvBebida.AllowUserToOrderColumns = true;
            this.DgvBebida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBebida.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DgvBebida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvBebida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBebida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBebida.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvBebida.EnableHeadersVisualStyles = false;
            this.DgvBebida.GridColor = System.Drawing.Color.SlateBlue;
            this.DgvBebida.Location = new System.Drawing.Point(135, 28);
            this.DgvBebida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvBebida.Name = "DgvBebida";
            this.DgvBebida.ReadOnly = true;
            this.DgvBebida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBebida.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvBebida.RowHeadersVisible = false;
            this.DgvBebida.RowHeadersWidth = 51;
            this.DgvBebida.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvBebida.RowTemplate.Height = 25;
            this.DgvBebida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBebida.Size = new System.Drawing.Size(894, 200);
            this.DgvBebida.TabIndex = 4;
            // 
            // BtnEliminarBebida
            // 
            this.BtnEliminarBebida.BackgroundImage = global::InterfazGrafica.Properties.Resources.minus_gross_horizontal_straight_line_symbol_icon_icons_com_74137;
            this.BtnEliminarBebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarBebida.FlatAppearance.BorderSize = 0;
            this.BtnEliminarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarBebida.Location = new System.Drawing.Point(31, 165);
            this.BtnEliminarBebida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEliminarBebida.Name = "BtnEliminarBebida";
            this.BtnEliminarBebida.Size = new System.Drawing.Size(43, 39);
            this.BtnEliminarBebida.TabIndex = 5;
            this.BtnEliminarBebida.UseVisualStyleBackColor = true;
            this.BtnEliminarBebida.Click += new System.EventHandler(this.BtnEliminarBebida_Click);
            // 
            // BtnEditarBebida
            // 
            this.BtnEditarBebida.BackgroundImage = global::InterfazGrafica.Properties.Resources.pen_edit_pencil_modify_icon_149413;
            this.BtnEditarBebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarBebida.FlatAppearance.BorderSize = 0;
            this.BtnEditarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarBebida.Location = new System.Drawing.Point(31, 106);
            this.BtnEditarBebida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditarBebida.Name = "BtnEditarBebida";
            this.BtnEditarBebida.Size = new System.Drawing.Size(43, 39);
            this.BtnEditarBebida.TabIndex = 6;
            this.BtnEditarBebida.UseVisualStyleBackColor = true;
            this.BtnEditarBebida.Click += new System.EventHandler(this.BtnEditarBebida_Click);
            // 
            // GpbEmpleado
            // 
            this.GpbEmpleado.Controls.Add(this.DgvComida);
            this.GpbEmpleado.Controls.Add(this.BtnBorrarComida);
            this.GpbEmpleado.Controls.Add(this.BtnAgregarComida);
            this.GpbEmpleado.Controls.Add(this.BtnEditarComida);
            this.GpbEmpleado.Location = new System.Drawing.Point(12, 13);
            this.GpbEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GpbEmpleado.Name = "GpbEmpleado";
            this.GpbEmpleado.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GpbEmpleado.Size = new System.Drawing.Size(1035, 236);
            this.GpbEmpleado.TabIndex = 7;
            this.GpbEmpleado.TabStop = false;
            this.GpbEmpleado.Text = "Lista Comida";
            // 
            // GpbBebida
            // 
            this.GpbBebida.Controls.Add(this.BtnAgregarBebida);
            this.GpbBebida.Controls.Add(this.DgvBebida);
            this.GpbBebida.Controls.Add(this.BtnEliminarBebida);
            this.GpbBebida.Controls.Add(this.BtnEditarBebida);
            this.GpbBebida.Location = new System.Drawing.Point(12, 284);
            this.GpbBebida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GpbBebida.Name = "GpbBebida";
            this.GpbBebida.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GpbBebida.Size = new System.Drawing.Size(1035, 236);
            this.GpbBebida.TabIndex = 8;
            this.GpbBebida.TabStop = false;
            this.GpbBebida.Text = "Lista Bebibas";
            // 
            // BtnAgregarBebida
            // 
            this.BtnAgregarBebida.BackgroundImage = global::InterfazGrafica.Properties.Resources._;
            this.BtnAgregarBebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarBebida.FlatAppearance.BorderSize = 0;
            this.BtnAgregarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarBebida.Location = new System.Drawing.Point(31, 43);
            this.BtnAgregarBebida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAgregarBebida.Name = "BtnAgregarBebida";
            this.BtnAgregarBebida.Size = new System.Drawing.Size(43, 39);
            this.BtnAgregarBebida.TabIndex = 7;
            this.BtnAgregarBebida.UseVisualStyleBackColor = true;
            this.BtnAgregarBebida.Click += new System.EventHandler(this.BtnAgregarBebida_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1059, 546);
            this.Controls.Add(this.GpbBebida);
            this.Controls.Add(this.GpbEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmInventario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvComida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBebida)).EndInit();
            this.GpbEmpleado.ResumeLayout(false);
            this.GpbBebida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvComida;
        private System.Windows.Forms.Button BtnAgregarComida;
        private System.Windows.Forms.Button BtnEditarComida;
        private System.Windows.Forms.Button BtnBorrarComida;
        private System.Windows.Forms.DataGridView DgvBebida;
        private System.Windows.Forms.Button BtnEliminarBebida;
        private System.Windows.Forms.Button BtnEditarBebida;
        private System.Windows.Forms.GroupBox GpbEmpleado;
        private System.Windows.Forms.GroupBox GpbBebida;
        private System.Windows.Forms.Button BtnAgregarBebida;
    }
}