namespace gstPresentacion
{
    partial class gstFrmRecibo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblAlumno = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNivel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSeccion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGrado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEstado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEstado = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtSeccion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtGrado = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNivel = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtAlumno = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtCodigoAlumno = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtCodigoRecibo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblCodigoRecibo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCodigoAlumno = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgdRecibo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtTotal = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlRecibo = new System.Windows.Forms.Panel();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgdRecibo)).BeginInit();
            this.pnlRecibo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(50, 69);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(53, 13);
            this.lblAlumno.TabIndex = 1;
            this.lblAlumno.Text = "ALUMNO";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(50, 122);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(38, 13);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "NIVEL";
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Location = new System.Drawing.Point(188, 185);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(54, 13);
            this.lblSeccion.TabIndex = 3;
            this.lblSeccion.Text = "SECCIÓN";
            this.lblSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(50, 185);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(46, 13);
            this.lblGrado.TabIndex = 4;
            this.lblGrado.Text = "GRADO";
            this.lblGrado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(50, 245);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "ESTADO";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEstado.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(53, 270);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(122, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // txtSeccion
            // 
            this.txtSeccion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSeccion.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSeccion.Enabled = false;
            this.txtSeccion.Location = new System.Drawing.Point(191, 201);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(96, 20);
            this.txtSeccion.TabIndex = 7;
            // 
            // txtGrado
            // 
            this.txtGrado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtGrado.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtGrado.Enabled = false;
            this.txtGrado.Location = new System.Drawing.Point(53, 201);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(93, 20);
            this.txtGrado.TabIndex = 8;
            // 
            // txtNivel
            // 
            this.txtNivel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNivel.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNivel.Enabled = false;
            this.txtNivel.Location = new System.Drawing.Point(53, 138);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(155, 20);
            this.txtNivel.TabIndex = 9;
            // 
            // txtAlumno
            // 
            this.txtAlumno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAlumno.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAlumno.Enabled = false;
            this.txtAlumno.Location = new System.Drawing.Point(53, 85);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(234, 20);
            this.txtAlumno.TabIndex = 10;
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigoAlumno.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCodigoAlumno.Enabled = false;
            this.txtCodigoAlumno.Location = new System.Drawing.Point(365, 85);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(155, 20);
            this.txtCodigoAlumno.TabIndex = 14;
            // 
            // txtCodigoRecibo
            // 
            this.txtCodigoRecibo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigoRecibo.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCodigoRecibo.Enabled = false;
            this.txtCodigoRecibo.Location = new System.Drawing.Point(365, 138);
            this.txtCodigoRecibo.Name = "txtCodigoRecibo";
            this.txtCodigoRecibo.Size = new System.Drawing.Size(155, 20);
            this.txtCodigoRecibo.TabIndex = 13;
            // 
            // lblCodigoRecibo
            // 
            this.lblCodigoRecibo.AutoSize = true;
            this.lblCodigoRecibo.Location = new System.Drawing.Point(362, 122);
            this.lblCodigoRecibo.Name = "lblCodigoRecibo";
            this.lblCodigoRecibo.Size = new System.Drawing.Size(110, 13);
            this.lblCodigoRecibo.TabIndex = 12;
            this.lblCodigoRecibo.Text = "CÓDIGO DE RECIBO";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(362, 69);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(116, 13);
            this.lblCodigoAlumno.TabIndex = 11;
            this.lblCodigoAlumno.Text = "CÓDIGO DE ALUMNO";
            // 
            // dgdRecibo
            // 
            this.dgdRecibo.AllowUserToAddRows = false;
            this.dgdRecibo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgdRecibo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgdRecibo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgdRecibo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdRecibo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdRecibo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgdRecibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdRecibo.DoubleBuffered = true;
            this.dgdRecibo.EnableHeadersVisualStyles = false;
            this.dgdRecibo.HeaderBgColor = System.Drawing.Color.PowderBlue;
            this.dgdRecibo.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgdRecibo.Location = new System.Drawing.Point(53, 320);
            this.dgdRecibo.Name = "dgdRecibo";
            this.dgdRecibo.ReadOnly = true;
            this.dgdRecibo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdRecibo.Size = new System.Drawing.Size(467, 103);
            this.dgdRecibo.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotal.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(424, 442);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(362, 449);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "TOTAL:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(435, 481);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pnlRecibo
            // 
            this.pnlRecibo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlRecibo.Controls.Add(this.lblTitulo);
            this.pnlRecibo.Controls.Add(this.btnCerrar);
            this.pnlRecibo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecibo.Location = new System.Drawing.Point(0, 0);
            this.pnlRecibo.Name = "pnlRecibo";
            this.pnlRecibo.Size = new System.Drawing.Size(566, 32);
            this.pnlRecibo.TabIndex = 34;
            this.pnlRecibo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlRecibo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRecibo_MouseDown);
            this.pnlRecibo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlRecibo_MouseMove);
            this.pnlRecibo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlRecibo_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(25, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(64, 16);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "RECIBO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(521, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gstFrmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 520);
            this.Controls.Add(this.pnlRecibo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgdRecibo);
            this.Controls.Add(this.txtCodigoAlumno);
            this.Controls.Add(this.txtCodigoRecibo);
            this.Controls.Add(this.lblCodigoRecibo);
            this.Controls.Add(this.lblCodigoAlumno);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblAlumno);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmRecibo";
            this.Text = "gstFrmRecibo";
            this.Load += new System.EventHandler(this.gstFrmRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdRecibo)).EndInit();
            this.pnlRecibo.ResumeLayout(false);
            this.pnlRecibo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEstado;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGrado;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSeccion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNivel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAlumno;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotal;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgdRecibo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCodigoAlumno;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCodigoRecibo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCodigoRecibo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCodigoAlumno;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtAlumno;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNivel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtGrado;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSeccion;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtEstado;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel pnlRecibo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
    }
}