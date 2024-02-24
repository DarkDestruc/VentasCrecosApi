namespace VentasCrecosApi.Models
{
    public class DetallePedido
    {
        public  int Id { get; set; }
        public int PedidosId { get; set; }
        public Pedido Pedido { get; set; }

        public int ProductosId { get; set; }
        public Producto Producto { get; set; }
    }
}
