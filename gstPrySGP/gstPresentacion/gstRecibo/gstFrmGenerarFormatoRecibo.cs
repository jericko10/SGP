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
    }
}
