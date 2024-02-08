namespace Store.Management.Service.Domain.Entities
{
    public class Warehouse
    {
        public int WarehouseID { get; set; }
        public string Name { get; set; }
        public string LocationType { get; set; }
        public int? StoreID { get; set; } // Nullable for the main warehouse
        public Store Store { get; set; }
    }
}
