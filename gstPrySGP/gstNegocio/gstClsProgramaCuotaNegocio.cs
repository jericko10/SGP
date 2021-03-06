﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gstDatos;
using System.Data;

namespace gstNegocio
{
    public class gstClsProgramaCuotaNegocio
    {
        gstClsProgramaCuota LobjProgramaCuota = new gstClsProgramaCuota();

        public List<gstClsConcepto> mtdListarConcepto()
        {
            return LobjProgramaCuota.mtdListarConcepto();
        }

        public DataTable mtdCargarTabla(string LstrParametro)
        {
            return LobjProgramaCuota.mtdCargarTabla(LstrParametro);
        }

        public DataTable mtdBuscarProgramaCuota(string LstrAño, string LstrParametro)
        {
            return LobjProgramaCuota.mtdBuscarProgramaCuota(LstrAño, LstrParametro);
        }

        public int mtdGuardar(gstClsProgramaCuota LobjModelo)
        {
            return LobjProgramaCuota.mtdGuardar(LobjModelo);
        }

        public gstClsProgramaCuota mtdObtenerProgramaCuota(int LintCodigoProgramaCuota)
        {
            return LobjProgramaCuota.mtdObtenerProgramaCuota(LintCodigoProgramaCuota);
        }

        public int mtdModificar(gstClsProgramaCuota LobjModelo)
        {
            return LobjProgramaCuota.mtdModificar(LobjModelo);
        }

        public int mtdAplicarProgramaCuota(string LstrAño)
        {
            return LobjProgramaCuota.mtdAplicarProgramaCuota(LstrAño);
        }
    }
}
