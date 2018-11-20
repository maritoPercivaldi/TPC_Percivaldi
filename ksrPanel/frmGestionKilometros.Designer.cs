namespace ksrPanel
{
    partial class frmGestionKilometros
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
            this.lblRegistrarKilometros = new System.Windows.Forms.Label();
            this.lblVehiculoRegistrado = new System.Windows.Forms.Label();
            this.tbKmRegistro = new System.Windows.Forms.TextBox();
            this.lblKilometrosRecorridos = new System.Windows.Forms.Label();
            this.dtpFechaRegistroKM = new System.Windows.Forms.DateTimePicker();
            this.btnOkKm = new System.Windows.Forms.Button();
            this.btnCxlKM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistrarKilometros
            // 
            this.lblRegistrarKilometros.AutoSize = true;
            this.lblRegistrarKilometros.Location = new System.Drawing.Point(12, 9);
            this.lblRegistrarKilometros.Name = "lblRegistrarKilometros";
            this.lblRegistrarKilometros.Size = new System.Drawing.Size(199, 24);
            this.lblRegistrarKilometros.TabIndex = 1;
            this.lblRegistrarKilometros.Text = "Registro de Kilometros";
            // 
            // lblVehiculoRegistrado
            // 
            this.lblVehiculoRegistrado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehiculoRegistrado.AutoSize = true;
            this.lblVehiculoRegistrado.Location = new System.Drawing.Point(325, 9);
            this.lblVehiculoRegistrado.Name = "lblVehiculoRegistrado";
            this.lblVehiculoRegistrado.Size = new System.Drawing.Size(81, 24);
            this.lblVehiculoRegistrado.TabIndex = 2;
            this.lblVehiculoRegistrado.Text = "Vehiculo";
            // 
            // tbKmRegistro
            // 
            this.tbKmRegistro.Location = new System.Drawing.Point(12, 130);
            this.tbKmRegistro.Name = "tbKmRegistro";
            this.tbKmRegistro.Size = new System.Drawing.Size(199, 32);
            this.tbKmRegistro.TabIndex = 3;
            this.tbKmRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKmRegistro_KeyPress);
            // 
            // lblKilometrosRecorridos
            // 
            this.lblKilometrosRecorridos.AutoSize = true;
            this.lblKilometrosRecorridos.Location = new System.Drawing.Point(217, 133);
            this.lblKilometrosRecorridos.Name = "lblKilometrosRecorridos";
            this.lblKilometrosRecorridos.Size = new System.Drawing.Size(187, 24);
            this.lblKilometrosRecorridos.TabIndex = 4;
            this.lblKilometrosRecorridos.Text = "Kilometros a Ingresar";
            // 
            // dtpFechaRegistroKM
            // 
            this.dtpFechaRegistroKM.Location = new System.Drawing.Point(12, 183);
            this.dtpFechaRegistroKM.Name = "dtpFechaRegistroKM";
            this.dtpFechaRegistroKM.Size = new System.Drawing.Size(392, 32);
            this.dtpFechaRegistroKM.TabIndex = 5;
            // 
            // btnOkKm
            // 
            this.btnOkKm.Location = new System.Drawing.Point(12, 236);
            this.btnOkKm.Name = "btnOkKm";
            this.btnOkKm.Size = new System.Drawing.Size(138, 62);
            this.btnOkKm.TabIndex = 6;
            this.btnOkKm.Text = "Aceptar";
            this.btnOkKm.UseVisualStyleBackColor = true;
            this.btnOkKm.Click += new System.EventHandler(this.btnOkKm_Click);
            // 
            // btnCxlKM
            // 
            this.btnCxlKM.Location = new System.Drawing.Point(156, 236);
            this.btnCxlKM.Name = "btnCxlKM";
            this.btnCxlKM.Size = new System.Drawing.Size(138, 62);
            this.btnCxlKM.TabIndex = 7;
            this.btnCxlKM.Text = "Cancelar";
            this.btnCxlKM.UseVisualStyleBackColor = true;
            // 
            // frmGestionKilometros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 508);
            this.Controls.Add(this.btnCxlKM);
            this.Controls.Add(this.btnOkKm);
            this.Controls.Add(this.dtpFechaRegistroKM);
            this.Controls.Add(this.lblKilometrosRecorridos);
            this.Controls.Add(this.tbKmRegistro);
            this.Controls.Add(this.lblVehiculoRegistrado);
            this.Controls.Add(this.lblRegistrarKilometros);
            this.Name = "frmGestionKilometros";
            this.Text = "frmGestionKilometros";
            this.Load += new System.EventHandler(this.frmGestionKilometros_Load);
            this.Controls.SetChildIndex(this.lblRegistrarKilometros, 0);
            this.Controls.SetChildIndex(this.lblVehiculoRegistrado, 0);
            this.Controls.SetChildIndex(this.tbKmRegistro, 0);
            this.Controls.SetChildIndex(this.lblKilometrosRecorridos, 0);
            this.Controls.SetChildIndex(this.dtpFechaRegistroKM, 0);
            this.Controls.SetChildIndex(this.btnOkKm, 0);
            this.Controls.SetChildIndex(this.btnCxlKM, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrarKilometros;
        private System.Windows.Forms.Label lblVehiculoRegistrado;
        private System.Windows.Forms.TextBox tbKmRegistro;
        private System.Windows.Forms.Label lblKilometrosRecorridos;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistroKM;
        private System.Windows.Forms.Button btnOkKm;
        private System.Windows.Forms.Button btnCxlKM;
    }
}