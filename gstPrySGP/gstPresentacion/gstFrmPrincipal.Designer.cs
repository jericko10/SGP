namespace gstPre
{
    partial class gstFrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmPrincipal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblFH = new System.Windows.Forms.Label();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExpandir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReporte = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnUsuario = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRecibo = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMatricula = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAlumno = new Bunifu.Framework.UI.BunifuTileButton();
            this.tltPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRecibo = new System.Windows.Forms.Panel();
            this.btnFraccionarApafa = new System.Windows.Forms.Button();
            this.btnExonerarDeudasPendientes = new System.Windows.Forms.Button();
            this.btnCuotaExtraordinaria = new System.Windows.Forms.Button();
            this.btnGenerarFormatoRecibo = new System.Windows.Forms.Button();
            this.pnlReporte = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReporteDeudasSeccion = new System.Windows.Forms.Button();
            this.btnReporteDeudasAlumno = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCuota = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlCuota = new System.Windows.Forms.Panel();
            this.btnGestionarProgramaCuota = new System.Windows.Forms.Button();
            this.btnGestionarConcepto = new System.Windows.Forms.Button();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRecibo.SuspendLayout();
            this.pnlReporte.SuspendLayout();
            this.pnlCuota.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlPrincipal.Controls.Add(this.lblFH);
            this.pnlPrincipal.Controls.Add(this.btnMinimizar);
            this.pnlPrincipal.Controls.Add(this.btnExpandir);
            this.pnlPrincipal.Controls.Add(this.btnCerrar);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(824, 26);
            this.pnlPrincipal.TabIndex = 0;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pnlPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPrincipal_MouseMove);
            this.pnlPrincipal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPrincipal_MouseUp);
            // 
            // lblFH
            // 
            this.lblFH.AutoSize = true;
            this.lblFH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFH.Location = new System.Drawing.Point(313, 5);
            this.lblFH.Name = "lblFH";
            this.lblFH.Size = new System.Drawing.Size(65, 13);
            this.lblFH.TabIndex = 4;
            this.lblFH.Text = "FechayHora";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Image = global::gstPresentacion.Properties.Resources.subtraction;
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(739, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 34;
            this.btnMinimizar.TabStop = false;
            this.tltPrincipal.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandir.BackColor = System.Drawing.Color.Transparent;
            this.btnExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpandir.Image = global::gstPresentacion.Properties.Resources.check_box_empty;
            this.btnExpandir.ImageActive = null;
            this.btnExpandir.InitialImage = global::gstPresentacion.Properties.Resources.check_box_empty;
            this.btnExpandir.Location = new System.Drawing.Point(768, 2);
            this.btnExpandir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(30, 20);
            this.btnExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExpandir.TabIndex = 33;
            this.btnExpandir.TabStop = false;
            this.tltPrincipal.SetToolTip(this.btnExpandir, "Expandir");
            this.btnExpandir.Zoom = 10;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            this.btnExpandir.DoubleClick += new System.EventHandler(this.btnExpandir_DoubleClick);
            this.btnExpandir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btnExpandir_MouseDoubleClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(798, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 19);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.TabStop = false;
            this.tltPrincipal.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE GESTIÓN DE PAGOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.btnCuota);
            this.panel2.Controls.Add(this.btnReporte);
            this.panel2.Controls.Add(this.btnUsuario);
            this.panel2.Controls.Add(this.btnRecibo);
            this.panel2.Controls.Add(this.btnMatricula);
            this.panel2.Controls.Add(this.btnAlumno);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 529);
            this.panel2.TabIndex = 1;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReporte.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReporte.color = System.Drawing.Color.DodgerBlue;
            this.btnReporte.colorActive = System.Drawing.Color.SteelBlue;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = global::gstPresentacion.Properties.Resources.newspaper;
            this.btnReporte.ImagePosition = 7;
            this.btnReporte.ImageZoom = 50;
            this.btnReporte.LabelPosition = 29;
            this.btnReporte.LabelText = "REPORTE";
            this.btnReporte.Location = new System.Drawing.Point(5, 343);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(84, 74);
            this.btnReporte.TabIndex = 5;
            this.tltPrincipal.SetToolTip(this.btnReporte, "Reporte");
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click_1);
            this.btnReporte.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReporte_MouseMove);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUsuario.color = System.Drawing.Color.DodgerBlue;
            this.btnUsuario.colorActive = System.Drawing.Color.SteelBlue;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = global::gstPresentacion.Properties.Resources.user;
            this.btnUsuario.ImagePosition = 7;
            this.btnUsuario.ImageZoom = 50;
            this.btnUsuario.LabelPosition = 29;
            this.btnUsuario.LabelText = "USUARIO";
            this.btnUsuario.Location = new System.Drawing.Point(5, 425);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(84, 74);
            this.btnUsuario.TabIndex = 4;
            this.tltPrincipal.SetToolTip(this.btnUsuario, "Usuario");
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnRecibo
            // 
            this.btnRecibo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRecibo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRecibo.color = System.Drawing.Color.DodgerBlue;
            this.btnRecibo.colorActive = System.Drawing.Color.SteelBlue;
            this.btnRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRecibo.ForeColor = System.Drawing.Color.White;
            this.btnRecibo.Image = global::gstPresentacion.Properties.Resources.note;
            this.btnRecibo.ImagePosition = 7;
            this.btnRecibo.ImageZoom = 50;
            this.btnRecibo.LabelPosition = 29;
            this.btnRecibo.LabelText = "RECIBO";
            this.btnRecibo.Location = new System.Drawing.Point(5, 97);
            this.btnRecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(84, 74);
            this.btnRecibo.TabIndex = 3;
            this.tltPrincipal.SetToolTip(this.btnRecibo, "Recibo");
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            this.btnRecibo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRecibo_MouseMove);
            // 
            // btnMatricula
            // 
            this.btnMatricula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMatricula.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMatricula.color = System.Drawing.Color.DodgerBlue;
            this.btnMatricula.colorActive = System.Drawing.Color.SteelBlue;
            this.btnMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatricula.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnMatricula.ForeColor = System.Drawing.Color.White;
            this.btnMatricula.Image = global::gstPresentacion.Properties.Resources.note__1_;
            this.btnMatricula.ImagePosition = 7;
            this.btnMatricula.ImageZoom = 50;
            this.btnMatricula.LabelPosition = 29;
            this.btnMatricula.LabelText = "MATRICULA";
            this.btnMatricula.Location = new System.Drawing.Point(5, 179);
            this.btnMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(84, 74);
            this.btnMatricula.TabIndex = 2;
            this.tltPrincipal.SetToolTip(this.btnMatricula, "Matrícula");
            this.btnMatricula.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAlumno.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlumno.color = System.Drawing.Color.DodgerBlue;
            this.btnAlumno.colorActive = System.Drawing.Color.SteelBlue;
            this.btnAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumno.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumno.Image")));
            this.btnAlumno.ImagePosition = 7;
            this.btnAlumno.ImageZoom = 50;
            this.btnAlumno.LabelPosition = 29;
            this.btnAlumno.LabelText = "ALUMNO";
            this.btnAlumno.Location = new System.Drawing.Point(5, 15);
            this.btnAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(84, 74);
            this.btnAlumno.TabIndex = 1;
            this.tltPrincipal.SetToolTip(this.btnAlumno, "Alumno");
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // tltPrincipal
            // 
            this.tltPrincipal.Popup += new System.Windows.Forms.PopupEventHandler(this.tltExpandir_Popup);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.pnlCuota);
            this.panel1.Controls.Add(this.pnlRecibo);
            this.panel1.Controls.Add(this.pnlReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(93, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 529);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pnlRecibo
            // 
            this.pnlRecibo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlRecibo.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlRecibo.Controls.Add(this.btnFraccionarApafa);
            this.pnlRecibo.Controls.Add(this.btnExonerarDeudasPendientes);
            this.pnlRecibo.Controls.Add(this.btnCuotaExtraordinaria);
            this.pnlRecibo.Controls.Add(this.btnGenerarFormatoRecibo);
            this.pnlRecibo.Location = new System.Drawing.Point(-1, 91);
            this.pnlRecibo.Name = "pnlRecibo";
            this.pnlRecibo.Size = new System.Drawing.Size(155, 87);
            this.pnlRecibo.TabIndex = 3;
            this.pnlRecibo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRecibo_Paint);
            this.pnlRecibo.MouseLeave += new System.EventHandler(this.pnlRecibo_MouseLeave);
            this.pnlRecibo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlRecibo_MouseMove);
            // 
            // btnFraccionarApafa
            // 
            this.btnFraccionarApafa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFraccionarApafa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFraccionarApafa.FlatAppearance.BorderSize = 0;
            this.btnFraccionarApafa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFraccionarApafa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFraccionarApafa.Location = new System.Drawing.Point(0, 64);
            this.btnFraccionarApafa.Name = "btnFraccionarApafa";
            this.btnFraccionarApafa.Size = new System.Drawing.Size(155, 23);
            this.btnFraccionarApafa.TabIndex = 3;
            this.btnFraccionarApafa.Text = "Fraccionar cobro de APAFA";
            this.btnFraccionarApafa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFraccionarApafa.UseVisualStyleBackColor = false;
            this.btnFraccionarApafa.Click += new System.EventHandler(this.btnFraccionarApafa_Click);
            // 
            // btnExonerarDeudasPendientes
            // 
            this.btnExonerarDeudasPendientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExonerarDeudasPendientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExonerarDeudasPendientes.FlatAppearance.BorderSize = 0;
            this.btnExonerarDeudasPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExonerarDeudasPendientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExonerarDeudasPendientes.Location = new System.Drawing.Point(0, 42);
            this.btnExonerarDeudasPendientes.Name = "btnExonerarDeudasPendientes";
            this.btnExonerarDeudasPendientes.Size = new System.Drawing.Size(155, 23);
            this.btnExonerarDeudasPendientes.TabIndex = 2;
            this.btnExonerarDeudasPendientes.Text = "Exonerar deudas";
            this.btnExonerarDeudasPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExonerarDeudasPendientes.UseVisualStyleBackColor = false;
            this.btnExonerarDeudasPendientes.Click += new System.EventHandler(this.btnExonerarDeudasPendientes_Click);
            // 
            // btnCuotaExtraordinaria
            // 
            this.btnCuotaExtraordinaria.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCuotaExtraordinaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCuotaExtraordinaria.FlatAppearance.BorderSize = 0;
            this.btnCuotaExtraordinaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuotaExtraordinaria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCuotaExtraordinaria.Location = new System.Drawing.Point(0, 21);
            this.btnCuotaExtraordinaria.Name = "btnCuotaExtraordinaria";
            this.btnCuotaExtraordinaria.Size = new System.Drawing.Size(155, 23);
            this.btnCuotaExtraordinaria.TabIndex = 1;
            this.btnCuotaExtraordinaria.Text = "Agregar CuotaExtraordinaria";
            this.btnCuotaExtraordinaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuotaExtraordinaria.UseVisualStyleBackColor = false;
            this.btnCuotaExtraordinaria.Click += new System.EventHandler(this.btnCuotaExtraordinaria_Click);
            // 
            // btnGenerarFormatoRecibo
            // 
            this.btnGenerarFormatoRecibo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerarFormatoRecibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerarFormatoRecibo.FlatAppearance.BorderSize = 0;
            this.btnGenerarFormatoRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarFormatoRecibo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerarFormatoRecibo.Location = new System.Drawing.Point(0, 0);
            this.btnGenerarFormatoRecibo.Name = "btnGenerarFormatoRecibo";
            this.btnGenerarFormatoRecibo.Size = new System.Drawing.Size(155, 23);
            this.btnGenerarFormatoRecibo.TabIndex = 0;
            this.btnGenerarFormatoRecibo.Text = "Generar recibo";
            this.btnGenerarFormatoRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarFormatoRecibo.UseVisualStyleBackColor = false;
            this.btnGenerarFormatoRecibo.Click += new System.EventHandler(this.btnGenerarFormatoRecibo_Click);
            // 
            // pnlReporte
            // 
            this.pnlReporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlReporte.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlReporte.Controls.Add(this.button1);
            this.pnlReporte.Controls.Add(this.btnReporteDeudasSeccion);
            this.pnlReporte.Controls.Add(this.btnReporteDeudasAlumno);
            this.pnlReporte.Location = new System.Drawing.Point(-1, 349);
            this.pnlReporte.Name = "pnlReporte";
            this.pnlReporte.Size = new System.Drawing.Size(155, 65);
            this.pnlReporte.TabIndex = 0;
            this.pnlReporte.MouseLeave += new System.EventHandler(this.pnlReporte_MouseLeave);
            this.pnlReporte.MouseHover += new System.EventHandler(this.pnlReporte_MouseHover);
            this.pnlReporte.Move += new System.EventHandler(this.pnlReporte_Move);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reporte pago diario";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnReporteDeudasSeccion
            // 
            this.btnReporteDeudasSeccion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReporteDeudasSeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporteDeudasSeccion.FlatAppearance.BorderSize = 0;
            this.btnReporteDeudasSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporteDeudasSeccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReporteDeudasSeccion.Location = new System.Drawing.Point(0, 21);
            this.btnReporteDeudasSeccion.Name = "btnReporteDeudasSeccion";
            this.btnReporteDeudasSeccion.Size = new System.Drawing.Size(155, 23);
            this.btnReporteDeudasSeccion.TabIndex = 1;
            this.btnReporteDeudasSeccion.Text = "Reporte deudas por sección";
            this.btnReporteDeudasSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteDeudasSeccion.UseVisualStyleBackColor = false;
            this.btnReporteDeudasSeccion.Click += new System.EventHandler(this.btnReporteDeudasSeccion_Click);
            // 
            // btnReporteDeudasAlumno
            // 
            this.btnReporteDeudasAlumno.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReporteDeudasAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporteDeudasAlumno.FlatAppearance.BorderSize = 0;
            this.btnReporteDeudasAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporteDeudasAlumno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReporteDeudasAlumno.Location = new System.Drawing.Point(0, 0);
            this.btnReporteDeudasAlumno.Name = "btnReporteDeudasAlumno";
            this.btnReporteDeudasAlumno.Size = new System.Drawing.Size(155, 23);
            this.btnReporteDeudasAlumno.TabIndex = 0;
            this.btnReporteDeudasAlumno.Text = "Reporte deudas por alumno";
            this.btnReporteDeudasAlumno.UseVisualStyleBackColor = false;
            this.btnReporteDeudasAlumno.Click += new System.EventHandler(this.btnReporteDeudasAlumno_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCuota
            // 
            this.btnCuota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCuota.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCuota.color = System.Drawing.Color.DodgerBlue;
            this.btnCuota.colorActive = System.Drawing.Color.SteelBlue;
            this.btnCuota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuota.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCuota.ForeColor = System.Drawing.Color.White;
            this.btnCuota.Image = global::gstPresentacion.Properties.Resources.note__1_;
            this.btnCuota.ImagePosition = 7;
            this.btnCuota.ImageZoom = 50;
            this.btnCuota.LabelPosition = 29;
            this.btnCuota.LabelText = "CUOTA";
            this.btnCuota.Location = new System.Drawing.Point(5, 261);
            this.btnCuota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCuota.Name = "btnCuota";
            this.btnCuota.Size = new System.Drawing.Size(84, 74);
            this.btnCuota.TabIndex = 6;
            this.tltPrincipal.SetToolTip(this.btnCuota, "Matrícula");
            this.btnCuota.Click += new System.EventHandler(this.btnCuota_Click);
            this.btnCuota.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCuota_MouseMove);
            // 
            // pnlCuota
            // 
            this.pnlCuota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlCuota.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlCuota.Controls.Add(this.btnGestionarProgramaCuota);
            this.pnlCuota.Controls.Add(this.btnGestionarConcepto);
            this.pnlCuota.Location = new System.Drawing.Point(-1, 276);
            this.pnlCuota.Name = "pnlCuota";
            this.pnlCuota.Size = new System.Drawing.Size(167, 45);
            this.pnlCuota.TabIndex = 4;
            // 
            // btnGestionarProgramaCuota
            // 
            this.btnGestionarProgramaCuota.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionarProgramaCuota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGestionarProgramaCuota.FlatAppearance.BorderSize = 0;
            this.btnGestionarProgramaCuota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionarProgramaCuota.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionarProgramaCuota.Location = new System.Drawing.Point(0, 21);
            this.btnGestionarProgramaCuota.Name = "btnGestionarProgramaCuota";
            this.btnGestionarProgramaCuota.Size = new System.Drawing.Size(167, 23);
            this.btnGestionarProgramaCuota.TabIndex = 1;
            this.btnGestionarProgramaCuota.Text = "Gestionar Programa de Cuotas";
            this.btnGestionarProgramaCuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarProgramaCuota.UseVisualStyleBackColor = false;
            // 
            // btnGestionarConcepto
            // 
            this.btnGestionarConcepto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionarConcepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGestionarConcepto.FlatAppearance.BorderSize = 0;
            this.btnGestionarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionarConcepto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionarConcepto.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarConcepto.Name = "btnGestionarConcepto";
            this.btnGestionarConcepto.Size = new System.Drawing.Size(167, 23);
            this.btnGestionarConcepto.TabIndex = 0;
            this.btnGestionarConcepto.Text = "Gestionar Concepto";
            this.btnGestionarConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarConcepto.UseVisualStyleBackColor = false;
            this.btnGestionarConcepto.Click += new System.EventHandler(this.btnGestionarConcepto_Click);
            // 
            // gstFrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 555);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gstFrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gstFrmPrincipal";
            this.Load += new System.EventHandler(this.gstFrmPrincipal_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlRecibo.ResumeLayout(false);
            this.pnlReporte.ResumeLayout(false);
            this.pnlCuota.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btnAlumno;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuTileButton btnMatricula;
        private Bunifu.Framework.UI.BunifuImageButton btnExpandir;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private System.Windows.Forms.ToolTip tltPrincipal;
        private Bunifu.Framework.UI.BunifuTileButton btnReporte;
        private Bunifu.Framework.UI.BunifuTileButton btnUsuario;
        private Bunifu.Framework.UI.BunifuTileButton btnRecibo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFH;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlReporte;
        private System.Windows.Forms.Button btnReporteDeudasSeccion;
        private System.Windows.Forms.Button btnReporteDeudasAlumno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlRecibo;
        private System.Windows.Forms.Button btnExonerarDeudasPendientes;
        private System.Windows.Forms.Button btnCuotaExtraordinaria;
        private System.Windows.Forms.Button btnGenerarFormatoRecibo;
        private System.Windows.Forms.Button btnFraccionarApafa;
        private System.Windows.Forms.Panel pnlCuota;
        private System.Windows.Forms.Button btnGestionarProgramaCuota;
        private System.Windows.Forms.Button btnGestionarConcepto;
        private Bunifu.Framework.UI.BunifuTileButton btnCuota;
    }
}