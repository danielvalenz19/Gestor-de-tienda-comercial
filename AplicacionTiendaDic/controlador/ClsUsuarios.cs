using AplicacionTienda.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTiendaDic.controlador
{
    internal class ClsUsuarios
    {
        // Método para obtener todos los usuarios
        public DataTable ObtenerTodosUsuarios()
        {
            MySqlConnection conexion = new ClsConexion().establecerConexion();
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT * FROM Usuarios";

                using (MySqlCommand command = new MySqlCommand(query, conexion))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuarios: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return dataTable;
        }

        // Método para guardar un nuevo usuario
        public void GuardarUsuario(string id, string nombre, string apellido, string edad, string contraseña, string usuario)
        {
            MySqlConnection conexion = new ClsConexion().establecerConexion();

            try
            {
                string query = "INSERT INTO Usuarios (UserId, Nombre, Apellido, Edad, Contraseña, usuario) VALUES (@UserId, @Nombre, @Apellido, @Edad, @Contraseña, @usuario)";

                using (MySqlCommand command = new MySqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@UserId", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    command.Parameters.AddWithValue("@usuario", usuario);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }

}

