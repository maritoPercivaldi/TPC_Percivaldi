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
                conexion.ConnectionString = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog= PERCIVALDI_DB ;Integrated Security=SSPI";
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

        public void altaUsuario(clsUsuarios nuevo)
        {
            //instancio un objeto de la clase acceso a datos y lo nuleo
            AccesoDatos conexion = null;
            try
            {
                //le asigno con el constructor el string de conexion;
                conexion = new AccesoDatos();
                //le asigno la consulta con el metodo setearConsulta
                conexion.setearConsulta("insert into USUARIOS (NOMBRE,APELLIDO,ACCESS,DEPID,MAIL) values (@Nombre,@Apellido,@Access,@DepId,@Mail)");
                //conexion.setearConsulta("insert into USUARIOS (NOMBRE,APELLIDO,ACCESS,DEPID,MAIL) values ('" + nuevo.Nombre +"','"+nuevo.Apellido+"','"+nuevo.Secret+"',"+nuevo.DeptoId+",'"+nuevo.Mail+"')");
                //blanqueo los datos existentes en las variables de las consultas.
                conexion.Comando.Parameters.Clear();
                //aca cargo los parametros con las variables
                conexion.Comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@Apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@Access", nuevo.Secret);
                conexion.Comando.Parameters.AddWithValue("@DepId", nuevo.DeptoId+1);
                conexion.Comando.Parameters.AddWithValue("@Mail", nuevo.Mail);

                //abrir la conexion y ejecutar
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }
    }

   
}
