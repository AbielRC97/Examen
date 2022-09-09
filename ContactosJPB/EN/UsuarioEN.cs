using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class UsuarioEN
    {
        public int IdUsuario { get; set; }
        public string Nombre {get; set;}
        public DateTime FechaRegistro { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public bool Estatus { get; set; }
    }
}
