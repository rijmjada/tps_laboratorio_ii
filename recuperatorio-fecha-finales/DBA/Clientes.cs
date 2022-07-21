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
        public static SqlConnection conexion;
        public static SqlCommand comando;

        static Clientes()
        {
            conexion = new SqlConnection(DataAccess.stringConexion);
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
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return list;
        }

        public static bool Guardar(Cliente c)
        {
            bool ret = false;
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
                ret = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return ret;
        }

        public static bool Eliminar(int id)
        {
            bool ret = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM clientes WHERE id = @ID";
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
                
                ret = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return ret;
        }

        public static bool Modificar(int id, Cliente c)
        {
            bool ret = false;
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
                ret = true;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return ret;
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
              }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return codigo;
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
              
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return id;
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
               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return c1;
        }
    }
}
