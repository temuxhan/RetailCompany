namespace Order.Management.Service.Domain.Database.Entities
{
    public class ProductMovement
    {
        public int MovementID { get; set; }
        public int ProductID { get; set; }
        public int FromWarehouseID { get; set; }
        public int ToWarehouseID { get; set; }
        public int Quantity { get; set; }
        public DateTime MovementDate { get; set; }
        public Product Product { get; set; }
        public Warehouse FromWarehouse { get; set; }
        public Warehouse ToWarehouse { get; set; }
    }

}
