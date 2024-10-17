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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(TravelaContext context) : base(context)
        {
           
        }

        public int CategoryCount()
        {
            using var context = new TravelaContext();
            var value = context.Categories.Count();
            return value;
        }

        public int GetCategoryCount()
        {
            var context=new TravelaContext();
            var value = context.Categories.Count();
            return value;
        }
    }
}
