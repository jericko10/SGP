using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gstDatos
{
    public class gstClsConexion
    {
        public SqlConnection Conectar()
        {
            try
            {
                SqlConnection LobjConexion = new SqlConnection("server=PERCYLP_LP; database=gstPago; user id=percy; password = 123; integrated security = true");
                LobjConexion.Open();
                return LobjConexion;
            }
            catch (Exception LobjExcepcion)
            {
                throw new ArgumentException("Error al conectar", LobjExcepcion);
            }

        }
    }
}
