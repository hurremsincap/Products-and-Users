﻿using System.Collections.Generic;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.Business.Abstract
{
    public interface IProductsService
    {
        List<Products> GetAll();
    }
}
