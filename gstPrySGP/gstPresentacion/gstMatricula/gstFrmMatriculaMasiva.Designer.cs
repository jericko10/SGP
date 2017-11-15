namespace gstPresentacion.gstMatricula
{
    partial class gstFrmMatriculaMasiva
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMatriculaMasiva = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCerrarMM = new Bunifu.Framework.UI.BunifuImageButton();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.txtArchivoMM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarArchivoExcelMM = new System.Windows.Forms.Button();
            this.btnGenerarMatriculaMasivaMM = new System.Windows.Forms.Button();
            this.pnlMatriculaMasiva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMM)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlMatriculaMasiva
            // 
            this.pnlMatriculaMasiva.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlMatriculaMasiva.Controls.Add(this.bunifuCustomLabel1);
            this.pnlMatriculaMasiva.Controls.Add(this.btnCerrarMM);
            this.pnlMatriculaMasiva.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMatriculaMasiva.Location = new System.Drawing.Point(0, 0);
            this.pnlMatriculaMasiva.Name = "pnlMatriculaMasiva";
            this.pnlMatriculaMasiva.Size = new System.Drawing.Size(500, 32);
            this.pnlMatriculaMasiva.TabIndex = 31;
            this.pnlMatriculaMasiva.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMatriculaMasiva_Paint);
            this.pnlMatriculaMasiva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pnlMatriculaMasiva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pnlMatriculaMasiva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(154, 16);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "MATRÍCULA MASIVA";
            // 
            // btnCerrarMM
            // 
            this.btnCerrarMM.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarMM.BackgroundImage = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarMM.Image = global::gstPresentacion.Properties.Resources.close_1540630_960_720;
            this.btnCerrarMM.ImageActive = null;
            this.btnCerrarMM.Location = new System.Drawing.Point(454, 0);
            this.btnCerrarMM.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarMM.Name = "btnCerrarMM";
            this.btnCerrarMM.Size = new System.Drawing.Size(36, 29);
            this.btnCerrarMM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarMM.TabIndex = 31;
            this.btnCerrarMM.TabStop = false;
            this.btnCerrarMM.Zoom = 10;
            this.btnCerrarMM.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txtArchivoMM
            // 
            this.txtArchivoMM.Location = new System.Drawing.Point(55, 114);
            this.txtArchivoMM.Name = "txtArchivoMM";
            this.txtArchivoMM.Size = new System.Drawing.Size(187, 20);
            this.txtArchivoMM.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "ARCHIVO";
            // 
            // btnCargarArchivoExcelMM
            // 
            this.btnCargarArchivoExcelMM.Location = new System.Drawing.Point(286, 112);
            this.btnCargarArchivoExcelMM.Name = "btnCargarArchivoExcelMM";
            this.btnCargarArchivoExcelMM.Size = new System.Drawing.Size(153, 23);
            this.btnCargarArchivoExcelMM.TabIndex = 34;
            this.btnCargarArchivoExcelMM.Text = "CARGAR ARCHIVO EXCEL";
            this.btnCargarArchivoExcelMM.UseVisualStyleBackColor = true;
            // 
            // btnGenerarMatriculaMasivaMM
            // 
            this.btnGenerarMatriculaMasivaMM.Location = new System.Drawing.Point(181, 191);
            this.btnGenerarMatriculaMasivaMM.Name = "btnGenerarMatriculaMasivaMM";
            this.btnGenerarMatriculaMasivaMM.Size = new System.Drawing.Size(139, 54);
            this.btnGenerarMatriculaMasivaMM.TabIndex = 35;
            this.btnGenerarMatriculaMasivaMM.Text = "GENERAR MATRÍCULA MASIVA";
            this.btnGenerarMatriculaMasivaMM.UseVisualStyleBackColor = true;
            // 
            // gstFrmMatriculaMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 278);
            this.Controls.Add(this.btnGenerarMatriculaMasivaMM);
            this.Controls.Add(this.btnCargarArchivoExcelMM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArchivoMM);
            this.Controls.Add(this.pnlMatriculaMasiva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gstFrmMatriculaMasiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gstFrmMatriculaMasiva";
            this.pnlMatriculaMasiva.ResumeLayout(false);
            this.pnlMatriculaMasiva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlMatriculaMasiva;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarMM;
        private System.Windows.Forms.Button btnGenerarMatriculaMasivaMM;
        private System.Windows.Forms.Button btnCargarArchivoExcelMM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArchivoMM;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}