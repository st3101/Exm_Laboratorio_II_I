namespace InterfazGrafica
{
    partial class FrmMesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GpbInventario = new System.Windows.Forms.GroupBox();
            this.DgvInventarioComida = new System.Windows.Forms.DataGridView();
            this.DgvInventarioBebida = new System.Windows.Forms.DataGridView();
            this.GpbListaAlimento = new System.Windows.Forms.GroupBox();
            this.DgvListaAlimentos = new System.Windows.Forms.DataGridView();
            this.BtnActualizarDatos = new System.Windows.Forms.Button();
            this.LblApellidoCliente = new System.Windows.Forms.Label();
            this.TxtApellidoCliente = new System.Windows.Forms.TextBox();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblPrecioApagarNumero = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.GpbBebidas = new System.Windows.Forms.GroupBox();
            this.GpbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventarioComida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventarioBebida)).BeginInit();
            this.GpbListaAlimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaAlimentos)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.GpbBebidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbInventario
            // 
            this.GpbInventario.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.GpbInventario.Controls.Add(this.DgvInventarioComida);
            this.GpbInventario.ForeColor = System.Drawing.Color.MediumPurple;
            this.GpbInventario.Location = new System.Drawing.Point(790, 1);
            this.GpbInventario.Name = "GpbInventario";
            this.GpbInventario.Size = new System.Drawing.Size(890, 257);
            this.GpbInventario.TabIndex = 3;
            this.GpbInventario.TabStop = false;
            this.GpbInventario.Text = "Comidas";
            // 
            // DgvInventarioComida
            // 
            this.DgvInventarioComida.AllowUserToAddRows = false;
            this.DgvInventarioComida.AllowUserToDeleteRows = false;
            this.DgvInventarioComida.AllowUserToOrderColumns = true;
            this.DgvInventarioComida.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DgvInventarioComida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvInventarioComida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventarioComida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvInventarioComida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInventarioComida.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvInventarioComida.EnableHeadersVisualStyles = false;
            this.DgvInventarioComida.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DgvInventarioComida.Location = new System.Drawing.Point(6, 26);
            this.DgvInventarioComida.Name = "DgvInventarioComida";
            this.DgvInventarioComida.ReadOnly = true;
            this.DgvInventarioComida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventarioComida.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvInventarioComida.RowHeadersVisible = false;
            this.DgvInventarioComida.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DgvInventarioComida.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvInventarioComida.RowTemplate.Height = 29;
            this.DgvInventarioComida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInventarioComida.Size = new System.Drawing.Size(878, 217);
            this.DgvInventarioComida.TabIndex = 0;
            this.DgvInventarioComida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventarioComida_CellDoubleClick);
            // 
            // DgvInventarioBebida
            // 
            this.DgvInventarioBebida.AllowUserToAddRows = false;
            this.DgvInventarioBebida.AllowUserToDeleteRows = false;
            this.DgvInventarioBebida.AllowUserToOrderColumns = true;
            this.DgvInventarioBebida.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DgvInventarioBebida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvInventarioBebida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventarioBebida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvInventarioBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInventarioBebida.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvInventarioBebida.EnableHeadersVisualStyles = false;
            this.DgvInventarioBebida.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DgvInventarioBebida.Location = new System.Drawing.Point(6, 20);
            this.DgvInventarioBebida.Name = "DgvInventarioBebida";
            this.DgvInventarioBebida.ReadOnly = true;
            this.DgvInventarioBebida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventarioBebida.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvInventarioBebida.RowHeadersVisible = false;
            this.DgvInventarioBebida.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvInventarioBebida.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvInventarioBebida.RowTemplate.Height = 29;
            this.DgvInventarioBebida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInventarioBebida.Size = new System.Drawing.Size(878, 229);
            this.DgvInventarioBebida.TabIndex = 0;
            this.DgvInventarioBebida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventarioBebida_CellDoubleClick);
            // 
            // GpbListaAlimento
            // 
            this.GpbListaAlimento.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.GpbListaAlimento.Controls.Add(this.DgvListaAlimentos);
            this.GpbListaAlimento.ForeColor = System.Drawing.Color.MediumPurple;
            this.GpbListaAlimento.Location = new System.Drawing.Point(12, 1);
            this.GpbListaAlimento.Name = "GpbListaAlimento";
            this.GpbListaAlimento.Size = new System.Drawing.Size(772, 257);
            this.GpbListaAlimento.TabIndex = 5;
            this.GpbListaAlimento.TabStop = false;
            this.GpbListaAlimento.Text = "Lista Alimentos (Cliente)";
            // 
            // DgvListaAlimentos
            // 
            this.DgvListaAlimentos.AllowUserToAddRows = false;
            this.DgvListaAlimentos.AllowUserToDeleteRows = false;
            this.DgvListaAlimentos.AllowUserToOrderColumns = true;
            this.DgvListaAlimentos.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.DgvListaAlimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListaAlimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaAlimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvListaAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaAlimentos.DefaultCellStyle = dataGridViewCellStyle10;
            this.DgvListaAlimentos.EnableHeadersVisualStyles = false;
            this.DgvListaAlimentos.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DgvListaAlimentos.Location = new System.Drawing.Point(6, 26);
            this.DgvListaAlimentos.Name = "DgvListaAlimentos";
            this.DgvListaAlimentos.ReadOnly = true;
            this.DgvListaAlimentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaAlimentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvListaAlimentos.RowHeadersVisible = false;
            this.DgvListaAlimentos.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.DgvListaAlimentos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvListaAlimentos.RowTemplate.Height = 29;
            this.DgvListaAlimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaAlimentos.Size = new System.Drawing.Size(760, 217);
            this.DgvListaAlimentos.TabIndex = 0;
            // 
            // BtnActualizarDatos
            // 
            this.BtnActualizarDatos.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnActualizarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarDatos.ForeColor = System.Drawing.Color.Black;
            this.BtnActualizarDatos.Location = new System.Drawing.Point(276, 138);
            this.BtnActualizarDatos.Name = "BtnActualizarDatos";
            this.BtnActualizarDatos.Size = new System.Drawing.Size(167, 29);
            this.BtnActualizarDatos.TabIndex = 13;
            this.BtnActualizarDatos.Text = "Actualizar";
            this.BtnActualizarDatos.UseVisualStyleBackColor = true;
            this.BtnActualizarDatos.Click += new System.EventHandler(this.BtnActualizarDatos_Click);
            // 
            // LblApellidoCliente
            // 
            this.LblApellidoCliente.AutoSize = true;
            this.LblApellidoCliente.Location = new System.Drawing.Point(381, 68);
            this.LblApellidoCliente.Name = "LblApellidoCliente";
            this.LblApellidoCliente.Size = new System.Drawing.Size(190, 20);
            this.LblApellidoCliente.TabIndex = 12;
            this.LblApellidoCliente.Text = "Apellido Cliente (Opcional)";
            // 
            // TxtApellidoCliente
            // 
            this.TxtApellidoCliente.BackColor = System.Drawing.Color.SlateBlue;
            this.TxtApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtApellidoCliente.ForeColor = System.Drawing.Color.Black;
            this.TxtApellidoCliente.Location = new System.Drawing.Point(381, 91);
            this.TxtApellidoCliente.Name = "TxtApellidoCliente";
            this.TxtApellidoCliente.Size = new System.Drawing.Size(190, 27);
            this.TxtApellidoCliente.TabIndex = 11;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.Color.SlateBlue;
            this.TxtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombreCliente.Location = new System.Drawing.Point(159, 91);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(188, 27);
            this.TxtNombreCliente.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre Cliente (Opcional)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.BtnCancelar);
            this.groupBox5.Controls.Add(this.LblPrecioApagarNumero);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.TxtApellidoCliente);
            this.groupBox5.Controls.Add(this.TxtNombreCliente);
            this.groupBox5.Controls.Add(this.LblApellidoCliente);
            this.groupBox5.Controls.Add(this.BtnActualizarDatos);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.ForeColor = System.Drawing.Color.MediumPurple;
            this.groupBox5.Location = new System.Drawing.Point(12, 259);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(772, 257);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(522, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Facturar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(191, 215);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(167, 29);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar ";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblPrecioApagarNumero
            // 
            this.LblPrecioApagarNumero.AutoSize = true;
            this.LblPrecioApagarNumero.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LblPrecioApagarNumero.Location = new System.Drawing.Point(581, 192);
            this.LblPrecioApagarNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrecioApagarNumero.Name = "LblPrecioApagarNumero";
            this.LblPrecioApagarNumero.Size = new System.Drawing.Size(118, 20);
            this.LblPrecioApagarNumero.TabIndex = 15;
            this.LblPrecioApagarNumero.Text = "Total Alimento:0";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(15, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Volver menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GpbBebidas
            // 
            this.GpbBebidas.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.GpbBebidas.Controls.Add(this.DgvInventarioBebida);
            this.GpbBebidas.ForeColor = System.Drawing.Color.MediumPurple;
            this.GpbBebidas.Location = new System.Drawing.Point(790, 259);
            this.GpbBebidas.Name = "GpbBebidas";
            this.GpbBebidas.Size = new System.Drawing.Size(890, 255);
            this.GpbBebidas.TabIndex = 6;
            this.GpbBebidas.TabStop = false;
            this.GpbBebidas.Text = "Bebidas";
            // 
            // FrmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1692, 526);
            this.Controls.Add(this.GpbBebidas);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.GpbListaAlimento);
            this.Controls.Add(this.GpbInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMesa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesa";
            this.Load += new System.EventHandler(this.FrmMesa_Load);
            this.GpbInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventarioComida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventarioBebida)).EndInit();
            this.GpbListaAlimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaAlimentos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GpbBebidas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbInventario;
        private System.Windows.Forms.DataGridView DgvInventarioComida;
        private System.Windows.Forms.DataGridView DgvInventarioBebida;
        private System.Windows.Forms.GroupBox GpbListaAlimento;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DgvListaAlimentos;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnActualizarDatos;
        private System.Windows.Forms.Label LblApellidoCliente;
        private System.Windows.Forms.TextBox TxtApellidoCliente;
        private System.Windows.Forms.GroupBox GpbBebidas;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblPrecioApagarNumero;
    }
}