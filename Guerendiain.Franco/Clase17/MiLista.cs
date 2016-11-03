using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    class MiLista<T> : IEnumerable<T>
    {
        #region ATRIBUTOS
        private T[] _lista;
        #endregion

        #region CONSTRUCTORES
        public MiLista()
        {
            this._lista = new T[0];
        }

        #endregion

        #region METODOS
        public void Add(T item)
        {
            Array.Resize(ref this._lista, this.Count() + 1);
            this._lista[this.Count()-1] = item;
        }

        public void Remove(T item)
        {

            for (int i = (Array.IndexOf(this._lista, item)); i < this.Count()-1; i++)
            {
                this._lista[i] = this._lista[i + 1];
            }

            Array.Resize(ref this._lista, this.Count() - 1);
        }

        public int Count()
        {
            return this._lista.Length;
        }

        #endregion

        #region IENUMERABLE


        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count(); i++)
            {
                yield return this._lista[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
