using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCoffeShop.Core.Interfaces
{
    public interface IContextService
    {
        void RefreshContext(ICoffeShopContext context);
        //Task<int> SaveChanges();
    }
}
