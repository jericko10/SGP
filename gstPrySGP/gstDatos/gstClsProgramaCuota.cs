using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gstDatos
{
    public class gstClsProgramaCuota
    {
        public int CUOcodigo { get; set; }
        public int CONcodigo { get; set; }
        public string CONdescripcion { get; set; }
        public string CUOano { get; set; }
        public string CUOmes { get; set; }
        public string CUOperiodo { get; set; }
        public string CUOalcance { get; set; }


        gstClsConexion LobjConexion = new gstClsConexion();
        SqlCommand LobjComando;
        SqlConnection LobjConnection = new SqlConnection();

        public DataTable mtdCargarTabla(string LstrParametro)
        {
            string LstrComando = "select CUOcodigo as CODIGO, CONdescripcion as CONCEPTO, YEAR(CUOano) as AÑO, CUOmes as MES, CUOperiodo as PERIODO, CUOalcance as ALCANCE from gstCUOtCuota inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where YEAR(CUOano) = '" + LstrParametro + "'";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public List<gstClsConcepto> mtdListarConcepto()
        {
            string LstrComando = "select * from gstCONpConcepto";
            List<gstClsConcepto> LobjListaConcepto = new List<gstClsConcepto>();
            gstClsConcepto LobjConcepto;
            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();
            if (LobjDataTable.Rows.Count > 0)
            {
                foreach (DataRow LobjRegistro in LobjDataTable.Rows)
                {
                    LobjConcepto = new gstClsConcepto();
                    LobjConcepto.CONcodigo = Convert.ToInt32(LobjRegistro[0]);
                    LobjConcepto.CONdescripcion = LobjRegistro[1].ToString();
                    LobjConcepto.CONmonto = LobjRegistro[2].ToString();
                    LobjConcepto.CONtipo = LobjRegistro[3].ToString();


                    LobjListaConcepto.Add(LobjConcepto);
                }
            }

            return LobjListaConcepto;
        }

        public DataTable mtdBuscarProgramaCuota(string LstrAño, string LstrParametro)
        {
            string LstrComando = "select CUOcodigo as CODIGO, CONdescripcion as CONCEPTO, YEAR(CUOano) as AÑO, CUOmes as MES, CUOperiodo as PERIODO, CUOalcance as ALCANCE from gstCUOtCuota inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where YEAR(CUOano) = '" + LstrAño + "' AND CONdescripcion like ('" + LstrParametro + "%')";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public int mtdGuardar(gstClsProgramaCuota LobjModelo)
        {
            int LintRespuesta = 0;

            string LstrComando = "select * from gstCONpConcepto where CONdescripcion = '" + LobjModelo.CONdescripcion + "'";
            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();
            if (LobjDataTable.Rows.Count > 0)
            {
                foreach (DataRow LobjRegistro in LobjDataTable.Rows)
                {
                    LobjModelo.CONcodigo = Convert.ToInt32(LobjRegistro[0]);
                }
            }

            string LstrComandoVerificarExistente = "select * from gstCUOtCuota inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstCONpConcepto.CONdescripcion = '" + LobjModelo.CONdescripcion + "' AND YEAR(gstCUOtCuota.CUOano) = '" + LobjModelo.CUOano + "'";
            SqlDataAdapter LobjAdaptadors = new SqlDataAdapter(LstrComandoVerificarExistente, LobjConexion.Conectar());
            DataTable LobjDataTables = new DataTable();
            LobjAdaptadors.Fill(LobjDataTables);
            LobjConexion.Conectar().Close();
            if (LobjDataTables.Rows.Count > 0)
            {
                LintRespuesta = -2;
            }
            else
            {
                string LstrComandoRecibo = "insert into gstCUOtCuota values(" + LobjModelo.CONcodigo + ", '" + LobjModelo.CUOano + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "', '" + LobjModelo.CUOmes + "', '" + LobjModelo.CUOperiodo + "', '" + LobjModelo.CUOalcance + "')";

                LobjComando = new SqlCommand(LstrComandoRecibo, LobjConexion.Conectar());

                LintRespuesta = LobjComando.ExecuteNonQuery();

                LobjConexion.Conectar().Close();
            }

            return LintRespuesta;
        }
    }
}
