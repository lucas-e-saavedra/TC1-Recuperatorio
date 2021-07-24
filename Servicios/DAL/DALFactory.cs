using Servicios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAL
{

    public sealed class DALFactory
    {
        private readonly static DALFactory _instance = new DALFactory();

        public static DALFactory Current
        {
            get
            {
                return _instance;
            }
        }

        private DAL.IGenericRepository<Usuario> dalUsuario;

        private DALFactory()
        {
            dalUsuario = new DAL.Memory.DALUsuario();
        }

        public IGenericRepository<Usuario> GetDalUsuario() {
            return dalUsuario;
        }
    }

}
