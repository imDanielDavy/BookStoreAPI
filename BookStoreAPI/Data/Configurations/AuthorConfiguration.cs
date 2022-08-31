using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreAPI.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Tolkien"
                },
                new Author
                {
                    Id = 2,
                    FirstName = "Marcus",
                    LastName = "Aurelius"
                },
                new Author
                {
                    Id = 3,
                    FirstName = "Immanuel",
                    LastName = "Kant"
                }, 
                new Author
                {
                    Id = 4,
                    FirstName = "Adam",
                    LastName = "Smith"
                }
            );
        }
    }
}
