﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.DataAccessLayer.Abstract
{
    public interface IDestinationDal:IGenericDal<Destination>
    {
        //List<Destination> GetListWithCategory();
        int DestinationCount();
        List<Destination> LastEightDestination();
        List<Destination> DestinationListCatgory();
    }
}
