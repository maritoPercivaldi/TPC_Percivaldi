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
        private clsUsuarios usuario = null;
        public frmAgregarUsuario()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 800);
            cambiarUbicacionLogo(680, 600);

        }

        public frmAgregarUsuario(clsUsuarios modificado)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 800);
            cambiarUbicacionLogo(680, 600);
            usuario = modificado;
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
                if (usuario == null)
                { 
                    cbSector.SelectedIndex = -1;
                }
                else
                {
                    tbApellido.Text = usuario.Apellido;
                    tbNombre.Text = usuario.Nombre;
                    tbPass.Text = usuario.Secret;
                    tbMail.Text = usuario.Mail;
                    //cbSector.SelectedIndex = usuario.DeptoId;
                    cbSector.SelectedIndex = (int)usuario.DeptoId-1;
                }
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

        private void btnAceptarAltaUsuario_Click(object sender, EventArgs e)
        {
            UsuarioBusiness usuarioNegocio = new UsuarioBusiness();
            try
            {
                if (usuario == null)
                {
                    usuario = new clsUsuarios();
                }
                //validamos si apellido y nombre contienen datos
                if (tbApellido.Text.Trim() == "" || tbNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Los campos Apellido y Nombre son obligatorios", "Campos Incompletos!");
                    return;
                }
                usuario.Apellido = tbApellido.Text;
                usuario.Nombre = tbNombre.Text;
                //valido si el password esta vacio
                if(tbPass.Text.Trim() == "")
                {
                    MessageBox.Show("La contraseña es necesaria", "Campos Incompletos!");
                    return;
                }
                usuario.Secret = tbPass.Text;
                //valido el mail
                if(tbMail.Text.Trim() == "")
                {
                    MessageBox.Show("El mail es obligatorio", "Campos Incompletos!");
                    return;
                }
                else
                {
                    ValidacionesLocas validar = new ValidacionesLocas();
                    try
                    {
                        if (validar.IsValidEmail(tbMail.Text))
                        {
                            //MessageBox.Show("El mail " + tbMail.Text + " es correcto!");
                            usuario.Mail = tbMail.Text;
                        }
                        else
                        {
                            MessageBox.Show("El valor ingresado no tiene formato de email valido","Error en el mail");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                //valido si eligio campo de departamento
                if(cbSector.SelectedIndex == -1)
                {
                    MessageBox.Show("No se ingreso un departamento valido", "Error de departamento");
                    return;
                }
                usuario.DeptoId = cbSector.SelectedIndex;
                if(usuario.Id != 0) //si es distinto de cero es porque trae un id cargado en el usuario
                {
                    usuarioNegocio.modificarUsuario(usuario);
                    MessageBox.Show("Usuario Modificado correctamente", "Modificacion Exitosa");

                }
                else
                {
                    //inserto el nuevo usuario en la base.
                    usuarioNegocio.altaUsuario(usuario);
                    //largo un cartel diciendo que estuvo ok.
                    MessageBox.Show("Usuario Agregado Correctamente.", "Alta Exitosa");
                }
                
                Close();
                //TODO: validar contra la base que el usuario no exista, validando el mail.

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarAltaUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
