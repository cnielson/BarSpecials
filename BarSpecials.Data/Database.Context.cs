﻿using BarSpecials.Data.Models;
using MySql.Data.Entity;
using System.Data.Entity;

namespace BarSpecials.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DatabaseEntities : DbContext
    {
        public DatabaseEntities() : base("name=SpecialsConnection") { }
        public virtual DbSet<PlaceModel> Places { get; set; }
    }

    
}
