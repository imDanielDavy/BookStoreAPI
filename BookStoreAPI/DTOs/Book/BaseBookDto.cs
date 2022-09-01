using Microsoft.Build.Framework;

namespace BookStoreAPI.DTOs.Book
{
    public class BaseBookDto
    {
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ImgUrl { get; set; } = string.Empty;
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
    }
}
