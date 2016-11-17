using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace TestUnitarioSegundoParcial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ErrorAlGuardar()
        {
            try
            {
                Tienda tprueba = new Tienda(null, 22, null);
                tprueba.guardar("pruebaErrorGuardar.txt", tprueba.ToString());
            }
            catch (NoGuardaException)
            {
            }
        }

        [TestMethod]
        public void ErrorLectoOEscritura()
        {
            try
            {
                string cadena = null;
                Tienda tprueba = new Tienda("FARMACITY", 80, "Rodolfo Lopez 1235");
                tprueba.guardar("pruebaErrorGuardar.txt", tprueba.ToString());
                tprueba.leer("pruebaErrorGuardar.txt", out cadena);
            }
            catch (NoGuardaException)
            {
            }
            catch (NoLeeException)
            {
            }
        
        }
    }
}
