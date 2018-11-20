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
    public partial class frmLogin : frmModelo
    {
        private List<clsUsuarios> listaUsuarios;
        public UsuarioBusiness negocio;
        clsUsuarios userLoged = null;


        public frmLogin()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(600, 400);
            cambiarUbicacionLogo(280, 400);
            cargar();
        }

        private void cargar()
        {
            //creo un objeto nuevo de la clase negocio
            UsuarioBusiness negocio = new UsuarioBusiness();
            try
            {
                listaUsuarios = (List<clsUsuarios>)negocio.listar();
                cbUsuarios.DataSource = listaUsuarios;
                cbUsuarios.DataSource = negocio.listar();
                cbUsuarios.DisplayMember = "MAIL";
                cbUsuarios.ValueMember = "MAIL";
                cbUsuarios.SelectedIndex = -1;
          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogCXL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La Aplicacion se cerrara", "Salir!");
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogOk_Click(object sender, EventArgs e)
        {
            if(cbUsuarios.SelectedIndex != -1 || tbSecret.Text != "")
            {
                try
                {
                    userLoged = (clsUsuarios)cbUsuarios.SelectedItem;
                    if(userLoged.Secret == tbSecret.Text)
                    {
                        //logeado
                        MessageBox.Show("Contraseña Correcta", "Password Correcto para: " + userLoged.ToString());
                        frmMainMenu form = new frmMainMenu(userLoged);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta", "Error Password para usuario: " + userLoged.ToString());
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + " - " + ex.ToString(), "Error!");
                }

            }
            else
            {
                MessageBox.Show("Se requiere usuario y contraseña", "Error de ingreso");
            }
            
            
        }
    }
}
