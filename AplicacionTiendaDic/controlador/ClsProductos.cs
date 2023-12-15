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
    internal class ClsProductos
    { // Método para obtener todos los usuarios
        public DataTable ObtenerTodosUsuarios()
        {
            MySqlConnection conexion = new ClsConexion().establecerConexion();
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT * FROM productos";
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
        public DataTable BuscarProductos(string palabraClave)
        {
            MySqlConnection conexion = new ClsConexion().establecerConexion();
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT ProductoID, NombreProducto, Precio, Stock FROM Productos WHERE NombreProducto LIKE @PalabraClave OR Precio LIKE @PalabraClave OR Stock LIKE @PalabraClave";

                using (MySqlCommand command = new MySqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@PalabraClave", "%" + palabraClave + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return dataTable;
        }
    }
}
