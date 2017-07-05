using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase18Cl;
using System.IO;

namespace Clase18Wf
{
    public partial class Form1 : Form, IGrafica
    {
        public Form1()
        {
            InitializeComponent();
            Empleado e2 = new Empleado("Franco", "Guerendiain", "31757094", EPuestoJerarquico.Sistemas, 2);
            e2.Mostrar(this);

        }

        public void MostrarEnGUI(string cadena)
        {
            this.textBox1.Text = cadena;
        }

        public bool EscribirTxT(string path, Empleado e)
        {
            try
            {
                using (StreamWriter st = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Empleado.txt"))
                {
                    st.WriteLine(e.ToString());

                }
                return true;
            }
            catch(Exception es)
            {
                Console.WriteLine(es.Message);
                return false;
            }
        }
    }
}
