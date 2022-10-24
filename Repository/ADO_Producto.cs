using Apis.Models;
using System.Data.SqlClient;

namespace Apis.Repository
{
    public class ADO_Producto
    {
        public static List<Producto> TraerProductosVendidos(int idusuario)
        {
            string connectionString = "Server= DESKTOP-N741CHP ; Database = SistemaGestion; Trusted_Connection = True;";
            var listaproductos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var comando = new SqlCommand("Select p.Descripciones , p.PrecioVenta , p.Stock , p.IdUsuario From Producto as p inner join Usuario as u  on u.id = p.IdUsuario inner join ProductoVendido as pv on p.id = pv.IdProducto  Where IdUsuario = '" + idusuario + "'", connection);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var producto = new Producto();
                        producto._descripcion = dr["Descripciones"].ToString();
                        producto._precioVenta = Convert.ToInt32(dr["PrecioVenta"]);
                        producto._stock = Convert.ToInt32(dr["Stock"]);
                        producto._idUsuario = Convert.ToInt32(dr["IdUsuario"]);
                        listaproductos.Add(producto);
                    }
                }
                connection.Close();

            }

            return listaproductos;



        }

        public static List<Producto> TraerProductos(int idusuario)
        {
            string connectionString = "Server= DESKTOP-N741CHP ; Database = SistemaGestion; Trusted_Connection = True;";
            var listaproductos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var comando = new SqlCommand("Select * From Producto Where IdUsuario = '" + idusuario + "'", connection);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var producto = new Producto();
                        producto._id = Convert.ToInt32(dr["Id"]);
                        producto._descripcion = dr["Descripciones"].ToString();
                        producto._costo = Convert.ToInt32(dr["Costo"]);
                        producto._precioVenta = Convert.ToInt32(dr["PrecioVenta"]);
                        producto._stock = Convert.ToInt32(dr["Stock"]);
                        producto._idUsuario = Convert.ToInt32(dr["IdUsuario"]);

                        listaproductos.Add(producto);


                    }

                }
                connection.Close();
            }

            return listaproductos;
        }

        public static List<Producto> TraerVentas(int idusuario)
        {
            string connectionString = "Server= DESKTOP-N741CHP ; Database = SistemaGestion; Trusted_Connection = True;";
            var listaproductos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var comando = new SqlCommand("Select p.Descripciones , p.PrecioVenta , p.Stock , p.IdUsuario  From Producto as p inner join Usuario as u on u.id = p.IdUsuario inner join Venta as v on v.IdProducto = p.Id  Where IdUsuario = '" + idusuario + "'", connection);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var producto = new Producto();
                        producto._descripcion = dr["Descripciones"].ToString();
                        producto._precioVenta = Convert.ToInt32(dr["PrecioVenta"]);
                        producto._stock = Convert.ToInt32(dr["Stock"]);
                        producto._idUsuario = Convert.ToInt32(dr["IdUsuario"]);
                        listaproductos.Add(producto);

                    }
                }
                connection.Close();
            }
            return listaproductos;



        }
    }


}