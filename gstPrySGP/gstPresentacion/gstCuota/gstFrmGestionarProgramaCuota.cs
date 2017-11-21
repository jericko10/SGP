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

namespace gstPresentacion.gstCuota
{
    public partial class gstFrmGestionarProgramaCuota : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;

        public bool LblnModificar = false;
        public int LintCodigoProgramaCuota = 0;
        public gstFrmGestionarProgramaCuota()
        {
            InitializeComponent();
        }

        private void gstFrmGestionarProgramaCuota_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }

        private void pnlGestionarProgramaCuota_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void pnlGestionarProgramaCuota_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlGestionarProgramaCuota_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mtdCargarDatos()
        {
            nupAño.Value = DateTime.Now.Year;

            cmbMes.Items.Clear();
            cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril");
            cmbMes.Items.Add("Mayo");
            cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("Julio");
            cmbMes.Items.Add("Agosto");
            cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre");
            cmbMes.Items.Add("Noviembre");
            cmbMes.Items.Add("Diciembre");
            cmbMes.SelectedIndex = 0;

            cmbPeriodo.Items.Clear();
            cmbPeriodo.Items.Add("Por año");
            cmbPeriodo.Items.Add("Cada mes");
            cmbPeriodo.SelectedIndex = 0;

            cmbAlcance.Items.Clear();
            cmbAlcance.Items.Add("Todo");
            cmbAlcance.Items.Add("Primaria");
            cmbAlcance.Items.Add("Secundaria");
            cmbAlcance.SelectedIndex = 0;

            nupFiltrarPorAño.Value = DateTime.Now.Year;

            nupAplicarAño.Value = DateTime.Now.Year;

            gstClsProgramaCuotaNegocio LobjProgramaCuotaNegocio = new gstClsProgramaCuotaNegocio();

            List<gstClsConcepto> LobjListaConcepto = new List<gstClsConcepto>();
            LobjListaConcepto = LobjProgramaCuotaNegocio.mtdListarConcepto();

            cmbConcepto.Items.Clear();

            foreach(var LobjRegistro in LobjListaConcepto)
            {
                cmbConcepto.Items.Add(LobjRegistro.CONdescripcion);
            }

            cmbConcepto.SelectedIndex = 0;

            var LobjCargarTabla = LobjProgramaCuotaNegocio.mtdCargarTabla(nupAño.Value.ToString());

            dgdProgramaCuota.DataSource = LobjCargarTabla;
        }

        private void nupFiltrarPorAño_ValueChanged(object sender, EventArgs e)
        {
            gstClsProgramaCuotaNegocio LobjProgramaCuotaNegocio = new gstClsProgramaCuotaNegocio();
            var LobjCargarTabla = LobjProgramaCuotaNegocio.mtdCargarTabla(nupFiltrarPorAño.Value.ToString());

            dgdProgramaCuota.DataSource = LobjCargarTabla;
        }

        private void txtBuscar_KeyUp(object sender, EventArgs e)
        {
            gstClsProgramaCuotaNegocio LobjProgramaCuotaNegocio = new gstClsProgramaCuotaNegocio();

            var LobjProgramaCuota = LobjProgramaCuotaNegocio.mtdBuscarProgramaCuota(nupFiltrarPorAño.Value.ToString(), txtBuscar.text);

            dgdProgramaCuota.DataSource = LobjProgramaCuota;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gstClsProgramaCuota LobjProgramaCuota = new gstClsProgramaCuota();
            gstClsProgramaCuotaNegocio LobjProgramaCuotaNegocio = new gstClsProgramaCuotaNegocio();

            LobjProgramaCuota.CONdescripcion = cmbConcepto.Text;
            LobjProgramaCuota.CUOano = nupAño.Value.ToString();
            LobjProgramaCuota.CUOmes = cmbMes.Text;
            LobjProgramaCuota.CUOperiodo = cmbPeriodo.Text;
            LobjProgramaCuota.CUOalcance = cmbAlcance.Text;

            if (MessageBox.Show("¿Está seguro de realizar la operación?", "GESTIONAR PROGRAMA DE CUOTAS", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int LintResultado = LobjProgramaCuotaNegocio.mtdGuardar(LobjProgramaCuota);
                if (LintResultado == -2)
                {
                    MessageBox.Show("La cuota se encuentra registrado para el presente año. Modifique la actual cuota ó registre la cuota en un año diferente.", "ERROR");
                    mtdCargarDatos();
                }
                else if (LintResultado == 1)
                {
                    MessageBox.Show("Operación realizada con éxito.", "CORRECTO");
                    mtdCargarDatos();
                }
                else
                {
                    MessageBox.Show("Error en la operación.", "ERROR");
                    mtdCargarDatos();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgdProgramaCuota.CurrentRow.Cells[0].Value != null)
            {
                int LintCodigoProgramaCuota = Convert.ToInt32(dgdProgramaCuota.CurrentRow.Cells[0].Value);

                mtdLlenarCampos(LintCodigoProgramaCuota);

                LblnModificar = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro.", "GESTIONAR PROGRAMA DE CUOTAS");
            }
        }

        private void btnAplicarProgramaCuota_Click(object sender, EventArgs e)
        {

        }

        public void mtdLlenarCampos(int LintCodigoProgramaCuota)
        {

        }
    }
}
