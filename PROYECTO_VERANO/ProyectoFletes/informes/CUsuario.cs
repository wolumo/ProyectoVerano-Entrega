using ProyectoFletes.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFletes.Controllers
{
    class CUsuario
    {
        public static DataTable Validar_Acesso (string user , string pass)
        {
            return new DUsuario().Validar_Acceso(user, pass);
        }
    }
}
