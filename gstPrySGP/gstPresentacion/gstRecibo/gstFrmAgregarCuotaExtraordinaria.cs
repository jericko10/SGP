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
    public partial class gstFrmAgregarCuotaExtraordinaria : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;
        public gstFrmAgregarCuotaExtraordinaria()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gstFrmAgregarCuotaExtraordinaria_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCuotaExtraordinaria_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlCuotaExtraordinaria_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void pnlCuotaExtraordinaria_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void dgvAlumnoCE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
