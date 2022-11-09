using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        void AddProduct(Product product);
        List<Product> GetAllRecentProducts();
        List<Product> GetAllPopularProducts();
        Product GetProductById(int id);
        List<Product> GetProductsBySubCategoryId(int id);
    }
}
