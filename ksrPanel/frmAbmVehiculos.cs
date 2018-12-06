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
    public partial class frmAbmVehiculos : frmModelo
    {
        private List<Vehiculos> listaVehiculos;
        private clsUsuarios userLoged;

        public frmAbmVehiculos()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
            cambiarUbicacionLogo(904, 824);
        }

        public frmAbmVehiculos(clsUsuarios userLoged)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
            cambiarUbicacionLogo(904, 824);
            this.userLoged = userLoged;
        }

        private void frmAbmVehiculos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            VehiculoBusiness negocio = new VehiculoBusiness();
            try
            {
                listaVehiculos = (List<Vehiculos>)negocio.listar();
                dgvVehiculos.DataSource = listaVehiculos;
                dgvVehiculos.Columns[0].Visible = false;
                dgvVehiculos.Columns[4].Visible = false;
                dgvVehiculos.Columns[5].Visible = false;
                dgvVehiculos.Columns[7].Visible = false;
                dgvVehiculos.Columns[8].Visible = false;
                dgvVehiculos.Columns[9].Visible = false;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            frmGestionVehiculo form = new frmGestionVehiculo();
            form.ShowDialog();
            cargar();
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculos modificado;
            //clsUsuarios conductormodificado = new clsUsuarios();
            //UsuarioBusiness conductorBusines = new UsuarioBusiness();
            //VehiculoBusiness vehiculoBusiness = new VehiculoBusiness();
            try
            {
                modificado = (Vehiculos)dgvVehiculos.CurrentRow.DataBoundItem;
                //verificamos si el vehiculo tiene conductor. si es asi le cargamos el conductor y lo pasamos con el vehiculo.
                //if(vehiculoBusiness.traerConductor(modificado.Chapa)!= 0) //si es distinto de cero tiene conductor.
                //{
                //    modificado.Conductor = (clsUsuarios)conductorBusines.cargarData((int)vehiculoBusiness.traerConductor(modificado.Chapa));
                //}
                //conductormodificado = conductorBusines.cargarData(modificado.Conductor.Id);
                //modificado.Conductor.Id = conductormodificado.Id;
                //modificado.Conductor.Nombre = conductormodificado.Nombre;
                //modificado.Conductor.Apellido = conductormodificado.Apellido;
                //le paso al constructor del formulario el objeto
                frmGestionVehiculo modificar = new frmGestionVehiculo(modificado);
                modificar.ShowDialog();
                cargar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " - " + ex.ToString());
            }

        }

        private void btnBajaVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculos vehiculoBaja;
            VehiculoBusiness negocio = new VehiculoBusiness();
            try
            {
                vehiculoBaja = (Vehiculos)dgvVehiculos.CurrentRow.DataBoundItem;
                negocio.baja(vehiculoBaja);
                cargar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " - "+ ex.ToString());
            }

        }

        private void btnRegistrarKM_Click(object sender, EventArgs e)
        {
            Vehiculos VehiculoARegistrarKm;
            clsUsuarios usuarioLogeado = userLoged;
            VehiculoARegistrarKm = (Vehiculos)dgvVehiculos.CurrentRow.DataBoundItem;
            frmGestionKilometros cargaKm = new frmGestionKilometros(VehiculoARegistrarKm,usuarioLogeado);
            cargaKm.ShowDialog();
            cargar();
        }

        private void btbAsignarChofer_Click(object sender, EventArgs e)
        {
            Vehiculos VehiculoARegistrarKm;
            VehiculoARegistrarKm = (Vehiculos)dgvVehiculos.CurrentRow.DataBoundItem;
            frmAsignarChofer asignarConductor = new frmAsignarChofer(VehiculoARegistrarKm);
            asignarConductor.ShowDialog();
            cargar();

        }
    }
}
