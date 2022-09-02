using BookStoreAPI.DTOs.Book;

namespace BookStoreAPI.DTOs.Author
{
    public class AuthorDto : BaseAuthorDto
    {
        public int Id { get; set; }
        public List<GetBookDto> Books { get; set; }
    }
}
