using CSharpCamp301.DataAccessLayer.Abstract;
using CSharpCamp301.DataAccessLayer.Context;
using CSharpCamp301.DataAccessLayer.Repositories;
using CSharpCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCamp301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProductsWithCategory()
        {
            var context = new CampContext();
            var values = context.Products.Select(x => new 
            {
                 CategoryId = x.CategoryId,
                 ProductName = x.ProductName,
                 ProductStock=  x.ProductStock,
                 ProductPrice = x.ProductPrice, 
                 ProductDescription = x.ProductDescription,
                 CategoryName = x.Category.CategoryName,

            }).ToList();

             return values.Cast<object>().ToList();
        }
    }
}
