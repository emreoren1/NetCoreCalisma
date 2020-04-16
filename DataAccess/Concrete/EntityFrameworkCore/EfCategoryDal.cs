using Core.DataAccess.Concrete.EntityFrameworkCore;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCategoryDal : EfRepositoryBase<Category,NorthwindContext>, ICategoryDal
    {
        
    }
}
