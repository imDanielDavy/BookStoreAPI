using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public string ImgUrl { get; set; } = string.Empty;
        [ForeignKey(nameof(AuthorId))]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        [ForeignKey(nameof(GenreId))]
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
        public IList<BookVariant> BookVariants { get; set; }
    }
}
