using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Clase18Cl
{
    public class Empresa
    {
        #region ATRIBUTOS
        private List<Empleado> _nominaEmpleados;
        private string _razonSocial;
        private string _direccion;
        private float _ganancias;
        #endregion
        
        #region PROPERTIES
        public string RazonSocial
        {
            get{return _razonSocial;}
            set{_razonSocial = value;}
        }
        
        public string Direccion
        {
            get{return _direccion;}
            set{_direccion = value;}
        }
            
        public float Ganancias
        {
            get{return _ganancias;}
            set{_ganancias = value;}
        }
        #endregion

        #region CONSTRUCTORES
        private Empresa()
        {
            _nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial, string direccion, float ganancias) : this()
        {
            this.RazonSocial = razonSocial;
            this.Direccion = direccion;
            this.Ganancias = ganancias;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
 /*       public static Empresa operator +(Empresa e1, Empleado p1)
        {
            foreach (Empleado t in e1._nominaEmpleados)
            {
                if (t == p1)
                {
                    break;
                }
                e1._nominaEmpleados.Add(p1);
            }
            return e1;
        }*/
        
        #endregion

        #region METODOS
        public string MostrarEmpresa()
        {
            string cadena = "La empresa " + _razonSocial + " sita en la calle " + _direccion + " cuenta con ganancias por " + _ganancias + " y con " + "ARMAR ALGO QUE CUENTE EMPLEADOS" + " empleados:\n\n";

            foreach (Empleado t in this._nominaEmpleados)
            {
                cadena += t.Mostrar(t);                
            }

            return cadena;
        }
        #endregion


    }
}
