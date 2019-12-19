using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System.Collections.Generic;
using System.Linq;

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

        public List<string> GetAllName()
        {
            return _context.ProductTypes.Select(x => x.nameProductType).ToList();
        }

        public ProductType GetName(string name)
        {
            return _context.ProductTypes.Where(x => x.nameProductType == name).SingleOrDefault();
        }
        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

    }
}
