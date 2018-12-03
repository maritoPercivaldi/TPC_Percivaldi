using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace ksrPanel
{
    public partial class frmGestionKilometros : frmModelo
    {
        private Vehiculos vehiculo = null;
        KilometrosPorVehiculos kmARegistrar = null;
        kmPorVehiculosBusiness negocio = null;

        public frmGestionKilometros()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(600,400);
            cambiarUbicacionLogo(280,400);
        }

        public frmGestionKilometros(Vehiculos VehiculoModificado, clsUsuarios userLoged)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(600, 400);
            cambiarUbicacionLogo(280, 400);
            vehiculo = VehiculoModificado;
            kmARegistrar = new KilometrosPorVehiculos();
            lblVehiculoRegistrado.Text = vehiculo.Chapa + " - " + vehiculo.Marca + " - " + vehiculo.Modelo + " - " + vehiculo.IdAuto;
            kmARegistrar.UsuarioCarga = userLoged;
            kmARegistrar.VehiculoKM = vehiculo;
        }

        private void tbKmRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnOkKm_Click(object sender, EventArgs e)
        {
            if(vehiculo != null)
            {
                try
                {
                   
                    kmARegistrar.FechaCarga = dtpFechaRegistroKM.Value;
                    kmARegistrar.Kilometros = Convert.ToInt32(tbKmRegistro.Text);
                    negocio = new kmPorVehiculosBusiness(); 
                    negocio.AltaRegistro(kmARegistrar);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - " + ex.ToString(),"Error!");
                }
                
            }

        }

        private void frmGestionKilometros_Load(object sender, EventArgs e)
        {
            dtpFechaRegistroKM.Value = DateTime.Today;
        }
    }
}
