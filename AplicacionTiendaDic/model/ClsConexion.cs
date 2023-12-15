using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTienda.model
{
    internal class ClsConexion
    {

        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "proyectodb";
        static string usuario = "root";
        static string password = "toor";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("no se pudo conectar a la base de datos, error: " + e);

            }
            return conex;
        }
    }
}