using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DBA
{
    public static class Clientes
    {
        static string stringConexion;
        static SqlConnection conexion;
        static SqlCommand comando;

        static Clientes()
        {
            stringConexion = @"Data Source =.;Initial Catalog=Libreria;Integrated Security=True";
            conexion = new SqlConnection(stringConexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Cliente> Leer()
        {
            List<Cliente> list = new List<Cliente>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT * FROM clientes";

                using (SqlDataReader lectura = comando.ExecuteReader())
                {
                    while (lectura.Read() == true)
                    {
                        int id = (int)lectura["id"];
                        string nombre = lectura["nombre"].ToString();
                        string apellido = lectura["apellido"].ToString();
                        int dni = (int)lectura["dni"];
                        string direccion = lectura["direccion"].ToString();

                        list.Add(new Cliente(id, nombre, apellido, dni, direccion));
                    }
                }
                return list;
            }
            catch (Exception exeption)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static bool Guardar(Cliente c)
        {
            try
            {
                comando.Parameters.Clear();

                conexion.Open();
                comando.CommandText = $"INSERT INTO clientes (nombre, apellido, dni, direccion) VALUES (@nombre,@apellido,@dni,@direccion)";
                comando.Parameters.AddWithValue("@nombre", (c.Nombre));
                comando.Parameters.AddWithValue("@apellido", (c.Apellido));
                comando.Parameters.AddWithValue("@dni", (c.Dni));
                comando.Parameters.AddWithValue("@direccion", (c.Direccion));

                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static bool Eliminar(int id)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM clientes WHERE id = @ID";
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static bool Modificar(int id, Cliente c)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE clientes SET " +
                    $"nombre = @nombre, " +
                    $"apellido = @apellido, " +
                    $"dni = @dni, " +
                    $"direccion = @direccion " +
                    $"WHERE id = @id";
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@apellido", c.Apellido);
                comando.Parameters.AddWithValue("@dni", c.Dni);
                comando.Parameters.AddWithValue("@direccion", c.Direccion);
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static int TraerUltimoCodigo()
        {
            int codigo = -1;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT TOP 1 id FROM clientes order by id desc";

                using (SqlDataReader lectura = comando.ExecuteReader())
                {
                    while (lectura.Read() == true)
                    {
                        codigo = (int)lectura["id"];
                    }
                }
                return codigo;
            }
            catch (Exception exeption)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static int TraerIdClientePorDni(string dni)
        {
            int id = -1;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT id from clientes where dni = @dni";
                comando.Parameters.AddWithValue("@dni", dni);

                using (SqlDataReader lectura = comando.ExecuteReader())
                {
                    while (lectura.Read() == true)
                    {
                        id = (int)lectura["id"];
                    }
                }
                return id;
            }
            catch (Exception exeption)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static Cliente TraerClientePorID(int ID)
        {
            Cliente c1 = null;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT * from clientes where id = @id";
                comando.Parameters.AddWithValue("@id", ID);

                using (SqlDataReader lectura = comando.ExecuteReader())
                {
                    while (lectura.Read() == true)
                    {
                        c1 = new Cliente((int)lectura["id"], lectura["nombre"].ToString(), lectura["apellido"].ToString(), (int)lectura["dni"], lectura["direccion"].ToString());
                    }
                }
                return c1;
            }
            catch (Exception exeption)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
