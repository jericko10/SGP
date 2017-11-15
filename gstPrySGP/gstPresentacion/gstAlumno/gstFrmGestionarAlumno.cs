using gstPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstPre
{
    public partial class gstFrmGestionarAlumno : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;
        public gstFrmGestionarAlumno()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gstFrmGestionarAlumno_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCuotaApafa_Click(object sender, EventArgs e)
        {
            gstFrmCuotaApafa frmGA = new gstFrmCuotaApafa();
            frmGA.MdiParent = this.MdiParent;
            frmGA.StartPosition = FormStartPosition.CenterScreen;
            frmGA.Show();
        }

        private void btnGenerarRecibo_Click(object sender, EventArgs e)
        {
            gstFrmGenerarFormatoRecibo frmGA = new gstFrmGenerarFormatoRecibo();
            frmGA.MdiParent = this.MdiParent;
            frmGA.StartPosition = FormStartPosition.CenterScreen;
            frmGA.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
       
    }
    }
}
