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
            clsBaseBusiness datos = new clsBaseBusiness();
            string select = "select * from USUARIOS";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select,datos.CadenaConexion);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.DataSource = ds.Tables[0];
            




        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            //string connetionString = null;
            //SqlConnection cnn;
            //connetionString = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog=ksrPanel;Integrated Security=SSPI";
            //cnn = new SqlConnection(connetionString);
            //try
            //{
            //    cnn.Open();
            //    MessageBox.Show("Connection Open ! ");
            //    cnn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Can not open connection ! " + ex.Message.ToString());
            //}
            llenar();
            frmAbmUsuarios.ActiveForm.Refresh();

        }

        private void llenar()
        {
            string select = "select * from USUARIOS";
            SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog=ksrPanel;Integrated Security=SSPI"); // Your Connection String here
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, c);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.DataSource = ds.Tables[0];
            c.Close();
        }

       
    }
}
