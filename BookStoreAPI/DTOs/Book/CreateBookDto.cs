using BookStoreAPI.DTOs.BookVariant;
using Microsoft.Build.Framework;

namespace BookStoreAPI.DTOs.Book
{
    public class CreateBookDto : BaseBookDto
    {
        public List<BookVariantDto> BookVariants { get; set; }
    }
}
