using Share.Common;
using Share.Models;
using Share.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Interfaces
{
    public interface IProductSvc
    {
        //async
        Task<List<Product>> GetAllProductAsync();
        Task<Product> GetProductAsync(int id);
        Task<int> AddProductAsync(Product product);
        Task<int> EditProductAsync(int id, Product product);
        Task<PagedList<Product>> GetPagingProducts(PagingParameter productParameters);


        //sync
        List<Product> GetAllProduct();
        Product GetProduct(int id);
        int AddProduct(Product product);
        int EditProduct(int id, Product product);
    }
}
