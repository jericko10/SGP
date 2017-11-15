using gstPre;
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
    public partial class gstFrmIniciarSesion : Form
    {
        public gstFrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            gstFrmPrincipal frmPrincipal = new gstFrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
