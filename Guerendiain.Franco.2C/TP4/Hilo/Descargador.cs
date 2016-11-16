using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Net; // Avisar del espacio de nombre
using System.ComponentModel;

namespace Hilo
{
    public class Descargador
    {
        private string html;
        private Uri direccion;
        private WebClient cliente;
        private System.Net.DownloadProgressChangedEventHandler onProgressChanged;
        private System.Net.DownloadStringCompletedEventHandler onDownloadComplete;

        public Descargador(Uri direccion, System.Net.DownloadProgressChangedEventHandler onProgressChanged, System.Net.DownloadStringCompletedEventHandler onDownloadComplete)
        {
            this.html = direccion.AbsolutePath;
            this.direccion = direccion;
            this.cliente = new WebClient();

            this.cliente.DownloadProgressChanged += this.WebClientDownloadProgressChanged;
            this.cliente.DownloadProgressChanged += onProgressChanged;

            this.cliente.DownloadStringCompleted += this.WebClientDownloadCompleted;
            this.cliente.DownloadStringCompleted += onDownloadComplete;

            this.onProgressChanged = onProgressChanged;
            this.onDownloadComplete = onDownloadComplete;
        }

        public void IniciarDescarga()
        {
            try
            {
                this.cliente.DownloadStringAsync(this.direccion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Left empty but functional for future possible implementations
        }

        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            // Left empty but functional for future possible implementations
        }
    }
}
