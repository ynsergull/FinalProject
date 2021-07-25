using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Product = Entities.Concrete.Product;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        

    }
}
