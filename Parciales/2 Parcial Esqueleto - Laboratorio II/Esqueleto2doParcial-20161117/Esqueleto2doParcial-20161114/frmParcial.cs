using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace Esqueleto2doParcial_20161114
{
    public partial class frmParcial : Form
    {
        Tienda t1 = new Tienda("MaxiDescuento", 22, "Av. Mitre 219");

        public frmParcial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Descomentar esta linea para probar el caso de Error del punto 9 y 10
                //
                //t1.SetAnchoDeFrente(23);
                //
                t1.guardar("tiendaGuardada.txt", Tienda.ExponerDatos(t1));
            }
            catch(AnchoFrenteInvalidoException)
            {
                MessageBox.Show("El Ancho del Frente no es valido");
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string cadena = "";
            t1.leer("tiendaGuardada.txt", out cadena);
            MessageBox.Show(cadena);
        }
    }
}
