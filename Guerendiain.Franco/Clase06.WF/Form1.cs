using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06.WF
{
    public partial class Form1 : Form
    {

        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {

            this.lblHolaMundo.Text = "Hola Mundo!!";

            switch (contador)
            {
                case 0:
                    this.BackColor = Color.Purple;
                    contador++;
                    break;

                case 1:
                    this.BackColor = Color.Red;
                    contador++;
                    break;

                case 2:
                    this.BackColor = Color.Yellow;
                    contador++;
                    break;

                case 3:
                    this.BackColor = Color.Green;
                    contador = 0;
                    break;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenido " + DateTime.Now;
        }
    }
}
