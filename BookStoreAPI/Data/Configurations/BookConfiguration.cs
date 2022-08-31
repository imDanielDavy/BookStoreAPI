using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreAPI.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Lord Of The Rings",
                    Description = "The Lord of the Rings is an epic high-fantasy novel by English author and scholar J. R. R. Tolkien.",
                    ImgUrl = "https://s26162.pcdn.co/wp-content/uploads/2017/05/the-lord-of-the-rings-book-cover.jpg",
                    GenreId = 1,
                    AuthorId = 1,
                    Year = 1949
                },
                new Book
                {
                    Id = 2,
                    Title = "The Hobbit",
                    Description = "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien.",
                    ImgUrl = "https://images-na.ssl-images-amazon.com/images/I/71KqBbH93lL.jpg",
                    GenreId = 1,
                    AuthorId = 1,
                    Year = 1937
                },
                new Book
                {
                    Id = 3,
                    Title = "Meditations",
                    Description = "Meditations is a series of personal writings by Marcus Aurelius, Roman Emperor from AD 161 to 180, recording his private notes to himself and ideas on Stoic philosophy.",
                    ImgUrl = "https://images-na.ssl-images-amazon.com/images/I/7107Yk5DWtL.jpg",
                    GenreId = 2,
                    AuthorId = 2,
                    Year = 180
                },
                new Book
                {
                    Id = 4,
                    Title = "Critique of Pure Reason",
                    Description = "The Critique of Pure Reason is a book by the German philosopher Immanuel Kant, in which the author seeks to determine the limits and scope of metaphysics.",
                    ImgUrl = "https://www.gutenberg.org/files/4280/4280-h/images/cover.jpg",
                    GenreId = 2,
                    AuthorId = 3,
                    Year = 1781
                },
                new Book
                {
                    Id = 5,
                    Title = "The Wealth of Nations",
                    Description = "An Inquiry into the Nature and Causes of the Wealth of Nations is the magnum opus of the Scottish economist and moral philosopher Adam Smith.",
                    ImgUrl = "https://images-na.ssl-images-amazon.com/images/I/71yqXZeTuxL.jpg",
                    GenreId = 3,
                    AuthorId = 4,
                    Year = 1781
                }
            );
        }
    }
}
