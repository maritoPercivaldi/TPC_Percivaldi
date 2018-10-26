using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace negocio
{
    public class VehiculoBusiness
    {
        public List<Vehiculos> listar()
        {
            AccesoDatos conexion = null;
            List<Vehiculos> lista = new List<Vehiculos>();
            Vehiculos aux;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select veh.Chapa, veh.Marca,veh.Modelo,veh.FechaAlta,veh.estado,veh.CodigoMotor,veh.CodigoChasis from VEHICULOS as VEH where estado = 1");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while(conexion.Lector.Read())
                {
                    aux = new Vehiculos();
                    aux.Chapa = conexion.Lector.GetString(0);
                    aux.Marca = conexion.Lector.GetString(1);
                    aux.Modelo = conexion.Lector.GetString(2);
                    aux.FechaAlta = conexion.Lector.GetDateTime(3);
                    aux.Estado = conexion.Lector.GetInt32(4);
                    aux.CodigoMotor = conexion.Lector.GetString(5);
                    aux.CodigoChasis = conexion.Lector.GetString(6);
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
