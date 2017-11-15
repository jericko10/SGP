namespace gstPresentacion
{
    partial class gstFrmReportePagoDiario
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlReportePagoDiario = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.pnlReportePagoDiario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlReportePagoDiario
            // 
            this.pnlReportePagoDiario.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlReportePagoDiario.Controls.Add(this.bunifuCustomLabel1);
            this.pnlReportePagoDiario.Controls.Add(this.btnCerrar);
            this.pnlReportePagoDiario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportePagoDiario.Location = new System.Drawing.Point(0, 0);
            this.pnlReportePagoDiario.Name = "pnlReportePagoDiario";
            this.pnlReportePagoDiario.Size = new System.Drawing.Size(830, 32);
            this.pnlReportePagoDiario.TabIndex = 33;
            this.pnlReportePagoDiario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlReportePagoDiario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlReportePagoDiario_MouseDown);
            this.pnlReportePagoDiario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlReportePagoDiario_MouseMove);
            this.pnlReportePagoDiario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlReportePagoDiario_MouseUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(182, 16);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "REPORTE PAGO DIARIO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(788, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(439, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "GENERAR REPORTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(623, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "IMPRIMIR REPORTE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFecha,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(51, 136);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(744, 209);
            this.bunifuCustomDataGrid1.TabIndex = 36;
            // 
            // clnFecha
            // 
            this.clnFecha.HeaderText = "FECHA";
            this.clnFecha.Name = "clnFecha";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RECIBO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "APELLIDOS Y NOMBRES";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NIVEL";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GRADO";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SECCIÓN";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DETALLE";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "MONTO";
            this.Column7.Name = "Column7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "TOTAL";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Location = new System.Drawing.Point(667, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 39;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(51, 84);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(295, 32);
            this.bunifuDatepicker1.TabIndex = 40;
            this.bunifuDatepicker1.Value = new System.DateTime(2017, 10, 29, 23, 4, 59, 423);
            // 
            // gstFrmReportePagoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 414);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlReportePagoDiario);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmReportePagoDiario";
            this.Text = "gstFrmReportePagoDiario";
            this.pnlReportePagoDiario.ResumeLayout(false);
            this.pnlReportePagoDiario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlReportePagoDiario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}