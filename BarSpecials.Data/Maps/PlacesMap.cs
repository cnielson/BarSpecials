using BarSpecials.Data.Models;
using Specials.Domain;

namespace BarSpecials.Data.Maps
{
    public class PlacesMap
    {
        public static void Configure()
        {
            AutoMapper.Mapper.CreateMap<Place, PlaceModel>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id.Value));

            AutoMapper.Mapper.CreateMap<PlaceModel, Place>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => new Identifier(src.Id)));
        }
    }
}
