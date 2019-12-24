using ManagementCoffeShop.Core.Interfaces;
using ManagementCoffeShop.Core.Models.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementCoffeShop.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private ICoffeShopContext _context;

        public CustomerService(ICoffeShopContext context)
        {
            _context = context;
        }

        public Customer GetCustomer(string nameCustomer)
        {
            var customer = _context.Customers.AsNoTracking().FirstOrDefault(x => x.nameCustomer == nameCustomer);
            return customer;
        }
        /// <inheritdoc />
        public void RefreshContext(ICoffeShopContext context)
        {
            _context = context;
        }

    }
}
