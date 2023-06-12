namespace Testing_Project_Server.DBMock
{
    public static class MockDatabase
    {
        private static List<StockItem> _stockItems = new List<StockItem> {
            new StockItem() {
                Id = 1,
                Description= "Spade",
                Price = 140,
                Quantity = 100,
                Type = ProductType.Garden
            },
            new StockItem() {
                Id = 2,
                Description= "Hose",
                Price = 400,
                Quantity = 20,
                Type = ProductType.Garden
            },
            new StockItem() {
                Id = 3,
                Description= "Seeds",
                Price = 40,
                Quantity = 10000,
                Type = ProductType.Garden
            },
            new StockItem() {
                Id = 4,
                Description= "Sprinkler",
                Price = 1540,
                Quantity = 10,
                Type = ProductType.Garden
            },
            new StockItem() {
                Id = 5,
                Description= "L-Shaped Couch",
                Price = 15400,
                Quantity = 4,
                Type = ProductType.Home
            },
            new StockItem() {
                Id = 6,
                Description= "Desk Chair",
                Price = 540,
                Quantity = 100,
                Type = ProductType.Home
            },
        };


        public static List<StockItem> GetStockItems()
        {
            return _stockItems;
        }
        public static void AddStockItem(StockItem item)
        {
            _stockItems.Add(item);
        }

        public static void EditStockItem(StockItem item)
        {
            var stockItem = _stockItems.Where(i => i.Id == item.Id).FirstOrDefault();
            stockItem.Quantity = item.Quantity;
            stockItem.Type = item.Type;
            stockItem.Price = item.Price;
        }

        public static void DeleteStockItem(int itemId)
        {
            _stockItems.Remove(_stockItems.Where(i => i.Id == itemId).FirstOrDefault());
        }



    }
}
