using ManagementCoffeShop.Core.Models.Entities;

namespace ManagementCoffeShop.Core.Interfaces
{
    public interface IBillSellService : IContextService
    {
        bool DeleteBillSell(BillSell billSell);
        BillSell CreateBillSell(Employe employe, Customer customer = null, Tables table = null);
    }
}
