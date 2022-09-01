using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookStoreAPI.DTOs.Book
{
    public class GetBookDto : BaseBookDto
    {
        public int Id { get; set; }
    }

    
}
