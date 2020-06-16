using NetCoreMVC.Core.DataAccess;
using NetCoreMVC.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreMVC.DataAccess.Abstract
{
    public interface ICategoryDal :IEntityRepository<Category>
    {

    }
}
