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
    public partial class frmAgregarUsuario : ksrPanel.frmModelo
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 800);

        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            //nuevo objeto de la clase negocio 
            DepartamentoBusiness negocio = new DepartamentoBusiness();
            try
            {
                cbSector.DataSource = negocio.listar();
                cbSector.DisplayMember = "NOMBREDEPTO";
                cbSector.ValueMember = "NOMBREDEPTO";
                cbSector.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProbarMail_Click(object sender, EventArgs e)
        {
            ValidacionesLocas validar = new ValidacionesLocas();
            try
            {
                if(validar.IsValidEmail(tbMail.Text))
                {
                    MessageBox.Show("El mail " + tbMail.Text + " es correcto!");
                }
                else
                {
                    MessageBox.Show("No es un mail");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
