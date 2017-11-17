using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gstDatos
{
    public class gstClsRecibo
    {
        gstClsConexion LobjConexion = new gstClsConexion();
        public DataTable mtdBuscarAlumno(string LstrParametro)
        {
            LobjConexion.Conectar().Open();
            string LstrComando = "select ALMcodigo as CÓDIGO, ALMapellido as APELLIDO, ALMnombre as NOMBRE from gstALMpAlumno where ALMapellido like ('" + LstrParametro + "%') OR ALMdni like ('" + LstrParametro + "%') AND ALMestado = 'Matriculado'";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public DataTable mtdListarDeudaExtraordinaria(int LintCodigoAlumno)
        {
            LobjConexion.Conectar().Open();
            string LstrComando = "select YEAR(gstCUOtCuota.CUOano) as AÑO, gstDEUtDeuda.DEUdescripcion as DESCRIPCIÓN, gstDEUtDeuda.DEUmonto as MONTO from gstDEUtDeuda inner join gstCUOtCuota on gstDEUtDeuda.CUOcodigo = gstCUOtCuota.CUOcodigo inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstDEUtDeuda.ALMcodigo = " + LintCodigoAlumno + " AND (gstCONpConcepto.CONtipo = 'APAFA' OR gstCONpConcepto.CONtipo = 'Cuota Extraordinaria')";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public DataTable mtdListarDeudaMensualidad(int LintCodigoAlumno)
        {
            LobjConexion.Conectar().Open();
            string LstrComando = "select YEAR(gstCUOtCuota.CUOano) as AÑO, gstDEUtDeuda.DEUdescripcion as DESCRIPCIÓN, gstDEUtDeuda.DEUmonto as MONTO from gstDEUtDeuda inner join gstCUOtCuota on gstDEUtDeuda.CUOcodigo = gstCUOtCuota.CUOcodigo inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstDEUtDeuda.ALMcodigo = " + LintCodigoAlumno + " AND (gstCONpConcepto.CONtipo = 'Mensualidad')";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjDataTable.Columns.Add(new DataColumn("SELECCIONAR", typeof(bool)));
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public DataTable mtdListarDeudaPagada(int LintCodigoAlumno)
        {
            LobjConexion.Conectar().Open();
            string LstrComando = "select YEAR(gstCUOtCuota.CUOano) as AÑO, gstDEUtDeuda.DEUdescripcion as DESCRIPCIÓN, gstDEUtDeuda.DEUmonto as MONTO from gstDEUtDeuda inner join gstCUOtCuota on gstDEUtDeuda.CUOcodigo = gstCUOtCuota.CUOcodigo inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstDEUtDeuda.ALMcodigo = " + LintCodigoAlumno + " AND (gstCONpConcepto.CONtipo = 'APAFA' OR gstCONpConcepto.CONtipo = 'Cuota Extraordinaria')";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjDataTable.Columns.Add(new DataColumn("SELECCIONAR", typeof(bool)));
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }
    }
}
