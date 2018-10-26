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
    public partial class frmGestionVehiculo : frmModelo
    {
        private Vehiculos vehiculo = null;
        private UsuarioBusiness conductor = null;
        
        public frmGestionVehiculo()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800,800);
            cambiarUbicacionLogo(680, 600);

        }
        //constructor que recibe el Vehiculo por parametro
        public frmGestionVehiculo(Vehiculos VehiculoModificado)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 800);
            cambiarUbicacionLogo(680, 600);
            vehiculo = VehiculoModificado;
            conductor.cargarData(vehiculo.IdAuto);
        }

        //en el evento load de la gestion de vehiculos. Labura independiente si es ALTA o MODIFICACION
        private void frmGestionVehiculo_Load(object sender, EventArgs e)
        {
            //instancio la clase negocio
            
            VehiculoBusiness negocioVehiculo = new VehiculoBusiness();
            try
            {
                UsuarioBusiness negocioUsuario = new UsuarioBusiness();
                cbConductor.DataSource = negocioUsuario.listarApenom();
                cbConductor.DisplayMember = "ApeNom";
                cbConductor.ValueMember = "Id";
                if (vehiculo == null)
                {
                    cbConductor.SelectedIndex = -1;
                }
                else
                {
                    tbDominio.Text = vehiculo.Chapa;
                    tbMarca.Text = vehiculo.Marca;
                    tbModelo.Text = vehiculo.Modelo;
                    tbCodMotor.Text = vehiculo.CodigoMotor;
                    tbCodChasis.Text = vehiculo.CodigoChasis;
                    dtpFechaAlta.Value = vehiculo.FechaAlta.Date;
                    cbConductor.SelectedValue = (int)vehiculo.Conductor.Id+1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " - " + ex.ToString());
            }

        }

        
    }
}
