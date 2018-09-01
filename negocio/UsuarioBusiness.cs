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
            IList<clsUsuarios> usuariosLista = new List<clsUsuarios>();
            try
            {
                conexion.ConnectionString = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog= ksrPanel ;Integrated Security=SSPI";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select * from USUARIOS";
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    clsUsuarios usuario = new clsUsuarios();
                    usuario.Nombre = lector.GetString(1);
                    usuario.Apellido = lector.GetString(2);
                    usuario.Mail = lector.GetString(5);
                    usuariosLista.Add(usuario);
                    usuario = null;
                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            
            



        }
    }
}
