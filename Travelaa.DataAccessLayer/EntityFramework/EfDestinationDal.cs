using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelaa.DataAccessLayer.Abstract;
using Travelaa.DataAccessLayer.Context;
using Travelaa.DataAccessLayer.Repositories;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public EfDestinationDal(TravelaContext context) : base(context)
        {
        }

        public int DestinationCount()
        {
            using var context = new TravelaContext();
            var value = context.Destinations.Count();
            return value;
        }

        public List<Destination> LastEightDestination()
        {
            using var context = new TravelaContext();
            var value=context.Destinations.OrderByDescending(x=>x.DestinationId).Take(8).ToList();
            return value;
        }

        //public List<Destination> GetListWithCategory()
        //{
        //   // var context = new Context();
        //    return context.Destinations.Include(d => d.Category).ToList();
        //}
    }
}
