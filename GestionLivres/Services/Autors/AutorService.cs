using AutoMapper;
using GestionLivres.DTO.AutorDto;
using GestionLivres.DTO.CategorieDTO;
using GestionLivres.Entities;
using GestionLivres.Repository.Autors;
using System.Collections.Generic;

namespace GestionLivres.Services.Autors
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _repository;
        private readonly IMapper _mapper;

        public AutorService(IAutorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool AddAutorService(AddAutorDto dto)
        {
            var result = _mapper.Map<Autor>(dto);
            _repository.AddAutorRepository(result);
            return true;
        }

        public GetAutorDetailDto GetAutorDetailService(int Id)
        {
            var autor = _repository.GetAutorDetailRepository(Id);
            var result = _mapper.Map<GetAutorDetailDto>(autor);
            return result;
        }

        public IEnumerable<GetAutorDto> GetAutorService()
        {
            var list = _repository.GetAutorRepository();
            var result = _mapper.Map<IEnumerable<GetAutorDto>>(list);
            return result;

        }

        public GetAutorByIdDto GetAutorServiceById(int Id)
        {
            var autor = _repository.GetAutorRepositoryById(Id);
            var result = _mapper.Map<GetAutorByIdDto>(autor);
            return result;
        }
    }
}
