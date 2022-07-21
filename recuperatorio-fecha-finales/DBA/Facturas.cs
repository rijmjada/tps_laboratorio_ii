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
        public static SqlConnection conexion;
        public static SqlCommand comando;

        static Facturas()
        {
            conexion = new SqlConnection(DataAccess.stringConexion);
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

        public static bool Guardar(Factura f)
        {
            bool ret = false;
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
                comando.CommandText = "SELECT TOP 1 id FROM facturas order by id desc";

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
    }
}
