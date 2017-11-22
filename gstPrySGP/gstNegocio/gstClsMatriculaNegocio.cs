using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gstDatos;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace gstNegocio
{
    public class gstClsMatriculaNegocio
    {


        OleDbConnection conn;
        OleDbDataAdapter MydataAdapter;

        DataTable dt;

        public void mtdImportar(DataGridView dgv, String nombreHoja)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel files | *.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }


                }

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=NO'");
                MydataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                dt = new DataTable();
                MydataAdapter.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

    
    }
}
























