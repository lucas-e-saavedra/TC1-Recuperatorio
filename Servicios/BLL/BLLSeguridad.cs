using Servicios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{

    public sealed class BLLSeguridad
    {
        private readonly static BLLSeguridad _instance = new BLLSeguridad();

        public static BLLSeguridad Current
        {
            get
            {
                return _instance;
            }
        }

        private BLLSeguridad()
        {
            
        }

        public Usuario GetUsuario(int idUsuario) {
            return DAL.DALFactory.Current.GetDalUsuario().getOne(idUsuario);
        }
    }

}
