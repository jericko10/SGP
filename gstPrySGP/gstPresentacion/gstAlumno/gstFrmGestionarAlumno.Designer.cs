namespace gstPre
{
    partial class gstFrmGestionarAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmGestionarAlumno));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblCodigo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDni = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPeriodo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblObservacion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblApellido = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCodigoGA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtObservacionGA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtApellidoGA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNombreGA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDniGA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPeriodoGA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbxNivelGA = new System.Windows.Forms.ComboBox();
            this.cbxEstadoGA = new System.Windows.Forms.ComboBox();
            this.cbxSeccionGA = new System.Windows.Forms.ComboBox();
            this.cbxGradoGA = new System.Windows.Forms.ComboBox();
            this.dgvAlumnoGA = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApellidosNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNivelGradoSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrarGA = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGenerarReciboGA = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarGA = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarCuotaApafaGA = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnGuardarGA = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoGA)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGA)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(62, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(62, 96);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(399, 47);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(56, 13);
            this.lblPeriodo.TabIndex = 6;
            this.lblPeriodo.Text = "PERIODO";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(62, 254);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(84, 13);
            this.lblObservacion.TabIndex = 7;
            this.lblObservacion.Text = "OBSERVACIÓN";
            this.lblObservacion.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(62, 196);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtCodigoGA
            // 
            this.txtCodigoGA.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtCodigoGA.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoGA.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtCodigoGA.BorderThickness = 3;
            this.txtCodigoGA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoGA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoGA.isPassword = false;
            this.txtCodigoGA.Location = new System.Drawing.Point(65, 64);
            this.txtCodigoGA.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoGA.Name = "txtCodigoGA";
            this.txtCodigoGA.Size = new System.Drawing.Size(132, 24);
            this.txtCodigoGA.TabIndex = 10;
            this.txtCodigoGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtObservacionGA
            // 
            this.txtObservacionGA.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtObservacionGA.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservacionGA.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtObservacionGA.BorderThickness = 3;
            this.txtObservacionGA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacionGA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtObservacionGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservacionGA.isPassword = false;
            this.txtObservacionGA.Location = new System.Drawing.Point(65, 271);
            this.txtObservacionGA.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacionGA.Name = "txtObservacionGA";
            this.txtObservacionGA.Size = new System.Drawing.Size(215, 102);
            this.txtObservacionGA.TabIndex = 11;
            this.txtObservacionGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtApellidoGA
            // 
            this.txtApellidoGA.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtApellidoGA.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoGA.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtApellidoGA.BorderThickness = 3;
            this.txtApellidoGA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoGA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellidoGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoGA.isPassword = false;
            this.txtApellidoGA.Location = new System.Drawing.Point(65, 213);
            this.txtApellidoGA.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoGA.Name = "txtApellidoGA";
            this.txtApellidoGA.Size = new System.Drawing.Size(215, 24);
            this.txtApellidoGA.TabIndex = 12;
            this.txtApellidoGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombreGA
            // 
            this.txtNombreGA.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtNombreGA.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreGA.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtNombreGA.BorderThickness = 3;
            this.txtNombreGA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreGA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreGA.isPassword = false;
            this.txtNombreGA.Location = new System.Drawing.Point(65, 161);
            this.txtNombreGA.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreGA.Name = "txtNombreGA";
            this.txtNombreGA.Size = new System.Drawing.Size(171, 24);
            this.txtNombreGA.TabIndex = 13;
            this.txtNombreGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDniGA
            // 
            this.txtDniGA.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtDniGA.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDniGA.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtDniGA.BorderThickness = 3;
            this.txtDniGA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDniGA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDniGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDniGA.isPassword = false;
            this.txtDniGA.Location = new System.Drawing.Point(65, 113);
            this.txtDniGA.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniGA.Name = "txtDniGA";
            this.txtDniGA.Size = new System.Drawing.Size(132, 24);
            this.txtDniGA.TabIndex = 14;
            this.txtDniGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPeriodoGA
            // 
            this.txtPeriodoGA.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txtPeriodoGA.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPeriodoGA.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txtPeriodoGA.BorderThickness = 3;
            this.txtPeriodoGA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPeriodoGA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPeriodoGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPeriodoGA.isPassword = false;
            this.txtPeriodoGA.Location = new System.Drawing.Point(402, 64);
            this.txtPeriodoGA.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodoGA.Name = "txtPeriodoGA";
            this.txtPeriodoGA.Size = new System.Drawing.Size(132, 24);
            this.txtPeriodoGA.TabIndex = 15;
            this.txtPeriodoGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbxNivelGA
            // 
            this.cbxNivelGA.FormattingEnabled = true;
            this.cbxNivelGA.Location = new System.Drawing.Point(402, 105);
            this.cbxNivelGA.Name = "cbxNivelGA";
            this.cbxNivelGA.Size = new System.Drawing.Size(132, 21);
            this.cbxNivelGA.TabIndex = 21;
            this.cbxNivelGA.Text = "NIVEL";
            // 
            // cbxEstadoGA
            // 
            this.cbxEstadoGA.FormattingEnabled = true;
            this.cbxEstadoGA.Location = new System.Drawing.Point(402, 213);
            this.cbxEstadoGA.Name = "cbxEstadoGA";
            this.cbxEstadoGA.Size = new System.Drawing.Size(132, 21);
            this.cbxEstadoGA.TabIndex = 22;
            this.cbxEstadoGA.Text = "ESTADO";
            // 
            // cbxSeccionGA
            // 
            this.cbxSeccionGA.FormattingEnabled = true;
            this.cbxSeccionGA.Location = new System.Drawing.Point(402, 176);
            this.cbxSeccionGA.Name = "cbxSeccionGA";
            this.cbxSeccionGA.Size = new System.Drawing.Size(132, 21);
            this.cbxSeccionGA.TabIndex = 23;
            this.cbxSeccionGA.Text = "SECCIÓN";
            // 
            // cbxGradoGA
            // 
            this.cbxGradoGA.FormattingEnabled = true;
            this.cbxGradoGA.Location = new System.Drawing.Point(402, 141);
            this.cbxGradoGA.Name = "cbxGradoGA";
            this.cbxGradoGA.Size = new System.Drawing.Size(132, 21);
            this.cbxGradoGA.TabIndex = 24;
            this.cbxGradoGA.Text = "GRADO";
            // 
            // dgvAlumnoGA
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlumnoGA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnoGA.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAlumnoGA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnoGA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnoGA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnoGA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoGA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnDni,
            this.clnApellidosNombres,
            this.clnPeriodo,
            this.clnNivelGradoSeccion});
            this.dgvAlumnoGA.DoubleBuffered = true;
            this.dgvAlumnoGA.EnableHeadersVisualStyles = false;
            this.dgvAlumnoGA.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAlumnoGA.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAlumnoGA.Location = new System.Drawing.Point(40, 400);
            this.dgvAlumnoGA.Name = "dgvAlumnoGA";
            this.dgvAlumnoGA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlumnoGA.Size = new System.Drawing.Size(542, 229);
            this.dgvAlumnoGA.TabIndex = 26;
            // 
            // clnCodigo
            // 
            this.clnCodigo.HeaderText = "CÓDIGO";
            this.clnCodigo.Name = "clnCodigo";
            // 
            // clnDni
            // 
            this.clnDni.HeaderText = "DNI";
            this.clnDni.Name = "clnDni";
            // 
            // clnApellidosNombres
            // 
            this.clnApellidosNombres.HeaderText = "APELLIDOS Y NOMBRES";
            this.clnApellidosNombres.Name = "clnApellidosNombres";
            // 
            // clnPeriodo
            // 
            this.clnPeriodo.HeaderText = "PERIODO";
            this.clnPeriodo.Name = "clnPeriodo";
            // 
            // clnNivelGradoSeccion
            // 
            this.clnNivelGradoSeccion.HeaderText = "NIVEL-GRADO-SECCIÓN";
            this.clnNivelGradoSeccion.Name = "clnNivelGradoSeccion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.btnCerrarGA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 32);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(75, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(163, 16);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "GESTIONAR ALUMNO";
            // 
            // btnCerrarGA
            // 
            this.btnCerrarGA.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarGA.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarGA.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarGA.ImageActive = null;
            this.btnCerrarGA.Location = new System.Drawing.Point(696, 0);
            this.btnCerrarGA.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarGA.Name = "btnCerrarGA";
            this.btnCerrarGA.Size = new System.Drawing.Size(36, 29);
            this.btnCerrarGA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarGA.TabIndex = 31;
            this.btnCerrarGA.TabStop = false;
            this.btnCerrarGA.Zoom = 10;
            this.btnCerrarGA.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGenerarReciboGA
            // 
            this.btnGenerarReciboGA.Activecolor = System.Drawing.Color.SkyBlue;
            this.btnGenerarReciboGA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerarReciboGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarReciboGA.BorderRadius = 0;
            this.btnGenerarReciboGA.ButtonText = "GENERAR RECIBO";
            this.btnGenerarReciboGA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReciboGA.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerarReciboGA.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerarReciboGA.Iconimage = global::gstPresentacion.Properties.Resources.add_documents__1_;
            this.btnGenerarReciboGA.Iconimage_right = null;
            this.btnGenerarReciboGA.Iconimage_right_Selected = null;
            this.btnGenerarReciboGA.Iconimage_Selected = null;
            this.btnGenerarReciboGA.IconMarginLeft = 0;
            this.btnGenerarReciboGA.IconMarginRight = 0;
            this.btnGenerarReciboGA.IconRightVisible = true;
            this.btnGenerarReciboGA.IconRightZoom = 0D;
            this.btnGenerarReciboGA.IconVisible = true;
            this.btnGenerarReciboGA.IconZoom = 60D;
            this.btnGenerarReciboGA.IsTab = false;
            this.btnGenerarReciboGA.Location = new System.Drawing.Point(588, 566);
            this.btnGenerarReciboGA.Name = "btnGenerarReciboGA";
            this.btnGenerarReciboGA.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnGenerarReciboGA.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerarReciboGA.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenerarReciboGA.selected = false;
            this.btnGenerarReciboGA.Size = new System.Drawing.Size(132, 50);
            this.btnGenerarReciboGA.TabIndex = 29;
            this.btnGenerarReciboGA.Text = "GENERAR RECIBO";
            this.btnGenerarReciboGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarReciboGA.Textcolor = System.Drawing.Color.White;
            this.btnGenerarReciboGA.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReciboGA.Click += new System.EventHandler(this.btnGenerarRecibo_Click);
            // 
            // btnModificarGA
            // 
            this.btnModificarGA.Activecolor = System.Drawing.Color.SkyBlue;
            this.btnModificarGA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarGA.BorderRadius = 0;
            this.btnModificarGA.ButtonText = "MODIFICAR";
            this.btnModificarGA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarGA.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificarGA.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarGA.Iconimage = global::gstPresentacion.Properties.Resources.edit;
            this.btnModificarGA.Iconimage_right = null;
            this.btnModificarGA.Iconimage_right_Selected = null;
            this.btnModificarGA.Iconimage_Selected = null;
            this.btnModificarGA.IconMarginLeft = 0;
            this.btnModificarGA.IconMarginRight = 0;
            this.btnModificarGA.IconRightVisible = true;
            this.btnModificarGA.IconRightZoom = 0D;
            this.btnModificarGA.IconVisible = true;
            this.btnModificarGA.IconZoom = 50D;
            this.btnModificarGA.IsTab = false;
            this.btnModificarGA.Location = new System.Drawing.Point(588, 435);
            this.btnModificarGA.Name = "btnModificarGA";
            this.btnModificarGA.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnModificarGA.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificarGA.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificarGA.selected = false;
            this.btnModificarGA.Size = new System.Drawing.Size(132, 42);
            this.btnModificarGA.TabIndex = 28;
            this.btnModificarGA.Text = "MODIFICAR";
            this.btnModificarGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarGA.Textcolor = System.Drawing.Color.White;
            this.btnModificarGA.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAgregarCuotaApafaGA
            // 
            this.btnAgregarCuotaApafaGA.Activecolor = System.Drawing.Color.SkyBlue;
            this.btnAgregarCuotaApafaGA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCuotaApafaGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCuotaApafaGA.BorderRadius = 0;
            this.btnAgregarCuotaApafaGA.ButtonText = "AGREGAR CUOTA DE APAFA";
            this.btnAgregarCuotaApafaGA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCuotaApafaGA.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarCuotaApafaGA.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCuotaApafaGA.Iconimage = global::gstPresentacion.Properties.Resources.give_money;
            this.btnAgregarCuotaApafaGA.Iconimage_right = null;
            this.btnAgregarCuotaApafaGA.Iconimage_right_Selected = null;
            this.btnAgregarCuotaApafaGA.Iconimage_Selected = null;
            this.btnAgregarCuotaApafaGA.IconMarginLeft = 0;
            this.btnAgregarCuotaApafaGA.IconMarginRight = 0;
            this.btnAgregarCuotaApafaGA.IconRightVisible = true;
            this.btnAgregarCuotaApafaGA.IconRightZoom = 0D;
            this.btnAgregarCuotaApafaGA.IconVisible = true;
            this.btnAgregarCuotaApafaGA.IconZoom = 50D;
            this.btnAgregarCuotaApafaGA.IsTab = false;
            this.btnAgregarCuotaApafaGA.Location = new System.Drawing.Point(588, 493);
            this.btnAgregarCuotaApafaGA.Name = "btnAgregarCuotaApafaGA";
            this.btnAgregarCuotaApafaGA.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCuotaApafaGA.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarCuotaApafaGA.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarCuotaApafaGA.selected = false;
            this.btnAgregarCuotaApafaGA.Size = new System.Drawing.Size(132, 55);
            this.btnAgregarCuotaApafaGA.TabIndex = 27;
            this.btnAgregarCuotaApafaGA.Text = "AGREGAR CUOTA DE APAFA";
            this.btnAgregarCuotaApafaGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCuotaApafaGA.Textcolor = System.Drawing.Color.White;
            this.btnAgregarCuotaApafaGA.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCuotaApafaGA.Click += new System.EventHandler(this.btnAgregarCuotaApafa_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Silver;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(365, 343);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(169, 30);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.text = "BUSCAR";
            // 
            // btnGuardarGA
            // 
            this.btnGuardarGA.Activecolor = System.Drawing.Color.SkyBlue;
            this.btnGuardarGA.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardarGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarGA.BorderRadius = 0;
            this.btnGuardarGA.ButtonText = "GUARDAR";
            this.btnGuardarGA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarGA.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarGA.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarGA.Iconimage = global::gstPresentacion.Properties.Resources.save;
            this.btnGuardarGA.Iconimage_right = null;
            this.btnGuardarGA.Iconimage_right_Selected = null;
            this.btnGuardarGA.Iconimage_Selected = null;
            this.btnGuardarGA.IconMarginLeft = 0;
            this.btnGuardarGA.IconMarginRight = 0;
            this.btnGuardarGA.IconRightVisible = true;
            this.btnGuardarGA.IconRightZoom = 0D;
            this.btnGuardarGA.IconVisible = true;
            this.btnGuardarGA.IconZoom = 60D;
            this.btnGuardarGA.IsTab = false;
            this.btnGuardarGA.Location = new System.Drawing.Point(402, 271);
            this.btnGuardarGA.Name = "btnGuardarGA";
            this.btnGuardarGA.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnGuardarGA.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarGA.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarGA.selected = false;
            this.btnGuardarGA.Size = new System.Drawing.Size(132, 42);
            this.btnGuardarGA.TabIndex = 20;
            this.btnGuardarGA.Text = "GUARDAR";
            this.btnGuardarGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarGA.Textcolor = System.Drawing.Color.White;
            this.btnGuardarGA.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGA.Click += new System.EventHandler(this.btnGuardarGA_Click);
            // 
            // gstFrmGestionarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerarReciboGA);
            this.Controls.Add(this.btnModificarGA);
            this.Controls.Add(this.btnAgregarCuotaApafaGA);
            this.Controls.Add(this.dgvAlumnoGA);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxGradoGA);
            this.Controls.Add(this.cbxSeccionGA);
            this.Controls.Add(this.cbxEstadoGA);
            this.Controls.Add(this.cbxNivelGA);
            this.Controls.Add(this.btnGuardarGA);
            this.Controls.Add(this.txtPeriodoGA);
            this.Controls.Add(this.txtDniGA);
            this.Controls.Add(this.txtNombreGA);
            this.Controls.Add(this.txtApellidoGA);
            this.Controls.Add(this.txtObservacionGA);
            this.Controls.Add(this.txtCodigoGA);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmGestionarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "gstFrmGestionarAlumno";
            this.Load += new System.EventHandler(this.gstFrmGestionarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoGA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCodigo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lblApellido;
        private Bunifu.Framework.UI.BunifuCustomLabel lblObservacion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPeriodo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDni;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenerarReciboGA;
        private Bunifu.Framework.UI.BunifuFlatButton btnModificarGA;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarCuotaApafaGA;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnoGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApellidosNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNivelGradoSeccion;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private System.Windows.Forms.ComboBox cbxGradoGA;
        private System.Windows.Forms.ComboBox cbxSeccionGA;
        private System.Windows.Forms.ComboBox cbxEstadoGA;
        private System.Windows.Forms.ComboBox cbxNivelGA;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarGA;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPeriodoGA;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDniGA;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombreGA;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtApellidoGA;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtObservacionGA;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCodigoGA;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarGA;
    }
}