namespace Apis.Models
{
    public class Venta
    {
        public int _id { get; set; }
        public string _comentaros { get; set; }
        public int _idUsuario { get; set; }

        public Venta()
        {
            _id = 0;
            _comentaros = "";
            _idUsuario = 0;
        }

        public Venta(int id, string comentaros, int idUsuario)
        {
            _id = id;
            _comentaros = comentaros;
            _idUsuario = idUsuario;
        }
    }
}
