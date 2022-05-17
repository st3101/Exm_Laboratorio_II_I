namespace InterfazGrafica
{
    partial class FrmHistorial
    {
        /// <summary
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
            this.RtbHistorial = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RtbHistorial
            // 
            this.RtbHistorial.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.RtbHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtbHistorial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbHistorial.Location = new System.Drawing.Point(12, 12);
            this.RtbHistorial.Name = "RtbHistorial";
            this.RtbHistorial.ReadOnly = true;
            this.RtbHistorial.Size = new System.Drawing.Size(615, 681);
            this.RtbHistorial.TabIndex = 0;
            this.RtbHistorial.Text = "Sin historial";
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(639, 705);
            this.Controls.Add(this.RtbHistorial);
            this.MaximizeBox = false;
            this.Name = "FrmHistorial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistorial_FormClosing);
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbHistorial;
    }
}