using Microsoft.EntityFrameworkCore;
using pos_repo.Data;
using pos_repo.Models;
using pos_repo.Services;

namespace pos_repo.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ItemRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<IEnumerable<Item>> GetAllItemsAsync()
        {
            IEnumerable<Item> items =  _applicationDbContext.Items;

            return items;
        }       

        public async Task<IEnumerable<Item>> GetItemsByCategoryAsync(int itemCategotyId)
        {
            IEnumerable<Item> items = _applicationDbContext.Items
                .Where(item => item.ItemCategoryId == itemCategotyId);

            return items;
        }

        public async Task<Item?> GetItemDetailsAsync(int itemId)
        {
            var item =  await _applicationDbContext.Items
                .Where(item => item.Id == itemId).SingleOrDefaultAsync();

            return item;
        }

    }
}
