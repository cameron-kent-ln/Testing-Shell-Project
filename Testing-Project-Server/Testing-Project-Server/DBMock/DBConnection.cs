namespace Testing_Project_Server.DBMock
{
    public interface IDBConnection
    {
        List<StockItem> Get();
        void Add(StockItem item);
        void Edit(StockItem item);
        void Delete(int itemId);
    }
    public class DBConnection : IDBConnection
    {
        public List<StockItem> Get()
        {
            return MockDatabase.GetStockItems();
        }
        public void Add(StockItem item)
        {
            MockDatabase.AddStockItem(item);
        }

        public void Edit(StockItem item)
        {
            MockDatabase.EditStockItem(item);
        }

        public void Delete(int itemId)
        {
            MockDatabase.DeleteStockItem(itemId);
        }

    }
}
