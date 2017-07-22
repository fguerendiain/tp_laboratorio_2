using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Punto6F
{
    class AlumnoEgresado : Alumno
    {
        public float promedio;
        public short promocion;

        public AlumnoEgresado(string nombreParam, Eraza razaParam, string apellidoParam, sbyte edadParam, short legajoParam, ENivelDeEstudio nivelParam, float promedioParam, short promocionParam) : base(nombreParam,razaParam,apellidoParam,edadParam,legajoParam,nivelParam) {
            this.promedio = promedioParam;
            this.promocion = promocionParam;
        }

    }
}
