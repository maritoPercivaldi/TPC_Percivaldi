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
    public partial class frmCompras : ksrPanel.frmModelo
    {
        public frmCompras()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
            cambiarUbicacionLogo(904, 824);
        }

        private void btnNuevoReq_Click(object sender, EventArgs e)
        {
            frmNuevoRequerimientoCompra form = new frmNuevoRequerimientoCompra();
            form.ShowDialog();
        }
    }
}
