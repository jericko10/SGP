using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstPre
{
    public partial class Form1 : Form
    {
        int botones;
        public Form1()
        {
            InitializeComponent();
            botones = this.Height - btnAlumno.Height;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //btnAlumno.Height = (this.Height - botones) / botones;
            //btnMatricula.Height =( this.Height - botones) / botones;
            //btnRecibo.Height = (this.Height - botones)/botones;
            //btnReporte.Height = (this.Height - botones)/ botones;
            //btnUsuario.Height = (this.Height - botones) / botones;

            
        }
    }
}
