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
                conexion.Comando.Parameters.AddWithValue("@KmRegistro", kmARegistrar.)
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
