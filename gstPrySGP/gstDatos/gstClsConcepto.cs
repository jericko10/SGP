using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gstDatos
{
    public class gstClsConcepto
    {
        public int CONcodigo { get; set; }
        public string CONdescripcion { get; set; }
        public string CONmonto { get; set; }
        public string CONtipo { get; set; }

        gstClsConexion LobjConexion = new gstClsConexion();
        SqlCommand LobjComando;
        SqlConnection LobjConnection = new SqlConnection();

        public DataTable mtdCargarDatos()
        {
            string LstrComando = "select CONcodigo as CÓDIGO, CONdescripcion as DESCRIPCIÓN, CONmonto as MONTO, CONtipo as TIPO from gstCONpConcepto";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public DataTable mtdBuscarConcepto(string LstrParametro)
        {
            string LstrComando = "select CONcodigo as CÓDIGO, CONdescripcion as DESCRIPCIÓN, CONmonto as MONTO, CONtipo as TIPO from gstCONpConcepto where CONdescripcion like ('" + LstrParametro + "%')";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public int mtdGuardar(gstClsConcepto LobjConcepto)
        {
            int LintRespuesta = 0;

            string LstrComando = "insert into gstCONpConcepto values('" + LobjConcepto.CONdescripcion + "', " + LobjConcepto.CONmonto + ", '" + LobjConcepto.CONtipo + "')";

            LobjComando = new SqlCommand(LstrComando, LobjConexion.Conectar());

            LintRespuesta = LobjComando.ExecuteNonQuery();

            LobjConexion.Conectar().Close();
            return LintRespuesta;
        }

        public gstClsConcepto mtdObtenerConcepto(int LintCodigo)
        {
            gstClsConcepto LobjConcepto = new gstClsConcepto();

            string LstrComando = "select CONcodigo as CÓDIGO, CONdescripcion as DESCRIPCIÓN, CONmonto as MONTO, CONtipo as TIPO from gstCONpConcepto where CONcodigo = " + LintCodigo;

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);

            foreach(DataRow LobjRegistro in LobjDataTable.Rows)
            {
                LobjConcepto.CONcodigo = Convert.ToInt32(LobjRegistro[0]);
                LobjConcepto.CONdescripcion = LobjRegistro[1].ToString();
                LobjConcepto.CONmonto = LobjRegistro[2].ToString();
                LobjConcepto.CONtipo = LobjRegistro[3].ToString();
            }

            LobjConexion.Conectar().Close();
            return LobjConcepto;
        }

        public int mtdModificar(gstClsConcepto LobjConcepto)
        {
            int LintRespuesta = 0;

            string LstrComando = "update gstCONpConcepto set CONdescripcion = '" + LobjConcepto.CONdescripcion + "', CONmonto = " + LobjConcepto.CONmonto + ", CONtipo = '" + LobjConcepto.CONtipo + "' where CONcodigo = " + LobjConcepto.CONcodigo;

            LobjComando = new SqlCommand(LstrComando, LobjConexion.Conectar());

            LintRespuesta = LobjComando.ExecuteNonQuery();

            LobjConexion.Conectar().Close();
            return LintRespuesta;
        }
    }
}
