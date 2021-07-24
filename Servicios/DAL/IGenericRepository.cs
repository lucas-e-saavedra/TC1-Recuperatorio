using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAL
{
    public interface IGenericRepository<T>
    {
        void Insert(T obj);
        T getOne(int id);
        IEnumerable<T> getAll();
    }
}
