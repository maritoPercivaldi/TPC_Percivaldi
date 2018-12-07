namespace ksrPanel
{
    partial class frmGestionMantenimiento
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
            this.lblUnidadAsingada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoMante = new System.Windows.Forms.ComboBox();
            this.cbCatMante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescMante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImporteMante = new System.Windows.Forms.TextBox();
            this.btnOkMante = new System.Windows.Forms.Button();
            this.btnCxlMante = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblUnidadAsingada
            // 
            this.lblUnidadAsingada.AutoSize = true;
            this.lblUnidadAsingada.Location = new System.Drawing.Point(360, 9);
            this.lblUnidadAsingada.Name = "lblUnidadAsingada";
            this.lblUnidadAsingada.Size = new System.Drawing.Size(61, 24);
            this.lblUnidadAsingada.TabIndex = 1;
            this.lblUnidadAsingada.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Reparación";
            // 
            // cbTipoMante
            // 
            this.cbTipoMante.FormattingEnabled = true;
            this.cbTipoMante.Items.AddRange(new object[] {
            "-",
            "Preventiva",
            "Correctiva\t"});
            this.cbTipoMante.Location = new System.Drawing.Point(190, 87);
            this.cbTipoMante.Name = "cbTipoMante";
            this.cbTipoMante.Size = new System.Drawing.Size(172, 32);
            this.cbTipoMante.TabIndex = 3;
            // 
            // cbCatMante
            // 
            this.cbCatMante.FormattingEnabled = true;
            this.cbCatMante.Items.AddRange(new object[] {
            "-",
            "Tren delantero",
            "Tren trasero",
            "Chapa y Pintura",
            "Motor",
            "Caja y Embrague",
            "Frenos",
            "Neumaticos",
            "Electricidad",
            "Service Estandar",
            ""});
            this.cbCatMante.Location = new System.Drawing.Point(190, 128);
            this.cbCatMante.Name = "cbCatMante";
            this.cbCatMante.Size = new System.Drawing.Size(172, 32);
            this.cbCatMante.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // tbDescMante
            // 
            this.tbDescMante.Location = new System.Drawing.Point(124, 179);
            this.tbDescMante.Multiline = true;
            this.tbDescMante.Name = "tbDescMante";
            this.tbDescMante.Size = new System.Drawing.Size(238, 126);
            this.tbDescMante.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Importe";
            // 
            // tbImporteMante
            // 
            this.tbImporteMante.Location = new System.Drawing.Point(124, 324);
            this.tbImporteMante.Name = "tbImporteMante";
            this.tbImporteMante.Size = new System.Drawing.Size(238, 32);
            this.tbImporteMante.TabIndex = 10;
            // 
            // btnOkMante
            // 
            this.btnOkMante.Location = new System.Drawing.Point(16, 446);
            this.btnOkMante.Name = "btnOkMante";
            this.btnOkMante.Size = new System.Drawing.Size(134, 50);
            this.btnOkMante.TabIndex = 11;
            this.btnOkMante.Text = "Aceptar";
            this.btnOkMante.UseVisualStyleBackColor = true;
            this.btnOkMante.Click += new System.EventHandler(this.btnOkMante_Click);
            // 
            // btnCxlMante
            // 
            this.btnCxlMante.Location = new System.Drawing.Point(156, 446);
            this.btnCxlMante.Name = "btnCxlMante";
            this.btnCxlMante.Size = new System.Drawing.Size(134, 50);
            this.btnCxlMante.TabIndex = 12;
            this.btnCxlMante.Text = "Cancelar";
            this.btnCxlMante.UseVisualStyleBackColor = true;
            this.btnCxlMante.Click += new System.EventHandler(this.btnCxlMante_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 386);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 32);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // frmGestionMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCxlMante);
            this.Controls.Add(this.btnOkMante);
            this.Controls.Add(this.tbImporteMante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescMante);
            this.Controls.Add(this.cbCatMante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoMante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUnidadAsingada);
            this.Name = "frmGestionMantenimiento";
            this.Text = "frmGestionMantenimiento";
            this.Controls.SetChildIndex(this.lblUnidadAsingada, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbTipoMante, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbCatMante, 0);
            this.Controls.SetChildIndex(this.tbDescMante, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbImporteMante, 0);
            this.Controls.SetChildIndex(this.btnOkMante, 0);
            this.Controls.SetChildIndex(this.btnCxlMante, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnidadAsingada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoMante;
        private System.Windows.Forms.ComboBox cbCatMante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescMante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbImporteMante;
        private System.Windows.Forms.Button btnOkMante;
        private System.Windows.Forms.Button btnCxlMante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}