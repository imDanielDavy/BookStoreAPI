using BookStoreAPI.DTOs.Book;

namespace BookStoreAPI.DTOs.Genre
{
    public class GenreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GetBookDto> Books { get; set; }
    }
}
