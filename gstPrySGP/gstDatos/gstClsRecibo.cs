using System;
using System.Collections;
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
        public string RECcodigo { get; set; }
        public int ALMcodigo { get; set; }
        public int USUcodigo { get; set; }
        public string RECfecha { get; set; }
        public double RECtotal { get; set; }
        public int DPGcodigo { get; set; }
        public int DEUcodigo { get; set; }
        public double DPGsubtotal { get; set; }


        gstClsConexion LobjConexion = new gstClsConexion();
        SqlCommand LobjComando;
        SqlConnection LobjConnection = new SqlConnection();

        public DataTable mtdBuscarAlumno(string LstrParametro)
        {
            string LstrComando = "select ALMcodigo as CÓDIGO, ALMapellido as APELLIDO, ALMnombre as NOMBRE from gstALMpAlumno where ALMapellido like ('" + LstrParametro + "%') OR ALMdni like ('" + LstrParametro + "%') AND ALMestado = 'Matriculado'";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public DataTable mtdListarDeudaExtraordinaria(int LintCodigoAlumno)
        {
            string LstrComando = "select gstDEUtDeuda.DEUcodigo as CÓDIGO, YEAR(gstCUOtCuota.CUOano) as AÑO, gstDEUtDeuda.DEUdescripcion as DESCRIPCIÓN, gstDEUtDeuda.DEUmonto as MONTO from gstDEUtDeuda inner join gstCUOtCuota on gstDEUtDeuda.CUOcodigo = gstCUOtCuota.CUOcodigo inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstDEUtDeuda.ALMcodigo = " + LintCodigoAlumno + " AND (gstCONpConcepto.CONtipo = 'APAFA' OR gstCONpConcepto.CONtipo = 'Cuota Extraordinaria') AND gstDEUtDeuda.DEUcodigo not in (select DEUcodigo from gstEXOtExoneracion) AND gstDEUtDeuda.DEUcodigo not in (select DEUcodigo from gstDPGtDeudaPago)";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjDataTable.Columns.Add(new DataColumn("SELECCIONAR", typeof(bool)));
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public DataTable mtdListarDeudaMensualidad(int LintCodigoAlumno)
        {
            string LstrComando = "select gstDEUtDeuda.DEUcodigo as CÓDIGO, YEAR(gstCUOtCuota.CUOano) as AÑO, gstDEUtDeuda.DEUdescripcion as DESCRIPCIÓN, gstDEUtDeuda.DEUmonto as MONTO from gstDEUtDeuda inner join gstCUOtCuota on gstDEUtDeuda.CUOcodigo = gstCUOtCuota.CUOcodigo inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstDEUtDeuda.ALMcodigo = " + LintCodigoAlumno + " AND (gstCONpConcepto.CONtipo = 'Mensualidad')  AND gstDEUtDeuda.DEUcodigo not in (select DEUcodigo from gstEXOtExoneracion) AND gstDEUtDeuda.DEUcodigo not in (select DEUcodigo from gstDPGtDeudaPago)";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjDataTable.Columns.Add(new DataColumn("SELECCIONAR", typeof(bool)));
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public DataTable mtdListarDeudaPagada(int LintCodigoAlumno)
        {
            string LstrComando = "select gstDEUtDeuda.DEUcodigo as CÓDIGO, YEAR(gstCUOtCuota.CUOano) as AÑO, gstDEUtDeuda.DEUdescripcion as DESCRIPCIÓN, gstDEUtDeuda.DEUmonto as MONTO from gstDEUtDeuda inner join gstCUOtCuota on gstDEUtDeuda.CUOcodigo = gstCUOtCuota.CUOcodigo inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstDEUtDeuda.ALMcodigo = " + LintCodigoAlumno + " AND gstDEUtDeuda.DEUcodigo not in (select DEUcodigo from gstEXOtExoneracion) AND gstDEUtDeuda.DEUcodigo in (select DEUcodigo from gstDPGtDeudaPago)";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public string mtdObtenerUltimoCodigoRecibo()
        {
            string LstrUltimoCodigo = "";
            string LstrComando = "select RECcodigo from gstRECtRecibo";
            string LstrCodigoRecibo = "";
            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();
            if(LobjDataTable.Rows.Count > 0)
            {
                foreach (DataRow LobjRegistro in LobjDataTable.Rows)
                {
                    LstrCodigoRecibo = LobjRegistro[0].ToString();
                }

                LstrUltimoCodigo = LstrCodigoRecibo.Substring(2,8);
            }
            else
            {
                LstrUltimoCodigo = "0";
            }

            return LstrUltimoCodigo;
        }

        public int mtdGuardarRecibo(gstClsRecibo LobjRecibo, List<gstClsRecibo> LobjReciboDetalle)
        {
            int LintRespuesta = 0;

            string LstrComandoRecibo = "insert into gstRECtRecibo values('" + LobjRecibo.RECcodigo + "', " + LobjRecibo.ALMcodigo + ", " + LobjRecibo.USUcodigo + ", '" + LobjRecibo.RECfecha + "', " + LobjRecibo.RECtotal + ")";

            LobjComando = new SqlCommand(LstrComandoRecibo, LobjConexion.Conectar());

            LintRespuesta = LobjComando.ExecuteNonQuery();   

            foreach(var LobjRegistro in LobjReciboDetalle)
            {
                string LstrComandoReciboDetalle = "insert into gstDPGtDeudaPago values('" + LobjRecibo.RECcodigo + "', " + LobjRegistro.DEUcodigo + ", " + LobjRegistro.DPGsubtotal + ")";

                LobjComando = new SqlCommand(LstrComandoReciboDetalle, LobjConexion.Conectar());

                LintRespuesta = LobjComando.ExecuteNonQuery();
            }

            LobjConexion.Conectar().Close();
            return LintRespuesta;
        }

        public ArrayList mtdListarRecibos(int LintCodigoAlumno)
        {
            string LstrComando = "select RECcodigo, RECfecha from gstRECtRecibo where ALMcodigo = " + LintCodigoAlumno;
            ArrayList LobjListaRecibos = new ArrayList();
            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();
            if (LobjDataTable.Rows.Count > 0)
            {
                foreach (DataRow LobjRegistro in LobjDataTable.Rows)
                {
                    LobjListaRecibos.Add(LobjRegistro[0].ToString() + "-" + Convert.ToDateTime(LobjRegistro[1]).ToString("dd/MM/yyyy"));
                }

            }

            return LobjListaRecibos;
        }

        public gstClsAlumno mtdObtenerAlumno(int LintCodigoAlumno)
        {
            string LstrComando = "select ALMcodigo, ALMnombre, ALMapellido, ALMnivel, ALMgrado, ALMseccion, ALMestado from gstALMpAlumno where ALMcodigo = " + LintCodigoAlumno;
            gstClsAlumno LobjALumno = new gstClsAlumno();
            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();
            if (LobjDataTable.Rows.Count > 0)
            {
                foreach (DataRow LobjRegistro in LobjDataTable.Rows)
                {
                    LobjALumno.ALMcodigo = Convert.ToInt32(LobjRegistro[0]);
                    LobjALumno.ALMnombre = LobjRegistro[1].ToString();
                    LobjALumno.ALMapellido = LobjRegistro[2].ToString();
                    LobjALumno.ALMnivel = LobjRegistro[3].ToString();
                    LobjALumno.ALMgrado = Convert.ToInt32(LobjRegistro[4]);
                    LobjALumno.ALMseccion = LobjRegistro[5].ToString();
                    LobjALumno.ALMestado = LobjRegistro[6].ToString();
                }

            }

            return LobjALumno;
        }

        public DataTable mtdCargarReciboGenerado(string LstrCodigoReciboAlumno)
        {
            string LstrComando = "select gstDEUtDeuda.DEUcodigo as CÓDIGO, YEAR(gstCUOtCuota.CUOano) as AÑO, gstDEUtDeuda.DEUdescripcion as DESCRIPCIÓN, gstDEUtDeuda.DEUmonto as MONTO from gstDEUtDeuda inner join gstCUOtCuota on gstDEUtDeuda.CUOcodigo = gstCUOtCuota.CUOcodigo inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo inner join gstDPGtDeudaPago on gstDEUtDeuda.DEUcodigo = gstDPGtDeudaPago.DEUcodigo where gstDEUtDeuda.DEUcodigo not in (select DEUcodigo from gstEXOtExoneracion) AND gstDEUtDeuda.DEUcodigo in (select DEUcodigo from gstDPGtDeudaPago) AND gstDPGtDeudaPago.RECcodigo = '" + LstrCodigoReciboAlumno + "'";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }

        public int mtdEliminarRecibo(int LintCodigoAlumno)
        {
            int LintRespuesta = 0;

            string LstrComandoRecibo = "delete from gstDPGtDeudaPago where RECcodigo = (select TOP 1 RECcodigo from gstRECtRecibo where ALMcodigo = " + LintCodigoAlumno + " order by RECcodigo DESC)";
            string LstrComandoReciboDetalle = "delete from gstRECtRecibo where RECcodigo = (select TOP 1 RECcodigo from gstRECtRecibo where ALMcodigo = " + LintCodigoAlumno + " order by RECcodigo DESC)";

            LobjComando = new SqlCommand(LstrComandoRecibo, LobjConexion.Conectar());
            LintRespuesta = LobjComando.ExecuteNonQuery();

            LobjComando = new SqlCommand(LstrComandoReciboDetalle, LobjConexion.Conectar());
            LintRespuesta = LobjComando.ExecuteNonQuery();

            LobjConexion.Conectar().Close();
            return LintRespuesta;
        }

        public DataTable mtdFiltrarDeudaPago(string LstrParametro, int LintCodigoAlumno)
        {
            if(LstrParametro.Equals("Todo"))
            {
                string LstrComando = "select gstDEUtDeuda.DEUcodigo as CÓDIGO, YEAR(gstCUOtCuota.CUOano) as AÑO, gstDEUtDeuda.DEUdescripcion as DESCRIPCIÓN, gstDEUtDeuda.DEUmonto as MONTO from gstDEUtDeuda inner join gstCUOtCuota on gstDEUtDeuda.CUOcodigo = gstCUOtCuota.CUOcodigo inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstDEUtDeuda.ALMcodigo = " + LintCodigoAlumno + " AND gstDEUtDeuda.DEUcodigo not in (select DEUcodigo from gstEXOtExoneracion) AND gstDEUtDeuda.DEUcodigo in (select DEUcodigo from gstDPGtDeudaPago)";

                SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
                DataTable LobjDataTable = new DataTable();
                LobjAdaptador.Fill(LobjDataTable);
                LobjConexion.Conectar().Close();

                return LobjDataTable;
            }
            else
            {
                string LstrComando = "select gstDEUtDeuda.DEUcodigo as CÓDIGO, YEAR(gstCUOtCuota.CUOano) as AÑO, gstDEUtDeuda.DEUdescripcion as DESCRIPCIÓN, gstDEUtDeuda.DEUmonto as MONTO from gstDEUtDeuda inner join gstCUOtCuota on gstDEUtDeuda.CUOcodigo = gstCUOtCuota.CUOcodigo inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstDEUtDeuda.ALMcodigo = " + LintCodigoAlumno + " AND gstDEUtDeuda.DEUcodigo not in (select DEUcodigo from gstEXOtExoneracion) AND gstDEUtDeuda.DEUcodigo in (select DEUcodigo from gstDPGtDeudaPago) AND gstCONpConcepto.CONtipo = '" + LstrParametro + "'";

                SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
                DataTable LobjDataTable = new DataTable();
                LobjAdaptador.Fill(LobjDataTable);
                LobjConexion.Conectar().Close();

                return LobjDataTable;
            }
        }
    }
}
