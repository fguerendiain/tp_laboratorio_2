using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using Hilo;
using System.Net;

namespace Navegador
{
    public partial class frmWebBrowser : Form
    {
        private const string ESCRIBA_AQUI = "Escriba aquí...";
        Archivos.Texto historial;

        public frmWebBrowser()
        {
            InitializeComponent();
        }

        private void frmWebBrowser_Load(object sender, EventArgs e)
        {
            this.txtUrl.SelectionStart = 0;  //This keeps the text
            this.txtUrl.SelectionLength = 0; //from being highlighted
            this.txtUrl.ForeColor = Color.Gray;
            this.txtUrl.Text = frmWebBrowser.ESCRIBA_AQUI;
            this.tspbProgreso.Minimum = 0;
            this.tspbProgreso.Maximum = 100;

            this.historial = new Archivos.Texto(frmHistorial.ARCHIVO_HISTORIAL);
        }

        #region "Escriba aquí..."
        private void txtUrl_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.IBeam; //Without this the mouse pointer shows busy
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtUrl.Text.Equals(frmWebBrowser.ESCRIBA_AQUI) == true)
            {
                this.txtUrl.Text = "";
                this.txtUrl.ForeColor = Color.Black;
            }
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.txtUrl.Text.Equals(null) == true || this.txtUrl.Text.Equals("") == true)
            {
                this.txtUrl.Text = frmWebBrowser.ESCRIBA_AQUI;
                this.txtUrl.ForeColor = Color.Gray;
            }
        }

        private void txtUrl_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtUrl.SelectAll();
        }
        #endregion

        private void mostrarTodoElHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial historial = new frmHistorial();
            historial.Show();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            String requestedURL = this.cleanUrl(this.txtUrl.Text);
            this.txtUrl.Text = requestedURL;
            this.downloadData(requestedURL);
            this.historial.guardar(requestedURL);
        }

        private String cleanUrl(String requestedURL)
        {
            if (!requestedURL.StartsWith("http://") && !requestedURL.StartsWith("https://"))
            {
                return "http://" + requestedURL;
            }
            else
            {
                return requestedURL;
            }
        }

        private void downloadData(String url)
        {
            this.tspbProgreso.Value = 0;
            Uri uri = new Uri(url);
            Hilo.Descargador downloader = new Hilo.Descargador(uri, this.onDownloadProgressChanged, this.onDownloadCompleted);
            downloader.IniciarDescarga();
        }

        private void onDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.tspbProgreso.Value = e.ProgressPercentage;
        }

        private void onDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            this.tspbProgreso.Value = 100;
            this.rtxtHtmlCode.Text = e.Result;
        }

    }
}
