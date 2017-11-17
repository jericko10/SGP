using gstNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstPresentacion
{
    public partial class gstFrmGenerarFormatoRecibo : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;
        public gstFrmGenerarFormatoRecibo()
        {
            InitializeComponent();
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gstFrmRecibo frmRecibo = new gstFrmRecibo();
            frmRecibo.MdiParent = this.MdiParent;
            frmRecibo.StartPosition = FormStartPosition.CenterScreen;
            frmRecibo.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlGenerarFormatoRecibo_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlGenerarFormatoRecibo_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void pnlGenerarFormatoRecibo_MouseDown(object sender, MouseEventArgs e)
        {

            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyUp(object sender, EventArgs e)
        {
            gstClsReciboNegocio LobjRecibo = new gstClsReciboNegocio();

            var LobjAlumno = LobjRecibo.mtdBuscarAlumno(txtBuscar.text);

            dgdAlumno.DataSource = LobjAlumno;
        }

        private void dgdAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgdAlumno.CurrentCell.RowIndex.ToString());
        }

        private void dgdAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int LintCodigoAlumno = Convert.ToInt32(dgdAlumno.CurrentRow.Cells[0].Value.ToString());

            string LstrNombreApellidoAlumno = dgdAlumno.CurrentRow.Cells[1].Value.ToString().ToUpper() + ", " + dgdAlumno.CurrentRow.Cells[2].Value.ToString();

            lblCodigoAlumno.Text = LintCodigoAlumno.ToString();
            lblNombreApellidoAlumno.Text = LstrNombreApellidoAlumno;

            gstClsReciboNegocio LobjRecibo = new gstClsReciboNegocio();

            var LobjDeudaExtraordinaria = LobjRecibo.mtdListarDeudaExtraordinaria(LintCodigoAlumno);
            var LobjDeudaMensualidad = LobjRecibo.mtdListarDeudaMensualidad(LintCodigoAlumno);
            var LobjDeudaPagada = LobjRecibo.mtdListarDeudaPagada(LintCodigoAlumno);

            dgdDeudaExtraordinaria.DataSource = LobjDeudaExtraordinaria;
            dgdDeudaMensualidad.DataSource = LobjDeudaMensualidad;

            double LdblMontoTotal = 0;

            foreach(DataRow LobjRegistro in LobjDeudaMensualidad.Rows)
            {
                LdblMontoTotal = LdblMontoTotal + Convert.ToDouble(LobjRegistro[2].ToString());
            }

            foreach(DataRow LobjRegistro in LobjDeudaExtraordinaria.Rows)
            {
                LdblMontoTotal = LdblMontoTotal + Convert.ToDouble(LobjRegistro[2].ToString());
            }

            lblMontoTotal.Text = LdblMontoTotal.ToString();
        }

        private void dgdDeudaMensualidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgdDeudaMensualidad.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgdDeudaMensualidad_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgdDeudaMensualidad.Rows)
            {
                if (row.Cells[3].Value.Equals(true))
                {
                    //falta seleccionar
                }
            }
        }
    }
}
