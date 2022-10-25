using Apis.Models;
using System.Data.SqlClient;
namespace Apis.Repository

{
    public class ADO_ProductoVendido
    {
        public void ElimnarProductoVendio(ProductoVendido proVe)
        {
            string connectionString = "Server= DESKTOP-N741CHP ; Database = SistemaGestion; Trusted_Connection = True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var comando = new SqlCommand("Delete From ProductoVendido Where ID=" + proVe._id + " And Stock=" + proVe._stock + " And IdProducto=" + proVe._idProducto + " And IdVenta=" + proVe._idVenta, connection);
                comando.ExecuteNonQuery();
                connection.Close();
            }

        }

    }
}
