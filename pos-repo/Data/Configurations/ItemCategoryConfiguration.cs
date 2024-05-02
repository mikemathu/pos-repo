using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using pos_repo.Models;

namespace pos_repo.Data.Configurations
{
    internal sealed class ItemCategoryConfiguration : IEntityTypeConfiguration<ItemCategory>
    {
        public void Configure(EntityTypeBuilder<ItemCategory> itemCategoryConfiguration)
        {
            itemCategoryConfiguration.HasKey(itemCategory => itemCategory.Id);

            itemCategoryConfiguration.Property(itemCategory => itemCategory.Name).IsRequired().HasMaxLength(40);

            itemCategoryConfiguration.HasMany(e => e.Items)
                .WithOne(e => e.ItemCategory)
                .HasForeignKey(e => e.ItemCategoryId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            itemCategoryConfiguration.HasData
                (
                    new ItemCategory
                    {
                        Id = 1,
                        Name = "Meat"
                    },
                    new ItemCategory
                    {
                        Id = 2,
                        Name = "Burger"
                    },
                    new ItemCategory
                    {
                        Id = 3,
                        Name = "Pizza"
                    },
                    new ItemCategory
                    {
                        Id = 4,
                        Name = "Drinks"
                    },
                    new ItemCategory
                    {
                        Id = 5,
                        Name = "Desserts"
                    },
                    new ItemCategory
                    {
                        Id = 6,
                        Name = "Snacks"
                    }
                );
        }
    }
}
