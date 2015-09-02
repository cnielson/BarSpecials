using BarSpecials.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarSpecials.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new SqlPlacesRepository();
            var places = repo.GetAll();
            foreach(var place in places)
            {
                System.Console.WriteLine(place.Id + " - " + place.Name);
            }
        }
    }
}
