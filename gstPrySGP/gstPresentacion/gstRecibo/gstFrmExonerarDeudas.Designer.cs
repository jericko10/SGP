namespace gstPresentacion
{
    partial class gstFrmExonerarDeudas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmExonerarDeudas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlExonerarDeudas = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnExonerarDeudasPendientesEDP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDetalleMotivoExoneracionEDP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.rbtMotivoExoneracionSolicitadoEDP = new System.Windows.Forms.RadioButton();
            this.rbtMotivoExoneracionRetiradoEDP = new System.Windows.Forms.RadioButton();
            this.rbtMotivoExoneracionTrasladoEDP = new System.Windows.Forms.RadioButton();
            this.rbtMotivoExoneracionDocenteEDP = new System.Windows.Forms.RadioButton();
            this.rbtMotivoExoneracionHermanoEDP = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDeudasPendientesEDP = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMontoTotalDeudasEDP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodoEDP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEDP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEstadoEDP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDniEDP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNumOperacionEDP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAlumnoEDP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvAlumnoEDP = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarApellidoDniEDP = new Bunifu.Framework.UI.BunifuTextbox();
            this.pnlExonerarDeudas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudasPendientesEDP)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoEDP)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlExonerarDeudas
            // 
            this.pnlExonerarDeudas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlExonerarDeudas.Controls.Add(this.bunifuCustomLabel1);
            this.pnlExonerarDeudas.Controls.Add(this.btnCerrar);
            this.pnlExonerarDeudas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExonerarDeudas.Location = new System.Drawing.Point(0, 0);
            this.pnlExonerarDeudas.Name = "pnlExonerarDeudas";
            this.pnlExonerarDeudas.Size = new System.Drawing.Size(1086, 32);
            this.pnlExonerarDeudas.TabIndex = 31;
            this.pnlExonerarDeudas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlExonerarDeudas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlExonerarDeudas_MouseDown);
            this.pnlExonerarDeudas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlExonerarDeudas_MouseMove);
            this.pnlExonerarDeudas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlExonerarDeudas_MouseUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(259, 16);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "EXONERAR DEUDAS PENDIENTES";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(1041, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btnExonerarDeudasPendientesEDP);
            this.bunifuGradientPanel2.Controls.Add(this.label11);
            this.bunifuGradientPanel2.Controls.Add(this.txtDetalleMotivoExoneracionEDP);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuGradientPanel3);
            this.bunifuGradientPanel2.Controls.Add(this.dgvDeudasPendientesEDP);
            this.bunifuGradientPanel2.Controls.Add(this.label9);
            this.bunifuGradientPanel2.Controls.Add(this.label8);
            this.bunifuGradientPanel2.Controls.Add(this.lblMontoTotalDeudasEDP);
            this.bunifuGradientPanel2.Controls.Add(this.label6);
            this.bunifuGradientPanel2.Controls.Add(this.label5);
            this.bunifuGradientPanel2.Controls.Add(this.label4);
            this.bunifuGradientPanel2.Controls.Add(this.label3);
            this.bunifuGradientPanel2.Controls.Add(this.label2);
            this.bunifuGradientPanel2.Controls.Add(this.txtPeriodoEDP);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Controls.Add(this.txtCodigoEDP);
            this.bunifuGradientPanel2.Controls.Add(this.txtEstadoEDP);
            this.bunifuGradientPanel2.Controls.Add(this.txtDniEDP);
            this.bunifuGradientPanel2.Controls.Add(this.txtNumOperacionEDP);
            this.bunifuGradientPanel2.Controls.Add(this.txtAlumnoEDP);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(436, 53);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(623, 586);
            this.bunifuGradientPanel2.TabIndex = 34;
            // 
            // btnExonerarDeudasPendientesEDP
            // 
            this.btnExonerarDeudasPendientesEDP.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExonerarDeudasPendientesEDP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExonerarDeudasPendientesEDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExonerarDeudasPendientesEDP.BorderRadius = 0;
            this.btnExonerarDeudasPendientesEDP.ButtonText = "EXONERAR DEUDAS PENDIENTES";
            this.btnExonerarDeudasPendientesEDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExonerarDeudasPendientesEDP.DisabledColor = System.Drawing.Color.Gray;
            this.btnExonerarDeudasPendientesEDP.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExonerarDeudasPendientesEDP.Iconimage = null;
            this.btnExonerarDeudasPendientesEDP.Iconimage_right = null;
            this.btnExonerarDeudasPendientesEDP.Iconimage_right_Selected = null;
            this.btnExonerarDeudasPendientesEDP.Iconimage_Selected = null;
            this.btnExonerarDeudasPendientesEDP.IconMarginLeft = 0;
            this.btnExonerarDeudasPendientesEDP.IconMarginRight = 0;
            this.btnExonerarDeudasPendientesEDP.IconRightVisible = true;
            this.btnExonerarDeudasPendientesEDP.IconRightZoom = 0D;
            this.btnExonerarDeudasPendientesEDP.IconVisible = true;
            this.btnExonerarDeudasPendientesEDP.IconZoom = 90D;
            this.btnExonerarDeudasPendientesEDP.IsTab = false;
            this.btnExonerarDeudasPendientesEDP.Location = new System.Drawing.Point(219, 520);
            this.btnExonerarDeudasPendientesEDP.Name = "btnExonerarDeudasPendientesEDP";
            this.btnExonerarDeudasPendientesEDP.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.btnExonerarDeudasPendientesEDP.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnExonerarDeudasPendientesEDP.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExonerarDeudasPendientesEDP.selected = false;
            this.btnExonerarDeudasPendientesEDP.Size = new System.Drawing.Size(241, 48);
            this.btnExonerarDeudasPendientesEDP.TabIndex = 49;
            this.btnExonerarDeudasPendientesEDP.Text = "EXONERAR DEUDAS PENDIENTES";
            this.btnExonerarDeudasPendientesEDP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExonerarDeudasPendientesEDP.Textcolor = System.Drawing.Color.White;
            this.btnExonerarDeudasPendientesEDP.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "DETALLE MOTIVO DE EXONERACIÓN";
            // 
            // txtDetalleMotivoExoneracionEDP
            // 
            this.txtDetalleMotivoExoneracionEDP.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDetalleMotivoExoneracionEDP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDetalleMotivoExoneracionEDP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDetalleMotivoExoneracionEDP.BorderThickness = 3;
            this.txtDetalleMotivoExoneracionEDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetalleMotivoExoneracionEDP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDetalleMotivoExoneracionEDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDetalleMotivoExoneracionEDP.isPassword = false;
            this.txtDetalleMotivoExoneracionEDP.Location = new System.Drawing.Point(51, 472);
            this.txtDetalleMotivoExoneracionEDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalleMotivoExoneracionEDP.Name = "txtDetalleMotivoExoneracionEDP";
            this.txtDetalleMotivoExoneracionEDP.Size = new System.Drawing.Size(540, 41);
            this.txtDetalleMotivoExoneracionEDP.TabIndex = 47;
            this.txtDetalleMotivoExoneracionEDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.rbtMotivoExoneracionSolicitadoEDP);
            this.bunifuGradientPanel3.Controls.Add(this.rbtMotivoExoneracionRetiradoEDP);
            this.bunifuGradientPanel3.Controls.Add(this.rbtMotivoExoneracionTrasladoEDP);
            this.bunifuGradientPanel3.Controls.Add(this.rbtMotivoExoneracionDocenteEDP);
            this.bunifuGradientPanel3.Controls.Add(this.rbtMotivoExoneracionHermanoEDP);
            this.bunifuGradientPanel3.Controls.Add(this.label10);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(31, 353);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(567, 85);
            this.bunifuGradientPanel3.TabIndex = 34;
            // 
            // rbtMotivoExoneracionSolicitadoEDP
            // 
            this.rbtMotivoExoneracionSolicitadoEDP.AutoSize = true;
            this.rbtMotivoExoneracionSolicitadoEDP.Location = new System.Drawing.Point(477, 48);
            this.rbtMotivoExoneracionSolicitadoEDP.Name = "rbtMotivoExoneracionSolicitadoEDP";
            this.rbtMotivoExoneracionSolicitadoEDP.Size = new System.Drawing.Size(89, 17);
            this.rbtMotivoExoneracionSolicitadoEDP.TabIndex = 52;
            this.rbtMotivoExoneracionSolicitadoEDP.TabStop = true;
            this.rbtMotivoExoneracionSolicitadoEDP.Text = "SOLICITADO";
            this.rbtMotivoExoneracionSolicitadoEDP.UseVisualStyleBackColor = true;
            // 
            // rbtMotivoExoneracionRetiradoEDP
            // 
            this.rbtMotivoExoneracionRetiradoEDP.AutoSize = true;
            this.rbtMotivoExoneracionRetiradoEDP.Location = new System.Drawing.Point(260, 48);
            this.rbtMotivoExoneracionRetiradoEDP.Name = "rbtMotivoExoneracionRetiradoEDP";
            this.rbtMotivoExoneracionRetiradoEDP.Size = new System.Drawing.Size(81, 17);
            this.rbtMotivoExoneracionRetiradoEDP.TabIndex = 51;
            this.rbtMotivoExoneracionRetiradoEDP.TabStop = true;
            this.rbtMotivoExoneracionRetiradoEDP.Text = "RETIRADO";
            this.rbtMotivoExoneracionRetiradoEDP.UseVisualStyleBackColor = true;
            // 
            // rbtMotivoExoneracionTrasladoEDP
            // 
            this.rbtMotivoExoneracionTrasladoEDP.AutoSize = true;
            this.rbtMotivoExoneracionTrasladoEDP.Location = new System.Drawing.Point(378, 48);
            this.rbtMotivoExoneracionTrasladoEDP.Name = "rbtMotivoExoneracionTrasladoEDP";
            this.rbtMotivoExoneracionTrasladoEDP.Size = new System.Drawing.Size(83, 17);
            this.rbtMotivoExoneracionTrasladoEDP.TabIndex = 50;
            this.rbtMotivoExoneracionTrasladoEDP.TabStop = true;
            this.rbtMotivoExoneracionTrasladoEDP.Text = "TRASLADO";
            this.rbtMotivoExoneracionTrasladoEDP.UseVisualStyleBackColor = true;
            // 
            // rbtMotivoExoneracionDocenteEDP
            // 
            this.rbtMotivoExoneracionDocenteEDP.AutoSize = true;
            this.rbtMotivoExoneracionDocenteEDP.Location = new System.Drawing.Point(151, 48);
            this.rbtMotivoExoneracionDocenteEDP.Name = "rbtMotivoExoneracionDocenteEDP";
            this.rbtMotivoExoneracionDocenteEDP.Size = new System.Drawing.Size(77, 17);
            this.rbtMotivoExoneracionDocenteEDP.TabIndex = 49;
            this.rbtMotivoExoneracionDocenteEDP.TabStop = true;
            this.rbtMotivoExoneracionDocenteEDP.Text = "DOCENTE";
            this.rbtMotivoExoneracionDocenteEDP.UseVisualStyleBackColor = true;
            // 
            // rbtMotivoExoneracionHermanoEDP
            // 
            this.rbtMotivoExoneracionHermanoEDP.AutoSize = true;
            this.rbtMotivoExoneracionHermanoEDP.Location = new System.Drawing.Point(20, 48);
            this.rbtMotivoExoneracionHermanoEDP.Name = "rbtMotivoExoneracionHermanoEDP";
            this.rbtMotivoExoneracionHermanoEDP.Size = new System.Drawing.Size(80, 17);
            this.rbtMotivoExoneracionHermanoEDP.TabIndex = 48;
            this.rbtMotivoExoneracionHermanoEDP.TabStop = true;
            this.rbtMotivoExoneracionHermanoEDP.Text = "HERMANO";
            this.rbtMotivoExoneracionHermanoEDP.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "MOTIVO DE EXONERACIÓN";
            // 
            // dgvDeudasPendientesEDP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDeudasPendientesEDP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeudasPendientesEDP.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDeudasPendientesEDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeudasPendientesEDP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeudasPendientesEDP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeudasPendientesEDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudasPendientesEDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.clnSeleccionar});
            this.dgvDeudasPendientesEDP.DoubleBuffered = true;
            this.dgvDeudasPendientesEDP.EnableHeadersVisualStyles = false;
            this.dgvDeudasPendientesEDP.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDeudasPendientesEDP.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDeudasPendientesEDP.Location = new System.Drawing.Point(42, 225);
            this.dgvDeudasPendientesEDP.Name = "dgvDeudasPendientesEDP";
            this.dgvDeudasPendientesEDP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDeudasPendientesEDP.Size = new System.Drawing.Size(537, 112);
            this.dgvDeudasPendientesEDP.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "AÑO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "DESCRIPCIÓN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "MONTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // clnSeleccionar
            // 
            this.clnSeleccionar.HeaderText = "EXONERAR";
            this.clnSeleccionar.Name = "clnSeleccionar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "DEUDAS PENDIENTES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "MONTO TOTAL DE DEUDAS:";
            // 
            // lblMontoTotalDeudasEDP
            // 
            this.lblMontoTotalDeudasEDP.AutoSize = true;
            this.lblMontoTotalDeudasEDP.Location = new System.Drawing.Point(540, 188);
            this.lblMontoTotalDeudasEDP.Name = "lblMontoTotalDeudasEDP";
            this.lblMontoTotalDeudasEDP.Size = new System.Drawing.Size(49, 13);
            this.lblMontoTotalDeudasEDP.TabIndex = 43;
            this.lblMontoTotalDeudasEDP.Text = "S/.00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "NRO. OPERACIÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "ESTADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "PERIODO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "CÓDIGO";
            // 
            // txtPeriodoEDP
            // 
            this.txtPeriodoEDP.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPeriodoEDP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPeriodoEDP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPeriodoEDP.BorderThickness = 3;
            this.txtPeriodoEDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPeriodoEDP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPeriodoEDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPeriodoEDP.isPassword = false;
            this.txtPeriodoEDP.Location = new System.Drawing.Point(350, 111);
            this.txtPeriodoEDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodoEDP.Name = "txtPeriodoEDP";
            this.txtPeriodoEDP.Size = new System.Drawing.Size(101, 29);
            this.txtPeriodoEDP.TabIndex = 37;
            this.txtPeriodoEDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ALUMNO";
            // 
            // txtCodigoEDP
            // 
            this.txtCodigoEDP.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCodigoEDP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoEDP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCodigoEDP.BorderThickness = 3;
            this.txtCodigoEDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoEDP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoEDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoEDP.isPassword = false;
            this.txtCodigoEDP.Location = new System.Drawing.Point(443, 40);
            this.txtCodigoEDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEDP.Name = "txtCodigoEDP";
            this.txtCodigoEDP.Size = new System.Drawing.Size(148, 29);
            this.txtCodigoEDP.TabIndex = 35;
            this.txtCodigoEDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEstadoEDP
            // 
            this.txtEstadoEDP.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtEstadoEDP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstadoEDP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtEstadoEDP.BorderThickness = 3;
            this.txtEstadoEDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstadoEDP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEstadoEDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstadoEDP.isPassword = false;
            this.txtEstadoEDP.Location = new System.Drawing.Point(31, 111);
            this.txtEstadoEDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoEDP.Name = "txtEstadoEDP";
            this.txtEstadoEDP.Size = new System.Drawing.Size(116, 29);
            this.txtEstadoEDP.TabIndex = 34;
            this.txtEstadoEDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDniEDP
            // 
            this.txtDniEDP.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDniEDP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDniEDP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDniEDP.BorderThickness = 3;
            this.txtDniEDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDniEDP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDniEDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDniEDP.isPassword = false;
            this.txtDniEDP.Location = new System.Drawing.Point(194, 111);
            this.txtDniEDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniEDP.Name = "txtDniEDP";
            this.txtDniEDP.Size = new System.Drawing.Size(113, 29);
            this.txtDniEDP.TabIndex = 33;
            this.txtDniEDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNumOperacionEDP
            // 
            this.txtNumOperacionEDP.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNumOperacionEDP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumOperacionEDP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNumOperacionEDP.BorderThickness = 3;
            this.txtNumOperacionEDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumOperacionEDP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumOperacionEDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumOperacionEDP.isPassword = false;
            this.txtNumOperacionEDP.Location = new System.Drawing.Point(482, 111);
            this.txtNumOperacionEDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumOperacionEDP.Name = "txtNumOperacionEDP";
            this.txtNumOperacionEDP.Size = new System.Drawing.Size(109, 29);
            this.txtNumOperacionEDP.TabIndex = 32;
            this.txtNumOperacionEDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAlumnoEDP
            // 
            this.txtAlumnoEDP.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAlumnoEDP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlumnoEDP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAlumnoEDP.BorderThickness = 3;
            this.txtAlumnoEDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlumnoEDP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAlumnoEDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlumnoEDP.isPassword = false;
            this.txtAlumnoEDP.Location = new System.Drawing.Point(31, 40);
            this.txtAlumnoEDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlumnoEDP.Name = "txtAlumnoEDP";
            this.txtAlumnoEDP.Size = new System.Drawing.Size(341, 29);
            this.txtAlumnoEDP.TabIndex = 31;
            this.txtAlumnoEDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dgvAlumnoEDP);
            this.bunifuGradientPanel1.Controls.Add(this.txtBuscarApellidoDniEDP);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 117);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(391, 318);
            this.bunifuGradientPanel1.TabIndex = 33;
            // 
            // dgvAlumnoEDP
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlumnoEDP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnoEDP.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAlumnoEDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnoEDP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnoEDP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlumnoEDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoEDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnApellidos,
            this.clnNombres});
            this.dgvAlumnoEDP.DoubleBuffered = true;
            this.dgvAlumnoEDP.EnableHeadersVisualStyles = false;
            this.dgvAlumnoEDP.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAlumnoEDP.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAlumnoEDP.Location = new System.Drawing.Point(23, 72);
            this.dgvAlumnoEDP.Name = "dgvAlumnoEDP";
            this.dgvAlumnoEDP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlumnoEDP.Size = new System.Drawing.Size(345, 204);
            this.dgvAlumnoEDP.TabIndex = 30;
            // 
            // clnCodigo
            // 
            this.clnCodigo.HeaderText = "CÓDIGO";
            this.clnCodigo.Name = "clnCodigo";
            // 
            // clnApellidos
            // 
            this.clnApellidos.HeaderText = "APELLIDOS";
            this.clnApellidos.Name = "clnApellidos";
            // 
            // clnNombres
            // 
            this.clnNombres.HeaderText = "NOMBRES";
            this.clnNombres.Name = "clnNombres";
            // 
            // txtBuscarApellidoDniEDP
            // 
            this.txtBuscarApellidoDniEDP.BackColor = System.Drawing.Color.Silver;
            this.txtBuscarApellidoDniEDP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarApellidoDniEDP.BackgroundImage")));
            this.txtBuscarApellidoDniEDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarApellidoDniEDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarApellidoDniEDP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscarApellidoDniEDP.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarApellidoDniEDP.Icon")));
            this.txtBuscarApellidoDniEDP.Location = new System.Drawing.Point(23, 25);
            this.txtBuscarApellidoDniEDP.Name = "txtBuscarApellidoDniEDP";
            this.txtBuscarApellidoDniEDP.Size = new System.Drawing.Size(284, 32);
            this.txtBuscarApellidoDniEDP.TabIndex = 29;
            this.txtBuscarApellidoDniEDP.text = "BUSCAR POR APELLIDOS O DNI";
            // 
            // gstFrmExonerarDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1086, 693);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pnlExonerarDeudas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmExonerarDeudas";
            this.Text = "gstFrmExoneracion";
            this.pnlExonerarDeudas.ResumeLayout(false);
            this.pnlExonerarDeudas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudasPendientesEDP)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoEDP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlExonerarDeudas;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMontoTotalDeudasEDP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPeriodoEDP;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCodigoEDP;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEstadoEDP;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDniEDP;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNumOperacionEDP;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAlumnoEDP;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnoEDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNombres;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarApellidoDniEDP;
        private Bunifu.Framework.UI.BunifuFlatButton btnExonerarDeudasPendientesEDP;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDetalleMotivoExoneracionEDP;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDeudasPendientesEDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnSeleccionar;
        private System.Windows.Forms.RadioButton rbtMotivoExoneracionSolicitadoEDP;
        private System.Windows.Forms.RadioButton rbtMotivoExoneracionRetiradoEDP;
        private System.Windows.Forms.RadioButton rbtMotivoExoneracionTrasladoEDP;
        private System.Windows.Forms.RadioButton rbtMotivoExoneracionDocenteEDP;
        private System.Windows.Forms.RadioButton rbtMotivoExoneracionHermanoEDP;
    }
}