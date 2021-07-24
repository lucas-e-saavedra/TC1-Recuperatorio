using Servicios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAL.Memory
{
    class DALUsuario : IGenericRepository<Usuario>
    {
        private List<Usuario> usuarios = new List<Usuario>();

        private DALRol dalRol = new DALRol();
        private void LoadSampleUsers() {
            Usuario usuario1 = new Usuario();
            usuario1.id = 1;
            usuario1.Name = "Gastón";
            usuario1.RolDelUsuario = dalRol.getOne(1);            
            usuarios.Add(usuario1);

            Usuario usuario2 = new Usuario();
            usuario2.id = 2;
            usuario2.Name = "Brian";
            usuario2.RolDelUsuario = dalRol.getOne(1);
            usuarios.Add(usuario2);

            Usuario usuario3 = new Usuario();
            usuario3.id = 3;
            usuario3.Name = "Lucas";
            usuario2.RolDelUsuario = dalRol.getOne(2);
            usuarios.Add(usuario3);

            Usuario usuario4 = new Usuario();
            usuario4.id = 4;
            usuario4.Name = "Emanuel";
            usuario2.RolDelUsuario = dalRol.getOne(3);
            usuarios.Add(usuario4);
        }

        public DALUsuario() {
            LoadSampleUsers();
        }

        public IEnumerable<Usuario> getAll()
        {
            return usuarios;
        }

        public Usuario getOne(int id)
        {
            return usuarios.First(user => user.id== id);
        }

        public void Insert(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
