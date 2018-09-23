namespace ksrPanel
{
    partial class frmNuevoRequerimientoCompra
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
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechadeHoy = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cbUsuarioRequerimiento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(13, 13);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(70, 24);
            this.lblAsunto.TabIndex = 1;
            this.lblAsunto.Text = "Asunto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(186, 24);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Detalle de la Compra";
            // 
            // lblFechadeHoy
            // 
            this.lblFechadeHoy.AutoSize = true;
            this.lblFechadeHoy.Location = new System.Drawing.Point(572, 14);
            this.lblFechadeHoy.Name = "lblFechadeHoy";
            this.lblFechadeHoy.Size = new System.Drawing.Size(58, 24);
            this.lblFechadeHoy.TabIndex = 3;
            this.lblFechadeHoy.Text = "Fecha";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(13, 41);
            this.tbNombre.MaxLength = 140;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(479, 32);
            this.tbNombre.TabIndex = 4;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(13, 119);
            this.tbDescripcion.MaxLength = 400;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(479, 295);
            this.tbDescripcion.TabIndex = 5;
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Enabled = false;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(576, 41);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(367, 32);
            this.dtpFechaCreacion.TabIndex = 6;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(13, 448);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(277, 24);
            this.lblResponsable.TabIndex = 7;
            this.lblResponsable.Text = "Responsable del Requerimiento";
            // 
            // cbUsuarioRequerimiento
            // 
            this.cbUsuarioRequerimiento.FormattingEnabled = true;
            this.cbUsuarioRequerimiento.Location = new System.Drawing.Point(13, 476);
            this.cbUsuarioRequerimiento.Name = "cbUsuarioRequerimiento";
            this.cbUsuarioRequerimiento.Size = new System.Drawing.Size(277, 32);
            this.cbUsuarioRequerimiento.TabIndex = 8;
            // 
            // frmNuevoRequerimientoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 740);
            this.Controls.Add(this.cbUsuarioRequerimiento);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblFechadeHoy);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblAsunto);
            this.Name = "frmNuevoRequerimientoCompra";
            this.Text = "Nuevo Requerimiento de Compra";
            this.Load += new System.EventHandler(this.frmNuevoRequerimientoCompra_Load);
            this.Controls.SetChildIndex(this.lblAsunto, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.lblFechadeHoy, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.tbDescripcion, 0);
            this.Controls.SetChildIndex(this.dtpFechaCreacion, 0);
            this.Controls.SetChildIndex(this.lblResponsable, 0);
            this.Controls.SetChildIndex(this.cbUsuarioRequerimiento, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechadeHoy;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cbUsuarioRequerimiento;
    }
}