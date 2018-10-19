namespace ksrPanel
{
    partial class frmAgregarUsuario
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
            this.lblAgregarUsuarioTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.btnProbarMail = new System.Windows.Forms.Button();
            this.btnAceptarAltaUsuario = new System.Windows.Forms.Button();
            this.btnCancelarAltaUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgregarUsuarioTitulo
            // 
            this.lblAgregarUsuarioTitulo.AutoSize = true;
            this.lblAgregarUsuarioTitulo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarUsuarioTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblAgregarUsuarioTitulo.Name = "lblAgregarUsuarioTitulo";
            this.lblAgregarUsuarioTitulo.Size = new System.Drawing.Size(301, 35);
            this.lblAgregarUsuarioTitulo.TabIndex = 1;
            this.lblAgregarUsuarioTitulo.Text = "Complete la información:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 24);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(340, 76);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(80, 24);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(19, 188);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 24);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(340, 188);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(62, 24);
            this.lblDepartamento.TabIndex = 5;
            this.lblDepartamento.Text = "Sector";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(19, 300);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 24);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(23, 104);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(291, 32);
            this.tbNombre.TabIndex = 7;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(344, 104);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(291, 32);
            this.tbApellido.TabIndex = 8;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(23, 215);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(291, 32);
            this.tbMail.TabIndex = 9;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(23, 327);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(291, 32);
            this.tbPass.TabIndex = 10;
            // 
            // cbSector
            // 
            this.cbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Location = new System.Drawing.Point(344, 215);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(291, 32);
            this.cbSector.TabIndex = 11;
            // 
            // btnProbarMail
            // 
            this.btnProbarMail.Location = new System.Drawing.Point(89, 440);
            this.btnProbarMail.Name = "btnProbarMail";
            this.btnProbarMail.Size = new System.Drawing.Size(135, 83);
            this.btnProbarMail.TabIndex = 12;
            this.btnProbarMail.Text = "probarmail";
            this.btnProbarMail.UseVisualStyleBackColor = true;
            this.btnProbarMail.Click += new System.EventHandler(this.btnProbarMail_Click);
            // 
            // btnAceptarAltaUsuario
            // 
            this.btnAceptarAltaUsuario.Location = new System.Drawing.Point(257, 440);
            this.btnAceptarAltaUsuario.Name = "btnAceptarAltaUsuario";
            this.btnAceptarAltaUsuario.Size = new System.Drawing.Size(128, 83);
            this.btnAceptarAltaUsuario.TabIndex = 13;
            this.btnAceptarAltaUsuario.Text = "Aceptar";
            this.btnAceptarAltaUsuario.UseVisualStyleBackColor = true;
            this.btnAceptarAltaUsuario.Click += new System.EventHandler(this.btnAceptarAltaUsuario_Click);
            // 
            // btnCancelarAltaUsuario
            // 
            this.btnCancelarAltaUsuario.Location = new System.Drawing.Point(391, 440);
            this.btnCancelarAltaUsuario.Name = "btnCancelarAltaUsuario";
            this.btnCancelarAltaUsuario.Size = new System.Drawing.Size(128, 83);
            this.btnCancelarAltaUsuario.TabIndex = 14;
            this.btnCancelarAltaUsuario.Text = "Cancelar";
            this.btnCancelarAltaUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarAltaUsuario.Click += new System.EventHandler(this.btnCancelarAltaUsuario_Click);
            // 
            // frmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 740);
            this.Controls.Add(this.btnCancelarAltaUsuario);
            this.Controls.Add(this.btnAceptarAltaUsuario);
            this.Controls.Add(this.btnProbarMail);
            this.Controls.Add(this.cbSector);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarUsuarioTitulo);
            this.Name = "frmAgregarUsuario";
            this.Text = "Agregar un nuevo usuario";
            this.Load += new System.EventHandler(this.frmAgregarUsuario_Load);
            this.Controls.SetChildIndex(this.lblAgregarUsuarioTitulo, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblMail, 0);
            this.Controls.SetChildIndex(this.lblDepartamento, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.tbApellido, 0);
            this.Controls.SetChildIndex(this.tbMail, 0);
            this.Controls.SetChildIndex(this.tbPass, 0);
            this.Controls.SetChildIndex(this.cbSector, 0);
            this.Controls.SetChildIndex(this.btnProbarMail, 0);
            this.Controls.SetChildIndex(this.btnAceptarAltaUsuario, 0);
            this.Controls.SetChildIndex(this.btnCancelarAltaUsuario, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarUsuarioTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.Button btnProbarMail;
        private System.Windows.Forms.Button btnAceptarAltaUsuario;
        private System.Windows.Forms.Button btnCancelarAltaUsuario;
    }
}