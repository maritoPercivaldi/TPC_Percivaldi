using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace negocio
{
    public partial class clsBaseBusiness
    {

        public string BaseDeDatos { get; set; }
        public SqlConnection conn { get; set; }
        public SqlCommand comm { get; set; }
        public string CadenaConexion { get; set; }

        public clsBaseBusiness()
        {
            BaseDeDatos = "ksrPanel";
            CadenaConexion = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog=" + BaseDeDatos + ";Integrated Security=SSPI";
        }





        public void Conectar()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog=ksrPanel;Integrated Security=SSPI";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
               
            }
        }

        //{
        //    string connetionString = null;
        //SqlConnection cnn;
        //connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"
        //    cnn = new SqlConnection(connetionString);
        //    try
        //    {
        //        cnn.Open();
        //        MessageBox.Show("Connection Open ! ");
        //        cnn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Can not open connection ! ");
        //    }
        //}
    }
}
