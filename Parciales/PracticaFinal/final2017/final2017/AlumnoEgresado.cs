using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Punto6F;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades.Inicio
{
    class AlumnoEgresado : Alumno, ISerializar, IDeserializar
    {
        public float promedio;
        public short promocion;

        public AlumnoEgresado(string nombreParam, Eraza razaParam, string apellidoParam, sbyte edadParam, short legajoParam, ENivelDeEstudio nivelParam, float promedioParam, short promocionParam)
            : base(nombreParam, razaParam, apellidoParam, edadParam, legajoParam, nivelParam)
        {
            this.promedio = promedioParam;
            this.promocion = promocionParam;
        }

        public bool Xml(string datos)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter("archivo.xml", Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AlumnoEgresado));
                    serializer.Serialize(writer, datos);
                }

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        bool IDeserializar.Xml(string datos, out AlumnoEgresado alumno)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(datos))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AlumnoEgresado));
                    alumno = (AlumnoEgresado)serializer.Deserialize(reader);
                    return true;
                }
            }
            catch (Exception)
            {
                alumno = default(AlumnoEgresado);
                return false;
            }

        }
    }
}
