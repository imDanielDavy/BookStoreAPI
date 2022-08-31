using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreAPI.Data.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Adventure"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Philosophy"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Economics"
                }
            );
        }
    }
}

