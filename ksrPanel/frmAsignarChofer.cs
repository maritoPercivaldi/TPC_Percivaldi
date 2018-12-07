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
    public partial class frmAsignarChofer : frmModelo
    {
        private List<clsUsuarios> listaUsuarios;
        Vehiculos autoRecibido = null;
        ConductorPorVehiculo conductor = null;
        ConductorPorVehiculoBusiness negocio = null;
        bool TipoEjecucion;
        public frmAsignarChofer()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(600, 400);
            cambiarUbicacionLogo(280, 400);
        }

        public frmAsignarChofer(Vehiculos VehiculoModificado)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(600, 400);
            cambiarUbicacionLogo(280, 400);
            autoRecibido = VehiculoModificado;
            lblUnidadAsignada.Text = autoRecibido.Chapa.ToString() + " - " + autoRecibido.Marca.ToString() +" - " + autoRecibido.Modelo.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAsignarChofer_Load(object sender, EventArgs e)
        {
            cargar();
            negocio = new ConductorPorVehiculoBusiness();
            conductor = negocio.cargarData(autoRecibido.Chapa);
            if(conductor != null)
            {
                //si no es null significa que hay chofer asignado para la unidad.
                MessageBox.Show(conductor.ConductorAsignado.Nombre +" "+ conductor.ConductorAsignado.Apellido, "Conductor Asignado");
                dgvConductores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvConductores.CurrentCell = dgvConductores[1,conductor.ConductorAsignado.Id -1];
                TipoEjecucion = true; //existe conductor
            }
            else
            {
                //si es null significa que no hay chofer asignado para la unidad.
                MessageBox.Show("No hay una chofer asignado", "Alerta!");
                TipoEjecucion = false; //no existe conductor
            }
            
        }

        private void cargar()
        {
            //creo un objeto nuevo de la clase negocio
            UsuarioBusiness negocio = new UsuarioBusiness();
            try
            {
                listaUsuarios = (List<clsUsuarios>)negocio.listar();
                dgvConductores.DataSource = listaUsuarios;
                //dgvUsuarios.AutoResizeColumns();
                dgvConductores.Columns[0].Visible = false;
                dgvConductores.Columns[3].Visible = false;
                dgvConductores.Columns[6].Visible = false;
                dgvConductores.Columns[7].Visible = false;
                dgvConductores.Columns[8].Visible = false;

                //limpiar el casillero de busqueda

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
         if(TipoEjecucion)
            {
                //si es true, hay conductor entonces:
                //construir el conductor con los datos actuales. Ya tiene todo salvo la fecha de baja.
                conductor.FechaBajaAsignacion = DateTime.Today;
                conductor.EstadoAsignacion = 2;
                //grabar la fecha de modificación y pasar a la baja el registro actual
                negocio.bajarConductor(conductor);
                //segundo:
                //cargar la info nueva en el conductor.
                conductor.ConductorAsignado = (clsUsuarios)dgvConductores.CurrentRow.DataBoundItem;
                conductor.EstadoAsignacion = 1;
                conductor.FechaAltaAsignacion = dtpFechaAsignacion.Value;
                //grabar el registro con la nueva info
                negocio.altaConductor(conductor);
                MessageBox.Show("Registro Grabado!", "Asignación de Conductor!");
                Close();
            }
         else
            {
                conductor = new ConductorPorVehiculo();
                //si es false, no hay conductor y es un alta nueva
                //grabar el registro con la nueva info
                //cargar la info nueva en el conductor.
                conductor.VehiculoAsignado = autoRecibido;
                conductor.ConductorAsignado = (clsUsuarios)dgvConductores.CurrentRow.DataBoundItem;
                conductor.EstadoAsignacion = 1;
                conductor.FechaAltaAsignacion = dtpFechaAsignacion.Value;
                //grabar el registro con la nueva info
                negocio.altaConductor(conductor);
                MessageBox.Show("Registro Grabado!", "Asignación de Conductor!");
                Close();

            }

        }
    }
}
