using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace gstDatos
{
    class gstClsMatricula
    {
        public int ALMcodigo { get; set; }
        public string ALMdni { get; set; }
        public string ALMnombre { get; set; }
        public string ALMapellido { get; set; }
        public string ALMobservacion { get; set; }
        public int ALMperiodo { get; set; }
        public string ALMnivel { get; set; }
        public int ALMgrado { get; set; }
        public string ALMseccion { get; set; }
        public string ALMestado { get; set; }

       // public int mtdExportar() { }



    }
}
