using gstDatos;
using gstNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstPresentacion.gstCuota
{
    public partial class gstFrmGestionarConcepto : Form
    {
        public bool LblnModificar = false;
        public int LintCodigoConcepto = 0;
        public gstFrmGestionarConcepto()
        {
            InitializeComponent();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gstFrmGestionarConcepto_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }

        public void mtdCargarDatos()
        {
            gstClsConceptoNegocio LobjConcepto = new gstClsConceptoNegocio();

            var LobjDatosConcepto = LobjConcepto.mtdCargarDatos();

            dgdConcepto.DataSource = LobjDatosConcepto;

            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("APAFA");
            cmbTipo.Items.Add("Cuota Extraordinaria");
            cmbTipo.Items.Add("Mensualidad");

            cmbTipo.SelectedIndex = 0;

            txtDescripcion.Text = "";
            txtMonto.Text = "";
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyUp(object sender, EventArgs e)
        {
            gstClsConceptoNegocio LobjConcepto = new gstClsConceptoNegocio();

            var LobjBuscarConcepto = LobjConcepto.mtdBuscarConcepto(txtBuscar.text);

            dgdConcepto.DataSource = LobjBuscarConcepto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gstClsConcepto LobjConcepto = new gstClsConcepto();
            gstClsConceptoNegocio LobjConceptoNegocio = new gstClsConceptoNegocio();

            if (!LblnModificar)
            {
                LobjConcepto.CONdescripcion = txtDescripcion.Text;
                if (txtMonto.Text.Equals(""))
                {
                    txtMonto.Text = "0";
                }
                LobjConcepto.CONmonto = txtMonto.Text;
                LobjConcepto.CONtipo = cmbTipo.Text;

                if (MessageBox.Show("¿Está seguro de realizar la operación?", "GESTIONAR CONCEPTO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (LobjConcepto.CONdescripcion != "" && LobjConcepto.CONmonto != "0" && LobjConcepto.CONmonto != "" && LobjConcepto.CONtipo != "")
                    {
                        if (LobjConceptoNegocio.mtdGuardar(LobjConcepto) == 1)
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
                    else
                    {
                        MessageBox.Show("No se puede completar el proceso. Complete todos los espacios.", "INCOMPLETO");
                    }
                }
            }
            else
            {
                LobjConcepto.CONcodigo = LintCodigoConcepto;
                LobjConcepto.CONdescripcion = txtDescripcion.Text;
                if (txtMonto.Text.Equals(""))
                {
                    txtMonto.Text = "0";
                }
                LobjConcepto.CONmonto = txtMonto.Text;
                LobjConcepto.CONtipo = cmbTipo.Text;

                if (MessageBox.Show("¿Está seguro de realizar la operación?", "GESTIONAR CONCEPTO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (LobjConcepto.CONdescripcion != "" && LobjConcepto.CONmonto != "0" && LobjConcepto.CONmonto != "" && LobjConcepto.CONtipo != "")
                    {
                        if (LobjConceptoNegocio.mtdModificar(LobjConcepto) == 1)
                        {
                            MessageBox.Show("Operación realizada con éxito.", "CORRECTO");
                            mtdCargarDatos();
                            LblnModificar = false;
                        }
                        else
                        {
                            MessageBox.Show("Error en la operación.", "ERROR");
                            mtdCargarDatos();
                            LblnModificar = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede completar el proceso. Complete todos los espacios.", "INCOMPLETO");
                    }
                }
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMonto.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                       {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar =='.' || e.KeyChar == '\b')
                          {
                    e.Handled = false;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgdConcepto.CurrentRow.Cells[0].Value != null)
            {
                int LintCodigoConcepto = Convert.ToInt32(dgdConcepto.CurrentRow.Cells[0].Value);

                mtdLlenarCampos(LintCodigoConcepto);

                LblnModificar = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro,", "Gestionar Concepto");
            }
        }

        public void mtdLlenarCampos(int LintCodigo)
        {
            gstClsConcepto LobjConcepto = new gstClsConcepto();
            gstClsConceptoNegocio LobjConceptoNegocio = new gstClsConceptoNegocio();
            LobjConcepto = LobjConceptoNegocio.mtdObtenerConcepto(LintCodigo);

            LintCodigoConcepto = LintCodigo;
            txtDescripcion.Text = LobjConcepto.CONdescripcion;
            txtMonto.Text = LobjConcepto.CONmonto.Replace(",",".");
            cmbTipo.Text = LobjConcepto.CONtipo;
        }
    }
}
