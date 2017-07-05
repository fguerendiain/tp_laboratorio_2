using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Eventos
{
    public class JuegoEventArgs : EventArgs
    {
        private int _numeroSecreto;

        public int NumeroSecreto
        {
            get { return this._numeroSecreto; }
        }

        public JuegoEventArgs(int numeroSecreto)
        {
            this._numeroSecreto = numeroSecreto;
        }
    }
}
