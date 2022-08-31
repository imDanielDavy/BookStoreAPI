using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreAPI.Data.Configurations
{
    public class BookTypeConfiguration : IEntityTypeConfiguration<BookType>
    {
        public void Configure(EntityTypeBuilder<BookType> builder)
        {
            builder.HasData(
                new BookType
                {
                    Id = 1,
                    Name = "Paperback"
                },
                new BookType
                {
                    Id = 2,
                    Name = "Audio"
                },
                new BookType
                {
                    Id = 3,
                    Name = "Kindle"
                }
            );
        }
    }
}
