namespace Inventory.Management.Service.Domain.Entities
{
    public class StoreRoom
    {
        public int StoreRoomID { get; set; }
        public int StoreID { get; set; }
        public int Capacity { get; set; }
        public Store Store { get; set; }
    }
}
