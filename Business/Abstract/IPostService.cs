using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPostService
    {
        IDataResult<List<Post>> GetList();
       IDataResult<List<Post>> GetListByCategory(int categoryId);
        IDataResult<Post> GetById(int postId);
        IResult Add(Post post);
        IResult Update(Post post);
        IResult Delete(Post post);

        IResult TransactionOperation(Post post);
    }
}
