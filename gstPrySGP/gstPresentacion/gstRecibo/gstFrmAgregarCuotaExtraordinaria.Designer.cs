namespace gstPresentacion
{
    partial class gstFrmAgregarCuotaExtraordinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmAgregarCuotaExtraordinaria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlCuotaExtraordinaria = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtCodigoCE = new System.Windows.Forms.TextBox();
            this.txtAlumnoCE = new System.Windows.Forms.TextBox();
            this.txtCobroCE = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvCobroCE = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnCodigoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvAlumnoCE = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarApellidoDniCE = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAgregarCuotasExtraordinariasCE = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlCuotaExtraordinaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobroCE)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoCE)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlCuotaExtraordinaria
            // 
            this.pnlCuotaExtraordinaria.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlCuotaExtraordinaria.Controls.Add(this.bunifuCustomLabel1);
            this.pnlCuotaExtraordinaria.Controls.Add(this.btnCerrar);
            this.pnlCuotaExtraordinaria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCuotaExtraordinaria.Location = new System.Drawing.Point(0, 0);
            this.pnlCuotaExtraordinaria.Name = "pnlCuotaExtraordinaria";
            this.pnlCuotaExtraordinaria.Size = new System.Drawing.Size(1070, 32);
            this.pnlCuotaExtraordinaria.TabIndex = 31;
            this.pnlCuotaExtraordinaria.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlCuotaExtraordinaria.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCuotaExtraordinaria_MouseDown);
            this.pnlCuotaExtraordinaria.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCuotaExtraordinaria_MouseMove);
            this.pnlCuotaExtraordinaria.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCuotaExtraordinaria_MouseUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(75, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(197, 16);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "CUOTA EXTRAORDINARIA";
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
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel3.Controls.Add(this.btnAgregarCuotasExtraordinariasCE);
            this.bunifuGradientPanel3.Controls.Add(this.txtCodigoCE);
            this.bunifuGradientPanel3.Controls.Add(this.txtAlumnoCE);
            this.bunifuGradientPanel3.Controls.Add(this.txtCobroCE);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel3.Controls.Add(this.dgvCobroCE);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(475, 64);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(538, 330);
            this.bunifuGradientPanel3.TabIndex = 33;
            // 
            // txtCodigoCE
            // 
            this.txtCodigoCE.Location = new System.Drawing.Point(360, 72);
            this.txtCodigoCE.Name = "txtCodigoCE";
            this.txtCodigoCE.Size = new System.Drawing.Size(138, 20);
            this.txtCodigoCE.TabIndex = 45;
            // 
            // txtAlumnoCE
            // 
            this.txtAlumnoCE.Location = new System.Drawing.Point(22, 72);
            this.txtAlumnoCE.Name = "txtAlumnoCE";
            this.txtAlumnoCE.Size = new System.Drawing.Size(257, 20);
            this.txtAlumnoCE.TabIndex = 44;
            // 
            // txtCobroCE
            // 
            this.txtCobroCE.BackColor = System.Drawing.Color.Silver;
            this.txtCobroCE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCobroCE.BackgroundImage")));
            this.txtCobroCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCobroCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCobroCE.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtCobroCE.Icon = ((System.Drawing.Image)(resources.GetObject("txtCobroCE.Icon")));
            this.txtCobroCE.Location = new System.Drawing.Point(22, 104);
            this.txtCobroCE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCobroCE.Name = "txtCobroCE";
            this.txtCobroCE.Size = new System.Drawing.Size(189, 23);
            this.txtCobroCE.TabIndex = 31;
            this.txtCobroCE.text = "BUSCAR COBRO";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(357, 44);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(49, 13);
            this.bunifuCustomLabel6.TabIndex = 42;
            this.bunifuCustomLabel6.Text = "CÓDIGO";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(19, 44);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(53, 13);
            this.bunifuCustomLabel5.TabIndex = 38;
            this.bunifuCustomLabel5.Text = "ALUMNO";
            // 
            // dgvCobroCE
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCobroCE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCobroCE.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCobroCE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCobroCE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobroCE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCobroCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobroCE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigoAlumno,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.clnSeleccionar});
            this.dgvCobroCE.DoubleBuffered = true;
            this.dgvCobroCE.EnableHeadersVisualStyles = false;
            this.dgvCobroCE.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCobroCE.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCobroCE.Location = new System.Drawing.Point(22, 134);
            this.dgvCobroCE.Name = "dgvCobroCE";
            this.dgvCobroCE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCobroCE.Size = new System.Drawing.Size(476, 118);
            this.dgvCobroCE.TabIndex = 30;
            // 
            // clnCodigoAlumno
            // 
            this.clnCodigoAlumno.HeaderText = "CODIGO";
            this.clnCodigoAlumno.Name = "clnCodigoAlumno";
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
            this.clnSeleccionar.HeaderText = "SELECCIONAR";
            this.clnSeleccionar.Name = "clnSeleccionar";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.dgvAlumnoCE);
            this.bunifuGradientPanel1.Controls.Add(this.txtBuscarApellidoDniCE);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 64);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(391, 175);
            this.bunifuGradientPanel1.TabIndex = 32;
            // 
            // dgvAlumnoCE
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlumnoCE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnoCE.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAlumnoCE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnoCE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnoCE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlumnoCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoCE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnApellidos,
            this.clnNombres});
            this.dgvAlumnoCE.DoubleBuffered = true;
            this.dgvAlumnoCE.EnableHeadersVisualStyles = false;
            this.dgvAlumnoCE.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAlumnoCE.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAlumnoCE.Location = new System.Drawing.Point(23, 72);
            this.dgvAlumnoCE.Name = "dgvAlumnoCE";
            this.dgvAlumnoCE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlumnoCE.Size = new System.Drawing.Size(345, 79);
            this.dgvAlumnoCE.TabIndex = 30;
            this.dgvAlumnoCE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnoCE_CellContentClick);
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
            // txtBuscarApellidoDniCE
            // 
            this.txtBuscarApellidoDniCE.BackColor = System.Drawing.Color.Silver;
            this.txtBuscarApellidoDniCE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarApellidoDniCE.BackgroundImage")));
            this.txtBuscarApellidoDniCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarApellidoDniCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarApellidoDniCE.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscarApellidoDniCE.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarApellidoDniCE.Icon")));
            this.txtBuscarApellidoDniCE.Location = new System.Drawing.Point(23, 25);
            this.txtBuscarApellidoDniCE.Name = "txtBuscarApellidoDniCE";
            this.txtBuscarApellidoDniCE.Size = new System.Drawing.Size(284, 32);
            this.txtBuscarApellidoDniCE.TabIndex = 29;
            this.txtBuscarApellidoDniCE.text = "BUSCAR POR APELLIDOS O DNI";
            // 
            // btnAgregarCuotasExtraordinariasCE
            // 
            this.btnAgregarCuotasExtraordinariasCE.Activecolor = System.Drawing.Color.SkyBlue;
            this.btnAgregarCuotasExtraordinariasCE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCuotasExtraordinariasCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCuotasExtraordinariasCE.BorderRadius = 0;
            this.btnAgregarCuotasExtraordinariasCE.ButtonText = "AGREGAR COUTAS EXTRAORDINARIAS";
            this.btnAgregarCuotasExtraordinariasCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCuotasExtraordinariasCE.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarCuotasExtraordinariasCE.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCuotasExtraordinariasCE.Iconimage = null;
            this.btnAgregarCuotasExtraordinariasCE.Iconimage_right = null;
            this.btnAgregarCuotasExtraordinariasCE.Iconimage_right_Selected = null;
            this.btnAgregarCuotasExtraordinariasCE.Iconimage_Selected = null;
            this.btnAgregarCuotasExtraordinariasCE.IconMarginLeft = 0;
            this.btnAgregarCuotasExtraordinariasCE.IconMarginRight = 0;
            this.btnAgregarCuotasExtraordinariasCE.IconRightVisible = true;
            this.btnAgregarCuotasExtraordinariasCE.IconRightZoom = 0D;
            this.btnAgregarCuotasExtraordinariasCE.IconVisible = true;
            this.btnAgregarCuotasExtraordinariasCE.IconZoom = 60D;
            this.btnAgregarCuotasExtraordinariasCE.IsTab = false;
            this.btnAgregarCuotasExtraordinariasCE.Location = new System.Drawing.Point(229, 271);
            this.btnAgregarCuotasExtraordinariasCE.Name = "btnAgregarCuotasExtraordinariasCE";
            this.btnAgregarCuotasExtraordinariasCE.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCuotasExtraordinariasCE.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarCuotasExtraordinariasCE.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarCuotasExtraordinariasCE.selected = false;
            this.btnAgregarCuotasExtraordinariasCE.Size = new System.Drawing.Size(143, 42);
            this.btnAgregarCuotasExtraordinariasCE.TabIndex = 46;
            this.btnAgregarCuotasExtraordinariasCE.Text = "AGREGAR COUTAS EXTRAORDINARIAS";
            this.btnAgregarCuotasExtraordinariasCE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarCuotasExtraordinariasCE.Textcolor = System.Drawing.Color.White;
            this.btnAgregarCuotasExtraordinariasCE.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // gstFrmAgregarCuotaExtraordinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 448);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pnlCuotaExtraordinaria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmAgregarCuotaExtraordinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gstFrmCuotasExtraordinarias";
            this.Load += new System.EventHandler(this.gstFrmAgregarCuotaExtraordinaria_Load);
            this.pnlCuotaExtraordinaria.ResumeLayout(false);
            this.pnlCuotaExtraordinaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobroCE)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoCE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlCuotaExtraordinaria;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnoCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNombres;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarApellidoDniCE;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuTextbox txtCobroCE;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCobroCE;
        private System.Windows.Forms.TextBox txtCodigoCE;
        private System.Windows.Forms.TextBox txtAlumnoCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnSeleccionar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarCuotasExtraordinariasCE;
    }
}