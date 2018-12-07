namespace ksrPanel
{
    partial class frmReportes
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
            this.dgvConductoresReporte = new System.Windows.Forms.DataGridView();
            this.dgvKmReporte = new System.Windows.Forms.DataGridView();
            this.btnExportarConductor = new System.Windows.Forms.Button();
            this.btnExportarKM = new System.Windows.Forms.Button();
            this.lblReporteConductores = new System.Windows.Forms.Label();
            this.lblReporteKM = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblReporteMant = new System.Windows.Forms.Label();
            this.dgvMantVehiculo = new System.Windows.Forms.DataGridView();
            this.btnExpoMante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductoresReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKmReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConductoresReporte
            // 
            this.dgvConductoresReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConductoresReporte.Location = new System.Drawing.Point(12, 140);
            this.dgvConductoresReporte.Name = "dgvConductoresReporte";
            this.dgvConductoresReporte.RowTemplate.Height = 28;
            this.dgvConductoresReporte.Size = new System.Drawing.Size(674, 141);
            this.dgvConductoresReporte.TabIndex = 1;
            // 
            // dgvKmReporte
            // 
            this.dgvKmReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKmReporte.Location = new System.Drawing.Point(12, 393);
            this.dgvKmReporte.Name = "dgvKmReporte";
            this.dgvKmReporte.RowTemplate.Height = 28;
            this.dgvKmReporte.Size = new System.Drawing.Size(674, 146);
            this.dgvKmReporte.TabIndex = 2;
            // 
            // btnExportarConductor
            // 
            this.btnExportarConductor.Location = new System.Drawing.Point(21, 287);
            this.btnExportarConductor.Name = "btnExportarConductor";
            this.btnExportarConductor.Size = new System.Drawing.Size(104, 62);
            this.btnExportarConductor.TabIndex = 3;
            this.btnExportarConductor.Text = "Exportar a Excel";
            this.btnExportarConductor.UseVisualStyleBackColor = true;
            this.btnExportarConductor.Click += new System.EventHandler(this.btnExportarConductor_Click);
            // 
            // btnExportarKM
            // 
            this.btnExportarKM.Location = new System.Drawing.Point(21, 545);
            this.btnExportarKM.Name = "btnExportarKM";
            this.btnExportarKM.Size = new System.Drawing.Size(104, 61);
            this.btnExportarKM.TabIndex = 4;
            this.btnExportarKM.Text = "Exportar a Excel";
            this.btnExportarKM.UseVisualStyleBackColor = true;
            this.btnExportarKM.Click += new System.EventHandler(this.btnExportarKM_Click);
            // 
            // lblReporteConductores
            // 
            this.lblReporteConductores.AutoSize = true;
            this.lblReporteConductores.Location = new System.Drawing.Point(12, 113);
            this.lblReporteConductores.Name = "lblReporteConductores";
            this.lblReporteConductores.Size = new System.Drawing.Size(208, 24);
            this.lblReporteConductores.TabIndex = 5;
            this.lblReporteConductores.Text = "Conductor por Vehiculo";
            // 
            // lblReporteKM
            // 
            this.lblReporteKM.AutoSize = true;
            this.lblReporteKM.Location = new System.Drawing.Point(8, 366);
            this.lblReporteKM.Name = "lblReporteKM";
            this.lblReporteKM.Size = new System.Drawing.Size(145, 24);
            this.lblReporteKM.TabIndex = 6;
            this.lblReporteKM.Text = "Km Por Vehiculo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 900);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 52);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblReporteMant
            // 
            this.lblReporteMant.AutoSize = true;
            this.lblReporteMant.Location = new System.Drawing.Point(8, 627);
            this.lblReporteMant.Name = "lblReporteMant";
            this.lblReporteMant.Size = new System.Drawing.Size(250, 24);
            this.lblReporteMant.TabIndex = 8;
            this.lblReporteMant.Text = "Mantenimiento Por Vehiculo";
            // 
            // dgvMantVehiculo
            // 
            this.dgvMantVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantVehiculo.Location = new System.Drawing.Point(12, 654);
            this.dgvMantVehiculo.Name = "dgvMantVehiculo";
            this.dgvMantVehiculo.RowTemplate.Height = 28;
            this.dgvMantVehiculo.Size = new System.Drawing.Size(674, 146);
            this.dgvMantVehiculo.TabIndex = 9;
            // 
            // btnExpoMante
            // 
            this.btnExpoMante.Location = new System.Drawing.Point(21, 806);
            this.btnExpoMante.Name = "btnExpoMante";
            this.btnExpoMante.Size = new System.Drawing.Size(104, 61);
            this.btnExpoMante.TabIndex = 10;
            this.btnExpoMante.Text = "Exportar a Excel";
            this.btnExpoMante.UseVisualStyleBackColor = true;
            this.btnExpoMante.Click += new System.EventHandler(this.btnExpoMante_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 964);
            this.Controls.Add(this.btnExpoMante);
            this.Controls.Add(this.dgvMantVehiculo);
            this.Controls.Add(this.lblReporteMant);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblReporteKM);
            this.Controls.Add(this.lblReporteConductores);
            this.Controls.Add(this.btnExportarKM);
            this.Controls.Add(this.btnExportarConductor);
            this.Controls.Add(this.dgvKmReporte);
            this.Controls.Add(this.dgvConductoresReporte);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.Controls.SetChildIndex(this.dgvConductoresReporte, 0);
            this.Controls.SetChildIndex(this.dgvKmReporte, 0);
            this.Controls.SetChildIndex(this.btnExportarConductor, 0);
            this.Controls.SetChildIndex(this.btnExportarKM, 0);
            this.Controls.SetChildIndex(this.lblReporteConductores, 0);
            this.Controls.SetChildIndex(this.lblReporteKM, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.lblReporteMant, 0);
            this.Controls.SetChildIndex(this.dgvMantVehiculo, 0);
            this.Controls.SetChildIndex(this.btnExpoMante, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductoresReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKmReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConductoresReporte;
        private System.Windows.Forms.DataGridView dgvKmReporte;
        private System.Windows.Forms.Button btnExportarConductor;
        private System.Windows.Forms.Button btnExportarKM;
        private System.Windows.Forms.Label lblReporteConductores;
        private System.Windows.Forms.Label lblReporteKM;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblReporteMant;
        private System.Windows.Forms.DataGridView dgvMantVehiculo;
        private System.Windows.Forms.Button btnExpoMante;
    }
}