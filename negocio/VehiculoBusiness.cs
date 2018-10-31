﻿using System;
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

        public int traerConductor(string Chapa)
        {
            AccesoDatos conexion = null;
            int conductor;
            conductor = 0;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select IdConductor from VEHICULOS where Chapa = @Chapa");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Chapa", Chapa);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while(conexion.Lector.Read())
                {
                    conductor = conexion.Lector.GetInt32(0);
                }
                return conductor;
                
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

        public void altaVehiculo(Vehiculos vehiculo)
        {
            //instancion la conexion y la nuleo.
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                //consulta
                conexion.setearConsulta("insert into VEHICULOS (Chapa,Marca,Modelo,CodigoMotor,CodigoChasis,FechaAlta,IdConductor,Estado) values " +
                    "(@Chapa,@Marca,@Modelo,@CodigoMotor,@CodigoChasis,@FechaAlta,@IdConductor,@Estado)");
                //limpio los parametros
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Chapa", vehiculo.Chapa);
                conexion.Comando.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                conexion.Comando.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                conexion.Comando.Parameters.AddWithValue("@CodigoMotor", vehiculo.CodigoMotor);
                conexion.Comando.Parameters.AddWithValue("@CodigoChasis", vehiculo.CodigoChasis);
                conexion.Comando.Parameters.AddWithValue("@FechaAlta", vehiculo.FechaAlta);
                conexion.Comando.Parameters.AddWithValue("@IdConductor", vehiculo.Conductor.Id);
                conexion.Comando.Parameters.AddWithValue("@Estado", 1);
                //abro la conexion
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

        public void modificacarVehiculo(Vehiculos vehiculo)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("Update vehiculos set Chapa = @Chapa, Marca = @Marca, Modelo = @Modelo, CodigoMotor = @CodigoMotor, CodigoChasis = @CodigoChasis," +
                    "FechaAlta = @FechaAlta, IdConductor = @IdConductor where IdAuto = @IdAuto");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Chapa", vehiculo.Chapa);
                conexion.Comando.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                conexion.Comando.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                conexion.Comando.Parameters.AddWithValue("@CodigoMotor", vehiculo.CodigoMotor);
                conexion.Comando.Parameters.AddWithValue("@CodigoChasis", vehiculo.CodigoChasis);
                conexion.Comando.Parameters.AddWithValue("@FechaAlta", vehiculo.FechaAlta);
                conexion.Comando.Parameters.AddWithValue("@IdConductor", vehiculo.Conductor.Id);
                conexion.Comando.Parameters.AddWithValue("@IdAuto", vehiculo.IdAuto);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
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
