﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.BusinessLayer.Abstract
{
    public interface IDestinationService:IGenericService<Destination>
    {
        int TDestinationCount();
        List<Destination> TLastEightDestination();
        List<Destination> TDestinationListCatgory();
    }
}
