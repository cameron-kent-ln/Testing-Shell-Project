using Testing_Project_Server.DBMock;

namespace Testing_Project_Server.BusinessLogic
{
    public interface IStockManager
    {
        bool ShouldOrderMoreStock(StockItem item);
    }

    public class StockManager : IStockManager
    {
        public bool ShouldOrderMoreStock(StockItem item)
        {
            if(item.Discounted == false)
            {
                if(item.Price < 100 && item.Quantity < 100)
                {
                    return true;
                }
                if(item.Price < 700 && item.Quantity < 50)
                {
                    return true;
                }
                if (item.Price < 1000 && item.Quantity < 20)
                {
                    return true;
                }
                if (item.Price > 1000 && item.Quantity < 20)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
