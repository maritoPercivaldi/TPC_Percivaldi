using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ConductorPorVehiculo
    {
        public int IdAsignacion { get; set; }
        public Vehiculos VehiculoAsignado { get; set; }
        public clsUsuarios ConductorAsignado { get; set; }
        public DateTime FechaAltaAsignacion { get; set; }
        public DateTime FechaBajaAsignacion { get; set; }
        public int EstadoAsignacion { get; set; }

        public ConductorPorVehiculo()
        {
            ConductorAsignado = new clsUsuarios();
            VehiculoAsignado = new Vehiculos();
        }

    }

   
}
