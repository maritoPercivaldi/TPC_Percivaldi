﻿namespace ksrPanel
{
    partial class frmGestionVehiculo
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
            this.lblDominio = new System.Windows.Forms.Label();
            this.tbDominio = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.tbCodMotor = new System.Windows.Forms.TextBox();
            this.lblCodigoMotor = new System.Windows.Forms.Label();
            this.tbCodChasis = new System.Windows.Forms.TextBox();
            this.lblCodigoChasis = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.btnOKModificar = new System.Windows.Forms.Button();
            this.btnCXLModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(12, 89);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(81, 24);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // tbDominio
            // 
            this.tbDominio.Location = new System.Drawing.Point(125, 86);
            this.tbDominio.Name = "tbDominio";
            this.tbDominio.Size = new System.Drawing.Size(166, 32);
            this.tbDominio.TabIndex = 1;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(125, 142);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(166, 32);
            this.tbMarca.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 145);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(62, 24);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(540, 142);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(337, 32);
            this.tbModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(433, 145);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(75, 24);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo";
            // 
            // tbCodMotor
            // 
            this.tbCodMotor.Location = new System.Drawing.Point(125, 198);
            this.tbCodMotor.Name = "tbCodMotor";
            this.tbCodMotor.Size = new System.Drawing.Size(302, 32);
            this.tbCodMotor.TabIndex = 4;
            // 
            // lblCodigoMotor
            // 
            this.lblCodigoMotor.AutoSize = true;
            this.lblCodigoMotor.Location = new System.Drawing.Point(12, 201);
            this.lblCodigoMotor.Name = "lblCodigoMotor";
            this.lblCodigoMotor.Size = new System.Drawing.Size(101, 24);
            this.lblCodigoMotor.TabIndex = 7;
            this.lblCodigoMotor.Text = "Cod Motor";
            // 
            // tbCodChasis
            // 
            this.tbCodChasis.Location = new System.Drawing.Point(540, 197);
            this.tbCodChasis.Name = "tbCodChasis";
            this.tbCodChasis.Size = new System.Drawing.Size(337, 32);
            this.tbCodChasis.TabIndex = 5;
            // 
            // lblCodigoChasis
            // 
            this.lblCodigoChasis.AutoSize = true;
            this.lblCodigoChasis.Location = new System.Drawing.Point(433, 205);
            this.lblCodigoChasis.Name = "lblCodigoChasis";
            this.lblCodigoChasis.Size = new System.Drawing.Size(101, 24);
            this.lblCodigoChasis.TabIndex = 9;
            this.lblCodigoChasis.Text = "Cod Chasis";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(489, 260);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(123, 24);
            this.lblFechaAlta.TabIndex = 11;
            this.lblFechaAlta.Text = "Fecha de Alta";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Location = new System.Drawing.Point(125, 254);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(358, 32);
            this.dtpFechaAlta.TabIndex = 6;
            // 
            // btnOKModificar
            // 
            this.btnOKModificar.Location = new System.Drawing.Point(125, 397);
            this.btnOKModificar.Name = "btnOKModificar";
            this.btnOKModificar.Size = new System.Drawing.Size(147, 69);
            this.btnOKModificar.TabIndex = 15;
            this.btnOKModificar.Text = "Aceptar";
            this.btnOKModificar.UseVisualStyleBackColor = true;
            this.btnOKModificar.Click += new System.EventHandler(this.btnOKModificar_Click);
            // 
            // btnCXLModificar
            // 
            this.btnCXLModificar.Location = new System.Drawing.Point(280, 397);
            this.btnCXLModificar.Name = "btnCXLModificar";
            this.btnCXLModificar.Size = new System.Drawing.Size(147, 69);
            this.btnCXLModificar.TabIndex = 16;
            this.btnCXLModificar.Text = "Cancelar";
            this.btnCXLModificar.UseVisualStyleBackColor = true;
            this.btnCXLModificar.Click += new System.EventHandler(this.btnCXLModificar_Click);
            // 
            // frmGestionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 540);
            this.Controls.Add(this.btnCXLModificar);
            this.Controls.Add(this.btnOKModificar);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.tbCodChasis);
            this.Controls.Add(this.lblCodigoChasis);
            this.Controls.Add(this.tbCodMotor);
            this.Controls.Add(this.lblCodigoMotor);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tbDominio);
            this.Controls.Add(this.lblDominio);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmGestionVehiculo";
            this.Text = "Gestión de Vehículos";
            this.Load += new System.EventHandler(this.frmGestionVehiculo_Load);
            this.Controls.SetChildIndex(this.lblDominio, 0);
            this.Controls.SetChildIndex(this.tbDominio, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.tbMarca, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.tbModelo, 0);
            this.Controls.SetChildIndex(this.lblCodigoMotor, 0);
            this.Controls.SetChildIndex(this.tbCodMotor, 0);
            this.Controls.SetChildIndex(this.lblCodigoChasis, 0);
            this.Controls.SetChildIndex(this.tbCodChasis, 0);
            this.Controls.SetChildIndex(this.lblFechaAlta, 0);
            this.Controls.SetChildIndex(this.dtpFechaAlta, 0);
            this.Controls.SetChildIndex(this.btnOKModificar, 0);
            this.Controls.SetChildIndex(this.btnCXLModificar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.TextBox tbDominio;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox tbCodMotor;
        private System.Windows.Forms.Label lblCodigoMotor;
        private System.Windows.Forms.TextBox tbCodChasis;
        private System.Windows.Forms.Label lblCodigoChasis;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Button btnOKModificar;
        private System.Windows.Forms.Button btnCXLModificar;
    }
}