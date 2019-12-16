using ManagementCoffeShop.Core.Models.Entities;

namespace ManagementCoffeShop.Core.Interfaces
{
    public interface ICustomerService : IContextService
    {
        Customer GetCustomer(string namCustomer);
    }
}
