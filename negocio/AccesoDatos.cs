using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace negocio
{
    public class AccesoDatos
    {
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }

        }

        public SqlCommand Comando
        {
            get { return comando; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog= PERCIVALDI_DB;Integrated Security=SSPI");
        }

        //metodo para configurar la consulta, que recibe por parametro un string con la consulta.
        public void setearConsulta (string consulta)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //metodo para configurar una consulta con SP. Recibe como parametro el string con el SP.

        public void SetearSP (string sp)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;
        }

        //metodo para abrir la conexipon

        public void abrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //metodo para cerrar la conexion
        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            try
            {
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ejecutarAccionReturn()
        {
            try
            {
                comando.Connection = conexion;
                return (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarConsulta()
        {
            try
            {
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
