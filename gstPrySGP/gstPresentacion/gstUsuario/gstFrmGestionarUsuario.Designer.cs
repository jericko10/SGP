namespace gstPresentacion
{
    partial class gstFrmGestionarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmGestionarUsuario));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlGestionarUsuario = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtDni = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtApellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtObservacion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblApellido = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblObservacion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDni = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCodigo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.dgdAlumno = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApellidosNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNivelGradoSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlGestionarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlGestionarUsuario
            // 
            this.pnlGestionarUsuario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlGestionarUsuario.Controls.Add(this.bunifuCustomLabel1);
            this.pnlGestionarUsuario.Controls.Add(this.btnCerrar);
            this.pnlGestionarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestionarUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionarUsuario.Name = "pnlGestionarUsuario";
            this.pnlGestionarUsuario.Size = new System.Drawing.Size(669, 32);
            this.pnlGestionarUsuario.TabIndex = 32;
            this.pnlGestionarUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlGestionarUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGestionarUsuario_MouseDown);
            this.pnlGestionarUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGestionarUsuario_MouseMove);
            this.pnlGestionarUsuario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGestionarUsuario_MouseUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(168, 16);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "GESTIONAR USUARIO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(624, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDni
            // 
            this.txtDni.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtDni.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDni.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtDni.BorderThickness = 3;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDni.isPassword = false;
            this.txtDni.Location = new System.Drawing.Point(36, 125);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(132, 24);
            this.txtDni.TabIndex = 42;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNombre.BorderThickness = 3;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.isPassword = false;
            this.txtNombre.Location = new System.Drawing.Point(36, 173);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 24);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtApellido.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtApellido.BorderThickness = 3;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.isPassword = false;
            this.txtApellido.Location = new System.Drawing.Point(36, 225);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 24);
            this.txtApellido.TabIndex = 40;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtObservacion.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtObservacion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservacion.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtObservacion.BorderThickness = 3;
            this.txtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservacion.isPassword = false;
            this.txtObservacion.Location = new System.Drawing.Point(329, 166);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(132, 25);
            this.txtObservacion.TabIndex = 39;
            this.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCodigo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCodigo.BorderThickness = 3;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.isPassword = false;
            this.txtCodigo.Location = new System.Drawing.Point(36, 76);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 24);
            this.txtCodigo.TabIndex = 38;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 156);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(33, 208);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 36;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(326, 149);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(56, 13);
            this.lblObservacion.TabIndex = 35;
            this.lblObservacion.Text = "USUARIO";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(33, 108);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 34;
            this.lblDni.Text = "DNI";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(33, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 33;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(495, 166);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(132, 25);
            this.bunifuMetroTextbox1.TabIndex = 44;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(492, 149);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 13);
            this.bunifuCustomLabel2.TabIndex = 43;
            this.bunifuCustomLabel2.Text = "CONTRASEÑA";
            // 
            // cmbGrado
            // 
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(329, 105);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(132, 21);
            this.cmbGrado.TabIndex = 48;
            this.cmbGrado.Text = "GRADO";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(495, 68);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(132, 21);
            this.cmbSeccion.TabIndex = 47;
            this.cmbSeccion.Text = "SECCIÓN";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(495, 108);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(132, 21);
            this.cmbEstado.TabIndex = 46;
            this.cmbEstado.Text = "ESTADO";
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(329, 69);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(132, 21);
            this.cmbNivel.TabIndex = 45;
            this.cmbNivel.Text = "NIVEL";
            // 
            // dgdAlumno
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgdAlumno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdAlumno.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgdAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdAlumno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnDni,
            this.clnApellidosNombres,
            this.clnPeriodo,
            this.clnNivelGradoSeccion});
            this.dgdAlumno.DoubleBuffered = true;
            this.dgdAlumno.EnableHeadersVisualStyles = false;
            this.dgdAlumno.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdAlumno.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgdAlumno.Location = new System.Drawing.Point(36, 272);
            this.dgdAlumno.Name = "dgdAlumno";
            this.dgdAlumno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdAlumno.Size = new System.Drawing.Size(591, 306);
            this.dgdAlumno.TabIndex = 50;
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
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Silver;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(329, 225);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(181, 24);
            this.txtBuscar.TabIndex = 49;
            this.txtBuscar.text = "BUSCAR ALUMNO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gstFrmGestionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgdAlumno);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pnlGestionarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmGestionarUsuario";
            this.Text = "gstFrmGestionarUsuario";
            this.pnlGestionarUsuario.ResumeLayout(false);
            this.pnlGestionarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlGestionarUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDni;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtApellido;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtObservacion;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCodigo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lblApellido;
        private Bunifu.Framework.UI.BunifuCustomLabel lblObservacion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDni;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCodigo;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApellidosNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNivelGradoSeccion;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
    }
}