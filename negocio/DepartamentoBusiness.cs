using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace negocio
{
    public class DepartamentoBusiness
    {
        public IList<Departamentos> listar()
        {
            //conexion
            SqlConnection conexion = new SqlConnection();
            //comando
            SqlCommand comando = new SqlCommand();
            //objeto receptor
            SqlDataReader lector;
            //lista que recibe los datos existentes en la tabla.
            IList<Departamentos> lista = new List<Departamentos>();
            try
            {
                conexion.ConnectionString = @"Data Source=DESKTOP-5UAJG1S\SQLEXPRESS;Initial Catalog= ksrPanel ;Integrated Security=SSPI";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from DEPARTAMENTOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while(lector.Read())
                {
                    Departamentos aux = new Departamentos();
                    aux.IdDepto = lector.GetInt32(0);
                    aux.NombreDepto = lector.GetString(1);
                    lista.Add(aux);
                }
                return lista;

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
