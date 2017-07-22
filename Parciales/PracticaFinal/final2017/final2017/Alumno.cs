﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades.Inicio
{
    [XmlInclude(typeof(AlumnoEgresado))]
    class Alumno : Persona
    {
        public short legajo;
        public ENivelDeEstudio nivel;

        public Alumno(string nombreParam, Eraza razaParam, string apellidoParam, sbyte edadParam, short legajoParam, ENivelDeEstudio nivelParam) : base(nombreParam,razaParam,apellidoParam,edadParam) {
            this.legajo = legajoParam;
            this.nivel = nivelParam;
        }
    }
}

enum ENivelDeEstudio {Primartia,Segundaria,Terciaria,Universitaria};