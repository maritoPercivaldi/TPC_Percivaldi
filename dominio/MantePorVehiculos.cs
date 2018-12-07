using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class MantePorVehiculos
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public Vehiculos AutoAsociado { get; set; }
        public DateTime FechaCarga { get; set; }

        public MantePorVehiculos()
        {
            AutoAsociado = new Vehiculos();
        }
    }
}
