namespace gstPresentacion.gstCuota
{
    partial class gstFrmGestionarConcepto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmGestionarConcepto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGestionarConcepto = new System.Windows.Forms.Panel();
            this.btnCerrarFormulario = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtDescripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblDescripcion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMonto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTipo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgdConcepto = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtMonto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pnlGestionarConcepto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdConcepto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGestionarConcepto
            // 
            this.pnlGestionarConcepto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlGestionarConcepto.Controls.Add(this.btnCerrarFormulario);
            this.pnlGestionarConcepto.Controls.Add(this.lblTitulo);
            this.pnlGestionarConcepto.Controls.Add(this.btnCerrar);
            this.pnlGestionarConcepto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestionarConcepto.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionarConcepto.Name = "pnlGestionarConcepto";
            this.pnlGestionarConcepto.Size = new System.Drawing.Size(672, 32);
            this.pnlGestionarConcepto.TabIndex = 32;
            this.pnlGestionarConcepto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGestionarConcepto_Paint);
            this.pnlGestionarConcepto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGestionarConcepto_MouseDown);
            this.pnlGestionarConcepto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGestionarConcepto_MouseMove);
            this.pnlGestionarConcepto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGestionarConcepto_MouseUp);
            // 
            // btnCerrarFormulario
            // 
            this.btnCerrarFormulario.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFormulario.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarFormulario.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarFormulario.ImageActive = null;
            this.btnCerrarFormulario.Location = new System.Drawing.Point(636, 0);
            this.btnCerrarFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarFormulario.Name = "btnCerrarFormulario";
            this.btnCerrarFormulario.Size = new System.Drawing.Size(36, 29);
            this.btnCerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarFormulario.TabIndex = 32;
            this.btnCerrarFormulario.TabStop = false;
            this.btnCerrarFormulario.Zoom = 10;
            this.btnCerrarFormulario.Click += new System.EventHandler(this.btnCerrarFormulario_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(75, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 16);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "CONCEPTO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(1031, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescripcion.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDescripcion.Location = new System.Drawing.Point(48, 91);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(266, 20);
            this.txtDescripcion.TabIndex = 41;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(45, 66);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 13);
            this.lblDescripcion.TabIndex = 42;
            this.lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(45, 132);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(47, 13);
            this.lblMonto.TabIndex = 44;
            this.lblMonto.Text = "MONTO";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(45, 199);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 13);
            this.lblTipo.TabIndex = 45;
            this.lblTipo.Text = "TIPO";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(48, 223);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(216, 21);
            this.cmbTipo.TabIndex = 46;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Silver;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(234, 297);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(284, 32);
            this.txtBuscar.TabIndex = 47;
            this.txtBuscar.text = "BUSCAR POR DESCRIPCIÓN...";
            this.txtBuscar.KeyUp += new System.EventHandler(this.txtBuscar_KeyUp);
            // 
            // dgdConcepto
            // 
            this.dgdConcepto.AllowUserToAddRows = false;
            this.dgdConcepto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgdConcepto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgdConcepto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgdConcepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdConcepto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdConcepto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgdConcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdConcepto.DoubleBuffered = true;
            this.dgdConcepto.EnableHeadersVisualStyles = false;
            this.dgdConcepto.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdConcepto.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgdConcepto.Location = new System.Drawing.Point(48, 335);
            this.dgdConcepto.Name = "dgdConcepto";
            this.dgdConcepto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdConcepto.Size = new System.Drawing.Size(470, 202);
            this.dgdConcepto.TabIndex = 48;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(397, 156);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 23);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(534, 356);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 23);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMonto.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMonto.Location = new System.Drawing.Point(48, 159);
            this.txtMonto.MaxLength = 250;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(91, 20);
            this.txtMonto.TabIndex = 51;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // gstFrmGestionarConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 559);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgdConcepto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.pnlGestionarConcepto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmGestionarConcepto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gstFrmGestionarConcepto";
            this.Load += new System.EventHandler(this.gstFrmGestionarConcepto_Load);
            this.pnlGestionarConcepto.ResumeLayout(false);
            this.pnlGestionarConcepto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdConcepto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGestionarConcepto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarFormulario;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDescripcion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescripcion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMonto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgdConcepto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMonto;
    }
}