using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCoffeShop.Core.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private ICoffeShopContext _context;

        public ProductTypeService(ICoffeShopContext context)
        {
            _context = context;
        }

        public List<ProductType> GetProductTypes()
        {
            var listProductType = _context.ProductTypes.Select(c => c).ToList();
            return listProductType;
        }
        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        //public async Task<int> SaveChanges()
        //{
        //    return await _context.SaveChangesAsync();
        //}
    }
}
