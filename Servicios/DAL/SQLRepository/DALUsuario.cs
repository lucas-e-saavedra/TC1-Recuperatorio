using Servicios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAL.SQLRepository
{
    class DALUsuario : IGenericRepository<Usuario>
    {
        public IEnumerable<Usuario> getAll()
        {
            throw new NotImplementedException();
        }

        public Usuario getOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
