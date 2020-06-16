using NetCoreMVC.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreMVC.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetByProduct(int productId);
    }
}
