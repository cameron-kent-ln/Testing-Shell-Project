namespace Testing_Project_Server.DBMock
{
    public class StockItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public bool Discounted = false;
    }

    public enum ProductType
    {
        Unspecified,
        Health,
        Garden,
        Home
    }
}
