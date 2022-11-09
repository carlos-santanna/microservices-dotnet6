using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.nome))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.preco))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.descricao))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.nome_categoria))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.url_imagem));
                config.CreateMap<Product, ProductVO>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.nome, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.descricao, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.preco, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.nome_categoria, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.url_imagem, opt => opt.MapFrom(src => src.ImageUrl));
                ;
            });
            return mappingConfig;
        }
    }
}
