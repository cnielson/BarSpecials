using BarSpecials.Data.Models;
using Specials.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpecials.Data.Repositories
{
    public class SqlPlacesRepository
    {
        public List<Place> GetAll()
        {
            //Todo: obviously move this shit
            AutoMapper.Mapper.CreateMap<Place, PlaceModel>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id.Value));

            AutoMapper.Mapper.CreateMap<PlaceModel, Place>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => new Identifier(src.Id)));

            using (var db = new DatabaseEntities())
            {
                var places = db.Places.ToList();
                return AutoMapper.Mapper.Map<List<Place>>(places);
            }
        }
    }
}
