namespace gstPresentacion
{
    partial class gstFrmReporteDeudasSeccion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlReporteDeudasSeccion = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEnero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABRIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCTUBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnBanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQaliWarma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlReporteDeudasSeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlReporteDeudasSeccion
            // 
            this.pnlReporteDeudasSeccion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlReporteDeudasSeccion.Controls.Add(this.bunifuCustomLabel1);
            this.pnlReporteDeudasSeccion.Controls.Add(this.btnCerrar);
            this.pnlReporteDeudasSeccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReporteDeudasSeccion.Location = new System.Drawing.Point(0, 0);
            this.pnlReporteDeudasSeccion.Name = "pnlReporteDeudasSeccion";
            this.pnlReporteDeudasSeccion.Size = new System.Drawing.Size(845, 32);
            this.pnlReporteDeudasSeccion.TabIndex = 33;
            this.pnlReporteDeudasSeccion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlReporteDeudasSeccion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlReporteDeudasSeccion_MouseDown);
            this.pnlReporteDeudasSeccion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlReporteDeudasSeccion_MouseMove);
            this.pnlReporteDeudasSeccion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlReporteDeudasSeccion_MouseUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(279, 16);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "REPORTE DE DEUDAS POR SECCIÓN";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.Text = "NIVEL";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(629, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.Text = "AÑO";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(436, 59);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 36;
            this.comboBox3.Text = "SECCIÓN";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(249, 59);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 37;
            this.comboBox4.Text = "GRADO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "GENERAR REPORTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "IMPRIMIR REPORTE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnAlumnos,
            this.clnMatricula,
            this.clnEnero,
            this.Column1,
            this.Column2,
            this.ABRIL,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.OCTUBRE,
            this.Column8,
            this.Column9});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(12, 164);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(378, 217);
            this.bunifuCustomDataGrid1.TabIndex = 40;
            // 
            // clnAlumnos
            // 
            this.clnAlumnos.HeaderText = "ALUMNOS";
            this.clnAlumnos.Name = "clnAlumnos";
            // 
            // clnMatricula
            // 
            this.clnMatricula.HeaderText = "MATRICULA";
            this.clnMatricula.Name = "clnMatricula";
            // 
            // clnEnero
            // 
            this.clnEnero.HeaderText = "ENERO";
            this.clnEnero.Name = "clnEnero";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FEBRERO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MARZO";
            this.Column2.Name = "Column2";
            // 
            // ABRIL
            // 
            this.ABRIL.HeaderText = "ABRIL";
            this.ABRIL.Name = "ABRIL";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MAYO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "JUNIO";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "JULIO";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "AGOSTO";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "SETIEMPRE";
            this.Column7.Name = "Column7";
            // 
            // OCTUBRE
            // 
            this.OCTUBRE.HeaderText = "OCTUBRE";
            this.OCTUBRE.Name = "OCTUBRE";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "NOVIEMBRE";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "DICIMBRE";
            this.Column9.Name = "Column9";
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnBanda,
            this.clnQaliWarma});
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(463, 164);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(300, 217);
            this.bunifuCustomDataGrid2.TabIndex = 41;
            // 
            // clnBanda
            // 
            this.clnBanda.HeaderText = "BANDA";
            this.clnBanda.Name = "clnBanda";
            // 
            // clnQaliWarma
            // 
            this.clnQaliWarma.HeaderText = "QALIWARMA";
            this.clnQaliWarma.Name = "clnQaliWarma";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(525, 410);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(63, 13);
            this.bunifuCustomLabel2.TabIndex = 42;
            this.bunifuCustomLabel2.Text = "% PAGADO";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(525, 445);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel3.TabIndex = 43;
            this.bunifuCustomLabel3.Text = "% DEBE";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Location = new System.Drawing.Point(629, 403);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 44;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.Location = new System.Drawing.Point(629, 445);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 45;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(800, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gstFrmReporteDeudasSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 566);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlReporteDeudasSeccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmReporteDeudasSeccion";
            this.Text = "gstFrmGestionarDeudasSeccion";
            this.pnlReporteDeudasSeccion.ResumeLayout(false);
            this.pnlReporteDeudasSeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlReporteDeudasSeccion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEnero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABRIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCTUBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQaliWarma;
    }
}