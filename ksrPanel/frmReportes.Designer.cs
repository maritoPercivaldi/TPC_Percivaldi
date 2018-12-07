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
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductoresReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKmReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConductoresReporte
            // 
            this.dgvConductoresReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConductoresReporte.Location = new System.Drawing.Point(12, 140);
            this.dgvConductoresReporte.Name = "dgvConductoresReporte";
            this.dgvConductoresReporte.RowTemplate.Height = 28;
            this.dgvConductoresReporte.Size = new System.Drawing.Size(674, 197);
            this.dgvConductoresReporte.TabIndex = 1;
            // 
            // dgvKmReporte
            // 
            this.dgvKmReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKmReporte.Location = new System.Drawing.Point(12, 494);
            this.dgvKmReporte.Name = "dgvKmReporte";
            this.dgvKmReporte.RowTemplate.Height = 28;
            this.dgvKmReporte.Size = new System.Drawing.Size(674, 197);
            this.dgvKmReporte.TabIndex = 2;
            // 
            // btnExportarConductor
            // 
            this.btnExportarConductor.Location = new System.Drawing.Point(21, 343);
            this.btnExportarConductor.Name = "btnExportarConductor";
            this.btnExportarConductor.Size = new System.Drawing.Size(104, 62);
            this.btnExportarConductor.TabIndex = 3;
            this.btnExportarConductor.Text = "Exportar a Excel";
            this.btnExportarConductor.UseVisualStyleBackColor = true;
            this.btnExportarConductor.Click += new System.EventHandler(this.btnExportarConductor_Click);
            // 
            // btnExportarKM
            // 
            this.btnExportarKM.Location = new System.Drawing.Point(21, 697);
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
            this.lblReporteKM.Location = new System.Drawing.Point(8, 467);
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
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 964);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductoresReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKmReporte)).EndInit();
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
    }
}