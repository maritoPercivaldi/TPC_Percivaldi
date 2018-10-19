namespace ksrPanel
{
    partial class frmAbmUsuarios
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
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.tbBuscarUsuario = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Location = new System.Drawing.Point(13, 13);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(88, 24);
            this.lblListaUsuarios.TabIndex = 1;
            this.lblListaUsuarios.Text = "Usuarios:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(17, 106);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(767, 340);
            this.dgvUsuarios.TabIndex = 2;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AutoSize = true;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(827, 133);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(159, 58);
            this.btnAgregarUsuario.TabIndex = 3;
            this.btnAgregarUsuario.Text = "Nuevo Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.AutoSize = true;
            this.btnEditarUsuario.Location = new System.Drawing.Point(826, 197);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(160, 58);
            this.btnEditarUsuario.TabIndex = 4;
            this.btnEditarUsuario.Text = "Editar Usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.AutoSize = true;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(827, 261);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(159, 58);
            this.btnEliminarUsuario.TabIndex = 5;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // tbBuscarUsuario
            // 
            this.tbBuscarUsuario.Location = new System.Drawing.Point(489, 61);
            this.tbBuscarUsuario.Name = "tbBuscarUsuario";
            this.tbBuscarUsuario.Size = new System.Drawing.Size(295, 32);
            this.tbBuscarUsuario.TabIndex = 6;
            this.tbBuscarUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarUsuario_KeyPress);
            this.tbBuscarUsuario.MouseHover += new System.EventHandler(this.tbBuscarUsuario_MouseHover);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(395, 64);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(70, 24);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar:";
            // 
            // frmAbmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 964);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tbBuscarUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblListaUsuarios);
            this.Name = "frmAbmUsuarios";
            this.Text = "frmAbmUsuarios";
            this.Load += new System.EventHandler(this.frmAbmUsuarios_Load);
            this.Controls.SetChildIndex(this.lblListaUsuarios, 0);
            this.Controls.SetChildIndex(this.dgvUsuarios, 0);
            this.Controls.SetChildIndex(this.btnAgregarUsuario, 0);
            this.Controls.SetChildIndex(this.btnEditarUsuario, 0);
            this.Controls.SetChildIndex(this.btnEliminarUsuario, 0);
            this.Controls.SetChildIndex(this.tbBuscarUsuario, 0);
            this.Controls.SetChildIndex(this.lblBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.TextBox tbBuscarUsuario;
        private System.Windows.Forms.Label lblBuscar;
    }
}