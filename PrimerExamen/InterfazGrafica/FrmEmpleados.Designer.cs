namespace InterfazGrafica
{
    partial class FrmEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvEmpleado = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GpbEmpleado = new System.Windows.Forms.GroupBox();
            this.CmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.TbxBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).BeginInit();
            this.GpbEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEmpleado
            // 
            this.DgvEmpleado.AllowUserToAddRows = false;
            this.DgvEmpleado.AllowUserToDeleteRows = false;
            this.DgvEmpleado.AllowUserToOrderColumns = true;
            this.DgvEmpleado.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEmpleado.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvEmpleado.EnableHeadersVisualStyles = false;
            this.DgvEmpleado.GridColor = System.Drawing.Color.SlateBlue;
            this.DgvEmpleado.Location = new System.Drawing.Point(90, 26);
            this.DgvEmpleado.Name = "DgvEmpleado";
            this.DgvEmpleado.ReadOnly = true;
            this.DgvEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvEmpleado.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvEmpleado.RowTemplate.Height = 29;
            this.DgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpleado.Size = new System.Drawing.Size(804, 236);
            this.DgvEmpleado.TabIndex = 0;
            // 
            // usuario
            // 
            this.usuario.Frozen = true;
            this.usuario.HeaderText = "Usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::InterfazGrafica.Properties.Resources.plus_user_icon_195527;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(21, 50);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(51, 45);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackgroundImage = global::InterfazGrafica.Properties.Resources.edit_user_icon_195392;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(21, 116);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(51, 45);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackgroundImage = global::InterfazGrafica.Properties.Resources.user_minus_icon_195437;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(21, 176);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(51, 58);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GpbEmpleado
            // 
            this.GpbEmpleado.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.GpbEmpleado.Controls.Add(this.CmbBuscarPor);
            this.GpbEmpleado.Controls.Add(this.TbxBuscar);
            this.GpbEmpleado.Controls.Add(this.BtnBuscar);
            this.GpbEmpleado.Controls.Add(this.DgvEmpleado);
            this.GpbEmpleado.Controls.Add(this.BtnEliminar);
            this.GpbEmpleado.Controls.Add(this.BtnAgregar);
            this.GpbEmpleado.Controls.Add(this.BtnEditar);
            this.GpbEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbEmpleado.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.GpbEmpleado.Location = new System.Drawing.Point(18, 12);
            this.GpbEmpleado.Name = "GpbEmpleado";
            this.GpbEmpleado.Size = new System.Drawing.Size(914, 323);
            this.GpbEmpleado.TabIndex = 4;
            this.GpbEmpleado.TabStop = false;
            this.GpbEmpleado.Text = "Lista Empleado";
            // 
            // CmbBuscarPor
            // 
            this.CmbBuscarPor.BackColor = System.Drawing.Color.SlateBlue;
            this.CmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBuscarPor.FormattingEnabled = true;
            this.CmbBuscarPor.Items.AddRange(new object[] {
            "Nombre",
            "Sueldo"});
            this.CmbBuscarPor.Location = new System.Drawing.Point(126, 269);
            this.CmbBuscarPor.Name = "CmbBuscarPor";
            this.CmbBuscarPor.Size = new System.Drawing.Size(121, 28);
            this.CmbBuscarPor.TabIndex = 6;
            // 
            // TbxBuscar
            // 
            this.TbxBuscar.BackColor = System.Drawing.Color.SlateBlue;
            this.TbxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxBuscar.Location = new System.Drawing.Point(289, 269);
            this.TbxBuscar.Name = "TbxBuscar";
            this.TbxBuscar.Size = new System.Drawing.Size(559, 27);
            this.TbxBuscar.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::InterfazGrafica.Properties.Resources.lupa3;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(21, 253);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(51, 55);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(959, 347);
            this.Controls.Add(this.GpbEmpleado);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEmpleados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).EndInit();
            this.GpbEmpleado.ResumeLayout(false);
            this.GpbEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GpbEmpleado;
        private System.Windows.Forms.TextBox TbxBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CmbBuscarPor;
    }
}