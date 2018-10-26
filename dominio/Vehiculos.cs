using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Vehiculos
    {
        //id
        public int IdAuto { get; set; }
        //chapa
        public string Chapa { get; set; }
        //marca
        public string Marca { get; set; }
        //modelo
        public string Modelo { get; set; }
        //nro motor
        public string CodigoMotor { get; set; }
        //nro chasis
        public string CodigoChasis { get; set; }
        //fecha de alta
        public DateTime FechaAlta { get; set; }
        //fecha de baja
        public DateTime FechaBaja { get; set; }
        //conductor. A futuro puede ser una clase que herede de usuario y que agregue atributos como vigencia del registro ect.
        public clsUsuarios Conductor { get; set; }
        //estado si esta activo o no.
        public int Estado { get; set; }
        

        public override string ToString()
        {
            return Chapa + "-" + Marca;
        }

        public Vehiculos()
        {
            clsUsuarios conductor = new clsUsuarios();
            

        }

    }
}
