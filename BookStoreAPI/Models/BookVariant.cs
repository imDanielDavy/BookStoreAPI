using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BookStoreAPI.Models
{
    public class BookVariant
    {
        [JsonIgnore]
        public Book? Book { get; set; }
        public int BookId { get; set; }
        public BookType? BookType { get; set; }
        public int BookTypeId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}