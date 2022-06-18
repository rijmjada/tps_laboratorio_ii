using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;

namespace DBA
{
    public static class Libros
    {
        static string stringConexion;
        static SqlConnection conexion;
        static SqlCommand comando;

        static Libros()
        {
            stringConexion = @"Data Source =.;Initial Catalog=Libreria;Integrated Security=True";
            conexion = new SqlConnection(stringConexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Producto> Leer()
        {
            List<Producto> list = new List<Producto>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT * FROM libros";

                using (SqlDataReader lectura = comando.ExecuteReader())
                {
                    while (lectura.Read() == true)
                    {
                        int codigo = Convert.ToInt32(lectura["codigo"]);
                        string titulo = lectura["titulo"].ToString();
                        string autor = lectura["autor"].ToString();
                        int paginas = Convert.ToInt32(lectura["paginas"]);
                        double precio = Convert.ToDouble(lectura["precio"]);
                        EGeneroLiterario genero = (EGeneroLiterario)Convert.ToInt32(lectura["id_genero"]);
                        EOrigen origen = (EOrigen)Convert.ToInt32(lectura["id_origen"]);

                        list.Add(new Libro(codigo, precio, origen, paginas, genero, autor, titulo));
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

        public static bool Guardar(Libro l)
        {
            try
            {
                comando.Parameters.Clear();

                conexion.Open();
                comando.CommandText = $"INSERT INTO libros (titulo, autor, paginas, precio, id_genero, id_origen) VALUES (@titulo,@autor,@paginas,@precio,@genero,@origen)";
                comando.Parameters.AddWithValue("@titulo", (l.Titulo));
                comando.Parameters.AddWithValue("@autor", (l.Autor));
                comando.Parameters.AddWithValue("@paginas", (l.Paginas));
                comando.Parameters.AddWithValue("@precio", (l.Precio));
                comando.Parameters.AddWithValue("@genero", ((int)l.Genero));
                comando.Parameters.AddWithValue("@origen", ((int)l.Origen));

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

        public static bool Eliminar(Libro l)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM libros WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@codigo", l.Codigo);
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

        public static bool Modificar(int codigo, Libro l)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE libros SET " +
                    $"titulo = @titulo, " +
                    $"autor = @autor, " +
                    $"paginas = @paginas, " +
                    $"id_genero = @genero, " +
                    $"id_origen = @origen WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@titulo", l.Titulo);
                comando.Parameters.AddWithValue("@autor", l.Autor);
                comando.Parameters.AddWithValue("@paginas", l.Paginas);
                comando.Parameters.AddWithValue("@precio", l.Precio);
                comando.Parameters.AddWithValue("@genero", (int)l.Genero);
                comando.Parameters.AddWithValue("@origen", (int)l.Origen);
                comando.Parameters.AddWithValue("@codigo", codigo);
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
                comando.CommandText = "SELECT TOP 1 codigo FROM libros order by codigo desc";

                using (SqlDataReader lectura = comando.ExecuteReader())
                {
                    while (lectura.Read() == true)
                    {
                        codigo = (int)lectura["codigo"];
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
    }
}
