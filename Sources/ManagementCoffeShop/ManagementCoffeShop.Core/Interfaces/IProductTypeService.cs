using ManagementCoffeShop.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCoffeShop.Core.Interfaces
{
    public interface IProductTypeService : IContextService
    {
        List<ProductType> GetProductTypes();
    }
}
