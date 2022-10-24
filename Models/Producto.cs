namespace Apis.Models
{
    public class Producto
    {
        public int _id { get; set; }
        public string _descripcion { get; set; }
        public int _costo { get; set; }
        public int _precioVenta { set; get; }
        public int _stock { get; set; }
        public int _idUsuario { get; set; }

        public Producto()
        {
            _id = 0;
            _descripcion = "";
            _costo = 0;
            _precioVenta = 0;
            _stock = 0;
            _idUsuario = 0;

        }

        public Producto(int id, string descripcion, int costo, int precioVenta, int stock, int idUsuario)
        {
            _id = id;
            _descripcion = descripcion;
            _costo = costo;
            _precioVenta = precioVenta;
            _stock = stock;
            _idUsuario = idUsuario;
        }
    }
}
