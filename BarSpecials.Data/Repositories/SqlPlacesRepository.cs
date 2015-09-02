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
        public Place GetAll()
        {
            using (var db = new DatabaseEntities())
            {
                var places = db.Places;
                return AutoMapper.Mapper.Map<Place>(places);
            }
        }
    }
}
