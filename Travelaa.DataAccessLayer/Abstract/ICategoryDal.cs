﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        int GetCategoryCount();
        int CategoryCount();
    }
}
