using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    class clsUsuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Secret { get; set; }
        public int DeptoId { get; set; }
        public string Mail { get; set; }

        public clsUsuarios(int Id,string Nombre, string Apellido,string Secret, int DeptoId, string Mail)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Secret = Secret;
            this.DeptoId = DeptoId;
            this.Mail = Mail;
        }
    }
}
