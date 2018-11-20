namespace ksrPanel
{
    partial class frmLogin
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
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblLogUser = new System.Windows.Forms.Label();
            this.lblLogPass = new System.Windows.Forms.Label();
            this.tbSecret = new System.Windows.Forms.TextBox();
            this.btnLogOk = new System.Windows.Forms.Button();
            this.btnLogCXL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(260, 80);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(387, 32);
            this.cbUsuarios.TabIndex = 1;
            // 
            // lblLogUser
            // 
            this.lblLogUser.AutoSize = true;
            this.lblLogUser.Location = new System.Drawing.Point(174, 83);
            this.lblLogUser.Name = "lblLogUser";
            this.lblLogUser.Size = new System.Drawing.Size(80, 24);
            this.lblLogUser.TabIndex = 2;
            this.lblLogUser.Text = "Usuario:";
            // 
            // lblLogPass
            // 
            this.lblLogPass.AutoSize = true;
            this.lblLogPass.Location = new System.Drawing.Point(143, 154);
            this.lblLogPass.Name = "lblLogPass";
            this.lblLogPass.Size = new System.Drawing.Size(111, 24);
            this.lblLogPass.TabIndex = 3;
            this.lblLogPass.Text = "Contraseña:";
            // 
            // tbSecret
            // 
            this.tbSecret.Location = new System.Drawing.Point(260, 151);
            this.tbSecret.Name = "tbSecret";
            this.tbSecret.PasswordChar = '*';
            this.tbSecret.Size = new System.Drawing.Size(285, 32);
            this.tbSecret.TabIndex = 4;
            // 
            // btnLogOk
            // 
            this.btnLogOk.Location = new System.Drawing.Point(260, 203);
            this.btnLogOk.Name = "btnLogOk";
            this.btnLogOk.Size = new System.Drawing.Size(144, 65);
            this.btnLogOk.TabIndex = 5;
            this.btnLogOk.Text = "Aceptar";
            this.btnLogOk.UseVisualStyleBackColor = true;
            this.btnLogOk.Click += new System.EventHandler(this.btnLogOk_Click);
            // 
            // btnLogCXL
            // 
            this.btnLogCXL.Location = new System.Drawing.Point(410, 203);
            this.btnLogCXL.Name = "btnLogCXL";
            this.btnLogCXL.Size = new System.Drawing.Size(135, 65);
            this.btnLogCXL.TabIndex = 6;
            this.btnLogCXL.Text = "Cancelar";
            this.btnLogCXL.UseVisualStyleBackColor = true;
            this.btnLogCXL.Click += new System.EventHandler(this.btnLogCXL_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogCXL);
            this.Controls.Add(this.btnLogOk);
            this.Controls.Add(this.tbSecret);
            this.Controls.Add(this.lblLogPass);
            this.Controls.Add(this.lblLogUser);
            this.Controls.Add(this.cbUsuarios);
            this.Name = "frmLogin";
            this.Text = "Log In";
            this.Controls.SetChildIndex(this.cbUsuarios, 0);
            this.Controls.SetChildIndex(this.lblLogUser, 0);
            this.Controls.SetChildIndex(this.lblLogPass, 0);
            this.Controls.SetChildIndex(this.tbSecret, 0);
            this.Controls.SetChildIndex(this.btnLogOk, 0);
            this.Controls.SetChildIndex(this.btnLogCXL, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label lblLogUser;
        private System.Windows.Forms.Label lblLogPass;
        private System.Windows.Forms.TextBox tbSecret;
        private System.Windows.Forms.Button btnLogOk;
        private System.Windows.Forms.Button btnLogCXL;
    }
}