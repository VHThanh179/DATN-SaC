using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Services
{
    public class ProductSvc : IProductSvc
    {
        public Task<int> AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<int> EditProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
