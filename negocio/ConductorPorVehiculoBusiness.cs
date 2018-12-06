using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace negocio
{
    public class ConductorPorVehiculoBusiness
    {
        public List<ConductorPorVehiculo> listar()
        {
            AccesoDatos conexion = null;
            List<ConductorPorVehiculo> lista = new List<ConductorPorVehiculo>();
            ConductorPorVehiculo aux;
            UsuarioBusiness negocioUsuario;
            VehiculoBusiness negocioVehiculo;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select CON.ID, VEH.Chapa, USU.APELLIDO, USU.NOMBRE, CON.FECHAREGIN, USU.ID from CONDUCTORXVEHICULO AS CON" +
                    "INNER JOIN VEHICULOS AS VEH" +
                    "ON CON.IDVEHICULO = VEH.IdAuto" +
                    "INNER JOIN USUARIOS AS USU" +
                    "ON CON.IDUSUARIO = USU.ID" +
                    "WHERE CON.ESTADO = 1");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while(conexion.Lector.Read())
                {
                    aux = new ConductorPorVehiculo();
                    negocioUsuario = new UsuarioBusiness();
                    negocioVehiculo = new VehiculoBusiness();
                    aux.IdAsignacion = conexion.Lector.GetInt32(0);
                    aux.ConductorAsignado = negocioUsuario.cargarData(conexion.Lector.GetInt32(5));
                    aux.VehiculoAsignado = negocioVehiculo.cargarData(conexion.Lector.GetString(1));
                    aux.FechaAltaAsignacion = conexion.Lector.GetDateTime(4);
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
                if(conexion !=null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public ConductorPorVehiculo cargarData(string Chapa)
        {
            AccesoDatos conexion = null;
            ConductorPorVehiculo aux = null;
            UsuarioBusiness negocioUsuario = null;
            VehiculoBusiness negocioVehiculo = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select CON.ID, CON.IDUSUARIO, CON.FECHAREGIN, CON.FECHAREGOUT, VEH.Chapa FROM CONDUCTORXVEHICULO AS CON " +
                    "INNER JOIN VEHICULOS AS VEH ON CON.IDVEHICULO = VEH.IdAuto WHERE VEH.Chapa like @Chapa");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Chapa", Chapa);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while (conexion.Lector.Read())
                {
                    aux = new ConductorPorVehiculo();
                    negocioUsuario = new UsuarioBusiness();
                    negocioVehiculo = new VehiculoBusiness();
                    aux.IdAsignacion = conexion.Lector.GetInt32(0);
                    aux.VehiculoAsignado = negocioVehiculo.cargarData(conexion.Lector.GetString(4));
                    aux.ConductorAsignado = negocioUsuario.cargarData(conexion.Lector.GetInt32(1));
                    aux.FechaAltaAsignacion = conexion.Lector.GetDateTime(2);
                    //aux.FechaBajaAsignacion = conexion.Lector.GetDateTime(3);
                }
                return aux;


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
