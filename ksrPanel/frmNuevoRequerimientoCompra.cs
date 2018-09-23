using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ksrPanel
{
    public partial class frmNuevoRequerimientoCompra : ksrPanel.frmModelo
    {
        public frmNuevoRequerimientoCompra()
        {
            InitializeComponent();
            
            this.Size = new System.Drawing.Size(1024, 800);
            cambiarUbicacionLogo(800, 800);
            
        }

        private void frmNuevoRequerimientoCompra_Load(object sender, EventArgs e)
        {
            //nuevo objeto de la clase negocioen este caso de usuarios para que llene la lista
            UsuarioBusiness negocioUsuario = new UsuarioBusiness();

            try
            {
                cbUsuarioRequerimiento.DataSource = negocioUsuario.listar();
                cbUsuarioRequerimiento.DisplayMember = "APELLIDO";
                cbUsuarioRequerimiento.ValueMember = "NOMBRE";
                cbUsuarioRequerimiento.SelectedIndex = -1;
                dtpFechaCreacion.Value = DateTime.Now;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
