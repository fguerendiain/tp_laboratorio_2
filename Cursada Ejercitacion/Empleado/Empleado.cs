using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18Cl
{
    public class Empleado
    {

        #region ATRIBUTOS
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private EPuestoJerarquico _puesto;
        private int _salario;
        #endregion

        #region CONSTRUCTOR
        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        { 
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }
        #endregion

        #region METODO
        public static string Mostrar(Empleado employe)
        {
            return "NOMBRE: " + employe._nombre + "\nAPELLIDO: " + employe._apellido + "\nLEGAJO: " + employe._legajo + "Puesto: " + employe._puesto + "\nSALARIO: $" + employe._salario + "\n----------------\n\n";
        }

        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Empleado p1, Empleado p2)
        {
            return p1._legajo == p2._legajo;
        }

        public static bool operator !=(Empleado p1, Empleado p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
