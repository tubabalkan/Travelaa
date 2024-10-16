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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(TravelaContext context) : base(context)
        {
        }
    }
}
