using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccesoDatos;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            AccesoDatos.AccesoDatos objAcceso = new AccesoDatos.AccesoDatos();
            Persona persona;

            do
            {
                Console.Clear();
                Console.WriteLine("1-Alta de Personas");
                Console.WriteLine("2-Baja de Personas");
                Console.WriteLine("3-Modificación de Personas");
                Console.WriteLine("4-Listado de Personas -con LIST<PERSONA>-");
                Console.WriteLine("5-Listado de Personas -con DATATABLE-");
                Console.WriteLine("9-Salir");
                Console.WriteLine("\nIngrese una opción");

                while (!int.TryParse(Console.ReadLine(), out opcion))
                    Console.WriteLine("Error. Ingrese un entero!!!");

                switch (opcion)
                {
                    #region Alta
                    case 1:
                        
                        Console.WriteLine();
                        Console.Write("Ingrese Nombre:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Ingrese Apellido:");
                        string apellido = Console.ReadLine();
                        Console.WriteLine(); 
                        Console.Write("Ingrese Edad:");
                        int edad = int.Parse(Console.ReadLine());

                        if (!objAcceso.InsertarPersona(new Persona(apellido, nombre, edad)))
                            Console.WriteLine("No se ha podido INSERTAR a la persona :(");
                        else
                            Console.WriteLine("Persona INSERTADA correctamente!!!");

                        break;
                    #endregion

                    #region Baja
                    case 2:

                        Console.WriteLine("Ingrese ID a buscar:");
                        int id = int.Parse(Console.ReadLine());

                        persona = objAcceso.ObtenerPersonaPorID(id);

                        if (persona != null)
                        {
                            Console.WriteLine("===========================================================");
                            Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", "ID", "APELLIDO", "NOMBRE", "EDAD");
                            Console.WriteLine("===========================================================");

                            Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", persona.ID, persona.Apellido, persona.Nombre, persona.Edad);

                            Console.WriteLine("Será eliminada, confirma?(s/n):");
                            string rta = Console.ReadLine();

                            if (rta.CompareTo("s") == 0)
                                if (!objAcceso.EliminarPersona(persona))
                                {
                                    Console.WriteLine("No se ha podido ELIMINAR a la persona :(");
                                }
                                else
                                    Console.WriteLine("Persona ELIMINADA correctamente!!!");
                        }
                        else
                        {
                            Console.WriteLine("No se ha encontrado la persona...");
                            Console.ReadLine();
                        }

                        break;
                    #endregion 

                    #region Modificación
                    case 3:

                        Console.WriteLine("Ingrese ID a buscar:");
                        id = int.Parse(Console.ReadLine());

                        persona = objAcceso.ObtenerPersonaPorID(id);

                        if (persona != null)
                        {
                            Console.WriteLine("===========================================================");
                            Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", "ID", "APELLIDO", "NOMBRE", "EDAD");
                            Console.WriteLine("===========================================================");

                            Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", persona.ID, persona.Apellido, persona.Nombre, persona.Edad);

                            Console.WriteLine("Será modificada, confirma?(s/n):");
                            string rta = Console.ReadLine();

                            if (rta.CompareTo("s") == 0)
                            {
                                Console.WriteLine();
                                Console.Write("Ingrese nuevo Nombre:");
                                nombre = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Ingrese nuevo Apellido:");
                                apellido = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Ingrese nueva Edad:");
                                edad = int.Parse(Console.ReadLine());

                                if (!objAcceso.ModificarPersona(new Persona(persona.ID, apellido, nombre, edad)))
                                {
                                    Console.WriteLine("No se ha podido MODIFICAR a la persona :(");
                                }
                                else
                                {
                                    Console.WriteLine("Persona MODIFICADA correctamente!!!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se ha encontrado la persona...");
                                Console.ReadLine();
                            }
                        }
                        break;
                    #endregion

                    #region Listado -con LIST<PERSONA>-
                    case 4:
                        List<Persona> l = objAcceso.ObtenerListaPersonas();

                        Console.WriteLine("OBTENGO DATOS Y LO MUESTRO CON LIST<PERSONA>");
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", "ID", "APELLIDO", "NOMBRE", "EDAD");
                        Console.WriteLine("===========================================================");
            
                        foreach (Persona p in l)
                        {
                            Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", p.ID, p.Apellido, p.Nombre, p.Edad);    
                        }
                        
                        Console.ReadLine();
                        
                        break;
                    #endregion

                    #region Listado -con DATATABLE-
                    case 5:

                        System.Data.DataTable miTablaPersonas = objAcceso.ObtenerTablaPersonas();

                        Console.WriteLine("OBTENGO DATOS Y LO MUESTRO CON DATATABLE");
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", "ID", "APELLIDO", "NOMBRE", "EDAD");
                        Console.WriteLine("===========================================================");

                        foreach (System.Data.DataRow fila in miTablaPersonas.Rows)
                        {
                            Console.WriteLine("{0,5} {1,15} {2,15} {3,15}", fila["id"], fila["apellido"], fila[2], fila["edad"]);
                        }

                        Console.ReadLine();                        
                        
                        break;
                }
                    #endregion

            } while (opcion != 9);

            Console.WriteLine("Pulse una tecla para salir...");
            Console.ReadLine();
            
        }
    }
}
