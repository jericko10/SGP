using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gstDatos;
using System.Data;
using System.Collections;

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
        public int mtdGuardarRecibo(gstClsRecibo LobjRecibo, List<gstClsRecibo> LobjReciboDetalle)
        {
            return GobjRecibo.mtdGuardarRecibo(LobjRecibo, LobjReciboDetalle);
        }

        public string mtdObtenerUltimoCodigoRecibo()
        {
            return GobjRecibo.mtdObtenerUltimoCodigoRecibo();
        }

        public ArrayList mtdListarRecibos(int LintCodigoAlumno)
        {
            return GobjRecibo.mtdListarRecibos(LintCodigoAlumno);
        }

        public gstClsAlumno mtdObtenerAlumno(int LintCodigoAlumno)
        {
            return GobjRecibo.mtdObtenerAlumno(LintCodigoAlumno);
        }

        public DataTable mtdCargarReciboGenerado(string LstrCodigoReciboAlumno)
        {
            return GobjRecibo.mtdCargarReciboGenerado(LstrCodigoReciboAlumno);
        }

        public int mtdEliminarRecibo(int LintCodigoAlumno)
        {
            return GobjRecibo.mtdEliminarRecibo(LintCodigoAlumno);
        }

        public DataTable mtdFiltrarDeudaPago(string LstrParametro, int LintCodigoAlumno)
        {
            return GobjRecibo.mtdFiltrarDeudaPago(LstrParametro, LintCodigoAlumno);
        }
    }
}
