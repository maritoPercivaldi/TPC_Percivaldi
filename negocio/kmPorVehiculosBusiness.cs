using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class kmPorVehiculosBusiness
    {
        public void AltaRegistro(KilometrosPorVehiculos kmARegistrar)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("INSERT INTO REGISTROKM (FechaRegistro,IdVehiculo,IdUsuarioReg,KmRegistro)" +
                    " Values (@FechaRegistro,@IdVehiculo,@IdUsuarioReg,@KmRegistro)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@FechaRegistro",kmARegistrar.FechaCarga.Date);
                conexion.Comando.Parameters.AddWithValue("@IdVehiculo", kmARegistrar.VehiculoKM.IdAuto);
                conexion.Comando.Parameters.AddWithValue("@IdUsuarioReg", kmARegistrar.UsuarioCarga.Id);
                conexion.Comando.Parameters.AddWithValue("@KmRegistro", kmARegistrar.Kilometros);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool VerificarConsistencia(KilometrosPorVehiculos kmARegistrar)
        {
            bool ValidaOk = false;
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("");

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            return ValidaOk;
        }

        public List<KilometrosPorVehiculos> listar()
        {
            AccesoDatos conexion = null;
            List<KilometrosPorVehiculos> lista = new List<KilometrosPorVehiculos>();
            KilometrosPorVehiculos aux;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select usu.APELLIDO,usu.NOMBRE,veh.Chapa,veh.Marca,veh.Modelo,regkm.KmRegistro,regkm.FechaRegistro from REGISTROKM as regkm inner join VEHICULOS as veh on regkm.IdVehiculo = veh.IdAuto inner join usuarios as usu on regkm.IdUsuarioReg = usu.ID");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while(conexion.Lector.Read())
                {
                    aux = new KilometrosPorVehiculos();
                    aux.UsuarioCarga.Apellido = conexion.Lector.GetString(0);
                    aux.UsuarioCarga.Nombre = conexion.Lector.GetString(1);
                    aux.VehiculoKM.Chapa = conexion.Lector.GetString(2);
                    aux.VehiculoKM.Marca = conexion.Lector.GetString(3);
                    aux.VehiculoKM.Modelo = conexion.Lector.GetString(4);
                    aux.Kilometros = conexion.Lector.GetInt32(5);
                    aux.FechaCarga = conexion.Lector.GetDateTime(6);
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
                if(conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }
    }
}
