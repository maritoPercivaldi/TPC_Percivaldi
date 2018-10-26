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
        public frmAbmVehiculos()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
            cambiarUbicacionLogo(904, 824);
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
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculos modificado;
            clsUsuarios conductormodificado = new clsUsuarios();
            UsuarioBusiness conductorBusines = new UsuarioBusiness();
            try
            {
                modificado = (Vehiculos)dgvVehiculos.CurrentRow.DataBoundItem;
                conductormodificado = conductorBusines.cargarData(modificado.Conductor.Id);
                modificado.Conductor.Id = conductormodificado.Id;
                modificado.Conductor.Nombre = conductormodificado.Nombre;
                modificado.Conductor.Apellido = conductormodificado.Apellido;
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
    }
}
