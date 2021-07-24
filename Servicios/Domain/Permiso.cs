using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Domain
{
    class Permiso : PermisoRol
    {
        public override void AgregarHijo(PermisoRol hijo)
        {
            throw new Exception("No se pueden agregar hijos a un permiso");
        }

        public override string ToString()
        {
            return $"Permiso: {Name}\n";
        }
    }
}
