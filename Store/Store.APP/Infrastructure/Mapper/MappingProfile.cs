using AutoMapper;
using Store.Entities.Dtos;
using Store.Entities.Models;

namespace Store.APP.Infrastructure.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductDtoForInsertion, Product>();
        CreateMap<ProductDtoForUpdate, Product>().ReverseMap();
    }
}