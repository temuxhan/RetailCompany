using AutoMapper;
using Store.Management.Service.Application.Dtos;
using Store.Management.Service.Application.UseCases.Queries;
using Store.Management.Service.Domain.Entities;

namespace Store.Management.Service.Application.Mappers
{
    internal class RetailStoreDatabaseMappingProfile : Profile
    {
        public RetailStoreDatabaseMappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<FindProductQueryDto, FindProductRequestQuery>().ReverseMap();
        }
    }
}
