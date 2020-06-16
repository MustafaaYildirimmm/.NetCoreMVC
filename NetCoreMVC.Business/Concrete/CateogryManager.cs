using NetCoreMVC.Business.Abstract;
using NetCoreMVC.DataAccess.Abstract;
using NetCoreMVC.Entities.Concrete;
using System.Collections.Generic;

namespace NetCoreMVC.Business.Concrete
{
    public class CateogryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CateogryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetByProduct(int productId)
        {
            throw new System.NotImplementedException();
        }
    }
}
