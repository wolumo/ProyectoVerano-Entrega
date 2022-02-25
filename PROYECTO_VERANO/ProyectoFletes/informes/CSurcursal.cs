using ProyectoFletes.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFletes.Controllers
{
    class CSurcursal
    {
        public static DataTable InsertarSucursal()
        {
            return new DSucursal().InsertarSucursal(); 
        }
    }
}
