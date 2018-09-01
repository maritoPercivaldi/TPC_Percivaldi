using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;


namespace negocio
{
    public class UsuarioBusiness
    {
        public void listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            clsUsuarios usuarios = new IList<usuarios>();


            conexion.ConnectionString = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog= ksrPanel ;Integrated Security=SSPI";
            comando.CommandType = System.Data.CommandType.Text;
            comando = "Select * from USUARIOS";
            conexion.Open();
            while(lector.Read())
            {

            }
            



        }
    }
}
