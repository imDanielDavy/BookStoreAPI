using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BookStoreAPI.Models
{
    public class BookType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}