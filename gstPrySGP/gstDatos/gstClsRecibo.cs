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
            string LstrComando = "select ALMcodigo, ALMapellido, ALMnombre from gstALMpAlumno where ALMapellido like ('" + LstrParametro + "%') OR ALMdni like ('" + LstrParametro + "%') AND ALMestado = 'Matriculado'";

            SqlDataAdapter LobjAdaptador = new SqlDataAdapter(LstrComando, LobjConexion.Conectar());
            DataTable LobjDataTable = new DataTable();
            LobjAdaptador.Fill(LobjDataTable);
            LobjConexion.Conectar().Close();

            return LobjDataTable;
        }
    }
}
