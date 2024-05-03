using Microsoft.AspNetCore.Mvc;
using pos_repo.Models;
using pos_repo.Services;
using System.Collections.Generic;

namespace pos_repo.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        // GET: Item
        public async Task<ActionResult> GetAllItems()
        {
            IEnumerable <Item> items = await _itemRepository.GetAllItemsAsync();

            return View("Index", items);
        }

        // GET: Item
        public async Task<ActionResult> GetItemsByCategory(int itemCategotyId)
        {
            IEnumerable<Item> items = await _itemRepository.GetItemsByCategoryAsync(itemCategotyId);

            return View(items);
        }

        // GET: Item
        public async Task<ActionResult> GetItemDetails(int itemId)
        {
            Item? item = await _itemRepository.GetItemDetailsAsync(itemId);

            return View(item);
        }
    }
}
