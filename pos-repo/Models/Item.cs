namespace pos_repo.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public int AvailableQuantity { get; set; }
        public int ItemCategoryId { get; set; }
        public ItemCategory ItemCategory { get; set; } = null!;
    }
}
