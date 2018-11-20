using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class KilometrosPorVehiculos
    {
        public int IdCarga { get; set; }
        public Vehiculos VehiculoKM { get; set; }
        public clsUsuarios UsuarioCarga { get; set; }
        public DateTime FechaCarga { get; set; }
        public int Kilometros { get; set; }

        public KilometrosPorVehiculos()
        {
            VehiculoKM = new Vehiculos();
            UsuarioCarga = new clsUsuarios();
        }
    }
}
