using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Inicio;


namespace Entidades.Punto6F
{
    interface IDeserializar
    {
        public bool Xml(string cadena, out AlumnoEgresado alumno);
    }
}
