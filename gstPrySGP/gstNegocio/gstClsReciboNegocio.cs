using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gstDatos;
using System.Data;

namespace gstNegocio
{
    public class gstClsReciboNegocio
    {
        gstClsRecibo GobjRecibo = new gstClsRecibo();
        public DataTable mtdBuscarAlumno(string LstrParametro)
        {
            return GobjRecibo.mtdBuscarAlumno(LstrParametro);
        }
    }
}
