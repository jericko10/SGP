using gstPresentacion.gstMatricula;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gstPresentacion;
namespace gstPre
{
    public partial class gstFrmPrincipal : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;

        public gstFrmPrincipal()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            gstFrmGestionarAlumno frmGA = new gstFrmGestionarAlumno();
            frmGA.MdiParent = this.MdiParent;
           frmGA.StartPosition = FormStartPosition.CenterParent;
            frmGA.Show();


        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
           // this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;


          this.WindowState = ( this.WindowState == FormWindowState.Maximized ?
          FormWindowState.Normal :
        FormWindowState.Maximized);

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tltExpandir_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void pnlPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            gstFrmMatriculaMasiva frmMM = new gstFrmMatriculaMasiva();
            frmMM.MdiParent = this.MdiParent;
            frmMM.StartPosition = FormStartPosition.CenterScreen;
            frmMM.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            gstFrmGestionarUsuario frmGU = new gstFrmGestionarUsuario();
            frmGU.MdiParent = this.MdiParent;
            frmGU.StartPosition = FormStartPosition.CenterScreen;
            frmGU.Show();
        }

        private void gstFrmPrincipal_Load(object sender, EventArgs e)
        {
            pnlReporte.Visible = false;
            pnlRecibo.Visible=false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFH.Text = DateTime.Now.ToString("G");
        }

        private void btnExpandir_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnReporteDeudasAlumno_Click(object sender, EventArgs e)
        {
            gstFrmReporteDeudasAlumno frmRDA = new gstFrmReporteDeudasAlumno();
            frmRDA.MdiParent = this.MdiParent;
            frmRDA.StartPosition = FormStartPosition.CenterScreen;
            frmRDA.Show();
            pnlReporte.Hide();
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            //pnlReporte.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gstFrmReportePagoDiario frmRPD = new gstFrmReportePagoDiario();
            frmRPD.MdiParent = this.MdiParent;
            frmRPD.StartPosition = FormStartPosition.CenterScreen;
            frmRPD.Show();
            pnlReporte.Hide();
        }

        private void btnReporteDeudasSeccion_Click(object sender, EventArgs e)
        {
            gstFrmReporteDeudasSeccion frmRDS = new gstFrmReporteDeudasSeccion();
            frmRDS.MdiParent = this.MdiParent;
            frmRDS.StartPosition = FormStartPosition.CenterScreen;
            frmRDS.Show();
            pnlReporte.Hide();
        }

        private void btnExpandir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnReporte_MouseMove(object sender, MouseEventArgs e)
        {
            pnlReporte.Visible = true;
        }

        private void btnGenerarFormatoRecibo_Click(object sender, EventArgs e)
        {
            gstFrmGenerarFormatoRecibo frmGFR = new gstFrmGenerarFormatoRecibo();
            frmGFR.MdiParent = this.MdiParent;
            frmGFR.StartPosition = FormStartPosition.CenterParent;
            frmGFR.Show();
            pnlRecibo.Hide();
        }

        private void btnFraccionarApafa_Click(object sender, EventArgs e)
        {
            gstFrmFraccionar_Apafa frmFCA = new gstFrmFraccionar_Apafa();
            frmFCA.MdiParent = this.MdiParent;
            frmFCA.StartPosition = FormStartPosition.CenterParent;
            frmFCA.Show();
            pnlRecibo.Hide();
        }

        private void btnExonerarDeudasPendientes_Click(object sender, EventArgs e)
        {
            gstFrmExonerarDeudas frmED = new gstFrmExonerarDeudas();
            frmED.MdiParent = this.MdiParent;
            frmED.StartPosition = FormStartPosition.CenterParent;
            frmED.Show();
            pnlRecibo.Hide();
        }

        private void btnCuotaExtraordinaria_Click(object sender, EventArgs e)
        {
            gstFrmAgregarCuotaExtraordinaria frmACE = new gstFrmAgregarCuotaExtraordinaria();
            frmACE.MdiParent = this.MdiParent;
            frmACE.StartPosition = FormStartPosition.CenterParent;
            frmACE.Show();
            pnlRecibo.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
          
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            pnlRecibo.Visible = true;
        }

        private void pnlReporte_Move(object sender, EventArgs e)
        {
           
        }

        private void pnlReporte_MouseHover(object sender, EventArgs e)
        {
         //   pnlReporte.Visible = true;
        }

        private void pnlReporte_MouseLeave(object sender, EventArgs e)
        {
            pnlReporte.Visible=false;
        }

        private void btnRecibo_MouseMove(object sender, MouseEventArgs e)
        {
            pnlRecibo.Visible = true;
        }

        private void pnlRecibo_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pnlRecibo_MouseLeave(object sender, EventArgs e)
        {
           
            pnlRecibo.Visible = false;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pnlRecibo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
        
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            pnlReporte.Visible = false;
            pnlRecibo.Visible = false;
        }
    }
}
