using System;
using System.Collections.Generic;
using System.Text;

namespace SerializacionXml2
{
    [Serializable]
    public class Lista
    {
        //Sólo maneja listas de objetos de tipo Dato
        private List<Dato> _items;

        public List<Dato> Items
        {
            get { return _items; }
        }

        /// <summary>
        /// Constructor de Lista.
        /// </summary>
        public Lista()
        {
            _items = new List<Dato>();
        }
    }
}
