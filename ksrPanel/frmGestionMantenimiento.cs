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
    public partial class frmGestionMantenimiento : frmModelo
    {
        Vehiculos autoRecibido = null;
        
        public frmGestionMantenimiento()
        {
            InitializeComponent();
            InitializeComponent();
            this.Size = new System.Drawing.Size(600, 400);
            cambiarUbicacionLogo(280, 400);
        }

        public frmGestionMantenimiento(Vehiculos VehiculoModificado)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(600, 400);
            cambiarUbicacionLogo(280, 400);
            autoRecibido = VehiculoModificado;
            lblUnidadAsingada.Text = autoRecibido.Chapa.ToString() + " - " + autoRecibido.Marca.ToString() + " - " + autoRecibido.Modelo.ToString();

        }

        public bool Validar()
        {
            int acumulado = 0;
            bool va;
            if(cbTipoMante.SelectedIndex != 0)
            {
                acumulado ++;
            }
            if(cbCatMante.SelectedIndex !=0)
            {
                acumulado ++;
            }
            if(tbDescMante.Text != "")
            {
                acumulado ++;
            }
            if (tbImporteMante.Text != "" )
            {
                acumulado ++;
            }
            if (acumulado == 4)
            {
                va = true;
            }
            else
            {
                va = false;
            }
            return va;
        }

        private void btnOkMante_Click(object sender, EventArgs e)
        {
            MantePorVehiculos autoACargarMante = null;
            MantPorVehiculoBusiness negocio = new MantPorVehiculoBusiness();
            if (Validar())
            {
                try
                {
                    autoACargarMante = new MantePorVehiculos();
                    autoACargarMante.AutoAsociado = (Vehiculos)autoRecibido;
                    autoACargarMante.Tipo = cbTipoMante.SelectedItem.ToString();
                    autoACargarMante.Categoria = cbCatMante.SelectedItem.ToString();
                    autoACargarMante.Descripcion = tbDescMante.Text;
                    autoACargarMante.Importe = Convert.ToDecimal(tbImporteMante.Text);
                    autoACargarMante.FechaCarga = dateTimePicker1.Value.Date;
                    negocio.NuevoMantenimiento(autoACargarMante);
                    MessageBox.Show("Alta Exitosa!", "Success!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error!");
                }
                
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos Incompletos");
            }
        }

        private void btnCxlMante_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
