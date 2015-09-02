namespace BarSpecials.Data.Migrations
{
    using BarSpecials.Data.Models;
    using Specials.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BarSpecials.Data.DatabaseEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BarSpecials.Data.DatabaseEntities context)
        {
            context.Places.AddOrUpdate(
              p => p.Name,
              new PlaceModel { Id = Identifier.New().Value, Name = "Dark Horse" }
              );
        }
    }
}   
