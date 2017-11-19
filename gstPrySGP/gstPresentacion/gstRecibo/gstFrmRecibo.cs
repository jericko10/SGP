using gstDatos;
using gstNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstPresentacion
{
    public partial class gstFrmRecibo : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;
        public string GstrCodigoReciboAlumno = "";
        public int GintCodigoAlumno = 0;
        public gstFrmRecibo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRecibo_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlRecibo_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void pnlRecibo_MouseDown(object sender, MouseEventArgs e)
        {

            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mtdCargarDatos()
        {
            gstClsAlumno LobjAlumno = new gstClsAlumno();
            gstClsReciboNegocio LobjReciboNegocio = new gstClsReciboNegocio();

            LobjAlumno = LobjReciboNegocio.mtdObtenerAlumno(GintCodigoAlumno);
            var LobjDeudaExtraordinaria = LobjReciboNegocio.mtdCargarReciboGenerado(GstrCodigoReciboAlumno);

            dgdRecibo.DataSource = LobjDeudaExtraordinaria;

            txtAlumno.Text = LobjAlumno.ALMapellido.ToUpper() + ", " + LobjAlumno.ALMnombre;
            txtCodigoAlumno.Text = LobjAlumno.ALMcodigo.ToString();
            txtCodigoRecibo.Text = GstrCodigoReciboAlumno;
            txtNivel.Text = LobjAlumno.ALMnivel.ToString();
            txtGrado.Text = LobjAlumno.ALMgrado.ToString();
            txtSeccion.Text = LobjAlumno.ALMseccion.ToString();
            txtEstado.Text = LobjAlumno.ALMestado.ToString();

            double LdblMontoTotal = 0;

            foreach (DataRow LobjRegistro in LobjDeudaExtraordinaria.Rows)
            {
                LdblMontoTotal = LdblMontoTotal + Convert.ToDouble(LobjRegistro[3].ToString());
            }

            txtTotal.Text = LdblMontoTotal.ToString();
        }

        private void gstFrmRecibo_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
