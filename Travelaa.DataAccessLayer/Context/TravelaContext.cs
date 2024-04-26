using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.DataAccessLayer.Context
{
    public class TravelaContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-E4NV9FV;initial Catalog=TravelaDb; integrated Security=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Destination> Destinations { get; set; }
    }
}
