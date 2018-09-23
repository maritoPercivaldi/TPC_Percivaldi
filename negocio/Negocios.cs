using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class Negocios
    {
        public SqlConnection conexion { get; set; }
        public SqlCommand comando { get; set; }
        public SqlDataReader lector { get; set; }
        public string consulta { get; set; }

        public Negocios(string servidor, string db, string consulta, int tipo)
        {
            try
            {
                conexion.ConnectionString = @"Data Source=" + servidor + ";Initial Catalog=" + db + ";Integrated Security=SSPI";
                switch (tipo)
                {
                    case 1:
                        //caso 1 es tipo texto.
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.CommandText = consulta;
                        break;
                    case 2:
                        //caso 2 es tipo procedimiento almacenado.
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.CommandText = consulta;
                        break;
                }
                comando.Connection = conexion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<clsUsuarios> negocioUsuario(Negocios negocio)
        {
            IList<clsUsuarios> usuariosLista = new List<clsUsuarios>();
            try
            {

                negocio.lector = negocio.comando.ExecuteReader();
                while(negocio.lector.Read())
                {
                    clsUsuarios aux = new clsUsuarios();
                    aux.Nombre = negocio.lector.GetString(1);
                    aux.Apellido = negocio.lector.GetString(2);
                    aux.Mail = negocio.lector.GetString(5);
                }
                return usuariosLista;
            }
            
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
