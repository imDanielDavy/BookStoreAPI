using BookStoreAPI.DTOs.BookVariant;

namespace BookStoreAPI.DTOs.Book
{
    public class BookDto : BaseBookDto
    {
        public int Id { get; set; }
        public List<BookVariantDto> BookVariants { get; set; }
    }
}
