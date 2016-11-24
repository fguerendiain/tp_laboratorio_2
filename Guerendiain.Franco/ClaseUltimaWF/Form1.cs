using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseUltima;

namespace ClaseUltimaWF
{
    public partial class Form1 : Form
    {
        Moneda mon;

        public Form1()
        {
            InitializeComponent();
            mon = new Moneda();
            mon.Ganar += new DelMonedaWins(Ganamos);
            mon.Perder += new DelMonedaLose(Perdimos);

            foreach (ELado t in Enum.GetValues(typeof(ELado)))
            {
                this.cmbElejir.Items.Add(t);
            }

        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            mon.Tirar((ELado)this.cmbElejir.SelectedItem);
        }

        public void Ganamos()
        {
            this.lblResultado.Text = "Ganaste";
        }

        public void Perdimos(ELado lado)
        {
            this.lblResultado.Text = "Perdiste te salio " + lado;
        }

    }
}
