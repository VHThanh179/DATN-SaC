using Microsoft.EntityFrameworkCore;
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
        protected DataContext _context;
        public ProductSvc (DataContext context)
        {
            _context = context;
        }
        public async Task<int> AddProductAsync(Product product)
        {
            int ret = 0;
            try
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                ret = product.ProductId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> EditProductAsync(int id, Product product)
        {
            int ret = 0;
            try
            {
                //Product _product = null;
                //_product = _context.Products.Find(id);
                //_product.ProductName = product.ProductName;
                //_product.Price = product.Price;
                //_product.Category = product.Category;
                //_product.Image = product.Image;
                //_product.Description = product.Description;
                //_product.Status = _product.Status;

                _context.Update(product);
                await _context.SaveChangesAsync();
                ret = product.ProductId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            List<Product> list = await _context.Products.ToListAsync();
            return list;
        }

        public async Task<Product> GetProductAsync(int id)
        {
            Product product = null;
            product = await _context.Products.FindAsync(id);
            return product;
        }
    }
}
