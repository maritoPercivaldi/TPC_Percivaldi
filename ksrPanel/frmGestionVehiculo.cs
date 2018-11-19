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
        
        //private UsuarioBusiness negocioU = null;
        //private VehiculoBusiness negocioV = null;
                
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
        }

        //en el evento load de la gestion de vehiculos. Labura independiente si es ALTA o MODIFICACION
        private void frmGestionVehiculo_Load(object sender, EventArgs e)
        {
            //instancio la clase negocio
            //MessageBox.Show(vehiculo.Chapa);
            //MessageBox.Show(vehiculo.Conductor.Nombre);
            //VehiculoBusiness negocioVehiculo = new VehiculoBusiness();
            try
            {
             
             if (vehiculo != null)//si es distinto a null es porque estamos modificando.
             {
                    //el textbox del dominio no se puede cambiar. para cambiar una patente hay que boletear el auto.
                    tbDominio.Enabled = false;
                    btnOKModificar.Text = "Modificar";
                    tbDominio.Text = vehiculo.Chapa;
                    tbMarca.Text = vehiculo.Marca;
                    tbModelo.Text = vehiculo.Modelo;
                    tbCodMotor.Text = vehiculo.CodigoMotor;
                    tbCodChasis.Text = vehiculo.CodigoChasis;
                    dtpFechaAlta.Value = vehiculo.FechaAlta.Date;
             }
             else
                {
                    MessageBox.Show("vehiculo nuevito!");
                }
             
            }
            catch (Exception ex)
            {

                    MessageBox.Show(ex.Message + " - " + ex.ToString());
            }

        }

        private void btnCXLModificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOKModificar_Click(object sender, EventArgs e)
        {
            VehiculoBusiness vehiculoNegocio = new VehiculoBusiness();
            try
            {
                if(vehiculo != null)//vehiculo a modificar.
                {
                    vehiculo.Chapa = tbDominio.Text;
                    vehiculo.Marca = tbMarca.Text;
                    vehiculo.Modelo = tbModelo.Text;
                    vehiculo.CodigoMotor = tbCodMotor.Text;
                    vehiculo.CodigoChasis = tbCodChasis.Text;
                    vehiculo.FechaAlta = dtpFechaAlta.Value;
                    vehiculoNegocio.modificacarVehiculo(vehiculo);
                    MessageBox.Show("Modificación Exitosa", "Gestión Vehículos");
                    Close();
                    return;
                }
                else
                {
                    vehiculo = new Vehiculos();
                    vehiculo.Chapa = tbDominio.Text;
                    vehiculo.Marca = tbMarca.Text;
                    vehiculo.Modelo = tbModelo.Text;
                    vehiculo.CodigoMotor = tbCodMotor.Text;
                    vehiculo.CodigoChasis = tbCodChasis.Text;
                    vehiculo.FechaAlta = dtpFechaAlta.Value;
                }

                //revisamos si el dominio del vehiculo a ingresar nuevo no esta repetido en la base
                int prueba = vehiculoNegocio.VehiculoExistente(vehiculo.Chapa);
                if(prueba == 0)
                {//vehiculo nuevo por el lado del true
                    vehiculoNegocio.altaVehiculo(vehiculo);
                    MessageBox.Show("Alta Exitosa", "Gestión Vehículos");
                    Close();

                }
                else
                {//vehiculo existente
                    MessageBox.Show("Vehiculo Existente!", "Alerta!");
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
