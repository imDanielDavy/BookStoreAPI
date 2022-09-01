using AutoMapper;
using BookStoreAPI.DTOs.Book;
using BookStoreAPI.DTOs.BookVariant;
using BookStoreAPI.Models;
using NuGet.Configuration;

namespace BookStoreAPI.AutoMapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Book, CreateBookDto>().ReverseMap();
            CreateMap<Book, GetBookDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, UpdateBookDto>().ReverseMap();
            CreateMap<BookVariant, BookVariantDto>().ReverseMap();
        }
    }
}
