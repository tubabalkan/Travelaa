﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.BusinessLayer.Abstract
{
    public interface IAdminService : IGenericService<Admin>
    {
        int TAdminCount();
    }
}
