﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace EntidadesInstanciables
{
    public class Alumno : PersonaGimnasio
    {
        #region ---------------ATRIBBUTOS--------------
        protected Instructor.EClases _claseQueToma;
        protected EEstadoCuenta _estadoCuenta;
        #endregion

        #region --------------CONSTRUCTORES------------

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Instructor.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Instructor.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }

        #endregion

        #region -----------------METODOS---------------
        public override string ParticiparEnClase()
        {
            return "TOMA CLASES DE " + this._claseQueToma.ToString();
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        protected override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.MostrarDatos());
            cadena.AppendLine("ESTADO DE CUENTA: " + this._estadoCuenta.ToString());
            cadena.AppendLine(this.ParticiparEnClase());

            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------
        public static bool operator ==(Alumno alumno, Instructor.EClases clase)
        {
            return (alumno._claseQueToma == clase && alumno._estadoCuenta != EEstadoCuenta.Deudor);
        }

        public static bool operator !=(Alumno alumno, Instructor.EClases clase)
        {
            return !(alumno._claseQueToma == clase);
        }

        #endregion

        #region ----------------ENUMERADOS-------------

        public enum EEstadoCuenta
        {
            MesPrueba,
            Deudor,
            AlDia
        }

        public enum EClases
        {
            Natacion,
            Pilates,
            CrossFit,
            Yoga
        }
        #endregion
    }
}
