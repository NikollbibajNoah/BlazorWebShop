using Microsoft.EntityFrameworkCore;
using WebShop.DB;
using WebShop.Model;

namespace WebShop.Implementation
{
    public class ProductService
    {
        private readonly StoreDBContext _dbContext;
        public ProductService(StoreDBContext context) {
            _dbContext = context;
        }

        public async Task<List<ItemData>> LoadItemsFromDB()
        {
           return await _dbContext.StoreItems.ToListAsync();
        }

        public async Task<List<ItemData>> FilterItemsByPrice(int min, int max)
        {
            return await _dbContext.StoreItems.Where((item) => item.Price >= min && item.Price <= max).ToListAsync();
        }
    }
}
