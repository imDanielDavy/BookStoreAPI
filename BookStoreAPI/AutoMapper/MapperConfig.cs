using AutoMapper;
using BookStoreAPI.DTOs.Author;
using BookStoreAPI.DTOs.Book;
using BookStoreAPI.DTOs.BookVariant;
using BookStoreAPI.DTOs.Genre;
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

            CreateMap<Author, CreateAuthorDto>().ReverseMap();
            CreateMap<Author, GetAuthorDto>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();

            CreateMap<Genre, CreateGenreDto>().ReverseMap();
            CreateMap<Genre, GetGenreDto>().ReverseMap();
            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<Genre, UpdateGenreDto>().ReverseMap();
        }
    }
}
