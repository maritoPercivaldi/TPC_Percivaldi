using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using negocio;
using dominio;







namespace ksrPanel
{
    public partial class frmAbmUsuarios : ksrPanel.frmModelo
    {
        private List<clsUsuarios> listaUsuarios;
        public frmAbmUsuarios()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
            cambiarUbicacionLogo(904, 824);
        }


        //private void llenar()
        //{
        //    string select = "select * from USUARIOS";
        //    SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog=ksrPanel;Integrated Security=SSPI"); // Your Connection String here
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(select, c);
        //    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
        //    DataSet ds = new DataSet();
        //    dataAdapter.Fill(ds);
        //    dgvUsuarios.ReadOnly = true;
        //    dgvUsuarios.DataSource = ds.Tables[0];
        //    c.Close();
        //}

        private void frmAbmUsuarios_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            //creo un objeto nuevo de la clase negocio
            UsuarioBusiness negocio = new UsuarioBusiness();
            try
            {
                listaUsuarios = (List<clsUsuarios>)negocio.listar();
                dgvUsuarios.DataSource = listaUsuarios;
                //dgvUsuarios.AutoResizeColumns();
                dgvUsuarios.Columns[0].Visible = false;
                dgvUsuarios.Columns[3].Visible = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario frm = new frmAgregarUsuario();
            frm.ShowDialog();
            cargar();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            clsUsuarios modificado;
            try
            {
                //al objeto usuario lo instancio con los valores del usuario elegido
                modificado = (clsUsuarios)dgvUsuarios.CurrentRow.DataBoundItem;
                //instancio el formulario
                frmAgregarUsuario modificar = new frmAgregarUsuario(modificado);
                modificar.ShowDialog();
                cargar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "error!");
            }

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioBusiness negocio = new UsuarioBusiness();
            try
            {
                negocio.eliminarLogico((int)dgvUsuarios.CurrentRow.Cells[0].Value);
                MessageBox.Show("Usuario Eliminado Exitosamente", "Baja Logica");
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error al eliminar el usuario");
            }
        }

        private void tbBuscarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbBuscarUsuario.Text == "")
            {
                dgvUsuarios.DataSource = listaUsuarios;
            }
            else
            {
                List<clsUsuarios> lista;
                lista = listaUsuarios.FindAll(PEPE => PEPE.Apellido.Contains(tbBuscarUsuario.Text));
                dgvUsuarios.DataSource = lista;
            }
        }
    }
}
