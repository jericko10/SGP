namespace gstPresentacion
{
    partial class gstFrmReporteDeudasAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gstFrmReporteDeudasAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlReporteDeudasAlumno = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgdAlumno = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnApellidosNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.pnlReporteDeudasAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlReporteDeudasAlumno
            // 
            this.pnlReporteDeudasAlumno.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlReporteDeudasAlumno.Controls.Add(this.bunifuCustomLabel1);
            this.pnlReporteDeudasAlumno.Controls.Add(this.btnCerrar);
            this.pnlReporteDeudasAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReporteDeudasAlumno.Location = new System.Drawing.Point(0, 0);
            this.pnlReporteDeudasAlumno.Name = "pnlReporteDeudasAlumno";
            this.pnlReporteDeudasAlumno.Size = new System.Drawing.Size(827, 32);
            this.pnlReporteDeudasAlumno.TabIndex = 32;
            this.pnlReporteDeudasAlumno.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlReporteDeudasAlumno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlReporteDeudasAlumno_MouseDown);
            this.pnlReporteDeudasAlumno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlReporteDeudasAlumno_MouseMove);
            this.pnlReporteDeudasAlumno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlReporteDeudasAlumno_MouseUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(276, 16);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "REPORTE DE DEUDAS POR ALUMNO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(791, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnAnio,
            this.clnDeuda,
            this.clnMonto});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(28, 283);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(761, 210);
            this.bunifuCustomDataGrid1.TabIndex = 31;
            // 
            // clnAnio
            // 
            this.clnAnio.HeaderText = "AÑO";
            this.clnAnio.Name = "clnAnio";
            // 
            // clnDeuda
            // 
            this.clnDeuda.HeaderText = "DEUDA";
            this.clnDeuda.Name = "clnDeuda";
            // 
            // clnMonto
            // 
            this.clnMonto.HeaderText = "MONTO";
            this.clnMonto.Name = "clnMonto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 34;
            this.button1.Text = "GENERAR REPORTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 38);
            this.button2.TabIndex = 35;
            this.button2.Text = "IMPRIMIR REPORTE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(496, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.Text = "Tipo De Deuda";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(649, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.Text = "Año";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dgdAlumno);
            this.bunifuGradientPanel1.Controls.Add(this.txtBuscar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(28, 73);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(391, 175);
            this.bunifuGradientPanel1.TabIndex = 33;
            // 
            // dgdAlumno
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgdAlumno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdAlumno.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgdAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdAlumno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgdAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnApellidos,
            this.clnApellidosNombres});
            this.dgdAlumno.DoubleBuffered = true;
            this.dgdAlumno.EnableHeadersVisualStyles = false;
            this.dgdAlumno.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdAlumno.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgdAlumno.Location = new System.Drawing.Point(23, 65);
            this.dgdAlumno.Name = "dgdAlumno";
            this.dgdAlumno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdAlumno.Size = new System.Drawing.Size(345, 79);
            this.dgdAlumno.TabIndex = 30;
            // 
            // clnCodigo
            // 
            this.clnCodigo.HeaderText = "CÓDIGO";
            this.clnCodigo.Name = "clnCodigo";
            // 
            // clnApellidos
            // 
            this.clnApellidos.HeaderText = "DNI";
            this.clnApellidos.Name = "clnApellidos";
            // 
            // clnApellidosNombres
            // 
            this.clnApellidosNombres.HeaderText = "APELLIDOS Y NOMBRES";
            this.clnApellidosNombres.Name = "clnApellidosNombres";
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
            this.txtBuscar.Size = new System.Drawing.Size(280, 25);
            this.txtBuscar.TabIndex = 29;
            this.txtBuscar.text = "BUSCAR POR APELLIDOS O DNI";
            // 
            // gstFrmReporteDeudasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(827, 505);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pnlReporteDeudasAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmReporteDeudasAlumno";
            this.Text = "gstFrmReporteDeudasAlumno";
            this.pnlReporteDeudasAlumno.ResumeLayout(false);
            this.pnlReporteDeudasAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlReporteDeudasAlumno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMonto;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnApellidosNombres;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
    }
}