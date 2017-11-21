using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gstDatos;
using System.Data;

namespace gstNegocio
{
    public class gstClsConceptoNegocio
    {
        gstClsConcepto GobjConcepto = new gstClsConcepto();

        public DataTable mtdCargarDatos()
        {
            return GobjConcepto.mtdCargarDatos();
        }

        public DataTable mtdBuscarConcepto(string LstrParametro)
        {
            return GobjConcepto.mtdBuscarConcepto(LstrParametro);
        }

        public int mtdGuardar(gstClsConcepto LobjModelo)
        {
            return GobjConcepto.mtdGuardar(LobjModelo);
        }

        public gstClsConcepto mtdObtenerConcepto(int LintCodigo)
        {
            return GobjConcepto.mtdObtenerConcepto(LintCodigo);
        }

        public int mtdModificar(gstClsConcepto LobjModelo)
        {
            return GobjConcepto.mtdModificar(LobjModelo);
        }

    }
}
