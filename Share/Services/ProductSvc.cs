using Microsoft.EntityFrameworkCore;
using Share.Common;
using Share.Interfaces;
using Share.Models;
using Share.Paging;
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

        public async Task<List<Product>> GetTrendingProductsAsync()
        {
            return await _context.Products.FromSqlRaw("BestSellingProducts").ToListAsync();
        }

        public async Task<Product> GetProductAsync(int id)
        {
            Product product = null;
            product = await _context.Products.FindAsync(id);
            return product;
        }
        
        // sync

        public List<Product> GetAllProduct()
        {
            List<Product> list = _context.Products.ToList();
            return list;
        }

        public Product GetProduct(int id)
        {
            Product product = _context.Products.Find(id);
            return product;
        }

        public int AddProduct(Product product)
        {
            int ret = 0;
            try
            {
                _context.Add(product);
                _context.SaveChanges();
                ret = product.ProductId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public int EditProduct(int id, Product product)
        {
            int ret = 0;
            try
            {
                Product _product = null;
                _product = _context.Products.Find(id);
                _product.ProductName = product.ProductName;
                _product.Price = product.Price;
                _product.Category = product.Category;
                _product.Image = product.Image;
                _product.Description = product.Description;
                _product.Status = _product.Status;

                _context.Update(product);
                _context.SaveChanges();
                ret = product.ProductId;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public async Task<PagedList<Product>> GetPagingProducts(PagingParameter productParameters)
        {
            var products = await _context.Products.ToListAsync();
            return PagedList<Product>
                .ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }
    }
}
