using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ksrPanel
{
    public partial class frmMainMenu : ksrPanel.frmModelo
    {
        public frmMainMenu()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
            cambiarUbicacionLogo(904, 824);



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
            frmAbmVehiculos form = new frmAbmVehiculos();
            form.ShowDialog();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPruebas form = new FrmPruebas();
            form.ShowDialog();
        }
    }
}
