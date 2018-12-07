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

        public void bajarConductor(ConductorPorVehiculo conductor)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update CONDUCTORXVEHICULO set FECHAREGOUT = @dateout, ESTADO = @estado  where IDVEHICULO = @IDAUTO and IDUSUARIO = @IDUSER");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@dateout", conductor.FechaBajaAsignacion);
                conexion.Comando.Parameters.AddWithValue("@IDAUTO", conductor.VehiculoAsignado.IdAuto);
                conexion.Comando.Parameters.AddWithValue("@IDUSER", conductor.ConductorAsignado.Id);
                conexion.Comando.Parameters.AddWithValue("@estado", conductor.EstadoAsignacion);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if(conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
            
        }

        public void altaConductor(ConductorPorVehiculo conductor)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("INSERT INTO CONDUCTORXVEHICULO (IDVEHICULO,IDUSUARIO,FECHAREGIN,ESTADO) VALUES (@IdVehiculo,@IdUsuario,@FechaIn,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@FechaIn", conductor.FechaAltaAsignacion.Date);
                conexion.Comando.Parameters.AddWithValue("@IdVehiculo", conductor.VehiculoAsignado.IdAuto);
                conexion.Comando.Parameters.AddWithValue("@IdUsuario", conductor.ConductorAsignado.Id);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
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
