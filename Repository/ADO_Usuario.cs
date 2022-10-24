using Apis.Models;
using System.Data.SqlClient;

namespace Apis.Repository
{
    public class ADO_Usuario
    {
        public static Usuario TraerUsuario(string nombreUsuario)
        {
            string connectionString = "Server= DESKTOP-N741CHP ; Database = SistemaGestion; Trusted_Connection = True;";
            var usuario = new Usuario();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                var comando = new SqlCommand("Select * From Usuario Where NombreUsuario = '" + nombreUsuario + "'", connection);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    usuario._nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    usuario._apellido = dr.GetString(dr.GetOrdinal("Apellido"));
                    usuario._nombreDeUsuario = dr.GetString(dr.GetOrdinal("NombreUsuario"));
                    usuario._contraseña = dr.GetString(dr.GetOrdinal("Contraseña"));
                    usuario._mail = dr.GetString(dr.GetOrdinal("Mail"));


                }
                connection.Close();
            }
            return usuario;
        }


        public static Usuario Login(string nombreUsuario, int contraseña)
        {
            string connectionString = "Server= DESKTOP-N741CHP ; Database = SistemaGestion; Trusted_Connection = True;";
            var usuario = new Usuario();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var comando = new SqlCommand("Select * From Usuario Where NombreUsuario = '" + nombreUsuario + "' and Contraseña = '" + contraseña + "'", connection);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        usuario._nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                        usuario._apellido = dr.GetString(dr.GetOrdinal("Apellido"));
                        usuario._nombreDeUsuario = dr.GetString(dr.GetOrdinal("NombreUsuario"));
                        usuario._contraseña = dr.GetString(dr.GetOrdinal("Contraseña"));
                        usuario._mail = dr.GetString(dr.GetOrdinal("Mail"));

                    }
                    return usuario;
                }
                else
                {
                    return usuario;


                }
                connection.Close();
            }


        }

        public void ModifucarUsuario(Usuario usu)
        {

            string connectionString = "Server= DESKTOP-N741CHP ; Database = SistemaGestion; Trusted_Connection = True;";
            var usuario = new Usuario();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                var comando = new SqlCommand("Update Usuario set Nombre = '" + usu._nombre + "',Apellido= '" + usu._apellido + "' ,NombreUsuario= '" + usu._nombreDeUsuario + "',Contraseña= '" + usu._contraseña + "',Mail= '" + usu._mail + "'", connection);
                comando.ExecuteNonQuery();
                connection.Close();
            }

        }
    
        
    
    }
}