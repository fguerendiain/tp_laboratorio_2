using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOperar_Click(object sender, EventArgs e)
        {

            double resultado;

            Numero num1 = new Numero(this.txtNumero1.Text);
            Numero num2 = new Numero(this.txtNumero2.Text);

            resultado = Calculadora.operar(num1, num2, cmbOperacion.Text);

            this.lblResultado.Text = resultado.ToString();

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
        }
    }
}
