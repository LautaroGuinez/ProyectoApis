namespace Apis.Models
{
    public class ProductoVendido
    {
        public int _id { get; set; }
        public int _idProducto { get; set; }
        public int _stock { get; set; }
        public int _idVenta { get; set; }

        public ProductoVendido()
        {
            _id = 0;
            _idProducto = 0;
            _stock = 0;
            _idVenta = 0;
        }

        public ProductoVendido(int id, int idProductoVenta, int stock, int idVenta)
        {
            _id = id;
            _idProducto = idProductoVenta;
            _stock = stock;
            _idVenta = idVenta;
        }
    }
}
