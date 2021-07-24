using Servicios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAL.Memory
{
    class DALPermiso : IGenericRepository<Permiso>
    {
        private List<Permiso> permisos = new List<Permiso>();

        private void LoadSample()
        {
            Permiso permisoA = new Permiso();
            permisoA.id = 1;
            permisoA.Name = "Permiso A";
            permisos.Add(permisoA);

            Permiso permisoB = new Permiso();
            permisoB.id = 2;
            permisoB.Name = "Permiso B";
            permisos.Add(permisoB);

            Permiso permisoC = new Permiso();
            permisoC.id = 3;
            permisoC.Name = "Permiso C";
            permisos.Add(permisoC);


            Permiso permisoD = new Permiso();
            permisoD.id = 4;
            permisoD.Name = "Permiso D";
            permisos.Add(permisoD);
        }

        public DALPermiso()
        {
            LoadSample();
        }
        public IEnumerable<Permiso> getAll()
        {
            return permisos;
        }

        public Permiso getOne(int id)
        {
            return permisos.First(permiso=> permiso.id == id);
        }

        public void Insert(Permiso obj)
        {
            permisos.Add(obj);
        }
    }
}
