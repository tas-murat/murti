﻿using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPostDal : IEntityRepository<Post>
    {
        List<Post> GetListByCategoryJoin(int categoryId);
    }
}
