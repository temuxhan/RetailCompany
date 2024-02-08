namespace Store.Management.Service.Application.Dtos
{
    public record FindProductQueryDto
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int WarehouseId { get; set; }

        public string ProductName { get; set; }
    }
}
