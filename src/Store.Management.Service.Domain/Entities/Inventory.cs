namespace Store.Management.Service.Domain.Entities
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int ProductID { get; set; }
        public int WarehouseID { get; set; }
        public int Quantity { get; set; }
        public string State { get; set; }
        public Product Product { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
