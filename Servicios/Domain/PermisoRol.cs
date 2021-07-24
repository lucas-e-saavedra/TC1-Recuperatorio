using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Domain
{
    public abstract class PermisoRol
    {
        public int id { get; set; }
        public String Name { get; set; }

        public abstract void AgregarHijo(PermisoRol hijo);
    }
}
