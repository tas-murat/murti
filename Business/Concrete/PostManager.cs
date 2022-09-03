using Business.Abstract;
using Business.BusinessAspects.AutoFac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Exception;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class PostManager : IPostService
    {
        IPostDal _postDal;
        ICategoryService _categoryService;

        public PostManager(IPostDal  productDal, ICategoryService categoryService)
        {
            _postDal = productDal;
            _categoryService = categoryService;
        }


        public IDataResult<Post> GetById(int postId)
        {
            return new SuccessDataResult<Post>(_postDal.Get(p => p.Id == postId));
        }
       // [SecuredOperation("Post.List,Admin")]
        [PerformanceAspect(5)]
        public IDataResult<List<Post>> GetList()
        {
            //Thread.Sleep(5000);
            return new SuccessDataResult<List<Post>>(_postDal.GetList());
        }

        // [SecuredOperation("Product.List,Admin")]
        [CacheAspect(duration: 10)]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<Post>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Post>>(_postDal.GetListByCategoryJoin(categoryId));
        }

        public IResult Update(Post post)
        {
            _postDal.Update(post);
            return new SuccessResult(Messages.ProductUpdated);
        }

        [ValidationAspect(typeof(ProductValidator), Priority = 1)]
        [CacheRemoveAspect("IProductService.Get")]

        public IResult Add(Post post)
        {

            //IResult result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName), CheckIfCategoryIsEnabled());
            //if (result != null)
            //{
            //    return result;
            //}

            _postDal.Add(post);
            return new SuccessResult(Messages.ProductAdded);
        }

        //private IResult CheckIfProductNameExists(string productName)
        //{
        //    if (_productDal.Get(p => p.ProductName == productName) != null)
        //    {
        //        return new ErrorResult(Messages.ProductNameAlreadyExsists);
        //    }
        //    return new SuccessResult();
        //}
        private IResult CheckIfCategoryIsEnabled()
        {
            var result = _categoryService.GetList();
            if (result.Data.Count < 10)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExsists);
            }
            return new SuccessResult();
        }

        public IResult Delete(Post post)
        {
            _postDal.Delete(post);
            return new SuccessResult(Messages.ProductRemoved);
        }
        [TransactionScopeAspect]
        public IResult TransactionOperation(Post post)
        {
            _postDal.Update(post);
            _postDal.Add(post);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
