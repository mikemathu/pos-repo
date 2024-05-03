using pos_repo.Models;

namespace pos_repo.Services
{
    public interface IItemRepository
    {
        public abstract Task<IEnumerable<Item>> GetAllItemsAsync();
        public abstract Task<IEnumerable<Item>> GetItemsByCategoryAsync(int itemCategotyId);
        public abstract Task<Item?> GetItemDetailsAsync(int itemId);
    }
}
