using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace negocio
{
    public class MantPorVehiculoBusiness
    {
        public List<MantePorVehiculos> listar()
        {
            AccesoDatos conexion = null;
            List<MantePorVehiculos> lista = new List<MantePorVehiculos>();
            MantePorVehiculos aux;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select mant.FechaCarga,veh.Chapa,veh.Marca,veh.Modelo,mant.Tipo,mant.Categoria, mant.Descripcion,mant.Importe from MANTEXVEHICULO as mant inner join VEHICULOS as veh on mant.IdAuto = veh.IdAuto");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while(conexion.Lector.Read())
                {
                    aux = new MantePorVehiculos();
                    aux.FechaCarga = conexion.Lector.GetDateTime(0);
                    aux.AutoAsociado.Chapa = conexion.Lector.GetString(1);
                    aux.AutoAsociado.Marca = conexion.Lector.GetString(2);
                    aux.AutoAsociado.Modelo = conexion.Lector.GetString(3);
                    aux.Tipo = conexion.Lector.GetString(4);
                    aux.Categoria = conexion.Lector.GetString(5);
                    aux.Descripcion = conexion.Lector.GetString(6);
                    aux.Importe = conexion.Lector.GetDecimal(7);
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

        public void NuevoMantenimiento(MantePorVehiculos manteCargado)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert into MANTEXVEHICULO (Tipo,Categoria,Descripcion,Importe,IdAuto,FechaCarga) values (@Tipo,@Categoria,@Descripcion,@Importe,@IdAuto,@FechaCarga)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Tipo", manteCargado.Tipo);
                conexion.Comando.Parameters.AddWithValue("@Categoria", manteCargado.Categoria);
                conexion.Comando.Parameters.AddWithValue("@Descripcion", manteCargado.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@Importe", manteCargado.Importe);
                conexion.Comando.Parameters.AddWithValue("@IdAuto", manteCargado.AutoAsociado.IdAuto);
                conexion.Comando.Parameters.AddWithValue("@FechaCarga", manteCargado.FechaCarga.Date);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
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
