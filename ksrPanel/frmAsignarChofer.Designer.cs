namespace ksrPanel
{
    partial class frmAsignarChofer
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
            this.lblAsignarChofer = new System.Windows.Forms.Label();
            this.lblUnidadAsignada = new System.Windows.Forms.Label();
            this.lblComboConductor = new System.Windows.Forms.Label();
            this.dgvConductores = new System.Windows.Forms.DataGridView();
            this.lblFechaAsingacion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsignarChofer
            // 
            this.lblAsignarChofer.AutoSize = true;
            this.lblAsignarChofer.Location = new System.Drawing.Point(12, 9);
            this.lblAsignarChofer.Name = "lblAsignarChofer";
            this.lblAsignarChofer.Size = new System.Drawing.Size(133, 24);
            this.lblAsignarChofer.TabIndex = 1;
            this.lblAsignarChofer.Text = "Asignar Chofer";
            // 
            // lblUnidadAsignada
            // 
            this.lblUnidadAsignada.AutoSize = true;
            this.lblUnidadAsignada.Location = new System.Drawing.Point(343, 9);
            this.lblUnidadAsignada.Name = "lblUnidadAsignada";
            this.lblUnidadAsignada.Size = new System.Drawing.Size(80, 24);
            this.lblUnidadAsignada.TabIndex = 2;
            this.lblUnidadAsignada.Text = "vehiculo";
            // 
            // lblComboConductor
            // 
            this.lblComboConductor.AutoSize = true;
            this.lblComboConductor.Location = new System.Drawing.Point(12, 97);
            this.lblComboConductor.Name = "lblComboConductor";
            this.lblComboConductor.Size = new System.Drawing.Size(103, 24);
            this.lblComboConductor.TabIndex = 3;
            this.lblComboConductor.Text = "Conductor:";
            // 
            // dgvConductores
            // 
            this.dgvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConductores.Location = new System.Drawing.Point(16, 124);
            this.dgvConductores.Name = "dgvConductores";
            this.dgvConductores.RowTemplate.Height = 28;
            this.dgvConductores.Size = new System.Drawing.Size(399, 150);
            this.dgvConductores.TabIndex = 4;
            // 
            // lblFechaAsingacion
            // 
            this.lblFechaAsingacion.AutoSize = true;
            this.lblFechaAsingacion.Location = new System.Drawing.Point(421, 97);
            this.lblFechaAsingacion.Name = "lblFechaAsingacion";
            this.lblFechaAsingacion.Size = new System.Drawing.Size(179, 24);
            this.lblFechaAsingacion.TabIndex = 5;
            this.lblFechaAsingacion.Text = "Fecha de Asignacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(425, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(348, 32);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 384);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 54);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(148, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 54);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAsignarChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaAsingacion);
            this.Controls.Add(this.dgvConductores);
            this.Controls.Add(this.lblComboConductor);
            this.Controls.Add(this.lblUnidadAsignada);
            this.Controls.Add(this.lblAsignarChofer);
            this.Name = "frmAsignarChofer";
            this.Text = "frmAsignarChofer";
            this.Load += new System.EventHandler(this.frmAsignarChofer_Load);
            this.Controls.SetChildIndex(this.lblAsignarChofer, 0);
            this.Controls.SetChildIndex(this.lblUnidadAsignada, 0);
            this.Controls.SetChildIndex(this.lblComboConductor, 0);
            this.Controls.SetChildIndex(this.dgvConductores, 0);
            this.Controls.SetChildIndex(this.lblFechaAsingacion, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsignarChofer;
        private System.Windows.Forms.Label lblUnidadAsignada;
        private System.Windows.Forms.Label lblComboConductor;
        private System.Windows.Forms.DataGridView dgvConductores;
        private System.Windows.Forms.Label lblFechaAsingacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
    }
}