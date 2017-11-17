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

        public DataTable mtdListarDeudaExtraordinaria(int LintCodigoAlumno)
        {
            return GobjRecibo.mtdListarDeudaExtraordinaria(LintCodigoAlumno);
        }
        public DataTable mtdListarDeudaMensualidad(int LintCodigoAlumno)
        {
            return GobjRecibo.mtdListarDeudaMensualidad(LintCodigoAlumno);
        }
        public DataTable mtdListarDeudaPagada(int LintCodigoAlumno)
        {
            return GobjRecibo.mtdListarDeudaPagada(LintCodigoAlumno);
        }
    }
}
