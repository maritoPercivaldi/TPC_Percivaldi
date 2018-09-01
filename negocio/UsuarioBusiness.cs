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
        public IList<clsUsuarios> listar()
        {
            //conexion
            SqlConnection conexion = new SqlConnection();
            //sentencia
            SqlCommand comando = new SqlCommand();
            //objeto receptor
            SqlDataReader lector;
            IList<clsUsuarios> usuariosLista = new List<clsUsuarios>();
            try
            {
                conexion.ConnectionString = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog= ksrPanel ;Integrated Security=SSPI";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select * from USUARIOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    clsUsuarios aux = new clsUsuarios();
                    aux.Nombre = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.Mail = lector.GetString(5);
                    usuariosLista.Add(aux);
                    
                }
                return usuariosLista;
               
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
