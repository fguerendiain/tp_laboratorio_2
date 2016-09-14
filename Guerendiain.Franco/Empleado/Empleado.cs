using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Empleado
    {

        //ATRIBUTOS
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private EPuestoJerarquico _puesto;
        private int _salario;

        //CONSTRUCTOR
        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        { 
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }

        //METODO
        public string Mostrar(Empleado employe)
        {
            return "Apellido: " + employe._apellido + "\n" + "Nombre: " + employe._nombre + "\n" + "Legajo: " + employe._legajo + "\n" + "Puesto: " + employe._puesto + "\n" + "Salario: $" + employe._salario + "\n";
        
        }


    }
}
