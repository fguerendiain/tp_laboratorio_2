using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clase20DB
{
    public class Persona
    {
        public static SqlConnection _cn;
        public static SqlCommand _command;
        public static SqlDataReader _dataReader;

        protected int _id;
        public string nombre;
        public int edad;

        public Persona(int id)
        {
            this._id = id;
        }

        public Persona(string nombre, int edad, int id):this(id)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public static List<Persona> TraerPersonas()
        {
            List<Persona> lista = new List<Persona>();

            try
            {

                _cn = new SqlConnection(Properties.Settings.Default.MiConexion);
                //_cn.Open();
                //_cn.Close();
                //Console.WriteLine("Conecto OK");
                //Console.ReadLine();
                _command = new SqlCommand();    //creo un receptor de commandos

                _command.CommandType = System.Data.CommandType.Text;    //seteo el tipo de commando con un enumerado

                _command.CommandText = "Select * from Personas"; //paso la query a ejecutar como string

                _command.Connection = _cn;  //le agrego los datos de connexion

                _cn.Open(); //abro la connexion a la base

                _dataReader = _command.ExecuteReader(); //el dataReader es un cursos de solo lectura y solo avance.Funciona como una cola

                while (_dataReader.Read())
                {
                    lista.Add(new Persona((string)_dataReader[1], (int)_dataReader[2], (int)_dataReader[0]));
                }
                _cn.Close();
                return lista;

            }
            catch(Exception e)
            {
                Console.WriteLine("No anda");
                Console.ReadLine();
                throw e;
            }
        
        }



        public override string ToString()
        {
            return "ID: " + this._id + "\nNombre: " + this.nombre + "\nEdad: " + this.edad;
        }
    
        public bool Agregar()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Properties.Settings.Default.MiConexion);
                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "Insert into Personas (nombre,edad) VALUES ('"+this.nombre+"',"+this.edad+")";

                command.Connection = connect;

                connect.Open();

                command.ExecuteNonQuery();

                connect.Close();

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        
        
        }

        public bool Eliminar()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Properties.Settings.Default.MiConexion);
                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "Delete Personas where id="this._id.nombre + "'," + this.edad + ")";

                command.Connection = connect;

                connect.Open();

                command.ExecuteNonQuery();

                connect.Close();

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }


        }
    
    }
}
