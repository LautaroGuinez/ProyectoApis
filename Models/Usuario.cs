namespace Apis.Models
{
    public class Usuario
    {
        public int _id { get; set; }
        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public string _nombreDeUsuario { get; set; }
        public string _contraseña { get; set; }
        public string _mail { get; set; }

        public Usuario()
        {
            _id = 0;
            _nombre = "";
            _apellido = "";
            _nombreDeUsuario = "";
            _contraseña = "";
            _mail = "";
        }

        public Usuario(int id, string nombre, string apellido, string nombreDeUsuario, string contraseña, string mail)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _nombreDeUsuario = nombreDeUsuario;
            _contraseña = contraseña;
            _mail = mail;
        }
    }
}
