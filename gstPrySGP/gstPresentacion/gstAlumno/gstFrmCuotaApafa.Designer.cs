namespace gstPresentacion
{
    partial class gstFrmCuotaApafa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmCuotaApafa));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtObservacionCA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSeccionGA = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtGradoCA = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNivelCA = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtAlumnoCA = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dgvCuotaApafa = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApellidosNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnaApafaPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApafaCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCuotaApafa = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrarCuotaApafa = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCancelarCuotaApafa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarCuotaApafa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbxEstadoCA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotaApafa)).BeginInit();
            this.pnlCuotaApafa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCuotaApafa)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(53, 58);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(53, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "ALUMNO";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(53, 105);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "NIVEL";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(53, 154);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(46, 13);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "GRADO";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(53, 267);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(51, 13);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "ESTADO";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(53, 210);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(54, 13);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "SECCIÓN";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(302, 58);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(84, 13);
            this.bunifuCustomLabel6.TabIndex = 10;
            this.bunifuCustomLabel6.Text = "OBSERVACION";
            // 
            // txtObservacionCA
            // 
            this.txtObservacionCA.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtObservacionCA.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservacionCA.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtObservacionCA.BorderThickness = 3;
            this.txtObservacionCA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacionCA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtObservacionCA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservacionCA.isPassword = false;
            this.txtObservacionCA.Location = new System.Drawing.Point(305, 75);
            this.txtObservacionCA.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacionCA.Name = "txtObservacionCA";
            this.txtObservacionCA.Size = new System.Drawing.Size(233, 92);
            this.txtObservacionCA.TabIndex = 11;
            this.txtObservacionCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSeccionGA
            // 
            this.txtSeccionGA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSeccionGA.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSeccionGA.Location = new System.Drawing.Point(56, 226);
            this.txtSeccionGA.Name = "txtSeccionGA";
            this.txtSeccionGA.Size = new System.Drawing.Size(100, 20);
            this.txtSeccionGA.TabIndex = 9;
            // 
            // txtGradoCA
            // 
            this.txtGradoCA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtGradoCA.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtGradoCA.Location = new System.Drawing.Point(56, 170);
            this.txtGradoCA.Name = "txtGradoCA";
            this.txtGradoCA.Size = new System.Drawing.Size(100, 20);
            this.txtGradoCA.TabIndex = 7;
            // 
            // txtNivelCA
            // 
            this.txtNivelCA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNivelCA.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNivelCA.Location = new System.Drawing.Point(56, 121);
            this.txtNivelCA.Name = "txtNivelCA";
            this.txtNivelCA.Size = new System.Drawing.Size(159, 20);
            this.txtNivelCA.TabIndex = 8;
            // 
            // txtAlumnoCA
            // 
            this.txtAlumnoCA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAlumnoCA.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAlumnoCA.Location = new System.Drawing.Point(56, 74);
            this.txtAlumnoCA.Name = "txtAlumnoCA";
            this.txtAlumnoCA.Size = new System.Drawing.Size(212, 20);
            this.txtAlumnoCA.TabIndex = 5;
            // 
            // dgvCuotaApafa
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCuotaApafa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuotaApafa.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCuotaApafa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuotaApafa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuotaApafa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuotaApafa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotaApafa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnDni,
            this.clnApellidosNombres,
            this.clnaApafaPeriodo,
            this.clnApafaCuota,
            this.clnObservacion});
            this.dgvCuotaApafa.DoubleBuffered = true;
            this.dgvCuotaApafa.EnableHeadersVisualStyles = false;
            this.dgvCuotaApafa.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCuotaApafa.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCuotaApafa.Location = new System.Drawing.Point(25, 329);
            this.dgvCuotaApafa.Name = "dgvCuotaApafa";
            this.dgvCuotaApafa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCuotaApafa.Size = new System.Drawing.Size(542, 318);
            this.dgvCuotaApafa.TabIndex = 27;
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
            // clnaApafaPeriodo
            // 
            this.clnaApafaPeriodo.HeaderText = "APAFA PERIODO";
            this.clnaApafaPeriodo.Name = "clnaApafaPeriodo";
            // 
            // clnApafaCuota
            // 
            this.clnApafaCuota.HeaderText = "APAFA-CUOTA";
            this.clnApafaCuota.Name = "clnApafaCuota";
            // 
            // clnObservacion
            // 
            this.clnObservacion.HeaderText = "OBSERVACIÓN";
            this.clnObservacion.Name = "clnObservacion";
            // 
            // pnlCuotaApafa
            // 
            this.pnlCuotaApafa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlCuotaApafa.Controls.Add(this.bunifuCustomLabel8);
            this.pnlCuotaApafa.Controls.Add(this.btnCerrarCuotaApafa);
            this.pnlCuotaApafa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCuotaApafa.Location = new System.Drawing.Point(0, 0);
            this.pnlCuotaApafa.Name = "pnlCuotaApafa";
            this.pnlCuotaApafa.Size = new System.Drawing.Size(584, 32);
            this.pnlCuotaApafa.TabIndex = 31;
            this.pnlCuotaApafa.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCuotaApafa_Paint);
            this.pnlCuotaApafa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCuotaApafa_MouseDown);
            this.pnlCuotaApafa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCuotaApafa_MouseMove);
            this.pnlCuotaApafa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCuotaApafa_MouseUp);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(53, 9);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(113, 16);
            this.bunifuCustomLabel8.TabIndex = 31;
            this.bunifuCustomLabel8.Text = "CUOTA APAFA";
            this.bunifuCustomLabel8.Click += new System.EventHandler(this.bunifuCustomLabel8_Click);
            // 
            // btnCerrarCuotaApafa
            // 
            this.btnCerrarCuotaApafa.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarCuotaApafa.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarCuotaApafa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarCuotaApafa.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarCuotaApafa.ImageActive = null;
            this.btnCerrarCuotaApafa.Location = new System.Drawing.Point(548, 3);
            this.btnCerrarCuotaApafa.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarCuotaApafa.Name = "btnCerrarCuotaApafa";
            this.btnCerrarCuotaApafa.Size = new System.Drawing.Size(36, 29);
            this.btnCerrarCuotaApafa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarCuotaApafa.TabIndex = 31;
            this.btnCerrarCuotaApafa.TabStop = false;
            this.btnCerrarCuotaApafa.Zoom = 10;
            this.btnCerrarCuotaApafa.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelarCuotaApafa
            // 
            this.btnCancelarCuotaApafa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelarCuotaApafa.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelarCuotaApafa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarCuotaApafa.BorderRadius = 0;
            this.btnCancelarCuotaApafa.ButtonText = "CANCELAR CUOTA DE APAFA";
            this.btnCancelarCuotaApafa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCuotaApafa.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelarCuotaApafa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCuotaApafa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelarCuotaApafa.Iconimage = global::gstPresentacion.Properties.Resources.cancel;
            this.btnCancelarCuotaApafa.Iconimage_right = null;
            this.btnCancelarCuotaApafa.Iconimage_right_Selected = null;
            this.btnCancelarCuotaApafa.Iconimage_Selected = null;
            this.btnCancelarCuotaApafa.IconMarginLeft = 0;
            this.btnCancelarCuotaApafa.IconMarginRight = 0;
            this.btnCancelarCuotaApafa.IconRightVisible = true;
            this.btnCancelarCuotaApafa.IconRightZoom = 0D;
            this.btnCancelarCuotaApafa.IconVisible = true;
            this.btnCancelarCuotaApafa.IconZoom = 30D;
            this.btnCancelarCuotaApafa.IsTab = false;
            this.btnCancelarCuotaApafa.Location = new System.Drawing.Point(352, 241);
            this.btnCancelarCuotaApafa.Name = "btnCancelarCuotaApafa";
            this.btnCancelarCuotaApafa.Normalcolor = System.Drawing.Color.Maroon;
            this.btnCancelarCuotaApafa.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnCancelarCuotaApafa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelarCuotaApafa.selected = false;
            this.btnCancelarCuotaApafa.Size = new System.Drawing.Size(152, 50);
            this.btnCancelarCuotaApafa.TabIndex = 22;
            this.btnCancelarCuotaApafa.Text = "CANCELAR CUOTA DE APAFA";
            this.btnCancelarCuotaApafa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelarCuotaApafa.Textcolor = System.Drawing.Color.White;
            this.btnCancelarCuotaApafa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAgregarCuotaApafa
            // 
            this.btnAgregarCuotaApafa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarCuotaApafa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCuotaApafa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCuotaApafa.BorderRadius = 0;
            this.btnAgregarCuotaApafa.ButtonText = "AGREGAR CUOTA DE APAFA";
            this.btnAgregarCuotaApafa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCuotaApafa.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarCuotaApafa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCuotaApafa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCuotaApafa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCuotaApafa.Iconimage")));
            this.btnAgregarCuotaApafa.Iconimage_right = null;
            this.btnAgregarCuotaApafa.Iconimage_right_Selected = null;
            this.btnAgregarCuotaApafa.Iconimage_Selected = null;
            this.btnAgregarCuotaApafa.IconMarginLeft = 0;
            this.btnAgregarCuotaApafa.IconMarginRight = 0;
            this.btnAgregarCuotaApafa.IconRightVisible = true;
            this.btnAgregarCuotaApafa.IconRightZoom = 0D;
            this.btnAgregarCuotaApafa.IconVisible = true;
            this.btnAgregarCuotaApafa.IconZoom = 90D;
            this.btnAgregarCuotaApafa.IsTab = false;
            this.btnAgregarCuotaApafa.Location = new System.Drawing.Point(352, 183);
            this.btnAgregarCuotaApafa.Name = "btnAgregarCuotaApafa";
            this.btnAgregarCuotaApafa.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCuotaApafa.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarCuotaApafa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarCuotaApafa.selected = false;
            this.btnAgregarCuotaApafa.Size = new System.Drawing.Size(152, 52);
            this.btnAgregarCuotaApafa.TabIndex = 21;
            this.btnAgregarCuotaApafa.Text = "AGREGAR CUOTA DE APAFA";
            this.btnAgregarCuotaApafa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCuotaApafa.Textcolor = System.Drawing.Color.White;
            this.btnAgregarCuotaApafa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCuotaApafa.Click += new System.EventHandler(this.btnAgregarCuotaApafa_Click);
            // 
            // cbxEstadoCA
            // 
            this.cbxEstadoCA.FormattingEnabled = true;
            this.cbxEstadoCA.Location = new System.Drawing.Point(56, 283);
            this.cbxEstadoCA.Name = "cbxEstadoCA";
            this.cbxEstadoCA.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoCA.TabIndex = 32;
            // 
            // gstFrmCuotaApafa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 687);
            this.Controls.Add(this.cbxEstadoCA);
            this.Controls.Add(this.pnlCuotaApafa);
            this.Controls.Add(this.dgvCuotaApafa);
            this.Controls.Add(this.btnCancelarCuotaApafa);
            this.Controls.Add(this.btnAgregarCuotaApafa);
            this.Controls.Add(this.txtObservacionCA);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtSeccionGA);
            this.Controls.Add(this.txtNivelCA);
            this.Controls.Add(this.txtGradoCA);
            this.Controls.Add(this.txtAlumnoCA);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmCuotaApafa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "gstFrmCuotaAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotaApafa)).EndInit();
            this.pnlCuotaApafa.ResumeLayout(false);
            this.pnlCuotaApafa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCuotaApafa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtObservacionCA;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSeccionGA;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNivelCA;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtGradoCA;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtAlumnoCA;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelarCuotaApafa;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarCuotaApafa;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCuotaApafa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApellidosNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnaApafaPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApafaCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnObservacion;
        private System.Windows.Forms.Panel pnlCuotaApafa;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarCuotaApafa;
        private System.Windows.Forms.ComboBox cbxEstadoCA;
    }
}