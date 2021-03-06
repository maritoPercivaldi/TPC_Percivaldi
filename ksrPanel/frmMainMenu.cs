﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace ksrPanel
{
    public partial class frmMainMenu : ksrPanel.frmModelo
    {
        private clsUsuarios userLoged;

        public frmMainMenu()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
            cambiarUbicacionLogo(904, 824);



        }

        public frmMainMenu(clsUsuarios userLoged)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
            cambiarUbicacionLogo(904, 824);
            this.userLoged = userLoged;
        }

        private void aBMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbmUsuarios form = new frmAbmUsuarios();
            form.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras form = new frmCompras();
            form.ShowDialog();
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbmVehiculos form = new frmAbmVehiculos(userLoged);
            form.ShowDialog();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPruebas form = new FrmPruebas();
            form.ShowDialog();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por usar la aplicacion", "Salida!");
            System.Windows.Forms.Application.Exit();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes form = new frmReportes();
            form.ShowDialog();
        }
    }
}
