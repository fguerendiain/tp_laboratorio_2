using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empleado;

namespace Clase08WF
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float ganancia;
            float.TryParse(this.mtxtGanancias.Text, out ganancia);
            Empresa e1 = new Empresa(this.txtRazonSocial.Text, this.txtDireccion.Text, ganancia);
           // Form2.ActiveForm.Des; //INTENTANDO CERRAR LA VENTANA PARA ABRIR EL FORM1
        }
    }
}
