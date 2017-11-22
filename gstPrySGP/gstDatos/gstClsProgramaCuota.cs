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
                string LstrComandos = "insert into gstCUOtCuota values(" + LobjModelo.CONcodigo + ", '" + LobjModelo.CUOano + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "', '" + LobjModelo.CUOmes + "', '" + LobjModelo.CUOperiodo + "', '" + LobjModelo.CUOalcance + "')";

                LobjComando = new SqlCommand(LstrComandos, LobjConexion.Conectar());

                LintRespuesta = LobjComando.ExecuteNonQuery();

                LobjConexion.Conectar().Close();
            }

            return LintRespuesta;
        }

        public gstClsProgramaCuota mtdObtenerProgramaCuota(int LintCodigoProgramaCuota)
        {
            gstClsProgramaCuota LobjProgramaCuota = new gstClsProgramaCuota();

            string LstrComando = "select CUOcodigo as CODIGO, CONdescripcion as CONCEPTO, YEAR(CUOano) as AÑO, CUOmes as MES, CUOperiodo as PERIODO, CUOalcance as ALCANCE from gstCUOtCuota inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where gstCUOtCuota.CUOcodigo = " + LintCodigoProgramaCuota;
            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();
            if (LobjDataTable.Rows.Count > 0)
            {
                foreach (DataRow LobjRegistro in LobjDataTable.Rows)
                {
                    LobjProgramaCuota.CONcodigo = Convert.ToInt32(LobjRegistro[0]);
                    LobjProgramaCuota.CONdescripcion = LobjRegistro[1].ToString();
                    LobjProgramaCuota.CUOano = LobjRegistro[2].ToString();
                    LobjProgramaCuota.CUOmes = LobjRegistro[3].ToString();
                    LobjProgramaCuota.CUOperiodo = LobjRegistro[4].ToString();
                    LobjProgramaCuota.CUOalcance = LobjRegistro[5].ToString();
                }
            }

            return LobjProgramaCuota;
        }

        public int mtdModificar(gstClsProgramaCuota LobjModelo)
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

            string LstrComandos = "update gstCUOtCuota set CONcodigo = " + LobjModelo.CONcodigo + ", CUOano = '" + LobjModelo.CUOano + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "', CUOmes = '" + LobjModelo.CUOmes + "', CUOperiodo = '" + LobjModelo.CUOperiodo + "', CUOalcance = '" + LobjModelo.CUOalcance + "' where CUOcodigo = " + LobjModelo.CUOcodigo;

            LobjComando = new SqlCommand(LstrComandos, LobjConexion.Conectar());

            LintRespuesta = LobjComando.ExecuteNonQuery();

            LobjConexion.Conectar().Close();

            return LintRespuesta;
        }

        public int mtdAplicarProgramaCuota(string LstrAño)
        {
            int LintRespuesta = 0;

            string LstrComando = "select * from gstCUOtCuota inner join gstCONpConcepto on gstCUOtCuota.CONcodigo = gstCONpConcepto.CONcodigo where YEAR(gstCUOtCuota.CUOano) = '" + LstrAño + "'";
            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            string LstrComandoAlumno = "select * from gstALMpAlumno";
            SqlDataAdapter LobjAdaptadorAlumno = new SqlDataAdapter(LstrComandoAlumno, LobjConexion.Conectar());
            DataTable LobjDataTableAlumno = new DataTable();
            LobjAdaptadorAlumno.Fill(LobjDataTableAlumno);
            LobjConexion.Conectar().Close();

            if (LobjDataTableAlumno.Rows.Count > 0)
            {
                foreach (DataRow LobjRegistroAlumno in LobjDataTableAlumno.Rows)
                {
                    foreach (DataRow LobjRegistro in LobjDataTable.Rows)
                    {
                        if(LobjRegistro[4].ToString().Equals("Por año"))
                        {
                            if(LobjRegistro[5].ToString().Equals("Todo"))
                            {
                                string LstrMonto = LobjRegistro[8].ToString().Replace(",", ".");
                                string LstrComandoDeuda = "insert into gstDEUtDeuda values(" + LobjRegistroAlumno[0].ToString() + ", " + LobjRegistro[0].ToString() + ", " + LstrMonto + ", '" + LobjRegistro[7].ToString() + "')";

                                LobjComando = new SqlCommand(LstrComandoDeuda, LobjConexion.Conectar());

                                LintRespuesta = LobjComando.ExecuteNonQuery();

                                LobjConexion.Conectar().Close();
                            }
                            else if(LobjRegistro[5].ToString().Equals("Primaria"))
                            {
                                if(LobjRegistroAlumno[6].ToString().Equals("Primaria"))
                                {
                                    string LstrMonto = LobjRegistro[8].ToString().Replace(",", ".");
                                    string LstrComandoDeuda = "insert into gstDEUtDeuda values(" + LobjRegistroAlumno[0].ToString() + ", " + LobjRegistro[0].ToString() + ", " + LstrMonto + ", '" + LobjRegistro[7].ToString() + "')";

                                    LobjComando = new SqlCommand(LstrComandoDeuda, LobjConexion.Conectar());

                                    LintRespuesta = LobjComando.ExecuteNonQuery();

                                    LobjConexion.Conectar().Close();
                                }
                            }
                            else
                            {
                                if (LobjRegistroAlumno[6].ToString().Equals("Secundaria"))
                                {
                                    string LstrMonto = LobjRegistro[8].ToString().Replace(",", ".");
                                    string LstrComandoDeuda = "insert into gstDEUtDeuda values(" + LobjRegistroAlumno[0].ToString() + ", " + LobjRegistro[0].ToString() + ", " + LstrMonto + ", '" + LobjRegistro[7].ToString() + "')";

                                    LobjComando = new SqlCommand(LstrComandoDeuda, LobjConexion.Conectar());

                                    LintRespuesta = LobjComando.ExecuteNonQuery();

                                    LobjConexion.Conectar().Close();
                                }
                            }
                        }
                        else
                        {
                            int LintNumeroMes = 0;
                            switch(LobjRegistro[3].ToString())
                            {
                                case "Marzo":
                                    LintNumeroMes = 3;
                                    break;
                                case "Abril":
                                    LintNumeroMes = 4;
                                    break;
                                case "Mayo":
                                    LintNumeroMes = 5;
                                    break;
                                case "Junio":
                                    LintNumeroMes = 6;
                                    break;
                                case "Julio":
                                    LintNumeroMes = 7;
                                    break;
                                case "Agosto":
                                    LintNumeroMes = 8;
                                    break;
                                case "Septiembre":
                                    LintNumeroMes = 9;
                                    break;
                                case "Octubre":
                                    LintNumeroMes = 10;
                                    break;
                                case "Noviembre":
                                    LintNumeroMes = 11;
                                    break;
                                case "Diciembre":
                                    LintNumeroMes = 12;
                                    break;
                            }

                            if (LobjRegistro[5].ToString().Equals("Todo"))
                            {
                                for (int i = LintNumeroMes; i <= 12; i++)
                                {
                                    DateTimeFormatInfo LobjNombreMes = new CultureInfo("es-ES", false).DateTimeFormat;

                                    string LstrMonto = LobjRegistro[8].ToString().Replace(",", ".");
                                    string LstrComandoDeuda = "insert into gstDEUtDeuda values (" + LobjRegistroAlumno[0].ToString() + ", " + LobjRegistro[0].ToString() + ", " + LstrMonto + ", '" + LobjRegistro[7].ToString() + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LobjNombreMes.GetMonthName(i)) + "')";

                                    LobjComando = new SqlCommand(LstrComandoDeuda, LobjConexion.Conectar());

                                    LintRespuesta = LobjComando.ExecuteNonQuery();

                                    LobjConexion.Conectar().Close();
                                }
                            }
                            else if (LobjRegistro[5].ToString().Equals("Primaria"))
                            {
                                if (LobjRegistroAlumno[6].ToString().Equals("Primaria"))
                                {
                                    for (int i = LintNumeroMes; i <= 12; i++)
                                    {
                                        DateTimeFormatInfo LobjNombreMes = new CultureInfo("es-ES", false).DateTimeFormat;

                                        string LstrMonto = LobjRegistro[8].ToString().Replace(",", ".");
                                        string LstrComandoDeuda = "insert into gstDEUtDeuda values (" + LobjRegistroAlumno[0].ToString() + ", " + LobjRegistro[0].ToString() + ", " + LstrMonto + ", '" + LobjRegistro[7].ToString() + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LobjNombreMes.GetMonthName(i)) + "')";

                                        LobjComando = new SqlCommand(LstrComandoDeuda, LobjConexion.Conectar());

                                        LintRespuesta = LobjComando.ExecuteNonQuery();

                                        LobjConexion.Conectar().Close();
                                    }
                                }
                            }
                            else
                            {
                                if (LobjRegistroAlumno[6].ToString().Equals("Secundaria"))
                                {
                                    for (int i = LintNumeroMes; i <= 12; i++)
                                    {
                                        DateTimeFormatInfo LobjNombreMes = new CultureInfo("es-ES", false).DateTimeFormat;

                                        string LstrMonto = LobjRegistro[8].ToString().Replace(",", ".");
                                        string LstrComandoDeuda = "insert into gstDEUtDeuda values (" + LobjRegistroAlumno[0].ToString() + ", " + LobjRegistro[0].ToString() + ", " + LstrMonto + ", '" + LobjRegistro[7].ToString() + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LobjNombreMes.GetMonthName(i)) + "')";

                                        LobjComando = new SqlCommand(LstrComandoDeuda, LobjConexion.Conectar());

                                        LintRespuesta = LobjComando.ExecuteNonQuery();

                                        LobjConexion.Conectar().Close();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return LintRespuesta;
        }
    }
}
