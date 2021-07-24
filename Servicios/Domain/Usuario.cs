using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Domain
{
    public class Usuario
    {
        private PermisoRol rolDelUsuario;

        public int id { get; set; }
        public string Name { get; set; }
        private int idRol;
        public PermisoRol RolDelUsuario { get => rolDelUsuario; set => rolDelUsuario = value; }
    }
}
