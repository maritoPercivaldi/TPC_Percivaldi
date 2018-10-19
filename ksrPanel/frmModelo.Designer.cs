namespace ksrPanel
{
    partial class frmModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelo));
            this.pbKaeser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaeser)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKaeser
            // 
            this.pbKaeser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbKaeser.Image = global::ksrPanel.Properties.Resources.kaeser;
            this.pbKaeser.Location = new System.Drawing.Point(12, 12);
            this.pbKaeser.Name = "pbKaeser";
            this.pbKaeser.Size = new System.Drawing.Size(160, 54);
            this.pbKaeser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKaeser.TabIndex = 0;
            this.pbKaeser.TabStop = false;
            // 
            // frmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(998, 964);
            this.Controls.Add(this.pbKaeser);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModelo";
            ((System.ComponentModel.ISupportInitialize)(this.pbKaeser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKaeser;
        public void cambiarUbicacionLogo(int alto, int ancho)
        {
            pbKaeser.Location = new System.Drawing.Point(ancho, alto);
        }
    }
}