namespace ksrPanel
{
    partial class frmAbmVehiculos
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
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnNuevoVehiculo = new System.Windows.Forms.Button();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.btnBajaVehiculo = new System.Windows.Forms.Button();
            this.btnRegistrarKM = new System.Windows.Forms.Button();
            this.btbAsignarChofer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(12, 95);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.RowTemplate.Height = 28;
            this.dgvVehiculos.Size = new System.Drawing.Size(627, 330);
            this.dgvVehiculos.TabIndex = 1;
            // 
            // btnNuevoVehiculo
            // 
            this.btnNuevoVehiculo.Location = new System.Drawing.Point(645, 94);
            this.btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            this.btnNuevoVehiculo.Size = new System.Drawing.Size(177, 47);
            this.btnNuevoVehiculo.TabIndex = 2;
            this.btnNuevoVehiculo.Text = "Nuevo Vehiculo";
            this.btnNuevoVehiculo.UseVisualStyleBackColor = true;
            this.btnNuevoVehiculo.Click += new System.EventHandler(this.btnNuevoVehiculo_Click);
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.Location = new System.Drawing.Point(645, 147);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(177, 46);
            this.btnModificarVehiculo.TabIndex = 3;
            this.btnModificarVehiculo.Text = "Modificar Vehículo";
            this.btnModificarVehiculo.UseVisualStyleBackColor = true;
            this.btnModificarVehiculo.Click += new System.EventHandler(this.btnModificarVehiculo_Click);
            // 
            // btnBajaVehiculo
            // 
            this.btnBajaVehiculo.Location = new System.Drawing.Point(645, 199);
            this.btnBajaVehiculo.Name = "btnBajaVehiculo";
            this.btnBajaVehiculo.Size = new System.Drawing.Size(177, 46);
            this.btnBajaVehiculo.TabIndex = 4;
            this.btnBajaVehiculo.Text = "Baja Vehículo";
            this.btnBajaVehiculo.UseVisualStyleBackColor = true;
            this.btnBajaVehiculo.Click += new System.EventHandler(this.btnBajaVehiculo_Click);
            // 
            // btnRegistrarKM
            // 
            this.btnRegistrarKM.Location = new System.Drawing.Point(645, 251);
            this.btnRegistrarKM.Name = "btnRegistrarKM";
            this.btnRegistrarKM.Size = new System.Drawing.Size(177, 84);
            this.btnRegistrarKM.TabIndex = 5;
            this.btnRegistrarKM.Text = "Registrar Kilometros";
            this.btnRegistrarKM.UseVisualStyleBackColor = true;
            this.btnRegistrarKM.Click += new System.EventHandler(this.btnRegistrarKM_Click);
            // 
            // btbAsignarChofer
            // 
            this.btbAsignarChofer.Location = new System.Drawing.Point(645, 341);
            this.btbAsignarChofer.Name = "btbAsignarChofer";
            this.btbAsignarChofer.Size = new System.Drawing.Size(177, 84);
            this.btbAsignarChofer.TabIndex = 6;
            this.btbAsignarChofer.Text = "Asignar Chofer";
            this.btbAsignarChofer.UseVisualStyleBackColor = true;
            // 
            // frmAbmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 1185);
            this.Controls.Add(this.btbAsignarChofer);
            this.Controls.Add(this.btnRegistrarKM);
            this.Controls.Add(this.btnBajaVehiculo);
            this.Controls.Add(this.btnModificarVehiculo);
            this.Controls.Add(this.btnNuevoVehiculo);
            this.Controls.Add(this.dgvVehiculos);
            this.Name = "frmAbmVehiculos";
            this.Text = "ABM Vehiculos";
            this.Load += new System.EventHandler(this.frmAbmVehiculos_Load);
            this.Controls.SetChildIndex(this.dgvVehiculos, 0);
            this.Controls.SetChildIndex(this.btnNuevoVehiculo, 0);
            this.Controls.SetChildIndex(this.btnModificarVehiculo, 0);
            this.Controls.SetChildIndex(this.btnBajaVehiculo, 0);
            this.Controls.SetChildIndex(this.btnRegistrarKM, 0);
            this.Controls.SetChildIndex(this.btbAsignarChofer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnNuevoVehiculo;
        private System.Windows.Forms.Button btnModificarVehiculo;
        private System.Windows.Forms.Button btnBajaVehiculo;
        private System.Windows.Forms.Button btnRegistrarKM;
        private System.Windows.Forms.Button btbAsignarChofer;
    }
}