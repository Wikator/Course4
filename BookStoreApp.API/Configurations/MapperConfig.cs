﻿using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Author;
using BookStoreApp.API.Models.Book;

namespace BookStoreApp.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            
            CreateMap<BookReadOnlyDto, Book>();
            CreateMap<Book, BookReadOnlyDto>()
                .ForMember(q => q.AuthorName,
                    d => d.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"));
            
            CreateMap<Book, BookDetailsDto>()
                .ForMember(q => q.AuthorName,
                    d => d.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"));
            
            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
        }
    }
}
