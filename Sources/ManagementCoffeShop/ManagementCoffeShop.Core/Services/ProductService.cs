using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementCoffeShop.Core.Services
{
    public class ProductService : IProductService
    {
        private ICoffeShopContext _context;
        public ProductService(ICoffeShopContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            var listProducts = _context.Products.Select(c => c).ToList();
            return listProducts;
        }

        public List<Product> GetProcductsToType(ProductType productType)
        {
            var listProducts = _context.Products.Where(c => c.ProductType.Id == productType.Id).ToList();
            return listProducts;
        }
        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

        public Product GetProduct(Product product)
        {
            return _context.Products.Where(x => x.Id == product.Id).Include(x => x.ProductType).SingleOrDefault();
        }
        /// <inheritdoc />
        //public async Task<int> SaveChanges()
        //{
        //    return await _context.SaveChangesAsync();
        //}
    }
}
