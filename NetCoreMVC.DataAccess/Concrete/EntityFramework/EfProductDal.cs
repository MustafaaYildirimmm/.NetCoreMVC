using NetCoreMVC.Core.DataAccess.EntityFramework;
using NetCoreMVC.DataAccess.Abstract;
using NetCoreMVC.DataAccess.Concrete.EntityFramework.Context;
using NetCoreMVC.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreMVC.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
