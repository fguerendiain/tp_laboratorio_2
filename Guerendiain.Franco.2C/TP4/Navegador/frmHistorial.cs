using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;
using System.IO;

namespace Navegador
{
    public partial class frmHistorial : Form
    {
        public const string ARCHIVO_HISTORIAL = "historico.dat";

        public frmHistorial()
        {
            List<string> historial = new List<string>();
            StringBuilder cadena = new StringBuilder();

            InitializeComponent();
            Texto historico = new Texto(ARCHIVO_HISTORIAL);
            historico.leer(out historial);
            foreach (string t in historial)
            {
                cadena.AppendLine(t);
            }
        
            lstHistorial.Text = cadena.ToString();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            Archivos.Texto archivos = new Archivos.Texto(frmHistorial.ARCHIVO_HISTORIAL);

            
        }
    }
}
