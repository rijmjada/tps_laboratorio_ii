using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DBA
{
    public static class Facturas
    {
        static string stringConexion;
        static SqlConnection conexion;
        static SqlCommand comando;

        static Facturas()
        {
            stringConexion = @"Data Source =.;Initial Catalog=Libreria;Integrated Security=True";
            conexion = new SqlConnection(stringConexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Factura> Leer()
        {
            List<Factura> list = new List<Factura>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT * FROM facturas";

                using (SqlDataReader lectura = comando.ExecuteReader())
                {
                    while (lectura.Read() == true)
                    {
                        int id = (int)lectura["id"];
                        DateTime fecha = Convert.ToDateTime(lectura["fecha"]);
                        string producto = lectura["producto"].ToString();
                        double monto = (double)lectura["monto"];
                        int id_cliente = (int)lectura["id_cliente"];

                        list.Add(new Factura(id, fecha, producto, monto, id_cliente));
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

        public static bool Guardar(Factura f)
        {
            try
            {
                comando.Parameters.Clear();

                conexion.Open();
                comando.CommandText = $"INSERT INTO facturas (fecha, producto, monto, id_cliente) VALUES (@fecha,@producto,@monto,@id_cliente)";
                comando.Parameters.AddWithValue("@fecha", f.Fecha);
                comando.Parameters.AddWithValue("@producto", f.Producto);
                comando.Parameters.AddWithValue("@monto", f.Monto);
                comando.Parameters.AddWithValue("@id_cliente", f.Id_cliente);
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
                comando.CommandText = "SELECT TOP 1 id FROM facturas order by id desc";

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

        public static List<Factura> TraerComprasCliente(int idCliente)
        {
            List<Factura> list = new List<Factura>();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "SELECT * FROM facturas WHERE id_cliente = @ID";
                comando.Parameters.AddWithValue("@ID", idCliente);

                using (SqlDataReader lectura = comando.ExecuteReader())
                {
                    while (lectura.Read() == true)
                    {
                        int id = (int)lectura["id"];
                        DateTime fecha = Convert.ToDateTime(lectura["fecha"]);
                        string producto = lectura["producto"].ToString();
                        double monto = (double)lectura["monto"];
                        int id_cliente = (int)lectura["id_cliente"];

                        list.Add(new Factura(id, fecha, producto, monto, id_cliente));
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
    }
}
