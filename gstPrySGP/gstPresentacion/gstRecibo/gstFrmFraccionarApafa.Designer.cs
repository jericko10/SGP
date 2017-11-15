namespace gstPresentacion
{
    partial class gstFrmFraccionar_Apafa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmFraccionar_Apafa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlFraccionarApafa = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvAlumnoFA = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarFA = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCancelarFraccionamientoFA = new System.Windows.Forms.Button();
            this.txtEstadoFA = new System.Windows.Forms.TextBox();
            this.txtPeriodoFA = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNumOperacionFA = new System.Windows.Forms.TextBox();
            this.txtAlumnoFA = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDniFA = new System.Windows.Forms.TextBox();
            this.txtCodigoFA = new System.Windows.Forms.TextBox();
            this.btnFraccionarApafaFA = new System.Windows.Forms.Button();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvDeudasPendientesFA = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlFraccionarApafa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoFA)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudasPendientesFA)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlFraccionarApafa
            // 
            this.pnlFraccionarApafa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlFraccionarApafa.Controls.Add(this.bunifuCustomLabel1);
            this.pnlFraccionarApafa.Controls.Add(this.btnCerrar);
            this.pnlFraccionarApafa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFraccionarApafa.Location = new System.Drawing.Point(0, 0);
            this.pnlFraccionarApafa.Name = "pnlFraccionarApafa";
            this.pnlFraccionarApafa.Size = new System.Drawing.Size(1102, 32);
            this.pnlFraccionarApafa.TabIndex = 32;
            this.pnlFraccionarApafa.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlFraccionarApafa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFraccionarApafa_MouseDown);
            this.pnlFraccionarApafa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFraccionarApafa_MouseMove);
            this.pnlFraccionarApafa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlFraccionarApafa_MouseUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 16);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "FRACCIONAR APAFA";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(1057, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dgvAlumnoFA);
            this.bunifuGradientPanel1.Controls.Add(this.txtBuscarFA);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(36, 79);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(391, 175);
            this.bunifuGradientPanel1.TabIndex = 33;
            // 
            // dgvAlumnoFA
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlumnoFA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnoFA.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAlumnoFA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnoFA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnoFA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlumnoFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoFA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnApellidos,
            this.clnNombres});
            this.dgvAlumnoFA.DoubleBuffered = true;
            this.dgvAlumnoFA.EnableHeadersVisualStyles = false;
            this.dgvAlumnoFA.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAlumnoFA.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAlumnoFA.Location = new System.Drawing.Point(23, 72);
            this.dgvAlumnoFA.Name = "dgvAlumnoFA";
            this.dgvAlumnoFA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlumnoFA.Size = new System.Drawing.Size(345, 79);
            this.dgvAlumnoFA.TabIndex = 30;
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
            // txtBuscarFA
            // 
            this.txtBuscarFA.BackColor = System.Drawing.Color.Silver;
            this.txtBuscarFA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarFA.BackgroundImage")));
            this.txtBuscarFA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarFA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFA.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscarFA.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarFA.Icon")));
            this.txtBuscarFA.Location = new System.Drawing.Point(23, 25);
            this.txtBuscarFA.Name = "txtBuscarFA";
            this.txtBuscarFA.Size = new System.Drawing.Size(284, 32);
            this.txtBuscarFA.TabIndex = 29;
            this.txtBuscarFA.text = "BUSCAR POR APELLIDOS O DNI";
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.btnCancelarFraccionamientoFA);
            this.bunifuGradientPanel3.Controls.Add(this.txtEstadoFA);
            this.bunifuGradientPanel3.Controls.Add(this.txtPeriodoFA);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuGradientPanel3.Controls.Add(this.txtNumOperacionFA);
            this.bunifuGradientPanel3.Controls.Add(this.txtAlumnoFA);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel3.Controls.Add(this.txtDniFA);
            this.bunifuGradientPanel3.Controls.Add(this.txtCodigoFA);
            this.bunifuGradientPanel3.Controls.Add(this.btnFraccionarApafaFA);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel3.Controls.Add(this.dgvDeudasPendientesFA);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(487, 79);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(603, 405);
            this.bunifuGradientPanel3.TabIndex = 34;
            // 
            // btnCancelarFraccionamientoFA
            // 
            this.btnCancelarFraccionamientoFA.Location = new System.Drawing.Point(458, 289);
            this.btnCancelarFraccionamientoFA.Name = "btnCancelarFraccionamientoFA";
            this.btnCancelarFraccionamientoFA.Size = new System.Drawing.Size(118, 42);
            this.btnCancelarFraccionamientoFA.TabIndex = 54;
            this.btnCancelarFraccionamientoFA.Text = "CANCELAR FRACCIONAMIENTO";
            this.btnCancelarFraccionamientoFA.UseVisualStyleBackColor = true;
            // 
            // txtEstadoFA
            // 
            this.txtEstadoFA.Location = new System.Drawing.Point(249, 191);
            this.txtEstadoFA.Name = "txtEstadoFA";
            this.txtEstadoFA.Size = new System.Drawing.Size(138, 20);
            this.txtEstadoFA.TabIndex = 53;
            // 
            // txtPeriodoFA
            // 
            this.txtPeriodoFA.Location = new System.Drawing.Point(22, 191);
            this.txtPeriodoFA.Name = "txtPeriodoFA";
            this.txtPeriodoFA.Size = new System.Drawing.Size(138, 20);
            this.txtPeriodoFA.TabIndex = 52;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(246, 163);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(124, 13);
            this.bunifuCustomLabel7.TabIndex = 51;
            this.bunifuCustomLabel7.Text = "ESTADO DEL ALUMNO";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(19, 163);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(56, 13);
            this.bunifuCustomLabel8.TabIndex = 50;
            this.bunifuCustomLabel8.Text = "PERIODO";
            // 
            // txtNumOperacionFA
            // 
            this.txtNumOperacionFA.Location = new System.Drawing.Point(397, 72);
            this.txtNumOperacionFA.Name = "txtNumOperacionFA";
            this.txtNumOperacionFA.Size = new System.Drawing.Size(138, 20);
            this.txtNumOperacionFA.TabIndex = 49;
            // 
            // txtAlumnoFA
            // 
            this.txtAlumnoFA.Location = new System.Drawing.Point(22, 131);
            this.txtAlumnoFA.Name = "txtAlumnoFA";
            this.txtAlumnoFA.Size = new System.Drawing.Size(373, 20);
            this.txtAlumnoFA.TabIndex = 48;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(397, 44);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(118, 13);
            this.bunifuCustomLabel2.TabIndex = 47;
            this.bunifuCustomLabel2.Text = "NRO. DE OPERACIÓN";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(19, 103);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(53, 13);
            this.bunifuCustomLabel4.TabIndex = 46;
            this.bunifuCustomLabel4.Text = "ALUMNO";
            // 
            // txtDniFA
            // 
            this.txtDniFA.Location = new System.Drawing.Point(207, 72);
            this.txtDniFA.Name = "txtDniFA";
            this.txtDniFA.Size = new System.Drawing.Size(138, 20);
            this.txtDniFA.TabIndex = 45;
            // 
            // txtCodigoFA
            // 
            this.txtCodigoFA.Location = new System.Drawing.Point(22, 72);
            this.txtCodigoFA.Name = "txtCodigoFA";
            this.txtCodigoFA.Size = new System.Drawing.Size(138, 20);
            this.txtCodigoFA.TabIndex = 44;
            // 
            // btnFraccionarApafaFA
            // 
            this.btnFraccionarApafaFA.Location = new System.Drawing.Point(458, 228);
            this.btnFraccionarApafaFA.Name = "btnFraccionarApafaFA";
            this.btnFraccionarApafaFA.Size = new System.Drawing.Size(121, 42);
            this.btnFraccionarApafaFA.TabIndex = 43;
            this.btnFraccionarApafaFA.Text = "FRACCIONAR APAFA";
            this.btnFraccionarApafaFA.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(209, 44);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(26, 13);
            this.bunifuCustomLabel6.TabIndex = 42;
            this.bunifuCustomLabel6.Text = "DNI";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(19, 44);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(116, 13);
            this.bunifuCustomLabel5.TabIndex = 38;
            this.bunifuCustomLabel5.Text = "CODIGO DE ALUMNO";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(173, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(172, 16);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "DEUDAS PENDIENTES";
            // 
            // dgvDeudasPendientesFA
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDeudasPendientesFA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeudasPendientesFA.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDeudasPendientesFA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeudasPendientesFA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeudasPendientesFA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeudasPendientesFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudasPendientesFA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.clnSeleccionar});
            this.dgvDeudasPendientesFA.DoubleBuffered = true;
            this.dgvDeudasPendientesFA.EnableHeadersVisualStyles = false;
            this.dgvDeudasPendientesFA.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDeudasPendientesFA.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDeudasPendientesFA.Location = new System.Drawing.Point(22, 217);
            this.dgvDeudasPendientesFA.Name = "dgvDeudasPendientesFA";
            this.dgvDeudasPendientesFA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDeudasPendientesFA.Size = new System.Drawing.Size(430, 145);
            this.dgvDeudasPendientesFA.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "NRO DE OPERACIÓN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "AÑO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
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
            // gstFrmFraccionar_Apafa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 509);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pnlFraccionarApafa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmFraccionar_Apafa";
            this.Text = "gstFrmFraccionar_Apafa";
            this.pnlFraccionarApafa.ResumeLayout(false);
            this.pnlFraccionarApafa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoFA)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudasPendientesFA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlFraccionarApafa;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnoFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNombres;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarFA;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Button btnCancelarFraccionamientoFA;
        private System.Windows.Forms.TextBox txtEstadoFA;
        private System.Windows.Forms.TextBox txtPeriodoFA;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.TextBox txtNumOperacionFA;
        private System.Windows.Forms.TextBox txtAlumnoFA;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txtDniFA;
        private System.Windows.Forms.TextBox txtCodigoFA;
        private System.Windows.Forms.Button btnFraccionarApafaFA;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDeudasPendientesFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnSeleccionar;
    }
}