using ManagementCoffeShop.Core.Models.Entities;

namespace ManagementCoffeShop.Core.Interfaces
{
    public interface IUserService : IContextService
    {
        //  Employe Get(Guid Id);
        Employe GetUser(string userName);
        bool ValidateUser(string userName, string password);
    }
}
