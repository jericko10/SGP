using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gstDatos
{
    class gstClsExoneracion
    {
        public int EXOcodigo { set; get; }
        public int DEUcodigo { set; get; }
        public string EXOmotivo { set; get; }
        public string EXOdescripcion { set; get; }
        gstClsConexion LobjConexion = new gstClsConexion();
        SqlCommand LobjComando;
        SqlConnection LobjConnection = new SqlConnection();

        public int mtdGuardar(gstClsExoneracion LobjModelo)
        {
            int LintRespuesta = 0;

            string LstrComando = "select * from gstDEUtDeuda where DEUcodigo = '" + LobjModelo.DEUcodigo + "'";
            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();
            if (LobjDataTable.Rows.Count > 0)
            {
                foreach (DataRow LobjRegistro in LobjDataTable.Rows)
                {
                    LobjModelo.DEUcodigo = Convert.ToInt32(LobjRegistro[0]);
                }
            }

            string LstrComandoVerificarExistente = "select * from gstDEUtDeuda inner join gstDEUpDeuda on gstDEUtDeuda.DEUcodigo = gstEXOpExoneracion.EXOcodigo where gstEXOpExoneracion.EXOcodigo = '" + LobjModelo.DEUcodigo + "' AND YEAR(gstDEUtDeuda.DEUdescripcion) = '" + LobjModelo.DEUcodigo + "'";
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
                string LstrComandoRecibo = "insert into dbo.gstEXOtExoneracion (DEUcodigo, EXOmotivo,EXOdescripcion) values ("+LobjModelo.DEUcodigo+", '"+LobjModelo.EXOmotivo+"', '"+LobjModelo.EXOdescripcion+"');";

                LobjComando = new SqlCommand(LstrComandoRecibo, LobjConexion.Conectar());

                LintRespuesta = LobjComando.ExecuteNonQuery();

                LobjConexion.Conectar().Close();
            }

            return LintRespuesta;
        }
    }
}
