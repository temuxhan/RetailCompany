namespace Store.Management.Service.Domain.Entities
{
    public class StoreRoomInventory
    {
        public int StoreRoomInventoryID { get; set; }
        public int StoreRoomID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string State { get; set; }
        public StoreRoom StoreRoom { get; set; }
        public Product Product { get; set; }
    }
}
