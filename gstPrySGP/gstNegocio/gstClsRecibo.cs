using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gstDatos;

namespace gstNegocio
{
    public class gstClsRecibo
    {
        gstClsRecibo GobjRecibo = new gstClsRecibo();
        public List<gstClsAlumno> mtdBuscarAlumno(string LstrParametro)
        {
            List<gstClsAlumno> LobjAlumno = new List<gstClsAlumno>();
            LobjAlumno = GobjRecibo.mtdBuscarAlumno(LstrParametro);
            return LobjAlumno;
        }
    }
}
