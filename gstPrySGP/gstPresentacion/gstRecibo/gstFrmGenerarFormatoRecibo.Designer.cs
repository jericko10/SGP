namespace gstPresentacion
{
    partial class gstFrmGenerarFormatoRecibo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmGenerarFormatoRecibo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbTareas = new System.Windows.Forms.ComboBox();
            this.pnlGenerarFormatoRecibo = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlReciboGenerado = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnEliminarRecibo = new System.Windows.Forms.Button();
            this.btnVisualizarImprimir = new System.Windows.Forms.Button();
            this.lblRecibo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbReciboGenerado = new System.Windows.Forms.ComboBox();
            this.pnlDeudaPendiente = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblNombreApellidoAlumno = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCodigoAlumno = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombres = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCodigo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.lblMontoTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMontoTotalSeleccionado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSubTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDeudaPendienteTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCuotaExtraordinaria = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgdDeudaExtraordinaria = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblDeudaPendiente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMensualidad = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgdDeudaMensualidad = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlDeudaPagada = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblDeudaPagada = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbFiltrarDeudaPago = new System.Windows.Forms.ComboBox();
            this.dgdDeudaPago = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlAlumno = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgdAlumno = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.pnlGenerarFormatoRecibo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlReciboGenerado.SuspendLayout();
            this.pnlDeudaPendiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeudaExtraordinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeudaMensualidad)).BeginInit();
            this.pnlDeudaPagada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeudaPago)).BeginInit();
            this.pnlAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(32, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 16);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "GENERAR FORMATO RECIBO";
            // 
            // cmbTareas
            // 
            this.cmbTareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTareas.FormattingEnabled = true;
            this.cmbTareas.Location = new System.Drawing.Point(12, 596);
            this.cmbTareas.Name = "cmbTareas";
            this.cmbTareas.Size = new System.Drawing.Size(217, 21);
            this.cmbTareas.TabIndex = 34;
            // 
            // pnlGenerarFormatoRecibo
            // 
            this.pnlGenerarFormatoRecibo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlGenerarFormatoRecibo.Controls.Add(this.btnCerrar);
            this.pnlGenerarFormatoRecibo.Controls.Add(this.lblTitulo);
            this.pnlGenerarFormatoRecibo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGenerarFormatoRecibo.Location = new System.Drawing.Point(0, 0);
            this.pnlGenerarFormatoRecibo.Name = "pnlGenerarFormatoRecibo";
            this.pnlGenerarFormatoRecibo.Size = new System.Drawing.Size(1022, 32);
            this.pnlGenerarFormatoRecibo.TabIndex = 35;
            this.pnlGenerarFormatoRecibo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlGenerarFormatoRecibo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGenerarFormatoRecibo_MouseDown);
            this.pnlGenerarFormatoRecibo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGenerarFormatoRecibo_MouseMove);
            this.pnlGenerarFormatoRecibo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGenerarFormatoRecibo_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(986, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlReciboGenerado
            // 
            this.pnlReciboGenerado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlReciboGenerado.BackgroundImage")));
            this.pnlReciboGenerado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReciboGenerado.Controls.Add(this.btnEliminarRecibo);
            this.pnlReciboGenerado.Controls.Add(this.btnVisualizarImprimir);
            this.pnlReciboGenerado.Controls.Add(this.lblRecibo);
            this.pnlReciboGenerado.Controls.Add(this.cmbReciboGenerado);
            this.pnlReciboGenerado.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlReciboGenerado.GradientBottomRight = System.Drawing.Color.White;
            this.pnlReciboGenerado.GradientTopLeft = System.Drawing.Color.White;
            this.pnlReciboGenerado.GradientTopRight = System.Drawing.Color.White;
            this.pnlReciboGenerado.Location = new System.Drawing.Point(459, 589);
            this.pnlReciboGenerado.Name = "pnlReciboGenerado";
            this.pnlReciboGenerado.Quality = 10;
            this.pnlReciboGenerado.Size = new System.Drawing.Size(523, 105);
            this.pnlReciboGenerado.TabIndex = 34;
            // 
            // btnEliminarRecibo
            // 
            this.btnEliminarRecibo.Location = new System.Drawing.Point(329, 70);
            this.btnEliminarRecibo.Name = "btnEliminarRecibo";
            this.btnEliminarRecibo.Size = new System.Drawing.Size(159, 23);
            this.btnEliminarRecibo.TabIndex = 45;
            this.btnEliminarRecibo.Text = "ELIMINAR";
            this.btnEliminarRecibo.UseVisualStyleBackColor = true;
            this.btnEliminarRecibo.Click += new System.EventHandler(this.btnEliminarRecibo_Click);
            // 
            // btnVisualizarImprimir
            // 
            this.btnVisualizarImprimir.Location = new System.Drawing.Point(329, 41);
            this.btnVisualizarImprimir.Name = "btnVisualizarImprimir";
            this.btnVisualizarImprimir.Size = new System.Drawing.Size(159, 23);
            this.btnVisualizarImprimir.TabIndex = 44;
            this.btnVisualizarImprimir.Text = "VISUALIZAR/IMPRIMIR";
            this.btnVisualizarImprimir.UseVisualStyleBackColor = true;
            this.btnVisualizarImprimir.Click += new System.EventHandler(this.btnVisualizarImprimir_Click);
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibo.Location = new System.Drawing.Point(229, 12);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(104, 16);
            this.lblRecibo.TabIndex = 33;
            this.lblRecibo.Text = "MIS RECIBOS";
            // 
            // cmbReciboGenerado
            // 
            this.cmbReciboGenerado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReciboGenerado.FormattingEnabled = true;
            this.cmbReciboGenerado.Location = new System.Drawing.Point(21, 43);
            this.cmbReciboGenerado.Name = "cmbReciboGenerado";
            this.cmbReciboGenerado.Size = new System.Drawing.Size(216, 21);
            this.cmbReciboGenerado.TabIndex = 28;
            // 
            // pnlDeudaPendiente
            // 
            this.pnlDeudaPendiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDeudaPendiente.BackgroundImage")));
            this.pnlDeudaPendiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDeudaPendiente.Controls.Add(this.lblNombreApellidoAlumno);
            this.pnlDeudaPendiente.Controls.Add(this.lblCodigoAlumno);
            this.pnlDeudaPendiente.Controls.Add(this.lblNombres);
            this.pnlDeudaPendiente.Controls.Add(this.lblCodigo);
            this.pnlDeudaPendiente.Controls.Add(this.btnGenerarRecibo);
            this.pnlDeudaPendiente.Controls.Add(this.lblMontoTotal);
            this.pnlDeudaPendiente.Controls.Add(this.lblMontoTotalSeleccionado);
            this.pnlDeudaPendiente.Controls.Add(this.lblSubTotal);
            this.pnlDeudaPendiente.Controls.Add(this.lblDeudaPendienteTotal);
            this.pnlDeudaPendiente.Controls.Add(this.lblCuotaExtraordinaria);
            this.pnlDeudaPendiente.Controls.Add(this.dgdDeudaExtraordinaria);
            this.pnlDeudaPendiente.Controls.Add(this.lblDeudaPendiente);
            this.pnlDeudaPendiente.Controls.Add(this.lblMensualidad);
            this.pnlDeudaPendiente.Controls.Add(this.dgdDeudaMensualidad);
            this.pnlDeudaPendiente.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlDeudaPendiente.GradientBottomRight = System.Drawing.Color.White;
            this.pnlDeudaPendiente.GradientTopLeft = System.Drawing.Color.White;
            this.pnlDeudaPendiente.GradientTopRight = System.Drawing.Color.White;
            this.pnlDeudaPendiente.Location = new System.Drawing.Point(459, 102);
            this.pnlDeudaPendiente.Name = "pnlDeudaPendiente";
            this.pnlDeudaPendiente.Quality = 10;
            this.pnlDeudaPendiente.Size = new System.Drawing.Size(538, 460);
            this.pnlDeudaPendiente.TabIndex = 32;
            // 
            // lblNombreApellidoAlumno
            // 
            this.lblNombreApellidoAlumno.AutoSize = true;
            this.lblNombreApellidoAlumno.Location = new System.Drawing.Point(129, 44);
            this.lblNombreApellidoAlumno.Name = "lblNombreApellidoAlumno";
            this.lblNombreApellidoAlumno.Size = new System.Drawing.Size(0, 13);
            this.lblNombreApellidoAlumno.TabIndex = 46;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(122, 12);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(0, 13);
            this.lblCodigoAlumno.TabIndex = 45;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(18, 44);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(105, 13);
            this.lblNombres.TabIndex = 44;
            this.lblNombres.Text = "Apellidos y Nombres:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 13);
            this.lblCodigo.TabIndex = 39;
            this.lblCodigo.Text = "Código del Alumno:";
            // 
            // btnGenerarRecibo
            // 
            this.btnGenerarRecibo.Location = new System.Drawing.Point(222, 420);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(121, 23);
            this.btnGenerarRecibo.TabIndex = 43;
            this.btnGenerarRecibo.Text = "GENERAR RECIBO";
            this.btnGenerarRecibo.UseVisualStyleBackColor = true;
            this.btnGenerarRecibo.Click += new System.EventHandler(this.btnGenerarRecibo_Click);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(195, 382);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(13, 13);
            this.lblMontoTotal.TabIndex = 42;
            this.lblMontoTotal.Text = "0";
            // 
            // lblMontoTotalSeleccionado
            // 
            this.lblMontoTotalSeleccionado.AutoSize = true;
            this.lblMontoTotalSeleccionado.Location = new System.Drawing.Point(245, 382);
            this.lblMontoTotalSeleccionado.Name = "lblMontoTotalSeleccionado";
            this.lblMontoTotalSeleccionado.Size = new System.Drawing.Size(189, 13);
            this.lblMontoTotalSeleccionado.TabIndex = 41;
            this.lblMontoTotalSeleccionado.Text = "MONTO TOTAL SELECCIONADO: S/";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(451, 382);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(13, 13);
            this.lblSubTotal.TabIndex = 40;
            this.lblSubTotal.Text = "0";
            // 
            // lblDeudaPendienteTotal
            // 
            this.lblDeudaPendienteTotal.AutoSize = true;
            this.lblDeudaPendienteTotal.Location = new System.Drawing.Point(9, 382);
            this.lblDeudaPendienteTotal.Name = "lblDeudaPendienteTotal";
            this.lblDeudaPendienteTotal.Size = new System.Drawing.Size(166, 13);
            this.lblDeudaPendienteTotal.TabIndex = 38;
            this.lblDeudaPendienteTotal.Text = "DEUDA PENDIENTE TOTAL: S/";
            // 
            // lblCuotaExtraordinaria
            // 
            this.lblCuotaExtraordinaria.AutoSize = true;
            this.lblCuotaExtraordinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaExtraordinaria.Location = new System.Drawing.Point(20, 220);
            this.lblCuotaExtraordinaria.Name = "lblCuotaExtraordinaria";
            this.lblCuotaExtraordinaria.Size = new System.Drawing.Size(217, 16);
            this.lblCuotaExtraordinaria.TabIndex = 37;
            this.lblCuotaExtraordinaria.Text = "CUOTAS EXTRAORDINARIAS";
            // 
            // dgdDeudaExtraordinaria
            // 
            this.dgdDeudaExtraordinaria.AllowUserToAddRows = false;
            this.dgdDeudaExtraordinaria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgdDeudaExtraordinaria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdDeudaExtraordinaria.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgdDeudaExtraordinaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdDeudaExtraordinaria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdDeudaExtraordinaria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdDeudaExtraordinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDeudaExtraordinaria.DoubleBuffered = true;
            this.dgdDeudaExtraordinaria.EnableHeadersVisualStyles = false;
            this.dgdDeudaExtraordinaria.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdDeudaExtraordinaria.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgdDeudaExtraordinaria.Location = new System.Drawing.Point(12, 239);
            this.dgdDeudaExtraordinaria.Name = "dgdDeudaExtraordinaria";
            this.dgdDeudaExtraordinaria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdDeudaExtraordinaria.Size = new System.Drawing.Size(476, 118);
            this.dgdDeudaExtraordinaria.TabIndex = 36;
            this.dgdDeudaExtraordinaria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdDeudaExtraordinaria_CellContentClick);
            this.dgdDeudaExtraordinaria.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdDeudaExtraordinaria_CellValueChanged);
            // 
            // lblDeudaPendiente
            // 
            this.lblDeudaPendiente.AutoSize = true;
            this.lblDeudaPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeudaPendiente.Location = new System.Drawing.Point(262, 12);
            this.lblDeudaPendiente.Name = "lblDeudaPendiente";
            this.lblDeudaPendiente.Size = new System.Drawing.Size(172, 16);
            this.lblDeudaPendiente.TabIndex = 35;
            this.lblDeudaPendiente.Text = "DEUDAS PENDIENTES";
            // 
            // lblMensualidad
            // 
            this.lblMensualidad.AutoSize = true;
            this.lblMensualidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensualidad.Location = new System.Drawing.Point(20, 68);
            this.lblMensualidad.Name = "lblMensualidad";
            this.lblMensualidad.Size = new System.Drawing.Size(136, 16);
            this.lblMensualidad.TabIndex = 34;
            this.lblMensualidad.Text = "MENSUALIDADES";
            // 
            // dgdDeudaMensualidad
            // 
            this.dgdDeudaMensualidad.AllowUserToAddRows = false;
            this.dgdDeudaMensualidad.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgdDeudaMensualidad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdDeudaMensualidad.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgdDeudaMensualidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdDeudaMensualidad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdDeudaMensualidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgdDeudaMensualidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDeudaMensualidad.DoubleBuffered = true;
            this.dgdDeudaMensualidad.EnableHeadersVisualStyles = false;
            this.dgdDeudaMensualidad.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdDeudaMensualidad.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgdDeudaMensualidad.Location = new System.Drawing.Point(12, 87);
            this.dgdDeudaMensualidad.Name = "dgdDeudaMensualidad";
            this.dgdDeudaMensualidad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdDeudaMensualidad.Size = new System.Drawing.Size(476, 118);
            this.dgdDeudaMensualidad.TabIndex = 30;
            this.dgdDeudaMensualidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdDeudaMensualidad_CellContentClick);
            this.dgdDeudaMensualidad.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdDeudaMensualidad_CellValueChanged);
            // 
            // pnlDeudaPagada
            // 
            this.pnlDeudaPagada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDeudaPagada.BackgroundImage")));
            this.pnlDeudaPagada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDeudaPagada.Controls.Add(this.lblDeudaPagada);
            this.pnlDeudaPagada.Controls.Add(this.cmbFiltrarDeudaPago);
            this.pnlDeudaPagada.Controls.Add(this.dgdDeudaPago);
            this.pnlDeudaPagada.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlDeudaPagada.GradientBottomRight = System.Drawing.Color.White;
            this.pnlDeudaPagada.GradientTopLeft = System.Drawing.Color.White;
            this.pnlDeudaPagada.GradientTopRight = System.Drawing.Color.White;
            this.pnlDeudaPagada.Location = new System.Drawing.Point(12, 341);
            this.pnlDeudaPagada.Name = "pnlDeudaPagada";
            this.pnlDeudaPagada.Quality = 10;
            this.pnlDeudaPagada.Size = new System.Drawing.Size(400, 221);
            this.pnlDeudaPagada.TabIndex = 32;
            // 
            // lblDeudaPagada
            // 
            this.lblDeudaPagada.AutoSize = true;
            this.lblDeudaPagada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeudaPagada.Location = new System.Drawing.Point(118, 15);
            this.lblDeudaPagada.Name = "lblDeudaPagada";
            this.lblDeudaPagada.Size = new System.Drawing.Size(147, 16);
            this.lblDeudaPagada.TabIndex = 33;
            this.lblDeudaPagada.Text = "DEUDAS PAGADAS";
            // 
            // cmbFiltrarDeudaPago
            // 
            this.cmbFiltrarDeudaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarDeudaPago.FormattingEnabled = true;
            this.cmbFiltrarDeudaPago.Location = new System.Drawing.Point(23, 60);
            this.cmbFiltrarDeudaPago.Name = "cmbFiltrarDeudaPago";
            this.cmbFiltrarDeudaPago.Size = new System.Drawing.Size(132, 21);
            this.cmbFiltrarDeudaPago.TabIndex = 28;
            this.cmbFiltrarDeudaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarDeudaPago_SelectedIndexChanged);
            // 
            // dgdDeudaPago
            // 
            this.dgdDeudaPago.AllowUserToAddRows = false;
            this.dgdDeudaPago.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgdDeudaPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgdDeudaPago.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgdDeudaPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdDeudaPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdDeudaPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgdDeudaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDeudaPago.DoubleBuffered = true;
            this.dgdDeudaPago.EnableHeadersVisualStyles = false;
            this.dgdDeudaPago.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdDeudaPago.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgdDeudaPago.Location = new System.Drawing.Point(23, 87);
            this.dgdDeudaPago.Name = "dgdDeudaPago";
            this.dgdDeudaPago.ReadOnly = true;
            this.dgdDeudaPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdDeudaPago.Size = new System.Drawing.Size(345, 79);
            this.dgdDeudaPago.TabIndex = 30;
            // 
            // pnlAlumno
            // 
            this.pnlAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAlumno.BackgroundImage")));
            this.pnlAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAlumno.Controls.Add(this.dgdAlumno);
            this.pnlAlumno.Controls.Add(this.txtBuscar);
            this.pnlAlumno.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlAlumno.GradientBottomRight = System.Drawing.Color.White;
            this.pnlAlumno.GradientTopLeft = System.Drawing.Color.White;
            this.pnlAlumno.GradientTopRight = System.Drawing.Color.White;
            this.pnlAlumno.Location = new System.Drawing.Point(12, 102);
            this.pnlAlumno.Name = "pnlAlumno";
            this.pnlAlumno.Quality = 10;
            this.pnlAlumno.Size = new System.Drawing.Size(400, 205);
            this.pnlAlumno.TabIndex = 31;
            // 
            // dgdAlumno
            // 
            this.dgdAlumno.AllowUserToAddRows = false;
            this.dgdAlumno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgdAlumno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgdAlumno.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgdAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdAlumno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgdAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAlumno.DoubleBuffered = true;
            this.dgdAlumno.EnableHeadersVisualStyles = false;
            this.dgdAlumno.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdAlumno.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgdAlumno.Location = new System.Drawing.Point(23, 87);
            this.dgdAlumno.Name = "dgdAlumno";
            this.dgdAlumno.ReadOnly = true;
            this.dgdAlumno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdAlumno.Size = new System.Drawing.Size(345, 79);
            this.dgdAlumno.TabIndex = 30;
            this.dgdAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdAlumno_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Silver;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(23, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(284, 32);
            this.txtBuscar.TabIndex = 29;
            this.txtBuscar.text = "BUSCAR POR APELLIDOS O DNI";
            this.txtBuscar.KeyUp += new System.EventHandler(this.txtBuscar_KeyUp);
            // 
            // gstFrmGenerarFormatoRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 722);
            this.Controls.Add(this.pnlGenerarFormatoRecibo);
            this.Controls.Add(this.pnlReciboGenerado);
            this.Controls.Add(this.pnlDeudaPendiente);
            this.Controls.Add(this.cmbTareas);
            this.Controls.Add(this.pnlDeudaPagada);
            this.Controls.Add(this.pnlAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmGenerarFormatoRecibo";
            this.Text = "gstFrmDeudasPendientes";
            this.Load += new System.EventHandler(this.gstFrmGenerarFormatoRecibo_Load);
            this.pnlGenerarFormatoRecibo.ResumeLayout(false);
            this.pnlGenerarFormatoRecibo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlReciboGenerado.ResumeLayout(false);
            this.pnlReciboGenerado.PerformLayout();
            this.pnlDeudaPendiente.ResumeLayout(false);
            this.pnlDeudaPendiente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeudaExtraordinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeudaMensualidad)).EndInit();
            this.pnlDeudaPagada.ResumeLayout(false);
            this.pnlDeudaPagada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeudaPago)).EndInit();
            this.pnlAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgdAlumno;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private System.Windows.Forms.ComboBox cmbFiltrarDeudaPago;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlReciboGenerado;
        private System.Windows.Forms.Button btnVisualizarImprimir;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRecibo;
        private System.Windows.Forms.ComboBox cmbReciboGenerado;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlDeudaPendiente;
        private System.Windows.Forms.Button btnGenerarRecibo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMontoTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMontoTotalSeleccionado;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSubTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeudaPendienteTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCuotaExtraordinaria;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgdDeudaExtraordinaria;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeudaPendiente;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMensualidad;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgdDeudaMensualidad;
        private System.Windows.Forms.ComboBox cmbTareas;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlDeudaPagada;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDeudaPagada;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgdDeudaPago;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlAlumno;
        private System.Windows.Forms.Panel pnlGenerarFormatoRecibo;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Button btnEliminarRecibo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombreApellidoAlumno;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCodigoAlumno;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombres;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCodigo;
    }
}