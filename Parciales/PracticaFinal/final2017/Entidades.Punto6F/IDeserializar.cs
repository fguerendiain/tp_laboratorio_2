using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.Punto6F
{
    interface IDeserializar<T>
    {
        public bool Xml(string cadena, out AlumnoEgresado alumno);
    }
}
