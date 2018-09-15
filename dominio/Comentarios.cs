using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Comentarios
    {
        public int IdComentario { get; set; }
        public DateTime FechaCreacionComentario { get; set; }
        public clsUsuarios UsuarioCreador { get; set; }
        public string Comentario { get; set; }
        public IList<Adjuntos> Adjuntos { get; set; }
        public bool Activo { get; set; }
    }
}
