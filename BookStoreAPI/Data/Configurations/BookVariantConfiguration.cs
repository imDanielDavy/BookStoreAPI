using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BookStoreAPI.Data.Configurations
{
    public class BookVariantConfiguration : IEntityTypeConfiguration<BookVariant>
    {
        public void Configure(EntityTypeBuilder<BookVariant> builder)
        {
            builder.HasData(
                new BookVariant
                {
                    BookId = 1,
                    BookTypeId = 1,
                    Price = 29.99m
                },
                new BookVariant
                {
                    BookId = 1,
                    BookTypeId = 3,
                    Price = 12.99m
                },
                new BookVariant
                {
                    BookId = 2,
                    BookTypeId = 1,
                    Price = 24.99m
                },
                new BookVariant
                {
                    BookId = 3,
                    BookTypeId = 1,
                    Price = 19.99m
                },
                new BookVariant
                {
                    BookId = 3,
                    BookTypeId = 2,
                    Price = 9.99m
                },
                new BookVariant
                {
                    BookId = 4,
                    BookTypeId = 1,
                    Price = 49.99m
                },
                new BookVariant
                {
                    BookId = 5,
                    BookTypeId = 1,
                    Price = 39.99m
                }
            );
        }
    }
}
