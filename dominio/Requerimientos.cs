using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Requerimientos
    {
        public int IdRequerimiento { get; set; }
        public string NombreRequerimiento { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public clsUsuarios UsuarioCreador { get; set; }
        public IList<Comentarios> ComentariosAsociados { get; set; }
    }
}
