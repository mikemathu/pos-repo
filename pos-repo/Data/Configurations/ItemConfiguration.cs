using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pos_repo.Models;

namespace pos_repo.Data.Configurations
{
    internal sealed class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> itemConfiguration)
        {
            itemConfiguration.HasKey(item => item.Id);

            itemConfiguration.Property(item => item.Name).IsRequired().HasMaxLength(100);

            itemConfiguration.Property(item => item.Description).IsRequired(false).HasMaxLength(255);

            itemConfiguration.Property(item => item.Price).IsRequired();

            itemConfiguration.Property(item => item.Image).IsRequired(false);

            itemConfiguration.Property(item => item.AvailableQuantity).IsRequired();

            itemConfiguration.HasData
                (
                    new Item
                    {
                        Id = 1,
                        Name = "Grill Chicken Chop",
                        Description = "chicken, egg, mushroom, salad",
                        Price = 10.99,
                        Image = "product-1.jpg",
                        AvailableQuantity = 100,
                        ItemCategoryId = 1
                    },
                     new Item
                     {
                         Id = 2,
                         Name = "Grill Pork Chop",
                         Description = "pork, egg, mushroom, salad",
                         Price = 12.99,
                         Image = "product-2.jpg",
                         AvailableQuantity = 90,
                         ItemCategoryId = 1
                     },
                    new Item
                    {
                        Id = 3,
                        Name = "Capellini Tomato Sauce",
                        Description = "spaghetti, tomato, mushroom ",
                        Price = 11.99,
                        Image = "product-3.jpg",
                        AvailableQuantity = 70,
                        ItemCategoryId = 1
                    },
                    new Item
                    {
                        Id = 4,
                        Name = "Vegan Salad Bowl",
                        Description = "apple, carrot, tomato",
                        Price = 6.99,
                        Image = "product-4.jpg",
                        AvailableQuantity = 120,
                        ItemCategoryId = 1
                    },
                    new Item
                    {
                        Id = 5,
                        Name = "Perfect Burger",
                        Description = "Dill pickle, cheddar cheese, tomato, red onion, ground chuck beef",
                        Price = 8.99,
                        Image = "product-17.jpg",
                        AvailableQuantity = 30,
                        ItemCategoryId = 2
                    }
                );
        }
    }
}
