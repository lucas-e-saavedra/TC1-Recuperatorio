using Servicios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAL.Memory
{
    class DALRol : IGenericRepository<Rol>
    {
        private List<Rol> roles = new List<Rol>();

        private void LoadSample()
        {
            DALPermiso dalPermisos = new DALPermiso();
            Rol rolSupervisor = new Rol();
            rolSupervisor.id = 2;
            rolSupervisor.Name = "Supervisor";
            rolSupervisor.AgregarHijo(dalPermisos.getOne(1));
            rolSupervisor.AgregarHijo(dalPermisos.getOne(2));
            rolSupervisor.AgregarHijo(dalPermisos.getOne(3));
            roles.Add(rolSupervisor);

            Rol rolRepartidor = new Rol();
            rolRepartidor.id = 3;
            rolRepartidor.Name = "Repartidor";
            rolRepartidor.AgregarHijo(dalPermisos.getOne(4));
            roles.Add(rolRepartidor);


            Rol rolAdmin = new Rol();
            rolAdmin.id = 1; 
            rolAdmin.Name = "Admin";
            rolAdmin.AgregarHijo(rolSupervisor);
            rolAdmin.AgregarHijo(rolRepartidor);
            roles.Add(rolAdmin);

        }

        public DALRol()
        {
            LoadSample();
        }

        public IEnumerable<Rol> getAll()
        {
            return roles;
        }

        public Rol getOne(int id)
        {
            return roles.First(rol => rol.id == id);
        }

        public void Insert(Rol obj)
        {
            roles.Add(obj);
        }
    }
}