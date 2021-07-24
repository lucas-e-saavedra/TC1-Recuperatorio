using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Domain
{
    class Rol : PermisoRol
    {
        public List<PermisoRol> hijos { get; }

        public Rol() {
            this.hijos = new List<PermisoRol>();
        }
        public Rol(List<PermisoRol> hijos)
        {
            this.hijos = hijos;
        }
        public override void AgregarHijo(PermisoRol hijo)
        {
            this.hijos.Add(hijo);
        }

        public override string ToString()
        {
            string desc = $"El rol: {Name} contiene \n";
            foreach(PermisoRol unHijo in hijos) {
                desc = desc + unHijo.ToString();
            }
            return desc;
        }


    }
}
