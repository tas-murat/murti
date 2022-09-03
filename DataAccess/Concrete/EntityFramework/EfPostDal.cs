using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPostDal : EfEntityRepositoryBase<Post, CSqlContext>, IPostDal
    {
        public List<Post> GetListByCategoryJoin(int categoryId)
        {
            using (var context = new CSqlContext())
            {
                var result = from p in context.Posts
                             join pc in context.PostCategories on p.Id equals pc.PostId
                             join c in context.Categories on pc.CategoryId equals c.Id
                             where pc.CategoryId == categoryId
                             select p;

                return result.ToList();
            }
        }
    }
}
