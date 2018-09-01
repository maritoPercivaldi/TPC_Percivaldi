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
        public frmAbmUsuarios()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
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
            //creo un objeto nuevo de la clase negocio
            UsuarioBusiness negocio = new UsuarioBusiness();
            try
            {
                dgvUsuarios.DataSource = negocio.listar();
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
        }
    }
}
