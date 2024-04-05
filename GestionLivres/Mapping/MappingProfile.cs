using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.BookDto;
using GestionLivres.DTO.BookDTO;
using GestionLivres.DTO.CategorieDto;
using GestionLivres.DTO.CategorieDTO;
using GestionLivres.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestionLivres.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            CreateMap<Categorie, CategorieDetailDto>().ReverseMap();
            CreateMap<Categorie, AddCategorieDto>().ReverseMap();
            CreateMap<Categorie, GetCategorieDto>().ReverseMap();
            CreateMap<Book, AddBookDto>().ReverseMap();
            CreateMap<Book, GetBookDto>().ReverseMap();
            CreateMap<Book, GetBookByIdDto>().ReverseMap();
            CreateMap<Book, DeleteBookDto>().ReverseMap();

            CreateMap<Autor, AddAutorDto>().ReverseMap();
            CreateMap<Autor, GetAutorDto>().ReverseMap();
            CreateMap<GetAutorDto, Autor>().ReverseMap();

            CreateMap<Autor, GetAutorDetailDto>().ReverseMap();
            CreateMap<Autor, GetAutorByIdDto>().ReverseMap();

        }

    }
}
