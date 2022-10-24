namespace Apis.Models
{
    public class ProductoVendido
    {
        public int _id { get; set; }
        public int _idProductoVenta { get; set; }
        public int _stock { get; set; }
        public int _idVenta { get; set; }

        public ProductoVendido()
        {
            _id = 0;
            _idProductoVenta = 0;
            _stock = 0;
            _idVenta = 0;
        }

        public ProductoVendido(int id, int idProductoVenta, int stock, int idVenta)
        {
            _id = id;
            _idProductoVenta = idProductoVenta;
            _stock = stock;
            _idVenta = idVenta;
        }
    }
}
