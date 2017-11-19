using gstDatos;
using gstNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstPresentacion
{
    public partial class gstFrmGenerarFormatoRecibo : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;
        double LdblSubTotalMensualidad = 0;
        double LdblSubTotalExtraordinario = 0;
        double LdblTotalDeudaMensualidad = 0;
        double LdblTotalDeudaExtraordinario = 0;
        public gstFrmGenerarFormatoRecibo()
        {
            InitializeComponent();
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {

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
            var LobjRecibosGenerados = LobjRecibo.mtdListarRecibos(LintCodigoAlumno);

            dgdDeudaExtraordinaria.DataSource = LobjDeudaExtraordinaria;
            dgdDeudaMensualidad.DataSource = LobjDeudaMensualidad;
            dgdDeudaPago.DataSource = LobjDeudaPagada;

            double LdblMontoTotal = 0;

            foreach(DataRow LobjRegistro in LobjDeudaMensualidad.Rows)
            {
                LdblMontoTotal = LdblMontoTotal + Convert.ToDouble(LobjRegistro[3].ToString());
            }

            foreach(DataRow LobjRegistro in LobjDeudaExtraordinaria.Rows)
            {
                LdblMontoTotal = LdblMontoTotal + Convert.ToDouble(LobjRegistro[3].ToString());
            }

            lblMontoTotal.Text = LdblMontoTotal.ToString();

            cmbReciboGenerado.Items.Clear();

            foreach(var LobjRegistro in LobjRecibosGenerados)
            {
                cmbReciboGenerado.Items.Add(LobjRegistro);
            }
        }

        private void dgdDeudaMensualidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgdDeudaMensualidad.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgdDeudaMensualidad_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            LdblSubTotalExtraordinario = 0;
            LdblTotalDeudaExtraordinario = 0;
            foreach (DataGridViewRow row in dgdDeudaExtraordinaria.Rows)
            {
                if (row.Cells[4].Value.Equals(true))
                {
                    LdblSubTotalExtraordinario = LdblSubTotalExtraordinario + Convert.ToDouble(row.Cells[3].Value);
                }
                else
                {
                    LdblTotalDeudaExtraordinario = LdblTotalDeudaExtraordinario + Convert.ToDouble(row.Cells[3].Value);
                }
            }

            LdblSubTotalMensualidad = 0;
            LdblTotalDeudaMensualidad = 0;
            foreach (DataGridViewRow row in dgdDeudaMensualidad.Rows)
            {
                if (row.Cells[4].Value.Equals(true))
                {
                    LdblSubTotalMensualidad = LdblSubTotalMensualidad + Convert.ToDouble(row.Cells[3].Value);
                }
                else
                {
                    LdblTotalDeudaMensualidad = LdblTotalDeudaMensualidad + Convert.ToDouble(row.Cells[3].Value);
                }
            }
            lblSubTotal.Text = (LdblSubTotalExtraordinario + LdblSubTotalMensualidad).ToString();
            double LdblSub = (LdblTotalDeudaMensualidad + LdblTotalDeudaExtraordinario);
            lblMontoTotal.Text = (LdblSub).ToString();
        }

        private void dgdDeudaExtraordinaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgdDeudaExtraordinaria.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgdDeudaExtraordinaria_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            LdblSubTotalExtraordinario = 0;
            LdblTotalDeudaExtraordinario = 0;
            foreach (DataGridViewRow row in dgdDeudaExtraordinaria.Rows)
            {
                if (row.Cells[4].Value.Equals(true))
                {
                    LdblSubTotalExtraordinario = LdblSubTotalExtraordinario + Convert.ToDouble(row.Cells[3].Value);
                }
                else
                {
                    LdblTotalDeudaExtraordinario = LdblTotalDeudaExtraordinario + Convert.ToDouble(row.Cells[3].Value);
                }
            }

            LdblSubTotalMensualidad = 0;
            LdblTotalDeudaMensualidad = 0;
            foreach (DataGridViewRow row in dgdDeudaMensualidad.Rows)
            {
                if (row.Cells[4].Value.Equals(true))
                {
                    LdblSubTotalMensualidad = LdblSubTotalMensualidad + Convert.ToDouble(row.Cells[3].Value);
                }
                else
                {
                    LdblTotalDeudaMensualidad = LdblTotalDeudaMensualidad + Convert.ToDouble(row.Cells[3].Value);
                }
            }

            lblSubTotal.Text = (LdblSubTotalExtraordinario + LdblSubTotalMensualidad).ToString();
            double LdblSub = (LdblTotalDeudaMensualidad + LdblTotalDeudaExtraordinario);
            lblMontoTotal.Text = (LdblSub).ToString();
        }

        private void btnGenerarRecibo_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(lblSubTotal.Text) != 0)
            {
                if (MessageBox.Show("¿Está seguro de generar el recibo?", "Generar Recibo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gstClsRecibo LobjRecibo = new gstClsRecibo();
                    gstClsRecibo LobjRec;
                    List<gstClsRecibo> LobjReciboDetalle = new List<gstClsRecibo>();
                    gstClsReciboNegocio LobjReciboNegocio = new gstClsReciboNegocio();

                    string LstrUltimoCodigo = LobjReciboNegocio.mtdObtenerUltimoCodigoRecibo();

                    LobjRecibo.RECcodigo = DateTime.Now.Year.ToString().Substring(2,2) + ((Convert.ToInt32(LstrUltimoCodigo) + 1).ToString("00000000"));
                    LobjRecibo.ALMcodigo = Convert.ToInt32(lblCodigoAlumno.Text);
                    LobjRecibo.USUcodigo = 1;
                    LobjRecibo.RECfecha = DateTime.Now.ToString("dd/MM/yyyy");
                    LobjRecibo.RECtotal = Convert.ToDouble(lblSubTotal.Text);

                    foreach (DataGridViewRow row in dgdDeudaExtraordinaria.Rows)
                    {
                        if (row.Cells[4].Value.Equals(true))
                        {
                            LobjRec = new gstClsRecibo();
                            LobjRec.DEUcodigo = Convert.ToInt32(row.Cells[0].Value);
                            LobjRec.DPGsubtotal = Convert.ToInt32(row.Cells[3].Value);
                            LobjReciboDetalle.Add(LobjRec);
                        }
                    }

                    foreach (DataGridViewRow row in dgdDeudaMensualidad.Rows)
                    {
                        if (row.Cells[4].Value.Equals(true))
                        {
                            LobjRec = new gstClsRecibo();
                            LobjRec.DEUcodigo = Convert.ToInt32(row.Cells[0].Value);
                            LobjRec.DPGsubtotal = Convert.ToInt32(row.Cells[3].Value);
                            LobjReciboDetalle.Add(LobjRec);
                        }
                    }

                    if (LobjReciboNegocio.mtdGuardarRecibo(LobjRecibo, LobjReciboDetalle) == 1)
                    {
                        mtdRecargarTablas();
                        gstFrmRecibo frmRecibo = new gstFrmRecibo();
                        frmRecibo.GstrCodigoReciboAlumno = LobjRecibo.RECcodigo;
                        frmRecibo.GintCodigoAlumno = LobjRecibo.ALMcodigo;
                        frmRecibo.MdiParent = this.MdiParent;
                        frmRecibo.StartPosition = FormStartPosition.CenterScreen;
                        frmRecibo.Show();
                    }
                    else
                    {
                        MessageBox.Show("A ocurrido un error al generar el recibo.", "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado una deuda.", "INCOMPLETO");
            }
        }

        public void mtdRecargarTablas()
        {
            lblSubTotal.Text = "0";

            int LintCodigoAlumno = Convert.ToInt32(dgdAlumno.CurrentRow.Cells[0].Value.ToString());

            string LstrNombreApellidoAlumno = dgdAlumno.CurrentRow.Cells[1].Value.ToString().ToUpper() + ", " + dgdAlumno.CurrentRow.Cells[2].Value.ToString();

            lblCodigoAlumno.Text = LintCodigoAlumno.ToString();
            lblNombreApellidoAlumno.Text = LstrNombreApellidoAlumno;

            gstClsReciboNegocio LobjRecibo = new gstClsReciboNegocio();

            var LobjDeudaExtraordinaria = LobjRecibo.mtdListarDeudaExtraordinaria(LintCodigoAlumno);
            var LobjDeudaMensualidad = LobjRecibo.mtdListarDeudaMensualidad(LintCodigoAlumno);
            var LobjDeudaPagada = LobjRecibo.mtdListarDeudaPagada(LintCodigoAlumno);
            var LobjRecibosGenerados = LobjRecibo.mtdListarRecibos(LintCodigoAlumno);

            dgdDeudaExtraordinaria.DataSource = LobjDeudaExtraordinaria;
            dgdDeudaMensualidad.DataSource = LobjDeudaMensualidad;
            dgdDeudaPago.DataSource = LobjDeudaPagada;

            double LdblMontoTotal = 0;

            foreach (DataRow LobjRegistro in LobjDeudaMensualidad.Rows)
            {
                LdblMontoTotal = LdblMontoTotal + Convert.ToDouble(LobjRegistro[3].ToString());
            }

            foreach (DataRow LobjRegistro in LobjDeudaExtraordinaria.Rows)
            {
                LdblMontoTotal = LdblMontoTotal + Convert.ToDouble(LobjRegistro[3].ToString());
            }

            lblMontoTotal.Text = LdblMontoTotal.ToString();

            cmbReciboGenerado.Text = "RECIBOS GENERADOS";
            cmbReciboGenerado.Items.Clear();

            foreach (var LobjRegistro in LobjRecibosGenerados)
            {
                cmbReciboGenerado.Items.Add(LobjRegistro);
            }
        }

        private void btnVisualizarImprimir_Click(object sender, EventArgs e)
        {
            if (cmbReciboGenerado.Text != "RECIBOS GENERADOS" && lblCodigoAlumno.Text != "")
            {
                gstFrmRecibo frmRecibo = new gstFrmRecibo();
                string[] LstrCodigoRecibo = cmbReciboGenerado.Text.Split('-');
                frmRecibo.GstrCodigoReciboAlumno = LstrCodigoRecibo[0];
                frmRecibo.GintCodigoAlumno = Convert.ToInt32(lblCodigoAlumno.Text);
                frmRecibo.MdiParent = this.MdiParent;
                frmRecibo.StartPosition = FormStartPosition.CenterScreen;
                frmRecibo.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un recibo.", "SELECCIONAR ALUMNO");
            }
        }

        private const int EM_SETCUEBANNER = 0x1501;
        private void gstFrmGenerarFormatoRecibo_Load(object sender, EventArgs e)
        {
            cmbFiltrarDeudaPago.Items.Clear();
            cmbFiltrarDeudaPago.Items.Add("APAFA");
            cmbFiltrarDeudaPago.Items.Add("Mensualidad");
            cmbFiltrarDeudaPago.Items.Add("Cuota Extraordinaria");

            cmbTareas.Items.Clear();
            cmbTareas.Items.Add("Agregar Cuotas Extraordinarias");
            cmbTareas.Items.Add("Exonerar Cuotas Extraordinarias");
            cmbTareas.Items.Add("Fraccionar Cuota de APAFA");
        }

        private void btnEliminarRecibo_Click(object sender, EventArgs e)
        {
            if(lblCodigoAlumno.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un alumno.","ELIMINAR RECIBO");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar el último recibo generado?", "Eliminar Recibo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gstClsReciboNegocio LobjRecibo = new gstClsReciboNegocio();
                    if (LobjRecibo.mtdEliminarRecibo(Convert.ToInt32(lblCodigoAlumno.Text)) == 1)
                    {
                        MessageBox.Show("Recibo eliminado con éxito.", "ELIMINAR RECIBO");
                        mtdRecargarTablas();
                    }
                    else
                    {
                        MessageBox.Show("A ocurrido un error al eliminar el recibo.", "ELIMINAR RECIBO");
                    }
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, EventArgs e)
        {
            gstClsReciboNegocio LobjRecibo = new gstClsReciboNegocio();

            var LobjAlumno = LobjRecibo.mtdBuscarAlumno(txtBuscar.text);

            dgdAlumno.DataSource = LobjAlumno;
        }
    }
}
