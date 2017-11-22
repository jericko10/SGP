namespace gstPresentacion.gstCuota
{
    partial class gstFrmGestionarProgramaCuota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmGestionarProgramaCuota));
            this.pnlGestionarProgramaCuota = new System.Windows.Forms.Panel();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrarFormulario = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAño = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblConcepto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbConcepto = new System.Windows.Forms.ComboBox();
            this.nupAño = new System.Windows.Forms.NumericUpDown();
            this.lblMes = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbAlcance = new System.Windows.Forms.ComboBox();
            this.lblAlcance = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgdProgramaCuota = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblFiltrarAño = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.nupFiltrarPorAño = new System.Windows.Forms.NumericUpDown();
            this.btnAplicarProgramaCuota = new System.Windows.Forms.Button();
            this.nupAplicarAño = new System.Windows.Forms.NumericUpDown();
            this.lblAplicarAño = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlGestionarProgramaCuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProgramaCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFiltrarPorAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAplicarAño)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGestionarProgramaCuota
            // 
            this.pnlGestionarProgramaCuota.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlGestionarProgramaCuota.Controls.Add(this.btnCerrarFormulario);
            this.pnlGestionarProgramaCuota.Controls.Add(this.lblTitulo);
            this.pnlGestionarProgramaCuota.Controls.Add(this.btnCerrar);
            this.pnlGestionarProgramaCuota.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestionarProgramaCuota.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionarProgramaCuota.Name = "pnlGestionarProgramaCuota";
            this.pnlGestionarProgramaCuota.Size = new System.Drawing.Size(791, 32);
            this.pnlGestionarProgramaCuota.TabIndex = 33;
            this.pnlGestionarProgramaCuota.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGestionarProgramaCuota_MouseDown);
            this.pnlGestionarProgramaCuota.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGestionarProgramaCuota_MouseMove);
            this.pnlGestionarProgramaCuota.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGestionarProgramaCuota_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(75, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 16);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "PROGRAMA DE CUOTAS";
            // 
            // btnCerrarFormulario
            // 
            this.btnCerrarFormulario.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFormulario.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarFormulario.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarFormulario.ImageActive = null;
            this.btnCerrarFormulario.Location = new System.Drawing.Point(755, 2);
            this.btnCerrarFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarFormulario.Name = "btnCerrarFormulario";
            this.btnCerrarFormulario.Size = new System.Drawing.Size(36, 29);
            this.btnCerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarFormulario.TabIndex = 32;
            this.btnCerrarFormulario.TabStop = false;
            this.btnCerrarFormulario.Zoom = 10;
            this.btnCerrarFormulario.Click += new System.EventHandler(this.btnCerrarFormulario_Click);
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
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(30, 132);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(30, 13);
            this.lblAño.TabIndex = 54;
            this.lblAño.Text = "AÑO";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(30, 66);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(66, 13);
            this.lblConcepto.TabIndex = 53;
            this.lblConcepto.Text = "CONCEPTO";
            // 
            // cmbConcepto
            // 
            this.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConcepto.FormattingEnabled = true;
            this.cmbConcepto.Location = new System.Drawing.Point(33, 96);
            this.cmbConcepto.Name = "cmbConcepto";
            this.cmbConcepto.Size = new System.Drawing.Size(266, 21);
            this.cmbConcepto.TabIndex = 56;
            // 
            // nupAño
            // 
            this.nupAño.Location = new System.Drawing.Point(33, 164);
            this.nupAño.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupAño.Name = "nupAño";
            this.nupAño.ReadOnly = true;
            this.nupAño.Size = new System.Drawing.Size(84, 20);
            this.nupAño.TabIndex = 57;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(30, 208);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 58;
            this.lblMes.Text = "MES";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(33, 236);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(167, 21);
            this.cmbMes.TabIndex = 59;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(458, 96);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(128, 21);
            this.cmbPeriodo.TabIndex = 61;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(455, 66);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(56, 13);
            this.lblPeriodo.TabIndex = 60;
            this.lblPeriodo.Text = "PERIODO";
            // 
            // cmbAlcance
            // 
            this.cmbAlcance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlcance.FormattingEnabled = true;
            this.cmbAlcance.Location = new System.Drawing.Point(458, 163);
            this.cmbAlcance.Name = "cmbAlcance";
            this.cmbAlcance.Size = new System.Drawing.Size(167, 21);
            this.cmbAlcance.TabIndex = 63;
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(455, 132);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(56, 13);
            this.lblAlcance.TabIndex = 62;
            this.lblAlcance.Text = "ALCANCE";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(458, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 23);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgdProgramaCuota
            // 
            this.dgdProgramaCuota.AllowUserToAddRows = false;
            this.dgdProgramaCuota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgdProgramaCuota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgdProgramaCuota.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgdProgramaCuota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdProgramaCuota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdProgramaCuota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgdProgramaCuota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdProgramaCuota.DoubleBuffered = true;
            this.dgdProgramaCuota.EnableHeadersVisualStyles = false;
            this.dgdProgramaCuota.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdProgramaCuota.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgdProgramaCuota.Location = new System.Drawing.Point(33, 367);
            this.dgdProgramaCuota.Name = "dgdProgramaCuota";
            this.dgdProgramaCuota.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdProgramaCuota.Size = new System.Drawing.Size(592, 245);
            this.dgdProgramaCuota.TabIndex = 65;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Silver;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(341, 316);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(284, 31);
            this.txtBuscar.TabIndex = 66;
            this.txtBuscar.text = "BUSCAR POR DESCRIPCIÓN...";
            this.txtBuscar.KeyUp += new System.EventHandler(this.txtBuscar_KeyUp);
            // 
            // lblFiltrarAño
            // 
            this.lblFiltrarAño.AutoSize = true;
            this.lblFiltrarAño.Location = new System.Drawing.Point(30, 330);
            this.lblFiltrarAño.Name = "lblFiltrarAño";
            this.lblFiltrarAño.Size = new System.Drawing.Size(104, 13);
            this.lblFiltrarAño.TabIndex = 68;
            this.lblFiltrarAño.Text = "FILTRAR POR AÑO";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(647, 389);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 23);
            this.btnModificar.TabIndex = 69;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // nupFiltrarPorAño
            // 
            this.nupFiltrarPorAño.Location = new System.Drawing.Point(151, 327);
            this.nupFiltrarPorAño.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupFiltrarPorAño.Name = "nupFiltrarPorAño";
            this.nupFiltrarPorAño.ReadOnly = true;
            this.nupFiltrarPorAño.Size = new System.Drawing.Size(84, 20);
            this.nupFiltrarPorAño.TabIndex = 70;
            this.nupFiltrarPorAño.ValueChanged += new System.EventHandler(this.nupFiltrarPorAño_ValueChanged);
            // 
            // btnAplicarProgramaCuota
            // 
            this.btnAplicarProgramaCuota.Location = new System.Drawing.Point(647, 558);
            this.btnAplicarProgramaCuota.Name = "btnAplicarProgramaCuota";
            this.btnAplicarProgramaCuota.Size = new System.Drawing.Size(121, 54);
            this.btnAplicarProgramaCuota.TabIndex = 71;
            this.btnAplicarProgramaCuota.Text = "APLICAR PROGRAMA DE CUOTAS";
            this.btnAplicarProgramaCuota.UseVisualStyleBackColor = true;
            this.btnAplicarProgramaCuota.Click += new System.EventHandler(this.btnAplicarProgramaCuota_Click);
            // 
            // nupAplicarAño
            // 
            this.nupAplicarAño.Location = new System.Drawing.Point(647, 517);
            this.nupAplicarAño.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupAplicarAño.Name = "nupAplicarAño";
            this.nupAplicarAño.ReadOnly = true;
            this.nupAplicarAño.Size = new System.Drawing.Size(121, 20);
            this.nupAplicarAño.TabIndex = 72;
            // 
            // lblAplicarAño
            // 
            this.lblAplicarAño.AutoSize = true;
            this.lblAplicarAño.Location = new System.Drawing.Point(644, 490);
            this.lblAplicarAño.Name = "lblAplicarAño";
            this.lblAplicarAño.Size = new System.Drawing.Size(78, 13);
            this.lblAplicarAño.TabIndex = 73;
            this.lblAplicarAño.Text = "APLICAR AÑO";
            // 
            // gstFrmGestionarProgramaCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 636);
            this.Controls.Add(this.lblAplicarAño);
            this.Controls.Add(this.nupAplicarAño);
            this.Controls.Add(this.btnAplicarProgramaCuota);
            this.Controls.Add(this.nupFiltrarPorAño);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblFiltrarAño);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgdProgramaCuota);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbAlcance);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.nupAño);
            this.Controls.Add(this.cmbConcepto);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.pnlGestionarProgramaCuota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmGestionarProgramaCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gstFrmGestionarProgramaCuota";
            this.Load += new System.EventHandler(this.gstFrmGestionarProgramaCuota_Load);
            this.pnlGestionarProgramaCuota.ResumeLayout(false);
            this.pnlGestionarProgramaCuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProgramaCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFiltrarPorAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAplicarAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGestionarProgramaCuota;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarFormulario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAño;
        private Bunifu.Framework.UI.BunifuCustomLabel lblConcepto;
        private System.Windows.Forms.ComboBox cmbConcepto;
        private System.Windows.Forms.NumericUpDown nupAño;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPeriodo;
        private System.Windows.Forms.ComboBox cmbAlcance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAlcance;
        private System.Windows.Forms.Button btnGuardar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgdProgramaCuota;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFiltrarAño;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.NumericUpDown nupFiltrarPorAño;
        private System.Windows.Forms.Button btnAplicarProgramaCuota;
        private System.Windows.Forms.NumericUpDown nupAplicarAño;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAplicarAño;
    }
}