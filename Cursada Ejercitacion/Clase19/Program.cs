using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Clase19
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Debora", "Meltrozo", 446632145);
            Persona p2 = new Persona("Micho", "Tito", 1234567);
            Persona p3 = new Persona("Rosamel", "Trozo", 9876544);
            PersonaH h1 = new PersonaH("horrible","Armando","Estebanquito",3121456);
            PersonaH h2 = new PersonaH("zafable","Carlos","PerezCompan",5465132);
            PersonaH h3 = new PersonaH("agradable", "Jhon", "Nash", 6847643211);


            List<Persona> personList = new List<Persona>();
            List<Persona> a1;

            personList.Add(p1);
            personList.Add(p3);
            personList.Add(p3);
            personList.Add(h1);
            personList.Add(h2);
            personList.Add(h3);


            //el encardago de escribir o leer
            XmlSerializer serXml = new XmlSerializer(typeof(List<Persona>));

            //nombre de archivoy juego de carateres
            using (XmlTextWriter wriXml = new XmlTextWriter("../../prueba.xml", Encoding.UTF8))
            {
                //grabo la lista de personas en el archivo xml
                serXml.Serialize(wriXml, personList);
            }

            //setear ruta
            using (XmlTextReader redXml = new XmlTextReader("../../prueba.xml"))
            {   //leo la lista de personas del archivo xml y la cargo en mi lista auxiliar
                a1 = (List<Persona>)serXml.Deserialize(redXml);
            }

            foreach (Persona t in a1)
            {
                Console.WriteLine(t);                
            }
            Console.ReadLine();

        }
    }
}
